using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript: MonoBehaviour
{
    //public Scene cena;
    public void restartScene()
    {
        
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        
    }


}
