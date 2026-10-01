using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialSelect : MonoBehaviour
{
    public void firstLevel()
    {
        //Loads the tutorial level
        SceneManager.LoadScene("Tutorial");
    }
}
