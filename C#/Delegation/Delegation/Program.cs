using System.Security.Principal;

namespace Delegation
{
    internal class Program
    {
        delegate bool MyDel(int n);
        //delegate void MyDel2(string a);
        static bool IsNegative(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"Is Negative = {n}");
            }
            return n < 0;
        }
        //static void DisplayNegative(List<int> nums)
        //{
        //    foreach (int n in nums)
        //    {
        //        if(IsNegative(n))
        //        {
        //            Console.WriteLine(n);
        //        }
        //    }
        //}
        static bool IsPosative(int n)
        {
            if(n>0)
            {
                Console.WriteLine($"Is Posative = {n}");
            }
            return n > 0;
        }
        //static void DisplayPosative(List<int> nums)
        //{ 
        //    foreach (int n in nums)
        //    {
        //        if (IsPosative(n))
        //        {
        //            Console.WriteLine(n);
        //        }
        //    }
        //}
        static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"Is Even = {n}");
            }
            return n % 2 == 0;
        }
        //static void DisplayEven(List<int> nums)
        //{
        //    foreach (int n in nums)
        //    {
        //        if (IsEven(n))
        //        {
        //            Console.WriteLine(n);
        //        }
        //    }
        //}
        static bool IsOOd(int n)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine($"Is OOd = {n}");
            }
            return n % 2 != 0;
        }
        //static void DisplayOod(List<int> nums)
        //{
        //    foreach (int n in nums)
        //    {
        //        if (IsOOd(n))
        //        {
        //            Console.WriteLine(n);
        //        }
        //    }
        //}
        //static void Display(List<int> nums,MyDel myDel/*,MyDel2 myDel2*/)
        //{
        //    //myDel2("ahmed");
        //    foreach (int n in nums)
        //    {
        //        if (myDel(n))
        //        {
        //            Console.Write(n);
        //        }
        //    }
        //}
        static void Display(List<int> nums, Predicate<int> myDel/*,MyDel2 myDel2*/)
        {
            //myDel2("ahmed");
            foreach (int n in nums)
            {
                if (myDel(n))
                {
                    Console.Write(n);
                }
            }
        }

        delegate int Calculation(int n1,int n2);

        #region Built in  delegate
        static void Print()
        {
            Console.WriteLine("hello world");
        }
        static void Print1(int n)
        {
            Console.WriteLine(n);
        }
        static void Print3(int n, string name, long t)
        {
            Console.WriteLine(n);
        }
        static int Fun1()
        {
            return 10;
        }
        public static string Div(int n1, int n2)
        {
            return (n1 / n2).ToString();
        }
        #endregion

        #region Generic Delegate
        //delegate int del(int n, int n2);
        delegate T Del<T>(T n, T n2);

        static string PrintGeneric(string s, string s2)
        {
            return s + s2;
        }

        delegate string del2(int n, float n2);
        delegate T Del2<in T1, in T2, out T>(T1 n, T2 n2);
        static string PrintGeneric2(int s, long s2)
        {
            return (s + s2).ToString();
        }

        #endregion
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int> { 10, 30, 28, 7, -6, -19, 18, -5, 16 };

            #region Anonymous Method , Lambda expression
            //Display(Numbers, IsEven);
            //Display(Numbers, delegate (int n)  // anonymous Method on the fly
            //{
            //    return n % 2 != 0;
            //});

            //Display(Numbers, n => n % 2 == 0);// lambda expression method
            //Display(Numbers, n => n % 2 != 0);// lambda expression method
            //Display(Numbers, n => n > 0);// lambda expression method
            //Display(Numbers, n => n < 0);// lambda expression method
            //                             //Display(Numbers, (n, n2) => n % 2 != 0);// lambda expression method
            //                             //Display(Numbers, n =>
            //                             //{
            //                             //    n += 5;
            //                             //    ///
            //                             //    ///
            //                             //    ///
            //                             //    ///
            //                             //    return n % 2 != 0;

            ////});// lambda expression method

            #endregion

            #region user Defind Delegate
            //DisplayNegative(Numbers);
            //DisplayPosative(Numbers);
            //DisplayOod(Numbers);
            //DisplayEven(Numbers);
            //MyDel myDel1 = IsEven;
            //MyDel myDel2 = IsOOd;
            //MyDel myDel3 = IsPosative;
            //MyDel myDel4 = IsNegative;

            //Display(Numbers, myDel1);
            //Display(Numbers, myDel2);
            //Display(Numbers, myDel3);
            //Display(Numbers, myDel4);


            //MyDel myDel = new MyDel(IsEven);
            //MyDel myDel2 = IsEven;

            //myDel2.Invoke(10);
            //myDel2(10); 
            #endregion

            #region Muticast Delegate
            //MyDel myDel = IsEven;
            //var a = myDel.GetInvocationList();
            //myDel += IsOOd;
            //a = myDel.GetInvocationList();
            //myDel += IsPosative;
            //a = myDel.GetInvocationList();
            //myDel -= IsOOd;
            //a = myDel.GetInvocationList();
            //myDel -= IsNegative;
            //a = myDel.GetInvocationList();
            ////var a= myDel.GetInvocationList();
            //myDel(10);

            #region How to pass Multi cast deletgate to method
            //MyDel myDel1 = IsEven;
            //MyDel myDel2 = IsPosative;
            //MyDel myDel3 = IsOOd;
            //MyDel myDel4 = IsNegative;

            //MyDel myDel = myDel1 + myDel2 + myDel3 + myDel4;
            //var a = myDel.GetInvocationList();
            //Display(Numbers, myDel); 
            #endregion

            //MyDel myDel= IsEven + IsPosative + IsOOd - IsNegative; // not valid

            #endregion

            #region Delegate pointer to method out side class (method in another class)
            //Calculation calculation = Calc.Sub;
            //calculation(10, 20);
            //Calculation calculation2 = Calc.Sum;
            //calculation2(10, 20);
            //Calculation calculation3 = Calc.Div;
            //calculation3(10, 20);
            //Calculation calculation4 = Calc.Muti;
            //calculation4(10, 20); 
            #endregion

            #region Built-In Delegate
            //Built-In Delegate
            #region Action Delegate
            ////Action can not return datatype , can take from 0 to 16 paramter
            //Action action = Print;
            //action();

            //Action<int> action1 = Print1;
            //action1(10);

            //Action<int, string, long> action2 = Print3;
            //action2(10, "ahmed", 1215454); 
            #endregion

            #region predicate Delegate
            //Predicate return Boolean and one parameter as generic
            //Predicate<int> predicate1 = IsEven;
            //Display(Numbers, predicate1);

            #region send Muti cast built in delegate to method
            //Predicate<int> predicate2 = IsOOd;
            //Predicate<int> predicate3 = IsNegative;
            //Predicate<int> predicate4 = IsPosative;
            //Predicate<int> predicate= predicate1+ predicate2+ predicate3+ predicate4;
            //Display(Numbers, predicate); 
            #endregion
            #endregion

            #region Func Delegate
            //Func can take from 0 to 16 paramter and return one generic Datatype
            //Func<int> func = Fun1;
            //int value = func();

            //Func<int, int, int> func1 = Calc.Sum;
            //int value = func1(10, 30);

            //Func<int, int, string> func1 = Div;
            //string value = func1(10, 30); 
            #endregion

            #region Generic Delegate
            //Del<string> deL = PrintGeneric;
            //deL("AHMED", "MAHMOUD");

            //Del2<int, long, string> del2 = PrintGeneric2;
            //del2(1001, 4556465); 
            #endregion


            #endregion

        }
    }
}