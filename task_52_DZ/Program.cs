Console.Clear();
YslovieZadachi();
//НАЧ: ПОСТАНОВКА ЗАДАЧИ
    void YslovieZadachi(){
        Console.Write("Задача 52.\n"+
        "!1!-Задайте двумерный массив\n"+
        "!2!-из целых чисел\n"+
        "!3!-Найдите среднее арифметическое элементов\n"+
        "!4!-в каждом столбце.");
    }
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//КОН: ПОСТАНОВКА ЗАДАЧИ

//НАЧ: МЕТОДЫ
    //-метод принимает string-сообщение & выводит его & пользователь вводит число & int-число возвращает:
    int Prompt(string message){
        int result = 0;
            try{
                Console.Write(message);
                result = int.Parse(Console.ReadLine());
            }
            catch{Console.WriteLine("\n ошибка метода Prompt");}
        return result;
    }
    //-метод принимает кол-во рядов и колонок & создаёт двумерный массив рандомных int чисел(от min=0 до max=10) & выводит его:
    int[,] GetIntTwoDimArrayAndPrint(int row,int col){
        int[,] result = new int[row,col];int min =0;int max=10;
            try{
                Console.WriteLine($"\nСоздан массив из {row} строк и {col} колонок, с рандомными числами от {min} до {max}:");
                for(int i=0;i<row;i++){
                    for(int j=0;j<col;j++){
                        result[i,j] = new Random().Next(min,max);
                        Console.Write($"{result[i,j]} | ");
                    }
                    Console.WriteLine();
                }
            }
            catch{Console.WriteLine("\n ошибка метода GetIntTwoDimArrayAndPrint");}
        return result;
    }
    //-метод принимает двумерный int-масссив & выводит среднее арифметическое:
    void PrintAverage_TwoDimArray(int[,] array){
        double sum = 0;
        double kol = 0;
        double result = 0;
        try{
            //-посчитать среднее арифметическое по каждой колонке:
            kol = Convert.ToDouble(array.GetLength(0));//-количество чисел в колонке равно количеству строк массива
            for(int col=0;col<array.GetLength(1);col++){//-по колонкам
                for(int row=0;row<array.GetLength(0);row++){//-по строкам
                    sum=sum+Convert.ToDouble(array[row,col]);
                }
                result=Math.Round(sum/kol,2);
                Console.WriteLine($"-в колонке={col+1},сумма={sum},количество чисел={kol}, среднее арифметическое равно {result}");
                sum=0;
            }
            //-посчитать общее среднее арифметическое:
            foreach(var el in array){
                 sum=sum+Convert.ToDouble(el);
             }
             kol = Convert.ToDouble(array.GetLength(0)*array.GetLength(1));
             result=Math.Round(sum/kol,2);
             Console.WriteLine($"Сумма всех чисел={sum},общее количество чисел={kol}, среднее арифметическое равно {result}");
        }
        catch{Console.WriteLine("\n\n ошибка метода PrintAverage_TwoDimArray");}
    }
//КОН: МЕТОДЫ

//НАЧ: РЕШЕНИЕ
    //-создать двумерный массив целых чисел:
    int[,] array = GetIntTwoDimArrayAndPrint(Prompt("\n\nДля создания массива\n ведите число строк массива: "),
                                             Prompt(" введите число колонок массива:"));
    //-посчитать среднее арифметическое двумерного массива
    PrintAverage_TwoDimArray(array);
//КОН: РЕШЕНИЕ