using System;
using UnityEngine;

namespace MentallyStable.Services.Containers
{

    public class MonoContainer : MonoBehaviour, IMonoContainer
    {
        public ContainerData Data { get; set; }

        public event Action<MonoContainer> OnCreated;

        public virtual void Created() => OnCreated?.Invoke(this);
    }
}