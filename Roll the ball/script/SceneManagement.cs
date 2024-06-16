using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour

{
    // public static SceneManager instance;
    // void Awake()
    // {
    //     if (instance==null)
    //     instance=this;
    //     else if(instance!=null &&instance!=this)
    //     Destroy(this);
    // }
public void loadMainMenuScene(){
    SceneManager.LoadScene("Maimenu");
}
public void loadRunnerGameScene(){
    SceneManager.LoadScene("Runner game");
}
public void loadLevel1Scene(){
    SceneManager.LoadScene("Level 1");
}

}
