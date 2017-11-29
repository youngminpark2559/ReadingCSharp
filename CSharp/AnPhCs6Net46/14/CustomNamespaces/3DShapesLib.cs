// Another shape-centric namespace.
using System;

//c Add 3DShapresLib.cs file and in this file, I create a unique namespace named My3DShapes and in this namespace I create 3 classes whose class name are same with the ones in the MyShapes namespace. So, ambiguity issue is occured.

namespace My3DShapes
{
    // 3D Circle class.
    public class Circle { }

    // 3D Hexagon class.
    public class Hexagon { }

    // 3D Square class.
    public class Square { }
}