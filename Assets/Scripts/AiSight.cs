using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class AiSight : MonoBehaviour {
    public GameObject anObject;
    public Collider anObjCollider;
    public Camera cam;
    private Plane[] planes;
    public bool isInSight=false;
    public ThirdPersonCharacter character { get; private set; }

    void Start()
    {
        planes = GeometryUtility.CalculateFrustumPlanes(cam);
        
        if(!anObjCollider)
        {
            anObjCollider =character.GetComponent<Collider>();
        }
        

    }
    void Update()
    {
        //If Character is in enemy camera sight then isInSight variable be true
        if (GeometryUtility.TestPlanesAABB(planes, anObjCollider.bounds))
        {       
            isInSight = true;
        }
        else
        {     
            isInSight = false;
        }
    }

}
