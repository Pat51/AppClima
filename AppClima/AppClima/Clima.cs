using System;
using System.Collections.Generic;
using System.Text;

namespace AppClima
{
    public class Clima
    {
        public string Titulo { get; set; }
        public string Temperatura { get; set; }
        public string Viento { get; set; }
        public string Humedad { get; set; }
        public string Visibilidad { get; set; }
        public string Amanecer { get; set; }
        public string Ocaso { get; set; }

        public Clima()
        {
            this.Titulo = "";
            this.Temperatura = "";
            this.Viento = "";
            this.Humedad = "";
            this.Visibilidad = "";
            this.Amanecer = "";
            this.Ocaso = "";
        }
    }
}
