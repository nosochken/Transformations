using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciprocatingMover : Mover
{
    private Vector3 _startingPosition;

    private float _distance = 5f;

    private void Awake()
    {
        _startingPosition = transform.position;

        _speed = 0.5f;
    }

    void Update()
    {
        Move();
    }

    public override void Move()
    {
        transform.position =
            _startingPosition + TransformChanger.GetOffset(Vector3.forward * _distance, _speed);
    }
}
