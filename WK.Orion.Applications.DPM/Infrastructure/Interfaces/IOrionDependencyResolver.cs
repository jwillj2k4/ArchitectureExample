using System.Web.Http.Dependencies;

namespace WK.Orion.Applications.DPM.Infrastructure.Interfaces
{
    public interface IOrionDependencyResolver : IDependencyResolver
    {
        T GetService<T>();
    }
}