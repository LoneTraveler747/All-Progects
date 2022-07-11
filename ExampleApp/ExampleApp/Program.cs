using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ExampleApp
{
    class Program
    {

        static void Writer()
        {
            if(!File.Exists("Example.txt"))//Проверка на существование файла
            {
                File.Create("Example.txt").Close(); //Создание файла, в случае, если его нету.
            }

            using(StreamWriter sw = new StreamWriter("Example.txt")) //Открытие потока на запись
            {
                sw.WriteLine("Mother");//Запись строки 1
                sw.WriteLine("Father");//Запись строки 2
                sw.WriteLine("Brother");//Запись строки 3
            }//Тут поток закрылся
        }

        static void Reader_good()
        {
            string word_one = "", word_two = "", word_three = ""; //Объявили переменные, которые нужно получиться
            int count = 0;//Объявили переменную-счетчик
            
            Console.WriteLine("word_one now: " + word_one);//Вывели текущее состояние первого слова(первой переменной)
            Console.WriteLine("word_two now: " + word_two);//Вывели текущее состояние второго слова(второй переменной) 
            Console.WriteLine("word_three now: " + word_three);//Вывели текущее состояние третьего слова(третьей переменной)

            if (!File.Exists("Example.txt"))//Провека на существование файла
            {
                File.Create("Example.txt").Close();//Создание файла, в случае, если его нету.
            }

            using(StreamReader sr = new StreamReader("Example.txt"))//Открытие потока на чтение
            {
                while (!sr.EndOfStream)//Чтение файла до тех пор, пока не наступит его конец
                {

                    switch(count)//Если счетчик равен...
                    {
                        case 0://0 -- то...
                            {
                                word_one = sr.ReadLine();//В файле это первое слово и его нужно записать в переменную с первым словом.
                                break;
                            }

                        case 1://1 -- то...
                            {
                                word_two = sr.ReadLine();//В файле это второе слово и его нужно записать в переменную со вторым словом.
                                break;
                            }

                        case 2://2 -- то...
                            {
                                word_three = sr.ReadLine();//В файле это третье слово и его нужно записать в переменную с третьим словом.
                                break;
                            }
                    }

                    count++;//Увеличение счетчика
                }
            }//Поток чтения закроется тут

            Console.WriteLine("Read has been compled successfully!");//Вывод сообщение об успешном чтении

            Console.WriteLine("word_one now: " + word_one);//Вывод первой переменной после чтения
            Console.WriteLine("word_two now: " + word_two);//Вывод второй переменной после чтения
            Console.WriteLine("word_three now: " + word_three);//Вывод третьей переменной после чтения


        }

        static void Reader_bed()
        {
            string word_one = "", word_two = "", word_three = "";//Объявление переменных, которые нужно получить

            Console.WriteLine("word_one now: " + word_one);//Вывод текущего состояния переменных до чтения.
            Console.WriteLine("word_two now: " + word_two);//Вывод текущего состояния переменных до чтения.
            Console.WriteLine("word_three now: " + word_three);//Вывод текущего состояния  переменных до чтения.

            if (!File.Exists("Example.txt"))//Проверка файла на существование
            {
                File.Create("Example.txt").Close();//Если файла нет, создать его
            }

            using (StreamReader sr = new StreamReader("Example.txt"))//Открыть поток для чтения
            {
                try//Блок обработки возможных ошибок
                {
                    word_one = sr.ReadLine();//Чтение первой переменной
                    word_two = sr.ReadLine();//Чтение второй переменной
                    word_three = sr.ReadLine();//Чтение третьей переменной
                }
                catch(Exception exp)//Блок обработки возможных ошибок часть 2
                {
                    Console.WriteLine(exp.Message);//Вывод сообщения об ошибке
                }
                
            }//Поток чтения закроется тут

            Console.WriteLine("Read has been compled successfully!");//Выовд сообщения об успешном прочтении.

            Console.WriteLine("word_one now: " + word_one);//Вывод текущего состояния переменной первой после прочтения
            Console.WriteLine("word_two now: " + word_two);//Вывод текущего состояния второй первой после прочтения
            Console.WriteLine("word_three now: " + word_three);//Вывод текущего состояния переменной третьей после прочтения


        }

        static void Main(string[] args)
        {
            //Writer();

            //Reader_good();

            Reader_bed();
            //ЫЫЫЫ

            //Я думал, что если прочитать из файла 3 строки, когда в файле тока 2, будет ошибка, поэтому городил конструкцию защиты через while(паранойя).
            //Но к моему удивлению, этого не произошло. Так что можно и кратче.


            //Вопросы?

            //У тебя идёт запись в файл, так? Вот, а как ты выводил в TextBox. 

            
            //Я понял твой вопрос. Ты понял тот момент, что мы получили строки из файла и записали их в локальные переменные? Да. Ты понял, как мы это сделали? По теме ввода/вывода из текстового файла вопросы есть? Понятно! Проект специально тебе создал отдельный простой и раскоментировал. В случае чего сможешь вернуться сюда и подглядеть.
            //Теперь твой второй вопрос.

            Console.ReadKey();

        }
    }
}
