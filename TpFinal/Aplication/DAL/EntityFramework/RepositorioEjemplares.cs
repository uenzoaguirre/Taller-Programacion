using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication.DAL.EntityFramework
{
    public class RepositorioEjemplares : Repository<Ejemplar, BibliotecaDbContext>, IRepositorioEjemplares
    {
        public RepositorioEjemplares (BibliotecaDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}