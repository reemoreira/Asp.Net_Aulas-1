using Aula2405_EF_MF.Model;
using Aula2405_EF_MF.View.Categorias;

namespace Aula2405_EF_MF.Dao
{
    public class CatDao :BasePage
    {
         static public void Incluir (Categoria cat)
        {
            contexto.Categorias.Add(cat);
            contexto.SaveChanges();
        }
    }
}