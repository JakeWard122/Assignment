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
                if (button1Timer.Enabled == true)
                {
                    tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                    button1Timer.Enabled = false;
                }
                button1Timer.Enabled = true;
                word += "p";
                Wordbuilder();

            }
            else if (button1Clicks == 2)
            {
                button1Timer.Enabled = false;
                button1Timer.Enabled = true;
                word = word.Remove(word.Length - 1, 1);
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                word += "q";
                Wordbuilder();
            }
            else if (button1Clicks == 3)
            {
                button1Timer.Enabled = false;
                button1Timer.Enabled = true;
                word = word.Remove(word.Length - 1, 1);
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                word += "r";
                Wordbuilder();
            }
            else if (button1Clicks == 4)
            {
                button1Timer.Enabled = false;
                button1Timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                word += "s";
                Wordbuilder();
            }
            else if (button1Clicks == 5)
            {
                button1Timer.Enabled = false;
                button1Timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                word += "1";
                Wordbuilder();
            }
            else if (button1Clicks == 6)
            {
                button1Timer.Enabled = false;
                button1Timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                word += "P";
                Wordbuilder();
            }
            else if (button1Clicks == 7)
            {
                button1Timer.Enabled = false;
                button1Timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                word += "Q";
                Wordbuilder();
            }
            else if (button1Clicks == 8)
            {
                button1Timer.Enabled = false;
                button1Timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                word += "R";
                Wordbuilder();
            }
            else if (button1Clicks == 9)
            {
                button1Timer.Enabled = false;
                button1Timer.Enabled = true;
                button1Clicks = 0;
                word = word.Remove(word.Length - 1);
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                word += "S";
                Wordbuilder();
                word = "";
            }
        }

        private void tbx_WordBuild_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void Wordbuilder()
        {
            tbx_WordBuild.Text += word;
        
        
        }

        private void button1Timer_Tick(object sender, EventArgs e)
        {
            word = "";
            button1Timer.Enabled = false;
            button1Clicks = 0;
        }

        private void btn_000_Click(object sender, EventArgs e)
        {
            
        }


        
    }
}
