
namespace Labo3_MoreSimple.Infrastructure
{
    public abstract class WrapperBase : BindableBase
    {
        public object Content { get; set; }


        protected WrapperBase(object content)
        {
            Content = content;
        }
    }
}
