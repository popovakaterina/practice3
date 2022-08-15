// Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("введите координаты первой точки (xyz): ");
Console.Write("Введите х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки (xyz): ");
Console.Write("Введите х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

// √((x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2)
int x = x2-x1;
int y = y2-y1;
int z = z2-z1;

double x_sqr = Math.Pow(x,2);
double y_sqr = Math.Pow(y,2);
double z_sqr = Math.Pow(z,2);
double sum = x_sqr + y_sqr + z_sqr;
double sqr = Math.Sqrt(sum);
Console.WriteLine(Math.Round(sqr,2));

//A (7,-5, 0); B (1,-1,9) -> 11.53
// A (3,6,8); B (2,1,-7), -> 15.84