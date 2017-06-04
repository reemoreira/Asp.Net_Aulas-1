using AvaliacaoRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoRenan.Dao
{
    public class MarcaController
    {
       static  protected BaseDadosContainer contexto = new BaseDadosContainer();
       static  public void Adicionar(Marca Marca)
        {
            if (Marca != null)
            {
                contexto.Marcas.Add(Marca);
                contexto.SaveChanges();
            }
        }
        static public List<Marca> Listar()
        {
            return contexto.Marcas.Where(x => x.Ativo == true).ToList();
        }
        static public List<Marca> ListarInativo()
        {
            return contexto.Marcas.Where(x => x.Ativo == false).ToList();
        }
        static public Marca BuscarPorId(int id)
        {
            return contexto.Marcas.Find(id);
        }
        static public Marca BuscarPorNome(string Nome)
        {
            return contexto.Marcas.FirstOrDefault(x=>x.Nome.Equals(Nome));
        }
        static public void Excluir(Marca Marca)
        {
            //gera um update
            contexto.Entry(Marca).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        static public void Editar(Marca Marca)
        {
            contexto.Entry(Marca).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}