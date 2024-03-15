using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _minScale;
    private Vector3 _maxScale;

    private bool _hasReached;

    private void Start()
    {
        _minScale = transform.localScale;
        _maxScale = new Vector3(2f, 2f, 2f);

        _hasReached = false;
    }

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        if (_hasReached)
        {
            transform.localScale -= transform.localScale * _speed * Time.deltaTime;

            if (transform.localScale.x <= _minScale.x)
                _hasReached = false;
        }
        else
        {
            transform.localScale += transform.localScale * _speed * Time.deltaTime;

            if (transform.localScale.x >= _maxScale.x)
                _hasReached = true;
        }
    }
}