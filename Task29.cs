// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
for (int count = 0; count < i; count++) {
    array[count] = new Random().Next(1, 100);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
