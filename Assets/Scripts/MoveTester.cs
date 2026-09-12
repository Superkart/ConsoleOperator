using UnityEngine;
using UnityEngine.InputSystem;

public class MoveTester : MonoBehaviour
{

    [SerializeField] private Mover mover;

    [SerializeField] private Transform TargetA;
    [SerializeField] private Transform TargetB;


    private void Update()
    {
        if(Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            mover.MoveTo(TargetA);
        }
        if(Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            mover.MoveTo(TargetB);
        }
    }

}
