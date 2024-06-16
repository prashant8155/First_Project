using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class NewBehaviourScript : MonoBehaviour
{
   
    public void Quit()
    {
         #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
            #endif
            Application.Quit();
    }
}
    


