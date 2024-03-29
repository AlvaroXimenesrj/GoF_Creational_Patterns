﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPatterns.Models.Factory
{
    public interface IChart
    {
        string Title { get; set; }
        List<string> XData { get; set; }
        List<int> YData { get; set; }
        Bitmap GenerateChart();
    }
}
