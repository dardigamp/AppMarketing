using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System
{
    public static class ObjectExtensiones
    {
        public static bool EsNulo(this object objeto)
        {
            return (objeto == null);
        }
    }
}