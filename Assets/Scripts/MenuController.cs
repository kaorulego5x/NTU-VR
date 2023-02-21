using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartButton(){
        Debug.Log("clicked");
        SceneManager.LoadScene("ObstacleCourse");
    }
    public void QuitButton(){
     Application.Quit();
    }
}
