using ITP4915M_Group8_Project.Login;
using ITP4915M_Group8_Project.Staff.Inventory;
using MySqlConnector;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4915M_Group8_Project.Staff.Sales
{

    public partial class Replace_Request_List : Form
    {
        private string currentRid = "0";
        private string currentOid = "0";
        private string currentFid = "0";
        private string currentStatus = "0";
        private bool isOrder =false;


        public Replace_Request_List()
        {
            InitializeComponent();
            LoadDataToGridView();

        }
        private void LoadDataToGridView()
        {

            string sql = "SELECT * FROM returnreplacerequest";


            DataTable dt = DbConnect.Query(sql);


            dgvfInventoryControl.DataSource = dt;
        }

        private void dgvfInventoryControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvfInventoryControl.Rows[e.RowIndex];

                if (row.IsNewRow)
                {
                    // 清空输入框
                    ClearTextBox();
                    currentRid = "0";
                    return;
                }
                txtReason.Text = row.Cells["rDESC"].Value.ToString();
                txtType.Text = row.Cells["rType"].Value.ToString();

                currentRid = Convert.ToString(row.Cells["rid"].Value);
                currentOid = Convert.ToString(row.Cells["oid"].Value);
                currentFid = Convert.ToString(row.Cells["fid"].Value);
                currentStatus = Convert.ToString(row.Cells["statusType"].Value);


                string getoid = currentOid?.Trim() ?? "";

                if (getoid.StartsWith("CO", StringComparison.OrdinalIgnoreCase))
                {
                    isOrder = false;
                }
                else if (getoid.StartsWith("O", StringComparison.OrdinalIgnoreCase))
                {
                    isOrder = true; 
                }
                else
                {
                    // 未知前缀默认
                    isOrder = false;
                }



            }


        }
        public void ClearTextBox()
        {
            txtReason.Text = "";
            txtType.Text = "";
        }

        private void btnfSearch_Click(object sender, EventArgs e)
        {

            string keyword = txtfSearch.Text.Trim();

            string sql = "SELECT * FROM returnreplacerequest WHERE rid LIKE @keyword";

            MySqlParameter[] parameters = { new MySqlParameter("@keyword", "%" + keyword + "%") };


            DataTable dt = DbConnect.Query(sql, parameters);

            dgvfInventoryControl.DataSource = dt;
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRejected_Click(object sender, EventArgs e)
        {
            if (currentRid == "0")
            {
                MessageBox.Show("Please select a row ！");
                return;
            }
            else if (currentStatus != "Pending")
            {
                MessageBox.Show("This request has already been processed.");
                return;
            }
            else if (txtStaffNote.Text == "")
            {
                MessageBox.Show("Please enter a reason for rejection.");
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                string sql = "";
                if (isOrder)
                {
                     sql = "UPDATE orders SET statusType = @type ,StaffNote = @note WHERE orderID = @oid AND fID = @fID;";
                    MySqlParameter[] updateorder = {
                        new MySqlParameter("@type", "ST10"),
                        new MySqlParameter("@oid",currentOid),
                        new MySqlParameter("@fID",currentFid),
                        new MySqlParameter("@note", txtStaffNote.Text)
                    };
                    DbConnect.Execute(sql, updateorder);
                }
                else
                {
                     sql = "UPDATE customorders SET statusType = @type ,StaffNote = @note WHERE corderID = @oid AND cfID = @fID;";
                    MySqlParameter[] updateorder = {
                        new MySqlParameter("@type", "ST10"),
                        new MySqlParameter("@oid",currentOid),
                        new MySqlParameter("@fID",currentFid),
                        new MySqlParameter("@note", txtStaffNote.Text)
                    };
                    DbConnect.Execute(sql, updateorder);
                }
               

                 string sq2l = "UPDATE returnreplacerequest SET statusType = @type WHERE rid  = @rid AND fid = @fid;";
                MySqlParameter[] updaterequest = {
                        new MySqlParameter("@type", "Rejected"),
                        new MySqlParameter("@rid",currentRid),
                        new MySqlParameter("@fid",currentFid)
                    };
                DbConnect.Execute(sq2l, updaterequest);
            }



        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (currentRid == "0")
            {
                MessageBox.Show("Please select a row ！");
                return;
            }
            else if (currentStatus != "Pending")
            {
                MessageBox.Show("This request has already been processed.");
                return;
            }
            else if (txtStaffNote.Text == "")
            {
                MessageBox.Show("Please enter a note for acceptance.");
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to accept this request?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }


                string sql = "";
                if (txtType.Text == "Refund")
                {
                    if (isOrder)
                    {
                        sql = @"SELECT oAmount FROM orders WHERE orderID = @orderID AND fID = @fID";
                        MySqlParameter[] parameters = { new MySqlParameter("@orderID", currentOid), new MySqlParameter("@fID", currentFid) };
                        DataTable dt = DbConnect.Query(sql, parameters);

                        int oAmount = Convert.ToInt32(dt.Rows[0]["oAmount"]);


                        sql = "UPDATE orders SET statusType = @type ， StaffNote = @note WHERE orderID = @oid AND fID = @fID;";
                        MySqlParameter[] updateorder11 = {
                            new MySqlParameter("@type", "ST12"),
                            new MySqlParameter("@note", "Refund received"),
                            new MySqlParameter("@oid",currentOid),
                            new MySqlParameter("@fID",currentFid)
                        };
                        DbConnect.Execute(sql, updateorder11);


                        sql = "UPDATE customers SET cBudget = cBudget + @oAmount WHERE cUserID  = @cid;";
                        MySqlParameter[] customer = {
                            new MySqlParameter("@oAmount", oAmount),
                            new MySqlParameter("@cid", UserSession.CustomerId)
                        };
                        DbConnect.Execute(sql, customer);
                    }
                    else
                    {
                        sql = @"SELECT coAmount FROM customorders WHERE corderID = @orderID AND cfID = @fID";
                        MySqlParameter[] parameters = { new MySqlParameter("@orderID", currentOid), new MySqlParameter("@fID", currentFid) };
                        DataTable dt = DbConnect.Query(sql, parameters);

                        int oAmount = Convert.ToInt32(dt.Rows[0]["oAmount"]);


                        sql = "UPDATE coAmount SET statusType = @type ， StaffNote = @note WHERE corderID = @oid AND cfID = @fID;";
                        MySqlParameter[] updateorder11 = {
                            new MySqlParameter("@type", "ST12"),
                            new MySqlParameter("@note", "Refund received"),
                            new MySqlParameter("@oid",currentOid),
                            new MySqlParameter("@fID",currentFid)
                        };
                        DbConnect.Execute(sql, updateorder11);


                        sql = "UPDATE customers SET cBudget = cBudget + @oAmount WHERE cUserID  = @cid;";
                        MySqlParameter[] customer = {
                            new MySqlParameter("@oAmount", oAmount),
                            new MySqlParameter("@cid", UserSession.CustomerId)
                        };
                        DbConnect.Execute(sql, customer);
                    }

                }

                if (txtType.Text == "Replace")
                {


                    if (isOrder)
                    {
                        txtStaffNote.Text += "    \n This is From Order : " + currentOid;
                        string sqlMaxId = "SELECT MAX(CAST(SUBSTRING(orderID,2)AS UNSIGNED)) FROM orders;";
                        int maxOrderid = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlMaxId)) + 1;
                        string newOrderId = $"O{maxOrderid:D7}";

                        sql = @"SELECT * FROM orders WHERE orderID = @orderID AND fID = @fID";
                        MySqlParameter[] parameters = { new MySqlParameter("@orderID", currentOid), new MySqlParameter("@fID", currentFid) };
                        DataTable dt = DbConnect.Query(sql, parameters);

                        string deliverydate = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");

                        string fID = dt.Rows[0]["fID"].ToString();
                        int qty = Convert.ToInt32(dt.Rows[0]["Quantity"]);
                        string cID = dt.Rows[0]["cUserID"].ToString();
                        int oAmount = Convert.ToInt32(dt.Rows[0]["oAmount"]);
                        string address = dt.Rows[0]["odeliveryaddress"].ToString();
                        string shipType = dt.Rows[0]["shippingType"].ToString();

                        sql = @"SELECT fQuantity FROM furniture WHERE fID = @fID";
                        MySqlParameter[] fid = { new MySqlParameter("@fID", fID) };
                        DataTable rs = DbConnect.Query(sql, parameters);
                        int fQuantity = Convert.ToInt32(rs.Rows[0]["fQuantity"]);
                        if (fQuantity < qty)
                        {
                            MessageBox.Show("Not enough stock to replace the item.");
                            return;
                        }

                        sql = "UPDATE furniture SET fQuantity = fQuantity-@fQuantity WHERE fID = @fID;";
                        MySqlParameter[] furnitureStock = {
                            new MySqlParameter("@fQuantity", qty),
                            new MySqlParameter("@fID", fID),
                        };
                        DbConnect.Execute(sql, furnitureStock);


                        string insertSql = @"
                        INSERT INTO orders(orderID,fID,Quantity,cUserID,oAmount,odeliverydate,odeliveryaddress,shippingType ,statusType ,StaffNote)
                        VALUES(@oid,@fid,@qty,@uid,@subtotal,@date,@addr,@ship,@stat,@note)";


                        MySqlParameter[] para = {
                        new MySqlParameter("@oid",newOrderId),
                        new MySqlParameter("@fid",fID),
                        new MySqlParameter("@qty",qty),
                        new MySqlParameter("@uid",cID),
                        new MySqlParameter("@subtotal",0),
                        new MySqlParameter("@date",deliverydate),
                        new MySqlParameter("@addr",address),
                        new MySqlParameter("@ship",shipType),
                        new MySqlParameter("@stat","ST01"),
                        new MySqlParameter("@note",txtStaffNote.Text)
                        };
                        DbConnect.Execute(insertSql, para);



                    

                        sql = "UPDATE returnreplacerequest SET statusType = @type WHERE rid  = @rid AND fid = @fid;";
                        MySqlParameter[] updaterequest = {
                                new MySqlParameter("@type", "Accept"),
                                new MySqlParameter("@rid",currentRid),
                                new MySqlParameter("@fid",currentFid)
                            };
                        DbConnect.Execute(sql, updaterequest);

                        sql = "UPDATE orders SET statusType = @type ， StaffNote = @note WHERE orderID = @oid;";
                        MySqlParameter[] updateorder = {
                                new MySqlParameter("@type", "ST13"),
                                new MySqlParameter("@oid",currentOid),
                                new MySqlParameter("@note", "Replacement products will take 7 days to arrive after your application is approved. Please see your new order for details.")
                            };
                        DbConnect.Execute(sql, updateorder);
                    }


                    else
                    {
                        string sqlcustom = "SELECT * FROM customorders WHERE corderID = @oid AND cfrID = @fid;";
                        MySqlParameter[] param = {
                            new MySqlParameter("@oid", currentOid),
                            new MySqlParameter("@fid", currentFid)
                        };
                        DataTable dt = DbConnect.Query(sql, param);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Original custom order not found!");
                            return;
                        }


                        string sqlcustomorder = "SELECT MAX(CAST(SUBSTRING(corderID,3) AS UNSIGNED)) FROM customorders;";
                        int maxId = Convert.ToInt32(DbConnect.ExecuteScalar1(sqlcustomorder)) + 1;
                        string coid = $"CO{maxId:D7}";

                        DataRow row = dt.Rows[0];
                        string fID = row["cfID"].ToString();
                        int qty = Convert.ToInt32(row["Quantity"]);
                        string cID = row["cUserID"].ToString();
                        int coAmount = Convert.ToInt32(row["coAmount"]);
                        string address = row["codeliveryaddress"].ToString();
                        string shipType = row["shippingType"].ToString();

                       
                        string deliveryDate = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");
                        string insertSql = @"
                            INSERT INTO customorders(
                                corderID, cfID, Quantity, cUserID, coAmount, 
                                codeliverydate, codeliveryaddress, shippingType, 
                                , statusType, StaffNote
                            ) VALUES(
                                @oid, @fid, @qty, @uid, @amount, 
                                @date, @addr, @ship, 
                                @spec, @stat, @note
                            )";
                                    MySqlParameter[] insertParam = {
                            new MySqlParameter("@oid", coid),
                            new MySqlParameter("@fid", fID),
                            new MySqlParameter("@qty", qty),
                            new MySqlParameter("@uid", cID),
                            new MySqlParameter("@amount", coAmount),
                            new MySqlParameter("@date", deliveryDate),
                            new MySqlParameter("@addr", address),
                            new MySqlParameter("@ship", shipType),
                            new MySqlParameter("@stat", "ST01"),
                            new MySqlParameter("@note", txtStaffNote.Text)
                        };
                        DbConnect.Execute(insertSql, insertParam);

                        sql = "UPDATE returnreplacerequest SET statusType = @type WHERE rid  = @rid AND fid = @fid;";
                        MySqlParameter[] updaterequest = {
                                new MySqlParameter("@type", "Accept"),
                                new MySqlParameter("@rid",currentRid),
                                new MySqlParameter("@fid",currentFid)
                            };
                        DbConnect.Execute(sql, updaterequest);

                        sql = "UPDATE customorders SET statusType = @type ， StaffNote = @note WHERE corderID = @oid;";
                        MySqlParameter[] updateorder = {
                                new MySqlParameter("@type", "ST13"),
                                new MySqlParameter("@oid",currentOid),
                                new MySqlParameter("@note", "Replacement products will take 7 days to arrive after your application is approved. Please see your new order for details.")
                            };
                        DbConnect.Execute(sql, updateorder);


                    }








                }
                
            }





            }
        

        private void txtStaffNote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
