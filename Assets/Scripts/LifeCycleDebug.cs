using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class LifeCycleDebug : MonoBehaviour
{

    [SerializeField] private GameObject other;
    
    private void Awake()
    {
        Debug.Log($"Label Awake frame = {Time.frameCount}") ;
    }

    private void OnEnable()
    {
        Debug.Log($"Label Awake frame = {Time.frameCount}") ;
    }

    private void Start()
    {
        Debug.Log($"Label Awake frame = {Time.frameCount}") ;
    }

    private void FixedUpdate()
    {
        if(Time.frameCount < 5)
        {
            Debug.Log($"Label Awake frame = {Time.frameCount}") ;     
        }
        
    }


    private void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame && other != null)
        {
            other.SetActive(!other.activeSelf);
            Debug.Log($"Label Awake frame = {Time.frameCount}") ;    
        }

        
    }

    private void LateUpdate()
    {
        if(Time.frameCount < 5)
        {
            Debug.Log($"Label Awake frame = {Time.frameCount}") ;     
        } 
    }

    private void OnDisable()
    {
        Debug.Log($"Label Awake frame = {Time.frameCount}") ;
    }




}
