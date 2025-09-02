// switches
string day = "Monday";
string activity;
// c# under 8.0 switch expression
switch (day)
{
    case "Monday":
        activity = "Go to the gym";
        break;
    case "Tuesday":
        activity = "Attend a cooking class";
        break;
    case "Wednesday":
        activity = "Work on a personal project";
        break;
    case "Thursday":
        activity = "Meet friends for dinner";
        break;
    case "Friday":
        activity = "Watch a movie";
        break;
    case "Saturday":
        activity = "Go hiking";
        break;
    case "Sunday":
        activity = "Relax and read a book";
        break;
    default:
        activity = "Invalid day";
        break;
}
Console.WriteLine(activity);

// c# 8.0 switch expression
activity = day switch
{
    "Monday" => "Go to the gym",
    "Tuesday" => "Attend a cooking class",
    "Wednesday" => "Work on a personal project",
    "Thursday" => "Meet friends for dinner",
    "Friday" => "Watch a movie",
    "Saturday" => "Go hiking",
    "Sunday" => "Relax and read a book",
    _ => "Invalid day"
};
Console.WriteLine(activity);