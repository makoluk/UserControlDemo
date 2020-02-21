namespace UserControlDemo
{
    partial class FrmExample
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
            this.textBoxWithLabel1 = new UserControlDemo.TextBoxWithLabel();
            this.textBoxWithLabel2 = new UserControlDemo.TextBoxWithLabel();
            this.SuspendLayout();
            // 
            // textBoxWithLabel1
            // 
            this.textBoxWithLabel1.LabelContent = null;
            this.textBoxWithLabel1.Location = new System.Drawing.Point(11, 11);
            this.textBoxWithLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWithLabel1.Name = "textBoxWithLabel1";
            this.textBoxWithLabel1.Size = new System.Drawing.Size(364, 27);
            this.textBoxWithLabel1.TabIndex = 0;
            // 
            // textBoxWithLabel2
            // 
            this.textBoxWithLabel2.LabelContent = "Label Name";
            this.textBoxWithLabel2.Location = new System.Drawing.Point(11, 57);
            this.textBoxWithLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWithLabel2.Name = "textBoxWithLabel2";
            this.textBoxWithLabel2.Size = new System.Drawing.Size(364, 27);
            this.textBoxWithLabel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxWithLabel2);
            this.Controls.Add(this.textBoxWithLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxWithLabel textBoxWithLabel1;
        private TextBoxWithLabel textBoxWithLabel2;
    }
}

