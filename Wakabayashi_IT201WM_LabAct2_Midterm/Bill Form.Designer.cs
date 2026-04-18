namespace Wakabayashi_IT201WM_LabAct2_Midterm
{
    partial class Bill_Form
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
            this.BFExit = new System.Windows.Forms.Button();
            this.BFClear = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.BFSave = new System.Windows.Forms.Button();
            this.BFAmount = new System.Windows.Forms.TextBox();
            this.BFpatientnm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BFExit);
            this.groupBox1.Controls.Add(this.BFClear);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.BFSave);
            this.groupBox1.Controls.Add(this.BFAmount);
            this.groupBox1.Controls.Add(this.BFpatientnm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 194);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // BFExit
            // 
            this.BFExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFExit.Location = new System.Drawing.Point(495, 113);
            this.BFExit.Name = "BFExit";
            this.BFExit.Size = new System.Drawing.Size(128, 29);
            this.BFExit.TabIndex = 16;
            this.BFExit.Text = "EXIT";
            this.BFExit.UseVisualStyleBackColor = true;
            this.BFExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BFClear
            // 
            this.BFClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFClear.Location = new System.Drawing.Point(495, 77);
            this.BFClear.Name = "BFClear";
            this.BFClear.Size = new System.Drawing.Size(128, 29);
            this.BFClear.TabIndex = 15;
            this.BFClear.Text = "CLEAR";
            this.BFClear.UseVisualStyleBackColor = true;
            this.BFClear.Click += new System.EventHandler(this.btnBFClear_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.cbStatus.Location = new System.Drawing.Point(147, 126);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(282, 21);
            this.cbStatus.TabIndex = 14;
            // 
            // BFSave
            // 
            this.BFSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFSave.Location = new System.Drawing.Point(495, 41);
            this.BFSave.Name = "BFSave";
            this.BFSave.Size = new System.Drawing.Size(128, 29);
            this.BFSave.TabIndex = 0;
            this.BFSave.Text = "SAVE";
            this.BFSave.UseVisualStyleBackColor = true;
            this.BFSave.Click += new System.EventHandler(this.btnBFSave_Click);
            // 
            // BFAmount
            // 
            this.BFAmount.Location = new System.Drawing.Point(111, 84);
            this.BFAmount.Name = "BFAmount";
            this.BFAmount.Size = new System.Drawing.Size(318, 20);
            this.BFAmount.TabIndex = 6;
            // 
            // BFpatientnm
            // 
            this.BFpatientnm.Location = new System.Drawing.Point(132, 44);
            this.BFpatientnm.Name = "BFpatientnm";
            this.BFpatientnm.Size = new System.Drawing.Size(318, 20);
            this.BFpatientnm.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AMOUNT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PAYMENT STATUS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PATIENT NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "BILLING FORM";
            // 
            // Bill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Bill_Form";
            this.Text = "Bill_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BFExit;
        private System.Windows.Forms.Button BFClear;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button BFSave;
        private System.Windows.Forms.TextBox BFAmount;
        private System.Windows.Forms.TextBox BFpatientnm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}