using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NullFrameworkException.Test.Core
{


    public class AttributeTests : MonoBehaviour
    {
        [Tag, SerializeField] private string playerTag;
        [Tag, SerializeField] private string finishTag = "Finish";
        
        [SerializeField, ReadOnly] private string dontTouchThis = "NO TOUCH";

        [SerializeField, SceneField] private string testLevel;


    }
}
