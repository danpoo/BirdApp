using System;
using System.Collections.Generic;
using System.Text;

namespace BirdApp
{
    class User
    {
        private static int lastUserNumber = 0;

        #region Properties
        /// <summary>
        /// Properties for Users
        /// </summary>
        public int UserNumber { get; private set; }
        public string UserName { get; set; }
        public TypeOfUser UserType { get; set; }
        public DateTime CreatedDate { get; private set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public int UserAge { get; set; }
        public char UserSex { get; set; }
        public int UserPosts { get; set; }
        public int UserBirdCount { get; set; }

        #endregion
    }
}
