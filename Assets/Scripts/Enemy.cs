using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 2;

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
        
        Destroy(gameObject, 7f);
    }
}
