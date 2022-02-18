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
    public partial class ManageFoodType : Form
    {
        public ManageFoodType()
        {
            InitializeComponent();
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            foodTypeWiseMenuListComboBox.DataSource = foodDataAccess.GetAllFoodTypeNames();
        }

        private void ManageFoodType_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageFoodType_Load(object sender, EventArgs e)
        {
            LoadFoodTypeList();
            foodTypeWiseMenuListComboBox.SelectedIndex = -1;
        }

        void LoadFoodTypeList()
        {
            TypeDataAccess typeDataAccess = new TypeDataAccess();
            foodTypeListDataGridView.DataSource = typeDataAccess.GetAllTypes();
        }

        private void addFoodTypeButton_Click(object sender, EventArgs e)
        {
            TypeDataAccess typeDataAccess = new TypeDataAccess();
            if(typeDataAccess.AddNewFoodType(addFoodTypeNameTextBox.Text))
            {
                MessageBox.Show("Food Type added");
                LoadFoodTypeList();
            }
            else
            {
                MessageBox.Show("Errore in adding");
            }
        }

        private void deleteFoodTypeButton_Click(object sender, EventArgs e)
        {
            TypeDataAccess typeDataAccess = new TypeDataAccess();
            if (typeDataAccess.DeleteNewFoodType(Convert.ToInt32(deleteFoodTypeTextBox.Text)))
            {
                MessageBox.Show("Food Type deleted");
                LoadFoodTypeList();
            }
            else
            {
                MessageBox.Show("Errore in deleting");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            TypeDataAccess typeDataAccess = new TypeDataAccess();
            string value = typeDataAccess.GetFoodTypeNameById(Convert.ToInt32(searchFoodTypeTextBox.Text));
            if (value==null)
            {
                MessageBox.Show("Food Type Not Found");
                updateFoodTypeNameTextBox.Text = "";

            }
            else
            {
                updateFoodTypeNameTextBox.Text = value;
            }
        }

        private void updateFoodTypeNameButton_Click(object sender, EventArgs e)
        {
            if((searchFoodTypeTextBox.Text == "") || (updateFoodTypeNameTextBox.Text == ""))
            {
                MessageBox.Show("Searce proper Food Type To Update");
            }
            else
            {
                TypeDataAccess typeDataAccess = new TypeDataAccess();
                if (typeDataAccess.UpdateNewFoodType(Convert.ToInt32(searchFoodTypeTextBox.Text),updateFoodTypeNameTextBox.Text))
                {
                    MessageBox.Show("Food Type Updated");
                    LoadFoodTypeList();
                }
                else
                {
                    MessageBox.Show("Errore in Updateing");
                }
            }
        }

        private void foodTypeWiseMenuListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodDataAccess foodDataAccess = new FoodDataAccess();
            int foodTyprId = foodDataAccess.GetFoodTypeIdByName(foodTypeWiseMenuListComboBox.Text);
            foodDataAccess = new FoodDataAccess();
            foodTypeWiseMenuListDataGridView.DataSource = foodDataAccess.GetAllFoodsbyFoodTypeId(foodTyprId);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            this.Hide();
        }
    }
}
