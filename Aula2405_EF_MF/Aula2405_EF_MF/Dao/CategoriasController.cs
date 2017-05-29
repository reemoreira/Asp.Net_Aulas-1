using Aula2405_EF_MF.Model;
using Aula2405_EF_MF.View.Categorias;
using System.Collections.Generic;
using System.Linq;

namespace Aula2405_EF_MF.Dao
{
    public class CategoriasController
    {
        static protected BaseDadosContainer contexto = new BaseDadosContainer();
        static public void Adicionar(Categoria categoria)
        {
            if (categoria != null)
            {
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
            }
        }
         public List<Categoria> Listar()
        {
            return contexto.Categorias.Where(x => x.Ativo == true).ToList();
        }
         public List<Categoria> ListarInativo()
        {
            return contexto.Categorias.Where(x => x.Ativo == false).ToList();
        }
        static public Categoria BuscarPorId(int id)
        {
            return contexto.Categorias.Find(id);
        }
        /*Exclusão fisicia
        public void Excluir(Categoria categoria)
        {
            //gera um delete
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }*/

        //Exclusão logica (Campo Ativo/Inativo)
        static public void Excluir (Categoria cat)
        {
            //gera um update
            cat.Ativo =false;
            contexto.Entry(cat).State = System.Data.Entity.EntityState.Modified;
        }
        static public void Editar(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}