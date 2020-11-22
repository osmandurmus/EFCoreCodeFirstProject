using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDevbase.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Ürün Id")]
        public int productID { get; set; }

        [Required(ErrorMessage ="Bu alan boş bırakılamaz!")]
        [Display(Name="Ürün Adı")]
        public string productName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        [Display(Name = "Birim Fiyat")]
        public int productUnitPrice { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        [Display(Name="Depo Miktar")]
        public int productStockQuantity { get; set; }


    }
}
