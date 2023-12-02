using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Braill_System
{
    public partial class Form2 : Form
    {
        int dotCount =0;
        int L,R,W;
        double H ;
        double pi = 3.14;
        double P ;
        int x = 260;
        int y = 230;
        int shape = Form1.shape;
        string C;


        private void btncal_Click(object sender, EventArgs e)
        {
            dotCount = 0;
            //visible calculate value
            
            lbldot.Visible = true;
            lblNdot.Visible = true;
            lblpe.Visible = true;
            lblval.Visible = true;
            lblBval.Visible = true;
            //crate grapic
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = DashStyle.Dot;
            Graphics g = panel1.CreateGraphics();
            
            lblBval.Text = C;
            try 
            {
                if (L <= 500)
                {


                    if (W <= 450)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Maximum Width is 450");

                    }
                }
                else { MessageBox.Show("Maximum Length is 500"); }
                if (R <= 225)
                {

                }
                else { MessageBox.Show("Maximum radius is 220"); }
                
                //switch shape
                switch (shape)
                {
                    //square
                    case 0:
                        L = int.Parse(txtL.Text);
                        if (L != null) 
                        { square(g, pen);
                            lbldotval.Visible = true;
                            lbldotc.Visible = true;
                        }
                        
                        break;
                    //rectangle
                    case 1:
                        L = int.Parse(txtL.Text);
                        W = int.Parse(txtW.Text);
                        if (L != null && W != null) 
                        { rectangle(g, pen); 
                            lbldotval.Visible = true;
                            lbldotc.Visible = true;
                        }
                        break;
                    //triangle
                    case 2:
                        L = int.Parse(txtL.Text);
                        H = double.Parse(txtW.Text);
                        if (L != null && H != null) 
                        { triangle(g, pen);
                            lbldotval.Visible = true;
                            lbldotc.Visible = true;
                        }
                       
                        break;
                    //circle
                    case 3:
                        R = int.Parse(txtR.Text);
                        if (R != null) 
                        { circle(g, pen); 
                            lbldotval.Visible = true;
                            lbldotc.Visible = true;
                        }
                        break;
                }
                

            }
            catch {
                MessageBox.Show(" you can use maximum Length =500 and maximum width =250");
            }
            
        }

        public Form2()
        {
            InitializeComponent();
            shapebox.SelectedIndex = shape;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            lbldotval.Visible = false;
            lbldotc.Visible = false;

            lblBval.Visible = false;
            lbldot.Visible = false;
            lblNdot.Visible = false;
            lblval.Visible = false;
            lblpe.Visible = false;
            switch (shape) 
            {
                //square
                case 0:
                    lblshape.Text = "Square";
                    lblL.Visible = true;
                    lblR.Visible = false;
                    lblP.Visible = false;
                    lblW.Visible = false;

                    txtL.Visible = true;
                    txtR.Visible = false;
                    txtW.Visible = false;
                    break;
                //rectangle
                case 1:
                    lblshape.Text = "Rectangle";
                    lblL.Visible = true;
                    lblR.Visible = false;
                    lblP.Visible = false;
                    lblW.Visible = true;

                    txtL.Visible = true;
                    txtR.Visible = false;
                    txtW.Visible = true;
                    break;
                //triangle
                case 2:
                    lblshape.Text = "Triangle";
                    lblL.Visible = true;
                    lblR.Visible = false;
                    lblP.Visible = true;
                    lblW.Visible = false;

                    txtL.Visible = true;
                    txtR.Visible = false;
                    txtW.Visible = true;
                    break;
                //circle
                case 3:
                    lblshape.Text = "Circle";
                    lblL.Visible = false;
                    lblR.Visible = true;
                    lblP.Visible = false;
                    lblW.Visible = false;

                    txtL.Visible = false;
                    txtR.Visible = true;
                    txtW.Visible = false;
                    break;
                default:
                    lblL.Visible = false;
                    lblR.Visible = false;
                    lblP.Visible = false;
                    lblW.Visible = false;

                    txtL.Visible = false;
                    txtR.Visible = false;
                    txtW.Visible = false;
                    break;
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel
        }
// draw rectangle
        public void rectangle( Graphics e,Pen pen)
        {
            P = 2*L +2*W;
            
            e.DrawRectangle(pen, x-L/2,y-W/2,L,W);
            perimeter(P);

        }
        // draw square
        public void square(Graphics e, Pen pen)
        {
            P = 4 * L;
            e.DrawRectangle(pen, x,y, L + 40, L + 40);
            perimeter(P);
        }
        // draw triangle
        public void triangle(Graphics e, Pen pen)
        {
            double X;
            X = (H * H+(L*L)/4);
            X = Math.Sqrt(X);
            P = 2 * X + L;
            int h =Convert.ToInt32(H);
            Point[] pontos =
                    {
                     new Point(x-L/2,y-h/2),
                     new Point(x+L/2,y-h/2),
                     new Point(x,y+h/2)
                     };
            e.DrawPolygon(pen, pontos);
            perimeter(P);
        }
        // draw circle
        public void circle(Graphics e, Pen pen)
        {
            P = 2 * pi * R;
            int d = R * 2;
            e.DrawEllipse(pen, x-R,y-R, d, d);
            perimeter(P);
        }
        //back button
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
        //go to text button
        private void btntext_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            this.Hide();
            this.Close();
            myForm.ShowDialog();
            
        }

        private void shapebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            shape = shapebox.SelectedIndex;
            switch (shape)
            {
                //square
                case 0:
                    lblshape.Text = "Square";
                    lblL.Visible = true;
                    lblR.Visible = false;
                    lblP.Visible = false;
                    lblW.Visible = false;

                    txtL.Visible = true;
                    txtR.Visible = false;
                    txtW.Visible = false;
                    break;
                //rectangle
                case 1:
                    lblshape.Text = "Rectangle";
                    lblL.Visible = true;
                    lblR.Visible = false;
                    lblP.Visible = false;
                    lblW.Visible = true;

                    txtL.Visible = true;
                    txtR.Visible = false;
                    txtW.Visible = true;
                    break;
                //triangle
                case 2:
                    lblshape.Text = "Triangle";
                    lblL.Visible = true;
                    lblR.Visible = false;
                    lblP.Visible = true;
                    lblW.Visible = false;

                    txtL.Visible = true;
                    txtR.Visible = false;
                    txtW.Visible = true;
                    break;
                //circle
                case 3:
                    lblshape.Text = "Circle";
                    lblL.Visible = false;
                    lblR.Visible = true;
                    lblP.Visible = false;
                    lblW.Visible = false;

                    txtL.Visible = false;
                    txtR.Visible = true;
                    txtW.Visible = false;
                    break;
                default:
                    lblL.Visible = false;
                    lblR.Visible = false;
                    lblP.Visible = false;
                    lblW.Visible = false;

                    txtL.Visible = false;
                    txtR.Visible = false;
                    txtW.Visible = false;
                    break;

            }

        }
        //clear values and drawing
        private void btnclear_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            txtL.Text = String.Empty;
            txtR.Text = String.Empty;
            txtW.Text = String.Empty;
            lblBval.Text = String.Empty;
            lbldot.Visible = false;
            lblval.Visible = false;
            lblBval.Visible= false;
            lbldotval.Visible = false;
            lbldotc.Visible = false;
        }

        //calculate perimeter
        public void perimeter(double P)
        {
            lblval.Text = P.ToString("0.00");
            int dot = Convert.ToInt32(P);
            lbldot.Text = (dot / 2).ToString();
            convert();
        }

     public void convert ()
        {
            string valueStr = P.ToString("0.00");

            // Create a dictionary that maps each character to its Braille dot pattern
            Dictionary<char, string> brailleDict = new Dictionary<char, string>()
{
    {'0', "⠚"},
    {'1', "⠁"},
    {'2', "⠃"},
    {'3', "⠉"},
    {'4', "⠙"},
    {'5', "⠑"},
    {'6', "⠋"},
    {'7', "⠛"},
    {'8', "⠓"},
    {'9', "⠊"},
    {'.', "⠲"}
};

            // Convert each character of the string to its Braille dot pattern
            StringBuilder brailleText = new StringBuilder();
            foreach (char c in valueStr)
            {
                if (brailleDict.ContainsKey(c))
                {
                    brailleText.Append(brailleDict[c]);
                }
            }
            foreach (char c in brailleText.ToString())
            {
                if (c >= 0x2800 && c <= 0x28FF) // Check if the character is a valid Braille character
                {
                    for (int i = 0; i < 6; i++) // Iterate through each dot position
                    {
                        if ((c & (1 << i)) != 0) // Check if the dot is raised
                        {
                            dotCount++; // Increment the dot count
                        }
                    }
                }
            }
            // Output the Braille dot pattern for the double value
            lblBval.Text = brailleText.ToString();
            lbldotval.Text = dotCount.ToString();
        }

    }
}
