using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface Ilogin
    {
         void Login();

         string Logar(Usuario l);

         string Deslogar(Usuario d);
    }
}