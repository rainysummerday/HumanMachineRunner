using System;

namespace Assets.Scripts.Model
{
    public class KinectInputModel {

        public enum KINECTMOVE
        {
            KINNECTMOVE_IDLE = 0,
            KINNECTMOVE_JUMPING = 1,
            KINNECTMOVE_DUCKING = 2,
            KINNECTMOVE_LANELEFT = 3,
            KINECTMOVE_LANERIGHT = 4
        }

        private KINECTMOVE _kinectMoveState;

        public KinectInputModel(KINECTMOVE kinectMoveState)
        {
            _kinectMoveState = kinectMoveState;
        }

        public KINECTMOVE Kinectmove { get; set; }

        public string VerboseKinectMove()
        {
            return _kinectMoveState.ToString();
        }

    }
}
