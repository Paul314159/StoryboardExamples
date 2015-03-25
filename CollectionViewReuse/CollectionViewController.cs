using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CollectionViewReuseTest
{
	partial class CollectionViewController : UICollectionViewController
	{
		public CollectionViewController (IntPtr handle) : base (handle)
		{
		}

		public override nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			return 1;
		}

		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = (Cell)collectionView.DequeueReusableCell (Cell.Id, indexPath);
			cell.LabelText = "Hello " + ParentViewController.Title;
			return cell;
		}
	}
}
