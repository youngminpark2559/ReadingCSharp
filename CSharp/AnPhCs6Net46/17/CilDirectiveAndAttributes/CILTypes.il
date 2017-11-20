//c Add a reference for mscorlib.dll by using assembly directives. Since this is strongly type assembly located in GAC, you should add the publickeytoken. Actually, you can omit this reference for mscorlib.dll, because it's automatically referenced.
//c Use ver directives to specify version in the scope of assembly declaration.
//c Use module directives to specify the assembly name to CILTypes.dll.
//c Add a namespace by using namespace directives, with specifying its name.
//c Add a nested namespace by adding a root namespace, MyCompany.
//c Add a class, MyBaseClass by using class directives in MyNamespace namespace. When you omit the base class, every class inherits from System.Object class.
//c Add an interface, IMyInterface, by using class directives and interface attribute. MyBaseClass implements IMyInterface interface.
//c Make an interface hierarchies. IMyOtherInterface implements IMyInterface.
//c Add a structure. When you do this, you should inherits from System.ValueType class from mscorlib.dll and notate sealed to prevent other type from inheriting this structure. // When you want to declare a structure in simple way, you should use value attribute. And then this is automatically inherited by System.ValueType as a base class.

.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 4:0:0:0
}

// Our assembly.
.assembly CILTypes
{
  .ver 1:0:0:0
}

// The module of our single-file assembly.
.module CILTypes.dll



.namespace MyCompany
{
  .namespace MyNamespace {}
}


// Defining a nested namespace.
//.namespace MyCompany.MyNamespace {}


// This will not compile!
//.namespace MyNamespace
//{
//  .class public MyBaseClass {}
// 
//  .class public MyDerivedClass
//    extends MyBaseClass {}
//}

// Better!
.namespace MyNamespace
{
  // An interface definition.
  .class public interface IMyInterface {}
 
 .class public interface IMyOtherInterface
  implements MyNamespace.IMyInterface {}

  // A simple base class.
  .class public MyBaseClass {}
 
  // MyDerivedClass now implements IMyInterface,
  // and extends MyBaseClass.
  .class public MyDerivedClass extends MyNamespace.MyBaseClass implements MyNamespace.IMyInterface 
	{
	
	}
}


// A structure definition is always sealed.
//.class public sealed MyStruct extends [mscorlib]System.ValueType
//{
//
//}

// Shorthand notation for declaring a structure.
.class public sealed value MyStruct{}

// An enum.
//.class public sealed MyEnum extends [mscorlib]System.Enum
//{
//
//}


// Enum shorthand.
.class public sealed enum MyEnum{}

// In C#: List<int> myInts = new List<int>();
newobj instance void class [mscorlib]System.Collections.Generic.List`1<int32>::.ctor()


// In C#: Dictionary<string, int> d = new Dictionary<string, int>();
newobj instance void class [mscorlib]System.Collections.Generic.Dictionary`2<string,int32>::.ctor()


// In C#: List<List<int>> myInts = new List<List<int>>();
newobj instance void class [mscorlib]System.Collections.Generic.List`1<class>[mscorlib]System.Collections.Generic.List`1<int32>>::.ctor()


