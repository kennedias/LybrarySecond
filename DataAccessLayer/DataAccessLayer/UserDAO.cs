using System;
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

        public int DeleteUser(int userId)
        {
            return _tabUserTableAdapter.DeleteUserByID(userId);
        }

        public int InsertUser(string userName, string userPassword, int userLevel)
        {
            return _tabUserTableAdapter.InsertUser(userName, userPassword, userLevel);
        }

    /*    public int UpdateUserById(int userId, string userName, string userPassword, int userLevel)
        {
            return _tabUserTableAdapter.UpdateUserPasswordByID(userPassword, userId);
        }
        */

        public int UpdateUser(string userName, string userPassword, int userLevel, int userId)
        {
            return _tabUserTableAdapter.UpdateUser(userName, userPassword, userLevel, userId);
        }

        public int SelectCountUserByName(string userName)
        {
            return (int)_tabUserTableAdapter.SelectCountByUserName(userName);
        }
    }
}
