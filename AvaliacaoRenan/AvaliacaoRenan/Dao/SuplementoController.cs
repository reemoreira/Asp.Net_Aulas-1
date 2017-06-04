using AvaliacaoRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoRenan.Dao
{
    public class SuplementoController
    {
       static protected BaseDadosContainer contexto = new BaseDadosContainer();
        static public void Adicionar(Suplemento Sup)
        {
            if (Sup != null)
            {
                contexto.Suplementos.Add(Sup);
                //problema de contexto
                contexto.SaveChanges();
            }
        }
        static public List<Suplemento> Listar()
        {
            return contexto.Suplementos.Where(x => x.Ativo == true).ToList();
        }
        static public List<Suplemento> ListarInativo()
        {
            return contexto.Suplementos.Where(x => x.Ativo == false).ToList();
        }
        static public Suplemento BuscarPorId(int id)
        {
            return contexto.Suplementos.Find(id);
        }
        static public Suplemento BuscarPorNome(string Nome)
        {
            return contexto.Suplementos.FirstOrDefault(x => x.Nome.Equals(Nome));
        }
        static public void Excluir(Suplemento Sup)
        {
            //gera um update
            Sup.Ativo = false;
            contexto.Entry(Sup).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        static public void Editar(Suplemento Sup)
        {
            contexto.Entry(Sup).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}