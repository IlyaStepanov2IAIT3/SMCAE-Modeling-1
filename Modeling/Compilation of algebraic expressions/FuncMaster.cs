using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilation_of_algebraic_expressions
{
    public partial class FuncMaster : Form
    {
        private MainWindow parent;
        public FuncMaster(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void CommonBtn_Click(object sender, EventArgs e)
        {
            inputLb.Text += ((Button)sender).Text;
        }

        private void FuncMaster_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is Button && ((Button)item).Text != "<-" && ((Button)item).Text != "Er")
                {
                    ((Button)item).Click += CommonBtn_Click;
                }
            }
        }

        private void BackSpace_btn_Click(object sender, EventArgs e)
        {
            if (inputLb.Text.Length > 0)
                inputLb.Text = inputLb.Text.Substring(0, inputLb.Text.Length - 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            inputLb.Text = "";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            parent.setBtnEnabled();
            this.Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            parent.setInfixLb(inputLb.Text);
            parent.setBtnEnabled();
            this.Close();
        }
    }
}
