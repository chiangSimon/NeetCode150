
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace ado.net
{
    public class AttendanceHelper
    {
        string connectingString = "Data Source=DESKTOP-H3RAS03;Initial Catalog=Home;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=True;Trust Server Certificate=True;Command Timeout=0";
        string filePath = @"C:\Users\ivonn\source\repos\NeetCode150-2\file\log.txt";


        public void CreateAttendacne()
        {
            string[] lines = File.ReadAllLines(filePath);

            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                string sql = @"insert into attendance  values (@EmployeeId, @EmployeeName, @WorkDay, @ClockInTime, @ClockoutTime)";

                connection.Open();
                // Do work here.
                foreach (string line in lines) 
                {
                    string[] value = line.Split(',');
                    string EmployeeId = value[0];
                    string EmployeeName = value[1];
                    string WorkDay = value[2];
                    string ClockInTime = value[3];
                    string ClockoutTime = value[4];

                }
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
