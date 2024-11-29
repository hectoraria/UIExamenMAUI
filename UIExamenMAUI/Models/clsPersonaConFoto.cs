using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIExamenMAUI.Models
{
    //Clase que hereda de persona
    public class clsPersonaConFoto : clsPersona
    {
        #region atributos
        private String foto;
        #endregion
        #region Propiedades
        public String Foto { get { return foto; } }
        #endregion

        #region Constructores
        public clsPersonaConFoto(clsPersona persona)
        {
            this.Id = persona.Id;
            this.Nombre = persona.Nombre;
            obtenerFoto();
        }
        #endregion

        //Metodo que añade la foto 
        private void obtenerFoto()
        {
            this.foto = "f" + this.Id + "f.jfif";
        }
    }
}
