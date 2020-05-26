namespace Picker.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;

    [DisplayName("marka")]
    internal class Brand : IEntity
    {
        [Required]
        public int Argb
        {
            get => Color.ToArgb();
            set => Color = Color.FromArgb(value);
        }

        [NotMapped] public Color Color { get; set; }
        [Required] public string Country { get; set; }
        public int Id { get; private set; }
        [Required] public string Name { get; set; }
    }
}