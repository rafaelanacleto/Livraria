using Livraria.Domain.Abstractions;
using Livraria.Domain.Entities;
using Livraria.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.InfraStructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {

        private ApplicationDbContext _context;

        public LivroRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Livro> AdcionarLivro(Livro livro)
        {
            if(_context is not null && livro is not null && _context.Livros is not null)
            {
                _context.Livros.Add(livro);
                await _context.SaveChangesAsync();
                return livro;
            }
            else
            {
                throw new InvalidOperationException("Dados Inválidos...");
            }
        }

        public async Task AtualizaLivro(Livro livro)
        {
            if (livro is not null)
            {
                _context.Entry(livro).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeletarLivro(int id)
        {
            var livro = _context.Livros.FirstOrDefault(l => l.LivroId ==  id);

            if(livro is not null)
                _context.Remove(livro);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Livro>> GetAll()
        {
            if (_context is not null && _context.Livros is not null)
            {
                var livros = await _context.Livros.ToListAsync();
                return livros;
            }
            else
            {
                return new List<Livro>();
            }
        }

        public async Task<Livro?> GetById(int id)
        {
            var livro = await _context.Livros.FirstOrDefaultAsync(l => l.LivroId == id);

            if (livro == null)
                throw new InvalidOperationException("Dados Inválidos....");
            return livro;
        }

        public async Task<Livro?> GetByName(string name)
        {
            var livro = await _context.Livros.FindAsync(_context.Livros, name);

            if (livro == null)
                throw new InvalidOperationException("Dados Inválidos....");

            return livro;
        }
    }
}