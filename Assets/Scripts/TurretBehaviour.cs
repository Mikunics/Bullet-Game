using UnityEngine;
using System.Collections;

public class TurretBehaviour : MonoBehaviour {

    public GameObject projectile;
    public float speed = 10;
    float timeStamp = Time.time + 0.2f;

    void BulletFire()
    {
            Rigidbody2D bullet;
            this.transform.Rotate(0f, 0f, Random.Range(0f, 10.0f));
            bullet = (Rigidbody2D)Instantiate(projectile.GetComponent<Rigidbody2D>(), this.transform.position, this.transform.rotation);
            bullet.AddForce(bullet.transform.up * speed);
            timeStamp = Time.time + 0.2f;
    }

    void Spray()
    {
        Rigidbody2D bullet;
        for (int i = 5; i > 0; i--)
        {
            this.transform.Rotate(0f, 0f, 10f);
            bullet = (Rigidbody2D)Instantiate(projectile.GetComponent<Rigidbody2D>(), this.transform.position, this.transform.rotation);
            bullet.AddForce(bullet.transform.up * speed);
        }
        timeStamp = Time.time + 0.2f;
    }
void Start()
{     
        
}

// Update is called once per frame
void Update()
{
        if (timeStamp <= Time.time) Spray(); 
        
    }
}
