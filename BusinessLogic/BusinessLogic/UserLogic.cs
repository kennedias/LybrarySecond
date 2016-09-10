using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class UserLogic
    {
        private UserDAO _userDAO; //DataAccessLayer Engine
        private List<TabUserModel> _users;
        private UserDS.TabUserDataTable _tabUserTable;

        public UserLogic()
        {
            _userDAO = new UserDAO();
            _users = new List<TabUserModel>();
            _tabUserTable = new UserDS.TabUserDataTable();
        }

        public List<TabUserModel> GetAllUser()
        {
            _users = new List<TabUserModel>();

            _tabUserTable = _userDAO.GetAllUser();

            foreach (UserDS.TabUserRow row in _tabUserTable.Rows)
            {
                _users.Add(TabUserModel.Parse(row));

            }
            return _users;
        }

        public List<TabUserModel> PerformLogin(string username, string password)
        {
            _users = new List<TabUserModel>();

            if (password.Length > 0)
            {
                _tabUserTable = _userDAO.GetLogin(username, password);

                foreach (UserDS.TabUserRow row in _tabUserTable.Rows)
                {
                    _users.Add(TabUserModel.Parse(row));
                }
            }
            return _users;
        }

        public 
    }
}

