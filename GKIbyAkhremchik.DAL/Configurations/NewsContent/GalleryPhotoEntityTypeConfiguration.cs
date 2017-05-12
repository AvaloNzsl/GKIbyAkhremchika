using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations.NewsContent
{
    public class GalleryPhotoEntityTypeConfiguration : EntityTypeConfiguration<GalleryPhoto>
    {
        public GalleryPhotoEntityTypeConfiguration()
        {
            HasMany(r => r.NewsSchools).WithOptional(r => r.GalleryPhoto).HasForeignKey(r => r.GalleryPhotoId);
            HasMany(r => r.NewsArts).WithOptional(r => r.GalleryPhoto).HasForeignKey(r => r.GalleryPhotoId);
            HasMany(r => r.NewsMusicals).WithOptional(r => r.GalleryPhoto).HasForeignKey(r => r.GalleryPhotoId);
            HasMany(r => r.NewsEvents).WithOptional(r => r.GalleryPhoto).HasForeignKey(r => r.GalleryPhotoId);
        }
    }
}
