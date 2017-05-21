using AutoMapper;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.Gallery;
using GKIbyAkhremchik.ViewModel.NewsModels;

namespace GKIbyAkhremchik.BL.AutoMapperConfiguration
{
    public interface IAutoConfiguration<TEntity> where TEntity : class
    {
        void MapConfigDB();
        void MapConfigModel();
    }
}
