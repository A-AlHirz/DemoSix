//Console.Write("Enter number of employees: ");

//int EmpNumber = Convert.ToInt32(Console.ReadLine());
//int total = 0;

//for (int i = 0; i < EmpNumber; i++)
//{
//    Console.Write("Enter the salary of employee " + (i + 1) + ": ");
//    int salary = Convert.ToInt32(Console.ReadLine());
//    total += salary;
//}

#region Employees Salary
Console.Write("Enter number of employees: ");
int EmpNumber = Convert.ToInt32(Console.ReadLine());
string[] employees = new string[EmpNumber];
const int wage = 10;
int total = 0;
for (int i = 0; i < EmpNumber; i++)
{
    Console.Write("Number of hours of employee number " + (i + 1) + ": ");
    employees[i] = Console.ReadLine();
}

for (int i = 0; i < EmpNumber; i++)
{
    Console.WriteLine("Employee " + (i + 1) + " wage is: " + (Convert.ToInt32(employees[i]) * wage));
    total += Convert.ToInt32(employees[i]) * wage;
}

Console.WriteLine("Total salary of all employees is: " + total);

#endregion


Console.WriteLine("--------------------");

#region failed Login System

//Console.Write("Enter your Username: ");
//string Username = Console.ReadLine();


//Console.Write("Enter your Password: ");
//string password = Console.ReadLine();

////if (Username == "admin" && password == "123456")
////{
////    Console.WriteLine("Welcome admin");

////}
//int c = 0;
//for (int i = 0; i < 2; i++)
//{
//    //Console.WriteLine("Invalid Username or Password");
//    Console.Write("Enter your Username: ");
//    Username = Console.ReadLine();
//    Console.Write("Enter your Password: ");
//    password = Console.ReadLine();
//    if (Username == "admin" && password == "123456")
//    {
//        Console.WriteLine("Access Granted");
//        break;
//    } else
//    {

//        Console.WriteLine("Access Denied");
//        c++;
//    }
//}

//if (c == 2)
//{
//    Console.WriteLine("You have reached the maximum number of attempts");
//}
//else
//{
//    Console.WriteLine("Invalid Username or Password");
//}



#endregion


#region Login System

string correctPassword = "12345";
string correctUsername = "admin";
int attempts = 0;

while (attempts < 3)
{
    Console.Write("Enter your Username: ");
    string inputUsername = Console.ReadLine();
    Console.Write("Enter your Password: ");
    string inputPassword = Console.ReadLine();
    if (inputUsername == correctUsername && inputPassword == correctPassword)
    {
        Console.WriteLine("Access Granted");
        return;
    }
    attempts++;
}

Console.WriteLine("Access Denied too many attempts");
#endregion

Console.WriteLine("--------------------");

#region Array list
//datatype[] arrayName= new dataType[];



#endregion