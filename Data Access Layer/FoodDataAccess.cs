using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Data_Access_Layer
{
    class FoodDataAccess:DataAccess
    {
        public List<Food> GetAllFoods()
        {
            string sql = "SELECT * FROM Foods";
            SqlDataReader reader = this.GetData(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {    
                Food food = new Food();
                food.FoodId = (int)reader["FoodId"];
                food.Menu = reader["Menu"].ToString();
                food.Price = Convert.ToDouble(reader["Price"]);
                food.FoodTypeId = (int)reader["FoodTypeId"];
                foods.Add(food);
            }
            return foods;
        }

        public bool AddNewFood(string menu,double price,int foodTypeId)
        {
            string sql = "INSERT INTO Foods(Menu,Price,FoodTypeId) VALUES('" + menu + "'," + price + "," + foodTypeId + ")";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteFood(int foodId)
        {
            string sql = "DELETE FROM Foods WHERE FoodId=" + foodId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public Food GetFoodById(int foodId)
        {
            string sql = "SELECT * FROM Foods WHERE FoodId="+foodId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            { 
                Food food = new Food();
                food.FoodId = (int)reader["FoodId"];
                food.Menu = reader["Menu"].ToString();
                food.Price = Convert.ToDouble(reader["Price"]);
                food.FoodTypeId = (int)reader["FoodTypeId"];
                return food;
            }
            return null;
        }
        public bool UpdateFood(int foodId, string menu, double price, int foodTypeId)
        {
            string sql = "UPDATE Foods SET Menu='"+menu+"',Price="+price+",FoodTypeId="+foodTypeId+" WHERE FoodId="+foodId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public List<string> GetAllFoodTypeNames()
        {
            string sql = "SELECT * FROM Types";
            SqlDataReader reader = this.GetData(sql);
            List<string> foodTypeName = new List<string>();
            while (reader.Read())
            {

                foodTypeName.Add(reader["FoodTypeName"].ToString());
            }
            return foodTypeName;
        }
        public int GetFoodTypeIdByName(string foodTypeName)
        {
            string sql = "SELECT * FROM Types WHERE FoodTypeName='"+foodTypeName+"'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return (int)reader["FoodTypeId"];
            }
            return -1;
        }

        public List<Food> GetAllFoodsbyFoodTypeId(int foodTypeId)
        {
            string sql = "SELECT * FROM Foods WHERE FoodTypeId="+foodTypeId;
            SqlDataReader reader = this.GetData(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.FoodId = (int)reader["FoodId"];
                food.Menu = reader["Menu"].ToString();
                food.Price = Convert.ToDouble(reader["Price"]);
                food.FoodTypeId = (int)reader["FoodTypeId"];
                foods.Add(food);
            }
            return foods;
        }
        public List<Food> GetFoodsByName(string foodName)
        {
            string sql = "SELECT * FROM Foods WHERE Menu Like '"+foodName+"%'";
            SqlDataReader reader = this.GetData(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.FoodId = (int)reader["FoodId"];
                food.Menu = reader["Menu"].ToString();
                food.Price = Convert.ToDouble(reader["Price"]);
                food.FoodTypeId = (int)reader["FoodTypeId"];
                foods.Add(food);
            }
            return foods;
        }
    }
}
