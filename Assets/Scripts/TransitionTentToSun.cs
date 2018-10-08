using UnityEngine;
using UnityEngine.SceneManagement;
 
public class TransitionTentToSun : MonoBehaviour
{
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("SunRise", LoadSceneMode.Single);
    }
}
