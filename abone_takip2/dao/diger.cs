using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abone_takip2.dao
{
  public  class diger
    {

        public bool data_clean ( )
        {
            bool silindi = false;

            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"delete from kasa", connection.sqlConnection);
                int affected_rows = cmd.ExecuteNonQuery();
                if (affected_rows > 0) { MessageBox.Show("Kasalar silindi"); silindi = true; }
                else silindi = false;
                SqlCommand cmd1 = new SqlCommand($"delete from abone_takip", connection.sqlConnection);
                int affected_rows1 = cmd1.ExecuteNonQuery();
                if (affected_rows1 > 0) { MessageBox.Show("abone islemleri silindi"); silindi = true; }
                else silindi = false;
                SqlCommand cmd2 = new SqlCommand($"delete from depo", connection.sqlConnection);
                int affected_rows2 = cmd2.ExecuteNonQuery();
                if (affected_rows2 > 0) { MessageBox.Show("depo silindi"); silindi = true; }
                else silindi = false;
                SqlCommand cmd3 = new SqlCommand($"delete from dergi", connection.sqlConnection);
                int affected_rows3 = cmd3.ExecuteNonQuery();
                if (affected_rows3 > 0) { MessageBox.Show("dergi silindi"); silindi = true; }
                else silindi = false;
                SqlCommand cmd5 = new SqlCommand($"delete from kisiler ", connection.sqlConnection);
                int affected_rows5 = cmd5.ExecuteNonQuery();
                if (affected_rows5 > 0) { MessageBox.Show("kisiler silindi"); silindi = true; }
                else silindi = false;
                SqlCommand cmd4 = new SqlCommand($"delete from iller", connection.sqlConnection);
                int affected_rows4 = cmd4.ExecuteNonQuery();
                if (affected_rows4 > 0) { MessageBox.Show("iller silindi"); silindi = true; }
                else silindi = false;

            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
                silindi = false;
            }
            finally
            {
                connection.close();

            }
            return silindi;
        }


        public bool il_ekle(string il)
        {
            bool eklendi = false;

            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"insert into iller (il_isim) values ('{il}')", connection.sqlConnection);
                int affected_rows = cmd.ExecuteNonQuery();
                if (affected_rows > 0) eklendi = true;
            }
            catch (Exception hata)
            {
              //  System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return eklendi;
        }


        public DataTable iller()
        {
             DataTable iller = new DataTable();

            try
            {
                connection.open();
                SqlDataAdapter dr= new SqlDataAdapter($"select il_isim from iller", connection.sqlConnection);
                dr.Fill(iller);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
                
            }
            finally
            {
                connection.close();
                
            }

            return iller;
        }

        public string il_isim(int il_id)
        {
            string isim  = "";

            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"select il_isim from iller where ID = '{il_id}' ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                isim = dr["il_isim"].ToString();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return isim;
        }


    }
}
