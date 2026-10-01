using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButton : MonoBehaviour
{
     public void Begin()
    {
        //Loads level select screen
        SceneManager.LoadScene("levelSelect");
    }
}
