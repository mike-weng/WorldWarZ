using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour {
    private Terrain terrain;
    public float spawnTime = 10f;
    public int numPerSpawn = 5;
    public GameObject zombie;
    public float spawnRange = 100;
    // Use this for initialization
    void Start () {
        terrain = FindObjectOfType<Terrain>();
        InvokeRepeating("SpawnZombie", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void SpawnZombie() {
        PlayerCharacter player = FindObjectOfType<PlayerCharacter>();
        for (int i = 0; i < numPerSpawn; i++) {
            float maxX = player.transform.position.x + spawnRange;
            float minX = player.transform.position.x - spawnRange;
            float maxZ = player.transform.position.z + spawnRange;
            float minZ = player.transform.position.z - spawnRange;
            float x = Random.Range(minX, maxX);
            float z = Random.Range(minZ, maxZ);
            float y = 4.0f;
            Instantiate(zombie, new Vector3(x, y, z), Quaternion.identity);
        }
    }
}
