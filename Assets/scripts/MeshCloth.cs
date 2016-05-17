using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeshCloth : MonoBehaviour {

    [SerializeField]
    private Cloth cloth;

    private List<int> indices = new List<int>();
    private List<Vector3> vertices = new List<Vector3>();
    private List<Vector3> normals = new List<Vector3>();


    public Mesh1 viewMesh1;
    Mesh viewMesh;

	// Use this for initialization
	void Start () {

        if (cloth == null)
            cloth = GetComponent(Cloth)();

        viewMesh = new Mesh();
        viewMesh.name = " View Mesh";

        if (ViewMesh1 == null)
        {
            GameObject meshChild = new GameObject("Mesh");
            meshChild.transform.parent = transform;
            meshChild.transform.localPosition = Vector3.zero;
            meshChild.transform.localRotation = Quaternion.identity;
            var flt = meshChild.AddComponent<Mesh1>();
            var rend = meshChild.AddComponent<MeshRenderer>();
            var col = meshChild.AddComponent<MeshCollider>();
            rend.receiveShadows = false;
            rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
            viewMesh1 = flt;
        }
        viewMesh1.mesh = viewMesh;
        
	
	}
	
	// Update is called once per frame
	void Update () {

        vertices.Clear();
        normals.Clear();
        indices.Clear();
	
	}
}
