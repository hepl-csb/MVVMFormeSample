using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSample.Infrastructure
{
    public abstract class WrapperBase<T> : BindableBase
    {
        public T Content { get; set; }


        protected WrapperBase(T content)
        {
            Content = content;
        }
    }
}
