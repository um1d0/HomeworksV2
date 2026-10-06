using HW_4;

Products products = new();
products.Water = "Bakuriani 1L(Water)";
products.House = "Palace";
products.GraphicCard = "RTX 5060";
products.Toy = "Star Destroyer Lego";
products.Phone = "Nokia 3310";
List<string> productList = [products.Water, products.House, products.GraphicCard, products.Toy, products.Phone];
Console.WriteLine("Name a Product You Want To Add");
string ExtraProduct1 = Console.ReadLine();
Console.WriteLine("Another One");
string ExtraProduct2 = Console.ReadLine();
Console.WriteLine("Another One");
string ExtraProduct3 = Console.ReadLine();
productList.Add(ExtraProduct1);
productList.Add(ExtraProduct2);
productList.Add(ExtraProduct3);
for (int i = 0; i < productList.Count; i++)
{
    Console.Write(productList[i] + ",");
}