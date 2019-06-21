using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Player player;

    [Space]

    public float resetTime = 5f;

    // Update is called once per frame
    void Update()
    {
        if(!player.isHoldingBall) 
        {
            resetTime -= Time.deltaTime;
            if(resetTime <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
