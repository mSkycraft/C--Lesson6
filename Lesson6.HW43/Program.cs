// Задача 43

Console.WriteLine("Задача 43");
Console.Write("Введите число b1 - ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("Введите число k1 - ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Введите число b2 - ");
float b2 = float.Parse(Console.ReadLine());
Console.Write("Введите число k2 - ");
float k2 = float.Parse(Console.ReadLine());

List<double> per(float b1, float k1, float b2, float k2){
    List<double> point = new List<double>();
    point.Add((b2-b1)/(k1-k2));
    point.Add(k1*point[0]+b1);
    return point;
}

List<double> answer = per(b1,k1,b2,k2);

Console.WriteLine("X:" + answer[0] + " Y:" + answer[1]);

