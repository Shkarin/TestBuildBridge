using System;
using flash.text;
using flash.display;
using System.Collections.Generic;
using as3;
using RockiePlayer;
using flash.filters;

public class Libevents : ResourcesExternalLib{
	public Libevents() {
	graphics = new string[] {
	"7d87ce6dea097020fde64737db61beae",
	"a840dd7e9a3de231715b3c593ad5e02c",
	"45c7731631c836717c2cbae4a66f6d7e",
	"6e97756eca217944c067b532ec635221",
	"2535b866aefa182963f5311ab894a647",
	"679da60e20e9ed132af6b6773b834026",
	"f50ec3edf4fe2331716783b1f22acc26",
	"932fc6be81ca24670e7b21ab6841132b",
	"97b8df510db9bc5a24dd3a89a953e57a",
	"29a7e0f77f351fecb96dff1fa2bb1429",
	"347eb8f11af11e4948becbb52f8a347e",
	"13c57da2316e2414eceababc7ac512b7",
	"a7e95d57f216f443b16624e24f2a895d",
	"e20a8d07e41c413298e23e5ed393af98",
	"c3fda396c89f84af148b97509d6491d8",
	"2c4cd630d8939fea35901ea49249964f",
	"11520d2da582e05a6f5e8c3678118d67",
	"3eb6e0c803dae4a7e4c2c6ddf89fdcd5",
	"91bfb3e505015be0e22cd12aa63a5633",
	"01c8473b629f33e1e83da7f663a0e34f",
	"b70431a2a024495a8799a9b8612cf8a6",
	"135a5b0483652b9d72aff70b16d8a214",
	"7702bb2b49a5a9c15f512c86763576d4",
	"6a5a1ca2c13a846aa88864019a4b4b79",
	"64d26ec9fc3b7466b0c7b9f99926094b",
	"b1da31cc6383c6c9a0354d45ad961618"
	};
	}
}
public class BananiEventImage : BitmapData{ 
	public BananiEventImage() {
		width = 56;
		height = 77;
		setPixels("e20a8d07e41c413298e23e5ed393af98");
	}
}
public class BrokenHeartIcon : BitmapData{ 
	public BrokenHeartIcon() {
		width = 30;
		height = 30;
		setPixels("3eb6e0c803dae4a7e4c2c6ddf89fdcd5");
	}
}
public class EventBottleIcon : BitmapData{ 
	public EventBottleIcon() {
		width = 8;
		height = 20;
		setPixels("7d87ce6dea097020fde64737db61beae");
	}
}
public class IconAddCommentEvent : BitmapData{ 
	public IconAddCommentEvent() {
		width = 29;
		height = 29;
		setPixels("932fc6be81ca24670e7b21ab6841132b");
	}
}
public class IconAddEvent : BitmapData{ 
	public IconAddEvent() {
		width = 29;
		height = 29;
		setPixels("13c57da2316e2414eceababc7ac512b7");
	}
}
public class IconBottlePrize : BitmapData{ 
	public IconBottlePrize() {
		width = 46;
		height = 46;
		setPixels("2c4cd630d8939fea35901ea49249964f");
	}
}
public class IconFreeGift : BitmapData{ 
	public IconFreeGift() {
		width = 62;
		height = 65;
		setPixels("347eb8f11af11e4948becbb52f8a347e");
	}
}
public class IconFurniturePrize : BitmapData{ 
	public IconFurniturePrize() {
		width = 44;
		height = 46;
		setPixels("97b8df510db9bc5a24dd3a89a953e57a");
	}
}
public class IconGiftEvent : BitmapData{ 
	public IconGiftEvent() {
		width = 29;
		height = 29;
		setPixels("2535b866aefa182963f5311ab894a647");
	}
}
public class IconGuestRequest : BitmapData{ 
	public IconGuestRequest() {
		width = 29;
		height = 29;
		setPixels("f50ec3edf4fe2331716783b1f22acc26");
	}
}
public class IconKeyPrize : BitmapData{ 
	public IconKeyPrize() {
		width = 45;
		height = 31;
		setPixels("a840dd7e9a3de231715b3c593ad5e02c");
	}
}
public class IconPetEvent : BitmapData{ 
	public IconPetEvent() {
		width = 29;
		height = 29;
		setPixels("c3fda396c89f84af148b97509d6491d8");
	}
}
public class IconPhotoEvent : BitmapData{ 
	public IconPhotoEvent() {
		width = 30;
		height = 30;
		setPixels("6e97756eca217944c067b532ec635221");
	}
}
public class IconPhotosLikeEvent : BitmapData{ 
	public IconPhotosLikeEvent() {
		width = 29;
		height = 29;
		setPixels("91bfb3e505015be0e22cd12aa63a5633");
	}
}
public class IconProposal : BitmapData{ 
	public IconProposal() {
		width = 29;
		height = 29;
		setPixels("11520d2da582e05a6f5e8c3678118d67");
	}
}
public class IconRemoveEvent : BitmapData{ 
	public IconRemoveEvent() {
		width = 30;
		height = 30;
		setPixels("7702bb2b49a5a9c15f512c86763576d4");
	}
}
public class IconStartAdmireEvent : BitmapData{ 
	public IconStartAdmireEvent() {
		width = 29;
		height = 29;
		setPixels("01c8473b629f33e1e83da7f663a0e34f");
	}
}
public class IconVipMan : BitmapData{ 
	public IconVipMan() {
		width = 63;
		height = 47;
		setPixels("45c7731631c836717c2cbae4a66f6d7e");
	}
}
public class IconVipManNoShadow : BitmapData{ 
	public IconVipManNoShadow() {
		width = 61;
		height = 47;
		setPixels("b1da31cc6383c6c9a0354d45ad961618");
	}
}
public class IconVipWoman : BitmapData{ 
	public IconVipWoman() {
		width = 60;
		height = 48;
		setPixels("679da60e20e9ed132af6b6773b834026");
	}
}
public class IconVipWomanNoShadow : BitmapData{ 
	public IconVipWomanNoShadow() {
		width = 61;
		height = 47;
		setPixels("a7e95d57f216f443b16624e24f2a895d");
	}
}
public class LoveTreeGrewIcon : BitmapData{ 
	public LoveTreeGrewIcon() {
		width = 82;
		height = 85;
		setPixels("b70431a2a024495a8799a9b8612cf8a6");
	}
}
public class NewsTabArrow : BitmapData{ 
	public NewsTabArrow() {
		width = 14;
		height = 9;
		setPixels("135a5b0483652b9d72aff70b16d8a214");
	}
}
public class PhotosLikeHint : BitmapData{ 
	public PhotosLikeHint() {
		width = 117;
		height = 70;
		setPixels("6a5a1ca2c13a846aa88864019a4b4b79");
	}
}
public class RingboxIcon : BitmapData{ 
	public RingboxIcon() {
		width = 30;
		height = 33;
		setPixels("29a7e0f77f351fecb96dff1fa2bb1429");
	}
}
public class UnderIconImg : BitmapData{ 
	public UnderIconImg() {
		width = 68;
		height = 68;
		setPixels("64d26ec9fc3b7466b0c7b9f99926094b");
	}
}
