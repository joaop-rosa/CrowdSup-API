using CrowdSup.Domain.Entities.Usuarios;
using CrowdSup.Domain.Interfaces.Repositories.Usuarios;
using CrowdSup.Infra.Data.Context;

namespace CrowdSup.Infra.Data.repositories.usuarios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CrowdsupContext _context;

        public UsuarioRepository(CrowdsupContext comissoesContext)
            => _context = comissoesContext;

        public async Task InserirAsync(Usuario usuario)
        {
            await _context.AddAsync(usuario);
            
            await _context.SaveChangesAsync();
        }
    }
}