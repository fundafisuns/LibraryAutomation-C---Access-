using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ogrenciler //Öğrenciler sınıfı(Erişime Açık)
    {
        //veritabanındaki öğrenciler tablosundaki sütunları tanımlıyoruz.
        public int ogrenciid { get; set; } //Her yerden erişim sağlamak için Public tanımlıyoruz.
        public string isim { get; set; } //Veri okunduğu zaman Get metodu kullanılır.
        public string numara { get; set; }//Veri yazıldığı zaman Set metodu kullanılır.
        public string bolum { get; set; }
        public string sehir { get; set; }
    }
}
