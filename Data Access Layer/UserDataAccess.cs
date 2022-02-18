using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Data_Access_Layer
{
    class UserDataAccess:DataAccess
    {
       public bool RegisterUser(string name, string username, string email, string password, string dateOfBirth, string gender, string bloodGroup)
        {
            string sql = "INSERT INTO Users(Name,Username,Email,Password,DateOfBirth,Gender,BloodGroup) VALUES('"+name+"','"+username+"','"+email+"','"+password+"','"+dateOfBirth+"','"+gender+"','"+bloodGroup+"')";
            int result = this.ExecuteQuery(sql);
            if(result>0)
            {
                return true;
            }
            return false;
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='"+username+"' AND Password='"+password+"'";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

    }
}
