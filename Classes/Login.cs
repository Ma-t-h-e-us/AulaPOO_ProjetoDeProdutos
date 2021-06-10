using System;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using AulaPOO_ProjetoDeProdutos_Branches.Classes;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login : Ilogin
    {
        public bool Logado { get; set; }
        Usuario u = new Usuario();
        Marca m = new Marca();
        Produto p = new Produto();
        int Codigo = 0;

        public string Deslogar(Usuario d)
        {
                Logado = false;
                return $@"
                
                                {d.Nome}
                         Desconectando...";
        }
        public Login()
        {
            Logado = false;
            bool loopEntrada = true;
                do
                {
                    Console.WriteLine(@"
            + + + + + + + + + + +
            + OLA !!! BEM VINDO +
            +                   +
            +   O QUE DESEJA    +
            +                   +     
            +    1 - Cadastrar  +
            +    2 - Fazer login+
            +    3 - SAIR       +
            + + + + + + + + + + +
            ");
                    int Resposta = int.Parse(Console.ReadLine());
                    switch (Resposta)
                    {
                        case 1:
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
                            break;

                        case 2:
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

                            if (usuarioEncontrado != null)
                            {
                                Logar(usuarioEncontrado);
                                Console.WriteLine(@"
                      + + + + + 
                      + Entrar +
                      + + + + +
                    ");
do
                {
                    Console.WriteLine($@"
                    O QUE DESEJA
                    
                    1 - Cadastrar Produto
                    2 - Cadastrar Marca
                    3 - Listar Produtos
                    4 - Listar Marcas
                    5 - Remover usuario
                    6 - Remover produtos ou marcas
                    7 - SAIR");
                    int Resposta2 = int.Parse(Console.ReadLine());
                    switch (Resposta2)
                    {
                        case 1:
                            Console.WriteLine($"Qual o nome do produto?");
                            string _NomeProduto = Console.ReadLine().ToLower();
                            Console.WriteLine($"Qual o preço do produto?");
                            float _Preco = float.Parse(Console.ReadLine());
                            Console.WriteLine($"Qual a marca do produto?");
                            string _MarcaNome = Console.ReadLine();
                            Marca _Marca = m.ListaMarcas.Find(x => x.NomeMarca == _MarcaNome);
                            if (_Marca == null)
                            {
                                Console.WriteLine("marca inexistente");
                                break;
                            }
                            Console.WriteLine($"Qual código deseja no seu produto?");
                            int _Codigo = int.Parse(Console.ReadLine());
                            DateTime _DataCadastro = DateTime.Today;
                            Usuario _CadastradoPor = u;
                            Produto produto = new Produto(_Codigo, _NomeProduto, _Preco, _DataCadastro, _Marca, _CadastradoPor);
                            p.Cadastrar(produto);
                            Console.WriteLine("produto cadastrado");
                            break;
                        case 2:
                            Console.WriteLine($"Qual o nome da marca?");
                            string _NomeMarca = Console.ReadLine().ToLower();
                            Console.WriteLine($"Qual código deseja para a marca?");
                            int _CodigoM = int.Parse(Console.ReadLine());
                            DateTime _DataCadastroM = DateTime.Today;
                            Marca marca = new Marca(_CodigoM, _NomeMarca, _DataCadastroM);
                            m.Cadastrar(marca);
                            Console.WriteLine("marca cadastrada");
                            break;
                        case 3:
                            Console.WriteLine(p.Listar());
                            break;
                        case 4:
                            Console.WriteLine(m.Listar());
                            break;
                        case 5:
                            u.Deletar(usuarioEncontrado);
                            Console.WriteLine("usuario deletado");
                            break;
                        case 6:
                            Console.WriteLine($@"
                            O que deseja remover?

                            1 - Marcas
                            2 - Produtos
                            ");
                            int respostaRemocao = int.Parse(Console.ReadLine());

                            if (respostaRemocao == 1)
                            {
                                Console.WriteLine($@"Qual marca deseja deletar?");
                                string _NomeMarcaDeletar = Console.ReadLine();
                                Marca marcaDeletada = m.ListaMarcas.Find(x => x.NomeMarca == _NomeMarcaDeletar);
                                if (marcaDeletada != null)
                                {
                                    m.Deletar(marcaDeletada);
                                    Console.WriteLine("marca deletada");
                                } else {
                                    Console.WriteLine("marca não encontrada :(");
                                }    
                            } else if (respostaRemocao == 2)
                            {
                                Console.WriteLine($@"Qual produto deseja deletar?");
                                string _NomeProdutoDeletar = Console.ReadLine();
                                Produto produtoDeletado = p.ListaDeProdutos.Find(x => x.NomeProduto == _NomeProdutoDeletar);
                                if (produtoDeletado != null)
                                {
                                    p.Deletar(produtoDeletado);
                                    Console.WriteLine("produto deletado");
                                } else {
                                    Console.WriteLine("produto não encontrado");
                                }
                            }

                            break;
                        case 7:
                            Console.WriteLine(Deslogar(usuarioEncontrado));
                            break;
                        default:
                            break;
                    }
                    
                } while (Logado == true);
                            } else {
                                Console.WriteLine("usuario não encontrado");
                            }
                            break;

                        case 3:
                            loopEntrada = false;
                            Console.WriteLine("Você Saiu......... Até Mais!!");
                            break;
                        default:
                            break;
                    }

                } while (loopEntrada == true);
        }
            
    public string Logar(Usuario l)
{
    if (Logado == false)
    {
        Logado = true;
        return $@"
                
         {l.Nome}
             Você Entrou......... Bem Vindo!!";
    }
    return "Você já se Logou";
}
}
}
