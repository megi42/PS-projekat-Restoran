namespace Forme.UserControls
{
    partial class UCInvoice
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
            this.txtTotalVAT = new System.Windows.Forms.TextBox();
            this.txtTotalToPay = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtCache = new System.Windows.Forms.TextBox();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNoFilter = new System.Windows.Forms.Button();
            this.Porudžbine = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Porudžbine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalVAT
            // 
            this.txtTotalVAT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalVAT.Enabled = false;
            this.txtTotalVAT.Location = new System.Drawing.Point(844, 334);
            this.txtTotalVAT.Name = "txtTotalVAT";
            this.txtTotalVAT.Size = new System.Drawing.Size(135, 26);
            this.txtTotalVAT.TabIndex = 11;
            // 
            // txtTotalToPay
            // 
            this.txtTotalToPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalToPay.Enabled = false;
            this.txtTotalToPay.Location = new System.Drawing.Point(844, 374);
            this.txtTotalToPay.Name = "txtTotalToPay";
            this.txtTotalToPay.Size = new System.Drawing.Size(135, 26);
            this.txtTotalToPay.TabIndex = 12;
            // 
            // txtCard
            // 
            this.txtCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCard.Enabled = false;
            this.txtCard.Location = new System.Drawing.Point(866, 546);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(152, 26);
            this.txtCard.TabIndex = 21;
            // 
            // txtCache
            // 
            this.txtCache.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCache.Enabled = false;
            this.txtCache.Location = new System.Drawing.Point(866, 500);
            this.txtCache.Name = "txtCache";
            this.txtCache.Size = new System.Drawing.Size(152, 26);
            this.txtCache.TabIndex = 20;
            // 
            // cbPayment
            // 
            this.cbPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPayment.Enabled = false;
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(844, 455);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(189, 28);
            this.cbPayment.TabIndex = 16;
            this.cbPayment.SelectedIndexChanged += new System.EventHandler(this.cbPayment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1022, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sto:";
            // 
            // txtTable
            // 
            this.txtTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTable.Enabled = false;
            this.txtTable.Location = new System.Drawing.Point(720, 49);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(65, 26);
            this.txtTable.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(1087, 13);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(170, 26);
            this.txtDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Radnik:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ukupan iznos:";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(720, 84);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(170, 26);
            this.txtUser.TabIndex = 7;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(6, 22);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.RowTemplate.Height = 28;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(610, 133);
            this.dgvItems.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgvItems);
            this.groupBox1.Location = new System.Drawing.Point(641, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 162);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(767, 294);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(123, 26);
            this.txtTotal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ukupan iznos sa PDV-om:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ukupan iznos za plaćanje:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valuta:";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrency.Enabled = false;
            this.txtCurrency.Location = new System.Drawing.Point(709, 414);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 26);
            this.txtCurrency.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(644, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Odaberite način plaćanja:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1074, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 39);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(644, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Iznos koji se plaća gotovinom:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Iznos koji se plaća karticom:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Pretraga porudžbine";
            // 
            // cbTable
            // 
            this.cbTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(114, 61);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(112, 28);
            this.cbTable.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Broj stola:";
            // 
            // cbUser
            // 
            this.cbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(114, 102);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(202, 28);
            this.cbUser.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Radnik:";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateFrom.Location = new System.Drawing.Point(114, 143);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(169, 26);
            this.txtDateFrom.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Datum od:";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateTo.Location = new System.Drawing.Point(114, 182);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(169, 26);
            this.txtDateTo.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Datum do:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(29, 234);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(179, 44);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNoFilter
            // 
            this.btnNoFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNoFilter.Location = new System.Drawing.Point(239, 234);
            this.btnNoFilter.Name = "btnNoFilter";
            this.btnNoFilter.Size = new System.Drawing.Size(179, 44);
            this.btnNoFilter.TabIndex = 32;
            this.btnNoFilter.Text = "Poništi filtere";
            this.btnNoFilter.UseVisualStyleBackColor = true;
            this.btnNoFilter.Click += new System.EventHandler(this.btnNoFilter_Click);
            // 
            // Porudžbine
            // 
            this.Porudžbine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Porudžbine.Controls.Add(this.dgvOrders);
            this.Porudžbine.Location = new System.Drawing.Point(3, 306);
            this.Porudžbine.Name = "Porudžbine";
            this.Porudžbine.Size = new System.Drawing.Size(616, 239);
            this.Porudžbine.TabIndex = 33;
            this.Porudžbine.TabStop = false;
            this.Porudžbine.Text = "Porudžbine:";
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
            this.dgvOrders.Size = new System.Drawing.Size(604, 207);
            this.dgvOrders.TabIndex = 0;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInvoice.Location = new System.Drawing.Point(9, 560);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(207, 49);
            this.btnInvoice.TabIndex = 44;
            this.btnInvoice.Text = "Kreiraj račun";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(1074, 616);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 39);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCardNumber.Enabled = false;
            this.txtCardNumber.Location = new System.Drawing.Point(751, 629);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(267, 26);
            this.txtCardNumber.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(644, 635);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 47;
            this.label16.Text = "Broj kartice:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(644, 592);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "Tip kartice:";
            // 
            // cbCardType
            // 
            this.cbCardType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCardType.Enabled = false;
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Location = new System.Drawing.Point(751, 584);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(121, 28);
            this.cbCardType.TabIndex = 49;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(1074, 450);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(173, 37);
            this.btnPay.TabIndex = 50;
            this.btnPay.Text = "Potvrdi";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // UCInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cbCardType);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.Porudžbine);
            this.Controls.Add(this.btnNoFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.txtCache);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalToPay);
            this.Controls.Add(this.txtTotalVAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Name = "UCInvoice";
            this.Size = new System.Drawing.Size(1271, 670);
            this.Load += new System.EventHandler(this.UCInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Porudžbine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalVAT;
        private System.Windows.Forms.TextBox txtTotalToPay;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtCache;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNoFilter;
        private System.Windows.Forms.GroupBox Porudžbine;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.Button btnPay;
    }
}
