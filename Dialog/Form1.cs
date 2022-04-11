using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog
{
    public partial class Form1 : Form
    {
        DialogResult result = new DialogResult();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            result = MessageBox.Show("Спасибо за внимание", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DialogResult.No:
                    MessageBox.Show("Отмена");
                    System.Environment.Exit(0);
                    break;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Внимание!", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Да", "Да", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case DialogResult.No:
                    MessageBox.Show("Нет");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Отменяем");
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
