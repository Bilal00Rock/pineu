﻿using System.Reflection;

namespace Pineu.Persistence {
    public static class AssemblyReference {
        public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
    }
}