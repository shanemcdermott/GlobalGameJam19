using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTarget : DirectionalMovement
{
    public Transform target;
    private TargetNode targetNode;
    
    public float acceptableDistance = .5f;


    public void SetTarget(TargetNode newTargetNode)
    {
        SetTarget(newTargetNode.transform);
    }
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
        if(target)
        {
            targetNode = target.gameObject.GetComponent<TargetNode>();
        }
    }
    public override void Move()
    {
        if(target)
        {           
            Vector2 relativePosition = target.position - transform.position;
            
            float angle = 0;
            if(Mathf.Abs(relativePosition.x) > Mathf.Abs(relativePosition.y))
            {
                angle = 90;
                if(relativePosition.x<0)
                angle = -90;
            }
            else if(relativePosition.y<0)
            {
                angle = 180;
            }
            

            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target.position, speed * Time.deltaTime);
            
            float distance = Vector2.Distance(target.position, transform.position);
            if(distance <= acceptableDistance && targetNode != null)
            {
                SetTarget(targetNode.nextNode);
            }
          //transform.rotation = Quaternion.LookRotation(relativePosition);
        }
        else
        {
            base.Move();
        }
    }
}
