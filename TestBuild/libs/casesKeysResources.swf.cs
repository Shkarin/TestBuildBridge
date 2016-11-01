using System;
using flash.text;
using flash.display;
using System.Collections.Generic;
using casesKeysResources.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class LibcasesKeysResources : ResourcesExternalLib{
	public LibcasesKeysResources() {
	vectors = new string[] {
	"f64c428c613728f0737711b788507ecd",
	"fa88a703a25aca27f27ffa1f941b7975",
	"ed2dd3bd2127915b50e46e206ef8b8b4",
	"8059db9a4dd1dc4696322f63079789fa",
	"7c6b15b9ed8accca52800b86d4e8afc4",
	"5a65a12aa0f079380e8d191a700f0e8b",
	"0b1062427ebd6ed97f8cc96535ab74a2",
	"3047139ece7795cf6292563e6bb03714"
	};
	graphics = new string[] {
	"undefined",
	"cf8f9137569c5f0eeacf494a9c4c9aed"
	};
	}
}
public class GlowAward : MovieClip{ 
	public GlowAward() {
		var i22 = new symbol_1(){filters = new as3.Array(new object[]{})};
		addChild(i22);//0
	}
}
public class GoldenCaseAppear : MovieClip{ 
	public GoldenCaseAppear() {
		var filter_0 = new BlurFilter(){blurX = 2, blurY = 2};
		var filter_1 = new GlowFilter(){strength = 1.21, color = 16777215, blurX = 13, blurY = 13};
		var i24 = new symbol_3(){scaleX = 0.5 , y = 14.9 , scaleY = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i24);//0
		var i26 = new symbol_5(){scaleX = 0.5 , y = -18.4 , scaleY = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i26);//1
		var i28 = new casesKeysResources_fla.ef1_5(){x = -1.4 , scaleX = 0.46 , y = 6.5 , scaleY = 0.46 , filters = new as3.Array(new object[]{filter_1,filter_0})};
		addChild(i28);//2
		FrameInfo f;
		var l= new Frames(15);
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.x = 0;
			i24.scaleX = 0.5;
			i24.y = 14.9;
			i24.scaleY = 0.5;
			i24.rotation = 0;
			i24.alpha = 1;
			i24.filters = new as3.Array(new object[]{});
			i24.scale9Grid = null;
			i24.visible = true;
			i26.x = 0;
			i26.scaleX = 0.5;
			i26.y = -18.4;
			i26.scaleY = 0.5;
			i26.rotation = 0;
			i26.alpha = 1;
			i26.filters = new as3.Array(new object[]{});
			i26.scale9Grid = null;
			i26.visible = true;
			i28.x = -1.4;
			i28.scaleX = 0.46;
			i28.y = 6.5;
			i28.scaleY = 0.46;
			i28.rotation = 0;
			i28.alpha = 1;
			i28.filters = new as3.Array(new object[]{filter_1,filter_0});
			i28.scale9Grid = null;
			i28.visible = true;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.49;
			i24.y = 16.1;
			i24.scaleY = 0.54;
			i26.scaleX = 0.49;
			i26.y = -19.8;
			i26.scaleY = 0.54;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.47;
			i24.y = 17.2;
			i24.scaleY = 0.58;
			i26.scaleX = 0.47;
			i26.y = -21.2;
			i26.scaleY = 0.58;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.46;
			i24.y = 18.4;
			i24.scaleY = 0.62;
			i26.scaleX = 0.46;
			i26.y = -22.6;
			i26.scaleY = 0.62;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.49;
			i24.y = 17.1;
			i24.scaleY = 0.58;
			i26.scaleX = 0.49;
			i26.y = -21.1;
			i26.scaleY = 0.58;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.52;
			i24.y = 15.9;
			i24.scaleY = 0.53;
			i26.scaleX = 0.52;
			i26.y = -19.6;
			i26.scaleY = 0.53;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.55;
			i24.y = 14.7;
			i24.scaleY = 0.49;
			i26.scaleX = 0.55;
			i26.y = -18;
			i26.scaleY = 0.49;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.58;
			i24.y = 13.3;
			i24.scaleY = 0.45;
			i26.scaleX = 0.58;
			i26.y = -16.4;
			i26.scaleY = 0.45;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.57;
			i24.y = 13.6;
			i24.scaleY = 0.46;
			i26.scaleX = 0.57;
			i26.y = -16.8;
			i26.scaleY = 0.46;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.56;
			i24.y = 13.8;
			i24.scaleY = 0.47;
			i26.scaleX = 0.56;
			i26.y = -17.1;
			i26.scaleY = 0.47;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.54;
			i24.y = 14.2;
			i24.scaleY = 0.48;
			i26.scaleX = 0.54;
			i26.y = -17.4;
			i26.scaleY = 0.48;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.53;
			i24.y = 14.4;
			i26.scaleX = 0.53;
			i26.y = -17.7;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.52;
			i24.y = 14.7;
			i24.scaleY = 0.49;
			i26.scaleX = 0.52;
			i26.y = -18.1;
			i26.scaleY = 0.49;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f += () => {
			i24.scaleX = 0.5;
			i24.y = 14.9;
			i24.scaleY = 0.5;
			i26.scaleX = 0.5;
			i26.y = -18.4;
			i26.scaleY = 0.5;
		};
		f = l.Add();
		f.Add(i24);
		f.Add(i26);
		setFrames(l);
	}
}
public class GoldenKeyAppear : MovieClip{ 
	public GoldenKeyAppear() {
		var filter_0 = new BlurFilter(){blurX = 2, blurY = 2};
		var filter_1 = new GlowFilter(){strength = 1.21, color = 16777215, blurX = 13, blurY = 13};
		var i31 = new symbol_8(){scaleX = 0.5 , filters = new as3.Array(new object[]{}) , scaleY = 0.5};
		addChild(i31);//0
		var i33 = new casesKeysResources_fla.ef1_5(){x = -0.3 , scaleX = 0.46 , y = 13.4 , scaleY = 0.46 , filters = new as3.Array(new object[]{filter_1,filter_0})};
		addChild(i33);//1
		FrameInfo f;
		var l= new Frames(15);
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.x = 0;
			i31.scaleX = 0.5;
			i31.y = 0;
			i31.scaleY = 0.5;
			i31.rotation = 0;
			i31.alpha = 1;
			i31.filters = new as3.Array(new object[]{});
			i31.scale9Grid = null;
			i31.visible = true;
			i33.x = -0.3;
			i33.scaleX = 0.46;
			i33.y = 13.4;
			i33.scaleY = 0.46;
			i33.rotation = 0;
			i33.alpha = 1;
			i33.filters = new as3.Array(new object[]{filter_1,filter_0});
			i33.scale9Grid = null;
			i33.visible = true;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.46;
			i31.scaleY = 0.58;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.42;
			i31.scaleY = 0.65;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.38;
			i31.scaleY = 0.73;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.46;
			i31.scaleY = 0.65;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.55;
			i31.scaleY = 0.56;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.63;
			i31.scaleY = 0.48;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.72;
			i31.scaleY = 0.39;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.68;
			i31.scaleY = 0.41;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.64;
			i31.scaleY = 0.43;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.61;
			i31.scaleY = 0.45;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.57;
			i31.scaleY = 0.47;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.54;
			i31.scaleY = 0.48;
		};
		f = l.Add();
		f.Add(i31);
		f.Add(i33);
		f += () => {
			i31.scaleX = 0.5;
			i31.scaleY = 0.5;
		};
		f = l.Add();
		f.Add(i31);
		setFrames(l);
	}
}
public class KeyChatIcon : BitmapData{ 
	public KeyChatIcon() {
		width = 22;
		height = 21;
		setPixels("662f30eba308011afe509ee0678efcdb");
	}
}
public class KeyIconDiagonal : BitmapData{ 
	public KeyIconDiagonal() {
		width = 23;
		height = 26;
		setPixels("cf8f9137569c5f0eeacf494a9c4c9aed");
	}
}
public class RegularCaseAppear : MovieClip{ 
	public RegularCaseAppear() {
		var filter_0 = new BlurFilter(){blurX = 2, blurY = 2};
		var filter_1 = new GlowFilter(){strength = 1.21, color = 16777215, blurX = 13, blurY = 13};
		var i36 = new symbol_10(){scaleX = 0.5 , y = 14.9 , scaleY = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i36);//0
		var i38 = new symbol_12(){scaleX = 0.5 , y = -18.4 , scaleY = 0.5 , filters = new as3.Array(new object[]{})};
		addChild(i38);//1
		var i40 = new casesKeysResources_fla.ef1_5(){x = -1.4 , scaleX = 0.46 , y = 6.5 , scaleY = 0.46 , filters = new as3.Array(new object[]{filter_1,filter_0})};
		addChild(i40);//2
		FrameInfo f;
		var l= new Frames(15);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.x = 0;
			i36.scaleX = 0.5;
			i36.y = 14.9;
			i36.scaleY = 0.5;
			i36.rotation = 0;
			i36.alpha = 1;
			i36.filters = new as3.Array(new object[]{});
			i36.scale9Grid = null;
			i36.visible = true;
			i38.x = 0;
			i38.scaleX = 0.5;
			i38.y = -18.4;
			i38.scaleY = 0.5;
			i38.rotation = 0;
			i38.alpha = 1;
			i38.filters = new as3.Array(new object[]{});
			i38.scale9Grid = null;
			i38.visible = true;
			i40.x = -1.4;
			i40.scaleX = 0.46;
			i40.y = 6.5;
			i40.scaleY = 0.46;
			i40.rotation = 0;
			i40.alpha = 1;
			i40.filters = new as3.Array(new object[]{filter_1,filter_0});
			i40.scale9Grid = null;
			i40.visible = true;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.49;
			i36.y = 16.1;
			i36.scaleY = 0.54;
			i38.scaleX = 0.49;
			i38.y = -19.8;
			i38.scaleY = 0.54;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.47;
			i36.y = 17.2;
			i36.scaleY = 0.58;
			i38.scaleX = 0.47;
			i38.y = -21.2;
			i38.scaleY = 0.58;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.46;
			i36.y = 18.4;
			i36.scaleY = 0.62;
			i38.scaleX = 0.46;
			i38.y = -22.6;
			i38.scaleY = 0.62;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.49;
			i36.y = 17.1;
			i36.scaleY = 0.58;
			i38.scaleX = 0.49;
			i38.y = -21.1;
			i38.scaleY = 0.58;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.52;
			i36.y = 15.9;
			i36.scaleY = 0.53;
			i38.scaleX = 0.52;
			i38.y = -19.6;
			i38.scaleY = 0.53;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.55;
			i36.y = 14.7;
			i36.scaleY = 0.49;
			i38.scaleX = 0.55;
			i38.y = -18;
			i38.scaleY = 0.49;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.58;
			i36.y = 13.3;
			i36.scaleY = 0.45;
			i38.scaleX = 0.58;
			i38.y = -16.4;
			i38.scaleY = 0.45;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.57;
			i36.y = 13.6;
			i36.scaleY = 0.46;
			i38.scaleX = 0.57;
			i38.y = -16.8;
			i38.scaleY = 0.46;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.56;
			i36.y = 13.8;
			i36.scaleY = 0.47;
			i38.scaleX = 0.56;
			i38.y = -17.1;
			i38.scaleY = 0.47;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.54;
			i36.y = 14.2;
			i36.scaleY = 0.48;
			i38.scaleX = 0.54;
			i38.y = -17.4;
			i38.scaleY = 0.48;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.53;
			i36.y = 14.4;
			i38.scaleX = 0.53;
			i38.y = -17.7;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.52;
			i36.y = 14.7;
			i36.scaleY = 0.49;
			i38.scaleX = 0.52;
			i38.y = -18.1;
			i38.scaleY = 0.49;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.scaleX = 0.5;
			i36.y = 14.9;
			i36.scaleY = 0.5;
			i38.scaleX = 0.5;
			i38.y = -18.4;
			i38.scaleY = 0.5;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		setFrames(l);
	}
}
public class RegularKeyAppear : MovieClip{ 
	public RegularKeyAppear() {
		var filter_0 = new BlurFilter(){blurX = 2, blurY = 2};
		var filter_1 = new GlowFilter(){strength = 1.21, color = 16777215, blurX = 13, blurY = 13};
		var i43 = new symbol_15(){scaleX = 0.5 , filters = new as3.Array(new object[]{}) , scaleY = 0.5};
		addChild(i43);//0
		var i45 = new casesKeysResources_fla.ef1_5(){x = -0.3 , scaleX = 0.46 , y = 13.4 , scaleY = 0.46 , filters = new as3.Array(new object[]{filter_1,filter_0})};
		addChild(i45);//1
		FrameInfo f;
		var l= new Frames(15);
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.x = 0;
			i43.scaleX = 0.5;
			i43.y = 0;
			i43.scaleY = 0.5;
			i43.rotation = 0;
			i43.alpha = 1;
			i43.filters = new as3.Array(new object[]{});
			i43.scale9Grid = null;
			i43.visible = true;
			i45.x = -0.3;
			i45.scaleX = 0.46;
			i45.y = 13.4;
			i45.scaleY = 0.46;
			i45.rotation = 0;
			i45.alpha = 1;
			i45.filters = new as3.Array(new object[]{filter_1,filter_0});
			i45.scale9Grid = null;
			i45.visible = true;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.46;
			i43.scaleY = 0.58;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.42;
			i43.scaleY = 0.65;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.38;
			i43.scaleY = 0.73;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.46;
			i43.scaleY = 0.65;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.55;
			i43.scaleY = 0.56;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.63;
			i43.scaleY = 0.48;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.72;
			i43.scaleY = 0.39;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.68;
			i43.scaleY = 0.41;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.64;
			i43.scaleY = 0.43;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.61;
			i43.scaleY = 0.45;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.57;
			i43.scaleY = 0.47;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.54;
			i43.scaleY = 0.48;
		};
		f = l.Add();
		f.Add(i43);
		f.Add(i45);
		f += () => {
			i43.scaleX = 0.5;
			i43.scaleY = 0.5;
		};
		f = l.Add();
		f.Add(i43);
		setFrames(l);
	}
}
namespace casesKeysResources_fla
{	public class ef1_5 : MovieClip{ 
		public ef1_5() {
			var i20 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i20);//0
			FrameInfo f;
			var l= new Frames(14);
			f = l.Add();
			f.Add(i20);
			f += () => {
				i20.x = 0;
				i20.scaleX = 1;
				i20.y = 0;
				i20.scaleY = 1;
				i20.rotation = 0;
				i20.alpha = 1;
				i20.filters = new as3.Array(new object[]{});
				i20.scale9Grid = null;
				i20.visible = true;
			};
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			f.Add(i20);
			f = l.Add();
			setFrames(l);
		}
	}
}
namespace casesKeysResources.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("7c6b15b9ed8accca52800b86d4e8afc4", -57.7, -74.9, 154.35000000000002, 83.9, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("3047139ece7795cf6292563e6bb03714", -6.75, -6.5, 13.5, 13, 1, 1);
		}
	}
	public class symbol_10 : MovieClip{ 
		public symbol_10() {
			var i37 = new symbol_9(){filters = new as3.Array(new object[]{})};
			addChild(i37);//0
		}
	}
	public class symbol_11 : Shape{ 
		public symbol_11() {
			setGraphics("fa88a703a25aca27f27ffa1f941b7975", -87.85, -41.7, 175.7, 83.35, 1, 1);
		}
	}
	public class symbol_12 : MovieClip{ 
		public symbol_12() {
			var i39 = new symbol_11(){filters = new as3.Array(new object[]{})};
			addChild(i39);//0
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("7c6b15b9ed8accca52800b86d4e8afc4", -57.7, -74.9, 154.35000000000002, 83.9, 1, 1);
		}
	}
	public class symbol_14 : Shape{ 
		public symbol_14() {
			setGraphics("f64c428c613728f0737711b788507ecd", -54.7, -37.25, 109.4, 74.5, 1, 1);
		}
	}
	public class symbol_15 : MovieClip{ 
		public symbol_15() {
			var i44 = new symbol_14(){filters = new as3.Array(new object[]{})};
			addChild(i44);//0
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("ed2dd3bd2127915b50e46e206ef8b8b4", -84.7, -48.7, 169.4, 97.35, 1, 1);
		}
	}
	public class symbol_3 : MovieClip{ 
		public symbol_3() {
			var i25 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i25);//0
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("0b1062427ebd6ed97f8cc96535ab74a2", -87.85, -41.7, 175.7, 83.35, 1, 1);
		}
	}
	public class symbol_5 : MovieClip{ 
		public symbol_5() {
			var i27 = new symbol_4(){filters = new as3.Array(new object[]{})};
			addChild(i27);//0
		}
	}
	public class symbol_6 : Shape{ 
		public symbol_6() {
			setGraphics("7c6b15b9ed8accca52800b86d4e8afc4", -57.7, -74.9, 154.35000000000002, 83.9, 1, 1);
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("5a65a12aa0f079380e8d191a700f0e8b", -52.65, -35.85, 105.3, 71.7, 1, 1);
		}
	}
	public class symbol_8 : MovieClip{ 
		public symbol_8() {
			var i32 = new symbol_7(){filters = new as3.Array(new object[]{})};
			addChild(i32);//0
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("8059db9a4dd1dc4696322f63079789fa", -84.7, -48.7, 169.4, 97.35, 1, 1);
		}
	}
}
