using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] protected float _speed;

    private void Update()
    {
        Revolve();
    }

    public virtual void Revolve()
    {
        transform.Rotate(transform.up, _speed * Time.deltaTime);
    }
}
