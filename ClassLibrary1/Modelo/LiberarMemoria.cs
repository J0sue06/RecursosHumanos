using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Modelo;

namespace ClassLibrary1.Modelo
{
    public class LiberarMemoria
    {
        DatosAcademicos _datosAcademicos = new DatosAcademicos();
        DatosFamiliares _datosFamiliares = new DatosFamiliares();
        public void Liberar()
        {
            //Datos Academicos -----------------
            _datosAcademicos.Id = 0;
            _datosAcademicos.Estudios = null;
            _datosAcademicos.Colegio = null;
            _datosAcademicos.Lugar = null;
            _datosAcademicos.Titulo = null;
            _datosAcademicos.Idioma = null;
            _datosAcademicos.FechaFin = null;
            //----------------------------------

            //Datos Familiares -----------------
            _datosFamiliares.Id = 0;
            _datosFamiliares.Nombre_padre = null;
            _datosFamiliares.Estado_padre = null;
            _datosFamiliares.Telefono_padre = null;
            _datosFamiliares.Nombre_madre = null;
            _datosFamiliares.Estado_madre = null;
            _datosFamiliares.Telefono_madre = null;
            _datosFamiliares.Nombre_conyugue = null;
            _datosFamiliares.Telefono_conyugue = null;
            _datosFamiliares.Persona_emergencia = null;
            _datosFamiliares.Parentesco_emergencia = null;
            _datosFamiliares.Telefono_emergencia = null;
            //----------------------------------
        }
    }
}
