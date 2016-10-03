using UnityEngine;
using System.Collections;

public class CharacterBehaviour : MonoBehaviour {

       public Rigidbody2D Character;
       public float normSpeed;
       public float rollSpeed;
       private bool roll = false;
       private Vector2 forces;

    void GameOver() {
        Debug.Log("Game Over phase started");
        // UI for gameover goes here
        // I agree Glenn 
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Entered Collision");
        if(other.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Character collided with projectile");
            GameOver();
        }
    }

    void Update() {
        if (Input.GetKeyDown("space")) {
            roll = true;
            forces.x = Input.GetAxis("Horizontal") * rollSpeed * Time.deltaTime;
            forces.y = Input.GetAxis("Vertical") * rollSpeed * Time.deltaTime;
        } else {
            roll = false;
            forces.x = Input.GetAxis("Horizontal") * normSpeed * Time.deltaTime;
            forces.y = Input.GetAxis("Vertical") * normSpeed * Time.deltaTime;
        }
    }

    void FixedUpdate() {
        // sorry if i did it the ugly way :)
        // check if person should roll
        if (roll == false) {
            // normal movement or dont move
            Character.AddForce(forces);
        } else if (roll == true) {
            // roll speed
            Character.AddForce(forces);
         }
    }
}
