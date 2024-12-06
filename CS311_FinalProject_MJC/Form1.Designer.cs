namespace CS311_FinalProject_MJC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            txtFrom1 = new TextBox();
            rdoMetersFrom = new RadioButton();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rdoFromOunces = new RadioButton();
            rdoFromPounds = new RadioButton();
            rdoFromGrams = new RadioButton();
            rdoFromFahrenheit = new RadioButton();
            rdoFromKilograms = new RadioButton();
            rdoFromMiles = new RadioButton();
            rdoFromCelsius = new RadioButton();
            rdoFeetFrom = new RadioButton();
            rdoFromKilometers = new RadioButton();
            txtResult1 = new TextBox();
            pictureBox1 = new PictureBox();
            lblResult1 = new Label();
            lblFrom1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblFormula = new Label();
            panel1 = new Panel();
            label9 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(222, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit Converter";
            // 
            // txtFrom1
            // 
            txtFrom1.Location = new Point(56, 200);
            txtFrom1.Name = "txtFrom1";
            txtFrom1.PlaceholderText = "Number to be Converted";
            txtFrom1.Size = new Size(175, 27);
            txtFrom1.TabIndex = 1;
            txtFrom1.TextChanged += txtFrom1_TextChanged;
            // 
            // rdoMetersFrom
            // 
            rdoMetersFrom.AutoSize = true;
            rdoMetersFrom.Location = new Point(6, 26);
            rdoMetersFrom.Name = "rdoMetersFrom";
            rdoMetersFrom.Size = new Size(75, 24);
            rdoMetersFrom.TabIndex = 2;
            rdoMetersFrom.TabStop = true;
            rdoMetersFrom.Text = "Meters";
            rdoMetersFrom.UseVisualStyleBackColor = true;
            rdoMetersFrom.CheckedChanged += rdoMetersFrom_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdoFromOunces);
            groupBox1.Controls.Add(rdoFromPounds);
            groupBox1.Controls.Add(rdoFromGrams);
            groupBox1.Controls.Add(rdoFromFahrenheit);
            groupBox1.Controls.Add(rdoFromKilograms);
            groupBox1.Controls.Add(rdoFromMiles);
            groupBox1.Controls.Add(rdoFromCelsius);
            groupBox1.Controls.Add(rdoFeetFrom);
            groupBox1.Controls.Add(rdoFromKilometers);
            groupBox1.Controls.Add(rdoMetersFrom);
            groupBox1.Location = new Point(12, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 233);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 195);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 25;
            label5.Text = "<--->";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 152);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 24;
            label4.Text = "<--->";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 112);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 23;
            label3.Text = "<--->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 68);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 22;
            label2.Text = "<--->";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 21;
            label1.Text = "<--->";
            // 
            // rdoFromOunces
            // 
            rdoFromOunces.AutoSize = true;
            rdoFromOunces.Location = new Point(161, 195);
            rdoFromOunces.Name = "rdoFromOunces";
            rdoFromOunces.Size = new Size(78, 24);
            rdoFromOunces.TabIndex = 3;
            rdoFromOunces.TabStop = true;
            rdoFromOunces.Text = "Ounces";
            rdoFromOunces.UseVisualStyleBackColor = true;
            rdoFromOunces.CheckedChanged += rdoFromOunces_CheckedChanged;
            // 
            // rdoFromPounds
            // 
            rdoFromPounds.AutoSize = true;
            rdoFromPounds.Location = new Point(161, 152);
            rdoFromPounds.Name = "rdoFromPounds";
            rdoFromPounds.Size = new Size(77, 24);
            rdoFromPounds.TabIndex = 3;
            rdoFromPounds.TabStop = true;
            rdoFromPounds.Text = "Pounds";
            rdoFromPounds.UseVisualStyleBackColor = true;
            rdoFromPounds.CheckedChanged += rdoFromPounds_CheckedChanged;
            // 
            // rdoFromGrams
            // 
            rdoFromGrams.AutoSize = true;
            rdoFromGrams.Location = new Point(6, 195);
            rdoFromGrams.Name = "rdoFromGrams";
            rdoFromGrams.Size = new Size(72, 24);
            rdoFromGrams.TabIndex = 2;
            rdoFromGrams.TabStop = true;
            rdoFromGrams.Text = "Grams";
            rdoFromGrams.UseVisualStyleBackColor = true;
            rdoFromGrams.CheckedChanged += rdoFromGrams_CheckedChanged;
            // 
            // rdoFromFahrenheit
            // 
            rdoFromFahrenheit.AutoSize = true;
            rdoFromFahrenheit.Location = new Point(161, 112);
            rdoFromFahrenheit.Name = "rdoFromFahrenheit";
            rdoFromFahrenheit.Size = new Size(98, 24);
            rdoFromFahrenheit.TabIndex = 3;
            rdoFromFahrenheit.TabStop = true;
            rdoFromFahrenheit.Text = "Fahrenheit";
            rdoFromFahrenheit.UseVisualStyleBackColor = true;
            rdoFromFahrenheit.CheckedChanged += rdoFromFahrenheit_CheckedChanged;
            // 
            // rdoFromKilograms
            // 
            rdoFromKilograms.AutoSize = true;
            rdoFromKilograms.Location = new Point(6, 152);
            rdoFromKilograms.Name = "rdoFromKilograms";
            rdoFromKilograms.Size = new Size(97, 24);
            rdoFromKilograms.TabIndex = 2;
            rdoFromKilograms.TabStop = true;
            rdoFromKilograms.Text = "Kilograms";
            rdoFromKilograms.UseVisualStyleBackColor = true;
            rdoFromKilograms.CheckedChanged += rdoFromKilograms_CheckedChanged;
            // 
            // rdoFromMiles
            // 
            rdoFromMiles.AutoSize = true;
            rdoFromMiles.Location = new Point(161, 68);
            rdoFromMiles.Name = "rdoFromMiles";
            rdoFromMiles.Size = new Size(65, 24);
            rdoFromMiles.TabIndex = 3;
            rdoFromMiles.TabStop = true;
            rdoFromMiles.Text = "Miles";
            rdoFromMiles.UseVisualStyleBackColor = true;
            rdoFromMiles.CheckedChanged += rdoFromMiles_CheckedChanged;
            // 
            // rdoFromCelsius
            // 
            rdoFromCelsius.AutoSize = true;
            rdoFromCelsius.Location = new Point(6, 112);
            rdoFromCelsius.Name = "rdoFromCelsius";
            rdoFromCelsius.Size = new Size(75, 24);
            rdoFromCelsius.TabIndex = 2;
            rdoFromCelsius.TabStop = true;
            rdoFromCelsius.Text = "Celsius";
            rdoFromCelsius.UseVisualStyleBackColor = true;
            rdoFromCelsius.CheckedChanged += rdoFromCelsius_CheckedChanged;
            // 
            // rdoFeetFrom
            // 
            rdoFeetFrom.AutoSize = true;
            rdoFeetFrom.Location = new Point(161, 26);
            rdoFeetFrom.Name = "rdoFeetFrom";
            rdoFeetFrom.Size = new Size(58, 24);
            rdoFeetFrom.TabIndex = 3;
            rdoFeetFrom.TabStop = true;
            rdoFeetFrom.Text = "Feet";
            rdoFeetFrom.UseVisualStyleBackColor = true;
            rdoFeetFrom.CheckedChanged += rdoFeetFrom_CheckedChanged;
            // 
            // rdoFromKilometers
            // 
            rdoFromKilometers.AutoSize = true;
            rdoFromKilometers.Location = new Point(6, 68);
            rdoFromKilometers.Name = "rdoFromKilometers";
            rdoFromKilometers.Size = new Size(101, 24);
            rdoFromKilometers.TabIndex = 2;
            rdoFromKilometers.TabStop = true;
            rdoFromKilometers.Text = "Kilometers";
            rdoFromKilometers.UseVisualStyleBackColor = true;
            rdoFromKilometers.CheckedChanged += rdoFromKilometers_CheckedChanged;
            // 
            // txtResult1
            // 
            txtResult1.Location = new Point(466, 200);
            txtResult1.Name = "txtResult1";
            txtResult1.PlaceholderText = "                Result";
            txtResult1.ReadOnly = true;
            txtResult1.Size = new Size(182, 27);
            txtResult1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(330, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 77);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblResult1
            // 
            lblResult1.AutoSize = true;
            lblResult1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult1.Location = new Point(654, 204);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(0, 23);
            lblResult1.TabIndex = 4;
            // 
            // lblFrom1
            // 
            lblFrom1.AutoSize = true;
            lblFrom1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrom1.Location = new Point(237, 204);
            lblFrom1.Name = "lblFrom1";
            lblFrom1.Size = new Size(0, 23);
            lblFrom1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 15);
            label6.Name = "label6";
            label6.Size = new Size(576, 20);
            label6.TabIndex = 21;
            label6.Text = "Please enter a number to be converted and select a unit of measurement from the list.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 44);
            label7.Name = "label7";
            label7.Size = new Size(696, 20);
            label7.TabIndex = 22;
            label7.Text = "*Your number will be converted from the unit chosen to the corresponding unit across from it in the list.*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(512, 251);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 23;
            label8.Text = "Formula";
            // 
            // lblFormula
            // 
            lblFormula.AutoSize = true;
            lblFormula.Location = new Point(40, 21);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(0, 20);
            lblFormula.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblFormula);
            panel1.Location = new Point(434, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 73);
            label9.Name = "label9";
            label9.Size = new Size(199, 20);
            label9.TabIndex = 26;
            label9.Text = "**Enter only number values**";
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(12, 542);
            panel3.Name = "panel3";
            panel3.Size = new Size(724, 101);
            panel3.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 519);
            label10.Name = "label10";
            label10.Size = new Size(108, 23);
            label10.TabIndex = 26;
            label10.Text = "Instructions:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 655);
            Controls.Add(label10);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(lblFrom1);
            Controls.Add(lblResult1);
            Controls.Add(pictureBox1);
            Controls.Add(txtResult1);
            Controls.Add(groupBox1);
            Controls.Add(txtFrom1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Unit Converter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtFrom1;
        private RadioButton rdoMetersFrom;
        private GroupBox groupBox1;
        private RadioButton rdoFeetFrom;
        private TextBox txtResult1;
        private RadioButton rdoFromMiles;
        private RadioButton rdoFromKilometers;
        private RadioButton rdoFromFahrenheit;
        private RadioButton rdoFromCelsius;
        private RadioButton rdoFromPounds;
        private RadioButton rdoFromKilograms;
        private RadioButton rdoFromOunces;
        private RadioButton rdoFromGrams;
        private PictureBox pictureBox1;
        private Label lblResult1;
        private Label lblFrom1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblFormula;
        private Panel panel1;
        private Label label9;
        private Panel panel3;
        private Label label10;
    }
}
