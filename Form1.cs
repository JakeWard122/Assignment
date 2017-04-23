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
        string Str_KeyStrokes;
        Dictionary PredictiveDict = new Dictionary();
        List<string> PredictiveWords; 

        public Form1()
        {
            InitializeComponent();
            PredictiveDict.LoadDictionary();
        }

        private void btn_mode_Click(object sender, EventArgs e)
        {
            //Make mode toggle on click 
            if (tbx_Mode.Text == "Multi-Press")
            {
                tbx_Mode.Text = "Prediction";
            }
            else
            {
                tbx_Mode.Text = "Multi-Press";
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (tbx_Mode.Text == "Prediction") //Use predictive mode if set but also only if some words have been added to the dictionary
            {
                //Routine called by all multipress buttons 
                if (CurrentButton == (Button)sender && button1Timer.Enabled == true)
                {
                    button1Timer.Enabled = false; //Temporarily disable the timer 
                    int newindex = CurrentList.SelectedIndex + 1; //go to next listbox index
                    try
                    { CurrentList.SelectedIndex = newindex; }
                    catch //will catch if index is above the max
                    { CurrentList.SelectedIndex = 0; }
                    Str_KeyStrokes = Str_KeyStrokes.Remove(Str_KeyStrokes.Length - 1); //remove the old char
                    Str_KeyStrokes += CurrentList.SelectedItem; //add the new chhar to Str_KeyStrokes
                    button1Timer.Enabled = true; //restart the timer to begin countdown again
                }
                else
                {
                    //if first press find corresponding char list box (matches by number on end of name)
                    CurrentButton = (Button)sender;
                    //split button name by the underscore to get the number off the end of the button name
                    string ButtNum = CurrentButton.Name.Split('_')[1];
                    //get the list box control with the same number on the end
                    CurrentList = (ListBox)this.Controls["lst_" + ButtNum];
                    //start the timer 
                    button1Timer.Enabled = true;
                    //set the listbox index to be the first char
                    CurrentList.SelectedIndex = 0;
                    //add the selected char to the Str_KeyStrokes
                    Str_KeyStrokes += CurrentList.SelectedItem;
                }
                //Find matching words from list...
                PredictiveWords = PredictiveDict.ReturnWords(Str_KeyStrokes);
                if (PredictiveWords.Count > 0)
                {
                    string PredictiveWord = PredictiveWords[0];
                    SplicePredWord(Str_KeyStrokes, PredictiveWord);
                }
                else
                {
                    SplicePredWord(Str_KeyStrokes, Str_KeyStrokes);
                }
            }
            else //Multi-Press Mode
            {
                //Routine called by all multipress buttons 
                if (CurrentButton == (Button)sender && button1Timer.Enabled == true)
                {
                    button1Timer.Enabled = false; //Temporarily disable the timer 
                    int newindex = CurrentList.SelectedIndex + 1; //go to next listbox index
                    try
                    { CurrentList.SelectedIndex = newindex; }
                    catch //will catch if index is above the max
                    { CurrentList.SelectedIndex = 0; }
                    tbx_WordBuild.Text = tbx_WordBuild.Text.Remove(tbx_WordBuild.Text.Length - 1); //remove the old char
                    tbx_WordBuild.Text += CurrentList.SelectedItem; //add the new chhar to word builder
                    button1Timer.Enabled = true; //restart the timer to begin countdown again
                }
                else
                {
                    //if first press find corresponding char list box (matches by number on end of name)
                    CurrentButton = (Button)sender;
                    //split button name by the underscore to get the number off the end of the button name
                    string ButtNum = CurrentButton.Name.Split('_')[1];
                    //get the list box control with the same number on the end
                    CurrentList = (ListBox)this.Controls["lst_" + ButtNum];
                    //start the timer 
                    button1Timer.Enabled = true;
                    //set the listbox index to be the first char
                    CurrentList.SelectedIndex = 0;
                    //add the selected char to the word builder
                    tbx_WordBuild.Text += CurrentList.SelectedItem;
                }
            }
        }

        public void SplicePredWord(string KeyStrokes, string Word)
        {
            string remainingchars = Word.Substring(KeyStrokes.Length);
            tbx_WordBuild.ForeColor = Color.Black;
            tbx_WordBuild.Text = KeyStrokes;
            tbx_WordBuild.ForeColor = Color.Red;
            tbx_WordBuild.Text += remainingchars;

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
            Tbx_Words.Text += tbx_WordBuild.Text + " ";
            PredictiveDict.AddWord(tbx_WordBuild.Text);
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

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            Tbx_Words.Text = Tbx_Words.Text + Environment.NewLine; 
        }


    }
}
