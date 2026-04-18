using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wakabayashi_IT201WM_LabAct2_Midterm
{
    public partial class Bill_Form : Form
    {
        public Bill_Form()
        {
            InitializeComponent();
        }
        private void btnBFSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(BFpatientnm.Text) ||
                string.IsNullOrWhiteSpace(BFAmount.Text) ||
                cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("All billing fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Add this inside your Billing Form Save click
            if (!double.TryParse(BFAmount.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Invalid Input");
                return;
            }
            string status = cbStatus.SelectedItem.ToString();

            string output = $"    BILLING INVOICE    \n\n" +
                            $"Patient: {BFpatientnm.Text}\n" +
                            $"Amount: {BFAmount.Text}\n" +
                            $"Status: {status}";

            MessageBox.Show(output, "Invoice Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBFClear_Click(object sender, EventArgs e)
        {
            BFpatientnm.Clear();
            BFAmount.Clear();

            // Reset the dropdown
            cbStatus.SelectedIndex = -1;

            BFpatientnm.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
