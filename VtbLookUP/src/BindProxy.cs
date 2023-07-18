using System.Windows;

namespace JsonVis
{
    public class BindProxy : Freezable
    {
        protected override Freezable CreateInstanceCore() => new BindProxy();

        public object Data
        {
            get => GetValue(DadaPorperty);
            set => SetValue(DadaPorperty, value);
        }

        public static readonly DependencyProperty DadaPorperty = DependencyProperty.Register(
            nameof(Data),
            typeof(object),
            typeof(BindProxy)
            );
    }
}
