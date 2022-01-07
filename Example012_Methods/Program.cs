// Вид  1
//void Method1()
{
//    Console.WriteLine("Автор ");
}
//Method1();

// Вид 2
//void Method2(string msg)
{
 //   Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

//void Method21(string msg, int count)
{
 //   int i = 0;
 //   while (i<count)
    {
 //       Console.WriteLine(msg);
 //       i++;
    }
}
// Method21("Текст", count:4);
// Method21(count:4, msg: "Новый текст");

// Вид 3
//int Method3()
{
 //   return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);

// Вид 4
//string Method4(int count, string text)
{
 //   int i = 0;
  //  string result = string.Empty;

  //  while (i < count)
    {
    //    result = result + text;
    //    i++;
    }
    //return result;
}

//string res = Method4(10, "f");
//Console.WriteLine(res);

// Таблица умножения
 for (int i = 2; i<=10; i++)
 {
     for(int j =0; j<10; j++)
     {
         Console.WriteLine($"{i}x{j}={i*j}");
     }
     Console.WriteLine();
 }

 // Дан текст.В тексте нужно все проблемы заменить черточками маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "c".
 // Ясна ли задача?