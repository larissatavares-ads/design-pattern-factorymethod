using FactoryMethod.Interface;

namespace FactoryMethod.Personagem
{
    public class Katana : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Katana");
        }
    }
}
