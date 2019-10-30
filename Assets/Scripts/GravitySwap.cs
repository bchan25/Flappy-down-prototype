using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwap : MonoBehaviour
{
    enum GravityDirection { Up, Down, Left, Right };
    [SerializeField]
    GravityDirection gravityDirection;

    [SerializeField]
    float gravity = 9.81f;

    enum GameDimension { ThreeD, TwoD};
    GameDimension gameDimension = GameDimension.ThreeD;


    // Start is called before the first frame update
    void Start()
    {
        if(gameDimension == GameDimension.ThreeD)
        {
            switch (gravityDirection)
            {
                case GravityDirection.Up:
                    Physics.gravity = new Vector3(0f, gravity, 0f);
                    break;
                case GravityDirection.Down:
                    Physics.gravity = new Vector3(0f, -gravity, 0f);
                    break;
                case GravityDirection.Left:
                    Physics.gravity = new Vector3(-gravity, 0f, 0f); ;
                    break;
                case GravityDirection.Right:
                    Physics.gravity = new Vector3(gravity, 0f, 0f); ;
                    break;
                default:
                    print("Incorrect Gravity Scale");
                    break;
            }
        }
        else if(gameDimension == GameDimension.TwoD)
        {
            switch (gravityDirection)
            {
                case GravityDirection.Up:
                    Physics2D.gravity = new Vector2(0f, gravity);
                    break;
                case GravityDirection.Down:
                    Physics2D.gravity = new Vector2(0f, -gravity);
                    break;
                case GravityDirection.Left:
                    Physics2D.gravity = new Vector2(-gravity, 0f); 
                    break;
                case GravityDirection.Right:
                    Physics2D.gravity = new Vector2(gravity, 0f);
                    break;
                default:
                    print("Incorrect Gravity Scale");
                    break;
            }
        }
        
    }

    
}
