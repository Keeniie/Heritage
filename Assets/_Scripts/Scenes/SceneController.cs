using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SceneController", menuName = "Controllers/SceneController", order = 1)]
public class SceneController : ScriptableObject {

	public List<Scene> scenes;
}
