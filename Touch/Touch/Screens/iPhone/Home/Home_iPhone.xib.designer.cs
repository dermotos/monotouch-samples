// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_Touch.Screens.iPhone.Home {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("Home_iPhone")]
	public partial class Home_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt_btnGestureRecognizers;
		
		private MonoTouch.UIKit.UIButton __mt_btnTouch;
		
		private MonoTouch.UIKit.UIButton __mt_btnCustomGestureRecognizer;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnGestureRecognizers")]
		private MonoTouch.UIKit.UIButton btnGestureRecognizers {
			get {
				this.__mt_btnGestureRecognizers = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnGestureRecognizers")));
				return this.__mt_btnGestureRecognizers;
			}
			set {
				this.__mt_btnGestureRecognizers = value;
				this.SetNativeField("btnGestureRecognizers", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnTouch")]
		private MonoTouch.UIKit.UIButton btnTouch {
			get {
				this.__mt_btnTouch = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnTouch")));
				return this.__mt_btnTouch;
			}
			set {
				this.__mt_btnTouch = value;
				this.SetNativeField("btnTouch", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnCustomGestureRecognizer")]
		private MonoTouch.UIKit.UIButton btnCustomGestureRecognizer {
			get {
				this.__mt_btnCustomGestureRecognizer = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnCustomGestureRecognizer")));
				return this.__mt_btnCustomGestureRecognizer;
			}
			set {
				this.__mt_btnCustomGestureRecognizer = value;
				this.SetNativeField("btnCustomGestureRecognizer", value);
			}
		}
	}
}