using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Insight
{
    public partial class CustomerInfo : Form
    {
        private static SqlConnection conn = new SqlConnection("Data Source=" + ConfigurationManager.AppSettings["DBServer"] + ";Initial Catalog=" + ConfigurationManager.AppSettings["DBName"] + ";Integrated Security=True; MultipleActiveResultSets=True");
        private SqlCommand command = new SqlCommand("", conn);
        private SqlDataReader reader;

        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            FillCustomerIDComboBox();
        }

        private void FillCustomerIDComboBox()
        {
            conn.Open();

            command.CommandText = "SELECT CustomerID, FirstName, LastName FROM Customers ORDER BY CustomerID";

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cust = comboBox1.SelectedItem.ToString().Split(' ');

            conn.Open();

            command.CommandText = "SELECT FirstName, LastName, Address1, Address2, City, State, Zip, MobilePhone, HomePhone, WorkPhone, Email FROM Customers WHERE CustomerId='" + cust[0] + "'";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                custName.Text = reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString();

                custAddress.Text = reader.GetValue(2).ToString() + Environment.NewLine +
                    reader.GetValue(3).ToString() + Environment.NewLine +
                    reader.GetValue(4).ToString() + ", " + reader.GetValue(5).ToString() + " " + reader.GetValue(6).ToString();

                custPhone.Text = "M: " + reader.GetValue(7).ToString() + Environment.NewLine +
                    "H: " + reader.GetValue(8).ToString() + Environment.NewLine +
                    "W: " + reader.GetValue(9).ToString();

                custEmail.Text = reader.GetValue(10).ToString();
            }
            reader.Close();

            openWOs.Rows.Clear();
            command.CommandText = "SELECT WorkOrderID, EmployeeID, Title FROM WorkOrders WHERE CustomerID='" + cust[0] + "'";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                openWOs.Rows.Add(reader.GetValue(0).ToString(), GetEmployeeName(reader.GetValue(1).ToString()), reader.GetValue(2).ToString());
            }
            reader.Close();

            conn.Close();
        }

        public string GetEmployeeName(string ID)
        {
            SqlCommand command2 = new SqlCommand("SELECT FirstName + ' ' + LastName FROM Employees WHERE EmployeeID=" + ID, conn);
            string name = command2.ExecuteScalar().ToString();

            return name;
        }
    }
}