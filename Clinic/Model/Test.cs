using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
    public class Test
    {
        public DateTime DatePerformed { get; set;  }
        public DateTime DateAvailable { get; set; }
        public bool AbnormalResult { get; set; }
        public string Result { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
