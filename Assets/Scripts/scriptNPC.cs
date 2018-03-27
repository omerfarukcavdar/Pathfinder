using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class scriptNPC : MonoBehaviour
{
    NavMeshAgent myNevMeshAgent;
    public ThirdPersonCharacter character { get; private set; }
    public Camera myCamera;
    bool isInSight = false;
    public GameObject Enemy;
    scriptDetector myScriptDetector;

    void Start()
    {
        myScriptDetector = Enemy.GetComponent<scriptDetector>();
        myNevMeshAgent = this.GetComponent<NavMeshAgent>();
        character = GetComponent<ThirdPersonCharacter>();
        isInSight = Enemy.GetComponent<scriptDetector>().isInSightFunction();
    }
    
    private void Update()
    {
        if (myScriptDetector.isInSightFunction())
        {
            Debug.Log("Enemy Detect You !");
        }
        else
            Debug.Log("You are a ghost ;)");
        
        //This codes help us to use NavMeshAgent.
        if (Input.GetMouseButton(0))
        {
            
            Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                myNevMeshAgent.SetDestination(hit.point);
            }
        }
            
        //When character arrive the destination then his movement velocity of the x axis will be zero.
        if (myNevMeshAgent.remainingDistance > myNevMeshAgent.stoppingDistance)
            character.Move(myNevMeshAgent.desiredVelocity, false, false);
        else
            character.Move(Vector3.zero, false, false);
    }
}