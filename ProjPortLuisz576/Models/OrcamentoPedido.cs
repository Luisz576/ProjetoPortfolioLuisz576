using System;

namespace Etapa_3.Models{

    public class OrcamentoPedido
    {
        public int id;
        public bool lido { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public bool android  { get; set; }
        public bool ios  { get; set; }
        public bool web  { get; set; }
        public string descricao  { get; set; }
    }
    
}