using System;
using System.Data.SqlClient;
using System.Windows.Forms;
//使用sqlclient命名空间


namespace RemoteReading
{
    class MeterBD
    {
        //数据库连接字符串
        string strcon = "Data Source=STU63;Initial Catalog=laijunyu;Integrated Security=True";
        //数据库连接初始化
        public void DBInit()
        {

            SqlConnection sqlcon;
            using (sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                MessageBox.Show("数据库连接成功！");

            }

        }

        //数据写入
        public int WriteDB(string WriteText)
        {

            int writeYes = 0;
            SqlConnection sqlcon = null;
            try
            {

                sqlcon = new SqlConnection(strcon);
                SqlCommand command = new SqlCommand();
                //命令语句
                command.CommandText = WriteText;
                command.Connection = sqlcon;
                sqlcon.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    writeYes = 1;
                }
                else
                {
                    writeYes = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();

            }
            return writeYes;
        }

        //数据查询
        public string ReadDB(string readcommand)
        {
            string tempstring = null;
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                //打开数据库
                sqlcon.Open();
                SqlCommand command = new SqlCommand(readcommand, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    tempstring = reader[0].ToString();

                }


            }
            return tempstring;
        }


    }
}
