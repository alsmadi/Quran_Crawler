using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WatiN.Core;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;



namespace WindowsFormsApplication1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\Izzat\\Desktop\\Kuran_Research\\Quran_Crawler\\WindowsFormsApplication1\\bin\\Debug\\Holy_Quran1\\quran333.txt");
            string filename = "Quran1" + ".csv";
            StreamWriter sw = new StreamWriter(filename);
            
            // Open a new Internet Explorer window and
      // goto the google website.
   //   IE myIE = new IE("http://www.google.com");
      IE myIE = new IE(txtURL.Text);
      //  sw.WriteLine("sequence"+","+"title"+","+"author-publisher"+","+"abstract"+","+"citation");

      sw.WriteLine("SurahNO" + "," + "VerseNO" + "," + "Verse" + "," + "count" + "links" + ",");
      lstvURL.Items.Clear();
      // Find the search text field and type qatalks.

            string line;

            string parsed = "";
            int NOResults = 0;
            string temp = null;
            while ((line = sr.ReadLine()) != null)
            {
                parsed = "";
              //  myIE = new IE("http://www.google.com");
               // NOResults = 0;
                if(line.Length<3){
                    continue;
                }

                if (line.Length > 80)
                {
                    line = line.Substring(0, 80);
                }

                //try
                //{
                //    myIE.TextField(Find.ByName("q")).Clear();
                //}
                //catch (Exception ex)
                //{

                //}
                try
                {
                    myIE.Refresh();
                }
                catch (Exception ex)
                {
                    myIE=new IE("http://www.google.com");
                }
                temp = "";
                string tmp = "";
                int Surah = 0;
                int verse = 0;
                string tmp1 = "";
                foreach (char ch in line)
                {
                    tmp1 += ch;
                    int charCount=0;
                    foreach (char ch1 in tmp1)
                    {
                        if (ch1 == '|')
                        {
                            charCount++;
                        }
                    }
                    tmp += ch;
                    if (ch == '|' && charCount==1)
                    {
                        try
                        {
                            tmp = tmp.TrimEnd('|');
                            Surah = int.Parse(tmp);
                        }
                        catch (Exception ex)
                        {
                        }
                        tmp = "";
                    }
                    if (ch == '|' && charCount==2)
                    {
                        try
                        {
                        tmp = tmp.TrimEnd('|');
                        verse = int.Parse(tmp);
                        }
                        catch (Exception ex)
                        {
                        }
                        tmp = "";
                    }
                    if (ch == '|' || char.IsNumber(ch))
                    {
                      
                        continue;
                    }
                    else
                    {
                        temp += ch;
                    }
                }

                TextField tf;
                try
                {
                    tf=myIE.TextField(Find.ByName("q"));
                 //   myIE.TextField(Find.ByName("q")).TypeText(temp);
                    tf.TypeText(temp);
                    System.Windows.Forms.SendKeys.Flush();

                    SetForegroundWindow(tf.DomContainer.hWnd);
                    SetFocus(tf.DomContainer.hWnd);
                    tf.Focus();
                    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    Thread.Sleep(1000);


                }


                catch (Exception ex)
                {
                    //sw.Close();
                }

                int SleepTime5 = RandomNumber(10, 8000);
                //DoMouseClickLeft();
                Thread.Sleep(SleepTime5);
                    try
                    {
                      //  System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                     //    System.Windows.Forms.SendKeys.SendWait("2")
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                        System.Windows.Forms.SendKeys.Send("{ENTER}");
                      //  System.Windows.Forms.Keys.Enter();
                        System.Windows.Forms.SendKeys.Flush();
                      //  System.Windows.Forms.SendKeys.Send("{DOWN}");


                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.SendKeys.SendWait("{ENTER}");
                    }

                   
                    WatiN.Core.Button b1 = null;
                    // Click the Google search button.
                    //   myIE.Button(Find.ByName("btnG")).Click();
                try{
                    b1 = myIE.Button(Find.ByName("btnG"));

                    if (b1 == null)
                    {

                        b1 = myIE.Button(Find.ByValue("Google Search"));
                        //  ie.Button(Find.ByValue("Google Search")).Click();
                    }
                }


                catch (Exception ex)
                {
                    //sw.Close();
                }

                    if (b1 != null)
                    {
                        try
                        {
                            int SleepTime6 = RandomNumber(10, 3000);
                            //DoMouseClickLeft();
                            Thread.Sleep(SleepTime6);
                            b1.Click();
                            int SleepTime7 = RandomNumber(10, 3000);
                            //DoMouseClickLeft();
                            Thread.Sleep(SleepTime7);
                        }
                        catch (Exception ex)
                        {
                            int k = 4;
                        }

                        myIE.WaitForComplete();
                        int SleepTime3 = RandomNumber(10, 10000);
                        //DoMouseClickLeft();
                        Thread.Sleep(SleepTime3);
                        foreach (Div div in myIE.Divs)
                        {
                            //if (div.Id == "main")
                            //{
                                if (div !=null && div.Text!=null && div.Text.Contains("About") && div.Text.Contains("results"))
                                {
                                    int SleepTime4 = RandomNumber(10, 3000);
                                    //DoMouseClickLeft();
                                    Thread.Sleep(SleepTime4);
                                    int length11 = 0;
                                    string temp11 = null;
                                    try
                                    {
                                        length11 = div.Text.IndexOf("results (") - div.Text.IndexOf("About");
                                        temp11 = div.Text.Substring(div.Text.IndexOf("About") + 5, length11 - 5);
                                    
                                    temp11 = temp11.Trim(',');
                                    string temp2 = "";
                                    foreach (char c in temp11)
                                    {
                                        if (c != ',')
                                        {
                                            temp2 += c;
                                        }
                                    }
                                    NOResults = int.Parse(temp2);
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                          //          sw.WriteLine(Surah+","+verse+","+temp+"," +NOResults + ",");
                          //      }



                                    try
                                    {
                                   //     Div searchResults = myIE.Div(Find.ById("res"));

                                        //foreach (Div div1 in searchResults.Divs)
                                        //{
                                        //    if (div1.Id == "search")
                                        //    {
                                                string results = div.Text;

                                                //    string[] results1=results.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); 

                                                //   sw.WriteLine();
                                                results = results.Trim();
                                                string[] parts = results.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                                                string[] newString = new string[8];

                                                foreach (string t1 in parts)
                                                {
                                                    //if ((t1 != "Cached") && (t1 != "Share") && (t1 != "View shared post")
                                                    //    && (t1 != "Translate this page") && (t1 != "Search Results"))

                                                    if(t1.Contains("www") || t1.Contains("http"))
                                                    {
                                                        // sw.Write(t1 + ",");

                                                        parsed += t1+",";
                                                        break;
                                                    }
                                                }

                                        //    }

                                        //}
                                    }
                                    catch (Exception ex)
                                    {
                                        //  sw.Close();
                                    }



                            }
                        }
                    }



                    //if (NOResults > 0)
                    //{
                       

                        sw.WriteLine(Surah + "," + verse + "," + temp + "," + NOResults + "," + parsed + ",");
                //    }
                        int SleepTime2 = RandomNumber(10, 30000);
                        //DoMouseClickLeft();
                        Thread.Sleep(SleepTime2);
            }
                
               
      sw.Close();
      MessageBox.Show("Done");
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = txtPaperSearch.Text.Trim();
            string temp1 = null;
            foreach (char c in temp)
            {
                if (c != ' ')
                {
                    temp1 += c;
                }
            }

            temp1 = temp1.Substring(0, 10);
            string filename = temp1 + ".csv";
            StreamWriter sw = new StreamWriter(filename);

            // Open a new Internet Explorer window and
            // goto the google website.
            //   IE myIE = new IE("http://www.google.com");
            IE myIE = new IE(txtURL.Text);
            sw.WriteLine("sequence" + "," + "title" + "," + "author-publisher" + "," + "abstract" + "," + "citation");
            lstvURL.Items.Clear();
            // Find the search text field and type qatalks.
            string Stext = @"" + txtPaperSearch.Text + @"";
            myIE.TextField(Find.ByName("q")).TypeText(Stext);

            // Click the Google search button.
            myIE.Button(Find.ByName("btnG")).Click();
            // sw.WriteLine("divs");
            int counter = 1;
            string title = null;
            string author = null;
            string abstractt = null;
            string citation = null;

  /*    foreach (Div div in myIE.Divs)
      {
          foreach (WatiN.Core.Button bu in div.Buttons)
          {
              if (bu != null && bu.TagName !=null )
              {
                 
                  string test = bu.Text;
              }
          }
      }

      foreach (WatiN.Core.Button bu in myIE.Buttons)
      {
          string test = bu.Text;
      }
            */

            foreach (Div div in myIE.Divs)
            {
                //  if(div.Text.Contains("Next")){
                //
                //   string test = div.Text;
                // }

                if (div.ClassName == "gs_r")
                {
                    string test = div.Text;
                    int intcount = 0;
                    //    foreach (string line in new LineReader(() => new StringReader(test)))
                    // {
                    using (StringReader reader = new StringReader(test))
                    {
                        string line;
                        string newAbstract = null;
                        string newAuthors = null;
                        string newTitle = null;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("Cited by"))
                            {
                                try
                                {
                                    citation = line.Substring(9, line.IndexOf("Rel") - 9);
                                }
                                catch (Exception ex)
                                {

                                    if (line.Length == 10)
                                    {
                                        citation = line.Substring(9, 1);
                                    }
                                    if (line.Length == 11)
                                    {
                                        citation = line.Substring(9, 2);
                                    }
                                    if (line.Length == 12)
                                    {
                                        citation = line.Substring(9, 3);
                                    }
                                    if (line.Length == 13)
                                    {
                                        citation = line.Substring(9, 4);
                                    }
                                    if (line.Length == 14)
                                    {
                                        citation = line.Substring(9, 5);
                                    }
                                }

                                //    citation = line.Substring(9, line.IndexOf("Rel")-9);
                            }
                            if (line.Length > 0)
                            {
                                // Do something with the line
                                //  }
                                //}
                                if (intcount == 0)
                                {
                                    title = line;
                                    foreach (char ch in title)
                                    {
                                        if (ch != ',')
                                        {
                                            newTitle += ch;
                                        }
                                    }
                                    intcount++;
                                    continue;
                                }
                                if (intcount == 1)
                                {
                                    author = line;

                                    foreach (char ch in author)
                                    {
                                        if (ch != ',')
                                        {
                                            newAuthors += ch;
                                        }
                                    }
                                    intcount++;
                                    continue;
                                }
                                if (intcount == 2)
                                {

                                    abstractt = line;
                                    abstractt = abstractt.Substring(0, 15);

                                    foreach (char ch in abstractt)
                                    {
                                        if (ch != ',')
                                        {
                                            newAbstract += ch;
                                        }
                                    }
                                    intcount++;
                                    continue;
                                }
                                /*        if (intcount == 3)
                                        {
                                            citation = line;
                                            intcount++;
                                            continue;
                                        } */

                                //Console.WriteLine(line);
                                //  }
                            }
                        }
                        sw.WriteLine(counter + "," + newTitle + "," + newAuthors + "," + newAbstract + "," + citation);
                        //counter++;
                        break;

                    }
                }
            }

            int exepCounter1 = 0;
            int SleepTime2 = 0;

            string citText = null;
            foreach (Link lnk in myIE.Links)
            {
                if (lnk != null)
                {
                  //  citText=lnk.Text;
                    if (lnk.Text!=null && (lnk.Text.StartsWith("Cited") || lnk.Text.Contains("Cited")))
                    {
                        citText = lnk.Text;
                        break;
                    }
                }
            }

            try
            {
                Link e2 = myIE.Link(Find.ByText(citText));
                //    try
                //   {

                e2.Click();
                SleepTime2 = RandomNumber(10, 30000);
                //DoMouseClickLeft();
                Thread.Sleep(SleepTime2);

                goto NextCycle;
            }

            catch (Exception ex)
            {
                /*  exepCounter++;
                  string test3 = ex.Message;
                  if (exepCounter < 3)
                  {
                      continue;
                  }
                  else
                  {
                      goto Exit;
                  } */
                int t = 5;
            }
        NextCycle:
            foreach (Div div in myIE.Divs)
            {
                //  if(div.Text.Contains("Next")){
                //
                //   string test = div.Text;
                // }

                if (div.ClassName == "gs_r")
                {
                    string test = div.Text;
                    int intcount = 0;
                    //    foreach (string line in new LineReader(() => new StringReader(test)))
                    // {
                    using (StringReader reader = new StringReader(test))
                    {
                        string line;
                        string newAbstract = null;
                        string newAuthors = null;
                        string newTitle = null;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("Cited by"))
                            {
                                try
                                {
                                    citation = line.Substring(9, line.IndexOf("Rel") - 9);
                                }
                                catch (Exception ex)
                                {

                                    if (line.Length == 10)
                                    {
                                        citation = line.Substring(9, 1);
                                    }
                                    if (line.Length == 11)
                                    {
                                        citation = line.Substring(9, 2);
                                    }
                                    if (line.Length == 12)
                                    {
                                        citation = line.Substring(9, 3);
                                    }
                                    if (line.Length == 13)
                                    {
                                        citation = line.Substring(9, 4);
                                    }
                                    if (line.Length == 14)
                                    {
                                        citation = line.Substring(9, 5);
                                    }
                                }

                                //    citation = line.Substring(9, line.IndexOf("Rel")-9);
                            }
                            if (line.Length > 0)
                            {
                                // Do something with the line
                                //  }
                                //}
                                if (intcount == 0)
                                {
                                    title = line;
                                    foreach (char ch in title)
                                    {
                                        if (ch != ',')
                                        {
                                            newTitle += ch;
                                        }
                                    }
                                    intcount++;
                                    continue;
                                }
                                if (intcount == 1)
                                {
                                    author = line;

                                    foreach (char ch in author)
                                    {
                                        if (ch != ',')
                                        {
                                            newAuthors += ch;
                                        }
                                    }
                                    intcount++;
                                    continue;
                                }
                                if (intcount == 2)
                                {

                                    abstractt = line;
                                    abstractt = abstractt.Substring(0, 15);

                                    foreach (char ch in abstractt)
                                    {
                                        if (ch != ',')
                                        {
                                            newAbstract += ch;
                                        }
                                    }
                                    intcount++;
                                    continue;
                                }
                                /*        if (intcount == 3)
                                        {
                                            citation = line;
                                            intcount++;
                                            continue;
                                        } */

                                //Console.WriteLine(line);
                                //  }
                            }
                        }
                        sw.WriteLine(counter + "," + newTitle + "," + newAuthors + "," + newAbstract + "," + citation);
                        counter++;
                       
                        
                    }
                }
            }
            int exepCounter = 0;
            int SleepTime1 = 0;
        try
        {
            Link e3 = myIE.Link(Find.ByText("Next"));
            //    try
            //   {

            e3.Click();
            SleepTime1 = RandomNumber(10, 30000);
            //DoMouseClickLeft();
            Thread.Sleep(SleepTime1);

            goto NextCycle;
        }

        catch (Exception ex)
        {
            goto Exit;
          /*  exepCounter++;
            string test3 = ex.Message;
            if (exepCounter < 3)
            {
                continue;
            }
            else
            {
                
            } */
        }
        
        Exit:
            sw.Close();
        MessageBox.Show("Done");
        }
    }
}
