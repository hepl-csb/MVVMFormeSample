namespace Infrastructure
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
