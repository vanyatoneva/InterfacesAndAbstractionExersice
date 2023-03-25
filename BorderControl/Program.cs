
using BorderControl;
using BorderControl.Models;
using BorderControl.Models.Interfaces;

List<IBIrthable> birthables = new();
string[] commArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (commArgs[0] != "End")
{
    IBIrthable birthable = null;
    if (commArgs[0] == "Citizen")
    {
        birthable = new Citizen(commArgs[1], int.Parse(commArgs[2]), commArgs[3], commArgs[4]);
    }
    else if (commArgs[0] == "Pet")
    {
        birthable = new Pet(commArgs[1], commArgs[2]);
    }
    if (birthable != null)
    {
        birthables.Add(birthable);
    }
    commArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

string year = Console.ReadLine();

foreach(IBIrthable birthable in birthables.Where(b => b.BirthDate.EndsWith(year)))
{
    Console.WriteLine(birthable.BirthDate);
}


//string fakeIds = Console.ReadLine();


//List<IIdentifiable> detained = tryingToEnter.FindAll(i => i.Id.EndsWith(fakeIds));
//foreach(IIdentifiable identifiable in detained)
//{
//    Console.WriteLine(identifiable.Id);
//}