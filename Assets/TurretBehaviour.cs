using UnityEngine;
using System.Collections;

public class TurretBehaviour : MonoBehaviour {

    public GameObject projectile;
    public float speed = 10;
    float timeStamp = Time.time + 0.5f;
    void BulletFire()
{
        Rigidbody2D bullet;
        bullet = (Rigidbody2D) Instantiate(projectile.GetComponent<Rigidbody2D>(), this.transform.position, this.transform.rotation);
        bullet.AddForce(bullet.transform.up * speed);
        timeStamp = Time.time + 0.5f;
    }
void Start()
{
        BulletFire();
}

// Update is called once per frame
void Update()
{
        this.transform.Rotate(0f, 0f, 1f);
        if(timeStamp <= Time.time) BulletFire();
}
}
