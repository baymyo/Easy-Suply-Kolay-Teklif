using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySupply
{
    public partial class Fatura
    {
        public int SiraNo { get; set; }
        public string UrunAdi { get; set; }
        public float Kdv { get; set; }
        public float Adet { get; set; }
        public string Birim { get; set; }
        public float BirimFiyat { get; set; }
        public float Tutar { get; set; }
    }
}
