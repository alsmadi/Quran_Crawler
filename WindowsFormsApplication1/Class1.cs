using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class1
    {

         // Link e3 = myIE.Link(Find.ByText("Next"));
                
                // sw.WriteLine("divs");
                //int counter = 1;
                //string title = null;
                //string author = null;
                //string abstractt = null;
                //string citation = null;

      //          foreach (Div div in myIE.Divs)
      //{
      //    foreach (WatiN.Core.Button bu in div.Buttons)
      //    {
      //        if (bu != null && bu.TagName !=null )
      //        {
                 
      //            string test = bu.Text;
      //        }
      //    }
      //}

      //foreach (WatiN.Core.Button bu in myIE.Buttons)
      //{
      //    string test = bu.Text;
      //}
            

//            }

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
 // NextCycle:
 //     foreach (Div div in myIE.Divs)
 //     {
 //       //  if(div.Text.Contains("Next")){
 //         //
 //          //   string test = div.Text;
 //        // }

 //         if (div.ClassName == "gs_r")
 //         {
 //             string test = div.Text;
 //             int intcount=0;
 //         //    foreach (string line in new LineReader(() => new StringReader(test)))
 //          // {
 //             using (StringReader reader = new StringReader(line))
 //             {
 //                 string line;
 //                 string newAbstract = null;
 //                 string newAuthors = null;
 //                 string newTitle = null;
 //                 while ((line = reader.ReadLine()) != null)
 //                 {
 //                     if(line.Contains("Cited by")){
 //                         try
 //                         {
 //                             citation = line.Substring(9, line.IndexOf("Rel") - 9);
 //                         }
 //                         catch (Exception ex)
 //                         {

 //                             if (line.Length == 10)
 //                             {
 //                                 citation = line.Substring(9, 1);
 //                             }
 //                             if (line.Length == 11)
 //                             {
 //                                 citation = line.Substring(9, 2);
 //                             }
 //                             if (line.Length == 12)
 //                             {
 //                                 citation = line.Substring(9, 3);
 //                             }
 //                             if (line.Length == 13)
 //                             {
 //                                 citation = line.Substring(9, 4);
 //                             }
 //                             if (line.Length == 14)
 //                             {
 //                                 citation = line.Substring(9, 5);
 //                             }
 //                         }

 //                     //    citation = line.Substring(9, line.IndexOf("Rel")-9);
 //                     }
 //                     if (line.Length > 0)
 //                     {
 //                         // Do something with the line
 //                         //  }
 //                         //}
 //                         if (intcount == 0)
 //                         {
 //                             title = line;
 //                             foreach (char ch in title)
 //                             {
 //                                 if (ch != ',')
 //                                 {
 //                                     newTitle += ch;
 //                                 }
 //                             }
 //                             intcount++;
 //                             continue;
 //                         }
 //                         if (intcount == 1)
 //                         {
 //                             author = line;

 //                             foreach (char ch in author)
 //                             {
 //                                 if (ch != ',')
 //                                 {
 //                                     newAuthors += ch;
 //                                 }
 //                             }
 //                             intcount++;
 //                             continue;
 //                         }
 //                         if (intcount == 2)
 //                         {
                            
 //                             abstractt = line;
 //                             abstractt = abstractt.Substring(0, 15);

 //                             foreach (char ch in abstractt)
 //                             {
 //                                 if (ch != ',')
 //                                 {
 //                                     newAbstract += ch;
 //                                 }
 //                             }
 //                             intcount++;
 //                             continue;
 //                         }
 //                 /*        if (intcount == 3)
 //                         {
 //                             citation = line;
 //                             intcount++;
 //                             continue;
 //                         } */

 //                         //Console.WriteLine(line);
 //                         //  }
 //                     }
 //                 }
 //                 sw.WriteLine(counter + "," + newTitle + "," + newAuthors + "," + newAbstract + "," + citation);
 //                 counter++;
 //                 int exepCounter = 0;
 //                 int SleepTime1=0;
 //                 try{
 //                 Link e3 = myIE.Link(Find.ByText("Next"));
 //             //    try
 //              //   {

 //                     e3.Click();
 //                     SleepTime1 =  RandomNumber(10, 30000);
 //                     //DoMouseClickLeft();
 //                     Thread.Sleep(SleepTime1);

 //                     goto NextCycle;
 //                 }
                      
 //                 catch (Exception ex)
 //                 {
 //                     exepCounter++;
 //                     string test3 = ex.Message;
 //                     if (exepCounter < 3)
 //                     {
 //                         continue;
 //                     }
 //                     else
 //                     {
 //                         goto Exit;
 //                     }
 //                 }
 //             }
 //         }
 //     }
 ///*     sw.WriteLine("elements");
 //     foreach (Element ele in myIE.Elements )
 //     {
 //         string test = ele.Text;
 //         sw.WriteLine(ele.Text);
 //     }
 //     sw.WriteLine("tables");
 //     foreach (Table tbl in myIE.Tables )
 //     {
 //         foreach (TableRow row in tbl.TableRows)
 //         {
 //             foreach (TableCell cel in row.TableCells)
 //             {
 //                 string test = cel.Text;
 //                 sw.WriteLine(test);
 //             }
 //         }
 //         string test1 = tbl.Text;
 //         sw.WriteLine(test1);
 //     }

 //     sw.WriteLine("textfields");
 //     foreach (TextField txt in myIE.TextFields )
 //     {
 //         string test = txt.Text;
 //         sw.WriteLine(test);
 //     }

 //     sw.WriteLine("spans");
 //     foreach (Span div in myIE.Spans)
 //     {
 //         string test = div.Text;
 //         sw.WriteLine(test);
 //     }
 //     sw.WriteLine("paras");
 //     foreach (Para par in myIE.Paras)
 //     {
 //         string test = par.Text;
 //         sw.WriteLine(test);
 //     }
 ////     string resultStats1 = myIE.Div(Find.ById("resultStats")).Text;
 //    // Element element = myIE.Element(Find.ByName("resultStats"));

 //   //  Table table1 = myIE.Tables[0];

 //   //  string resultStats1 = table1.TableRows[0].TableCells[1].Text;
            
 ////           Table table = myIE.Tables[1];

 ////     string resultStats = table.TableRows[0].TableCells[2].Text;


 //    // Element element1 = myIE.Element(Find.ById("resultStats"));
 //     //Table table1 = ie.Table(Find.By("classname","t"));
 //     // Find the para which shows the search result statistics and get text.
 //   //  string resultStats = myIE.Para(Find.ById("resultStats")).Text;
 

 //     // Write these statistics to the console window.
 //   //  Console.WriteLine(resultStats);
 
 //     // Uncomment the following line if you want to close
 //     // Internet Explorer and the console window immediately.
 //     //myIE.Close(); */
 //      //     Exit: */
   // }

    //using (StreamReader reader = new StreamReader(bs)     )     {


                //string line3;
                //string results1="";

                //foreach (char line4 in results)


                //{
                //    if (line3.Length > 3 && line3.Contains("Cached")==false && line3.Contains("Share")==false &&
                //        line3.Contains("View shared post")==false &&
                //        line3.Contains("Translate this page")==false)
                //    {
                //        results1 += line3;
                //    }

                //}
               //         }


                        //    sw.WriteLine(results.ToString());
            //            }
               //     }
      //          
                    //searchResults = myIE.Div(Find.ByName("res"));
                    //Div div = myIE.Div(Find.ById("ssb"));
                    //Para p = div.Paras[0];
                    //string result = p.Text;
                    //Table table = myIE.Tables[2];
                    //table = myIE.Table(Find.ByName("t"));
                    //string resultStats = table.TableRows[0].TableCells[1].Text;
}
}
