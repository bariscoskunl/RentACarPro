namespace RentACarPro.Mvc.Data.Entities
{
    public class Resarvation
    {
        public int Id { get; set; } 
        public DateTime StartDate { get; set; } // Alış
        public DateTime EndDate { get; set; }   // Veriş
        public decimal TotalPrice { get; set; } // Toplam Para

        // Durum: 0=Bekliyor, 1=Onaylandı, 2=İptal
        public int Status { get; set; }

        // Hangi Araba?
        public int CarId { get; set; }
        public Car Car { get; set; }

        // Hangi Müşteri?
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
