using Assets.Scripts.Model;
using UnityEngine;

namespace Assets.Scripts.View
{
    public class PlayerView : MonoBehaviour
    {

        private GameObject _player;
        private PlayerModel _playerModel;

        // Use this for initialization
        public void Start ()
        {
            _playerModel = Application.GetPlayerModel();
            _player = GameObject.Find("ExamplePlayer");
        }
	
        // Update is called once per frame
        public void Update ()
        {
            // Always RUN
            _player.transform.position = _playerModel.PlayerPositionVector3;
        }
    }
}
