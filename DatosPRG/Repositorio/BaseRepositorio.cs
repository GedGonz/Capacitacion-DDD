using NegocioPRG.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DatosPRG.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        protected readonly DbContext contexto;
        protected readonly DbSet<T> Tabla;
        public BaseRepositorio(DbContext contexto)
        {
            this.contexto = contexto;
            this.Tabla = contexto.Set<T>();
        }
        public void add(T entidad)
        {
            Tabla.Add(entidad);
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicado)
        {
            return Tabla.Where(predicado);
        }

        public IEnumerable<T> ListAll()
        {
            return Tabla.ToList();
        }
    }
}
