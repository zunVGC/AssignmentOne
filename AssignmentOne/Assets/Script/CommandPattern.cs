using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern
{
    public class CommandPattern : MonoBehaviour
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

    public abstract class Command
    {
        // Execute functions and save it to command
        public abstract void Execute(Transform myObj, Command command);

        // undo function for object
        public virtual void Undo(Transform myObj) { }

        // move function for object
        public virtual void Move(Transform myObj) { }
    }

    public class MoveFront : Command
    {
        // call function for object move front and save for command
        public override void Execute(Transform myObj, Command command)
        {
            // move object
            Move(myObj);

            // save this command for undo function
            CommandPattern.preCommand.Add(command);
        }

        // go back to last position for undo function, when move 1f, it save for go back 1f
        public override void Undo(Transform myObj)
        {
            myObj.Translate(-myObj.forward * 0.5f);
        }

        // move object for 0.5f
        public override void Move(Transform myObj)
        {
            myObj.Translate(myObj.forward * 0.5f);
        }
    }


    public class MoveBack : Command
    {
        // call function for object move back and save for command
        public override void Execute(Transform myObj, Command command)
        {
            // move object
            Move(myObj);

            // save this command for undo function
            CommandPattern.preCommand.Add(command);
        }

        // go back to last position for undo function, when move 0.5f, it save for go back 0.5f
        public override void Undo(Transform myObj)
        {
            myObj.Translate(myObj.forward * 0.5f);
        }

        // move object for 0.5f
        public override void Move(Transform myObj)
        {
            myObj.Translate(-myObj.forward * 0.5f);
        }
    }

    public class MoveLeft : Command
    {
        // call function for object move left and save for command
        public override void Execute(Transform myObj, Command command)
        {
            // move object
            Move(myObj);

            // save this command for undo function
            CommandPattern.preCommand.Add(command);
        }

        // go back to last position for undo function, when move 0.5f, it save for go back 0.5f
        public override void Undo(Transform myObj)
        {
            myObj.Translate(myObj.right * 0.5f);
        }

        // move object for 0.5f
        public override void Move(Transform myObj)
        {
            myObj.Translate(-myObj.right * 0.5f);
        }
    }

    public class MoveRight : Command
    {
        // call function for object move right and save for command
        public override void Execute(Transform myObj, Command command)
        {
            // move object
            Move(myObj);

            // save this command for undo function
            CommandPattern.preCommand.Add(command);
        }

        // go back to last position for undo function, when move 0.5f, it save for go back 0.5f
        public override void Undo(Transform myObj)
        {
            myObj.Translate(-myObj.right * 0.5f);
        }

        // move object for 0.5f
        public override void Move(Transform myObj)
        {
            myObj.Translate(myObj.right * 0.5f);
        }
    }

    // undo function
    public class Undo : Command
    {
        // press key for calling function
        public override void Execute(Transform myObj, Command command)
        {
            // create and save commands list for each time press key to call function for undo
            List<Command> preCommand = CommandPattern.preCommand;

            if (preCommand.Count > 0)
            {
                // last command is the end of command list - 1 because last command should go back previous command
                Command latestCommand = preCommand[preCommand.Count - 1];

                // object goes to last command
                latestCommand.Undo(myObj);

                // after go back previous command and remove last command in the end of list
                preCommand.RemoveAt(preCommand.Count - 1);
            }
        }
    }
}