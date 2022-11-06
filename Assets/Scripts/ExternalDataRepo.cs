using System.Collections;
using System.IO;
using UnityEngine;

namespace Assets.ThirdParty {
    public class ExternalDataRepo {

        public string GetEmployeeJsonDataFroMockApi() {

            string contents = File.ReadAllText(@"./Assets/Scripts/data.json");
            return contents;
        }
        public string GetSalaryJsonDataFroMockApi() {

            string contents = File.ReadAllText(@"./Assets/Scripts/salaries.json");
            return contents;
        }
        public string GetSalaryIncrementsJsonDataFroMockApi() {

            string contents = File.ReadAllText(@"./Assets/Scripts/salaryIncrements.json");
            return contents;
        }
    }
}