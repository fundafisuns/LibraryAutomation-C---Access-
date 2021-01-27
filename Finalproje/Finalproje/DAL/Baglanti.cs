using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
namespace DAL
{
    class Baglanti //Bağlantı Sınıfı
    {
        //veritabanı bağlantımızı kontrol açmak için bu yapıyı kullanıyoruz.
        OleDbConnection baglanti;
        public OleDbConnection BaglantiKismi
        {
            get
            {
                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();//bağlantı açık 
                    }
                    return baglanti;
                }
                else//bağlantı açık değilse aşağıdaki adımları yürüt
                {
                    baglanti = new OleDbConnection ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=veritab.accdb");//veritabanımızıdan verileri çekiyoruz.
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();//Bağlantı kapalıysa bağlantıyı aç.
                    }
                    return baglanti;
                }
            }
        }
    }
}
