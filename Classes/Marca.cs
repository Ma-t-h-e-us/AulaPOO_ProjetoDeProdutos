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

        public string Cadastrar(Marca _NomeMarca){
            ListaMarcas.Add(_NomeMarca);
            return $"{_NomeMarca} cadastrado";
        }   
        public List<Marca> listar(){
            return ListaMarcas;
        }
        public string Deletar(string MarcaDeletar){
            ListaMarcas.RemoveAll(x => x.NomeMarca == MarcaDeletar);
            return $"{MarcaDeletar} foi deletada com sucesso";
        }
    }
}