using LamedalCore.domain.Attributes;
using LamedalCore.domain.Enumerals;

namespace LamedalCore.zPublicClass
{
    /// <summary>
    /// Public class used for test configurations
    /// </summary>
    [Test_IgnoreCoverage(enTestIgnore.CodeIsUsedForTesting)]
    public sealed class pcTest_Configuration
    {
        public string Folder_TestCase_About = "Please specify the folder where the Excel test cases are located. Use '/' to separate folders. Path should end with '/'";
        public string Folder_TestCase = "";
    }
}