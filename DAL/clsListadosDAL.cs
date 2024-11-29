using ENT;

namespace DAL
{
    public class clsListadosDAL
    {
        //Listado de personas relleno
        private static List<clsPersona> listaPersonas= new List<clsPersona>
        {
            new clsPersona(1,"Paulie Gualtieri"),
            new clsPersona(2,"Christopher Moltisanti"),
            new clsPersona(3,"Silvio Dante"),
            new clsPersona(4,"Vito Spatafore"),
            new clsPersona(5,"Ralph Cifaretto"),
            new clsPersona(6,"Furio Giunta"),
            new clsPersona(7,"Carlo Gervasi"),
            new clsPersona(8,"Jackie Aprile Jr"),
            new clsPersona(9,"Richie Aprile"),
            new clsPersona(10,"Bobby Baccalieri"),
            new clsPersona(11,"Phil Leotardo"),
            new clsPersona(12,"Big Pussy Bonpensiero"),
            new clsPersona(13,"Benny Fazio"),
            new clsPersona(14,"Tonu Blundetto"),
            new clsPersona(15,"Little Paulie Germani"),  

        };
        /// <summary>
        /// Funcion que te devuelve un listado de tipo clsPersonas
        /// </summary>
        /// pre: Nada
        /// post: Se espera que la lista no este vacia
        /// <returns>Te devuelve la lista de clsPersona</returns>
        public static List<clsPersona> obtenerListadoPersonasDAL() 
        {
            List<clsPersona> listaP = listaPersonas;

            return listaP;
        }
    }
}
