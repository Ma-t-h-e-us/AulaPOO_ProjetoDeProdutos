using System;
using AulaPOO_ProjetoDeProdutos.Interfaces;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login : Ilogin
    {

        public bool Logado { get; set; }
        Usuario u = new Usuario();

        int Codigo = 0;

        public string Deslogar(Usuario d)
        {

            if (Logado)
            {
                Logado = false;
                return $@"
                
                                {d.Nome}
                         Você Saiu......... Até Mais!!
 ";
            }
            return "Você Não se Logou";

        }


        public Login()
        {
            Console.WriteLine(@"
            + + + + + + + + + + +
            + OLA !!! BEM VINDO +
            +                   +
            +   O QUE DESEJA    +
            +                   +     
            +    1 - Cadastrar  +
            +    2 - SAIR       +
            + + + + + + + + + + +
            ");
            Console.WriteLine("");
            int Resposta = int.Parse(Console.ReadLine());

            if (Resposta == 1)
            {
                Console.WriteLine(@"
            + + + + + + + + +  +
            + Digite seu Nome  +
            + + + + + + + + +  +");
                string Nome = Console.ReadLine();

                Console.WriteLine(@"
            + + + + + + + + +  +
            + Digite seu EMAIL +
            + + + + + + + + +  +
            ");
                string Email = Console.ReadLine();


                Console.WriteLine(@"
            + + + + + + + + +  +
            + Digite sua Senha +
            + + + + + + + + +  +
            ");
                string Senha = Console.ReadLine();

                Console.WriteLine(@"
            + + + + + + + + +  + + + +
            + Cadastrado com Sucesso +
            + + + + + + + + +  + + + +
            ");

                Usuario NovoUsuario = new Usuario(Codigo, Nome, Email, Senha);
                Codigo++;

                u.Cadastrar(NovoUsuario);


                Console.WriteLine(@"
                      + + + + + 
                      + Entrar +
                      + + + + +
            ");

                do
                {
                    Console.WriteLine(@"
             + + + + + + + + +  +
             + Digite seu EMAIL +
             + + + + + + + + +  +
             ");
                    string EmailLogar = Console.ReadLine();


                    Console.WriteLine(@"
            + + + + + + + + +  +
            + Digite sua Senha +
            + + + + + + + + +  +
            ");
                    string SenhaLogar = Console.ReadLine();

                    Usuario usuarioEncontrado = u.ListaUsuario.Find(x => x.Email == EmailLogar && x.Senha == SenhaLogar);

                    if (usuarioEncontrado == null)
                    {
                        Console.WriteLine(Logar(NovoUsuario));
                        Logado = false;
                        Console.WriteLine(@"
                      + + + + + 
                      + Entrar +
                      + + + + +
                    ");


                    }
                } while (Logado == true);

            }
            else if (Resposta == 2)
            {
                Logado = false;
                Console.WriteLine("Você Saiu......... Até Mais!!");
            }





        }
        public string Logar(Usuario l)
        {
            if (Logado)
            {
                Logado = true;
                return $@"
                
                                {l.Nome}
                         Você Entrou......... Bem Vindo!!
 ";
            }
            return "Você Não se Logou";
        }


    }
}