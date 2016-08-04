This Source folder contains C# source code that was originally generated from the Enterprise Architect file in the [KPI-ML](http://www.mesa.org/en/KPIML.asp) [1.0 release](https://services.mesa.org/ResourceLibrary/ShowResource/8c814090-51b7-476c-8e64-3d0b3ae7ced2), which is now available here in GitHub in the new [MESA International repository](https://github.com/MESAInternational/KPI-ML). 

The `.EAP` file was tweaked to set some data types, and further adjustments have been made to the C# code to provide explicit initialization in the constructors, e.g. of List<> objects. 

Current contents of branch **addCSharpSource** include the C# source for classes for **KPI_Definition**, **KPI_Instance**, and **KPI_Value**, and subordinate classes. Placeholder classes were also created for supporting "helper" methods, to be discussed by the XML Committee.

The branch also includes a placeholder for Java source. Once we have worked out implementation concerns, the Java source will be synced and uploaded as well.

**`.gitignore`** is used to deliberately exclude bin, obj, and the NuGet.exe files, as well as Visual Studio's `.user` files. 

For C#, open **`KPI-ML\Source\Csharp\MESA.KPIML\KPI-ML.sln`** in Visual Studio and build it. It should build correctly except for one possible issue, i.e. publishing the MESA.KPIML NuGet package to D:\NuGets\, which is a path you are unlikely to have. This is a temporary problem and will be resolved when the permanent NuGet deployment location is determined.

Please see the pull request for discussion of the implementation concerns.
