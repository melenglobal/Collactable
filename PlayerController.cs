using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidbody;
     public Rigidbody Rigidbody
    {
        get
        {
            if(_rigidbody == null)
            {
                _rigidbody = GetComponent<Rigidbody>();

            }

          return _rigidbody;
        }
    }

     
    public float moveSpeed = 30.0f;

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Rigidbody.velocity = input * moveSpeed * Time.fixedDeltaTime;
        

    }
    
    private void OnTriggerEnter(Collider other)
    {
        IInteractable myInteract = other.GetComponent<IInteractable>();
           
            if (myInteract != null)
            {
            
                myInteract.Interact();

            }    
       
    }
}












 