using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Wakabayashi_IT201WM_LabAct2_Midterm
{
    public partial class Doctor_Form : Form
    {
        public Doctor_Form()
        {
            InitializeComponent();
        }
        private void btnDFSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DFName.Text) || cbSpecialization.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter the Doctor's Name and select a Specialization.",
                                "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string specialization = cbSpecialization.SelectedItem.ToString();

            string output = $"     DOCTOR PROFILE SAVED    \n\n" +
                            $"Name: {DFName.Text}\n" +
                            $"Age: {DFAge.Text}\n" +
                            $"Address: {DFAddress.Text}\n" +
                            $"Specialization: {specialization}";

            MessageBox.Show(output, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDFClear_Click(object sender, EventArgs e)
        {
            DFName.Clear();
            DFAge.Clear(); 
            DFAddress.Clear();
            cbSpecialization.SelectedIndex = -1;

            DFName.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
