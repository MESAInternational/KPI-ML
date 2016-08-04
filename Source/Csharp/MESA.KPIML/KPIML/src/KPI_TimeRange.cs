///////////////////////////////////////////////////////////
//  KPI_Time_Range.cs
//  Implementation of the Class KPI_Time_Range
//  Refactord from KPI_Definition_Time_Range, KPI_Instance_Time_Range, KPI_Value_Time_Range
//  Created on:      15-Jul-2016 5:26 PM
//  Original author: dnbrandl
//  Code generator/author: kjsmiley
//  Last revised 2016-08-03
//  The KPI Markup Language (KPI-ML) is used courtesy of MESA International. 
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MESA.KPIML
{
    /// <summary>
    /// MESA KPI Time Range class.
    /// See http://mesa.org/en/kpiml.asp for more information.
    /// </summary>
    public class KPI_Time_Range
    {

	/// <summary>
	/// Duration of this KPI Instance Time Range
	/// See standard for syntax.
	/// </summary>
	public string Duration = "";
	/// <summary>
	/// End point of this KPI Instance Time Range
	/// </summary>
	public DateTime EndTime = DateTime.MaxValue;
	/// <summary>
	/// Recurrence of this KPI Instance Time Range
	/// See standard for syntax.
	/// </summary>
	public string Recurrence = "";
	/// <summary>
	/// Start point of this KPI Instance Time Range
	/// </summary>
	public DateTime StartTime = DateTime.MinValue;

    /// <summary>
    /// Constructor
    /// </summary>
    public KPI_Time_Range()
    {

	}

    /// <summary>
    /// Destructor
    /// </summary>
    ~KPI_Time_Range()
    {

	}

    }//end KPI_Time_Range
}