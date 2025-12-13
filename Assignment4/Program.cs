///<summary>
/// Program created to allow staff at "Thrilladelphia" to store and manage details about each ride.
/// Storing details such as: How thrilling a ride is, how many visitors it had, how profitable it is, and/or how terrifying it is.
/// Created By: Chris Malone
/// Created for: CPSC1012 - Abhilash Hareendranathan
/// Created: Dec 12th, 2025
/// Last updated: Dec 12, 2025
/// </summary>

//Ride Class
//void Ride()
//string Name (get, set); // Property 'Name'
//int FrightFactor(get, set); // Property 'FrightFactor'
//double cost(get, set); // Property 'CostToEnter'
//int vistors(get, set); // Property 'VisitorsToday'

//default constructor

//greedy constructor

// Part 1A
// Create a 'Ride Class'
// 1) - A `string` field to store the ride’s **name** and a corresponding `Name` property with both `get` and `set` functionality.
//   - This field cannot be empty, null, or whitespace. Ensure that the stored value is trimmed of leading and trailing whitespace.
// 2) - An `int` field for **fright factor** and a corresponding `FrightFactor` property with both `get` and `set` functionality.
//   - The fright factor must be between 0 and 100.
// 3) - A `double` field for the **cost** to enter and a `CostToEnter` property with both `get` and `set` functionality.
//   - The cost must be at least 1.00.
// 4) - An `int` field for **visitors** today and a `VisitorsToday` property with both `get` and `set` functionality.
//   - The value for this field must be 0 or greater.
// 5) - A **default constructor**.
// 6) - A [**greedy constructor**] (https://dagilleland.hashnode.dev/greedy-constructors)  that requires the name, fright factor, cost, and number of visitors as parameters.
//   -Use the properties in the constructor for setting the fields to take advantage of any validation checks already coded.
// 7) - A read-only property named `PopularityScore` that returns as a `double` the calculated score, using the following formula:
//   `(FrightFactor / 10.0) * VisitorsToday`
// 8) -A read - only property named `ThrillLevel` that will return as a `string` the thrill level based on the `FrightFactor` value.
//   | Fright Factor |	Thrill Level |
//   | ------------- | ------------ |
//   | 0–20          |	Mild         |
//   | 21–60	        | Exciting     |
//   | 61–90	        | Thrilling    |
//   | 91–100	      | Extreme      |
// 9) - A `public` method named `RideDetails()` that returns a `string` with the Name, Fright Factor, Cost, Visitors, Thrill Level, and Popularity Score with labels and appropriate padding.
// 

// Part 1B
// After creating your `Ride` class, write a program to test the class as shown in the sample run below. The program, must, **at a minimum**, demonstrate the following:
// 
// -a. prompt for a `string`
// -b. prompt for an `int`
// -c. prompt for a `double`
// -d. create an instance of `Ride` from user input
// -e. display either the popularity score, the thrill level, or full ride details * *depending on user input * *.
// -f. have appropriate * *error handling * *(i.e.the program must not crash)


// Part 2 – Ride List + Menu-Driven Program 🎪
// Once your base functionality is complete, you will improve on the program developed in Part A by adding the following features (_NOTE: this is not a new program, update the program from Part A to be a more robust and functional program._):
// 
// - The program should make use of **file storage** (specifically, a CSV file) to store Rides.
//   - The ordering of fields for the CSV file is up to you, and the file must be in an acceptable CSV format.
//   - **When the program begins**, load each ride from the file as a `Ride` object and store them in a `List`. 
// - Any rides **added** to the program must be added to the list of rides.
//   > Note: duplicate ride names are not allowed.
// - Any rides **removed** from the program must be removed from the list of rides.
// - Any changes made to the ride details (fright factor, cost, or # of guests) must be **saved** to the appropriate item in the list.
// - Allow the user to **search** for a ride by name (case-insensitive), then display all details for that ride.
// - Allow the user to **view all** the rides in the `List`.
// - When the program ends, **write** the `List` of rides to the file.
// 
// Stretch Goals [Optional]
// - Keep the list/file sorted in alphabetical order by ride name.
// 
// An **example** of what your main menu options could be:
// ```
// 1) Display All Rides
// 2) Search for a Ride by Name
// 3) Add a New Ride
// 4) Edit a Ride
// 5) Remove a Ride
// 6) Quit and Save
// 
// 
// You must use a modular approach to your solution: utilize previous work and in-class examples to help with this task.### Part B – Ride List + Menu-Driven Program 🎪

//Program layout

//1 - Menu
   
Menu();

static void Menu()
{
    bool userQuit = false;
    int userInput = 0;

    do
    {
        // 1) Display All Rides
        Console.WriteLine("1) Display All Rides");
        // 2) Search for a Ride by Name
        Console.WriteLine("2) Search for a Ride by Name");
        // 3) Add a New Ride
        Console.WriteLine("3) Add a New Ride");
        // 4) Edit a Ride
        Console.WriteLine("4) Edit a Ride");
        // 5) Remove a Ride
        Console.WriteLine("5) Remove a Ride");
        // 6) Quit and Save
        Console.WriteLine("6) Quit and Save");
        Console.Write("Enter a letter to select a menu option: ");
        
        try
        {
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:

                    //DisplayAllRides();
                    Console.WriteLine("DisplayAllRides()");
                    break;

                case 2:

                    //SearchRideName();
                    Console.WriteLine("SearchRideName()");
                    break;
                case 3:

                    //AddNewRide();
                    Console.WriteLine("AddNewRide()");
                    break;
                case 4:

                    //EditARide();
                    Console.WriteLine("EditARide()");
                    break;
                case 5:

                    //RemoveARide();
                    Console.WriteLine("RemoveARide()");
                    break;
                case 6:

                    //SaveAndQuit();
                    userQuit = true;
                    Console.WriteLine("SaveAndQuit()");
                     break;

                default:
                    try
                    {
                        Console.WriteLine("Input must be a number between 1-6. Examples: 1,2,3,4,5, or 6");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Input must be a number between 1-6. Examples: 1,2,3,4,5, or 6");
                    }
                    break;

            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Input must be a number between 1-6. Examples: 1,2,3,4,5, or 6");

        }
    } while (userQuit == false);
    
    
}


// Menu Options
//1
// static void DisplayRides()
//{
//
//}
//2
// static void SearchRidesName()
//{
//
//}
//3
// static void AddNewRide()
//{
//
//}
//4
// static void EditARide()
//{
//
//}
//5
// static void RemoveARide()
//{
//
//}
//6
// static void SaveAndQuit()
//{
//
//}
