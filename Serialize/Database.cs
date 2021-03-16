using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication.Serialize
{
    public class Database
    {
        public int ID { get; set; }
        public string WHITE { get; set; }
        public int SCORE_WHITE { get; set; }
        public int SCORE_BLACK { get; set; }
        public string BLACK { get; set; }
        public DateTime MTC_DATE { get; set; }
        public string DEBUT { get; set; }
        public string TOURNAMENT { get; set; }

    }
}
