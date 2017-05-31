using AvaliacaoRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvaliacaoRenan.Dao
{
    public class MarcaController
    {
         protected BaseDadosContainer contexto = new BaseDadosContainer();
         public void Adicionar(Marca Marca)
        {
            if (Marca != null)
            {
                contexto.Marcas.Add(Marca);
                contexto.SaveChanges();
            }
        }
        public List<Marca> Listar()
        {
            return contexto.Marcas.Where(x => x.Ativo == true).ToList();
        }
        public List<Marca> ListarInativo()
        {
            return contexto.Marcas.Where(x => x.Ativo == false).ToList();
        }
         public Marca BuscarPorId(int id)
        {
            return contexto.Marcas.Find(id);
        }
        public void Excluir(Marca Marca)
        {
            //gera um update
            Marca.Ativo = false;
            contexto.Entry(Marca).State = System.Data.Entity.EntityState.Modified;
        }
        public void Editar(Marca Marca)
        {
            contexto.Entry(Marca).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}