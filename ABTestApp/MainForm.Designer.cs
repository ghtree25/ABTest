namespace ABTestApp
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dvLiveData = new DataGridView();
            Time = new DataGridViewTextBoxColumn();
            USD = new DataGridViewTextBoxColumn();
            GBP = new DataGridViewTextBoxColumn();
            EUR = new DataGridViewTextBoxColumn();
            CZK = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            laMessage = new Label();
            btSaveLive = new Button();
            tabPage2 = new TabPage();
            dvSavedData = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            columnTime = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            cZKDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            priceDataBindingSource = new BindingSource(components);
            panel2 = new Panel();
            btDelete = new Button();
            btSave = new Button();
            tabPage3 = new TabPage();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            rbSavedData = new RadioButton();
            rbLiveData = new RadioButton();
            cbCurrency = new ComboBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvLiveData).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvSavedData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceDataBindingSource).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dvLiveData);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Live Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvLiveData
            // 
            dvLiveData.AllowUserToAddRows = false;
            dvLiveData.AllowUserToDeleteRows = false;
            dvLiveData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvLiveData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvLiveData.Columns.AddRange(new DataGridViewColumn[] { Time, USD, GBP, EUR, CZK });
            dvLiveData.Dock = DockStyle.Fill;
            dvLiveData.Location = new Point(3, 3);
            dvLiveData.Name = "dvLiveData";
            dvLiveData.ReadOnly = true;
            dvLiveData.Size = new Size(786, 366);
            dvLiveData.TabIndex = 0;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 58;
            // 
            // USD
            // 
            USD.HeaderText = "USD";
            USD.Name = "USD";
            USD.ReadOnly = true;
            USD.Width = 54;
            // 
            // GBP
            // 
            GBP.HeaderText = "GBP";
            GBP.Name = "GBP";
            GBP.ReadOnly = true;
            GBP.Width = 54;
            // 
            // EUR
            // 
            EUR.HeaderText = "EUR";
            EUR.Name = "EUR";
            EUR.ReadOnly = true;
            EUR.Width = 53;
            // 
            // CZK
            // 
            CZK.HeaderText = "CZK";
            CZK.Name = "CZK";
            CZK.ReadOnly = true;
            CZK.Width = 54;
            // 
            // panel1
            // 
            panel1.Controls.Add(laMessage);
            panel1.Controls.Add(btSaveLive);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 369);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 50);
            panel1.TabIndex = 3;
            // 
            // laMessage
            // 
            laMessage.AutoSize = true;
            laMessage.Location = new Point(134, 19);
            laMessage.Name = "laMessage";
            laMessage.Size = new Size(0, 15);
            laMessage.TabIndex = 4;
            // 
            // btSaveLive
            // 
            btSaveLive.Location = new Point(16, 15);
            btSaveLive.Name = "btSaveLive";
            btSaveLive.Size = new Size(75, 23);
            btSaveLive.TabIndex = 3;
            btSaveLive.Text = "Save";
            btSaveLive.UseVisualStyleBackColor = true;
            btSaveLive.Click += btSaveLive_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dvSavedData);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Saved Data";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvSavedData
            // 
            dvSavedData.AllowUserToAddRows = false;
            dvSavedData.AllowUserToDeleteRows = false;
            dvSavedData.AutoGenerateColumns = false;
            dvSavedData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvSavedData.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, columnTime, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, cZKDataGridViewTextBoxColumn, dataGridViewTextBoxColumn5 });
            dvSavedData.DataSource = priceDataBindingSource;
            dvSavedData.Dock = DockStyle.Fill;
            dvSavedData.Location = new Point(3, 3);
            dvSavedData.Name = "dvSavedData";
            dvSavedData.Size = new Size(786, 366);
            dvSavedData.TabIndex = 0;
            dvSavedData.CellValueChanged += dvSavedData_CellValueChanged;
            dvSavedData.SelectionChanged += dvSavedData_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // columnTime
            // 
            columnTime.DataPropertyName = "Time";
            columnTime.HeaderText = "Time";
            columnTime.Name = "columnTime";
            columnTime.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "USD";
            dataGridViewTextBoxColumn2.HeaderText = "USD";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "EUR";
            dataGridViewTextBoxColumn3.HeaderText = "EUR";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "GBP";
            dataGridViewTextBoxColumn4.HeaderText = "GBP";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cZKDataGridViewTextBoxColumn
            // 
            cZKDataGridViewTextBoxColumn.DataPropertyName = "CZK";
            cZKDataGridViewTextBoxColumn.HeaderText = "CZK";
            cZKDataGridViewTextBoxColumn.Name = "cZKDataGridViewTextBoxColumn";
            cZKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Note";
            dataGridViewTextBoxColumn5.HeaderText = "Note";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // priceDataBindingSource
            // 
            priceDataBindingSource.DataSource = typeof(PriceData);
            // 
            // panel2
            // 
            panel2.Controls.Add(btDelete);
            panel2.Controls.Add(btSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 50);
            panel2.TabIndex = 3;
            // 
            // btDelete
            // 
            btDelete.Enabled = false;
            btDelete.Location = new Point(109, 15);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 3;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btSave
            // 
            btSave.Enabled = false;
            btSave.Location = new Point(16, 15);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 2;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chart);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Chart";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(3, 3);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Rate";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart.Series.Add(series1);
            chart.Size = new Size(651, 416);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(cbCurrency);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(654, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(135, 416);
            panel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSavedData);
            groupBox1.Controls.Add(rbLiveData);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 86);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // rbSavedData
            // 
            rbSavedData.AutoSize = true;
            rbSavedData.Location = new Point(6, 47);
            rbSavedData.Name = "rbSavedData";
            rbSavedData.Size = new Size(82, 19);
            rbSavedData.TabIndex = 7;
            rbSavedData.Text = "Saved data";
            rbSavedData.UseVisualStyleBackColor = true;
            // 
            // rbLiveData
            // 
            rbLiveData.AutoSize = true;
            rbLiveData.Checked = true;
            rbLiveData.Location = new Point(6, 22);
            rbLiveData.Name = "rbLiveData";
            rbLiveData.Size = new Size(72, 19);
            rbLiveData.TabIndex = 6;
            rbLiveData.TabStop = true;
            rbLiveData.Text = "Live data";
            rbLiveData.UseVisualStyleBackColor = true;
            rbLiveData.CheckedChanged += rbLiveData_CheckedChanged;
            // 
            // cbCurrency
            // 
            cbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Items.AddRange(new object[] { "USD", "GBP", "EUR", "CZK" });
            cbCurrency.Location = new Point(16, 112);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(98, 23);
            cbCurrency.TabIndex = 4;
            cbCurrency.SelectedIndexChanged += cbCurrency_SelectedIndexChanged;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MinimumSize = new Size(400, 300);
            Name = "MainForm";
            Text = "BTC Price";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvLiveData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvSavedData).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceDataBindingSource).EndInit();
            panel2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dvSavedData;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uSDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eURDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gBPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridView dvLiveData;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn USD;
        private DataGridViewTextBoxColumn GBP;
        private DataGridViewTextBoxColumn EUR;
        private DataGridViewTextBoxColumn CZK;
        private Panel panel1;
        private Button btSaveLive;
        private BindingSource priceDataBindingSource;
        private Panel panel2;
        private Button btDelete;
        private Button btSave;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn columnTime;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn cZKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TabPage tabPage3;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Label laMessage;
        private Panel panel3;
        private ComboBox cbCurrency;
        private GroupBox groupBox1;
        private RadioButton rbSavedData;
        private RadioButton rbLiveData;
    }
}
