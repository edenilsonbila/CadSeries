using System.Collections.Generic;
namespace MRV.CadSeries
{
  public interface IRepositorio<T>
  {
    List<T> lista();

    T GetById(int id);

    void Insere(T entidade);

    void Exclui(int id);

    void Atualiza(int id, T entidade);

    int ProximoId();
  }
}