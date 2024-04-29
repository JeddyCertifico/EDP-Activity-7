using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace eCommerce.Forms
{
    public partial class Product : Form
    {
        private DataTable dataTable;

        public Product()
        {
            InitializeComponent();

            Product_Load();
        }

        public void Product_Load(
            string query =
                @"SELECT 
                    p.product_id, 
                    p.name, 
                    p.description, 
                    p.price, 
                    p.quantity_in_stock, 
                    c.category_name 
                FROM 
                    product p
                JOIN 
                    category c ON p.category_id = c.category_id",
            Dictionary<string, object> parameters = null
        )
        {
            DbHelper dbHelper = new DbHelper();
            dataTable = dbHelper.Read(query, parameters);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                productGridView.Rows.Add(
                    dataRow["product_id"],
                    dataRow["name"],
                    dataRow["description"],
                    dataRow["price"],
                    dataRow["quantity_in_stock"],
                    dataRow["category_name"]
                );
                //set the total number of products
                lblTotal.Text = "" + productGridView.Rows.Count;

                //set the number of stock products
                lblInStock.Text =
                    ""
                    + productGridView
                        .Rows.Cast<DataGridViewRow>()
                        .Count(row => row.Cells[4].Value.ToString() != "0");

                //set the number of Out of Stock products
                lblOutStock.Text =
                    ""
                    + productGridView
                        .Rows.Cast<DataGridViewRow>()
                        .Count(row => row.Cells[4].Value.ToString() == "0");
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            productGridView.Rows.Clear();
            Product_Load();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            productGridView.Rows.Clear();
            Product_Load(
                @"SELECT 
                    p.product_id, 
                    p.name, 
                    p.description, 
                    p.price, 
                    p.quantity_in_stock, 
                    c.category_name 
                FROM 
                    product p
                JOIN 
                    category c ON p.category_id = c.category_id
                WHERE 
                    p.quantity_in_stock != 0"
            );
        }

        private void btnOutStock_Click(object sender, EventArgs e)
        {
            productGridView.Rows.Clear();
            Product_Load(
                @"SELECT 
                    p.product_id, 
                    p.name, 
                    p.description, 
                    p.price, 
                    p.quantity_in_stock, 
                    c.category_name 
                FROM 
                    product p
                JOIN 
                    category c ON p.category_id = c.category_id
                WHERE 
                    p.quantity_in_stock = 0"
            );
        }

        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            string txtSearch = customerSearchBar.Text;
            if (txtSearch == "Search")
            {
                txtSearch = "";
            }

            if (!string.IsNullOrEmpty(txtSearch))
            {
                string query =
                    @"SELECT 
                        p.product_id, 
                        p.name, 
                        p.description, 
                        p.price, 
                        p.quantity_in_stock, 
                        c.category_name
                    FROM
                        product p
                    JOIN
                        category c ON p.category_id = c.category_id
                    WHERE
                        p.name LIKE @txtSearch
                    OR 
                        p.description LIKE @txtSearch";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@txtSearch", "%" + txtSearch + "%" }
                };

                productGridView.Rows.Clear();
                Product_Load(query, parameters);
            }
        }

        private void customerSearchBar_Enter(object sender, EventArgs e)
        {
            if (customerSearchBar.Text == "Search")
            {
                customerSearchBar.Text = "";
                customerSearchBar.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void customerSearchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerSearchBar.Text))
            {
                customerSearchBar.Text = "Search";
                customerSearchBar.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = "ProductReport.xlsx";
            Excel.Application excelApp = new Excel.Application();
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream templateStream = assembly.GetManifestResourceStream(
                "eCommerce.ReportTemplates." + fileName
            );

            if (templateStream == null)
            {
                MessageBox.Show(
                    "Template file not found",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string tempFilePath = Path.GetTempFileName();
            using (FileStream tempFileStream = File.Create(tempFilePath))
            {
                templateStream.CopyTo(tempFileStream);
            }

            Excel.Workbook templateWorkbook = excelApp.Workbooks.Open(tempFilePath);

            Excel.Worksheet worksheet = templateWorkbook.Sheets[1];

            Excel.Range signatureRange = worksheet.Range["A5:B6"];
            signatureRange.Copy();

            //transfer the signature to the last row of the data
            int rowIndex = 4;
            int rowCount = dataTable.Rows.Count;
            Excel.Range newSignatureRange = worksheet.Range[
                "A" + (rowCount + 6) + ":B" + (rowCount + 7)
            ];
            newSignatureRange.PasteSpecial();
            signatureRange.Delete(Excel.XlDeleteShiftDirection.xlShiftToLeft);

            foreach (DataRow row in dataTable.Rows)
            {
                worksheet.Cells[rowIndex, 1] = row["product_id"];
                worksheet.Cells[rowIndex, 2] = row["name"];
                worksheet.Cells[rowIndex, 3] = row["description"];
                worksheet.Cells[rowIndex, 4] = row["price"];
                worksheet.Cells[rowIndex, 5] = row["quantity_in_stock"];
                worksheet.Cells[rowIndex, 6] = row["category_name"];
                rowIndex++;
            }

            //for sheet 2, chart for category_name
            /*
             * Electronics
             * Home and Garden
             * Fashion
             * Toys and Games
             * Sports and Outdoors
             * Books
             * Health and Beauty
             * Automotive
             * Kitchen and Dining
             * Pet Supplies
             */

            Excel.Worksheet chartSheet = templateWorkbook.Sheets[2];
            // Category chart
            for (int i = 2; i <= 11; i++)
            {
                chartSheet.Cells[i, 3] =
                    "=COUNTIF('Cutomer Report'!F4:F" + (rowCount + 3) + ", B" + i + ")";
            }

            //inventory chart
            chartSheet.Cells[14, 3] =
                "=COUNTIF('Cutomer Report'!E4:E" + (rowCount + 3) + ", \"<>0\")";
            chartSheet.Cells[15, 3] = "=COUNTIF('Cutomer Report'!E4:E" + (rowCount + 3) + ", \0\")";

            // Save the updated workbook with a new filename
            string downloadPath =
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";
            templateWorkbook.SaveAs(downloadPath + fileName);

            // Close the workbook
            templateWorkbook.Close();

            // Quit Excel application
            excelApp.Quit();

            // Release COM objects
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(templateWorkbook);
            Marshal.ReleaseComObject(excelApp);

            MessageBox.Show(
                "Exported successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
