using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public GameObject loseMenuUI;
    private float y_coordinate;

    public Data data;

    void Update()
    {
        y_coordinate = transform.position.y;
        // when you click on the screen, the ball changes its position
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
		{            
            // if it was at the y coordinate = -1.35f
            if (y_coordinate == data.y_down)
            {
                // the ball changes its coordinate to 1.17 (to top)
                transform.position = new Vector3(0, data.y_up, 0);
            }
            // if it was at the y coordinate = 1.27
            else if (y_coordinate == data.y_up)
            {
                // to down
                transform.position = new Vector3(0, data.y_down, 0);
            }
		}
    }

    // if the ball hits an empty space, call the lose menu and pause the game
	private void OnCollisionEnter2D(Collision2D collision)
	{
        loseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
