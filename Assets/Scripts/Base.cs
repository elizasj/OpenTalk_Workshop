using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Regenerate creature every 30 seconds
    public bool auto = true;
    public float autoGenerateTime = 30;

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

        materials = Resources.LoadAll("Materials", typeof(Material));
    }

    void GenerateShapes()
    {
        Material material = (Material)materials[Random.Range(0, materials.Length)];

        for (int i = 0; i < 10; i++)
        {

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
