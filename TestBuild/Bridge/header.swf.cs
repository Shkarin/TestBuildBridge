using System;
using flash.display;
using System.Collections.Generic;
using header.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libheader : ResourcesExternalLib{
	public Libheader() {
	vectors = new string[] {
	"a79ad29c76dad3da1eff6a7f16ec39ee",
	"1c379a8ba5272eec2a7135644c5a63ed"
	};
	graphics = new string[] {
	"0f9b8bbcbdd8f6b12dcfd71c2b89b17d",
	"12e7d97796fb8557d921348f445ef80e",
	"0f9b8bbcbdd8f6b12dcfd71c2b89b17d",
	"bb3d791bae889837eec435534d3f6e15",
	"06dd63e00fa7aed410c82cdce5491d94",
	"f80859f72242ffa1e383de9c666c7fdc",
	"3b6c52b4fe39f79b453315f8484af07c",
	"452bc7eef467601d45da13a67d873787",
	"30184268baaae164fbd98e40e2ece319",
	"df11274524795a179763e5fbd99c2626",
	"be8cf836509b9a1e8daf69850c9c1d14",
	"9a5c6f0b514e176d22891d7b96b8fb6a",
	"ad5e0c826dc93072629c144091812e7e",
	"941798dc6c297fb0de1a0ea21791064c",
	"7be0b4f40052e280963103aa6bd45978",
	"4ea3c2f103ad9a1c503a97e652daf05a",
	"72a0f44505a2fa2664bc82e5e8c410bc",
	"0ecb3967e459516ea3f9d3dc2597f8f3",
	"58b5bfcf73b45ee8f8cab1f626327ee0",
	"2c8844c624731978e7962b109a9b15a1",
	"64999fe2bdab8791ef9c1ce830c87ed5",
	"fe991ce4fc1b2dde4335f198ebd251a1",
	"51e5818ad27e67c211b3727a36a6e9dd",
	"330e84a72a2cfaa345f774bee8782b76"
	};
	}
}
public class AddBottlesImg : BitmapData{ 
	public AddBottlesImg() {
		width = 23;
		height = 23;
		setPixels("ad5e0c826dc93072629c144091812e7e");
	}
}
public class ButtonsGroup : BitmapData{ 
	public ButtonsGroup() {
		width = 22;
		height = 20;
		setPixels("7be0b4f40052e280963103aa6bd45978");
	}
}
public class ButtonsGroupdBackground : BitmapData{ 
	public ButtonsGroupdBackground() {
		width = 181;
		height = 14;
		setPixels("330e84a72a2cfaa345f774bee8782b76");
	}
}
public class HelpSettingsImg : BitmapData{ 
	public HelpSettingsImg() {
		width = 21;
		height = 21;
		setPixels("0ecb3967e459516ea3f9d3dc2597f8f3");
	}
}
public class IconColorOff : BitmapData{ 
	public IconColorOff() {
		width = 20;
		height = 19;
		setPixels("c4ef3cc99a2ccd417f26c5cea96a5b37");
	}
}
public class IconColorOn : BitmapData{ 
	public IconColorOn() {
		width = 20;
		height = 19;
		setPixels("be8cf836509b9a1e8daf69850c9c1d14");
	}
}
public class IconFamilyHouse : BitmapData{ 
	public IconFamilyHouse() {
		width = 20;
		height = 16;
		setPixels("72a0f44505a2fa2664bc82e5e8c410bc");
	}
}
public class IconHouse : BitmapData{ 
	public IconHouse() {
		width = 20;
		height = 16;
		setPixels("64999fe2bdab8791ef9c1ce830c87ed5");
	}
}
public class IconMenuAchievementsImg : BitmapData{ 
	public IconMenuAchievementsImg() {
		width = 18;
		height = 17;
		setPixels("f80859f72242ffa1e383de9c666c7fdc");
	}
}
public class IconMenuChatImg : BitmapData{ 
	public IconMenuChatImg() {
		width = 18;
		height = 19;
		setPixels("df11274524795a179763e5fbd99c2626");
	}
}
public class IconMenuGameImg : BitmapData{ 
	public IconMenuGameImg() {
		width = 20;
		height = 21;
		setPixels("452bc7eef467601d45da13a67d873787");
	}
}
public class IconMenuHouseImg : BitmapData{ 
	public IconMenuHouseImg() {
		width = 20;
		height = 17;
		setPixels("30184268baaae164fbd98e40e2ece319");
	}
}
public class IconMenuMafiaImg : BitmapData{ 
	public IconMenuMafiaImg() {
		width = 25;
		height = 15;
		setPixels("bb3d791bae889837eec435534d3f6e15");
	}
}
public class IconMenuProfileImg : BitmapData{ 
	public IconMenuProfileImg() {
		width = 17;
		height = 18;
		setPixels("fe991ce4fc1b2dde4335f198ebd251a1");
	}
}
public class IconMenuRatingImg : BitmapData{ 
	public IconMenuRatingImg() {
		width = 34;
		height = 20;
		setPixels("58b5bfcf73b45ee8f8cab1f626327ee0");
	}
}
public class IconMenuWeddingImg : BitmapData{ 
	public IconMenuWeddingImg() {
		width = 21;
		height = 19;
		setPixels("51e5818ad27e67c211b3727a36a6e9dd");
	}
}
public class IconModerationHeader : BitmapData{ 
	public IconModerationHeader() {
		width = 22;
		height = 19;
		setPixels("9a5c6f0b514e176d22891d7b96b8fb6a");
	}
}
public class IconPhotoRatesHeader : BitmapData{ 
	public IconPhotoRatesHeader() {
		width = 23;
		height = 21;
		setPixels("0f9b8bbcbdd8f6b12dcfd71c2b89b17d");
	}
}
public class MusicOffSettingsImg : BitmapData{ 
	public MusicOffSettingsImg() {
		width = 23;
		height = 19;
		setPixels("941798dc6c297fb0de1a0ea21791064c");
	}
}
public class MusicSettingsImg : BitmapData{ 
	public MusicSettingsImg() {
		width = 23;
		height = 19;
		setPixels("3b6c52b4fe39f79b453315f8484af07c");
	}
}
public class ScreenshotSettingsImg : BitmapData{ 
	public ScreenshotSettingsImg() {
		width = 19;
		height = 16;
		setPixels("06dd63e00fa7aed410c82cdce5491d94");
	}
}
public class SettingsBgImg : BitmapData{ 
	public SettingsBgImg() {
		width = 181;
		height = 14;
		setPixels("330e84a72a2cfaa345f774bee8782b76");
	}
}
public class SettingsButton : SimpleButton{ 
	public SettingsButton() {
		downState = new symbol_0(){filters = new as3.Array(new object[]{})};
		overState = new symbol_0(){filters = new as3.Array(new object[]{})};
		upState = new symbol_0(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_1(){filters = new as3.Array(new object[]{})};
	}
}
public class SoundsOffSettingsImg : BitmapData{ 
	public SoundsOffSettingsImg() {
		width = 21;
		height = 21;
		setPixels("2c8844c624731978e7962b109a9b15a1");
	}
}
public class SoundsSettingsImg : BitmapData{ 
	public SoundsSettingsImg() {
		width = 21;
		height = 21;
		setPixels("12e7d97796fb8557d921348f445ef80e");
	}
}
namespace header.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("a79ad29c76dad3da1eff6a7f16ec39ee", -6, -6, 30, 30, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("1c379a8ba5272eec2a7135644c5a63ed", 0, 0, 19.3, 19.3, 1, 1);
		}
	}
}
