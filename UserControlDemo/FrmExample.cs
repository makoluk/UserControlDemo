using System;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class FrmExample : Form
    {
        public FrmExample()
        {
            InitializeComponent();
            textBoxWithLabel1.textboxClick += UserControlClick;
        }

        //Clear textbox
        private void UserControlClick(object sender, EventArgs e)
        {
            textBoxWithLabel1.TextContent = string.Empty;
        }
    }
}