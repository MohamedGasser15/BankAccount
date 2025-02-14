// linq
// it is like lamda in python , it make the code smaller 
// #Methods in Linq (You Can See More in https://learn.microsoft.com/en-us/dotnet/csharp)
// 1) Where => it make filterations for what do you want to appear 
//List<string> Cars =
//    new List<string> { "Volvo", "Ford", "Honda", "BMW", "Mazda",
//                       "Opel", "Kia", "Chery", "Reno", "ford" };
//// With Sql Code =>
//var query = from c in Cars 
//            where c == "Ford" 
//            select c;

//With Where Linq =>
//var query = Cars.Where( c => c == "Ford"); 

//foreach (string car in query)
//{
//    Console.WriteLine(car);
//}

// ===========================================

// 2) First => Get the first name That you ask in the list 
// If There Is no element like what do you want , it Give You Error "Sequance contain no elements", Example =>

//var query = Cars.First( c => c == "Ford");
//  Console.WriteLine(query);

// 3) FirstOrDefault() => same as first name but when there is no element ,
//  it will appear the default value that you make it 
//  

// ===========================================

// 4) Last => same as the first but it will Get The Last element in the list, Example =>

//var query = Cars.Last(c => c == "Ford");
//Console.WriteLine(query);

// 5) LastOrDefault => Same As FirstOrDefault  but it will Get The Last element in the list

























// try , catch , finally
// try => if you have a code and you excepect an error from it , you can use it
// catch =>  handle the excepection goes here
// finally => Regardless of whether an exception occurred or not, the code within the finally block is executed.

//int a = 0;
//int b = 0;

//try
//{
//    b = 7 / a;
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Exception is :  { ex.Message}");  // => messgae said to you the problem in the code
//}
//finally  // will execute if the code was correct or wrong
//{
//    Console.WriteLine("Result : {0}",b);
//}
//Console.ReadLine();




//=====================================================================================================



// interface in c#
// => it is provide you a way of defining behavior without implementaion (تنفيذ)
// it can make inheritance without being realted to class 
// => it used to creatte a contract that other classes must follow (inheritance)
// => Multiple inheritance is achieved by interface
// => it can't contain static member and it only contain public modifier


//=====================================================================================================



//Structs => structures
//it is like "class" but with a few difference
/*
 1) it is value type not reference type like class
 2) can contain constractor only
 3) inheritance is not allowed 
 4) can create an instance with or without new keyword
 */

//Employee NewEmployee = new Employee();
//NewEmployee.EmployeeName = "james";
//NewEmployee.EmployeeJob = "Dircetor";
//NewEmployee.Salary = 7000;
//Console.WriteLine($"Employee Name Is {NewEmployee.EmployeeName} ,Employee job Is {NewEmployee.EmployeeJob} , Employee Salary Is {NewEmployee.Salary}");

//NewEmployee.DisplayTimeSheet();
//public struct Employee
//{
//   public string EmployeeName { get; set; }
//   public string EmployeeJob {  get; set; } 
//   public decimal Salary { get; set; }

//    public Employee(string name , string job ,  decimal salary)
//    {
//        EmployeeName = name;
//        EmployeeJob = job;
//        Salary = salary;
//    }
//    public void DisplayTimeSheet()
//    {
//        Console.WriteLine("Timesheet Method is struct");
//    }
//}





//=====================================================================================================




//Nested Classes 
// => the Developer allowed to define a class within another class=

//Animal animal = new Animal();
//Animal.Dog dog = new Animal.Dog();
//Animal.cat cat = new Animal.cat();
//cat.DogBread 
//class Animal   // outer class
//{
//    public string AnimalName { get; set; }
//    public int lifeSpan { get; set; }

//    public class Dog // inner class
//    {
//        public string DogBread { get; set; }
//        public int intelligence { get; set; }
//    }

//    public class cat // inner class
//    {
//        public string Coat { get; set; }
//        public string[] color { get; set; }
//    }
//}




//=====================================================================================================



//Partial Classes
// => it is like make a class in file and continue it in another file
/*
 1) each partial class's name must be the same
 2) all the partial class must be in the same file ( ConsoleApp1)
 3) Must have the same access modifiers like (public or private)
 4) if any part is declared abstract or sealed or base type ,
    then the whole class is declared of the same type
 5) Must Contain "Partial" Keyword in the class
 6) 
 */
//using ConsoleApp1;

//Employee NewEmpolyee = new Employee();
//NewEmpolyee.EmployeeNumber = 7;
//NewEmpolyee.EmployeeName = "Mohamed";
//Console.WriteLine($"{NewEmpolyee.EmployeeNumber} - {NewEmpolyee.EmployeeName} - {NewEmpolyee.CalculateSalary()}");

//=====================================================================================================



//Static Class
/*
 1) Only Static Members Allowed
 2) can't be instantiated (can'r make variable from it)
 3) it is sealed by default (UNABLE to inheritance)
 4) can't conatin instance constructor (write ctor to understand)
 */

//static class company
//{
//    static public string CompanyName = "BolBol";
//    public company()  // num4 in rules => Can't use it
//    {

//    }
//}


//=====================================================================================================


//Sealed Classes in C#
// sealed class phone  // Sealed => Make The Class UNABLE to inheritance 
//{
//    public string Name { get; set; }
//}

//class Apple : phone // and now phone class can't be used due to "sealed Class" 
//{
//    public string MobilColor;
//}
// =====================================================================================


//polymorphism im C#
//class shape
//{
//    // We Can Use Function In other Class with this way ,
//    // through using virtual in the father class and override in the child classes
//    public virtual void Draw()  
//    {
//        Console.WriteLine("Basic Shape Is Created");
//    }
//}
//class Circle : shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Circle Is Created");
//    }
//}
//class Triangle : shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Triangle Is Created");
//    }
//}
//class Rectangle : shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Triangle Is Created");

//    }
//}


//==================================================================



//Encapsulation in C#
//class Animal
//{
//    private string PrivateVariable;  //  Private => Can access it in their class only ( animal class)
//    public string PublicVariable;  // Public => Can access it in any place in the project 
//    protected string ProtectedVaraiable; // Protected => Can Access it only in Other Class (Inheritance)
//                                         // or Father And Child Classes
//    internal string InternalVariable; // Internal => CAn Acces it in any place in the project like (public)

//    private void TrainAnimal_Private() { }
//    public void TrainAnimal_Public() { }
//    protected void TrainAnimal_Protected() { }
//    internal void TrainAnimal_Internal() { }
//}
//class Dog : Animal
//{
//    Dog dog = new Dog();

//    void FeedDog()
//    {
//    }
//}
//class Cat : Animal
//{
//    void FeedCat()
//    {

//    }
//}







//==============================================


//static class ExtensionsMethods
//{
//    public static bool IsGreater(this int num1, int num2)
//    {
//        return num1 > num2;
//    }

//    public static bool IsNumber(this string text)
//    {
//        return int.TryParse(text, out var example);
//    }

//    public static int CountWords(this string text)
//    {
//        if (!string.IsNullOrEmpty(text))
//        {
//            string[] StringArray = text.Split(' '); //بتقسم الكلام 
//            return StringArray.Length;
//        }
//        else
//        {
//            return 0;
//        }
//    }
//}




