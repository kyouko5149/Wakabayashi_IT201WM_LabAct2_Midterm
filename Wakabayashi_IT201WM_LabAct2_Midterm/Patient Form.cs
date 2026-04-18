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
    public partial class Patient_Form : Form
    {
        public Patient_Form()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Validation Logic
            if (string.IsNullOrWhiteSpace(PFName.Text) || string.IsNullOrWhiteSpace(PFAge.Text))
            {
                MessageBox.Show("Please fill out the required fields (Name and Age) before saving.",
                                "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gather Data (Handling RadioButtons for Sex)
            string sex = PFMale.Checked ? "Male" : (PFFemale.Checked ? "Female" : "Not Specified");

            // 3. Show Output via MessageBox
            string summary = $"    PATIENT RECORD SAVED    \n\n" +
                             $"Name: {PFName.Text}\n" +
                             $"Age: {PFAge.Text}\n" +
                             $"Sex: {sex}\n" +
                             $"Address: {PFAddress.Text}\n" +
                             $"Diagnosis: {PFDiagnosis.Text}";

            MessageBox.Show(summary, "System Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears all textboxes
            PFName.Clear();
            PFAge.Clear();
            PFAddress.Clear();
            PFDiagnosis.Clear();
            PFMale.Checked = false;
            PFFemale.Checked = false;
            PFName.Focus(); // Sets cursor back to Name
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Only closes this specific child form
        }
    }
}
