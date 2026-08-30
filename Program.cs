//Vetores:

// Declarando com tamanho fixo
int[] idades = new int[5];

// Declarando e inicializando ao mesmo tempo
int[] notas = { 8, 7, 10, 6, 9 };

// Forma explícita
string[] nomes = new string[3] { "Ana", "Bruno", "Carla" };

string[] nomes2 = ["Ana", "Bruno", "Carla"];

//Acessando e modificando elementos:
Console.WriteLine(notas[0]);   
notas[2] = 5;                  
Console.WriteLine(notas.Length);

// Com for
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Nota {i}: {notas[i]}");
}

// Com foreach (mais simples, sem controle de índice)
foreach (int nota in notas)
{
    Console.WriteLine(nota);
}

//Leitura e impressão:
int[] numerosLeitura = new int[5];

for (int i = 0; i < numerosLeitura.Length; i++)
{
    numerosLeitura[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < numerosLeitura.Length; i++)
{
    Console.WriteLine("O valor na posição " + i + " é: " + numerosLeitura[i]);
}

int[] numeros = { 5, 2, 8, 1, 9 };

Array.Sort(numeros);           // ordena: {1, 2, 5, 8, 9}
Array.Reverse(numeros);        // inverte: {9, 8, 5, 2, 1}
int pos = Array.IndexOf(numeros, 8); // encontra a posição do valor 8
bool existe = Array.Exists(numeros, n => n > 7); // verifica se um ou mais valores existem no array

//Matrizes: 

//3 linhas, 4 colunas, tudo zerado
int[,] matriz = new int[3, 4];

//Inicializando com valores
int[,] tabuleiro = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Console.WriteLine(tabuleiro[1, 2]); // linha 1, coluna 2 -> 6
tabuleiro[0, 0] = 100;              // altera o primeiro elemento

for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++)
    {
        Console.Write(tabuleiro[linha, coluna] + " ");
    }
    Console.WriteLine();
}

//Diferente da matriz retangular, cada linha pode ter um tamanho diferente:
int[][] matriz2 = new int[3][];
matriz2[0] = new int[] { 1, 2 };
matriz2[1] = new int[] { 3, 4, 5 };
matriz2[2] = new int[] { 6 };

foreach (int[] linha in matriz2)
{
    foreach (int valor in linha)
    {
        Console.Write(valor + " ");
    }
    Console.WriteLine();
}

List<string> alunos = new List<string>();
List<int> numeros2 = new List<int> { 10, 20, 30 };

alunos.Add("Isabele");          // adiciona ao final
alunos.Add("Luis");
alunos.Insert(0, "Maria");      // insere em posição específica

alunos.Remove("Luis");          // remove pelo valor
alunos.RemoveAt(0);             // remove pelo índice

bool contem = alunos.Contains("Isabele"); // true
int total = alunos.Count;                 // quantidade de elementos

//Percorrendo a lista
foreach (int num in numeros2)
{
    Console.WriteLine(num + " ");
}

// Criando um dictionary onde a chave é string e o valor é int
Dictionary<string, int> nums = new Dictionary<string, int>();

// Adicionando elementos
nums.Add("Ana", 25);
nums.Add("Bruno", 30);
nums["Carla"] = 28; // outra forma de adicionar/atualizar

Console.WriteLine($"Idade da Ana: {nums["Ana"]}");

// Verificando se uma chave existe (evita exceção)
if (nums.ContainsKey("Bruno"))
{
    Console.WriteLine($"Bruno tem {nums["Bruno"]} anos");
}

// Removendo um item
nums.Remove("Bruno");

// Percorrendo todo o dictionary
Console.WriteLine("\nTodos os registros:");
foreach (KeyValuePair<string, int> item in nums)
{
    Console.WriteLine($"{item.Key}: {item.Value} anos");
}

Console.WriteLine($"\nTotal de pessoas: {nums.Count}");