using UnityEngine;
using System.Collections;

public class TerrainShading : MonoBehaviour {

    public Moon moon;
    public Terrain terrain;

	// Use this for initialization
	void Start () {
        terrain = (Terrain)GetComponent(typeof(Terrain));
	}
	
	// Update is called once per frame
	void Update () {
        if (terrain.materialType.Equals(Terrain.MaterialType.Custom))
        {
            terrain.materialTemplate.SetColor("_PointLightColor", this.moon.color);
            terrain.materialTemplate.SetVector("_PointLightPosition", this.moon.GetWorldPosition());
        }
	}
}
