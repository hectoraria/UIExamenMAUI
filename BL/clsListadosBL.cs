using DAL;
using ENT;

namespace BL
{
    public class clsListadosBL
    {
        /// <summary>
        /// Funcion que te devuelve un listado de tipo clsPersonas 
        /// cumpliendo con las normas del negocio
        /// </summary>
        /// pre: Nada
        /// post: Se espera que la lista no este vacia
        /// <returns>Te devuelve la lista de clsPersona</returns>
        public static List<clsPersona> obtenerListadoPersonasBL()
        {
            List<clsPersona> listaP = clsListadosDAL.obtenerListadoPersonasDAL();

            return listaP;
        }
    }
}
