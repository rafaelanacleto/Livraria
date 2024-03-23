using Livraria.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Entities
{
    public sealed class Livro
    {
        public int LivroId { get; set; }
        [Required(ErrorMessage = "Informe o titulo do livro")]
        [StringLength(100)]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Informe o autor do livro")]
        [StringLength(120)]
        public string? Autor { get; set; }
        [Required]
        public DateTime Lancamento { get; set; }
        [Required(ErrorMessage = "Informe a imagem capa do livro")]
        [StringLength(220)]
        public string? Capa { get; set; }
        [Required]
        [EnumDataType(typeof(Editora), ErrorMessage = "Editora Inválida")]
        public Editora Editora { get; set; }
        [Required]
        [EnumDataType(typeof(Categoria), ErrorMessage = "Categoria Inválida")]
        public Categoria Categoria { get; set; }

        public Livro(int livroId, string? titulo, string? autor, DateTime lancamento, string? capa, Editora editora, Categoria categoria)
        {
            LivroId = livroId;
            Titulo = titulo;
            Autor = autor;
            Lancamento = lancamento;
            Capa = capa;
            Editora = editora;
            Categoria = categoria;
        }
    }
}
