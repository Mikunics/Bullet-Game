using UnityEngine;
using System.Collections;

public class MobileControl : MonoBehaviour {

       public Rigidbody2D Character;
       public float normSpeed;
       float rollSpeed = 9999;
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

    void FixedUpdate() {
       Character.AddForce(forces);
    }

	public void moveUpFunc() {
		forces.y = 1  * normSpeed * Time.deltaTime;
    }
	public void cancellMoveUpFunc() {
		forces.y = 0  * normSpeed * Time.deltaTime;

    }
	public void moveDownFunc() {
		forces.y = -1  * normSpeed * Time.deltaTime;
    }
	public void cancellMoveDownFunc() {
		forces.y = 0  * normSpeed * Time.deltaTime;
    }
	public void moveLeftFunc() {
		forces.x = -1  * normSpeed * Time.deltaTime;
    }
	public void cancellMoveLeftFunc() {
		forces.x = 0  * normSpeed * Time.deltaTime;
    }
	public void moveRightFunc() {
		forces.x = 1  * normSpeed * Time.deltaTime;
    }
	public void cancellMoveRightFunc() {
		forces.x = 0  * normSpeed * Time.deltaTime;
    }
	public void wildBoar() {
		normSpeed = normSpeed + rollSpeed;
    }
	public void calmWildBoar() {
		normSpeed = normSpeed - rollSpeed;
    }
}
