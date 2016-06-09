using System.Web.Http.Dependencies;

namespace WK.Orion.Applications.ADM.Infrastructure.Interfaces
{
    public interface IOrionDependencyResolver : IDependencyResolver
    {
        T GetService<T>();
    }
}