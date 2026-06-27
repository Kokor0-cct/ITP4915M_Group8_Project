using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ITP4915M_Group8_Project.Login;
using Microsoft.VisualBasic;

namespace ITP4915M_Group8_Project.Customer.CustomerService
{
    public partial class After_sales_Request : Form
    {
        public After_sales_Request(string orderId, string furnitureId)
        {
            InitializeComponent();
            txtoid.Text = orderId;
            txtfID.Text = furnitureId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(rid,4)AS UNSIGNED)) FROM returnreplacerequest;";
            int maxRid = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) + 1;
            string newRId = $"RPR{maxRid:D8}";




            string oid = txtoid.Text.ToString();
            string fid = txtfID.Text.ToString();
            string rType = cmbtype.Text.ToString();
            string rDESC = txtReason.Text.ToString();
            string cid = UserSession.CustomerId.ToString();
            string insertSql = @"INSERT INTO returnreplacerequest(rid,oid,fid,rCreateDate,cid,rType,rDESC )
                                 VALUES(@rid,@oid,@fid,@rCreateDate,@cid,@rType,@rDESC)";
            MySqlParameter[] para = {
                        new MySqlParameter("@rid",newRId),
                        new MySqlParameter("@oid",oid),
                        new MySqlParameter("@fid",fid),
                        new MySqlParameter("@rCreateDate",DateTime.Now),
                        new MySqlParameter("@cid",UserSession.CustomerId),
                        new MySqlParameter("@rType",cmbtype.Text),
                        new MySqlParameter("@rDESC",txtReason.Text),

                    };
            DbConnect.Execute(insertSql, para);

            string updateStockSql = "UPDATE orders SET statusType = @type WHERE orderID = @oid;";
            MySqlParameter[] UpdateStock = {
                        new MySqlParameter("@type", "ST11"),
                        new MySqlParameter("@oid",oid)
                    };
            DbConnect.Execute(updateStockSql, UpdateStock);
            
            MsgBoxResult result = Interaction.MsgBox("Request submitted successfully!", MsgBoxStyle.OkOnly, "Success");
            this.Close();

        }
    }
}
