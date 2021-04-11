
namespace formm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbcname = new System.Windows.Forms.TextBox();
            this.tbccode = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddcourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "course code";
            // 
            // tbcname
            // 
            this.tbcname.Location = new System.Drawing.Point(210, 61);
            this.tbcname.Name = "tbcname";
            this.tbcname.Size = new System.Drawing.Size(188, 20);
            this.tbcname.TabIndex = 1;
            this.tbcname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbccode
            // 
            this.tbccode.Location = new System.Drawing.Point(210, 21);
            this.tbccode.Name = "tbccode";
            this.tbccode.Size = new System.Drawing.Size(188, 20);
            this.tbccode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "course name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnaddcourse
            // 
            this.btnaddcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcourse.Location = new System.Drawing.Point(277, 112);
            this.btnaddcourse.Name = "btnaddcourse";
            this.btnaddcourse.Size = new System.Drawing.Size(193, 43);
            this.btnaddcourse.TabIndex = 4;
            this.btnaddcourse.Text = "add course";
            this.btnaddcourse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.btnaddcourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbccode);
            this.Controls.Add(this.tbcname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.addcourse);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcname;
        private System.Windows.Forms.MaskedTextBox tbccode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaddcourse;
    }
}

