using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

public unsafe class RawBitmap : IDisposable
{
    private Bitmap _originBitmap;
    private BitmapData _bitmapData;
    private byte* _begin;

    public RawBitmap(Bitmap originBitmap)
    {
        _originBitmap = originBitmap;
        _bitmapData = _originBitmap.LockBits(new Rectangle(0, 0, _originBitmap.Width, _originBitmap.Height),
                                             ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
        _begin = (byte*)(void*)_bitmapData.Scan0;
    }

    #region IDisposable Members

    public void Dispose()
    {
        _originBitmap.UnlockBits(_bitmapData);
    }

    #endregion

    public unsafe byte* Begin
    {
        get { return _begin; }
    }

    public unsafe byte* this[int x, int y]
    {
        get
        {
            return _begin + y * (_bitmapData.Stride) + x * 3;
        }
    }

    public unsafe byte* this[int x, int y, int offset]
    {
        get
        {
            return _begin + y * (_bitmapData.Stride) + x * 3 + offset;
        }
    }

    //public unsafe void SetColor(int x, int y, int color)
    //{
    //    *(int*)(_begin + y * (_bitmapData.Stride) + x * 3) = color;
    //}

    public int Stride
    {
        get { return _bitmapData.Stride; }
    }

    public int Width
    {
        get { return _bitmapData.Width; }
    }

    public int Height
    {
        get { return _bitmapData.Height; }
    }

    public int GetOffset()
    {
        return _bitmapData.Stride - _bitmapData.Width * 3;
    }

    public Bitmap OriginBitmap
    {
        get { return _originBitmap; }
    }
}

