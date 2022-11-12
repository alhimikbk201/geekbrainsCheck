int m;

string number1;

Console.Write("Введите желаемое количество слов  ");

number1 = Console.ReadLine()!;

int.TryParse(number1, out m);

string [] array =  new string [m];

for(int i = 0; i < array.Length; i ++) {
    Console.Write("Введите желаемые слова  ");
    array[i] = Console.ReadLine()!;
}

for(int i = 0; i < array.Length; i ++) {
    Console.Write(array[i]);
    
}