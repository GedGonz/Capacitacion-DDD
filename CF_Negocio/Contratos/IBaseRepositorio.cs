using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CF_Negocio.Contratos
{
    public interface IBaseRepositorio<T> where T : class
    {
        void add(T Tentidad);
        IEnumerable<T> ListAll();
        IEnumerable<T> ListFilter(Expression<Func<T,bool>> perdicado);
    }
}
