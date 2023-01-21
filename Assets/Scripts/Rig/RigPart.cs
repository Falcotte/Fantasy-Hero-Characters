using UnityEngine;

namespace AngryKoala.Modular.Rig
{
    public class RigPart : MonoBehaviour
    {
        [SerializeField] private new string name;
        public string Name => name;

        public void Setup(string name)
        {
            this.name = name;
        }
    }
}