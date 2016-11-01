using System;
using flash.display;
using System.Collections.Generic;
using houseResources.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class LibhouseResources : ResourcesExternalLib{
	public LibhouseResources() {
	vectors = new string[] {
	"2815c9a6d62db1d94a089ee307a00f7b",
	"4ec0fe34ed0c0bddf3fb61ee15f2f45e",
	"0bef28c0e73809f40129043030dc2bf9",
	"8316e064019e745027b2eab8e463286a",
	"b8222d669abeca9ec3d5ee1a9ee252ea",
	"ef34b78fffc8c8e2901eb58c57999235",
	"acc521d07063ebe7a9e8ca8d9f0bd269",
	"b2d0bc136f6ba296ff0b04aaa3ba3e6c",
	"e9b397b50c1f2df1a0496de7ff6a31a5",
	"7e1cd120027a3eec514ca2623e899b64",
	"5aa83f9a23d551592bbaf61c30635337",
	"92a04ae4592defe4e4e4282af652be0c",
	"3dfbab60da13d50cb2fd482bc73844dc",
	"d98d7cc7099b407e47262b88d16009da",
	"a4c1125c2db687d3db045c3dd0f975ed",
	"2ab5f2e5498d75e1ebc6c313aa352fe5",
	"32e8476001737ee82b0f4530d2cd0b73",
	"81fb4d36487b827f5089ff464ee2ac59",
	"ce3b4821edd3f226308c39365912b0a1",
	"db2dde59b9b32308122952490bbf16f3",
	"b52372e87118032d6006ac5895955dbd",
	"a30a56dab37a3a779287a9fead0ea92e",
	"0d7d9661b0d2db44067db1a5961dc26b",
	"14335bccfd70fbec697ef27f97760ff2",
	"bae6544660cbd354e373fa5576da562b",
	"e5836a166c6f7155d8697b9cf876bccf",
	"f3766338856a69587253de5d18a52b71",
	"60d71e47f4ef4d7abc6dcd02404feee1"
	};
	graphics = new string[] {
	"undefined",
	"0ae44fe8ed1c149682e30218c70acc2b",
	"82c82482988a6d1a7a077ab56d73bac3",
	"adec2f44037bbc47b9093311029b0dec",
	"8f9a3fd65976c3b192e48d274c355fe4",
	"9a6c51b788d4cf10a7ebe8f245c55afb",
	"ce5b14a28b2499d791b56f549f320b45",
	"27e56fbec0966d9a5b32e1a6e853d9ab",
	"123bafd0a62812e331f4bc8f94c5a048",
	"d410448ec227f0832a3acb56b82b0b91",
	"9b7ff7de7c860062e36b84ebca8cd48c",
	"26a80bbb8d0169407bd9bffac55468b5",
	"88d9556fda9dad41a2af6821305f2233"
	};
	}
}
public class GiftPercentImg : BitmapData{ 
	public GiftPercentImg() {
		width = 48;
		height = 48;
		setPixels("bc4d52e73952725071a963f0247b439d");
	}
}
public class HintTreeGrowIcon : BitmapData{ 
	public HintTreeGrowIcon() {
		width = 55;
		height = 53;
		setPixels("27e56fbec0966d9a5b32e1a6e853d9ab");
	}
}
public class HouseIconAttic : BitmapData{ 
	public HouseIconAttic() {
		width = 23;
		height = 15;
		setPixels("0ae44fe8ed1c149682e30218c70acc2b");
	}
}
public class HouseIconNew : BitmapData{ 
	public HouseIconNew() {
		width = 20;
		height = 20;
		setPixels("d410448ec227f0832a3acb56b82b0b91");
	}
}
public class HouseIconNewYear : BitmapData{ 
	public HouseIconNewYear() {
		width = 20;
		height = 20;
		setPixels("9b7ff7de7c860062e36b84ebca8cd48c");
	}
}
public class HouseIconPack : BitmapData{ 
	public HouseIconPack() {
		width = 18;
		height = 18;
		setPixels("123bafd0a62812e331f4bc8f94c5a048");
	}
}
public class HouseIconSale : BitmapData{ 
	public HouseIconSale() {
		width = 20;
		height = 20;
		setPixels("88d9556fda9dad41a2af6821305f2233");
	}
}
public class HouseOwnerImg : BitmapData{ 
	public HouseOwnerImg() {
		width = 108;
		height = 22;
		setPixels("82c82482988a6d1a7a077ab56d73bac3");
	}
}
public class HouseOwners : BitmapData{ 
	public HouseOwners() {
		width = 100;
		height = 22;
		setPixels("adec2f44037bbc47b9093311029b0dec");
	}
}
public class IconGuestLocked : BitmapData{ 
	public IconGuestLocked() {
		width = 16;
		height = 20;
		setPixels("8f9a3fd65976c3b192e48d274c355fe4");
	}
}
public class IconGuestUnlocked : BitmapData{ 
	public IconGuestUnlocked() {
		width = 16;
		height = 20;
		setPixels("9a6c51b788d4cf10a7ebe8f245c55afb");
	}
}
public class RedCrossImg : BitmapData{ 
	public RedCrossImg() {
		width = 14;
		height = 14;
		setPixels("26a80bbb8d0169407bd9bffac55468b5");
	}
}
public class SearchFriendIconImg : BitmapData{ 
	public SearchFriendIconImg() {
		width = 20;
		height = 20;
		setPixels("ce5b14a28b2499d791b56f549f320b45");
	}
}
public class TreeLevelUpMovie : MovieClip{ 
	public TreeLevelUpMovie() {
		var filter_0 = new DropShadowFilter(){distance = -1, angle = 90.00, blurX = 3, blurY = 3};
		var i20 = new symbol_2(){x = 8.3 , scaleX = 0.12 , y = 112 , scaleY = 0.12 , alpha = 0 , filters = new as3.Array(new object[]{})};
		addChild(i20);//0
		var i58 = new symbol_31(){x = -17.8 , scaleX = 0.23 , y = 56.3 , scaleY = 0.23 , filters = new as3.Array(new object[]{})};
		addChild(i58);//1
		var i23 = new symbol_4(){x = -16.2 , scaleX = 0.13 , y = 8.2 , scaleY = 0.13 , filters = new as3.Array(new object[]{})};
		addChild(i23);//1
		var i25 = new symbol_7(){x = 7.4 , scaleX = 0.19 , y = 93.7 , scaleY = 0.19 , filters = new as3.Array(new object[]{})};
		addChild(i25);//2
		var i66 = new symbol_37(){x = 6.3 , scaleX = 0.17 , y = 44 , scaleY = 0.17 , filters = new as3.Array(new object[]{})};
		addChild(i66);//2
		var i40 = new symbol_18(){filters = new as3.Array(new object[]{})};
		addChild(i40);//3
		var i37 = new symbol_16(){filters = new as3.Array(new object[]{})};
		addChild(i37);//3
		var i31 = new symbol_11(){filters = new as3.Array(new object[]{})};
		addChild(i31);//3
		var i28 = new symbol_8(){filters = new as3.Array(new object[]{})};
		addChild(i28);//3
		var i43 = new symbol_20(){filters = new as3.Array(new object[]{})};
		addChild(i43);//3
		var i55 = new symbol_28(){filters = new as3.Array(new object[]{})};
		addChild(i55);//3
		var i80 = new symbol_47(){x = -16.4 , scaleX = 0.26 , y = 11.3 , scaleY = 0.26 , rotation = 2 , filters = new as3.Array(new object[]{})};
		addChild(i80);//3
		var i49 = new symbol_24(){filters = new as3.Array(new object[]{})};
		addChild(i49);//3
		var i46 = new symbol_22(){filters = new as3.Array(new object[]{})};
		addChild(i46);//3
		var i52 = new symbol_26(){filters = new as3.Array(new object[]{})};
		addChild(i52);//3
		var i34 = new symbol_14(){filters = new as3.Array(new object[]{})};
		addChild(i34);//3
		var i32 = new symbol_13(){x = 7.3 , y = 42 , mask = i31 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i32);//4
		var i41 = new symbol_19(){x = 7.3 , y = 42 , mask = i40 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i41);//4
		var i47 = new symbol_23(){x = 7.3 , y = 42 , mask = i46 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i47);//4
		var i63 = new symbol_34(){filters = new as3.Array(new object[]{})};
		addChild(i63);//4
		var i29 = new symbol_10(){x = 7.3 , y = 42 , mask = i28 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i29);//4
		var i38 = new symbol_17(){x = 7.3 , y = 42 , mask = i37 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i38);//4
		var i53 = new symbol_27(){x = 7.3 , y = 42 , mask = i52 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i53);//4
		var i35 = new symbol_15(){x = 7.3 , y = 42 , mask = i34 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i35);//4
		var i56 = new symbol_29(){x = 7.3 , y = 42 , mask = i55 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i56);//4
		var i44 = new symbol_21(){x = 7.3 , y = 42 , mask = i43 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i44);//4
		var i50 = new symbol_25(){x = 7.3 , y = 42 , mask = i49 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i50);//4
		var i60 = new symbol_32(){filters = new as3.Array(new object[]{})};
		addChild(i60);//4
		var i71 = new symbol_40(){filters = new as3.Array(new object[]{})};
		addChild(i71);//5
		var i77 = new symbol_44(){filters = new as3.Array(new object[]{})};
		addChild(i77);//5
		var i68 = new symbol_38(){filters = new as3.Array(new object[]{})};
		addChild(i68);//5
		var i64 = new symbol_35(){x = 7.3 , y = 42 , mask = i63 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i64);//5
		var i61 = new symbol_33(){x = 7.3 , y = 42 , mask = i60 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i61);//5
		var i88 = new symbol_53(){x = 27.4 , scaleX = 0.08 , y = -4.8 , scaleY = 0.08 , filters = new as3.Array(new object[]{})};
		addChild(i88);//5
		var i74 = new symbol_42(){filters = new as3.Array(new object[]{})};
		addChild(i74);//5
		var i75 = new symbol_43(){x = 7.3 , y = 42 , mask = i74 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i75);//6
		var i69 = new symbol_39(){x = 7.3 , y = 42 , mask = i68 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i69);//6
		var i82 = new symbol_48(){filters = new as3.Array(new object[]{})};
		addChild(i82);//6
		var i78 = new symbol_45(){x = 7.3 , y = 42 , mask = i77 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i78);//6
		var i72 = new symbol_41(){x = 7.3 , y = 42 , mask = i71 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i72);//6
		var i90 = new symbol_55(){x = 34.2 , scaleX = 0.32 , y = -3.9 , scaleY = 0.32 , rotation = -14 , filters = new as3.Array(new object[]{})};
		addChild(i90);//6
		var i85 = new symbol_50(){filters = new as3.Array(new object[]{})};
		addChild(i85);//6
		var i86 = new symbol_51(){x = 7.3 , y = 42 , mask = i85 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i86);//7
		var i83 = new symbol_49(){x = 7.3 , y = 42 , mask = i82 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i83);//7
		var i95 = new symbol_59(){x = 6.9 , scaleX = 0.23 , y = 91.6 , scaleY = 0.23 , rotation = -74 , filters = new as3.Array(new object[]{})};
		addChild(i95);//8
		var i92 = new symbol_56(){x = 10.4 , y = 42.6 , filters = new as3.Array(new object[]{})};
		addChild(i92);//8
		var i93 = new symbol_57(){x = 7.3 , y = 42 , mask = i92 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i93);//9
		var i97 = new symbol_60(){x = 10.4 , y = 42.6 , filters = new as3.Array(new object[]{})};
		addChild(i97);//9
		var i100 = new symbol_60(){x = 10.4 , alpha = 0 , y = 42.6 , filters = new as3.Array(new object[]{})};
		addChild(i100);//9
		var i98 = new symbol_61(){x = 7.3 , y = 42 , mask = i97 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i98);//10
		var i101 = new symbol_62(){x = 7.3 , alpha = 0 , y = 42 , mask = i100 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i101);//10
		FrameInfo f;
		var l= new Frames(134);
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.x = 8.3;
			i20.scaleX = 0.12;
			i20.y = 112;
			i20.scaleY = 0.12;
			i20.rotation = 0;
			i20.alpha = 0;
			i20.filters = new as3.Array(new object[]{});
			i20.scale9Grid = null;
			i20.visible = true;
			i23.x = -16.2;
			i23.scaleX = 0.13;
			i23.y = 8.2;
			i23.scaleY = 0.13;
			i23.rotation = 0;
			i23.alpha = 1;
			i23.filters = new as3.Array(new object[]{});
			i23.scale9Grid = null;
			i23.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 0.31;
			i20.y = 110.1;
			i20.scaleY = 0.31;
			i20.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 0.49;
			i20.y = 108;
			i20.scaleY = 0.49;
			i20.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 0.68;
			i20.y = 106.1;
			i20.scaleY = 0.68;
			i20.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 0.86;
			i20.y = 104;
			i20.scaleY = 0.86;
			i20.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.04;
			i20.y = 102;
			i20.scaleY = 1.04;
			i20.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.23;
			i20.y = 100;
			i20.scaleY = 1.23;
			i20.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.41;
			i20.y = 98;
			i20.scaleY = 1.41;
			i20.alpha = 1;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.36;
			i20.y = 98.6;
			i20.scaleY = 1.36;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.31;
			i20.y = 99.2;
			i20.scaleY = 1.31;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.25;
			i20.y = 99.7;
			i20.scaleY = 1.25;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.2;
			i20.y = 100.3;
			i20.scaleY = 1.2;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.15;
			i20.y = 101;
			i20.scaleY = 1.15;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.09;
			i20.y = 101.5;
			i20.scaleY = 1.09;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.04;
			i20.y = 102.1;
			i20.scaleY = 1.04;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.05;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.y = 102.2;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.y = 102.3;
			i20.scaleY = 1.03;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleY = 1.02;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.x = 8.2;
			i20.y = 102.4;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.y = 102.5;
			i20.scaleY = 1.01;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.06;
			i20.y = 102.6;
			i20.scaleY = 1;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.y = 102.7;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.x = 8.3;
			i20.scaleX = 1.07;
			i20.y = 102.8;
			i20.scaleY = 0.99;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f += () => {
			i20.scaleX = 1.08;
			i20.scaleY = 0.98;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f += () => {
			i20.scaleX = 1.09;
			i25.x = 7.4;
			i25.scaleX = 0.19;
			i25.y = 93.7;
			i25.scaleY = 0.19;
			i25.rotation = 0;
			i25.alpha = 1;
			i25.filters = new as3.Array(new object[]{});
			i25.scale9Grid = null;
			i25.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f += () => {
			i20.y = 102.3;
			i20.scaleY = 1.02;
			i25.scaleX = 0.39;
			i25.y = 92.3;
			i25.scaleY = 0.39;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f += () => {
			i20.y = 102;
			i20.scaleY = 1.06;
			i25.scaleX = 0.58;
			i25.y = 91.1;
			i25.scaleY = 0.58;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i28);
		f.Add(i29);
		f += () => {
			i20.scaleX = 1.1;
			i20.y = 101.5;
			i20.scaleY = 1.1;
			i25.scaleX = 0.78;
			i25.y = 89.8;
			i25.scaleY = 0.78;
			i28.x = 0;
			i28.scaleX = 1;
			i28.y = 0;
			i28.scaleY = 1;
			i28.rotation = 0;
			i28.alpha = 1;
			i28.filters = new as3.Array(new object[]{});
			i28.scale9Grid = null;
			i28.visible = true;
			i29.x = 7.3;
			i29.scaleX = 1;
			i29.y = 42;
			i29.scaleY = 1;
			i29.rotation = 0;
			i29.alpha = 1;
			i29.filters = new as3.Array(new object[]{filter_0});
			i29.scale9Grid = null;
			i29.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i31);
		f.Add(i32);
		f += () => {
			i25.x = 7.5;
			i25.scaleX = 0.81;
			i25.scaleY = 0.81;
			i31.x = 0;
			i31.scaleX = 1;
			i31.y = 0;
			i31.scaleY = 1;
			i31.rotation = 0;
			i31.alpha = 1;
			i31.filters = new as3.Array(new object[]{});
			i31.scale9Grid = null;
			i31.visible = true;
			i32.x = 7.3;
			i32.scaleX = 1;
			i32.y = 42;
			i32.scaleY = 1;
			i32.rotation = 0;
			i32.alpha = 1;
			i32.filters = new as3.Array(new object[]{filter_0});
			i32.scale9Grid = null;
			i32.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i34);
		f.Add(i35);
		f += () => {
			i25.x = 7.4;
			i25.scaleX = 0.83;
			i25.scaleY = 0.83;
			i34.x = 0;
			i34.scaleX = 1;
			i34.y = 0;
			i34.scaleY = 1;
			i34.rotation = 0;
			i34.alpha = 1;
			i34.filters = new as3.Array(new object[]{});
			i34.scale9Grid = null;
			i34.visible = true;
			i35.x = 7.3;
			i35.scaleX = 1;
			i35.y = 42;
			i35.scaleY = 1;
			i35.rotation = 0;
			i35.alpha = 1;
			i35.filters = new as3.Array(new object[]{filter_0});
			i35.scale9Grid = null;
			i35.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i37);
		f.Add(i38);
		f += () => {
			i25.x = 7.5;
			i25.scaleX = 0.85;
			i25.scaleY = 0.85;
			i37.x = 0;
			i37.scaleX = 1;
			i37.y = 0;
			i37.scaleY = 1;
			i37.rotation = 0;
			i37.alpha = 1;
			i37.filters = new as3.Array(new object[]{});
			i37.scale9Grid = null;
			i37.visible = true;
			i38.x = 7.3;
			i38.scaleX = 1;
			i38.y = 42;
			i38.scaleY = 1;
			i38.rotation = 0;
			i38.alpha = 1;
			i38.filters = new as3.Array(new object[]{filter_0});
			i38.scale9Grid = null;
			i38.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i40);
		f.Add(i41);
		f += () => {
			i25.x = 7.4;
			i25.scaleX = 0.88;
			i25.scaleY = 0.88;
			i40.x = 0;
			i40.scaleX = 1;
			i40.y = 0;
			i40.scaleY = 1;
			i40.rotation = 0;
			i40.alpha = 1;
			i40.filters = new as3.Array(new object[]{});
			i40.scale9Grid = null;
			i40.visible = true;
			i41.x = 7.3;
			i41.scaleX = 1;
			i41.y = 42;
			i41.scaleY = 1;
			i41.rotation = 0;
			i41.alpha = 1;
			i41.filters = new as3.Array(new object[]{filter_0});
			i41.scale9Grid = null;
			i41.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i43);
		f.Add(i44);
		f += () => {
			i25.scaleX = 0.9;
			i25.scaleY = 0.9;
			i43.x = 0;
			i43.scaleX = 1;
			i43.y = 0;
			i43.scaleY = 1;
			i43.rotation = 0;
			i43.alpha = 1;
			i43.filters = new as3.Array(new object[]{});
			i43.scale9Grid = null;
			i43.visible = true;
			i44.x = 7.3;
			i44.scaleX = 1;
			i44.y = 42;
			i44.scaleY = 1;
			i44.rotation = 0;
			i44.alpha = 1;
			i44.filters = new as3.Array(new object[]{filter_0});
			i44.scale9Grid = null;
			i44.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i46);
		f.Add(i47);
		f += () => {
			i25.scaleX = 0.93;
			i25.scaleY = 0.93;
			i46.x = 0;
			i46.scaleX = 1;
			i46.y = 0;
			i46.scaleY = 1;
			i46.rotation = 0;
			i46.alpha = 1;
			i46.filters = new as3.Array(new object[]{});
			i46.scale9Grid = null;
			i46.visible = true;
			i47.x = 7.3;
			i47.scaleX = 1;
			i47.y = 42;
			i47.scaleY = 1;
			i47.rotation = 0;
			i47.alpha = 1;
			i47.filters = new as3.Array(new object[]{filter_0});
			i47.scale9Grid = null;
			i47.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i49);
		f.Add(i50);
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
			i50.x = 7.3;
			i50.scaleX = 1;
			i50.y = 42;
			i50.scaleY = 1;
			i50.rotation = 0;
			i50.alpha = 1;
			i50.filters = new as3.Array(new object[]{filter_0});
			i50.scale9Grid = null;
			i50.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i52);
		f.Add(i53);
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
			i53.x = 7.3;
			i53.scaleX = 1;
			i53.y = 42;
			i53.scaleY = 1;
			i53.rotation = 0;
			i53.alpha = 1;
			i53.filters = new as3.Array(new object[]{filter_0});
			i53.scale9Grid = null;
			i53.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i23);
		f.Add(i25);
		f.Add(i55);
		f.Add(i56);
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
			i56.x = 7.3;
			i56.scaleX = 1;
			i56.y = 42;
			i56.scaleY = 1;
			i56.rotation = 0;
			i56.alpha = 1;
			i56.filters = new as3.Array(new object[]{filter_0});
			i56.scale9Grid = null;
			i56.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i60);
		f.Add(i61);
		f += () => {
			i58.x = -17.8;
			i58.scaleX = 0.23;
			i58.y = 56.3;
			i58.scaleY = 0.23;
			i58.rotation = 0;
			i58.alpha = 1;
			i58.filters = new as3.Array(new object[]{});
			i58.scale9Grid = null;
			i58.visible = true;
			i60.x = 0;
			i60.scaleX = 1;
			i60.y = 0;
			i60.scaleY = 1;
			i60.rotation = 0;
			i60.alpha = 1;
			i60.filters = new as3.Array(new object[]{});
			i60.scale9Grid = null;
			i60.visible = true;
			i61.x = 7.3;
			i61.scaleX = 1;
			i61.y = 42;
			i61.scaleY = 1;
			i61.rotation = 0;
			i61.alpha = 1;
			i61.filters = new as3.Array(new object[]{filter_0});
			i61.scale9Grid = null;
			i61.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i63);
		f.Add(i64);
		f += () => {
			i58.x = -18.1;
			i58.scaleX = 0.36;
			i58.y = 56;
			i58.scaleY = 0.36;
			i63.x = 0;
			i63.scaleX = 1;
			i63.y = 0;
			i63.scaleY = 1;
			i63.rotation = 0;
			i63.alpha = 1;
			i63.filters = new as3.Array(new object[]{});
			i63.scale9Grid = null;
			i63.visible = true;
			i64.x = 7.3;
			i64.scaleX = 1;
			i64.y = 42;
			i64.scaleY = 1;
			i64.rotation = 0;
			i64.alpha = 1;
			i64.filters = new as3.Array(new object[]{filter_0});
			i64.scale9Grid = null;
			i64.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i68);
		f.Add(i69);
		f += () => {
			i58.x = -18.4;
			i58.scaleX = 0.49;
			i58.y = 55.7;
			i58.scaleY = 0.49;
			i66.x = 6.3;
			i66.scaleX = 0.17;
			i66.y = 44;
			i66.scaleY = 0.17;
			i66.rotation = 0;
			i66.alpha = 1;
			i66.filters = new as3.Array(new object[]{});
			i66.scale9Grid = null;
			i66.visible = true;
			i68.x = 0;
			i68.scaleX = 1;
			i68.y = 0;
			i68.scaleY = 1;
			i68.rotation = 0;
			i68.alpha = 1;
			i68.filters = new as3.Array(new object[]{});
			i68.scale9Grid = null;
			i68.visible = true;
			i69.x = 7.3;
			i69.scaleX = 1;
			i69.y = 42;
			i69.scaleY = 1;
			i69.rotation = 0;
			i69.alpha = 1;
			i69.filters = new as3.Array(new object[]{filter_0});
			i69.scale9Grid = null;
			i69.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i71);
		f.Add(i72);
		f += () => {
			i58.x = -18.8;
			i58.scaleX = 0.62;
			i58.y = 55.4;
			i58.scaleY = 0.62;
			i66.x = 6.7;
			i66.scaleX = 0.25;
			i66.y = 43.8;
			i66.scaleY = 0.25;
			i71.x = 0;
			i71.scaleX = 1;
			i71.y = 0;
			i71.scaleY = 1;
			i71.rotation = 0;
			i71.alpha = 1;
			i71.filters = new as3.Array(new object[]{});
			i71.scale9Grid = null;
			i71.visible = true;
			i72.x = 7.3;
			i72.scaleX = 1;
			i72.y = 42;
			i72.scaleY = 1;
			i72.rotation = 0;
			i72.alpha = 1;
			i72.filters = new as3.Array(new object[]{filter_0});
			i72.scale9Grid = null;
			i72.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i74);
		f.Add(i75);
		f += () => {
			i58.x = -19;
			i58.scaleX = 0.74;
			i58.y = 55.1;
			i58.scaleY = 0.74;
			i66.x = 7;
			i66.scaleX = 0.33;
			i66.y = 43.5;
			i66.scaleY = 0.33;
			i74.x = 0;
			i74.scaleX = 1;
			i74.y = 0;
			i74.scaleY = 1;
			i74.rotation = 0;
			i74.alpha = 1;
			i74.filters = new as3.Array(new object[]{});
			i74.scale9Grid = null;
			i74.visible = true;
			i75.x = 7.3;
			i75.scaleX = 1;
			i75.y = 42;
			i75.scaleY = 1;
			i75.rotation = 0;
			i75.alpha = 1;
			i75.filters = new as3.Array(new object[]{filter_0});
			i75.scale9Grid = null;
			i75.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i77);
		f.Add(i78);
		f += () => {
			i58.x = -19.4;
			i58.scaleX = 0.87;
			i58.y = 54.8;
			i58.scaleY = 0.87;
			i66.x = 7.3;
			i66.scaleX = 0.41;
			i66.y = 43.2;
			i66.scaleY = 0.41;
			i77.x = 0;
			i77.scaleX = 1;
			i77.y = 0;
			i77.scaleY = 1;
			i77.rotation = 0;
			i77.alpha = 1;
			i77.filters = new as3.Array(new object[]{});
			i77.scale9Grid = null;
			i77.visible = true;
			i78.x = 7.3;
			i78.scaleX = 1;
			i78.y = 42;
			i78.scaleY = 1;
			i78.rotation = 0;
			i78.alpha = 1;
			i78.filters = new as3.Array(new object[]{filter_0});
			i78.scale9Grid = null;
			i78.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i82);
		f.Add(i83);
		f += () => {
			i58.x = -19.7;
			i58.scaleX = 1;
			i58.y = 54.5;
			i58.scaleY = 1;
			i23.x = -15.9;
			i66.x = 7.8;
			i66.scaleX = 0.49;
			i66.y = 42.9;
			i66.scaleY = 0.49;
			i80.x = -16.4;
			i80.scaleX = 0.26;
			i80.y = 11.3;
			i80.scaleY = 0.26;
			i80.rotation = 2;
			i80.alpha = 1;
			i80.filters = new as3.Array(new object[]{});
			i80.scale9Grid = null;
			i80.visible = true;
			i82.x = 0;
			i82.scaleX = 1;
			i82.y = 0;
			i82.scaleY = 1;
			i82.rotation = 0;
			i82.alpha = 1;
			i82.filters = new as3.Array(new object[]{});
			i82.scale9Grid = null;
			i82.visible = true;
			i83.x = 7.3;
			i83.scaleX = 1;
			i83.y = 42;
			i83.scaleY = 1;
			i83.rotation = 0;
			i83.alpha = 1;
			i83.filters = new as3.Array(new object[]{filter_0});
			i83.scale9Grid = null;
			i83.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i85);
		f.Add(i86);
		f += () => {
			i58.x = -20;
			i58.scaleX = 1.13;
			i58.y = 54.3;
			i58.scaleY = 1.13;
			i23.x = -16.5;
			i23.scaleX = 0.3;
			i23.y = 7.5;
			i23.scaleY = 0.3;
			i66.x = 8.2;
			i66.scaleX = 0.57;
			i66.y = 42.7;
			i66.scaleY = 0.57;
			i80.x = -17.1;
			i80.scaleX = 0.35;
			i80.y = 11.7;
			i80.scaleY = 0.35;
			i85.x = 0;
			i85.scaleX = 1;
			i85.y = 0;
			i85.scaleY = 1;
			i85.rotation = 0;
			i85.alpha = 1;
			i85.filters = new as3.Array(new object[]{});
			i85.scale9Grid = null;
			i85.visible = true;
			i86.x = 7.3;
			i86.scaleX = 1;
			i86.y = 42;
			i86.scaleY = 1;
			i86.rotation = 0;
			i86.alpha = 1;
			i86.filters = new as3.Array(new object[]{filter_0});
			i86.scale9Grid = null;
			i86.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.scaleX = 1.26;
			i58.scaleY = 1.26;
			i23.x = -17;
			i23.scaleX = 0.47;
			i23.y = 6.7;
			i23.scaleY = 0.47;
			i66.x = 8.5;
			i66.scaleX = 0.65;
			i66.y = 42.4;
			i66.scaleY = 0.65;
			i80.x = -17.7;
			i80.scaleX = 0.45;
			i80.y = 12;
			i80.scaleY = 0.45;
			i88.x = 27.4;
			i88.scaleX = 0.08;
			i88.y = -4.8;
			i88.scaleY = 0.08;
			i88.rotation = 0;
			i88.alpha = 1;
			i88.filters = new as3.Array(new object[]{});
			i88.scale9Grid = null;
			i88.visible = true;
			i90.x = 34.2;
			i90.scaleX = 0.32;
			i90.y = -3.9;
			i90.scaleY = 0.32;
			i90.rotation = -14;
			i90.alpha = 1;
			i90.filters = new as3.Array(new object[]{});
			i90.scale9Grid = null;
			i90.visible = true;
			i92.x = 10.4;
			i92.scaleX = 1;
			i92.y = 42.6;
			i92.scaleY = 1;
			i92.rotation = 0;
			i92.alpha = 1;
			i92.filters = new as3.Array(new object[]{});
			i92.scale9Grid = null;
			i92.visible = true;
			i93.x = 7.3;
			i93.scaleX = 1;
			i93.y = 42;
			i93.scaleY = 1;
			i93.rotation = 0;
			i93.alpha = 1;
			i93.filters = new as3.Array(new object[]{filter_0});
			i93.scale9Grid = null;
			i93.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -20.4;
			i58.scaleX = 1.41;
			i58.y = 54;
			i58.scaleY = 1.41;
			i23.x = -17.5;
			i23.scaleX = 0.64;
			i23.y = 6;
			i23.scaleY = 0.64;
			i23.rotation = 1;
			i66.x = 8.8;
			i66.scaleX = 0.73;
			i66.y = 42.1;
			i66.scaleY = 0.73;
			i80.x = -18.4;
			i80.scaleX = 0.54;
			i80.y = 12.4;
			i80.scaleY = 0.54;
			i80.rotation = 3;
			i88.x = 27;
			i88.scaleX = 0.26;
			i88.y = -5.5;
			i88.scaleY = 0.26;
			i90.x = 34.7;
			i90.scaleX = 0.39;
			i90.scaleY = 0.39;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -20.6;
			i58.scaleX = 1.56;
			i58.y = 53.6;
			i58.scaleY = 1.56;
			i23.x = -18.1;
			i23.scaleX = 0.81;
			i23.y = 5.2;
			i23.scaleY = 0.81;
			i66.x = 9.2;
			i66.scaleX = 0.81;
			i66.y = 41.9;
			i66.scaleY = 0.81;
			i80.x = -19.1;
			i80.scaleX = 0.64;
			i80.y = 12.7;
			i80.scaleY = 0.64;
			i88.x = 26.6;
			i88.scaleX = 0.44;
			i88.y = -6.2;
			i88.scaleY = 0.44;
			i90.x = 35.1;
			i90.scaleX = 0.47;
			i90.scaleY = 0.47;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -20.9;
			i58.scaleX = 1.71;
			i58.y = 53.4;
			i58.scaleY = 1.71;
			i23.x = -18.6;
			i23.scaleX = 0.98;
			i23.y = 4.5;
			i23.scaleY = 0.98;
			i66.x = 9.6;
			i66.scaleX = 0.89;
			i66.y = 41.6;
			i66.scaleY = 0.89;
			i80.x = -19.6;
			i80.scaleX = 0.73;
			i80.y = 13;
			i80.scaleY = 0.73;
			i88.x = 26.1;
			i88.scaleX = 0.61;
			i88.y = -7;
			i88.scaleY = 0.61;
			i90.x = 35.7;
			i90.scaleX = 0.55;
			i90.y = -4;
			i90.scaleY = 0.55;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -21.3;
			i58.scaleX = 1.86;
			i58.y = 53;
			i58.scaleY = 1.86;
			i23.x = -19;
			i23.scaleX = 1.15;
			i23.y = 3.6;
			i23.scaleY = 1.15;
			i23.rotation = 2;
			i66.x = 9.9;
			i66.scaleX = 0.97;
			i66.y = 41.3;
			i66.scaleY = 0.97;
			i80.x = -20.4;
			i80.scaleX = 0.82;
			i80.y = 13.3;
			i80.scaleY = 0.82;
			i80.rotation = 4;
			i88.x = 25.8;
			i88.scaleX = 0.79;
			i88.y = -7.7;
			i88.scaleY = 0.79;
			i90.x = 36.1;
			i90.scaleX = 0.62;
			i90.scaleY = 0.62;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.scaleX = 1.79;
			i58.y = 53.3;
			i58.scaleY = 1.79;
			i58.rotation = -1;
			i23.x = -19.6;
			i23.scaleX = 1.32;
			i23.y = 2.9;
			i23.scaleY = 1.32;
			i66.x = 10.4;
			i66.scaleX = 1.06;
			i66.y = 41;
			i66.scaleY = 1.06;
			i80.x = -21;
			i80.scaleX = 0.92;
			i80.y = 13.6;
			i80.scaleY = 0.92;
			i88.x = 25.4;
			i88.scaleX = 0.97;
			i88.y = -8.3;
			i88.scaleY = 0.97;
			i90.x = 36.6;
			i90.scaleX = 0.7;
			i90.scaleY = 0.7;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -21.2;
			i58.scaleX = 1.72;
			i58.y = 53.4;
			i58.scaleY = 1.72;
			i58.rotation = -3;
			i23.x = -20.1;
			i23.scaleX = 1.49;
			i23.y = 2.1;
			i23.scaleY = 1.49;
			i66.x = 10.8;
			i66.scaleX = 1.15;
			i66.y = 40.7;
			i66.scaleY = 1.15;
			i80.x = -21.7;
			i80.scaleX = 1.01;
			i80.y = 13.9;
			i80.scaleY = 1.01;
			i88.x = 24.9;
			i88.scaleX = 1.14;
			i88.y = -9.1;
			i88.scaleY = 1.14;
			i90.x = 37.1;
			i90.scaleX = 0.78;
			i90.y = -4.1;
			i90.scaleY = 0.78;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -21.1;
			i58.scaleX = 1.65;
			i58.y = 53.8;
			i58.scaleY = 1.65;
			i58.rotation = -5;
			i23.x = -20.6;
			i23.scaleX = 1.67;
			i23.y = 1.4;
			i23.scaleY = 1.67;
			i23.rotation = 3;
			i66.x = 11.3;
			i66.scaleX = 1.24;
			i66.y = 40.4;
			i66.scaleY = 1.24;
			i80.x = -22.4;
			i80.scaleX = 1.11;
			i80.y = 14.2;
			i80.scaleY = 1.11;
			i80.rotation = 5;
			i88.x = 24.4;
			i88.scaleX = 1.32;
			i88.y = -9.8;
			i88.scaleY = 1.32;
			i90.x = 37.6;
			i90.scaleX = 0.85;
			i90.y = -4;
			i90.scaleY = 0.85;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.scaleX = 1.58;
			i58.y = 54;
			i58.scaleY = 1.58;
			i58.rotation = -7;
			i23.x = -20.9;
			i23.scaleX = 1.84;
			i23.y = 0.6;
			i23.scaleY = 1.84;
			i66.x = 11.7;
			i66.scaleX = 1.33;
			i66.y = 40.1;
			i66.scaleY = 1.33;
			i80.x = -23.1;
			i80.scaleX = 1.2;
			i80.y = 14.5;
			i80.scaleY = 1.2;
			i88.x = 24.1;
			i88.scaleX = 1.5;
			i88.y = -10.6;
			i88.scaleY = 1.5;
			i90.x = 38.1;
			i90.scaleX = 0.93;
			i90.y = -4.3;
			i90.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -21;
			i58.scaleX = 1.51;
			i58.y = 54.3;
			i58.scaleY = 1.51;
			i58.rotation = -9;
			i23.x = -21.4;
			i23.scaleX = 2.01;
			i23.y = -0.3;
			i23.scaleY = 2.01;
			i66.x = 11.9;
			i66.scaleX = 1.43;
			i66.y = 39.8;
			i66.scaleY = 1.43;
			i80.x = -23.8;
			i80.scaleX = 1.29;
			i80.y = 14.8;
			i80.scaleY = 1.29;
			i88.x = 24.2;
			i88.scaleX = 1.45;
			i88.y = -10.4;
			i88.scaleY = 1.45;
			i90.x = 38.6;
			i90.scaleX = 1;
			i90.scaleY = 1;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -20.9;
			i58.scaleX = 1.44;
			i58.y = 54.5;
			i58.scaleY = 1.44;
			i58.rotation = -11;
			i23.x = -21.9;
			i23.scaleX = 2.18;
			i23.y = -1.1;
			i23.scaleY = 2.18;
			i23.rotation = 4;
			i66.x = 11.8;
			i66.scaleX = 1.4;
			i66.y = 40;
			i66.scaleY = 1.4;
			i66.rotation = 1;
			i80.x = -24.4;
			i80.scaleX = 1.39;
			i80.y = 15.1;
			i80.scaleY = 1.39;
			i80.rotation = 6;
			i88.x = 24.4;
			i88.scaleX = 1.41;
			i88.y = -10.2;
			i88.scaleY = 1.41;
			i90.x = 39.1;
			i90.scaleX = 1.08;
			i90.scaleY = 1.08;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -20.8;
			i58.scaleX = 1.38;
			i58.y = 54.7;
			i58.scaleY = 1.38;
			i58.rotation = -13;
			i23.x = -22.4;
			i23.scaleX = 2.35;
			i23.y = -1.9;
			i23.scaleY = 2.35;
			i66.scaleX = 1.37;
			i66.y = 40.3;
			i66.scaleY = 1.37;
			i66.rotation = 2;
			i80.x = -25.1;
			i80.scaleX = 1.48;
			i80.y = 15.3;
			i80.scaleY = 1.48;
			i88.scaleX = 1.36;
			i88.y = -9.9;
			i88.scaleY = 1.36;
			i90.x = 39.5;
			i90.scaleX = 1.16;
			i90.scaleY = 1.16;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i58.x = -20.6;
			i58.scaleX = 1.31;
			i58.y = 54.9;
			i58.scaleY = 1.31;
			i58.rotation = -14;
			i23.x = -22.8;
			i23.scaleX = 2.52;
			i23.y = -2.8;
			i23.scaleY = 2.52;
			i66.scaleX = 1.34;
			i66.y = 40.5;
			i66.scaleY = 1.34;
			i66.rotation = 4;
			i80.x = -26;
			i80.scaleX = 1.58;
			i80.y = 15.9;
			i80.scaleY = 1.58;
			i88.x = 24.6;
			i88.scaleX = 1.32;
			i88.y = -9.8;
			i88.scaleY = 1.32;
			i90.x = 40;
			i90.scaleX = 1.23;
			i90.scaleY = 1.23;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i23.x = -22.6;
			i23.scaleX = 2.47;
			i23.y = -2.5;
			i23.scaleY = 2.47;
			i66.scaleX = 1.32;
			i66.y = 40.7;
			i66.scaleY = 1.32;
			i66.rotation = 5;
			i80.x = -25.6;
			i80.scaleX = 1.54;
			i80.y = 16.1;
			i80.scaleY = 1.54;
			i80.rotation = 4;
			i90.x = 40.5;
			i90.scaleX = 1.31;
			i90.y = -4.5;
			i90.scaleY = 1.31;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i23.x = -22.3;
			i23.scaleX = 2.41;
			i23.y = -2.3;
			i23.scaleY = 2.41;
			i66.scaleX = 1.29;
			i66.y = 40.9;
			i66.scaleY = 1.29;
			i66.rotation = 7;
			i80.x = -25.1;
			i80.scaleX = 1.5;
			i80.y = 16.4;
			i80.scaleY = 1.5;
			i80.rotation = 2;
			i90.x = 41;
			i90.scaleX = 1.39;
			i90.scaleY = 1.39;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i23.x = -22.1;
			i23.scaleX = 2.36;
			i23.y = -2;
			i23.scaleY = 2.36;
			i66.scaleX = 1.26;
			i66.y = 41.1;
			i66.scaleY = 1.26;
			i66.rotation = 8;
			i80.x = -24.6;
			i80.scaleX = 1.47;
			i80.y = 16.6;
			i80.scaleY = 1.47;
			i80.rotation = 0;
			i90.x = 41.5;
			i90.scaleX = 1.46;
			i90.y = -4.4;
			i90.scaleY = 1.46;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i23.x = -21.9;
			i23.scaleX = 2.31;
			i23.y = -1.8;
			i23.scaleY = 2.31;
			i80.x = -24.2;
			i80.scaleX = 1.43;
			i80.y = 16.9;
			i80.scaleY = 1.43;
			i80.rotation = -1;
			i90.x = 41;
			i90.scaleX = 1.39;
			i90.y = -3.8;
			i90.scaleY = 1.39;
			i90.rotation = -11;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i23.scaleX = 2.25;
			i23.y = -1.5;
			i23.scaleY = 2.25;
			i80.x = -23.6;
			i80.scaleX = 1.4;
			i80.scaleY = 1.4;
			i80.rotation = -3;
			i90.x = 40.5;
			i90.scaleX = 1.31;
			i90.y = -3.4;
			i90.scaleY = 1.31;
			i90.rotation = -8;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i90.x = 40;
			i90.scaleX = 1.23;
			i90.y = -3;
			i90.scaleY = 1.23;
			i90.rotation = -5;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i90.x = 39.4;
			i90.scaleX = 1.16;
			i90.y = -2.6;
			i90.scaleY = 1.16;
			i90.rotation = -2;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f += () => {
			i90.x = 38.9;
			i90.scaleX = 1.08;
			i90.y = -2.5;
			i90.scaleY = 1.08;
			i90.rotation = 0;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i92);
		f.Add(i93);
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i95.x = 6.9;
			i95.scaleX = 0.23;
			i95.y = 91.6;
			i95.scaleY = 0.23;
			i95.rotation = -74;
			i95.alpha = 1;
			i95.filters = new as3.Array(new object[]{});
			i95.scale9Grid = null;
			i95.visible = true;
			i97.x = 10.4;
			i97.scaleX = 1;
			i97.y = 42.6;
			i97.scaleY = 1;
			i97.rotation = 0;
			i97.alpha = 1;
			i97.filters = new as3.Array(new object[]{});
			i97.scale9Grid = null;
			i97.visible = true;
			i98.x = 7.3;
			i98.scaleX = 1;
			i98.y = 42;
			i98.scaleY = 1;
			i98.rotation = 0;
			i98.alpha = 1;
			i98.filters = new as3.Array(new object[]{filter_0});
			i98.scale9Grid = null;
			i98.visible = true;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.9;
			i23.y = -1.4;
			i23.alpha = 0.9;
			i66.alpha = 0.9;
			i80.alpha = 0.9;
			i88.alpha = 0.9;
			i90.alpha = 0.9;
			i95.x = 6.8;
			i95.scaleX = 0.31;
			i95.y = 91.2;
			i95.scaleY = 0.31;
			i97.alpha = 0.9;
			i98.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i95.x = 6.7;
			i95.scaleX = 0.38;
			i95.y = 90.8;
			i95.scaleY = 0.38;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.8;
			i23.alpha = 0.8;
			i66.alpha = 0.8;
			i80.alpha = 0.8;
			i88.alpha = 0.8;
			i90.alpha = 0.8;
			i95.x = 6.5;
			i95.scaleX = 0.46;
			i95.y = 90.3;
			i95.scaleY = 0.46;
			i97.alpha = 0.8;
			i98.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.7;
			i23.alpha = 0.7;
			i66.alpha = 0.7;
			i80.alpha = 0.7;
			i88.alpha = 0.7;
			i90.alpha = 0.7;
			i95.x = 6.3;
			i95.scaleX = 0.53;
			i95.y = 90;
			i95.scaleY = 0.53;
			i97.alpha = 0.7;
			i98.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i95.x = 6.2;
			i95.scaleX = 0.61;
			i95.y = 89.5;
			i95.scaleY = 0.61;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.6;
			i23.alpha = 0.6;
			i66.alpha = 0.6;
			i80.alpha = 0.6;
			i88.alpha = 0.6;
			i90.alpha = 0.6;
			i95.x = 6;
			i95.scaleX = 0.69;
			i95.y = 89.2;
			i95.scaleY = 0.69;
			i97.alpha = 0.6;
			i98.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.5;
			i23.alpha = 0.5;
			i66.alpha = 0.5;
			i80.alpha = 0.5;
			i88.alpha = 0.5;
			i90.alpha = 0.5;
			i95.scaleX = 0.76;
			i95.y = 88.8;
			i95.scaleY = 0.76;
			i97.alpha = 0.5;
			i98.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i95.x = 5.8;
			i95.scaleX = 0.84;
			i95.y = 88.4;
			i95.scaleY = 0.84;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.4;
			i23.alpha = 0.4;
			i66.alpha = 0.4;
			i80.alpha = 0.4;
			i88.alpha = 0.4;
			i90.alpha = 0.4;
			i95.x = 5.7;
			i95.scaleX = 0.91;
			i95.y = 88;
			i95.scaleY = 0.91;
			i97.alpha = 0.4;
			i98.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.3;
			i23.alpha = 0.3;
			i66.alpha = 0.3;
			i80.alpha = 0.3;
			i88.alpha = 0.3;
			i90.alpha = 0.3;
			i95.x = 5.5;
			i95.scaleX = 0.99;
			i95.y = 87.5;
			i95.scaleY = 0.99;
			i97.alpha = 0.3;
			i98.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i95.x = 5.3;
			i95.scaleX = 1.06;
			i95.y = 87.2;
			i95.scaleY = 1.06;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.2;
			i23.alpha = 0.2;
			i66.alpha = 0.2;
			i80.alpha = 0.2;
			i88.alpha = 0.2;
			i90.alpha = 0.2;
			i95.x = 5.5;
			i95.scaleX = 0.99;
			i95.y = 87.5;
			i95.scaleY = 0.99;
			i97.alpha = 0.2;
			i98.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0.1;
			i23.alpha = 0.1;
			i66.alpha = 0.1;
			i80.alpha = 0.1;
			i88.alpha = 0.1;
			i90.alpha = 0.1;
			i95.x = 5.8;
			i95.scaleX = 0.92;
			i95.y = 88;
			i95.scaleY = 0.92;
			i97.alpha = 0.1;
			i98.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i97);
		f.Add(i98);
		f += () => {
			i58.alpha = 0;
			i23.alpha = 0;
			i66.alpha = 0;
			i80.alpha = 0;
			i88.alpha = 0;
			i90.alpha = 0;
			i95.scaleX = 0.85;
			i95.y = 88.3;
			i95.scaleY = 0.85;
			i97.alpha = 0;
			i98.alpha = 0;
		};
		f = l.Add();
		f.Add(i20);
		f.Add(i58);
		f.Add(i23);
		f.Add(i25);
		f.Add(i66);
		f.Add(i80);
		f.Add(i88);
		f.Add(i90);
		f.Add(i95);
		f.Add(i100);
		f.Add(i101);
		f += () => {
			i23.y = -1.5;
			i95.x = 5.9;
			i95.scaleX = 0.78;
			i95.y = 88.7;
			i95.scaleY = 0.78;
			i100.x = 10.4;
			i100.scaleX = 1;
			i100.y = 42.6;
			i100.scaleY = 1;
			i100.rotation = 0;
			i100.alpha = 0;
			i100.filters = new as3.Array(new object[]{});
			i100.scale9Grid = null;
			i100.visible = true;
			i101.x = 7.3;
			i101.scaleX = 1;
			i101.y = 42;
			i101.scaleY = 1;
			i101.rotation = 0;
			i101.alpha = 0;
			i101.filters = new as3.Array(new object[]{filter_0});
			i101.scale9Grid = null;
			i101.visible = true;
		};
		setFrames(l);
	}

	private class DropShadowFilter
	{
		public DropShadowFilter()
		{
		}

		public double angle { get; set; }
		public int blurX { get; set; }
		public int blurY { get; set; }
		public int distance { get; set; }
	}
}
namespace houseResources.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("acc521d07063ebe7a9e8ca8d9f0bd269", -46, -68.1, 89.35, 88.64999999999999, 1, 1);
		}
	}
	public class symbol_1 : MovieClip{ 
		public symbol_1() {
			var i22 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i22);//0
		}
	}
	public class symbol_10 : MovieClip{ 
		public symbol_10() {
			var i30 = new symbol_9(){filters = new as3.Array(new object[]{})};
			addChild(i30);//0
		}
	}
	public class symbol_11 : Shape{ 
		public symbol_11() {
			setGraphics("bae6544660cbd354e373fa5576da562b", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_12 : Shape{ 
		public symbol_12() {
			setGraphics("e9b397b50c1f2df1a0496de7ff6a31a5", -29.85, -50.55, 59.75, 100.9, 1, 1);
		}
	}
	public class symbol_13 : MovieClip{ 
		public symbol_13() {
			var i33 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i33);//0
		}
	}
	public class symbol_14 : Shape{ 
		public symbol_14() {
			setGraphics("ce3b4821edd3f226308c39365912b0a1", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_15 : MovieClip{ 
		public symbol_15() {
			var i36 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i36);//0
		}
	}
	public class symbol_16 : Shape{ 
		public symbol_16() {
			setGraphics("db2dde59b9b32308122952490bbf16f3", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_17 : MovieClip{ 
		public symbol_17() {
			var i39 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i39);//0
		}
	}
	public class symbol_18 : Shape{ 
		public symbol_18() {
			setGraphics("e5836a166c6f7155d8697b9cf876bccf", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_19 : MovieClip{ 
		public symbol_19() {
			var i42 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i42);//0
		}
	}
	public class symbol_2 : MovieClip{ 
		public symbol_2() {
			var i21 = new symbol_1(){x = 0.3 , scaleX = 0.31 , y = 7.3 , scaleY = 0.31 , filters = new as3.Array(new object[]{})};
			addChild(i21);//0
		}
	}
	public class symbol_20 : Shape{ 
		public symbol_20() {
			setGraphics("14335bccfd70fbec697ef27f97760ff2", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_21 : MovieClip{ 
		public symbol_21() {
			var i45 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i45);//0
		}
	}
	public class symbol_22 : Shape{ 
		public symbol_22() {
			setGraphics("92a04ae4592defe4e4e4282af652be0c", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_23 : MovieClip{ 
		public symbol_23() {
			var i48 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i48);//0
		}
	}
	public class symbol_24 : Shape{ 
		public symbol_24() {
			setGraphics("d98d7cc7099b407e47262b88d16009da", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_25 : MovieClip{ 
		public symbol_25() {
			var i51 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i51);//0
		}
	}
	public class symbol_26 : Shape{ 
		public symbol_26() {
			setGraphics("60d71e47f4ef4d7abc6dcd02404feee1", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_27 : MovieClip{ 
		public symbol_27() {
			var i54 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i54);//0
		}
	}
	public class symbol_28 : Shape{ 
		public symbol_28() {
			setGraphics("4ec0fe34ed0c0bddf3fb61ee15f2f45e", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_29 : MovieClip{ 
		public symbol_29() {
			var i57 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i57);//0
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("b2d0bc136f6ba296ff0b04aaa3ba3e6c", -3.4, -4.35, 6.8, 8.7, 1, 1);
		}
	}
	public class symbol_30 : Shape{ 
		public symbol_30() {
			setGraphics("b52372e87118032d6006ac5895955dbd", -6.9, -12.05, 9.8, 20.65, 1, 1);
		}
	}
	public class symbol_31 : MovieClip{ 
		public symbol_31() {
			var i59 = new symbol_30(){filters = new as3.Array(new object[]{})};
			addChild(i59);//0
		}
	}
	public class symbol_32 : Shape{ 
		public symbol_32() {
			setGraphics("2ab5f2e5498d75e1ebc6c313aa352fe5", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_33 : MovieClip{ 
		public symbol_33() {
			var i62 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i62);//0
		}
	}
	public class symbol_34 : Shape{ 
		public symbol_34() {
			setGraphics("f3766338856a69587253de5d18a52b71", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_35 : MovieClip{ 
		public symbol_35() {
			var i65 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i65);//0
		}
	}
	public class symbol_36 : Shape{ 
		public symbol_36() {
			setGraphics("32e8476001737ee82b0f4530d2cd0b73", -4.55, -6.55, 13.25, 16.15, 1, 1);
		}
	}
	public class symbol_37 : MovieClip{ 
		public symbol_37() {
			var i67 = new symbol_36(){filters = new as3.Array(new object[]{})};
			addChild(i67);//0
		}
	}
	public class symbol_38 : Shape{ 
		public symbol_38() {
			setGraphics("a4c1125c2db687d3db045c3dd0f975ed", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_39 : MovieClip{ 
		public symbol_39() {
			var i70 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i70);//0
		}
	}
	public class symbol_4 : MovieClip{ 
		public symbol_4() {
			var i24 = new symbol_3(){filters = new as3.Array(new object[]{})};
			addChild(i24);//0
		}
	}
	public class symbol_40 : Shape{ 
		public symbol_40() {
			setGraphics("5aa83f9a23d551592bbaf61c30635337", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_41 : MovieClip{ 
		public symbol_41() {
			var i73 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i73);//0
		}
	}
	public class symbol_42 : Shape{ 
		public symbol_42() {
			setGraphics("ef34b78fffc8c8e2901eb58c57999235", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_43 : MovieClip{ 
		public symbol_43() {
			var i76 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i76);//0
		}
	}
	public class symbol_44 : Shape{ 
		public symbol_44() {
			setGraphics("0d7d9661b0d2db44067db1a5961dc26b", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_45 : MovieClip{ 
		public symbol_45() {
			var i79 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i79);//0
		}
	}
	public class symbol_46 : Shape{ 
		public symbol_46() {
			setGraphics("81fb4d36487b827f5089ff464ee2ac59", -8.8, -5.9, 17.65, 11.850000000000001, 1, 1);
		}
	}
	public class symbol_47 : MovieClip{ 
		public symbol_47() {
			var i81 = new symbol_46(){filters = new as3.Array(new object[]{})};
			addChild(i81);//0
		}
	}
	public class symbol_48 : Shape{ 
		public symbol_48() {
			setGraphics("7e1cd120027a3eec514ca2623e899b64", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_49 : MovieClip{ 
		public symbol_49() {
			var i84 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i84);//0
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("3dfbab60da13d50cb2fd482bc73844dc", -52.65, -17.05, 100.9, 20, 1, 1);
		}
	}
	public class symbol_50 : Shape{ 
		public symbol_50() {
			setGraphics("b8222d669abeca9ec3d5ee1a9ee252ea", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_51 : MovieClip{ 
		public symbol_51() {
			var i87 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i87);//0
		}
	}
	public class symbol_52 : Shape{ 
		public symbol_52() {
			setGraphics("a30a56dab37a3a779287a9fead0ea92e", -3.15, -4.3, 6.35, 8.85, 1, 1);
		}
	}
	public class symbol_53 : MovieClip{ 
		public symbol_53() {
			var i89 = new symbol_52(){filters = new as3.Array(new object[]{})};
			addChild(i89);//0
		}
	}
	public class symbol_54 : Shape{ 
		public symbol_54() {
			setGraphics("2815c9a6d62db1d94a089ee307a00f7b", -7.65, -6.6, 15.350000000000001, 13.25, 1, 1);
		}
	}
	public class symbol_55 : MovieClip{ 
		public symbol_55() {
			var i91 = new symbol_54(){filters = new as3.Array(new object[]{})};
			addChild(i91);//0
		}
	}
	public class symbol_56 : Shape{ 
		public symbol_56() {
			setGraphics("0bef28c0e73809f40129043030dc2bf9", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_57 : MovieClip{ 
		public symbol_57() {
			var i94 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i94);//0
		}
	}
	public class symbol_58 : Shape{ 
		public symbol_58() {
			setGraphics("32e8476001737ee82b0f4530d2cd0b73", -4.55, -6.55, 13.25, 16.15, 1, 1);
		}
	}
	public class symbol_59 : MovieClip{ 
		public symbol_59() {
			var i96 = new symbol_58(){filters = new as3.Array(new object[]{})};
			addChild(i96);//0
		}
	}
	public class symbol_6 : MovieClip{ 
		public symbol_6() {
			var i27 = new symbol_5(){filters = new as3.Array(new object[]{})};
			addChild(i27);//0
		}
	}
	public class symbol_60 : Shape{ 
		public symbol_60() {
			setGraphics("0bef28c0e73809f40129043030dc2bf9", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_61 : MovieClip{ 
		public symbol_61() {
			var i99 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i99);//0
		}
	}
	public class symbol_62 : MovieClip{ 
		public symbol_62() {
			var i102 = new symbol_12(){filters = new as3.Array(new object[]{})};
			addChild(i102);//0
		}
	}
	public class symbol_7 : MovieClip{ 
		public symbol_7() {
			var i26 = new symbol_6(){x = 0.7 , scaleX = 0.32 , y = 2.3 , scaleY = 0.32 , filters = new as3.Array(new object[]{})};
			addChild(i26);//0
		}
	}
	public class symbol_8 : Shape{ 
		public symbol_8() {
			setGraphics("8316e064019e745027b2eab8e463286a", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("e9b397b50c1f2df1a0496de7ff6a31a5", -29.85, -50.55, 59.75, 100.9, 1, 1);
		}
	}
}
