using com.IronicEntertainment.Scripts.Components.Global.Stats;
using com.IronicEntertainment.Scripts.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static com.IronicEntertainment.Scripts.Enums.E_Statistics;

// Author: Ironee 

namespace com.IronicEntertainment.TheBanished.SparkOfCreation
{
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private InputsContainer_Resource _Controler;

        [SerializeField] private StatBook_Component _StatContainer;

        [SerializeField] private bool _ApplyDefaultJump_Force = true;
        [SerializeField] private int _DefaultJump_Force = 1;

        private bool _CanJump = true;
        public bool CanJump { get => _CanJump; set => _CanJump = value; }

        private int _Jump_Force;
        public int Jump_Force
        {
            get
            {
                if (_StatContainer != null) _Jump_Force = _StatContainer.Stats[StatBookKeys.Simple.ToString()][nameof(Jump_Force)][StatBookKeys.Value.ToString()];

                return _Jump_Force;
            }
        }
    }
}