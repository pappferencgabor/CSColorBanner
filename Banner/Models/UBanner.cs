using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner.Models
{

    public class UjabbBanner : UBanner
    {
        public UjabbBanner()
        {
            HelpFiller(Color.Red);
        }
    }
    public class UBanner : ABanner, IBannerOperations
    {
        public void Clear()
        {
            HelpFiller(BackgroundColor);
        }

        public void Fill(Color fillColor)
        {
            HelpFiller(fillColor);
        }

        public void ReplaceColor(Color oldColor, Color newColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                for (int columnIndex = 1; columnIndex < ColumnNum; columnIndex++)
                {
                    if (this[rowIndex, columnIndex] == oldColor)
                    {
                        this[rowIndex, columnIndex] = newColor;
                    }
                }
            }
        }

        public void RotateToLeft()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color temp = this[rowIndex, 0];
                for (int columnIndex = 1; columnIndex < ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex - 1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, ColumnNum - 1] = temp;
            }
        }

        public void RotateToRight()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color temp = this[rowIndex, ColumnNum - 1];
                for (int columnIndex = ColumnNum - 1; columnIndex > 0; columnIndex--)
                {
                    this[rowIndex, columnIndex] = this[rowIndex, columnIndex - 1];
                }
                this[rowIndex, 0] = temp;
            }
        }

        public void ShiftToLeft(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                for (int columnIndex = 1; columnIndex < ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex - 1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, ColumnNum - 1] = fillColor;
            }
        }

        public void ShiftToRight(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                for (int columnIndex = ColumnNum - 1; columnIndex > 0; columnIndex--)
                {
                    this[rowIndex, columnIndex] = this[rowIndex, columnIndex - 1];
                }
                this[rowIndex, 0] = fillColor;
            }
        }

        void IBannerOperations.DrawLine(int lineIndex, Color drawingColor, IBannerOperations.Orientation lineOrientation)
        {
            if (lineOrientation == IBannerOperations.Orientation.Horizontally)
            {
                for (int oszlopIndex = 0; oszlopIndex < ColumnNum; oszlopIndex++)
                {
                    this[lineIndex, oszlopIndex] = drawingColor;
                }
            }
            else
            {
                for (int sorIndex = 0; sorIndex < ColumnNum; sorIndex++)
                {
                    this[lineIndex, sorIndex] = drawingColor;
                }
            }
        }
    }
}
