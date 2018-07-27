namespace Lands.iOS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FFImageLoading.Forms.Platform;
    //using FFImageLoading.Forms.Touch;
    using FFImageLoading.Svg.Forms;
    using Foundation;
    using UIKit;

    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            
            global::Xamarin.Forms.Forms.Init();
            CachedImageRenderer.Init();
            var ignore = typeof(SvgCachedImage);
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
}
