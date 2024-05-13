using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleFire : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject gameOb;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == gameOb)
        {
            particle.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
