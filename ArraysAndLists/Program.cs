/*
string[] names = new string[5];

names[0] = "Hans";
names[1] = "Tommy";
names[2] = "Joakim";
names[3] = "Emil";
names[4] = "Jakob";

Array.Sort(names);

foreach(string name in names)
    Console.WriteLine(name);

Console.ReadKey();

 */


/*


List<string> names = [];

names.Add("Hans");
names.Add("Tommy");
names.Add("Joakim");

foreach (string name in names)
    Console.WriteLine(name);

names.Remove("Tommy");

foreach (string name in names)
    Console.WriteLine(name);

Console.ReadKey(); 

 */

/*
 
List<string> names = [];

names.Add("Hans");
names.Add("Hans");

bool exists = names.Any(x => x == "Hans");

int count = names.Count();
Console.WriteLine($"Listan har objekt: {exists}");

 */

List<string> names = [];

List<string> databaseList = [];
databaseList.Add("Hans");

names.Add("Hans");
names.Remove("Hans");

IEnumerable<string> customerList = names;

IEnumerable<string> inMemoryList = databaseList;
inMemoryList.Add("Tommy");

foreach (var name in inMemoryList)
    Console.WriteLine(name);