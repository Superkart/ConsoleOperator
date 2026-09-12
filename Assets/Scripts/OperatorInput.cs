using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class OperatorInput : MonoBehaviour
{
    
    private OperatorControls controls;

    public event Action SelectPressed;
    public event Action CyclePressed;
    public event Action CancelPressed;

    public Vector2 Look {get; private set;}
    public float Zoom {get; private set;}


    private void Awake()
    {
        controls = new OperatorControls();
    }


    private void Update()
    {
        Look = controls.Operator.Look.ReadValue<Vector2>();
        Zoom = controls.Operator.Zoom.ReadValue<float>();
    }
    private void OnEnable()
    {
        controls.Operator.Enable();
        controls.Operator.Select.performed += OnSelect;
        controls.Operator.Cycle.performed += OnCycle;
        controls.Operator.Cancel.performed += OnCancel;
    }


    private void OnDisable()
    {
        controls.Operator.Select.performed -= OnSelect;
        controls.Operator.Cycle.performed  -= OnCycle;
        controls.Operator.Cancel.performed -= OnCancel;
        controls.Operator.Disable(); 
    }


    private void OnDestroy()
    {
        controls.Dispose();
    }

    private void OnSelect(InputAction.CallbackContext ctx){ SelectPressed?.Invoke();}
    private void OnCycle(InputAction.CallbackContext ctx){CyclePressed?.Invoke();}
    private void OnCancel(InputAction.CallbackContext ctx){CancelPressed?.Invoke();}




}
