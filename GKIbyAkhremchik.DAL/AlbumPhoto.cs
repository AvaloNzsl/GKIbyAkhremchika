//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GKIbyAkhremchik.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlbumPhoto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlbumPhoto()
        {
            this.GalleryPhotoes = new HashSet<GalleryPhoto>();
        }
    
        public int AlbumPhotoId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GalleryPhoto> GalleryPhotoes { get; set; }
    }
}
