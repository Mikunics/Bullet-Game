using UnityEngine;
using System.Collections;

public class TurretBehaviour : MonoBehaviour {

    public GameObject projectile;
    public float speed = 10;    
void BulletFire()
{
        Rigidbody2D bullet;
        bullet = (Rigidbody2D) Instantiate(projectile.GetComponent<Rigidbody2D>(), this.transform.position, this.transform.rotation);
        bullet.AddForce(bullet.transform.up * speed);
        Debug.Log("Fire Succesfull");
        Debug.Log(bullet.transform.up * speed);
    }

void Start()
{
        BulletFire();
}

// Update is called once per frame
void Update()
{

}
}
