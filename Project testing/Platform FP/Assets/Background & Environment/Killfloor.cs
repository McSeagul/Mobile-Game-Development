using System.Collections;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;

public class Killfloor : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D light2D;
    public float baseIntensity = 0f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            light2D.intensity = baseIntensity;
            Destroy(collision.gameObject);
            StartCoroutine(WaitTime());
        }
    }
    IEnumerator WaitTime()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("GameOver");
        } 
            
    }
}
