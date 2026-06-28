using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using OxyPlot.WindowsForms;
using ScottPlot;
using ScottPlot.Panels;
using ScottPlot.Plottables;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ITP4915M_Group8_Project.Staff.Sales
{
    public partial class SalesReport : Form
    {
        private readonly FormsPlot plotBar = new FormsPlot();
        private readonly FormsPlot plotPie = new FormsPlot();

        public SalesReport()
        {
            InitializeComponent();
            LoadDataToGridView();

            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "yyyy-MM";
            dtpMonth.ShowUpDown = true;

            dtpMonth.Value = DateTime.Now;


          
            dateStart.Value = DateTime.Now.AddDays(-30);
            dateEnd.Value = DateTime.Now;


        }



        private void LoadDataToGridView()
        {

            string sql = @"
                     WITH AllOrderData AS (
                    SELECT
                        f.fName AS ProductName,
                        od.Quantity,
                        od.oAmount AS Amount,
                        od.oCreateDate AS order_time
                    FROM orders od
                    LEFT JOIN furniture f ON od.fID = f.fID

                    UNION ALL

                    SELECT
                        cf.cfName AS ProductName,
                        cod.Quantity,
                        cod.coAmount AS Amount,
                        cod.coCreateDate AS order_time
                    FROM customorders cod
                    LEFT JOIN customfurniture cf ON cod.cfID = cf.cfID
                )


                SELECT
                    ProductName,
                    SUM(Quantity) AS TotalQuantity,
                    SUM(Amount) AS TotalSales
                FROM AllOrderData
                GROUP BY ProductName
                ORDER BY TotalSales DESC;
            ";


            DataTable table;
            try
            {
                table = DbConnect.Query(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report loading failed ：" + ex.Message);
                dvgSalesReport.DataSource = null;
                return;
            }

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Report loading failed ：No sales records found for the selected time period (both regular and custom orders are empty)");
                dvgSalesReport.DataSource = null;
                return;
            }
            string Amount = table.Compute("SUM(TotalSales)", "").ToString();
            txtAmount.Text = Amount;

            dvgSalesReport.DataSource = table;

        }


        private void dvgSalesReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgSalesReport.CurrentRow.Selected = true;
            if (e.RowIndex < 0)
                return;
        }

        private void btnGenerateDaay_Click(object sender, EventArgs e)
        {


            DateTime startDate = dateStart.Value.Date;
            DateTime endDate = dateEnd.Value.Date.AddDays(1);

            string sql = @"
                     WITH AllOrderData AS (
                    SELECT
                        f.fName AS ProductName,
                        od.Quantity,
                        od.oAmount AS Amount,
                        od.oCreateDate AS order_time
                    FROM orders od
                    LEFT JOIN furniture f ON od.fID = f.fID

                    UNION ALL

                    SELECT
                        cf.cfName AS ProductName,
                        cod.Quantity,
                        cod.coAmount AS Amount,
                        cod.coCreateDate AS order_time
                    FROM customorders cod
                    LEFT JOIN customfurniture cf ON cod.cfID = cf.cfID
                )


                SELECT
                    ProductName,
                    SUM(Quantity) AS TotalQuantity,
                    SUM(Amount) AS TotalSales
                FROM AllOrderData
                WHERE order_time >= @start AND order_time < @end
                GROUP BY ProductName
                ORDER BY TotalSales DESC;
            ";

            MySqlParameter[] paras = {
                new MySqlParameter("@start", startDate),
                new MySqlParameter("@end", endDate)
            };

            DataTable table;
            try
            {
                table = DbConnect.Query(sql, paras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report loading failed ：" + ex.Message);
                dvgSalesReport.DataSource = null;
                return;
            }

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Report loading failed ：No sales records found for the selected time period (both regular and custom orders are empty)");
                dvgSalesReport.DataSource = null;
                return;
            }

            string Amount = table.Compute("SUM(TotalSales)", "").ToString();



            dvgSalesReport.DataSource = table;
            txtAmount.Text = Amount;
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnGenerateMon_Click(object sender, EventArgs e)
        {
            int year = dtpMonth.Value.Year;
            int month = dtpMonth.Value.Month;

            string sql = @"
            WITH AllOrderData AS (
                SELECT
                    f.fName AS ProductName,
                    od.Quantity,
                    od.oAmount AS Amount,
                    od.oCreateDate AS order_time
                FROM orders od
                LEFT JOIN furniture f ON od.fID = f.fID

                UNION ALL

                SELECT
                    cf.cfName AS ProductName,
                    cod.Quantity,
                    cod.coAmount AS Amount,
                    cod.coCreateDate AS order_time
                FROM customorders cod
                LEFT JOIN customfurniture cf ON cod.cfID = cf.cfID
            )
            SELECT
                ProductName,
                SUM(Quantity) AS TotalQuantity,
                SUM(Amount) AS TotalSales
            FROM AllOrderData
            WHERE YEAR(order_time) = @year AND MONTH(order_time) = @month
            GROUP BY ProductName
            ORDER BY TotalSales DESC;
            ";

            MySqlParameter[] paras = {
        new MySqlParameter("@year", year),
        new MySqlParameter("@month", month)
    };

            DataTable table;
            try
            {
                table = DbConnect.Query(sql, paras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report loading failed：" + ex.Message);
                dvgSalesReport.DataSource = null;
                return;
            }

            if (table.Rows.Count == 0)
            {
                MessageBox.Show($"{year}-{month:D2} Report loading failed ：No sales records found for the selected time period (both regular and custom orders are empty)");
                dvgSalesReport.DataSource = null;
                return;
            }

            dvgSalesReport.DataSource = table;
            string Amount = table.Compute("SUM(TotalSales)", "").ToString();
            txtAmount.Text = Amount;

        }
    }
}
