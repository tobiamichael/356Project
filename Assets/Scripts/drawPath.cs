using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawPath : MonoBehaviour
{
    Vector3[] plotline3d;
    private LineRenderer myline;
    public int ballVelocity = 15;

    Rigidbody cannon3D;
    Vector3 velociiity;
    Vector3[] plotline;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        velociiity.x = ballVelocity;
        velociiity.y = 0;
        velociiity.z = 0;
        */

        

        myline = this.GetComponent<LineRenderer>();
        cannon3D = this.GetComponent<Rigidbody>();

        velociiity = cannon3D.transform.forward * ballVelocity;

        plotline = Plot(cannon3D, cannon3D.position, velociiity, 1000);

        myline.positionCount = plotline.Length;

        myline.SetPositions(plotline);
    }

    public static Vector3[] Plot(Rigidbody rigidbody, Vector3 pos, Vector3 velocity, int steps)
    {
        Vector3[] results = new Vector3[steps];

        float timestep = Time.fixedDeltaTime / Physics.defaultSolverVelocityIterations;
        Vector3 gravityAccel = Physics.gravity * 1 * timestep * timestep;
        float drag = 1f - timestep * rigidbody.drag;
        Vector3 moveStep = velocity * timestep;

        for (int i = 0; i < steps; ++i)
        {
            moveStep += gravityAccel;
            moveStep *= drag;
            pos += moveStep;
            results[i] = pos;
        }

        return results;
    }

}
