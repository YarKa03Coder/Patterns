using System.Collections.Generic;

namespace Patterns.Behavioral.Command
{
    public class ControlUnit
    {
        private readonly List<Command> _command = new List<Command>();

        private int _index = 0;

        public void StoreCommand(Command command)
        {
            _command.Add(command);
        }

        public void ExecuteCommand()
        {
            _command[_index++].Execute();
        }

        public void Undo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                if (_index > 0)
                {
                    _command[--_index].UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                if (_index <= _command.Count - 1)
                {
                    _command[_index++].Execute();
                }
            }
        }
    }
}