using Newtonsoft.Json.Serialization;
using System;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Data.Entities // estou no 7
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = " The fiekd {0} can contain {1} charcters lengh. ") ]
        public string Name { get; set; }


        [DisplayFormat(DataFormatString = "{0:C2}" , ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name ="Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase {  get; set; }

        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }


        [Display(Name = "Is Avalible")]
        public bool IsAvalible { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]

        public double stock {  get; set; }


    }
}
