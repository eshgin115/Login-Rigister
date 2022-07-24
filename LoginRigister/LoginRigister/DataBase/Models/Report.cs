using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRigister.DataBase.Models
{
    class Report
    {

        public static int _numberOnTheList = 1;
        public int NumberOnTheList { get; set; }
        public string  FromMSS { get; set; }
        public string ToMSS { get; set; }
        public string Text { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime ReportTIME { get; set; }
        public Report(int numberOnTheList, string fromMSS, string toMSS, string text, bool isAdmin, DateTime reportTIME)
        {
          
            FromMSS = fromMSS;
            ToMSS = toMSS;
            Text = text;
            IsAdmin = isAdmin;
            ReportTIME = reportTIME;
        }
      
    }
}
