using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public virtual void GameOver()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
