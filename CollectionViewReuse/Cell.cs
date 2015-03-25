using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CollectionViewReuseTest
{
	partial class Cell : UICollectionViewCell
	{
		public static readonly string Id = "cell";


		public string LabelText {
			get { return label.Text; }
			set { label.Text = value; }
		}

		public Cell (IntPtr handle) : base (handle)
		{
		}
	}
}
