Console.Write("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите cтепень в которую необходимо возвести число {namber}: ");
int degreeNam = Convert.ToInt32(Console.ReadLine());


double erectDegree(int namber, int degreeNam){
    double result = 1;
    for(int i = 0; i<degreeNam; i++) result*=namber;
    return result;
}

Console.WriteLine(erectDegree(namber, degreeNam));