using System;
using flash.text;
using flash.display;
using System.Collections.Generic;
using moneyBox.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class LibmoneyBox : ResourcesExternalLib{
	public LibmoneyBox() {
	vectors = new string[] {
	"851d3c56619bf456a16bb2a9690c2dc8",
	"c7b6f338ba5188a0167a27b50ca7afb3",
	"07a63db5ae74483c3ef322aec7b5435d",
	"c835772130dd29f3f2ff041bbd0ff36c",
	"387000a4b7b2bfa48981af03b5e5c30f",
	"51beb69a795f53df44bc2a637911d9f1",
	"4fdf43b212985d4a8328ff632bbf054e",
	"181660296cf447a5db63ee5133200d00",
	"61460a248b331e1c2a46e33f56f773b6",
	"288d3686192777125fec5f26778f6fcd",
	"040190892575efb318c9c2cc85f00cad",
	"301f62708420720d68346e14e6a1eadb",
	"ffefaf5f341f10cfd8140a6cf5ba1d06",
	"1ac7c153508d34d6e13de5030311b6c5",
	"d9d8ae251a1ea668b0c675bcf7f772be",
	"01092839c761246a410da52fc83eae7e",
	"4a539148f5ce3531ad8140c0c4573d1c",
	"e1334018e756ba9f76c956032013d878",
	"c4ef3b3d0624370a75da494dd8da014b",
	"8711cfb1cced39739118560f51ec9249"
	};
	graphics = new string[] {
	"undefined",
	"b43f6e2e9318f91c31dd669cf5d44096",
	"82c346bcad1f3010f6752c50c32ed194",
	"5bc27bc303d61c2e1550251e7beeebe6",
	"11046e6cb7bc5a529fbcac330d485dbf",
	"e5deea2235cb56b65ca86b5955a3606b",
	"ca2fd63c94328edc683ba8582a6b10ef",
	"34232132b6145c6d6e19a6bd1902769f",
	"931fb50421d32a502a4051d0ea498b95",
	"a42f817e565649cd1e1b6aae57041130",
	"0a564cdc58e5dd6ba0d550594c876260",
	"fcc73ec40860ca13b8a6bf55b76066ab",
	"387e917b32fe2ae34e8203f867e8f150",
	"094fb2274e2cf23790ad3f34ba0c7472",
	"da27bc63db511bc404c3488023f00985",
	"847f3e960e84dcb99bd4fc270996a7c3",
	"76699df6e445677ed7a06c089d026b90",
	"56b38de9af91b8862e74e9dc9b64ec99"
	};
	}
}
public class BreakClipGold : MovieClip{ 
	public BreakClipGold() {
		var filter_0 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_1 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-51.00,0.00,1.00,0.00,0.00,-51.00,0.00,0.00,1.00,0.00,-51.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_2 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-2.04,0.00,1.00,0.00,0.00,-2.04,0.00,0.00,1.00,0.00,-2.04,0.00,0.00,0.00,1.00,0.00})};
		var filter_3 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-18.36,0.00,1.00,0.00,0.00,-18.36,0.00,0.00,1.00,0.00,-18.36,0.00,0.00,0.00,1.00,0.00})};
		var filter_4 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-8.16,0.00,1.00,0.00,0.00,-8.16,0.00,0.00,1.00,0.00,-8.16,0.00,0.00,0.00,1.00,0.00})};
		var filter_5 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-32.64,0.00,1.00,0.00,0.00,-32.64,0.00,0.00,1.00,0.00,-32.64,0.00,0.00,0.00,1.00,0.00})};
		var i36 = new symbol_1(){filters = new as3.Array(new object[]{})};
		addChild(i36);//0
		var i41 = new symbol_6(){x = 114.3 , y = 4.8 , filters = new as3.Array(new object[]{})};
		addChild(i41);//0
		var i38 = new symbol_3(){x = 212.8 , scaleX = 1 , y = 63.9 , scaleY = 1 , rotation = 51 , filters = new as3.Array(new object[]{})};
		addChild(i38);//1
		var i40 = new symbol_4(){filters = new as3.Array(new object[]{})};
		addChild(i40);//1
		var i43 = new symbol_8(){x = 39.9 , scaleX = 0.68 , scaleY = 0.68 , filters = new as3.Array(new object[]{})};
		addChild(i43);//1
		var i45 = new symbol_9(){filters = new as3.Array(new object[]{})};
		addChild(i45);//2
		var i46 = new symbol_11(){x = -8.7 , y = 21.3 , filters = new as3.Array(new object[]{})};
		addChild(i46);//3
		var i48 = new symbol_13(){x = 65.2 , y = 60.5 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i48);//4
		var i57 = new symbol_22(){x = 90.1 , scaleX = 0.68 , y = 186.3 , scaleY = 1 , rotation = -96 , filters = new as3.Array(new object[]{})};
		addChild(i57);//4
		var i55 = new symbol_20(){x = 16.4 , y = 142.2 , filters = new as3.Array(new object[]{})};
		addChild(i55);//5
		var i50 = new symbol_15(){x = 19.1 , y = 106.2 , filters = new as3.Array(new object[]{})};
		addChild(i50);//5
		var i52 = new symbol_17(){x = 143.8 , y = 65.8 , filters = new as3.Array(new object[]{})};
		addChild(i52);//6
		var i59 = new symbol_24(){x = 45.9 , y = 170.5 , filters = new as3.Array(new object[]{})};
		addChild(i59);//6
		var i61 = new symbol_25(){x = 168.1 , y = 116.5 , filters = new as3.Array(new object[]{})};
		addChild(i61);//7
		var i54 = new symbol_18(){filters = new as3.Array(new object[]{})};
		addChild(i54);//7
		var i63 = new symbol_27(){x = 26.4 , scaleX = 0.84 , y = 152.3 , scaleY = 0.84 , rotation = 77 , filters = new as3.Array(new object[]{})};
		addChild(i63);//8
		var i65 = new symbol_29(){x = 161.8 , scaleX = 0.55 , y = 102.3 , scaleY = 0.55 , rotation = 28 , filters = new as3.Array(new object[]{})};
		addChild(i65);//8
		var i67 = new symbol_30(){x = -18.4 , scaleX = 0.55 , y = 97 , scaleY = 0.55 , rotation = -2 , filters = new as3.Array(new object[]{})};
		addChild(i67);//9
		var i69 = new symbol_31(){x = 161.8 , scaleX = 0.55 , y = 132.1 , scaleY = 0.55 , rotation = 4 , filters = new as3.Array(new object[]{})};
		addChild(i69);//10
		FrameInfo f;
		var l= new Frames(84);
		f = l.Add("^pig");
		f.Add(i36);
		f += () => {
			i36.x = 0;
			i36.scaleX = 1;
			i36.y = 0;
			i36.scaleY = 1;
			i36.rotation = 0;
			i36.alpha = 1;
			i36.filters = new as3.Array(new object[]{});
			i36.scale9Grid = null;
			i36.visible = true;
		};
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add();
		f.Add(i36);
		f = l.Add("^hammer");
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 212.8;
			i38.scaleX = 1;
			i38.y = 63.9;
			i38.scaleY = 1;
			i38.rotation = 51;
			i38.alpha = 1;
			i38.filters = new as3.Array(new object[]{});
			i38.scale9Grid = null;
			i38.visible = true;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 228.7;
			i38.y = 69;
			i38.rotation = 71;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 241.1;
			i38.y = 75.8;
			i38.rotation = 88;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 250.1;
			i38.y = 82.8;
			i38.rotation = 102;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 256.1;
			i38.y = 89.4;
			i38.rotation = 114;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 260.1;
			i38.y = 94.8;
			i38.rotation = 123;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 262.4;
			i38.y = 98.7;
			i38.rotation = 130;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 263.7;
			i38.y = 101;
			i38.rotation = 134;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 264.1;
			i38.y = 101.7;
			i38.rotation = 135;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 230.2;
			i38.y = 70;
			i38.rotation = 59;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i38.x = 193.7;
			i38.y = 73.5;
			i38.rotation = 4;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f += () => {
			i36.x = -6.8;
			i36.scaleX = 1.07;
			i36.y = 7.7;
			i36.scaleY = 0.95;
			i38.x = 177.9;
			i38.y = 86;
			i38.rotation = -27;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.x = -13.5;
			i36.scaleX = 1.15;
			i36.y = 15.4;
			i36.scaleY = 0.91;
			i38.x = 174.4;
			i38.y = 91.3;
			i38.rotation = -38;
			i40.x = 0;
			i40.scaleX = 1;
			i40.y = 0;
			i40.scaleY = 1;
			i40.rotation = 0;
			i40.alpha = 1;
			i40.filters = new as3.Array(new object[]{});
			i40.scale9Grid = null;
			i40.visible = true;
		};
		f = l.Add();
		f.Add(i36);
		f.Add(i38);
		f.Add(i40);
		f += () => {
			i36.x = -20.3;
			i36.scaleX = 1.22;
			i36.y = 23.1;
			i36.scaleY = 0.86;
			i38.x = 183.2;
			i38.y = 75.1;
			i38.rotation = -6;
		};
		f = l.Add("^pig_broke");
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i48);
		f.Add(i50);
		f.Add(i52);
		f.Add(i54);
		f += () => {
			i41.x = 114.3;
			i41.scaleX = 1;
			i41.y = 4.8;
			i41.scaleY = 1;
			i41.rotation = 0;
			i41.alpha = 1;
			i41.filters = new as3.Array(new object[]{});
			i41.scale9Grid = null;
			i41.visible = true;
			i38.x = 194.9;
			i38.y = 66.8;
			i38.rotation = 19;
			i43.x = 39.9;
			i43.scaleX = 0.68;
			i43.y = 0;
			i43.scaleY = 0.68;
			i43.rotation = 0;
			i43.alpha = 1;
			i43.filters = new as3.Array(new object[]{});
			i43.scale9Grid = null;
			i43.visible = true;
			i45.x = 0;
			i45.scaleX = 1;
			i45.y = 0;
			i45.scaleY = 1;
			i45.rotation = 0;
			i45.alpha = 1;
			i45.filters = new as3.Array(new object[]{});
			i45.scale9Grid = null;
			i45.visible = true;
			i46.x = -8.7;
			i46.scaleX = 1;
			i46.y = 21.3;
			i46.scaleY = 1;
			i46.rotation = 0;
			i46.alpha = 1;
			i46.filters = new as3.Array(new object[]{});
			i46.scale9Grid = null;
			i46.visible = true;
			i48.x = 65.2;
			i48.scaleX = 1;
			i48.y = 60.5;
			i48.scaleY = 1;
			i48.rotation = 0;
			i48.alpha = 1;
			i48.filters = new as3.Array(new object[]{filter_0});
			i48.scale9Grid = null;
			i48.visible = true;
			i50.x = 19.1;
			i50.scaleX = 1;
			i50.y = 106.2;
			i50.scaleY = 1;
			i50.rotation = 0;
			i50.alpha = 1;
			i50.filters = new as3.Array(new object[]{});
			i50.scale9Grid = null;
			i50.visible = true;
			i52.x = 143.8;
			i52.scaleX = 1;
			i52.y = 65.8;
			i52.scaleY = 1;
			i52.rotation = 0;
			i52.alpha = 1;
			i52.filters = new as3.Array(new object[]{});
			i52.scale9Grid = null;
			i52.visible = true;
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
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i48);
		f.Add(i50);
		f.Add(i52);
		f.Add(i54);
		f += () => {
			i41.x = 120.7;
			i41.scaleX = 1.06;
			i41.y = 30.3;
			i41.scaleY = 0.82;
			i41.rotation = 3;
			i38.x = 204.7;
			i38.y = 64;
			i38.rotation = 37;
			i43.x = 36.5;
			i43.y = 0.7;
			i43.rotation = -1;
			i46.x = -9.5;
			i46.y = 21.8;
			i46.rotation = 1;
			i48.x = 67.6;
			i48.y = 62.1;
			i48.scaleY = 0.98;
			i48.filters = new as3.Array(new object[]{filter_2});
			i50.x = 19.6;
			i50.y = 113.5;
			i52.x = 145.9;
			i52.y = 82.8;
			i52.rotation = 13;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i48);
		f.Add(i50);
		f.Add(i52);
		f += () => {
			i41.x = 126.3;
			i41.scaleX = 1.1;
			i41.y = 51;
			i41.scaleY = 0.68;
			i41.rotation = 5;
			i38.x = 210.8;
			i38.y = 63.8;
			i38.rotation = 48;
			i43.x = 28.3;
			i43.y = 3.5;
			i43.rotation = -6;
			i46.x = -11.2;
			i46.y = 23.4;
			i46.rotation = 5;
			i48.x = 73.8;
			i48.y = 68.5;
			i48.scaleY = 0.93;
			i48.filters = new as3.Array(new object[]{filter_4});
			i50.x = 19.9;
			i50.y = 117.9;
			i52.x = 148.3;
			i52.y = 97.5;
			i52.rotation = 23;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i48);
		f.Add(i50);
		f.Add(i52);
		f += () => {
			i41.x = 130.7;
			i41.scaleX = 1.14;
			i41.y = 67.1;
			i41.scaleY = 0.56;
			i41.rotation = 7;
			i38.x = 212.8;
			i38.y = 63.9;
			i38.rotation = 51;
			i43.x = 16.1;
			i43.y = 11.9;
			i43.rotation = -14;
			i46.x = -12.6;
			i46.y = 28.1;
			i46.rotation = 13;
			i48.x = 81.3;
			i48.y = 82;
			i48.scaleY = 0.85;
			i48.filters = new as3.Array(new object[]{filter_3});
			i50.y = 119.3;
			i52.x = 150.4;
			i52.y = 109.3;
			i52.rotation = 32;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i48);
		f.Add(i55);
		f.Add(i52);
		f += () => {
			i41.x = 134.1;
			i41.scaleX = 1.17;
			i41.y = 78.5;
			i41.scaleY = 0.48;
			i41.rotation = 9;
			i43.x = 2.5;
			i43.y = 28.2;
			i43.rotation = -26;
			i46.x = -11.9;
			i46.y = 37.9;
			i46.rotation = 23;
			i48.x = 86.8;
			i48.y = 103.5;
			i48.scaleY = 0.74;
			i48.filters = new as3.Array(new object[]{filter_5});
			i55.x = 16.4;
			i55.scaleX = 1;
			i55.y = 142.2;
			i55.scaleY = 1;
			i55.rotation = 0;
			i55.alpha = 1;
			i55.filters = new as3.Array(new object[]{});
			i55.scale9Grid = null;
			i55.visible = true;
			i52.x = 152.1;
			i52.y = 118;
			i52.rotation = 38;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i48);
		f.Add(i55);
		f.Add(i52);
		f += () => {
			i41.x = 136;
			i41.scaleX = 1.18;
			i41.y = 85.5;
			i41.scaleY = 0.43;
			i43.x = -8.8;
			i43.y = 53.4;
			i43.rotation = -41;
			i46.x = -6.7;
			i46.y = 55.2;
			i46.rotation = 36;
			i48.x = 84.7;
			i48.y = 131.9;
			i48.scaleY = 0.59;
			i48.filters = new as3.Array(new object[]{filter_1});
			i55.y = 141.7;
			i52.x = 153.1;
			i52.y = 123.3;
			i52.rotation = 41;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f += () => {
			i41.x = 136.6;
			i41.scaleX = 1.19;
			i41.y = 87.7;
			i41.scaleY = 0.42;
			i41.rotation = 10;
			i43.x = -15.4;
			i43.y = 85.9;
			i43.rotation = -59;
			i46.x = 4.8;
			i46.y = 81.3;
			i46.rotation = 52;
			i57.x = 90.1;
			i57.scaleX = 0.68;
			i57.y = 186.3;
			i57.scaleY = 1;
			i57.rotation = -96;
			i57.alpha = 1;
			i57.filters = new as3.Array(new object[]{});
			i57.scale9Grid = null;
			i57.visible = true;
			i55.y = 141.2;
			i52.x = 153.5;
			i52.y = 125.1;
			i52.rotation = 43;
			i59.x = 45.9;
			i59.scaleX = 1;
			i59.y = 170.5;
			i59.scaleY = 1;
			i59.rotation = 0;
			i59.alpha = 1;
			i59.filters = new as3.Array(new object[]{});
			i59.scale9Grid = null;
			i59.visible = true;
			i61.x = 168.1;
			i61.scaleX = 1;
			i61.y = 116.5;
			i61.scaleY = 1;
			i61.rotation = 0;
			i61.alpha = 1;
			i61.filters = new as3.Array(new object[]{});
			i61.scale9Grid = null;
			i61.visible = true;
			i63.x = 26.4;
			i63.scaleX = 0.84;
			i63.y = 152.3;
			i63.scaleY = 0.84;
			i63.rotation = 77;
			i63.alpha = 1;
			i63.filters = new as3.Array(new object[]{});
			i63.scale9Grid = null;
			i63.visible = true;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f += () => {
			i41.x = 137.2;
			i41.y = 86.9;
			i43.x = -15.2;
			i43.y = 85;
			i46.x = 4.7;
			i46.y = 80.5;
			i57.x = 90;
			i57.y = 185.6;
			i55.y = 140.6;
			i52.x = 153.6;
			i52.y = 124.5;
			i59.y = 168.3;
			i61.y = 114.3;
			i63.x = 27.2;
			i63.y = 152.5;
			i63.rotation = 80;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f += () => {
			i41.x = 137.7;
			i41.y = 86;
			i43.x = -14.9;
			i43.y = 84.2;
			i46.x = 4.8;
			i46.y = 79.5;
			i57.y = 184.8;
			i55.y = 141.2;
			i52.y = 123.9;
			i59.y = 166.8;
			i61.y = 112.8;
			i63.x = 27.9;
			i63.y = 152.7;
			i63.rotation = 82;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i41.x = 138.2;
			i41.y = 85.2;
			i43.x = -18.4;
			i43.y = 82.5;
			i46.x = 4.6;
			i46.y = 78.3;
			i57.x = 90.1;
			i57.y = 184.3;
			i55.y = 141.7;
			i52.x = 153.5;
			i52.y = 123.2;
			i59.y = 165.8;
			i61.y = 111.8;
			i63.x = 28.4;
			i63.y = 153;
			i63.rotation = 85;
			i65.x = 161.8;
			i65.scaleX = 0.55;
			i65.y = 102.3;
			i65.scaleY = 0.55;
			i65.rotation = 28;
			i65.alpha = 1;
			i65.filters = new as3.Array(new object[]{});
			i65.scale9Grid = null;
			i65.visible = true;
			i67.x = -18.4;
			i67.scaleX = 0.55;
			i67.y = 97;
			i67.scaleY = 0.55;
			i67.rotation = -2;
			i67.alpha = 1;
			i67.filters = new as3.Array(new object[]{});
			i67.scale9Grid = null;
			i67.visible = true;
			i69.x = 161.8;
			i69.scaleX = 0.55;
			i69.y = 132.1;
			i69.scaleY = 0.55;
			i69.rotation = 4;
			i69.alpha = 1;
			i69.filters = new as3.Array(new object[]{});
			i69.scale9Grid = null;
			i69.visible = true;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i41.x = 138.6;
			i41.y = 86;
			i43.x = -19.4;
			i43.y = 83.6;
			i46.x = 3.4;
			i46.y = 79.3;
			i57.x = 90.3;
			i57.y = 185.4;
			i55.y = 142.2;
			i52.x = 153.6;
			i52.y = 123.8;
			i59.y = 165.6;
			i61.y = 111.5;
			i63.x = 27.9;
			i63.y = 152.7;
			i63.rotation = 82;
			i65.x = 162.2;
			i65.y = 102.1;
			i67.x = -18.2;
			i67.y = 96.5;
			i69.x = 162;
			i69.y = 131.7;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i41.x = 139.1;
			i41.y = 86.8;
			i38.alpha = 0.9;
			i43.x = -20.4;
			i43.y = 84.8;
			i46.x = 2.3;
			i46.y = 80.4;
			i57.x = 90.5;
			i57.y = 186.6;
			i52.x = 153.4;
			i52.y = 124.5;
			i59.y = 167.2;
			i61.y = 113.2;
			i63.x = 27.2;
			i63.y = 152.5;
			i63.rotation = 80;
			i65.x = 162.4;
			i65.y = 101.8;
			i67.x = -18.1;
			i67.y = 96.2;
			i69.x = 162.1;
			i69.y = 131.4;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i41.x = 139.6;
			i41.y = 87.7;
			i38.alpha = 0.8;
			i43.x = -21.4;
			i43.y = 85.9;
			i46.x = 1.1;
			i46.y = 81.3;
			i57.x = 90.7;
			i57.y = 187.8;
			i52.x = 153.5;
			i52.y = 125.1;
			i59.y = 168.8;
			i61.y = 114.8;
			i63.x = 26.4;
			i63.y = 152.3;
			i63.rotation = 77;
			i65.x = 162.6;
			i67.y = 96;
			i69.x = 162.2;
			i69.y = 131.2;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i38.alpha = 0.7;
			i57.x = 90.9;
			i57.y = 189.1;
			i59.y = 170.5;
			i61.y = 116.5;
			i65.y = 102;
			i67.x = -17.9;
			i67.y = 96.2;
			i69.x = 162.3;
			i69.y = 131.4;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i38.alpha = 0.6;
			i65.x = 162.7;
			i65.y = 102.2;
			i67.x = -17.6;
			i67.y = 96.3;
			i69.x = 162.6;
			i69.y = 131.6;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i38.alpha = 0.4;
			i65.x = 162.8;
			i65.y = 102.3;
			i67.x = -17.5;
			i67.y = 96.5;
			i69.x = 162.7;
			i69.y = 131.7;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i38.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i38.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i38.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i38);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		f += () => {
			i38.alpha = 0;
		};
		f = l.Add();
		f.Add(i41);
		f.Add(i43);
		f.Add(i45);
		f.Add(i46);
		f.Add(i57);
		f.Add(i55);
		f.Add(i52);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f.Add(i69);
		setFrames(l);
	}
}
public class BreakClipPink : MovieClip{ 
	public BreakClipPink() {
		var filter_0 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_1 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-51.00,0.00,1.00,0.00,0.00,-51.00,0.00,0.00,1.00,0.00,-51.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_2 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-2.04,0.00,1.00,0.00,0.00,-2.04,0.00,0.00,1.00,0.00,-2.04,0.00,0.00,0.00,1.00,0.00})};
		var filter_3 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-18.36,0.00,1.00,0.00,0.00,-18.36,0.00,0.00,1.00,0.00,-18.36,0.00,0.00,0.00,1.00,0.00})};
		var filter_4 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-8.16,0.00,1.00,0.00,0.00,-8.16,0.00,0.00,1.00,0.00,-8.16,0.00,0.00,0.00,1.00,0.00})};
		var filter_5 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-32.64,0.00,1.00,0.00,0.00,-32.64,0.00,0.00,1.00,0.00,-32.64,0.00,0.00,0.00,1.00,0.00})};
		var i77 = new symbol_38(){x = 114.3 , y = 4.8 , filters = new as3.Array(new object[]{})};
		addChild(i77);//0
		var i72 = new symbol_33(){filters = new as3.Array(new object[]{})};
		addChild(i72);//0
		var i79 = new symbol_40(){x = 39.9 , scaleX = 0.68 , scaleY = 0.68 , filters = new as3.Array(new object[]{})};
		addChild(i79);//1
		var i76 = new symbol_36(){filters = new as3.Array(new object[]{})};
		addChild(i76);//1
		var i74 = new symbol_35(){x = 212.8 , scaleX = 1 , y = 63.9 , scaleY = 1 , rotation = 51 , filters = new as3.Array(new object[]{})};
		addChild(i74);//1
		var i81 = new symbol_41(){filters = new as3.Array(new object[]{})};
		addChild(i81);//2
		var i82 = new symbol_43(){x = -8.7 , y = 21.3 , filters = new as3.Array(new object[]{})};
		addChild(i82);//3
		var i84 = new symbol_45(){x = 65.2 , y = 60.5 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i84);//4
		var i93 = new symbol_53(){x = 90.1 , scaleX = 0.68 , y = 186.3 , scaleY = 1 , rotation = -96 , filters = new as3.Array(new object[]{})};
		addChild(i93);//4
		var i91 = new symbol_52(){x = 16.4 , y = 142.2 , filters = new as3.Array(new object[]{})};
		addChild(i91);//5
		var i86 = new symbol_47(){x = 19.1 , y = 106.2 , filters = new as3.Array(new object[]{})};
		addChild(i86);//5
		var i95 = new symbol_55(){x = 45.9 , y = 170.5 , filters = new as3.Array(new object[]{})};
		addChild(i95);//6
		var i88 = new symbol_49(){x = 143.8 , y = 65.8 , filters = new as3.Array(new object[]{})};
		addChild(i88);//6
		var i97 = new symbol_56(){x = 168.1 , y = 116.5 , filters = new as3.Array(new object[]{})};
		addChild(i97);//7
		var i90 = new symbol_50(){filters = new as3.Array(new object[]{})};
		addChild(i90);//7
		var i99 = new symbol_58(){x = 26.4 , scaleX = 0.84 , y = 152.3 , scaleY = 0.84 , rotation = 77 , filters = new as3.Array(new object[]{})};
		addChild(i99);//8
		var i101 = new symbol_59(){x = 161.8 , scaleX = 0.55 , y = 102.3 , scaleY = 0.55 , rotation = 28 , filters = new as3.Array(new object[]{})};
		addChild(i101);//8
		var i103 = new symbol_60(){x = -18.4 , scaleX = 0.55 , y = 97 , scaleY = 0.55 , rotation = -2 , filters = new as3.Array(new object[]{})};
		addChild(i103);//9
		var i105 = new symbol_61(){x = 161.8 , scaleX = 0.55 , y = 132.1 , scaleY = 0.55 , rotation = 4 , filters = new as3.Array(new object[]{})};
		addChild(i105);//10
		FrameInfo f;
		var l= new Frames(84);
		f = l.Add("^pig");
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
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add();
		f.Add(i72);
		f = l.Add("^hammer");
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 212.8;
			i74.scaleX = 1;
			i74.y = 63.9;
			i74.scaleY = 1;
			i74.rotation = 51;
			i74.alpha = 1;
			i74.filters = new as3.Array(new object[]{});
			i74.scale9Grid = null;
			i74.visible = true;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 228.7;
			i74.y = 69;
			i74.rotation = 71;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 241.1;
			i74.y = 75.8;
			i74.rotation = 88;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 250.1;
			i74.y = 82.8;
			i74.rotation = 102;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 256.1;
			i74.y = 89.4;
			i74.rotation = 114;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 260.1;
			i74.y = 94.8;
			i74.rotation = 123;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 262.4;
			i74.y = 98.7;
			i74.rotation = 130;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 263.7;
			i74.y = 101;
			i74.rotation = 134;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 264.1;
			i74.y = 101.7;
			i74.rotation = 135;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 230.2;
			i74.y = 70;
			i74.rotation = 59;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i74.x = 193.7;
			i74.y = 73.5;
			i74.rotation = 4;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i74);
		f += () => {
			i72.x = -6.8;
			i72.scaleX = 1.07;
			i72.y = 7.7;
			i72.scaleY = 0.95;
			i74.x = 177.9;
			i74.y = 86;
			i74.rotation = -27;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i76);
		f.Add(i74);
		f += () => {
			i72.x = -13.5;
			i72.scaleX = 1.15;
			i72.y = 15.4;
			i72.scaleY = 0.91;
			i76.x = 0;
			i76.scaleX = 1;
			i76.y = 0;
			i76.scaleY = 1;
			i76.rotation = 0;
			i76.alpha = 1;
			i76.filters = new as3.Array(new object[]{});
			i76.scale9Grid = null;
			i76.visible = true;
			i74.x = 174.4;
			i74.y = 91.3;
			i74.rotation = -38;
		};
		f = l.Add();
		f.Add(i72);
		f.Add(i76);
		f.Add(i74);
		f += () => {
			i72.x = -20.3;
			i72.scaleX = 1.22;
			i72.y = 23.1;
			i72.scaleY = 0.86;
			i74.x = 183.2;
			i74.y = 75.1;
			i74.rotation = -6;
		};
		f = l.Add("^pig_broke");
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i84);
		f.Add(i86);
		f.Add(i88);
		f.Add(i90);
		f += () => {
			i77.x = 114.3;
			i77.scaleX = 1;
			i77.y = 4.8;
			i77.scaleY = 1;
			i77.rotation = 0;
			i77.alpha = 1;
			i77.filters = new as3.Array(new object[]{});
			i77.scale9Grid = null;
			i77.visible = true;
			i79.x = 39.9;
			i79.scaleX = 0.68;
			i79.y = 0;
			i79.scaleY = 0.68;
			i79.rotation = 0;
			i79.alpha = 1;
			i79.filters = new as3.Array(new object[]{});
			i79.scale9Grid = null;
			i79.visible = true;
			i74.x = 194.9;
			i74.y = 66.8;
			i74.rotation = 19;
			i81.x = 0;
			i81.scaleX = 1;
			i81.y = 0;
			i81.scaleY = 1;
			i81.rotation = 0;
			i81.alpha = 1;
			i81.filters = new as3.Array(new object[]{});
			i81.scale9Grid = null;
			i81.visible = true;
			i82.x = -8.7;
			i82.scaleX = 1;
			i82.y = 21.3;
			i82.scaleY = 1;
			i82.rotation = 0;
			i82.alpha = 1;
			i82.filters = new as3.Array(new object[]{});
			i82.scale9Grid = null;
			i82.visible = true;
			i84.x = 65.2;
			i84.scaleX = 1;
			i84.y = 60.5;
			i84.scaleY = 1;
			i84.rotation = 0;
			i84.alpha = 1;
			i84.filters = new as3.Array(new object[]{filter_0});
			i84.scale9Grid = null;
			i84.visible = true;
			i86.x = 19.1;
			i86.scaleX = 1;
			i86.y = 106.2;
			i86.scaleY = 1;
			i86.rotation = 0;
			i86.alpha = 1;
			i86.filters = new as3.Array(new object[]{});
			i86.scale9Grid = null;
			i86.visible = true;
			i88.x = 143.8;
			i88.scaleX = 1;
			i88.y = 65.8;
			i88.scaleY = 1;
			i88.rotation = 0;
			i88.alpha = 1;
			i88.filters = new as3.Array(new object[]{});
			i88.scale9Grid = null;
			i88.visible = true;
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
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i84);
		f.Add(i86);
		f.Add(i88);
		f.Add(i90);
		f += () => {
			i77.x = 120.7;
			i77.scaleX = 1.06;
			i77.y = 30.3;
			i77.scaleY = 0.82;
			i77.rotation = 3;
			i79.x = 36.5;
			i79.y = 0.7;
			i79.rotation = -1;
			i74.x = 204.7;
			i74.y = 64;
			i74.rotation = 37;
			i82.x = -9.5;
			i82.y = 21.8;
			i82.rotation = 1;
			i84.x = 67.6;
			i84.y = 62.1;
			i84.scaleY = 0.98;
			i84.filters = new as3.Array(new object[]{filter_2});
			i86.x = 19.6;
			i86.y = 113.5;
			i88.x = 145.9;
			i88.y = 82.8;
			i88.rotation = 13;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i84);
		f.Add(i86);
		f.Add(i88);
		f += () => {
			i77.x = 126.3;
			i77.scaleX = 1.1;
			i77.y = 51;
			i77.scaleY = 0.68;
			i77.rotation = 5;
			i79.x = 28.3;
			i79.y = 3.5;
			i79.rotation = -6;
			i74.x = 210.8;
			i74.y = 63.8;
			i74.rotation = 48;
			i82.x = -11.2;
			i82.y = 23.4;
			i82.rotation = 5;
			i84.x = 73.8;
			i84.y = 68.5;
			i84.scaleY = 0.93;
			i84.filters = new as3.Array(new object[]{filter_4});
			i86.x = 19.9;
			i86.y = 117.9;
			i88.x = 148.3;
			i88.y = 97.5;
			i88.rotation = 23;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i84);
		f.Add(i86);
		f.Add(i88);
		f += () => {
			i77.x = 130.7;
			i77.scaleX = 1.14;
			i77.y = 67.1;
			i77.scaleY = 0.56;
			i77.rotation = 7;
			i79.x = 16.1;
			i79.y = 11.9;
			i79.rotation = -14;
			i74.x = 212.8;
			i74.y = 63.9;
			i74.rotation = 51;
			i82.x = -12.6;
			i82.y = 28.1;
			i82.rotation = 13;
			i84.x = 81.3;
			i84.y = 82;
			i84.scaleY = 0.85;
			i84.filters = new as3.Array(new object[]{filter_3});
			i86.y = 119.3;
			i88.x = 150.4;
			i88.y = 109.3;
			i88.rotation = 32;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i84);
		f.Add(i91);
		f.Add(i88);
		f += () => {
			i77.x = 134.1;
			i77.scaleX = 1.17;
			i77.y = 78.5;
			i77.scaleY = 0.48;
			i77.rotation = 9;
			i79.x = 2.5;
			i79.y = 28.2;
			i79.rotation = -26;
			i82.x = -11.9;
			i82.y = 37.9;
			i82.rotation = 23;
			i84.x = 86.8;
			i84.y = 103.5;
			i84.scaleY = 0.74;
			i84.filters = new as3.Array(new object[]{filter_5});
			i91.x = 16.4;
			i91.scaleX = 1;
			i91.y = 142.2;
			i91.scaleY = 1;
			i91.rotation = 0;
			i91.alpha = 1;
			i91.filters = new as3.Array(new object[]{});
			i91.scale9Grid = null;
			i91.visible = true;
			i88.x = 152.1;
			i88.y = 118;
			i88.rotation = 38;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i84);
		f.Add(i91);
		f.Add(i88);
		f += () => {
			i77.x = 136;
			i77.scaleX = 1.18;
			i77.y = 85.5;
			i77.scaleY = 0.43;
			i79.x = -8.8;
			i79.y = 53.4;
			i79.rotation = -41;
			i82.x = -6.7;
			i82.y = 55.2;
			i82.rotation = 36;
			i84.x = 84.7;
			i84.y = 131.9;
			i84.scaleY = 0.59;
			i84.filters = new as3.Array(new object[]{filter_1});
			i91.y = 141.7;
			i88.x = 153.1;
			i88.y = 123.3;
			i88.rotation = 41;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f += () => {
			i77.x = 136.6;
			i77.scaleX = 1.19;
			i77.y = 87.7;
			i77.scaleY = 0.42;
			i77.rotation = 10;
			i79.x = -15.4;
			i79.y = 85.9;
			i79.rotation = -59;
			i82.x = 4.8;
			i82.y = 81.3;
			i82.rotation = 52;
			i93.x = 90.1;
			i93.scaleX = 0.68;
			i93.y = 186.3;
			i93.scaleY = 1;
			i93.rotation = -96;
			i93.alpha = 1;
			i93.filters = new as3.Array(new object[]{});
			i93.scale9Grid = null;
			i93.visible = true;
			i91.y = 141.2;
			i95.x = 45.9;
			i95.scaleX = 1;
			i95.y = 170.5;
			i95.scaleY = 1;
			i95.rotation = 0;
			i95.alpha = 1;
			i95.filters = new as3.Array(new object[]{});
			i95.scale9Grid = null;
			i95.visible = true;
			i88.x = 153.5;
			i88.y = 125.1;
			i88.rotation = 43;
			i97.x = 168.1;
			i97.scaleX = 1;
			i97.y = 116.5;
			i97.scaleY = 1;
			i97.rotation = 0;
			i97.alpha = 1;
			i97.filters = new as3.Array(new object[]{});
			i97.scale9Grid = null;
			i97.visible = true;
			i99.x = 26.4;
			i99.scaleX = 0.84;
			i99.y = 152.3;
			i99.scaleY = 0.84;
			i99.rotation = 77;
			i99.alpha = 1;
			i99.filters = new as3.Array(new object[]{});
			i99.scale9Grid = null;
			i99.visible = true;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f += () => {
			i77.x = 137.2;
			i77.y = 86.9;
			i79.x = -15.2;
			i79.y = 85;
			i82.x = 4.7;
			i82.y = 80.5;
			i93.x = 90;
			i93.y = 185.6;
			i91.y = 140.6;
			i95.y = 168.3;
			i88.x = 153.6;
			i88.y = 124.5;
			i97.y = 114.3;
			i99.x = 27.2;
			i99.y = 152.5;
			i99.rotation = 80;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f += () => {
			i77.x = 137.7;
			i77.y = 86;
			i79.x = -14.9;
			i79.y = 84.2;
			i82.x = 4.8;
			i82.y = 79.5;
			i93.y = 184.8;
			i91.y = 141.2;
			i95.y = 166.8;
			i88.y = 123.9;
			i97.y = 112.8;
			i99.x = 27.9;
			i99.y = 152.7;
			i99.rotation = 82;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i77.x = 138.2;
			i77.y = 85.2;
			i79.x = -18.4;
			i79.y = 82.5;
			i82.x = 4.6;
			i82.y = 78.3;
			i93.x = 90.1;
			i93.y = 184.3;
			i91.y = 141.7;
			i95.y = 165.8;
			i88.x = 153.5;
			i88.y = 123.2;
			i97.y = 111.8;
			i99.x = 28.4;
			i99.y = 153;
			i99.rotation = 85;
			i101.x = 161.8;
			i101.scaleX = 0.55;
			i101.y = 102.3;
			i101.scaleY = 0.55;
			i101.rotation = 28;
			i101.alpha = 1;
			i101.filters = new as3.Array(new object[]{});
			i101.scale9Grid = null;
			i101.visible = true;
			i103.x = -18.4;
			i103.scaleX = 0.55;
			i103.y = 97;
			i103.scaleY = 0.55;
			i103.rotation = -2;
			i103.alpha = 1;
			i103.filters = new as3.Array(new object[]{});
			i103.scale9Grid = null;
			i103.visible = true;
			i105.x = 161.8;
			i105.scaleX = 0.55;
			i105.y = 132.1;
			i105.scaleY = 0.55;
			i105.rotation = 4;
			i105.alpha = 1;
			i105.filters = new as3.Array(new object[]{});
			i105.scale9Grid = null;
			i105.visible = true;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i77.x = 138.6;
			i77.y = 86;
			i79.x = -19.4;
			i79.y = 83.6;
			i82.x = 3.4;
			i82.y = 79.3;
			i93.x = 90.3;
			i93.y = 185.4;
			i91.y = 142.2;
			i95.y = 165.6;
			i88.x = 153.6;
			i88.y = 123.8;
			i97.y = 111.5;
			i99.x = 27.9;
			i99.y = 152.7;
			i99.rotation = 82;
			i101.x = 162.2;
			i101.y = 102.1;
			i103.x = -18.2;
			i103.y = 96.5;
			i105.x = 162;
			i105.y = 131.7;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i77.x = 139.1;
			i77.y = 86.8;
			i79.x = -20.4;
			i79.y = 84.8;
			i74.alpha = 0.9;
			i82.x = 2.3;
			i82.y = 80.4;
			i93.x = 90.5;
			i93.y = 186.6;
			i95.y = 167.2;
			i88.y = 124.5;
			i97.y = 113.2;
			i99.x = 27.2;
			i99.y = 152.5;
			i99.rotation = 80;
			i101.x = 162.4;
			i101.y = 101.8;
			i103.x = -18.1;
			i103.y = 96.2;
			i105.x = 162.1;
			i105.y = 131.4;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i77.x = 139.6;
			i77.y = 87.7;
			i79.x = -21.4;
			i79.y = 85.9;
			i74.alpha = 0.8;
			i82.x = 1.1;
			i82.y = 81.3;
			i93.x = 90.7;
			i93.y = 187.8;
			i95.y = 168.8;
			i88.x = 153.5;
			i88.y = 125.1;
			i97.y = 114.8;
			i99.x = 26.4;
			i99.y = 152.3;
			i99.rotation = 77;
			i101.x = 162.6;
			i103.y = 96;
			i105.x = 162.2;
			i105.y = 131.2;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i74.alpha = 0.7;
			i93.x = 90.9;
			i93.y = 189.1;
			i95.y = 170.5;
			i97.y = 116.5;
			i101.y = 102;
			i103.x = -17.9;
			i103.y = 96.2;
			i105.x = 162.3;
			i105.y = 131.4;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i74.alpha = 0.6;
			i101.x = 162.7;
			i101.y = 102.2;
			i103.x = -17.6;
			i103.y = 96.3;
			i105.x = 162.6;
			i105.y = 131.6;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i74.alpha = 0.4;
			i101.x = 162.8;
			i101.y = 102.3;
			i103.x = -17.5;
			i103.y = 96.5;
			i105.x = 162.7;
			i105.y = 131.7;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i74.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i74.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i74.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i74);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		f += () => {
			i74.alpha = 0;
		};
		f = l.Add();
		f.Add(i77);
		f.Add(i79);
		f.Add(i81);
		f.Add(i82);
		f.Add(i93);
		f.Add(i91);
		f.Add(i95);
		f.Add(i88);
		f.Add(i97);
		f.Add(i99);
		f.Add(i101);
		f.Add(i103);
		f.Add(i105);
		setFrames(l);
	}
}
public class BreakClipSilver : MovieClip{ 
	public BreakClipSilver() {
		var filter_0 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00,0.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_1 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-51.00,0.00,1.00,0.00,0.00,-51.00,0.00,0.00,1.00,0.00,-51.00,0.00,0.00,0.00,1.00,0.00})};
		var filter_2 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-2.04,0.00,1.00,0.00,0.00,-2.04,0.00,0.00,1.00,0.00,-2.04,0.00,0.00,0.00,1.00,0.00})};
		var filter_3 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-18.36,0.00,1.00,0.00,0.00,-18.36,0.00,0.00,1.00,0.00,-18.36,0.00,0.00,0.00,1.00,0.00})};
		var filter_4 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-8.16,0.00,1.00,0.00,0.00,-8.16,0.00,0.00,1.00,0.00,-8.16,0.00,0.00,0.00,1.00,0.00})};
		var filter_5 = new ColorMatrixFilter(){matrix = new as3.Array(new object[]{1.00,0.00,0.00,0.00,-32.64,0.00,1.00,0.00,0.00,-32.64,0.00,0.00,1.00,0.00,-32.64,0.00,0.00,0.00,1.00,0.00})};
		var i113 = new symbol_66(){x = 114.3 , y = 4.8 , filters = new as3.Array(new object[]{})};
		addChild(i113);//0
		var i108 = new symbol_63(){filters = new as3.Array(new object[]{})};
		addChild(i108);//0
		var i115 = new symbol_67(){x = 39.9 , scaleX = 0.68 , scaleY = 0.68 , filters = new as3.Array(new object[]{})};
		addChild(i115);//1
		var i110 = new symbol_64(){x = 212.8 , scaleX = 1 , y = 63.9 , scaleY = 1 , rotation = 51 , filters = new as3.Array(new object[]{})};
		addChild(i110);//1
		var i112 = new symbol_36(){filters = new as3.Array(new object[]{})};
		addChild(i112);//1
		var i117 = new symbol_41(){filters = new as3.Array(new object[]{})};
		addChild(i117);//2
		var i118 = new symbol_69(){x = -8.7 , y = 21.3 , filters = new as3.Array(new object[]{})};
		addChild(i118);//3
		var i129 = new symbol_76(){x = 90.1 , scaleX = 0.68 , y = 186.3 , scaleY = 1 , rotation = -96 , filters = new as3.Array(new object[]{})};
		addChild(i129);//4
		var i120 = new symbol_71(){x = 65.2 , y = 60.5 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i120);//4
		var i122 = new symbol_72(){x = 19.1 , y = 106.2 , filters = new as3.Array(new object[]{})};
		addChild(i122);//5
		var i127 = new symbol_75(){x = 16.4 , y = 142.2 , filters = new as3.Array(new object[]{})};
		addChild(i127);//5
		var i124 = new symbol_73(){x = 143.8 , y = 65.8 , filters = new as3.Array(new object[]{})};
		addChild(i124);//6
		var i131 = new symbol_77(){x = 45.9 , y = 170.5 , filters = new as3.Array(new object[]{})};
		addChild(i131);//6
		var i126 = new symbol_74(){filters = new as3.Array(new object[]{})};
		addChild(i126);//7
		var i133 = new symbol_78(){x = 168.1 , y = 116.5 , filters = new as3.Array(new object[]{})};
		addChild(i133);//7
		var i137 = new symbol_80(){x = 161.8 , scaleX = 0.55 , y = 102.3 , scaleY = 0.55 , rotation = 28 , filters = new as3.Array(new object[]{})};
		addChild(i137);//8
		var i135 = new symbol_79(){x = 26.4 , scaleX = 0.84 , y = 152.3 , scaleY = 0.84 , rotation = 77 , filters = new as3.Array(new object[]{})};
		addChild(i135);//8
		var i139 = new symbol_81(){x = -18.4 , scaleX = 0.55 , y = 97 , scaleY = 0.55 , rotation = -2 , filters = new as3.Array(new object[]{})};
		addChild(i139);//9
		var i141 = new symbol_82(){x = 161.8 , scaleX = 0.55 , y = 132.1 , scaleY = 0.55 , rotation = 4 , filters = new as3.Array(new object[]{})};
		addChild(i141);//10
		FrameInfo f;
		var l= new Frames(84);
		f = l.Add("^pig");
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
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add();
		f.Add(i108);
		f = l.Add("^hammer");
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 212.8;
			i110.scaleX = 1;
			i110.y = 63.9;
			i110.scaleY = 1;
			i110.rotation = 51;
			i110.alpha = 1;
			i110.filters = new as3.Array(new object[]{});
			i110.scale9Grid = null;
			i110.visible = true;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 228.7;
			i110.y = 69;
			i110.rotation = 71;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 241.1;
			i110.y = 75.8;
			i110.rotation = 88;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 250.1;
			i110.y = 82.8;
			i110.rotation = 102;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 256.1;
			i110.y = 89.4;
			i110.rotation = 114;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 260.1;
			i110.y = 94.8;
			i110.rotation = 123;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 262.4;
			i110.y = 98.7;
			i110.rotation = 130;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 263.7;
			i110.y = 101;
			i110.rotation = 134;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 264.1;
			i110.y = 101.7;
			i110.rotation = 135;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 230.2;
			i110.y = 70;
			i110.rotation = 59;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i110.x = 193.7;
			i110.y = 73.5;
			i110.rotation = 4;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f += () => {
			i108.x = -6.8;
			i108.scaleX = 1.07;
			i108.y = 7.7;
			i108.scaleY = 0.95;
			i110.x = 177.9;
			i110.y = 86;
			i110.rotation = -27;
		};
		f = l.Add();
		f.Add(i108);
		f.Add(i110);
		f.Add(i112);
		f += () => {
			i108.x = -13.5;
			i108.scaleX = 1.15;
			i108.y = 15.4;
			i108.scaleY = 0.91;
			i110.x = 174.4;
			i110.y = 91.3;
			i110.rotation = -38;
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
		f.Add(i108);
		f.Add(i110);
		f.Add(i112);
		f += () => {
			i108.x = -20.3;
			i108.scaleX = 1.22;
			i108.y = 23.1;
			i108.scaleY = 0.86;
			i110.x = 183.2;
			i110.y = 75.1;
			i110.rotation = -6;
		};
		f = l.Add("^pig_broke");
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f += () => {
			i113.x = 114.3;
			i113.scaleX = 1;
			i113.y = 4.8;
			i113.scaleY = 1;
			i113.rotation = 0;
			i113.alpha = 1;
			i113.filters = new as3.Array(new object[]{});
			i113.scale9Grid = null;
			i113.visible = true;
			i115.x = 39.9;
			i115.scaleX = 0.68;
			i115.y = 0;
			i115.scaleY = 0.68;
			i115.rotation = 0;
			i115.alpha = 1;
			i115.filters = new as3.Array(new object[]{});
			i115.scale9Grid = null;
			i115.visible = true;
			i110.x = 194.9;
			i110.y = 66.8;
			i110.rotation = 19;
			i117.x = 0;
			i117.scaleX = 1;
			i117.y = 0;
			i117.scaleY = 1;
			i117.rotation = 0;
			i117.alpha = 1;
			i117.filters = new as3.Array(new object[]{});
			i117.scale9Grid = null;
			i117.visible = true;
			i118.x = -8.7;
			i118.scaleX = 1;
			i118.y = 21.3;
			i118.scaleY = 1;
			i118.rotation = 0;
			i118.alpha = 1;
			i118.filters = new as3.Array(new object[]{});
			i118.scale9Grid = null;
			i118.visible = true;
			i120.x = 65.2;
			i120.scaleX = 1;
			i120.y = 60.5;
			i120.scaleY = 1;
			i120.rotation = 0;
			i120.alpha = 1;
			i120.filters = new as3.Array(new object[]{filter_0});
			i120.scale9Grid = null;
			i120.visible = true;
			i122.x = 19.1;
			i122.scaleX = 1;
			i122.y = 106.2;
			i122.scaleY = 1;
			i122.rotation = 0;
			i122.alpha = 1;
			i122.filters = new as3.Array(new object[]{});
			i122.scale9Grid = null;
			i122.visible = true;
			i124.x = 143.8;
			i124.scaleX = 1;
			i124.y = 65.8;
			i124.scaleY = 1;
			i124.rotation = 0;
			i124.alpha = 1;
			i124.filters = new as3.Array(new object[]{});
			i124.scale9Grid = null;
			i124.visible = true;
			i126.x = 0;
			i126.scaleX = 1;
			i126.y = 0;
			i126.scaleY = 1;
			i126.rotation = 0;
			i126.alpha = 1;
			i126.filters = new as3.Array(new object[]{});
			i126.scale9Grid = null;
			i126.visible = true;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f.Add(i126);
		f += () => {
			i113.x = 120.7;
			i113.scaleX = 1.06;
			i113.y = 30.3;
			i113.scaleY = 0.82;
			i113.rotation = 3;
			i115.x = 36.5;
			i115.y = 0.7;
			i115.rotation = -1;
			i110.x = 204.7;
			i110.y = 64;
			i110.rotation = 37;
			i118.x = -9.5;
			i118.y = 21.8;
			i118.rotation = 1;
			i120.x = 67.6;
			i120.y = 62.1;
			i120.scaleY = 0.98;
			i120.filters = new as3.Array(new object[]{filter_2});
			i122.x = 19.6;
			i122.y = 113.5;
			i124.x = 145.9;
			i124.y = 82.8;
			i124.rotation = 13;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f += () => {
			i113.x = 126.3;
			i113.scaleX = 1.1;
			i113.y = 51;
			i113.scaleY = 0.68;
			i113.rotation = 5;
			i115.x = 28.3;
			i115.y = 3.5;
			i115.rotation = -6;
			i110.x = 210.8;
			i110.y = 63.8;
			i110.rotation = 48;
			i118.x = -11.2;
			i118.y = 23.4;
			i118.rotation = 5;
			i120.x = 73.8;
			i120.y = 68.5;
			i120.scaleY = 0.93;
			i120.filters = new as3.Array(new object[]{filter_4});
			i122.x = 19.9;
			i122.y = 117.9;
			i124.x = 148.3;
			i124.y = 97.5;
			i124.rotation = 23;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i120);
		f.Add(i122);
		f.Add(i124);
		f += () => {
			i113.x = 130.7;
			i113.scaleX = 1.14;
			i113.y = 67.1;
			i113.scaleY = 0.56;
			i113.rotation = 7;
			i115.x = 16.1;
			i115.y = 11.9;
			i115.rotation = -14;
			i110.x = 212.8;
			i110.y = 63.9;
			i110.rotation = 51;
			i118.x = -12.6;
			i118.y = 28.1;
			i118.rotation = 13;
			i120.x = 81.3;
			i120.y = 82;
			i120.scaleY = 0.85;
			i120.filters = new as3.Array(new object[]{filter_3});
			i122.y = 119.3;
			i124.x = 150.4;
			i124.y = 109.3;
			i124.rotation = 32;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i120);
		f.Add(i127);
		f.Add(i124);
		f += () => {
			i113.x = 134.1;
			i113.scaleX = 1.17;
			i113.y = 78.5;
			i113.scaleY = 0.48;
			i113.rotation = 9;
			i115.x = 2.5;
			i115.y = 28.2;
			i115.rotation = -26;
			i118.x = -11.9;
			i118.y = 37.9;
			i118.rotation = 23;
			i120.x = 86.8;
			i120.y = 103.5;
			i120.scaleY = 0.74;
			i120.filters = new as3.Array(new object[]{filter_5});
			i127.x = 16.4;
			i127.scaleX = 1;
			i127.y = 142.2;
			i127.scaleY = 1;
			i127.rotation = 0;
			i127.alpha = 1;
			i127.filters = new as3.Array(new object[]{});
			i127.scale9Grid = null;
			i127.visible = true;
			i124.x = 152.1;
			i124.y = 118;
			i124.rotation = 38;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i120);
		f.Add(i127);
		f.Add(i124);
		f += () => {
			i113.x = 136;
			i113.scaleX = 1.18;
			i113.y = 85.5;
			i113.scaleY = 0.43;
			i115.x = -8.8;
			i115.y = 53.4;
			i115.rotation = -41;
			i118.x = -6.7;
			i118.y = 55.2;
			i118.rotation = 36;
			i120.x = 84.7;
			i120.y = 131.9;
			i120.scaleY = 0.59;
			i120.filters = new as3.Array(new object[]{filter_1});
			i127.y = 141.7;
			i124.x = 153.1;
			i124.y = 123.3;
			i124.rotation = 41;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i135);
		f += () => {
			i113.x = 136.6;
			i113.scaleX = 1.19;
			i113.y = 87.7;
			i113.scaleY = 0.42;
			i113.rotation = 10;
			i115.x = -15.4;
			i115.y = 85.9;
			i115.rotation = -59;
			i118.x = 4.8;
			i118.y = 81.3;
			i118.rotation = 52;
			i129.x = 90.1;
			i129.scaleX = 0.68;
			i129.y = 186.3;
			i129.scaleY = 1;
			i129.rotation = -96;
			i129.alpha = 1;
			i129.filters = new as3.Array(new object[]{});
			i129.scale9Grid = null;
			i129.visible = true;
			i127.y = 141.2;
			i124.x = 153.5;
			i124.y = 125.1;
			i124.rotation = 43;
			i131.x = 45.9;
			i131.scaleX = 1;
			i131.y = 170.5;
			i131.scaleY = 1;
			i131.rotation = 0;
			i131.alpha = 1;
			i131.filters = new as3.Array(new object[]{});
			i131.scale9Grid = null;
			i131.visible = true;
			i133.x = 168.1;
			i133.scaleX = 1;
			i133.y = 116.5;
			i133.scaleY = 1;
			i133.rotation = 0;
			i133.alpha = 1;
			i133.filters = new as3.Array(new object[]{});
			i133.scale9Grid = null;
			i133.visible = true;
			i135.x = 26.4;
			i135.scaleX = 0.84;
			i135.y = 152.3;
			i135.scaleY = 0.84;
			i135.rotation = 77;
			i135.alpha = 1;
			i135.filters = new as3.Array(new object[]{});
			i135.scale9Grid = null;
			i135.visible = true;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i135);
		f += () => {
			i113.x = 137.2;
			i113.y = 86.9;
			i115.x = -15.2;
			i115.y = 85;
			i118.x = 4.7;
			i118.y = 80.5;
			i129.x = 90;
			i129.y = 185.6;
			i127.y = 140.6;
			i124.x = 153.6;
			i124.y = 124.5;
			i131.y = 168.3;
			i133.y = 114.3;
			i135.x = 27.2;
			i135.y = 152.5;
			i135.rotation = 80;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i135);
		f += () => {
			i113.x = 137.7;
			i113.y = 86;
			i115.x = -14.9;
			i115.y = 84.2;
			i118.x = 4.8;
			i118.y = 79.5;
			i129.y = 184.8;
			i127.y = 141.2;
			i124.y = 123.9;
			i131.y = 166.8;
			i133.y = 112.8;
			i135.x = 27.9;
			i135.y = 152.7;
			i135.rotation = 82;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i113.x = 138.2;
			i113.y = 85.2;
			i115.x = -18.4;
			i115.y = 82.5;
			i118.x = 4.6;
			i118.y = 78.3;
			i129.x = 90.1;
			i129.y = 184.3;
			i127.y = 141.7;
			i124.x = 153.5;
			i124.y = 123.2;
			i131.y = 165.8;
			i133.y = 111.8;
			i137.x = 161.8;
			i137.scaleX = 0.55;
			i137.y = 102.3;
			i137.scaleY = 0.55;
			i137.rotation = 28;
			i137.alpha = 1;
			i137.filters = new as3.Array(new object[]{});
			i137.scale9Grid = null;
			i137.visible = true;
			i135.x = 28.4;
			i135.y = 153;
			i135.rotation = 85;
			i139.x = -18.4;
			i139.scaleX = 0.55;
			i139.y = 97;
			i139.scaleY = 0.55;
			i139.rotation = -2;
			i139.alpha = 1;
			i139.filters = new as3.Array(new object[]{});
			i139.scale9Grid = null;
			i139.visible = true;
			i141.x = 161.8;
			i141.scaleX = 0.55;
			i141.y = 132.1;
			i141.scaleY = 0.55;
			i141.rotation = 4;
			i141.alpha = 1;
			i141.filters = new as3.Array(new object[]{});
			i141.scale9Grid = null;
			i141.visible = true;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i113.x = 138.6;
			i113.y = 86;
			i115.x = -19.4;
			i115.y = 83.6;
			i118.x = 3.4;
			i118.y = 79.3;
			i129.x = 90.3;
			i129.y = 185.4;
			i127.y = 142.2;
			i124.x = 153.6;
			i124.y = 123.8;
			i131.y = 165.6;
			i133.y = 111.5;
			i137.x = 162.2;
			i137.y = 102.1;
			i135.x = 27.9;
			i135.y = 152.7;
			i135.rotation = 82;
			i139.x = -18.2;
			i139.y = 96.5;
			i141.x = 162;
			i141.y = 131.7;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i113.x = 139.1;
			i113.y = 86.8;
			i115.x = -20.4;
			i115.y = 84.8;
			i110.alpha = 0.9;
			i118.x = 2.3;
			i118.y = 80.4;
			i129.x = 90.5;
			i129.y = 186.6;
			i124.x = 153.4;
			i124.y = 124.5;
			i131.y = 167.2;
			i133.y = 113.2;
			i137.x = 162.4;
			i137.y = 101.8;
			i135.x = 27.2;
			i135.y = 152.5;
			i135.rotation = 80;
			i139.x = -18.1;
			i139.y = 96.2;
			i141.x = 162.1;
			i141.y = 131.4;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i113.x = 139.6;
			i113.y = 87.7;
			i115.x = -21.4;
			i115.y = 85.9;
			i110.alpha = 0.8;
			i118.x = 1.1;
			i118.y = 81.3;
			i129.x = 90.7;
			i129.y = 187.8;
			i124.x = 153.5;
			i124.y = 125.1;
			i131.y = 168.8;
			i133.y = 114.8;
			i137.x = 162.6;
			i135.x = 26.4;
			i135.y = 152.3;
			i135.rotation = 77;
			i139.y = 96;
			i141.x = 162.2;
			i141.y = 131.2;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i110.alpha = 0.7;
			i129.x = 90.9;
			i129.y = 189.1;
			i131.y = 170.5;
			i133.y = 116.5;
			i137.y = 102;
			i139.x = -17.9;
			i139.y = 96.2;
			i141.x = 162.3;
			i141.y = 131.4;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i110.alpha = 0.6;
			i137.x = 162.7;
			i137.y = 102.2;
			i139.x = -17.6;
			i139.y = 96.3;
			i141.x = 162.6;
			i141.y = 131.6;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i110.alpha = 0.4;
			i137.x = 162.8;
			i137.y = 102.3;
			i139.x = -17.5;
			i139.y = 96.5;
			i141.x = 162.7;
			i141.y = 131.7;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i110.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i110.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i110.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i110);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		f += () => {
			i110.alpha = 0;
		};
		f = l.Add();
		f.Add(i113);
		f.Add(i115);
		f.Add(i117);
		f.Add(i118);
		f.Add(i129);
		f.Add(i127);
		f.Add(i124);
		f.Add(i131);
		f.Add(i133);
		f.Add(i137);
		f.Add(i135);
		f.Add(i139);
		f.Add(i141);
		setFrames(l);
	}
}
public class MoneyBoxShining : MovieClip{ 
	public MoneyBoxShining() {
		var filter_0 = new BlurFilter(){blurX = 6, quality = 2, blurY = 6};
		var i144 = new symbol_83(){filters = new as3.Array(new object[]{})};
		addChild(i144);//0
		var i145 = new symbol_85(){x = -110.3 , scaleX = 0.98 , y = -96.8 , scaleY = 0.98 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i145);//1
	}
}
public class PigGold : BitmapData{ 
	public PigGold() {
		width = 68;
		height = 60;
		setPixels("fcc73ec40860ca13b8a6bf55b76066ab");
	}
}
public class PigPink : BitmapData{ 
	public PigPink() {
		width = 68;
		height = 60;
		setPixels("b43f6e2e9318f91c31dd669cf5d44096");
	}
}
public class PigSilver : BitmapData{ 
	public PigSilver() {
		width = 68;
		height = 60;
		setPixels("11046e6cb7bc5a529fbcac330d485dbf");
	}
}
namespace moneyBox.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("c4ef3b3d0624370a75da494dd8da014b", 0, 0, 185, 163, 1, 1);
		}
	}
	public class symbol_1 : MovieClip{ 
		public symbol_1() {
			var i37 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i37);//0
		}
	}
	public class symbol_10 : Shape{ 
		public symbol_10() {
			setGraphics("288d3686192777125fec5f26778f6fcd", 0, 0, 63, 89, 1, 1);
		}
	}
	public class symbol_11 : MovieClip{ 
		public symbol_11() {
			var i47 = new symbol_10(){filters = new as3.Array(new object[]{})};
			addChild(i47);//0
		}
	}
	public class symbol_12 : Shape{ 
		public symbol_12() {
			setGraphics("1ac7c153508d34d6e13de5030311b6c5", 0, 0, 58, 65, 1, 1);
		}
	}
	public class symbol_13 : MovieClip{ 
		public symbol_13() {
			var i49 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i49);//0
		}
	}
	public class symbol_14 : Shape{ 
		public symbol_14() {
			setGraphics("61460a248b331e1c2a46e33f56f773b6", 0, 0, 53, 40, 1, 1);
		}
	}
	public class symbol_15 : MovieClip{ 
		public symbol_15() {
			var i51 = new symbol_14(){filters = new as3.Array(new object[]{})};
			addChild(i51);//0
		}
	}
	public class symbol_16 : Shape{ 
		public symbol_16() {
			setGraphics("040190892575efb318c9c2cc85f00cad", 0, 0, 36, 26, 1, 1);
		}
	}
	public class symbol_17 : MovieClip{ 
		public symbol_17() {
			var i53 = new symbol_16(){filters = new as3.Array(new object[]{})};
			addChild(i53);//0
		}
	}
	public class symbol_18 : Shape{ 
		public symbol_18() {
			setGraphics("301f62708420720d68346e14e6a1eadb", 38.35, 0, 81.19999999999999, 114.55, 1, 1);
		}
	}
	public class symbol_19 : Shape{ 
		public symbol_19() {
			setGraphics("01092839c761246a410da52fc83eae7e", 0, 0, 39, 36, 1, 1);
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("e1334018e756ba9f76c956032013d878", -47.2, -47.9, 70.45, 105.25, 1, 1);
		}
	}
	public class symbol_20 : MovieClip{ 
		public symbol_20() {
			var i56 = new symbol_19(){filters = new as3.Array(new object[]{})};
			addChild(i56);//0
		}
	}
	public class symbol_21 : Shape{ 
		public symbol_21() {
			setGraphics("d9d8ae251a1ea668b0c675bcf7f772be", 0, 0, 55, 59, 1, 1);
		}
	}
	public class symbol_22 : MovieClip{ 
		public symbol_22() {
			var i58 = new symbol_21(){filters = new as3.Array(new object[]{})};
			addChild(i58);//0
		}
	}
	public class symbol_23 : Shape{ 
		public symbol_23() {
			setGraphics("07a63db5ae74483c3ef322aec7b5435d", 0, 0, 20, 11, 1, 1);
		}
	}
	public class symbol_24 : MovieClip{ 
		public symbol_24() {
			var i60 = new symbol_23(){filters = new as3.Array(new object[]{})};
			addChild(i60);//0
		}
	}
	public class symbol_25 : MovieClip{ 
		public symbol_25() {
			var i62 = new symbol_23(){filters = new as3.Array(new object[]{})};
			addChild(i62);//0
		}
	}
	public class symbol_26 : Shape{ 
		public symbol_26() {
			setGraphics("51beb69a795f53df44bc2a637911d9f1", 0, 0, 26, 42, 1, 1);
		}
	}
	public class symbol_27 : MovieClip{ 
		public symbol_27() {
			var i64 = new symbol_26(){filters = new as3.Array(new object[]{})};
			addChild(i64);//0
		}
	}
	public class symbol_28 : Shape{ 
		public symbol_28() {
			setGraphics("07a63db5ae74483c3ef322aec7b5435d", 0, 0, 20, 11, 1, 1);
		}
	}
	public class symbol_29 : MovieClip{ 
		public symbol_29() {
			var i66 = new symbol_28(){filters = new as3.Array(new object[]{})};
			addChild(i66);//0
		}
	}
	public class symbol_3 : MovieClip{ 
		public symbol_3() {
			var i39 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i39);//0
		}
	}
	public class symbol_30 : MovieClip{ 
		public symbol_30() {
			var i68 = new symbol_28(){filters = new as3.Array(new object[]{})};
			addChild(i68);//0
		}
	}
	public class symbol_31 : MovieClip{ 
		public symbol_31() {
			var i70 = new symbol_28(){filters = new as3.Array(new object[]{})};
			addChild(i70);//0
		}
	}
	public class symbol_32 : Shape{ 
		public symbol_32() {
			setGraphics("4fdf43b212985d4a8328ff632bbf054e", 0, 0, 185, 163, 1, 1);
		}
	}
	public class symbol_33 : MovieClip{ 
		public symbol_33() {
			var i73 = new symbol_32(){filters = new as3.Array(new object[]{})};
			addChild(i73);//0
		}
	}
	public class symbol_34 : Shape{ 
		public symbol_34() {
			setGraphics("e1334018e756ba9f76c956032013d878", -47.2, -47.9, 70.45, 105.25, 1, 1);
		}
	}
	public class symbol_35 : MovieClip{ 
		public symbol_35() {
			var i75 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i75);//0
		}
	}
	public class symbol_36 : Shape{ 
		public symbol_36() {
			setGraphics("387000a4b7b2bfa48981af03b5e5c30f", 70, 28.05, 80.19999999999999, 74.95, 1, 1);
		}
	}
	public class symbol_37 : Shape{ 
		public symbol_37() {
			setGraphics("181660296cf447a5db63ee5133200d00", 0, 0, 39, 36, 1, 1);
		}
	}
	public class symbol_38 : MovieClip{ 
		public symbol_38() {
			var i78 = new symbol_37(){filters = new as3.Array(new object[]{})};
			addChild(i78);//0
		}
	}
	public class symbol_39 : Shape{ 
		public symbol_39() {
			setGraphics("d9d8ae251a1ea668b0c675bcf7f772be", 0, 0, 55, 59, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("387000a4b7b2bfa48981af03b5e5c30f", 70, 28.05, 80.19999999999999, 74.95, 1, 1);
		}
	}
	public class symbol_40 : MovieClip{ 
		public symbol_40() {
			var i80 = new symbol_39(){filters = new as3.Array(new object[]{})};
			addChild(i80);//0
		}
	}
	public class symbol_41 : Shape{ 
		public symbol_41() {
			setGraphics("c7b6f338ba5188a0167a27b50ca7afb3", -1, 18, 186, 145, 1, 1);
		}
	}
	public class symbol_42 : Shape{ 
		public symbol_42() {
			setGraphics("288d3686192777125fec5f26778f6fcd", 0, 0, 63, 89, 1, 1);
		}
	}
	public class symbol_43 : MovieClip{ 
		public symbol_43() {
			var i83 = new symbol_42(){filters = new as3.Array(new object[]{})};
			addChild(i83);//0
		}
	}
	public class symbol_44 : Shape{ 
		public symbol_44() {
			setGraphics("851d3c56619bf456a16bb2a9690c2dc8", 0, 0, 58, 65, 1, 1);
		}
	}
	public class symbol_45 : MovieClip{ 
		public symbol_45() {
			var i85 = new symbol_44(){filters = new as3.Array(new object[]{})};
			addChild(i85);//0
		}
	}
	public class symbol_46 : Shape{ 
		public symbol_46() {
			setGraphics("61460a248b331e1c2a46e33f56f773b6", 0, 0, 53, 40, 1, 1);
		}
	}
	public class symbol_47 : MovieClip{ 
		public symbol_47() {
			var i87 = new symbol_46(){filters = new as3.Array(new object[]{})};
			addChild(i87);//0
		}
	}
	public class symbol_48 : Shape{ 
		public symbol_48() {
			setGraphics("040190892575efb318c9c2cc85f00cad", 0, 0, 36, 26, 1, 1);
		}
	}
	public class symbol_49 : MovieClip{ 
		public symbol_49() {
			var i89 = new symbol_48(){filters = new as3.Array(new object[]{})};
			addChild(i89);//0
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("01092839c761246a410da52fc83eae7e", 0, 0, 39, 36, 1, 1);
		}
	}
	public class symbol_50 : Shape{ 
		public symbol_50() {
			setGraphics("c835772130dd29f3f2ff041bbd0ff36c", 38.35, 0, 81.19999999999999, 114.55, 1, 1);
		}
	}
	public class symbol_51 : Shape{ 
		public symbol_51() {
			setGraphics("181660296cf447a5db63ee5133200d00", 0, 0, 39, 36, 1, 1);
		}
	}
	public class symbol_52 : MovieClip{ 
		public symbol_52() {
			var i92 = new symbol_51(){filters = new as3.Array(new object[]{})};
			addChild(i92);//0
		}
	}
	public class symbol_53 : MovieClip{ 
		public symbol_53() {
			var i94 = new symbol_39(){filters = new as3.Array(new object[]{})};
			addChild(i94);//0
		}
	}
	public class symbol_54 : Shape{ 
		public symbol_54() {
			setGraphics("07a63db5ae74483c3ef322aec7b5435d", 0, 0, 20, 11, 1, 1);
		}
	}
	public class symbol_55 : MovieClip{ 
		public symbol_55() {
			var i96 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i96);//0
		}
	}
	public class symbol_56 : MovieClip{ 
		public symbol_56() {
			var i98 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i98);//0
		}
	}
	public class symbol_57 : Shape{ 
		public symbol_57() {
			setGraphics("51beb69a795f53df44bc2a637911d9f1", 0, 0, 26, 42, 1, 1);
		}
	}
	public class symbol_58 : MovieClip{ 
		public symbol_58() {
			var i100 = new symbol_57(){filters = new as3.Array(new object[]{})};
			addChild(i100);//0
		}
	}
	public class symbol_59 : MovieClip{ 
		public symbol_59() {
			var i102 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i102);//0
		}
	}
	public class symbol_6 : MovieClip{ 
		public symbol_6() {
			var i42 = new symbol_5(){filters = new as3.Array(new object[]{})};
			addChild(i42);//0
		}
	}
	public class symbol_60 : MovieClip{ 
		public symbol_60() {
			var i104 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i104);//0
		}
	}
	public class symbol_61 : MovieClip{ 
		public symbol_61() {
			var i106 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i106);//0
		}
	}
	public class symbol_62 : Shape{ 
		public symbol_62() {
			setGraphics("c4ef3b3d0624370a75da494dd8da014b", 0, 0, 185, 163, 1, 1);
		}
	}
	public class symbol_63 : MovieClip{ 
		public symbol_63() {
			var i109 = new symbol_62(){filters = new as3.Array(new object[]{})};
			addChild(i109);//0
		}
	}
	public class symbol_64 : MovieClip{ 
		public symbol_64() {
			var i111 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i111);//0
		}
	}
	public class symbol_65 : Shape{ 
		public symbol_65() {
			setGraphics("181660296cf447a5db63ee5133200d00", 0, 0, 39, 36, 1, 1);
		}
	}
	public class symbol_66 : MovieClip{ 
		public symbol_66() {
			var i114 = new symbol_65(){filters = new as3.Array(new object[]{})};
			addChild(i114);//0
		}
	}
	public class symbol_67 : MovieClip{ 
		public symbol_67() {
			var i116 = new symbol_39(){filters = new as3.Array(new object[]{})};
			addChild(i116);//0
		}
	}
	public class symbol_68 : Shape{ 
		public symbol_68() {
			setGraphics("4a539148f5ce3531ad8140c0c4573d1c", 0, 0, 63, 89, 1, 1);
		}
	}
	public class symbol_69 : MovieClip{ 
		public symbol_69() {
			var i119 = new symbol_68(){filters = new as3.Array(new object[]{})};
			addChild(i119);//0
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("d9d8ae251a1ea668b0c675bcf7f772be", 0, 0, 55, 59, 1, 1);
		}
	}
	public class symbol_70 : Shape{ 
		public symbol_70() {
			setGraphics("1ac7c153508d34d6e13de5030311b6c5", 0, 0, 58, 65, 1, 1);
		}
	}
	public class symbol_71 : MovieClip{ 
		public symbol_71() {
			var i121 = new symbol_70(){filters = new as3.Array(new object[]{})};
			addChild(i121);//0
		}
	}
	public class symbol_72 : MovieClip{ 
		public symbol_72() {
			var i123 = new symbol_46(){filters = new as3.Array(new object[]{})};
			addChild(i123);//0
		}
	}
	public class symbol_73 : MovieClip{ 
		public symbol_73() {
			var i125 = new symbol_48(){filters = new as3.Array(new object[]{})};
			addChild(i125);//0
		}
	}
	public class symbol_74 : Shape{ 
		public symbol_74() {
			setGraphics("c835772130dd29f3f2ff041bbd0ff36c", 38.35, 0, 81.19999999999999, 114.55, 1, 1);
		}
	}
	public class symbol_75 : MovieClip{ 
		public symbol_75() {
			var i128 = new symbol_65(){filters = new as3.Array(new object[]{})};
			addChild(i128);//0
		}
	}
	public class symbol_76 : MovieClip{ 
		public symbol_76() {
			var i130 = new symbol_39(){filters = new as3.Array(new object[]{})};
			addChild(i130);//0
		}
	}
	public class symbol_77 : MovieClip{ 
		public symbol_77() {
			var i132 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i132);//0
		}
	}
	public class symbol_78 : MovieClip{ 
		public symbol_78() {
			var i134 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i134);//0
		}
	}
	public class symbol_79 : MovieClip{ 
		public symbol_79() {
			var i136 = new symbol_57(){filters = new as3.Array(new object[]{})};
			addChild(i136);//0
		}
	}
	public class symbol_8 : MovieClip{ 
		public symbol_8() {
			var i44 = new symbol_7(){filters = new as3.Array(new object[]{})};
			addChild(i44);//0
		}
	}
	public class symbol_80 : MovieClip{ 
		public symbol_80() {
			var i138 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i138);//0
		}
	}
	public class symbol_81 : MovieClip{ 
		public symbol_81() {
			var i140 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i140);//0
		}
	}
	public class symbol_82 : MovieClip{ 
		public symbol_82() {
			var i142 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i142);//0
		}
	}
	public class symbol_83 : Shape{ 
		public symbol_83() {
			setGraphics("ffefaf5f341f10cfd8140a6cf5ba1d06", -186.05, -182.7, 372.1, 365.45, 1, 1);
		}
	}
	public class symbol_84 : Shape{ 
		public symbol_84() {
			setGraphics("8711cfb1cced39739118560f51ec9249", 6.55, 0, 212.5, 198.1, 1, 1);
		}
	}
	public class symbol_85 : MovieClip{ 
		public symbol_85() {
			var i146 = new symbol_84(){filters = new as3.Array(new object[]{})};
			addChild(i146);//0
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("c7b6f338ba5188a0167a27b50ca7afb3", -1, 18, 186, 145, 1, 1);
		}
	}
}
