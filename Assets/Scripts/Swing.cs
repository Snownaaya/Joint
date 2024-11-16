using UnityEngine;

[RequireComponent(typeof(HingeJoint), typeof(Rigidbody))]
public class Swing : MonoBehaviour
{
    [SerializeField] private KeyboardInput _keyboardInput;
    [SerializeField] private float _force;

    private Rigidbody _rigidbody;

    private void Awake() =>
        _rigidbody = GetComponent<Rigidbody>();

    private void OnEnable() =>
        _keyboardInput.EKeyDown += Move;

    private void OnDisable() =>
        _keyboardInput.EKeyDown -= Move;

    private void Move() =>
        _rigidbody.AddForce(transform.forward * _force, ForceMode.Force);
}
