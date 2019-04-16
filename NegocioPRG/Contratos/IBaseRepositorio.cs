using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NegocioPRG.Contratos
{
    public interface IBaseRepositorio<T> where T:class
    {
        void add(T entidad);
        IEnumerable<T> ListAll();
        IEnumerable<T> List(Expression<Func<T,bool>> predicado);
    }
}
