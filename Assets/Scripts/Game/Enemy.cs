using UnityEngine;

namespace Game
{
    public class Enemy : MonoBehaviour
    {
        private float _speed = 2;
        private float _timeBeforeDestroy = 7;

        private void Update()
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);

            Destroy(gameObject, _timeBeforeDestroy);
        }
    }
}
