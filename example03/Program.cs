//  Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
int[] Array(){
Random myRandom = new Random();
int [] array = new int[8];
for(int i = 0; i < array.Length; i++){
    Console.WriteLine("Введите число");
    array[i] = myRandom.Next(0 , 20);
    // array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}
void ShowArray(int[] array){
 for(int i = 0 ; i < array.Length; i++){
    Console.Write($"{array[i]}");
 }
}
ShowArray(Array());