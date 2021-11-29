using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typeControlForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getType_CheckedChanged(object sender, EventArgs e)
        {
            System.Type tip = sender.GetType();
            MessageBox.Show($"Gelen nesnenin türü {tip}");
        }

        private void btn_type_of_Click(object sender, EventArgs e)
        {
            bool tip = sender.GetType() == typeof(Button);
            MessageBox.Show("" + tip);
        }

        private void btn_is_Click(object sender, EventArgs e)
        {
            bool deger = sender is Button;
            MessageBox.Show("" + deger);
        }
    }
}
