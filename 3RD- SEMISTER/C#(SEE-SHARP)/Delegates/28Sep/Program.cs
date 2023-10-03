using System;
using System.Reflection;
class Program
{
    private static void Main(string[] args)
    {
        Employee employee=new Employee(1,"Muneeb",30000);
        employee.EmployeeDetails();
        Console.ReadKey();
    }
}
class Employee{
    public int empId;
    public string empName;
    public double grossPay;
    private double taxDeductions=0.1;
    private double netSalary;
    public Employee(int empId,string empName,double grossPay){
        this.empId=empId;
        this.empName=empName;
        this.grossPay=grossPay;
    }
    private void CalculateSalary(){
        if(grossPay>=30000){
            netSalary=grossPay - (taxDeductions*grossPay);
        }
        else{
            netSalary=grossPay;
        }
        Console.WriteLine($"Your Salary is Before Tax Deductions : {grossPay}");
        Console.WriteLine($"Your Salary is After Tax Deductions : {netSalary}");
    }

    public void EmployeeDetails(){
        Console.WriteLine($"Employee Id : {empId}");
        Console.WriteLine($"Employee Name : {empName}");
        CalculateSalary();
    }

}