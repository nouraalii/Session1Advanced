using System.Xml.Linq;

namespace Session1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generics:
            //C# Feature 2005 C# 2.0
            //Before 2005 Class Object

            #region Generic EX01 SWAP
            ////SWAP
            //int A = 4, B = 5;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine("==========After swap=========");

            //Helper.SWAP(ref A,ref B); //Passing by Ref

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //double L = 1.5, K = 2.6;
            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");

            //Console.WriteLine("==========After swap=========");

            //Helper.SWAP(ref L, ref K); //Passing by Ref

            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");

            //Point X, Y

            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");

            //Console.WriteLine("==========After swap=========");

            //Helper.SWAP(ref P01,ref P02);

            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");


            ////===============================================

            //int A = 4, B = 5;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine("==========After swap=========");

            //Helper.SWAP(ref A, ref B); //Passing by Ref

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");



            //double L = 1.5, K = 2.6;
            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");

            //Console.WriteLine("==========After swap=========");

            //Helper.SWAP(ref L, ref K); //Passing by Ref

            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");



            //Point X, Y

            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");

            //Console.WriteLine("==========After swap=========");

            //Helper.SWAP(ref P01, ref P02);

            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}"); 
            #endregion

            #region Generic Ex02 Linear Search
            //Linear Search

            //4 7 8 9 10 1 2 3 5 12 -1 -13 11
            //Index

            //int[] Number = { 4 ,7 ,8 ,9 ,10 ,1 ,2 ,3 ,5 ,12 ,-1 ,-13 ,11 };
            //int Index = Helper.LinearSearch(Number, 5);
            //int Index = Helper.LinearSearch(Number, 10);

            //Console.WriteLine(Index);

            //Employee E01 = new Employee() { Id = 1 , Name = "Noura" , Age = 30 , Salary= 12000};
            //Employee E02 = new Employee() { Id = 1 , Name = "Ahmed" , Age = 34 , Salary= 13000};
            //Employee E03 = new Employee() { Id = 1 , Name = "Malak" , Age = 33 , Salary= 17000};
            //Employee E04 = new Employee() { Id = 1 , Name = "Omar" , Age = 29 , Salary= 19000};

            //Employee[] employees ={ E01, E02, E03, E04 };

            //int Index= Helper.LinearSearch(employees, E01);

            //Console.WriteLine(Index);


            //if (E01 == E02)
            //{
            //    Console.WriteLine("E01 == E02");
            //} 
            #endregion

            #region Equality in Class or Struct
            ////Equality in Class or Struct
            //Equal
            //'Class'   Has equals functions which inherited from object class --> compare reference , ==
            //'Struct'  Has equals functions which inherited from object class --> compare data
            //Note:struct don't have implementation to == operator

            //Employee E01 = new Employee() { Id = 1, Name = "Noura", Age = 30, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 34, Salary = 13000 };

            //Console.WriteLine($"E01:{E01.GetHashCode}");
            //Console.WriteLine($"E02:{E02.GetHashCode}");

            //if (E01.Equals(E02))
            //    Console.WriteLine("E01 == E02");
            //else
            //    Console.WriteLine("E01 != E02");

            //if (E01==E02)
            //    Console.WriteLine("E01 == E02");
            //else
            //    Console.WriteLine("E01 != E02"); 
            #endregion

            #region Generic Ex03 BubbleSort
            ////2,6,7,-1,0,8,9,3,14,13
            ////sorting bubble sort
            //int[] Numbers = {2, 6, 7, -1, 0, 8, 9, 3, 14, 13};
            //Helper.Print(Numbers);
            //Console.WriteLine();

            //Helper.BubbleSort(Numbers); //Print Assending
            //Helper.Print(Numbers);


            //Point[] points = 
            //{
            //    new Point(6,6),
            //    new Point(4,4),
            //    new Point(1,1),
            //    new Point(5,5),
            //    new Point(3,3),
            //    new Point(2,2),
            //};

            //Helper.BubbleSort(points);

            ////IComparable : CompareTo
            ////Int
            ////+ : Caller > parameter
            ////- : Caller < Parameter
            ////0 : Caller = parameter 
            #endregion

            #region is and as casting operators 
            //Point[] points =
            //{
            //    new Point(6,6),
            //    new Point(4,4),
            //    new Point(1,1),
            //    new Point(5,5),
            //    new Point(3,3),
            //    new Point(2,2),
            //};

            //Helper.Print(points);
            //Console.WriteLine();

            //Helper.BubbleSort(points);

            //Helper.Print(points);

            //Point P01 = new Point(3,3);
            //Point P02 = new Point(2,2);

            //if (P01.CompareTo(P02) > 0)
            //    Console.WriteLine("P01 is greater than P02");
            //else
            //    Console.WriteLine("P01 is less than P02"); 
            #endregion


            #region IComparable Vs Generic IComparable
            //Employee E01 = new Employee() { Id = 1, Name = "Noura", Age = 30, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 34, Salary = 13000 };
            //Employee E03 = new Employee() { Id = 1, Name = "Malak", Age = 33, Salary = 17000 };
            //Employee E04 = new Employee() { Id = 1, Name = "Omar", Age = 29, Salary = 19000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //Helper.Print(employees);
            //Console.WriteLine();

            //Helper.BubbleSort(employees);

            //Helper.Print(employees);
            #endregion

            #region Built-In interface Generic IEquatable
            //Employee E01 = new Employee() { Id = 1, Name = "Noura", Age = 30, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 34, Salary = 13000 };
            //Employee E03 = new Employee() { Id = 1, Name = "Malak", Age = 33, Salary = 17000 };
            //Employee E04 = new Employee() { Id = 1, Name = "Omar", Age = 29, Salary = 19000 };

            ////Employee[] employees = { E01, E02, E03, E04 };

            //if (E01.Equals(null))
            //    Console.WriteLine("E01 == E02");
            //else
            //    Console.WriteLine("E01 != E02");

            #endregion

            #region Built-In interface Generic IEqualityComparer
            ////Built-In interface Generic IEqualityComparer

            //Employee E01 = new Employee() { Id = 1, Name = "Noura", Age = 30, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 34, Salary = 13000 };
            //Employee E03 = new Employee() { Id = 1, Name = "Malak", Age = 33, Salary = 17000 };
            //Employee E04 = new Employee() { Id = 1, Name = "Omar", Age = 29, Salary = 19000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //int Index = Helper.LinearSearch(employees,new Employee(){ Id = 1, Name = "Noura", Age = 30, Salary = 12000 });
            //int Index = Helper.LinearSearch(employees,new Employee(){ Name = "Noura"},new EqualityCopmarerEmployeeName());

            //Console.WriteLine(Index); 
            #endregion


            #region Built-In interface Generic Icomparer
            //Employee E01 = new Employee() { Id = 1, Name = "Noura", Age = 30, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 34, Salary = 13000 };
            //Employee E03 = new Employee() { Id = 1, Name = "Malak", Age = 33, Salary = 17000 };
            //Employee E04 = new Employee() { Id = 1, Name = "Omar", Age = 29, Salary = 19000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //Helper.Print(employees);
            //Console.WriteLine();

            ////Helper.BubbleSort(employees); //sorting by age
            //Helper.BubbleSort(employees,new EmployeeComparerSalary()); //based on salary

            //Helper.Print(employees); 
            #endregion



        }
    }
}
