using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Usuario
{
    public interface IUsuarioBusiness
    {   
        Task<List<Entities.Usuario>> GetList();
    }
}
