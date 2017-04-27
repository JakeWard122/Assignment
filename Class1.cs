using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace minikeyboard
{
    class Dictionary
    {
        public List<String> Words = new List<String>();
        public List<int> Count = new List<int>();

        public void AddWord(string word)
        {
            int i;
            int WordCount = Words.Count;
            Boolean bExists = false;
            if (WordCount > 0)
            {
                for (i = 0; i <= WordCount - 1; i++)
                {
                    if (Words[i] == word)
                    {
                        Count[i]++;
                        bExists = true;
                    }
                }
            }

            if (!bExists)
            {
                Words.Add(word);
                Count.Add(1);
            }
            SaveDictionary();
        }

        public List<string> ReturnWords(string sKeystrokes)
        {
            int i;
            List<string> returnlist = new List<string>();
            List<int> returnlistcnt = new List<int>();
            for (i = 0; i <= Words.Count - 1; i++)
            {
                if (Words[i].StartsWith(sKeystrokes))
                {
                    if (returnlist.Count == 0)
                    {
                        returnlist.Add(Words[i]);
                        returnlistcnt.Add(Count[i]);
                    }
                    else
                    {
                        int i2;
                        Boolean bAdded = false;
                        
                        for (i2 = 0; i2 <= returnlistcnt.Count - 1; i2++)
                        {
                            if (Count[i] > returnlistcnt[i2])
                            {
                                returnlist.Insert(i2, Words[i]);
                                returnlistcnt.Insert(i2,Count[i]);
                                break;
                            }
                        }
                        if (!bAdded)
                        {
                            returnlist.Add(Words[i]);
                            returnlistcnt.Add(Count[i]);
                        }
                    }
                }
            }
            return returnlist; 
        }

        public void LoadDictionary()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Dictionary.csv";
            if (File.Exists(path))
            {
                string[] sList = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\Dictionary.csv");
                int i;
                for (i = 0; i <= sList.Length-1; i++)
                {
                    if (!String.IsNullOrWhiteSpace(sList[i]))
                    {
                        Words.Add(sList[i].Split(',')[0]);
                        Count.Add(Convert.ToInt32(sList[i].Split(',')[1]));
                    }
                }
            }
        }

        public void SaveDictionary()
        {
            int i;
            int WordCount = Words.Count;
            if (WordCount > 0)
            {
                List<string> Lines = new List<string>();
                for (i = 0; i <= WordCount - 1; i++)
                {
                    Lines.Add(Words[i] + "," + Count[i]);
                }
                string path = AppDomain.CurrentDomain.BaseDirectory + "\\Dictionary.csv";
                File.WriteAllLines(path,Lines.ToArray());
            }
        }

    }
}
