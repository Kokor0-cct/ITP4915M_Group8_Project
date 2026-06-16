using ITP4915M_Group8_Project.Customer;
using ITP4915M_Group8_Project.Staff.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITP4915M_Group8_Project.Staff.Production
{
    public partial class Material_Requirement_Sheet : UserControl
    {
        public Material_Requirement_Sheet()
        {
            InitializeComponent();
            string sql = "SELECT * FROM material";
            try
            {
                DataTable dt = DbConnect.Query(sql);
                cmbMaterialRequirement.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    cmbMaterialRequirement.Items.Add(row["mName"].ToString());


                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Material reading failed：" + ex.Message);
            }
           
        }

        public string SelectedMaterialName
        {
            get
            {
                if (cmbMaterialRequirement.SelectedItem == null)
                    return null;
                return cmbMaterialRequirement.SelectedItem.ToString();
            }
        }
        public int RequireQuantity
        {
            get
            {
                return (int)numdMaterialRequirement.Value;
            }
        }
    }
}
