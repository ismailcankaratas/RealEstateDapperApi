﻿namespace RealEstate_Dapper_UI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string title { get; set; }
        public decimal price { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string categoryId { get; set; }
        public string categoryName { get; set; }
        public string coverimage { get; set; }
        public string type { get; set; }
        public string address { get; set; }
    }
}
