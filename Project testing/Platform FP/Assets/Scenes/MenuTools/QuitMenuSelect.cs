using UnityEngine;

public class QuitMenuSelect : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
