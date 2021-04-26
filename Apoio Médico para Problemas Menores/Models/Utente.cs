using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apoio_Médico_para_Problemas_Menores.Models
{
    public class Utente
    {
        /// <summary>
        /// Id do utilizador utente
        /// </summary>
        public int UtenteId { get; set; }

        /// <summary>
        /// Nome do utilizador utente
        /// </summary>
        public String Nome { get; set; }

        /// <summary>
        /// Data de nascimento do utilizador utente
        /// </summary>
        public DateTime DataNasc { get; set; }


        /// <summary>
        /// Nif do utilizador utente
        /// </summary>
        public string NIF { get; set; }




    }
}
