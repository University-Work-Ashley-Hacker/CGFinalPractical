using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject _bulletFab;
    [SerializeField] Transform _shootSpot;

    Camera _cam;

    private void Awake()
    {
        _cam = Camera.main;
    }
    void Shoot()
    {
        var bullet = Instantiate(_bulletFab);

        bullet.transform.position = _shootSpot.position;
        bullet.transform.rotation = _cam.transform.rotation;
    }

    private void OnEnable()
    {
        PlayerInputHandler.ShootEvent += Shoot;
    }

    private void OnDisable()
    {
        PlayerInputHandler.ShootEvent -= Shoot;
    }
}
