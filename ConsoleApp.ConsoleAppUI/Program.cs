
using ConsoleApp.Business.Services;
using ConsoleApp.Business.DTOs.EmployeeDTO;

EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();
CompanyService companyService = new CompanyService();

Console.WriteLine("Banking: ");
companyService.Create("Banking");

Console.WriteLine("Welcome ");
MainMenu:
Console.WriteLine("Choose an operation: "
    + "\n"
    + "\n"
    + "1. Emloyee operations"
    + "\n"
    + "2. Department operations"
    + "\n"
    + "3. Company operations"
    +"\n"
    +"4. Exit menu");

int input;
int empMenuInput;

bool check = int.TryParse(Console.ReadLine(), out input);
if (!check)
{
    throw new FormatException("Given value is not valid!");
}

while (true)
{
    switch (input)
    {
        case 1:
            #region employeeOperations
            Console.WriteLine("\n"
                +"1.Add employee: "
                +"\n"
                +"2.Delete employee: "
                +"\n"
                +"3.Update employee: "
                +"\n"
                +"4.Show all employees: "
                +"\n"
                +"5.Show employee by ID: "
                +"\n"
                +"6.Show employee by department ID: "
                +"\n"
                +"7.Show employee by name: "
                +"\n"
                +"8.Go back to main menu: ");
            bool empMenuCheck = int.TryParse(Console.ReadLine(), out empMenuInput);
            switch (empMenuInput)
            {
                case 1:
                    Console.WriteLine("Enter name: ");
                    string empName = Console.ReadLine();
                    Console.WriteLine("Enter surname: ");
                    string empSurname = Console.ReadLine();
                    Console.WriteLine("Enter department: ");
                    string empDepName = Console.ReadLine();
                    EmployeeCreateDto dto = new(empName, empSurname, empDepName);
                    employeeService.Create(dto);
                    break;
                case 2:
                    Console.WriteLine("Enter name: ");
                    break;
                case 3:
                    Console.WriteLine("Menu 3");
                    break;
                case 4:
                    Console.WriteLine("Menu 4");
                    break;
                case 5:
                    Console.WriteLine("Menu 5");
                    break;
                case 6:
                    Console.WriteLine("Menu 6");
                    break;
                case 7:
                    Console.WriteLine("Menu 7");
                    break;
                case 8:
                    goto MainMenu;
                default:
                    break;
            }
            #endregion
            break;
        case 2:

            Console.WriteLine();

            break;
        case 3:
            break;
        case 4:
            System.Environment.Exit(500);
            break;
        default:
            throw new Exception("Enter valid number!");
    }
}
