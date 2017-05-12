using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations.NewsContent
{
    public class GalleryVideoEntityTypeConfiguration : EntityTypeConfiguration<GalleryVideo>
    {
        public GalleryVideoEntityTypeConfiguration()
        {
            HasMany(r => r.NewsSchools).WithOptional(r => r.GalleryVideo).HasForeignKey(r => r.GalleryVideoId);
            HasMany(r => r.NewsArts).WithOptional(r => r.GalleryVideo).HasForeignKey(r => r.GalleryVideoId);
            HasMany(r => r.NewsMusicals).WithOptional(r => r.GalleryVideo).HasForeignKey(r => r.GalleryVideoId);
            HasMany(r => r.NewsEvents).WithOptional(r => r.GalleryVideo).HasForeignKey(r => r.GalleryVideoId);
        }
    }
}
