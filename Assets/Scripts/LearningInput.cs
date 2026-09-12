using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class LearningInput : MonoBehaviour
{

    private LearningActions input;
    //public event Action moveAround;
    public Vector2 mouseLook {get; private set;}

    private void Awake()
    {
        input = new LearningActions();
    }
    private void OnDestroy()
    {
        input.Dispose();
    }

    private void OnEnable()
    {
        input.LearningMap.Enable(); 
        //input.LearningMap.Look.performed += MoveAround;
    }
    private void OnDisable()
    {
        input.LearningMap.Disable();
        //input.LearningMap.Look.performed -= MoveAround;
    }


    private void Update()
    {
        mouseLook = input.LearningMap.Look.ReadValue<Vector2>();
    }


    //private void MoveAround(InputAction.CallbackContext context){moveAround?.Invoke();}
}
