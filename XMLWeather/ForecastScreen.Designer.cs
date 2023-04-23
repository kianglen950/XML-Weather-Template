namespace XMLWeather
{
    partial class ForecastScreen
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
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min1Output = new System.Windows.Forms.Label();
            this.min1Label = new System.Windows.Forms.Label();
            this.max1Output = new System.Windows.Forms.Label();
            this.max1Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date1Output = new System.Windows.Forms.Label();
            this.forecastIconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.forecastIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(142, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 11);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1Output
            // 
            this.min1Output.BackColor = System.Drawing.Color.Transparent;
            this.min1Output.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1Output.Location = new System.Drawing.Point(203, 85);
            this.min1Output.Name = "min1Output";
            this.min1Output.Size = new System.Drawing.Size(22, 13);
            this.min1Output.TabIndex = 48;
            // 
            // min1Label
            // 
            this.min1Label.AutoSize = true;
            this.min1Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1Label.ForeColor = System.Drawing.Color.White;
            this.min1Label.Location = new System.Drawing.Point(94, 85);
            this.min1Label.Name = "min1Label";
            this.min1Label.Size = new System.Drawing.Size(103, 13);
            this.min1Label.TabIndex = 46;
            this.min1Label.Text = " Min Temperature";
            // 
            // max1Output
            // 
            this.max1Output.BackColor = System.Drawing.Color.Transparent;
            this.max1Output.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1Output.Location = new System.Drawing.Point(203, 55);
            this.max1Output.Name = "max1Output";
            this.max1Output.Size = new System.Drawing.Size(22, 13);
            this.max1Output.TabIndex = 45;
            // 
            // max1Label
            // 
            this.max1Label.AutoSize = true;
            this.max1Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1Label.ForeColor = System.Drawing.Color.White;
            this.max1Label.Location = new System.Drawing.Point(100, 55);
            this.max1Label.Name = "max1Label";
            this.max1Label.Size = new System.Drawing.Size(97, 13);
            this.max1Label.TabIndex = 44;
            this.max1Label.Text = "Max Temperature";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 30);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1Output
            // 
            this.date1Output.AutoSize = true;
            this.date1Output.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1Output.ForeColor = System.Drawing.Color.White;
            this.date1Output.Location = new System.Drawing.Point(3, 55);
            this.date1Output.Name = "date1Output";
            this.date1Output.Size = new System.Drawing.Size(31, 13);
            this.date1Output.TabIndex = 64;
            this.date1Output.Text = "Date";
            // 
            // forecastIconBox
            // 
            this.forecastIconBox.Location = new System.Drawing.Point(40, 38);
            this.forecastIconBox.Name = "forecastIconBox";
            this.forecastIconBox.Size = new System.Drawing.Size(53, 92);
            this.forecastIconBox.TabIndex = 65;
            this.forecastIconBox.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.forecastIconBox);
            this.Controls.Add(this.date1Output);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min1Output);
            this.Controls.Add(this.min1Label);
            this.Controls.Add(this.max1Output);
            this.Controls.Add(this.max1Label);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(685, 418);
            ((System.ComponentModel.ISupportInitialize)(this.forecastIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1Output;
        private System.Windows.Forms.Label min1Label;
        private System.Windows.Forms.Label max1Output;
        private System.Windows.Forms.Label max1Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date1Output;
        private System.Windows.Forms.PictureBox forecastIconBox;
    }
}
