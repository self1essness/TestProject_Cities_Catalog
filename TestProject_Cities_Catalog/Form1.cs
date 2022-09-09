using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestProject_Cities_Catalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Design of TextBoxes

            DictrictTextBox.ForeColor = Color.Gray;
            DictrictTextBox.Text = "Введите округ";

            RegionTextBox.ForeColor = Color.Gray;
            RegionTextBox.Text = "Введите регион";

            CityTextBox.ForeColor = Color.Gray;
            CityTextBox.Text = "Введите город";
            #endregion

            onOpen();
        }

        #region Design of TextBoxes

        private void DictrictTextBox_Enter(object sender, EventArgs e)
        {
            if (DictrictTextBox.Text == "Введите округ")
            {
                DictrictTextBox.ForeColor = Color.Black;
                DictrictTextBox.Text = "";
            }

        }
        private void DictrictTextBox_Leave(object sender, EventArgs e)
        {
            if (DictrictTextBox.Text == "")
            {
                DictrictTextBox.ForeColor = Color.Gray;
                DictrictTextBox.Text = "Введите округ";
            }
        }

        private void RegionTextBox_Enter(object sender, EventArgs e)
        {
            if (RegionTextBox.Text == "Введите регион")
            {
                RegionTextBox.ForeColor = Color.Black;
                RegionTextBox.Text = "";
            }
        }
        private void RegionTextBox_Leave(object sender, EventArgs e)
        {
            if (RegionTextBox.Text == "")
            {
                RegionTextBox.ForeColor = Color.Gray;
                RegionTextBox.Text = "Введите регион";
            }
        }

        private void CityTextBox_Enter(object sender, EventArgs e)
        {
            if (CityTextBox.Text == "Введите город")
            {
                CityTextBox.ForeColor = Color.Black;
                CityTextBox.Text = "";
            }
        }
        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            if (CityTextBox.Text == "")
            {
                CityTextBox.ForeColor = Color.Gray;
                CityTextBox.Text = "Введите город";
            }
        }
        #endregion


        private void onOpen()
        {
            DistrictListBox.Items.Clear();

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT name FROM `districts`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow[] districts = table.Select();
            foreach (DataRow row in districts)
            {
                DistrictListBox.Items.Add(row[0].ToString());
            }
            DistrictListBox.SetSelected(0, true);
        }


        private void DistrictListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DistrictListBox.SelectedItem == null)
                return;

            RegionListBox.Items.Clear();
            string selectedDistrict = DistrictListBox.SelectedItem.ToString();

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT regions.name FROM regions JOIN districts ON regions.id_district = districts.id WHERE districts.name = @district", db.getConnection());

            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = selectedDistrict;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 0)
            {
                RegionListBox.Items.Clear();
                CityListBox.Items.Clear();
                MessageBox.Show($"Не внесено ни одного региона для выбраного округа");
                return;
            }

            DataRow[] regions = table.Select();
            foreach (DataRow row in regions)
            {
                RegionListBox.Items.Add(row[0].ToString());
            }
            RegionListBox.SetSelected(0, true);
        }
        private void RegionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegionListBox.SelectedItem == null)
                return;

            CityListBox.Items.Clear();
            string selectedRegion = RegionListBox.SelectedItem.ToString();

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT cities.name, regions.name FROM cities JOIN regions ON cities.id_region = regions.id WHERE regions.name = @region", db.getConnection());

            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = selectedRegion;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                CityListBox.Items.Clear();
                MessageBox.Show($"Не внесено ни одного города для выбраного округа");
                return;
            }

            DataRow[] cities = table.Select();

            foreach (DataRow row in cities)
            {
                CityListBox.Items.Add(row[0].ToString());
            }
        }
        private void CityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityListBox.SelectedItem == null)
                return;

            string selectedCity = CityListBox.SelectedItem.ToString();

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT population FROM cities WHERE name = @city", db.getConnection());

            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = selectedCity;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MessageBox.Show($"Город: {selectedCity}\nНаселение: {table.Rows[0][0]} человек");
        }


        private void AddDistrict_Click(object sender, EventArgs e)
        {
            string addDistrict = DictrictTextBox.Text.ToString();

            if (addDistrict == "Введите округ")
            {
                MessageBox.Show("Вы не ввели название округа");
                return;
            }
            if (IsDistrictExists(addDistrict))
            {
                MessageBox.Show($"Такой округ уже существует");
                return;
            }
                

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO districts (name) VALUES (@district)", db.getConnection());

            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = addDistrict;

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                onOpen();
                MessageBox.Show($"Округ добавлен");
            }
            else
                MessageBox.Show("Ошибка");

            db.closeConnection();
        }
        private void DeleteDistrict_Click(object sender, EventArgs e)
        {
            string deleteDistrict = DictrictTextBox.Text.ToString();

            if (deleteDistrict == "Введите округ")
            {
                MessageBox.Show("Вы не ввели название округа");
                return;
            }
            if (!IsDistrictExists(deleteDistrict))
            {
                MessageBox.Show($"Такого округа не существует");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Удалятся все регионы и города относящиеся к этому округу.\nВы уверены? ", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("DELETE FROM cities WHERE id_region IN ( SELECT id FROM regions WHERE id_district in (SELECT id FROM districts WHERE name = @district))", db.getConnection());
            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = deleteDistrict;

            db.openConnection();
            int numberOfRemovedCities = command.ExecuteNonQuery();
            db.closeConnection();

            command = new MySqlCommand("DELETE FROM regions WHERE id_district IN (SELECT id FROM districts WHERE name = @district)", db.getConnection());
            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = deleteDistrict;

            db.openConnection();
            int numberOfRemovedRegions = command.ExecuteNonQuery();
            db.closeConnection();

            command = new MySqlCommand("DELETE FROM districts WHERE name = @district", db.getConnection());
            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = deleteDistrict;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                onOpen();

                MessageBox.Show($"Округ под названием {deleteDistrict} удалён. \n Удалено {numberOfRemovedCities} городов и {numberOfRemovedRegions} регионов относящихся к этому региону.");
            }

            db.closeConnection();


        }
        private bool IsDistrictExists(string district)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM districts WHERE name = @district", db.getConnection());

            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = district;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }


        private void AddRegion_Click(object sender, EventArgs e)
        {
            string selectedDistrict = DistrictListBox.Text.ToString();
            string addRegion = RegionTextBox.Text.ToString();

            if (addRegion == "Введите регион")
            {
                MessageBox.Show("Вы не ввели название региона");
                return;
            }
            if (IsRegionExists(addRegion, selectedDistrict))
            {
                MessageBox.Show($"Такой регион уже существует");
                return;
            }

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT id FROM districts WHERE name = @district", db.getConnection());
            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = selectedDistrict;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow district_id = table.Rows[0];

            command = new MySqlCommand("INSERT INTO regions (name, id_district) VALUES (@region, @districtId)", db.getConnection());
            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = addRegion;
            command.Parameters.Add("@districtId", MySqlDbType.UInt32).Value = district_id[0];

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                onOpen();
                MessageBox.Show($"Регион добавлен");
            }
            else
                MessageBox.Show("Ошибка");

            db.closeConnection();
        }
        private void DeleteRegion_Click(object sender, EventArgs e)
        {
            string deleteRegion = RegionTextBox.Text.ToString();
            string selectedDistrict = DistrictListBox.Text.ToString();

            if (deleteRegion == "Введите регион")
            {
                MessageBox.Show("Вы не ввели название регион");
                return;
            }
            if (!IsRegionExists(deleteRegion, selectedDistrict))
            {
                MessageBox.Show($"Такого региона в округе под названием \"{selectedDistrict}\" не существует");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Удалятся все города относящиеся к этому региону.\nВы уверены? ", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("DELETE FROM cities WHERE id_region IN ( SELECT id FROM regions WHERE name = @region)", db.getConnection());
            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = deleteRegion;

            db.openConnection();
            int numberOfRemovedCities = command.ExecuteNonQuery();
            db.closeConnection();

            command = new MySqlCommand("DELETE FROM regions WHERE name = @region", db.getConnection());
            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = deleteRegion;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                onOpen();
                MessageBox.Show($"Регион под названием {deleteRegion} был удалён. \nУдалено {numberOfRemovedCities} городов, относящихся к этому региону.");
            }

            db.closeConnection();
        }
        private bool IsRegionExists(string region, string district)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM regions WHERE name = @region AND id_district IN (SELECT id FROM districts WHERE name = @district) ", db.getConnection());

            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = region;
            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = district;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void AddCity_Click(object sender, EventArgs e)
        {
            string selectedRegion = RegionListBox.Text.ToString();
            string selectedDistrict = DistrictListBox.Text.ToString();
            string addCity = CityTextBox.Text.ToString();

            if (CityTextBox.Text == "Введите город")
            {
                MessageBox.Show("Вы не ввели название региона");
                return;
            }
            if (IsCityExists(selectedRegion, selectedDistrict, addCity))
            {
                MessageBox.Show($"Такой город уже существует");
                return;
            }

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT id FROM regions WHERE name = @region", db.getConnection());
            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = selectedRegion;

            adapter.SelectCommand = command;
            adapter.Fill(table);

                DataRow region_id = table.Rows[0];

            command = new MySqlCommand("INSERT INTO cities (name, id_region, population) VALUES (@city, @region_id, 0)", db.getConnection());
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = addCity;
            command.Parameters.Add("@region_id", MySqlDbType.UInt32).Value = region_id[0];

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                onOpen();
                MessageBox.Show($"Город добален");
            }
            else
                MessageBox.Show("Ошибка");

            db.closeConnection();

        }
        private void DeleteCity_Click(object sender, EventArgs e)
        {
            string deleteCity = CityTextBox.Text.ToString();
            string selectedRegion = RegionListBox.Text.ToString();
            string selectedDistrict = DistrictListBox.Text.ToString();

            if (deleteCity == "Введите город")
            {
                MessageBox.Show("Вы не ввели название города");
                return;
            }
            if (!IsCityExists(selectedRegion, selectedDistrict, deleteCity))
            {
                MessageBox.Show($"Такого города в регионе под названием \"{selectedRegion}\" не существует!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить этот город?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("DELETE FROM cities WHERE name = @city", db.getConnection());
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = deleteCity;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                onOpen();
                MessageBox.Show($"Город удалён!", "Сообщение");
            }

            db.closeConnection();
        }
        private bool IsCityExists(string region, string district, string city)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM cities WHERE name = @city AND id_region IN (SELECT id FROM regions WHERE name = @region AND id_district IN (SELECT id FROM districts WHERE name = @district))", db.getConnection());

            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = region;
            command.Parameters.Add("@district", MySqlDbType.VarChar).Value = district;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
