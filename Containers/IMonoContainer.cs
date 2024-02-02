using System;

namespace MentallyStable.Services.Containers
{

    public interface IMonoContainer
    {
        public ContainerData Data { get; }

        public event Action<MonoContainer> OnCreated;

        public void Created();
    }
}