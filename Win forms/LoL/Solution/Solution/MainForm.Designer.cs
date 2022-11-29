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
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfRelease = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelMana = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelHp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // formGroup
            // 
            this.formGroup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.formGroup.Controls.Add(this.buttonOK);
            this.formGroup.Controls.Add(this.comboBoxRole);
            this.formGroup.Controls.Add(this.labelRole);
            this.formGroup.Controls.Add(this.dateTimePicker1);
            this.formGroup.Controls.Add(this.labelDateOfRelease);
            this.formGroup.Controls.Add(this.textBox3);
            this.formGroup.Controls.Add(this.labelMana);
            this.formGroup.Controls.Add(this.textBox2);
            this.formGroup.Controls.Add(this.labelHp);
            this.formGroup.Controls.Add(this.textBox1);
            this.formGroup.Controls.Add(this.labelName);
            this.formGroup.Enabled = false;
            this.formGroup.Location = new System.Drawing.Point(0, 28);
            this.formGroup.Name = "formGroup";
            this.formGroup.Size = new System.Drawing.Size(400, 732);
            this.formGroup.TabIndex = 1;
            this.formGroup.TabStop = false;
            this.formGroup.Text = "Champion Data";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(147, 703);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(5, 221);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(389, 23);
            this.comboBoxRole.TabIndex = 9;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(5, 203);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(30, 15);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Role";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(389, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // labelDateOfRelease
            // 
            this.labelDateOfRelease.AutoSize = true;
            this.labelDateOfRelease.Location = new System.Drawing.Point(5, 159);
            this.labelDateOfRelease.Name = "labelDateOfRelease";
            this.labelDateOfRelease.Size = new System.Drawing.Size(89, 15);
            this.labelDateOfRelease.TabIndex = 6;
            this.labelDateOfRelease.Text = "Date Of Release";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(5, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 23);
            this.textBox3.TabIndex = 5;
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Location = new System.Drawing.Point(5, 115);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(37, 15);
            this.labelMana.TabIndex = 4;
            this.labelMana.Text = "Mana";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 23);
            this.textBox2.TabIndex = 3;
            // 
            // labelHp
            // 
            this.labelHp.AutoSize = true;
            this.labelHp.Location = new System.Drawing.Point(5, 71);
            this.labelHp.Name = "labelHp";
            this.labelHp.Size = new System.Drawing.Size(23, 15);
            this.labelHp.TabIndex = 2;
            this.labelHp.Text = "HP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 23);
            this.textBox1.TabIndex = 1;
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
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(406, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(778, 732);
            this.dataGridView.TabIndex = 2;
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
        private DateTimePicker dateTimePicker1;
        private Label labelDateOfRelease;
        private TextBox textBox3;
        private Label labelMana;
        private TextBox textBox2;
        private Label labelHp;
        private TextBox textBox1;
        private Label labelName;
    }
}