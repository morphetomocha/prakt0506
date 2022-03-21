
namespace prakt0506
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
            this.button1 = new System.Windows.Forms.Button();
            this.perviy = new System.Windows.Forms.TextBox();
            this.vtoroy = new System.Windows.Forms.TextBox();
            this.kekBox = new System.Windows.Forms.RichTextBox();
            this.tretiy = new System.Windows.Forms.TextBox();
            this.zvBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "нажимай меня полностью";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // perviy
            // 
            this.perviy.Location = new System.Drawing.Point(54, 41);
            this.perviy.Name = "perviy";
            this.perviy.Size = new System.Drawing.Size(68, 23);
            this.perviy.TabIndex = 1;
            this.perviy.TextChanged += new System.EventHandler(this.perviy_TextChanged);
            // 
            // vtoroy
            // 
            this.vtoroy.Location = new System.Drawing.Point(54, 12);
            this.vtoroy.Name = "vtoroy";
            this.vtoroy.Size = new System.Drawing.Size(68, 23);
            this.vtoroy.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.kekBox.Location = new System.Drawing.Point(177, 49);
            this.kekBox.Name = "richTextBox1";
            this.kekBox.Size = new System.Drawing.Size(199, 152);
            this.kekBox.TabIndex = 3;
            this.kekBox.Text = "";
            this.kekBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tretiy
            // 
            this.tretiy.Location = new System.Drawing.Point(44, 70);
            this.tretiy.Name = "tretiy";
            this.tretiy.Size = new System.Drawing.Size(127, 23);
            this.tretiy.TabIndex = 4;
            // 
            // richTextBox2
            // 
            this.zvBox.Location = new System.Drawing.Point(394, 49);
            this.zvBox.Name = "richTextBox2";
            this.zvBox.Size = new System.Drawing.Size(178, 160);
            this.zvBox.TabIndex = 5;
            this.zvBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zvBox);
            this.Controls.Add(this.tretiy);
            this.Controls.Add(this.kekBox);
            this.Controls.Add(this.vtoroy);
            this.Controls.Add(this.perviy);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox perviy;
        private System.Windows.Forms.TextBox vtoroy;
        private System.Windows.Forms.RichTextBox kekBox;
        private System.Windows.Forms.TextBox tretiy;
        private System.Windows.Forms.RichTextBox zvBox;
    }
}

