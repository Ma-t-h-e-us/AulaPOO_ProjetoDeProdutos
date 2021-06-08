using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario
    {


        private int Codigo { get; set; }

        public string Nome { get; set; }

        private string Email { get; set; }

        private string Senha { get; set; }

        private DateTime DataCadastro { get; set; }

        List<Usuario> ListaUsuario = new List<Usuario>();
        
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