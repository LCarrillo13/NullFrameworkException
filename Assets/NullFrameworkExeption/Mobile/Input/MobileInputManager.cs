namespace NullFrameworkException.Mobile.InputHandling
{
    public class MobileInputManager : MonoSingleton<MobileInputManager>
    {
        public Optional<JoystickInputHandler> joystick = Optional<JoystickInputHandler>.Empty();
        public Optional<SwipeInputHandler> swiping = Optional<SwipeInputHandler>.Empty();
        
        // Start is called before the first frame update
        private void Start()
        {
            RunnableUtils.Setup(ref joystick, gameObject, this);
            RunnableUtils.Setup(ref swiping, gameObject);
        }

        // Update is called once per frame
        private void Update()
        {
            RunnableUtils.Run(ref joystick, gameObject);
            RunnableUtils.Run(ref swiping, gameObject);
        }
    }
}