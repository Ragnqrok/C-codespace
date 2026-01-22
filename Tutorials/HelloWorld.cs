String aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);

Console.WriteLine($"Hello {aFriend}");




String firstfriend = "Maira";
String secondfriend = "Sage";
Console.WriteLine($"My friends are {firstfriend} and {secondfriend}");

Console.WriteLine($"The name {firstfriend} has {firstfriend.Length} letters.");
Console.WriteLine($"The name {secondfriend} has {secondfriend.Length} letters.");

String greeting = "      Hello World!           ";

String trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
Console.WriteLine($"{trimmedGreeting}");


trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");



String sayHello = "Hello World!";

Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");

Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

String songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));


Console.WriteLine(songLyrics.StartsWith("you"));
Console.WriteLine(songLyrics.EndsWith("hello"));


