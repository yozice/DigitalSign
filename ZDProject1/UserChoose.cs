using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDProject1
{
    public partial class UserChoose : Form
    {
        private bool badName = true;
        public UserChoose()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserChoose_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (badName) Application.Exit();
            else DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                badName = false;
                Form1.current_user = textBox1.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Нужно ввести имя пользователя!", "Ошибка");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void UserChoose_Load(object sender, EventArgs e)
        {

        }
    }
}
