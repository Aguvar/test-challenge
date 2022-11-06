using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataFeed {
    public Employee[] GetEmployees();

    public Dictionary<string, Dictionary<Seniority, int>> GetSalaries();
    public Dictionary<string, Dictionary<Seniority, float>> GetSalaryIncrements();
}
