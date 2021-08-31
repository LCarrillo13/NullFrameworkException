using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileInputSystem
{
    public class MobileInputManager : MonoBehaviour
    {
        public JoystickInputHandler joystick;
        
        // Start is called before the first frame update
        private void Start()
        {
            joystick = FindObjectOfType<JoystickInputHandler>();
            joystick.Setup(this);
        }

        // Update is called once per frame
        private void Update()
        {
            joystick.Run();
        }
    }
}