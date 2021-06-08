using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos_Branches.Classes
{
    public class Marca
    {
        protected int Codigo;
        protected string NomeMarca;
        protected DateTime DataCadastro;

        List<Marca> ListaMarcas = new List<Marca>();

        public Marca() {
        }

        public Marca(int _Codigo, string _NomeMarca, DateTime _DataCadastro){
            this.Codigo = _Codigo;
            this.NomeMarca = _NomeMarca;
            this.DataCadastro = _DataCadastro;
        }
        public string Cadastrar(Marca marca){
            ListaMarcas.Add(marca);
            return $"{NomeMarca} cadastrado com sucesso";
        }   
        public List<Marca> Listar(){
            return ListaMarcas;
        }
        public string Deletar(Marca marcaDeletada){
            if (ListaMarcas != null)
            {
            ListaMarcas.RemoveAll(x => x.Codigo == marcaDeletada.Codigo);
            return $"{marcaDeletada.NomeMarca} foi deletgitada com sucesso";
            }
            return "não há marcas cadastradas";
        }
    }
}