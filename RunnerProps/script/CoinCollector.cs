using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
   private int coin=0;
   

   private void OnTriggerEnter(Collider other)
   {
    if(other.CompareTag("Player")){ 
      coin++;
    Debug.Log(coin);
    Destroy(gameObject);}
     
   
   }
}
