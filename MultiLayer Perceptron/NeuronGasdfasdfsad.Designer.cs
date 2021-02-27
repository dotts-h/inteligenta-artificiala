namespace Neuron_1
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
            this.binarCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.generate_numericUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.aLabel = new System.Windows.Forms.Label();
            this.aUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rampaRadioButton = new System.Windows.Forms.RadioButton();
            this.gLabel = new System.Windows.Forms.Label();
            this.thetaLabel = new System.Windows.Forms.Label();
            this.gUpDown = new System.Windows.Forms.NumericUpDown();
            this.thetaUpDown = new System.Windows.Forms.NumericUpDown();
            this.activationTextBox = new System.Windows.Forms.TextBox();
            this.treaptaRadioButton = new System.Windows.Forms.RadioButton();
            this.tanHRadioButton = new System.Windows.Forms.RadioButton();
            this.sigmoidalaRadioButton = new System.Windows.Forms.RadioButton();
            this.signumRadioButton = new System.Windows.Forms.RadioButton();
            this.productRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.globalInputTextBox = new System.Windows.Forms.TextBox();
            this.maxRadioButton = new System.Windows.Forms.RadioButton();
            this.sumRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generate_numericUpAndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // binarCheckBox
            // 
            this.binarCheckBox.AutoSize = true;
            this.binarCheckBox.Location = new System.Drawing.Point(6, 19);
            this.binarCheckBox.Name = "binarCheckBox";
            this.binarCheckBox.Size = new System.Drawing.Size(55, 17);
            this.binarCheckBox.TabIndex = 0;
            this.binarCheckBox.Text = "Binary";
            this.binarCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.outputTextBox);
            this.groupBox4.Controls.Add(this.binarCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(194, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 96);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.outputTextBox.Location = new System.Drawing.Point(6, 42);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(252, 38);
            this.outputTextBox.TabIndex = 7;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generate_numericUpAndDown
            // 
            this.generate_numericUpAndDown.Location = new System.Drawing.Point(6, 19);
            this.generate_numericUpAndDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.generate_numericUpAndDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.generate_numericUpAndDown.Name = "generate_numericUpAndDown";
            this.generate_numericUpAndDown.Size = new System.Drawing.Size(164, 20);
            this.generate_numericUpAndDown.TabIndex = 0;
            this.generate_numericUpAndDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.generate_numericUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(151, 92);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 13;
            this.aLabel.Text = "a";
            // 
            // aUpDown
            // 
            this.aUpDown.DecimalPlaces = 2;
            this.aUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.aUpDown.Location = new System.Drawing.Point(100, 90);
            this.aUpDown.Name = "aUpDown";
            this.aUpDown.Size = new System.Drawing.Size(45, 20);
            this.aUpDown.TabIndex = 12;
            this.aUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aLabel);
            this.groupBox3.Controls.Add(this.aUpDown);
            this.groupBox3.Controls.Add(this.rampaRadioButton);
            this.groupBox3.Controls.Add(this.gLabel);
            this.groupBox3.Controls.Add(this.thetaLabel);
            this.groupBox3.Controls.Add(this.gUpDown);
            this.groupBox3.Controls.Add(this.thetaUpDown);
            this.groupBox3.Controls.Add(this.activationTextBox);
            this.groupBox3.Controls.Add(this.treaptaRadioButton);
            this.groupBox3.Controls.Add(this.tanHRadioButton);
            this.groupBox3.Controls.Add(this.sigmoidalaRadioButton);
            this.groupBox3.Controls.Add(this.signumRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(292, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 156);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activation";
            // 
            // rampaRadioButton
            // 
            this.rampaRadioButton.AutoSize = true;
            this.rampaRadioButton.Location = new System.Drawing.Point(5, 111);
            this.rampaRadioButton.Name = "rampaRadioButton";
            this.rampaRadioButton.Size = new System.Drawing.Size(59, 17);
            this.rampaRadioButton.TabIndex = 11;
            this.rampaRadioButton.TabStop = true;
            this.rampaRadioButton.Text = "Rampa";
            this.rampaRadioButton.UseVisualStyleBackColor = true;
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(151, 66);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(13, 13);
            this.gLabel.TabIndex = 7;
            this.gLabel.Text = "g";
            // 
            // thetaLabel
            // 
            this.thetaLabel.AutoSize = true;
            this.thetaLabel.Location = new System.Drawing.Point(151, 41);
            this.thetaLabel.Name = "thetaLabel";
            this.thetaLabel.Size = new System.Drawing.Size(13, 13);
            this.thetaLabel.TabIndex = 6;
            this.thetaLabel.Text = "θ";
            // 
            // gUpDown
            // 
            this.gUpDown.DecimalPlaces = 2;
            this.gUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gUpDown.Location = new System.Drawing.Point(100, 64);
            this.gUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gUpDown.Name = "gUpDown";
            this.gUpDown.Size = new System.Drawing.Size(45, 20);
            this.gUpDown.TabIndex = 6;
            this.gUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thetaUpDown
            // 
            this.thetaUpDown.DecimalPlaces = 2;
            this.thetaUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.thetaUpDown.Location = new System.Drawing.Point(100, 38);
            this.thetaUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.thetaUpDown.Name = "thetaUpDown";
            this.thetaUpDown.Size = new System.Drawing.Size(45, 20);
            this.thetaUpDown.TabIndex = 5;
            this.thetaUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activationTextBox
            // 
            this.activationTextBox.Location = new System.Drawing.Point(5, 134);
            this.activationTextBox.Name = "activationTextBox";
            this.activationTextBox.ReadOnly = true;
            this.activationTextBox.Size = new System.Drawing.Size(155, 20);
            this.activationTextBox.TabIndex = 10;
            this.activationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treaptaRadioButton
            // 
            this.treaptaRadioButton.AutoSize = true;
            this.treaptaRadioButton.Location = new System.Drawing.Point(6, 19);
            this.treaptaRadioButton.Name = "treaptaRadioButton";
            this.treaptaRadioButton.Size = new System.Drawing.Size(62, 17);
            this.treaptaRadioButton.TabIndex = 5;
            this.treaptaRadioButton.TabStop = true;
            this.treaptaRadioButton.Text = "Treapta";
            this.treaptaRadioButton.UseVisualStyleBackColor = true;
            // 
            // tanHRadioButton
            // 
            this.tanHRadioButton.AutoSize = true;
            this.tanHRadioButton.Location = new System.Drawing.Point(6, 87);
            this.tanHRadioButton.Name = "tanHRadioButton";
            this.tanHRadioButton.Size = new System.Drawing.Size(52, 17);
            this.tanHRadioButton.TabIndex = 8;
            this.tanHRadioButton.TabStop = true;
            this.tanHRadioButton.Text = "TanH";
            this.tanHRadioButton.UseVisualStyleBackColor = true;
            // 
            // sigmoidalaRadioButton
            // 
            this.sigmoidalaRadioButton.AutoSize = true;
            this.sigmoidalaRadioButton.Location = new System.Drawing.Point(6, 41);
            this.sigmoidalaRadioButton.Name = "sigmoidalaRadioButton";
            this.sigmoidalaRadioButton.Size = new System.Drawing.Size(76, 17);
            this.sigmoidalaRadioButton.TabIndex = 6;
            this.sigmoidalaRadioButton.TabStop = true;
            this.sigmoidalaRadioButton.Text = "Sigmoidala";
            this.sigmoidalaRadioButton.UseVisualStyleBackColor = true;
            // 
            // signumRadioButton
            // 
            this.signumRadioButton.AutoSize = true;
            this.signumRadioButton.Location = new System.Drawing.Point(6, 64);
            this.signumRadioButton.Name = "signumRadioButton";
            this.signumRadioButton.Size = new System.Drawing.Size(60, 17);
            this.signumRadioButton.TabIndex = 7;
            this.signumRadioButton.TabStop = true;
            this.signumRadioButton.Text = "Signum";
            this.signumRadioButton.UseVisualStyleBackColor = true;
            // 
            // productRadioButton
            // 
            this.productRadioButton.AutoSize = true;
            this.productRadioButton.Location = new System.Drawing.Point(6, 42);
            this.productRadioButton.Name = "productRadioButton";
            this.productRadioButton.Size = new System.Drawing.Size(62, 17);
            this.productRadioButton.TabIndex = 5;
            this.productRadioButton.TabStop = true;
            this.productRadioButton.Text = "Product";
            this.productRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generate_numericUpAndDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Inputs + Weights";
            // 
            // minRadioButton
            // 
            this.minRadioButton.AutoSize = true;
            this.minRadioButton.Location = new System.Drawing.Point(6, 65);
            this.minRadioButton.Name = "minRadioButton";
            this.minRadioButton.Size = new System.Drawing.Size(42, 17);
            this.minRadioButton.TabIndex = 6;
            this.minRadioButton.TabStop = true;
            this.minRadioButton.Text = "Min";
            this.minRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.globalInputTextBox);
            this.groupBox2.Controls.Add(this.maxRadioButton);
            this.groupBox2.Controls.Add(this.sumRadioButton);
            this.groupBox2.Controls.Add(this.minRadioButton);
            this.groupBox2.Controls.Add(this.productRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(194, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 133);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Global Input";
            // 
            // globalInputTextBox
            // 
            this.globalInputTextBox.Location = new System.Drawing.Point(0, 111);
            this.globalInputTextBox.Name = "globalInputTextBox";
            this.globalInputTextBox.ReadOnly = true;
            this.globalInputTextBox.Size = new System.Drawing.Size(91, 20);
            this.globalInputTextBox.TabIndex = 4;
            this.globalInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxRadioButton
            // 
            this.maxRadioButton.AutoSize = true;
            this.maxRadioButton.Location = new System.Drawing.Point(6, 88);
            this.maxRadioButton.Name = "maxRadioButton";
            this.maxRadioButton.Size = new System.Drawing.Size(45, 17);
            this.maxRadioButton.TabIndex = 7;
            this.maxRadioButton.TabStop = true;
            this.maxRadioButton.Text = "Max";
            this.maxRadioButton.UseVisualStyleBackColor = true;
            // 
            // sumRadioButton
            // 
            this.sumRadioButton.AutoSize = true;
            this.sumRadioButton.Location = new System.Drawing.Point(6, 19);
            this.sumRadioButton.Name = "sumRadioButton";
            this.sumRadioButton.Size = new System.Drawing.Size(46, 17);
            this.sumRadioButton.TabIndex = 4;
            this.sumRadioButton.TabStop = true;
            this.sumRadioButton.Text = "Sum";
            this.sumRadioButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(176, 204);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 283);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Neuron";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generate_numericUpAndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox binarCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.NumericUpDown generate_numericUpAndDown;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.NumericUpDown aUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rampaRadioButton;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label thetaLabel;
        private System.Windows.Forms.NumericUpDown gUpDown;
        private System.Windows.Forms.NumericUpDown thetaUpDown;
        private System.Windows.Forms.TextBox activationTextBox;
        private System.Windows.Forms.RadioButton treaptaRadioButton;
        private System.Windows.Forms.RadioButton tanHRadioButton;
        private System.Windows.Forms.RadioButton sigmoidalaRadioButton;
        private System.Windows.Forms.RadioButton signumRadioButton;
        private System.Windows.Forms.RadioButton productRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton minRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox globalInputTextBox;
        private System.Windows.Forms.RadioButton maxRadioButton;
        private System.Windows.Forms.RadioButton sumRadioButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}