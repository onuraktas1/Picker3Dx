using RunTime.Data.ValueObjects;
using RunTime.Managers;

namespace RunTime.Commands.Player
{
    public class ForceBallsToPoolCommand
    {
        private PlayerManager _playerManager;
        private PlayerForceData _forceData;

        public ForceBallsToPoolCommand(PlayerManager manager, PlayerForceData forceData)
        {
            _playerManager = manager;
            _forceData = forceData;
        }

        internal void Execute()
        {
        }

      
    }
}