using LivrariaDomain.Entities.Base;
using LivrariaDomain.Enum;
using LivrariaDomain.ValueObjects;
namespace LivrariaDomain.Entities
{
    public class Usuario : BaseEntity
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
        public EnumTipoUsuario  TipoUsuario { get; set; }
    }
}
