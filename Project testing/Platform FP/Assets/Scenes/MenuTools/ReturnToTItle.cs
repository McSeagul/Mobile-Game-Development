using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToTItle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void ReturnTitle()
    {

        SceneManager.LoadScene("Menu");
    }
}
