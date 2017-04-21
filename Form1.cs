using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minikeyboard
{

    public partial class Form1 : Form
    {
         string word = "";
            int button1Clicks = 0;
            int button2Clicks = 0;
            int button3Clicks = 0;
            int button4Clicks = 0;
            int button5Clicks = 0;
            int button6Clicks = 0;
            int button7Clicks = 0;
            int button8Clicks = 0;


        public Form1()
        {
            InitializeComponent();
           
        }

        private void btn_mode_Click(object sender, EventArgs e)
        {
            tbx_Mode.Text = "Prediction";
        }
        
        private void btn_1_Click(object sender, EventArgs e)
        {
            button1Clicks++;

            if (button1Clicks == 1)
            {
               
                {
                    tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                    button1Timer.Enabled = false;
                }
                button1Timer.Enabled = true;
                word += "p";
               

            }
          
        }

        private void tbx_WordBuild_TextChanged(object sender, EventArgs e)
        {
           
        }

      

        private void button1Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn_000_Click(object sender, EventArgs e)
        {
            
        }


        
    }
}
