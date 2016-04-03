using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Model
{
    public class PlayerModel
    {
        public enum STATE
        {
            STATE_STANDING,
            STATE_JUMPING,
            STATE_DUCKING,
            STATE_DEAD
        }

        public enum LANE
        {
            LANE_LEFT,
            LANE_MIDDLE,
            LANE_RIGHT
        }

        private readonly STATE _currentPlayerState;
        private readonly LANE _currentPlayerLane;
        
        public PlayerModel(STATE currentPlayerState, LANE currentPlayerLane)
        {
            _currentPlayerState = currentPlayerState;
            _currentPlayerLane = currentPlayerLane;
        }

        public STATE CurrentPlayerState { get; set; }
        public LANE CurrentPlayerLane { get; set; }

        public string VerbosePlayerState()
        {
            return _currentPlayerState.ToString();
        }

        public string VerbosePlayerLane()
        {
            return _currentPlayerLane.ToString();
        }
    }
}
