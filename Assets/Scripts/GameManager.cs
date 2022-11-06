using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.TestTools;

public class GameManager : MonoBehaviour {

    private EmployeeCalculations calculator;

    public GameObject AreaPanel;
    public GameObject EmployeePanel;
    public GameObject AreaButton;
    public GameObject EmployeeButton;
    public TMP_Text EmployeeInfo;


    // Start is called before the first frame update
    void Start() {
        calculator = new EmployeeCalculations();

        foreach (string area in calculator.GetAreas()) {
            GameObject newButton = Instantiate(AreaButton);
            newButton.GetComponent<Button>().onClick.AddListener(() => ListEmployeesByArea(area));
            newButton.GetComponentInChildren<TMP_Text>().text = area;
            newButton.transform.SetParent(AreaPanel.transform, false);
        }
    }

    // Update is called once per frame
    void Update() {

    }

    

    public void ListEmployeesByArea(string area) {
        foreach (Transform previousButton in EmployeePanel.transform) {
            Destroy(previousButton.gameObject);
        }
        List<Employee> areaEmployees = calculator.GetEmployeesByArea(area);
        foreach (Employee employee in areaEmployees) {
            GameObject newButton = Instantiate(EmployeeButton);
            newButton.GetComponent<Button>().onClick.AddListener(() => ShowEmployeeInfo(employee));
            newButton.GetComponentInChildren<TMP_Text>().text = employee.name;
            newButton.transform.SetParent(EmployeePanel.transform, false);
        }
    }

    public void ShowEmployeeInfo(Employee employee) {
        EmployeeInfo.text = $@"Name: {employee.name}

Area: {employee.area}

Seniority: {employee.seniority}

Current Salary: {calculator.GetEmployeeSalary(employee)}

Salary Increase: {calculator.GetEmployeeIncrement(employee)}%

Expected Salary: {calculator.GetEmployeeSalaryIncremented(employee)}";
    }

    


}
