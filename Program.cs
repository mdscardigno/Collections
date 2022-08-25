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
            Console.WriteLine("Total names: " + nameCount + ". " + "First Name on Index 0 and Second Name on Index 1: " + firstName + " " + secondName);
            // Console.WriteLine(names[42]); //outside bounds
            // the word new indicates we are creating a new object of a specific class.
            //The parenthesis after <string>() is where we are to put info on how to create the list and is a required syntax
            var namesList = new List<string>() { "Mark", "Paula", "Sandy", "Bill" };
            //The List is still accessed with the []
            var firstNameOnList = namesList[0];
            Console.WriteLine(firstNameOnList);
            System.Console.WriteLine(namesList.Count);
            namesList.Add("Mila");
            System.Console.WriteLine(namesList.Count);

            var listOfScores = new List<int>();
            //Lists must contain items of the same type
            listOfScores.Add(12);
            listOfScores.Add(12);
            listOfScores.Add(12);


        }
    }
}
