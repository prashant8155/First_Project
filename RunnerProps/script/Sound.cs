using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
   public AudioSource CoinSound;

     void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag=="coin") {
        CoinSound.Play();
       }
       
    }
     void OnCollisionExit(Collision other)
       {
         CoinSound.Stop();
       }
}
