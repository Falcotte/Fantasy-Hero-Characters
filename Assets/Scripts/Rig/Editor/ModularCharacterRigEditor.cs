using UnityEditor;
using UnityEngine;

namespace AngryKoala.Modular.Rig
{
    [CustomEditor(typeof(ModularCharacterRig))]
    public class ModularCharacterRigEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            ModularCharacterRig rig = (ModularCharacterRig)target;

            base.OnInspectorGUI();

            if(GUILayout.Button("Setup Rig"))
            {
                rig.SetupRig();
            }
        }
    }
}