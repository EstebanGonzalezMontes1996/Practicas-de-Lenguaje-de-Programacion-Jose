using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace EstebanBD
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<TablaEsteban> list = Seleccionar();

            //Console.WriteLine(list[1].EstebanID);    

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].EstebanID);


            }

            Console.ReadKey();  
        }

        public static List<TablaEsteban> Seleccionar()
        {
            try
            {
                List<TablaEsteban> result = new List<TablaEsteban>();
                using (MySqlConnection conexion = new MySqlConnection("server=127.0.0.1 ; port=3306; user id=Esteban; password=123456; database=esteban"))
                {
                    using(MySqlCommand command = new MySqlCommand("SELECT * FROM TablaEsteban", conexion))
                    {
                        command.CommandType = CommandType.Text;

                        conexion.Open();

                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read()) 
                            {
                                result.Add(new TablaEsteban()
                                {
                                    EstebanID = Convert.ToInt32(dataReader["EstebanID"]),
                                }
                                );
                            
                            }
                        conexion.Close();   
                        }

                    }

                    
                }
                return result;
            }
            catch
            {
                return new List<TablaEsteban>();
            }
        }
    }

}