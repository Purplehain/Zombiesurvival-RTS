using UnityEngine;
using System.Collections;

[RequireComponent(typeof (MeshFilter), typeof(MeshRenderer))]
public class WorldGenerator : MonoBehaviour {

    public int sizeX, sizeY;

    void Awake( ) {
        GenerateGrid();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private Vector3[] vertices;
    void GenerateGrid( ) {
        vertices = new Vector3[(sizeX + 1) * (sizeY + 1)];
        for (int i = 0, y = 0 ; y <= sizeY ; y++ ) {
            for (int x = 0 ; x <= sizeX ;  x++, i++ ) {
                vertices[i] = new Vector3( x , y );
            }
        }
    }
    private void OnDrawGizmos( ) {
        if(vertices == null ) {
            return;
        }
        Gizmos.color = Color.black;
        for(int i = 0 ; i < vertices.Length ; i++ ) {
            Gizmos.DrawSphere( vertices[i] , 0.1f );
        }
    }

    void GenerateStreets( ) {

    } 

    void GenerateBuildings( ) {

    }

    void GenerateRessources( ) {

    }

}
