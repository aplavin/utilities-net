// <copyright file="ImageUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Drawing;
using System.Windows.Media.Imaging;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for ImageUtils</summary>
[PexClass(typeof(global::ImageUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class ImageUtilsTest
{
    /// <summary>Test stub for Download(Uri)</summary>
    [PexMethod]
    public Bitmap Download(Uri url)
    {
        Bitmap result = global::ImageUtils.Download(url);
        return result;
        // TODO: add assertions to method ImageUtilsTest.Download(Uri)
    }

    /// <summary>Test stub for Download(String)</summary>
    [PexMethod]
    public Bitmap Download01(string url)
    {
        Bitmap result = global::ImageUtils.Download(url);
        return result;
        // TODO: add assertions to method ImageUtilsTest.Download01(String)
    }

    /// <summary>Test stub for GetJpegBytes(Image, Int32)</summary>
    [PexMethod]
    public byte[] GetJpegBytes(Image image, int quality)
    {
        byte[] result = global::ImageUtils.GetJpegBytes(image, quality);
        return result;
        // TODO: add assertions to method ImageUtilsTest.GetJpegBytes(Image, Int32)
    }

    /// <summary>Test stub for Grayscale(Image)</summary>
    [PexMethod]
    public Bitmap Grayscale(Image original)
    {
        Bitmap result = global::ImageUtils.Grayscale(original);
        return result;
        // TODO: add assertions to method ImageUtilsTest.Grayscale(Image)
    }

    /// <summary>Test stub for Scale(Image, Int32, Int32)</summary>
    [PexMethod]
    public Bitmap Scale(
        Image image,
        int width,
        int height
    )
    {
        Bitmap result = global::ImageUtils.Scale(image, width, height);
        return result;
        // TODO: add assertions to method ImageUtilsTest.Scale(Image, Int32, Int32)
    }

    /// <summary>Test stub for Scale(Image, Size)</summary>
    [PexMethod]
    public Bitmap Scale01(Image image, Size size)
    {
        Bitmap result = global::ImageUtils.Scale(image, size);
        return result;
        // TODO: add assertions to method ImageUtilsTest.Scale01(Image, Size)
    }

    /// <summary>Test stub for Shrink(Image, Int32, Int32)</summary>
    [PexMethod]
    public Bitmap Shrink(
        Image image,
        int maxWidth,
        int maxHeight
    )
    {
        Bitmap result = global::ImageUtils.Shrink(image, maxWidth, maxHeight);
        return result;
        // TODO: add assertions to method ImageUtilsTest.Shrink(Image, Int32, Int32)
    }

    /// <summary>Test stub for ToBitmap(BitmapSource)</summary>
    [PexMethod]
    public Bitmap ToBitmap(BitmapSource bitmapSource)
    {
        Bitmap result = global::ImageUtils.ToBitmap(bitmapSource);
        return result;
        // TODO: add assertions to method ImageUtilsTest.ToBitmap(BitmapSource)
    }

    /// <summary>Test stub for ToBitmapSource(Bitmap)</summary>
    [PexMethod]
    public BitmapSource ToBitmapSource(Bitmap bitmap)
    {
        BitmapSource result = global::ImageUtils.ToBitmapSource(bitmap);
        return result;
        // TODO: add assertions to method ImageUtilsTest.ToBitmapSource(Bitmap)
    }
}
