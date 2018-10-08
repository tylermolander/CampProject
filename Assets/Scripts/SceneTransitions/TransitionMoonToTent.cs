using UnityEngine;
using UnityEngine.SceneManagement;
 
public class TransitionMoonToTent : MonoBehaviour
{
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("InTent", LoadSceneMode.Single);
    }
}
