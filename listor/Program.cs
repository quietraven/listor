// det är en array/ samling
// har fast antal platser efter skapad
// string[] names = ["Micke", "Martin", "Yoko", "Johan"];

List<string> names = ["Micke", "Martin", "Yoko", "Johan"];

names.Add("");
names.Remove("");
names.RemoveAt(3);

// array.leangth
// list.count
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

// for each, do while



Console.ReadLine();