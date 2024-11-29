namespace ENT
{
    public class clsPersona
    {
        #region Atributos
        private int id;
        private string nombre;
        #endregion
        #region propiedades
        public int Id { get;set; }
        public string Nombre { get; set; }
        #endregion

        #region constructores
        public clsPersona() { }

        public clsPersona(int id, string nombre) 
        { 
            Id = id;
            Nombre = nombre;
        }
        #endregion
    }
}
