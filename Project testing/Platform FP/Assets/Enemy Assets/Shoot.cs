using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;
    public float FireRate = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EnemyShoot());
    }

    IEnumerator EnemyShoot()
    {
        while(true)
        {
            Instantiate(Bullet, transform.position , transform.rotation);
            yield return new WaitForSeconds(FireRate);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
