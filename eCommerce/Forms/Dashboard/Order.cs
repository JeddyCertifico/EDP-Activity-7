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
using Excel = Microsoft.Office.Interop.Excel;

namespace eCommerce.Forms
{
    public partial class Order : Form
    {
        private DataTable dataTable;

        public Order()
        {
            InitializeComponent();

            Order_Load();
        }

        private void Order_Load()
        {
            string query =
                @"
                SELECT 
                    o.order_id, 
                    o.user_id, 
                    o.order_date, 
                    o.total_amount, 
                    s.status_name
                FROM
                    _order o
                JOIN
                    order_status s ON o.status_id = s.status_id";

            DbHelper dbHelper = new DbHelper();

            dataTable = dbHelper.Read(query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                orderGridView.Rows.Add(
                    dataRow["order_id"],
                    dataRow["user_id"],
                    dataRow["order_date"],
                    dataRow["total_amount"],
                    dataRow["status_name"]
                );
            }

            // set the total number of orders completed
            lblOrderCompleted.Text =
                ""
                + orderGridView
                    .Rows.Cast<DataGridViewRow>()
                    .Count(row => row.Cells[4].Value.ToString() == "Completed");

            // set the total number of orders Received
            lblOrderNew.Text =
                ""
                + orderGridView
                    .Rows.Cast<DataGridViewRow>()
                    .Count(row => row.Cells[4].Value.ToString() == "Received");

            // set the total number of orders cancelled
            lblOrderCancelled.Text =
                ""
                + orderGridView
                    .Rows.Cast<DataGridViewRow>()
                    .Count(row => row.Cells[4].Value.ToString() == "Cancelled");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = "OrderReport.xlsx";
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

            //transfer the signature to the last row of the
            Excel.Range signatureRange = worksheet.Range["A5:B6"];
            signatureRange.Copy();

            int rowIndex = 4;
            int rowCount = dataTable.Rows.Count;
            Excel.Range newSignatureRange = worksheet.Range[
                "A" + (rowCount + 6) + ":B" + (rowCount + 7)
            ];
            newSignatureRange.PasteSpecial();
            signatureRange.Delete(Excel.XlDeleteShiftDirection.xlShiftToLeft);

            foreach (DataRow row in dataTable.Rows)
            {
                worksheet.Cells[rowIndex, 1] = row["order_id"];
                worksheet.Cells[rowIndex, 2] = row["user_id"];
                worksheet.Cells[rowIndex, 3] = row["order_date"];
                worksheet.Cells[rowIndex, 4] = row["total_amount"];
                worksheet.Cells[rowIndex, 5] = row["status_name"];
                rowIndex++;
            }

            Excel.Worksheet chartSheet = templateWorkbook.Sheets[2];
            for (int i = 2; i <= 4; i++)
            {
                chartSheet.Cells[i, 3] =
                    "=COUNTIF('Order Report'!E4:E" + (rowCount + 3) + ", B" + i + ")";
            }

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
