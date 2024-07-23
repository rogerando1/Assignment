using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Problem1.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

namespace Problem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGrid();
            FillComboBox();
        }

        private void StatusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DataGrid()
        {
            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserID};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();

            string query = "SELECT Students.StudentID, Students.Firstname, Students.Lastname, Students.Address, Students.Age, Students.Gender, StatusTable.StatusCode " +
                           "FROM Students " +
                           "INNER JOIN StatusTable ON StatusTable.StatusID = Students.StatusID";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);
            studentlist.DataSource = dt;
        }

        private void FillComboBox()
        {
            try
            {
                
                StatusSort.Items.Add("(All Students)");
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserID};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT StatusCode FROM StatusTable", connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string eqName = reader.GetString("StatusCode");
                    StatusSort.Items.Add(eqName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StatusSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusSort.SelectedItem == null)
            {
                return;
            }

            if (StatusSort.Text == "(All Students)")
            {
                DataGrid();
            }
            else
            {
                string statuscode = StatusSort.SelectedItem.ToString();
                string connectionString = $"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserID};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "SELECT Students.StudentID, Students.Firstname, Students.Lastname, Students.Age, Students.Address, Students.Gender, StatusTable.StatusCode " +
                                   "FROM Students " +
                                   "INNER JOIN StatusTable ON Students.StatusID = StatusTable.StatusID " +
                                   "WHERE StatusTable.StatusCode = @statuscode";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@statuscode", statuscode);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                studentlist.DataSource = dataTable;
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(FirstNameTxtbx.Text == "" || LastNameTxtbx.Text == "" || AgeTxtbx.Text == "" || GenderTxtbx.Text == "" || AddressTxtbx.Text == "" || StatusCodeTxtbx.Text == "")
                {
                    MessageBox.Show("Please provide all necessary imformation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserID};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "INSERT into Students (Firstname, Lastname, Age, Address, Gender, StatusID) VALUES (@firstname, @lastname, @age, @address, @gender, @statuscode)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstname", FirstNameTxtbx.Text);
                command.Parameters.AddWithValue("@lastname", LastNameTxtbx.Text);
                command.Parameters.AddWithValue("age", AgeTxtbx.Text);
                command.Parameters.AddWithValue("@address", AddressTxtbx.Text);
                command.Parameters.AddWithValue("@gender", GenderTxtbx.Text);
                command.Parameters.AddWithValue("@statuscode", StatusCodeTxtbx.Text);

                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if(rowsAffected > 0)
                {
                    DataGrid();
                    MessageBox.Show("New Students successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    FirstNameTxtbx.Text = "";
                    LastNameTxtbx.Text = "";
                    AgeTxtbx.Text = "";
                    GenderTxtbx.Text = "";
                    AddressTxtbx.Text = "";
                    StatusCodeTxtbx.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to create account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserID};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "UPDATE Students SET Firstname = @firstname, Lastname = @lastname, Age = @age, Gender = @gender, Address = @address, StatusID = @statuscode WHERE StudentID = @studentID";
                MySqlCommand command = new MySqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@firstname", FirstNameTxtbx.Text);
                command.Parameters.AddWithValue("@lastname", LastNameTxtbx.Text);
                command.Parameters.AddWithValue("@age", AgeTxtbx.Text);
                command.Parameters.AddWithValue("@address", AddressTxtbx.Text);
                command.Parameters.AddWithValue("@gender", GenderTxtbx.Text);
                command.Parameters.AddWithValue("@statuscode", StatusCodeTxtbx.Text);
                command.Parameters.AddWithValue("@studentID", StudentIDTxtbx.Text);
                MySqlDataReader reader = command.ExecuteReader();

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                reader.Close();

                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    DataGrid();
                    MessageBox.Show("Student successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentIDTxtbx.Text = "";
                    FirstNameTxtbx.Text = "";
                    LastNameTxtbx.Text = "";
                    AgeTxtbx.Text = "";
                    GenderTxtbx.Text = "";
                    AddressTxtbx.Text = "";
                    StatusCodeTxtbx.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = studentlist.Rows[e.RowIndex];

                StudentIDTxtbx.Text = row.Cells["StudentID"].Value.ToString();
                FirstNameTxtbx.Text = row.Cells["Firstname"].Value.ToString();
                LastNameTxtbx.Text = row.Cells["Lastname"].Value.ToString();
                AgeTxtbx.Text = row.Cells["Age"].Value.ToString();
                AddressTxtbx.Text = row.Cells["Address"].Value.ToString();
                GenderTxtbx.Text = row.Cells["Gender"].Value.ToString();
                StatusCodeTxtbx.Text = row.Cells["StatusID"].Value.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string StudentID = StudentIDTxtbx.Text;

            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserID};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            
                try
                {
                    connection.Open();
                    string queryCheck = "SELECT * FROM Students WHERE StudentID = @studentid";
                    MySqlCommand commandCheck = new MySqlCommand(queryCheck, connection);
                    commandCheck.Parameters.AddWithValue("@studentid", StudentID);

                    MySqlDataReader reader = commandCheck.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                        return;
                    }
                    reader.Close(); // Ensure the reader is closed before proceeding

                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    MySqlConnection con = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserID};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                        con.Open();
                        string queryDelete = "DELETE FROM Students WHERE StudentID = @studentid";
                        MySqlCommand commandDelete = new MySqlCommand(queryDelete, con);
                        commandDelete.Parameters.AddWithValue("@studentid", StudentID);

                        int rowsAffected = commandDelete.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            DataGrid(); // Refresh the DataGrid
                            MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StudentIDTxtbx.Text = "";   
                            FirstNameTxtbx.Text = "";
                            LastNameTxtbx.Text = "";
                            AgeTxtbx.Text = "";
                            GenderTxtbx.Text = "";
                            AddressTxtbx.Text = "";
                            StatusCodeTxtbx.Text = "";
                            }
                        else
                        {
                            MessageBox.Show("Failed to delete student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            StudentIDTxtbx.Text = "";
            FirstNameTxtbx.Text = "";
            LastNameTxtbx.Text = "";
            AgeTxtbx.Text = "";
            GenderTxtbx.Text = "";
            AddressTxtbx.Text = "";
            StatusCodeTxtbx.Text = "";
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (searchData.Text == "")
            {
                DataGrid();
            }
        }

        private void searchDatas(string Search)
        {
            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserID};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();

            string query = "SELECT Students.StudentID, Students.Firstname, Students.Lastname, Students.Age, Students.Gender, Students.Address, StatusTable.StatusCode " +
                            "FROM Students " +
                            "INNER JOIN StatusTable ON Students.StatusID = StatusTable.StatusID " +
                            "WHERE CONCAT (Students.Firstname, Students.Lastname, Students.Age, Students.Gender, Students.Address, StatusTable.StatusCode) LIKE '%" + searchData.Text + "%'";
            
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            if(dt.Rows.Count > 0)
            {
                studentlist.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string Search = searchData.Text.ToString();
            searchDatas(Search);
        }
    }
}
    

