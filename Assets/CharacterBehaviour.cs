using UnityEngine;
using System.Collections;

public class CharacterBehaviour : MonoBehaviour {

       public Rigidbody2D Character;
       public float speed;

// Update is called once per frame
void Update()
{
        Vector2 forces;
        forces.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        forces.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Character.AddForce(forces);
}
}
