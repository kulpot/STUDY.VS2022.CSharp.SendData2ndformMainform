using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SendData2ndformMainform
{
    public partial class InputForm : Form
    {
        private TextBoxState _state;

        public InputForm(TextBoxState state)
        {
            InitializeComponent();
            _state = state;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _state.Text = textBox1.Text;
            _state.CaretPosition = textBox1.SelectionStart;
            base.OnClosing(e);
        }

        /*
        public string TextBoxText
        {
            get { return textBox1.Text; }
        }*/
    }
}
