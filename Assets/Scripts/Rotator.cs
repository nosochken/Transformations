using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] protected float _speed;

    private void Update()
    {
        Rotate();
    }

    protected virtual void Rotate()
    {
        transform.Rotate(transform.up, _speed * Time.deltaTime);
    }
}