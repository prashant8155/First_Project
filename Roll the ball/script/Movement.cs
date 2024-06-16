using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
public Rigidbody rb;
 public float forwardForce; 
 public float sideWaysForce; 

 public float JumpForce; 
 void Update()
 {
    


  
  
     transform.Translate(Vector3.right*Time.deltaTime*forwardForce);

     if(Input.GetKey(KeyCode.A)){
        transform.Translate(Vector3.forward*Time.deltaTime*sideWaysForce);
     }  
     if(Input.GetKey(KeyCode.D)){
        transform.Translate(Vector3.back*Time.deltaTime*sideWaysForce);
     } 
     if(Input.GetKeyDown(KeyCode.Space)){
      rb.AddForce(0,JumpForce,0*Time.deltaTime,ForceMode.Impulse);
     }
      if(Input.GetKeyUp(KeyCode.Space)){
      rb.AddForce(0,-JumpForce,0*Time.deltaTime,ForceMode.Impulse);
      }
}

}

