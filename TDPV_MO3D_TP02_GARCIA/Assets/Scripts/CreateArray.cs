using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArray : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabObject;
    public int sizeX;
    public int sizeY;

    public int currentX;
    public int currentY;

    private Vector3 start;
    private Vector3 next;
    private Vector3 partDimensions;

    void Start()
    {
        // Calcula las dimensiones totales del prefab (incluyendo cubos y esferas)
        partDimensions = CalculateTotalDimensions(prefabObject);
        currentX = 0;
        currentY = 1;
        start = new Vector3(0, 0, 0); // Determina la posición inicial de los bloques
        next = start; // Inicializa la posición actualizada
    }

    private Vector3 CalculateTotalDimensions(GameObject prefab)
    {
        Renderer[] childRenderers = prefab.GetComponentsInChildren<Renderer>();

        Vector3 totalDimensions = Vector3.zero;

        // Calcula las dimensiones totales sumando las dimensiones de todos los renderers
        foreach (Renderer childRenderer in childRenderers)
        {
            totalDimensions += childRenderer.bounds.size;
        }

        return totalDimensions;
    }

    void Update()
    {
        if (currentX < sizeY)
        {
            // Instancia el prefab en la próxima posición
            Instantiate(prefabObject, next, Quaternion.identity);
            next.x += partDimensions.x;
            currentX++;
        }
        else
        {
            if (currentY < sizeX)
            {
                // Reinicia la posición en X y asigna la posición en Y
                next.x = start.x;
                next.y += partDimensions.y / 2;
                Instantiate(prefabObject, next, Quaternion.identity);
                currentX = 1;
                next.x += partDimensions.x;
                currentY++;
            }
        }
    }

    // Calcula las dimensiones totales del prefab combinado
  
}
