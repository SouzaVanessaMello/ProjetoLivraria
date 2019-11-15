using System;

namespace LivrariaDomain.Arguments.Usuario
{
    public class AutenticarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string Email { get; set; }
        public int TipoUsuario { get; set; }

        public static explicit operator AutenticarUsuarioResponse (Entities.Usuario entity)
        {
            return new AutenticarUsuarioResponse()
            {
                Id = entity.Id,
                Email = entity.Email.Endereco,
                PrimeiroNome = entity.Nome.PrimeiroNome,
                TipoUsuario = (int)entity.TipoUsuario
            };
        }
    }
}
