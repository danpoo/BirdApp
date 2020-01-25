using System;
using System.Collections.Generic;
using System.Text;

namespace BirdApp
{
    class Bird
    {
        private static int lastAccountNumber = 0;

        #region Properties
        /// <summary>
        /// Properties of Birds
        /// </summary>
        public int BirdIDNumber { get; private set; }
        public string BirdName { get; private set; }
        public string BirdRegion { get; set; }
        public string BirdShape { get; set; }
        public string BirdSize { get; set; }
        public string BirdColorPrimary { get; set; }
        public string BirdColorSecondary { get; set; }
        public string BirdBillShape { get; set; }
        public string BirdBillLength { get; set; }
        public string BirdWingShape { get; set; }
        public string BirdTailShape { get; set; }
        #endregion
    }
}
