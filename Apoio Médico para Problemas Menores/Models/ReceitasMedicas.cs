using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apoio_Médico_para_Problemas_Menores.Models
{
    public class ReceitasMedicas
    {
        /// <summary>
        /// Id da receita médica
        /// </summary>
        public int ReceitaId { get; set; }

        /// <summary>
        /// Preço total da receita médica
        /// </summary>
        public int Preco { get; set; }

        /// <summary>
        /// FK para o médico que receitou a receita médica
        /// </summary>
        [ForeignKey(nameof(Medico))]
        public int MedicoIDFK { get; set; }
        public Medico MedicoID { get; set; }



    }
}
