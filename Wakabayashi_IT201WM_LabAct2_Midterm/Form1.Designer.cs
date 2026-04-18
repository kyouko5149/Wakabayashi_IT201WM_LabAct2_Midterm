namespace Wakabayashi_IT201WM_LabAct2_Midterm
{
    partial class HospitalManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalManagement));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileCascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tlsNewPatient = new System.Windows.Forms.ToolStripButton();
            this.tlsNewDoctor = new System.Windows.Forms.ToolStripButton();
            this.tlsNewBilling = new System.Windows.Forms.ToolStripButton();
            this.tlsTileVertical = new System.Windows.Forms.ToolStripButton();
            this.tlsTileHorizontal = new System.Windows.Forms.ToolStripButton();
            this.tlsTileCascade = new System.Windows.Forms.ToolStripButton();
            this.tlsClose = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newPatientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newDoctorFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBillingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tileCascadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(990, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem,
            this.newDoctorToolStripMenuItem,
            this.newBillToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newPatientToolStripMenuItem.Text = "New Patient";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatient_Click);
            // 
            // newDoctorToolStripMenuItem
            // 
            this.newDoctorToolStripMenuItem.Name = "newDoctorToolStripMenuItem";
            this.newDoctorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newDoctorToolStripMenuItem.Text = "New Doctor";
            this.newDoctorToolStripMenuItem.Click += new System.EventHandler(this.newDoctor_Click);
            // 
            // newBillToolStripMenuItem
            // 
            this.newBillToolStripMenuItem.Name = "newBillToolStripMenuItem";
            this.newBillToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newBillToolStripMenuItem.Text = "New Bill";
            this.newBillToolStripMenuItem.Click += new System.EventHandler(this.newBill_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileCascadeToolStripMenuItem,
            this.closeWindowToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVertical_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontal_Click);
            // 
            // tileCascadeToolStripMenuItem
            // 
            this.tileCascadeToolStripMenuItem.Name = "tileCascadeToolStripMenuItem";
            this.tileCascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileCascadeToolStripMenuItem.Text = "Tile Cascade";
            this.tileCascadeToolStripMenuItem.Click += new System.EventHandler(this.tileCascade_Click);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.closeWindowToolStripMenuItem.Text = "Close Window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeAllWindows_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNewPatient,
            this.tlsNewDoctor,
            this.tlsNewBilling,
            this.tlsTileVertical,
            this.tlsTileHorizontal,
            this.tlsTileCascade,
            this.tlsClose});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(990, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tlsNewPatient
            // 
            this.tlsNewPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsNewPatient.Image = ((System.Drawing.Image)(resources.GetObject("tlsNewPatient.Image")));
            this.tlsNewPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsNewPatient.Name = "tlsNewPatient";
            this.tlsNewPatient.Size = new System.Drawing.Size(23, 22);
            this.tlsNewPatient.Text = "New Patient";
            this.tlsNewPatient.ToolTipText = "New Patient Form";
            this.tlsNewPatient.Click += new System.EventHandler(this.newPatient_Click);
            // 
            // tlsNewDoctor
            // 
            this.tlsNewDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsNewDoctor.Image = ((System.Drawing.Image)(resources.GetObject("tlsNewDoctor.Image")));
            this.tlsNewDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsNewDoctor.Name = "tlsNewDoctor";
            this.tlsNewDoctor.Size = new System.Drawing.Size(23, 22);
            this.tlsNewDoctor.Text = "New Doctor";
            this.tlsNewDoctor.ToolTipText = "New Doctor Form";
            this.tlsNewDoctor.Click += new System.EventHandler(this.newDoctor_Click);
            // 
            // tlsNewBilling
            // 
            this.tlsNewBilling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsNewBilling.Image = ((System.Drawing.Image)(resources.GetObject("tlsNewBilling.Image")));
            this.tlsNewBilling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsNewBilling.Name = "tlsNewBilling";
            this.tlsNewBilling.Size = new System.Drawing.Size(23, 22);
            this.tlsNewBilling.Text = "New Billing";
            this.tlsNewBilling.ToolTipText = "New Billing Form";
            this.tlsNewBilling.Click += new System.EventHandler(this.newBill_Click);
            // 
            // tlsTileVertical
            // 
            this.tlsTileVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsTileVertical.Image = ((System.Drawing.Image)(resources.GetObject("tlsTileVertical.Image")));
            this.tlsTileVertical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsTileVertical.Name = "tlsTileVertical";
            this.tlsTileVertical.Size = new System.Drawing.Size(23, 22);
            this.tlsTileVertical.Text = "Tile Vertical";
            this.tlsTileVertical.ToolTipText = "Tile Vertical";
            this.tlsTileVertical.Click += new System.EventHandler(this.tileVertical_Click);
            // 
            // tlsTileHorizontal
            // 
            this.tlsTileHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsTileHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("tlsTileHorizontal.Image")));
            this.tlsTileHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsTileHorizontal.Name = "tlsTileHorizontal";
            this.tlsTileHorizontal.Size = new System.Drawing.Size(23, 22);
            this.tlsTileHorizontal.Text = "Tile Horizontal";
            this.tlsTileHorizontal.ToolTipText = "Tile Horizontal";
            this.tlsTileHorizontal.Click += new System.EventHandler(this.tileHorizontal_Click);
            // 
            // tlsTileCascade
            // 
            this.tlsTileCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsTileCascade.Image = ((System.Drawing.Image)(resources.GetObject("tlsTileCascade.Image")));
            this.tlsTileCascade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsTileCascade.Name = "tlsTileCascade";
            this.tlsTileCascade.Size = new System.Drawing.Size(23, 22);
            this.tlsTileCascade.Text = "Cascade";
            this.tlsTileCascade.ToolTipText = "Tile Cascade";
            this.tlsTileCascade.Click += new System.EventHandler(this.tileCascade_Click);
            // 
            // tlsClose
            // 
            this.tlsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsClose.Image = ((System.Drawing.Image)(resources.GetObject("tlsClose.Image")));
            this.tlsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsClose.Name = "tlsClose";
            this.tlsClose.Size = new System.Drawing.Size(23, 22);
            this.tlsClose.Text = "Close All Window";
            this.tlsClose.Click += new System.EventHandler(this.closeAllWindows_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem1,
            this.newDoctorFormToolStripMenuItem,
            this.newBillingFormToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tileVerticalToolStripMenuItem1,
            this.tileHorizontalToolStripMenuItem1,
            this.tileCascadeToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.closeAllWindowToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 224);
            // 
            // newPatientToolStripMenuItem1
            // 
            this.newPatientToolStripMenuItem1.Name = "newPatientToolStripMenuItem1";
            this.newPatientToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.newPatientToolStripMenuItem1.Text = "New Patient Form";
            this.newPatientToolStripMenuItem1.Click += new System.EventHandler(this.ctxNewPatient_Click);
            // 
            // newDoctorFormToolStripMenuItem
            // 
            this.newDoctorFormToolStripMenuItem.Name = "newDoctorFormToolStripMenuItem";
            this.newDoctorFormToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.newDoctorFormToolStripMenuItem.Text = "New Doctor Form";
            this.newDoctorFormToolStripMenuItem.Click += new System.EventHandler(this.ctxNewDoctor_Click);
            // 
            // newBillingFormToolStripMenuItem
            // 
            this.newBillingFormToolStripMenuItem.Name = "newBillingFormToolStripMenuItem";
            this.newBillingFormToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.newBillingFormToolStripMenuItem.Text = "New Billing Form";
            this.newBillingFormToolStripMenuItem.Click += new System.EventHandler(this.ctxNewBilling_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(264, 22);
            this.toolStripMenuItem2.Text = "--------------------------------------";
            // 
            // tileVerticalToolStripMenuItem1
            // 
            this.tileVerticalToolStripMenuItem1.Name = "tileVerticalToolStripMenuItem1";
            this.tileVerticalToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.tileVerticalToolStripMenuItem1.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem1.Click += new System.EventHandler(this.ctxVertical_Click);
            // 
            // tileHorizontalToolStripMenuItem1
            // 
            this.tileHorizontalToolStripMenuItem1.Name = "tileHorizontalToolStripMenuItem1";
            this.tileHorizontalToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.tileHorizontalToolStripMenuItem1.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem1.Click += new System.EventHandler(this.ctxHorizontal_Click);
            // 
            // tileCascadeToolStripMenuItem1
            // 
            this.tileCascadeToolStripMenuItem1.Name = "tileCascadeToolStripMenuItem1";
            this.tileCascadeToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.tileCascadeToolStripMenuItem1.Text = "Tile Cascade";
            this.tileCascadeToolStripMenuItem1.Click += new System.EventHandler(this.ctxCascade_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(264, 22);
            this.toolStripMenuItem3.Text = "-------------------------------------";
            // 
            // closeAllWindowToolStripMenuItem
            // 
            this.closeAllWindowToolStripMenuItem.Name = "closeAllWindowToolStripMenuItem";
            this.closeAllWindowToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.closeAllWindowToolStripMenuItem.Text = "Close All Window";
            this.closeAllWindowToolStripMenuItem.Click += new System.EventHandler(this.ctxCloseAll_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // HospitalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 496);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HospitalManagement";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileCascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tlsNewPatient;
        private System.Windows.Forms.ToolStripButton tlsNewDoctor;
        private System.Windows.Forms.ToolStripButton tlsNewBilling;
        private System.Windows.Forms.ToolStripButton tlsTileVertical;
        private System.Windows.Forms.ToolStripButton tlsTileHorizontal;
        private System.Windows.Forms.ToolStripButton tlsTileCascade;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tlsClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newDoctorFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBillingFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tileCascadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem closeAllWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

