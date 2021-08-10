using UnityEngine;

namespace NullFrameworkException.Mobile.InputHandling
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