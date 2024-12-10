//Console.WriteLine("Enter your first name:");
// string userName = Console.ReadLine().Trim();
//string myString = "Hello, World!";
//int theLenghtOfMyString = myString.Length;

string userName = "Santa Klaus";
Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}");
//Console.WriteLine(userName[0]);
//Console.WriteLine(userName[1]);
//Console.WriteLine(userName[2]);
//Console.WriteLine(userName[3]);
//Console.WriteLine(userName[4]);

// a-counter

////int counter = 0;

////for(int i = 0; i < userName.Length; i++)
////{
////    if (userName[i] == 'a')
////        { counter++; } //counter = counter + 1

////}
////Console.WriteLine($"Your first name has {counter} a-letters.");
//

// replace
// a - 4

string updateUserName = userName.Replace('a', '4').Replace('l', '3');
Console.WriteLine(updateUserName);
