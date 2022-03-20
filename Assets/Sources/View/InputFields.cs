using System;
using System.Globalization;
using TMPro;
using UnityEngine;

public class InputFields : MonoBehaviour
{
    [SerializeField] private TMP_InputField _spawnIntervalField;
    [SerializeField] private TMP_InputField _cubesMovementSpeedField;
    [SerializeField] private TMP_InputField _cubeDistanceField;

    public Action<float> SpawnIntervalValueChange;
    public Action<float> CubeMovementSpeedValueChange;
    public Action<float> CubeDestroyDistanceValueChange;

    public void ChangeSpawnIntervalValue()
    {
        if (_spawnIntervalField.text != null || _spawnIntervalField.text != "")
        {
            float newValue = float.Parse(_spawnIntervalField.text, new CultureInfo("en-US").NumberFormat);
            SpawnIntervalValueChange?.Invoke(newValue);
        }
    }

    public void ChangeCubeMovementSpeedValue()
    {
        if (_spawnIntervalField.text != null || _spawnIntervalField.text != "")
        {
            float newValue = float.Parse(_cubesMovementSpeedField.text, new CultureInfo("en-US").NumberFormat);
            CubeMovementSpeedValueChange?.Invoke(newValue);
        }
    }

    public void ChangeCubeMoveDistanceValue()
    {
        if (_spawnIntervalField.text != null || _cubeDistanceField.text != "")
        {
            float newValue = float.Parse(_cubeDistanceField.text, new CultureInfo("en-US").NumberFormat);
            CubeDestroyDistanceValueChange?.Invoke(newValue);
        }
    }
}
