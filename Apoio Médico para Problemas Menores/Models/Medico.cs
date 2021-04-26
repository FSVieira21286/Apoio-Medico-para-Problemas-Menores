using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apoio_Médico_para_Problemas_Menores.Models
{
    public class Medico
    {
        /// <summary>
        /// id do médico
        /// </summary>
        [Key]
        public int MedicoId  { get; set; }



        /// <summary>
        /// nome do medico
        /// </summary>
        
        public String Nome { get; set; }







    }
}
