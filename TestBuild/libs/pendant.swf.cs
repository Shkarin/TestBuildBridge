using System;
using flash.text;
using flash.display;
using System.Collections.Generic;
using pendant.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libpendant : ResourcesExternalLib{
	public Libpendant() {
	vectors = new string[] {
	"8c82badb2a5ba0ecc5bd12da11db768a",
	"d634ebc518bb2c99c8a8b9aed948ee3b",
	"0df691bee496089a0492c767d725745d",
	"b95fc2f8d3cdee0f9296d7683aa3e1c5",
	"a79c56a3b404ca6ef590e466b61abc36",
	"e4c85f3a1a33ba1a799d88fb2cfaccb1",
	"2bfb0a75fc4ad89eb65da30c59c43aa3",
	"df11f42d5877bbef778d36e3b132ae5b",
	"b5099972ff4c23891be844a5fa4f0a59",
	"fdeecdc889b646cd688ceae3d6c6d183",
	"e6fda441d8622f2b162a32e1de680e73",
	"5ba52b779105a5330ed700488ac2afff",
	"687f6c1ec9460417f28e9a1333194b9d",
	"92c1e16e7cf3932e7e7b02c49db4da7e",
	"d440e481afda60899a9bcd68e01694da",
	"4993c6ca79bb64f677c6785669c6b416",
	"70eb024258db42c9ba9860d7dd3435f4",
	"0e4fcb63ca6f442ced533355145a93fd",
	"5e4d7a51348743c069f2772aa2255171",
	"80bcd5429dc07f4f56547870fb9c2d4a",
	"2beffba33c633cf280f21b02347a6285",
	"1b523ec1d70f8f2842b1fdec89085ef8",
	"adfb04898a1e9359beaf95f2a4322e39",
	"c32f3eb680712de530f216c7cb4bffea",
	"d4818332044036b86ab19333d005454a",
	"cadecb00c41c33996974d2853841f4ba",
	"df6eadffa8062c618ecfa2892c9334ec",
	"54ee087de8f95be5cafe671a88f27804"
	};
	graphics = new string[] {
	"90dae68851d6b90589cb03be80fb2fc0",
	"21d04d4032c105cee2facb51217f2a8a",
	"e8a709fe57bdaeb2009457709a693d8b",
	"8e222de8e7f81df5628d03ba769884df",
	"d27c1a30875c4aba8946472f72fdc96d",
	"71809378be44edf206236797248cb519",
	"be13f229d2acdb0f665360259465a427",
	"b3e658a08482dca616ea05e1071d931a",
	"b4be6209d2727358e25a44ece7d62be7",
	"6a76462c81f4880bb94bd4fc745850ad",
	"e2007acfc081188a5621ffbe8ed3fdd4",
	"fc3cf8c27b1fff2c11c3bedc7e44075a",
	"6bf61699ed162e63a9c90bb09accd5e6",
	"06a6881ee9b634efbc57b3199bd06815",
	"e065e1a482877fa45c15bc2ea26e3af8",
	"cec256607d8e0f914eaffb8bbec6fe41",
	"148a8a592a3d9e6c0970dc65c7d6d124",
	"88e0a4389819c55685f589fb4342469d",
	"fe359a8002c166641c1df482bac0bb0a",
	"9cec541c6d65300cf5a0540cabce601d",
	"2109612f32a56225be68e5213b9a4325",
	"59a2a718c41c2ab9c4ddc562a33e64af",
	"894eff33f90c4a10ab80216d052362ca",
	"c7e5ad991e778273de6504ca2beaa734",
	"c7e7f4c097e8fcd817be4e77cd4c5aa7",
	"dedac13db77026a54d8c241dbef53106",
	"2a363ca94252ca3c72a2ad66cd095861",
	"1d02291231c06386f3f5f5a011f45567",
	"90dae68851d6b90589cb03be80fb2fc0",
	"4645d167712133b5147e5817cc460fb7",
	"000b0f626af67c005f2e3d80deb723ee",
	"678389fe9b8275defc92e6f82db6602a",
	"e3541f28cf053de15021cfae0f82b86a"
	};
	}
}
public class AwardCongratulationEn : BitmapData{ 
	public AwardCongratulationEn() {
		width = 286;
		height = 56;
		setPixels("cec256607d8e0f914eaffb8bbec6fe41");
	}
}
public class AwardCongratulationRu : BitmapData{ 
	public AwardCongratulationRu() {
		width = 264;
		height = 51;
		setPixels("6a76462c81f4880bb94bd4fc745850ad");
	}
}
public class GoldenSpringImg : BitmapData{ 
	public GoldenSpringImg() {
		width = 50;
		height = 89;
		setPixels("c7e7f4c097e8fcd817be4e77cd4c5aa7");
	}
}
public class PendantBeauty : MovieClip{ 
	public PendantBeauty() {
		var i44 = new symbol_0(){filters = new as3.Array(new object[]{})};
		addChild(i44);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i44);
		f += () => {
			i44.x = 0;
			i44.scaleX = 1;
			i44.y = 0;
			i44.scaleY = 1;
			i44.rotation = 0;
			i44.alpha = 1;
			i44.filters = new as3.Array(new object[]{});
			i44.scale9Grid = null;
			i44.visible = true;
		};
		f = l.Add();
		f.Add(i44);
		setFrames(l);
	}
}
public class PendantBeautyButton : MovieClip{ 
	public PendantBeautyButton() {
		var i46 = new symbol_1(){alpha = 0.7 , filters = new as3.Array(new object[]{})};
		addChild(i46);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i46);
		f += () => {
			i46.x = 0;
			i46.scaleX = 1;
			i46.y = 0;
			i46.scaleY = 1;
			i46.rotation = 0;
			i46.alpha = 0.7;
			i46.filters = new as3.Array(new object[]{});
			i46.scale9Grid = null;
			i46.visible = true;
		};
		f = l.Add();
		f.Add(i46);
		f += () => {
			i46.alpha = 1;
		};
		f = l.Add();
		f.Add(i46);
		setFrames(l);
	}
}
public class PendantBeautyCaption : MovieClip{ 
	public PendantBeautyCaption() {
		var i48 = new symbol_2(){filters = new as3.Array(new object[]{})};
		addChild(i48);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i48);
		f += () => {
			i48.x = 0;
			i48.scaleX = 1;
			i48.y = 0;
			i48.scaleY = 1;
			i48.rotation = 0;
			i48.alpha = 1;
			i48.filters = new as3.Array(new object[]{});
			i48.scale9Grid = null;
			i48.visible = true;
		};
		f = l.Add();
		f.Add(i48);
		setFrames(l);
	}
}
public class PendantBeautyCaptionEn : MovieClip{ 
	public PendantBeautyCaptionEn() {
		var i50 = new symbol_3(){filters = new as3.Array(new object[]{})};
		addChild(i50);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i50);
		f += () => {
			i50.x = 0;
			i50.scaleX = 1;
			i50.y = 0;
			i50.scaleY = 1;
			i50.rotation = 0;
			i50.alpha = 1;
			i50.filters = new as3.Array(new object[]{});
			i50.scale9Grid = null;
			i50.visible = true;
		};
		f = l.Add();
		f.Add(i50);
		setFrames(l);
	}
}
public class PendantBlockedIcon : BitmapData{ 
	public PendantBlockedIcon() {
		width = 31;
		height = 38;
		setPixels("894eff33f90c4a10ab80216d052362ca");
	}
}
public class PendantChat : MovieClip{ 
	public PendantChat() {
		var i52 = new symbol_4(){filters = new as3.Array(new object[]{})};
		addChild(i52);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i52);
		f += () => {
			i52.x = 0;
			i52.scaleX = 1;
			i52.y = 0;
			i52.scaleY = 1;
			i52.rotation = 0;
			i52.alpha = 1;
			i52.filters = new as3.Array(new object[]{});
			i52.scale9Grid = null;
			i52.visible = true;
		};
		f = l.Add();
		f.Add(i52);
		setFrames(l);
	}
}
public class PendantChatButton : MovieClip{ 
	public PendantChatButton() {
		var i54 = new symbol_5(){alpha = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i54);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i54);
		f += () => {
			i54.x = 0;
			i54.scaleX = 1;
			i54.y = 0;
			i54.scaleY = 1;
			i54.rotation = 0;
			i54.alpha = 0.5;
			i54.filters = new as3.Array(new object[]{});
			i54.scale9Grid = null;
			i54.visible = true;
		};
		f = l.Add();
		f.Add(i54);
		f += () => {
			i54.alpha = 1;
		};
		f = l.Add();
		f.Add(i54);
		setFrames(l);
	}
}
public class PendantChatCaption : MovieClip{ 
	public PendantChatCaption() {
		var i56 = new symbol_6(){filters = new as3.Array(new object[]{})};
		addChild(i56);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i56);
		f += () => {
			i56.x = 0;
			i56.scaleX = 1;
			i56.y = 0;
			i56.scaleY = 1;
			i56.rotation = 0;
			i56.alpha = 1;
			i56.filters = new as3.Array(new object[]{});
			i56.scale9Grid = null;
			i56.visible = true;
		};
		f = l.Add();
		f.Add(i56);
		setFrames(l);
	}
}
public class PendantChatCaptionEn : MovieClip{ 
	public PendantChatCaptionEn() {
		var i58 = new symbol_7(){filters = new as3.Array(new object[]{})};
		addChild(i58);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i58);
		f += () => {
			i58.x = 0;
			i58.scaleX = 1;
			i58.y = 0;
			i58.scaleY = 1;
			i58.rotation = 0;
			i58.alpha = 1;
			i58.filters = new as3.Array(new object[]{});
			i58.scale9Grid = null;
			i58.visible = true;
		};
		f = l.Add();
		f.Add(i58);
		setFrames(l);
	}
}
public class PendantElementOverImg : BitmapData{ 
	public PendantElementOverImg() {
		width = 172;
		height = 172;
		setPixels("1d02291231c06386f3f5f5a011f45567");
	}
}
public class PendantFate : MovieClip{ 
	public PendantFate() {
		var i60 = new symbol_8(){filters = new as3.Array(new object[]{})};
		addChild(i60);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i60);
		f += () => {
			i60.x = 0;
			i60.scaleX = 1;
			i60.y = 0;
			i60.scaleY = 1;
			i60.rotation = 0;
			i60.alpha = 1;
			i60.filters = new as3.Array(new object[]{});
			i60.scale9Grid = null;
			i60.visible = true;
		};
		f = l.Add();
		f.Add(i60);
		setFrames(l);
	}
}
public class PendantFateButton : MovieClip{ 
	public PendantFateButton() {
		var i62 = new symbol_5(){alpha = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i62);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i62);
		f += () => {
			i62.x = 0;
			i62.scaleX = 1;
			i62.y = 0;
			i62.scaleY = 1;
			i62.rotation = 0;
			i62.alpha = 0.5;
			i62.filters = new as3.Array(new object[]{});
			i62.scale9Grid = null;
			i62.visible = true;
		};
		f = l.Add();
		f.Add(i62);
		f += () => {
			i62.alpha = 1;
		};
		f = l.Add();
		f.Add(i62);
		setFrames(l);
	}
}
public class PendantFateCaption : MovieClip{ 
	public PendantFateCaption() {
		var i64 = new symbol_9(){filters = new as3.Array(new object[]{})};
		addChild(i64);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i64);
		f += () => {
			i64.x = 0;
			i64.scaleX = 1;
			i64.y = 0;
			i64.scaleY = 1;
			i64.rotation = 0;
			i64.alpha = 1;
			i64.filters = new as3.Array(new object[]{});
			i64.scale9Grid = null;
			i64.visible = true;
		};
		f = l.Add();
		f.Add(i64);
		setFrames(l);
	}
}
public class PendantFateCaptionEn : MovieClip{ 
	public PendantFateCaptionEn() {
		var i66 = new symbol_10(){filters = new as3.Array(new object[]{})};
		addChild(i66);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i66);
		f += () => {
			i66.x = 0;
			i66.scaleX = 1;
			i66.y = 0;
			i66.scaleY = 1;
			i66.rotation = 0;
			i66.alpha = 1;
			i66.filters = new as3.Array(new object[]{});
			i66.scale9Grid = null;
			i66.visible = true;
		};
		f = l.Add();
		f.Add(i66);
		setFrames(l);
	}
}
public class PendantFortune : MovieClip{ 
	public PendantFortune() {
		var i68 = new symbol_11(){filters = new as3.Array(new object[]{})};
		addChild(i68);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i68);
		f += () => {
			i68.x = 0;
			i68.scaleX = 1;
			i68.y = 0;
			i68.scaleY = 1;
			i68.rotation = 0;
			i68.alpha = 1;
			i68.filters = new as3.Array(new object[]{});
			i68.scale9Grid = null;
			i68.visible = true;
		};
		f = l.Add();
		f.Add(i68);
		setFrames(l);
	}
}
public class PendantFortuneButton : MovieClip{ 
	public PendantFortuneButton() {
		var i70 = new symbol_5(){alpha = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i70);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i70);
		f += () => {
			i70.x = 0;
			i70.scaleX = 1;
			i70.y = 0;
			i70.scaleY = 1;
			i70.rotation = 0;
			i70.alpha = 0.5;
			i70.filters = new as3.Array(new object[]{});
			i70.scale9Grid = null;
			i70.visible = true;
		};
		f = l.Add();
		f.Add(i70);
		f += () => {
			i70.alpha = 1;
		};
		f = l.Add();
		f.Add(i70);
		setFrames(l);
	}
}
public class PendantFortuneCaption : MovieClip{ 
	public PendantFortuneCaption() {
		var i72 = new symbol_12(){filters = new as3.Array(new object[]{})};
		addChild(i72);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i72);
		f += () => {
			i72.x = 0;
			i72.scaleX = 1;
			i72.y = 0;
			i72.scaleY = 1;
			i72.rotation = 0;
			i72.alpha = 1;
			i72.filters = new as3.Array(new object[]{});
			i72.scale9Grid = null;
			i72.visible = true;
		};
		f = l.Add();
		f.Add(i72);
		setFrames(l);
	}
}
public class PendantFortuneCaptionEn : MovieClip{ 
	public PendantFortuneCaptionEn() {
		var i74 = new symbol_13(){filters = new as3.Array(new object[]{})};
		addChild(i74);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i74);
		f += () => {
			i74.x = 0;
			i74.scaleX = 1;
			i74.y = 0;
			i74.scaleY = 1;
			i74.rotation = 0;
			i74.alpha = 1;
			i74.filters = new as3.Array(new object[]{});
			i74.scale9Grid = null;
			i74.visible = true;
		};
		f = l.Add();
		f.Add(i74);
		setFrames(l);
	}
}
public class PendantFriendship : MovieClip{ 
	public PendantFriendship() {
		var i76 = new symbol_14(){filters = new as3.Array(new object[]{})};
		addChild(i76);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i76);
		f += () => {
			i76.x = 0;
			i76.scaleX = 1;
			i76.y = 0;
			i76.scaleY = 1;
			i76.rotation = 0;
			i76.alpha = 1;
			i76.filters = new as3.Array(new object[]{});
			i76.scale9Grid = null;
			i76.visible = true;
		};
		f = l.Add();
		f.Add(i76);
		setFrames(l);
	}
}
public class PendantFriendshipButton : MovieClip{ 
	public PendantFriendshipButton() {
		var i78 = new symbol_5(){alpha = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i78);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i78);
		f += () => {
			i78.x = 0;
			i78.scaleX = 1;
			i78.y = 0;
			i78.scaleY = 1;
			i78.rotation = 0;
			i78.alpha = 0.5;
			i78.filters = new as3.Array(new object[]{});
			i78.scale9Grid = null;
			i78.visible = true;
		};
		f = l.Add();
		f.Add(i78);
		f += () => {
			i78.alpha = 1;
		};
		f = l.Add();
		f.Add(i78);
		setFrames(l);
	}
}
public class PendantFriendshipCaption : MovieClip{ 
	public PendantFriendshipCaption() {
		var i80 = new symbol_15(){filters = new as3.Array(new object[]{})};
		addChild(i80);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i80);
		f += () => {
			i80.x = 0;
			i80.scaleX = 1;
			i80.y = 0;
			i80.scaleY = 1;
			i80.rotation = 0;
			i80.alpha = 1;
			i80.filters = new as3.Array(new object[]{});
			i80.scale9Grid = null;
			i80.visible = true;
		};
		f = l.Add();
		f.Add(i80);
		setFrames(l);
	}
}
public class PendantFriendshipCaptionEn : MovieClip{ 
	public PendantFriendshipCaptionEn() {
		var i82 = new symbol_16(){filters = new as3.Array(new object[]{})};
		addChild(i82);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i82);
		f += () => {
			i82.x = 0;
			i82.scaleX = 1;
			i82.y = 0;
			i82.scaleY = 1;
			i82.rotation = 0;
			i82.alpha = 1;
			i82.filters = new as3.Array(new object[]{});
			i82.scale9Grid = null;
			i82.visible = true;
		};
		f = l.Add();
		f.Add(i82);
		setFrames(l);
	}
}
public class PendantLove : MovieClip{ 
	public PendantLove() {
		var i84 = new symbol_17(){filters = new as3.Array(new object[]{})};
		addChild(i84);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i84);
		f += () => {
			i84.x = 0;
			i84.scaleX = 1;
			i84.y = 0;
			i84.scaleY = 1;
			i84.rotation = 0;
			i84.alpha = 1;
			i84.filters = new as3.Array(new object[]{});
			i84.scale9Grid = null;
			i84.visible = true;
		};
		f = l.Add();
		f.Add(i84);
		setFrames(l);
	}
}
public class PendantLoveButton : MovieClip{ 
	public PendantLoveButton() {
		var i86 = new symbol_5(){alpha = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i86);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i86);
		f += () => {
			i86.x = 0;
			i86.scaleX = 1;
			i86.y = 0;
			i86.scaleY = 1;
			i86.rotation = 0;
			i86.alpha = 0.5;
			i86.filters = new as3.Array(new object[]{});
			i86.scale9Grid = null;
			i86.visible = true;
		};
		f = l.Add();
		f.Add(i86);
		f += () => {
			i86.alpha = 1;
		};
		f = l.Add();
		f.Add(i86);
		setFrames(l);
	}
}
public class PendantLoveCaption : MovieClip{ 
	public PendantLoveCaption() {
		var i88 = new symbol_18(){filters = new as3.Array(new object[]{})};
		addChild(i88);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i88);
		f += () => {
			i88.x = 0;
			i88.scaleX = 1;
			i88.y = 0;
			i88.scaleY = 1;
			i88.rotation = 0;
			i88.alpha = 1;
			i88.filters = new as3.Array(new object[]{});
			i88.scale9Grid = null;
			i88.visible = true;
		};
		f = l.Add();
		f.Add(i88);
		setFrames(l);
	}
}
public class PendantLoveCaptionEn : MovieClip{ 
	public PendantLoveCaptionEn() {
		var i90 = new symbol_19(){filters = new as3.Array(new object[]{})};
		addChild(i90);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i90);
		f += () => {
			i90.x = 0;
			i90.scaleX = 1;
			i90.y = 0;
			i90.scaleY = 1;
			i90.rotation = 0;
			i90.alpha = 1;
			i90.filters = new as3.Array(new object[]{});
			i90.scale9Grid = null;
			i90.visible = true;
		};
		f = l.Add();
		f.Add(i90);
		setFrames(l);
	}
}
public class PendantLuck : MovieClip{ 
	public PendantLuck() {
		var i92 = new symbol_20(){filters = new as3.Array(new object[]{})};
		addChild(i92);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i92);
		f += () => {
			i92.x = 0;
			i92.scaleX = 1;
			i92.y = 0;
			i92.scaleY = 1;
			i92.rotation = 0;
			i92.alpha = 1;
			i92.filters = new as3.Array(new object[]{});
			i92.scale9Grid = null;
			i92.visible = true;
		};
		f = l.Add();
		f.Add(i92);
		setFrames(l);
	}
}
public class PendantLuckButton : MovieClip{ 
	public PendantLuckButton() {
		var i94 = new symbol_5(){alpha = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i94);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i94);
		f += () => {
			i94.x = 0;
			i94.scaleX = 1;
			i94.y = 0;
			i94.scaleY = 1;
			i94.rotation = 0;
			i94.alpha = 0.5;
			i94.filters = new as3.Array(new object[]{});
			i94.scale9Grid = null;
			i94.visible = true;
		};
		f = l.Add();
		f.Add(i94);
		f += () => {
			i94.alpha = 1;
		};
		f = l.Add();
		f.Add(i94);
		setFrames(l);
	}
}
public class PendantLuckCaption : MovieClip{ 
	public PendantLuckCaption() {
		var i96 = new symbol_21(){filters = new as3.Array(new object[]{})};
		addChild(i96);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i96);
		f += () => {
			i96.x = 0;
			i96.scaleX = 1;
			i96.y = 0;
			i96.scaleY = 1;
			i96.rotation = 0;
			i96.alpha = 1;
			i96.filters = new as3.Array(new object[]{});
			i96.scale9Grid = null;
			i96.visible = true;
		};
		f = l.Add();
		f.Add(i96);
		setFrames(l);
	}
}
public class PendantLuckCaptionEn : MovieClip{ 
	public PendantLuckCaptionEn() {
		var i98 = new symbol_22(){filters = new as3.Array(new object[]{})};
		addChild(i98);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i98);
		f += () => {
			i98.x = 0;
			i98.scaleX = 1;
			i98.y = 0;
			i98.scaleY = 1;
			i98.rotation = 0;
			i98.alpha = 1;
			i98.filters = new as3.Array(new object[]{});
			i98.scale9Grid = null;
			i98.visible = true;
		};
		f = l.Add();
		f.Add(i98);
		setFrames(l);
	}
}
public class PendantPopularity : MovieClip{ 
	public PendantPopularity() {
		var i100 = new symbol_23(){filters = new as3.Array(new object[]{})};
		addChild(i100);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i100);
		f += () => {
			i100.x = 0;
			i100.scaleX = 1;
			i100.y = 0;
			i100.scaleY = 1;
			i100.rotation = 0;
			i100.alpha = 1;
			i100.filters = new as3.Array(new object[]{});
			i100.scale9Grid = null;
			i100.visible = true;
		};
		f = l.Add();
		f.Add(i100);
		setFrames(l);
	}
}
public class PendantPopularityButton : MovieClip{ 
	public PendantPopularityButton() {
		var i102 = new symbol_5(){alpha = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i102);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i102);
		f += () => {
			i102.x = 0;
			i102.scaleX = 1;
			i102.y = 0;
			i102.scaleY = 1;
			i102.rotation = 0;
			i102.alpha = 0.5;
			i102.filters = new as3.Array(new object[]{});
			i102.scale9Grid = null;
			i102.visible = true;
		};
		f = l.Add();
		f.Add(i102);
		f += () => {
			i102.alpha = 1;
		};
		f = l.Add();
		f.Add(i102);
		setFrames(l);
	}
}
public class PendantPopularityCaption : MovieClip{ 
	public PendantPopularityCaption() {
		var i104 = new symbol_24(){filters = new as3.Array(new object[]{})};
		addChild(i104);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i104);
		f += () => {
			i104.x = 0;
			i104.scaleX = 1;
			i104.y = 0;
			i104.scaleY = 1;
			i104.rotation = 0;
			i104.alpha = 1;
			i104.filters = new as3.Array(new object[]{});
			i104.scale9Grid = null;
			i104.visible = true;
		};
		f = l.Add();
		f.Add(i104);
		setFrames(l);
	}
}
public class PendantPopularityCaptionEn : MovieClip{ 
	public PendantPopularityCaptionEn() {
		var i106 = new symbol_25(){filters = new as3.Array(new object[]{})};
		addChild(i106);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i106);
		f += () => {
			i106.x = 0;
			i106.scaleX = 1;
			i106.y = 0;
			i106.scaleY = 1;
			i106.rotation = 0;
			i106.alpha = 1;
			i106.filters = new as3.Array(new object[]{});
			i106.scale9Grid = null;
			i106.visible = true;
		};
		f = l.Add();
		f.Add(i106);
		setFrames(l);
	}
}
public class PendantSuccess : MovieClip{ 
	public PendantSuccess() {
		var i108 = new symbol_26(){filters = new as3.Array(new object[]{})};
		addChild(i108);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i108);
		f += () => {
			i108.x = 0;
			i108.scaleX = 1;
			i108.y = 0;
			i108.scaleY = 1;
			i108.rotation = 0;
			i108.alpha = 1;
			i108.filters = new as3.Array(new object[]{});
			i108.scale9Grid = null;
			i108.visible = true;
		};
		f = l.Add();
		f.Add(i108);
		setFrames(l);
	}
}
public class PendantSuccessButton : MovieClip{ 
	public PendantSuccessButton() {
		var i110 = new symbol_5(){alpha = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i110);//0
		FrameInfo f;
		var l= new Frames(3);
		f = l.Add();
		f.Add(i110);
		f += () => {
			i110.x = 0;
			i110.scaleX = 1;
			i110.y = 0;
			i110.scaleY = 1;
			i110.rotation = 0;
			i110.alpha = 0.5;
			i110.filters = new as3.Array(new object[]{});
			i110.scale9Grid = null;
			i110.visible = true;
		};
		f = l.Add();
		f.Add(i110);
		f += () => {
			i110.alpha = 1;
		};
		f = l.Add();
		f.Add(i110);
		setFrames(l);
	}
}
public class PendantSuccessCaption : MovieClip{ 
	public PendantSuccessCaption() {
		var i112 = new symbol_27(){filters = new as3.Array(new object[]{})};
		addChild(i112);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i112);
		f += () => {
			i112.x = 0;
			i112.scaleX = 1;
			i112.y = 0;
			i112.scaleY = 1;
			i112.rotation = 0;
			i112.alpha = 1;
			i112.filters = new as3.Array(new object[]{});
			i112.scale9Grid = null;
			i112.visible = true;
		};
		f = l.Add();
		f.Add(i112);
		setFrames(l);
	}
}
public class PendantSuccessCaptionEn : MovieClip{ 
	public PendantSuccessCaptionEn() {
		var i114 = new symbol_28(){filters = new as3.Array(new object[]{})};
		addChild(i114);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i114);
		f += () => {
			i114.x = 0;
			i114.scaleX = 1;
			i114.y = 0;
			i114.scaleY = 1;
			i114.rotation = 0;
			i114.alpha = 1;
			i114.filters = new as3.Array(new object[]{});
			i114.scale9Grid = null;
			i114.visible = true;
		};
		f = l.Add();
		f.Add(i114);
		setFrames(l);
	}
}
namespace pendant.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("687f6c1ec9460417f28e9a1333194b9d", -42, -51, 84, 102, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("54ee087de8f95be5cafe671a88f27804", 0, 0, 73, 69, 1, 1);
		}
	}
	public class symbol_10 : Shape{ 
		public symbol_10() {
			setGraphics("5ba52b779105a5330ed700488ac2afff", -66, -68, 112, 54, 1, 1);
		}
	}
	public class symbol_11 : Shape{ 
		public symbol_11() {
			setGraphics("d4818332044036b86ab19333d005454a", -48, -47, 97, 94, 1, 1);
		}
	}
	public class symbol_12 : Shape{ 
		public symbol_12() {
			setGraphics("5e4d7a51348743c069f2772aa2255171", -66, -65, 64, 66, 1, 1);
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("c32f3eb680712de530f216c7cb4bffea", -70, -69, 120, 71, 1, 1);
		}
	}
	public class symbol_14 : Shape{ 
		public symbol_14() {
			setGraphics("2bfb0a75fc4ad89eb65da30c59c43aa3", -52, -44, 104, 88, 1, 1);
		}
	}
	public class symbol_15 : Shape{ 
		public symbol_15() {
			setGraphics("0df691bee496089a0492c767d725745d", -21, -66, 89, 57, 1, 1);
		}
	}
	public class symbol_16 : Shape{ 
		public symbol_16() {
			setGraphics("70eb024258db42c9ba9860d7dd3435f4", -58, -69, 129, 81, 1, 1);
		}
	}
	public class symbol_17 : Shape{ 
		public symbol_17() {
			setGraphics("cadecb00c41c33996974d2853841f4ba", -66, -46, 132, 92, 1, 1);
		}
	}
	public class symbol_18 : Shape{ 
		public symbol_18() {
			setGraphics("1b523ec1d70f8f2842b1fdec89085ef8", -53, -72, 109, 41, 1, 1);
		}
	}
	public class symbol_19 : Shape{ 
		public symbol_19() {
			setGraphics("e6fda441d8622f2b162a32e1de680e73", -74, -71, 131, 81, 1, 1);
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("80bcd5429dc07f4f56547870fb9c2d4a", -60, -67, 99, 48, 1, 1);
		}
	}
	public class symbol_20 : Shape{ 
		public symbol_20() {
			setGraphics("df11f42d5877bbef778d36e3b132ae5b", -56, -55, 112, 111, 1, 1);
		}
	}
	public class symbol_21 : Shape{ 
		public symbol_21() {
			setGraphics("b5099972ff4c23891be844a5fa4f0a59", -5, -67, 73, 72, 1, 1);
		}
	}
	public class symbol_22 : Shape{ 
		public symbol_22() {
			setGraphics("b95fc2f8d3cdee0f9296d7683aa3e1c5", -28, -69, 99, 79, 1, 1);
		}
	}
	public class symbol_23 : Shape{ 
		public symbol_23() {
			setGraphics("0e4fcb63ca6f442ced533355145a93fd", -50, -51, 101, 103, 1, 1);
		}
	}
	public class symbol_24 : Shape{ 
		public symbol_24() {
			setGraphics("2beffba33c633cf280f21b02347a6285", -54, -70, 121, 65, 1, 1);
		}
	}
	public class symbol_25 : Shape{ 
		public symbol_25() {
			setGraphics("d634ebc518bb2c99c8a8b9aed948ee3b", -61, -68, 132, 73, 1, 1);
		}
	}
	public class symbol_26 : Shape{ 
		public symbol_26() {
			setGraphics("a79c56a3b404ca6ef590e466b61abc36", -47, -50, 95, 101, 1, 1);
		}
	}
	public class symbol_27 : Shape{ 
		public symbol_27() {
			setGraphics("92c1e16e7cf3932e7e7b02c49db4da7e", -64, -66, 76, 57, 1, 1);
		}
	}
	public class symbol_28 : Shape{ 
		public symbol_28() {
			setGraphics("e4c85f3a1a33ba1a799d88fb2cfaccb1", -69, -70, 120, 62, 1, 1);
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("d440e481afda60899a9bcd68e01694da", -69, -69, 123, 64, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("fdeecdc889b646cd688ceae3d6c6d183", -57, -47, 114, 95, 1, 1);
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("54ee087de8f95be5cafe671a88f27804", 0, 0, 73, 69, 1, 1);
		}
	}
	public class symbol_6 : Shape{ 
		public symbol_6() {
			setGraphics("df6eadffa8062c618ecfa2892c9334ec", -37, -68, 98, 46, 1, 1);
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("4993c6ca79bb64f677c6785669c6b416", -66, -68, 135, 94, 1, 1);
		}
	}
	public class symbol_8 : Shape{ 
		public symbol_8() {
			setGraphics("8c82badb2a5ba0ecc5bd12da11db768a", -51, -48, 103, 97, 1, 1);
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("adfb04898a1e9359beaf95f2a4322e39", -57, -68, 89, 43, 1, 1);
		}
	}
}
