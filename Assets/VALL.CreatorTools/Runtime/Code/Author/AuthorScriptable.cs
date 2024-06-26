using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "new Author", menuName = "Vall/Author", order = 1)]
public class AuthorScriptable : ScriptableObject {

    [SerializeField] string guid;
    public string givenName;
    public Sprite img;
    public Guid id => new Guid(guid);

    [FormerlySerializedAs("loc")]
    public LocalizedString info;
}