//c Add a reference for mscorlib.dll by using assembly directives. Since this is strongly typed assembly located in the GAC, you should add the publickey token by using publickeytoken directives. Actually, you can omit this reference for mscorlib.dll, because it's automatically referenced.
//c Use ver directives to specify the version of this assembly in the scope of assembly declaration.
//c Use module directives to specify the assembly name to CILTypes.dll.
//c Add a namespace by using namespace directives, with specifying its name.
//c Add a nested namespace by adding a root namespace, MyCompany.
//c Add a class, MyBaseClass by using class directives in MyNamespace namespace. When you omit the base class, every class inherits from System.Object class.
//c Add an interface, IMyInterface, by using class directives and interface attribute. MyBaseClass implements IMyInterface interface.
//c Make interface hierarchies. IMyOtherInterface implements IMyInterface.. IMyOtherInterface implements IMyInterface.
//c Add a structure. When you do this, you should inherits from System.ValueType class from mscorlib.dll and notate sealed to prevent other type from inheriting this structure. // When you want to declare a structure in simple way, you should use value attribute. And then this is automatically inherited by System.ValueType as a base class.
//c Add enum members by using field directives, literal, valuetype attributes.
//c Update MyBaseClass, with adding field by private modifier.
//c Add a custom constructor by using ctor directives and instance attributes, which means this constructor is used within instance level, not the static level. static level constructor is decorated by cctor directives.
//c Add a property in the class.
//c Use method directives. Specify the parameter by int32 for inputInt. int32& means it's a "ref parameter" in int32 for refInt. class token means it's a "reference type parameter" and its type is System.Collections.ArrayList from mscorlib.dll for ar. For "out parameter", we also use "&" character like "ref parameter" and also use [out] token to indicate it's an "out parameter" for outputInt.

.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 4:0:0:0
}

//This is our assembly that we're creating.
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

  .class public MyBaseClass
{
  .field private string stringField = "hello!"
  .field private int32 intField = int32(42)

  
  .method public hidebysig specialname rtspecialname
    instance void .ctor(string s, int32 i) cil managed
  {
    // TODO: Add implementation code...
  }

  //Declare TheString property, whose process needs 3 steps, get/set/property.
  
  //This is the method using method directives but also decorated by specialname. This method is for property, which plays a role of the getter.
.method public hidebysig specialname
    instance string get_TheString() cil managed
  {
    // TODO: Add implementation code...
  }
 //This is the method using method directives but also decorated by specialname. This method is for property, which plays a role of the setter.
  .method public hidebysig specialname
    instance void set_TheString(string 'value') cil managed
  {
    // TODO: Add implementation code...
  }
 
 //This is the property by using property directives, inside of this, there are get and set directives which are mapping to method decorated by specialname from above code.
 .property instance string TheString()
  {
    .get instance string
      MyNamespace.MyBaseClass::get_TheString()
	.set instance void
      MyNamespace.MyBaseClass::set_TheString(string)
  }


  //The mothod and its parameters and parameter type in C#, which I want to implement.
public static void MyMethod(int inputInt,
  ref int refInt, ArrayList ar, out int outputInt)
{
  outputInt = 0; // Just to satisfy the C# compiler...
}



.method public hidebysig static void MyMethod(int32 inputInt,
  int32& refInt,
  class [mscorlib]System.Collections.ArrayList ar,
  [out] int32& outputInt) cil managed
{
  ...
}


}
 
  // MyDerivedClass now implements IMyInterface,
  // and extends MyBaseClass.
  .class public MyDerivedClass extends MyNamespace.MyBaseClass implements MyNamespace.IMyInterface 
	{
	
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

.class public sealed enum MyEnum
{
  .field public static literal valuetype
   MyNamespace.MyEnum A = int32(0)
  .field public static literal valuetype
   MyNamespace.MyEnum B = int32(1)
  .field public static literal valuetype
   MyNamespace.MyEnum C = int32(2)
}

// In C#: List<int> myInts = new List<int>();
newobj instance void class [mscorlib]System.Collections.Generic.List`1<int32>::.ctor()


// In C#: Dictionary<string, int> d = new Dictionary<string, int>();
newobj instance void class [mscorlib]System.Collections.Generic.Dictionary`2<string,int32>::.ctor()


// In C#: List<List<int>> myInts = new List<List<int>>();
newobj instance void class [mscorlib]System.Collections.Generic.List`1<class>[mscorlib]System.Collections.Generic.List`1<int32>>::.ctor()

}
