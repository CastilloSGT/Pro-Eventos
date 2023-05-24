using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos_API.Model
{
    public class Evento
    {
        public int EventoId { get; set; }

        public string Local { get; set; }

        public string DateEvento { get; set; }

        public string Tema { get; set; }

        public int QtdPessoas { get; set; }

        public string Lote { get; set; }

        public string imagemURL { get; set; } 
    }
}