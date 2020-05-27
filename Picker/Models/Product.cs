namespace Picker.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [DisplayName("�r�n")]
    internal class Product : Part
    {
        [DisplayName("Model")]
        public string Model { get; set; }

        [Column(TypeName = "money")]
        [DisplayName("Fiyat")]
        public decimal Price { get; set; } // USD
    }
}