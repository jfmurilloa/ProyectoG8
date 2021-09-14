// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Municipio
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        // propiedad nabvigacional con la torneo
        public List<Torneo> Torneos {get;set;}

    }
}