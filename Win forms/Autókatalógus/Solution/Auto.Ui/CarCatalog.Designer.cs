namespace Vehicle.Ui
{
    partial class CarCatalog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarCatalog));
            this.formGroup = new System.Windows.Forms.GroupBox();
            this.labelErrorProductionYear = new System.Windows.Forms.Label();
            this.labelErrorCC = new System.Windows.Forms.Label();
            this.numericBoxProductionYear = new Vehicle.Ui.CustomControls.NumericBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelErrorCubicCapacity = new System.Windows.Forms.Label();
            this.numericBoxCubicCapacity = new Vehicle.Ui.CustomControls.NumericBox();
            this.labelCubicCapacity = new System.Windows.Forms.Label();
            this.labelErrorVehicleType = new System.Windows.Forms.Label();
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.labelVehicleType = new System.Windows.Forms.Label();
            this.labelErrorFuel = new System.Windows.Forms.Label();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelProductionYear = new System.Windows.Forms.Label();
            this.labelErrorModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelErrorManufacturer = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.formGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formGroup
            // 
            this.formGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.formGroup.Controls.Add(this.labelErrorProductionYear);
            this.formGroup.Controls.Add(this.labelErrorCC);
            this.formGroup.Controls.Add(this.numericBoxProductionYear);
            this.formGroup.Controls.Add(this.buttonCancel);
            this.formGroup.Controls.Add(this.buttonSubmit);
            this.formGroup.Controls.Add(this.labelErrorCubicCapacity);
            this.formGroup.Controls.Add(this.numericBoxCubicCapacity);
            this.formGroup.Controls.Add(this.labelCubicCapacity);
            this.formGroup.Controls.Add(this.labelErrorVehicleType);
            this.formGroup.Controls.Add(this.comboBoxVehicleType);
            this.formGroup.Controls.Add(this.labelVehicleType);
            this.formGroup.Controls.Add(this.labelErrorFuel);
            this.formGroup.Controls.Add(this.comboBoxFuel);
            this.formGroup.Controls.Add(this.labelFuel);
            this.formGroup.Controls.Add(this.labelProductionYear);
            this.formGroup.Controls.Add(this.labelErrorModel);
            this.formGroup.Controls.Add(this.textBoxModel);
            this.formGroup.Controls.Add(this.labelModel);
            this.formGroup.Controls.Add(this.labelErrorManufacturer);
            this.formGroup.Controls.Add(this.textBoxManufacturer);
            this.formGroup.Controls.Add(this.labelManufacturer);
            this.formGroup.Enabled = false;
            this.formGroup.Location = new System.Drawing.Point(12, 28);
            this.formGroup.Name = "formGroup";
            this.formGroup.Size = new System.Drawing.Size(396, 501);
            this.formGroup.TabIndex = 0;
            this.formGroup.TabStop = false;
            this.formGroup.Text = "Car data";
            // 
            // labelErrorProductionYear
            // 
            this.labelErrorProductionYear.AutoSize = true;
            this.labelErrorProductionYear.ForeColor = System.Drawing.Color.Red;
            this.labelErrorProductionYear.Location = new System.Drawing.Point(9, 198);
            this.labelErrorProductionYear.Name = "labelErrorProductionYear";
            this.labelErrorProductionYear.Size = new System.Drawing.Size(0, 15);
            this.labelErrorProductionYear.TabIndex = 30;
            // 
            // labelErrorCC
            // 
            this.labelErrorCC.AutoSize = true;
            this.labelErrorCC.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCC.Location = new System.Drawing.Point(9, 267);
            this.labelErrorCC.Name = "labelErrorCC";
            this.labelErrorCC.Size = new System.Drawing.Size(0, 15);
            this.labelErrorCC.TabIndex = 29;
            // 
            // numericBoxProductionYear
            // 
            this.numericBoxProductionYear.DoubleValue = null;
            this.numericBoxProductionYear.IntValue = null;
            this.numericBoxProductionYear.Location = new System.Drawing.Point(9, 172);
            this.numericBoxProductionYear.Name = "numericBoxProductionYear";
            this.numericBoxProductionYear.Size = new System.Drawing.Size(136, 23);
            this.numericBoxProductionYear.TabIndex = 28;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(6, 472);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(315, 472);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 26;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.OnSubmitClick);
            // 
            // labelErrorCubicCapacity
            // 
            this.labelErrorCubicCapacity.AutoSize = true;
            this.labelErrorCubicCapacity.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCubicCapacity.Location = new System.Drawing.Point(9, 267);
            this.labelErrorCubicCapacity.Name = "labelErrorCubicCapacity";
            this.labelErrorCubicCapacity.Size = new System.Drawing.Size(0, 15);
            this.labelErrorCubicCapacity.TabIndex = 25;
            // 
            // numericBoxCubicCapacity
            // 
            this.numericBoxCubicCapacity.DoubleValue = null;
            this.numericBoxCubicCapacity.IntValue = null;
            this.numericBoxCubicCapacity.Location = new System.Drawing.Point(9, 241);
            this.numericBoxCubicCapacity.Name = "numericBoxCubicCapacity";
            this.numericBoxCubicCapacity.Size = new System.Drawing.Size(136, 23);
            this.numericBoxCubicCapacity.TabIndex = 24;
            this.numericBoxCubicCapacity.Leave += new System.EventHandler(this.OnLostFocus);
            // 
            // labelCubicCapacity
            // 
            this.labelCubicCapacity.AutoSize = true;
            this.labelCubicCapacity.Location = new System.Drawing.Point(9, 223);
            this.labelCubicCapacity.Name = "labelCubicCapacity";
            this.labelCubicCapacity.Size = new System.Drawing.Size(87, 15);
            this.labelCubicCapacity.TabIndex = 23;
            this.labelCubicCapacity.Text = "Cubic Capacity";
            // 
            // labelErrorVehicleType
            // 
            this.labelErrorVehicleType.AutoSize = true;
            this.labelErrorVehicleType.ForeColor = System.Drawing.Color.Red;
            this.labelErrorVehicleType.Location = new System.Drawing.Point(9, 421);
            this.labelErrorVehicleType.Name = "labelErrorVehicleType";
            this.labelErrorVehicleType.Size = new System.Drawing.Size(0, 15);
            this.labelErrorVehicleType.TabIndex = 21;
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Location = new System.Drawing.Point(9, 391);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(199, 23);
            this.comboBoxVehicleType.TabIndex = 19;
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.Location = new System.Drawing.Point(9, 373);
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(71, 15);
            this.labelVehicleType.TabIndex = 20;
            this.labelVehicleType.Text = "Vehicle Type";
            // 
            // labelErrorFuel
            // 
            this.labelErrorFuel.AutoSize = true;
            this.labelErrorFuel.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFuel.Location = new System.Drawing.Point(9, 345);
            this.labelErrorFuel.Name = "labelErrorFuel";
            this.labelErrorFuel.Size = new System.Drawing.Size(0, 15);
            this.labelErrorFuel.TabIndex = 18;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(9, 315);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(199, 23);
            this.comboBoxFuel.TabIndex = 16;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(9, 297);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(56, 15);
            this.labelFuel.TabIndex = 17;
            this.labelFuel.Text = "Fuel Type";
            // 
            // labelProductionYear
            // 
            this.labelProductionYear.AutoSize = true;
            this.labelProductionYear.Location = new System.Drawing.Point(9, 154);
            this.labelProductionYear.Name = "labelProductionYear";
            this.labelProductionYear.Size = new System.Drawing.Size(91, 15);
            this.labelProductionYear.TabIndex = 7;
            this.labelProductionYear.Text = "Production Year";
            // 
            // labelErrorModel
            // 
            this.labelErrorModel.AutoSize = true;
            this.labelErrorModel.ForeColor = System.Drawing.Color.Red;
            this.labelErrorModel.Location = new System.Drawing.Point(9, 131);
            this.labelErrorModel.Name = "labelErrorModel";
            this.labelErrorModel.Size = new System.Drawing.Size(0, 15);
            this.labelErrorModel.TabIndex = 5;
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxModel.Location = new System.Drawing.Point(9, 105);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(136, 23);
            this.textBoxModel.TabIndex = 4;
            this.textBoxModel.Leave += new System.EventHandler(this.OnLostFocus);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(9, 87);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(41, 15);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Model";
            // 
            // labelErrorManufacturer
            // 
            this.labelErrorManufacturer.AutoSize = true;
            this.labelErrorManufacturer.ForeColor = System.Drawing.Color.Red;
            this.labelErrorManufacturer.Location = new System.Drawing.Point(9, 63);
            this.labelErrorManufacturer.Name = "labelErrorManufacturer";
            this.labelErrorManufacturer.Size = new System.Drawing.Size(0, 15);
            this.labelErrorManufacturer.TabIndex = 2;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxManufacturer.Location = new System.Drawing.Point(9, 37);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(136, 23);
            this.textBoxManufacturer.TabIndex = 1;
            this.textBoxManufacturer.Leave += new System.EventHandler(this.OnLostFocus);
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(9, 19);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(79, 15);
            this.labelManufacturer.TabIndex = 0;
            this.labelManufacturer.Text = "Manufacturer";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(414, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(633, 491);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.OnDataGridViewSelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripSeparator1,
            this.toolStripButtonDelete,
            this.toolStripSeparator2,
            this.toolStripButtonUpdate,
            this.SearchBox,
            this.toolStripLabel,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1059, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Add";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.OnAddClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdate.Text = "Edit";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.OnEditClick);
            // 
            // SearchBox
            // 
            this.SearchBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 25);
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnSearchKeyUp);
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel.Text = "Search:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // CarCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1059, 541);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.formGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1075, 580);
            this.MinimumSize = new System.Drawing.Size(1075, 580);
            this.Name = "CarCatalog";
            this.Text = "Autokatalógus";
            this.formGroup.ResumeLayout(false);
            this.formGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox formGroup;
        private DataGridView dataGridView;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonUpdate;
        private ToolStripTextBox SearchBox;
        private ToolStripLabel toolStripLabel;
        private Label labelErrorVehicleType;
        private ComboBox comboBoxVehicleType;
        private Label labelVehicleType;
        private Label labelErrorFuel;
        private ComboBox comboBoxFuel;
        private Label labelFuel;
        private Label labelProductionYear;
        private Label labelErrorModel;
        private TextBox textBoxModel;
        private Label labelModel;
        private Label labelErrorManufacturer;
        private TextBox textBoxManufacturer;
        private Label labelManufacturer;
        private Label labelErrorCubicCapacity;
        private CustomControls.NumericBox numericBoxCubicCapacity;
        private Label labelCubicCapacity;
        private Button buttonSubmit;
        private Button buttonCancel;
        private CustomControls.NumericBox numericBoxProductionYear;
        private Label labelErrorCC;
        private Label labelErrorProductionYear;
        private ToolStripSeparator toolStripSeparator3;
    }
}