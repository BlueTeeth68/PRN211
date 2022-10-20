namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarDetails));
            this.lbCarID = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.mtxtPrice = new System.Windows.Forms.MaskedTextBox();
            this.mtxtReleasedYear = new System.Windows.Forms.MaskedTextBox();
            this.lbReleasedYear = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(67, 64);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(44, 17);
            this.lbCarID.TabIndex = 0;
            this.lbCarID.Text = "Car ID";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(195, 61);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(290, 25);
            this.txtCarID.TabIndex = 1;
            this.txtCarID.TextChanged += new System.EventHandler(this.txtCarID_TextChanged);
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(195, 111);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(290, 25);
            this.txtCarName.TabIndex = 3;
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(67, 114);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(67, 17);
            this.lbCarName.TabIndex = 2;
            this.lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(67, 167);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(86, 17);
            this.lbManufacturer.TabIndex = 4;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Ford",
            "Honda",
            "Hyundai",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.cboManufacturer.Location = new System.Drawing.Point(195, 164);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(290, 25);
            this.cboManufacturer.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(67, 217);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 17);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price";
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // mtxtPrice
            // 
            this.mtxtPrice.Location = new System.Drawing.Point(195, 214);
            this.mtxtPrice.Mask = "000000000";
            this.mtxtPrice.Name = "mtxtPrice";
            this.mtxtPrice.Size = new System.Drawing.Size(290, 25);
            this.mtxtPrice.TabIndex = 7;
            this.mtxtPrice.Text = "0";
            this.mtxtPrice.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mtxtReleasedYear
            // 
            this.mtxtReleasedYear.Location = new System.Drawing.Point(195, 266);
            this.mtxtReleasedYear.Mask = "0000";
            this.mtxtReleasedYear.Name = "mtxtReleasedYear";
            this.mtxtReleasedYear.Size = new System.Drawing.Size(290, 25);
            this.mtxtReleasedYear.TabIndex = 9;
            this.mtxtReleasedYear.Text = "0";
            // 
            // lbReleasedYear
            // 
            this.lbReleasedYear.AutoSize = true;
            this.lbReleasedYear.Location = new System.Drawing.Point(67, 269);
            this.lbReleasedYear.Name = "lbReleasedYear";
            this.lbReleasedYear.Size = new System.Drawing.Size(90, 17);
            this.lbReleasedYear.TabIndex = 8;
            this.lbReleasedYear.Text = "Released Year";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(410, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 430);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mtxtReleasedYear);
            this.Controls.Add(this.lbReleasedYear);
            this.Controls.Add(this.mtxtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lbCarID);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Details";
            this.Load += new System.EventHandler(this.frmCarDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCarID;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private Label lbCarName;
        private Label lbManufacturer;
        private ComboBox cboManufacturer;
        private Label lbPrice;
        private MaskedTextBox mtxtPrice;
        private MaskedTextBox mtxtReleasedYear;
        private Label lbReleasedYear;
        private Button btnSave;
        private Button btnCancel;
    }
}