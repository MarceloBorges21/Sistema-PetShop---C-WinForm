//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raca()
        {
            this.Animal = new HashSet<Animal>();
        }
    
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Id_Funcionario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animal> Animal { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
