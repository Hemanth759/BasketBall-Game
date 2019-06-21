using UnityEngine;

public class ScoreArea : MonoBehaviour
{

    public GameObject ScoreAreaParticles;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        ScoreAreaParticles.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<BallParticle>() != null) 
        {
            ScoreAreaParticles.SetActive(true);
        }
    }
}
