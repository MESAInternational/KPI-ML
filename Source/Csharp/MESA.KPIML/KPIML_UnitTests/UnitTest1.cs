using System;
using NUnit.Framework;
using MESA.KPIML;

namespace KPIML_UnitTests
{
    /// <summary>
    /// KPI-ML Unit Tests
    /// </summary>
    [TestFixture()]
    public class KPIML_UnitTests
    {
        KPI_Definition def;
        KPI_Instance ins;
        KPI_Value val;

        #region Test setup and teardown
        /// <summary>
        /// Constructor for tests
        /// </summary>
        [OneTimeSetUp]
        public void KPIML_UnitTests_Start()
        {
            string where = "UnitTests_Start";

            Console.WriteLine("*******************************");
            Console.WriteLine("KPI-ML unit tests starting");
            def = new KPI_Definition();
            ins = new KPI_Instance();
            val = new KPI_Value();
            this.ReportStatus(where, "No exceptions in default constructors");

            // none should be null
            Assert.IsNotNull(def);
            Assert.IsNotNull(ins);
            Assert.IsNotNull(val);
            this.ReportStatus(where, "No null objects");

            // all IDs should be empty strings at first
            Assert.IsEmpty(def.ID);
            Assert.IsEmpty(ins.ID);
            Assert.IsEmpty(ins.ID);
            this.ReportStatus(where, "All IDs are initially empty");

            // now assign IDs for xref (generated once with Visual Studio GUID tool 2016-08-05)
            def.ID = new Guid("{3395892C-D200-4DC4-BD5B-403CBA9AC9C7}").ToString(); Assert.IsNotEmpty(def.ID);
            ins.ID = new Guid("{67BA088B-7341-4F7C-B013-E99DEA7C7ABD}").ToString(); Assert.IsNotEmpty(ins.ID);
            val.ID = new Guid("{273FD848-E1E1-4F90-8657-E8149FC791EE}").ToString(); Assert.IsNotEmpty(val.ID);
            this.ReportStatus(where, "All IDs are defined from GUIDs");

            // cross-reference the IDs
            ins.KPIDefinitionID = def.ID;
            this.ReportStatus(where, "Definition ID defined for Instance");
            //val.KPIInstanceID = ins.ID;   // not yet supported (need to fix in schema/code?)
            this.ReportStatus(where, "*** Instance ID NOT defined for Value ***");

        }

        /// <summary>
        /// Destructor for tests
        /// </summary>
        [OneTimeTearDown]
        public void KPIML_UnitTests_End()
        {
            Console.WriteLine("KPI-ML unit tests are done");
            Console.WriteLine("*******************************");
        }
        #endregion

        // TO DO: Add unit tests to cover all PUBLIC methods
        // (These Nunit tests do not work on PRIVATE methods. If you really want to test them too, 
        // make them PROTECTED and derive this unit test class from the class you're testing.)

        [Test()]
        public void KPI_Definition_UnitTest()
        {
            // for now, just ensure there are no null pointers or strings
            Assert.IsNotNull(def.Audience);
            Assert.IsNotNull(def.Description);
            Assert.IsNotNull(def.EffectModel);
            Assert.IsNotNull(def.Formula);
            Assert.IsNotNull(def.HierarchyScope);
            Assert.IsNotNull(def.ID);
            Assert.IsNotNull(def.m_KPI_Definition_Property);
            Assert.IsNotNull(def.m_KPI_Definition_Time_Range);
            Assert.IsNotNull(def.m_KPI_Range);
            Assert.IsNotNull(def.Name);
            Assert.IsNotNull(def.Notes);
            Assert.IsNotNull(def.ProductionMethodology);
            Assert.IsNotNull(def.Scope);
            Assert.IsNotNull(def.Timing);
            Assert.IsNotNull(def.Trend);
            Assert.IsNotNull(def.UnitOfMeasure);
            Assert.IsNotNull(def.used_in_calculation);
            this.ReportStatus("KPI_Definition_UnitTest", "No nulls");
        }

        [Test()]
        public void KPI_Instance_UnitTest()
        {
            // for now, just ensure there are no null pointers or strings
            Assert.IsNotNull(ins.Audience);
            Assert.IsNotNull(ins.Description);
            Assert.IsNotNull(ins.EffectModel);
            Assert.IsNotNull(ins.Formula);
            //Assert.IsNotNull(ins.HierarchyScope);     // not yet supported in Instance, should it be added?
            Assert.IsNotNull(ins.ID);
            Assert.IsNotNull(ins.KPIDefinitionID);      //  unique to Instance
            Assert.IsNotNull(ins.m_KPI_Instance_Property);
            Assert.IsNotNull(ins.m_KPI_Instance_Time_Range);
            Assert.IsNotNull(ins.m_KPI_Range);
            Assert.IsNotNull(ins.Name);
            Assert.IsNotNull(ins.Notes);
            Assert.IsNotNull(ins.ProductionMethodology);
            Assert.IsNotNull(ins.Scope);
            Assert.IsNotNull(ins.Timing);
            Assert.IsNotNull(ins.Trend);
            Assert.IsNotNull(ins.UnitOfMeasure);
            Assert.IsNotNull(ins.used_in_calculation);
            Assert.IsNotNull(ins.m_Resource_Reference);
            this.ReportStatus("KPI_Instance_UnitTest", "No nulls");
        }

        [Test()]
        public void KPI_Value_UnitTest()
        {
            // for now, just ensure there are no null pointers or strings
            Assert.IsNotNull(val.Description);
            //Assert.IsNotNull(val.HierarchyScope);     // not yet supported in Value, should it be added?
            Assert.IsNotNull(val.ID);
            //Assert.IsNotNull(val.KPIInstanceID);      //  unique to Value - not yet supported
            Assert.IsNotNull(val.m_KPI_Value_Property);
            Assert.IsNotNull(val.m_KPI_Value_Time_Range);
            Assert.IsNotNull(val.Name);
            //Assert.IsNotNull(val.Notes);              // not yet supported in Value, should it be added?
            Assert.IsNotNull(val.UnitOfMeasure);
            //Assert.IsNotNull(val.Value);                 // this is a numeric (double), can't be null
            Assert.AreEqual(System.Double.NaN,val.Value);  // default value is NotANumber
            //Assert.IsNotNull(val.m_Resource_Reference);// not yet supported in Value, should it be added?
            this.ReportStatus("KPI_Instance_UnitTest", "No nulls");
        }

        [Test()]
        public void KPI_Enums_UnitTest()
        {

        }

        [Test()]
        public void KPIML_TimeRange_UnitTests()
        {
            string where = "KPIML_TimeRange_UnitTests";

            // create time ranges and make sure they are interchangeable
            KPI_Time_Range tr = new KPI_Time_Range();
            Assert.IsNotNull(tr);
            this.ReportStatus(where, "Time Range created OK");

            Assert.IsEmpty(tr.Duration);
            Assert.IsEmpty(tr.Recurrence);
            Assert.AreEqual(DateTime.MinValue, tr.StartTime);
            Assert.AreEqual(DateTime.MaxValue, tr.EndTime);
            this.ReportStatus(where, "Time Range created with correct default values");

            // set something other than a default value for the elements
            DateTime end = DateTime.Now;
            //DateTime delta = new DateTime(new DateTimeOffset(1, 2, 3, 4, 5, 6, TimeSpan.Zero).Ticks);
            //DateTime start = new DateTime(end.Ticks - delta.Ticks);
            DateTime start = DateTime.Parse("2016-01-01 01:23:45");
            tr.StartTime = start;
            tr.EndTime = end;
            tr.Duration = "P1Y2M3D4h5m6s";
            tr.Recurrence = "Yearly";

            Assert.IsNotNull(def);
            Assert.IsNotNull(def.m_KPI_Definition_Time_Range);
            Assert.IsEmpty(def.m_KPI_Definition_Time_Range);
            Assert.IsNotNull(tr);

            //KPI_Definition_Time_Range dtr = tr as KPI_Definition_Time_Range;    // this cast is failing, returning a null
            //Assert.IsNotNull(dtr);
            //def.m_KPI_Definition_Time_Range.Add(dtr);
            def.m_KPI_Definition_Time_Range.Add(tr);
            Assert.IsNotEmpty(def.m_KPI_Definition_Time_Range);
            Assert.IsNotNull(def.m_KPI_Definition_Time_Range[0]);
            Assert.AreEqual(start, def.m_KPI_Definition_Time_Range[0].StartTime);
            this.ReportStatus(where, "Time Range added OK to KPI Definition (first element in list)");

            Assert.IsNotNull(ins);
            Assert.IsNotNull(ins.m_KPI_Instance_Time_Range);
            Assert.IsEmpty(ins.m_KPI_Instance_Time_Range);
            ins.m_KPI_Instance_Time_Range.Add(tr);
            Assert.IsNotEmpty(ins.m_KPI_Instance_Time_Range);
            Assert.AreEqual(end, ins.m_KPI_Instance_Time_Range[0].EndTime);
            this.ReportStatus(where, "Time Range added OK to KPI Instance (first element in list)");

            Assert.IsNotNull(val);
            Assert.IsEmpty(val.m_KPI_Value_Time_Range.Duration);
            val.m_KPI_Value_Time_Range = (tr);   //  as KPI_Value_Time_Range
            Assert.IsNotEmpty(val.m_KPI_Value_Time_Range.Duration);
            this.ReportStatus(where, "Time Range updated OK in KPI Value (single value)");
        }

        #region Non-test private methods
        /// <summary>
        /// Report status of a test
        /// </summary>
        /// <param name="where"></param>
        /// <param name="status"></param>
        private void ReportStatus(string where,string status)
        {
            string msg = where+" "+status;
            // put the message on the console where we can find it, regardless
            Console.Out.WriteLine(msg);
            //NUnit.VisualStudio.TestAdapter.TestLogger log = new NUnit.VisualStudio.TestAdapter.TestLogger(Console.Out,0);
        }
        #endregion
    }
}
