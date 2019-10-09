using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPatterns.Models.Factory
{
    interface IChartProvider
    {
        IChart GetChart();
    }
}
