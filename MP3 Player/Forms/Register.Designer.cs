namespace MP3_Player.Forms
{
    partial class Register
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label sifraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.registerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.log_InDataSet1 = new MP3_Player.Log_InDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.registerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sifraTextBox = new System.Windows.Forms.TextBox();
            this.registerTableAdapter = new MP3_Player.Log_InDataSet1TableAdapters.RegisterTableAdapter();
            this.tableAdapterManager = new MP3_Player.Log_InDataSet1TableAdapters.TableAdapterManager();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            sifraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingNavigator)).BeginInit();
            this.registerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_InDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            imeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            imeLabel.Location = new System.Drawing.Point(298, 73);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(41, 24);
            imeLabel.TabIndex = 18;
            imeLabel.Text = "Ime";
            // 
            // prezimeLabel
            // 
            prezimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            prezimeLabel.AutoSize = true;
            prezimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            prezimeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            prezimeLabel.Location = new System.Drawing.Point(260, 111);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(79, 24);
            prezimeLabel.TabIndex = 20;
            prezimeLabel.Text = "Prezime";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            emailLabel.Location = new System.Drawing.Point(282, 146);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(57, 24);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email";
            // 
            // sifraLabel
            // 
            sifraLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sifraLabel.AutoSize = true;
            sifraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            sifraLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            sifraLabel.Location = new System.Drawing.Point(293, 181);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(46, 24);
            sifraLabel.TabIndex = 24;
            sifraLabel.Text = "Sifra";
            // 
            // registerBindingNavigator
            // 
            this.registerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registerBindingNavigator.BindingSource = this.registerBindingSource;
            this.registerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.registerBindingNavigatorSaveItem});
            this.registerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registerBindingNavigator.Name = "registerBindingNavigator";
            this.registerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registerBindingNavigator.Size = new System.Drawing.Size(919, 25);
            this.registerBindingNavigator.TabIndex = 16;
            this.registerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "Register";
            this.registerBindingSource.DataSource = this.log_InDataSet1;
            // 
            // log_InDataSet1
            // 
            this.log_InDataSet1.DataSetName = "Log_InDataSet1";
            this.log_InDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // registerBindingNavigatorSaveItem
            // 
            this.registerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registerBindingNavigatorSaveItem.Image")));
            this.registerBindingNavigatorSaveItem.Name = "registerBindingNavigatorSaveItem";
            this.registerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.registerBindingNavigatorSaveItem.Text = "Save Data";
            this.registerBindingNavigatorSaveItem.Click += new System.EventHandler(this.registerBindingNavigatorSaveItem_Click);
            // 
            // registerDataGridView
            // 
            this.registerDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registerDataGridView.AutoGenerateColumns = false;
            this.registerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.registerDataGridView.DataSource = this.registerBindingSource;
            this.registerDataGridView.Location = new System.Drawing.Point(206, 325);
            this.registerDataGridView.Name = "registerDataGridView";
            this.registerDataGridView.Size = new System.Drawing.Size(544, 220);
            this.registerDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sifra";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sifra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(351, 77);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(242, 20);
            this.imeTextBox.TabIndex = 19;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(351, 115);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(242, 20);
            this.prezimeTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(351, 150);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(242, 20);
            this.emailTextBox.TabIndex = 23;
            // 
            // sifraTextBox
            // 
            this.sifraTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerBindingSource, "Sifra", true));
            this.sifraTextBox.Location = new System.Drawing.Point(351, 185);
            this.sifraTextBox.Name = "sifraTextBox";
            this.sifraTextBox.Size = new System.Drawing.Size(242, 20);
            this.sifraTextBox.TabIndex = 25;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RegisterTableAdapter = this.registerTableAdapter;
            this.tableAdapterManager.UpdateOrder = MP3_Player.Log_InDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 606);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(sifraLabel);
            this.Controls.Add(this.sifraTextBox);
            this.Controls.Add(this.registerDataGridView);
            this.Controls.Add(this.registerBindingNavigator);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingNavigator)).EndInit();
            this.registerBindingNavigator.ResumeLayout(false);
            this.registerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_InDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Log_InDataSet1 log_InDataSet1;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private Log_InDataSet1TableAdapters.RegisterTableAdapter registerTableAdapter;
        private Log_InDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton registerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView registerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sifraTextBox;
    }
}