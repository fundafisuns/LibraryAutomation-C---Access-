using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entity;
namespace BL
{
        public class kitap_islem // Bu sınıf kitap ekleme, silme, listeleme, güncelleme işlemleri için oluşturulmuş sınıftır.
        {
            DAL.DAL dl1 = new DAL.DAL();
            public List<kitaplar> kitap_goster()
            {
                //veritabanından kitap tablosundaki değerleri çekiyoruz.
                OleDbDataReader dr = dl1.DRVeriCek("SELECT * FROM kitaplar", CommandType.Text);
                if (dr.HasRows)
                {
                    //bu değerleri bir liste ile geri döndürüyoruz.
                    List<kitaplar> kitaplar = new List<kitaplar>();
                    while (dr.Read())
                    {
                        kitaplar ktp = new kitaplar { kitapid = int.Parse(dr["kitapid"].ToString()), kitapadi = dr["kitapadi"].ToString(), yazar = dr["yazar"].ToString(),
                            kitapnumara = dr["kitapnumara"].ToString(), tur = dr["tur"].ToString(), sayfasayisi = int.Parse(dr["sayfasayisi"].ToString()) };
                        kitaplar.Add(ktp);
                    }
                    return kitaplar;
                }
                return null;
            }
            DAL.DAL dl2 = new DAL.DAL();
            public List<kitaplar> kitap_goster(string deger, string yer)
            {
                //veritabanından kitap tablosundaki değerleri çekiyoruz.
                OleDbDataReader dr = dl2.DRVeriCek("SELECT * FROM kitaplar WHERE " + yer + " ='" + deger + "'", CommandType.Text);
                if (dr.HasRows)
                {
                    //bu değerleri bir liste ile geri döndürüyoruz.
                    //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                    List<kitaplar> kitaplar = new List<kitaplar>();
                    while (dr.Read())
                    {
                        kitaplar ktp = new kitaplar { kitapid = int.Parse(dr["kitapid"].ToString()), kitapadi = dr["kitapadi"].ToString(), yazar = dr["yazar"].ToString(),
                            kitapnumara = dr["kitapnumara"].ToString(), tur = dr["tur"].ToString(), sayfasayisi = int.Parse(dr["sayfasayisi"].ToString()) };
                        kitaplar.Add(ktp); //Kitaplar listesine yeni kitap ekleme komutudur.
                    }
                    return kitaplar;
                }
                return null;
            }
            DAL.DAL dl3 = new DAL.DAL();
            public int ktp_ekle(string kitapadi, string yazar, string kitapnumara, string tur, int sayfasayisi)
            {
                //kitap eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
                int sonuc = dl3.EkleSilGuncelle("insert into kitaplar (kitapadi,yazar,kitapnumara,tur,sayfasayisi) values ('" + kitapadi + "','" + yazar + "','" 
                    + kitapnumara + "','" + tur + "','" + sayfasayisi + "')", System.Data.CommandType.Text);
                return sonuc;
            }
            DAL.DAL dl4 = new DAL.DAL();
            public int ktp_guncelle(int kitapid, string kitapadi, string yazar, string kitapnumara, string tur,int sayfasayisi)
            {
                //kitap güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
                int sonuc = dl4.EkleSilGuncelle("update kitaplar set kitapadi='" + kitapadi + "', yazar='" + yazar + "', kitapnumara='" + kitapnumara + 
                    "', tur='" + tur + "', sayfasayisi='" + sayfasayisi + "' WHERE kitapid=" + kitapid + "", System.Data.CommandType.Text);
                return sonuc;
            }
            DAL.DAL dl5 = new DAL.DAL();
            public int ktp_sil(int kitapid)
            {
                //kitap silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
                int sonuc = dl5.EkleSilGuncelle("DELETE from kitaplar where kitapid =" + kitapid + " ", System.Data.CommandType.Text);
                return sonuc;
            }
        }
    }

