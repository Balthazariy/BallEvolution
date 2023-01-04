using UnityEngine;

namespace Balthazariy.Player
{
    public class PlayerMovement
    {
        private readonly GameObject _selfObject;
        private readonly Rigidbody _rigidbody;

        private float _speed;

        private Vector2 _direction;

        public PlayerMovement(GameObject selfObject, Rigidbody rigidbody, float speed)
        {
            _selfObject = selfObject;
            _rigidbody = rigidbody;
            _speed = speed;
        }

        public void Update()
        {
            UpdateAxisValue();
        }

        public void FixedUpdate()
        {
            if (_rigidbody == null)
                return;

            MoveByAxis();
        }

        public void UpdateSpeedValue(float value) => _speed = value;

        private void UpdateAxisValue()
        {
            _direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

        private void MoveByAxis()
        {
            _direction.Normalize();
            _rigidbody.velocity = _direction * _speed * Time.deltaTime;
        }
    }
}