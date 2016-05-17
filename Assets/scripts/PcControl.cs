using UnityEngine;
using System.Collections;

public class PcControl : MonoBehaviour {

    private Rigidbody bd;

    [SerializeField]
    private float Speed = 1.0f;

	// Use this for initialization
	void Start () {

        bd = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {

        float depth = 0.0f;
        if(Input.GetKey(KeyCode.Z))
           depth = 1.0f;
        else if (Input.GetKey(KeyCode.X))
            depth = -1.0f;

        bd.velocity = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            depth) * Time.deltaTime * Speed;
	
	}
}
