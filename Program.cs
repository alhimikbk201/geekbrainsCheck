int lengthArrInput, lengthArrResolt;

string number1;



Console.Write("Введите желаемое количество слов  ");

number1 = Console.ReadLine()!;

int.TryParse(number1, out lengthArrInput);

string [] array =  new string [lengthArrInput];

for(int i = 0; i < array.Length; i ++) {
    Console.Write("Введите желаемые слова  ");
    array[i] = Console.ReadLine()!;
}

/* for(int i = 0; i < array.Length; i ++) {
    Console.Write(array[i]);
    
} */

lengthArrResolt = getAmountStringlessFourSimdol(array);

string [] newArray =  new string [lengthArrResolt];



getArrLessFoursimbol(array, newArray);


void getArrLessFoursimbol(string [] _arr, string [] _newArr) {
   int count = 0;
    for(int j = 0; j < _arr.Length; j++) {
        if(_arr[j].Length < 4) {
           _newArr[count] = _arr[j];
           count++;  

        }
    }

    printArr(_newArr);


} 

int getAmountStringlessFourSimdol(string [] _arr) {
    int count = 0;
    for(int i = 0; i < _arr.Length; i++) {
        if(_arr[i].Length < 4) {
            count++;
        }
        
    }

    return count; 

}
void printArr(string [] _arr) {
for(int i = 0; i < _arr.Length; i ++) {
    Console.Write($"{_arr[i]} ");
    
}
}