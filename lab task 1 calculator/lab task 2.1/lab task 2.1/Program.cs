using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_2._1
{
    public Calculator() { }

    public Calculator(int firstNumber, int secondNumber)
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
    }

    public int sum(int x, int y)
    {
        return x + y;
    }

    public int sub(int x, int y)
    {
        return x - y;
    }

    public int multiplication(int x, int y)
    {
        return x * y;
    }

    public int division(int x, int y)
    {
        return x / y;
    }
    public calculator() { }
    public calculator(int sum, int sub, int multiplication, int division)
    {
        sum = sum;
        sub = sub;
        multiplication = multiplication;
        division = division
        }
    public void ShowInfo()
    {
        Console.WriteLine("sub " + sub);
        Console.WriteLine("sum " + sum);
        Console.WriteLine("multiplication: " + multiplication);
        Console.WriteLine("division " + division);
    }
    interface IBasicCar
    {
        void sum()
            public int sum(int x, int y)
        {
            return x + y;
        }
        void sub()  
            public int sub(int x, int y)
        {
            return x - y;
        }
        void multiplication() 
            public int multiplication(int x, int y)
        {
            return x * y;
        }
        void division()
            public int division(int x, int y)
        {
            return x / y;
        }
    }



    static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int sum = cal.sum(100, 200);
            Console.WriteLine(sum);

            Scientific sc = new Scientific();
            int res = sc.XtoY(4, 2);
            Console.WriteLine(res);

        }
    }
}