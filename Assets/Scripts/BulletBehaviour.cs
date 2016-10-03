using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {




void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }

// Update is called once per frame
void Update()
{
      
}
}
