using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformChanger
{
    public static Vector3 GetOffset(Vector3 vector,float speed)
    {
        float cycle = Time.time * speed;

        const float tau = Mathf.PI * 2;
        float rawSinWave = Mathf.Sin(tau * cycle);

        float factor = (rawSinWave + 1f) / 2f;

        return vector * factor;
    }
}