using AulaPOO_ProjetoDeProdutos.Interfaces;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login : Ilogin 
    {
       
        public bool Logado { get; set; }

        public string Deslogar(Usuario d){

            if (Logado)
            {
                Logado = false;
                return $@"
                
                                {d.}
                         Você Saiu......... Até Mais!!
 ";
            }
            return "Você Não se Logou";

        }

        public string Logar(Usuario l)
        {
            if (Logado)
            {
                Logado = true;
                return $@"
                
                                {Usuario.Nome}
                         Você Entrou......... Bem Vindo!!
 ";
            }
            return "Você Não se Logou";
        }

        void Ilogin.Login()
        {
            throw new System.NotImplementedException();
        }
    }
}