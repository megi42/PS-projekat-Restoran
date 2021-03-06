﻿namespace Forme
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porudžbenicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiPorudzbenicuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaPorudžbineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaPorudžbineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvodToolStripMenuItem,
            this.porudžbenicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proizvodToolStripMenuItem
            // 
            this.proizvodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiProizvodToolStripMenuItem,
            this.pretragaProizvodaToolStripMenuItem,
            this.brisanjeProizvodaToolStripMenuItem});
            this.proizvodToolStripMenuItem.Name = "proizvodToolStripMenuItem";
            this.proizvodToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.proizvodToolStripMenuItem.Text = "Proizvod";
            // 
            // unesiProizvodToolStripMenuItem
            // 
            this.unesiProizvodToolStripMenuItem.Name = "unesiProizvodToolStripMenuItem";
            this.unesiProizvodToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.unesiProizvodToolStripMenuItem.Text = "Unos novog proizvoda";
            this.unesiProizvodToolStripMenuItem.Click += new System.EventHandler(this.unesiProizvodToolStripMenuItem_Click);
            // 
            // pretragaProizvodaToolStripMenuItem
            // 
            this.pretragaProizvodaToolStripMenuItem.Name = "pretragaProizvodaToolStripMenuItem";
            this.pretragaProizvodaToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.pretragaProizvodaToolStripMenuItem.Text = "Pretraga proizvoda";
            this.pretragaProizvodaToolStripMenuItem.Click += new System.EventHandler(this.pretragaProizvodaToolStripMenuItem_Click);
            // 
            // brisanjeProizvodaToolStripMenuItem
            // 
            this.brisanjeProizvodaToolStripMenuItem.Name = "brisanjeProizvodaToolStripMenuItem";
            this.brisanjeProizvodaToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.brisanjeProizvodaToolStripMenuItem.Text = "Brisanje proizvoda";
            this.brisanjeProizvodaToolStripMenuItem.Click += new System.EventHandler(this.brisanjeProizvodaToolStripMenuItem_Click);
            // 
            // porudžbenicaToolStripMenuItem
            // 
            this.porudžbenicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiPorudzbenicuToolStripMenuItem,
            this.pretragaPorudžbineToolStripMenuItem,
            this.izmenaPorudžbineToolStripMenuItem,
            this.kreiranjeRačunaToolStripMenuItem});
            this.porudžbenicaToolStripMenuItem.Name = "porudžbenicaToolStripMenuItem";
            this.porudžbenicaToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.porudžbenicaToolStripMenuItem.Text = "Porudžbina";
            // 
            // unesiPorudzbenicuToolStripMenuItem
            // 
            this.unesiPorudzbenicuToolStripMenuItem.Name = "unesiPorudzbenicuToolStripMenuItem";
            this.unesiPorudzbenicuToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.unesiPorudzbenicuToolStripMenuItem.Text = "Unos nove porudžbine";
            this.unesiPorudzbenicuToolStripMenuItem.Click += new System.EventHandler(this.unesiPorudzbenicuToolStripMenuItem_Click);
            // 
            // pretragaPorudžbineToolStripMenuItem
            // 
            this.pretragaPorudžbineToolStripMenuItem.Name = "pretragaPorudžbineToolStripMenuItem";
            this.pretragaPorudžbineToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.pretragaPorudžbineToolStripMenuItem.Text = "Pretraga porudžbine";
            this.pretragaPorudžbineToolStripMenuItem.Click += new System.EventHandler(this.pretragaPorudžbineToolStripMenuItem_Click);
            // 
            // izmenaPorudžbineToolStripMenuItem
            // 
            this.izmenaPorudžbineToolStripMenuItem.Name = "izmenaPorudžbineToolStripMenuItem";
            this.izmenaPorudžbineToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.izmenaPorudžbineToolStripMenuItem.Text = "Izmena porudžbine";
            this.izmenaPorudžbineToolStripMenuItem.Click += new System.EventHandler(this.izmenaPorudžbineToolStripMenuItem_Click);
            // 
            // kreiranjeRačunaToolStripMenuItem
            // 
            this.kreiranjeRačunaToolStripMenuItem.Name = "kreiranjeRačunaToolStripMenuItem";
            this.kreiranjeRačunaToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.kreiranjeRačunaToolStripMenuItem.Text = "Kreiranje računa";
            this.kreiranjeRačunaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeRačunaToolStripMenuItem_Click);
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMainContainer.Controls.Add(this.lblWelcome);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 33);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1300, 975);
            this.pnlMainContainer.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(545, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(106, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1300, 1008);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna strana";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiProizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porudžbenicaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.ToolStripMenuItem unesiPorudzbenicuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaPorudžbineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaPorudžbineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeRačunaToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
    }
}