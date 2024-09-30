using System.Globalization;
using ExemploExplorando.Models;
using Newtonsoft.Json;
































// Venda v1 = new(1, "material", 23.00M);

// string serializado = JsonConvert.SerializeObject(v1);


























// (int, string, string) tupla = (1, "Murilo", "Scneider");

// ValueTuple<int, string, string, decimal> outraTupla = (1, "Murilo", "Scneider", 10.5M);

// Console.WriteLine(tupla.Item1);













// Dictionary<int, string> estados = new();

// estados.Add(10, "SC");
// estados.Add(11, "BA");


// estados.Remove(11);

// estados[10] = "outra coisa";


// foreach (var item in estados)
// {
//     Console.WriteLine(item);
// }




























// Stack<int> pilha = new();

// pilha.Push(4);
// pilha.Push(8);
// pilha.Push(16);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// pilha.Pop();

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

















// Queue<int> fila = new();


// fila.Enqueue(2);

// fila.Enqueue(4);

// fila.Enqueue(6);

// fila.Enqueue(8);

// fila.Dequeue();

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }












// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }







// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// DateTime dataSetada = DateTime.Parse("17/08/2024 18:00");
// Console.WriteLine(dataSetada);




// string dataString = "17/08/2024 18:00";

// DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataSaida);


// Console.WriteLine(dataSaida);

















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 82.40M;

// Console.WriteLine(valorMonetario.ToString("C1"));

// double porcentagem = .3492;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));




















// Pessoa p1 = new Pessoa(nome: "Estevao", sobrenome: "Schneider");
// Pessoa p2 = new Pessoa("Murilo", "Schneider");


// Curso cursoIngles = new Curso();
// cursoIngles.Nome = "Ingles";
// cursoIngles.Alunos = new List<Pessoa>();

// cursoIngles.AdicionarAluno(p1);
// cursoIngles.AdicionarAluno(p2);
// cursoIngles.ListarAlunos();


// Pessoa p1 = new Pessoa();
// p1.Nome = "Murilo";
// p1.Sobrenome = "Schneider";
// p1.Idade = 23;

// p1.Apresentar();