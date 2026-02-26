using UnityEngine;

public class Move : MonoBehaviour 
{

    public GameObject goal;
    Vector3 direction;
    float speed = 3f;

    void Start() 
    {

        //direction = goal.transform.position - this.transform.position;
        
        //this.transform.Translate(direction);
    }

    private void LateUpdate() 
    {
        direction = goal.transform.position - this.transform.position;
        if(direction.magnitude > 1.5)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
