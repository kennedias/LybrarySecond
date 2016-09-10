using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class TabUserModel
    {
        # region field

        private int _userID;
        private string _userName;
        private int _userLevelCode;
        private string _userLevelDescription;

        #endregion

        # region properties

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public int UserLevelCode
        {
            get { return _userLevelCode; }
            set { _userLevelCode = value; }
        }

        public string UserLevelDescription
        {
            get { return _userLevelDescription; }
            set { _userLevelDescription = value; }
        }

        #endregion

        #region methods

        public static TabUserModel Parse(UserDS.TabUserRow row)
        {
            if (row == null)
                return null;
            else
            {
                TabUserModel model = new TabUserModel();

                //Model data = Database data
                model.UserID = row.UID;
                model.UserName = row.UserName;

                if (row.UserLevel == Constants.administratorCode)
                    model._userLevelDescription = Constants.administratorDescription;
                else if (row.UserLevel == Constants.supervisorCode)
                    model._userLevelDescription = Constants.supervisorDescription;
                else if (row.UserLevel == Constants.userCode)
                    model._userLevelDescription = Constants.userDescription;
                else
                    throws new us


                return model;

            }
        }

        #endregion

    }
}

