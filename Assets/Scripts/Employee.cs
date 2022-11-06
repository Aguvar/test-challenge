using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts {
    [Serializable]
    public class Employee {

        public string area;
    
        public Seniority seniority;

        public string name;

    }

    public enum Seniority {
        CEO = 0,
        Senior = 1,
        SemiSenior = 2,
        Junior = 3
    }


}