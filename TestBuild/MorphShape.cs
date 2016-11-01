//===================================
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.display
{
	//[native(instance="MorphShapeObject",methods="auto",cls="MorphShapeClass",construct="restricted-check")]
	public /*final*/ class MorphShape : Shape
    {


        protected void setGraphicsStart(string imageGuid, double x, double y, double width, double height, double bitmapWidth, double bitmapHeight)
        {
       
        }

        protected void setGraphicsEnd(string imageGuid, double x, double y, double width, double height, double bitmapWidth, double bitmapHeight)
        {
            
        }

        public uint ratio
        {
            set
            {
              
            }
        }

        private uint shiftColor(uint sColor, uint eColor, float ratio)
        {
            uint sRed = sColor >> 16;
            uint sGreen = (sColor & 0xFF00) >> 8;
            uint sBlue = (sColor & 0xFF);

            uint eRed = eColor >> 16;
            uint eGreen = (eColor & 0xFF00) >> 8;
            uint eBlue = (eColor & 0xFF);

            sRed += (uint)((eRed - sRed) * ratio);
            sGreen += (uint)((eGreen - sGreen) * ratio);
            sBlue += (uint)((eBlue - sBlue) * ratio);

            return (sRed << 16) + (sGreen << 8) + sBlue;
        }
    }
}
