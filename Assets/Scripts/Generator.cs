using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Regenerate creature every 30 seconds
    public bool auto = true;
    public float autoGenerateTime = 30;

    private GameObject parent;
    private GameObject left;
    private GameObject right;

    public List<GameObject> shapes;
    private Object[] materials;

    // Start is called before the first frame update
    void Start()
    {
        // regenerate creature
        if (auto)
        {
            InvokeRepeating("GenerateShapes", 0.0f, autoGenerateTime);
        }

        // load materials from Resources folder
        materials = Resources.LoadAll("Materials", typeof(Material));
    }

    void GenerateShapes()
    {
        // clear for new creature
        Destroy(parent);

        // choose random material
        // Material material = (Material)materials[Random.Range(0, materials.Length)];

        // Skeleton 
        parent = new GameObject();
        left = new GameObject();
        right = new GameObject();

        parent.name = "Creature (Parent)";
        left.name = "left";
        right.name = "right";

        // set parent
        left.transform.parent = parent.transform;
        right.transform.parent = parent.transform;

        // loop to generate creature parts
        for (int i = 0; i < 10; i++)
        {

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
