using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace moveableshapes
{
   
    public partial class Form1 : Form

    {
        
        Graphics area;
        Pen pen;
        SolidBrush sb;
        SolidBrush eb;
        public int w = 10;
        public int l = 10;
        Circle c = new Circle();
        Rectangle r = new Rectangle();
        Square s = new Square();
        Shape ss = new Shape();
        bool c_exists = false, s_exists = false;
        public Form1()
        {
            InitializeComponent();
            area = this.CreateGraphics();
            pen = new Pen(Color.Black);
            sb = new SolidBrush(c.GetColor());
            eb = new SolidBrush(this.BackColor);
            
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked == true)
            {
                ss.SetFilled(true);
            }
            else
            {
                ss.SetFilled(false);
            }
        }
        private void btn_circle_Click(object sender, EventArgs e)
        {
            
            area.Clear(this.BackColor);
            pen.Color = c.GetColor();
            btn_circle.Enabled = false;
            btn_ractangle.Enabled = false;
            btn_Square.Enabled = false;
            checkBox1.Enabled = false;
            int x = c.GetRadius();
            if (ss.GetFilled() == true)
            {
                area.FillEllipse(sb, w, l, x, x);
            }
            else {
                area.DrawEllipse(pen, w, l, x, x);
            }
            c_exists = true;
        }

        private void btn_ractangle_Click(object sender, EventArgs e)
        {
            area.Clear(this.BackColor);
            int width = r.GetWidth();
            int length = r.GetLength();
            pen.Color = r.GetColor();

            if (ss.GetFilled() == true)
            {
                area.FillRectangle(sb, w, l, width, length);
            }
            else
            {
                area.DrawRectangle(pen, w, l, width, length);
            }

        }
       
        private void btn_Square_Click(object sender, EventArgs e)
        {
            area.Clear(this.BackColor);
            int side = s.GetSide();

            pen.Color = s.GetColor();
            btn_circle.Enabled = false;
            btn_ractangle.Enabled = false;
            btn_Square.Enabled = false;
            checkBox1.Enabled = false;
            if (ss.GetFilled())
            {
                area.FillRectangle(sb, w, l, side, side);
            }
            else
            {
                area.DrawRectangle(pen, w, l, side, side);
            }
            
            s_exists = true;
           
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (s_exists)
            {
                int side = s.GetSide();
                area.FillRectangle(eb, w, l, side+1, side+1);

                switch (e.KeyCode)
                {
                    case Keys.Left:
                        w -= 5;
                        break;
                    case Keys.Right:
                        w += 5; ;
                        break;
                    case Keys.Up:
                        l -= 5; ;
                        break;
                    case Keys.Down:
                        l += 5;
                        break;
                }
                if (ss.GetFilled())
                {
                    area.FillRectangle(sb, w, l, side, side);
                }
                else
                {
                    area.DrawRectangle(pen, w, l, side, side);
                }
            }
            else
            {
                int radius = c.GetRadius();
                area.FillRectangle(eb, w, l, radius + 1, radius + 1);

                switch (e.KeyCode)
                {
                    case Keys.Left:
                        w -= 5;
                        break;
                    case Keys.Right:
                        w += 5; ;
                        break;
                    case Keys.Up:
                        l -= 5; ;
                        break;
                    case Keys.Down:
                        l += 5;
                        break;
                }
                if (ss.GetFilled())
                {
                    area.FillEllipse(sb, w, l, radius, radius);
                }
                else
                {
                    area.DrawEllipse(pen, w, l, radius, radius);
                }
            }
        }
        private void Form1_Load(object sender, KeyEventArgs e)
        {

        }

        
    }

    
    }
