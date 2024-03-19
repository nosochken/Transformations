using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _startingScale;

    private void Awake()
    {
        _startingScale = transform.localScale;
    }

    private void Update()
    {
        transform.localScale =
            _startingScale + TransformChanger.GetOffset(Vector3.one ,_speed);
    }
}