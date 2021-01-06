namespace Forme.UserControls
{
    partial class UCAllOrders
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
            this.Porudžbine = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNoFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPayed = new System.Windows.Forms.Label();
            this.Porudžbine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // Porudžbine
            // 
            this.Porudžbine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Porudžbine.Controls.Add(this.dgvOrders);
            this.Porudžbine.Location = new System.Drawing.Point(15, 137);
            this.Porudžbine.Name = "Porudžbine";
            this.Porudžbine.Size = new System.Drawing.Size(1055, 239);
            this.Porudžbine.TabIndex = 0;
            this.Porudžbine.TabStop = false;
            this.Porudžbine.Text = "Porudžbine";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(6, 25);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1043, 207);
            this.dgvOrders.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga porudžbine";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj stola:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Radnik:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum od:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(942, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Datum do:";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateFrom.Location = new System.Drawing.Point(719, 92);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(169, 26);
            this.txtDateFrom.TabIndex = 8;
            // 
            // cbTable
            // 
            this.cbTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(115, 90);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(112, 28);
            this.cbTable.TabIndex = 10;
            // 
            // cbUser
            // 
            this.cbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(338, 90);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(202, 28);
            this.cbUser.TabIndex = 11;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateTo.Location = new System.Drawing.Point(1031, 92);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(169, 26);
            this.txtDateTo.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(1076, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(179, 44);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNoFilter
            // 
            this.btnNoFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNoFilter.Location = new System.Drawing.Point(1076, 212);
            this.btnNoFilter.Name = "btnNoFilter";
            this.btnNoFilter.Size = new System.Drawing.Size(179, 44);
            this.btnNoFilter.TabIndex = 14;
            this.btnNoFilter.Text = "Poništi filtere";
            this.btnNoFilter.UseVisualStyleBackColor = true;
            this.btnNoFilter.Click += new System.EventHandler(this.btnNoFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgvItems);
            this.groupBox2.Location = new System.Drawing.Point(15, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1230, 219);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke porudžbine:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(6, 20);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.RowTemplate.Height = 28;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1218, 193);
            this.dgvItems.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.Location = new System.Drawing.Point(1076, 262);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(179, 43);
            this.btnShow.TabIndex = 43;
            this.btnShow.Text = "Prikaži";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Status porudžbine:";
            // 
            // lblPayed
            // 
            this.lblPayed.AutoSize = true;
            this.lblPayed.Location = new System.Drawing.Point(176, 623);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(119, 20);
            this.lblPayed.TabIndex = 45;
            this.lblPayed.Text = "Status plaćanja";
            // 
            // UCAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblPayed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNoFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Porudžbine);
            this.Name = "UCAllOrders";
            this.Size = new System.Drawing.Size(1269, 655);
            this.Porudžbine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Porudžbine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNoFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPayed;
    }
}
