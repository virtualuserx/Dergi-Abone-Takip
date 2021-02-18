using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abone_takip2.dao
{
   public class dergi
    {

       public string[] bu_yilin_dergileri()
        {
            string[] dergiler = new string[6];
          //  string[] dergiler1 = new string[] { "a", "b", "c", "d", "e", "f" };

            try
            {
                connection.open();

               string yil = DateTime.Now.Year.ToString();
        //        System.Windows.Forms.MessageBox.Show(yil);
                SqlCommand cmd = new SqlCommand($"select * from dergi where zaman = '{yil}' ", connection.sqlConnection);
               

                    SqlDataReader dr = cmd.ExecuteReader();
                    for(int i= 0; i < 6; i++)
                    {
                        dr.Read();
                        dergiler[i] = dr["sayi_isim"].ToString();
                    }
                    
                    for(int a = 0; a < 5; a++)
                    {
                        for(int b = 0; b < 5; b++)
                        {
                            if(Convert.ToInt32(dergiler[b].Split('_')[1]) > Convert.ToInt32(dergiler[b + 1].Split('_')[1]))
                            {
                                string temp = dergiler[b];
                                dergiler[b] = dergiler[b + 1];
                                dergiler[b + 1] = temp;
                            }
                        }
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

            return dergiler;
        }


        public bool dergileri_sil( )
        {
            bool silindi = false;

            try
            {
               connection.open();    
               SqlCommand cmd = new SqlCommand($"delete from dergi where zaman = '{DateTime.Now.Year.ToString()}' ", connection.sqlConnection);     
               if(cmd.ExecuteNonQuery()>0) silindi = true;

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

        public bool abone_islemleri_temizle()
        {
            bool silindi = false;

            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"delete from abone_takip ", connection.sqlConnection);
                if (cmd.ExecuteNonQuery() > 0) silindi = true;

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


        public bool yeni_yil_sayilari_ekle(string yil)
        {
            bool eklendi = false;

            try
            {
                connection.open();
                for(int i = 1; i <= 6; i++)
                {
                    string dergi_isim = yil + "_0" + i.ToString();
                    SqlCommand cmd = new SqlCommand($"insert into dergi (sayi_isim,zaman) values('{dergi_isim}','{yil}') ", connection.sqlConnection);
                    if (cmd.ExecuteNonQuery() <= 0) throw new Exception();
                }
                eklendi = true;

            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return eklendi;
        }

        public bool dergi_abone_yap(info.abone_yap abone_Yap)
        {
            bool eklendi = false;

            try
            {

                string zaman = DateTime.Now.ToString();
                string yil = abone_Yap.dergi_isim.Split('_')[0];

                             
                if (dergiye_abone_mi(abone_Yap.kisi_id,abone_Yap.dergi_isim))
                {
                    if (!dergi_abone_sil(abone_Yap.kisi_id, abone_Yap.dergi_isim)) throw new IndexOutOfRangeException();  
                }
                connection.open();
                SqlCommand cmd = new SqlCommand($"insert into abone_takip (dergi_id,kac_tane,fiyat,abone_id,aboneyapan_id,aboneoldugu_zaman,odendi,teslimedildi,dergi_yil) " +
                       $"values ((select ID from dergi where sayi_isim = '{abone_Yap.dergi_isim}')," +
                       $"{abone_Yap.kac_tane},{abone_Yap.fiyat}," +
                       $"{abone_Yap.kisi_id}," +
                       $"{info.kisi_boss.id},'{zaman}','{abone_Yap.odendi}','{abone_Yap.teslim_edildi}','{yil}'  ) ", connection.sqlConnection);
                cmd.ExecuteNonQuery();
                eklendi = true;

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

        public bool dergi_abone_sil(int kisi_id,string dergi_isim)
        {
            bool silindi = false;

            try
            {
                connection.open();

                SqlCommand cmd_delete = new SqlCommand($"delete from abone_takip where abone_id = {kisi_id} and dergi_id = (select ID from dergi where sayi_isim = '{dergi_isim}') ", connection.sqlConnection);
                    cmd_delete.ExecuteNonQuery();
                    silindi = true;
            }
            catch (Exception hata)
            {
                //System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return silindi;
        }


        public DataTable takip(string dergi_sayi,bool teslim,bool odendi)
        {
            DataTable table_takip = new DataTable();
            try
            {
                connection.open();
                SqlDataAdapter cmd = new SqlDataAdapter($" select kac_tane,fiyat,abone_id from abone_takip where dergi_id = (select ID from dergi where sayi_isim = '{dergi_sayi}') and " +
                    $"odendi = '{odendi}' and teslimedildi = '{teslim}' ", connection.sqlConnection);
                cmd.Fill(table_takip);
               

            }
            catch (Exception hata)
            {
               // System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }
            return table_takip;
        }


        public int sayi_teslimedildi(string dergi_sayi)
        {
            int sayi = 0;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"select ID from abone_takip where dergi_id = (select ID from dergi where sayi_isim = '{dergi_sayi}')  and teslimedildi = 'True'  ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sayi++;
                }

            }
            catch (Exception hata)
            {
              //  System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }

            return sayi;
     }

        public int sayi_tumu(string dergi_sayi)
        {
            int sayi = 0;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"select ID from abone_takip where dergi_id = (select ID from dergi where sayi_isim = '{dergi_sayi}')  ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sayi++;
                }

            }
            catch (Exception hata)
            {
             //   System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }

            return sayi;
        }

        public int sayi_odendi(string dergi_sayi)
        {
            int sayi = 0;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"select ID from abone_takip where dergi_id = (select ID from dergi where sayi_isim = '{dergi_sayi}') and odendi = 'True'  ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sayi++;
                }

            }
            catch (Exception hata)
            {
              //  System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }

            return sayi;
        }

        public bool abone_mi(int kisi_id)
        {
            bool abone = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select ID from abone_takip where abone_id = {kisi_id}  ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                if (i > 0) abone = true;
            }
            catch (Exception hata)
            {
              //  System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }
            return abone;
        }

        public bool dergiye_abone_mi(int kisi_id,string dergi_isim)
        {
            bool abone = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select ID from abone_takip where abone_id = {kisi_id} and  dergi_id = (select ID from dergi where sayi_isim = '{dergi_isim}') ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                if (i > 0) abone = true;
            }
            catch (Exception hata)
            {
               // System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }
            return abone;
        }

        public bool sayi_odendi_mi(int kisi_id, string dergi_isim)
        {
            bool abone = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select ID from abone_takip where abone_id = {kisi_id} and  dergi_id = (select ID from dergi where sayi_isim = '{dergi_isim}') and odendi = 'True' ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                if (i > 0) abone = true;
            }
            catch (Exception hata)
            {
               // System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }
            return abone;
        }

        public bool sayi_teslimedildi_mi(int kisi_id, string dergi_isim)
        {
            bool abone = false;
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select ID from abone_takip where abone_id = {kisi_id} and  dergi_id = (select ID from dergi where sayi_isim = '{dergi_isim}') and teslimedildi = 'True' ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                if (i > 0) abone = true;
            }
            catch (Exception hata)
            {
             //   System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }
            return abone;
        }


        public string abonenin_sayi_fiyati(int kisi_id, string dergi_isim)
        {
            string fiyat = "";
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select fiyat from abone_takip where abone_id = {kisi_id} and  dergi_id = (select ID from dergi where sayi_isim = '{dergi_isim}') ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                fiyat = dr["fiyat"].ToString();
            }
            catch (Exception hata)
            {
             //  System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }
            return fiyat;
        }

        public string abonenin_sayi_miktari(int kisi_id, string dergi_isim)
        {
            string miktar = "";
            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($" select kac_tane from abone_takip where abone_id = {kisi_id} and  dergi_id = (select ID from dergi where sayi_isim = '{dergi_isim}') ", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                miktar = dr["kac_tane"].ToString();
            }
            catch (Exception hata)
            {
              //  System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();
            }
            return miktar;
        }


        public bool sayilari_sil()
        {
            bool silindi = false;

            try
            {
                connection.open();

                SqlCommand cmd_delete = new SqlCommand($"delete from dergi where zaman= '{DateTime.Now.Year.ToString()}' ", connection.sqlConnection);
                if(cmd_delete.ExecuteNonQuery()>0) silindi = true;
               
            }
            catch (Exception hata)
            {
              //  System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                connection.close();

            }

            return silindi;
        }



    }
}
