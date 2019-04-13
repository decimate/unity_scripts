using UnityEngine;
using UnityEditor.SceneManagement;

// Create a cube to use as the trigger, and disable the Mesh Renderer.
// Add this script to the trigger

public class SceneSwitch : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		// Method 1 - Loads the next scene
		EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + 1);
		
		// Method 2 - Loads a specific scene, based on the Build index
		// EditorSceneManager.LoadScene(1);
	}

}
