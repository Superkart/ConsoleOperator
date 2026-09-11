using UnityEngine;

public class Display : MonoBehaviour
{

    [SerializeField] private Sensor sensor;


    private void OnEnable()
    {
        sensor.data += ShowData;
    }

    private void OnDisable()
    {
        sensor.data -= ShowData;      
    }

    private void ShowData(float val)
    {
        Debug.Log(val);
    }
}
