using UnityEngine;
using UnityEngine.SceneManagement;
public class Tutorial : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
    public void TutorialLevel()
    {

        SceneManager.LoadScene("Tutorial");
    }
}
