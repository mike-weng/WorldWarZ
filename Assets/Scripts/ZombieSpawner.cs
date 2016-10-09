using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour {
    private Terrain terrain;
    public float spawnTime = 10f;
    public int numPerSpawn = 5;
    public GameObject zombie;
    // Use this for initialization
    void Start () {
        terrain = FindObjectOfType<Terrain>();
        InvokeRepeating("SpawnZombie", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void SpawnZombie() {
        for (int i = 0; i < numPerSpawn; i++) {
            float maxX = terrain.terrainData.size.x / 2;
            float minX = -terrain.terrainData.size.x / 2;
            float maxZ = terrain.terrainData.size.z / 2;
            float minZ = -terrain.terrainData.size.z / 2;
            float x = Random.Range(minX, maxX);
            float z = Random.Range(minZ, maxZ);
            float y = 4.0f;
            Instantiate(zombie, new Vector3(x, y, z), Quaternion.identity);
        }
    }
}
