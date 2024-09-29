using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReader : MonoBehaviour
{
    //string _myData;

    [SerializeField]
    private ObjectDB _objectdb;

    private List<string> entitiesName = new List<string>{};
    
    private void Awake() {
        // 실행 시 마다 "ObjectDB"를 리셋
        _objectdb.Entities = new List<ObjectDBEntity>{};

        // "YongsanData8.csv", "yongsanData_description" 파일 읽기
        List<Dictionary<string, object>> objectData = CSVReader.Read("YongsanData8");
        List<string> descriptions = TextReader.Descriptions("yongsanData_description");

        entitiesName = new List<string>(objectData[0].Keys);

        // 각 인덱스에 포함된 데이터 가져와서 "ObjectDB" 에 추가
        for(var i = 0; i < objectData.Count; i++){

            ObjectDBEntity _entity = new ObjectDBEntity();


            _entity.ProjectName = objectData[i]["Title"].ToString();
            _entity.Nickname = objectData[i]["Nickname"].ToString();
            _entity.Description = descriptions[i];
            _objectdb.Entities.Add(_entity);
        }
    }
}
