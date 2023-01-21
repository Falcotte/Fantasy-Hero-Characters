using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace AngryKoala.Modular.Rig
{
    public class ModularCharacterRig : MonoBehaviour
    {
        [SerializeField] private List<RigPart> rigParts = new List<RigPart>();
        public List<RigPart> RigParts => rigParts;

        public RigPart GetRigPartByName(string name)
        {
            RigPart rigPart = rigParts.Find(x => x.Name == name);

            if(rigPart == null)
            {
                Debug.LogWarning($"RigPart with name - {name} not found");
            }

            return rigPart;
        }

        #region Utility

        public void SetupRig()
        {
            foreach(var rigPart in GetComponentsInChildren<RigPart>(true))
            {
                DestroyImmediate(rigPart);
            }

            rigParts.Clear();

            foreach(var transform in GetComponentsInChildren<Transform>(true))
            {
                if(transform == this.transform)
                    continue;

                RigPart rigPart = transform.AddComponent<RigPart>();
                rigPart.Setup(transform.name);

                rigParts.Add(rigPart);
            }
        }

        #endregion
    }
}