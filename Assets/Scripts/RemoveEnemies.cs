using UnityEngine;

public class RemoveEnemies : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out MovementEnemy _))
            Destroy(collision.gameObject);
    }
}