
using UnityEngine;
using TMPro;


public class PlayerHP : MonoBehaviour
{
    [Header("Health txt")]
    public TextMeshProUGUI hitPointDisplay;

    [Header("Health logic")]
    public int hitPoints = 3; //Variables handle player HP
    public bool endState = false;

    void Start()
    {
        hitPoints = 3; //Set player health on spawn
        hitPointUpdate(); //Update set health on first frame
    }
    private void hitPointUpdate()
    {
        hitPointDisplay.text = "HP: " + hitPoints; //Update hitpoint value per frame
    }
    void Update()
    {
        hitPointUpdate(); //Update HP display per frame.

        if (hitPoints == 0)
        {
            endState = true;

            Debug.Log("PlayerDeathRegister"); //Note player death in console for now

            Time.timeScale = 0f; //Temp code

            
        }
    }
}
