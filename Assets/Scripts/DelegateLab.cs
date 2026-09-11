using System;
using UnityEngine;
public class DelegateLab : MonoBehaviour
{

    
    private void Start()
    {
        Action<int> h = null;     
        h += PrintDoubleValue;
        h += PrintSquareValue;

        h(5);
        
        h -= PrintDoubleValue;
        h -=PrintSquareValue;
        h?.Invoke(5);
    }


    private void PrintDoubleValue(int value)
    {
        Debug.Log("double: " + (value * 2));
    }

    private void PrintSquareValue(int value)
    {
        Debug.Log("square: " + (value * value));
    }


}
