using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos_Branches.Classes
{
    public class Produto
    {
        protected int Codigo;
        protected string NomeProduto;
        protected float Preco;
        protected DateTime DataCadastro;
        protected Marca Marca;
        protected Usuario CadastradoPor;
        protected List<Produto> ListaDeProdutos = new List<Produto>();

        public string Cadastrar(Produto produtoCadastrar)
        {
            ListaDeProdutos.Add(produtoCadastrar);
            return $"{produtoCadastrar.NomeProduto} cadastrado com sucesso";
        }
        public List<Produto> Listar()
        {
            return ListaDeProdutos;
        }
        public string Deletar(Produto produtoDeletar)
        {
            if (ListaDeProdutos != null)
            {
                ListaDeProdutos.RemoveAll(x => x.Codigo == produtoDeletar.Codigo);
                return $"{produtoDeletar.NomeProduto} deletado com sucesso";
            } return "não há produtos cadastrados";
        }
    }
}