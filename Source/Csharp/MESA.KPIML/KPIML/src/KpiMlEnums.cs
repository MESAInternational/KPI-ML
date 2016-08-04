using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESA.KPIML
{
    /// <summary>
    /// Hand-coded from KPI-ML schema v1.0
    /// </summary>
    static public class KpiMlEnums
    {
        /// <summary>
        /// Timing Values
        /// </summary>
        static public List<string> TimingValues = new List<string>() { "Real-time", "Periodically", "On-demand", "Other" };

        /// <summary>
        /// Trend Values
        /// </summary>
        static public List<string> TrendValues = new List<string>() { "Higher-is-better", "Lower-is-better", "Other" };

        /// <summary>
        /// ProductionMethodology Values
        /// </summary>
        static public List<string> ProductionMethodologies = new List<string>() { "Batch", "Discrete", "Continuous" };
    }
}
