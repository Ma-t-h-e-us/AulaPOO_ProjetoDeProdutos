using System;
using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario : Iusuario
    {
        private int Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        private DateTime DataCadastro { get; set; }

        public List<Usuario> ListaUsuario = new List<Usuario>();

        public Usuario(){

        }
        
        public Usuario(int _Codigo, string _Nome, string _Email, string _Senha)
        {
            this.Codigo = _Codigo;
            this.Nome = _Nome;
            this.Email = _Email;
            this.Senha = _Senha;
            this.DataCadastro = DateTime.Now;

        }
        


        public string Cadastrar(Usuario u)
        {
            ListaUsuario.Add(u);
            return $"Cadastro Com Sucesso {u.ListaUsuario}";
        }

        public string Deletar( Usuario u)
        {
            ListaUsuario.Remove(u);
            return @$"Usuario Removido!!!";
        }



    }
}