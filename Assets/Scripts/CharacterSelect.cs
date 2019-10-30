using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{

    // Make sure all models and sprites are the same size

    // List of Character prefabs
    public List<GameObject> characters;

    public GameObject currentPlayer;

    // Select the Player GameObject
    [SerializeField]
    private GameObject player;
    // Change the Mesh Filter
    private Mesh selectedPlayerMesh;
    // Change the material
    private Material selectedPlayerMaterial;
    




    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
            player = GameObject.FindWithTag("Player");

        // Set the Current character to the first in the list
        currentPlayer = characters[0];

        GetSelectedPlayer(currentPlayer);

        SetPlayer(selectedPlayerMesh, selectedPlayerMaterial);
    }

    private void GetSelectedPlayer(GameObject selected)
    {
        // Get the mesh Character mesh
        selectedPlayerMesh = selected.GetComponent<MeshFilter>().sharedMesh;
        selectedPlayerMaterial = selected.GetComponent<Renderer>().sharedMaterial;
    }

    private void SetPlayer(Mesh mesh, Material mat)
    {
        
        // Set the player
        player.GetComponent<MeshFilter>().mesh = mesh;
        player.GetComponent<Renderer>().material = mat;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentPlayer = characters[0];
            GetSelectedPlayer(currentPlayer);
            SetPlayer(selectedPlayerMesh, selectedPlayerMaterial);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentPlayer = characters[1];
            GetSelectedPlayer(currentPlayer);
            SetPlayer(selectedPlayerMesh, selectedPlayerMaterial);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentPlayer = characters[2];
            GetSelectedPlayer(currentPlayer);
            SetPlayer(selectedPlayerMesh, selectedPlayerMaterial);
        }
    }


}
