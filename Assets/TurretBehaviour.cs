using UnityEngine;
using System.Collections;

public class TurretBehaviour : MonoBehaviour {

    public GameObject Character;
    public GameObject projectile;
    public float speed = 70f;
    float timeStamp = Time.time + 0.2f;
    short FireType, count;

    void ChooseRandom()
    {
        FireType = (short)System.Math.Floor(Random.Range(1f,4.99f));
        count = 0;
    }

    void ParallelFire() // Type 1
    {
            Rigidbody2D bullet;
            transform.Rotate(0f, 0f,170f);
            bullet = (Rigidbody2D)Instantiate(projectile.GetComponent<Rigidbody2D>(), transform.position, transform.rotation);
            bullet.AddForce(bullet.transform.up * speed);
            timeStamp = Time.time + 0.1f;
    }

    void CircleFire() // Type 2
    {
        Rigidbody2D bullet;
        for(int i = 0; i!= 18; i++){
            transform.Rotate(0f, 0f,20.0f);
            bullet = (Rigidbody2D)Instantiate(projectile.GetComponent<Rigidbody2D>(), transform.position, transform.rotation);
            bullet.AddForce(bullet.transform.up * speed);
        }
        timeStamp = Time.time + 3f;
    }

    void FollowFire() // Type 3
    {
        transform.up = Character.transform.position - transform.position;
        Rigidbody2D bullet;
        bullet = (Rigidbody2D)Instantiate(projectile.GetComponent<Rigidbody2D>(), transform.position, transform.rotation);
        bullet.AddForce(bullet.transform.up * speed);
        timeStamp = Time.time + 0.3f;
    }

    void SprayFire() // Type 4
    {
        Rigidbody2D bullet;
        for (int i = 5; i > 0; i--)
        {
            transform.Rotate(0f, 0f, 10f);
            bullet = (Rigidbody2D)Instantiate(projectile.GetComponent<Rigidbody2D>(), transform.position, transform.rotation);
            bullet.AddForce(bullet.transform.up * speed);
        }
        timeStamp = Time.time + 0.5f;
    }
void Start()
{
        ChooseRandom();  
}

// Update is called once per frame
void Update()
{
        switch (FireType)
        {
            case 1:
                if (timeStamp <= Time.time) ParallelFire();
                count++;
                if (count > 300)ChooseRandom();
                break;
            case 2:
                if (timeStamp <= Time.time) CircleFire();
                count++;
                if (count > 300) ChooseRandom();
                break;
            case 3:
                if (timeStamp <= Time.time) FollowFire();
                count++;
                if (count > 300) ChooseRandom();
                break;
            case 4:
                if (timeStamp <= Time.time) SprayFire();
                count++;
                if (count > 300) ChooseRandom();
                break;

            default:

                break;
        }
       
        
    }
}
