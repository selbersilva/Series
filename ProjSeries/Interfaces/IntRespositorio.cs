using System;
using System.Collections.Generic;

namespace ProjSeries.Interfaces
{
   public interface IntRespositorio<T>
   {
      List<T> Lista();
      T RetornaPorId(int id);
      void Insere(T entidade);
      void Exclui(int id);
      void Atualiza(int id, T entidade);
      int ProximoId();
   }
}