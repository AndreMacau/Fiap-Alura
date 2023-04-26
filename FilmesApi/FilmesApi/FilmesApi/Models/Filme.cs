﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage ="O título do Filme é obrigatório!")]
    public string Titulo { get; set; }
    [Required(ErrorMessage ="O gênero do Filme é obrigatório!")]
    [MaxLength(50, ErrorMessage = "O Tamanho do gênero não pode exeder 50 caracteres!")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage ="A duração dever ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
