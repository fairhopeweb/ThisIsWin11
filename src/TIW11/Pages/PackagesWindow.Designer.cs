﻿
namespace ThisIsWin11
{
    partial class PackagesWindow
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCreatePackage = new System.Windows.Forms.Button();
            this.btnRunPackage = new System.Windows.Forms.Button();
            this.btnPackagesMenu = new System.Windows.Forms.Button();
            this.menuPackages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPackagesImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPackagesPopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInstallWinget = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblHeaderEmoji = new System.Windows.Forms.Label();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.tvwPackages = new System.Windows.Forms.TreeView();
            this.menuPackages.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(60, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(354, 94);
            this.lblHeader.TabIndex = 139;
            this.lblHeader.Text = "Install apps we think \r\nyou\'ll love ";
            // 
            // btnCreatePackage
            // 
            this.btnCreatePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreatePackage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreatePackage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreatePackage.FlatAppearance.BorderSize = 2;
            this.btnCreatePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePackage.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePackage.ForeColor = System.Drawing.Color.White;
            this.btnCreatePackage.Location = new System.Drawing.Point(70, 735);
            this.btnCreatePackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatePackage.Name = "btnCreatePackage";
            this.btnCreatePackage.Size = new System.Drawing.Size(213, 32);
            this.btnCreatePackage.TabIndex = 141;
            this.btnCreatePackage.Text = "1. Create Package";
            this.btnCreatePackage.UseVisualStyleBackColor = false;
            this.btnCreatePackage.Click += new System.EventHandler(this.btnCreatePackage_Click);
            // 
            // btnRunPackage
            // 
            this.btnRunPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRunPackage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRunPackage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRunPackage.FlatAppearance.BorderSize = 2;
            this.btnRunPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunPackage.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunPackage.ForeColor = System.Drawing.Color.White;
            this.btnRunPackage.Location = new System.Drawing.Point(305, 735);
            this.btnRunPackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunPackage.Name = "btnRunPackage";
            this.btnRunPackage.Size = new System.Drawing.Size(213, 32);
            this.btnRunPackage.TabIndex = 142;
            this.btnRunPackage.Text = "2. Run Installer";
            this.btnRunPackage.UseVisualStyleBackColor = false;
            this.btnRunPackage.Click += new System.EventHandler(this.btnRunPackage_Click);
            // 
            // btnPackagesMenu
            // 
            this.btnPackagesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPackagesMenu.BackColor = System.Drawing.Color.White;
            this.btnPackagesMenu.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPackagesMenu.FlatAppearance.BorderSize = 0;
            this.btnPackagesMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPackagesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackagesMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackagesMenu.Location = new System.Drawing.Point(1160, 0);
            this.btnPackagesMenu.Name = "btnPackagesMenu";
            this.btnPackagesMenu.Size = new System.Drawing.Size(48, 51);
            this.btnPackagesMenu.TabIndex = 157;
            this.btnPackagesMenu.UseVisualStyleBackColor = false;
            this.btnPackagesMenu.Click += new System.EventHandler(this.btnPackagesMenu_Click);
            // 
            // menuPackages
            // 
            this.menuPackages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuPackages.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPackages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPackagesImport,
            this.menuPackagesExport,
            this.menuPackagesExpand,
            this.menuPackagesRefresh,
            this.menuPackagesPopOut,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.menuPackages.Name = "menuMain";
            this.menuPackages.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPackages.Size = new System.Drawing.Size(305, 190);
            // 
            // menuPackagesImport
            // 
            this.menuPackagesImport.Name = "menuPackagesImport";
            this.menuPackagesImport.Size = new System.Drawing.Size(304, 30);
            this.menuPackagesImport.Text = "Import package list";
            this.menuPackagesImport.Click += new System.EventHandler(this.menuPackagesImport_Click);
            // 
            // menuPackagesExport
            // 
            this.menuPackagesExport.Name = "menuPackagesExport";
            this.menuPackagesExport.Size = new System.Drawing.Size(304, 30);
            this.menuPackagesExport.Text = "Export to PowerShell";
            this.menuPackagesExport.Click += new System.EventHandler(this.menuPackagesExport_Click);
            // 
            // menuPackagesExpand
            // 
            this.menuPackagesExpand.Name = "menuPackagesExpand";
            this.menuPackagesExpand.Size = new System.Drawing.Size(304, 30);
            this.menuPackagesExpand.Text = "Expand all";
            this.menuPackagesExpand.Click += new System.EventHandler(this.menuPackagesExpand_Click);
            // 
            // menuPackagesRefresh
            // 
            this.menuPackagesRefresh.Name = "menuPackagesRefresh";
            this.menuPackagesRefresh.Size = new System.Drawing.Size(304, 30);
            this.menuPackagesRefresh.Text = "Refresh";
            this.menuPackagesRefresh.Click += new System.EventHandler(this.menuPackagesRefresh_Click);
            // 
            // menuPackagesPopOut
            // 
            this.menuPackagesPopOut.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPackagesPopOut.Name = "menuPackagesPopOut";
            this.menuPackagesPopOut.Size = new System.Drawing.Size(304, 30);
            this.menuPackagesPopOut.Text = "Pop-out-App";
            this.menuPackagesPopOut.Click += new System.EventHandler(this.menuPackagesPopOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(301, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(304, 30);
            this.toolStripMenuItem1.Text = "Powered by Windows Package Manager";
            // 
            // btnInstallWinget
            // 
            this.btnInstallWinget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstallWinget.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnInstallWinget.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInstallWinget.FlatAppearance.BorderSize = 2;
            this.btnInstallWinget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallWinget.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallWinget.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInstallWinget.Location = new System.Drawing.Point(305, 105);
            this.btnInstallWinget.Name = "btnInstallWinget";
            this.btnInstallWinget.Size = new System.Drawing.Size(213, 32);
            this.btnInstallWinget.TabIndex = 161;
            this.btnInstallWinget.Text = "Install Windows Package Manager";
            this.btnInstallWinget.UseVisualStyleBackColor = false;
            this.btnInstallWinget.Click += new System.EventHandler(this.btnInstallWinget_Click);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(538, 61);
            this.progress.MarqueeAnimationSpeed = 30;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(663, 5);
            this.progress.TabIndex = 162;
            this.progress.Visible = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.lblHeaderEmoji);
            this.pnlLeft.Controls.Add(this.btnRunPackage);
            this.pnlLeft.Controls.Add(this.btnCreatePackage);
            this.pnlLeft.Controls.Add(this.btnInstallWinget);
            this.pnlLeft.Controls.Add(this.rtbPS);
            this.pnlLeft.Controls.Add(this.lblHeader);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(532, 862);
            this.pnlLeft.TabIndex = 163;
            // 
            // lblHeaderEmoji
            // 
            this.lblHeaderEmoji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderEmoji.BackColor = System.Drawing.Color.White;
            this.lblHeaderEmoji.Font = new System.Drawing.Font("Segoe Fluent Icons", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderEmoji.ForeColor = System.Drawing.Color.DeepPink;
            this.lblHeaderEmoji.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeaderEmoji.Location = new System.Drawing.Point(240, 105);
            this.lblHeaderEmoji.Name = "lblHeaderEmoji";
            this.lblHeaderEmoji.Size = new System.Drawing.Size(42, 35);
            this.lblHeaderEmoji.TabIndex = 162;
            // 
            // rtbPS
            // 
            this.rtbPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPS.BackColor = System.Drawing.Color.White;
            this.rtbPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPS.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbPS.HideSelection = false;
            this.rtbPS.Location = new System.Drawing.Point(68, 175);
            this.rtbPS.Name = "rtbPS";
            this.rtbPS.ReadOnly = true;
            this.rtbPS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbPS.Size = new System.Drawing.Size(450, 546);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = "";
            this.rtbPS.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbPS_LinkClicked);
            // 
            // tvwPackages
            // 
            this.tvwPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwPackages.CheckBoxes = true;
            this.tvwPackages.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwPackages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tvwPackages.HotTracking = true;
            this.tvwPackages.ItemHeight = 30;
            this.tvwPackages.Location = new System.Drawing.Point(544, 82);
            this.tvwPackages.Name = "tvwPackages";
            this.tvwPackages.ShowLines = false;
            this.tvwPackages.Size = new System.Drawing.Size(664, 736);
            this.tvwPackages.TabIndex = 165;
            // 
            // PackagesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 862);
            this.Controls.Add(this.tvwPackages);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btnPackagesMenu);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PackagesWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packages";
            this.Shown += new System.EventHandler(this.PackagesWindow_Shown);
            this.menuPackages.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCreatePackage;
        private System.Windows.Forms.Button btnRunPackage;
        private System.Windows.Forms.Button btnPackagesMenu;
        private System.Windows.Forms.ContextMenuStrip menuPackages;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesImport;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesPopOut;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesExport;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesRefresh;
        private System.Windows.Forms.Button btnInstallWinget;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TreeView tvwPackages;
        private System.Windows.Forms.ToolStripMenuItem menuPackagesExpand;
        private System.Windows.Forms.Label lblHeaderEmoji;
    }
}