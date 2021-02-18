using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abone_takip2.dao
{
  public   class kisi
    {

        public bool giris_kontrol(string tc,string password)
        {
            bool control = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select ID from kisiler where TC = '{tc}' and password = '{password}' and isboss = 'True' ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
               int kisi_id = Convert.ToInt32(dr["ID"]);
                dr.Close();
                if (kisi_id > 0)
                {
                    SqlCommand cmd1 = new SqlCommand($" select * from kisiler where ID = {kisi_id} ", connection.sqlConnection);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    dr1.Read();
                    info.kisi_boss.id = kisi_id;
                    info.kisi_boss.il_id = Convert.ToInt32(dr1["il_id"]);
                    info.kisi_boss.isboss = true;
                    info.kisi_boss.isim= dr1["isim_soyisim"].ToString();
                    info.kisi_boss.parola = password;
                    info.kisi_boss.tc = tc;
                    control = true;
                    dr1.Close();
                }
            }
            catch (Exception hata)
            {
               // System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return control;
        }

        public bool herkesi_sil()
        {
            bool silindi = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"delete from kisiler ", connection.sqlConnection);
                int affected_rows = cmd.ExecuteNonQuery();
                if (affected_rows > 0) silindi = true;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return silindi;
        }
        public bool kisiekle(info.kisi kisi)
        {
            bool eklendi = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"insert into kisiler (TC,isim_soyisim,il_id,adress,phone_number,isBoss,password) values ('{kisi.tc}','{kisi.isim}',(select ID from iller where il_isim = '{kisi.il}'),'{kisi.adress}','{kisi.telefon}','{kisi.isboss}','{kisi.parola}')", connection.sqlConnection);
                int affected_rows = cmd.ExecuteNonQuery();
                if (affected_rows > 0) eklendi = true;
            }
            catch (Exception hata)
            {
             //   System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
                
            }

            return eklendi;
        }

        public bool edit(info.kisi kisi)
        {
            // 
            bool eklendi = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"update kisiler set TC = '{kisi.tc}' , isim_soyisim = '{kisi.isim}' , il_id = (select ID from iller where il_isim = '{kisi.il}') , " +
                    $"adress = '{kisi.adress}' , phone_number = '{kisi.telefon}' , isBoss = '{kisi.isboss}' , password = '{kisi.parola}' where ID = {kisi.id}", connection.sqlConnection);
                int affected_rows = cmd.ExecuteNonQuery();
                if (affected_rows > 0) eklendi = true;
            }
            catch (Exception hata)
            {
             //   System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return eklendi;
        }


        


        public DataTable kisi_tc()
        {
            DataTable tcler = new DataTable();
            try
            {
                connection.open();
                SqlDataAdapter cmd = new SqlDataAdapter($" select ID , TC from kisiler ", connection.sqlConnection);
                cmd.Fill(tcler);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return tcler;
        }

        public DataTable kisi_isim()
        {
            DataTable isimler = new DataTable();
            try
            {
                connection.open();
                SqlDataAdapter cmd = new SqlDataAdapter($" select ID , isim_soyisim from kisiler ", connection.sqlConnection);
                cmd.Fill(isimler);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return isimler;
        }

        public DataTable kisi_numara()
        {
            DataTable isimler = new DataTable();
            try
            {
                connection.open();
                SqlDataAdapter cmd = new SqlDataAdapter($" select phone_number from kisiler ", connection.sqlConnection);
                cmd.Fill(isimler);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return isimler;
        }

        public string bul_tc(int abone_id)
        {
            string tc = "";
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select TC from kisiler where ID = {abone_id}", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                tc = dr["TC"].ToString();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return tc;
        }

        public string bul_isim(int abone_id)
        {
            string isim = "";
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select isim_soyisim from kisiler where ID = {abone_id}", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                isim = dr["isim_soyisim"].ToString();
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

        public DataTable get_info_with_tc(string tc)
        {
            DataTable kisi_info = new DataTable();
            try
            {
                connection.open();
                SqlDataAdapter cmd = new SqlDataAdapter($" select ID , isim_soyisim , il_id , adress ,phone_number from kisiler  where TC = '{tc}' ", connection.sqlConnection);
                cmd.Fill(kisi_info);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return kisi_info;
        }

        public DataTable get_info_with_isim(string isim)
        {
            DataTable kisi_info = new DataTable();
            try
            {
                connection.open();
                SqlDataAdapter cmd = new SqlDataAdapter($" select * from kisiler  where isim_soyisim like '%{isim}%' ", connection.sqlConnection);
                cmd.Fill(kisi_info);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return kisi_info;
        }

        public DataTable get_info_with_id(int id)
        {
            DataTable kisi_info = new DataTable();
            try
            {
                connection.open();
                SqlDataAdapter cmd = new SqlDataAdapter($" select * from kisiler  where ID = {id} ", connection.sqlConnection);
                cmd.Fill(kisi_info);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return kisi_info;
        }



        public int id_bul_tcile(string tc)
        {
            int kisi_id = -1;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select ID from kisiler where TC = '{tc}' ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                kisi_id = Convert.ToInt32(dr["ID"]);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return kisi_id;
        }

        public int id_bul_numaraile(string numara)
        {
            int kisi_id = -1;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select ID from kisiler where phone_number = '{numara}' ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                kisi_id = Convert.ToInt32(dr["ID"]);
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return kisi_id;
        }











        //class
    }

    // main
}
