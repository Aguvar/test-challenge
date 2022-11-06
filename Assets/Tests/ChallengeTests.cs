using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ChallengeTests {

    EmployeeCalculations calculator;

    [SetUp]
    public void Init() {
        calculator = new EmployeeCalculations();

    }

    [Test]
    public void GetEmployees_LengthIs251() {
        // Use the Assert class to test conditions
        JsonDataFeed feed = new JsonDataFeed();

        Employee[] employees = feed.GetEmployees();

        Assert.AreEqual(251, employees.Length);
    }

    [Test]
    public void GetEmployeesByArea_HRHas20() {

        List<Employee> employees = calculator.GetEmployeesByArea("HR");

        Assert.AreEqual(20, employees.Count);
        Assert.AreEqual(5, employees.Count(x => x.seniority.Equals(Seniority.Senior)));
        Assert.AreEqual(2, employees.Count(x => x.seniority.Equals(Seniority.SemiSenior)));
        Assert.AreEqual(13, employees.Count(x => x.seniority.Equals(Seniority.Junior)));
    }
    [Test]
    public void GetEmployeesByArea_EngineeringHas150() {

        List<Employee> employees = calculator.GetEmployeesByArea("Engineering");

        Assert.AreEqual(150, employees.Count);
        Assert.AreEqual(50, employees.Count(x => x.seniority.Equals(Seniority.Senior)));
        Assert.AreEqual(68, employees.Count(x => x.seniority.Equals(Seniority.SemiSenior)));
        Assert.AreEqual(32, employees.Count(x => x.seniority.Equals(Seniority.Junior)));
    }
    [Test]
    public void GetEmployeesByArea_ArtistHas25() {

        List<Employee> employees = calculator.GetEmployeesByArea("Artist");

        Assert.AreEqual(25, employees.Count);
        Assert.AreEqual(5, employees.Count(x => x.seniority.Equals(Seniority.Senior)));
        Assert.AreEqual(20, employees.Count(x => x.seniority.Equals(Seniority.SemiSenior)));
    }
    [Test]
    public void GetEmployeesByArea_DesignHas25() {

        List<Employee> employees = calculator.GetEmployeesByArea("Design");

        Assert.AreEqual(25, employees.Count);
        Assert.AreEqual(10, employees.Count(x => x.seniority.Equals(Seniority.Senior)));
        Assert.AreEqual(15, employees.Count(x => x.seniority.Equals(Seniority.Junior)));
    }
    [Test]
    public void GetEmployeesByArea_PMsHas30() {

        List<Employee> employees = calculator.GetEmployeesByArea("PMs");

        Assert.AreEqual(30, employees.Count);
        Assert.AreEqual(10, employees.Count(x => x.seniority.Equals(Seniority.Senior)));
        Assert.AreEqual(20, employees.Count(x => x.seniority.Equals(Seniority.SemiSenior)));
    }
    [Test]
    public void GetEmployeesByArea_CEOHas1() {

        List<Employee> employees = calculator.GetEmployeesByArea("CEO");

        Assert.AreEqual(1, employees.Count);
        Assert.AreEqual(1, employees.Count(x => x.seniority.Equals(Seniority.CEO)));
    }
    [Test]
    public void GetEmployeeSalary_HRSeniorIs1500() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.Senior };

        Assert.AreEqual(1500, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_HRSemiSeniorIs1000() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.SemiSenior };

        Assert.AreEqual(1000, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_HRJuniorIs500() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.Junior };

        Assert.AreEqual(500, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_EngineeringSeniorIs5000() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.Senior };

        Assert.AreEqual(5000, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_EngineeringSemiSeniorIs3000() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.SemiSenior };

        Assert.AreEqual(3000, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_EngineeringJuniorIs1500() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.Junior };

        Assert.AreEqual(1500, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_ArtistSeniorIs2000() {

        Employee employee = new Employee() { area = "Artist", seniority = Seniority.Senior };

        Assert.AreEqual(2000, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_ArtistSemiSeniorIs1200() {

        Employee employee = new Employee() { area = "Artist", seniority = Seniority.SemiSenior };

        Assert.AreEqual(1200, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_DesignSeniorIs2000() {

        Employee employee = new Employee() { area = "Design", seniority = Seniority.Senior };

        Assert.AreEqual(2000, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_DesignJuniorIs800() {

        Employee employee = new Employee() { area = "Design", seniority = Seniority.Junior };

        Assert.AreEqual(800, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_PMsSeniorIs4000() {

        Employee employee = new Employee() { area = "PMs", seniority = Seniority.Senior };

        Assert.AreEqual(4000, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_PMsSemiSeniorIs2400() {

        Employee employee = new Employee() { area = "PMs", seniority = Seniority.SemiSenior };

        Assert.AreEqual(2400, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeSalary_CEOIs20000() {

        Employee employee = new Employee() { area = "CEO", seniority = Seniority.CEO };

        Assert.AreEqual(20000, calculator.GetEmployeeSalary(employee));
    }
    [Test]
    public void GetEmployeeIncrement_HRSeniorIs5() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.Senior };

        Assert.AreEqual(5, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_HRSemiSeniorIs2() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.SemiSenior };

        Assert.AreEqual(2, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_HRJuniorIs05() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.Junior };

        Assert.AreEqual(0.5, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_EngineeringSeniorIs10() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.Senior };

        Assert.AreEqual(10, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_EngineeringSemiSeniorIs7() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.SemiSenior };

        Assert.AreEqual(7, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_EngineeringJuniorIs5() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.Junior };

        Assert.AreEqual(5, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_ArtistSeniorIs5() {

        Employee employee = new Employee() { area = "Artist", seniority = Seniority.Senior };

        Assert.AreEqual(5, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_ArtistSemiSeniorIs25() {

        Employee employee = new Employee() { area = "Artist", seniority = Seniority.SemiSenior };

        Assert.AreEqual(2.5, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_DesignSeniorIs7() {

        Employee employee = new Employee() { area = "Design", seniority = Seniority.Senior };

        Assert.AreEqual(7, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_DesignJuniorIs4() {

        Employee employee = new Employee() { area = "Design", seniority = Seniority.Junior };

        Assert.AreEqual(4, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_PMsSeniorIs10() {

        Employee employee = new Employee() { area = "PMs", seniority = Seniority.Senior };

        Assert.AreEqual(10, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_PMsSemiSeniorIs5() {

        Employee employee = new Employee() { area = "PMs", seniority = Seniority.SemiSenior };

        Assert.AreEqual(5, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeIncrement_CEOIs100() {

        Employee employee = new Employee() { area = "CEO", seniority = Seniority.CEO };

        Assert.AreEqual(100, calculator.GetEmployeeIncrement(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_HRSeniorIs1575() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.Senior };

        Assert.AreEqual(1575, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_HRSemiSeniorIs1020() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.SemiSenior };

        Assert.AreEqual(1020, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_HRJuniorIs5025() {

        Employee employee = new Employee() { area = "HR", seniority = Seniority.Junior };

        Assert.AreEqual(502.5, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_EngineeringSeniorIs5500() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.Senior };

        Assert.AreEqual(5500, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_EngineeringSemiSeniorIs3210() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.SemiSenior };

        Assert.AreEqual(3210, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_EngineeringJuniorIs1575() {

        Employee employee = new Employee() { area = "Engineering", seniority = Seniority.Junior };

        Assert.AreEqual(1575, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_ArtistSeniorIs2100() {

        Employee employee = new Employee() { area = "Artist", seniority = Seniority.Senior };

        Assert.AreEqual(2100, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_ArtistSemiSeniorIs1230() {

        Employee employee = new Employee() { area = "Artist", seniority = Seniority.SemiSenior };

        Assert.AreEqual(1230, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_DesignSeniorIs2140() {

        Employee employee = new Employee() { area = "Design", seniority = Seniority.Senior };

        Assert.AreEqual(2140, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_DesignJuniorIs832() {

        Employee employee = new Employee() { area = "Design", seniority = Seniority.Junior };

        Assert.AreEqual(832, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_PMsSeniorIs4400() {

        Employee employee = new Employee() { area = "PMs", seniority = Seniority.Senior };

        Assert.AreEqual(4400, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_PMsSemiSeniorIs2520() {

        Employee employee = new Employee() { area = "PMs", seniority = Seniority.SemiSenior };

        Assert.AreEqual(2520, calculator.GetEmployeeSalaryIncremented(employee));
    }
    [Test]
    public void GetEmployeeSalaryIncremented_CEOIs40000() {

        Employee employee = new Employee() { area = "CEO", seniority = Seniority.CEO };

        Assert.AreEqual(40000, calculator.GetEmployeeSalaryIncremented(employee));
    }

}
