using UnityEngine;

public class CubeSpawnerPresenter : MonoBehaviour
{
    [SerializeField] private InputFields _inputFields;
    [SerializeField] private CubeSpawnerView _cubeSpawnerView;

    private CubeSpawner _cubeSpawner;

    private void Awake()
    {
        _cubeSpawner = new CubeSpawner();
    }

    public void Update()
    {
        _cubeSpawner.Update();
    }

    private void OnEnable()
    {
        _inputFields.CubeDestroyDistanceValueChange += _cubeSpawner.ChangeDestroyDistance;
        _inputFields.SpawnIntervalValueChange += _cubeSpawner.ChangeSpawnInterval;
        _inputFields.CubeMovementSpeedValueChange += _cubeSpawner.ChangeSpeed;
        _cubeSpawner.OnCubeSpawn += _cubeSpawnerView.SpawnCube;
    }

    private void OnDisable()
    {
        _inputFields.CubeDestroyDistanceValueChange -= _cubeSpawner.ChangeDestroyDistance;
        _inputFields.SpawnIntervalValueChange -= _cubeSpawner.ChangeSpawnInterval;
        _inputFields.CubeMovementSpeedValueChange -= _cubeSpawner.ChangeSpeed;
        _cubeSpawner.OnCubeSpawn += _cubeSpawnerView.SpawnCube;
    }
}
