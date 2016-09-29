using UnityEngine;
using System.Collections;

public class CharacterBehaviour : MonoBehaviour {

       public Rigidbody2D Character;
       public float speed;

void GameOver()
    {
        Debug.Log("Game Over phase started");
        // UI for gameover goes here
    }

void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Entered Collision");
        if(other.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Character collided with projectile");
            GameOver();
        }
    }

void Update()
{
        Vector2 forces;
        forces.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        forces.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Character.AddForce(forces);
}
}
