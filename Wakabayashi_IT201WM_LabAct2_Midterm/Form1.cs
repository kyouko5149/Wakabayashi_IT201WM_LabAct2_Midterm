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
    public partial class HospitalManagement : Form
    {
        public HospitalManagement()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }
        private void ShowPatientForm() 
        { 
            new Patient_Form { MdiParent = this }.Show(); 
        }
        private void ShowDoctorForm() 
        { 
            new Doctor_Form { MdiParent = this }.Show(); 
        }
        private void ShowBillForm() 
        { 
            new Bill_Form { MdiParent = this }.Show(); 
        }
        private void ctxNewPatient_Click(object sender, EventArgs e) 
        { 
            ShowPatientForm(); 
        }
        private void ctxNewDoctor_Click(object sender, EventArgs e) 
        { 
            ShowDoctorForm(); 
        }
        private void ctxNewBilling_Click(object sender, EventArgs e) 
        { 
            ShowBillForm(); 
        }
        private void ctxVertical_Click(object sender, EventArgs e) 
        { 
            this.LayoutMdi(MdiLayout.TileVertical); 
        }
        private void ctxHorizontal_Click(object sender, EventArgs e) 
        { 
            this.LayoutMdi(MdiLayout.TileHorizontal); 
        }
        private void ctxCascade_Click(object sender, EventArgs e) 
        { 
            this.LayoutMdi(MdiLayout.Cascade); 
        }
        private void ctxCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void ctxExit_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                MessageBox.Show("Are you sure you want to exit the Hospital System?",
                                                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void OpenPatientForm()
        {
            Patient_Form pf = new Patient_Form { MdiParent = this };
            pf.Show();
        }
        private void OpenDoctorForm()
        {
            Doctor_Form df = new Doctor_Form { MdiParent = this };
            df.Show();
        }
        private void OpenBillForm()
        {
            Bill_Form bf = new Bill_Form { MdiParent = this };
            bf.Show();
        }
        private void newPatient_Click(object sender, EventArgs e) 
        { 
            OpenPatientForm();
        }
        private void newDoctor_Click(object sender, EventArgs e) 
        { 
            OpenDoctorForm(); 
        }
        private void newBill_Click(object sender, EventArgs e) 
        { 
            OpenBillForm(); 
        }

        private void exit_Click(object sender, EventArgs e) 
        {
            DialogResult result =
                MessageBox.Show("Are you sure you want to exit the Hospital System?",
                                                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tileVertical_Click(object sender, EventArgs e) 
        { 
            this.LayoutMdi(MdiLayout.TileVertical); 
        }
        private void tileHorizontal_Click(object sender, EventArgs e) 
        { 
            this.LayoutMdi(MdiLayout.TileHorizontal); 
        }
        private void tileCascade_Click(object sender, EventArgs e) 
        { 
            this.LayoutMdi(MdiLayout.Cascade); 
        }

        private void closeAllWindows_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

    }
}
