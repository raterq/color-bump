using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Unique] public class ScreenComponent : IComponent{}
public class ScreenSizeComponent : IComponent{public Vector2 value;}