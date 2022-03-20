using UnityEngine;

public class CubeSpawnerView : MonoBehaviour
{
    [SerializeField] private Transform _cubeSpawnPlace;
    [SerializeField] private Vector3 _moveDirection;

    public void SpawnCube(float speed, float destroyDistance)
    {
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newCube.transform.SetParent(_cubeSpawnPlace);
        newCube.transform.localPosition = Vector3.zero;
        var newCubePresenter = newCube.AddComponent<CubePresenter>();
        newCubePresenter.Initialize(_moveDirection, speed, destroyDistance);
    }
}
