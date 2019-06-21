using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallParticle : MonoBehaviour
{

    public GameObject trailObject;

    private bool showParticles;

    // Start is called before the first frame update
    void Start()
    {
        trailObject.SetActive(false);
    }

    public void startTrailing() 
    {
        trailObject.SetActive(true);
    }
    
}
