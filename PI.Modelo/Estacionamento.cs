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
    
    public partial class Estacionamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estacionamento()
        {
            this.Funcionario = new HashSet<Funcionario>();
            this.VagaVeiculo = new HashSet<VagaVeiculo>();
        }
    
        public int IdEstacionamento { get; set; }
        public int IdFuncionario { get; set; }
        public int VagasOcupadas { get; set; }
        public int VagasLivres { get; set; }
        public int NumeroVagas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario> Funcionario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VagaVeiculo> VagaVeiculo { get; set; }
        public virtual Funcionario Funcionario1 { get; set; }
    }
}
