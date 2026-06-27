using ITP4915M_Group8_Project.Customer.CustomerService;
using ITP4915M_Group8_Project.Customer.CustomerService;
using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Staff.Sales
{
    public partial class CustomerServiceSTaff : Form
    {
        public static string currentCid { get; set; }
        public CustomerServiceSTaff()
        {
            InitializeComponent();
            LoadCustomer();

        }

        private void lblTaital_Click(object sender, EventArgs e)
        {

        }

        private void linlblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        public void LoadChatHistory(string cid)
        {
            string sqls = @"SELECT * FROM support_messages WHERE cid = @cid ORDER BY created_at ASC;";
            MySqlParameter[] paras = {
                new MySqlParameter("@cid", cid)
            };
            DataTable dt = DbConnect.Query(sqls, paras);

            string sqlc = @"SELECT * FROM customers WHERE cUserID = @cid;";
            MySqlParameter[] parac = {
                new MySqlParameter("@cid", cid)
            };
            DataTable dtc = DbConnect.Query(sqlc, parac);


            if (dtc.Rows.Count == 0)
            {
                MessageBox.Show("Can not found this Cutomer Info！");
                return;
            }


            string name = dtc.Rows[0]["cName"].ToString();

            flpChatPanel.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string senderType = row["sender_type"].ToString();
                string id;
                bool isCustomer = senderType == "customer";
                if (senderType == "customer")
                {
                    id = name + "(" + row["cid"].ToString() + ")";
                }
                else
                {
                    id = row["sid"].ToString();
                }


                string message = row["message"].ToString();
                string createdAt = row["created_at"].ToString();

                chatboxCC chatBox = new chatboxCC(senderType, id, message, createdAt);
                if (isCustomer)
                {
                    chatBox.Margin = new Padding(170, 6, 5, 6);
                }
                else
                {
                    chatBox.Margin = new Padding(2, 6, 120, 6);
                }


                flpChatPanel.Controls.Add(chatBox);

            }
        }








        private void LoadCustomer()
        {
            flpCustomerContactList.Controls.Clear();
            string sql = @"SELECT * FROM customers;";
            DataTable dt = DbConnect.Query(sql);



            foreach (DataRow row in dt.Rows)
            {

                CustomerContacts Loadcustomers = new CustomerContacts(row["cUserID"].ToString());

                Loadcustomers.SearchCID += (sender, cid) =>
                {
                    currentCid = cid;
                    LoadChatHistory(cid);
                };
                flpCustomerContactList.Controls.Add(Loadcustomers);

            }

        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            string content = txtSendMsg.Text.Trim();
            if (content == "")
            {
                MessageBox.Show("Please enter a message.");
                return;
            }
            if (string.IsNullOrEmpty(currentCid))
            {
                MessageBox.Show("Please select a customer first!");
                return;
            }
            string insertSql = @"INSERT INTO support_messages (cid,sid, sender_type, message) VALUES (@cid, @sid, 'staff', @message);";
            MySqlParameter[] para = {
                new MySqlParameter("@cid", currentCid),
                new MySqlParameter("@sid", UserSession.StaffId),
                new MySqlParameter("@message", content)
            };
            DbConnect.Execute(insertSql, para);
            LoadChatHistory(currentCid);
            txtSendMsg.Clear();
        }

        private void linlblBack_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
