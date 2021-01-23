
namespace Hospital
{
    partial class FormHospital
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNotInsured = new System.Windows.Forms.RadioButton();
            this.radInsured = new System.Windows.Forms.RadioButton();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hours in hospital";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(32, 98);
            this.numHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(124, 20);
            this.numHours.TabIndex = 4;
            this.numHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalc
            // 
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(32, 222);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(84, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNotInsured);
            this.groupBox1.Controls.Add(this.radInsured);
            this.groupBox1.Location = new System.Drawing.Point(32, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insured?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radNotInsured
            // 
            this.radNotInsured.AutoSize = true;
            this.radNotInsured.Location = new System.Drawing.Point(6, 42);
            this.radNotInsured.Name = "radNotInsured";
            this.radNotInsured.Size = new System.Drawing.Size(80, 17);
            this.radNotInsured.TabIndex = 8;
            this.radNotInsured.TabStop = true;
            this.radNotInsured.Text = "Not Insured";
            this.radNotInsured.UseVisualStyleBackColor = true;
            // 
            // radInsured
            // 
            this.radInsured.AutoSize = true;
            this.radInsured.Location = new System.Drawing.Point(6, 19);
            this.radInsured.Name = "radInsured";
            this.radInsured.Size = new System.Drawing.Size(60, 17);
            this.radInsured.TabIndex = 7;
            this.radInsured.TabStop = true;
            this.radInsured.Text = "Insured\r\n";
            this.radInsured.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(207, 44);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(56, 20);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Cost: ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(211, 82);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 8;
            // 
            // FormHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 258);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.numHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "FormHospital";
            this.Text = "Hospital Bill Calculator";
            this.Load += new System.EventHandler(this.FormHospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNotInsured;
        private System.Windows.Forms.RadioButton radInsured;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblOutput;
    }
}

