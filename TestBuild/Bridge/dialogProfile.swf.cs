using System;
using flash.display;
using System.Collections.Generic;
using dialogProfile.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class LibdialogProfile : ResourcesExternalLib{
	public LibdialogProfile() {
	vectors = new string[] {
	"4be0de3aeafedd581a0191f1f2784ab6",
	"f3d665483183edf836dd284e5a878787",
	"68ce3a48a97bb241bc7767b6015c9b31",
	"aa2d2a24689fe1e056d33b289cb86597",
	"a574e7b1fc9086f6a5d5864ef27e7d96",
	"9f6701c3a3ebc90954f65e3fddff6482",
	"a03e2146196b8d4b1a70cc4cc3f871d4",
	"d1bbbe3d62e9c29bc42813437abc244a",
	"ae5cc20d57c293d0f23b7767e3422eca",
	"08f1d113f5bb7687934ba122c58327f2",
	"8c09339726e26ea382f52991fa19ddc4",
	"1122e6b6e1cfda692d45156abd6e97fa",
	"38d1ba0e6a1961fabc58bc085376c4ff",
	"11676549fb73111533ae933884b04664",
	"eca8f50f5a5560a807cbe53f197b74eb",
	"4095a26d300fdd8aa7bed2c6ce108f93",
	"86e4a436cc43dbd5fd7ca564c5766896",
	"1cb43eb16ffa338f2262d92fd61007c1"
	};
	graphics = new string[] {
	"4c538163a4e6912d78d03bd418161f0e",
	"81df4a85f5e06baf7483f35315e0732a",
	"6d99ac1a7369fc77031621ee2c43af55",
	"d58b7c84340d1cc78d2d62434338ab7f",
	"21d757034f351988567b06d2507b87e4",
	"57da2211ddd8538d0ab6c8cea70c005b",
	"d9b800e1e8242acc275245ebae9db7bf",
	"c5f1ce78a007ff6ca5eee954958f702f",
	"d17ff46faefd7a100a09502aa5e35060",
	"ad952b7556d54ea371f796324515e0a3",
	"b34abbcd2e301d979f50b7182175c7e6",
	"529061bbe877b8827481413a4bfcbee5",
	"6f968bed1c4f17c15a317301b68e44bb",
	"9c9a5b42245f27f0f78a65b2a78fd667",
	"de99606bedf57cc9637674cd1422e5de",
	"12ede8c3e007d1589f6858f9c0cc429e",
	"d2bc94efc4a0bb0f93520bdbabdf37a9",
	"95d68be631bdbe66c99a0cb705513dde",
	"2c54d8ad85cfd7b6d6b137619923a657",
	"201e18510fc8c7b6b43e43d5099506fb",
	"e84ce927c25fb0f7e2e56fbbf6ae86ef",
	"95615fb1f893740fbab83ef3c6d20c6c",
	"3eeec35b907536b5ce4527ba892eeeb9",
	"c8281c148665ec4c94ed9bb3fd4b39b4",
	"c4da0e7dc32c66ea0082ade938a8dffd",
	"5aa72f4278a95b2037c1fe7ee89ef5f5",
	"793b9553f56edbb9737e966df1879ce4",
	"03bf19b8156ce2dfd71ad6caabbb9d8a",
	"a45d13b6a8bfa8217bcf2ffcffdd0369",
	"e9e51cfc7d2eb37f546ce3ec5dcdfd02",
	"8027b56cb4a07aff40609a6676418a21",
	"fbc091965f6d097c499c917e6f92c695",
	"7812e384968c911dec67627c6380d6bf",
	"49d7e47999dc0454ac97c3a7566d7c63",
	"03b7e3086b6c6b84313d157acc5c86c3",
	"d09af6d836862d97949f0581e8c46b38",
	"a2893e4ed6814e5763dfce419a6a7680",
	"dec4e10803743cb9fdec164f2b18ee42",
	"ce5cbf15cc1af687f2e002739b53b2fb",
	"e59a259d42501afaddc0c13cedba7c5f",
	"38f08e744b3a927d0f314c5ebf363267",
	"fababab5d6ece82b537f31f2ae962095",
	"e56901dd643f631ebc341d8d60aecbb6",
	"4aa136185475d4ae1496a00103714271",
	"e94691ddf9cb26d9d5025d7758d62e75",
	"7befff9ef05ebe72cae185fd44e4a2da",
	"b7eb8c0d221ea663f7b666540f736454",
	"9e7bcf61955237f3a5b947a6618bb178",
	"e3af3ee748dcd18b666ca0dccb66375d",
	"37708d210e5db9679efe112369ebc50d",
	"cb5e94f6779c1ffe3f161c1b939ff282",
	"dc81cb3fdfd2d56a70daa321ec32c575",
	"a6b1f84cf21562036ea7031c7b0e0970",
	"78d7f381154f7af07f06b66fa08bb0a6",
	"d6d343c43f909cb2250eae8b191a7db9",
	"536cb2935977b97574e7bacbfacc2c73",
	"21d897f23445c62fde3411935aa3fd4b",
	"708b1657da7adb2dc7f193912dd2e086",
	"61cacfb77a473539f4d9a8f0dc493741",
	"10ae4d6fbbb3cb3d04522e23fc5d5d5c",
	"d1f2369ba99c98fb9a28e5b07171f1e8",
	"b8f41e68edee362dc482bf5d795541ef",
	"40cf924b9d5fcc7c6fe449dcb08ac4aa",
	"ecd3d7f0b1f7476597d6dd188c2403e9",
	"51a441ace6ee34f6598682f4b373e247",
	"f36215f96a73804475cc5006125d8c5d",
	"146bbceb0b1b9781a35abf671c7ba4b9",
	"3c522336ab92d69669cccbf6aab39651",
	"dbdf4a4c4e1834d142883249ac5ac30e",
	"67293d16c04329308d837a4aecd6d1d1",
	"8b7dd944b5a359ae252c49395eaec881",
	"70c92327e55ecee3249405af489d8ea2",
	"de89fb780d3396e42fa27127d7fd29ed",
	"1c08ce0b7fd48990808dd740cfc78dcf",
	"820fb32182e072a6bfa0efcfd636b8ba",
	"0cb4d392b095b54139e5466f3d8639e6",
	"5a0c0fd27d6106be2d6c6404859de65f",
	"03bd589aa9ae5197376ef81e6537b842",
	"c8e6552e5b133f71ba2c31209b806f38",
	"f72211f071d39dab26b3dfba48dcb590",
	"8be1fdad948ccb89d98d51567f4f20ec"
	};
	}
}
public class BackCompareAchievements : BitmapData{ 
	public BackCompareAchievements() {
		width = 564;
		height = 614;
		setPixels("e56901dd643f631ebc341d8d60aecbb6");
	}
}
public class BackgroundMedal : BitmapData{ 
	public BackgroundMedal() {
		width = 99;
		height = 130;
		setPixels("6d99ac1a7369fc77031621ee2c43af55");
	}
}
public class ButtonCloseGrey : SimpleButton{ 
	public ButtonCloseGrey() {
		downState = new symbol_0();
		overState = new symbol_1();
		upState = new symbol_2();
		hitTestState = new symbol_0();
	}
}
public class ButtonCloseWhite : SimpleButton{ 
	public ButtonCloseWhite() {
		downState = new symbol_3();
		overState = new symbol_4();
		upState = new symbol_3();
		hitTestState = new symbol_5();
	}
}
public class ButtonSwitchOff : SimpleButton{ 
	public ButtonSwitchOff() {
		downState = new symbol_6();
		overState = new symbol_7();
		upState = new symbol_6();
		hitTestState = new symbol_6();
	}
}
public class CommentSendIcon : BitmapData{ 
	public CommentSendIcon() {
		width = 20;
		height = 13;
		setPixels("8b7dd944b5a359ae252c49395eaec881");
	}
}
public class CommentSmilesClip : MovieClip{ 
	public CommentSmilesClip() {
		var i27 = new symbol_9();
		addChild(i27);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();//0
		f.Add(i27);
		f += () => {
			i27.x = 0;
			i27.scaleX = 1;
			i27.y = 0;
			i27.scaleY = 1;
			i27.rotation = 0;
			i27.alpha = 1;
			i27.filters = null;
			i27.visible = true;
		};
		f = l.Add();//1
		f.Add(i27);
		setFrames(l);
	}
}
public class CommentStickersClip : MovieClip{ 
	public CommentStickersClip() {
		var i30 = new symbol_11();
		addChild(i30);//0
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();//0
		f.Add(i30);
		f += () => {
			i30.x = 0;
			i30.scaleX = 1;
			i30.y = 0;
			i30.scaleY = 1;
			i30.rotation = 0;
			i30.alpha = 1;
			i30.filters = null;
			i30.visible = true;
		};
		f = l.Add();//1
		f.Add(i30);
		setFrames(l);
	}
}
public class CommentsEmptyImage : BitmapData{ 
	public CommentsEmptyImage() {
		width = 72;
		height = 58;
		setPixels("fababab5d6ece82b537f31f2ae962095");
	}
}
public class DesignSwitchOn : BitmapData{ 
	public DesignSwitchOn() {
		width = 32;
		height = 12;
		setPixels("ad952b7556d54ea371f796324515e0a3");
	}
}
public class IconAchievementProfile : BitmapData{ 
	public IconAchievementProfile() {
		width = 14;
		height = 20;
		setPixels("c5f1ce78a007ff6ca5eee954958f702f");
	}
}
public class IconBDComplain : BitmapData{ 
	public IconBDComplain() {
		width = 18;
		height = 18;
		setPixels("2c54d8ad85cfd7b6d6b137619923a657");
	}
}
public class IconCircles : BitmapData{ 
	public IconCircles() {
		width = 35;
		height = 22;
		setPixels("1c08ce0b7fd48990808dd740cfc78dcf");
	}
}
public class IconFamilyHouseProfile : BitmapData{ 
	public IconFamilyHouseProfile() {
		width = 21;
		height = 16;
		setPixels("c8e6552e5b133f71ba2c31209b806f38");
	}
}
public class IconGoToApartamentProfile : BitmapData{ 
	public IconGoToApartamentProfile() {
		width = 19;
		height = 18;
		setPixels("d2bc94efc4a0bb0f93520bdbabdf37a9");
	}
}
public class IconGoToRoomProfile : BitmapData{ 
	public IconGoToRoomProfile() {
		width = 13;
		height = 20;
		setPixels("d17ff46faefd7a100a09502aa5e35060");
	}
}
public class IconHeartProfile : BitmapData{ 
	public IconHeartProfile() {
		width = 16;
		height = 14;
		setPixels("9e7bcf61955237f3a5b947a6618bb178");
	}
}
public class IconIgnoreProfile : BitmapData{ 
	public IconIgnoreProfile() {
		width = 18;
		height = 16;
		setPixels("61cacfb77a473539f4d9a8f0dc493741");
	}
}
public class IconKnockProfile : BitmapData{ 
	public IconKnockProfile() {
		width = 23;
		height = 23;
		setPixels("708b1657da7adb2dc7f193912dd2e086");
	}
}
public class IconLetter : BitmapData{ 
	public IconLetter() {
		width = 19;
		height = 18;
		setPixels("dbdf4a4c4e1834d142883249ac5ac30e");
	}
}
public class IconMedalActivePerson : BitmapData{ 
	public IconMedalActivePerson() {
		width = 60;
		height = 60;
		setPixels("38f08e744b3a927d0f314c5ebf363267");
	}
}
public class IconMedalApartments : BitmapData{ 
	public IconMedalApartments() {
		width = 60;
		height = 60;
		setPixels("c4da0e7dc32c66ea0082ade938a8dffd");
	}
}
public class IconMedalCommon : BitmapData{ 
	public IconMedalCommon() {
		width = 60;
		height = 60;
		setPixels("5a0c0fd27d6106be2d6c6404859de65f");
	}
}
public class IconMedalElite : BitmapData{ 
	public IconMedalElite() {
		width = 60;
		height = 60;
		setPixels("cb5e94f6779c1ffe3f161c1b939ff282");
	}
}
public class IconMedalGift : BitmapData{ 
	public IconMedalGift() {
		width = 60;
		height = 60;
		setPixels("b7eb8c0d221ea663f7b666540f736454");
	}
}
public class IconMedalHappyFamily : BitmapData{ 
	public IconMedalHappyFamily() {
		width = 60;
		height = 60;
		setPixels("67293d16c04329308d837a4aecd6d1d1");
	}
}
public class IconMedalHeart : BitmapData{ 
	public IconMedalHeart() {
		width = 60;
		height = 60;
		setPixels("8027b56cb4a07aff40609a6676418a21");
	}
}
public class IconMedalKisses : BitmapData{ 
	public IconMedalKisses() {
		width = 60;
		height = 60;
		setPixels("9c9a5b42245f27f0f78a65b2a78fd667");
	}
}
public class IconMedalPet : BitmapData{ 
	public IconMedalPet() {
		width = 60;
		height = 60;
		setPixels("95d68be631bdbe66c99a0cb705513dde");
	}
}
public class IconMedalPhoto : BitmapData{ 
	public IconMedalPhoto() {
		width = 60;
		height = 60;
		setPixels("03bf19b8156ce2dfd71ad6caabbb9d8a");
	}
}
public class IconMedalPopular : BitmapData{ 
	public IconMedalPopular() {
		width = 60;
		height = 60;
		setPixels("d6d343c43f909cb2250eae8b191a7db9");
	}
}
public class IconMedalRich : BitmapData{ 
	public IconMedalRich() {
		width = 60;
		height = 60;
		setPixels("78d7f381154f7af07f06b66fa08bb0a6");
	}
}
public class IconMedalRichWedding : BitmapData{ 
	public IconMedalRichWedding() {
		width = 60;
		height = 60;
		setPixels("49d7e47999dc0454ac97c3a7566d7c63");
	}
}
public class IconMedalTree : BitmapData{ 
	public IconMedalTree() {
		width = 59;
		height = 59;
		setPixels("3eeec35b907536b5ce4527ba892eeeb9");
	}
}
public class IconModerProfile : BitmapData{ 
	public IconModerProfile() {
		width = 13;
		height = 13;
		setPixels("03bd589aa9ae5197376ef81e6537b842");
	}
}
public class IconPhotoRatesRating : BitmapData{ 
	public IconPhotoRatesRating() {
		width = 19;
		height = 20;
		setPixels("95615fb1f893740fbab83ef3c6d20c6c");
	}
}
public class IconPlayerHouseProfile : BitmapData{ 
	public IconPlayerHouseProfile() {
		width = 15;
		height = 16;
		setPixels("12ede8c3e007d1589f6858f9c0cc429e");
	}
}
public class IconProfileAddFriend : BitmapData{ 
	public IconProfileAddFriend() {
		width = 30;
		height = 21;
		setPixels("529061bbe877b8827481413a4bfcbee5");
	}
}
public class IconProfileChat : BitmapData{ 
	public IconProfileChat() {
		width = 28;
		height = 22;
		setPixels("dc81cb3fdfd2d56a70daa321ec32c575");
	}
}
public class IconProfileHeart : BitmapData{ 
	public IconProfileHeart() {
		width = 19;
		height = 16;
		setPixels("de99606bedf57cc9637674cd1422e5de");
	}
}
public class IconProfileRatingApartament : BitmapData{ 
	public IconProfileRatingApartament() {
		width = 22;
		height = 22;
		setPixels("4aa136185475d4ae1496a00103714271");
	}
}
public class IconProfileRatingMain : BitmapData{ 
	public IconProfileRatingMain() {
		width = 22;
		height = 22;
		setPixels("793b9553f56edbb9737e966df1879ce4");
	}
}
public class IconProfileRatingPet : BitmapData{ 
	public IconProfileRatingPet() {
		width = 22;
		height = 22;
		setPixels("dec4e10803743cb9fdec164f2b18ee42");
	}
}
public class IconProfileRatingTree : BitmapData{ 
	public IconProfileRatingTree() {
		width = 22;
		height = 22;
		setPixels("03b7e3086b6c6b84313d157acc5c86c3");
	}
}
public class IconProfileRemoveFriend : BitmapData{ 
	public IconProfileRemoveFriend() {
		width = 29;
		height = 21;
		setPixels("f36215f96a73804475cc5006125d8c5d");
	}
}
public class IconRatingDaily : BitmapData{ 
	public IconRatingDaily() {
		width = 22;
		height = 22;
		setPixels("21d757034f351988567b06d2507b87e4");
	}
}
public class IconRatingElite : BitmapData{ 
	public IconRatingElite() {
		width = 19;
		height = 21;
		setPixels("f72211f071d39dab26b3dfba48dcb590");
	}
}
public class IconRatingPopular : BitmapData{ 
	public IconRatingPopular() {
		width = 17;
		height = 18;
		setPixels("ce5cbf15cc1af687f2e002739b53b2fb");
	}
}
public class IconRatingRich : BitmapData{ 
	public IconRatingRich() {
		width = 22;
		height = 22;
		setPixels("37708d210e5db9679efe112369ebc50d");
	}
}
public class IconRatingSeparator : BitmapData{ 
	public IconRatingSeparator() {
		width = 1;
		height = 25;
		setPixels("51a441ace6ee34f6598682f4b373e247");
	}
}
public class IconRatingWedding : BitmapData{ 
	public IconRatingWedding() {
		width = 22;
		height = 22;
		setPixels("e59a259d42501afaddc0c13cedba7c5f");
	}
}
public class IconRatingWeddingRich : BitmapData{ 
	public IconRatingWeddingRich() {
		width = 22;
		height = 19;
		setPixels("a2893e4ed6814e5763dfce419a6a7680");
	}
}
public class IconSexMan : BitmapData{ 
	public IconSexMan() {
		width = 20;
		height = 20;
		setPixels("ecd3d7f0b1f7476597d6dd188c2403e9");
	}
}
public class IconSexWoman : BitmapData{ 
	public IconSexWoman() {
		width = 20;
		height = 20;
		setPixels("201e18510fc8c7b6b43e43d5099506fb");
	}
}
public class IconUnIgnoreProfile : BitmapData{ 
	public IconUnIgnoreProfile() {
		width = 21;
		height = 16;
		setPixels("e94691ddf9cb26d9d5025d7758d62e75");
	}
}
public class IconWakeUpProfile : BitmapData{ 
	public IconWakeUpProfile() {
		width = 16;
		height = 18;
		setPixels("d09af6d836862d97949f0581e8c46b38");
	}
}
public class IllIcon : BitmapData{ 
	public IllIcon() {
		width = 36;
		height = 35;
		setPixels("d1f2369ba99c98fb9a28e5b07171f1e8");
	}
}
public class ImageProfileVipMan : BitmapData{ 
	public ImageProfileVipMan() {
		width = 136;
		height = 80;
		setPixels("0cb4d392b095b54139e5466f3d8639e6");
	}
}
public class LikeIcon : BitmapData{ 
	public LikeIcon() {
		width = 20;
		height = 18;
		setPixels("de89fb780d3396e42fa27127d7fd29ed");
	}
}
public class NextAchievementButton : SimpleButton{ 
	public NextAchievementButton() {
		downState = new symbol_12();
		overState = new symbol_13();
		upState = new symbol_14();
		hitTestState = new symbol_15();
	}
}
public class PhotoAlertIcon : BitmapData{ 
	public PhotoAlertIcon() {
		width = 25;
		height = 25;
		setPixels("4c538163a4e6912d78d03bd418161f0e");
	}
}
public class PhotoDeleteIcon : BitmapData{ 
	public PhotoDeleteIcon() {
		width = 25;
		height = 25;
		setPixels("d9b800e1e8242acc275245ebae9db7bf");
	}
}
public class PhotosIcon : BitmapData{ 
	public PhotosIcon() {
		width = 16;
		height = 12;
		setPixels("e9e51cfc7d2eb37f546ce3ec5dcdfd02");
	}
}
public class PrevAchievementButton : SimpleButton{ 
	public PrevAchievementButton() {
		downState = new symbol_16();
		overState = new symbol_17();
		upState = new symbol_18();
		hitTestState = new symbol_19();
	}
}
public class ProfileTabDesign : BitmapData{ 
	public ProfileTabDesign() {
		width = 25;
		height = 17;
		setPixels("81df4a85f5e06baf7483f35315e0732a");
	}
}
public class ProfileTabGifts : BitmapData{ 
	public ProfileTabGifts() {
		width = 14;
		height = 17;
		setPixels("820fb32182e072a6bfa0efcfd636b8ba");
	}
}
public class ProfileTabMenu : BitmapData{ 
	public ProfileTabMenu() {
		width = 17;
		height = 13;
		setPixels("5aa72f4278a95b2037c1fe7ee89ef5f5");
	}
}
public class ProfileTabPets : BitmapData{ 
	public ProfileTabPets() {
		width = 21;
		height = 17;
		setPixels("a6b1f84cf21562036ea7031c7b0e0970");
	}
}
public class ProfileTabPhotos : BitmapData{ 
	public ProfileTabPhotos() {
		width = 18;
		height = 14;
		setPixels("40cf924b9d5fcc7c6fe449dcb08ac4aa");
	}
}
public class ProfileTabTree : BitmapData{ 
	public ProfileTabTree() {
		width = 14;
		height = 20;
		setPixels("70c92327e55ecee3249405af489d8ea2");
	}
}
public class RemoveCommentIcon : BitmapData{ 
	public RemoveCommentIcon() {
		width = 9;
		height = 8;
		setPixels("fbc091965f6d097c499c917e6f92c695");
	}
}
public class UnlikeIcon : BitmapData{ 
	public UnlikeIcon() {
		width = 20;
		height = 18;
		setPixels("e84ce927c25fb0f7e2e56fbbf6ae86ef");
	}
}
public class imageProfileVipWoman : BitmapData{ 
	public imageProfileVipWoman() {
		width = 136;
		height = 80;
		setPixels("c8281c148665ec4c94ed9bb3fd4b39b4");
	}
}
namespace dialogProfile.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("86e4a436cc43dbd5fd7ca564c5766896", 0, 0, 17, 17, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("f3d665483183edf836dd284e5a878787", 0, 0, 17, 17, 1, 1);
		}
	}
	public class symbol_10 : Shape{ 
		public symbol_10() {
			setGraphics("8c09339726e26ea382f52991fa19ddc4", 0, 0, 22, 26, 1, 1);
		}
	}
	public class symbol_11 : MovieClip{ 
		public symbol_11() {
			var i31 = new symbol_10();
			addChild(i31);//0
		}
	}
	public class symbol_12 : Shape{ 
		public symbol_12() {
			setGraphics("68ce3a48a97bb241bc7767b6015c9b31", 0, 0, 34, 69, 1, 1);
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("eca8f50f5a5560a807cbe53f197b74eb", 0, 0, 34, 69, 1, 1);
		}
	}
	public class symbol_14 : Shape{ 
		public symbol_14() {
			setGraphics("ae5cc20d57c293d0f23b7767e3422eca", 0, 0, 34, 69, 1, 1);
		}
	}
	public class symbol_15 : Shape{ 
		public symbol_15() {
			setGraphics("a03e2146196b8d4b1a70cc4cc3f871d4", 0.5, 0, 33.5, 67.75, 1, 1);
		}
	}
	public class symbol_16 : Shape{ 
		public symbol_16() {
			setGraphics("1122e6b6e1cfda692d45156abd6e97fa", 0, 0, 34, 68, 1, 1);
		}
	}
	public class symbol_17 : Shape{ 
		public symbol_17() {
			setGraphics("1cb43eb16ffa338f2262d92fd61007c1", 0, 0, 34, 68, 1, 1);
		}
	}
	public class symbol_18 : Shape{ 
		public symbol_18() {
			setGraphics("08f1d113f5bb7687934ba122c58327f2", 0, 0, 34, 68, 1, 1);
		}
	}
	public class symbol_19 : Shape{ 
		public symbol_19() {
			setGraphics("aa2d2a24689fe1e056d33b289cb86597", 0, 0, 33.5, 67, 1, 1);
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("38d1ba0e6a1961fabc58bc085376c4ff", 0, 0, 17, 17, 1, 1);
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("4095a26d300fdd8aa7bed2c6ce108f93", 0, 0, 14, 14, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("9f6701c3a3ebc90954f65e3fddff6482", -2, -2.5, 18, 19, 1, 1);
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("4be0de3aeafedd581a0191f1f2784ab6", -2.1, -1.8, 17.8, 17.8, 1, 1);
		}
	}
	public class symbol_6 : Shape{ 
		public symbol_6() {
			setGraphics("d1bbbe3d62e9c29bc42813437abc244a", 0, 0, 32, 12, 1, 1);
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("11676549fb73111533ae933884b04664", 0, 0, 32, 12, 1, 1);
		}
	}
	public class symbol_8 : Shape{ 
		public symbol_8() {
			setGraphics("a574e7b1fc9086f6a5d5864ef27e7d96", 0, 0, 20, 21, 1, 1);
		}
	}
	public class symbol_9 : MovieClip{ 
		public symbol_9() {
			var i28 = new symbol_8();
			addChild(i28);//0
		}
	}
}
