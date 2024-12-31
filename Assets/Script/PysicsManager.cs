using UnityEngine;

public class PysicsManager : MonoBehaviour
{
    public PysicsObject[] pysicsObjects;

    void Start()
    {
        pysicsObjects = GetComponents<PysicsObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
