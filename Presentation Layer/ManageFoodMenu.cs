using Restaurant_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Presentation_Layer
{
    public partial class ManageFoodMenu : Form
    {
        public ManageFoodMenu()
        {
            InitializeComponent();
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodMenuListDataGridView.DataSource = foodDataAccess.GetAllFoods();
            foodDataAccess = new FoodDataAccess();
            addTypeNameComboBox.DataSource = foodDataAccess.GetAllFoodTypeNames();
            foodDataAccess = new FoodDataAccess();
            updateFoodTypeComboBox.DataSource = foodDataAccess.GetAllFoodTypeNames();

        }

        private void ManageFoodMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void UpdateFoodList()
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodMenuListDataGridView.DataSource = foodDataAccess.GetAllFoods();
        }

        private void ManageFoodMenu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            int foodTypeId = foodDataAccess.GetFoodTypeIdByName(addTypeNameComboBox.Text);
            if(foodTypeId>0)
            {
                foodDataAccess = new FoodDataAccess();
                if (foodDataAccess.AddNewFood(addFoodMenuTextBox.Text, Convert.ToDouble(addFoodPriceTextBox.Text), foodTypeId))
                {
                    MessageBox.Show("Food added");
                    UpdateFoodList();
                }
                else
                {
                    MessageBox.Show("Errore in adding");
                }
            }
            else 
            {
                MessageBox.Show("Food Type Not Found");
            }
        }

        private void foodMenuListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteFoodButton_Click(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            Food food = foodDataAccess.GetFoodById(Convert.ToInt32(deleteFoodIdTextBox.Text));
            if(food==null)
            {
                MessageBox.Show("Food is not found");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete the following food ?", "Confirmation", MessageBoxButtons.YesNo);
                if(dialogResult==DialogResult.Yes)
                {
                    foodDataAccess = new FoodDataAccess();
                    if (foodDataAccess.DeleteFood(food.FoodId))
                    {
                        MessageBox.Show("Food deleted");
                        UpdateFoodList();
                    }
                    else
                    {
                        MessageBox.Show("Errore in dleting");
                    }
                }
            }
            

        }

        private void foodMenuListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateFoodIdTextBox.Text = foodMenuListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateFoodMenuTextBox.Text = foodMenuListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updatePriceTextBox.Text = foodMenuListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            int foodTYpeId = (int)foodMenuListDataGridView.Rows[e.RowIndex].Cells[3].Value;
            TypeDataAccess typeDataAccess = new TypeDataAccess();
            string foodTypeName = typeDataAccess.GetFoodTypeNameById(foodTYpeId);
            updateFoodTypeComboBox.Text =foodTypeName;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            int foodTypeId = foodDataAccess.GetFoodTypeIdByName(updateFoodTypeComboBox.Text);
            if (foodTypeId > 0)
            {
                foodDataAccess = new FoodDataAccess();
                if (foodDataAccess.UpdateFood(Convert.ToInt32(updateFoodIdTextBox.Text),updateFoodMenuTextBox.Text,Convert.ToDouble(updatePriceTextBox.Text),foodTypeId))
                {
                    MessageBox.Show("Food updated");
                    UpdateFoodList();
                }
                else
                {
                    MessageBox.Show("Errore in updateing");
                }
            }
            else
            {
                MessageBox.Show("Food Type Not Found");
            }
        }

        private void searchFoodNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            searchFoodDataGridView.DataSource = foodDataAccess.GetFoodsByName(searchFoodNameTextBox.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            this.Hide();
        }
    }
}
