using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //     List<int> grades = new List<int>(){100, 30, 45, 72, 91, 87, 66, 70, 92, 78, 81, 90, 89, 71, 83, 81, 99, 87, 78, 80, 65, 100};

            //     // List<int> highGrades = new List<int>();

            // //     grades.ForEach(grade => {
            // //     if(grade >= 90){
            // //         highGrades.Add(grade);
            // //     }
            // // }
            // //     );


            //     //Does the samething.  Written in two different ways.
            //     // List<int> highGrades = grades.Where(singleGrade => singleGrade >= 90).ToList();
            //     List<int> highGrades = (from singleGrade in grades where singleGrade >= 90 select singleGrade).ToList();

            //     double AverageGrade = grades.Average();

            //     int highGrade = grades.Max();

            //     int sumOfGrades = grades.Sum();

            //     Console.WriteLine();

            // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // List<string> LFruits = (from fruit in fruits where fruit.StartsWith("L") select fruit).ToList();

            // LFruits.ForEach(fruit => Console.WriteLine(fruit));


            //     // Which of the following numbers are multiples of 4 or 6
            //     List<int> numbers = new List<int>()
            // {
            //      15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            //     IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 6 == 0 || number % 4 == 0);

            //     foreach (int number in fourSixMultiples)
            //     {
            //         Console.WriteLine(number);
            //     }


            //     // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre"
            // };

            // IEnumerable<string> descend = names.OrderByDescending(name => name);

            //     foreach (string name in descend)
            //     {
            //         Console.WriteLine(name);
            //     }

            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // IEnumerable<int> ascend = numbers.OrderBy(num => num);

            // foreach (int num in ascend)
            // {
            //     Console.WriteLine(num);
            // }

            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // int count = numbers.Count();

            // Console.WriteLine(count);

            // List<double> purchases = new List<double>()
            // {
            //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            // };

            // double total = purchases.Sum();

            // Console.WriteLine(total);

            // List<double> prices = new List<double>()
            // {
            //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            // };

            // double mostExpensive = prices.Max();

            // Console.WriteLine(mostExpensive);


    //         List<int> wheresSquaredo = new List<int>()
    //         {
    //             66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
    //         };

    //         // List<double> newSquaredo = new List<double>();

    //     //    for (int i = 0; i < wheresSquaredo.Count(); i++)
    //     //    {
    //     //          newSquaredo.Add(wheresSquaredo[i]);
    //     //         if(Math.Sqrt(wheresSquaredo[i]) % 1 == 0){
    //     //             break;
    //     //         }    
    //     //    }

    //    List<int> newestSquaredo = wheresSquaredo.TakeWhile(x => (Math.Sqrt(x) % 1) != 0).ToList();

    //        newestSquaredo.ForEach(num => Console.WriteLine(num));


        // Using Custom Types

// Build a collection of customers who are millionaires


    
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };
    

        List<Customer> millionaires = customers.Where(customer => customer.Balance >= 1000000).ToList();

        // List<Customer> groupedMillionaires = from customer in millionaires group customer by customer.Bank;

         // millionaires.ForEach(customer => Console.WriteLine(customer.Name));

        IEnumerable<IGrouping<string, Customer>> groupedMillionaires = millionaires.GroupBy(x => x.Bank);

       

        foreach (IGrouping<string, Customer> group in groupedMillionaires)
        {
            Console.WriteLine($"{group.Key} {group.Count()}");
        }





        }
    }
}
