using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Data_Access_Layer
{
    class Food
    {
        public int FoodId { get; set; }
        public string Menu { get; set; }
        public double Price { get; set; }
        public int FoodTypeId { get; set; }

    }
}
