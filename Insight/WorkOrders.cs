using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Insight
{
    public partial class WorkOrders : Form
    {
        private static SqlConnection conn = new SqlConnection("Data Source=" + ConfigurationManager.AppSettings["DBServer"] + ";Initial Catalog=" + ConfigurationManager.AppSettings["DBName"] + ";Integrated Security=True; MultipleActiveResultSets=True");
        private SqlCommand command = new SqlCommand("", conn);
        private SqlDataReader reader;

        public WorkOrders()
        {
            InitializeComponent();
        }

        private void WorkOrders_Load(object sender, EventArgs e)
        {
            FillWorkOrdersList("true");
        }

        public string GetEmployeeName(string ID)
        {
            string name;
            try
            {
                SqlCommand command2 = new SqlCommand("SELECT FirstName + ' ' + LastName FROM Employees WHERE EmployeeID=" + ID, conn);
                name = command2.ExecuteScalar().ToString();
            }
            catch
            {
                name = "";
            }

            return name;
        }

        public string GetCustomerName(string ID)
        {
            SqlCommand command2 = new SqlCommand("SELECT FirstName + ' ' + LastName FROM Customers WHERE CustomerID=" + ID, conn);
            string name = command2.ExecuteScalar().ToString();

            return name;
        }

        private void dgWorkOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            command.CommandText = "SELECT Title, Description FROM WorkOrders WHERE WorkOrderId='" + dgWorkOrders.Rows[dgWorkOrders.CurrentRow.Index].Cells[0].Value.ToString() + "'";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                wOTitle.Text = reader.GetValue(0).ToString();

                tbDescription.Text = reader.GetValue(1).ToString();
            }
            reader.Close();

            tbComments.Clear();
            command.CommandText = "SELECT Date, EmployeeID, Comment FROM Comments WHERE WorkOrderId='" + dgWorkOrders.Rows[dgWorkOrders.CurrentRow.Index].Cells[0].Value.ToString() + "' ORDER BY Date DESC";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbComments.Text += "----" + reader.GetValue(0).ToString() + " | " + GetEmployeeName(reader.GetValue(1).ToString()) + "----" + Environment.NewLine
                    + reader.GetValue(2).ToString() + Environment.NewLine + Environment.NewLine;
            }
            reader.Close();

            lbSteps.Items.Clear();
            command.CommandText = "SELECT [Order], Step FROM StepsToREcreate WHERE WorkOrderId='" + dgWorkOrders.Rows[dgWorkOrders.CurrentRow.Index].Cells[0].Value.ToString() + "' ORDER BY [Order]";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lbSteps.Items.Add(reader.GetValue(0).ToString() + ". " + reader.GetValue(1).ToString());
            }
            reader.Close();

            conn.Close();
        }

        private void FillWorkOrdersList(string ShowOption)
        {
            dgWorkOrders.Rows.Clear();

            string[] date;

            conn.Open();

            command.CommandText = "SELECT WorkOrderID, Date, CustomerID, EmployeeID, Title FROM WorkOrders WHERE [Open] IN ('" + ShowOption + "') ORDER BY WorkOrderID";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                date = reader.GetValue(1).ToString().Split(' ');

                dgWorkOrders.Rows.Add(reader.GetValue(0).ToString(), date[0], GetCustomerName(reader.GetValue(2).ToString()), GetEmployeeName(reader.GetValue(3).ToString()), reader.GetValue(4).ToString());
            }
            reader.Close();

            conn.Close();
        }

        private void cbShowOption_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowOption.Checked)
            {
                FillWorkOrdersList("true");
            }
            else
            {
                FillWorkOrdersList("true', 'false");
            }
        }

        private void btnCloseWorkOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you wish to close this work order?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                command.CommandText = "UPDATE WorkOrders SET [Open] = 0, Completed = 1 WHERE WorkOrderID = " + dgWorkOrders.Rows[dgWorkOrders.CurrentRow.Index].Cells[0].Value.ToString();
                command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO Comments ([Date], Comment, WorkOrderID) VALUES ('" + DateTime.Now + "', 'Work order closed by " + GetUserName(Environment.UserName) + ".', " + dgWorkOrders.Rows[dgWorkOrders.CurrentRow.Index].Cells[0].Value.ToString() + ")";
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        private string GetUserName(string userName)
        {
            string userFullName = "Administrator";
            switch (userName)
            {
                case "matthew":
                    userFullName = "Matthew Despain";
                    break;
                case "meghan":
                    userFullName = "Meghan Despain";
                    break;
            }

            return userFullName;
        }
    }
}