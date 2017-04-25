using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomball
{
    public partial class Form1 : Form
    {
     
       Graphics g;
        ball b = new ball();
    Pen pen = new Pen(Color.Red);
     
        public Form1()
        {
            this.Size = new Size(600,600);
            InitializeComponent();
    
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            while (true)
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.FillPath(pen.Brush, b.gp);
                b.Move();
            }
        }
    }
}
