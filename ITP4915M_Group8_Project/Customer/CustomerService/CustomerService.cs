using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using ITP4915M_Group8_Project.Staff.Production;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Customer.CustomerService
{
    public partial class CustomerService : Form
    {
        public CustomerService()
        {
            InitializeComponent();

            LoadChatHistory();

        }

        private void lblTaital_Click(object sender, EventArgs e)
        {

        }

        private void linlblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void LoadChatHistory()
        {
            string sqls = @"SELECT * FROM support_messages WHERE cid = @cid ORDER BY created_at ASC;";
            MySqlParameter[] paras = {
                new MySqlParameter("@cid", UserSession.CustomerId)
            };
            DataTable dt = DbConnect.Query(sqls, paras);


            string name = UserSession.CustomerName;

            flpChatPanel.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string senderType = row["sender_type"].ToString();
                string id;
                bool isCustomer = senderType == "customer";
                if (senderType == "customer")
                {
                     id = name + "("+row["cid"].ToString()+")";
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string content = txtSendMsg.Text.Trim();
            if (content == "")
            {
                MessageBox.Show("Please enter a message.");
                return;
            }
            string insertSql = @"INSERT INTO support_messages (cid, sender_type, message) VALUES (@cid, 'customer', @message);";
            MySqlParameter[] para = {
                new MySqlParameter("@cid", UserSession.CustomerId),
                new MySqlParameter("@message", content)
            };
            DbConnect.Execute(insertSql, para);
            LoadChatHistory();
            txtSendMsg.Clear();
        }
    }
}
