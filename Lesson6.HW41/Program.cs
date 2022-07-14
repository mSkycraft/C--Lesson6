// Задача 41

Console.WriteLine("Задача 41");
Console.Write("Введите число элементов - ");
int M = int.Parse(Console.ReadLine());

int bolshezero(int M){
    int count = 0;
    for(int i = 0;i<M;i++){
        Console.Write("Введите число №" + (i+1) + " - ");
        if (int.Parse(Console.ReadLine())>0)
            count = count + 1;
    }

    return count;
}

Console.WriteLine("Число элементов больше 0 равно "+ bolshezero(M));