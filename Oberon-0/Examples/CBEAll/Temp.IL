.namespace OSS {
.class public OSS {
.field static literal public int32 IdLen = int32(16)
.field static literal assembly int32 KW = int32(34)
.field static literal assembly int32 'null' = int32(0)
.field static literal public int32 times = int32(1)
.field static literal public int32 'div' = int32(3)
.field static literal public int32 mod = int32(4)
.field static literal public int32 'and' = int32(5)
.field static literal public int32 plus = int32(6)
.field static literal public int32 minus = int32(7)
.field static literal public int32 'or' = int32(8)
.field static literal public int32 eql = int32(9)
.field static literal public int32 neq = int32(10)
.field static literal public int32 lss = int32(11)
.field static literal public int32 geq = int32(12)
.field static literal public int32 leq = int32(13)
.field static literal public int32 gtr = int32(14)
.field static literal public int32 period = int32(18)
.field static literal public int32 comma = int32(19)
.field static literal public int32 colon = int32(20)
.field static literal public int32 rparen = int32(22)
.field static literal public int32 rbrak = int32(23)
.field static literal public int32 of = int32(25)
.field static literal public int32 then = int32(26)
.field static literal public int32 do = int32(27)
.field static literal public int32 lparen = int32(29)
.field static literal public int32 lbrak = int32(30)
.field static literal public int32 'not' = int32(32)
.field static literal public int32 becomes = int32(33)
.field static literal public int32 number = int32(34)
.field static literal public int32 ident = int32(37)
.field static literal public int32 semicolon = int32(38)
.field static literal public int32 end = int32(40)
.field static literal public int32 else = int32(41)
.field static literal public int32 elsif = int32(42)
.field static literal public int32 if = int32(44)
.field static literal public int32 while = int32(46)
.field static literal public int32 'array' = int32(54)
.field static literal public int32 'record' = int32(55)
.field static literal public int32 'const' = int32(57)
.field static literal public int32 type = int32(58)
.field static literal public int32 var = int32(59)
.field static literal public int32 procedure = int32(60)
.field static literal public int32 begin = int32(61)
.field static literal public int32 'module' = int32(63)
.field static literal assembly int32 eof = int32(64)
.field static public int32 val
.field static public char[] id
.field static public bool 'error'
.field static assembly char ch
.field static assembly int32 nkw
.field static assembly int32 errpos
.field static assembly class [Texts]Texts.Reader R
.field static assembly class [Texts]Texts.Writer W
.field static assembly string[] keyTab
.field static private bool $BodyInitialized

// Begin MetaAccessorsForType
// End MetaAccessorsForType
.method static public void Mark (char[] msg) {.maxstack 30.locals init (int32)
  ldarg 0
  ldsfld class [Texts]Texts.Reader OSS.OSS::R
  call instance int32 [Texts]Texts.Texts::Pos (class [Texts]Texts.Reader )
  ldc.i4 1
  sub 
  stloc 0
  ldloc 0
  ldsfld int32 OSS.OSS::errpos
  ble L0_29
  ldarg 0
  ldsfld class [Texts]Texts.Writer OSS.OSS::W
  ldstr "  pos "
  call instance void [Texts]Texts.Texts::WriteString (class [Texts]Texts.Writer , string )
  ldarg 0
  ldsfld class [Texts]Texts.Writer OSS.OSS::W
  ldloc 0
  ldc.i4 1
  call instance void [Texts]Texts.Texts::WriteInt (class [Texts]Texts.Writer , int32 , int32 )
  ldarg 0
  ldsfld class [Texts]Texts.Writer OSS.OSS::W
  ldstr " "
  call instance void [Texts]Texts.Texts::Write (class [Texts]Texts.Writer , string )
  ldarg 0
  ldsfld class [Texts]Texts.Writer OSS.OSS::W
  ldarg 0
  call instance void [Texts]Texts.Texts::WriteString (class [Texts]Texts.Writer , char[] )
  ldarg 0
  ldsfld class [Texts]Texts.Writer OSS.OSS::W
  call instance void [Texts]Texts.Texts::WriteLn (class [Texts]Texts.Writer )
L0_29: ldloc 0
  stsfld int32 OSS.OSS::errpos
  ldc.i4 1
  stsfld bool OSS.OSS::'error'
  ret 
}
.method static assembly void Ident () {.maxstack 30.locals init (int32, int32)
  ldc.i4 0
  stloc 0
L1_2: ldloc 0
  ldc.i4 16
  bge L1_13
  ldsfld char[] OSS.OSS::id
  ldloc 0
  ldsfld char OSS.OSS::ch
  stelem.i2 
  ldloc 0
  ldc.i4 1
  add 
  stloc 0
L1_13: ldsfld char OSS.OSS::ch
  beq L1_18
  ldsfld char OSS.OSS::ch
  bne.un L1_2
  bne.un L1_2
L1_18: ldsfld char[] OSS.OSS::id
  ldloc 0
  ldc.i4 0
  stelem.i2 
  ldc.i4 0
  stloc 1
L1_24: ldloc 1
  ldsfld int32 OSS.OSS::nkw
  bge L1_34
  ldsfld char[] OSS.OSS::id
  bne.un L1_34
  ldloc 1
  ldc.i4 1
  add 
  stloc 1
  br L1_24
L1_34: ldloc 1
  ldsfld int32 OSS.OSS::nkw
  bge L1_42
  ldsfld string[] OSS.OSS::keyTab
  ldloc 1
  ldelem.ref 
  ldfld 
  br L1_43
L1_42: ldc.i4 37
L1_43: ret 
}
.method static assembly void Number () {.maxstack 30.locals init ()
  ldc.i4 0
  stsfld int32 OSS.OSS::val
  ldc.i4 34
L2_3: ldsfld int32 OSS.OSS::val
  ldc.i4 2147483647
  ldsfld char OSS.OSS::ch
  call int32 [mscorlib]System.Convert::ToInt32(char) 
  sub 
  ldstr "0"
  ldc.i4 10
  div 
  bgt L2_21
  ldc.i4 10
  ldsfld int32 OSS.OSS::val
  mul 
  ldsfld char OSS.OSS::ch
  call int32 [mscorlib]System.Convert::ToInt32(char) 
  ldstr "0"
  add 
  stsfld int32 OSS.OSS::val
  br L2_24
L2_21: call void OSS.OSS::Mark (char[] )
  ldc.i4 0
  stsfld int32 OSS.OSS::val
L2_24: ldsfld char OSS.OSS::ch
  beq L2_28
  ldsfld char OSS.OSS::ch
  bne.un L2_3
L2_28: ret 
}
.method static assembly void comment () {.maxstack 30.locals init ()
L3_0: ldsfld char OSS.OSS::ch
  bne.un L3_5
  ldsfld char OSS.OSS::ch
  bne.un L3_4
L3_4: br L3_0
L3_5: ldsfld char OSS.OSS::ch
  bne.un L3_8
  br L3_11
L3_8: ldsfld class [Texts]Texts.Reader OSS.OSS::R
  br L3_11
  br L3_0
L3_11: ldsfld char OSS.OSS::ch
  bne.un L3_14
  br L3_18
L3_14: ldsfld class [Texts]Texts.Reader OSS.OSS::R
  call void OSS.OSS::Mark (char[] )
  br L3_18
  br L3_0
L3_18: ret 
}
.method static public void Get (int32 & sym) {.maxstack 30.locals init ()
L4_0: ldsfld class [Texts]Texts.Reader OSS.OSS::R
  ldfld 
  ldsfld char OSS.OSS::ch
  br L4_0
  ldsfld class [Texts]Texts.Reader OSS.OSS::R
  ldarg 0
  ldc.i4 64
  stind.i4 
  br L4_108
  ldsfld char OSS.OSS::ch
   ldc.i4 344
  sub
  switch (L4_12, L4_16, L4_20, L4_24, L4_28, L4_32, L4_36, L4_105, L4_46, L4_105, L4_56, L4_60, L4_64, L4_105, L4_74, L4_78, L4_105, L4_87, L4_91, L4_95, L4_99, L4_99, L4_100, L4_100, L4_100, L4_100, L4_101)
  br L4_105
L4_12: ldarg 0
  ldc.i4 5
  stind.i4 
  br L4_108
L4_16: ldarg 0
  ldc.i4 1
  stind.i4 
  br L4_108
L4_20: ldarg 0
  ldc.i4 6
  stind.i4 
  br L4_108
L4_24: ldarg 0
  ldc.i4 7
  stind.i4 
  br L4_108
L4_28: ldarg 0
  ldc.i4 9
  stind.i4 
  br L4_108
L4_32: ldarg 0
  ldc.i4 10
  stind.i4 
  br L4_108
L4_36: ldsfld char OSS.OSS::ch
  bne.un L4_42
  ldarg 0
  ldc.i4 13
  stind.i4 
  br L4_45
L4_42: ldarg 0
  ldc.i4 11
  stind.i4 
L4_45: br L4_108
L4_46: ldsfld char OSS.OSS::ch
  bne.un L4_52
  ldarg 0
  ldc.i4 12
  stind.i4 
  br L4_55
L4_52: ldarg 0
  ldc.i4 14
  stind.i4 
L4_55: br L4_108
L4_56: ldarg 0
  ldc.i4 38
  stind.i4 
  br L4_108
L4_60: ldarg 0
  ldc.i4 19
  stind.i4 
  br L4_108
L4_64: ldsfld char OSS.OSS::ch
  bne.un L4_70
  ldarg 0
  ldc.i4 33
  stind.i4 
  br L4_73
L4_70: ldarg 0
  ldc.i4 20
  stind.i4 
L4_73: br L4_108
L4_74: ldarg 0
  ldc.i4 18
  stind.i4 
  br L4_108
L4_78: ldsfld char OSS.OSS::ch
  bne.un L4_83
  ldarg 0
  call void OSS.OSS::Get (int32 & )
  br L4_86
L4_83: ldarg 0
  ldc.i4 29
  stind.i4 
L4_86: br L4_108
L4_87: ldarg 0
  ldc.i4 22
  stind.i4 
  br L4_108
L4_91: ldarg 0
  ldc.i4 30
  stind.i4 
  br L4_108
L4_95: ldarg 0
  ldc.i4 23
  stind.i4 
  br L4_108
L4_99: br L4_108
L4_100: br L4_108
L4_101: ldarg 0
  ldc.i4 32
  stind.i4 
  br L4_108
L4_105: ldarg 0
  ldc.i4 0
  stind.i4 
L4_108: ret 
}
.method static public void Init ( T, int32 pos) {.maxstack 30.locals init ()
  ldc.i4 0
  stsfld bool OSS.OSS::'error'
  ldarg 1
  stsfld int32 OSS.OSS::errpos
  ret 
}
.method static assembly void EnterKW (int32 sym, char[] name) {.maxstack 30.locals init ()
  ldsfld string[] OSS.OSS::keyTab
  ldsfld int32 OSS.OSS::nkw
  ldelem.ref 
  ldarg 0
  stfld 
  ldsfld string[] OSS.OSS::keyTab
  ldsfld int32 OSS.OSS::nkw
  ldelem.ref 
  ldsfld int32 OSS.OSS::nkw
  ldc.i4 1
  add 
  stsfld int32 OSS.OSS::nkw
  ret 
}
// Begin FixDelegateProcs
// End FixDelegateProcs
.method static public void $OberonBody () {
.maxstack 30
.entrypoint
  ldsfld bool OSS.OSS::$BodyInitialized
  brfalse L$InitBody
  ret
  L$InitBody:
  ldc.i4 1
  stsfld bool OSS.OSS::$BodyInitialized
   // Begin of initialization of module-variables.
  ldc.i4 16
  newarr char
  stsfld char[] OSS.OSS::id
  ldc.i4 34
  newarr string
  stsfld string[] OSS.OSS::keyTab
   // End of initialization of module-variables.
  ldc.i4 1
  stsfld bool OSS.OSS::'error'
  ldc.i4 0
  stsfld int32 OSS.OSS::nkw
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 27
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 44
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 25
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 8
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 40
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 4
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 59
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 41
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 26
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 58
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 54
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 61
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 57
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 42
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 46
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 55
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 60
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 3
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 0
  call void OSS.OSS::EnterKW (int32 , char[] )
  ldc.i4 63
  call void OSS.OSS::EnterKW (int32 , char[] )
  ret 
}
}
}
