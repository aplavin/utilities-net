// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.Pex.Framework.Generated;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

public partial class ImageUtilsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::ImageUtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void DownloadThrowsArgumentNullException867()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Bitmap bitmap;
      bitmap = this.Download((Uri)null);
      disposables.Add((IDisposable)bitmap);
      disposables.Dispose();
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::ImageUtilsTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void Download02()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Uri uri;
      Bitmap bitmap;
      uri = new Uri("\0\u0080");
      bitmap = this.Download(uri);
      disposables.Add((IDisposable)bitmap);
      disposables.Dispose();
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::ImageUtilsTest))]
[PexRaisedException(typeof(WebException))]
public void DownloadThrowsWebException553()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Uri uri;
      Bitmap bitmap;
      uri = new Uri("a|\\");
      bitmap = this.Download(uri);
      disposables.Add((IDisposable)bitmap);
      disposables.Dispose();
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::ImageUtilsTest))]
[PexRaisedException(typeof(NotSupportedException))]
public void DownloadThrowsNotSupportedException231()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Uri uri;
      Bitmap bitmap;
      uri = new Uri("a-:");
      bitmap = this.Download(uri);
      disposables.Add((IDisposable)bitmap);
      disposables.Dispose();
    }
}
}
