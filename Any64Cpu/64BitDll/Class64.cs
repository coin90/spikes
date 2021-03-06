﻿using System;
using System.Reflection;

namespace _64BitDll
{
    public static class Class64
    {
        public static void GetInfo()
        {
            GetAsmInfo(typeof(Class64).Assembly);
        }

        private static void GetAsmInfo(Assembly asm)
        {
            PortableExecutableKinds peKind;
            ImageFileMachine imageFileMachine;

            asm.ManifestModule.GetPEKind(out peKind, out imageFileMachine);
            Console.WriteLine("{0} {1}", asm.ManifestModule.Name, imageFileMachine);
        }
    }
}