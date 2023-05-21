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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxState state = new TextBoxState(string.Empty, 0);
            InputForm form = new InputForm(state);
            form.ShowDialog(); //the key is to use ShowDialog method
            textBox1.Text = state.Text;
            textBox1.SelectionStart = state.CaretPosition;
            //this.Text = form.TextBoxText;
        }
    }
}
