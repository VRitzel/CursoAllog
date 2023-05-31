string name1 = null;
string name2 = null;
string name3 = "Richard";
string defaultname = "Mark";

if(name1 == null){
    name1 = defaultname;
}
Console.WriteLine(name1);
name2 ??= defaultname;
Console.WriteLine(name2);

name3 ??= defaultname;
Console.WriteLine(name3);
