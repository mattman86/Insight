using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Insight
{
    public partial class EmployeeInfo : Form
    {
        private static SqlConnection conn = new SqlConnection("Data Source=" + ConfigurationManager.AppSettings["DBServer"] + ";Initial Catalog=" + ConfigurationManager.AppSettings["DBName"] + ";Integrated Security=True; MultipleActiveResultSets=True");
        private SqlCommand command = new SqlCommand("", conn);
        private SqlDataReader reader;

        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            FillEmployeeIDComboBox();
        }

        private void FillEmployeeIDComboBox()
        {
            conn.Open();

            command.CommandText = "SELECT EmployeeID, FirstName, LastName FROM Employees ORDER BY EmployeeID";

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] emp = comboBox1.SelectedItem.ToString().Split(' ');

            conn.Open();

            command.CommandText = "SELECT FirstName, LastName, Position, Address1, Address2, City, State, Zip, MobilePhone, HomePhone, WorkPhone, Email FROM Employees WHERE EmployeeId='" + emp[0] + "'";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                empName.Text = reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString() + ", " + reader.GetValue(2).ToString();

                empAddress.Text = reader.GetValue(3).ToString() + Environment.NewLine +
                    reader.GetValue(4).ToString() + Environment.NewLine +
                    reader.GetValue(5).ToString() + ", " + reader.GetValue(6).ToString() + " " + reader.GetValue(7).ToString();

                empPhone.Text = "M: " + reader.GetValue(8).ToString() + Environment.NewLine +
                    "H: " + reader.GetValue(9).ToString() + Environment.NewLine +
                    "W: " + reader.GetValue(10).ToString();

                empEmail.Text = reader.GetValue(11).ToString();
            }
            reader.Close();

            assignedWOs.Rows.Clear();
            command.CommandText = "SELECT WorkOrderID, CustomerID, Title FROM WorkOrders WHERE EmployeeID='" + emp[0] + "'";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                assignedWOs.Rows.Add(reader.GetValue(0).ToString(), GetCustomerName(reader.GetValue(1).ToString()), reader.GetValue(2).ToString());
            }
            reader.Close();

            conn.Close();
        }

        public string GetCustomerName(string ID)
        {
            SqlCommand command2 = new SqlCommand("SELECT FirstName + ' ' + LastName FROM Customers WHERE CustomerID=" + ID, conn);
            string name = command2.ExecuteScalar().ToString();

            return name;
        }

        private void assignedWOs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}