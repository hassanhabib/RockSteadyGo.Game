using UnityEngine;

namespace Assets.Views.Bases
{
    [RequireComponent(typeof(ParticleSystem))]
    public class TurnBaseComponent : MonoBehaviour
    {
        private ParticleSystem externalParticleSystem;

        private void Awake() => 
            this.externalParticleSystem = GetComponent<ParticleSystem>();

        public void On() =>
            this.externalParticleSystem.Play();

        public void Off() =>
            this.externalParticleSystem.Stop();
    }
}