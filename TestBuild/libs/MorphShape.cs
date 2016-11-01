//===================================
using as3;

using flash.xml;
using System.Collections.Generic;
//using Function = System.Delegate;
//using Class = System.Type;
//using Object = System.Object;
//===================================

namespace flash.display
{
	//[native(instance="MorphShapeObject",methods="auto",cls="MorphShapeClass",construct="restricted-check")]
	public /*final*/ class MorphShape : Shape
    {
        private Graphics _graphicsStart = new Graphics();
        private Graphics _graphicsEnd = new Graphics();

        private Dictionary<uint, Vector<IGraphicsData>> cache = new Dictionary<uint, Vector<IGraphicsData>>();

        protected void AS3_ctor()
		{
			base.AS3_ctor();
		}

		public MorphShape()
		{
			AS3_ctor();
		}

        protected void setGraphicsStart(string imageGuid, double x, double y, double width, double height, double bitmapWidth, double bitmapHeight)
        {
            _graphicsStart.setGraphics(imageGuid, x, y, width, height);
        }

        protected void setGraphicsEnd(string imageGuid, double x, double y, double width, double height, double bitmapWidth, double bitmapHeight)
        {
            _graphicsEnd.setGraphics(imageGuid, x, y, width, height);
        }

        public uint ratio
        {
            set
            {
                if (!_graphicsStart.loaded || !_graphicsEnd.loaded)
                    return;

                if (!cache.ContainsKey(value))
                {
                    if (value == 0)
                    {
                        cache.Set(value, _graphicsStart.readGraphicsData());
                    }
                    else
                    {
                        Vector<IGraphicsData> sData = _graphicsStart.readGraphicsData();
                        Vector<IGraphicsData> eData = _graphicsEnd.readGraphicsData();
                        Vector<IGraphicsData> cData = new Vector<IGraphicsData>();

                        for (var i = 0; i < sData.length; i++)
                        {
                            if (sData[i] is GraphicsPath && eData[i] is GraphicsPath)
                            {
                                GraphicsPath path = new GraphicsPath();
                                path.winding = (sData[i] as GraphicsPath).winding;
                                path.data = (sData[i] as GraphicsPath).data.concat();
                                path.commands = (sData[i] as GraphicsPath).commands.concat();

                                for (var j = 0; j < (sData[i] as GraphicsPath).data.length; j++)
                                    path.data[j] += ((eData[i] as GraphicsPath).data[j] - (sData[i] as GraphicsPath).data[j]) * ((float)value / (1 << 16));
                                cData.push(path);
                            }
                            else if (sData[i] is GraphicsSolidFill && eData[i] is GraphicsSolidFill)
                            {
                                GraphicsSolidFill fill = new GraphicsSolidFill();
                                fill.color = (sData[i] as GraphicsSolidFill).color;
                                fill.alpha = (sData[i] as GraphicsSolidFill).alpha;

                                //TODO each color independently
                                fill.color += shiftColor((sData[i] as GraphicsSolidFill).color, (eData[i] as GraphicsSolidFill).color, (float)value / (1 << 16));
                                fill.alpha += ((eData[i] as GraphicsSolidFill).alpha - (sData[i] as GraphicsSolidFill).alpha) * ((float)value / (1 << 16));
                                cData.push(fill);
                            }
                            else
                                cData.push(sData[i]);
                        }
                        cache.Set(value, cData);
                    }
                }
                _graphics.clear();
                _graphics.drawGraphicsData(cache.Get(value));
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
