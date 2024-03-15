using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        if (GetComponent<Collider>().GetType() == typeof(SphereCollider))
            RotateSphere();
        else if (GetComponent<Collider>().GetType() == typeof(BoxCollider))
            RotateCube();
    }

    private void RotateSphere()
    {
        transform.Rotate(transform.right, _speed * Time.deltaTime);
    }

    private void RotateCube()
    {
        transform.Rotate(transform.up, _speed * Time.deltaTime);
    }
}
