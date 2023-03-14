using FactoryMethod.Interface;
using FactoryMethod.Personagem;

namespace FactoryMethod.UseCase
{   
    public class FactoryMethod
    {
        public IPersonagem Escolher_Personagem(string personagem)
        {
            switch (personagem)
            {
                case "LiuKang": return new LiuKang();
                case "SubZero": return new SubZero();
                case "Scorpion": return new Scorpion();
                case "Katana": return new Katana();
                default: return null;
            }
        }
    }
}
