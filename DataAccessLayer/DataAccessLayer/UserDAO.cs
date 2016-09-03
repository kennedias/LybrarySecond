﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.UserDSTableAdapters;

namespace DataAccessLayer
{
    public class UserDAO
    {
        private UserDS _userDataSet;
        private TabUserTableAdapter _tabUserTableAdapter;

        public UserDAO()
        {
            //Initialize objects
            _userDataSet = new UserDS();
            _tabUserTableAdapter = new TabUserTableAdapter();
        }

        public UserDS.TabUserDataTable GetAllUser()
        {
            _tabUserTableAdapter.FillAllUsers(_userDataSet.TabUser);

            return _userDataSet.TabUser;
        }

        public UserDS.TabUserDataTable GetLogin(string username, string password)
        {
            _tabUserTableAdapter.GetDataByUserNamePassword(username, password);
            return _userDataSet.TabUser;
        }

    }
}