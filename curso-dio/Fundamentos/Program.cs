using Biblioteca.Common.Models;





List<string> listaString = [];

listaString.Add("SP");
listaString.Add("SC");
listaString.Add("PR");
listaString.Add("RS");


for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine(listaString[i]);
}








// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 10;
// arrayInteiros[2] = 20;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine(arrayInteiros[i]);
// }













// foreach (int i in arrayInteiros)
// {
//     Console.WriteLine(i);
// }

















// Pessoa pessoa1 = new Pessoa();

// Calculadora calc = new Calculadora();





// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// if (possivelVenda)
// {
//     Console.WriteLine("venda realizada");
// }
// else if (quantidadeCompra == 0)
// {
//     Console.WriteLine("venda invalida");
// }
// else
// {
//     Console.WriteLine("sem estoque");
// }


// string a = "15-";
//
// int b = 0;
//
// int.TryParse(a, out b);
//
// Console.WriteLine(b);


// int a = 5;
// double b = a;

// Console.WriteLine(b);



// string a = 5.ToString();
// Console.WriteLine(a);



// int a = Convert.ToInt32("5");

// int a = int.Parse("5");

// Console.WriteLine(a);


// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5;

// Console.WriteLine(c);




// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
// Console.WriteLine(dataAtual.ToString("dd/MM/yy"));
// Console.WriteLine(dataAtual.ToString("HH:mm"));
// Console.WriteLine(dataAtual.ToString("mm:ss"));

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.50M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine(quantidade);
// Console.WriteLine(altura.ToString("0.00"));
// Console.WriteLine(preco);
// Console.WriteLine(condicao);



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Murilo";
// pessoa1.Idade = 23;
// pessoa1.Apresentar();