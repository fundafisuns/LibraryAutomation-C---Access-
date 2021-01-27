using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class kitaplar
    {
        //veritabanındaki kitaplar tablosundaki sütun verilerini tanımlıyoruz.
        public int kitapid { get; set; } //Her yerden erişim sağlamak için Public tanımlıyoruz.
        public string kitapadi { get; set; }
        public string yazar { get; set; }//Veri okunduğu zaman Get metodu kullanılır.
        public string kitapnumara { get; set; }//Veri yazıldığı zaman Set metodu kullanılır.
        public string tur { get; set; }
        public int sayfasayisi { get; set; }
    }
}
