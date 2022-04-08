using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WFMaze
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            Point start = door.Location;
            start = PointToScreen(door.Location);
            start.Offset(5, 5);
            Cursor.Position = start;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                System.Environment.Exit(0);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if(Cursor.Position != door.Location)
            Start();
        }

        private void finish_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer win = new SoundPlayer(@"C:\Users\AbstractSequence\source\repos\WFMaze\win.wav");
            win.Play();
            MessageBox.Show("Это победа!");
            win.Stop();
            Close();
            System.Environment.Exit(0);
        }
    }
}
