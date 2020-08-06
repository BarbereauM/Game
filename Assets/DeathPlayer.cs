
using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
}



