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
        transform.localScale = _startingScale * Interpolation.Sine(_speed) + Vector3.one;
    }
}