//c Add a reference for mscorlib.dll by using assembly directives. Since this is strongly type assembly located in GAC, you should add the publickeytoken. Actually, you can omit this reference for mscorlib.dll, because it's automaticall referenced.
//c Use ver directives to specify version in the scope of assembly declaration.
//c Use module directives to specify the assembly name to CILTypes.dll.
//c Add a namespace by using namespace directives, with specifying its name.
//c Add a nested namespace by adding a root namespace, MyCompany.
//c Add a class, MyBaseClass by using class directives in MyNamespace namespace. When you omit the base class, every class inherits from System.Object class.
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


.namespace MyNamespace
{
  // System.Object base class assumed.
  .class public MyBaseClass {}
}