using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileInputSystem
{
    public abstract class BaseInputHandler : MonoBehaviour
    {
        [SerializeField] protected bool isActive = false;

        // Properties can have default values
        public bool IsSetup { get; private set; } = false;
        
        public void Setup(params object[] _params)
        {
            // This is the same as IsSetup == true
            // IsSetup == false => !IsSetup
            // If we are setup, ignore this setup call and say a warning
            if(IsSetup)
            {
                Debug.LogWarning("InputHandler already setup, ignoring call...");
                return;
            }

            // Call the abstract setup function and set IsSetup to true
            OnSetup(_params);
            IsSetup = true;
        }
        
        // This parameter setup means that you can have any number of any
        // type of parameters, allowing for mixing parameter types
        protected abstract void OnSetup(params object[] _params);

        public void Run()
        {
            if(IsSetup && isActive)
            {
                OnUpdate();
            }
        }

        protected abstract void OnUpdate();
    }
}