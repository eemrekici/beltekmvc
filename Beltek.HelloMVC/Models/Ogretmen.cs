using System.ComponentModel.DataAnnotations;

namespace Beltek.HelloMVC.Models
{
    public class Ogretmen 
    {
        public Ogretmen() 
        {
        
        }
        public Ogretmen(int ogretmenid, string ad, string soyad, string alan)
        {
            this.Ogretmenid = ogretmenid;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Alan = alan;

        }

        [Key]
        public int Ogretmenid { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Alan { get; set; }

        public override string ToString()
        {
            return $"Ad:{this.Ad} Soyad:{this.Soyad} Alan:{this.Alan}";
        }
    }

    
    
        
    
}
