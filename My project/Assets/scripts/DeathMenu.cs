using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame(){
    SceneManager.LoadScene(1);
   }

  public void QuitGame (){
    Debug.Log("Quit");
    Application.Quit();
}
}