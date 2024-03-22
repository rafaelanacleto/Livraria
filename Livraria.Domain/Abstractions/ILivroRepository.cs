using Livraria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Abstractions
{
    public interface ILivroRepository
    {
        Task<List<Livro>> GetAll();
        Task<Livro?> GetById(int id);
        Task<Livro?> GetByName(string name);
        Task<Livro> AdcionarLivro(Livro livro);
        Task DeletarLivro(int id);
        Task AtualizaLivro(Livro livro);

    }
}
