using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEnum : MonoBehaviour
{
    public enum ListOfInputs
    {
        If,
        equals,
        notEquals,
        Null,
        Print,
        send,
        help,
        Void
    }
    public ListOfInputs input;
}