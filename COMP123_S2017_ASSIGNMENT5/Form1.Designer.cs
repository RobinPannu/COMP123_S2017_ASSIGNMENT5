namespace COMP123_S2017_ASSIGNMENT5
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
            this.imperial = new System.Windows.Forms.RadioButton();
            this.Matric = new System.Windows.Forms.RadioButton();
            this.weight = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imperial
            // 
            this.imperial.AutoSize = true;
            this.imperial.Location = new System.Drawing.Point(42, 51);
            this.imperial.Name = "imperial";
            this.imperial.Size = new System.Drawing.Size(94, 28);
            this.imperial.TabIndex = 0;
            this.imperial.TabStop = true;
            this.imperial.Text = "Imperial";
            this.imperial.UseVisualStyleBackColor = true;
            this.imperial.CheckedChanged += new System.EventHandler(this.Gender_CheckedChanged);
            // 
            // Matric
            // 
            this.Matric.AutoSize = true;
            this.Matric.Location = new System.Drawing.Point(159, 51);
            this.Matric.Name = "Matric";
            this.Matric.Size = new System.Drawing.Size(78, 28);
            this.Matric.TabIndex = 2;
            this.Matric.TabStop = true;
            this.Matric.Text = "Matric";
            this.Matric.UseVisualStyleBackColor = true;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(38, 121);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(69, 24);
            this.weight.TabIndex = 3;
            this.weight.Text = "Weight";
            this.weight.Click += new System.EventHandler(this.label1_Click);
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(38, 182);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(65, 24);
            this.height.TabIndex = 4;
            this.height.Text = "Height";
            this.height.Click += new System.EventHandler(this.height_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(38, 237);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(45, 24);
            this.age.TabIndex = 5;
            this.age.Text = "Age";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 29);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.Matric);
            this.Controls.Add(this.imperial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BMI CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton imperial;
        private System.Windows.Forms.RadioButton Matric;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox textBox1;
    }
}

