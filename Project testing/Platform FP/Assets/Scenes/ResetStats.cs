using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetStats : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Confirmation"))
        {
            ResetStat();
        }
    }
    public void ResetStat()
    {
        PlayerPrefs.DeleteAll();
    }
}

