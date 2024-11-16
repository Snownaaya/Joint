using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Catapult : MonoBehaviour
{
    [SerializeField] private float _lounchForce;

    [SerializeField] private KeyboardInput _keyboardInput;
    [SerializeField] private ProjectileSpawner _projectileSpawner;

    private Rigidbody _rigidbody;

    private void Awake() =>
        _rigidbody = GetComponent<Rigidbody>();

    private void Start() =>
        _projectileSpawner.Spawn();

    private void OnEnable()
    {
        _keyboardInput.QkeyDown += Fire;
        _keyboardInput.SpaceDown += ResetTile;
    }

    private void OnDisable()
    {
        _keyboardInput.QkeyDown -= Fire;
        _keyboardInput.SpaceDown -= ResetTile;
    }

    private void Fire() =>
        _rigidbody.AddForce(transform.up * _lounchForce, ForceMode.Force);

    private void ResetTile() =>
        _projectileSpawner.Spawn();
}
