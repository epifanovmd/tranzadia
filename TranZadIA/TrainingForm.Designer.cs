namespace TranZadIA
{
    partial class TrainingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridA = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridB = new System.Windows.Forms.DataGridView();
            this.MatrB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridC = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RowCount = new System.Windows.Forms.NumericUpDown();
            this.ColumnCount = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnModelType = new System.Windows.Forms.Button();
            this.lblModelType = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridDelta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOptPlan = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rbNW = new System.Windows.Forms.RadioButton();
            this.rbMinElem = new System.Windows.Forms.RadioButton();
            this.btnSolve = new System.Windows.Forms.Button();
            this.checkValue = new System.Windows.Forms.Button();
            this.checkDeltaZ = new System.Windows.Forms.Button();
            this.checkQ = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Qmin = new System.Windows.Forms.Label();
            this.txBZ = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.gridSupport = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCount)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDelta)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 516);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Условия задачи";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridC, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.RowCount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ColumnCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 481);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gridA
            // 
            this.gridA.AllowUserToAddRows = false;
            this.gridA.AllowUserToDeleteRows = false;
            this.gridA.AllowUserToResizeColumns = false;
            this.gridA.AllowUserToResizeRows = false;
            this.gridA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridA.ColumnHeadersHeight = 25;
            this.gridA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.gridA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridA.Location = new System.Drawing.Point(3, 67);
            this.gridA.Name = "gridA";
            this.gridA.RowHeadersWidth = 64;
            this.gridA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridA.Size = new System.Drawing.Size(164, 411);
            this.gridA.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Поставщики";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 98;
            // 
            // gridB
            // 
            this.gridB.AllowUserToAddRows = false;
            this.gridB.AllowUserToDeleteRows = false;
            this.gridB.AllowUserToResizeColumns = false;
            this.gridB.AllowUserToResizeRows = false;
            this.gridB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridB.ColumnHeadersHeight = 25;
            this.gridB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatrB});
            this.gridB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridB.Location = new System.Drawing.Point(173, 67);
            this.gridB.Name = "gridB";
            this.gridB.RowHeadersWidth = 64;
            this.gridB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridB.Size = new System.Drawing.Size(164, 411);
            this.gridB.TabIndex = 4;
            // 
            // MatrB
            // 
            this.MatrB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.MatrB.DefaultCellStyle = dataGridViewCellStyle2;
            this.MatrB.HeaderText = "Потребители";
            this.MatrB.Name = "MatrB";
            this.MatrB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MatrB.Width = 98;
            // 
            // gridC
            // 
            this.gridC.AllowUserToAddRows = false;
            this.gridC.AllowUserToDeleteRows = false;
            this.gridC.AllowUserToResizeColumns = false;
            this.gridC.AllowUserToResizeRows = false;
            this.gridC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridC.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridC.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridC.Location = new System.Drawing.Point(343, 67);
            this.gridC.Name = "gridC";
            this.gridC.RowHeadersWidth = 50;
            this.gridC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.gridC.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridC.Size = new System.Drawing.Size(584, 411);
            this.gridC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество поставщиков";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(173, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество потребителей";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(343, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(584, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тарифы";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RowCount
            // 
            this.RowCount.Location = new System.Drawing.Point(3, 35);
            this.RowCount.Name = "RowCount";
            this.RowCount.Size = new System.Drawing.Size(154, 22);
            this.RowCount.TabIndex = 1;
            this.RowCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowCount.ValueChanged += new System.EventHandler(this.RowCount_SelectedItemChanged);
            // 
            // ColumnCount
            // 
            this.ColumnCount.Location = new System.Drawing.Point(173, 35);
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.Size = new System.Drawing.Size(154, 22);
            this.ColumnCount.TabIndex = 2;
            this.ColumnCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnCount.ValueChanged += new System.EventHandler(this.RowCount_SelectedItemChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.48956F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.51044F));
            this.tableLayoutPanel5.Controls.Add(this.btnModelType, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblModelType, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(343, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(431, 26);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // btnModelType
            // 
            this.btnModelType.Location = new System.Drawing.Point(3, 3);
            this.btnModelType.Name = "btnModelType";
            this.btnModelType.Size = new System.Drawing.Size(75, 20);
            this.btnModelType.TabIndex = 6;
            this.btnModelType.Text = "Тип модели";
            this.btnModelType.UseVisualStyleBackColor = true;
            this.btnModelType.Click += new System.EventHandler(this.ModelType);
            // 
            // lblModelType
            // 
            this.lblModelType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelType.AutoSize = true;
            this.lblModelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModelType.Location = new System.Drawing.Point(257, 5);
            this.lblModelType.Name = "lblModelType";
            this.lblModelType.Size = new System.Drawing.Size(0, 16);
            this.lblModelType.TabIndex = 1;
            this.lblModelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Решение";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.29947F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.70053F));
            this.tableLayoutPanel2.Controls.Add(this.gridDelta, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOptPlan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.gridSupport, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.55556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(930, 481);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gridDelta
            // 
            this.gridDelta.AllowUserToAddRows = false;
            this.gridDelta.AllowUserToDeleteRows = false;
            this.gridDelta.AllowUserToResizeColumns = false;
            this.gridDelta.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDelta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridDelta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDelta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "null";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDelta.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridDelta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDelta.EnableHeadersVisualStyles = false;
            this.gridDelta.Location = new System.Drawing.Point(675, 35);
            this.gridDelta.MultiSelect = false;
            this.gridDelta.Name = "gridDelta";
            this.gridDelta.RowHeadersWidth = 85;
            this.gridDelta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridDelta.Size = new System.Drawing.Size(252, 328);
            this.gridDelta.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "Оценки свободных клеток";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 166;
            // 
            // lblOptPlan
            // 
            this.lblOptPlan.AutoSize = true;
            this.lblOptPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOptPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOptPlan.ForeColor = System.Drawing.Color.Red;
            this.lblOptPlan.Location = new System.Drawing.Point(3, 0);
            this.lblOptPlan.Name = "lblOptPlan";
            this.lblOptPlan.Size = new System.Drawing.Size(666, 32);
            this.lblOptPlan.TabIndex = 3;
            this.lblOptPlan.Text = "Оптимальный план найден";
            this.lblOptPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptPlan.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 369);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(666, 109);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel4.Controls.Add(this.rbNW, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbMinElem, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSolve, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkValue, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkDeltaZ, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkQ, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(660, 103);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rbNW
            // 
            this.rbNW.AutoSize = true;
            this.rbNW.Checked = true;
            this.rbNW.Location = new System.Drawing.Point(3, 3);
            this.rbNW.Name = "rbNW";
            this.rbNW.Size = new System.Drawing.Size(225, 20);
            this.rbNW.TabIndex = 0;
            this.rbNW.TabStop = true;
            this.rbNW.Text = "Метод северо-западного угла";
            this.rbNW.UseVisualStyleBackColor = true;
            // 
            // rbMinElem
            // 
            this.rbMinElem.AutoSize = true;
            this.rbMinElem.Location = new System.Drawing.Point(3, 37);
            this.rbMinElem.Name = "rbMinElem";
            this.rbMinElem.Size = new System.Drawing.Size(233, 20);
            this.rbMinElem.TabIndex = 1;
            this.rbMinElem.Text = "Метод минимального элемента";
            this.rbMinElem.UseVisualStyleBackColor = true;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(3, 71);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 21);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // checkValue
            // 
            this.checkValue.Location = new System.Drawing.Point(279, 3);
            this.checkValue.Name = "checkValue";
            this.checkValue.Size = new System.Drawing.Size(156, 23);
            this.checkValue.TabIndex = 8;
            this.checkValue.Text = "Проверить значения";
            this.checkValue.UseVisualStyleBackColor = true;
            this.checkValue.Click += new System.EventHandler(this.checkValue_Click);
            // 
            // checkDeltaZ
            // 
            this.checkDeltaZ.Location = new System.Drawing.Point(441, 3);
            this.checkDeltaZ.Name = "checkDeltaZ";
            this.checkDeltaZ.Size = new System.Drawing.Size(216, 23);
            this.checkDeltaZ.TabIndex = 9;
            this.checkDeltaZ.Text = "Проверить дэльта и Z";
            this.checkDeltaZ.UseVisualStyleBackColor = true;
            this.checkDeltaZ.Visible = false;
            this.checkDeltaZ.Click += new System.EventHandler(this.checkDeltaZ_Click);
            // 
            // checkQ
            // 
            this.checkQ.Location = new System.Drawing.Point(441, 37);
            this.checkQ.Name = "checkQ";
            this.checkQ.Size = new System.Drawing.Size(216, 23);
            this.checkQ.TabIndex = 9;
            this.checkQ.Text = "Провверить цикл пересчета";
            this.checkQ.UseVisualStyleBackColor = true;
            this.checkQ.Visible = false;
            this.checkQ.Click += new System.EventHandler(this.checkQ_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.Controls.Add(this.Qmin, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txBZ, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblSum, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(675, 369);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(250, 60);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // Qmin
            // 
            this.Qmin.AutoSize = true;
            this.Qmin.Location = new System.Drawing.Point(3, 0);
            this.Qmin.Name = "Qmin";
            this.Qmin.Size = new System.Drawing.Size(18, 16);
            this.Qmin.TabIndex = 8;
            this.Qmin.Text = "Q";
            this.Qmin.Visible = false;
            // 
            // txBZ
            // 
            this.txBZ.Location = new System.Drawing.Point(153, 33);
            this.txBZ.Name = "txBZ";
            this.txBZ.Size = new System.Drawing.Size(94, 22);
            this.txBZ.TabIndex = 9;
            // 
            // lblSum
            // 
            this.lblSum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSum.AutoSize = true;
            this.lblSum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSum.Location = new System.Drawing.Point(121, 37);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(26, 16);
            this.lblSum.TabIndex = 7;
            this.lblSum.Text = "Z =";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gridSupport
            // 
            this.gridSupport.AllowUserToAddRows = false;
            this.gridSupport.AllowUserToDeleteRows = false;
            this.gridSupport.AllowUserToResizeColumns = false;
            this.gridSupport.AllowUserToResizeRows = false;
            this.gridSupport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupport.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSupport.Location = new System.Drawing.Point(3, 35);
            this.gridSupport.Name = "gridSupport";
            this.gridSupport.RowHeadersWidth = 80;
            this.gridSupport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridSupport.RowTemplate.Height = 40;
            this.gridSupport.Size = new System.Drawing.Size(666, 328);
            this.gridSupport.TabIndex = 10;
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тренажер ТЗ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCount)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDelta)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gridA;
        private System.Windows.Forms.DataGridView gridB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatrB;
        private System.Windows.Forms.DataGridView gridC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown RowCount;
        private System.Windows.Forms.NumericUpDown ColumnCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnModelType;
        private System.Windows.Forms.Label lblModelType;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView gridDelta;
        private System.Windows.Forms.Label lblOptPlan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rbNW;
        private System.Windows.Forms.RadioButton rbMinElem;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label Qmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView gridSupport;
        private System.Windows.Forms.Button checkValue;
        private System.Windows.Forms.Button checkDeltaZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txBZ;
        private System.Windows.Forms.Button checkQ;
    }
}