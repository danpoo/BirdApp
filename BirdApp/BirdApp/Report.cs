using System;
using System.Collections.Generic;
using System.Text;

namespace BirdApp
{
    class Report
    {
        private static int lastAccountNumber = 0;

        #region Properties
        /// <summary>
        /// Properties for Sighting Reports
        /// </summary>
        public int ReportNumber { get; private set; }
        public string ReportName { get; set; }
        public string ReportLocation { get; set; }
        public DateTime TimeOfSighting { get; set; }
        public DateTime ReportCreatedDate { get; private set; }
        public string ReportMessage { get; set; }
        #endregion
    }
}
