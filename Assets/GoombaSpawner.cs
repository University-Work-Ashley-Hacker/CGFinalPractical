using UnityEngine;

public class GoombaSpawner : MonoBehaviour
{
    [SerializeField] GameObject _goomba;
    [SerializeField] int _goombas;
    private void Start()
    {
        for (int i = 0; i < _goombas; i++)
        {
            var goomba = Instantiate(_goomba);
            goomba.transform.position = new Vector3(Random.Range(-50, 50), 1, Random.Range(-30, 30));
            goomba.transform.rotation = Quaternion.identity;
        }

    }
}
