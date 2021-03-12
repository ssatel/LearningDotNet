using Begin5.Entidades;
using Begin5.Infra;
using Begin5.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Repository
{
    public class ContaRepository : IContaRepository
    {
        private readonly Context _context;
        public ContaRepository(Context context)
        {
            _context = context;
        }

        public async Task CriarConta(Conta conta)
        {

            _context.Add(conta);
            await _context.SaveChangesAsync();

            
        }
    }
}
