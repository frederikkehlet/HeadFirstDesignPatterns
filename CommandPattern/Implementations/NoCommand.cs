using Interfaces;

namespace Implementations 
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            return;
        }
    }
}