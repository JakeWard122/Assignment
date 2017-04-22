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
        ListBox CurrentList;
        Button CurrentButton;

        public Form1()
        {
            InitializeComponent();

        }




        private void btn_mode_Click(object sender, EventArgs e)
        {
            tbx_Mode.Text = "Prediction";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (CurrentButton == (Button)sender && button1Timer.Enabled == true)
            {
                button1Timer.Enabled = false;
                int newindex = CurrentList.SelectedIndex + 1;
                try
                { CurrentList.SelectedIndex = newindex; }
                catch
                { CurrentList.SelectedIndex = 0; }
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
                tbx_WordBuild.Text += CurrentList.SelectedItem;
                button1Timer.Enabled = true;
            }
            else
            {
                CurrentButton = (Button)sender;
                string ButtNum = CurrentButton.Name.Split('_')[1];
                CurrentList = (ListBox)this.Controls["lst_" + ButtNum];
                button1Timer.Enabled = true;
                CurrentList.SelectedIndex = 0;
                tbx_WordBuild.Text += CurrentList.SelectedItem;
            }
            
            
            
            

        }



        private void btn_1_Click(object sender, EventArgs e)
        {
          
        }

        public void Button1_on_click_state()
        {
            
            
        }

        private void tbx_WordBuild_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button1Timer_Tick(object sender, EventArgs e)
        {
            button1Timer.Enabled = false;
        }

        private void btn_000_Click(object sender, EventArgs e)
        {
            Tbx_Words.Text += tbx_WordBuild.Text;
            tbx_WordBuild.Text = "";

            button1Timer.Enabled = false;
          
        }

        private void btn_2_Click(object sender, EventArgs e)
        {

        }
      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSpaceBar_Click(object sender, EventArgs e)
        {
            tbx_WordBuild.Text += " "; 
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
           if(tbx_WordBuild.Text.Length > 0)
           {
                tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1);
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
