using UnityEngine;

public class MoverRepeating : Mover
{
    private Vector3 _startPosition;

    private float _distance = 5f;

    private void Awake()
    {
        _startPosition = transform.position;

        _speed = 0.5f;
    }

    protected override void Move()
    {
        Vector3 offset = Vector3.forward * _distance;
        transform.position = _startPosition + offset * Interpolation.Sine(_speed);
    }
}