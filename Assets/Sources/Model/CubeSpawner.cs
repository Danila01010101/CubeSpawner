using System;
using UnityEngine;

public class CubeSpawner
{
    private float _newCubeSpeed = 0.1f;
    private float _newCubeSpawnInterval = 1;
    private float _newCubeDestroyDistance = 10;
    private float _lastTimeCubeSpawned = 0;

    public Action<float, float> OnCubeSpawn;

    public void Update()
    {
        if (Time.time - _lastTimeCubeSpawned > _newCubeSpawnInterval)
        {
            OnCubeSpawn?.Invoke(_newCubeSpeed/10, _newCubeDestroyDistance);
            _lastTimeCubeSpawned = Time.time;
        }
    }

    public void ChangeSpawnInterval(float newValue)
    {
        _newCubeSpawnInterval = newValue;
    }

    public void ChangeSpeed(float newValue)
    {
        _newCubeSpeed = newValue;
    }

    public void ChangeDestroyDistance(float newValue)
    {
        _newCubeDestroyDistance = newValue;
    }
}