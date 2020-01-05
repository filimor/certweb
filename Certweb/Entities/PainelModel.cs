using System;

namespace Certweb.Entities
{
    public class PainelModel
    {
        public TimeSpan TempoDecorrido { get; set; }
        public DateTime UltimaExecucao { get; set; }
        public int QuantidadeErros { get; set; }
    }
}