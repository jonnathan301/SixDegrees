using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Usuario
{
    public class UsuarioBusiness : IUsuarioBusiness
    {

        private readonly SystemDbContext _context;
        
        public UsuarioBusiness(DbContext context)
        {
            _context = (SystemDbContext)context;
        }      
       
        public async Task<List<Entities.Usuario>> GetList()
        {
            try
            {
                return await _context.Usuario.ToListAsync();
            }
            catch (Exception Exception)
            {
                throw new ApplicationException(Exception.Message);
            }
        }
    }
}
