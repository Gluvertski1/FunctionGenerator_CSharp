namespace FunctionGenerator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.devPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wavFormBox = new System.Windows.Forms.ComboBox();
            this.amplitude = new System.Windows.Forms.NumericUpDown();
            this.dcOffset = new System.Windows.Forms.NumericUpDown();
            this.dutyCycle = new System.Windows.Forms.NumericUpDown();
            this.frequencySelector = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputBtn = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // devPort
            // 
            this.devPort.FormattingEnabled = true;
            this.devPort.Location = new System.Drawing.Point(158, 48);
            this.devPort.Name = "devPort";
            this.devPort.Size = new System.Drawing.Size(118, 21);
            this.devPort.TabIndex = 0;
            this.devPort.Text = "Dev0/ao0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device / Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amplitdue (V)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "DC Offset (V)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Duty Cycle (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Frequency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Waveform";
            // 
            // wavFormBox
            // 
            this.wavFormBox.FormattingEnabled = true;
            this.wavFormBox.Items.AddRange(new object[] {
            "Sine",
            "Square",
            "Triangle",
            "SawTooth",
            "TTL"});
            this.wavFormBox.Location = new System.Drawing.Point(158, 319);
            this.wavFormBox.Name = "wavFormBox";
            this.wavFormBox.Size = new System.Drawing.Size(118, 21);
            this.wavFormBox.TabIndex = 7;
            this.wavFormBox.Text = "Sine";
            this.wavFormBox.SelectedIndexChanged += new System.EventHandler(this.wavFormBox_SelectedIndexChanged);
            // 
            // amplitude
            // 
            this.amplitude.Location = new System.Drawing.Point(216, 107);
            this.amplitude.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(60, 20);
            this.amplitude.TabIndex = 8;
            this.amplitude.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amplitude.ValueChanged += new System.EventHandler(this.amplitude_ValueChanged);
            // 
            // dcOffset
            // 
            this.dcOffset.Location = new System.Drawing.Point(216, 166);
            this.dcOffset.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dcOffset.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.dcOffset.Name = "dcOffset";
            this.dcOffset.Size = new System.Drawing.Size(60, 20);
            this.dcOffset.TabIndex = 9;
            this.dcOffset.ValueChanged += new System.EventHandler(this.dcOffset_ValueChanged);
            // 
            // dutyCycle
            // 
            this.dutyCycle.Location = new System.Drawing.Point(216, 225);
            this.dutyCycle.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.dutyCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dutyCycle.Name = "dutyCycle";
            this.dutyCycle.Size = new System.Drawing.Size(60, 20);
            this.dutyCycle.TabIndex = 10;
            this.dutyCycle.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.dutyCycle.ValueChanged += new System.EventHandler(this.dutyCycle_ValueChanged);
            // 
            // frequencySelector
            // 
            this.frequencySelector.Location = new System.Drawing.Point(216, 270);
            this.frequencySelector.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.frequencySelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frequencySelector.Name = "frequencySelector";
            this.frequencySelector.Size = new System.Drawing.Size(60, 20);
            this.frequencySelector.TabIndex = 11;
            this.frequencySelector.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frequencySelector.ValueChanged += new System.EventHandler(this.frequencySelector_ValueChanged);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(366, 23);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(595, 316);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // outputBtn
            // 
            this.outputBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBtn.Location = new System.Drawing.Point(366, 352);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(131, 28);
            this.outputBtn.TabIndex = 13;
            this.outputBtn.Text = "Output";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(535, 352);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(119, 27);
            this.Stop.TabIndex = 14;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(682, 352);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(120, 26);
            this.quit.TabIndex = 15;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 392);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.frequencySelector);
            this.Controls.Add(this.dutyCycle);
            this.Controls.Add(this.dcOffset);
            this.Controls.Add(this.amplitude);
            this.Controls.Add(this.wavFormBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devPort);
            this.Name = "Form1";
            this.Text = "Function Generator";
            ((System.ComponentModel.ISupportInitialize)(this.amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox devPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox wavFormBox;
        private System.Windows.Forms.NumericUpDown amplitude;
        private System.Windows.Forms.NumericUpDown dcOffset;
        private System.Windows.Forms.NumericUpDown dutyCycle;
        private System.Windows.Forms.NumericUpDown frequencySelector;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button quit;
    }
}

