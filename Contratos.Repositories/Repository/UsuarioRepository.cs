﻿using Contratos.Data.Contexto;
using Contratos.Domain.Entities;
using Contratos.Repositories.Base;
using Contratos.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Contratos.Repositories.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ContratosContexto context) :base(context) {}
        
        public IEnumerable<Usuario> Buscar()
        {
            return entidade.AsNoTracking().ToList();
        }
    }
}
