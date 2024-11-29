using BL;
using ENT;
using MandalorianoMAUI.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UIExamenMAUI.Models;

namespace UIExamenMAUI.ViewModels
{
    public class PaginaPrincipalVM:INotifyPropertyChanged
    {
        Random aleatorio = new Random();
        
        #region atributos
        private int contadorPreguntas;
        private int contadorAcertado;
        private int contadorIncorrecto;
        private bool pasarPregunta;
        private List<clsPersona> listaPersonas;
        private List<clsPersonaConFoto> personasJuego;
        private clsPersonaConFoto personaSeleccionado;
        private clsPersonaConFoto personaJuego;
        private String pregunta ="¿Quien es esta persona?";
        #endregion

        #region Propiedades
       
        public int ContadorPreguntas 
        {
            get { return contadorPreguntas; }
            set { contadorPreguntas = value;
                

            }
        }
        //Me falta con el current que cuando llege a 5 preguntas se cierre la aplicacion
        public bool PasarPregunta
        {
            get
            {
                return pasarPregunta;
            }
            set { pasarPregunta = value; }
        }
        public int ContadorAcertado
        {
            get { return contadorAcertado; }
        }
        public int ContadorIncorrecto
        {
            get { return contadorIncorrecto; }
        }
        public List<clsPersonaConFoto> PersonasJuego
        {
            get { return personasJuego; }
            set
            {
                personasJuego = value;


            }
        }
        public List<clsPersona> ListaPersonas
        {
            get { return listaPersonas; }
            set { 
                listaPersonas = value;
            }
        }
        public clsPersonaConFoto PersonaJuego
        {
            get { return personaJuego; }
            set { personaJuego = value; }
        }

       
        
        public clsPersonaConFoto PersonaSeleccionado
        {
            get { return personaSeleccionado; }
            set { personaSeleccionado = value;
                comprobarPersona();
                NotifyPropertyChanged("ContadorAcertado");
                NotifyPropertyChanged("ContadorIncorrecto");
                comprobarPreguntas();
                NotifyPropertyChanged("ContadorPreguntas");
               
            }
        }

        public String Pregunta
        { 
            get { return pregunta; } 
        }
        #endregion
        #region Constructor
        public PaginaPrincipalVM()
        {

            listaPersonas = clsListadosBL.obtenerListadoPersonasBL();
            //Se que esta lista tiene que cambiar cada vez que seleccione una persona seleccionada estoy
            //probando para ver si funciona la lista (me queda que no se puedan repetir)
            nuevaPregunta();


        }
        #endregion
        #region metodos
        //Metodo para comprobar si la persona que se selecciona es la misma que la de la foto
        //Fernando te he puesto un apaño para que cuando la pregunta se hacierte se genere de nuevo no
        //tengo tiempo para poder hacerlo con un bool y que si a cambiado alguna de las dos se genere una nueva pregunta
        private void comprobarPersona()
        {
            if(personaSeleccionado != null)
            {
                if (personaJuego == personaSeleccionado)
                {
                    contadorAcertado++;
                    nuevaPregunta();
                }
                else
                {
                    contadorIncorrecto++;
                    nuevaPregunta();
                }
            }
            
            
        }
        //Metodo para poder saber cuando cerrar el juego y cambiar de preguntas
        //Me acabo de dar cuenta que las preguntas deberia cambiar si la aciertas tambien
        //lo que haria seria que en la funcion de comprobarpersona con bool que te cambie un atributo de bool para pasar de pregunta
        private void comprobarPreguntas()
        {

            if (contadorAcertado != 0 || contadorIncorrecto != 0)
            {
                
                contadorPreguntas++;
                contadorAcertado = 0;
                contadorIncorrecto = 0;

            }
        }

        //Metodo para crear una nueva pregunta
        private void nuevaPregunta()
        {
            personasJuego = new List<clsPersonaConFoto>();
            for (int i = 0; i < 4; i++)
            {
                clsPersonaConFoto personaF = new clsPersonaConFoto(listaPersonas[aleatorio.Next(0, 15)]);

                personasJuego.Add(personaF);
            }
            personaJuego = personasJuego[aleatorio.Next(0, 4)];
            NotifyPropertyChanged("PersonasJuego");
            NotifyPropertyChanged("PersonaJuego");
        }

        #endregion

        #region eventos
        

        #endregion
        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
