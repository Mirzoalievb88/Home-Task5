//#1

// Console.Write("Enter your FirstName : ");
// string firstName = Console.ReadLine();

// Console.Write("Enter your LastName : ");
// string lastName = Console.ReadLine();

// Console.Write("Enter your Age : ");
// int age = int.Parse(Console.ReadLine());

// Person person = new Person
// {
// FirstName = firstName,
// LastName = lastName,
// Age = age
// };
// Console.WriteLine(person.GetInfo());

// class Person
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public int Age { get; set; }

//     public string GetInfo()
//     {
//         return $"FirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}";
//     }
// }

//#2

// Post post = new Post();

// post.SetPost("It is Post");
// post.AddLike();
// post.AddLike();

// Console.WriteLine(post.GetInfo());

// class Post
// {
 
//     public string Text { get; set; }
//     public int Likes { get; set; }

 
//     public void SetPost(string text)
//     {
//         Text = text;
//         Likes = 0;
//     }

//     public void AddLike()
//     {
//         Likes++;
//     }

//     public string GetInfo()
//     {
//         return $"Text = {Text}\nLikes : {Likes}";
//     }
// }

//#3

// class Player
// {

//     public string Name { get; set; }
//     public int Number { get; set; }
//     public string Position { get; set; }
//     public string Team { get; set; }

//     public void ScoreGoal()
//     {
//         Console.WriteLine($"{Name} scores a goal!");
//     }

//     public void AssistGoal(string playerName)
//     {
//         Console.WriteLine($"{Name} assists a goal for {playerName}.");
//     }

//     public string GetInfo()
//     {
//         return $"Name: {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}";
//     }
// }

// Console.Write("Enter player's name: ");
// string name = Console.ReadLine();

// Console.Write("Enter player's number: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Enter player's position: ");
// string position = Console.ReadLine();

// Console.Write("Enter player's team: ");
// string team = Console.ReadLine();

// Player player = new Player
// {
//     Name = name,
//     Number = number,
//     Position = position,
//     Team = team
// };
// Console.WriteLine(player.GetInfo());
// player.ScoreGoal();
// player.AssistGoal("Neymar");

//#4

// class Employee
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public int Age { get; set; }
//     public string Position { get; set; }
//     public decimal Salary { get; set; }

//     public void SetSalary(decimal salary)
//     {
//         Salary = salary;
//     }

//     public decimal GetSalary()
//     {
//         return Salary;
//     }

//     public string GetInfo()
//     {
//         return $"FirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}\nPosition: {Position}\nSalary: {Salary}";
//     }
// }


// Console.Write("Enter employee's FirstName: ");
// string firstName = Console.ReadLine();

// Console.Write("Enter employee's LastName: ");
// string lastName = Console.ReadLine();

// Console.Write("Enter employee's Age: ");
// int age = int.Parse(Console.ReadLine());

// Console.Write("Enter employee's Position: ");
// string position = Console.ReadLine();

// Console.Write("Enter employee's Salary: ");
// decimal salary = decimal.Parse(Console.ReadLine());

// Employee employee = new Employee
// {
//     FirstName = firstName,
//     LastName = lastName,
//     Age = age,
//     Position = position,
//     Salary = salary
// };

// Console.WriteLine(employee.GetInfo());

// Console.Write("Set a new Salary: ");
// decimal newSalary = decimal.Parse(Console.ReadLine());
// employee.SetSalary(newSalary);

// Console.WriteLine(employee.GetInfo());

//HomeTask

//#1

// Person person = new Person
// {
//     FirstName = "Shahrom",
//     LastName = "Sharipov",
//     Age = 25,
//     Address = "Tashkent, Uzbekistan"
// };

// Console.WriteLine($"My name is {person.GetFullName()}");

// Console.WriteLine($"My birth year is {person.GetBirthYear()}.");

// class Person
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public int Age { get; set; }
//     public string Address { get; set; }

//     public string GetFullName()
//     {
//         return $"{FirstName} {LastName}";
//     }

//     public int GetBirthYear()
//     {
//         return DateTime.Now.Year - Age;
//     }
// }

//#2

// Rectangle rectangle1 = new Rectangle();
// System.Console.Write("width = ");
// rectangle1.GetWidth = int.Parse(Console.ReadLine());
// System.Console.Write("height = ");
// rectangle1.GetHeight = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Area = " + rectangle1.GetInfo());

// class Rectangle
// {
//     public int GetWidth;
    
//     public int GetHeight;

//     public int GetInfo()
//     {
//         return GetWidth * GetHeight;       
//     }
// }

//#3

// class Student
// {
//     public string Name { get; set; }
//     public int GradeLevel { get; set; }
//     public int[] TestScores { get; set; }


//     public double GetAverage()
//     {
//         int sum = 0;
//         for (int i = 0; i < TestScores.Length; i++)
//         {
//             sum += TestScores[i];
//         }
//         return (double)sum / TestScores.Length;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Student[] students = new Student[]
//         {
//             new Student
//             {
//                 Name = "Shahrom Sharipov",
//                 GradeLevel = 9,
//                 TestScores = new int[] { 85, 80, 75, 90, 88 }
//             },
//             new Student
//             {
//                 Name = "Abdulloh Abdulloev",
//                 GradeLevel = 10,
//                 TestScores = new int[] { 70, 68, 72, 75, 80 }
//             },
//             new Student
//             {
//                 Name = "Nurullo Sulaymonov",
//                 GradeLevel = 11,
//                 TestScores = new int[] { 95, 98, 100, 92, 91 }
//             },
//             new Student
//             {
//                 Name = "Alijoni Zabiri",
//                 GradeLevel = 12,
//                 TestScores = new int[] { 90, 85, 92, 88, 91 }
//             },
//             new Student
//             {
//                 Name = "Olimjon Tojiev",
//                 GradeLevel = 9,
//                 TestScores = new int[] { 85, 83, 88, 90, 82 }
//             }
//         };
//         for (int i = 0; i < students.Length; i++)
//         {
//             double average = students[i].GetAverage();
//             if (average > 85)
//             {
//                 Console.WriteLine($"Congratulations {students[i].Name} on achieving above average scores ({average}) in grade {students[i].GradeLevel}!");
//                 Console.WriteLine("Keep up the good work!");
//             }
//             else if (average < 70)
//             {
//                 Console.WriteLine($"{students[i].Name}, if you're having difficulties with your studies, don't hesitate to");
//                 Console.WriteLine("seek help. Your current average score is {0} in grade {1}.", average, students[i].GradeLevel);
//             }
//             else
//             {
//                 Console.WriteLine($"Congratulations {students[i].Name} on achieving an average score of {average} in grade {students[i].GradeLevel}!");
//                 Console.WriteLine("Keep working hard for even better results!");
//             }

//         }
//     }
// }

//#4

// class Car
// {

//     public string Make { get; set; }
//     public string Model { get; set; }
//     public int Year { get; set; }
//     public double Mileage { get; set; }
//     public double Fuel { get; set; }

  
//     public Car(string make, string model, int year)
//     {
//         Make = make;
//         Model = model;
//         Year = year;
//         Mileage = 0; 
//         Fuel = 0; 
//     }

//     public void Drive(double miles)
//     {
        
//         double requiredFuel = miles / 20;

//         if (Fuel < requiredFuel)
//         {
//             Console.WriteLine("Not enough fuel to drive. Please refuel.");
//         }
//         else
//         {
//             Fuel -= requiredFuel;
//             Mileage += miles;    
//             Console.WriteLine($"You have driven {miles} miles. Current mileage: {Mileage} miles. Remaining fuel: {Fuel} gallons.");
//         }
//     }

//     public void AddFuel(double gallons)
//     {
//         Fuel += gallons; 
//         Console.WriteLine($"Added {gallons} gallons of fuel. Current fuel level: {Fuel} gallons.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Car myCar = new Car("Toyota", "Camry", 2022);

//         Console.WriteLine($"Make: {myCar.Make}");
//         Console.WriteLine($"Model: {myCar.Model}");
//         Console.WriteLine($"Year: {myCar.Year}");
//         Console.WriteLine($"Mileage: {myCar.Mileage} miles");
//         Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");

//         myCar.Drive(100);

//         myCar.AddFuel(10);


//         myCar.Drive(100); 

        
//         Console.WriteLine($"\nAfter the trip and refueling:");
//         Console.WriteLine($"Mileage: {myCar.Mileage} miles");
//         Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");
//     }
// }