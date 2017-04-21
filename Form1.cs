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
                Button1_on_click_state();
                word += "q";
                Wordbuilder();
                
            }
            else if (button1Clicks == 3)
            {
                Button1_on_click_state();
                word += "r";
                Wordbuilder();
            }
            else if (button1Clicks == 4)
            {
                Button1_on_click_state();
                word += "s";
                Wordbuilder();
            }
            else if (button1Clicks == 5)
            {
                Button1_on_click_state();
                word += "1";
                Wordbuilder();
            }
            else if (button1Clicks == 6)
            {
                Button1_on_click_state();
                word += "P";
                Wordbuilder();
            }
            else if (button1Clicks == 7)
            {
                Button1_on_click_state();
                word += "Q";
                Wordbuilder();
            }
            else if (button1Clicks == 8)
            {
                Button1_on_click_state();
                word += "R";
                Wordbuilder();
            }
            else if (button1Clicks == 9)
            {
                Button1_on_click_state();
                word += "S";
                Wordbuilder();
                word = "";
            }
        }

        public void Button1_on_click_state()
        {
            button1Timer.Enabled = false;
            button1Timer.Enabled = true;
            word = word.Remove(word.Length - 1, 1);
            tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
            
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
            Tbx_Words.Text += tbx_WordBuild.Text;
            tbx_WordBuild.Text = "";

            button1Timer.Enabled = false;
            button1Clicks = 0;
            word = "";
        }



    }
}
