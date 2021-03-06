﻿namespace Ohana3DS_Transfigured.GUI
{
    partial class OGroupBox
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Component Designer

        /// <summary> 
        /// Método necessário para o suporte do Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OGroupBox));
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.BtnToggle = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnToggle)).BeginInit();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(0, 24);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(256, 232);
            this.ContentPanel.TabIndex = 0;
            // 
            // BtnToggle
            // 
            this.BtnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnToggle.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            this.BtnToggle.Image = global::Ohana3DS_Transfigured.Properties.Resources.ui_icon_minus;
            this.BtnToggle.Location = new System.Drawing.Point(234, 2);
            this.BtnToggle.Name = "BtnToggle";
            this.BtnToggle.Size = new System.Drawing.Size(20, 20);
            this.BtnToggle.TabIndex = 5;
            this.BtnToggle.TabStop = false;
            this.BtnToggle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnToggle_MouseDown);
            this.BtnToggle.MouseEnter += new System.EventHandler(this.BtnToggle_MouseEnter);
            this.BtnToggle.MouseLeave += new System.EventHandler(this.BtnToggle_MouseLeave);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(2, 5);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 15);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "Title";
            // 
            // TitleBar
            // 
            this.TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBar.BackgroundImage")));
            this.TitleBar.Controls.Add(this.BtnToggle);
            this.TitleBar.Controls.Add(this.LblTitle);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(256, 24);
            this.TitleBar.TabIndex = 7;
            // 
            // OGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.ContentPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OGroupBox";
            this.Size = new System.Drawing.Size(256, 256);
            this.EnabledChanged += new System.EventHandler(this.OGroupBox_EnabledChanged);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.OGroupBox_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.BtnToggle)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox BtnToggle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel TitleBar;
    }
}
