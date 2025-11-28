using UnityEngine;

public class Bottn : MonoBehaviour
{
    public Controller controller;

    void Start()
    {
        controller = GameObject.Find("Controller").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            controller.stopReel();
        }
        if (Input.GetKey(KeyCode.S))
        {
            controller.stopReel2();
        }
        if (Input.GetKey(KeyCode.D))
        {
            controller.stopReel3();
        }
        if (Input.GetKey(KeyCode.R))
        {
            controller.Resst();
        }
    }

}
