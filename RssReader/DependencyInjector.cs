using Unity;
using Unity.Lifetime;

namespace RssReader
{
    public static class DependencyInjector
    {
        private static readonly UnityContainer _unityContainer = new UnityContainer();

        public static void Register<I, T>() where T : I
        {
            _unityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }

        public static T Retrieve<T>()
        {
            return _unityContainer.Resolve<T>();
        }

        public static void Inject<I>(I instance)
        {
            _unityContainer.RegisterInstance<I>(instance, new ContainerControlledLifetimeManager());
        }
    }
}
