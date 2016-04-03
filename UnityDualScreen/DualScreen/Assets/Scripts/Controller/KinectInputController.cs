using System;
using System.Diagnostics;
using Assets.Scripts.Model;

namespace Assets.Scripts.Controller
{
    public class KinectInputController {

        private KinectInputModel _kinectInputModel;
        private PlayerController _playerController;
        private string _string = ""; 

        public KinectInputController(KinectInputModel kinectInputModel, PlayerController playerController)
        {
            _kinectInputModel = kinectInputModel;
            _playerController = playerController;
        }

        public void HandleKinectInput(string kinectInput)
        {
            switch (kinectInput)
            {
                case "idle":
                    _kinectInputModel.Kinectmove= KinectInputModel.KINECTMOVE.KINNECTMOVE_IDLE;
                    _playerController.HandleInput();
                    break;
                case "jump":
                    if(_kinectInputModel.Kinectmove != KinectInputModel.KINECTMOVE.KINNECTMOVE_JUMPING)
                        _kinectInputModel.Kinectmove = KinectInputModel.KINECTMOVE.KINNECTMOVE_JUMPING;
                        _playerController.HandleInput();
                    break;
                case "duck":
                    if (_kinectInputModel.Kinectmove != KinectInputModel.KINECTMOVE.KINNECTMOVE_DUCKING)
                        _kinectInputModel.Kinectmove = KinectInputModel.KINECTMOVE.KINNECTMOVE_DUCKING;
                    _playerController.HandleInput();
                    break;
                case "left":
                    _kinectInputModel.Kinectmove = KinectInputModel.KINECTMOVE.KINNECTMOVE_LANELEFT;
                    _playerController.HandleInput();
                    break;
                case "right":
                    _kinectInputModel.Kinectmove = KinectInputModel.KINECTMOVE.KINECTMOVE_LANERIGHT;
                    _playerController.HandleInput();
                    break;
            }
        }

        public string ReturnDebugLog()
        {
            return _string;
        }
    }
}
