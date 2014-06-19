﻿using System;

namespace EmpleoDotNet.Models
{
    /// <summary>
    /// Clase base de donde heredan todas las entidades del sistema. 
    /// Evita repetición de código y ayuda a mantener los modelos limpios
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Las entidades deben poseer un campo con la fecha de creación para posibles 
        /// auditorias o como referencia en potenciales sesiones de debugging.
        /// </summary>
        public DateTime Created { get; set; }
    }
}