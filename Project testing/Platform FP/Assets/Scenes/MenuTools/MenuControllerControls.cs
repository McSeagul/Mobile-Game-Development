using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerControls : MonoBehaviour
{
    public StartMenuButton StartMenuButton;
    public QuitMenuSelect QuitMenuSelect;
    public bool levelLocked = false;
    // Update is called once per frame
    void Update()
    {

            if (Input.GetButtonDown("Jump"))
            {
                StartMenuButton.Begin();
            }
            if (Input.GetButtonDown("Fire3"))
            {
                QuitMenuSelect.Quit();
            }

            //Below is leftover code from when this file was mostly swapped out


            //if(Input.GetButtonDown("Jump"))
            //{
            //    TutorialSelect.firstLevel();
            //}

            //if(Input.GetButtonDown("Fire2"))
            //{
            //    Level1.Level();
            //}
    }
}
