﻿// lindexi
// 16:34

using System;
using System.Text;
using lindexi.uwp.ImageShack.Thirdqiniucs.Model.Util;

namespace lindexi.uwp.ImageShack.Thirdqiniucs.Model.FileOp
{
    internal class ImageWaterMarker : WaterMarker
    {
        public ImageWaterMarker(string imageUrl, int dissolve = 50, MarkerGravity gravity = MarkerGravity.SouthEast,
            int dx = 10, int dy = 10)
            : base(dissolve, gravity, dx, dy)
        {
            this.imageUrl = imageUrl;
        }

        public override string MakeRequest(string url)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0}?watermark/{1}", url, 1));
            if (string.IsNullOrEmpty(imageUrl))
            {
                throw new Exception("Water Marker Image Url Error");
            }
            sb.Append("/image/" + Base64URLSafe.ToBase64URLSafe(imageUrl));
            sb.Append("/dissolve/" + dissolve);
            sb.Append("/gravity/" + Gravitys[(int) gravity]);
            sb.Append("/dx/" + dx);
            sb.Append("/dy/" + dy);
            return sb.ToString();
        }

        public string imageUrl;
    }
}