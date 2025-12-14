using UnityEngine;
using UnityEngine.InputSystem;

public class Deriver : MonoBehaviour
{
    [SerializeField]float SteerSpeed = 0.05f;
    [SerializeField]float MoveSpeed = 0.5f; 
    void Start()
    {
        
    }

    void Update()
    {
        float Steer = 0f;
        float Move = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            Move = 1f;
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            Steer = 1f;        
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Move = -1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            Steer = -1f;
        }
        float MoveAmnt = Move * MoveSpeed * Time.deltaTime;
        float SteerAmnt = Steer * SteerSpeed * Time.deltaTime;

        transform.Translate(0, MoveAmnt, 0);
        transform.Rotate(0, 0, SteerAmnt);
       
    }
}
