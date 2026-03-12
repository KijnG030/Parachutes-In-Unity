using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public string sceneName;

	// Veranderd de scene naar de scene die is gekoppeld aan "sceneName"
	public void ChangeScene()
    {
		ScoreManager.score = 0;
		SceneManager.LoadScene(sceneName);
    }

    
}
