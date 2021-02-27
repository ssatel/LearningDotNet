using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Models
{
    public class UsuarioResponseDTO
    {
        public int IDusuario { get; set; }
        public string UserID { get; set; }
        public string Email { get; set; }

        public UsuarioResponseDTO() { }

        public UsuarioResponseDTO(string useriD, string email, int idusuario)
        {
            UserID = useriD;
            Email = email;
            IDusuario = idusuario;
        }


    }
}
