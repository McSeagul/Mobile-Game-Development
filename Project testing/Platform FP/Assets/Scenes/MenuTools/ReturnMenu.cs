using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{   
    public void MenuReturn()
    {
        if(Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene("Menu");
        }
        SceneManager.LoadScene("Menu");
    }
}
