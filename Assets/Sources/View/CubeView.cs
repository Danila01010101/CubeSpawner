using UnityEngine;

public class CubeView : MonoBehaviour
{
    private Vector3 _direction;

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    public void RelocateCube(float newPositionOnDirection)
    {
        transform.localPosition = _direction * newPositionOnDirection;
    }

    public void DestroyCube()
    {
        Destroy(gameObject);
    }
}
