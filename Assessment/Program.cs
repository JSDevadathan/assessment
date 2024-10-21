using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // TASK: 1

            var builderTask1 = new StringBuilder();
            builderTask1.Append('-', 10);
            builderTask1.AppendLine();
            builderTask1.Append("TASK : 1");
            builderTask1.AppendLine();
            builderTask1.Append('-', 10);
            Console.WriteLine(builderTask1);


            Console.WriteLine("Enter the hourly rate");
            var hourlyRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the hours worked");
            var hoursWorked = Convert.ToInt32(Console.ReadLine());


            var regularPay = hourlyRate * hoursWorked;
            Console.WriteLine($"Regular Pay:  + {regularPay:C}");

            if (hoursWorked > 40)
            {
                Console.WriteLine($"OverTimePay:  + {1.5 * regularPay:C}");
                var overTime = 1.5 * regularPay;
                Console.WriteLine($"Gross Pay:  + {(regularPay + overTime):C}");
                var netPay = (regularPay + overTime) * 20 / 100;
                Console.WriteLine($"Net Pay:  + {netPay:C}");
            }
            else
            {
                Console.WriteLine("No OverTimePayment");
            }




            // TASK: 2

            Console.WriteLine();

            var builderTask2 = new StringBuilder();
            builderTask2.Append('-', 10);
            builderTask2.AppendLine();
            builderTask2.Append("TASK : 2");
            builderTask2.AppendLine();
            builderTask2.Append('-', 10);
            Console.WriteLine(builderTask2);


            BankAccount account = new BankAccount(12345, "JS DEVADATHAN", 1000);

            Console.WriteLine("Initial Account Information:");
            account.DisplayAccountDetails();

            account.deposit(500);

            account.withdrawal(200);

            Console.WriteLine("\nUpdated Account Information:");
            account.DisplayAccountDetails();

            account.withdrawal(1000);



            // TASK : 7


            Console.WriteLine();

            var builderTask3 = new StringBuilder();
            builderTask3.Append('-', 10);
            builderTask3.AppendLine();
            builderTask3.Append("TASK : 7");
            builderTask3.AppendLine();
            builderTask3.Append('-', 10);
            Console.WriteLine(builderTask3);


            var calculator = new Calculator();
            int[] numbers = { 10, 20, 30, 0, 40 };
            calculator.ProcessNumbers(numbers);


            // TASK : 10

            Console.WriteLine();

            var builderTask10 = new StringBuilder();
            builderTask10.Append('-', 10);
            builderTask10.AppendLine();
            builderTask10.Append("TASK : 10");
            builderTask10.AppendLine();
            builderTask10.Append('-', 10);
            Console.WriteLine(builderTask10);

            Circle circle = new Circle(4);

            Console.WriteLine("Area of Circle: " + circle.getArea());
            Console.WriteLine("Perimeter of Circle: " + circle.getPerimeter());

            Rectangle rectangle = new Rectangle(12, 34);
            Console.WriteLine("\nArea of Rectangle: " + rectangle.getArea());
            Console.WriteLine("Perimeter of Rectangle: " + rectangle.getPerimeter());

            Triangle triangle = new Triangle(5, 9, 2);
            Console.WriteLine("\nArea of Triangle: " + triangle.getArea());
            Console.WriteLine("Perimeter of Triangle: " +triangle.getPerimeter());



            // TASK : 9


            Console.WriteLine();

            var builderTask9 = new StringBuilder();
            builderTask9.Append('-', 10);
            builderTask9.AppendLine();
            builderTask9.Append("TASK : 9");
            builderTask9.AppendLine();
            builderTask9.Append('-', 10);
            Console.WriteLine(builderTask9);

            Task task = new Task("Complete the project ", TaskPriority.High, new TaskDuration(12, 30));
            Console.WriteLine("Task Created:");
            Console.WriteLine(task);
            if (task.UpdateStatus(TaskStatus.InProgress))
            {
                Console.WriteLine("Task status updated to InProgress.");
            }
            Console.WriteLine(task);

            if (task.UpdateStatus(TaskStatus.Complete))
            {
                Console.WriteLine("Task status updated to Complete.");
            }
            Console.WriteLine(task);

            if (!task.UpdateStatus(TaskStatus.New))
            {
                Console.WriteLine("Complete can't go back to New");
            }
            Console.WriteLine(task);

        }
    }
}
