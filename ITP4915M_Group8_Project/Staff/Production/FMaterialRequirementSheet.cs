namespace ITP4915M_Group8_Project.Staff.Production
{
    public partial class FMaterialRequirementSheet : Form
    {
        public FMaterialRequirementSheet()
        {
            InitializeComponent();
        }



        private void btnADDMaterialRequirement_Click(object sender, EventArgs e)
        {
            fpMaterialRequirement.Controls.Add(new Material_Requirement_Sheet());
        }

        private void btndeleteMaterialRequirement_Click(object sender, EventArgs e)
        {
            
            if (fpMaterialRequirement.Controls.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No more material requirement sheet to delete.");
                return;
            }

            fpMaterialRequirement.Controls.RemoveAt(fpMaterialRequirement.Controls.Count - 1);
        }
    }
}
