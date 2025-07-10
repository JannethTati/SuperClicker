using System.Runtime.CompilerServices;
using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {

        [SerializeField] private Bullet _bullet;
        [SerializeField] private float _speed = 1;
        [SerializeField] private SpriteRenderer _player;
        private Vector2 _movement;

        private void Update()
        {
            if (_movement.magnitude > 0)
            { 
                _player.transform.Translate(_movement, Space.World);
            }
        }

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            _movement = virtualMoveDirection * Time.deltaTime * _speed;
            
        }

        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            if (virtualLookDirection != Vector2.zero)
            { 
                _player.transform.up = new Vector2 (virtualLookDirection.x, -virtualLookDirection.y);
                Instantiate(_bullet, _player.transform.position + _player.transform.up, _player.transform.rotation);
            }
            
            
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            _player.color = Color.black;
        }

        public void VirtualSprintInput(bool virtualSprintState)
        {
            _player.color = Color.blue;
            
        }

        
    }

}
