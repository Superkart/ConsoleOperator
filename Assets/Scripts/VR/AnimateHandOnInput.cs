using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty triggerValue;
    public Animator handAnimator;

    private void Update()
    {
        float trigger = triggerValue.action.ReadValue<float>();


        handAnimator.SetFloat("Trigger", trigger);
    }

}
