using UnityEngine;
using System;

public class Sensor : MonoBehaviour
{

    public event Action<float> data;

    private void Update()
    {
        if(Time.frameCount % 60 == 0)
        {
            data?.Invoke(Mathf.Sin(Time.time));
        }
    }

}
