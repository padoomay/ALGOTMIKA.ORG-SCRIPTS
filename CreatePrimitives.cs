using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    private void Start()
    {
        // Создание объекта похожего на Стива
        CreateBlock(new Vector3(0, 0, 0));
        CreateBlock(new Vector3(-0.5f, 1, 0));
        CreateBlock(new Vector3(0.5f, 1, 0));
        CreateBlock(new Vector3(0.5f, 2, 0));
        CreateBlock(new Vector3(-0.5f, 2, 0));
        CreateBlock(new Vector3(0, 3, 0));
    }

    private void CreateBlock(Vector3 position)
    {
        // Создание отдельного блокаы
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = position;
    }
}
