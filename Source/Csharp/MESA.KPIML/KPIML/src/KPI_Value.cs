///////////////////////////////////////////////////////////
//  KPI_Value.cs
//  Implementation of the Class KPI_Value
//  Generated by Enterprise Architect
//  Created on:      22-Oct-2015 10:06:06 PM
//  Original author: dnbrandl
//  Code generator/author: kjsmiley
//  Last revised 2016-08-05
//  The KPI Markup Language (KPI-ML) is used courtesy of MESA International. 
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace MESA.KPIML
{
    /// <summary>
    /// MESA KPI Value class. Referenceable by ID.
    /// See http://mesa.org/en/kpiml.asp and https://github.com/MESAInternational/KPI-ML/ for more information.
    /// </summary>
    public class KPI_Value
    {
        /// <summary>
        /// Unique identifier for this KPI Value
        /// <i>(if a numeric value is desired, use LONG instead of ULONG </i>
        /// <i>to maximize compatibility across Java and C#. for a string,</i>
        /// <i>consider using string equivalent of a unique C# type such as GUID)</i>
        /// </summary>
        public string ID = "";

        /// <summary>
        /// Name of this KPI Value
        /// </summary>
        public string Name = "";

        /// <summary>
        /// Text(s) with Description of this KPI Value
        /// <i>Optional.</i>
        /// </summary>
        public List<string> Description = new List<string>();

        /// <summary>
        /// Texts describing units of measure for this KPI Value
        /// Unconstrained, but SI units are preferred.
        /// <i>Optional.</i>
        /// </summary>
        public string UnitOfMeasure = "";

        /// <summary>
        /// Value of this KPI
        /// <i>(NaN if no value is assigned)</i>
        /// </summary>
        public double Value = System.Double.NaN;

        /// <summary>
        /// KPI Value properties (embedded, not referenced by ID)
        /// <i>Optional.</i>
        /// </summary>
        public List<KPI_Value_Property> m_KPI_Value_Property = new List<KPI_Value_Property>();

        /// <summary>
        /// KPI Value time range
        /// <i>Optional.</i>
        /// </summary>
        public KPI_Time_Range m_KPI_Value_Time_Range = new KPI_Time_Range();

        /// <summary>
        /// Constructor (auto-generated)
        /// </summary>
        public KPI_Value()
        {

        }

        /// <summary>
        /// Destructor (auto-generated)
        /// </summary>
        ~KPI_Value()
        {

        }

    }//end KPI_Value
}