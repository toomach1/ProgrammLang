Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num<0){
    Console.WriteLine("Число не может быть отрицательным");
    Console.WriteLine("Введите новое число");
    int num1 = Convert.ToInt32(Console.ReadLine());  
    num=num1;
}



else{
    
    int num_minus=-num;
while(num_minus!=num){
    Console.Write(num_minus + ", ");
    num_minus++;
}
}

Console.WriteLine(num);
