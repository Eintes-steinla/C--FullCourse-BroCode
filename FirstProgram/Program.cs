// type casting
string a = "1";
int b = Convert.ToInt32(a);
double c = Convert.ToInt32(a);
char d = Convert.ToChar(a); 
string s = "true";
bool e = Convert.ToBoolean(s);
string f = Convert.ToString(a);

Console.WriteLine(b.GetType());
Console.WriteLine(c.GetType());
Console.WriteLine(d.GetType());
Console.WriteLine(e.GetType());
Console.WriteLine(f.GetType());


