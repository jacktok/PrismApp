

using System.Windows;

namespace PrismApp.Core.DependencyPropertyExtension
{
    public static class DialogCloser
    {
        
        public static bool? GetDialogResult(DependencyObject obj)
        {
            return (bool?)obj.GetValue(DialogResultProperty);
        }

        public static void SetDialogResult(DependencyObject obj, bool? value)
        {
            obj.SetValue(DialogResultProperty, value);
        }

        // Using a DependencyProperty as the backing store for DialogResult.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DialogResultProperty =
            DependencyProperty.RegisterAttached("DialogResult", 
                typeof(bool?), 
                typeof(DialogCloser), 
                new PropertyMetadata(DialogResultChanged));

        private static void DialogResultChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window window) window.DialogResult = e.NewValue as bool?;
        }
    }
}