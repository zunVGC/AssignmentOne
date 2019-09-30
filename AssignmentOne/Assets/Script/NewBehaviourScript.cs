using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    
    // Start is called before the first frame update
    void Start()
    {
        badguy badguy1 = new badguy("0", "badguy1");

        badguy badguy2 = (badguy)badguy1.clone();

        badguy2.Attack();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public abstract class Enemy
    {
        private string _id;
        private string _name;

        public Enemy(string id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract Enemy clone();
        public abstract void Attack();
        
    }

    public class badguy : Enemy
    {
        public badguy(string id, string name) : base(id, name)
        {

        }

        public override Enemy clone()
        {
            return (badguy)this.MemberwiseClone();
        
        }

        public override void Attack()
        {
            Debug.Log("badguy1");
            FindObjectOfType<spawner>().ss();
        }

       

    }
}
