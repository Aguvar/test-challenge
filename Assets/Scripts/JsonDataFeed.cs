using Assets.Scripts;
using Assets.ThirdParty;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace Assets.Scripts {
    public class JsonDataFeed : IDataFeed {
        public Employee[] GetEmployees() {
            ExternalDataRepo repo = new ExternalDataRepo();

            string jsonData = repo.GetEmployeeJsonDataFroMockApi();

            //RootObject employees = JsonUtility.FromJson<RootObject>("{\"employees\":" + jsonData + "}");

            Employee[] employees = JsonConvert.DeserializeObject<Employee[]>(jsonData);


            return employees;
        }

        public Dictionary<string, Dictionary<Seniority, float>> GetSalaryIncrements() {
            ExternalDataRepo repo = new ExternalDataRepo();

            string jsonData = repo.GetSalaryIncrementsJsonDataFroMockApi();

            Dictionary<string, Dictionary<Seniority, float>> increments = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<Seniority, float>>>(jsonData);

            return increments;
        }

        public Dictionary<string, Dictionary<Seniority, int>> GetSalaries() {
            ExternalDataRepo repo = new ExternalDataRepo();

            string jsonData = repo.GetSalaryJsonDataFroMockApi();

            Dictionary<string, Dictionary<Seniority, int>> salaries = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<Seniority, int>>>(jsonData);

            return salaries;
        }
    }

    //Helper class because the unity json utility doesn't want to play nice with arrays
    [Serializable]
    public class RootObject {
        public Employee[] employees;
    }
}