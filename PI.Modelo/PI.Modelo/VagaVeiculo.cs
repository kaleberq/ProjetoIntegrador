//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class VagaVeiculo
    {
        public int IdVaga { get; set; }
        public System.DateTime DateTimeEntrada { get; set; }
        public System.DateTime DateTimeSaida { get; set; }
        public int IdFuncionario { get; set; }
        public string Placa { get; set; }
    
        public virtual Funcionario Funcionario { get; set; }
        public virtual Veiculo Veiculo { get; set; }
    }
}
