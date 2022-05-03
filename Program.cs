using System;
internal class Program
{
    static void Main(string[] args)
    {
        string userPassword = "password";
        string secretMail = "Купон на скидку в 75% на обучения в ЯЮниор: 66?*#98444";
        byte tryCount = 3;

        for (byte i = tryCount; i > 0; i--)
        {
            Console.Write("Введите пароль: ");
            if (Console.ReadLine() == userPassword)
            {
                Console.WriteLine("Теперь мы точно знаем, что вы член нашей команды, вот то, что вы искали: ");
                Console.WriteLine(secretMail);
                break;
            }
            else
            {
                Console.WriteLine("Либо вы ошиблись, либо вам здесь не рады.");
                Console.WriteLine($"У вас осталось {i-1} попыток");
            }
        }
    }
}