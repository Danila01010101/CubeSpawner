using System;

public class DefaultCube
{
    private float _speed;
    private float _destroyDistance;
    private float _currentPosition;

    public Action<float> OnCubeMove;
    public Action OnCubeDestroy;

    public void Update()
    {
        _currentPosition += _speed;
        OnCubeMove?.Invoke(_currentPosition);
        if (_currentPosition > _destroyDistance)
        {
            OnCubeDestroy?.Invoke();
        }
    }

    public void Initialize(float speed, float destroyDistance)
    {
        _speed = speed;
        _destroyDistance = destroyDistance;
    }

    public DefaultCube() { }

    public DefaultCube(float speed, float destroyDistance)
    {
        _speed = speed;
        _destroyDistance = destroyDistance;
    }
}
