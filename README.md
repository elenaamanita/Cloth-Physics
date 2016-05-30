# Cloth-Physics

Cloth Simulation showing moving curtains,a table cloth and how they interact with a ball.

The environment has been created to represent a house which is the Gui window. 
All the assets for the house were created in Maya and exported to Unity.

The picture frame belongs to the artist  @Dimitris Giannakopoulos.

# Curtains Mesh

In order to have the natural movement of the curtain first i created a mesh in studio 3D Max to represent the cloth.
Therefore i created a plane where i increased the polygon counter regarding the width and the lengh.
Afterwards i created the bones that will act as the constraints points in Unity 3D.By clicking from 
the vertex where i wanted to constrained, the vertex that i want to start the bone and drag until the vertex
i wanted to stop constrained. The last step is to connect the mesh to the actual bone. Therefore i selected the
mesh and i added a skin modifier.After selecting the bones and the mesh i exported into Unity.

After drag and drop the object into the scene , i created a cloth component where i specified the constraints.
I added an external acceleration to add a bit of realism and by pressing play,the cloth is reacting as it is shown in the scene.

I added a sphere collider to demonstrate physics interaction with the cloth. You can move the sphere with the script:

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
	
	#Shader
	
	Shader "Custom/cloth_shader" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
	
	            Cull Off

	
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			half4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
	
	
	



