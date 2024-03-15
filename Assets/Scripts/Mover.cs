using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField] private MeshCollider _plane;

    private float _speed;
    private bool _hasReached;
    
    private void Start()
    {
        _speed = 5f;
        _hasReached = false;
    }

    private void Update()
    {
        if (GetComponent<Collider>().GetType() == typeof(SphereCollider))
            MoveSphere();
        else if (GetComponent<Collider>().GetType() == typeof(BoxCollider))
            MoveCube();
    }

    private void MoveSphere()
    {
        if (_hasReached)
        {
            transform.Translate(-Vector3.forward * _speed * Time.deltaTime);

            if (transform.position.z <= _plane.bounds.min.z)
                _hasReached = false;
        }
        else
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);

            if (transform.position.z >= _plane.bounds.max.z)
                _hasReached = true;
        }
    }

    private void MoveCube()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}
