namespace Picker
{
    using System.ComponentModel.DataAnnotations;

    internal class GraphicsCard : Product
    {
        public int BusWidth { get; set; } // Bit
        public Brand ChipsetBrand { get; set; }

        [Required]
        public string ChipsetModel { get; set; }

        public int Frequency { get; set; } // MHz
        public int Memory { get; set; } // GB
        public int MemoryFrequency { get; set; } // MHz

        [Required]
        public string MemoryType { get; set; }

        public int TurboFrequency { get; set; } // MHz

        public int GetBandwidth() => GetEfficientMemoryFrequency() * BusWidth / 8; // MB/s

        public int GetEfficientMemoryFrequency()
            => MemoryFrequency * Utilities.GetPumpRate(MemoryType); // MHz
    }
}