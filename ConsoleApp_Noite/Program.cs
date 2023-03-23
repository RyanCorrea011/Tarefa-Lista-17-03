
using ConsoleApp_Noite;
using ConsoleApp_Noite.Heranca;

//Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());


p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litrão");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco endereco = new Endereco(
    "Rua Mario Miziara",
    "91",
    "Sobral",
    "15906304",
    "Taquaritinga",
    "SP");

Cliente c1 = new Cliente(1, "Gabriele", "991340447", endereco);
Cliente c2 = new Cliente(2, "Gabriela", "991340447",endereco);
Cliente c3 = new Cliente(3, "Ryan", "991340447", endereco);
Cliente c4 = new Cliente(4, "Jhonatan", "991340447", endereco);
Cliente c5 = new Cliente(5, "Andre", "991340447", endereco);

Console.WriteLine( c2.getEndereco().getRua() + " "+c2.getEndereco().getNumero() );

c2.getEndereco().setNumero("135");

Console.WriteLine(c2.getEndereco().getNumero());
Console.WriteLine(c2.getEndereco().EnderecoCompleto());
c2.getEndereco().EnderecoCompleto();



Carro gol = new Carro();
gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssentos = 5;

Bike caloi = new Bike();
caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;
caloi.Nome = "Caloi";

gol.fabricante = "VW";
gol.cintoSeguranca = true;
gol.arCondicionado = false;
gol.Nome = "Golzinho";

Carro Saveiro = new Carro();
Carro Palio = new Carro();
Carro Uno = new Carro();

Saveiro.fabricante = "VW";
Saveiro.Nome = "Saveiro";
Palio.fabricante = "Fiat";
Palio.Nome = "Palio";
Uno.fabricante = "Fiat";
Uno.Nome = "Uno";


Bike speed = new Bike();
speed.temMotor = false;
speed.numeroPortas = 0;
speed.numeroAssentos = 1;
speed.Nome = "speed";
// Faça uma ação chamada ExibirDados e
// mostre as informações na tela pelo Console.Writeline
Console.WriteLine( speed.ExibirDados() );
Console.WriteLine( gol.ExibirDados() );



List<Carro> listaCarros = new List<Carro>();
listaCarros.Add(gol);
listaCarros.Add(Palio);
listaCarros.Add(Uno);
listaCarros.Add(Saveiro);

Console.WriteLine(listaCarros[0].fabricante);
listaCarros.Remove(Palio);

for (int i = 0; i < listaCarros.Count; i++)
{
    Console.WriteLine(listaCarros[i].ExibirDados());
}

foreach (var item in listaCarros)
{
    Console.WriteLine(item.ExibirMarca());
}

//Imprima na tela todos os clientes desse contexto;
//Dica crie uma lista para eles.
Console.WriteLine("-------------------------------------------");
Console.WriteLine(c1.getNome());
Console.WriteLine(c2.getNome());
Console.WriteLine(c3.getNome());
Console.WriteLine(c4.getNome());
Console.WriteLine(c5.getNome());

//Crie uma lista com 560 produtos
//Imprima na tela

List<Produto> listaProdutos = new List<Produto>();
for (int i = 0; i < 560; i++)
{
    Produto p = new Produto(i + 1, i * 1.1M, "Produto Nº " + (i + 1).ToString());
    listaProdutos.Add(p);
}

foreach (Produto p in listaProdutos)
{
    Console.WriteLine(p.getDescricao() + " - Valor R$ " + p.getValor().ToString());
}
Console.WriteLine("-------------------------------------------");
//Crie uma lista que aceite qualquer tipo de veiculo
//Imprimam na tela
Console.WriteLine("Lista de veiculos:");
List<Veiculo> listaVeiculos = new List<Veiculo>();
{
    listaVeiculos.Add(gol);
    listaVeiculos.Add(speed);
    listaVeiculos.Add(Saveiro);
    listaVeiculos.Add(Palio);
    listaVeiculos.Add(Uno);
    listaVeiculos.Add(caloi);
}
foreach(var veiculo in listaVeiculos)
{
    if (veiculo is Carro)
    {
        Carro carro = (Carro)veiculo;
        Console.WriteLine("Carro: " + carro.Nome);
    }
    else if (veiculo is Bike)
    {
        Bike bike = (Bike)veiculo;
        Console.WriteLine("Bike: " + bike.Nome);
    }
}