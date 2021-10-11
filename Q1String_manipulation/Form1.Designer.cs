
namespace Q1String_manipulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.concatination_button = new System.Windows.Forms.Button();
            this.string1_textBox = new System.Windows.Forms.TextBox();
            this.string2_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reverse_s1_button = new System.Windows.Forms.Button();
            this.check_equal_button = new System.Windows.Forms.Button();
            this.check_palindrom_button = new System.Windows.Forms.Button();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reverse_s2_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first String";
            // 
            // concatination_button
            // 
            this.concatination_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concatination_button.Location = new System.Drawing.Point(31, 163);
            this.concatination_button.Name = "concatination_button";
            this.concatination_button.Size = new System.Drawing.Size(170, 63);
            this.concatination_button.TabIndex = 1;
            this.concatination_button.Text = "Concatination";
            this.concatination_button.UseVisualStyleBackColor = true;
            this.concatination_button.Click += new System.EventHandler(this.concatination_button_Click);
            // 
            // string1_textBox
            // 
            this.string1_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.string1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.string1_textBox.Location = new System.Drawing.Point(31, 47);
            this.string1_textBox.Name = "string1_textBox";
            this.string1_textBox.Size = new System.Drawing.Size(208, 30);
            this.string1_textBox.TabIndex = 2;
            // 
            // string2_textBox
            // 
            this.string2_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.string2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.string2_textBox.Location = new System.Drawing.Point(282, 47);
            this.string2_textBox.Name = "string2_textBox";
            this.string2_textBox.Size = new System.Drawing.Size(208, 30);
            this.string2_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(277, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Second String";
            // 
            // reverse_s1_button
            // 
            this.reverse_s1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverse_s1_button.Location = new System.Drawing.Point(292, 256);
            this.reverse_s1_button.Name = "reverse_s1_button";
            this.reverse_s1_button.Size = new System.Drawing.Size(170, 63);
            this.reverse_s1_button.TabIndex = 5;
            this.reverse_s1_button.Text = "Reverse S1";
            this.reverse_s1_button.UseVisualStyleBackColor = true;
            this.reverse_s1_button.Click += new System.EventHandler(this.reverse_button_Click);
            // 
            // check_equal_button
            // 
            this.check_equal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_equal_button.Location = new System.Drawing.Point(292, 163);
            this.check_equal_button.Name = "check_equal_button";
            this.check_equal_button.Size = new System.Drawing.Size(170, 63);
            this.check_equal_button.TabIndex = 6;
            this.check_equal_button.Text = "Equals?";
            this.check_equal_button.UseVisualStyleBackColor = true;
            this.check_equal_button.Click += new System.EventHandler(this.check_equal_button_Click);
            // 
            // check_palindrom_button
            // 
            this.check_palindrom_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_palindrom_button.Location = new System.Drawing.Point(31, 256);
            this.check_palindrom_button.Name = "check_palindrom_button";
            this.check_palindrom_button.Size = new System.Drawing.Size(170, 63);
            this.check_palindrom_button.TabIndex = 7;
            this.check_palindrom_button.Text = "Palindrom?";
            this.check_palindrom_button.UseVisualStyleBackColor = true;
            this.check_palindrom_button.Click += new System.EventHandler(this.check_palindrom_button_Click);
            // 
            // result_textBox
            // 
            this.result_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_textBox.Location = new System.Drawing.Point(172, 462);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(299, 34);
            this.result_textBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(40, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result:";
            // 
            // reverse_s2_button
            // 
            this.reverse_s2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverse_s2_button.Location = new System.Drawing.Point(172, 346);
            this.reverse_s2_button.Name = "reverse_s2_button";
            this.reverse_s2_button.Size = new System.Drawing.Size(170, 63);
            this.reverse_s2_button.TabIndex = 10;
            this.reverse_s2_button.Text = "Reverse S2";
            this.reverse_s2_button.UseVisualStyleBackColor = true;
            this.reverse_s2_button.Click += new System.EventHandler(this.reverse_s2_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 600);
            this.Controls.Add(this.reverse_s2_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.check_palindrom_button);
            this.Controls.Add(this.check_equal_button);
            this.Controls.Add(this.reverse_s1_button);
            this.Controls.Add(this.string2_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.string1_textBox);
            this.Controls.Add(this.concatination_button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Manipulation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button concatination_button;
        private System.Windows.Forms.TextBox string1_textBox;
        private System.Windows.Forms.TextBox string2_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reverse_s1_button;
        private System.Windows.Forms.Button check_equal_button;
        private System.Windows.Forms.Button check_palindrom_button;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reverse_s2_button;
    }
}

