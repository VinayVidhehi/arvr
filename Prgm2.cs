using UnityEngine;
using UnityEngine.UI;

public class Prgm2 : MonoBehaviour
{
    public GameObject cube, sphere, plane;  // Assign objects in the Inspector
    public Material newCubeMaterial, newSphereMaterial, newPlaneMaterial;  // New materials
    public Texture newCubeTexture, newSphereTexture, newPlaneTexture;  // New textures

    // Function to change material
    public void ChangeMaterial(GameObject obj, Material newMaterial)
    {
        Renderer objRenderer = obj.GetComponent<Renderer>();
        objRenderer.material = newMaterial;
    }

    // Function to change texture
    public void ChangeTexture(GameObject obj, Texture newTexture)
    {
        Renderer objRenderer = obj.GetComponent<Renderer>();
        objRenderer.material.mainTexture = newTexture;
    }

    // Function to change color
    public void ChangeColor(GameObject obj, Color color)
    {
        Renderer objRenderer = obj.GetComponent<Renderer>();
        objRenderer.material.color = color;
    }

    // Function to change material for all objects
    public void ChangeAllMaterials()
    {
        ChangeMaterial(cube, newCubeMaterial);
        ChangeMaterial(sphere, newSphereMaterial);
        ChangeMaterial(plane, newPlaneMaterial);
    }

    // Function to change texture for all objects
    public void ChangeAllTextures()
    {
        ChangeTexture(cube, newCubeTexture);
        ChangeTexture(sphere, newSphereTexture);
        ChangeTexture(plane, newPlaneTexture);
    }

    // Function to change color for all objects
    public void ChangeAllColors()
    {
        ChangeColor(cube, Color.red);
        ChangeColor(sphere, Color.green);
        ChangeColor(plane, Color.blue);
    }
}