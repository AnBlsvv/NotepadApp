using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public static bool GameIsPaused = false; //изначально игра не на паузе
    public GameObject loseMenuUI; //меню, при пройгрыше

    void Update()
    {
        // при нажатии на экран, шарик меняет свое положение
		if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject(0))
		{
            // если он был на координате по у = -1.35f
            if (transform.position.y == -1.35f)
            {
                // шарик меняет свою у координату на 1.17 (т.е выше)
                transform.position = new Vector3(transform.position.x, 1.27f, transform.position.z);
            }
            // если он был выше, т.е на координате 1.27
            else if (transform.position.y == 1.27f)
            {
                // то перемещаемся вниз обратно
                transform.position = new Vector3(transform.position.x, -1.35f, transform.position.z);
            }
		}
    }

    // как только шарик попадает на пустое место, вызываем Меню пройгрыша 
	private void OnCollisionEnter2D(Collision2D collision)
	{
        LoseMenu();
	}
    // в котором время останавливается и можно, либо начать игру, либо выйти в главное меню
    public void LoseMenu()
    {
        loseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
