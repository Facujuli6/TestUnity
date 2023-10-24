using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CharacterTests
{
    [UnityTest]
    public IEnumerator TestPlayerMoves()
    {
        GameObject characterInstance = GameObject.Instantiate(character, Vector3.zero, Quaternion.identity);
        Press(keyboard.upArrowKey); 
        yield return new WaitForSeconds(1f);
        Release(keyboard.upArrowKey); 
        yield return new WaitForSeconds(1f);
        Assert.That(characterInstance.transform.GetChild(0).transform.position.z, Is.GreaterThan(1.5f));
    }
}
