using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void EndGame()
    {

        if(gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);

        }


    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // haritalari yukelemek icin. Or: SampleScene

    }

}
