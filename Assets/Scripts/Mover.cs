using UnityEngine;

public class Mover : MonoBehaviour
{
    protected float _speed = 1;

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.Translate(_speed * Time.deltaTime * transform.forward);
    }
}