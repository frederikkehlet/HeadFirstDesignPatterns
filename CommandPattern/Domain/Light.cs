namespace Domain
{
    public class Light
    {
        private State state;

        public Light()
        {
            state = State.Off;
        }

        public void On() 
        {
            if (state == State.Off)
            {
                state = State.On;
                Console.WriteLine("Light is on.");
            }
           
        }

        public void Off() 
        {
            if (state == State.On)
            {
                state = State.Off;
                Console.WriteLine("Light is off.");
            }
        }
    }

    enum State
    {
        On = 0,
        Off = 1
    }
}