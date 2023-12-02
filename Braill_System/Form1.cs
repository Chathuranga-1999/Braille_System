using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braill_System
{
    public partial class Form1 : Form
    {
        
        int index ;
        public static int shape ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblshape.Visible = false;
            shapebox.Visible = false;
            btnOk.Visible = false;
        }

        private void choiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = choiceBox.SelectedIndex;
           
            btnOk.Visible = true;
            switch(index)
            {
                //Text
                case 0:
                    btnOk.Visible = true;
                    lblshape.Visible = false;
                    shapebox.Visible = false;
                    break;
                //shapes
                case 1:
                    lblshape.Visible = true;
                    shapebox.Visible = true;
                    btnOk.Visible = true;
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            shape = (int)shapebox.SelectedIndex;
            if (btnOk.Visible) 
            { 
             
                //Text open
                if (index == 0) 
                    {
                    Form3 myForm = new Form3();
                    this.Hide();
                    myForm.ShowDialog();
                    this.Close();
                }
                //shape
                if(index== 1)
                    {
                        if(shape == 0 || shape == 1 || shape == 2 || shape == 3)
                        {
                            Form2 myForm = new Form2();
                            this.Hide();
                            myForm.ShowDialog();
                            this.Close();
                        }
                        else { MessageBox.Show("please enter shape"); }
                    }
            
            
            }
        }
    }
}
