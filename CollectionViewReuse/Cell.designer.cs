// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CollectionViewReuseTest
{
	[Register ("Cell")]
	partial class Cell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel label { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (label != null) {
				label.Dispose ();
				label = null;
			}
		}
	}
}
