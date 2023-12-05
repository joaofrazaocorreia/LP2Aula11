using System;
using System.Threading;
using System.Collections.Concurrent;

namespace InputSystem
{
    public class Program
    {
        // Coleção thread-safe, usa internamente uma Queue (primeira tecla a
        // entrar é a primeira a sair)
        private static BlockingCollection<ConsoleKey> fila;
        private static BlockingCollection<ConsoleKeyInfo> filaPeek;

        private static void Main()
        {
            Thread producer = new Thread(ReadKeys);
            Thread consumer = new Thread(ShowKeyOnScreen);

            fila = new BlockingCollection<ConsoleKey>();
            filaPeek = new BlockingCollection<ConsoleKeyInfo>();

            Console.WriteLine("Podes começar a carregar nas teclas");

            producer.Start();
            consumer.Start();

            producer.Join();
            consumer.Join();

            Console.WriteLine("Obrigado!");
            foreach (ConsoleKeyInfo ck in filaPeek)
                Console.Write(ck.KeyChar.ToString());
        }

        // Método produtor:
        // Lé as teclas do teclado e coloca-as na fila
        private static void ReadKeys()
        {
            ConsoleKeyInfo key = default;

            while(key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true);

                fila.Add(key.Key);
                filaPeek.Add(key);
            }
        }

        // Método consumidor:
        // Obtém/retira as teclas da fila, e apresenta informação no ecrã
        private static void ShowKeyOnScreen()
        {
            ConsoleKey key = default;

            while(key != ConsoleKey.Escape)
            {
                key = fila.Take();


                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                    Console.WriteLine("Cima");

                else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                    Console.WriteLine("Baixo");

                else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                    Console.WriteLine("Esquerda");

                else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                    Console.WriteLine("Direita");
            }
        }
    }
}