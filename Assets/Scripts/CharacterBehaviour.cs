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
    
    void CheckInput(){
    // here goes the code that check what skill is equipped
    if(Input.GetKeyDown("space")){
            forces.x = Input.GetAxis("Horizontal") * rollSpeed * Time.deltaTime;
            forces.y = Input.GetAxis("Vertical") * rollSpeed * Time.deltaTime;
    }       
           
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
            forces.x = Input.GetAxis("Horizontal") * normSpeed * Time.deltaTime;
            Debug.Log(Input.GetAxis("Horizontal")+"x");
            forces.y = Input.GetAxis("Vertical") * normSpeed * Time.deltaTime;
            Debug.Log(Input.GetAxis("Vertical")+"y");
            CheckInput();
    }

    void FixedUpdate() {
       Character.AddForce(forces);
    }
}

