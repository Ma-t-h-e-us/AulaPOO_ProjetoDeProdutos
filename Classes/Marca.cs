using System;
using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos_Branches.Interfaces;

namespace AulaPOO_ProjetoDeProdutos_Branches.Classes
{
    public class Marca : IMarca
    {
        protected int Codigo;
        public string NomeMarca;
        public DateTime DataCadastro;

        public List<Marca> ListaMarcas = new List<Marca>();

        public Marca() {
        }

        public Marca(int _Codigo, string _NomeMarca, DateTime _DataCadastro){
            this.Codigo = _Codigo;
            this.NomeMarca = _NomeMarca;
            this.DataCadastro = _DataCadastro;
        }
        public string Cadastrar(Marca marca){
            ListaMarcas.Add(marca);
            return $"{marca.NomeMarca} cadastrado com sucesso";
        }   
        public List<Marca> Listar(){
            return ListaMarcas;
        }
        public string Deletar(Marca marcaDeletada){
            if (ListaMarcas != null)
            {
            ListaMarcas.Remove(marcaDeletada);
            return $"{marcaDeletada.NomeMarca} foi deletgitada com sucesso";
            }
            return "não há marcas cadastradas";
        }
    }
}