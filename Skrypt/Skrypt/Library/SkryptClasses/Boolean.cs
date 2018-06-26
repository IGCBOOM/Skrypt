﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skrypt.Library.SkryptClasses {
    class SkryptBoolean : SkryptObject {
        public bool value;

        public SkryptBoolean() {
            Name = "boolean";
        }

        static public SkryptBoolean _and (SkryptBoolean A, SkryptBoolean B) {
            return new SkryptBoolean { value = A.value && B.value };
        }

        static public SkryptBoolean _or(SkryptBoolean A, SkryptBoolean B) {
            return new SkryptBoolean { value = A.value || B.value };
        }

        static public SkryptBoolean _not(SkryptBoolean A) {
            return new SkryptBoolean { value = !A.value};
        }

        public override string ToString() {
            return value.ToString();
        }
    }
}