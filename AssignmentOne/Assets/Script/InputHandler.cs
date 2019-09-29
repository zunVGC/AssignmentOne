using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern
{
    public class InputHandler : MonoBehaviour
    {
        // Object created for control
        public Transform myObj;
        // keyboard functions
        private Command W, S, A, D, C;
        // save all commands for undo
        public static List<Command> preCommand = new List<Command>();
        // object initialization position
        private Vector3 myObjInitPos;


        void Start()
        {
            // keyboard command functions
            W = new MoveFront();
            S = new MoveBack();
            A = new MoveLeft();
            D = new MoveRight();
            C = new Undo();
            myObjInitPos = myObj.position;
        }

        void Update()
        {
            HandleInput();
        }

        // press key for each functions
        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                A.Execute(myObj, A);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                D.Execute(myObj, D);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                S.Execute(myObj, S);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                W.Execute(myObj, W);
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                C.Execute(myObj, C);
            }
        }
    }
}