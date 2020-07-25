﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FAISP.Bootcamp.Pedios.Models
{
    public class PedidoModel
    {
        public PedidoModel()
        {
        }

        [DisplayName("Nome:")]
        [Required(ErrorMessage = "Informe o seu nome")]
        public string NomeCliente { get; set; }

        [DisplayName("Telefone com DDD:")]
        [Required(ErrorMessage ="Informe o seu número de telefone")]
        public string TelefoneContato { get; set; }

        [DisplayName("Forma Pagto")]
        [Required]
        public string FormaPagamento { get; set; }

        public decimal Valor { get; set; }

        public string Bairro { get; set; }

        public string  Logradouro { get; set; }

        public string Numero{ get; set; }

        public string Cep { get; set; }

        public string Cidade  { get; set; }

        public string Complemento { get; set; }

        public Pizza Pizza { get; set; }
    }
}
