using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHChoThueBangDia.DAO
{
    internal class DataProvider
    {
        //Tạo 1 Design Pattern Singleton

        private static DataProvider instance; //Đóng gói : Ctrl + R + E

        internal static DataProvider Instance
        {
            get 
            { 
                if (instance == null) 
                    instance = new DataProvider(); //Tạo 1 instance
                return DataProvider.instance; 
            }
            private set => instance = value; //Chỉ trong lớp này mới được set
        }

        private DataProvider() { } //Hàm dựng phục vụ cho Singleton, chỉ lớp này mới được tạo

        private string connectionStr = @"Data Source=.\MSSQLSERVER01;Initial Catalog=QuanLyCuaHangBangDia;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null )
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach ( string item in listPara  ) 
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);

                connection.Close();

                // Tham số truyền vào là 1 query, 1 mảng object para chứa userName, passWord
                // listPara chứa những tham số của thủ tục có dạng @
                // sau đó vòng foreach sẽ add tham số đó và giá trị trong mảng parameter tương ứng
                // 
                // adapter được fill bình thường
            }
            
            return table;
        } // Trả ra số dòng kết quả 

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        } // Trả về số dòng được thực thi

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        } // Trả ra cột có số kết quả 
    }
}
