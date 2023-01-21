using UnityEngine;

namespace AngryKoala.Modular.Rig
{
    public class ModularCharacterRigVisualizer : MonoBehaviour
    {
        [SerializeField] private ModularCharacterRig modularCharacterRig;

        [SerializeField] private bool visualize;

        private void OnDrawGizmos()
        {
            if(modularCharacterRig != null && visualize)
            {
                Gizmos.color = Color.red;

                foreach(var rigPart in modularCharacterRig.RigParts)
                {
                    Gizmos.DrawWireSphere(rigPart.transform.position, .02f);
                }
            }
        }
    }
}