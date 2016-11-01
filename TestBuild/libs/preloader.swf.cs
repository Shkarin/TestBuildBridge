using System;
using flash.text;
using flash.display;
using System.Collections.Generic;
using preloader.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libpreloader : ResourcesExternalLib{
	public Libpreloader() {
	vectors = new string[] {
	"974867b49eeef16405ce0da4a096e544",
	"d807e3186471b77a4f8c3cd35310b8a9"
	};
	graphics = new string[] {
	"f4474a41d178a4d77039ba2b2fd999bb",
	"99ee3c1eb7cf5f159c8060cf373a521e",
	"f4474a41d178a4d77039ba2b2fd999bb",
	"d43e8a7661ef1c4590bbed92072a015f"
	};
	}
}
public class PreloaderBar : MovieClip{ 
	public MovieClip line;
	public PreloaderBar() {
		var i10 = new symbol_0(){filters = new as3.Array(new object[]{})};
		addChild(i10);//0
		line = new symbol_2(){x = -122 , scaleX = 0 , y = -3 , filters = new as3.Array(new object[]{}) , scale9Grid = new flash.geom.Rectangle(3, 2, 141, 1)};
		addChild(line);//1
	}
}
public class PreloaderBg : BitmapData{ 
	public PreloaderBg() {
		width = 900;
		height = 690;
		setPixels("ba5d3f5de79ed246fa3e8dba9ed399d7");
	}
}
public class PreloaderLogoEn : BitmapData{ 
	public PreloaderLogoEn() {
		width = 563;
		height = 126;
		setPixels("f4474a41d178a4d77039ba2b2fd999bb");
	}
}
public class PreloaderLogoRu : BitmapData{ 
	public PreloaderLogoRu() {
		width = 445;
		height = 133;
		setPixels("d43e8a7661ef1c4590bbed92072a015f");
	}
}
namespace preloader.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("974867b49eeef16405ce0da4a096e544", -130, -11, 260, 22, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("d807e3186471b77a4f8c3cd35310b8a9", 0, 0, 149, 7, 1, 1);
		}
	}
	public class symbol_2 : MovieClip{ 
		public symbol_2() {
			this.scale9Grid = new flash.geom.Rectangle(3,  2,  141,  1);
			var i11 = new symbol_1(){filters = new as3.Array(new object[]{})};
			addChild(i11);//0
		}
	}
}
