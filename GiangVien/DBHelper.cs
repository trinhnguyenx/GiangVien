using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiangVien
{
    internal class DBHelper
    {
        SqlConnection connection;
        private static DBHelper instance;
        public static DBHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=GIANGVIEN;Integrated Security=True";
                    instance = new DBHelper(connectionString);
                }
                return instance;
            }
        }
        private DBHelper(string _connectionString)
        {
            connection = new SqlConnection(_connectionString);
        }
        private int ExecuteDB(SqlCommand command)
        {
            connection.Open();

            int rv = (int)command.ExecuteNonQuery();

            connection.Close();

            return rv;
        }

        private DataTable GetRecords(SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            connection.Open();
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }
        public DataTable GetProfessorsList(String _SearchText, String _OrderBy = "")
        {
            SqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select distinct GV.[Tên Giảng Viên], GV.[Ngày Sinh], GV.[Giới Tính], GV.[Học Hàm], GV.[Học Vị], GV.[Khoa], HP.[Tên Học Phần]\r\n" +
                "from JUNCTION\r\n" +
                "join HP on JUNCTION.[Mã Học Phần] = HP.[Mã Học Phần]\r\n" +
                "join GV on JUNCTION.[Mã Giảng Viên] = GV.[Mã Giảng Viên]\r\n";

            if (_SearchText != String.Empty)
            {
                cmd.CommandText += "where (CHARINDEX(@SEARCHED_TEXT, GV.[Tên Giảng Viên]) > 0)\r\n\t" +
                    "or (CHARINDEX(@SEARCHED_TEXT, GV.[Học Hàm]) > 0)\r\n\t" +
                    "or (CHARINDEX(@SEARCHED_TEXT, HP.[Tên Học Phần]) > 0)\r\n\t" +
                    "or (CHARINDEX(@SEARCHED_TEXT, HP..[Mã Học Phần]) > 0)";

                cmd.Parameters.Add("@SEARCHED_TEXT", SqlDbType.NVarChar);
                cmd.Parameters["@SEARCHED_TEXT"].Value = _SearchText;
            }

            if (_OrderBy != String.Empty && _OrderBy != "NONE")
            {
                cmd.CommandText += "order by [" + _OrderBy + "]";

            
            }

            return GetRecords(cmd);
        }
        public DataTable GetProfessorsList()
        {
            return GetProfessorsList("", "");
        }
        public bool ProductPrimaryKeyChecker(String _ProfID)
        {
            SqlCommand cmd = connection.CreateCommand();

            cmd.CommandText =
                "select count(*)\r\n" +
                "from GV\r\n" +
                "where [Tên Giảng Viên] = @PROF_Name";

            cmd.Parameters.Add("@PROF_ID", SqlDbType.VarChar);

            cmd.Parameters["@PROF_ID"].Value = _ProfID;

            connection.Open();
            bool check = ((int)cmd.ExecuteScalar() > 0);
            connection.Close();

            return check;
        }
        public void InsertProfessor(String _ProfID, String _ProfName, String _FacName, DateTime _Dtm, bool _Gender, String _HocHam, String _HocVi, String _HocPhan)
        {
            //PK duplicated
            /**
            if (ProductPrimaryKeyChecker(_ProductID) == true)
            {
                throw new Exception("Prof ID is duplicated.");
            } **/


            SqlCommand cmd = connection.CreateCommand();

            cmd.CommandText =
                "insert into GV\r\n" +
                "values(@PROF_ID, @PROF_NAME,@DATE , @FAC_NAME, @HOCHAM, @HOCVI, @GENDER )";

            cmd.Parameters.Add("@PROF_ID", SqlDbType.VarChar);
            cmd.Parameters.Add("@PROF_NAME", SqlDbType.NVarChar);
            cmd.Parameters.Add("@FAC_NAME", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters.Add("@GENDER", SqlDbType.Bit);
            cmd.Parameters.Add("@HOCHAM", SqlDbType.NVarChar);
            cmd.Parameters.Add("@HOCVI", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@HOCPHAN_NAME", SqlDbType.Int);


            cmd.Parameters["@PROF_NAME"].Value = _ProfName;
            cmd.Parameters["@PROF_ID"].Value = _ProfID;
            cmd.Parameters["@FAC_NAME"].Value = _FacName;
            cmd.Parameters["@DATE"].Value = _Dtm;
            cmd.Parameters["@GENDER"].Value = _Gender;
            cmd.Parameters["@HOCHAM"].Value = _HocHam;
            cmd.Parameters["@HOCVI"].Value = _HocVi;
           

            ExecuteDB(cmd);
            cmd.CommandText = "insert into  JUNCTION ( [Mã Học Phần], [Mã Giảng Viên] ) \r\n " +
                                "values((select[Mã Học Phần] from HP where [Tên Học Phần] = @HOCPHAN_NAME),\r\n" +
                                "(select[Mã Giảng Viên] from GV where [Mã Giảng Viên] = @PROF_ID) ); ";
            cmd.Parameters.Add("@HOCPHAN_NAME", SqlDbType.NVarChar);
            cmd.Parameters["@HOCPHAN_NAME"].Value = _HocPhan;
            ExecuteDB(cmd);
        }
        public DataTable GetFacList()
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT [Khoa]\r\n" +
                            "FROM GV";

            return GetRecords(cmd);
        }
        public DataTable GetSubList()
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT [Tên Học Phần]\r\n" +
                            "FROM HP";

            return GetRecords(cmd);
        }
        public void UpdateProduct(String _ProductID, String _ProductName, DateTime _Dtm, bool _Status, string _Type)
        {
            SqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "update GV\r\n" +
                              "set [Tên Giảng Viên] = @PROF_NAME," +
                                   "[Tên khoa] = @FAC_NAME," +
                                  "[Ngày Sinh] = @DATE," +
                                  "[Giới Tính] = @GENDER," +
                                  "[Học Hàm] = @HOCHAM\r\n" +
                                  "[Học Vị] = @HOCVI\r\n" +

                              "where [Mã Giảng Viên] = @PROF_ID";

            cmd.Parameters.Add("@PROF_ID", SqlDbType.VarChar);
            cmd.Parameters.Add("@PROF_NAME", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters.Add("@GENDER", SqlDbType.Bit);
            cmd.Parameters.Add("@HOCHAM", SqlDbType.NVarChar);
            cmd.Parameters.Add("@HOCVI", SqlDbType.NVarChar);

       
           

            ExecuteDB(cmd);
        }
        public DataRow GetSpecificProf(String _ProfName)
        {
            SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "select distinct GV.[Tên Giảng Viên], GV.[Ngày Sinh], GV.[Giới Tính], GV.[Học Hàm], GV.[Học Vị], GV.[Khoa], HP.[Tên Học Phần]\r\n" +
                "from JUNCTION\r\n" +
                "join HP on JUNCTION.[Mã Học Phần] = HP.[Mã Học Phần]\r\n" +
                "join GV on JUNCTION.[Mã Giảng Viên] = GV.[Mã Giảng Viên]\r\n"+
            "where [Tên Giảng Viên] = @PROF_name";
            cmd.Parameters.Add("@PROF_name", SqlDbType.NVarChar);

            cmd.Parameters["@PROF_name"].Value = _ProfName;

            return (GetRecords(cmd)).Rows[0];
        }
    }
}
