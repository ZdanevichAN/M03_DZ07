// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
int PromptInt(string message){//метод принимает сообщение,возращает int введенный пользователем
    int result = 0;
        try{
            Console.WriteLine(message);
            result = int.Parse(Console.ReadLine());
        }
        catch{Console.Write("Ошибка данных метода PromptInt");}
    return result;
}
double[,] GetDoubleTwoDimArrayAndPrint(int row, int col){
    double[,] result = new double[row,col];
    try{
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                result[i,j] = Math.Round((new Random().NextDouble())*10,2);
                Console.Write($"{result[i,j]} | ");
            }
            Console.WriteLine();
        }
    }
    catch{Console.WriteLine("Ошибка данных метода GetDoubleTwoDimArrayAndPrint");}
    return result;
}

double[,] array = GetDoubleTwoDimArrayAndPrint(PromptInt("\n Введите количество строк двумерного массива: "),
                                               PromptInt("\n Введите количество колонок двумерного массива: "));