void PrintArray(double[] numbers)                   // для вывода массива
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " | ");
    }
    Console.WriteLine();
}
double FindVolume(double r1, double r2, double h)   // для находения обьема промежутка
{
    double pi = 3.14;
    double v = (pi * h * (Math.Pow(r1, 2) + r1 * r2 + Math.Pow(r2, 2))) / 3;
    return v;
}
double[] DivArray(double[] array)                   // для находения радиуса
{
    int size = array.Length;
    double[] divArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        divArray[i] = array[i]/2;
    }
    return divArray;
}
double[] SumArray(double[] array)                   // для находения сумм высот
{
    int size = array.Length;
    double sum = 0;
    double[] sumArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        sum = sum + array[i];
        sumArray[i] = sum;
    }
    return sumArray;
}
double VvodimoeChislo(string msg)                   // для ввода данных
{
    Console.Write(msg);
    string number = Console.ReadLine()!;
    double VvodimoeChislo = Convert.ToInt32(number);
    return VvodimoeChislo;
}
double[] ReverseArray(double[] array)               // поворот массива
{
    double [] revArray =new double [array.Length];
    for (int i=0; i<array.Length; i++)
    {
        int s = array.Length;
        revArray[i]=array[s-1-i];
    }
    return revArray;
}




double h = VvodimoeChislo("Введите замер ");                                // ввод замера
double[] diametr = new double[] { 0.164, 3, 3, 0.315, 0.315, 3, 3 };        // диаметры отрезка колоны
double[] height = new double[] { 1.335, 7.31, 0.3, 1.7, 0.993, 1 };         // высоты отрезка колон
double[] divD = DivArray(diametr);                                          // радиусы отрезка колон (для расчетов)
double[] sumH = SumArray(height);                                           // сумма высот колон
double vtotal = 0;
double vzapolneni = 0;
double hzapolneni = sumH[sumH.Length-1]-h;
for (int i = 0; i < height.Length; i++)                                     // общий обьем
{
    vtotal = vtotal + FindVolume(divD[i], divD[i + 1], height[i]);
}
for (int k = 0; k < height.Length; k++)                                     // обьем запонленного 
{
    if (hzapolneni>sumH[k])
    {
        vzapolneni = vzapolneni + FindVolume(divD[k], divD[k + 1], height[k]);
    }
    else
    {
        double hdif = sumH[k]-hzapolneni;
        vzapolneni = vzapolneni + FindVolume(divD[k-1], divD[k], hdif);
    }
}

Console.WriteLine("   " + vzapolneni);
Console.WriteLine("");
Console.WriteLine("Общая высота колоны: " + sumH[sumH.Length-1]);
Console.WriteLine("Осточная высота: " + hzapolneni);
Console.WriteLine("Полный обьем колоны: " + vtotal);
Console.WriteLine("");
Console.Write("Диаметры отрезка ");PrintArray(diametr);
Console.Write("Радиусы отрезка ");PrintArray(divD);
Console.Write("Высоты отрезка ");PrintArray(height);
Console.Write("Сумма высот ");PrintArray(sumH);






















// // PrintArray(array); 
// double h = 7;
// double hmin = 0;
// for (int j = 0; hmin < h; j++)
//     {
//         hmin = hmin + array[j];
//         vnapolnenost = vnapolnenost + FindVolume(radius[j], radius[j + 1], height[j]);
//     }
// double hostatok = h - hmin;
// vnapolnenost = vnapolnenost + FindVolume(radius[j], radius[j + 1], height[j]);