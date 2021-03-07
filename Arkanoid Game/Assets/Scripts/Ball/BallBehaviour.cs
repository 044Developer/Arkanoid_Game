using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(CircleCollider2D))]
public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    private BallStats _ballStats;
    [SerializeField]
    private Transform _platformTransform;

    private BallController _ballController;
    private Rigidbody2D _rigidBody;
    private bool _isBallActive = false;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _ballController = new BallController(this.gameObject, _platformTransform, _rigidBody, _ballStats, _isBallActive);
    }

    private void Update()
    {
        _ballController.ControllTheBall();
    }

    private void OnDisable()
    {
        _ballController.ReloadPhysic();
    }
}
