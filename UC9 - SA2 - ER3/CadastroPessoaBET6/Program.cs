using CadastroPessoaBET6.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodosPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.Nome = "Odirlei";
novaPf.dataNasc = new DateTime(2000, 01, 01);
novaPf.Cpf = "1234567890";
novaPf.Rendimento = 3500.5f;

novoEndPf.logradouro = "Alameda barao de limeira";
novoEndPf.numero = 539;
novoEndPf.complemento = "SENAI Informatica";
novoEndPf.endComercial = true;

novaPf.Endereco = novoEndPf;


Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
");


// Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
// Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);