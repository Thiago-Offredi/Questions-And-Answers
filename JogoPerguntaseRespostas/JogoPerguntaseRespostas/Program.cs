using System;
namespace questionsAndAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            // jogo de perguntas
            int score = 0;
           
           
           
            
            

            Console.WriteLine("Quanto é 5 + 5 ? \n escreva abaixo");
            int answers_One = Convert.ToInt32(Console.ReadLine());
            if (answers_One == 10)
            {
                Console.WriteLine("Você acertou " + score++ + " ponto ");
            }
          

            Console.WriteLine("Quanto é 10 + 5 ? \n escreva abaixo");
            int answers_Two = Convert.ToInt32(Console.ReadLine());
            if (answers_Two == 15) {
                Console.WriteLine("Você acertou " + score++ + " ponto ");
            }
        
                    
            Console.WriteLine("Qual a capital do Brasil?\n escreva abaixo");
            string answers_Threee = Console.ReadLine();
            if (answers_Threee == "Brasilia")
            {
                Console.WriteLine("Você acertou " + score++ + " ponto ");
            }
            
            Console.WriteLine("Quem é o pai do naruto? \n escreva abaixo");
            string answers_Four = Console.ReadLine();
            if (answers_Four =="Minato")
            {
                Console.WriteLine("Você acertou " + score++ + " ponto ");
            }
         
            Console.WriteLine("Quem é a mãe do naruto? \n escreva abaixo");
            string answers_Five = Console.ReadLine();
            if (answers_Five=="Kushina")
            {
                Console.WriteLine("Você acertou " + score++ + " ponto ");
            }
         
            Console.WriteLine("Quanto é 12.5 + 2 ?\n escreva abaixo" );
            float answers_Six= float.Parse(Console.ReadLine());
            if (answers_Six == 14.5f)
            {
                Console.WriteLine("Você acertou " + score++ + " ponto ");
            }
        

            Console.WriteLine("O seu total de pontos foi " + score);
        }
    }
};



