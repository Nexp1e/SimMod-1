namespace SimMod_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelInputHeight = new System.Windows.Forms.Label();
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.inputAngle = new System.Windows.Forms.NumericUpDown();
            this.labelInputAngle = new System.Windows.Forms.Label();
            this.inputVelocity = new System.Windows.Forms.NumericUpDown();
            this.labelInputVelocity = new System.Windows.Forms.Label();
            this.inputSize = new System.Windows.Forms.NumericUpDown();
            this.labelInputSize = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.NumericUpDown();
            this.labelInputWeight = new System.Windows.Forms.Label();
            this.calculatedDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inputTimeStep = new System.Windows.Forms.NumericUpDown();
            this.labelInputTimeStep = new System.Windows.Forms.Label();
            this.timeStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatedDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTimeStep)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Location = new System.Drawing.Point(13, 93);
            this.chart1.Name = "chart1";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1079, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // labelInputHeight
            // 
            this.labelInputHeight.AutoSize = true;
            this.labelInputHeight.Location = new System.Drawing.Point(10, 17);
            this.labelInputHeight.Name = "labelInputHeight";
            this.labelInputHeight.Size = new System.Drawing.Size(38, 13);
            this.labelInputHeight.TabIndex = 2;
            this.labelInputHeight.Text = "Height";
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(54, 15);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(120, 20);
            this.inputHeight.TabIndex = 3;
            // 
            // inputAngle
            // 
            this.inputAngle.Location = new System.Drawing.Point(54, 41);
            this.inputAngle.Name = "inputAngle";
            this.inputAngle.Size = new System.Drawing.Size(120, 20);
            this.inputAngle.TabIndex = 5;
            this.inputAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelInputAngle
            // 
            this.labelInputAngle.AutoSize = true;
            this.labelInputAngle.Location = new System.Drawing.Point(10, 43);
            this.labelInputAngle.Name = "labelInputAngle";
            this.labelInputAngle.Size = new System.Drawing.Size(34, 13);
            this.labelInputAngle.TabIndex = 4;
            this.labelInputAngle.Text = "Angle";
            // 
            // inputVelocity
            // 
            this.inputVelocity.Location = new System.Drawing.Point(54, 67);
            this.inputVelocity.Name = "inputVelocity";
            this.inputVelocity.Size = new System.Drawing.Size(120, 20);
            this.inputVelocity.TabIndex = 7;
            this.inputVelocity.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelInputVelocity
            // 
            this.labelInputVelocity.AutoSize = true;
            this.labelInputVelocity.Location = new System.Drawing.Point(10, 69);
            this.labelInputVelocity.Name = "labelInputVelocity";
            this.labelInputVelocity.Size = new System.Drawing.Size(44, 13);
            this.labelInputVelocity.TabIndex = 6;
            this.labelInputVelocity.Text = "Velocity";
            // 
            // inputSize
            // 
            this.inputSize.Location = new System.Drawing.Point(281, 15);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(120, 20);
            this.inputSize.TabIndex = 9;
            this.inputSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelInputSize
            // 
            this.labelInputSize.AutoSize = true;
            this.labelInputSize.Location = new System.Drawing.Point(237, 17);
            this.labelInputSize.Name = "labelInputSize";
            this.labelInputSize.Size = new System.Drawing.Size(27, 13);
            this.labelInputSize.TabIndex = 8;
            this.labelInputSize.Text = "Size";
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(281, 43);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(120, 20);
            this.inputWeight.TabIndex = 11;
            this.inputWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelInputWeight
            // 
            this.labelInputWeight.AutoSize = true;
            this.labelInputWeight.Location = new System.Drawing.Point(237, 45);
            this.labelInputWeight.Name = "labelInputWeight";
            this.labelInputWeight.Size = new System.Drawing.Size(41, 13);
            this.labelInputWeight.TabIndex = 10;
            this.labelInputWeight.Text = "Weight";
            // 
            // calculatedDataGrid
            // 
            this.calculatedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculatedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStep,
            this.distance,
            this.maxHeightColumn,
            this.speedColumn});
            this.calculatedDataGrid.Location = new System.Drawing.Point(13, 399);
            this.calculatedDataGrid.Name = "calculatedDataGrid";
            this.calculatedDataGrid.RowHeadersWidth = 4;
            this.calculatedDataGrid.Size = new System.Drawing.Size(1079, 190);
            this.calculatedDataGrid.TabIndex = 12;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(993, 12);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(99, 75);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputTimeStep
            // 
            this.inputTimeStep.DecimalPlaces = 4;
            this.inputTimeStep.Location = new System.Drawing.Point(281, 69);
            this.inputTimeStep.Name = "inputTimeStep";
            this.inputTimeStep.Size = new System.Drawing.Size(120, 20);
            this.inputTimeStep.TabIndex = 15;
            this.inputTimeStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelInputTimeStep
            // 
            this.labelInputTimeStep.AutoSize = true;
            this.labelInputTimeStep.Location = new System.Drawing.Point(237, 71);
            this.labelInputTimeStep.Name = "labelInputTimeStep";
            this.labelInputTimeStep.Size = new System.Drawing.Size(29, 13);
            this.labelInputTimeStep.TabIndex = 14;
            this.labelInputTimeStep.Text = "Step";
            this.labelInputTimeStep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeStep
            // 
            this.timeStep.HeaderText = "Time step";
            this.timeStep.Name = "timeStep";
            // 
            // distance
            // 
            this.distance.HeaderText = "Distance";
            this.distance.Name = "distance";
            // 
            // maxHeightColumn
            // 
            this.maxHeightColumn.HeaderText = "Max height";
            this.maxHeightColumn.Name = "maxHeightColumn";
            // 
            // speedColumn
            // 
            this.speedColumn.HeaderText = "Speed at the end point";
            this.speedColumn.Name = "speedColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 601);
            this.Controls.Add(this.inputTimeStep);
            this.Controls.Add(this.labelInputTimeStep);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.calculatedDataGrid);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.labelInputWeight);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.labelInputSize);
            this.Controls.Add(this.inputVelocity);
            this.Controls.Add(this.labelInputVelocity);
            this.Controls.Add(this.inputAngle);
            this.Controls.Add(this.labelInputAngle);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.labelInputHeight);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatedDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTimeStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelInputHeight;
        private System.Windows.Forms.NumericUpDown inputHeight;
        private System.Windows.Forms.NumericUpDown inputAngle;
        private System.Windows.Forms.Label labelInputAngle;
        private System.Windows.Forms.NumericUpDown inputVelocity;
        private System.Windows.Forms.Label labelInputVelocity;
        private System.Windows.Forms.NumericUpDown inputSize;
        private System.Windows.Forms.Label labelInputSize;
        private System.Windows.Forms.NumericUpDown inputWeight;
        private System.Windows.Forms.Label labelInputWeight;
        private System.Windows.Forms.DataGridView calculatedDataGrid;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown inputTimeStep;
        private System.Windows.Forms.Label labelInputTimeStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedColumn;
    }
}

