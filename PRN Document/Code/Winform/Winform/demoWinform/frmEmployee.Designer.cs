namespace demoWinform
{
    partial class frmEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.gpGender = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.lbDegree = new System.Windows.Forms.Label();
            this.cboDegree = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gpGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeID.Location = new System.Drawing.Point(210, 56);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(269, 25);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmployeeID.Location = new System.Drawing.Point(68, 60);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(81, 17);
            this.lbEmployeeID.TabIndex = 1;
            this.lbEmployeeID.Text = "Employee ID";
            this.lbEmployeeID.Click += new System.EventHandler(this.lbEmployeeID_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(210, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 25);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(68, 108);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 17);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhoneNumber.Location = new System.Drawing.Point(68, 158);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(96, 17);
            this.lbPhoneNumber.TabIndex = 4;
            this.lbPhoneNumber.Text = "Phone Number";
            this.lbPhoneNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(210, 156);
            this.mtxtPhoneNumber.Mask = "0000000000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(269, 25);
            this.mtxtPhoneNumber.TabIndex = 5;
            this.mtxtPhoneNumber.ValidatingType = typeof(int);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGender.Location = new System.Drawing.Point(68, 213);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(51, 17);
            this.lbGender.TabIndex = 6;
            this.lbGender.Text = "Gender";
            this.lbGender.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpGender
            // 
            this.gpGender.Controls.Add(this.rdFemale);
            this.gpGender.Controls.Add(this.rdMale);
            this.gpGender.Location = new System.Drawing.Point(210, 196);
            this.gpGender.Name = "gpGender";
            this.gpGender.Size = new System.Drawing.Size(269, 50);
            this.gpGender.TabIndex = 7;
            this.gpGender.TabStop = false;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdFemale.Location = new System.Drawing.Point(160, 18);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(67, 21);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdMale.Location = new System.Drawing.Point(37, 18);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(55, 21);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // lbDegree
            // 
            this.lbDegree.AutoSize = true;
            this.lbDegree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDegree.Location = new System.Drawing.Point(68, 275);
            this.lbDegree.Name = "lbDegree";
            this.lbDegree.Size = new System.Drawing.Size(51, 17);
            this.lbDegree.TabIndex = 8;
            this.lbDegree.Text = "Degree";
            this.lbDegree.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cboDegree
            // 
            this.cboDegree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDegree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDegree.FormattingEnabled = true;
            this.cboDegree.Location = new System.Drawing.Point(210, 271);
            this.cboDegree.Name = "cboDegree";
            this.cboDegree.Size = new System.Drawing.Size(197, 25);
            this.cboDegree.TabIndex = 9;
            this.cboDegree.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(90, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(314, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(171, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboDegree);
            this.Controls.Add(this.lbDegree);
            this.Controls.Add(this.gpGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.mtxtPhoneNumber);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbEmployeeID);
            this.Controls.Add(this.txtEmployeeID);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Mangagement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpGender.ResumeLayout(false);
            this.gpGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmployeeID;
        private Label lbEmployeeID;
        private TextBox txtName;
        private Label lbName;
        private Label lbPhoneNumber;
        private MaskedTextBox mtxtPhoneNumber;
        private Label lbGender;
        private GroupBox gpGender;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label lbDegree;
        private ComboBox cboDegree;
        private GroupBox groupBox1;
        private Button btnReset;
        private Button btnSave;
        private Button btnClose;
    }
}