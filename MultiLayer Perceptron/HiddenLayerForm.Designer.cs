namespace MultiLayer_Perceptron
{
    partial class HiddenLayerForm
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
            this.globalInputGroupBox = new System.Windows.Forms.GroupBox();
            this.globalInputComboBox = new System.Windows.Forms.ComboBox();
            this.activationGroupBox = new System.Windows.Forms.GroupBox();
            this.aUpDown = new System.Windows.Forms.NumericUpDown();
            this.gUpDown = new System.Windows.Forms.NumericUpDown();
            this.aLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.thetaUpDown = new System.Windows.Forms.NumericUpDown();
            this.thetaLabel = new System.Windows.Forms.Label();
            this.activationComboBox = new System.Windows.Forms.ComboBox();
            this.binaryCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.globalInputGroupBox.SuspendLayout();
            this.activationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalInputGroupBox
            // 
            this.globalInputGroupBox.Controls.Add(this.globalInputComboBox);
            this.globalInputGroupBox.Location = new System.Drawing.Point(13, 13);
            this.globalInputGroupBox.Name = "globalInputGroupBox";
            this.globalInputGroupBox.Size = new System.Drawing.Size(200, 47);
            this.globalInputGroupBox.TabIndex = 0;
            this.globalInputGroupBox.TabStop = false;
            this.globalInputGroupBox.Text = "Global Input";
            // 
            // globalInputComboBox
            // 
            this.globalInputComboBox.FormattingEnabled = true;
            this.globalInputComboBox.Items.AddRange(new object[] {
            "Sum",
            "Product",
            "Min",
            "Max"});
            this.globalInputComboBox.Location = new System.Drawing.Point(6, 19);
            this.globalInputComboBox.Name = "globalInputComboBox";
            this.globalInputComboBox.Size = new System.Drawing.Size(188, 21);
            this.globalInputComboBox.TabIndex = 1;
            this.globalInputComboBox.Text = "Sum";
            this.globalInputComboBox.SelectedIndexChanged += new System.EventHandler(this.globalInputComboBox_SelectedIndexChanged);
            // 
            // activationGroupBox
            // 
            this.activationGroupBox.Controls.Add(this.aUpDown);
            this.activationGroupBox.Controls.Add(this.gUpDown);
            this.activationGroupBox.Controls.Add(this.aLabel);
            this.activationGroupBox.Controls.Add(this.gLabel);
            this.activationGroupBox.Controls.Add(this.thetaUpDown);
            this.activationGroupBox.Controls.Add(this.thetaLabel);
            this.activationGroupBox.Controls.Add(this.activationComboBox);
            this.activationGroupBox.Location = new System.Drawing.Point(13, 66);
            this.activationGroupBox.Name = "activationGroupBox";
            this.activationGroupBox.Size = new System.Drawing.Size(200, 75);
            this.activationGroupBox.TabIndex = 1;
            this.activationGroupBox.TabStop = false;
            this.activationGroupBox.Text = "Activation";
            // 
            // aUpDown
            // 
            this.aUpDown.DecimalPlaces = 2;
            this.aUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.aUpDown.Location = new System.Drawing.Point(135, 47);
            this.aUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.aUpDown.Name = "aUpDown";
            this.aUpDown.Size = new System.Drawing.Size(43, 20);
            this.aUpDown.TabIndex = 5;
            this.aUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aUpDown.ValueChanged += new System.EventHandler(this.aUpDown_ValueChanged);
            // 
            // gUpDown
            // 
            this.gUpDown.DecimalPlaces = 2;
            this.gUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gUpDown.Location = new System.Drawing.Point(71, 47);
            this.gUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gUpDown.Name = "gUpDown";
            this.gUpDown.Size = new System.Drawing.Size(43, 20);
            this.gUpDown.TabIndex = 5;
            this.gUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gUpDown.ValueChanged += new System.EventHandler(this.gUpDown_ValueChanged);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(181, 49);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 4;
            this.aLabel.Text = "a";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(117, 49);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(13, 13);
            this.gLabel.TabIndex = 4;
            this.gLabel.Text = "g";
            // 
            // thetaUpDown
            // 
            this.thetaUpDown.DecimalPlaces = 2;
            this.thetaUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.thetaUpDown.Location = new System.Drawing.Point(6, 47);
            this.thetaUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.thetaUpDown.Name = "thetaUpDown";
            this.thetaUpDown.Size = new System.Drawing.Size(43, 20);
            this.thetaUpDown.TabIndex = 3;
            this.thetaUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thetaUpDown.ValueChanged += new System.EventHandler(this.thetaUpDown_ValueChanged);
            // 
            // thetaLabel
            // 
            this.thetaLabel.AutoSize = true;
            this.thetaLabel.Location = new System.Drawing.Point(52, 49);
            this.thetaLabel.Name = "thetaLabel";
            this.thetaLabel.Size = new System.Drawing.Size(13, 13);
            this.thetaLabel.TabIndex = 2;
            this.thetaLabel.Text = "θ";
            // 
            // activationComboBox
            // 
            this.activationComboBox.FormattingEnabled = true;
            this.activationComboBox.Items.AddRange(new object[] {
            "Treapta",
            "Sigmoidala",
            "Signum",
            "TanH",
            "Rampa"});
            this.activationComboBox.Location = new System.Drawing.Point(6, 19);
            this.activationComboBox.Name = "activationComboBox";
            this.activationComboBox.Size = new System.Drawing.Size(188, 21);
            this.activationComboBox.TabIndex = 2;
            this.activationComboBox.Text = "Treapta";
            this.activationComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // binaryCheckBox
            // 
            this.binaryCheckBox.AutoSize = true;
            this.binaryCheckBox.Location = new System.Drawing.Point(71, 19);
            this.binaryCheckBox.Name = "binaryCheckBox";
            this.binaryCheckBox.Size = new System.Drawing.Size(55, 17);
            this.binaryCheckBox.TabIndex = 6;
            this.binaryCheckBox.Text = "Binary";
            this.binaryCheckBox.UseVisualStyleBackColor = true;
            this.binaryCheckBox.CheckedChanged += new System.EventHandler(this.binaryCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.binaryCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // HiddenLayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 198);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.activationGroupBox);
            this.Controls.Add(this.globalInputGroupBox);
            this.Name = "HiddenLayerForm";
            this.Text = "HiddenLayer";
            this.globalInputGroupBox.ResumeLayout(false);
            this.activationGroupBox.ResumeLayout(false);
            this.activationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox globalInputGroupBox;
        private System.Windows.Forms.ComboBox globalInputComboBox;
        private System.Windows.Forms.GroupBox activationGroupBox;
        private System.Windows.Forms.Label thetaLabel;
        private System.Windows.Forms.ComboBox activationComboBox;
        private System.Windows.Forms.NumericUpDown aUpDown;
        private System.Windows.Forms.NumericUpDown gUpDown;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.NumericUpDown thetaUpDown;
        private System.Windows.Forms.CheckBox binaryCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}