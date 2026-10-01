using UnityEngine;
public class LightFlicker : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D light2D;
    public float baseIntensity = 0.5f;
    public float flickerAmount = 0.3f;

    void Update()
    {
       // Controls the 2D light intensity of the ThrusterFlicker Spot light on ship
       light2D.intensity = baseIntensity + Random.Range(baseIntensity, flickerAmount); 
    }
}