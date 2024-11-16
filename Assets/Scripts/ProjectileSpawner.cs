using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private Projectile _projectile;
    [SerializeField] private Transform _point;

    public void Spawn() =>
        Instantiate(_projectile, _point.position, _point.transform.rotation);
}
