﻿namespace MP3_Player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Options = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BAR = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.kureserKontrolPanel = new System.Windows.Forms.Panel();
            this.pomeranjeProzora1 = new MP3_Player.PomeranjeProzora();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.logoBar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.titlBar = new System.Windows.Forms.Panel();
            this.labelOption = new System.Windows.Forms.Label();
            this.labelTiltle = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Options.SuspendLayout();
            this.kureserKontrolPanel.SuspendLayout();
            this.logoBar.SuspendLayout();
            this.titlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Options.Controls.Add(this.button2);
            this.Options.Controls.Add(this.BAR);
            this.Options.Controls.Add(this.panelDesktop);
            this.Options.Controls.Add(this.kureserKontrolPanel);
            this.Options.Controls.Add(this.logoBar);
            this.Options.Controls.Add(this.titlBar);
            this.Options.Controls.Add(this.button5);
            this.Options.Controls.Add(this.button1);
            this.Options.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(1188, 681);
            this.Options.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.ForeColor = System.Drawing.Color.Ivory;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "   Register";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BAR
            // 
            this.BAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.BAR.Location = new System.Drawing.Point(982, 39);
            this.BAR.Name = "BAR";
            this.BAR.Size = new System.Drawing.Size(206, 86);
            this.BAR.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.Location = new System.Drawing.Point(202, 125);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(986, 556);
            this.panelDesktop.TabIndex = 11;
            // 
            // kureserKontrolPanel
            // 
            this.kureserKontrolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kureserKontrolPanel.Controls.Add(this.pomeranjeProzora1);
            this.kureserKontrolPanel.Controls.Add(this.button8);
            this.kureserKontrolPanel.Controls.Add(this.button6);
            this.kureserKontrolPanel.Controls.Add(this.button7);
            this.kureserKontrolPanel.Location = new System.Drawing.Point(0, 0);
            this.kureserKontrolPanel.Name = "kureserKontrolPanel";
            this.kureserKontrolPanel.Size = new System.Drawing.Size(1186, 39);
            this.kureserKontrolPanel.TabIndex = 10;
            // 
            // pomeranjeProzora1
            // 
            this.pomeranjeProzora1.IzaberiKontrolu = this.kureserKontrolPanel;
            this.pomeranjeProzora1.Location = new System.Drawing.Point(800, 12);
            this.pomeranjeProzora1.Name = "pomeranjeProzora1";
            this.pomeranjeProzora1.Size = new System.Drawing.Size(10, 11);
            this.pomeranjeProzora1.TabIndex = 11;
            this.pomeranjeProzora1.Text = "pomeranjeProzora1";
            this.pomeranjeProzora1.Visible = false;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1081, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 27);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseLeave += new System.EventHandler(this.button8_MouseLeave);
            this.button8.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1153, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 27);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseLeave += new System.EventHandler(this.button6_Leave);
            this.button6.MouseHover += new System.EventHandler(this.button6_Hover);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1117, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 27);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            this.button7.MouseHover += new System.EventHandler(this.button7_MouseHover);
            // 
            // logoBar
            // 
            this.logoBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(100)))));
            this.logoBar.Controls.Add(this.label3);
            this.logoBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.logoBar.Location = new System.Drawing.Point(0, 39);
            this.logoBar.Name = "logoBar";
            this.logoBar.Size = new System.Drawing.Size(203, 86);
            this.logoBar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ren Player";
            // 
            // titlBar
            // 
            this.titlBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.titlBar.Controls.Add(this.labelOption);
            this.titlBar.Controls.Add(this.labelTiltle);
            this.titlBar.Location = new System.Drawing.Point(202, 39);
            this.titlBar.Name = "titlBar";
            this.titlBar.Size = new System.Drawing.Size(781, 86);
            this.titlBar.TabIndex = 1;
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Location = new System.Drawing.Point(365, 47);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(0, 13);
            this.labelOption.TabIndex = 13;
            // 
            // labelTiltle
            // 
            this.labelTiltle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTiltle.AutoSize = true;
            this.labelTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiltle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTiltle.Location = new System.Drawing.Point(364, 36);
            this.labelTiltle.Name = "labelTiltle";
            this.labelTiltle.Size = new System.Drawing.Size(95, 25);
            this.labelTiltle.TabIndex = 12;
            this.labelTiltle.Text = "Welcome";
            this.labelTiltle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button5.ForeColor = System.Drawing.Color.Ivory;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "   Radio";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "   Songs";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 681);
            this.Controls.Add(this.Options);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Options.ResumeLayout(false);
            this.kureserKontrolPanel.ResumeLayout(false);
            this.logoBar.ResumeLayout(false);
            this.logoBar.PerformLayout();
            this.titlBar.ResumeLayout(false);
            this.titlBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Options;
        private System.Windows.Forms.Panel titlBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel logoBar;
        private System.Windows.Forms.Panel kureserKontrolPanel;
        private PomeranjeProzora pomeranjeProzora1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelTiltle;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.Panel BAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

