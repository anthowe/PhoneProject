using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhoneProject.MarkupExtensions
{   [ContentProperty("ResourceId")]
    public class EmbeddedImage : IMarkupExtension
    {
        public String ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId))
            {
                return null;
            }
           return ImageSource.FromResource(ResourceId);
        }
    }
}
