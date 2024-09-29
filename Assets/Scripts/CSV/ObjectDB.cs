using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectData", menuName = "Scriptable Object/ObjectData", order = int.MaxValue)]
//출처: https://wergia.tistory.com/189 [베르의 프로그래밍 노트:티스토리]
public class ObjectDB : ScriptableObject
{
    public List<ObjectDBEntity> Entities = new List<ObjectDBEntity>();
}
