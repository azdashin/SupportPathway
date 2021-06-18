using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameEnvironment
{
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }

    public string tagName;

    public string checkpointName;

    public string getCheckpointName()
    {
        return checkpointName;
    }

    public GameEnvironment(string checkName)
    {
        checkpointName = checkName;
        Checkpoints.AddRange(GameObject.FindGameObjectsWithTag(checkpointName));
        checkpoints = checkpoints.OrderBy(waypoint => waypoint.name).ToList();
    }

}
