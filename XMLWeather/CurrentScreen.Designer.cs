namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.currentOutput = new System.Windows.Forms.Label();
            this.currentConditionLabel = new System.Windows.Forms.Label();
            this.windOutput = new System.Windows.Forms.Label();
            this.sunRiseOutput = new System.Windows.Forms.Label();
            this.sunSetOutput = new System.Windows.Forms.Label();
            this.updateOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(41, 52);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(154, 28);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(104, 261);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(238, 38);
            this.maxOutput.TabIndex = 32;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(41, 261);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(60, 33);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "Max";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(104, 215);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(189, 36);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(41, 215);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(60, 33);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Min";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(31, 173);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(300, 33);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(575, 5);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateOutput
            // 
            this.dateOutput.AutoSize = true;
            this.dateOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.White;
            this.dateOutput.Location = new System.Drawing.Point(36, 105);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(90, 33);
            this.dateOutput.TabIndex = 43;
            this.dateOutput.Text = "Date:";
            // 
            // humidityOutput
            // 
            this.humidityOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityOutput.ForeColor = System.Drawing.Color.White;
            this.humidityOutput.Location = new System.Drawing.Point(31, 299);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(242, 61);
            this.humidityOutput.TabIndex = 45;
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(550, 36);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(108, 119);
            this.iconBox.TabIndex = 47;
            this.iconBox.TabStop = false;
            // 
            // currentOutput
            // 
            this.currentOutput.AutoSize = true;
            this.currentOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(245, 173);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(0, 33);
            this.currentOutput.TabIndex = 48;
            // 
            // currentConditionLabel
            // 
            this.currentConditionLabel.AutoSize = true;
            this.currentConditionLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentConditionLabel.ForeColor = System.Drawing.Color.White;
            this.currentConditionLabel.Location = new System.Drawing.Point(213, 61);
            this.currentConditionLabel.Name = "currentConditionLabel";
            this.currentConditionLabel.Size = new System.Drawing.Size(0, 33);
            this.currentConditionLabel.TabIndex = 49;
            // 
            // windOutput
            // 
            this.windOutput.AutoSize = true;
            this.windOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windOutput.ForeColor = System.Drawing.Color.White;
            this.windOutput.Location = new System.Drawing.Point(41, 133);
            this.windOutput.Name = "windOutput";
            this.windOutput.Size = new System.Drawing.Size(0, 33);
            this.windOutput.TabIndex = 50;
            // 
            // sunRiseOutput
            // 
            this.sunRiseOutput.AutoSize = true;
            this.sunRiseOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunRiseOutput.ForeColor = System.Drawing.Color.White;
            this.sunRiseOutput.Location = new System.Drawing.Point(263, 228);
            this.sunRiseOutput.Name = "sunRiseOutput";
            this.sunRiseOutput.Size = new System.Drawing.Size(0, 33);
            this.sunRiseOutput.TabIndex = 51;
            // 
            // sunSetOutput
            // 
            this.sunSetOutput.AutoSize = true;
            this.sunSetOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunSetOutput.ForeColor = System.Drawing.Color.White;
            this.sunSetOutput.Location = new System.Drawing.Point(263, 284);
            this.sunSetOutput.Name = "sunSetOutput";
            this.sunSetOutput.Size = new System.Drawing.Size(0, 33);
            this.sunSetOutput.TabIndex = 52;
            // 
            // updateOutput
            // 
            this.updateOutput.AutoSize = true;
            this.updateOutput.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOutput.ForeColor = System.Drawing.Color.White;
            this.updateOutput.Location = new System.Drawing.Point(263, 347);
            this.updateOutput.Name = "updateOutput";
            this.updateOutput.Size = new System.Drawing.Size(0, 33);
            this.updateOutput.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 47);
            this.label3.TabIndex = 54;
            this.label3.Text = "Today";
            // 
            // cityInput
            // 
            this.cityInput.BackColor = System.Drawing.Color.White;
            this.cityInput.Location = new System.Drawing.Point(192, 12);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 20);
            this.cityInput.TabIndex = 55;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.SkyBlue;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(312, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 56;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateOutput);
            this.Controls.Add(this.sunSetOutput);
            this.Controls.Add(this.sunRiseOutput);
            this.Controls.Add(this.windOutput);
            this.Controls.Add(this.currentConditionLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(685, 418);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label currentConditionLabel;
        private System.Windows.Forms.Label windOutput;
        private System.Windows.Forms.Label sunRiseOutput;
        private System.Windows.Forms.Label sunSetOutput;
        private System.Windows.Forms.Label updateOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button searchButton;
    }
}
