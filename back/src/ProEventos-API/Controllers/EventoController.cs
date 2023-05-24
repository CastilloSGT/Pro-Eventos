using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos_API.Model;

namespace ProEventos_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                    EventoId = 1,
                    Tema = "Como é ser Paraibano.",
                    Local = "Paraíba",
                    Lote = "1º Og",
                    QtdPessoas = 2,
                    DateEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    imagemURL = "gats_1."
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Como é ser Paulista.",
                    Local = "São Paulo",
                    Lote = "2º Dr",
                    QtdPessoas = 4,
                    DateEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    imagemURL = "gats_2."
                },
                new Evento(){
                    EventoId = 3,
                    Tema = "Como é ser Tiktoker Vier.",
                    Local = "Casa do KRL",
                    Lote = "3º Ma",
                    QtdPessoas = 6,
                    DateEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    imagemURL = "gats_3."
                }
            };            

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId != id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo Posts";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put com id: {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete com id: {id}";
        }
    }
}
