using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Variable<T>: ScriptableObject
{
    public T Value;
}

[CreateAssetMenu(fileName = "new Float Variable", menuName = "Variables/float")]
public class FloatVariable:Variable<float>
{

}

[CreateAssetMenu(fileName = "new String variable", menuName = "Variables/string")]
public class Stringvariable : Variable<string>
{

}