using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CannonScript : MonoBehaviour
{

    public float SENS_HOR = 3.0F;
    public float SENS_VER = 2.0F;

    public Rigidbody cannonballInstance;

    public float initialForce = 15;
    public float pitchSpeed = 10.0F;
    public float pitchAngle;
    public float range;
    RaycastHit hitInfo;

    // Start is called before the first frame update
    void Start()
    {
        initialForce = 15;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone = Instantiate(cannonballInstance, transform.position, transform.rotation);
            clone.AddForce(transform.forward * initialForce, ForceMode.Impulse);
        }

        float rX = Input.GetAxis("Vertical") * Time.deltaTime * pitchSpeed;
        transform.Rotate(-rX, 0, 0);
        pitchAngle = 360 - transform.rotation.eulerAngles.x;

        var mouseMove = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mouseMove = Vector2.Scale(mouseMove, new Vector2(SENS_HOR, SENS_VER));
        //cannon.transform.Rotate(0, mouseMove.x, 0);
        transform.Rotate(-mouseMove.y, 0, 0);
    }

}
