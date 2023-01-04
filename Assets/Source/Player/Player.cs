using UnityEngine;

namespace Balthazariy.Player
{
    public class Player : MonoBehaviour
    {
        [Header("Player Settings")]
        [SerializeField] private GameObject _selfObject;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Collider _collider;
        [SerializeField] private float _speed;


        private PlayerMovement _playerMovement;
        private PlayerCollector _playerCollector;

        private void OnEnable()
        {

        }

        private void OnDisable()
        {

        }

        private void Awake()
        {

        }

        private void Start()
        {
            _playerCollector = _selfObject.GetComponent<PlayerCollector>();

            _playerCollector.PlayerCollectEvent += PlayerCollectEventHandler;

            GameplayStartedEventHandler();
        }

        private void Update()
        {
            UpdatePlayerMovement();
        }

        private void FixedUpdate()
        {
            FixedUpdatePlayerMovement();
        }

        private void UpdatePlayerMovement()
        {
            if (_playerMovement == null)
                return;

            _playerMovement.Update();
        }

        private void FixedUpdatePlayerMovement()
        {
            if (_playerMovement == null)
                return;

            _playerMovement.FixedUpdate();
        }    

        private void GameplayStartedEventHandler()
        {
            if (_playerMovement == null)
                _playerMovement = new PlayerMovement(_selfObject, _rigidbody, _speed);
        }

        private void PlayerCollectEventHandler(Collider collider)
        {

            Debug.Log(">>> Item was collected <<<" + 
                     $"> Item name = [{collider.gameObject.name}] <");
        }
    }
}