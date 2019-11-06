using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Monster_enum
{
    Daemon,fairy,cat,witch,
}

public class MonsterManager : MonoBehaviour
{
    private Dictionary<Monster_enum,GameObject> monsters = new Dictionary<Monster_enum, GameObject>();
    private Monster_enum[,] monster_tile = new Monster_enum[MapManager.map_width, MapManager.map_height];

    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = Resources.Load("Prefabs/Monsters/daemon", typeof(GameObject)) as GameObject;
        monsters.Add(Monster_enum.Daemon, prefab);
        this.CreateMonster(new Vector3(1, 7, 0), Monster_enum.Daemon);
    }

    void CreateMonster(Vector3 vector, Monster_enum monster_name)
    {
        Instantiate(monsters[monster_name], vector, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
