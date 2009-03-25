.module TEST.exe
.assembly TEST
{ .hash algorithm 0x00008004 .ver 0:0:0:0 }
.assembly extern mscorlib
{
.publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
.ver 2:0:0:0
}
.namespace TEST {
.class public TEST {
.field static private bool $BodyInitialized

// Begin MetaAccessorsForType
// End MetaAccessorsForType
.method static assembly void TestProc (int32 & x) {
.maxstack 30
.locals init ()
  ldarg 0
  ldc.i4 3
  stind.i4 
  ret 
}
// Begin FixDelegateProcs
// End FixDelegateProcs
.method static public void $OberonBody () {
.maxstack 30
.entrypoint
  ldsfld bool TEST.TEST::$BodyInitialized
  brfalse L$InitBody
  ret
  L$InitBody:
  ldc.i4 1
  stsfld bool TEST.TEST::$BodyInitialized
   // Begin of initialization of module-variables.
   // End of initialization of module-variables.
  ret 
}
}
}
