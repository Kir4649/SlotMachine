using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBottn : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Main");
    }
}
