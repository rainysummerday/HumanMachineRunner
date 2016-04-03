using System;
using Assets.Scripts.Model;

namespace Assets.Scripts.Controller
{
    public class PlayerController {

        private readonly PlayerModel _playerModel;
        private readonly KinectInputModel _kinectInputModel;

        public PlayerController(PlayerModel playerModel, KinectInputModel kinectInputModel)
        {
            _playerModel = playerModel;
            _kinectInputModel = kinectInputModel;
        }

        public void HandleInput()
        {
            switch (_kinectInputModel.Kinectmove)
            {
                // Moves
                case KinectInputModel.KINECTMOVE.KINNECTMOVE_IDLE:
                    _playerModel.CurrentPlayerState = PlayerModel.STATE.STATE_STANDING;
                    break;
                case KinectInputModel.KINECTMOVE.KINNECTMOVE_JUMPING:
                    _playerModel.CurrentPlayerState = PlayerModel.STATE.STATE_JUMPING;
                    break;
                case KinectInputModel.KINECTMOVE.KINNECTMOVE_DUCKING:
                    _playerModel.CurrentPlayerState = PlayerModel.STATE.STATE_DUCKING;
                    break;

                // Lanes
                case KinectInputModel.KINECTMOVE.KINECTMOVE_LANERIGHT:
                    if(_playerModel.CurrentPlayerLane != PlayerModel.LANE.LANE_RIGHT)
                    _playerModel.CurrentPlayerLane++;
                    break;
                case KinectInputModel.KINECTMOVE.KINNECTMOVE_LANELEFT:
                    if (_playerModel.CurrentPlayerLane != PlayerModel.LANE.LANE_LEFT)
                        _playerModel.CurrentPlayerLane--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("PlayerController " + "Wrong HandleInput value");
            }
        }
    }
}
