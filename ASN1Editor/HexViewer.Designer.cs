﻿namespace ASN1Editor
{
    partial class HexViewer
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
            this.txtHex = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtHex
            // 
            this.txtHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHex.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex.Location = new System.Drawing.Point(0, 0);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(555, 273);
            this.txtHex.TabIndex = 0;
            this.txtHex.Text = "";
            // 
            // HexViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 273);
            this.Controls.Add(this.txtHex);
            this.Name = "HexViewer";
            this.Text = "HexViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHex;

    }
}