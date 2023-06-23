/*int [] numbers = new int[5] {3,2,3,4,6}; or

int [] numbers = {3,2,3,4,6};
Or

int [] numbers;
    numbers = new int [] {3,2,3,4,6};

    Console.Write(number[0]);

int [] numbers = new int[5] {3,2,3,4,6}; 
    for (int i=0; i<numbers.Length; i++)
    {Console.Write(number[i]+" ");}
or link type data

int [] numbers = new int[] {3,2,3,4,6}; 
int [] numbers2 = new int[] {30,20,40,40,46}; 

number2= number1
number1[0]=990;
number2[0]=223;
Console.Write(number2[0]);  exit  999 

изменить размер массива командами 

int [] numbers = new int[] {3,2,3,4,6}; 
int [] temp = new int[number.Length +1]; 

Console.Write(number2[1]);

or 

string name ="MArina";
char symol ="!";
Console.WriteLine(name.Length);
*/
// Написать программу вводящую массив из 8 элементов заполненный 0 и 1 в случайном порядке

int size = 8;
int[] numbers= new int[size];

for(int i=0; i<numbers.Length; i++)
{
    numbers[i]=new Random().Next(0,2);
    Console.Write(numbers[i]+" ");
}




