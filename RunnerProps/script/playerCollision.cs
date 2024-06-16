
using UnityEngine;

public class playerCollision : MonoBehaviour

{
 public Movement movement;
 
 
  void OnCollisionEnter(Collision collisionInfo)
 {
    if(collisionInfo.collider.tag=="obstacle")
    movement.enabled=false;
     
 }
}
