using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private float mouseX;
    private float mouseY;

    public float a;
    public float b;

    private float xRotatiuon;

    public Transform Player;
    private float sensitivityMouse = 150f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivityMouse * Time.deltaTime; 
        mouseY = Input.GetAxis("Mouse Y") * sensitivityMouse * Time.deltaTime;

        a = mouseX;
        b = mouseY;

        xRotatiuon -= mouseY;
        xRotatiuon = Mathf.Clamp(xRotatiuon, -90f, 90f);

        Player.Rotate(mouseX * new Vector3(0, 1, 0));

        //transform.Rotate(-mouseY * new Vector3(1, 0, 0));
        transform.localRotation = Quaternion.Euler(xRotatiuon, 0f, 0f);
    }
}
