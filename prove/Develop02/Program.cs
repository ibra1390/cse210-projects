using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Program
    {


        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            myJournal.DisplayIntro();
            myJournal.GetChoice();
            
        }     
    }
}