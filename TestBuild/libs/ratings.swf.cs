using System;
using flash.text;
using flash.display;
using System.Collections.Generic;
using ratings.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libratings : ResourcesExternalLib{
	public Libratings() {
	vectors = new string[] {
	"1e58640ad41253cc7fa34ee131bd3b8b"
	};
	graphics = new string[] {
	"eb9744329072bece2094f473cfb441e7",
	"eb9744329072bece2094f473cfb441e7",
	"9dd681e8782ab998511dcedaa0059d58",
	"26e8d2b087f03d4ae96114386e82dbd6",
	"35cc6a2ab796bdfcd6ec4dc46e422d0b",
	"e94c7d9680614a48c814edc4424a336e",
	"36fa0f7c3c21c0f89955d006876eb810",
	"3cf63067c9fb9b2506714b2a4614d48b",
	"c2559da3fc72e1d53008053cb046a803",
	"de011b620f71c49ebacc3833dd25e3c5",
	"0b237a741696ad93adaf77283a4785e1",
	"a762cbc601b1a5f820807497adae585d",
	"6f78803fc5edd57479a924b5ae1abcc0",
	"bfb7702cc0ed724a7154cfdfde87380c",
	"cea07b5a57c6349298d33f1c47fbe382",
	"975c26ff59289673042849103e0970a0",
	"267ab84cdef1884fd4092c2775407f69",
	"22ecacd6e23f4ea7b703fcf19bc36acd",
	"9d1fc4de63a21d933c5902423b1577cc",
	"e9ac37bbba21fcd1b25dfce1a1af51f4",
	"fffa1928ec7b3bd07a7ecd104778189e",
	"d018305fab0d58cf58d1d683b1d972d6",
	"cb7ff9e3cedfe7ecd023c45272548d89",
	"ed5a0850d3fba0b57d46c36331f7c358",
	"a3e6a7d6c0852a423111888595c0d695",
	"362027c09589f3332f9032ecedbb54c5",
	"08da31439281e6959a354e95babb62e7",
	"2eeface00ef91e04dad0efe08fa617b9"
	};
	}
}
public class ActivityIcon : BitmapData{ 
	public ActivityIcon() {
		width = 22;
		height = 16;
		setPixels("267ab84cdef1884fd4092c2775407f69");
	}
}
public class CommonIcon : BitmapData{ 
	public CommonIcon() {
		width = 17;
		height = 16;
		setPixels("d018305fab0d58cf58d1d683b1d972d6");
	}
}
public class GiftsIcon : BitmapData{ 
	public GiftsIcon() {
		width = 14;
		height = 17;
		setPixels("3cf63067c9fb9b2506714b2a4614d48b");
	}
}
public class HappyWeddingIconBig : BitmapData{ 
	public HappyWeddingIconBig() {
		width = 31;
		height = 24;
		setPixels("975c26ff59289673042849103e0970a0");
	}
}
public class HeartsIcon : BitmapData{ 
	public HeartsIcon() {
		width = 17;
		height = 14;
		setPixels("35cc6a2ab796bdfcd6ec4dc46e422d0b");
	}
}
public class IconDay : BitmapData{ 
	public IconDay() {
		width = 35;
		height = 26;
		setPixels("a762cbc601b1a5f820807497adae585d");
	}
}
public class IconEaster : BitmapData{ 
	public IconEaster() {
		width = 35;
		height = 25;
		setPixels("0b237a741696ad93adaf77283a4785e1");
	}
}
public class IconElite : BitmapData{ 
	public IconElite() {
		width = 35;
		height = 26;
		setPixels("e9ac37bbba21fcd1b25dfce1a1af51f4");
	}
}
public class IconForbes : BitmapData{ 
	public IconForbes() {
		width = 35;
		height = 26;
		setPixels("cea07b5a57c6349298d33f1c47fbe382");
	}
}
public class IconMain : BitmapData{ 
	public IconMain() {
		width = 35;
		height = 26;
		setPixels("bfb7702cc0ed724a7154cfdfde87380c");
	}
}
public class IconPhotoRate : BitmapData{ 
	public IconPhotoRate() {
		width = 35;
		height = 26;
		setPixels("9d1fc4de63a21d933c5902423b1577cc");
	}
}
public class IconWedding : BitmapData{ 
	public IconWedding() {
		width = 35;
		height = 26;
		setPixels("ed5a0850d3fba0b57d46c36331f7c358");
	}
}
public class KissesIcon : BitmapData{ 
	public KissesIcon() {
		width = 20;
		height = 12;
		setPixels("9dd681e8782ab998511dcedaa0059d58");
	}
}
public class PopularIconBig : BitmapData{ 
	public PopularIconBig() {
		width = 23;
		height = 22;
		setPixels("ad1fee20abcddc950168ae821fbd97e8");
	}
}
public class RatingApartmentsBlueIcon : BitmapData{ 
	public RatingApartmentsBlueIcon() {
		width = 17;
		height = 16;
		setPixels("de011b620f71c49ebacc3833dd25e3c5");
	}
}
public class RatingDuoIcon : BitmapData{ 
	public RatingDuoIcon() {
		width = 28;
		height = 37;
		setPixels("a3e6a7d6c0852a423111888595c0d695");
	}
}
public class RatingHintBackground : MovieClip{ 
	public RatingHintBackground() {
		this.scale9Grid = new flash.geom.Rectangle(294, 71, 32, 150);
		var i9 = new symbol_0();
		addChild(i9);//0
	}
}
public class RatingPetsBlueIcon : BitmapData{ 
	public RatingPetsBlueIcon() {
		width = 21;
		height = 16;
		setPixels("08da31439281e6959a354e95babb62e7");
	}
}
public class RatingPlayerShadow : BitmapData{ 
	public RatingPlayerShadow() {
		width = 137;
		height = 198;
		setPixels("e94c7d9680614a48c814edc4424a336e");
	}
}
public class RatingScreenShadow : BitmapData{ 
	public RatingScreenShadow() {
		width = 720;
		height = 690;
		setPixels("36fa0f7c3c21c0f89955d006876eb810");
	}
}
public class RatingTreeIcon : BitmapData{ 
	public RatingTreeIcon() {
		width = 13;
		height = 18;
		setPixels("cb7ff9e3cedfe7ecd023c45272548d89");
	}
}
public class RichIconBig : BitmapData{ 
	public RichIconBig() {
		width = 42;
		height = 21;
		setPixels("26e8d2b087f03d4ae96114386e82dbd6");
	}
}
public class RichWeddingIconBig : BitmapData{ 
	public RichWeddingIconBig() {
		width = 24;
		height = 21;
		setPixels("6f78803fc5edd57479a924b5ae1abcc0");
	}
}
public class SearchPlaceIcon : BitmapData{ 
	public SearchPlaceIcon() {
		width = 13;
		height = 13;
		setPixels("362027c09589f3332f9032ecedbb54c5");
	}
}
public class TopIconRatingPopular : BitmapData{ 
	public TopIconRatingPopular() {
		width = 17;
		height = 18;
		setPixels("fffa1928ec7b3bd07a7ecd104778189e");
	}
}
public class TopIconRatingRich : BitmapData{ 
	public TopIconRatingRich() {
		width = 21;
		height = 14;
		setPixels("c2559da3fc72e1d53008053cb046a803");
	}
}
public class TopIconRatingWedding : BitmapData{ 
	public TopIconRatingWedding() {
		width = 21;
		height = 15;
		setPixels("22ecacd6e23f4ea7b703fcf19bc36acd");
	}
}
public class TopIconRatingWeddingRich : BitmapData{ 
	public TopIconRatingWeddingRich() {
		width = 20;
		height = 17;
		setPixels("2eeface00ef91e04dad0efe08fa617b9");
	}
}
namespace ratings.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("1e58640ad41253cc7fa34ee131bd3b8b", 0, 0, 560, 270, 1, 1);
		}
	}
}
