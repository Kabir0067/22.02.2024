var rectan1 = new Rectangle();
System.Console.Write(" Width-ro Doxil kuned: ");
rectan1.width = int.Parse(Console.ReadLine());
System.Console.Write(" Height-ro Doxil kuned: ");
rectan1.height =int.Parse(Console.ReadLine());
System.Console.Write(" Color-ro Doxil kuned: ");
rectan1.color = Console.ReadLine();

System.Console.WriteLine("________________________");
System.Console.WriteLine($"Masohatash={rectan1.GetArea()}");
System.Console.WriteLine($"Perimetrash={rectan1.GetPerimeter()}");
System.Console.WriteLine($"Color={rectan1.color}");