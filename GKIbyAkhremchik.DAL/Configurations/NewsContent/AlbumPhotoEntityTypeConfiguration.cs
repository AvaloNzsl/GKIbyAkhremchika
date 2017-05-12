using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations.NewsContent
{
    public class AlbumPhotoEntityTypeConfiguration : EntityTypeConfiguration<AlbumPhoto>
    {
        public AlbumPhotoEntityTypeConfiguration()
        {
            HasMany(r => r.GalleryPhotoes).WithRequired(r => r.AlbumPhoto).HasForeignKey(r => r.PhotosId);
        }
    }
}
