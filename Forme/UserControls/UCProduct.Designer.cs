namespace Forme.UserControls
{
    partial class UCProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtPriceVAT = new System.Windows.Forms.TextBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite novi proizvod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena bez PDV-a:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "PDV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cena sa PDV-om:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valuta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tip proizvida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Merna jedinica:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Proizvođač:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 26);
            this.txtName.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(593, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 26);
            this.txtPrice.TabIndex = 12;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(593, 137);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(164, 26);
            this.txtVAT.TabIndex = 13;
            // 
            // txtPriceVAT
            // 
            this.txtPriceVAT.Location = new System.Drawing.Point(593, 184);
            this.txtPriceVAT.Name = "txtPriceVAT";
            this.txtPriceVAT.Size = new System.Drawing.Size(164, 26);
            this.txtPriceVAT.TabIndex = 14;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(593, 231);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(164, 28);
            this.cmbCurrency.TabIndex = 15;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(194, 140);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(164, 28);
            this.cmbType.TabIndex = 16;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(194, 186);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(164, 28);
            this.cmbUnit.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 51);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Sačuvaj proizvod";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(194, 232);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(164, 26);
            this.txtManufacturer.TabIndex = 20;
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.txtPriceVAT);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(830, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtPriceVAT;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtManufacturer;
    }
}
