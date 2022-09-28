
using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private AnimationCurve curve;

    public Transform startMarker;
    public Transform endMarker;


    public float speed = 1.0F;

    private float startTime;


    private float journeyLength;

    void Start()
    {
      
        startTime = Time.time;

     
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    // Move to the target end position.
    void Update()
    {
       
        float distCovered = (Time.time - startTime) * speed;
   
        float fractionOfJourney = distCovered / journeyLength;
   
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, curve.Evaluate(fractionOfJourney));
         
       
    }
}