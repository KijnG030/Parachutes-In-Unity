using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string sceneName;

    // Veranderd de scene naar de scene die is gekoppeld aan "sceneName"
    public void ChangeScene()
    {
        ScoreManager.score = 0;
        ScoreManager.lives = 3;
        SceneManager.LoadScene(sceneName);
    }
}
