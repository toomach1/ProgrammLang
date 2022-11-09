Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int sqrt=num2*num2;
if (sqrt==num1){
    Console.WriteLine("первое число является квадратом второго");
}
else{
    Console.WriteLine("первое число не является квадратом второго");
}