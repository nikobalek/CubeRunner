using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public playerControl playerControl;
    public score score;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.tag == "obstical") 
        {
            Debug.Log("Game over");
            playerControl.enabled = false;
            score.isDead = true;
            Debug.Log(score.isGameOver());
        }
    }
}
