using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Arrays and Lists.");
            //keeping track of the names in a team, maintaining an order
            var names = new string[] { "Mark", "Paula", "Sandy", "Bill" };
            //what properties do arrays have?
            //I can get the index and the length
            var firstName = names[0];
            var secondName = names[1];
            var nameCount = names.Length;
            Console.WriteLine("Total names: " + nameCount + ". " + $"First Name on Index 0 is: {firstName} and Second Name on Index 1 is: {secondName}");
            // Console.WriteLine(names[42]); //outside bounds

            // the word new indicates we are creating a new object of a specific class.

            //The parenthesis after <string>() is where we are to put info on how to create the list and is a required syntax
            var namesList = new List<string>() { "Mark", "Paula", "Sandy", "Bill" };
            //The List is still accessed with the []
            var firstNameOnList = namesList[0];
            Console.WriteLine(firstNameOnList);
            System.Console.WriteLine($"How many names in the list before adding new member: {namesList.Count}.");
            namesList.Add("Mila");
            System.Console.WriteLine($"How many names in the list: {namesList.Count} after adding Mila.");
            namesList.Insert(1, "Vincent");// Mark, Vincent, Paula, Sandy, Bill, Mila
            System.Console.WriteLine(namesList);

            System.Console.WriteLine($"How many names in the list: {namesList.Count}, after adding new name.");
            var listOfScores = new List<int>();
            //Lists must contain items of the same type
            listOfScores.Add(12);
            listOfScores.Add(100);
            listOfScores.Add(55);
            listOfScores.Add(44);
            listOfScores.Add(12);

            var lastIndex = listOfScores.Count - 1;
            var lastScore = listOfScores[lastIndex];

            var indexOfFiftyFive = listOfScores.IndexOf(55);
            System.Console.WriteLine($"Found 55 at index {indexOfFiftyFive}");

            var indexOfFortyTwo = listOfScores.IndexOf(42);
            System.Console.WriteLine($"Found 42 at the index {indexOfFortyTwo}"); //did not find anything. This will print -1 or sentinal value

            var indexOfTwelve = listOfScores.IndexOf(12);
            var lastIndexOfTwelve = listOfScores.LastIndexOf(12);
            System.Console.WriteLine($"Found 12 at index {indexOfTwelve} ");// returns the index of the first one that it finds
            //is there a way of finding the last index of 12
            System.Console.WriteLine($"Found 12 at index {lastIndexOfTwelve} ");// returns the index of the first one that it finds

            //dictionaries dont work via an index
            var playerScores = new Dictionary<string,int>();
            playerScores.Add("Robbie Lakeman", 1_237_456); //you can add underscores to read this number better
            //this is an ERROR

            //what happens if we add Robbie Lakeman with a score of 3
            // playerScores.Add("Robbie Lakeman", 3);//I will get an exception : An item with the same key has already been added. Key: Robbie Lakeman
            //Look up Ribbie Lakeman and change his score
            playerScores["Robbie Lakeman"] = 3;//and index on the left hand side
            //Look up Gavin Stark and set his score
            playerScores["Gavin Stark"] = 42; //another way to add to the dictionary
            //does not matter we haven't added him yet
            //If it already exist, it will change what's already there.
            var robbiePlayerScore = playerScores["Robbie Lakeman"];
            //dictionaries are key based
            System.Console.WriteLine(robbiePlayerScore);//each key is unique

            var gavinScore = playerScores["Gavin Stark"];
            System.Console.WriteLine($"Gavin score is {gavinScore}");
            //var billyScore = playerScores["Billy Mitchell"];
            var hasKey = playerScores.ContainsKey("Billy Mitchell");
            if(hasKey == true){
                //keys are case sensitive
                var billyScore = playerScores["Billy Mitchell"];
                System.Console.WriteLine(billyScore);
            }
            //Other types of data
            //QUEUES - FIRST IN FIRST OUT - FIFO
            //APPEND DATA TO THE END OF A LIST AND REMOVE DATA FROM THE BEGINNING
            //It is not random access
            //list have indexes, dictionaries don't. Queue does not allow random access to its elements.
            //Enqueue and Dequeue to add and remove from the queue.
            var students = new Queue<string>();
            //we can only add to the end of the queue
            students.Enqueue("Mary");
            students.Enqueue("Bill");
            students.Enqueue("Paul");
            students.Enqueue("Saundra");
            students.Enqueue("Thomas");
            
            var student = students.Peek();
            System.Console.WriteLine($"You are up next {student}.");

            //var firstStudent = students[0];//it wont work so we use Pee()
            var firstStudent = students.Dequeue();
            var secondStudent = students.Dequeue();
            var thirdStudent = students.Dequeue();
            var fourthStudent = students.Dequeue();
            var fifthStudent = students.Dequeue();
            //it is linear. Whatever first we enqueue will be the first thing to dequeue
            System.Console.WriteLine(firstStudent);
            System.Console.WriteLine(secondStudent);
            System.Console.WriteLine(thirdStudent);
            System.Console.WriteLine(fourthStudent);
            System.Console.WriteLine(fifthStudent);
            //last in last out would be a stack
            //like the trays in a restaurant, the first tray you will remove is the last tray that was placed on the stack
            //there is no random access - cannot use []
            //this code will not work 
            //var student = students[0];
            //removing an element - cannot be removed in a random order
            //contain
            var isMaryThere = students.Contains("Mary");//will return false because we removed it.
            System.Console.WriteLine($"Mary is there? {isMaryThere}");
            //we can use Clear() 
            students.Clear();
            System.Console.WriteLine($"There are now {students.Count} students in the queue.");
            //The list, the dictionary, the queue are all an interface
            //c# has many other collections: SortedList, Stack, HashSet and LinkedList
            //how does c# knows how to use foreach and other methods that work for all? Interfaces is the answer
            //Interface is a description of a set of behaviors that a type or a type of variable can have. The interface defines the behavior that type must have
            //and the type must implement these. Methods implement behaviors. An interface describes a set of methods.
            //likely and interview question
            //IAnimal (isn't a real thing, it describes some behavior) is a generic type and Bear and Cat and Human are concrete types
            //you cant make an instance of an IAnimal; it wouldn't be able to do anything
            //QUACKS - Duck typing - If it walks like a duck, quacks like a duck, and looks like a duck, it must be a duck.
            //In our case, if it eats and sleeps and breathes like an IAnimal, it must be an IAnimal.
            //List, Dictionary and Queue adhere to the IEnumerable interface
            //And since all these types are IEnumerable LINQ will apply to each.
            
        }
    }
}
