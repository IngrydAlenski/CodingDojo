using System.Linq.Expressions;

string NomedoVendedor;
try { 
Console.WriteLine(" Insira o nome do vendedor: ");
string nome = Console.ReadLine();

Console.WriteLine("Qual e o nivel (I,II,III) do vendedor: ");
string nivel = Console.ReadLine();

Console.WriteLine("Quanto o vendedor vendeu: ");
if ( !decimal.TryParse (Console.ReadLine(), out decimal vendas)|| vendas < 0)
        {
    Console.WriteLine("Erro: Valor invalido");
    return;
}
decimal bonus   = 0;

switch (nivel)
{
    case "I":
        {
            if (vendas > 80000)
            {
                Console.WriteLine($"O vendedor {nome}, nivel I foi promovido ao nivel II");
            }
            else if (vendas > 50000)
            {
                bonus = vendas * 0.35m;
            }
            else if (vendas > 20000)
            {
                bonus = vendas * 0.20m;
                
                }
            else if(vendas < 5000)
            {
                Console.WriteLine($"vendedor {nome}, nivel I, esta em risco de demissao");
            }
                break ;
            
        }
    case "II":
        if (vendas > 20000)
        {
            Console.WriteLine($"O vendedor {nome}, nivel II foi promovido ao nivel III");
        }
        else if (vendas > 120000)
        {
            bonus = vendas * 0.40m;
        }
        else if (vendas > 90000)
        {
            bonus = vendas * 0.25m;

        }
        else if (vendas < 50000)
        {
            Console.WriteLine($"vendedor {nome}, nivel II, esta em risco de virar nivel I");
        }
        break;
   case "III":
    if (vendas > 50000)
    {
        Console.WriteLine($"O vendedor {nome}, nivel III, promovido a gerente!");
    }
    else if (vendas > 250000)
    {
        bonus = vendas * 0.45m;
    }
    else if (vendas > 210000)
    {
        bonus = vendas * 0.30m;

    }
    else if (vendas < 100000)
    {
        Console.WriteLine($"vendedor {nome}, nivel III, esta em risco de virar nivel II");
    }
    break;

default:
    Console.WriteLine("Erro: Nivel invalido.");

    return;
}

if( bonus > 0)
{
    Console.WriteLine($"O vendedor {nome}, nivel {nivel}, devera receber uma bonificacao R${bonus: F2}.");

}

}
catch (Exception ex)
{
    Console.WriteLine($"Erro inesperado: {ex.Message}");
}