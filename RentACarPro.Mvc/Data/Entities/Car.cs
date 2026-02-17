namespace RentACarPro.Mvc.Data.Entities
{
    public class Car
    {
        public int Id { get; set; } 
        public string Brand { get; set; } 
        public string Model { get; set; } 
        public int Year { get; set; }    
        public decimal DailyPrice { get; set; } 
        public string ImageUrl { get; set; } 
        public bool IsActive { get; set; } = true; 

        // BU ARABA KİME AİT? 
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
