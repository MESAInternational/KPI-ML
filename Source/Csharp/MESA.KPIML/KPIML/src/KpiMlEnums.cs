///////////////////////////////////////////////////////////
//  KpiMlEnums.cs
//  Hand-coded implementations of the restricted lists in KPI-ML
//  Created on:      22-Oct-2015 10:06:06 PM
//  Original author: kjsmiley
//  Last revised 2016-08-05
//  The KPI Markup Language (KPI-ML) is used courtesy of MESA International. 
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace MESA.KPIML
{
    /// <summary>
    /// Implementations of the restricted lists in KPI-ML
    /// See http://mesa.org/en/kpiml.asp and https://github.com/MESAInternational/KPI-ML/ for more information.
    /// </summary>
    static public class KpiMlEnums
    {
        /// <summary>
        /// List of valid Timing Values
        /// </summary>
        static public List<string> TimingValues = new List<string>() { "Real-time", "Periodically", "On-demand", "Other" };

        /// <summary>
        /// List of valid Trend Values
        /// </summary>
        static public List<string> TrendValues = new List<string>() { "Higher-is-better", "Lower-is-better", "Other" };

        /// <summary>
        /// List of valid ProductionMethodology Values
        /// </summary>
        /// <remarks>Should 'Other' be an option here too?</remarks>
        static public List<string> ProductionMethodologies = new List<string>() { "Batch", "Discrete", "Continuous" };

        // XML Committee: Should we include a list for any other restricted value, e.g. ResourceType?
    }
}
