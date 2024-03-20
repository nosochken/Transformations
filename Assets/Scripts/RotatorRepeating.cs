using UnityEngine;

public class RotatorRepeating : Rotator
{
    protected override void Rotate()
    {
        transform.rotation = Quaternion.Euler(Interpolation.Sine(_speed) * 360, 0f, 0f);
    }
}