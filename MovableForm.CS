using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovableForm
{
    public partial class Form1 : Form
    {

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        //create panel of the area You want to make draggable
        private void panel1_MouseUp(object sender, MouseEventArgs e) 
        {
            _dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }
}
