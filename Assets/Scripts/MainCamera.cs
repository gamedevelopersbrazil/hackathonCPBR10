using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCamera : MonoBehaviour {

    public GameObject screen1;
    public GameObject screen2;
    public float waiting;
    private void Start()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    private void Update()
    {
        waiting += Time.deltaTime;
        Debug.Log("Valor" + waiting);
        if(waiting >= 2.5)
        {
            screen1.SetActive(false);
            screen2.SetActive(true);
        }

        if(waiting >= 5)
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
    }
}
