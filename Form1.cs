using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMaze
{
    public partial class Form1 : Form
    {
        private bool locked = true;
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }
        private void finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("WINNER WINNER CHICKEN DINNER");
            Form2 Form2 = new Form2();
            Hide();
            Form2.Show();
            
        }
        private void MoveToStart()
        {
            if (locked)
            {
                Point startPoint = panel1.Location;
                startPoint.Offset(10, 10);
                Cursor.Position = PointToScreen(startPoint);
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)//27 == esc
                System.Environment.Exit(0);
            else if (e.Alt)
            {
                if (locked)
                    locked = false;
                else locked = true;
            }
        }
    }
}
