using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    protected float _speed = 1;

    private void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}
