using UnityEngine;

public class Interpolation
{
    private const float tau = Mathf.PI * 2;

    public static float Sine(float speed)
    {
        float cycle = Time.time * speed;

        float rawSinWave = Mathf.Sin(tau * cycle);

        float factor = (rawSinWave * 0.5f) + 0.5f;

        return factor;
    }
}