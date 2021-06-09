using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos_Branches.Classes;

namespace AulaPOO_ProjetoDeProdutos_Branches.Interfaces
{
    public interface IProduto
    {
         string Cadastrar(Produto produtoCadastrar);
         List<Produto> Listar();
         string Deletar(Produto produtoDeletar);
    }
}