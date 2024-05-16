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

namespace wfdbig
{
    public partial class GS : Form
    {
        private readonly gs1 go;
      


        public GS()
        {
            InitializeComponent();
            button1.Paint += button1_Paint;
            go = new gs1();
            panel1.Controls.Add(go);

        }

  
      

        private void button1_Click(object sender, EventArgs e)
        {
            ques go = new ques();


            go.Show();

            this.Close();

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            Rectangle bounds = new Rectangle(0, 0, button.Width, button.Height);
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            AddRoundedRectangle(path, bounds, radius);

            Rectangle outlineBounds = new Rectangle(bounds.X - 1, bounds.Y - 1, bounds.Width + 2, bounds.Height + 2);
            GraphicsPath outlinePath = new GraphicsPath();
            AddRoundedRectangle(outlinePath, outlineBounds, radius + 1);
            button.Region = new Region(path);

            using (Pen pen = new Pen(Color.White, 2))
            {
                e.Graphics.DrawPath(pen, outlinePath);
            }

            using (Pen pen = new Pen(Color.White, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            using (SolidBrush brush = new SolidBrush(button.ForeColor))
            {
                e.Graphics.DrawString(button.Text, button.Font, brush, bounds, format);
            }
        }


        private void AddRoundedRectangle(GraphicsPath path, Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);


            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);


            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);


            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

        }

        private void GS_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
