Console.WriteLine("Введите число: ");
string namber = Console.ReadLine();


int sumNamber(string namber){
    int result = 0;
    for (int i = 0; i < namber.Length; i++) result += int.Parse(namber[i].ToString());
    return result;
}

int result = sumNamber(namber);
Console.WriteLine(result);