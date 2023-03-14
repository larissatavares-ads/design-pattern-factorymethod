using FactoryMethod.Interface;

FactoryMethod.UseCase.FactoryMethod fm = new FactoryMethod.UseCase.FactoryMethod();

Console.WriteLine("Liu Kang | SubZero | Scorpion | Katana");
Console.WriteLine();
Console.Write("Escolha seu Personagem: ");
string escolha = Console.ReadLine();
IPersonagem personagem = fm.Escolher_Personagem(escolha);
Console.WriteLine();
Console.Write("Você vai jogar com ");
personagem.Escolhido();
Console.ReadKey();