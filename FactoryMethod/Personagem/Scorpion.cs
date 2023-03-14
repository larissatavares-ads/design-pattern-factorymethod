using FactoryMethod.Interface;

namespace FactoryMethod.Personagem
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Scorpion");
        }
    }
}
