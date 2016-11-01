using System;

using flash.display;
using System.Collections.Generic;
using profile.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libprofile : ResourcesExternalLib{
	public Libprofile() {
	vectors = new string[] {
	"5aa599dd221cb01fc074ddd6973276b8",
	"e2d82985d6e774c3378468e536cd3660",
	"32cb60aa917cc858fad01f9d5459a27c",
	"c3ce9f50033818290841fdf2b1b6ff49",
	"7476abe961f7c5e578e4bc4756f84816",
	"7ae8810d6403c120b32f6084ea8dc9eb",
	"8a9748cfb45ac2a6651eb8d79f49eb5f",
	"7331d49c7718731ddb79639a8fd260fb",
	"ea2478b7d928b786e19bb8417d7901a3",
	"80af23a89dbb0548064a89c08022e6ff",
	"a815caeec4e576c3d834d19f450b61ff",
	"80ca9fc7051161d81d0d60a76319f4cf",
	"a9e9bc9df415224bf7f1e2c5a21bac55",
	"a1868a99043cb38ecdc73379f5aff8d8",
	"e9b5858a8ba09192565b1f2e0099b5b6",
	"2632ddd0fbf14eb1b40e63cd95f5116a",
	"b92bf1b99b1501eb0a257397b4992a78",
	"766defb666e471d7355bafd0b36c980b",
	"ebf5711ef8c21c0d729a5b558f617afb",
	"d36d313459b99dabf0de4da938a1b974",
	"99b9e162932141f837e2bbaaa3165755",
	"9c41f2bfbdeedb2d169836b40f84cf64",
	"c3389d84051a7ce589a38667011e833f",
	"62072bfb6d216aa3cebea8d50f393fef",
	"8a6a4d915b7f25f8babfb7682138a042",
	"dad03ee9ef4575eae5e735b9ca39cbf0",
	"6143dce9c53b25b53f8a0f420386b048",
	"85bf8d1946be34a4c5f2e932a5e6a52d"
	};
	graphics = new string[] {
	"f38c09b6835c4d743d6c2330b6bb20f0",
	"6ea1bfb8b0bd3a698ce8d56d41da0e64",
	"9d3f2d7c82b2f768ac710c55b1b302e6",
	"6ed2d10e36d6cd9f9eaba3c18e5d48ff",
	"d5209b6dd5ba23467364a3467991672c",
	"16d237f70116d8bfbfd89f9c05d53d0b",
	"cba93549f971cdd673c02e98e2fb3df5",
	"0447aefd43db9abb555b98b151cdf2cc",
	"3fc70550a51e758d05e387c3029b4ecc",
	"785a8af6a6a83f37e20038388cfe88a8",
	"7bd8fe4e25fec75da57689efbc8f1d59",
	"01e04a7ebf0a2a2cd5f48bd54e2ee4d5",
	"7ca034549aed03367cc4e348491a7d1d",
	"bec5771c00dfa0176f04231dd99e1d19",
	"d17f2c279eee8f938bd115164aaf5be2",
	"207be7f758bd6defd0c6e5d596dca418",
	"13d098bec9364091e1349937325406f0",
	"f2630527e21d93d8da1fa34f994fe6ab",
	"a1a3a30747291eecf49577ebf8d4cba5",
	"cf2019531a6a2ca5ffd156a8dff5c337",
	"2d9ca7611795eeb4c0c23108214be9cf",
	"7464aaa901c80733957761090db7c5c5",
	"a924e8d2801f34f7c34dc9aa1c88d34d",
	"aca704d647e9d6074d16ce88520ddc3a",
	"26ec10b75639a2bcdbb9f84694c437f1",
	"eba4fba0cfeed5956bf55d17dc24943d",
	"30331b7dc935b528e0c752993c230516",
	"b8edda69dc2522bcc574768dfda02ec1",
	"f38c09b6835c4d743d6c2330b6bb20f0",
	"f73df81d3a3012c3c5e14d2ef62be203",
	"a7e8204939e263af9173b387557c0df8"
	};
	}
}
public class BgCasket : BitmapData{ 
	public BgCasket() {
		width = 375;
		height = 380;
		setPixels("30331b7dc935b528e0c752993c230516");
	}
}
public class ButtonCasket : SimpleButton{ 
	public ButtonCasket() {
		downState = new symbol_0();
		overState = new symbol_0();
		upState = new symbol_0();
		hitTestState = new symbol_0();
	}
}
public class ClockBlueIcon : BitmapData{ 
	public ClockBlueIcon() {
		width = 10;
		height = 10;
		setPixels("a7e8204939e263af9173b387557c0df8");
	}
}
public class CrossRedCancel : BitmapData{ 
	public CrossRedCancel() {
		width = 14;
		height = 14;
		setPixels("7464aaa901c80733957761090db7c5c5");
	}
}
public class CursorGoldKey : BitmapData{ 
	public CursorGoldKey() {
		width = 65;
		height = 44;
		setPixels("b8edda69dc2522bcc574768dfda02ec1");
	}
}
public class CursorRegularKey : BitmapData{ 
	public CursorRegularKey() {
		width = 65;
		height = 44;
		setPixels("f2630527e21d93d8da1fa34f994fe6ab");
	}
}
public class EditNamePencil : BitmapData{ 
	public EditNamePencil() {
		width = 9;
		height = 10;
		setPixels("f73df81d3a3012c3c5e14d2ef62be203");
	}
}
public class EditStatusPencil : BitmapData{ 
	public EditStatusPencil() {
		width = 9;
		height = 10;
		setPixels("16d237f70116d8bfbfd89f9c05d53d0b");
	}
}
public class GoldenCaseMovie : MovieClip{ 
	public MovieClip caseShining;
	public profile_fla.volume_8 keyVolume;
	public MovieClip awardMovie;
	public profile_fla.key_9 keyMovie;
	public GoldenCaseMovie() {
		var filter_0 = new BlurFilter(){blurX = 2, blurY = 2};
		var filter_1 = new GlowFilter(){strength = 1.21, color = 16777215, blurX = 13, blurY = 13};
		var i40 = new symbol_2(){y = 62.6 , x = -9.4};
		addChild(i40);//0
		var i42 = new symbol_4(){y = 29.6 , x = 0};
		addChild(i42);//1
		var i59 = new symbol_16(){x = -44.3 , scaleX = 0.89 , y = -77.5 , scaleY = 1.08};
		addChild(i59);//2
		var i71 = new symbol_25(){scaleX = 0.95 , y = -41 , scaleY = 1.04};
		addChild(i71);//2
		var i44 = new symbol_6(){y = -36.6};
		addChild(i44);//2
		var i61 = new symbol_19(){y = -54.5 , x = -1.5};
		addChild(i61);//3
		var i46 = new symbol_8(){y = 13.5 , x = 63.1};
		addChild(i46);//3
		var i67 = new symbol_23(){y = 6.1 , x = -23.9};
		addChild(i67);//4
		keyVolume = new profile_fla.volume_8(){x = -0.3 , y = 0.3 , mask = i46};
		addChild(keyVolume);//4
		awardMovie = new symbol_21(){y = -48};
		addChild(awardMovie);//4
		keyMovie = new profile_fla.key_9(){x = 44.9 , scaleX = 0.46 , y = 7.8 , scaleY = 0.46 , rotation = 14 , mask = i46};
		addChild(keyMovie);//5
		var i65 = new profile_fla.ef1_16(){x = -10.3 , y = -10.3 , filters = new as3.Array(new object[]{filter_1,filter_0})};
		addChild(i65);//5
		var i51 = new symbol_11(){x = 41.4 , y = 7.7 , mask = i46};
		addChild(i51);//6
		caseShining = new symbol_14(){y = 12.8 , x = 46};
		addChild(caseShining);//7
		FrameInfo f;
		var l= new Frames(66);
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.x = -9.4;
			i40.scaleX = 1;
			i40.y = 62.6;
			i40.scaleY = 1;
			i40.rotation = 0;
			i40.alpha = 1;
			i40.filters = new as3.Array(new object[]{});
			i40.scale9Grid = null;
			i40.visible = true;
			i42.x = 0;
			i42.scaleX = 1;
			i42.y = 29.6;
			i42.scaleY = 1;
			i42.rotation = 0;
			i42.alpha = 1;
			i42.filters = new as3.Array(new object[]{});
			i42.scale9Grid = null;
			i42.visible = true;
			i44.x = 0;
			i44.scaleX = 1;
			i44.y = -36.6;
			i44.scaleY = 1;
			i44.rotation = 0;
			i44.alpha = 1;
			i44.filters = new as3.Array(new object[]{});
			i44.scale9Grid = null;
			i44.visible = true;
			i46.x = 63.1;
			i46.scaleX = 1;
			i46.y = 13.5;
			i46.scaleY = 1;
			i46.rotation = 0;
			i46.alpha = 1;
			i46.filters = new as3.Array(new object[]{});
			i46.scale9Grid = null;
			i46.visible = true;
			keyVolume.x = -0.3;
			keyVolume.scaleX = 1;
			keyVolume.y = 0.3;
			keyVolume.scaleY = 1;
			keyVolume.rotation = 0;
			keyVolume.alpha = 1;
			keyVolume.filters = new as3.Array(new object[]{});
			keyVolume.scale9Grid = null;
			keyVolume.visible = true;
			keyMovie.x = 44.9;
			keyMovie.scaleX = 0.46;
			keyMovie.y = 7.8;
			keyMovie.scaleY = 0.46;
			keyMovie.rotation = 14;
			keyMovie.alpha = 1;
			keyMovie.filters = new as3.Array(new object[]{});
			keyMovie.scale9Grid = null;
			keyMovie.visible = true;
			i51.x = 41.4;
			i51.scaleX = 1;
			i51.y = 7.7;
			i51.scaleY = 1;
			i51.rotation = 0;
			i51.alpha = 1;
			i51.filters = new as3.Array(new object[]{});
			i51.scale9Grid = null;
			i51.visible = true;
			caseShining.x = 46;
			caseShining.scaleX = 1;
			caseShining.y = 12.8;
			caseShining.scaleY = 1;
			caseShining.rotation = 0;
			caseShining.alpha = 1;
			caseShining.filters = new as3.Array(new object[]{});
			caseShining.scale9Grid = null;
			caseShining.visible = true;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 45.2;
			keyMovie.scaleY = 0.45;
			i51.scaleY = 0.99;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 45.5;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 45.7;
			keyMovie.y = 7.9;
			i51.scaleY = 0.98;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.1;
			keyMovie.y = 8;
			i51.scaleY = 0.97;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.4;
			keyMovie.y = 8.1;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.6;
			i51.scaleY = 0.96;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.7;
			keyMovie.y = 8.2;
			i51.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.9;
			keyMovie.scaleY = 0.44;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 47.1;
			i51.scaleY = 0.94;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 47.3;
			keyMovie.y = 8.3;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 47.4;
			i51.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 47.5;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.02;
			i42.scaleX = 1.02;
			i42.y = 30.8;
			i42.scaleY = 0.98;
			i44.scaleX = 1.02;
			i44.y = -33.8;
			i44.scaleY = 0.98;
			i46.x = 63.8;
			i46.y = 15.1;
			i46.scaleY = 0.97;
			keyMovie.x = 48.1;
			keyMovie.scaleX = 0.45;
			keyMovie.y = 10;
			i51.x = 42.1;
			i51.y = 9.4;
			i51.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.03;
			i42.scaleX = 1.04;
			i42.y = 31.9;
			i42.scaleY = 0.95;
			i44.scaleX = 1.04;
			i44.y = -31;
			i44.scaleY = 0.95;
			i46.x = 64.5;
			i46.y = 16.6;
			i46.scaleY = 0.94;
			keyMovie.x = 48.8;
			keyMovie.y = 11.7;
			keyMovie.scaleY = 0.43;
			i51.x = 42.9;
			i51.y = 11.1;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.05;
			i42.scaleX = 1.06;
			i42.y = 33.1;
			i42.scaleY = 0.93;
			i44.scaleX = 1.06;
			i44.y = -28.3;
			i44.scaleY = 0.93;
			i46.x = 65.2;
			i46.y = 18.2;
			i46.scaleY = 0.92;
			keyMovie.x = 49.5;
			keyMovie.y = 13.4;
			keyMovie.scaleY = 0.42;
			keyMovie.rotation = 13;
			i51.x = 43.6;
			i51.y = 12.8;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.06;
			i42.scaleX = 1.07;
			i42.y = 34.3;
			i42.scaleY = 0.9;
			i44.scaleX = 1.07;
			i44.y = -25.4;
			i44.scaleY = 0.9;
			i46.x = 65.8;
			i46.y = 19.8;
			i46.scaleY = 0.89;
			keyMovie.x = 50.1;
			keyMovie.y = 15.1;
			i51.x = 44.5;
			i51.y = 14.5;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.08;
			i42.scaleX = 1.09;
			i42.y = 35.5;
			i42.scaleY = 0.88;
			i44.scaleX = 1.09;
			i44.y = -22.6;
			i44.scaleY = 0.88;
			i46.x = 66.5;
			i46.y = 21.3;
			i46.scaleY = 0.86;
			keyMovie.x = 50.9;
			keyMovie.y = 16.8;
			keyMovie.scaleY = 0.41;
			keyMovie.rotation = 12;
			i51.x = 45.3;
			i51.y = 16.1;
			i51.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.03;
			i42.scaleX = 1.06;
			i42.y = 33.5;
			i42.scaleY = 0.92;
			i44.scaleX = 1.06;
			i44.y = -27.3;
			i44.scaleY = 0.92;
			i46.x = 65.3;
			i46.y = 18.7;
			i46.scaleY = 0.9;
			keyMovie.x = 49.6;
			keyMovie.y = 14;
			keyMovie.scaleY = 0.42;
			keyMovie.rotation = 13;
			i51.x = 43.9;
			i51.y = 13.3;
			i51.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.98;
			i42.scaleX = 1.02;
			i42.y = 31.6;
			i42.scaleY = 0.96;
			i44.scaleX = 1.02;
			i44.y = -31.9;
			i44.scaleY = 0.96;
			i46.x = 64;
			i46.y = 16.1;
			i46.scaleY = 0.94;
			keyMovie.x = 48.4;
			keyMovie.y = 11.3;
			keyMovie.scaleY = 0.43;
			keyMovie.rotation = 14;
			i51.x = 42.5;
			i51.y = 10.4;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.94;
			i42.scaleX = 0.99;
			i42.y = 29.7;
			i42.scaleY = 1;
			i44.scaleX = 0.99;
			i44.y = -36.5;
			i44.scaleY = 1;
			i46.x = 62.8;
			i46.y = 13.6;
			i46.scaleY = 0.98;
			keyMovie.x = 47.1;
			keyMovie.y = 8.4;
			keyMovie.scaleY = 0.44;
			i51.x = 41.2;
			i51.y = 7.5;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i44);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.89;
			i42.scaleX = 0.95;
			i42.y = 27.8;
			i42.scaleY = 1.04;
			i44.scaleX = 0.95;
			i44.y = -41;
			i44.scaleY = 1.04;
			i46.x = 61.5;
			i46.y = 10.9;
			i46.scaleY = 1.02;
			keyMovie.x = 45.9;
			keyMovie.scaleX = 0.46;
			keyMovie.y = 5.7;
			keyMovie.scaleY = 0.45;
			keyMovie.rotation = 15;
			i51.x = 39.9;
			i51.y = 4.7;
			i51.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i59.x = -44.3;
			i59.scaleX = 0.89;
			i59.y = -77.5;
			i59.scaleY = 1.08;
			i59.rotation = 0;
			i59.alpha = 1;
			i59.filters = new as3.Array(new object[]{});
			i59.scale9Grid = null;
			i59.visible = true;
			i61.x = -1.5;
			i61.scaleX = 1;
			i61.y = -54.5;
			i61.scaleY = 1;
			i61.rotation = 0;
			i61.alpha = 1;
			i61.filters = new as3.Array(new object[]{});
			i61.scale9Grid = null;
			i61.visible = true;
			awardMovie.x = 0;
			awardMovie.scaleX = 1;
			awardMovie.y = -48;
			awardMovie.scaleY = 1;
			awardMovie.rotation = 0;
			awardMovie.alpha = 1;
			awardMovie.filters = new as3.Array(new object[]{});
			awardMovie.scale9Grid = null;
			awardMovie.visible = true;
			i65.x = -10.3;
			i65.scaleX = 1;
			i65.y = -10.3;
			i65.scaleY = 1;
			i65.rotation = 0;
			i65.alpha = 1;
			i65.filters = new as3.Array(new object[]{filter_1,filter_0});
			i65.scale9Grid = null;
			i65.visible = true;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.91;
			i42.scaleX = 0.96;
			i42.y = 28.1;
			i42.scaleY = 1.03;
			i59.x = -43.2;
			i59.scaleX = 0.9;
			i59.y = -76.5;
			i46.x = 61.8;
			i46.y = 11.4;
			i46.scaleY = 1.01;
			awardMovie.y = -51.6;
			keyMovie.x = 46;
			keyMovie.y = 6.2;
			keyMovie.scaleY = 0.44;
			i51.x = 40.1;
			i51.y = 5.3;
			i51.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.93;
			i42.scaleX = 0.97;
			i42.y = 28.6;
			i42.scaleY = 1.02;
			i59.x = -42.5;
			i59.scaleX = 0.91;
			i59.y = -75.4;
			i59.scaleY = 1.07;
			i46.x = 62.1;
			i46.y = 11.9;
			awardMovie.y = -54.9;
			keyMovie.x = 46.5;
			keyMovie.y = 6.8;
			i51.x = 40.5;
			i51.y = 5.8;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.96;
			i42.scaleX = 0.98;
			i42.y = 28.9;
			i59.x = -41.7;
			i59.scaleX = 0.93;
			i59.y = -74.3;
			i59.scaleY = 1.06;
			i46.x = 62.5;
			i46.y = 12.5;
			awardMovie.y = -57.8;
			keyMovie.x = 46.8;
			keyMovie.y = 7.3;
			i51.x = 40.8;
			i51.y = 6.5;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.98;
			i42.scaleX = 0.99;
			i42.y = 29.3;
			i42.scaleY = 1.01;
			i59.x = -40.9;
			i59.scaleX = 0.94;
			i59.y = -73.2;
			i59.scaleY = 1.05;
			i46.x = 62.8;
			i46.y = 13;
			i46.scaleY = 1;
			awardMovie.y = -60.4;
			keyMovie.x = 47.1;
			keyMovie.y = 7.8;
			i51.x = 41.1;
			i51.y = 7;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1;
			i42.scaleX = 1;
			i42.y = 29.6;
			i42.scaleY = 1;
			i59.x = -40;
			i59.scaleX = 0.95;
			i59.y = -72;
			i59.scaleY = 1.04;
			i46.x = 63.1;
			i46.y = 13.5;
			awardMovie.y = -62.5;
			keyMovie.x = 47.5;
			keyMovie.y = 8.3;
			keyMovie.rotation = 14;
			i51.x = 41.4;
			i51.y = 7.7;
			i51.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -64.4;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -65.8;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -67;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -65.7;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -64.3;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -63.1;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -62;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -60.9;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -59.9;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -59;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -58.1;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -57.4;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -56.6;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i46);
		f.Add(keyVolume);
		f.Add(awardMovie);
		f.Add(keyMovie);
		f.Add(i65);
		f.Add(i51);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -56;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i67.x = -23.9;
			i67.scaleX = 1;
			i67.y = 6.1;
			i67.scaleY = 1;
			i67.rotation = 0;
			i67.alpha = 1;
			i67.filters = new as3.Array(new object[]{});
			i67.scale9Grid = null;
			i67.visible = true;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.98;
			i42.scaleX = 0.99;
			i42.y = 29.3;
			i42.scaleY = 1.01;
			i59.x = -40.7;
			i59.scaleX = 0.94;
			i59.y = -73.2;
			i59.scaleY = 1.05;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.96;
			i42.scaleX = 0.98;
			i42.y = 28.9;
			i42.scaleY = 1.02;
			i59.x = -41.5;
			i59.scaleX = 0.93;
			i59.y = -74.3;
			i59.scaleY = 1.06;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.93;
			i42.scaleX = 0.97;
			i42.y = 28.6;
			i59.x = -42.5;
			i59.scaleX = 0.91;
			i59.y = -75.4;
			i59.scaleY = 1.07;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.91;
			i42.scaleX = 0.96;
			i42.y = 28.2;
			i42.scaleY = 1.03;
			i59.x = -43.1;
			i59.scaleX = 0.9;
			i59.y = -76.5;
			i59.scaleY = 1.08;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i59);
		f.Add(i61);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.89;
			i42.scaleX = 0.95;
			i42.y = 27.8;
			i42.scaleY = 1.04;
			i59.x = -44.3;
			i59.scaleX = 0.89;
			i59.y = -77.5;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i71.x = 0;
			i71.scaleX = 0.95;
			i71.y = -41;
			i71.scaleY = 1.04;
			i71.rotation = 0;
			i71.alpha = 1;
			i71.filters = new as3.Array(new object[]{});
			i71.scale9Grid = null;
			i71.visible = true;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.94;
			i42.scaleX = 0.99;
			i42.y = 29.7;
			i42.scaleY = 1;
			i71.scaleX = 0.99;
			i71.y = -36.5;
			i71.scaleY = 1;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 0.98;
			i42.scaleX = 1.02;
			i42.y = 31.7;
			i42.scaleY = 0.96;
			i71.scaleX = 1.02;
			i71.y = -31.9;
			i71.scaleY = 0.96;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.03;
			i42.scaleX = 1.06;
			i42.y = 33.5;
			i42.scaleY = 0.92;
			i71.scaleX = 1.06;
			i71.y = -27.3;
			i71.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.08;
			i42.scaleX = 1.09;
			i42.y = 35.5;
			i42.scaleY = 0.88;
			i71.scaleX = 1.09;
			i71.y = -22.6;
			i71.scaleY = 0.88;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.06;
			i42.scaleX = 1.07;
			i42.y = 34.3;
			i42.scaleY = 0.9;
			i71.scaleX = 1.07;
			i71.y = -25.4;
			i71.scaleY = 0.9;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.05;
			i42.scaleX = 1.06;
			i42.y = 33.1;
			i42.scaleY = 0.93;
			i71.scaleX = 1.06;
			i71.y = -28.2;
			i71.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.03;
			i42.scaleX = 1.04;
			i42.y = 31.9;
			i42.scaleY = 0.95;
			i71.scaleX = 1.04;
			i71.y = -31;
			i71.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1.02;
			i42.scaleX = 1.02;
			i42.y = 30.8;
			i42.scaleY = 0.98;
			i71.scaleX = 1.02;
			i71.y = -33.8;
			i71.scaleY = 0.98;
		};
		f = l.Add();
		f.Add(i40);
		f.Add(i42);
		f.Add(i71);
		f.Add(i67);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i40.scaleX = 1;
			i42.scaleX = 1;
			i42.y = 29.6;
			i42.scaleY = 1;
			i71.scaleX = 1;
			i71.y = -36.6;
			i71.scaleY = 1;
		};
		setFrames(l);
	}
}
public class GoldenKey : BitmapData{ 
	public GoldenKey() {
		width = 51;
		height = 37;
		setPixels("fb8f7d05f8f26afcea65420e98772f2a");
	}
}
public class IconHelpCasket : BitmapData{ 
	public IconHelpCasket() {
		width = 22;
		height = 22;
		setPixels("9d3f2d7c82b2f768ac710c55b1b302e6");
	}
}
public class LoadButtonFB : SimpleButton{ 
	public LoadButtonFB() {
		downState = new symbol_26();
		overState = new symbol_26();
		upState = new symbol_26();
		hitTestState = new symbol_27();
	}
}
public class LoadButtonFS : SimpleButton{ 
	public LoadButtonFS() {
		downState = new symbol_26();
		overState = new symbol_26();
		upState = new symbol_26();
		hitTestState = new symbol_28();
	}
}
public class LoadButtonMB : SimpleButton{ 
	public LoadButtonMB() {
		downState = new symbol_26();
		overState = new symbol_26();
		upState = new symbol_26();
		hitTestState = new symbol_27();
	}
}
public class LoadButtonMM : SimpleButton{ 
	public LoadButtonMM() {
		downState = new symbol_26();
		overState = new symbol_26();
		upState = new symbol_26();
		hitTestState = new symbol_27();
	}
}
public class LoadButtonOK : SimpleButton{ 
	public LoadButtonOK() {
		downState = new symbol_26();
		overState = new symbol_26();
		upState = new symbol_26();
		hitTestState = new symbol_27();
	}
}
public class LoadButtonVK : SimpleButton{ 
	public LoadButtonVK() {
		downState = new symbol_26();
		overState = new symbol_26();
		upState = new symbol_26();
		hitTestState = new symbol_27();
	}
}
public class PhotoAddImage : BitmapData{ 
	public PhotoAddImage() {
		width = 84;
		height = 84;
		setPixels("26ec10b75639a2bcdbb9f84694c437f1");
	}
}
public class PhotosAvatarImage : BitmapData{ 
	public PhotosAvatarImage() {
		width = 47;
		height = 47;
		setPixels("d17f2c279eee8f938bd115164aaf5be2");
	}
}
public class PhotosButtonChange : SimpleButton{ 
	public PhotosButtonChange() {
		downState = new symbol_26();
		overState = new symbol_26();
		upState = new symbol_26();
		hitTestState = new symbol_27(){y = 0.4 , x = 0.4};
	}
}
public class PhotosButtonDoAvatar : SimpleButton{ 
	public PhotosButtonDoAvatar() {
		downState = new symbol_26();
		overState = new symbol_26();
		upState = new symbol_26();
		hitTestState = new symbol_27();
	}
}
public class PhotosButtonEdit : SimpleButton{ 
	public PhotosButtonEdit() {
		downState = new symbol_29();
		overState = new symbol_29();
		upState = new symbol_29();
		hitTestState = new symbol_27(){y = -1 , x = 1};
	}
}
public class PhotosButtonRemove : SimpleButton{ 
	public PhotosButtonRemove() {
		downState = new symbol_30();
		overState = new symbol_30();
		upState = new symbol_30();
		hitTestState = new symbol_27(){y = -1.2 , x = -1.6};
	}
}
public class PhotosButtonWithCamera : SimpleButton{ 
	public PhotosButtonWithCamera() {
		downState = new symbol_31();
		overState = new symbol_31();
		upState = new symbol_31();
		hitTestState = new symbol_31();
	}
}
public class PhotosLikeIcon : BitmapData{ 
	public PhotosLikeIcon() {
		width = 28;
		height = 26;
		setPixels("7ca034549aed03367cc4e348491a7d1d");
	}
}
public class PhotosViewsIcon : BitmapData{ 
	public PhotosViewsIcon() {
		width = 28;
		height = 22;
		setPixels("bec5771c00dfa0176f04231dd99e1d19");
	}
}
public class ProfileKeysHelp : BitmapData{ 
	public ProfileKeysHelp() {
		width = 14;
		height = 14;
		setPixels("3fc70550a51e758d05e387c3029b4ecc");
	}
}
public class ProfileKeysItemLock : BitmapData{ 
	public ProfileKeysItemLock() {
		width = 12;
		height = 16;
		setPixels("7bd8fe4e25fec75da57689efbc8f1d59");
	}
}
public class ProfileStatusApply : BitmapData{ 
	public ProfileStatusApply() {
		width = 11;
		height = 9;
		setPixels("a924e8d2801f34f7c34dc9aa1c88d34d");
	}
}
public class ProfileStatusCancel : BitmapData{ 
	public ProfileStatusCancel() {
		width = 9;
		height = 9;
		setPixels("f38c09b6835c4d743d6c2330b6bb20f0");
	}
}
public class RegularCaseMovie : MovieClip{ 
	public MovieClip awardMovie;
	public MovieClip caseShining;
	public profile_fla.volume_8 keyVolume;
	public profile_fla.key_22 keyMovie;
	public RegularCaseMovie() {
		var filter_0 = new BlurFilter(){blurX = 2, blurY = 2};
		var filter_1 = new GlowFilter(){strength = 1.21, color = 16777215, blurX = 13, blurY = 13};
		var i167 = new symbol_49(){y = 62.6 , x = -9.4};
		addChild(i167);//0
		var i140 = new symbol_34(){y = 62.6 , x = -9.4};
		addChild(i140);//0
		var i142 = new symbol_36(){y = 29.6 , x = 0};
		addChild(i142);//1
		var i144 = new symbol_38(){y = -36.6};
		addChild(i144);//2
		var i173 = new symbol_52(){scaleX = 0.95 , y = -41 , scaleY = 1.04};
		addChild(i173);//2
		var i159 = new symbol_44(){x = -44.3 , scaleX = 0.89 , y = -77.5 , scaleY = 1.08};
		addChild(i159);//2
		var i161 = new symbol_46(){y = -54.5 , x = -1.5};
		addChild(i161);//3
		var i146 = new symbol_40(){y = 13.5 , x = 63.1};
		addChild(i146);//3
		awardMovie = new symbol_48(){y = -48};
		addChild(awardMovie);//4
		var i169 = new symbol_50(){y = 22.5 , x = -55.5};
		addChild(i169);//4
		keyVolume = new profile_fla.volume_8(){x = -0.3 , y = 0.3 , mask = i146};
		addChild(keyVolume);//4
		var i165 = new profile_fla.ef1_26(){x = -10.3 , y = -10.3 , filters = new as3.Array(new object[]{filter_1,filter_0})};
		addChild(i165);//5
		keyMovie = new profile_fla.key_22(){x = 44.9 , scaleX = 0.46 , y = 7.8 , scaleY = 0.46 , rotation = 14 , mask = i146};
		addChild(keyMovie);//5
		var i151 = new symbol_41(){x = 41.4 , y = 7.7 , mask = i146};
		addChild(i151);//6
		caseShining = new symbol_42(){y = 12.8 , x = 46};
		addChild(caseShining);//7
		FrameInfo f;
		var l= new Frames(66);
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.x = -9.4;
			i140.scaleX = 1;
			i140.y = 62.6;
			i140.scaleY = 1;
			i140.rotation = 0;
			i140.alpha = 1;
			i140.filters = new as3.Array(new object[]{});
			i140.scale9Grid = null;
			i140.visible = true;
			i142.x = 0;
			i142.scaleX = 1;
			i142.y = 29.6;
			i142.scaleY = 1;
			i142.rotation = 0;
			i142.alpha = 1;
			i142.filters = new as3.Array(new object[]{});
			i142.scale9Grid = null;
			i142.visible = true;
			i144.x = 0;
			i144.scaleX = 1;
			i144.y = -36.6;
			i144.scaleY = 1;
			i144.rotation = 0;
			i144.alpha = 1;
			i144.filters = new as3.Array(new object[]{});
			i144.scale9Grid = null;
			i144.visible = true;
			i146.x = 63.1;
			i146.scaleX = 1;
			i146.y = 13.5;
			i146.scaleY = 1;
			i146.rotation = 0;
			i146.alpha = 1;
			i146.filters = new as3.Array(new object[]{});
			i146.scale9Grid = null;
			i146.visible = true;
			keyVolume.x = -0.3;
			keyVolume.scaleX = 1;
			keyVolume.y = 0.3;
			keyVolume.scaleY = 1;
			keyVolume.rotation = 0;
			keyVolume.alpha = 1;
			keyVolume.filters = new as3.Array(new object[]{});
			keyVolume.scale9Grid = null;
			keyVolume.visible = true;
			keyMovie.x = 44.9;
			keyMovie.scaleX = 0.46;
			keyMovie.y = 7.8;
			keyMovie.scaleY = 0.46;
			keyMovie.rotation = 14;
			keyMovie.alpha = 1;
			keyMovie.filters = new as3.Array(new object[]{});
			keyMovie.scale9Grid = null;
			keyMovie.visible = true;
			i151.x = 41.4;
			i151.scaleX = 1;
			i151.y = 7.7;
			i151.scaleY = 1;
			i151.rotation = 0;
			i151.alpha = 1;
			i151.filters = new as3.Array(new object[]{});
			i151.scale9Grid = null;
			i151.visible = true;
			caseShining.x = 46;
			caseShining.scaleX = 1;
			caseShining.y = 12.8;
			caseShining.scaleY = 1;
			caseShining.rotation = 0;
			caseShining.alpha = 1;
			caseShining.filters = new as3.Array(new object[]{});
			caseShining.scale9Grid = null;
			caseShining.visible = true;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 45.2;
			keyMovie.scaleY = 0.45;
			i151.scaleY = 0.99;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 45.5;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 45.7;
			keyMovie.y = 7.9;
			i151.scaleY = 0.98;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.1;
			keyMovie.y = 8;
			i151.scaleY = 0.97;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.4;
			keyMovie.y = 8.1;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.6;
			i151.scaleY = 0.96;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.7;
			keyMovie.y = 8.2;
			i151.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 46.9;
			keyMovie.scaleY = 0.44;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 47.1;
			i151.scaleY = 0.94;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 47.3;
			keyMovie.y = 8.3;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 47.4;
			i151.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			keyMovie.x = 47.5;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 1.02;
			i142.scaleX = 1.02;
			i142.y = 30.8;
			i142.scaleY = 0.98;
			i144.scaleX = 1.02;
			i144.y = -33.8;
			i144.scaleY = 0.98;
			i146.x = 63.8;
			i146.y = 15.1;
			i146.scaleY = 0.97;
			keyMovie.x = 48.1;
			keyMovie.scaleX = 0.45;
			keyMovie.y = 10;
			i151.x = 42.1;
			i151.y = 9.4;
			i151.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 1.03;
			i142.scaleX = 1.04;
			i142.y = 31.9;
			i142.scaleY = 0.95;
			i144.scaleX = 1.04;
			i144.y = -31;
			i144.scaleY = 0.95;
			i146.x = 64.5;
			i146.y = 16.6;
			i146.scaleY = 0.94;
			keyMovie.x = 48.8;
			keyMovie.y = 11.7;
			keyMovie.scaleY = 0.43;
			i151.x = 42.9;
			i151.y = 11.1;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 1.05;
			i142.scaleX = 1.06;
			i142.y = 33.1;
			i142.scaleY = 0.93;
			i144.scaleX = 1.06;
			i144.y = -28.3;
			i144.scaleY = 0.93;
			i146.x = 65.2;
			i146.y = 18.2;
			i146.scaleY = 0.92;
			keyMovie.x = 49.5;
			keyMovie.y = 13.4;
			keyMovie.scaleY = 0.42;
			keyMovie.rotation = 13;
			i151.x = 43.6;
			i151.y = 12.8;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 1.06;
			i142.scaleX = 1.07;
			i142.y = 34.3;
			i142.scaleY = 0.9;
			i144.scaleX = 1.07;
			i144.y = -25.4;
			i144.scaleY = 0.9;
			i146.x = 65.8;
			i146.y = 19.8;
			i146.scaleY = 0.89;
			keyMovie.x = 50.1;
			keyMovie.y = 15.1;
			i151.x = 44.5;
			i151.y = 14.5;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 1.08;
			i142.scaleX = 1.09;
			i142.y = 35.5;
			i142.scaleY = 0.88;
			i144.scaleX = 1.09;
			i144.y = -22.6;
			i144.scaleY = 0.88;
			i146.x = 66.5;
			i146.y = 21.3;
			i146.scaleY = 0.86;
			keyMovie.x = 50.9;
			keyMovie.y = 16.8;
			keyMovie.scaleY = 0.41;
			keyMovie.rotation = 12;
			i151.x = 45.3;
			i151.y = 16.1;
			i151.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 1.03;
			i142.scaleX = 1.06;
			i142.y = 33.5;
			i142.scaleY = 0.92;
			i144.scaleX = 1.06;
			i144.y = -27.3;
			i144.scaleY = 0.92;
			i146.x = 65.3;
			i146.y = 18.7;
			i146.scaleY = 0.9;
			keyMovie.x = 49.6;
			keyMovie.y = 14;
			keyMovie.scaleY = 0.42;
			keyMovie.rotation = 13;
			i151.x = 43.9;
			i151.y = 13.3;
			i151.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 0.98;
			i142.scaleX = 1.02;
			i142.y = 31.6;
			i142.scaleY = 0.96;
			i144.scaleX = 1.02;
			i144.y = -31.9;
			i144.scaleY = 0.96;
			i146.x = 64;
			i146.y = 16.1;
			i146.scaleY = 0.94;
			keyMovie.x = 48.4;
			keyMovie.y = 11.3;
			keyMovie.scaleY = 0.43;
			keyMovie.rotation = 14;
			i151.x = 42.5;
			i151.y = 10.4;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 0.94;
			i142.scaleX = 0.99;
			i142.y = 29.7;
			i142.scaleY = 1;
			i144.scaleX = 0.99;
			i144.y = -36.5;
			i144.scaleY = 1;
			i146.x = 62.8;
			i146.y = 13.6;
			i146.scaleY = 0.98;
			keyMovie.x = 47.1;
			keyMovie.y = 8.4;
			keyMovie.scaleY = 0.44;
			i151.x = 41.2;
			i151.y = 7.5;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i144);
		f.Add(i146);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 0.89;
			i142.scaleX = 0.95;
			i142.y = 27.8;
			i142.scaleY = 1.04;
			i144.scaleX = 0.95;
			i144.y = -41;
			i144.scaleY = 1.04;
			i146.x = 61.5;
			i146.y = 10.9;
			i146.scaleY = 1.02;
			keyMovie.x = 45.9;
			keyMovie.scaleX = 0.46;
			keyMovie.y = 5.7;
			keyMovie.scaleY = 0.45;
			keyMovie.rotation = 15;
			i151.x = 39.9;
			i151.y = 4.7;
			i151.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i159.x = -44.3;
			i159.scaleX = 0.89;
			i159.y = -77.5;
			i159.scaleY = 1.08;
			i159.rotation = 0;
			i159.alpha = 1;
			i159.filters = new as3.Array(new object[]{});
			i159.scale9Grid = null;
			i159.visible = true;
			i161.x = -1.5;
			i161.scaleX = 1;
			i161.y = -54.5;
			i161.scaleY = 1;
			i161.rotation = 0;
			i161.alpha = 1;
			i161.filters = new as3.Array(new object[]{});
			i161.scale9Grid = null;
			i161.visible = true;
			awardMovie.x = 0;
			awardMovie.scaleX = 1;
			awardMovie.y = -48;
			awardMovie.scaleY = 1;
			awardMovie.rotation = 0;
			awardMovie.alpha = 1;
			awardMovie.filters = new as3.Array(new object[]{});
			awardMovie.scale9Grid = null;
			awardMovie.visible = true;
			i165.x = -10.3;
			i165.scaleX = 1;
			i165.y = -10.3;
			i165.scaleY = 1;
			i165.rotation = 0;
			i165.alpha = 1;
			i165.filters = new as3.Array(new object[]{filter_1,filter_0});
			i165.scale9Grid = null;
			i165.visible = true;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 0.91;
			i142.scaleX = 0.96;
			i142.y = 28.1;
			i142.scaleY = 1.03;
			i159.x = -43.2;
			i159.scaleX = 0.9;
			i159.y = -76.5;
			i146.x = 61.8;
			i146.y = 11.4;
			i146.scaleY = 1.01;
			awardMovie.y = -51.6;
			keyMovie.x = 46;
			keyMovie.y = 6.2;
			keyMovie.scaleY = 0.44;
			i151.x = 40.1;
			i151.y = 5.3;
			i151.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 0.93;
			i142.scaleX = 0.97;
			i142.y = 28.6;
			i142.scaleY = 1.02;
			i159.x = -42.5;
			i159.scaleX = 0.91;
			i159.y = -75.4;
			i159.scaleY = 1.07;
			i146.x = 62.1;
			i146.y = 11.9;
			awardMovie.y = -54.9;
			keyMovie.x = 46.5;
			keyMovie.y = 6.8;
			i151.x = 40.5;
			i151.y = 5.8;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 0.96;
			i142.scaleX = 0.98;
			i142.y = 28.9;
			i159.x = -41.7;
			i159.scaleX = 0.93;
			i159.y = -74.3;
			i159.scaleY = 1.06;
			i146.x = 62.5;
			i146.y = 12.5;
			awardMovie.y = -57.8;
			keyMovie.x = 46.8;
			keyMovie.y = 7.3;
			i151.x = 40.8;
			i151.y = 6.5;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 0.98;
			i142.scaleX = 0.99;
			i142.y = 29.3;
			i142.scaleY = 1.01;
			i159.x = -40.9;
			i159.scaleX = 0.94;
			i159.y = -73.2;
			i159.scaleY = 1.05;
			i146.x = 62.8;
			i146.y = 13;
			i146.scaleY = 1;
			awardMovie.y = -60.4;
			keyMovie.x = 47.1;
			keyMovie.y = 7.8;
			i151.x = 41.1;
			i151.y = 7;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			i140.scaleX = 1;
			i142.scaleX = 1;
			i142.y = 29.6;
			i142.scaleY = 1;
			i159.x = -40;
			i159.scaleX = 0.95;
			i159.y = -72;
			i159.scaleY = 1.04;
			i146.x = 63.1;
			i146.y = 13.5;
			awardMovie.y = -62.5;
			keyMovie.x = 47.5;
			keyMovie.y = 8.3;
			keyMovie.rotation = 14;
			i151.x = 41.4;
			i151.y = 7.7;
			i151.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -64.4;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -65.8;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -67;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -65.7;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -64.3;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -63.1;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -62;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -60.9;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -59.9;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -59;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -58.1;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -57.4;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -56.6;
		};
		f = l.Add();
		f.Add(i140);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i146);
		f.Add(awardMovie);
		f.Add(keyVolume);
		f.Add(i165);
		f.Add(keyMovie);
		f.Add(i151);
		f.Add(caseShining);
		f += () => {
			awardMovie.y = -56;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.x = -9.4;
			i167.scaleX = 1;
			i167.y = 62.6;
			i167.scaleY = 1;
			i167.rotation = 0;
			i167.alpha = 1;
			i167.filters = new as3.Array(new object[]{});
			i167.scale9Grid = null;
			i167.visible = true;
			i169.x = -55.5;
			i169.scaleX = 1;
			i169.y = 22.5;
			i169.scaleY = 1;
			i169.rotation = 0;
			i169.alpha = 1;
			i169.filters = new as3.Array(new object[]{});
			i169.scale9Grid = null;
			i169.visible = true;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 0.98;
			i142.scaleX = 0.99;
			i142.y = 29.3;
			i142.scaleY = 1.01;
			i159.x = -40.7;
			i159.scaleX = 0.94;
			i159.y = -73.2;
			i159.scaleY = 1.05;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 0.96;
			i142.scaleX = 0.98;
			i142.y = 28.9;
			i142.scaleY = 1.02;
			i159.x = -41.5;
			i159.scaleX = 0.93;
			i159.y = -74.3;
			i159.scaleY = 1.06;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 0.93;
			i142.scaleX = 0.97;
			i142.y = 28.6;
			i159.x = -42.5;
			i159.scaleX = 0.91;
			i159.y = -75.4;
			i159.scaleY = 1.07;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 0.91;
			i142.scaleX = 0.96;
			i142.y = 28.2;
			i142.scaleY = 1.03;
			i159.x = -43.1;
			i159.scaleX = 0.9;
			i159.y = -76.5;
			i159.scaleY = 1.08;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i159);
		f.Add(i161);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 0.89;
			i142.scaleX = 0.95;
			i142.y = 27.8;
			i142.scaleY = 1.04;
			i159.x = -44.3;
			i159.scaleX = 0.89;
			i159.y = -77.5;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i173.x = 0;
			i173.scaleX = 0.95;
			i173.y = -41;
			i173.scaleY = 1.04;
			i173.rotation = 0;
			i173.alpha = 1;
			i173.filters = new as3.Array(new object[]{});
			i173.scale9Grid = null;
			i173.visible = true;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 0.94;
			i142.scaleX = 0.99;
			i142.y = 29.7;
			i142.scaleY = 1;
			i173.scaleX = 0.99;
			i173.y = -36.5;
			i173.scaleY = 1;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 0.98;
			i142.scaleX = 1.02;
			i142.y = 31.7;
			i142.scaleY = 0.96;
			i173.scaleX = 1.02;
			i173.y = -31.9;
			i173.scaleY = 0.96;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 1.03;
			i142.scaleX = 1.06;
			i142.y = 33.5;
			i142.scaleY = 0.92;
			i173.scaleX = 1.06;
			i173.y = -27.3;
			i173.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 1.08;
			i142.scaleX = 1.09;
			i142.y = 35.5;
			i142.scaleY = 0.88;
			i173.scaleX = 1.09;
			i173.y = -22.6;
			i173.scaleY = 0.88;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 1.06;
			i142.scaleX = 1.07;
			i142.y = 34.3;
			i142.scaleY = 0.9;
			i173.scaleX = 1.07;
			i173.y = -25.4;
			i173.scaleY = 0.9;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 1.05;
			i142.scaleX = 1.06;
			i142.y = 33.1;
			i142.scaleY = 0.93;
			i173.scaleX = 1.06;
			i173.y = -28.2;
			i173.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 1.03;
			i142.scaleX = 1.04;
			i142.y = 31.9;
			i142.scaleY = 0.95;
			i173.scaleX = 1.04;
			i173.y = -31;
			i173.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 1.02;
			i142.scaleX = 1.02;
			i142.y = 30.8;
			i142.scaleY = 0.98;
			i173.scaleX = 1.02;
			i173.y = -33.8;
			i173.scaleY = 0.98;
		};
		f = l.Add();
		f.Add(i167);
		f.Add(i142);
		f.Add(i173);
		f.Add(i169);
		f.Add(keyVolume);
		f.Add(keyMovie);
		f.Add(caseShining);
		f += () => {
			i167.scaleX = 1;
			i142.scaleX = 1;
			i142.y = 29.6;
			i142.scaleY = 1;
			i173.scaleX = 1;
			i173.y = -36.6;
			i173.scaleY = 1;
		};
		setFrames(l);
	}
}
public class RegularKey : BitmapData{ 
	public RegularKey() {
		width = 52;
		height = 37;
		setPixels("a1a3a30747291eecf49577ebf8d4cba5");
	}
}
public class ReviewActive : BitmapData{ 
	public ReviewActive() {
		width = 21;
		height = 12;
		setPixels("aca704d647e9d6074d16ce88520ddc3a");
	}
}
public class ScreenProfileVipMan : BitmapData{ 
	public ScreenProfileVipMan() {
		width = 64;
		height = 40;
		setPixels("cf2019531a6a2ca5ffd156a8dff5c337");
	}
}
public class ScreenProfileVipWoman : BitmapData{ 
	public ScreenProfileVipWoman() {
		width = 64;
		height = 40;
		setPixels("2d9ca7611795eeb4c0c23108214be9cf");
	}
}
public class StartGameProfileIcon : BitmapData{ 
	public StartGameProfileIcon() {
		width = 24;
		height = 24;
		setPixels("6ea1bfb8b0bd3a698ce8d56d41da0e64");
	}
}
public class SwitchCaseButton : SimpleButton{ 
	public SwitchCaseButton() {
		downState = new symbol_53();
		overState = new symbol_53();
		upState = new symbol_53();
		hitTestState = new symbol_53();
	}
}
public class SwitchToGolden : MovieClip{ 
	public SwitchToGolden() {
		var filter_0 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.95,-0.12,0.17,0.00,0.00,0.03,1.02,-0.05,0.00,0.00,-0.14,0.14,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_1 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.08,-0.07,0.99,0.00,0.00,0.33,0.88,-0.22,0.00,0.00,-0.59,1.36,0.24,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_2 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.07,0.06,1.00,0.00,0.00,0.37,0.83,-0.20,0.00,0.00,-0.55,1.49,0.07,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_3 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.23,-0.17,0.94,0.00,0.00,0.29,0.93,-0.22,0.00,0.00,-0.60,1.20,0.40,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_4 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.52,-0.29,0.77,0.00,0.00,0.20,1.00,-0.20,0.00,0.00,-0.54,0.85,0.69,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_5 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.65,-0.29,0.64,0.00,0.00,0.15,1.02,-0.17,0.00,0.00,-0.47,0.66,0.81,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_6 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.51,0.75,0.76,0.00,0.00,0.47,0.60,-0.07,0.00,0.00,-0.17,1.73,-0.56,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_7 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.43,0.56,0.86,0.00,0.00,0.45,0.66,-0.11,0.00,0.00,-0.29,1.71,-0.42,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_8 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.20,0.21,0.99,0.00,0.00,0.41,0.77,-0.18,0.00,0.00,-0.49,1.59,-0.10,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_9 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.57,0.93,0.63,0.00,0.00,0.47,0.55,-0.02,0.00,0.00,-0.03,1.70,-0.67,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_10 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.87,-0.21,0.34,0.00,0.00,0.07,1.03,-0.10,0.00,0.00,-0.27,0.30,0.96,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_11 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_12 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.60,1.11,0.49,0.00,0.00,0.46,0.50,0.03,0.00,0.00,0.12,1.65,-0.76,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_13 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.32,0.38,0.94,0.00,0.00,0.43,0.72,-0.15,0.00,0.00,-0.40,1.67,-0.27,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_14 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.38,-0.25,0.87,0.00,0.00,0.24,0.97,-0.21,0.00,0.00,-0.59,1.03,0.55,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_15 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.77,-0.27,0.50,0.00,0.00,0.11,1.03,-0.14,0.00,0.00,-0.38,0.48,0.90,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var i181 = new symbol_55(){x = 5.2 , y = -4 , filters = new as3.Array(new object[]{filter_12})};
		addChild(i181);//0
		FrameInfo f;
		var l= new Frames(16);
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.x = 5.2;
			i181.scaleX = 1;
			i181.y = -4;
			i181.scaleY = 1;
			i181.rotation = 0;
			i181.alpha = 1;
			i181.filters = new as3.Array(new object[]{filter_12});
			i181.scale9Grid = null;
			i181.visible = true;
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_9});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_6});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_7});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_13});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_8});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_2});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_1});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_3});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_14});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_4});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_5});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_15});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_10});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_0});
		};
		f = l.Add();
		f.Add(i181);
		f += () => {
			i181.filters = new as3.Array(new object[]{filter_11});
		};
		setFrames(l);
	}
}
public class SwitchToRegular : MovieClip{ 
	public SwitchToRegular() {
		var filter_0 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.47,-0.28,0.81,0.00,0.00,0.21,0.99,-0.20,0.00,0.00,-0.56,0.92,0.65,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_1 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.86,-0.22,0.36,0.00,0.00,0.07,1.03,-0.10,0.00,0.00,-0.29,0.33,0.96,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_2 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.75,-0.28,0.53,0.00,0.00,0.12,1.03,-0.15,0.00,0.00,-0.40,0.52,0.88,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_3 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.41,0.52,0.88,0.00,0.00,0.45,0.67,-0.12,0.00,0.00,-0.32,1.71,-0.39,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_4 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.62,-0.30,0.68,0.00,0.00,0.16,1.02,-0.18,0.00,0.00,-0.50,0.72,0.78,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_5 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.00,0.00,1.00,0.00,0.00,0.36,0.85,-0.21,0.00,0.00,-0.57,1.43,0.14,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_6 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.94,-0.13,0.18,0.00,0.00,0.03,1.02,-0.05,0.00,0.00,-0.15,0.15,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_7 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.15,-0.12,0.97,0.00,0.00,0.31,0.91,-0.22,0.00,0.00,-0.60,1.28,0.32,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_8 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.15,0.16,1.00,0.00,0.00,0.40,0.79,-0.19,0.00,0.00,-0.52,1.56,-0.04,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_9 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_10 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.50,0.72,0.77,0.00,0.00,0.47,0.61,-0.08,0.00,0.00,-0.19,1.73,-0.54,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_11 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.60,1.11,0.49,0.00,0.00,0.46,0.50,0.03,0.00,0.00,0.12,1.65,-0.76,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_12 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.29,0.33,0.96,0.00,0.00,0.43,0.73,-0.16,0.00,0.00,-0.43,1.65,-0.22,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_13 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{-0.56,0.92,0.64,0.00,0.00,0.47,0.55,-0.02,0.00,0.00,-0.04,1.71,-0.66,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_14 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{0.31,-0.22,0.90,0.00,0.00,0.26,0.95,-0.22,0.00,0.00,-0.60,1.11,0.49,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var i184 = new symbol_56(){x = 5.2 , y = -4 , filters = new as3.Array(new object[]{filter_9})};
		addChild(i184);//0
		FrameInfo f;
		var l= new Frames(15);
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.x = 5.2;
			i184.scaleX = 1;
			i184.y = -4;
			i184.scaleY = 1;
			i184.rotation = 0;
			i184.alpha = 1;
			i184.filters = new as3.Array(new object[]{filter_9});
			i184.scale9Grid = null;
			i184.visible = true;
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_6});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_1});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_2});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_4});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_0});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_14});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_7});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_5});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_8});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_12});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_3});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_10});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_13});
		};
		f = l.Add();
		f.Add(i184);
		f += () => {
			i184.filters = new as3.Array(new object[]{filter_11});
		};
		setFrames(l);
	}
}
namespace profile_fla
{	public class ef1_16 : MovieClip{ 
		public ef1_16() {
			var i66 = new symbol_22();
			addChild(i66);//0
			FrameInfo f;
			var l= new Frames(14);
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
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			f.Add(i66);
			f = l.Add();
			setFrames(l);
		}
	}
	public class ef1_26 : MovieClip{ 
		public ef1_26() {
			var i131 = new symbol_32();
			addChild(i131);//0
			FrameInfo f;
			var l= new Frames(14);
			f = l.Add();
			f.Add(i131);
			f += () => {
				i131.x = 0;
				i131.scaleX = 1;
				i131.y = 0;
				i131.scaleY = 1;
				i131.rotation = 0;
				i131.alpha = 1;
				i131.filters = new as3.Array(new object[]{});
				i131.scale9Grid = null;
				i131.visible = true;
			};
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			f.Add(i131);
			f = l.Add();
			setFrames(l);
		}
	}
	public class key_22 : MovieClip{ 
		public key_22() {
			var i133 = new symbol_33();
			addChild(i133);//0
			FrameInfo f;
			var l= new Frames(2);
			f = l.Add();
			f.Add(i133);
			f += () => {
				i133.x = 0;
				i133.scaleX = 1;
				i133.y = 0;
				i133.scaleY = 1;
				i133.rotation = 0;
				i133.alpha = 1;
				i133.filters = new as3.Array(new object[]{});
				i133.scale9Grid = null;
				i133.visible = true;
			};
			f = l.Add();
			f.Add(i133);
			setFrames(l);
		}
	}
	public class key_9 : MovieClip{ 
		public key_9() {
			var i49 = new symbol_9();
			addChild(i49);//0
			FrameInfo f;
			var l= new Frames(2);
			f = l.Add();
			f.Add(i49);
			f += () => {
				i49.x = 0;
				i49.scaleX = 1;
				i49.y = 0;
				i49.scaleY = 1;
				i49.rotation = 0;
				i49.alpha = 1;
				i49.filters = new as3.Array(new object[]{});
				i49.scale9Grid = null;
				i49.visible = true;
			};
			f = l.Add();
			f.Add(i49);
			setFrames(l);
		}
	}
	public class volume_8 : MovieClip{ 
		public volume_8() {
			var i48 = new profile_fla.key_9(){x = 48.3 , scaleX = 0.46 , y = 7.8 , scaleY = 0.46 , rotation = 14};
			addChild(i48);//0
			FrameInfo f;
			var l= new Frames(50);
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.3;
				i48.scaleX = 0.46;
				i48.y = 7.8;
				i48.scaleY = 0.46;
				i48.rotation = 14;
				i48.alpha = 1;
				i48.filters = new as3.Array(new object[]{});
				i48.scale9Grid = null;
				i48.visible = true;
			};
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.4;
				i48.y = 8.2;
				i48.scaleY = 0.45;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.y = 8.7;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.5;
				i48.y = 9.1;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.y = 9.5;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.6;
				i48.y = 9.8;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.y = 10.3;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.8;
				i48.y = 10.6;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.9;
				i48.y = 10.9;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.y = 11.2;
				i48.scaleY = 0.44;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 49;
				i48.y = 11.5;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.y = 11.8;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.y = 12;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.y = 12.2;
			};
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 49.7;
				i48.scaleX = 0.45;
				i48.y = 13.9;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 50.5;
				i48.y = 15.6;
				i48.scaleY = 0.43;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 51.1;
				i48.y = 17.4;
				i48.scaleY = 0.42;
				i48.rotation = 13;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 51.9;
				i48.y = 19;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 52.5;
				i48.y = 20.7;
				i48.scaleY = 0.41;
				i48.rotation = 12;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 51.2;
				i48.y = 17.9;
				i48.scaleY = 0.42;
				i48.rotation = 13;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 49.8;
				i48.y = 15.1;
				i48.scaleY = 0.43;
				i48.rotation = 14;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.5;
				i48.y = 12.2;
				i48.scaleY = 0.44;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 47.1;
				i48.scaleX = 0.46;
				i48.y = 9.3;
				i48.scaleY = 0.45;
				i48.rotation = 15;
			};
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 47.5;
				i48.y = 9.9;
				i48.scaleY = 0.44;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 47.9;
				i48.y = 10.5;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.3;
				i48.y = 11.1;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 48.6;
				i48.y = 11.7;
			};
			f = l.Add();
			f.Add(i48);
			f += () => {
				i48.x = 49;
				i48.y = 12.2;
				i48.rotation = 14;
			};
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			f = l.Add();
			f.Add(i48);
			setFrames(l);
		}
	}
}
namespace profile.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("a1868a99043cb38ecdc73379f5aff8d8", 0, 0, 231, 140, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("c3ce9f50033818290841fdf2b1b6ff49", -117, -20.5, 234, 41, 1, 1);
		}
	}
	public class symbol_10 : Shape{ 
		public symbol_10() {
			setGraphics("e9b5858a8ba09192565b1f2e0099b5b6", -5.05, -6.3, 10.149999999999999, 12.649999999999999, 1, 1);
		}
	}
	public class symbol_11 : MovieClip{ 
		public symbol_11() {
			var i52 = new symbol_10();
			addChild(i52);//0
		}
	}
	public class symbol_12 : MorphShape{ 
		public symbol_12() {
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("8a6a4d915b7f25f8babfb7682138a042", -37.35, -40.8, 69.95, 78.1, 1, 1);
		}
	}
	public class symbol_14 : MovieClip{ 
		public symbol_14() {
			var i53 = new symbol_12();
			addChild(i53);//0
			var i56 = new symbol_13();
			addChild(i56);//0
			var i54 = new symbol_12();
			addChild(i54);//1
			var i57 = new symbol_13();
			addChild(i57);//1
			var i58 = new symbol_13();
			addChild(i58);//2
			var i55 = new symbol_12();
			addChild(i55);//2
			FrameInfo f;
			var l= new Frames(45);
			f = l.Add();
			f.Add(i53);
			f += () => {
				i53.x = 0;
				i53.scaleX = 1;
				i53.y = 0;
				i53.scaleY = 1;
				i53.rotation = 0;
				i53.alpha = 1;
				i53.filters = new as3.Array(new object[]{});
				i53.scale9Grid = null;
				i53.visible = true;
			};
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f += () => {
				i54.x = 0;
				i54.scaleX = 1;
				i54.y = 0;
				i54.scaleY = 1;
				i54.rotation = 0;
				i54.alpha = 1;
				i54.filters = new as3.Array(new object[]{});
				i54.scale9Grid = null;
				i54.visible = true;
			};
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f.Add(i55);
			f += () => {
				i55.x = 0;
				i55.scaleX = 1;
				i55.y = 0;
				i55.scaleY = 1;
				i55.rotation = 0;
				i55.alpha = 1;
				i55.filters = new as3.Array(new object[]{});
				i55.scale9Grid = null;
				i55.visible = true;
			};
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i53);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
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
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i54);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f += () => {
				i57.x = 0;
				i57.scaleX = 1;
				i57.y = 0;
				i57.scaleY = 1;
				i57.rotation = 0;
				i57.alpha = 1;
				i57.filters = new as3.Array(new object[]{});
				i57.scale9Grid = null;
				i57.visible = true;
			};
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
			f.Add(i55);
			f = l.Add();
			f.Add(i56);
			f.Add(i57);
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
			setFrames(l);
		}
	}
	public class symbol_15 : Shape{ 
		public symbol_15() {
			setGraphics("dad03ee9ef4575eae5e735b9ca39cbf0", -87.65, -64.25, 175.3, 128.45, 1, 1);
		}
	}
	public class symbol_16 : MovieClip{ 
		public symbol_16() {
			var i60 = new symbol_15();
			addChild(i60);//0
		}
	}
	public class symbol_17 : Shape{ 
		public symbol_17() {
			setGraphics("b92bf1b99b1501eb0a257397b4992a78", -153.5, -153, 307, 306, 1, 1);
		}
	}
	public class symbol_18 : MovieClip{ 
		public symbol_18() {
			var i63 = new symbol_17();
			addChild(i63);//0
		}
	}
	public class symbol_19 : MovieClip{ 
		public symbol_19() {
			var i62 = new symbol_18();
			addChild(i62);//0
			FrameInfo f;
			var l= new Frames(341);
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.x = 0;
				i62.scaleX = 1;
				i62.y = 0;
				i62.scaleY = 1;
				i62.rotation = 0;
				i62.alpha = 1;
				i62.filters = new as3.Array(new object[]{});
				i62.scale9Grid = null;
				i62.visible = true;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 1;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 2;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 3;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 4;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 5;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 6;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 7;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 8;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 9;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 10;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 11;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 12;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 13;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 14;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 15;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 16;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 18;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 19;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 20;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 21;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 22;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 23;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 24;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 25;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 26;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 27;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 28;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 29;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 30;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 31;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 32;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 33;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 34;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 36;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 37;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 38;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 39;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 40;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 41;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 42;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 43;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 44;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 45;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 46;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 47;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 48;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 49;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 50;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 51;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 52;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 53;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 55;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 56;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 57;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 58;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 59;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 60;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 61;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 62;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 63;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 64;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 65;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 66;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 67;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 68;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 69;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 70;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 71;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 73;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 74;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 75;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 76;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 77;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 78;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 79;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 80;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 81;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 82;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 83;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 84;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 85;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 86;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 87;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 88;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 90;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 91;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 92;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 93;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 94;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 95;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 96;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 97;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 98;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 99;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 100;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 101;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 102;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 103;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 104;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 105;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 106;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 108;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 109;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 110;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 111;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 112;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 113;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 114;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 115;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 116;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 117;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 118;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 119;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 120;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 121;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 122;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 123;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 124;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 126;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 127;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 128;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 129;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 130;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 131;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 132;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 133;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 134;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 135;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 136;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 137;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 138;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 139;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 140;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 141;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 142;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 143;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 145;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 146;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 147;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 148;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 149;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 150;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 151;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 152;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 153;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 154;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 155;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 156;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 157;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 158;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 159;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 160;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 161;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 163;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 164;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 165;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 166;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 167;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 168;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 169;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 170;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 171;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 172;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 173;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 174;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 175;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 176;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 177;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 178;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 180;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -178;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -177;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -176;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -175;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -174;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -173;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -172;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -171;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -170;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -169;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -168;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -167;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -166;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -165;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -164;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -163;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -161;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -160;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -159;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -158;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -157;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -156;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -155;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -154;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -153;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -152;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -151;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -150;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -149;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -148;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -147;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -146;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -145;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -143;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -142;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -141;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -140;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -139;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -138;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -137;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -136;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -135;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -134;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -133;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -132;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -131;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -130;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -129;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -128;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -127;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -126;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -124;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -123;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -122;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -121;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -120;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -119;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -118;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -117;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -116;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -115;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -114;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -113;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -112;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -111;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -110;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -109;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -108;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -106;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -105;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -104;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -103;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -102;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -101;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -100;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -99;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -98;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -97;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -96;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -95;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -94;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -93;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -92;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -91;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -90;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -88;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -87;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -86;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -85;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -84;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -83;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -82;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -81;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -80;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -79;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -78;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -77;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -76;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -75;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -74;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -73;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -71;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -70;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -69;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -68;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -67;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -66;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -65;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -64;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -63;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -62;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -61;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -60;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -59;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -58;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -57;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -56;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -55;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -53;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -52;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -51;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -50;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -49;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -48;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -47;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -46;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -45;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -44;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -43;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -42;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -41;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -40;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -39;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -38;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -37;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -36;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -34;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -33;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -32;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -31;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -30;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -29;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -28;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -27;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -26;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -25;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -24;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -23;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -22;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -21;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -20;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -19;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -18;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -16;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -15;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -14;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -13;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -12;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -11;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -10;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -9;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -8;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -7;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -6;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -5;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -4;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -3;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -2;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = -1;
			};
			f = l.Add();
			f.Add(i62);
			f += () => {
				i62.rotation = 0;
			};
			setFrames(l);
		}
	}
	public class symbol_2 : MovieClip{ 
		public symbol_2() {
			var i41 = new symbol_1();
			addChild(i41);//0
		}
	}
	public class symbol_20 : Shape{ 
		public symbol_20() {
			setGraphics("85bf8d1946be34a4c5f2e932a5e6a52d", -53, -53, 106, 106, 1, 1);
		}
	}
	public class symbol_21 : MovieClip{ 
		public symbol_21() {
			var i64 = new symbol_20();
			addChild(i64);//0
		}
	}
	public class symbol_22 : Shape{ 
		public symbol_22() {
			setGraphics("7476abe961f7c5e578e4bc4756f84816", -57.7, -74.9, 154.35000000000002, 83.9, 1, 1);
		}
	}
	public class symbol_23 : Shape{ 
		public symbol_23() {
			setGraphics("e2d82985d6e774c3378468e536cd3660", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_24 : Shape{ 
		public symbol_24() {
			setGraphics("2632ddd0fbf14eb1b40e63cd95f5116a", -87.85, -41.7, 175.7, 83.35, 1, 1);
		}
	}
	public class symbol_25 : MovieClip{ 
		public symbol_25() {
			var i72 = new symbol_24();
			addChild(i72);//0
		}
	}
	public class symbol_26 : Shape{ 
		public symbol_26() {
			setGraphics("d36d313459b99dabf0de4da938a1b974", 0, 0, 28, 28, 1, 1);
		}
	}
	public class symbol_27 : Shape{ 
		public symbol_27() {
			setGraphics("7331d49c7718731ddb79639a8fd260fb", 4, 4, 20, 20, 1, 1);
		}
	}
	public class symbol_28 : Shape{ 
		public symbol_28() {
			setGraphics("a9e9bc9df415224bf7f1e2c5a21bac55", 4, 3, 21, 21, 1, 1);
		}
	}
	public class symbol_29 : Shape{ 
		public symbol_29() {
			setGraphics("6143dce9c53b25b53f8a0f420386b048", 1, -1, 28, 28, 1, 1);
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("62072bfb6d216aa3cebea8d50f393fef", -84.7, -48.7, 169.4, 97.35, 1, 1);
		}
	}
	public class symbol_30 : Shape{ 
		public symbol_30() {
			setGraphics("7ae8810d6403c120b32f6084ea8dc9eb", 0, 0, 23, 27, 1, 1);
		}
	}
	public class symbol_31 : Shape{ 
		public symbol_31() {
			setGraphics("80ca9fc7051161d81d0d60a76319f4cf", 0, 0, 32, 28, 1, 1);
		}
	}
	public class symbol_32 : Shape{ 
		public symbol_32() {
			setGraphics("766defb666e471d7355bafd0b36c980b", -57.7, -74.9, 154.35000000000002, 83.9, 1, 1);
		}
	}
	public class symbol_33 : Shape{ 
		public symbol_33() {
			setGraphics("32cb60aa917cc858fad01f9d5459a27c", -60.6, -41.25, 121.2, 82.5, 1, 1);
		}
	}
	public class symbol_34 : MovieClip{ 
		public symbol_34() {
			var i141 = new symbol_1();
			addChild(i141);//0
		}
	}
	public class symbol_35 : Shape{ 
		public symbol_35() {
			setGraphics("9c41f2bfbdeedb2d169836b40f84cf64", -84.7, -48.7, 169.4, 97.35, 1, 1);
		}
	}
	public class symbol_36 : MovieClip{ 
		public symbol_36() {
			var i143 = new symbol_35();
			addChild(i143);//0
		}
	}
	public class symbol_37 : Shape{ 
		public symbol_37() {
			setGraphics("c3389d84051a7ce589a38667011e833f", -87.85, -41.7, 175.7, 83.35, 1, 1);
		}
	}
	public class symbol_38 : MovieClip{ 
		public symbol_38() {
			var i145 = new symbol_37();
			addChild(i145);//0
		}
	}
	public class symbol_39 : Shape{ 
		public symbol_39() {
			setGraphics("8a9748cfb45ac2a6651eb8d79f49eb5f", -34.75, -25.45, 63.1, 60.95, 1, 1);
		}
	}
	public class symbol_4 : MovieClip{ 
		public symbol_4() {
			var i43 = new symbol_3();
			addChild(i43);//0
		}
	}
	public class symbol_40 : MovieClip{ 
		public symbol_40() {
			var i147 = new symbol_39();
			addChild(i147);//0
		}
	}
	public class symbol_41 : MovieClip{ 
		public symbol_41() {
			var i152 = new symbol_10();
			addChild(i152);//0
		}
	}
	public class symbol_42 : MovieClip{ 
		public symbol_42() {
			var i156 = new symbol_13();
			addChild(i156);//0
			var i153 = new symbol_12();
			addChild(i153);//0
			var i154 = new symbol_12();
			addChild(i154);//1
			var i157 = new symbol_13();
			addChild(i157);//1
			var i158 = new symbol_13();
			addChild(i158);//2
			var i155 = new symbol_12();
			addChild(i155);//2
			FrameInfo f;
			var l= new Frames(45);
			f = l.Add();
			f.Add(i153);
			f += () => {
				i153.x = 0;
				i153.scaleX = 1;
				i153.y = 0;
				i153.scaleY = 1;
				i153.rotation = 0;
				i153.alpha = 1;
				i153.filters = new as3.Array(new object[]{});
				i153.scale9Grid = null;
				i153.visible = true;
			};
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f += () => {
				i154.x = 0;
				i154.scaleX = 1;
				i154.y = 0;
				i154.scaleY = 1;
				i154.rotation = 0;
				i154.alpha = 1;
				i154.filters = new as3.Array(new object[]{});
				i154.scale9Grid = null;
				i154.visible = true;
			};
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f.Add(i155);
			f += () => {
				i155.x = 0;
				i155.scaleX = 1;
				i155.y = 0;
				i155.scaleY = 1;
				i155.rotation = 0;
				i155.alpha = 1;
				i155.filters = new as3.Array(new object[]{});
				i155.scale9Grid = null;
				i155.visible = true;
			};
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i153);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f += () => {
				i156.x = 0;
				i156.scaleX = 1;
				i156.y = 0;
				i156.scaleY = 1;
				i156.rotation = 0;
				i156.alpha = 1;
				i156.filters = new as3.Array(new object[]{});
				i156.scale9Grid = null;
				i156.visible = true;
			};
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i154);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f += () => {
				i157.x = 0;
				i157.scaleX = 1;
				i157.y = 0;
				i157.scaleY = 1;
				i157.rotation = 0;
				i157.alpha = 1;
				i157.filters = new as3.Array(new object[]{});
				i157.scale9Grid = null;
				i157.visible = true;
			};
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i155);
			f = l.Add();
			f.Add(i156);
			f.Add(i157);
			f.Add(i158);
			f += () => {
				i158.x = 0;
				i158.scaleX = 1;
				i158.y = 0;
				i158.scaleY = 1;
				i158.rotation = 0;
				i158.alpha = 1;
				i158.filters = new as3.Array(new object[]{});
				i158.scale9Grid = null;
				i158.visible = true;
			};
			setFrames(l);
		}
	}
	public class symbol_43 : Shape{ 
		public symbol_43() {
			setGraphics("80af23a89dbb0548064a89c08022e6ff", -87.65, -64.25, 175.3, 128.45, 1, 1);
		}
	}
	public class symbol_44 : MovieClip{ 
		public symbol_44() {
			var i160 = new symbol_43();
			addChild(i160);//0
		}
	}
	public class symbol_45 : MovieClip{ 
		public symbol_45() {
			var i163 = new symbol_17();
			addChild(i163);//0
		}
	}
	public class symbol_46 : MovieClip{ 
		public symbol_46() {
			var i162 = new symbol_45();
			addChild(i162);//0
			FrameInfo f;
			var l= new Frames(341);
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.x = 0;
				i162.scaleX = 1;
				i162.y = 0;
				i162.scaleY = 1;
				i162.rotation = 0;
				i162.alpha = 1;
				i162.filters = new as3.Array(new object[]{});
				i162.scale9Grid = null;
				i162.visible = true;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 1;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 2;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 3;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 4;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 5;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 6;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 7;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 8;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 9;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 10;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 11;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 12;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 13;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 14;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 15;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 16;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 18;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 19;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 20;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 21;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 22;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 23;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 24;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 25;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 26;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 27;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 28;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 29;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 30;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 31;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 32;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 33;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 34;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 36;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 37;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 38;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 39;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 40;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 41;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 42;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 43;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 44;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 45;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 46;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 47;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 48;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 49;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 50;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 51;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 52;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 53;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 55;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 56;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 57;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 58;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 59;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 60;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 61;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 62;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 63;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 64;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 65;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 66;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 67;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 68;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 69;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 70;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 71;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 73;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 74;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 75;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 76;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 77;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 78;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 79;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 80;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 81;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 82;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 83;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 84;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 85;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 86;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 87;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 88;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 90;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 91;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 92;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 93;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 94;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 95;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 96;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 97;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 98;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 99;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 100;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 101;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 102;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 103;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 104;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 105;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 106;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 108;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 109;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 110;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 111;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 112;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 113;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 114;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 115;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 116;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 117;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 118;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 119;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 120;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 121;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 122;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 123;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 124;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 126;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 127;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 128;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 129;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 130;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 131;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 132;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 133;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 134;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 135;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 136;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 137;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 138;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 139;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 140;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 141;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 142;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 143;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 145;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 146;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 147;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 148;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 149;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 150;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 151;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 152;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 153;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 154;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 155;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 156;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 157;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 158;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 159;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 160;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 161;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 163;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 164;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 165;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 166;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 167;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 168;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 169;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 170;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 171;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 172;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 173;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 174;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 175;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 176;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 177;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 178;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 180;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -178;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -177;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -176;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -175;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -174;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -173;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -172;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -171;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -170;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -169;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -168;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -167;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -166;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -165;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -164;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -163;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -161;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -160;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -159;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -158;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -157;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -156;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -155;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -154;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -153;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -152;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -151;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -150;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -149;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -148;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -147;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -146;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -145;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -143;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -142;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -141;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -140;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -139;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -138;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -137;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -136;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -135;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -134;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -133;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -132;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -131;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -130;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -129;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -128;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -127;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -126;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -124;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -123;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -122;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -121;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -120;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -119;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -118;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -117;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -116;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -115;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -114;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -113;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -112;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -111;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -110;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -109;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -108;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -106;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -105;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -104;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -103;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -102;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -101;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -100;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -99;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -98;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -97;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -96;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -95;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -94;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -93;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -92;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -91;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -90;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -88;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -87;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -86;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -85;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -84;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -83;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -82;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -81;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -80;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -79;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -78;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -77;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -76;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -75;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -74;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -73;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -71;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -70;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -69;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -68;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -67;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -66;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -65;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -64;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -63;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -62;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -61;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -60;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -59;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -58;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -57;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -56;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -55;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -53;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -52;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -51;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -50;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -49;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -48;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -47;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -46;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -45;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -44;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -43;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -42;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -41;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -40;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -39;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -38;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -37;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -36;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -34;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -33;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -32;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -31;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -30;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -29;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -28;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -27;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -26;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -25;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -24;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -23;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -22;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -21;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -20;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -19;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -18;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -16;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -15;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -14;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -13;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -12;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -11;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -10;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -9;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -8;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -7;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -6;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -5;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -4;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -3;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -2;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = -1;
			};
			f = l.Add();
			f.Add(i162);
			f += () => {
				i162.rotation = 0;
			};
			setFrames(l);
		}
	}
	public class symbol_47 : Shape{ 
		public symbol_47() {
			setGraphics("a815caeec4e576c3d834d19f450b61ff", -99.5, -22.5, 199, 45, 1, 1);
		}
	}
	public class symbol_48 : MovieClip{ 
		public symbol_48() {
			var i164 = new symbol_47();
			addChild(i164);//0
		}
	}
	public class symbol_49 : MovieClip{ 
		public symbol_49() {
			var i168 = new symbol_1();
			addChild(i168);//0
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("2632ddd0fbf14eb1b40e63cd95f5116a", -87.85, -41.7, 175.7, 83.35, 1, 1);
		}
	}
	public class symbol_50 : Shape{ 
		public symbol_50() {
			setGraphics("5aa599dd221cb01fc074ddd6973276b8", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_51 : Shape{ 
		public symbol_51() {
			setGraphics("c3389d84051a7ce589a38667011e833f", -87.85, -41.7, 175.7, 83.35, 1, 1);
		}
	}
	public class symbol_52 : MovieClip{ 
		public symbol_52() {
			var i174 = new symbol_51();
			addChild(i174);//0
		}
	}
	public class symbol_53 : Shape{ 
		public symbol_53() {
			setGraphics("99b9e162932141f837e2bbaaa3165755", 0, 0, 45, 45, 1, 1);
		}
	}
	public class symbol_54 : Shape{ 
		public symbol_54() {
			setGraphics("ebf5711ef8c21c0d729a5b558f617afb", -118.5, -63.55, 207.3, 151.7, 1, 1);
		}
	}
	public class symbol_55 : MovieClip{ 
		public symbol_55() {
			var i182 = new symbol_54(){y = -11.4 , x = 13.4};
			addChild(i182);//0
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i182);
			f += () => {
				i182.x = 13.4;
				i182.scaleX = 1;
				i182.y = -11.4;
				i182.scaleY = 1;
				i182.rotation = 0;
				i182.alpha = 1;
				i182.filters = new as3.Array(new object[]{});
				i182.scale9Grid = null;
				i182.visible = true;
			};
			f = l.Add();
			f.Add(i182);
			f = l.Add();
			f.Add(i182);
			f += () => {
				i182.x = -2.1;
				i182.scaleX = 1.25;
				i182.y = -22.6;
				i182.scaleY = 1.25;
			};
			f = l.Add();
			f.Add(i182);
			f = l.Add();
			f.Add(i182);
			f += () => {
				i182.x = 2.3;
				i182.y = -38;
			};
			f = l.Add();
			f.Add(i182);
			f = l.Add();
			f.Add(i182);
			f += () => {
				i182.x = 6.5;
				i182.y = -52.7;
			};
			f = l.Add();
			f.Add(i182);
			f = l.Add();
			f.Add(i182);
			f += () => {
				i182.x = 12.2;
				i182.y = -57;
			};
			f = l.Add();
			f.Add(i182);
			f = l.Add();
			f.Add(i182);
			f += () => {
				i182.x = 11.5;
				i182.y = -62;
			};
			f = l.Add();
			f.Add(i182);
			f = l.Add();
			f.Add(i182);
			f += () => {
				i182.x = 16;
				i182.y = -67.5;
			};
			f = l.Add();
			f.Add(i182);
			f = l.Add();
			f.Add(i182);
			f += () => {
				i182.x = 7.7;
				i182.y = -60.8;
			};
			f = l.Add();
			f.Add(i182);
			setFrames(l);
		}
	}
	public class symbol_56 : MovieClip{ 
		public symbol_56() {
			var i185 = new symbol_54(){y = -11.4 , x = 13.4};
			addChild(i185);//0
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i185);
			f += () => {
				i185.x = 13.4;
				i185.scaleX = 1;
				i185.y = -11.4;
				i185.scaleY = 1;
				i185.rotation = 0;
				i185.alpha = 1;
				i185.filters = new as3.Array(new object[]{});
				i185.scale9Grid = null;
				i185.visible = true;
			};
			f = l.Add();
			f.Add(i185);
			f = l.Add();
			f.Add(i185);
			f += () => {
				i185.x = -2.1;
				i185.scaleX = 1.25;
				i185.y = -22.6;
				i185.scaleY = 1.25;
			};
			f = l.Add();
			f.Add(i185);
			f = l.Add();
			f.Add(i185);
			f += () => {
				i185.x = 2.3;
				i185.y = -38;
			};
			f = l.Add();
			f.Add(i185);
			f = l.Add();
			f.Add(i185);
			f += () => {
				i185.x = 6.5;
				i185.y = -52.7;
			};
			f = l.Add();
			f.Add(i185);
			f = l.Add();
			f.Add(i185);
			f += () => {
				i185.x = 12.2;
				i185.y = -57;
			};
			f = l.Add();
			f.Add(i185);
			f = l.Add();
			f.Add(i185);
			f += () => {
				i185.x = 11.5;
				i185.y = -62;
			};
			f = l.Add();
			f.Add(i185);
			f = l.Add();
			f.Add(i185);
			f += () => {
				i185.x = 16;
				i185.y = -67.5;
			};
			f = l.Add();
			f.Add(i185);
			f = l.Add();
			f.Add(i185);
			f += () => {
				i185.x = 7.7;
				i185.y = -60.8;
			};
			f = l.Add();
			f.Add(i185);
			setFrames(l);
		}
	}
	public class symbol_6 : MovieClip{ 
		public symbol_6() {
			var i45 = new symbol_5();
			addChild(i45);//0
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("ea2478b7d928b786e19bb8417d7901a3", -37.1, -25.45, 65.45, 60.95, 1, 1);
		}
	}
	public class symbol_8 : MovieClip{ 
		public symbol_8() {
			var i47 = new symbol_7();
			addChild(i47);//0
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("32cb60aa917cc858fad01f9d5459a27c", -60.6, -41.25, 121.2, 82.5, 1, 1);
		}
	}
}
