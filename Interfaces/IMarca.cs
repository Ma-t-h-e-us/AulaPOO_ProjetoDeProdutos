using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos_Branches.Classes;

namespace AulaPOO_ProjetoDeProdutos_Branches.Interfaces
{
    public interface IMarca
    {
         string Cadastrar(Marca marca);
         List<Marca> Listar();
         string Deletar(Marca marcaDeletada);
         
    }
}