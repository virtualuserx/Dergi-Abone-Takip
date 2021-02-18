using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abone_takip2.dao
{
   public class kasa
    {



        public bool kasa_ekle(string yil)
        {
            bool eklendimi = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"insert into kasa  (yil,aktif,gelen_para,gelecek_para) values ('{yil}','True',0,0) ", connection.sqlConnection);
                int ar = cmd.ExecuteNonQuery();
                if (ar > 0) eklendimi = true;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return eklendimi;
        }

        public void Kasalari_goster( )
        {
           
            try
            {
                connection.open();
                SqlDataAdapter cmd = new SqlDataAdapter($"select * from kasa ", connection.sqlConnection);
              
                    DataTable table = new DataTable();
                cmd.Fill(table);
                DataRowCollection collection = table.Rows;
                foreach(DataRow row in collection)
                {
                    System.Windows.Forms.MessageBox.Show("\tzaman = "+row["yil"]+"\ngelen para = "+ row["gelen_para"] + "   gelecek para = " + row["gelecek_para"]);
                }
                
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
           
        }


        public bool kasalari_sil()
        {
            bool silindimi = false;
            try
            {
                string yil = "";yil = DateTime.Now.Year.ToString();
                connection.open();
                SqlCommand cmd = new SqlCommand($"update kasa set aktif = 'False' where yil = '{yil}' ", connection.sqlConnection);
                int ar=cmd.ExecuteNonQuery();
                if (ar > 0) silindimi = true;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return silindimi;
        }


        public string getkasagelen()
        {
            string money = "";
            try
            {
                string yil = ""; yil = DateTime.Now.Year.ToString();
                connection.open();
                SqlCommand cmd = new SqlCommand($"select gelen_para from kasa where yil = '{yil}' and aktif='True' ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                money = dr["gelen_para"].ToString();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return money;
        }

        public string getkasagelecek()
        {
            string money = "";
            try
            {
                string yil = ""; yil = DateTime.Now.Year.ToString();

                connection.open();
                SqlCommand cmd = new SqlCommand($"select gelecek_para from kasa where yil = '{yil}' and aktif='True'", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                money = dr["gelecek_para"].ToString();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return money;
        }

        public void update()
        {

            try
            {
                double money = 0;
                DataTable table = new DataTable();
                connection.open();
                SqlDataAdapter cmd1 = new SqlDataAdapter($"select fiyat from abone_takip where odendi = 'True' ", connection.sqlConnection);
                cmd1.Fill(table);
                DataRowCollection collection1 = table.Rows;
                foreach(DataRow row in collection1)
                {

                    money += Convert.ToDouble(row["fiyat"]);

                }
             

                SqlCommand cmd11 = new SqlCommand($"update kasa set gelen_para = {money} where yil='{DateTime.Now.Year.ToString()}' and aktif = 'True' ",connection.sqlConnection);
                cmd11.ExecuteNonQuery();

              
                money = 0;
                table.Clear();
                SqlDataAdapter cmd2 = new SqlDataAdapter($"select fiyat from abone_takip where odendi = 'False' ", connection.sqlConnection);
                cmd2.Fill(table);
                DataRowCollection collection2 = table.Rows;
                foreach (DataRow row in collection2)
                {

                    money += Convert.ToDouble(row["fiyat"]);

                }
              

                SqlCommand cmd22 = new SqlCommand($"update kasa set gelecek_para = {money} where yil='{DateTime.Now.Year.ToString()}' and aktif = 'True'  ", connection.sqlConnection);

                cmd22.ExecuteNonQuery();
                
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

        }




       
    }
}
