using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using OxyPlot.WindowsForms;
using ScottPlot.Plottables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Staff.Sales
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();

            // 设计模式不执行初始化
            if (!DesignMode)
            {
                // 默认时间：今天 / 30天前
                dateTimePicker1.Value = DateTime.Now.AddDays(-30);
                dateTimePicker2.Value = DateTime.Now;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value.Date;
            DateTime end = dateTimePicker2.Value.Date.AddDays(1);

            // 清空两张图表旧数据
            plotBar.Plot.Clear();
            plotPie.Plot.Clear();

            // 统计SQL：按商品统计销量、总销售额
            string sql = @"
                SELECT f.fName,
                       SUM(od.quantity) AS totalQty,
                       SUM(od.quantity * od.unit_price) AS totalAmount
                FROM order_detail od
                LEFT JOIN furniture f ON od.fid = f.fid
                WHERE od.order_time >= @start AND od.order_time < @end
                GROUP BY od.fid, f.fName
                ORDER BY totalAmount DESC;
            ";

            MySqlParameter[] para = {
                new MySqlParameter("@start", start),
                new MySqlParameter("@end", end)
            };

            DataTable dt;
            try
            {
                dt = DbConnect.Query(sql, para);
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询报表失败：" + ex.Message);
                return;
            }

            // 无数据判断
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("所选时间段没有销售数据");
                return;
            }

            // 存放图表数据
            List<string> productNames = new List<string>();
            List<double> salesAmount = new List<double>();
            List<PieSlice> pieSliceList = new List<PieSlice>();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["fName"].ToString();
                double amount = Convert.ToDouble(row["totalAmount"]);
                double qty = Convert.ToDouble(row["totalQty"]);

                productNames.Add(name);
                salesAmount.Add(amount);
                pieSliceList.Add(new PieSlice(qty)
                {
                    Label = name
                });
            }

            // ========== 1. 柱状图：各商品销售额 ==========
            plotBar.Plot.Add.Bars(salesAmount.ToArray());
            // X轴商品名称
            plotBar.Plot.Axes.Bottom.TickLabels.TextLabels = productNames.ToArray();
            plotBar.Plot.Title("商品销售额统计");
            plotBar.Plot.YLabel("销售金额");
            plotBar.Refresh();

            // ========== 2. 饼图：销量占比 ==========
            Pie pie = plotPie.Plot.Add.Pie(pieSliceList.ToArray());
            pie.ShowPercentages = true;          // 显示百分比
            pie.PercentFormat = "0.00%";         // 百分比格式
            pie.SliceLabelDistance = 0.6;        // 文字距离饼图边缘
            pie.ExplodeFraction = 0.04;          // 每块轻微分开更好看
            plotPie.Plot.Title("商品销量占比");
            plotPie.Refresh();
        }
    }
}
