using com.IronicEntertainment.TheBanished.SparkOfCreation;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

// Author: Ironee 

namespace com.IronicEntertainment.TheBanished.SparkOfCreation
{
    [CustomEditor(typeof(PlayerJump))]
    public class NewScript : Editor
    {
        private PlayerJump _Target;
    
        private void OnEnable()
        {
            _Target = (PlayerJump)target;
        }
    
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }
    }
}