using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterZone : MonoBehaviour
{
    public int n;
    public GameObject loadingImage;
    void OnTriggerEnter(Collider col)  // ���� � ���������-������� �������-����� ��� ���������
    {
        if (col.tag.Equals("Player"))        // ���� ��� ������ � ����� "Player"
        {
            StartCoroutine(LOadingScreenOnFable());// ��������� ����� � �������� ��������
            
        }
        
    }

    IEnumerator LOadingScreenOnFable()
    {
        loadingImage.SetActive(true);
        AsyncOperation operation= SceneManager.LoadSceneAsync(n);
        Debug.Log("RUS");
       yield return operation;
        
    }
}
