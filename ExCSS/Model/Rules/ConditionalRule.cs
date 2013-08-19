
// ReSharper disable CheckNamespace
namespace ExCSS
// ReSharper restore CheckNamespace
{
    public abstract class ConditionalRule : AggregateRule
    {
        protected ConditionalRule(StyleSheet context) : base(context)
        {}

        public virtual string Condition
        {
            get { return string.Empty; }
            set { }
        }
    }
}
