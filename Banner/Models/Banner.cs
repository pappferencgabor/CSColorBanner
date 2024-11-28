using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner.Models
{
    public class Banner : ABanner, IBannerOperations
    {
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void DrawLine(int rowIndex, Color drawingColor)
        {
            throw new NotImplementedException();
        }

        public void RotateToLeft()
        {
            throw new NotImplementedException();
        }

        public void RotateToRight()
        {
            throw new NotImplementedException();
        }

        public void ShiftToLeft(Color fillColor)
        {
            throw new NotImplementedException();
        }

        public void ShiftToRight(Color fillColor)
        {
            throw new NotImplementedException();
        }
    }
}
