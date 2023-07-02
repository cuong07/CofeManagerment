using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        //private string connectionStringOfCuong = "Data Source=MANH_CUONG;Initial Catalog=COFFEEMANAGER;Integrated Security=True"; //Cường
        private string connectionStringOfCuong = "Data Source=COONG;Initial Catalog=COFFEEMANAGER;Integrated Security=True";        //Công

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }

        private DataProvider() { }
        // Đây là một hàm tạo private ngăn cản việc khởi tạo trực tiếp của lớp DataProvider từ bên ngoài lớp.

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStringOfCuong)) // Khi kết thúc khối lệnh dữ liệu khai báo được giải phóng
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection); // Chay query trong database


                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int index = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command); // trung gian 
                adapter.Fill(data); // add adapter vào data
                connection.Close();
            }

            return data;
        }
        // Phương thức này ExcuteQuery thực thi một câu truy vấn SQL và trả về kết quả dưới dạng một đối tượng DataTable.
        // Nó nhận một chuỗi truy vấn và một mảng các tham số truy vấn (tùy chọn). Bên trong phương thức,
        // nó tạo một đối tượng SqlConnection sử dụng chuỗi kết nối, mở kết nối và tạo một đối tượng SqlCommand để thực thi truy vấn.
        // Nếu có các tham số, nó thêm chúng vào đối tượng lệnh. Sau đó,
        // nó sử dụng một SqlDataAdapter để điền dữ liệu vào một DataTable từ kết quả truy vấn. Cuối cùng,
        // nó đóng kết nối và trả về đối tượng DataTable

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStringOfCuong)) // Khi kết thúc khối lệnh dữ liệu khai báo được giải phóng
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection); // Chay query trong database


                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int index = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }
        // Phương thức này ExcuteNonQuery thực thi một câu lệnh SQL không trả về kết quả (ví dụ: INSERT, UPDATE, DELETE) và trả về số hàng bị ảnh hưởng.

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStringOfCuong)) // Khi kết thúc khối lệnh dữ liệu khai báo được giải phóng
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection); // Chay query trong database


                if (parameter != null)
                {
                    string[] listParameter = query.Split(' ');
                    int index = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;
        }
        // Phương thức này ExcuteScalar thực thi một câu truy vấn SQL và trả về giá trị đơn (ví dụ: SELECT COUNT(*) FROM...).
        // Nó cũng tương tự như ExcuteQuery, nhưng thay vì sử dụng ExecuteNonQuery,
        // nó sử dụng ExecuteScalar của đối tượng SqlCommand để lấy giá trị đơn duy nhất từ câu truy vấn và gán kết quả vào biến data.
    }
}
