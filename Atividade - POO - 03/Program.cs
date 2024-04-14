using atv_poo3;


Produto v1 = new Produto("Tv 60", 5400);
Produto v2 = new Produto("Playstation 5", 3300);
Produto v3 = new Produto("Iphone 15 PRO MAX", 4400); 

Console.WriteLine("\nProdutos:\n");
v1.Mostrar_Atributos();
v2.Mostrar_Atributos();
v3.Mostrar_Atributos();


// Criando Vendedor, Comprador e Operação de Venda
Vendedor vendedor1 = new Vendedor(0, "Lucas");
Comprador comprador1 = new Comprador(9000.0, "Diego");
Venda venda1 = new Venda(comprador1);


// Adicionando itens no "Carrinho" e Mostrando detalhes
System.Console.WriteLine();
venda1.AdicionarProduto(v2);
venda1.AdicionarProduto(v3);
venda1.MostrarDetalhes();


// Exibindo Comissão do Vendedor
Console.WriteLine("Comissão do Vendedor Sobre Operação:");
vendedor1.Mostrar_Atributos();
Console.WriteLine($"\n\nSaldo atual do comprador {comprador1.Nome} após a compra: R${comprador1.Verba}.\n");


// Tratativa na classe produto

// Produto v4 = new Produto("", 5400);
// Console.WriteLine("\nProdutos:\n");
// v4.Mostrar_Atributos();


// Produto v5 = new Produto("teste", -0.5);
// Console.WriteLine("\nProdutos:\n");
// v5.Mostrar_Atributos();
