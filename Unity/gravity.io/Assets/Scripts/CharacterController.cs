using System; 
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class CharacterController:MonoBehaviour
{
    [Header("General Settings")] public float speed; 
    [Range(0, 1)] public float movement_smoothing; 
    public Rigidbody2D rigidbody; 
    public Joystick joystick; 
    
    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Movement_Handler(); 
    }

    private void Movement_Handler()
    {
        Vector3 input = new Vector3(joystick.Horizontal, joystick.Vertical); 
        rigidbody.MovePosition(transform.position + input * speed * Time.deltaTime);
    }
}
