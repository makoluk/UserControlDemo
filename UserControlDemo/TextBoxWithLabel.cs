using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class TextBoxWithLabel : UserControl
    {
        public TextBoxWithLabel()
        {
            InitializeComponent();
        }

        //Update label with text change
        private void txt_TextChanged(object sender, EventArgs e)
        {
            lbl.Text = txt.Text;
        }

        private string _labelContent;
        private string _textContent;

        //Attribute defination for label
        [Description("Label Content"), Category("Data")]
        public string LabelContent
        {
            get => _labelContent;

            set
            {
                _labelContent = value;
                lbl.Text = value;
            }
        }

        [Description("Text Content"), Category("Data")]
        public string TextContent
        {
            get => _textContent;

            set
            {
                _textContent = value;
                txt.Text = value;
            }
        }

        //Defination of specific event
        public EventHandler textboxClick { get; set; }

        private void txt_Click(object sender, EventArgs e)
        {
            try
            {
                textboxClick.Invoke(this, e);
            }
            catch (Exception)
            {
            }
        }
    }
}