using UnityEngine;

public class RemovingEnemies : MonoBehaviour
{
    private string _tagEnemy = "Enemy";
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_tagEnemy))
        {
            Destroy(collision.gameObject);
        }
    }
}