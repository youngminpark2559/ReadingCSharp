//c Add external assembly to reference it. At this, you will use System.Windows.Forms library.
//c Update Main() method to show the message by using Windows.Forms.MessageBox.

// Referenced assemblies..
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 4:0:0:0
}
 
 .assembly extern System.Windows.Forms
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
  .ver 4:0:0:0
}

// Our assembly.
.assembly HelloProgram
{
  /**** TargetFrameworkAttribute data removed for clarity! ****/
 
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module HelloProgram.exe
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003
.corflags 0x00000003
 
// Definition of Program class.
.class private auto ansi beforefieldinit Program
  extends [mscorlib]System.Object
{
  .method private hidebysig static void Main(string[] args) cil managed
{
  .entrypoint
  .maxstack 8
 
  ldstr "CIL is way cool"
  call valuetype [System.Windows.Forms]
    System.Windows.Forms.DialogResult
    [System.Windows.Forms]
  System.Windows.Forms.MessageBox::Show(string)
  pop
  ret
}
 
  // The default constructor.
  .method public hidebysig specialname rtspecialname
    instance void .ctor() cil managed
 {
    .maxstack 8
    IL_0000: ldarg.0
    IL_0001: call instance void [mscorlib]System.Object::.ctor()
    IL_0006: ret
  }
}