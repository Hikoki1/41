//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Karimvo41
{
    using System;
    using System.Collections.Generic;
    
    public partial class PickUpPoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PickUpPoint()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int PickupID { get; set; }
        public int PickupIndex { get; set; }
        public string PickupCity { get; set; }
        public string PickupStreet { get; set; }
        public int PickupBuilding { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}