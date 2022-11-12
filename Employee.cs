using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment;

internal class Employee
{
    public string EmployeeName { get; set; }
    public string Department { get; set; }
    public string Designtion { get; set; }

	private int _salary;

	public int Salary
	{
		get { return _salary; }
		set { 
			if(Designtion == "Trainee")
			{
				value = 5000;
				
			}	
			_salary = value; 
		}
	}
	

	public void ShowData()
	{
		Console.WriteLine();
		Console.WriteLine(EmployeeName);
		Console.WriteLine(Department);
		Console.WriteLine(Designtion);
		Console.WriteLine(Salary);
	}


}
