using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class almaverme
    {
        //veritabanındaki almaverme tablosundaki sütunları tanımlıyoruz.
        public int kitapid { get; set; }
        public int ogrenciid { get; set; } //Her yerden erişim sağlamak için Public tanımlıyoruz.
        public string emanettarihi { get; set; }
        public string iadetarihi { get; set; } //Veri okunduğu zaman Get metodu kullanılır.
        public string iadeedilentarih { get; set; } //Veri yazıldığı zaman Set metodu kullanılır.
        public string borc { get; set; }
        public string islemturu { get; set; }
    }
}
