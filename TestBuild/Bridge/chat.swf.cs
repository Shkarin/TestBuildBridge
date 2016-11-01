using System;
using flash.display;
using System.Collections.Generic;
using chat.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libchat : ResourcesExternalLib{
	public Libchat() {
	vectors = new string[] {
	"fb47a1a089ead461f1be6eaaaf97c083",
	"a7a0e1b4956f2e7adbbb7d14c3a90409",
	"e6308504b4dfd345e8041a7ebc564d20",
	"843aefbc67dbc29c4aeeb027fd54c0e8",
	"44e5c6edf8b5aca7943d1345d05472d9",
	"2806a229a1575f0a37fe7559fb96d104",
	"66abfce314ebf2f169dbdabb99f7ccc8",
	"9bacd4dfc5d9a9f8329d9efd2c0c6026"
	};
	graphics = new string[] {
	"a93eee430c1ce42167e0f77b9fb69b0d",
	"224ff9b209338114e17cedc2e93489f9",
	"fb57567d3ca996013735d3754e29bb4c",
	"b67daf44e63ade53cf7e3ccb5701b7f7",
	"86b5c602fbd614eb0f4dd70e586778cb",
	"2bacdf772fe6d0e0746d02cc321920e1",
	"aaf0fd75bc38421f8b2765c236fd14c7",
	"76a0e4f9992505dec6c6e85b1082f1ea",
	"a93eee430c1ce42167e0f77b9fb69b0d",
	"48f9d2cdb28feca75fc794e968396c39",
	"a47f55a38b0ac32390a1618aa19b4ad7",
	"c82b3660ddf1a275dcce33172a019773",
	"7ac5cc4a3bde0e1061eb88c1b85a2b00",
	"f06679c6b89c39d22708c269be0d2202",
	"7d49e3f4515cc09e79224231844cf44a",
	"860996c37abe5183f709dcfd4f354b6e",
	"ce385ef5cbecfb68a9fa211b7233c375",
	"9dc55f1e61d6603034751de6ddf3c085",
	"112a7d9a91d720f148e9eb5259c9fa10",
	"48f9fb4e2131fd6b309a243de5694e4e",
	"e869f5c94d32efd5a9faa0cca84c4d72",
	"de9c797d7ea3bf49f2fa9d362bc75b7d",
	"8ad8de929963f29ab039a53c13f011dc",
	"888670cc9b74940ef62c793bf26fc824",
	"7eb1e6172aef375575031f9bbea112a9",
	"d1cc5d68f1625b5ca84fa8b7c8b1ebbc",
	"9db432d7febc390753dc3c1c16388685",
	"dc5ca055dd22db5dd59b95fccd0814fb",
	"c37913e638c3c271c86359cbe980084b",
	"b99f6d5e23c9ecc07762bc8d767e7114"
	};
	}
}
public class BgCommon : BitmapData{ 
	public BgCommon() {
		width = 900;
		height = 860;
		setPixels("b67daf44e63ade53cf7e3ccb5701b7f7");
	}
}
public class ButtonChatEmotions : SimpleButton{ 
	public ButtonChatEmotions() {
		downState = new symbol_0(){filters = new as3.Array(new object[]{})};
		overState = new symbol_0(){filters = new as3.Array(new object[]{})};
		upState = new symbol_1(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_1(){filters = new as3.Array(new object[]{})};
	}
}
public class ChatHistoryButton : SimpleButton{ 
	public ChatHistoryButton() {
		downState = new symbol_2(){filters = new as3.Array(new object[]{})};
		overState = new symbol_2(){filters = new as3.Array(new object[]{})};
		upState = new symbol_3(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_2(){filters = new as3.Array(new object[]{})};
	}
}
public class ChatSmileButton : SimpleButton{ 
	public ChatSmileButton() {
		downState = new symbol_4(){filters = new as3.Array(new object[]{})};
		overState = new symbol_4(){filters = new as3.Array(new object[]{})};
		upState = new symbol_4(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_4(){filters = new as3.Array(new object[]{})};
	}
}
public class ChatSmileButtonClip : MovieClip{ 
	public ChatSmileButtonClip() {
		var i26 = new symbol_4(){filters = new as3.Array(new object[]{})};
		addChild(i26);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i26);
		f += () => {
			i26.x = 0;
			i26.scaleX = 1;
			i26.y = 0;
			i26.scaleY = 1;
			i26.rotation = 0;
			i26.alpha = 1;
			i26.filters = new as3.Array(new object[]{});
			i26.scale9Grid = null;
			i26.visible = true;
		};
		f = l.Add();
		f.Add(i26);
		setFrames(l);
	}
}
public class ChatTabHouseIcon : BitmapData{ 
	public ChatTabHouseIcon() {
		width = 12;
		height = 12;
		setPixels("a47f55a38b0ac32390a1618aa19b4ad7");
	}
}
public class ChatTabMafiaIcon : BitmapData{ 
	public ChatTabMafiaIcon() {
		width = 14;
		height = 9;
		setPixels("76a0e4f9992505dec6c6e85b1082f1ea");
	}
}
public class ChatTabModerateIcon : BitmapData{ 
	public ChatTabModerateIcon() {
		width = 12;
		height = 12;
		setPixels("d1cc5d68f1625b5ca84fa8b7c8b1ebbc");
	}
}
public class ChatTabPrivateIcon : BitmapData{ 
	public ChatTabPrivateIcon() {
		width = 10;
		height = 10;
		setPixels("224ff9b209338114e17cedc2e93489f9");
	}
}
public class ChatTabRoomIcon : BitmapData{ 
	public ChatTabRoomIcon() {
		width = 14;
		height = 12;
		setPixels("9dc55f1e61d6603034751de6ddf3c085");
	}
}
public class ChatTabVipIcon : BitmapData{ 
	public ChatTabVipIcon() {
		width = 10;
		height = 10;
		setPixels("fb57567d3ca996013735d3754e29bb4c");
	}
}
public class HintChatMessageIcon : BitmapData{ 
	public HintChatMessageIcon() {
		width = 16;
		height = 12;
		setPixels("48f9fb4e2131fd6b309a243de5694e4e");
	}
}
public class IconAddIgnoreChat : BitmapData{ 
	public IconAddIgnoreChat() {
		width = 16;
		height = 16;
		setPixels("48f9d2cdb28feca75fc794e968396c39");
	}
}
public class IconBirthdayChat : BitmapData{ 
	public IconBirthdayChat() {
		width = 15;
		height = 14;
		setPixels("8ad8de929963f29ab039a53c13f011dc");
	}
}
public class IconComplaintChat : BitmapData{ 
	public IconComplaintChat() {
		width = 8;
		height = 9;
		setPixels("888670cc9b74940ef62c793bf26fc824");
	}
}
public class IconGiftChat : BitmapData{ 
	public IconGiftChat() {
		width = 14;
		height = 16;
		setPixels("b99f6d5e23c9ecc07762bc8d767e7114");
	}
}
public class IconHeartChat : BitmapData{ 
	public IconHeartChat() {
		width = 14;
		height = 12;
		setPixels("a93eee430c1ce42167e0f77b9fb69b0d");
	}
}
public class IconMafiaChat : BitmapData{ 
	public IconMafiaChat() {
		width = 16;
		height = 10;
		setPixels("7d49e3f4515cc09e79224231844cf44a");
	}
}
public class IconModeratorChat : BitmapData{ 
	public IconModeratorChat() {
		width = 22;
		height = 22;
		setPixels("2bacdf772fe6d0e0746d02cc321920e1");
	}
}
public class IconOpenProfile : BitmapData{ 
	public IconOpenProfile() {
		width = 12;
		height = 12;
		setPixels("c82b3660ddf1a275dcce33172a019773");
	}
}
public class IconRemoveIgnoreChat : BitmapData{ 
	public IconRemoveIgnoreChat() {
		width = 16;
		height = 16;
		setPixels("860996c37abe5183f709dcfd4f354b6e");
	}
}
public class IconUnlockSticker : BitmapData{ 
	public IconUnlockSticker() {
		width = 21;
		height = 30;
		setPixels("de9c797d7ea3bf49f2fa9d362bc75b7d");
	}
}
public class IconVipChat : BitmapData{ 
	public IconVipChat() {
		width = 11;
		height = 17;
		setPixels("7ac5cc4a3bde0e1061eb88c1b85a2b00");
	}
}
public class IconWaitingKiss : BitmapData{ 
	public IconWaitingKiss() {
		width = 19;
		height = 14;
		setPixels("f06679c6b89c39d22708c269be0d2202");
	}
}
public class IconWeddingChat : BitmapData{ 
	public IconWeddingChat() {
		width = 17;
		height = 15;
		setPixels("e869f5c94d32efd5a9faa0cca84c4d72");
	}
}
public class StickersChatButtonClip : MovieClip{ 
	public StickersChatButtonClip() {
		var i28 = new symbol_5(){filters = new as3.Array(new object[]{})};
		addChild(i28);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(i28);
		f += () => {
			i28.x = 0;
			i28.scaleX = 1;
			i28.y = 0;
			i28.scaleY = 1;
			i28.rotation = 0;
			i28.alpha = 1;
			i28.filters = new as3.Array(new object[]{});
			i28.scale9Grid = null;
			i28.visible = true;
		};
		f = l.Add();
		f.Add(i28);
		setFrames(l);
	}
}
public class StickersChatHit : MovieClip{ 
	public StickersChatHit() {
		var i30 = new symbol_6(){filters = new as3.Array(new object[]{})};
		addChild(i30);//0
	}
}
public class TabCloseButton : SimpleButton{ 
	public TabCloseButton() {
		downState = new symbol_7(){filters = new as3.Array(new object[]{})};
		overState = new symbol_7(){filters = new as3.Array(new object[]{})};
		upState = new symbol_7(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_7(){filters = new as3.Array(new object[]{})};
	}
}
public class TextWantDeal : BitmapData{ 
	public TextWantDeal() {
		width = 114;
		height = 17;
		setPixels("c37913e638c3c271c86359cbe980084b");
	}
}
public class TextWantDealVertical : BitmapData{ 
	public TextWantDealVertical() {
		width = 14;
		height = 99;
		setPixels("9db432d7febc390753dc3c1c16388685");
	}
}
namespace chat.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("2806a229a1575f0a37fe7559fb96d104", -4, -5, 31, 34, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("66abfce314ebf2f169dbdabb99f7ccc8", 0, -1, 23, 26, 1, 1);
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("9bacd4dfc5d9a9f8329d9efd2c0c6026", -4, -4, 34, 34, 1, 1);
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("e6308504b4dfd345e8041a7ebc564d20", 0, 0, 26, 26, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("a7a0e1b4956f2e7adbbb7d14c3a90409", 0, 0, 39, 35, 1, 1);
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("843aefbc67dbc29c4aeeb027fd54c0e8", 0, 0, 34, 42, 1, 1);
		}
	}
	public class symbol_6 : Shape{ 
		public symbol_6() {
			setGraphics("fb47a1a089ead461f1be6eaaaf97c083", 3.15, 3.1, 27.3, 33, 1, 1);
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("44e5c6edf8b5aca7943d1345d05472d9", 0, 0, 12, 12, 1, 1);
		}
	}
}
