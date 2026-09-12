using UnityEngine;
using UnityEngine.InputSystem;

public class MoveTester : MonoBehaviour
{
    [SerializeField] private OperatorInput input;
    [SerializeField] private Mover mover;

    [SerializeField] private Transform TargetA;
    [SerializeField] private Transform TargetB;

    private bool goToA = true;

    private void OnEnable()
    {
        input.CyclePressed += OnCycle;
    } 


    private void OnCycle()
    {
        if (goToA)
        {
            mover.MoveTo(TargetA);
            goToA = false;
        }
        else
        {
            mover.MoveTo(TargetB);
            goToA = true;
        }
}

/*     private void Update()
    {
        if(Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            mover.MoveTo(TargetA);
        }
        if(Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            mover.MoveTo(TargetB);
        }
    } */

}
