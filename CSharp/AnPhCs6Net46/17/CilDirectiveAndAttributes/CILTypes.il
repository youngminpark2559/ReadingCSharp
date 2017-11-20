//c Add a reference for mscorlib.dll by using assembly directives. Since this is strongly type assembly located in GAC, you should add the publickeytoken. Actually, you can omit this reference for mscorlib.dll, because it's automaticall referenced.
//c Use ver directives to specify version in the scope of assembly declaration.

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