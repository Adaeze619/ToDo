using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TodoApp
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private readonly SqlConnection sqlConnection;
        private int selecteTaskId;
       

        //private readonly TaskAppContext _context;

        public Form1()
        {
          
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myListConnection"].ConnectionString);
          
        }

        //public Form1(DbContextOptions<TaskAppContext> dbContextOptions)
        //{
        //    this.dbContextOptions = dbContextOptions;
        //}

        private void LoadAllTask()
        {
            
            
            try
            {
                string selectQuery = "SELECT * FROM ViewTable";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, sqlConnection);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                TodoView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }


        public void DeleteTask(int taskId)
        {
            if (TodoView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one or more tasks to delete");
                return;
            }





            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected task(s) ?", "Confirm delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                List<int> selectedTaskIds = new List<int>();
                foreach (DataGridViewRow row in (TodoView.SelectedRows))
                {
                    int taskIdToDelete = Convert.ToInt32(row.Cells["ID"].Value);
                    selectedTaskIds.Add(taskIdToDelete);
                }





                string deleteQuery = "DELETE FROM ViewTable WHERE ID IN (" + string.Join(",", selectedTaskIds) + ")";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("SelectedTask(s) deleted successfully");





                        LoadTask();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }





                }
            }
        }


        private async Task LoadTask()
        {





            string selectQuery = "SELECT * FROM ViewTable";



            SqlDataAdapter adapter = await Task.Run(() => new SqlDataAdapter(selectQuery, sqlConnection));
            DataTable dataTable = new DataTable();





            adapter.Fill(dataTable);





            TodoView.DataSource = dataTable;





        }


        private DataTable SearchTask(string searchWord)
        {
            DataTable searchResults = new DataTable();
            try
            {
                string selectQuery = "SELECT * FROM ViewTable WHERE Title LIKE @SearchWord OR Description LIKE @SearchWord";
                using (SqlCommand cmd = new SqlCommand(selectQuery, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@SearchWord", "%" + searchWord + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(searchResults);





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);





            }
            return searchResults;
        }

        private void UpdateTask(int taskId, string newTitle, string newDescription, DateTime newStartDate, DateTime newEndDate)
        {
            try
            {
                string updateQuery = "UPDATE ViewTable SET Title = @NewTitle, Description = @NewDescription, StartDate = @NewStartDate, EndDate = @NewEndDate WHERE ID = @TaskId";
                //string updateQuery = "UPDATE ViewTable SET Title = @NewTitle, Description = @NewDescription, ID = @TaskId , StartDate = @NewStartDate, EndDate = @NewEndDate";
                using (SqlCommand cmd = new SqlCommand(updateQuery, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@NewTitle", newTitle);
                    cmd.Parameters.AddWithValue("@NewDescription", newDescription);
                    cmd.Parameters.AddWithValue("@TaskId", taskId);
                    cmd.Parameters.AddWithValue("@NewStartDate", newStartDate);
                    cmd.Parameters.AddWithValue("@NewEndDate", newEndDate);





                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            // Get data from textboxes
            string title = TitleBox.Text;
            string description = DescriptionBox.Text;
            DateTime StartDate = (DateTime)StartDateBox.Value;
            DateTime EndDate = (DateTime)EndDateBox.Value;
            int ID = 1;





            // If nothing is written
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Please enter a title");
                    TitleBox.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter a description");
                    DescriptionBox.Focus();
                }
                return;
            }





            if (selecteTaskId > 0)
            {
                UpdateTask(selecteTaskId, title, description, StartDate, EndDate);
                MessageBox.Show("Updated successfully");
                TitleBox.Text = "";
                DescriptionBox.Text = "";
                StartDateBox.Value = StartDate;
                EndDateBox.Value = EndDate;
                selecteTaskId = 0;
                LoadTask();
            }
            else
            {
                // Query the database to find the maximum existing ID
                string maxIdQuery = "SELECT MAX(ID) FROM ViewTable";
                using (SqlCommand getMaxIdCmd = new SqlCommand(maxIdQuery, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        object result = getMaxIdCmd.ExecuteScalar();





                        if (result != DBNull.Value) // Check if there are existing records
                        {
                            ID = Convert.ToInt32(result) + 1; // Increment the maximum ID
                        }





                        // Create a query to add the task to the database
                        string insertQuery = "INSERT INTO ViewTable (ID, Title, Description, StartDate, EndDate) VALUES (@ID, @Title, @Description, @StartDate, @EndDate)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@ID", ID);
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.Parameters.AddWithValue("@StartDate", StartDate);
                            cmd.Parameters.AddWithValue("@EndDate", EndDate);





                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Added successfully");





                                TitleBox.Text = "";
                                DescriptionBox.Text = "";





                                LoadTask();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error " + ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void LoadAllTodo_Click_1(object sender, EventArgs e)
        {
            LoadAllTask();
        }

        private void DeleteTodo_Click_1(object sender, EventArgs e)
        {
            if (TodoView.SelectedRows.Count > 0)
            {
                int selectedTaskId = Convert.ToInt32(TodoView.SelectedRows[0].Cells["ID"].Value);
                DeleteTask(selectedTaskId);
                LoadTask();
            }
            else
            {
                MessageBox.Show("Please select a task to delete");
            }
        }

        private void EditTodo_Click_1(object sender, EventArgs e)
        {
            if (TodoView.SelectedRows.Count > 0)
            {
                selecteTaskId = Convert.ToInt32(TodoView.SelectedRows[0].Cells["ID"].Value);





                string existingTitle = TodoView.SelectedRows[0].Cells["Title"].Value.ToString();
                string existingDescription = TodoView.SelectedRows[0].Cells["Description"].Value.ToString();
                DateTime existingStartDate = (DateTime)(TodoView.SelectedRows[0].Cells["StartDate"].Value);
                DateTime existingEndDate = (DateTime)(TodoView.SelectedRows[0].Cells["EndDate"].Value);







                TitleBox.Text = existingTitle;
                DescriptionBox.Text = existingDescription;
                StartDateBox.Value = existingStartDate;
                EndDateBox.Value = existingEndDate;





            }
            else
            {
                MessageBox.Show("Please select a task to edit");
            }
        }

        private void SearchTodo_Click_1(object sender, EventArgs e)
        {
            string searchWord = SearchBox.Text.Trim();





            if (string.IsNullOrEmpty(searchWord))
            {
                MessageBox.Show("Please enter a search key word");
                return;
            }





            DataTable searchResults = SearchTask(searchWord);





            TodoView.DataSource = searchResults;
            SearchBox.Clear();
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}