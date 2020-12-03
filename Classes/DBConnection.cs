using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data.SqlClient;




namespace WPFCore.Classes
{
    public partial class DBConnection
    {



        static DBConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            var cmncls = new Common();
            builder.ConnectionString = cmncls.GetConnectionString();


            try
            {


                // SQL Server に接続
                Console.Write("SQL Server に接続しています... ");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("接続成功。");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("すべてが完了しました。任意のキーを押してアプリを終了します...");
            Console.ReadKey(true);

        }


    }

}

    