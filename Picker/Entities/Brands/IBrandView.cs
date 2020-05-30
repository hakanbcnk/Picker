﻿namespace Picker
{
    using System.Drawing;

    internal interface IBrandView : IEntityView<Brand>
    {
        Color BrandColor { get; set; }
        string BrandCountry { get; set; }
        Image BrandImage { get; set; }
        string BrandName { get; set; }
    }
}