using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public static bool GameIsPaused = false; //���������� ���� �� �� �����
    public GameObject loseMenuUI; //����, ��� ���������

    void Update()
    {
        // ��� ������� �� �����, ����� ������ ���� ���������
		if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject(0))
		{
            // ���� �� ��� �� ���������� �� � = -1.35f
            if (transform.position.y == -1.35f)
            {
                // ����� ������ ���� � ���������� �� 1.17 (�.� ����)
                transform.position = new Vector3(transform.position.x, 1.27f, transform.position.z);
            }
            // ���� �� ��� ����, �.� �� ���������� 1.27
            else if (transform.position.y == 1.27f)
            {
                // �� ������������ ���� �������
                transform.position = new Vector3(transform.position.x, -1.35f, transform.position.z);
            }
		}
    }

    // ��� ������ ����� �������� �� ������ �����, �������� ���� ��������� 
	private void OnCollisionEnter2D(Collision2D collision)
	{
        LoseMenu();
	}
    // � ������� ����� ��������������� � �����, ���� ������ ����, ���� ����� � ������� ����
    public void LoseMenu()
    {
        loseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
