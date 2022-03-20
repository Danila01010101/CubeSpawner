using UnityEngine;

[RequireComponent(typeof(CubeView))]
public class CubePresenter : MonoBehaviour
{
    private DefaultCube _cube;
    private CubeView _cubeView;
    private bool _isInitialized = false;

    public void Awake()
    {
        _cubeView = GetComponent<CubeView>();
        _cube = new DefaultCube();
    }

    public void Initialize(Vector3 directionToMove, float speed, float destroyDistance)
    {
        _cubeView.SetDirection(directionToMove);
        _cube.Initialize(speed, destroyDistance);
        _isInitialized = true;
    }

    public void Update()
    {
        if (_isInitialized)
        {
            _cube.Update();
        }
        else
        {
            Debug.Log("CubePresenter Not Initialized");
        }
    }

    private void OnEnable()
    {
        _cube.OnCubeDestroy += _cubeView.DestroyCube;
        _cube.OnCubeMove += _cubeView.RelocateCube;
    }

    private void OnDisable()
    {
        _cube.OnCubeDestroy -= _cubeView.DestroyCube;
        _cube.OnCubeMove -= _cubeView.RelocateCube;
    }
}
