#region

using Buildings;

#endregion

var b = new Building();

b.SetApartments(80);
b.SetHeight(14);
b.SetPorches(4);
b.SetStoreys(5);


Console.WriteLine($"Bulding:\n{b}");
Console.WriteLine($"Calculated apartments per entrance: {b.ApartmentsPerEntrance()}");
Console.WriteLine($"Calculated apartments per storeys: {b.ApartmentsPerFloor()}");
Console.WriteLine($"Calculated storey height: {b.StoreyHeightCalculations()}");