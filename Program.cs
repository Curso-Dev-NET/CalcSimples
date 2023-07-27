int adicao(int num1, int num2){
    return num1 + num2;
}

int subtracao(int num1, int num2){
    return num1-num2;
}

int multiplicacao(int num1, int num2){
    return num1 * num2;
}

int divisao(int num1, int num2){
    int res;
    res = num1/num2;
    return res;
}

int resto(int num1, int num2){
    return num1%num2;
}


var input1 = Console.ReadLine();
var input2 = Console.ReadLine();
// int num1 = Int32.Parse(input1);
// int num2 = Int32.Parse(input2);
int num1 = System.Convert.ToInt32(input1);
int num2 = System.Convert.ToInt32(input2);
Console.WriteLine("Adição: " + adicao(num1, num2));
Console.WriteLine("Subtração: " + subtracao(num1, num2));
Console.WriteLine("Multiplicação: " + multiplicacao(num1, num2));
Console.WriteLine("Divisão Inteira: " + divisao(num1, num2));
Console.WriteLine("Resto: " + resto(num1, num2));


