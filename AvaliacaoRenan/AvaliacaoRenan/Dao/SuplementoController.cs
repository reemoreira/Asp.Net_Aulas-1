using AvaliacaoRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoRenan.Dao
{
    public class SuplementoController
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();
        public void Adicionar(Suplemento Sup)
        {
            if (Sup != null)
            {
                contexto.Suplementos.Add(Sup);
                contexto.SaveChanges();
            }
        }
        public List<Suplemento> Listar()
        {
            return contexto.Suplementos.Where(x => x.Ativo == true).ToList();
        }
        public List<Suplemento> ListarInativo()
        {
            return contexto.Suplementos.Where(x => x.Ativo == false).ToList();
        }
        public Suplemento BuscarPorId(int id)
        {
            return contexto.Suplementos.Find(id);
        }
        public void Excluir(Suplemento Sup)
        {
            //gera um update
            Sup.Ativo = false;
            contexto.Entry(Sup).State = System.Data.Entity.EntityState.Modified;
        }
        public void Editar(Suplemento Sup)
        {
            contexto.Entry(Sup).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}