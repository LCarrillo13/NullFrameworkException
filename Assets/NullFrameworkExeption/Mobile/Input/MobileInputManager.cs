namespace NullFrameworkException.Mobile.InputHandling
{
    public class MobileInputManager : MonoSingleton<MobileInputManager>
    {
        public JoystickInputHandler joystick;
        public SwipeInputHandler swiping;
        
        // Start is called before the first frame update
        private void Start()
        {
            RunnableUtils.Setup(ref joystick, gameObject, true, this);
            RunnableUtils.Setup(ref swiping, gameObject, true);
        }

        // Update is called once per frame
        private void Update()
        {
            RunnableUtils.Run(ref joystick, gameObject, true);
            RunnableUtils.Run(ref swiping, gameObject, true);
        }
    }
}