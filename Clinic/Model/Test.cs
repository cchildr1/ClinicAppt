using System;

namespace Clinic.Model
{
    /// <summary>
    /// A test at the clinic.
    /// </summary>
    public class Test
    {
        public int TestID { get; set; }
        public int VisitID { get; set; }
        public DateTime DatePerformed { get; set;  }
        public DateTime DateAvailable { get; set; }
        public bool AbnormalResult { get; set; }
        public string Result { get; set; }
        public int TestCodeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Formats a string in the necessary manner.
        /// </summary>
        /// <returns>Formatted string.</returns>
        public override string ToString()
        {
            return string.Format("{0}", Code);
        }
    }
}
