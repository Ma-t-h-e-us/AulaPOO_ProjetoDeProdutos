using System;
using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Classes;
using AulaPOO_ProjetoDeProdutos_Branches.Interfaces;

namespace AulaPOO_ProjetoDeProdutos_Branches.Classes
{
    public class Produto : IProduto
    {
        protected int Codigo;
        public string NomeProduto;
        public float Preco;
        protected DateTime DataCadastro;
        protected Marca Marca;
        protected Usuario CadastradoPor;
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public Produto(){
        }
        public Produto(int _Codigo, string _NomeProduto, float _Preco, DateTime _DataCadastro, Marca _Marca, Usuario _CadastradoPor){
            Codigo = _Codigo;
            NomeProduto = _NomeProduto;
            Preco = _Preco;
            DataCadastro = _DataCadastro;
            Marca = _Marca;
            CadastradoPor = _CadastradoPor; 
        }
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