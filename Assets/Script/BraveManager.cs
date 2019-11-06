using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Brave_enum
{
    Samurai,
}

public class BraveManager : MonoBehaviour
{
    private Dictionary<Brave_enum, GameObject> braves = new Dictionary<Brave_enum, GameObject>();

    void CreateBrave(Vector3 vector, Brave_enum brave_name)
    {
        Instantiate(braves[brave_name], vector, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = Resources.Load("Prefabs/Braves/samurai", typeof(GameObject)) as GameObject;
        braves.Add(Brave_enum.Samurai, prefab);
        this.CreateBrave(new Vector3(2, 8, 0), Brave_enum.Samurai);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
