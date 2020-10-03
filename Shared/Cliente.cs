using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace MisterMuscle.Shared {
    
    public class Cliente {

        public int Id { get; set; }
        [Required(ErrorMessage="O campo nome é obrigatório")]
        
        public string Nome { get; set; }
        [Required(ErrorMessage="O campo e-mail é obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage="O campo CPF é obrigatório")]
        [MaxLength(11, ErrorMessage = "Seu CPF deve conter no máximo 11 caracteres"),MinLength(11, ErrorMessage = "Seu CPF deve conter no minímo 11 caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage="O campo senha é obrigatório")]
        [MinLength(6, ErrorMessage = "Sua senha deve conter no minímo 6 caracteres")]
        public string Senha { get; set; }
        [Required(ErrorMessage="O campo telefone celular é obrigatório")]
        [Phone(ErrorMessage = "Número de telefone celular inválido")]
        public string Celular { get; set; }
        [Required(ErrorMessage="O campo confirme sua senha é obrigatório")]
        [CompareProperty("Senha")]
        public string Confirmarsenha { get; set; }
    }
}
