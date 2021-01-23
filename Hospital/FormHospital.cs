using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormHospital : Form
    {
        Patient patient;
        public FormHospital()
        {
            InitializeComponent();

        }

        private void FormHospital_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (radInsured.Checked)
            {
                patient = new InsuredPatient() { Name = txtName.Text, HoursInHospital = Convert.ToInt32(numHours.Value) };
            }
            else
            {
                patient = new Patient() { Name = txtName.Text, HoursInHospital = Convert.ToInt32(numHours.Value) };
            }
            lblOutput.Text = patient.ShowInfo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            btnCalc.Enabled = true;
        }
    }
}
