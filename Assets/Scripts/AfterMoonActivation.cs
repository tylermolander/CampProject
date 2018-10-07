using UnityEngine;
using UnityEngine.SceneManagement;
 
public class AfterMoonActivation : MonoBehaviour
{
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("InTent", LoadSceneMode.Single);
    }
}
