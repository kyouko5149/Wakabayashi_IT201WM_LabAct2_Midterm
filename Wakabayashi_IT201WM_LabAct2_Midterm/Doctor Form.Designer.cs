namespace Wakabayashi_IT201WM_LabAct2_Midterm
{
    partial class Doctor_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSpecialization = new System.Windows.Forms.ComboBox();
            this.DFExit = new System.Windows.Forms.Button();
            this.DFClear = new System.Windows.Forms.Button();
            this.DFSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DFFemale = new System.Windows.Forms.RadioButton();
            this.DFMale = new System.Windows.Forms.RadioButton();
            this.DFAge = new System.Windows.Forms.TextBox();
            this.DFAddress = new System.Windows.Forms.TextBox();
            this.DFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSpecialization);
            this.groupBox1.Controls.Add(this.DFExit);
            this.groupBox1.Controls.Add(this.DFClear);
            this.groupBox1.Controls.Add(this.DFSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DFFemale);
            this.groupBox1.Controls.Add(this.DFMale);
            this.groupBox1.Controls.Add(this.DFAge);
            this.groupBox1.Controls.Add(this.DFAddress);
            this.groupBox1.Controls.Add(this.DFName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 289);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cbSpecialization
            // 
            this.cbSpecialization.FormattingEnabled = true;
            this.cbSpecialization.Items.AddRange(new object[] {
            "Cardiology",
            "Pediatrics",
            "Neurology",
            "General Medicine",
            "Surgery"});
            this.cbSpecialization.Location = new System.Drawing.Point(150, 126);
            this.cbSpecialization.Name = "cbSpecialization";
            this.cbSpecialization.Size = new System.Drawing.Size(218, 21);
            this.cbSpecialization.TabIndex = 14;
            // 
            // DFExit
            // 
            this.DFExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFExit.Location = new System.Drawing.Point(509, 190);
            this.DFExit.Name = "DFExit";
            this.DFExit.Size = new System.Drawing.Size(154, 55);
            this.DFExit.TabIndex = 13;
            this.DFExit.Text = "EXIT";
            this.DFExit.UseVisualStyleBackColor = true;
            this.DFExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DFClear
            // 
            this.DFClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFClear.Location = new System.Drawing.Point(275, 190);
            this.DFClear.Name = "DFClear";
            this.DFClear.Size = new System.Drawing.Size(154, 55);
            this.DFClear.TabIndex = 12;
            this.DFClear.Text = "CLEAR";
            this.DFClear.UseVisualStyleBackColor = true;
            this.DFClear.Click += new System.EventHandler(this.btnDFClear_Click);
            // 
            // DFSave
            // 
            this.DFSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFSave.Location = new System.Drawing.Point(39, 190);
            this.DFSave.Name = "DFSave";
            this.DFSave.Size = new System.Drawing.Size(154, 55);
            this.DFSave.TabIndex = 0;
            this.DFSave.Text = "SAVE";
            this.DFSave.UseVisualStyleBackColor = true;
            this.DFSave.Click += new System.EventHandler(this.btnDFSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "SEX:";
            // 
            // DFFemale
            // 
            this.DFFemale.AutoSize = true;
            this.DFFemale.Location = new System.Drawing.Point(593, 87);
            this.DFFemale.Name = "DFFemale";
            this.DFFemale.Size = new System.Drawing.Size(70, 17);
            this.DFFemale.TabIndex = 10;
            this.DFFemale.TabStop = true;
            this.DFFemale.Text = "FEMALE:";
            this.DFFemale.UseVisualStyleBackColor = true;
            // 
            // DFMale
            // 
            this.DFMale.AutoSize = true;
            this.DFMale.Location = new System.Drawing.Point(524, 87);
            this.DFMale.Name = "DFMale";
            this.DFMale.Size = new System.Drawing.Size(54, 17);
            this.DFMale.TabIndex = 9;
            this.DFMale.TabStop = true;
            this.DFMale.Text = "MALE";
            this.DFMale.UseVisualStyleBackColor = true;
            // 
            // DFAge
            // 
            this.DFAge.Location = new System.Drawing.Point(509, 44);
            this.DFAge.Name = "DFAge";
            this.DFAge.Size = new System.Drawing.Size(104, 20);
            this.DFAge.TabIndex = 8;
            // 
            // DFAddress
            // 
            this.DFAddress.Location = new System.Drawing.Point(111, 84);
            this.DFAddress.Name = "DFAddress";
            this.DFAddress.Size = new System.Drawing.Size(318, 20);
            this.DFAddress.TabIndex = 6;
            // 
            // DFName
            // 
            this.DFName.Location = new System.Drawing.Point(111, 41);
            this.DFName.Name = "DFName";
            this.DFName.Size = new System.Drawing.Size(318, 20);
            this.DFName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ADDRESS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SPECIALIZATION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AGE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "DOCTOR FORM";
            // 
            // Doctor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Doctor_Form";
            this.Text = "Doctor_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSpecialization;
        private System.Windows.Forms.Button DFExit;
        private System.Windows.Forms.Button DFClear;
        private System.Windows.Forms.Button DFSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton DFFemale;
        private System.Windows.Forms.RadioButton DFMale;
        private System.Windows.Forms.TextBox DFAge;
        private System.Windows.Forms.TextBox DFAddress;
        private System.Windows.Forms.TextBox DFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}