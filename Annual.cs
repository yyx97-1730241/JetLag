using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jetlag
{
    public class Annual
    {
        public int? Value { get; set; }

        public Annual(int? value)
        {
            Value = value;
        }

        public Annual()
        {
            Value = null;
        }

        public static implicit operator Annual(int? value)
        {
            return new Annual(value);
        }

        public override string ToString()
        {
            return Value == null ? "xx" : Value.ToString();
        }

        public static explicit operator Annual(string value)
        {
            // todo@ 处理非整数的输入
            return string.IsNullOrEmpty(value) ? new Annual() : new Annual(int.Parse(value));
        }
    }
}

