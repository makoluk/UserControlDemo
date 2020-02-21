namespace UserControlDemo
{
    partial class TextBoxWithLabel
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
            this.lbl = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(36, 20);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Text";
            // 
            // txt
            // 
            this.txt.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt.Location = new System.Drawing.Point(130, 0);
            this.txt.Margin = new System.Windows.Forms.Padding(2);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(234, 27);
            this.txt.TabIndex = 1;
            this.txt.Click += new System.EventHandler(this.txt_Click);
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // TextBoxWithLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TextBoxWithLabel";
            this.Size = new System.Drawing.Size(364, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txt;
    }
}
