using UnityEngine;

public class Ingredient : MonoBehaviour
{
    // Class variables
    [field: SerializeField] public string ingredientName { get; set; } = "";
    [field: SerializeField] public int temperature {get; set; } = 0;
    [field: SerializeField] public int consistency { get; set; } = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
