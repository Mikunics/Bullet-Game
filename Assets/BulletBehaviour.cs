using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {

    public Transform Turret;
    public float speed = 10;
    Transform Bulletpos;
    Rigidbody2D Bulletbody;
    

void Start()
{
        GameObject Bullet = this.gameObject;
        Bulletpos = Bullet.GetComponent<Transform>();
        Bulletbody = this.GetComponent<Rigidbody2D>();
}

// Update is called once per frame
void Update()
{
        Bulletbody.velocity = transform.forward * speed;
        
}
}
