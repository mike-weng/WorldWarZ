using UnityEngine;
using System.Collections;

public class Moon : MonoBehaviour {

    public Color color;

    //void Update()
    //{
     //   Debug.Log(this.GetWorldPosition());
    //}

    public Vector3 GetWorldPosition()
    {
        return this.transform.position;
    }
}
