Console.Clear();
YslovieZadachi();
//НАЧАЛО: ПОСТАНОВКА ЗАДАЧИ
    void YslovieZadachi(){
    Console.WriteLine("Задача 50. Напишите программу,\n"+
            "!1!которая на вход принимает позиции элемента\n"+
            "!2!в двумерном массиве,\n"+
            "!3!и возвращает значение этого элемента\n"+
            "!4!или же указание, что такого элемента нет.\n");
        }
                            // Например, задан массив:
                            // 1 4 7 2
                            // 5 9 2 3
                            // 8 4 2 4
                            // [1,7] -> такого числа в массиве нет
//КОНЕЦ: ПОСТАНОВКА ЗАДАЧИ

//НАЧАЛО: МЕТОДЫ
    //-метод получает и выводит сообщение/возвращает int введенный пользователем:
    int PromptInt(string message){
        int result = 0;
        try{
            Console.Write(message);
            result = int.Parse(Console.ReadLine());
        }
        catch{Console.WriteLine($"ОШИБКА метода PromptInt, ПРИСВОЕНО ЗНАЧЕНИЕ = {result}");}
        return result;
    }

    //-метод получает кол-во рядов и строк массива/создаёт и возвращает двумерный массив рандомных int:
    int[,] GetIntTwoDimArrayAndPrint(int row,int col){
        int[,] result = new int[row,col];int min=0;int max=10;
            try{
                Console.WriteLine($"\n Создан массив из {row} строк и {col} колонок \n заполненный числами от {min} до {max}:");
                for(int i=0;i<row;i++){
                    for(int j=0;j<col;j++){
                        result[i,j] = new Random().Next(min,max);
                        Console.Write($"{result[i,j]} | ");
                    }
                    Console.WriteLine();
                }
            }
            catch{Console.WriteLine("ОШИБКА метода GetIntTwoDimArrayAndPrint, возврат пустого массива");}
        return result;
    }

    //-метод получает двумерный массив типа double,ряд int,колонку int/выводит элемент массива[ряд,колонка]:
    void NumOfPossition_TwoDimArray(int[,] array,int row,int col){
        try{
                if     (row>array.GetLength(0)) {Console.WriteLine($"в созданном выше массиве нет строки = {row}");}
                else if(col>array.GetLength(1)) {Console.WriteLine($"в созданном выше массиве нет колонки = {col}");}
                else   {Console.WriteLine($"в созданном выше массиве\n  строке = {row} | колонке = {col}\n содержится число = {array[row-1,col-1]}");}
            }
        catch{Console.WriteLine($"ошибка метода NumOfPossition_TwoDimArray");}
    }
//КОНЕЦ: МЕТОДЫ

//НАЧАЛО: РЕШЕНИЕ
    //-задать массив:
    int[,] array = GetIntTwoDimArrayAndPrint(PromptInt("Введите количество строк для создания массива рандомных чисел типа int: "),
                                            PromptInt("Введите количество колонок массива: "));
    //-спросить позиции массива(ряд/колонка) у пользователя/через метод вывести содержащееся в данной позиции число:
    NumOfPossition_TwoDimArray(array,
                               PromptInt("Введите ряд искомого числа в массиве: "),
                               PromptInt("Введите колонку искомого числа в массиве: "));
//КОНЕЦ: РЕШЕНИЕ