using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int someField; // instance_fields_should_be_camel_case

    public Item(string name) // unused parameter (VS default)
    {
        someField = 3; // dotnet_style_qualification_for_field
    }

    static public Item CreateItem()
    {
        return null; // csharp_style_expression_bodied_methods
    }
}
