using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bgt2_ntp2_31Ekim_1
{
    public class gorevler
    {
        public string baslik;
        public string detay;
        public int durum;
        private DateTime zaman;

        public gorevler(string title,string detail,int status)
        {
            this.baslik = title;
            this.detay = detail;
            this.durum = status;
        }

    }
}
