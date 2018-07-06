﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skrypt.Execution;

namespace Skrypt.Library.Native {
    partial class System {
        public class Numeric : SkryptObject {
            public double value;

            public Numeric() {
                Name = "numeric";
            }

            public Numeric(double v) {
                Name = "numeric";
                value = v;
            }

            //public static SkryptObject Constructor(SkryptObject[] Input) {
            //    var a = TypeConverter.ToNumeric(Input, 0);

            //    return new Numeric(a);
            //}

            new public Dictionary<string, operation> Operations = new Dictionary<string, operation>
            {
                {"add", (a,b) => {
                    return new Numeric(((Numeric)a).value + ((Numeric)b).value);
                } },
                {"subtract", (a,b) => {
                    return new Numeric(((Numeric)a).value - ((Numeric)b).value);
                } },
                {"multiply", (a,b) => {
                    return new Numeric(((Numeric)a).value * ((Numeric)b).value);
                } },
                {"lesser", (a,b) => {
                    return new Boolean(((Numeric)a).value < ((Numeric)b).value);
                } },
            };

            public static implicit operator Numeric(double d) {
                return new Numeric(d);
            }

            public static implicit operator double(Numeric d) {
                return d.value;
            }

            public override string ToString() {
                return "" + value;
            }
        }
    }

    //public class Numeric : SkryptObject {
    //    public double value;

    //    public Numeric() {
    //        Name = "numeric";
    //    }

    //    public Numeric(double v) {
    //        Name = "numeric";
    //        value = v;
    //    }

    //    new public Dictionary<string, operation> Operations = new Dictionary<string, operation>
    //    {
    //        {"add", (a,b) => {
    //            return new Numeric(((Numeric)a).value + ((Numeric)b).value);
    //        } },
    //        {"subtract", (a,b) => {
    //            return new Numeric(((Numeric)a).value - ((Numeric)b).value);
    //        } },
    //        {"multiply", (a,b) => {
    //            return new Numeric(((Numeric)a).value * ((Numeric)b).value);
    //        } },
    //        {"lesser", (a,b) => {
    //            return new SkryptBoolean(((Numeric)a).value < ((Numeric)b).value);
    //        } },
    //    };


    //    public static implicit operator Numeric(double d) {
    //        return new Numeric(d);
    //    }

    //    public static implicit operator double(Numeric d) {
    //        return d.value;
    //    }

    //    //public override SkryptObject _Add(SkryptObject X) {
    //    //    return new Numeric(value + ((Numeric)X).value);
    //    //}

    //    //public override SkryptObject _Subtract(SkryptObject X) {
    //    //    return new Numeric(value - ((Numeric)X).value);
    //    //}

    //    //public override SkryptObject _Multiply(SkryptObject X) {
    //    //    return new Numeric(value * ((Numeric)X).value);
    //    //}

    //    //public override SkryptObject _Divide(SkryptObject X) {
    //    //    return new Numeric(value / ((Numeric)X).value);
    //    //}

    //    //public override SkryptObject _Modulo(SkryptObject X) {
    //    //    return new Numeric(value % ((Numeric)X).value);
    //    //}

    //    //public override SkryptObject _Lesser(SkryptObject X) {
    //    //    return new SkryptBoolean(value < ((Numeric)X).value);
    //    //}

    //    //public override SkryptObject _Greater(SkryptObject X) {
    //    //    return new SkryptBoolean(value > ((Numeric)X).value);
    //    //}

    //    //public override SkryptObject _Equal(SkryptObject X) {
    //    //    return new SkryptBoolean(value == ((Numeric)X).value);
    //    //}

    //    //public override SkryptObject _PostIncrement() {
    //    //    double v = value;
    //    //    value++;
    //    //    return new Numeric(v);
    //    //}

    //    public override string ToString() {
    //        return "" + value;
    //    }
    //}
}
