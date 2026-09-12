using UnityEngine;
using System;
using System.Collections;
public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 2;



    private IEnumerator MoveRoutine(Transform t)
    {
        while(Vector3.Distance(transform.position, t.position) > 0.05)
        {

            transform.position = Vector3.MoveTowards(transform.position, t.position, speed * Time.deltaTime);

            yield return null;    
        }
        
        
    }
    public void MoveTo(Transform t)
    {
        
        StopAllCoroutines();
        StartCoroutine(MoveRoutine(t));

    }










/*     private void Update()
    {
        if(target == null)
        {
            return;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if(Vector3.Distance(transform.position, target.position) < 0.05)
            {
                Debug.Log("Arrived at target");
                target = null;
            }
        }

    } */

}
