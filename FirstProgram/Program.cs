// string method

string fullName = "Nguyen Bao Minh";
Console.WriteLine(fullName);

fullName = fullName.ToUpper();
Console.WriteLine(fullName);

fullName = fullName.ToLower();
Console.WriteLine(fullName);

string phoneNumber = "0123-456-789";
phoneNumber = phoneNumber.Replace("-", "");
Console.WriteLine(phoneNumber);

fullName = fullName.Insert(0, "Mr. ");
Console.WriteLine(fullName);

Console.WriteLine(fullName.Length);

string firstName = fullName.Substring(4, 6);
Console.WriteLine(firstName);
