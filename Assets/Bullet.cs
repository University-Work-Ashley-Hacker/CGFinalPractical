using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float _speed;

    private void OnEnable()
    {
        Invoke("DeleteMe", 5);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
            
    }

    void DeleteMe()
    {
        Destroy(gameObject);
    }

}
