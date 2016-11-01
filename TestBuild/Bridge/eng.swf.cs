using System;

using flash.display;
using System.Collections.Generic;
using eng.swf.privateSymbols;
using RockiePlayer;
using as3;
using flash.filters;

public class Libeng : ResourcesExternalLib{
	public Libeng() {
	vectors = new string[] {
	"2266a3064508c34da7439bd9e4c37609",
	"1c74e91adcffee2879f6c6898f7ea2bf",
	"151b04cd31fb0efdc5b4fc6bdc3ad254",
	"7e223c7da8f70df37f75cf18965176ab",
	"8e4a73517502a29fcc9059a5c4c147dc",
	"1e97490cff6268adb8c64c26d47ed4fc",
	"629afa1be7a1ab4692a981479bc97f0c",
	"35405d2bf8083b392c38fca40a05a6d5",
	"71c767165fcd172fd1a93c80db8a2131",
	"9a478cc8e74a234eab39e08d6022f4a9",
	"dc8932a0702252aac97c8e7169d596ac",
	"194dea5e2e366ffa72889aeb8fd40737",
	"a85f47a2f873b71b4d9b553b7c396238",
	"25e63820c3266112b34bdf5d1460e016",
	"3a38ebc54936e513ed45792e6c2186ee",
	"0f912d19ab7db633d6586ea11b4c1d6f"
	};
	graphics = new string[] {
	"undefined",
	"d921d36b79d7f33cb8afdbd08ea4c63d",
	"9dfc4698f2a8b3babb42c19083be13a5",
	"619699e49a4a68fe3f058575c535c4e5",
	"ca8126540739778c00f9a2290dec13b7",
	"a545289cbba1e2d52cbea09fe24a27e2",
	"54acdd83c42b0adb9a0c74ba2ae71bd2",
	"e61605acdbc32e217fb69fd2a8e447e8",
	"2a4d15f4cb3aa3d3b763e0ac96dbe709",
	"74fbff35553e4b4700423b021a360e3c",
	"bc5d8219f5f51e46cc33ec4193425dab"
	};
	}
}
public class Booster5BlockEng : BitmapData{ 
	public Booster5BlockEng() {
		width = 120;
		height = 100;
		setPixels("ca8126540739778c00f9a2290dec13b7");
	}
}
public class BoosterSuperEng : BitmapData{ 
	public BoosterSuperEng() {
		width = 120;
		height = 193;
		setPixels("a545289cbba1e2d52cbea09fe24a27e2");
	}
}
public class BoxOpenPetMovie2Eng : MovieClip{ 
	public BoxOpenPetMovie2Eng() {
		var filter_0 = new GlowFilter(){strength = 1, color = 16777134, blurX = 5, blurY = 5};
		var i22 = new symbol_1(){x = -5.6 , alpha = 0.4 , y = 28.3 , filters = new as3.Array(new object[]{})};
		addChild(i22);//0
		var i24 = new symbol_3(){x = -5.6 , y = -8.8 , filters = new as3.Array(new object[]{})};
		addChild(i24);//1
		var i120 = new symbol_24(){x = 22.3 , scaleX = 0.87 , y = -16 , scaleY = 1.18 , filters = new as3.Array(new object[]{})};
		addChild(i120);//1
		var i122 = new symbol_26(){x = -11.8 , scaleX = 0.87 , y = -10.6 , scaleY = 1.18 , filters = new as3.Array(new object[]{})};
		addChild(i122);//2
		var i26 = new symbol_5(){x = -48.1 , y = -3.6 , filters = new as3.Array(new object[]{})};
		addChild(i26);//2
		var i124 = new symbol_28(){x = -14.4 , scaleX = 0.87 , y = -10.6 , scaleY = 1.18 , filters = new as3.Array(new object[]{})};
		addChild(i124);//3
		var i28 = new symbol_7(){x = 29.2 , y = -8 , filters = new as3.Array(new object[]{})};
		addChild(i28);//3
		var i30 = new symbol_9(){x = 19.8 , y = -3.6 , filters = new as3.Array(new object[]{})};
		addChild(i30);//4
		var i126 = new symbol_30(){x = -11.4 , scaleX = 0.87 , y = 1.1 , scaleY = 1.18 , filters = new as3.Array(new object[]{})};
		addChild(i126);//4
		var i128 = new symbol_32(){x = -4.7 , scaleX = 0.87 , y = -60.3 , scaleY = 1.18 , filters = new as3.Array(new object[]{})};
		addChild(i128);//5
		var i32 = new eng_fla.open_7(){x = -3.8 , y = -3.8 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i32);//5
		var i130 = new symbol_34(){x = -7.5 , scaleX = 0.87 , y = -60.3 , scaleY = 1.18 , filters = new as3.Array(new object[]{})};
		addChild(i130);//6
		FrameInfo f;
		var l= new Frames(21);
		f = l.Add();
		f.Add(i22);
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f.Add(i30);
		f += () => {
			i22.x = -5.6;
			i22.scaleX = 1;
			i22.y = 28.3;
			i22.scaleY = 1;
			i22.rotation = 0;
			i22.alpha = 0.4;
			i22.filters = new as3.Array(new object[]{});
			i22.scale9Grid = null;
			i22.visible = true;
			i24.x = -5.6;
			i24.scaleX = 1;
			i24.y = -8.8;
			i24.scaleY = 1;
			i24.rotation = 0;
			i24.alpha = 1;
			i24.filters = new as3.Array(new object[]{});
			i24.scale9Grid = null;
			i24.visible = true;
			i26.x = -48.1;
			i26.scaleX = 1;
			i26.y = -3.6;
			i26.scaleY = 1;
			i26.rotation = 0;
			i26.alpha = 1;
			i26.filters = new as3.Array(new object[]{});
			i26.scale9Grid = null;
			i26.visible = true;
			i28.x = 29.2;
			i28.scaleX = 1;
			i28.y = -8;
			i28.scaleY = 1;
			i28.rotation = 0;
			i28.alpha = 1;
			i28.filters = new as3.Array(new object[]{});
			i28.scale9Grid = null;
			i28.visible = true;
			i30.x = 19.8;
			i30.scaleX = 1;
			i30.y = -3.6;
			i30.scaleY = 1;
			i30.rotation = 0;
			i30.alpha = 1;
			i30.filters = new as3.Array(new object[]{});
			i30.scale9Grid = null;
			i30.visible = true;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f.Add(i30);
		f += () => {
			i22.x = -6.3;
			i22.scaleX = 1.09;
			i22.y = 28.7;
			i22.scaleY = 0.95;
			i24.x = -6.3;
			i24.scaleX = 1.09;
			i24.y = -6.5;
			i24.scaleY = 0.95;
			i26.x = -52.5;
			i26.scaleX = 1.09;
			i26.y = -1.6;
			i26.scaleY = 0.95;
			i28.x = 31.6;
			i28.scaleX = 1.09;
			i28.y = -5.8;
			i28.scaleY = 0.95;
			i30.x = 21.3;
			i30.scaleX = 1.09;
			i30.y = -1.6;
			i30.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f.Add(i30);
		f += () => {
			i22.x = -7;
			i22.scaleX = 1.17;
			i22.y = 29.1;
			i22.scaleY = 0.9;
			i24.x = -7;
			i24.scaleX = 1.17;
			i24.y = -4.3;
			i24.scaleY = 0.9;
			i26.x = -56.9;
			i26.scaleX = 1.17;
			i26.y = 0.4;
			i26.scaleY = 0.9;
			i28.x = 33.9;
			i28.scaleX = 1.17;
			i28.y = -3.5;
			i28.scaleY = 0.9;
			i30.x = 22.8;
			i30.scaleX = 1.17;
			i30.y = 0.4;
			i30.scaleY = 0.9;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f.Add(i30);
		f.Add(i32);
		f += () => {
			i22.x = -7.7;
			i22.scaleX = 1.26;
			i22.y = 29.6;
			i22.scaleY = 0.85;
			i24.x = -7.7;
			i24.scaleX = 1.26;
			i24.y = -2;
			i24.scaleY = 0.85;
			i26.x = -61.3;
			i26.scaleX = 1.26;
			i26.y = 2.4;
			i26.scaleY = 0.85;
			i28.x = 36.3;
			i28.scaleX = 1.26;
			i28.y = -1.4;
			i28.scaleY = 0.85;
			i30.x = 24.4;
			i30.scaleX = 1.26;
			i30.y = 2.4;
			i30.scaleY = 0.85;
			i32.x = -3.8;
			i32.scaleX = 1;
			i32.y = -3.8;
			i32.scaleY = 1;
			i32.rotation = 0;
			i32.alpha = 1;
			i32.filters = new as3.Array(new object[]{filter_0});
			i32.scale9Grid = null;
			i32.visible = true;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f.Add(i30);
		f.Add(i32);
		f += () => {
			i22.x = -6.8;
			i22.scaleX = 1.16;
			i22.y = 28.9;
			i22.scaleY = 0.93;
			i24.x = -6.8;
			i24.scaleX = 1.16;
			i24.y = -5.7;
			i24.scaleY = 0.93;
			i26.x = -55.1;
			i26.scaleX = 1.07;
			i26.y = -0.8;
			i26.scaleY = 0.91;
			i28.x = 33;
			i28.scaleX = 1.07;
			i28.y = -4.5;
			i28.scaleY = 0.89;
			i30.x = 21.7;
			i30.scaleX = 1.03;
			i30.y = -0.8;
			i30.scaleY = 0.91;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f.Add(i30);
		f.Add(i32);
		f += () => {
			i22.x = -6.1;
			i22.scaleX = 1.07;
			i22.y = 28.1;
			i22.scaleY = 1.01;
			i24.x = -6.1;
			i24.scaleX = 1.07;
			i24.y = -9.2;
			i24.scaleY = 1.01;
			i26.x = -48.8;
			i26.scaleX = 0.88;
			i26.y = -3.9;
			i26.scaleY = 0.97;
			i28.x = 29.7;
			i28.scaleX = 0.87;
			i28.y = -7.6;
			i28.scaleY = 0.93;
			i30.x = 19.1;
			i30.scaleX = 0.8;
			i30.y = -4;
			i30.scaleY = 0.97;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i24);
		f.Add(i26);
		f.Add(i28);
		f.Add(i30);
		f.Add(i32);
		f += () => {
			i22.x = -5.3;
			i22.scaleX = 0.97;
			i22.y = 27.4;
			i22.scaleY = 1.09;
			i24.x = -5.3;
			i24.scaleX = 0.97;
			i24.y = -12.9;
			i24.scaleY = 1.09;
			i26.x = -42.6;
			i26.scaleX = 0.7;
			i26.y = -7;
			i26.scaleY = 1.02;
			i28.x = 26.4;
			i28.scaleX = 0.67;
			i28.y = -10.8;
			i28.scaleY = 0.96;
			i30.x = 16.4;
			i30.scaleX = 0.56;
			i30.y = -7.3;
			i30.scaleY = 1.03;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i24);
		f.Add(i120);
		f.Add(i122);
		f.Add(i26);
		f.Add(i124);
		f.Add(i28);
		f.Add(i30);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i22.x = -4.5;
			i22.scaleX = 0.87;
			i22.y = 26.8;
			i22.scaleY = 1.17;
			i24.x = -4.5;
			i24.scaleX = 0.87;
			i24.y = -16.6;
			i24.scaleY = 1.17;
			i120.x = 22.3;
			i120.scaleX = 0.87;
			i120.y = -16;
			i120.scaleY = 1.18;
			i120.rotation = 0;
			i120.alpha = 1;
			i120.filters = new as3.Array(new object[]{});
			i120.scale9Grid = null;
			i120.visible = true;
			i122.x = -11.8;
			i122.scaleX = 0.87;
			i122.y = -10.6;
			i122.scaleY = 1.18;
			i122.rotation = 0;
			i122.alpha = 1;
			i122.filters = new as3.Array(new object[]{});
			i122.scale9Grid = null;
			i122.visible = true;
			i26.x = -36.4;
			i26.scaleX = 0.51;
			i26.y = -10.2;
			i26.scaleY = 1.08;
			i124.x = -14.4;
			i124.scaleX = 0.87;
			i124.y = -10.6;
			i124.scaleY = 1.18;
			i124.rotation = 0;
			i124.alpha = 1;
			i124.filters = new as3.Array(new object[]{});
			i124.scale9Grid = null;
			i124.visible = true;
			i28.x = 23.1;
			i28.scaleX = 0.47;
			i28.y = -13.9;
			i28.scaleY = 1;
			i30.x = 13.8;
			i30.scaleX = 0.33;
			i30.y = -10.5;
			i30.scaleY = 1.08;
			i126.x = -11.4;
			i126.scaleX = 0.87;
			i126.y = 1.1;
			i126.scaleY = 1.18;
			i126.rotation = 0;
			i126.alpha = 1;
			i126.filters = new as3.Array(new object[]{});
			i126.scale9Grid = null;
			i126.visible = true;
			i128.x = -4.7;
			i128.scaleX = 0.87;
			i128.y = -60.3;
			i128.scaleY = 1.18;
			i128.rotation = 0;
			i128.alpha = 1;
			i128.filters = new as3.Array(new object[]{});
			i128.scale9Grid = null;
			i128.visible = true;
			i130.x = -7.5;
			i130.scaleX = 0.87;
			i130.y = -60.3;
			i130.scaleY = 1.18;
			i130.rotation = 0;
			i130.alpha = 1;
			i130.filters = new as3.Array(new object[]{});
			i130.scale9Grid = null;
			i130.visible = true;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i22.x = -4.9;
			i22.scaleX = 0.91;
			i22.y = 27.3;
			i22.scaleY = 1.11;
			i22.alpha = 0.3;
			i120.x = 26.1;
			i120.y = -18.9;
			i120.rotation = 3;
			i122.x = -22.7;
			i122.scaleX = 0.83;
			i122.y = -12.6;
			i122.scaleY = 1.24;
			i122.rotation = -12;
			i124.x = -24.7;
			i124.scaleX = 0.83;
			i124.y = -12.6;
			i124.scaleY = 1.24;
			i124.rotation = -12;
			i126.x = -21.4;
			i126.scaleX = 0.85;
			i126.y = -0.9;
			i126.scaleY = 1.2;
			i126.rotation = -22;
			i128.x = -4.3;
			i128.y = -67.8;
			i128.rotation = 6;
			i130.x = -7;
			i130.y = -68.1;
			i130.rotation = 6;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i22.x = -5.3;
			i22.scaleX = 0.96;
			i22.y = 27.8;
			i22.scaleY = 1.06;
			i22.alpha = 0.1;
			i120.x = 30;
			i120.y = -21.9;
			i120.rotation = 7;
			i122.x = -33.6;
			i122.scaleX = 0.8;
			i122.y = -14.7;
			i122.scaleY = 1.29;
			i122.rotation = -24;
			i124.x = -35;
			i124.scaleX = 0.79;
			i124.y = -14.4;
			i124.scaleY = 1.3;
			i124.rotation = -25;
			i126.x = -31.4;
			i126.scaleX = 0.83;
			i126.y = -3.1;
			i126.scaleY = 1.23;
			i126.rotation = -44;
			i128.x = -3.9;
			i128.y = -75.3;
			i128.rotation = 12;
			i130.x = -6.6;
			i130.y = -75.9;
			i130.rotation = 12;
		};
		f = l.Add();
		f.Add(i22);
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i22.x = -5.6;
			i22.scaleX = 1;
			i22.y = 28.3;
			i22.scaleY = 1;
			i22.alpha = 0;
			i120.x = 33.9;
			i120.y = -24.8;
			i120.rotation = 11;
			i122.x = -44.5;
			i122.scaleX = 0.76;
			i122.y = -16.8;
			i122.scaleY = 1.35;
			i122.rotation = -37;
			i124.x = -45.3;
			i124.scaleX = 0.76;
			i124.y = -16.4;
			i124.scaleY = 1.36;
			i124.rotation = -38;
			i126.x = -41.4;
			i126.scaleX = 0.82;
			i126.y = -5.4;
			i126.scaleY = 1.25;
			i126.rotation = -67;
			i128.x = -3.5;
			i128.y = -82.7;
			i128.rotation = 18;
			i130.x = -6.2;
			i130.y = -83.6;
			i130.rotation = 18;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 35.5;
			i120.rotation = 13;
			i120.alpha = 0.8;
			i122.x = -45.9;
			i122.y = -17.9;
			i122.rotation = -38;
			i122.alpha = 0.8;
			i124.x = -46.5;
			i124.y = -17.6;
			i124.scaleY = 1.35;
			i124.rotation = -39;
			i124.alpha = 0.8;
			i126.x = -42.5;
			i126.y = -6.7;
			i126.rotation = -68;
			i126.alpha = 0.8;
			i128.x = -1.9;
			i128.y = -86.5;
			i128.rotation = 20;
			i128.alpha = 0.8;
			i130.x = -4.5;
			i130.y = -87.5;
			i130.rotation = 20;
			i130.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 37.1;
			i120.y = -24.7;
			i120.rotation = 15;
			i120.alpha = 0.7;
			i122.x = -47.1;
			i122.y = -19.1;
			i122.rotation = -39;
			i122.alpha = 0.7;
			i124.x = -47.8;
			i124.y = -18.6;
			i124.rotation = -40;
			i124.alpha = 0.7;
			i126.x = -43.6;
			i126.y = -7.8;
			i126.rotation = -69;
			i126.alpha = 0.7;
			i128.x = -0.6;
			i128.y = -89.8;
			i128.rotation = 22;
			i128.alpha = 0.7;
			i130.x = -3.2;
			i130.y = -91;
			i130.rotation = 22;
			i130.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 38.5;
			i120.y = -24.8;
			i120.rotation = 17;
			i120.alpha = 0.5;
			i122.x = -48.2;
			i122.y = -19.9;
			i122.rotation = -40;
			i122.alpha = 0.5;
			i124.x = -49;
			i124.y = -19.6;
			i124.rotation = -41;
			i124.alpha = 0.5;
			i126.x = -44.6;
			i126.y = -8.8;
			i126.rotation = -70;
			i126.alpha = 0.5;
			i128.x = 0.7;
			i128.y = -92.9;
			i128.rotation = 24;
			i128.alpha = 0.5;
			i130.x = -1.9;
			i130.y = -94.2;
			i130.rotation = 24;
			i130.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 39.8;
			i120.y = -24.9;
			i120.rotation = 18;
			i120.alpha = 0.4;
			i122.x = -49.3;
			i122.y = -20.9;
			i122.rotation = -41;
			i122.alpha = 0.4;
			i124.x = -50;
			i124.y = -20.4;
			i124.rotation = -42;
			i124.alpha = 0.4;
			i126.x = -45.4;
			i126.y = -9.8;
			i126.rotation = -71;
			i126.alpha = 0.4;
			i128.x = 1.9;
			i128.y = -95.7;
			i128.rotation = 26;
			i128.alpha = 0.4;
			i130.x = -0.7;
			i130.y = -97;
			i130.rotation = 26;
			i130.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 40.9;
			i120.y = -24.8;
			i120.rotation = 20;
			i120.alpha = 0.3;
			i122.x = -50.1;
			i122.y = -21.6;
			i122.alpha = 0.3;
			i124.x = -50.9;
			i124.y = -21.3;
			i124.alpha = 0.3;
			i126.x = -46.1;
			i126.y = -10.6;
			i126.rotation = -72;
			i126.alpha = 0.3;
			i128.x = 2.8;
			i128.y = -98.2;
			i128.rotation = 27;
			i128.alpha = 0.3;
			i130.x = 0.3;
			i130.y = -99.5;
			i130.rotation = 27;
			i130.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 41.9;
			i120.rotation = 21;
			i120.alpha = 0.2;
			i122.x = -50.9;
			i122.y = -22.3;
			i122.rotation = -42;
			i122.alpha = 0.2;
			i124.x = -51.7;
			i124.y = -21.9;
			i124.rotation = -43;
			i124.alpha = 0.2;
			i126.x = -46.8;
			i126.y = -11.3;
			i126.alpha = 0.2;
			i128.x = 3.7;
			i128.y = -100.3;
			i128.rotation = 29;
			i128.alpha = 0.2;
			i130.x = 1.2;
			i130.y = -101.7;
			i130.rotation = 29;
			i130.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 42.6;
			i120.y = -24.9;
			i120.rotation = 22;
			i120.alpha = 0.1;
			i122.x = -51.5;
			i122.y = -22.9;
			i122.rotation = -43;
			i122.alpha = 0.1;
			i124.x = -52.4;
			i124.y = -22.4;
			i124.rotation = -44;
			i124.alpha = 0.1;
			i126.x = -47.3;
			i126.y = -11.9;
			i126.rotation = -73;
			i126.alpha = 0.1;
			i128.x = 4.5;
			i128.y = -102.1;
			i128.rotation = 30;
			i128.alpha = 0.1;
			i130.x = 1.9;
			i130.y = -103.5;
			i130.rotation = 30;
			i130.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 43.3;
			i120.y = -24.8;
			i120.rotation = 23;
			i120.alpha = 0;
			i122.x = -52.1;
			i122.y = -23.3;
			i122.alpha = 0;
			i124.x = -52.9;
			i124.y = -22.9;
			i124.alpha = 0;
			i126.x = -47.9;
			i126.y = -12.3;
			i126.alpha = 0;
			i128.x = 5;
			i128.y = -103.5;
			i128.rotation = 31;
			i128.alpha = 0;
			i130.x = 2.5;
			i130.y = -105;
			i130.rotation = 31;
			i130.alpha = 0;
		};
		f = l.Add();
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f.Add(i128);
		f.Add(i32);
		f.Add(i130);
		f += () => {
			i120.x = 43.9;
			i122.x = -52.5;
			i122.y = -23.7;
			i124.x = -53.3;
			i124.y = -23.3;
			i124.scaleY = 1.36;
			i126.x = -48.1;
			i126.y = -12.8;
			i126.rotation = -74;
			i128.x = 5.5;
			i128.y = -104.7;
			i130.x = 3.1;
			i130.y = -106.2;
		};
		f = l.Add();
		f.Add(i32);
		setFrames(l);
	}
}
public class HintRollMovieEng : MovieClip{ 
	public HintRollMovieEng() {
		var i135 = new symbol_35(){filters = new as3.Array(new object[]{})};
		addChild(i135);//0
		FrameInfo f;
		var l= new Frames(12);
		f = l.Add();
		f.Add(i135);
		f += () => {
			i135.x = 0;
			i135.scaleX = 1;
			i135.y = 0;
			i135.scaleY = 1;
			i135.rotation = 0;
			i135.alpha = 1;
			i135.filters = new as3.Array(new object[]{});
			i135.scale9Grid = null;
			i135.visible = true;
		};
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		f = l.Add();
		f.Add(i135);
		setFrames(l);
	}
}
public class HouseOwnerEng : BitmapData{ 
	public HouseOwnerEng() {
		width = 105;
		height = 21;
		setPixels("2a4d15f4cb3aa3d3b763e0ac96dbe709");
	}
}
public class HouseOwnersEng : BitmapData{ 
	public HouseOwnersEng() {
		width = 110;
		height = 21;
		setPixels("bc5d8219f5f51e46cc33ec4193425dab");
	}
}
public class LogoDisconectedEng : BitmapData{ 
	public LogoDisconectedEng() {
		width = 271;
		height = 43;
		setPixels("9dfc4698f2a8b3babb42c19083be13a5");
	}
}
public class LogoEng : BitmapData{ 
	public LogoEng() {
		width = 195;
		height = 35;
		setPixels("d921d36b79d7f33cb8afdbd08ea4c63d");
	}
}
public class MenuHintImgEng : BitmapData{ 
	public MenuHintImgEng() {
		width = 111;
		height = 95;
		setPixels("619699e49a4a68fe3f058575c535c4e5");
	}
}
public class TextBottleEng : BitmapData{ 
	public TextBottleEng() {
		width = 47;
		height = 28;
		setPixels("74fbff35553e4b4700423b021a360e3c");
	}
}
public class TextWantDealEng : BitmapData{ 
	public TextWantDealEng() {
		width = 100;
		height = 19;
		setPixels("54acdd83c42b0adb9a0c74ba2ae71bd2");
	}
}
public class TextWantDealVerticalEng : BitmapData{ 
	public TextWantDealVerticalEng() {
		width = 14;
		height = 99;
		setPixels("e61605acdbc32e217fb69fd2a8e447e8");
	}
}
namespace eng_fla
{	public class open_7 : MovieClip{ 
		public open_7() {
			var i63 = new symbol_10(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i63);//0
			var i89 = new symbol_10(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i89);//0
			var i72 = new symbol_12(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i72);//0
			var i75 = new symbol_10(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i75);//0
			var i61 = new symbol_16(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i61);//0
			var i35 = new symbol_10(){x = -31.1 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i35);//0
			var i38 = new symbol_10(){x = -3 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i38);//0
			var i116 = new symbol_12(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i116);//0
			var i43 = new symbol_12(){x = -3 , alpha = 0.6 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i43);//0
			var i110 = new symbol_10(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i110);//0
			var i52 = new symbol_10(){x = 9.4 , alpha = 0.5 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i52);//0
			var i33 = new symbol_10(){x = 0.3 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i33);//0
			var i96 = new symbol_12(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i96);//0
			var i117 = new symbol_10(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i117);//0
			var i107 = new symbol_16(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i107);//0
			var i44 = new symbol_10(){x = 9.4 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i44);//0
			var i37 = new symbol_12(){x = -31.1 , alpha = 0.6 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i37);//0
			var i51 = new symbol_12(){x = 9.4 , alpha = 0.6 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i51);//0
			var i98 = new symbol_10(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i98);//0
			var i34 = new symbol_11(){x = 0.3 , alpha = 0.6 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i34);//0
			var i85 = new symbol_16(){x = 9.4 , alpha = 0 , y = 17.3 , filters = new as3.Array(new object[]{})};
			addChild(i85);//0
			var i79 = new symbol_10(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i79);//1
			var i99 = new symbol_16(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i99);//1
			var i86 = new symbol_12(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i86);//1
			var i108 = new symbol_12(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i108);//1
			var i111 = new symbol_10(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i111);//1
			var i62 = new symbol_12(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i62);//1
			var i53 = new symbol_16(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i53);//1
			var i102 = new symbol_10(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i102);//1
			var i55 = new symbol_10(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i55);//1
			var i64 = new symbol_10(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i64);//1
			var i118 = new symbol_16(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i118);//1
			var i36 = new symbol_10(){x = 0.3 , alpha = 0.5 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i36);//1
			var i90 = new symbol_10(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i90);//1
			var i76 = new symbol_16(){x = -3 , alpha = 0 , y = -39.6 , filters = new as3.Array(new object[]{})};
			addChild(i76);//1
			var i114 = new symbol_10(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i114);//2
			var i93 = new symbol_10(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i93);//2
			var i49 = new symbol_10(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i49);//2
			var i45 = new symbol_16(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i45);//2
			var i56 = new symbol_10(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i56);//2
			var i54 = new symbol_12(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i54);//2
			var i112 = new symbol_16(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i112);//2
			var i100 = new symbol_12(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i100);//2
			var i40 = new symbol_10(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i40);//2
			var i65 = new symbol_16(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i65);//2
			var i91 = new symbol_16(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i91);//2
			var i103 = new symbol_10(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i103);//2
			var i68 = new symbol_10(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i68);//2
			var i119 = new symbol_12(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i119);//2
			var i80 = new symbol_10(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i80);//2
			var i77 = new symbol_12(){x = -31.1 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i77);//2
			var i39 = new symbol_13(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i39);//2
			var i113 = new symbol_12(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i113);//3
			var i92 = new symbol_12(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i92);//3
			var i50 = new symbol_10(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i50);//3
			var i94 = new symbol_10(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i94);//3
			var i105 = new symbol_10(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i105);//3
			var i46 = new symbol_12(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i46);//3
			var i104 = new symbol_16(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i104);//3
			var i57 = new symbol_16(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i57);//3
			var i41 = new symbol_14(){y = -0.2 , filters = new as3.Array(new object[]{})};
			addChild(i41);//3
			var i60 = new symbol_10(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i60);//3
			var i66 = new symbol_12(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i66);//3
			var i69 = new symbol_10(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i69);//3
			var i81 = new symbol_16(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i81);//3
			var i115 = new symbol_10(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i115);//3
			var i82 = new symbol_10(){x = 0.3 , alpha = 0 , y = -6.8 , filters = new as3.Array(new object[]{})};
			addChild(i82);//3
			var i42 = new symbol_15(){y = -0.2 , filters = new as3.Array(new object[]{})};
			addChild(i42);//4
			var i58 = new symbol_19(){x = -3 , y = -14.4 , filters = new as3.Array(new object[]{})};
			addChild(i58);//4
			var i70 = new symbol_21(){x = 3.4 , y = 0.1 , filters = new as3.Array(new object[]{})};
			addChild(i70);//4
			var i47 = new symbol_17(){x = -1.1 , y = -22.8 , filters = new as3.Array(new object[]{})};
			addChild(i47);//4
			var i106 = new symbol_12(){x = -25.4 , alpha = 0.6 , y = 21.2 , filters = new as3.Array(new object[]{})};
			addChild(i106);//5
			var i48 = new symbol_18(){x = -1.1 , y = -22.8 , filters = new as3.Array(new object[]{})};
			addChild(i48);//5
			var i109 = new symbol_10(){x = -25.4 , alpha = 0.5 , y = 21.2 , filters = new as3.Array(new object[]{})};
			addChild(i109);//5
			var i71 = new symbol_22(){x = 3.4 , y = 0.1 , filters = new as3.Array(new object[]{})};
			addChild(i71);//5
			var i59 = new symbol_20(){x = -3 , y = -14.4 , filters = new as3.Array(new object[]{})};
			addChild(i59);//5
			var i101 = new symbol_10(){x = -25.4 , y = 21.2 , filters = new as3.Array(new object[]{})};
			addChild(i101);//5
			var i97 = new symbol_10(){x = 30.2 , alpha = 0.5 , y = -1.6 , filters = new as3.Array(new object[]{})};
			addChild(i97);//7
			var i87 = new symbol_10(){x = 30.2 , y = -1.6 , filters = new as3.Array(new object[]{})};
			addChild(i87);//7
			var i95 = new symbol_12(){x = 30.2 , alpha = 0.6 , y = -1.6 , filters = new as3.Array(new object[]{})};
			addChild(i95);//7
			var i73 = new symbol_10(){x = 27.9 , y = -43.5 , filters = new as3.Array(new object[]{})};
			addChild(i73);//9
			var i84 = new symbol_10(){x = 27.9 , alpha = 0.5 , y = -43.5 , filters = new as3.Array(new object[]{})};
			addChild(i84);//9
			var i83 = new symbol_12(){x = 27.9 , alpha = 0.6 , y = -43.5 , filters = new as3.Array(new object[]{})};
			addChild(i83);//9
			var i67 = new symbol_10(){x = -26.4 , y = -36.6 , filters = new as3.Array(new object[]{})};
			addChild(i67);//9
			var i78 = new symbol_10(){x = -26.4 , alpha = 0.5 , y = -36.6 , filters = new as3.Array(new object[]{})};
			addChild(i78);//11
			var i74 = new symbol_12(){x = -26.4 , alpha = 0.6 , y = -36.6 , filters = new as3.Array(new object[]{})};
			addChild(i74);//11
			var i88 = new symbol_16(){x = -26.4 , alpha = 0 , y = -36.6 , filters = new as3.Array(new object[]{})};
			addChild(i88);//11
			FrameInfo f;
			var l= new Frames(44);
			f = l.Add();
			f.Add(i33);
			f += () => {
				i33.x = 0.3;
				i33.scaleX = 1;
				i33.y = -6.8;
				i33.scaleY = 1;
				i33.rotation = 0;
				i33.alpha = 1;
				i33.filters = new as3.Array(new object[]{});
				i33.scale9Grid = null;
				i33.visible = true;
			};
			f = l.Add();
			f.Add(i33);
			f += () => {
				i33.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i33);
			f += () => {
				i33.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i34);
			f += () => {
				i34.x = 0.3;
				i34.scaleX = 1;
				i34.y = -6.8;
				i34.scaleY = 1;
				i34.rotation = 0;
				i34.alpha = 0.6;
				i34.filters = new as3.Array(new object[]{});
				i34.scale9Grid = null;
				i34.visible = true;
			};
			f = l.Add();
			f.Add(i35);
			f.Add(i36);
			f += () => {
				i35.x = -31.1;
				i35.scaleX = 1;
				i35.y = -6.8;
				i35.scaleY = 1;
				i35.rotation = 0;
				i35.alpha = 1;
				i35.filters = new as3.Array(new object[]{});
				i35.scale9Grid = null;
				i35.visible = true;
				i36.x = 0.3;
				i36.scaleX = 1;
				i36.y = -6.8;
				i36.scaleY = 1;
				i36.rotation = 0;
				i36.alpha = 0.5;
				i36.filters = new as3.Array(new object[]{});
				i36.scale9Grid = null;
				i36.visible = true;
			};
			f = l.Add();
			f.Add(i35);
			f.Add(i36);
			f += () => {
				i35.alpha = 0.9;
				i36.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i35);
			f.Add(i36);
			f += () => {
				i35.alpha = 0.8;
				i36.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i37);
			f.Add(i36);
			f += () => {
				i37.x = -31.1;
				i37.scaleX = 1;
				i37.y = -6.8;
				i37.scaleY = 1;
				i37.rotation = 0;
				i37.alpha = 0.6;
				i37.filters = new as3.Array(new object[]{});
				i37.scale9Grid = null;
				i37.visible = true;
				i36.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i38);
			f.Add(i36);
			f.Add(i39);
			f += () => {
				i38.x = -3;
				i38.scaleX = 1;
				i38.y = -39.6;
				i38.scaleY = 1;
				i38.rotation = 0;
				i38.alpha = 1;
				i38.filters = new as3.Array(new object[]{});
				i38.scale9Grid = null;
				i38.visible = true;
				i36.x = -31.1;
				i36.alpha = 0.5;
				i39.x = 0.3;
				i39.scaleX = 1;
				i39.y = -6.8;
				i39.scaleY = 1;
				i39.rotation = 0;
				i39.alpha = 0;
				i39.filters = new as3.Array(new object[]{});
				i39.scale9Grid = null;
				i39.visible = true;
			};
			f = l.Add();
			f.Add(i38);
			f.Add(i36);
			f.Add(i40);
			f.Add(i41);
			f.Add(i42);
			f += () => {
				i38.alpha = 0.9;
				i36.alpha = 0.4;
				i40.x = 0.3;
				i40.scaleX = 1;
				i40.y = -6.8;
				i40.scaleY = 1;
				i40.rotation = 0;
				i40.alpha = 0;
				i40.filters = new as3.Array(new object[]{});
				i40.scale9Grid = null;
				i40.visible = true;
				i41.x = 0;
				i41.scaleX = 1;
				i41.y = -0.2;
				i41.scaleY = 1;
				i41.rotation = 0;
				i41.alpha = 1;
				i41.filters = new as3.Array(new object[]{});
				i41.scale9Grid = null;
				i41.visible = true;
				i42.x = 0;
				i42.scaleX = 1;
				i42.y = -0.2;
				i42.scaleY = 1;
				i42.rotation = 0;
				i42.alpha = 1;
				i42.filters = new as3.Array(new object[]{});
				i42.scale9Grid = null;
				i42.visible = true;
			};
			f = l.Add();
			f.Add(i38);
			f.Add(i36);
			f.Add(i40);
			f.Add(i41);
			f.Add(i42);
			f += () => {
				i38.alpha = 0.8;
				i36.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i43);
			f.Add(i36);
			f.Add(i40);
			f.Add(i41);
			f.Add(i42);
			f += () => {
				i43.x = -3;
				i43.scaleX = 1;
				i43.y = -39.6;
				i43.scaleY = 1;
				i43.rotation = 0;
				i43.alpha = 0.6;
				i43.filters = new as3.Array(new object[]{});
				i43.scale9Grid = null;
				i43.visible = true;
				i36.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i44);
			f.Add(i36);
			f.Add(i45);
			f.Add(i46);
			f.Add(i41);
			f.Add(i42);
			f.Add(i47);
			f.Add(i48);
			f += () => {
				i44.x = 9.4;
				i44.scaleX = 1;
				i44.y = 17.3;
				i44.scaleY = 1;
				i44.rotation = 0;
				i44.alpha = 1;
				i44.filters = new as3.Array(new object[]{});
				i44.scale9Grid = null;
				i44.visible = true;
				i36.x = -3;
				i36.scaleX = 0.71;
				i36.y = -39.6;
				i36.scaleY = 0.71;
				i36.alpha = 0.5;
				i45.x = -31.1;
				i45.scaleX = 1;
				i45.y = -6.8;
				i45.scaleY = 1;
				i45.rotation = 0;
				i45.alpha = 0;
				i45.filters = new as3.Array(new object[]{});
				i45.scale9Grid = null;
				i45.visible = true;
				i46.x = 0.3;
				i46.scaleX = 1;
				i46.y = -6.8;
				i46.scaleY = 1;
				i46.rotation = 0;
				i46.alpha = 0;
				i46.filters = new as3.Array(new object[]{});
				i46.scale9Grid = null;
				i46.visible = true;
				i47.x = -1.1;
				i47.scaleX = 1;
				i47.y = -22.8;
				i47.scaleY = 1;
				i47.rotation = 0;
				i47.alpha = 1;
				i47.filters = new as3.Array(new object[]{});
				i47.scale9Grid = null;
				i47.visible = true;
				i48.x = -1.1;
				i48.scaleX = 1;
				i48.y = -22.8;
				i48.scaleY = 1;
				i48.rotation = 0;
				i48.alpha = 1;
				i48.filters = new as3.Array(new object[]{});
				i48.scale9Grid = null;
				i48.visible = true;
			};
			f = l.Add();
			f.Add(i44);
			f.Add(i36);
			f.Add(i49);
			f.Add(i50);
			f.Add(i41);
			f.Add(i42);
			f.Add(i47);
			f.Add(i48);
			f += () => {
				i44.alpha = 0.9;
				i36.alpha = 0.4;
				i49.x = -31.1;
				i49.scaleX = 1;
				i49.y = -6.8;
				i49.scaleY = 1;
				i49.rotation = 0;
				i49.alpha = 0;
				i49.filters = new as3.Array(new object[]{});
				i49.scale9Grid = null;
				i49.visible = true;
				i50.x = 0.3;
				i50.scaleX = 1;
				i50.y = -6.8;
				i50.scaleY = 1;
				i50.rotation = 0;
				i50.alpha = 0;
				i50.filters = new as3.Array(new object[]{});
				i50.scale9Grid = null;
				i50.visible = true;
			};
			f = l.Add();
			f.Add(i44);
			f.Add(i36);
			f.Add(i49);
			f.Add(i50);
			f.Add(i41);
			f.Add(i42);
			f.Add(i47);
			f.Add(i48);
			f += () => {
				i44.alpha = 0.8;
				i36.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i51);
			f.Add(i36);
			f.Add(i49);
			f.Add(i50);
			f.Add(i41);
			f.Add(i42);
			f.Add(i47);
			f.Add(i48);
			f += () => {
				i51.x = 9.4;
				i51.scaleX = 1;
				i51.y = 17.3;
				i51.scaleY = 1;
				i51.rotation = 0;
				i51.alpha = 0.6;
				i51.filters = new as3.Array(new object[]{});
				i51.scale9Grid = null;
				i51.visible = true;
				i36.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i52);
			f.Add(i53);
			f.Add(i54);
			f.Add(i50);
			f.Add(i41);
			f.Add(i42);
			f.Add(i47);
			f.Add(i48);
			f += () => {
				i52.x = 9.4;
				i52.scaleX = 1;
				i52.y = 17.3;
				i52.scaleY = 1;
				i52.rotation = 0;
				i52.alpha = 0.5;
				i52.filters = new as3.Array(new object[]{});
				i52.scale9Grid = null;
				i52.visible = true;
				i53.x = -3;
				i53.scaleX = 1;
				i53.y = -39.6;
				i53.scaleY = 1;
				i53.rotation = 0;
				i53.alpha = 0;
				i53.filters = new as3.Array(new object[]{});
				i53.scale9Grid = null;
				i53.visible = true;
				i54.x = -31.1;
				i54.scaleX = 1;
				i54.y = -6.8;
				i54.scaleY = 1;
				i54.rotation = 0;
				i54.alpha = 0;
				i54.filters = new as3.Array(new object[]{});
				i54.scale9Grid = null;
				i54.visible = true;
			};
			f = l.Add();
			f.Add(i52);
			f.Add(i55);
			f.Add(i56);
			f.Add(i57);
			f.Add(i41);
			f.Add(i42);
			f.Add(i58);
			f.Add(i47);
			f.Add(i48);
			f.Add(i59);
			f += () => {
				i52.alpha = 0.4;
				i55.x = -3;
				i55.scaleX = 1;
				i55.y = -39.6;
				i55.scaleY = 1;
				i55.rotation = 0;
				i55.alpha = 0;
				i55.filters = new as3.Array(new object[]{});
				i55.scale9Grid = null;
				i55.visible = true;
				i56.x = -31.1;
				i56.scaleX = 1;
				i56.y = -6.8;
				i56.scaleY = 1;
				i56.rotation = 0;
				i56.alpha = 0;
				i56.filters = new as3.Array(new object[]{});
				i56.scale9Grid = null;
				i56.visible = true;
				i57.x = 0.3;
				i57.scaleX = 1;
				i57.y = -6.8;
				i57.scaleY = 1;
				i57.rotation = 0;
				i57.alpha = 0;
				i57.filters = new as3.Array(new object[]{});
				i57.scale9Grid = null;
				i57.visible = true;
				i58.x = -3;
				i58.scaleX = 1;
				i58.y = -14.4;
				i58.scaleY = 1;
				i58.rotation = 0;
				i58.alpha = 1;
				i58.filters = new as3.Array(new object[]{});
				i58.scale9Grid = null;
				i58.visible = true;
				i59.x = -3;
				i59.scaleX = 1;
				i59.y = -14.4;
				i59.scaleY = 1;
				i59.rotation = 0;
				i59.alpha = 1;
				i59.filters = new as3.Array(new object[]{});
				i59.scale9Grid = null;
				i59.visible = true;
			};
			f = l.Add();
			f.Add(i52);
			f.Add(i55);
			f.Add(i56);
			f.Add(i41);
			f.Add(i60);
			f.Add(i42);
			f.Add(i58);
			f.Add(i47);
			f.Add(i48);
			f.Add(i59);
			f += () => {
				i52.alpha = 0.3;
				i60.x = 0.3;
				i60.scaleX = 1;
				i60.y = -6.8;
				i60.scaleY = 1;
				i60.rotation = 0;
				i60.alpha = 0;
				i60.filters = new as3.Array(new object[]{});
				i60.scale9Grid = null;
				i60.visible = true;
			};
			f = l.Add();
			f.Add(i52);
			f.Add(i55);
			f.Add(i56);
			f.Add(i41);
			f.Add(i60);
			f.Add(i42);
			f.Add(i58);
			f.Add(i47);
			f.Add(i48);
			f.Add(i59);
			f += () => {
				i52.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i61);
			f.Add(i62);
			f.Add(i56);
			f.Add(i41);
			f.Add(i60);
			f.Add(i42);
			f.Add(i58);
			f.Add(i47);
			f.Add(i48);
			f.Add(i59);
			f += () => {
				i61.x = 9.4;
				i61.scaleX = 1;
				i61.y = 17.3;
				i61.scaleY = 1;
				i61.rotation = 0;
				i61.alpha = 0;
				i61.filters = new as3.Array(new object[]{});
				i61.scale9Grid = null;
				i61.visible = true;
				i62.x = -3;
				i62.scaleX = 1;
				i62.y = -39.6;
				i62.scaleY = 1;
				i62.rotation = 0;
				i62.alpha = 0;
				i62.filters = new as3.Array(new object[]{});
				i62.scale9Grid = null;
				i62.visible = true;
			};
			f = l.Add();
			f.Add(i63);
			f.Add(i64);
			f.Add(i65);
			f.Add(i41);
			f.Add(i66);
			f.Add(i58);
			f.Add(i47);
			f.Add(i48);
			f.Add(i59);
			f.Add(i67);
			f += () => {
				i63.x = 9.4;
				i63.scaleX = 1;
				i63.y = 17.3;
				i63.scaleY = 1;
				i63.rotation = 0;
				i63.alpha = 0;
				i63.filters = new as3.Array(new object[]{});
				i63.scale9Grid = null;
				i63.visible = true;
				i64.x = -3;
				i64.scaleX = 1;
				i64.y = -39.6;
				i64.scaleY = 1;
				i64.rotation = 0;
				i64.alpha = 0;
				i64.filters = new as3.Array(new object[]{});
				i64.scale9Grid = null;
				i64.visible = true;
				i65.x = -31.1;
				i65.scaleX = 1;
				i65.y = -6.8;
				i65.scaleY = 1;
				i65.rotation = 0;
				i65.alpha = 0;
				i65.filters = new as3.Array(new object[]{});
				i65.scale9Grid = null;
				i65.visible = true;
				i66.x = 0.3;
				i66.scaleX = 1;
				i66.y = -6.8;
				i66.scaleY = 1;
				i66.rotation = 0;
				i66.alpha = 0;
				i66.filters = new as3.Array(new object[]{});
				i66.scale9Grid = null;
				i66.visible = true;
				i67.x = -26.4;
				i67.scaleX = 1;
				i67.y = -36.6;
				i67.scaleY = 1;
				i67.rotation = 0;
				i67.alpha = 1;
				i67.filters = new as3.Array(new object[]{});
				i67.scale9Grid = null;
				i67.visible = true;
			};
			f = l.Add();
			f.Add(i63);
			f.Add(i64);
			f.Add(i68);
			f.Add(i41);
			f.Add(i69);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i48);
			f.Add(i71);
			f.Add(i59);
			f.Add(i67);
			f += () => {
				i68.x = -31.1;
				i68.scaleX = 1;
				i68.y = -6.8;
				i68.scaleY = 1;
				i68.rotation = 0;
				i68.alpha = 0;
				i68.filters = new as3.Array(new object[]{});
				i68.scale9Grid = null;
				i68.visible = true;
				i69.x = 0.3;
				i69.scaleX = 1;
				i69.y = -6.8;
				i69.scaleY = 1;
				i69.rotation = 0;
				i69.alpha = 0;
				i69.filters = new as3.Array(new object[]{});
				i69.scale9Grid = null;
				i69.visible = true;
				i70.x = 3.4;
				i70.scaleX = 1;
				i70.y = 0.1;
				i70.scaleY = 1;
				i70.rotation = 0;
				i70.alpha = 1;
				i70.filters = new as3.Array(new object[]{});
				i70.scale9Grid = null;
				i70.visible = true;
				i71.x = 3.4;
				i71.scaleX = 1;
				i71.y = 0.1;
				i71.scaleY = 1;
				i71.rotation = 0;
				i71.alpha = 1;
				i71.filters = new as3.Array(new object[]{});
				i71.scale9Grid = null;
				i71.visible = true;
				i67.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i63);
			f.Add(i64);
			f.Add(i68);
			f.Add(i41);
			f.Add(i69);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i48);
			f.Add(i71);
			f.Add(i59);
			f.Add(i67);
			f += () => {
				i67.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i72);
			f.Add(i64);
			f.Add(i68);
			f.Add(i41);
			f.Add(i69);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i71);
			f.Add(i59);
			f.Add(i73);
			f.Add(i74);
			f += () => {
				i72.x = 9.4;
				i72.scaleX = 1;
				i72.y = 17.3;
				i72.scaleY = 1;
				i72.rotation = 0;
				i72.alpha = 0;
				i72.filters = new as3.Array(new object[]{});
				i72.scale9Grid = null;
				i72.visible = true;
				i73.x = 27.9;
				i73.scaleX = 1;
				i73.y = -43.5;
				i73.scaleY = 1;
				i73.rotation = 0;
				i73.alpha = 1;
				i73.filters = new as3.Array(new object[]{});
				i73.scale9Grid = null;
				i73.visible = true;
				i74.x = -26.4;
				i74.scaleX = 1;
				i74.y = -36.6;
				i74.scaleY = 1;
				i74.rotation = 0;
				i74.alpha = 0.6;
				i74.filters = new as3.Array(new object[]{});
				i74.scale9Grid = null;
				i74.visible = true;
			};
			f = l.Add();
			f.Add(i75);
			f.Add(i76);
			f.Add(i77);
			f.Add(i41);
			f.Add(i69);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i71);
			f.Add(i59);
			f.Add(i73);
			f.Add(i78);
			f += () => {
				i75.x = 9.4;
				i75.scaleX = 1;
				i75.y = 17.3;
				i75.scaleY = 1;
				i75.rotation = 0;
				i75.alpha = 0;
				i75.filters = new as3.Array(new object[]{});
				i75.scale9Grid = null;
				i75.visible = true;
				i76.x = -3;
				i76.scaleX = 1;
				i76.y = -39.6;
				i76.scaleY = 1;
				i76.rotation = 0;
				i76.alpha = 0;
				i76.filters = new as3.Array(new object[]{});
				i76.scale9Grid = null;
				i76.visible = true;
				i77.x = -31.1;
				i77.scaleX = 1;
				i77.y = -6.8;
				i77.scaleY = 1;
				i77.rotation = 0;
				i77.alpha = 0;
				i77.filters = new as3.Array(new object[]{});
				i77.scale9Grid = null;
				i77.visible = true;
				i73.alpha = 0.9;
				i78.x = -26.4;
				i78.scaleX = 1;
				i78.y = -36.6;
				i78.scaleY = 1;
				i78.rotation = 0;
				i78.alpha = 0.5;
				i78.filters = new as3.Array(new object[]{});
				i78.scale9Grid = null;
				i78.visible = true;
			};
			f = l.Add();
			f.Add(i75);
			f.Add(i79);
			f.Add(i80);
			f.Add(i41);
			f.Add(i81);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i71);
			f.Add(i59);
			f.Add(i73);
			f.Add(i78);
			f += () => {
				i79.x = -3;
				i79.scaleX = 1;
				i79.y = -39.6;
				i79.scaleY = 1;
				i79.rotation = 0;
				i79.alpha = 0;
				i79.filters = new as3.Array(new object[]{});
				i79.scale9Grid = null;
				i79.visible = true;
				i80.x = -31.1;
				i80.scaleX = 1;
				i80.y = -6.8;
				i80.scaleY = 1;
				i80.rotation = 0;
				i80.alpha = 0;
				i80.filters = new as3.Array(new object[]{});
				i80.scale9Grid = null;
				i80.visible = true;
				i81.x = 0.3;
				i81.scaleX = 1;
				i81.y = -6.8;
				i81.scaleY = 1;
				i81.rotation = 0;
				i81.alpha = 0;
				i81.filters = new as3.Array(new object[]{});
				i81.scale9Grid = null;
				i81.visible = true;
				i73.alpha = 0.8;
				i78.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i75);
			f.Add(i79);
			f.Add(i80);
			f.Add(i41);
			f.Add(i82);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i71);
			f.Add(i59);
			f.Add(i83);
			f.Add(i78);
			f += () => {
				i82.x = 0.3;
				i82.scaleX = 1;
				i82.y = -6.8;
				i82.scaleY = 1;
				i82.rotation = 0;
				i82.alpha = 0;
				i82.filters = new as3.Array(new object[]{});
				i82.scale9Grid = null;
				i82.visible = true;
				i83.x = 27.9;
				i83.scaleX = 1;
				i83.y = -43.5;
				i83.scaleY = 1;
				i83.rotation = 0;
				i83.alpha = 0.6;
				i83.filters = new as3.Array(new object[]{});
				i83.scale9Grid = null;
				i83.visible = true;
				i78.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i75);
			f.Add(i79);
			f.Add(i80);
			f.Add(i41);
			f.Add(i82);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i71);
			f.Add(i59);
			f.Add(i84);
			f.Add(i78);
			f += () => {
				i84.x = 27.9;
				i84.scaleX = 1;
				i84.y = -43.5;
				i84.scaleY = 1;
				i84.rotation = 0;
				i84.alpha = 0.5;
				i84.filters = new as3.Array(new object[]{});
				i84.scale9Grid = null;
				i84.visible = true;
				i78.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i85);
			f.Add(i86);
			f.Add(i80);
			f.Add(i41);
			f.Add(i82);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i71);
			f.Add(i87);
			f.Add(i84);
			f.Add(i88);
			f += () => {
				i85.x = 9.4;
				i85.scaleX = 1;
				i85.y = 17.3;
				i85.scaleY = 1;
				i85.rotation = 0;
				i85.alpha = 0;
				i85.filters = new as3.Array(new object[]{});
				i85.scale9Grid = null;
				i85.visible = true;
				i86.x = -3;
				i86.scaleX = 1;
				i86.y = -39.6;
				i86.scaleY = 1;
				i86.rotation = 0;
				i86.alpha = 0;
				i86.filters = new as3.Array(new object[]{});
				i86.scale9Grid = null;
				i86.visible = true;
				i87.x = 30.2;
				i87.scaleX = 1;
				i87.y = -1.6;
				i87.scaleY = 1;
				i87.rotation = 0;
				i87.alpha = 1;
				i87.filters = new as3.Array(new object[]{});
				i87.scale9Grid = null;
				i87.visible = true;
				i84.alpha = 0.4;
				i88.x = -26.4;
				i88.scaleX = 1;
				i88.y = -36.6;
				i88.scaleY = 1;
				i88.rotation = 0;
				i88.alpha = 0;
				i88.filters = new as3.Array(new object[]{});
				i88.scale9Grid = null;
				i88.visible = true;
			};
			f = l.Add();
			f.Add(i89);
			f.Add(i90);
			f.Add(i91);
			f.Add(i92);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i71);
			f.Add(i87);
			f.Add(i84);
			f += () => {
				i89.x = 9.4;
				i89.scaleX = 1;
				i89.y = 17.3;
				i89.scaleY = 1;
				i89.rotation = 0;
				i89.alpha = 0;
				i89.filters = new as3.Array(new object[]{});
				i89.scale9Grid = null;
				i89.visible = true;
				i90.x = -3;
				i90.scaleX = 1;
				i90.y = -39.6;
				i90.scaleY = 1;
				i90.rotation = 0;
				i90.alpha = 0;
				i90.filters = new as3.Array(new object[]{});
				i90.scale9Grid = null;
				i90.visible = true;
				i91.x = -31.1;
				i91.scaleX = 1;
				i91.y = -6.8;
				i91.scaleY = 1;
				i91.rotation = 0;
				i91.alpha = 0;
				i91.filters = new as3.Array(new object[]{});
				i91.scale9Grid = null;
				i91.visible = true;
				i92.x = 0.3;
				i92.scaleX = 1;
				i92.y = -6.8;
				i92.scaleY = 1;
				i92.rotation = 0;
				i92.alpha = 0;
				i92.filters = new as3.Array(new object[]{});
				i92.scale9Grid = null;
				i92.visible = true;
				i87.alpha = 0.9;
				i84.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i89);
			f.Add(i90);
			f.Add(i93);
			f.Add(i94);
			f.Add(i58);
			f.Add(i70);
			f.Add(i47);
			f.Add(i71);
			f.Add(i87);
			f.Add(i84);
			f += () => {
				i93.x = -31.1;
				i93.scaleX = 1;
				i93.y = -6.8;
				i93.scaleY = 1;
				i93.rotation = 0;
				i93.alpha = 0;
				i93.filters = new as3.Array(new object[]{});
				i93.scale9Grid = null;
				i93.visible = true;
				i94.x = 0.3;
				i94.scaleX = 1;
				i94.y = -6.8;
				i94.scaleY = 1;
				i94.rotation = 0;
				i94.alpha = 0;
				i94.filters = new as3.Array(new object[]{});
				i94.scale9Grid = null;
				i94.visible = true;
				i87.alpha = 0.8;
				i84.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i89);
			f.Add(i90);
			f.Add(i93);
			f.Add(i94);
			f.Add(i58);
			f.Add(i70);
			f.Add(i71);
			f.Add(i95);
			f += () => {
				i95.x = 30.2;
				i95.scaleX = 1;
				i95.y = -1.6;
				i95.scaleY = 1;
				i95.rotation = 0;
				i95.alpha = 0.6;
				i95.filters = new as3.Array(new object[]{});
				i95.scale9Grid = null;
				i95.visible = true;
			};
			f = l.Add();
			f.Add(i96);
			f.Add(i90);
			f.Add(i93);
			f.Add(i94);
			f.Add(i58);
			f.Add(i70);
			f.Add(i71);
			f.Add(i97);
			f += () => {
				i96.x = 9.4;
				i96.scaleX = 1;
				i96.y = 17.3;
				i96.scaleY = 1;
				i96.rotation = 0;
				i96.alpha = 0;
				i96.filters = new as3.Array(new object[]{});
				i96.scale9Grid = null;
				i96.visible = true;
				i97.x = 30.2;
				i97.scaleX = 1;
				i97.y = -1.6;
				i97.scaleY = 1;
				i97.rotation = 0;
				i97.alpha = 0.5;
				i97.filters = new as3.Array(new object[]{});
				i97.scale9Grid = null;
				i97.visible = true;
			};
			f = l.Add();
			f.Add(i98);
			f.Add(i99);
			f.Add(i100);
			f.Add(i94);
			f.Add(i58);
			f.Add(i70);
			f.Add(i101);
			f.Add(i97);
			f += () => {
				i98.x = 9.4;
				i98.scaleX = 1;
				i98.y = 17.3;
				i98.scaleY = 1;
				i98.rotation = 0;
				i98.alpha = 0;
				i98.filters = new as3.Array(new object[]{});
				i98.scale9Grid = null;
				i98.visible = true;
				i99.x = -3;
				i99.scaleX = 1;
				i99.y = -39.6;
				i99.scaleY = 1;
				i99.rotation = 0;
				i99.alpha = 0;
				i99.filters = new as3.Array(new object[]{});
				i99.scale9Grid = null;
				i99.visible = true;
				i100.x = -31.1;
				i100.scaleX = 1;
				i100.y = -6.8;
				i100.scaleY = 1;
				i100.rotation = 0;
				i100.alpha = 0;
				i100.filters = new as3.Array(new object[]{});
				i100.scale9Grid = null;
				i100.visible = true;
				i101.x = -25.4;
				i101.scaleX = 1;
				i101.y = 21.2;
				i101.scaleY = 1;
				i101.rotation = 0;
				i101.alpha = 1;
				i101.filters = new as3.Array(new object[]{});
				i101.scale9Grid = null;
				i101.visible = true;
				i97.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i98);
			f.Add(i102);
			f.Add(i103);
			f.Add(i104);
			f.Add(i58);
			f.Add(i70);
			f.Add(i101);
			f.Add(i97);
			f += () => {
				i102.x = -3;
				i102.scaleX = 1;
				i102.y = -39.6;
				i102.scaleY = 1;
				i102.rotation = 0;
				i102.alpha = 0;
				i102.filters = new as3.Array(new object[]{});
				i102.scale9Grid = null;
				i102.visible = true;
				i103.x = -31.1;
				i103.scaleX = 1;
				i103.y = -6.8;
				i103.scaleY = 1;
				i103.rotation = 0;
				i103.alpha = 0;
				i103.filters = new as3.Array(new object[]{});
				i103.scale9Grid = null;
				i103.visible = true;
				i104.x = 0.3;
				i104.scaleX = 1;
				i104.y = -6.8;
				i104.scaleY = 1;
				i104.rotation = 0;
				i104.alpha = 0;
				i104.filters = new as3.Array(new object[]{});
				i104.scale9Grid = null;
				i104.visible = true;
				i101.alpha = 0.9;
				i97.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i98);
			f.Add(i102);
			f.Add(i103);
			f.Add(i105);
			f.Add(i58);
			f.Add(i70);
			f.Add(i101);
			f.Add(i97);
			f += () => {
				i105.x = 0.3;
				i105.scaleX = 1;
				i105.y = -6.8;
				i105.scaleY = 1;
				i105.rotation = 0;
				i105.alpha = 0;
				i105.filters = new as3.Array(new object[]{});
				i105.scale9Grid = null;
				i105.visible = true;
				i101.alpha = 0.8;
				i97.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i98);
			f.Add(i102);
			f.Add(i103);
			f.Add(i105);
			f.Add(i70);
			f.Add(i106);
			f += () => {
				i106.x = -25.4;
				i106.scaleX = 1;
				i106.y = 21.2;
				i106.scaleY = 1;
				i106.rotation = 0;
				i106.alpha = 0.6;
				i106.filters = new as3.Array(new object[]{});
				i106.scale9Grid = null;
				i106.visible = true;
			};
			f = l.Add();
			f.Add(i107);
			f.Add(i108);
			f.Add(i103);
			f.Add(i105);
			f.Add(i70);
			f.Add(i109);
			f += () => {
				i107.x = 9.4;
				i107.scaleX = 1;
				i107.y = 17.3;
				i107.scaleY = 1;
				i107.rotation = 0;
				i107.alpha = 0;
				i107.filters = new as3.Array(new object[]{});
				i107.scale9Grid = null;
				i107.visible = true;
				i108.x = -3;
				i108.scaleX = 1;
				i108.y = -39.6;
				i108.scaleY = 1;
				i108.rotation = 0;
				i108.alpha = 0;
				i108.filters = new as3.Array(new object[]{});
				i108.scale9Grid = null;
				i108.visible = true;
				i109.x = -25.4;
				i109.scaleX = 1;
				i109.y = 21.2;
				i109.scaleY = 1;
				i109.rotation = 0;
				i109.alpha = 0.5;
				i109.filters = new as3.Array(new object[]{});
				i109.scale9Grid = null;
				i109.visible = true;
			};
			f = l.Add();
			f.Add(i110);
			f.Add(i111);
			f.Add(i112);
			f.Add(i113);
			f.Add(i70);
			f.Add(i109);
			f += () => {
				i110.x = 9.4;
				i110.scaleX = 1;
				i110.y = 17.3;
				i110.scaleY = 1;
				i110.rotation = 0;
				i110.alpha = 0;
				i110.filters = new as3.Array(new object[]{});
				i110.scale9Grid = null;
				i110.visible = true;
				i111.x = -3;
				i111.scaleX = 1;
				i111.y = -39.6;
				i111.scaleY = 1;
				i111.rotation = 0;
				i111.alpha = 0;
				i111.filters = new as3.Array(new object[]{});
				i111.scale9Grid = null;
				i111.visible = true;
				i112.x = -31.1;
				i112.scaleX = 1;
				i112.y = -6.8;
				i112.scaleY = 1;
				i112.rotation = 0;
				i112.alpha = 0;
				i112.filters = new as3.Array(new object[]{});
				i112.scale9Grid = null;
				i112.visible = true;
				i113.x = 0.3;
				i113.scaleX = 1;
				i113.y = -6.8;
				i113.scaleY = 1;
				i113.rotation = 0;
				i113.alpha = 0;
				i113.filters = new as3.Array(new object[]{});
				i113.scale9Grid = null;
				i113.visible = true;
				i109.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i110);
			f.Add(i111);
			f.Add(i114);
			f.Add(i115);
			f.Add(i70);
			f.Add(i109);
			f += () => {
				i114.x = -31.1;
				i114.scaleX = 1;
				i114.y = -6.8;
				i114.scaleY = 1;
				i114.rotation = 0;
				i114.alpha = 0;
				i114.filters = new as3.Array(new object[]{});
				i114.scale9Grid = null;
				i114.visible = true;
				i115.x = 0.3;
				i115.scaleX = 1;
				i115.y = -6.8;
				i115.scaleY = 1;
				i115.rotation = 0;
				i115.alpha = 0;
				i115.filters = new as3.Array(new object[]{});
				i115.scale9Grid = null;
				i115.visible = true;
				i109.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i110);
			f.Add(i111);
			f.Add(i114);
			f.Add(i115);
			f.Add(i70);
			f.Add(i109);
			f += () => {
				i109.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i116);
			f.Add(i111);
			f.Add(i114);
			f.Add(i115);
			f += () => {
				i116.x = 9.4;
				i116.scaleX = 1;
				i116.y = 17.3;
				i116.scaleY = 1;
				i116.rotation = 0;
				i116.alpha = 0;
				i116.filters = new as3.Array(new object[]{});
				i116.scale9Grid = null;
				i116.visible = true;
			};
			f = l.Add();
			f.Add(i117);
			f.Add(i118);
			f.Add(i119);
			f.Add(i115);
			f += () => {
				i117.x = 9.4;
				i117.scaleX = 1;
				i117.y = 17.3;
				i117.scaleY = 1;
				i117.rotation = 0;
				i117.alpha = 0;
				i117.filters = new as3.Array(new object[]{});
				i117.scale9Grid = null;
				i117.visible = true;
				i118.x = -3;
				i118.scaleX = 1;
				i118.y = -39.6;
				i118.scaleY = 1;
				i118.rotation = 0;
				i118.alpha = 0;
				i118.filters = new as3.Array(new object[]{});
				i118.scale9Grid = null;
				i118.visible = true;
				i119.x = -31.1;
				i119.scaleX = 1;
				i119.y = -6.8;
				i119.scaleY = 1;
				i119.rotation = 0;
				i119.alpha = 0;
				i119.filters = new as3.Array(new object[]{});
				i119.scale9Grid = null;
				i119.visible = true;
			};
			setFrames(l);
		}
	}
}
namespace eng.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("8e4a73517502a29fcc9059a5c4c147dc", -53.15, -14.75, 121.94999999999999, 23.55, 1, 1);
		}
	}
	public class symbol_1 : MovieClip{ 
		public symbol_1() {
			var i23 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i23);//0
		}
	}
	public class symbol_10 : MorphShape{ 
		public symbol_10() {
		}
	}
	public class symbol_11 : Shape{ 
		public symbol_11() {
			setGraphics("71c767165fcd172fd1a93c80db8a2131", -9.65, -9.65, 19.3, 19.3, 1, 1);
		}
	}
	public class symbol_12 : Shape{ 
		public symbol_12() {
			setGraphics("71c767165fcd172fd1a93c80db8a2131", -9.65, -9.65, 19.3, 19.3, 1, 1);
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("9a478cc8e74a234eab39e08d6022f4a9", -20.25, -20.25, 40.5, 40.5, 1, 1);
		}
	}
	public class symbol_14 : Shape{ 
		public symbol_14() {
			setGraphics("7e223c7da8f70df37f75cf18965176ab", -49.4, -50.8, 49.5, 51, 1, 1);
		}
	}
	public class symbol_15 : Shape{ 
		public symbol_15() {
			setGraphics("194dea5e2e366ffa72889aeb8fd40737", -17.75, -8.25, 18.15, 7.25, 1, 1);
		}
	}
	public class symbol_16 : Shape{ 
		public symbol_16() {
			setGraphics("9a478cc8e74a234eab39e08d6022f4a9", -20.25, -20.25, 40.5, 40.5, 1, 1);
		}
	}
	public class symbol_17 : Shape{ 
		public symbol_17() {
			setGraphics("7e223c7da8f70df37f75cf18965176ab", -49.4, -50.8, 49.5, 51, 1, 1);
		}
	}
	public class symbol_18 : Shape{ 
		public symbol_18() {
			setGraphics("194dea5e2e366ffa72889aeb8fd40737", -17.75, -8.25, 18.15, 7.25, 1, 1);
		}
	}
	public class symbol_19 : Shape{ 
		public symbol_19() {
			setGraphics("7e223c7da8f70df37f75cf18965176ab", -49.4, -50.8, 49.5, 51, 1, 1);
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("1e97490cff6268adb8c64c26d47ed4fc", -40.55, -42.4, 81.1, 84.8, 1, 1);
		}
	}
	public class symbol_20 : Shape{ 
		public symbol_20() {
			setGraphics("194dea5e2e366ffa72889aeb8fd40737", -17.75, -8.25, 18.15, 7.25, 1, 1);
		}
	}
	public class symbol_21 : Shape{ 
		public symbol_21() {
			setGraphics("7e223c7da8f70df37f75cf18965176ab", -49.4, -50.8, 49.5, 51, 1, 1);
		}
	}
	public class symbol_22 : Shape{ 
		public symbol_22() {
			setGraphics("194dea5e2e366ffa72889aeb8fd40737", -17.75, -8.25, 18.15, 7.25, 1, 1);
		}
	}
	public class symbol_23 : Shape{ 
		public symbol_23() {
			setGraphics("35405d2bf8083b392c38fca40a05a6d5", -9.35, -42.15, 18.7, 84.25, 1, 1);
		}
	}
	public class symbol_24 : MovieClip{ 
		public symbol_24() {
			var i121 = new symbol_23(){filters = new as3.Array(new object[]{})};
			addChild(i121);//0
		}
	}
	public class symbol_25 : Shape{ 
		public symbol_25() {
			setGraphics("a85f47a2f873b71b4d9b553b7c396238", -32.4, -37.05, 64.75, 74.55, 1, 1);
		}
	}
	public class symbol_26 : MovieClip{ 
		public symbol_26() {
			var i123 = new symbol_25(){filters = new as3.Array(new object[]{})};
			addChild(i123);//0
		}
	}
	public class symbol_27 : Shape{ 
		public symbol_27() {
			setGraphics("151b04cd31fb0efdc5b4fc6bdc3ad254", -5.45, -37.55, 10.9, 75.05, 1, 1);
		}
	}
	public class symbol_28 : MovieClip{ 
		public symbol_28() {
			var i125 = new symbol_27(){filters = new as3.Array(new object[]{})};
			addChild(i125);//0
		}
	}
	public class symbol_29 : Shape{ 
		public symbol_29() {
			setGraphics("1c74e91adcffee2879f6c6898f7ea2bf", -28.45, -12.9, 56.849999999999994, 25.8, 1, 1);
		}
	}
	public class symbol_3 : MovieClip{ 
		public symbol_3() {
			var i25 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i25);//0
		}
	}
	public class symbol_30 : MovieClip{ 
		public symbol_30() {
			var i127 = new symbol_29(){filters = new as3.Array(new object[]{})};
			addChild(i127);//0
		}
	}
	public class symbol_31 : Shape{ 
		public symbol_31() {
			setGraphics("629afa1be7a1ab4692a981479bc97f0c", -40.55, -5.15, 81.1, 10.25, 1, 1);
		}
	}
	public class symbol_32 : MovieClip{ 
		public symbol_32() {
			var i129 = new symbol_31(){filters = new as3.Array(new object[]{})};
			addChild(i129);//0
		}
	}
	public class symbol_33 : Shape{ 
		public symbol_33() {
			setGraphics("0f912d19ab7db633d6586ea11b4c1d6f", -13.45, -5.15, 26.85, 10.25, 1, 1);
		}
	}
	public class symbol_34 : MovieClip{ 
		public symbol_34() {
			var i131 = new symbol_33(){filters = new as3.Array(new object[]{})};
			addChild(i131);//0
		}
	}
	public class symbol_35 : Shape{ 
		public symbol_35() {
			setGraphics("dc8932a0702252aac97c8e7169d596ac", 0, 0, 65, 60, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("2266a3064508c34da7439bd9e4c37609", -5.6, -37.3, 11.2, 74.55, 1, 1);
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
			setGraphics("25e63820c3266112b34bdf5d1460e016", -12.95, -41.9, 25.9, 83.75, 1, 1);
		}
	}
	public class symbol_7 : MovieClip{ 
		public symbol_7() {
			var i29 = new symbol_6(){filters = new as3.Array(new object[]{})};
			addChild(i29);//0
		}
	}
	public class symbol_8 : Shape{ 
		public symbol_8() {
			setGraphics("3a38ebc54936e513ed45792e6c2186ee", -4.5, -37.05, 9, 74.05, 1, 1);
		}
	}
	public class symbol_9 : MovieClip{ 
		public symbol_9() {
			var i31 = new symbol_8(){filters = new as3.Array(new object[]{})};
			addChild(i31);//0
		}
	}
}
