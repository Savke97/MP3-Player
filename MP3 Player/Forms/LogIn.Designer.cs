namespace MP3_Player.Forms
{
    partial class LogIn
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
            this.log_InDataSet = new MP3_Player.Log_InDataSet();
            this.logInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logInTableAdapter = new MP3_Player.Log_InDataSetTableAdapters.LogInTableAdapter();
            this.tableAdapterManager = new MP3_Player.Log_InDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.sifra = new System.Windows.Forms.TextBox();
            this.log_In_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.log_InDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // log_InDataSet
            // 
            this.log_InDataSet.DataSetName = "Log_InDataSet";
            this.log_InDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logInBindingSource
            // 
            this.logInBindingSource.DataMember = "LogIn";
            this.logInBindingSource.DataSource = this.log_InDataSet;
            // 
            // logInTableAdapter
            // 
            this.logInTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LogInTableAdapter = this.logInTableAdapter;
            this.tableAdapterManager.UpdateOrder = MP3_Player.Log_InDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(183, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(191, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifra";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.Location = new System.Drawing.Point(274, 139);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(197, 20);
            this.email.TabIndex = 4;
            // 
            // sifra
            // 
            this.sifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifra.Location = new System.Drawing.Point(274, 192);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(197, 20);
            this.sifra.TabIndex = 5;
            // 
            // log_In_BTN
            // 
            this.log_In_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_In_BTN.BackColor = System.Drawing.Color.LimeGreen;
            this.log_In_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.log_In_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_In_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.log_In_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_In_BTN.Location = new System.Drawing.Point(287, 262);
            this.log_In_BTN.Name = "log_In_BTN";
            this.log_In_BTN.Size = new System.Drawing.Size(175, 58);
            this.log_In_BTN.TabIndex = 6;
            this.log_In_BTN.Text = "Log In";
            this.log_In_BTN.UseVisualStyleBackColor = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(765, 517);
            this.Controls.Add(this.log_In_BTN);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "LogIn";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.log_InDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Log_InDataSet log_InDataSet;
        private System.Windows.Forms.BindingSource logInBindingSource;
        private Log_InDataSetTableAdapters.LogInTableAdapter logInTableAdapter;
        private Log_InDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox sifra;
        private System.Windows.Forms.Button log_In_BTN;
    }
}