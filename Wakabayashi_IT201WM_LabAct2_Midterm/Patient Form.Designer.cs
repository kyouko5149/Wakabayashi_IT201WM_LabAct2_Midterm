namespace Wakabayashi_IT201WM_LabAct2_Midterm
{
    partial class Patient_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PFExit = new System.Windows.Forms.Button();
            this.PFClear = new System.Windows.Forms.Button();
            this.PFSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PFFemale = new System.Windows.Forms.RadioButton();
            this.PFMale = new System.Windows.Forms.RadioButton();
            this.PFAge = new System.Windows.Forms.TextBox();
            this.PFDiagnosis = new System.Windows.Forms.TextBox();
            this.PFAddress = new System.Windows.Forms.TextBox();
            this.PFName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATIENT FORM";
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
            this.label3.Location = new System.Drawing.Point(397, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AGE:";
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
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DIAGNOSIS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PFExit);
            this.groupBox1.Controls.Add(this.PFClear);
            this.groupBox1.Controls.Add(this.PFSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PFFemale);
            this.groupBox1.Controls.Add(this.PFMale);
            this.groupBox1.Controls.Add(this.PFAge);
            this.groupBox1.Controls.Add(this.PFDiagnosis);
            this.groupBox1.Controls.Add(this.PFAddress);
            this.groupBox1.Controls.Add(this.PFName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // PFExit
            // 
            this.PFExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFExit.Location = new System.Drawing.Point(587, 251);
            this.PFExit.Name = "PFExit";
            this.PFExit.Size = new System.Drawing.Size(154, 55);
            this.PFExit.TabIndex = 13;
            this.PFExit.Text = "EXIT";
            this.PFExit.UseVisualStyleBackColor = true;
            this.PFExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PFClear
            // 
            this.PFClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFClear.Location = new System.Drawing.Point(587, 190);
            this.PFClear.Name = "PFClear";
            this.PFClear.Size = new System.Drawing.Size(154, 55);
            this.PFClear.TabIndex = 12;
            this.PFClear.Text = "CLEAR";
            this.PFClear.UseVisualStyleBackColor = true;
            this.PFClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PFSave
            // 
            this.PFSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFSave.Location = new System.Drawing.Point(587, 129);
            this.PFSave.Name = "PFSave";
            this.PFSave.Size = new System.Drawing.Size(154, 55);
            this.PFSave.TabIndex = 0;
            this.PFSave.Text = "SAVE";
            this.PFSave.UseVisualStyleBackColor = true;
            this.PFSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "SEX:";
            // 
            // PFFemale
            // 
            this.PFFemale.AutoSize = true;
            this.PFFemale.Location = new System.Drawing.Point(678, 44);
            this.PFFemale.Name = "PFFemale";
            this.PFFemale.Size = new System.Drawing.Size(70, 17);
            this.PFFemale.TabIndex = 10;
            this.PFFemale.TabStop = true;
            this.PFFemale.Text = "FEMALE:";
            this.PFFemale.UseVisualStyleBackColor = true;
            // 
            // PFMale
            // 
            this.PFMale.AutoSize = true;
            this.PFMale.Location = new System.Drawing.Point(609, 44);
            this.PFMale.Name = "PFMale";
            this.PFMale.Size = new System.Drawing.Size(54, 17);
            this.PFMale.TabIndex = 9;
            this.PFMale.TabStop = true;
            this.PFMale.Text = "MALE";
            this.PFMale.UseVisualStyleBackColor = true;
            // 
            // PFAge
            // 
            this.PFAge.Location = new System.Drawing.Point(435, 41);
            this.PFAge.Name = "PFAge";
            this.PFAge.Size = new System.Drawing.Size(104, 20);
            this.PFAge.TabIndex = 8;
            // 
            // PFDiagnosis
            // 
            this.PFDiagnosis.Location = new System.Drawing.Point(111, 126);
            this.PFDiagnosis.Multiline = true;
            this.PFDiagnosis.Name = "PFDiagnosis";
            this.PFDiagnosis.Size = new System.Drawing.Size(438, 177);
            this.PFDiagnosis.TabIndex = 7;
            // 
            // PFAddress
            // 
            this.PFAddress.Location = new System.Drawing.Point(111, 84);
            this.PFAddress.Name = "PFAddress";
            this.PFAddress.Size = new System.Drawing.Size(284, 20);
            this.PFAddress.TabIndex = 6;
            // 
            // PFName
            // 
            this.PFName.Location = new System.Drawing.Point(111, 41);
            this.PFName.Name = "PFName";
            this.PFName.Size = new System.Drawing.Size(256, 20);
            this.PFName.TabIndex = 5;
            // 
            // Patient_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Patient_Form";
            this.Text = "Patient_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PFExit;
        private System.Windows.Forms.Button PFClear;
        private System.Windows.Forms.Button PFSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton PFFemale;
        private System.Windows.Forms.RadioButton PFMale;
        private System.Windows.Forms.TextBox PFAge;
        private System.Windows.Forms.TextBox PFDiagnosis;
        private System.Windows.Forms.TextBox PFAddress;
        private System.Windows.Forms.TextBox PFName;
    }
}