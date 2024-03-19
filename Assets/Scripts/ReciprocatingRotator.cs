using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ReciprocatingRotator : Rotator
{
    void Update()
    {
        Revolve();
    }

    public override void Revolve()
    {
        transform.Rotate(TransformChanger.GetOffset(transform.right, _speed), _speed);
    }
}