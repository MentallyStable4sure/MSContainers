using UnityEngine;
using Cysharp.Threading.Tasks;
using MentallyStable.Data.Loaders;
using MentallyStable.Data.Factories;

namespace MentallyStable.Services.Containers
{

    public class MonoContainerLoader : IMonoResourceLoader
    {
        public MonoContainerLoader(string subfolder, Transform parent = null)
        {
            Factory = new BaseResourceFactory(subfolder, parent);
        }

        public IMonoContainerFactory Factory { get; }

        public virtual async UniTask<T> LoadContainer<T>()
            where T : MonoContainer
        {
            return await Factory.CreateInstance<T>();
        }

        public virtual async UniTask<T> LoadContainer<T,Y>(Y data)
            where T : MonoContainer
            where Y : ContainerData
        {
            return await Factory.CreateInstance<T, Y>(data);
        }
    }
}