using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;


namespace WindowsFormsApplication1
{
    public class SearchResults
    {
        internal IE myBrowser;

        // Write constructor
        public SearchResults(IE ie)
        {
            myBrowser = ie;
        }

        // Get the value of result statistics string
        public string GetResultStats()
        {
            // Find the para which shows the search result statistics and get text.
            return myBrowser.Para(Find.ById("resultStats")).Text;
        }
    }

}
