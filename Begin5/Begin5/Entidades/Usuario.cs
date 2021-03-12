using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Begin5.Entidades
{
    public class Usuario
    {

        [Key]
        public string UserID { get; set; }

        [JsonIgnore]
        public int IDusuario { get; set; }
        public string Email { get; private set; }


        public static int UsuariosLogados { get; private set; }

        public int codigoAutenticador { get; private set; }

        public Usuario() { }

        public Usuario(string userId, string email)
        {
            UserID = userId;
            Email = email;
            IDusuario = Convert.ToInt32(DateTime.Now.Year +
                                        DateTime.Now.Month +
                                        DateTime.Now.Day +
                                        DateTime.Now.Hour +
                                        DateTime.Now.Minute +
                                        DateTime.Now.Second);

            UsuariosLogados++;

            codigoAutenticador = IDusuario;

        }

        public int GetCodigoAutenticador()
        {
            return codigoAutenticador;
        }

        public void AtualizarEmail(string email)
        {
            Email = email;
        }


    }
}
