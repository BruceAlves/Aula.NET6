using Domain.Interfaces.Repositories;
using Domain.Models;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        protected MyContext _context;   
        public UsuarioRepository(MyContext myContext)
        {
            _context = myContext;
        }

        public void Insert(Usuario usuario)
        {
            var set = _context.Set<Usuario>();
            set.Add(usuario);
            _context.SaveChanges(); 
        }
    }
}
