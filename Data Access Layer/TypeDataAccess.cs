using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Data_Access_Layer
{
    class TypeDataAccess:DataAccess
    {
        public List<Type> GetAllTypes()
        {
            string sql = "SELECT * FROM Types";
            SqlDataReader reader = this.GetData(sql);
            List<Type> types = new List<Type>();
            while(reader.Read())
            {
                Type type = new Type();
                type.FoodTypeId = (int)reader["FoodTypeId"];
                type.FoodTypeName = reader["FoodTypeName"].ToString();
                types.Add(type);
            }
            return types; 

        }

        public bool AddNewFoodType(string foodTypeName)
        {
            string sql = "INSERT INTO Types(FoodTypeName) VALUES('"+foodTypeName+"')";
            int result = this.ExecuteQuery(sql);
            if(result>0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteNewFoodType(int foodTypeId)
        {
            string sql = "DELETE FROM Types WHERE FoodTypeId="+foodTypeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public string GetFoodTypeNameById(int foodTypeId)
        {
            string sql = "SELECT * FROM Types WHERE FoodTypeId=" + foodTypeId;
            SqlDataReader reader = this.GetData(sql);
            if(reader.Read())
            {
                return reader["FoodTypeName"].ToString();
            }
            return null;
        }

        public bool UpdateNewFoodType(int foodTypeId, string foodTypeName)
        {
            string sql = "UPDATE Types SET FoodTypeName='"+foodTypeName+"' WHERE FoodTypeId="+foodTypeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
