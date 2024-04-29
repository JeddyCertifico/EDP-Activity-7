using System;
using System.Collections;
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
using System.Windows.Controls;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;
using Excel = Microsoft.Office.Interop.Excel;

namespace eCommerce.Forms
{
    public partial class Customers : Form
    {
        private DataTable dataTable;

        public Customers()
        {
            InitializeComponent();

            Customers_Load();
        }

        public void Customers_Load(
            string query = "SELECT * FROM _user WHERE user_type_id = 2",
            Dictionary<string, object> parameters = null
        )
        {
            DbHelper dbHelper = new DbHelper();
            dataTable = dbHelper.Read(query, parameters);

            foreach (var customer in dataTable.AsEnumerable())
            {
                customerGridView.Rows.Add(
                    customer.Field<int>("user_id"),
                    customer.Field<string>("username"),
                    customer.Field<string>("email"),
                    customer.Field<string>("address"),
                    customer.Field<Boolean>("status") == true ? "Active" : "Inactive"
                );
            }

            //set the total number of customers
            lblTotal.Text = "" + customerGridView.Rows.Count;

            //set the number of active customers
            lblActive.Text =
                ""
                + customerGridView
                    .Rows.Cast<DataGridViewRow>()
                    .Count(row => row.Cells[4].Value.ToString() == "Active");

            //set the number of inactive customers
            lblInactive.Text =
                ""
                + customerGridView
                    .Rows.Cast<DataGridViewRow>()
                    .Count(row => row.Cells[4].Value.ToString() == "Inactive");
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
                    "SELECT * FROM _user WHERE user_type_id = 2 AND (username LIKE @txtSearch OR email LIKE @txtSearch)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@txtSearch", "%" + txtSearch + "%" }
                };
                customerGridView.Rows.Clear();
                Customers_Load(query, parameters);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            customerGridView.Rows.Clear();
            Customers_Load();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            customerGridView.Rows.Clear();
            string query = "SELECT * FROM _user WHERE user_type_id = 2 AND status = 1";
            Customers_Load(query);
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            customerGridView.Rows.Clear();
            string query = "SELECT * FROM _user WHERE user_type_id = 2 AND status = 0";
            Customers_Load(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddAccount addAccount = new AddAccount())
            {
                if (addAccount.ShowDialog() == DialogResult.OK)
                {
                    Customers_Load();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = "CustomerReport.xlsx";
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

            //Insert the current date
            foreach (DataRow row in dataTable.Rows)
            {
                worksheet.Cells[rowIndex, 1] = row["user_id"];
                worksheet.Cells[rowIndex, 2] = row["username"];
                worksheet.Cells[rowIndex, 3] = row["email"];
                worksheet.Cells[rowIndex, 4] = row["address"];
                worksheet.Cells[rowIndex, 5] = (bool)row["status"] ? "Active" : "Inactive";
                rowIndex++;
            }

            Excel.Worksheet chartSheet = templateWorkbook.Sheets[2];
            chartSheet.Cells[2, 3] =
                "=COUNTIF('Cutomer Report'!E4:E" + (rowCount + 3) + ", \"Active\")";
            chartSheet.Cells[3, 3] =
                "=COUNTIF('Cutomer Report'!E4:E" + (rowCount + 3) + ", \"Inactive\")";

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

        static void UpdateCell(Excel.Worksheet worksheet, string cellAddress, object value)
        {
            Excel.Range cell = worksheet.Range[cellAddress];
            cell.Value = value;
            Marshal.ReleaseComObject(cell);
        }
    }
}
