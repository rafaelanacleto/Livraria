using Livraria.Domain.Abstractions;
using Livraria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.InfraStructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public Task<Livro> AdcionarLivro(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task AtualizaLivro(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task DeletarLivro(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Livro>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Livro?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Livro?> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}