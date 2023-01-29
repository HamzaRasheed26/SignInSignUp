using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInSignUpApp.BL;

namespace SignInSignUpApp.DL
{
    internal class MUserDL
    {
        private static List<MUser> usersList = new List<MUser>();

        public static void addIntoList(MUser user)
        {
            usersList.Add(user);
        }

        public static List<MUser> getList()
        {
            return usersList;
        }

        public static bool isExist(MUser user)
        {
            foreach(MUser u in usersList)
            {
                if(user.Username == u.Username && user.Password == u.Password)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
