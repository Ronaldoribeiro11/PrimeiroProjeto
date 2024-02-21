using System.ComponentModel.Design;
using System.Dynamic;

string nome = "Ronaldo";
int idade = 18;
string cidade = string.Empty;

Console.WriteLine("Digite seu nome");
string entrada = Console.ReadLine();
if (entrada == nome) ;
{
    Console.WriteLine("Ola ronaldo quantos anos voce tem");
    int insert = int.Parse(Console.ReadLine());
    if (insert == idade) ;
    {
        Console.WriteLine("Muito bem daremos sequencia, de qual cidade vc é");
        string city = Console.ReadLine();

        if (cidade == city) ;
        {
            Console.WriteLine("muito bem cadastro concluido");
        }
    }

}


    



