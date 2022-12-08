namespace Solution
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.buttonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.formGroup = new System.Windows.Forms.GroupBox();
            this.numericBoxMana = new LoL.UI.CustomControls.NumericBox();
            this.numericBoxHp = new LoL.UI.CustomControls.NumericBox();
            this.labelManaError = new System.Windows.Forms.Label();
            this.labelHpError = new System.Windows.Forms.Label();
            this.labelNameError = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfRelease = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfRelease = new System.Windows.Forms.Label();
            this.labelMana = new System.Windows.Forms.Label();
            this.labelHp = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip.SuspendLayout();
            this.formGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAdd,
            this.toolStripSeparator1,
            this.buttonUpdate,
            this.toolStripSeparator2,
            this.buttonDelete,
            this.toolStripSeparator3});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "Menu";
            // 
            // buttonAdd
            // 
            this.buttonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(23, 22);
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.OnAddClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(23, 22);
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.onUpdateClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(23, 22);
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // formGroup
            // 
            this.formGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.formGroup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.formGroup.Controls.Add(this.numericBoxMana);
            this.formGroup.Controls.Add(this.numericBoxHp);
            this.formGroup.Controls.Add(this.labelManaError);
            this.formGroup.Controls.Add(this.labelHpError);
            this.formGroup.Controls.Add(this.labelNameError);
            this.formGroup.Controls.Add(this.buttonCancel);
            this.formGroup.Controls.Add(this.buttonOK);
            this.formGroup.Controls.Add(this.comboBoxRole);
            this.formGroup.Controls.Add(this.labelRole);
            this.formGroup.Controls.Add(this.dateTimePickerDateOfRelease);
            this.formGroup.Controls.Add(this.labelDateOfRelease);
            this.formGroup.Controls.Add(this.labelMana);
            this.formGroup.Controls.Add(this.labelHp);
            this.formGroup.Controls.Add(this.textBoxName);
            this.formGroup.Controls.Add(this.labelName);
            this.formGroup.Enabled = false;
            this.formGroup.Location = new System.Drawing.Point(0, 28);
            this.formGroup.Name = "formGroup";
            this.formGroup.Size = new System.Drawing.Size(400, 732);
            this.formGroup.TabIndex = 1;
            this.formGroup.TabStop = false;
            this.formGroup.Text = "Champion Data";
            // 
            // numericBoxMana
            // 
            this.numericBoxMana.DoubleValue = null;
            this.numericBoxMana.IntValue = null;
            this.numericBoxMana.Location = new System.Drawing.Point(5, 186);
            this.numericBoxMana.Name = "numericBoxMana";
            this.numericBoxMana.Size = new System.Drawing.Size(388, 23);
            this.numericBoxMana.TabIndex = 3;
            this.numericBoxMana.Leave += new System.EventHandler(this.OnLostFocus);
            // 
            // numericBoxHp
            // 
            this.numericBoxHp.DoubleValue = null;
            this.numericBoxHp.IntValue = null;
            this.numericBoxHp.Location = new System.Drawing.Point(6, 117);
            this.numericBoxHp.Name = "numericBoxHp";
            this.numericBoxHp.Size = new System.Drawing.Size(388, 23);
            this.numericBoxHp.TabIndex = 2;
            this.numericBoxHp.Leave += new System.EventHandler(this.OnLostFocus);
            // 
            // labelManaError
            // 
            this.labelManaError.AutoSize = true;
            this.labelManaError.ForeColor = System.Drawing.Color.Red;
            this.labelManaError.Location = new System.Drawing.Point(6, 212);
            this.labelManaError.Name = "labelManaError";
            this.labelManaError.Size = new System.Drawing.Size(0, 15);
            this.labelManaError.TabIndex = 14;
            // 
            // labelHpError
            // 
            this.labelHpError.AutoSize = true;
            this.labelHpError.ForeColor = System.Drawing.Color.Red;
            this.labelHpError.Location = new System.Drawing.Point(6, 143);
            this.labelHpError.Name = "labelHpError";
            this.labelHpError.Size = new System.Drawing.Size(0, 15);
            this.labelHpError.TabIndex = 13;
            // 
            // labelNameError
            // 
            this.labelNameError.AutoSize = true;
            this.labelNameError.ForeColor = System.Drawing.Color.Red;
            this.labelNameError.Location = new System.Drawing.Point(6, 71);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(0, 15);
            this.labelNameError.TabIndex = 12;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(6, 703);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(319, 703);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OnSubmitClick);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(5, 297);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(389, 23);
            this.comboBoxRole.TabIndex = 5;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(5, 279);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(30, 15);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Role";
            // 
            // dateTimePickerDateOfRelease
            // 
            this.dateTimePickerDateOfRelease.Location = new System.Drawing.Point(5, 253);
            this.dateTimePickerDateOfRelease.Name = "dateTimePickerDateOfRelease";
            this.dateTimePickerDateOfRelease.Size = new System.Drawing.Size(389, 23);
            this.dateTimePickerDateOfRelease.TabIndex = 4;
            // 
            // labelDateOfRelease
            // 
            this.labelDateOfRelease.AutoSize = true;
            this.labelDateOfRelease.Location = new System.Drawing.Point(5, 235);
            this.labelDateOfRelease.Name = "labelDateOfRelease";
            this.labelDateOfRelease.Size = new System.Drawing.Size(89, 15);
            this.labelDateOfRelease.TabIndex = 6;
            this.labelDateOfRelease.Text = "Date Of Release";
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Location = new System.Drawing.Point(5, 168);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(37, 15);
            this.labelMana.TabIndex = 4;
            this.labelMana.Text = "Mana";
            // 
            // labelHp
            // 
            this.labelHp.AutoSize = true;
            this.labelHp.Location = new System.Drawing.Point(5, 99);
            this.labelHp.Name = "labelHp";
            this.labelHp.Size = new System.Drawing.Size(23, 15);
            this.labelHp.TabIndex = 2;
            this.labelHp.Text = "HP";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(5, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(389, 23);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Leave += new System.EventHandler(this.OnLostFocus);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(406, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(778, 732);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.OnDataGridViewSelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.formGroup);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Text = "Lol";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.formGroup.ResumeLayout(false);
            this.formGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripButton buttonAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton buttonUpdate;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton buttonDelete;
        private ToolStripSeparator toolStripSeparator3;
        private GroupBox formGroup;
        private DataGridView dataGridView;
        private Button buttonOK;
        private ComboBox comboBoxRole;
        private Label labelRole;
        private DateTimePicker dateTimePickerDateOfRelease;
        private Label labelDateOfRelease;
        private Label labelMana;
        private Label labelHp;
        private TextBox textBoxName;
        private Label labelName;
        private Button buttonCancel;
        private Label labelNameError;
        private Label labelManaError;
        private Label labelHpError;
        private LoL.UI.CustomControls.NumericBox numericBoxMana;
        private LoL.UI.CustomControls.NumericBox numericBoxHp;
    }
}