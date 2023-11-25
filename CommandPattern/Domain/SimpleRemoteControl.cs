using Implementations;
using Interfaces;

namespace Domain
{
    public class SimpleRemoteControl
    {
        ICommand[] onCommands = new ICommand[7];
        ICommand[] offCommands = new ICommand[7];

        public SimpleRemoteControl()
        {
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }

        public void SetOnCommand(int slot, ICommand command)
        {
            onCommands[slot] = command;
        }

        public void SetOffCommand(int slot, ICommand command)
        {
            offCommands[slot] = command;
        }

        public void OnButtonWasPressed(int slot) 
        {
            onCommands[slot].Execute();
        }

        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].Execute();
        }
    }
}