using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class processInput : MonoBehaviour
{
    public PlayerController controller;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        controller.inputX = v.x;
        controller.inputY = v.y;
    }
}
