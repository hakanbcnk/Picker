namespace Picker.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;

    [DisplayName("yonga seti")]
    internal class Chipset : Part
    {
        [DisplayName("İşlemciler")]
        public virtual ICollection<Processor> Processors { get; set; }
    }
}