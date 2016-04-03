using Assets.Scripts.Controller;
using Assets.Scripts.Model;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Application : MonoBehaviour
    {
        private KinectInputModel _kinectInputModel;
        private PlayerModel _playerModel;
        private PlayerController _playerController;
        private KinectInputController _kinectInputController;

        private static bool VERBOSE = true;

        // Use this for initialization
        public void Start () {

            // Initalize MVC
            _kinectInputModel = new KinectInputModel(KinectInputModel.KINECTMOVE.KINNECTMOVE_IDLE);
            _playerModel = new PlayerModel(PlayerModel.STATE.STATE_STANDING, PlayerModel.LANE.LANE_MIDDLE);
            _playerController = new PlayerController(_playerModel, _kinectInputModel);
            _kinectInputController = new KinectInputController(_kinectInputModel, _playerController);
        }
	
        // Update is called once per frame
        private void Update () {
            // handle all actions
          //  _kinectInputController.HandleKinectInput("jump");
            if (VERBOSE)
            {
                if (Input.GetKeyDown(KeyCode.V))
                {
                    _kinectInputController.HandleKinectInput("left");
                    PrintVerbose();
                }
            }


        }


        private void PrintVerbose()
        {
            // VERBOSE
           Debug.Log("KinectInputModel State:" + _kinectInputModel.VerboseKinectMove());
           Debug.Log("PlayerModel State:" + _playerModel.VerbosePlayerState());
           Debug.Log("PlayerModel Lane:" + _playerModel.VerbosePlayerLane());
          // Debug.Log("PlayerModel Lane:" + _kinectInputController);
        }
    }
}
