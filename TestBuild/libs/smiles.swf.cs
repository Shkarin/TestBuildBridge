using System;
using flash.text;
using flash.display;
using System.Collections.Generic;
using as3;
using RockiePlayer;
using flash.filters;

public class Libsmiles : ResourcesExternalLib{
	public Libsmiles() {
	graphics = new string[] {
	"a6a1cc75a343ae6073011d25cee7f41b",
	"26a5e94d3eb142a09781e4436e1a87ec",
	"81087f8f862117d5607e4402bd0d9b76",
	"8eb47b1b0ce3778d0d6245b8c4f6fceb",
	"e853ab64f08151e9586840f439b314b7",
	"d631babe297b9fbb041d3b44d377479c",
	"ae84baada685103372b46313ff56a5f6",
	"84c031d83b5719a657bf071e8269bf3f",
	"da338fa572faca812cae65bf206c341f",
	"82b65b6ed46ec27f5f362d81c4c2bf4f",
	"1e29dd437c334fae56cad0eb14f6cfc3",
	"8e8266b47f51425b93c421842700fbed",
	"883ac454de866f13aaa55c012986d52b",
	"83f93baa433f794146a2bf91fc912f97",
	"54c2d728fb5347551e0d7800576b1c4a",
	"1fe7d9c497c8697ba8b81fd75141000b",
	"f8c5807175e91f185391d9f8519cf461",
	"a9a37862e45e704fa5b62dfa6cdc343c",
	"1078e1b4c2d3fd46d5cf88ddeb65aec0",
	"0895be6a2183464072b735007b0c7ae4",
	"59a9a2adb5b8079f763492202c9fa6fc",
	"39a72abef59570d868a07c8249f79ca0",
	"bbc9073c8db810e16d28bcf624eb54c0",
	"5a98cfb75e14b0db75f6730aff078810",
	"eb0153baf2a858775de9c5abb0419e1a",
	"4072d09e5dd264c4d7e41cae692671cc",
	"a909ade05e0a02004c1aae65f9013467",
	"be99fc3cb7563ea2f129ac1703e78fa0",
	"bfc43232dcc436908d3cceca60f5c0c6",
	"7b37fa7049a4a238d33a31ac36ab6c42",
	"3ecd972fa0e4d8b78de8b7b3547695b7",
	"c687c629d40623b9d1af9c3d3a582322",
	"f66075ff3e88334cc223e91eece00540",
	"e4aa0287efd0464ab9880dd966c58ce1",
	"19d64eb436ba1296a511991146626209",
	"2ad58428b2e77b65f2a7669fe18a83ca",
	"fe446ee0628bfc7142fe60294e8d2dfa",
	"819b987cb18cb298edb7bd6dae9705e4",
	"74afe983cb6d47759668f03e853193c0",
	"aa1d5490a9d89943dd6f61154779771f",
	"71b301e2f4816bdb1ee824ef9412e8f8",
	"76eae56279ad7d552aa7853fe0cb63f9",
	"5e6bbecc8d3e03c7287aa73bd1cf1710",
	"f81b2a8e5b5a0a1d2082cd904d871ea5",
	"55d03cf362ebc011adfd32a077fe67e4",
	"f35c661d92e8a8392cde30b1c765bcde",
	"edf9acdabfaa84d9c2ed6bc8f466fb0b",
	"bfd96f36e0a81de8da0e6716aff026dd",
	"d02f045d0e32d0e8383f2e18230e3914",
	"6a91a0f93ab3675d1630f48786773db2",
	"9d704c39a78c69d6714c219bbdbc63d9",
	"1c658082e8fc876c3259f13612a66375",
	"0c80b0f3de055d939fc69e5b951b63da",
	"451e0fdb8c0b1fe070a39dc535505807",
	"6f4c8fa1e3d67e89912af57adab63f3e",
	"d4f0c4581887e4d907bc67fcdd009054",
	"418d74600bab7a3cfea67369a099e219",
	"ae61237fe0a41efa9fecf79a6db23d81",
	"9a679c2b28cf0401538a758b0dc5b108",
	"c3e9c9b320037f513b7f105438b420eb",
	"1db0ec09d726bb8d5005854d516528b4",
	"7df3d536ad4e1953895c767ee0996aa9",
	"f6000fae6af598034f54b167305c5998",
	"99dff5bb7e2b822a9ba235994d59f133",
	"31a7458697cb290653d752e00d061423",
	"9ee895736ac1c4b1118abd511d757f14",
	"3e1b1ce21b99ce4fbeda1b83222cc2e3",
	"5a6aca96c516a2c4a82efb33d4182fab",
	"53494d5343ba6f04b7e9e784fc02e24b",
	"3372d3ef582cabed61242dc3c3503285",
	"cc35b2285a67aa1aa365211fae806f05",
	"5adad48a1ebd6813fc86594360a394f1",
	"0d149b20b4351139f796f3cf8d35cd1c",
	"d1384fd1ee1067a3760446ed9066c787",
	"12e8f4ca5f4f741912decb1b68ec80f2",
	"52bedb05374e36e2f5b2e235eacf82e5",
	"44077d769c026dff66dc75683f7bed71",
	"ead4cebb6599e81ccef634def015027f",
	"6c9482863bc514b342ec01de1aec5a49",
	"2ec2a2eec1f2790561373a3d8d21ba70"
	};
	}
}
public class AngelSmile : BitmapData{ 
	public AngelSmile() {
		width = 28;
		height = 22;
		setPixels("71b301e2f4816bdb1ee824ef9412e8f8");
	}
}
public class BabySmile : BitmapData{ 
	public BabySmile() {
		width = 20;
		height = 19;
		setPixels("6c9482863bc514b342ec01de1aec5a49");
	}
}
public class BadSmile : BitmapData{ 
	public BadSmile() {
		width = 25;
		height = 25;
		setPixels("5e6bbecc8d3e03c7287aa73bd1cf1710");
	}
}
public class BerrySmile : BitmapData{ 
	public BerrySmile() {
		width = 20;
		height = 22;
		setPixels("0895be6a2183464072b735007b0c7ae4");
	}
}
public class BirthdaySmile : BitmapData{ 
	public BirthdaySmile() {
		width = 22;
		height = 24;
		setPixels("da338fa572faca812cae65bf206c341f");
	}
}
public class BlackEyeSmile : BitmapData{ 
	public BlackEyeSmile() {
		width = 20;
		height = 19;
		setPixels("8eb47b1b0ce3778d0d6245b8c4f6fceb");
	}
}
public class BlinkingSmile : BitmapData{ 
	public BlinkingSmile() {
		width = 20;
		height = 19;
		setPixels("d02f045d0e32d0e8383f2e18230e3914");
	}
}
public class BombSmile : BitmapData{ 
	public BombSmile() {
		width = 27;
		height = 23;
		setPixels("7b37fa7049a4a238d33a31ac36ab6c42");
	}
}
public class BrockenHeartSmile : BitmapData{ 
	public BrockenHeartSmile() {
		width = 22;
		height = 21;
		setPixels("5adad48a1ebd6813fc86594360a394f1");
	}
}
public class BurningHeartSmile : BitmapData{ 
	public BurningHeartSmile() {
		width = 22;
		height = 25;
		setPixels("883ac454de866f13aaa55c012986d52b");
	}
}
public class CelebrationSmile : BitmapData{ 
	public CelebrationSmile() {
		width = 23;
		height = 23;
		setPixels("f35c661d92e8a8392cde30b1c765bcde");
	}
}
public class CoffeeSmile : BitmapData{ 
	public CoffeeSmile() {
		width = 25;
		height = 23;
		setPixels("0c80b0f3de055d939fc69e5b951b63da");
	}
}
public class CoolSmile : BitmapData{ 
	public CoolSmile() {
		width = 20;
		height = 19;
		setPixels("c687c629d40623b9d1af9c3d3a582322");
	}
}
public class CrySmile : BitmapData{ 
	public CrySmile() {
		width = 20;
		height = 19;
		setPixels("1c658082e8fc876c3259f13612a66375");
	}
}
public class DavaySmile : BitmapData{ 
	public DavaySmile() {
		width = 26;
		height = 21;
		setPixels("fe446ee0628bfc7142fe60294e8d2dfa");
	}
}
public class Dead2Smile : BitmapData{ 
	public Dead2Smile() {
		width = 20;
		height = 20;
		setPixels("418d74600bab7a3cfea67369a099e219");
	}
}
public class DeadSmile : BitmapData{ 
	public DeadSmile() {
		width = 20;
		height = 19;
		setPixels("c3e9c9b320037f513b7f105438b420eb");
	}
}
public class DevilSmile : BitmapData{ 
	public DevilSmile() {
		width = 20;
		height = 20;
		setPixels("9ee895736ac1c4b1118abd511d757f14");
	}
}
public class ExuseSmile : BitmapData{ 
	public ExuseSmile() {
		width = 20;
		height = 19;
		setPixels("7df3d536ad4e1953895c767ee0996aa9");
	}
}
public class FascinatedSmile : BitmapData{ 
	public FascinatedSmile() {
		width = 25;
		height = 25;
		setPixels("bfd96f36e0a81de8da0e6716aff026dd");
	}
}
public class FrightSmile : BitmapData{ 
	public FrightSmile() {
		width = 25;
		height = 25;
		setPixels("0d149b20b4351139f796f3cf8d35cd1c");
	}
}
public class GiggleSmile : BitmapData{ 
	public GiggleSmile() {
		width = 21;
		height = 22;
		setPixels("4072d09e5dd264c4d7e41cae692671cc");
	}
}
public class GrossSmile : BitmapData{ 
	public GrossSmile() {
		width = 21;
		height = 19;
		setPixels("12e8f4ca5f4f741912decb1b68ec80f2");
	}
}
public class HeartSmile : BitmapData{ 
	public HeartSmile() {
		width = 23;
		height = 21;
		setPixels("d1384fd1ee1067a3760446ed9066c787");
	}
}
public class Horror2Smile : BitmapData{ 
	public Horror2Smile() {
		width = 20;
		height = 20;
		setPixels("451e0fdb8c0b1fe070a39dc535505807");
	}
}
public class HorrorSmile : BitmapData{ 
	public HorrorSmile() {
		width = 20;
		height = 20;
		setPixels("59a9a2adb5b8079f763492202c9fa6fc");
	}
}
public class HugGirlSmile : BitmapData{ 
	public HugGirlSmile() {
		width = 25;
		height = 22;
		setPixels("1e29dd437c334fae56cad0eb14f6cfc3");
	}
}
public class HushSmile : BitmapData{ 
	public HushSmile() {
		width = 20;
		height = 23;
		setPixels("81087f8f862117d5607e4402bd0d9b76");
	}
}
public class IllSmile : BitmapData{ 
	public IllSmile() {
		width = 25;
		height = 25;
		setPixels("44077d769c026dff66dc75683f7bed71");
	}
}
public class InLoveSmile : BitmapData{ 
	public InLoveSmile() {
		width = 28;
		height = 22;
		setPixels("99dff5bb7e2b822a9ba235994d59f133");
	}
}
public class KingSmile : BitmapData{ 
	public KingSmile() {
		width = 21;
		height = 24;
		setPixels("74afe983cb6d47759668f03e853193c0");
	}
}
public class KissGirlSmile : BitmapData{ 
	public KissGirlSmile() {
		width = 24;
		height = 17;
		setPixels("f8c5807175e91f185391d9f8519cf461");
	}
}
public class KissSmile : BitmapData{ 
	public KissSmile() {
		width = 21;
		height = 23;
		setPixels("83f93baa433f794146a2bf91fc912f97");
	}
}
public class KissedSmile : BitmapData{ 
	public KissedSmile() {
		width = 26;
		height = 22;
		setPixels("3ecd972fa0e4d8b78de8b7b3547695b7");
	}
}
public class LauthingSmile : BitmapData{ 
	public LauthingSmile() {
		width = 20;
		height = 20;
		setPixels("52bedb05374e36e2f5b2e235eacf82e5");
	}
}
public class LolSmile : BitmapData{ 
	public LolSmile() {
		width = 20;
		height = 19;
		setPixels("3372d3ef582cabed61242dc3c3503285");
	}
}
public class Mad2Smile : BitmapData{ 
	public Mad2Smile() {
		width = 25;
		height = 25;
		setPixels("a909ade05e0a02004c1aae65f9013467");
	}
}
public class MadSmile : BitmapData{ 
	public MadSmile() {
		width = 20;
		height = 20;
		setPixels("eb0153baf2a858775de9c5abb0419e1a");
	}
}
public class MusicSmile : BitmapData{ 
	public MusicSmile() {
		width = 23;
		height = 22;
		setPixels("bbc9073c8db810e16d28bcf624eb54c0");
	}
}
public class NotHearSmile : BitmapData{ 
	public NotHearSmile() {
		width = 30;
		height = 19;
		setPixels("e853ab64f08151e9586840f439b314b7");
	}
}
public class PalmfaceSmile : BitmapData{ 
	public PalmfaceSmile() {
		width = 20;
		height = 19;
		setPixels("ead4cebb6599e81ccef634def015027f");
	}
}
public class PokerfaceSmile : BitmapData{ 
	public PokerfaceSmile() {
		width = 20;
		height = 19;
		setPixels("f81b2a8e5b5a0a1d2082cd904d871ea5");
	}
}
public class PrideSmile : BitmapData{ 
	public PrideSmile() {
		width = 20;
		height = 20;
		setPixels("819b987cb18cb298edb7bd6dae9705e4");
	}
}
public class PrincessSmile : BitmapData{ 
	public PrincessSmile() {
		width = 27;
		height = 25;
		setPixels("2ad58428b2e77b65f2a7669fe18a83ca");
	}
}
public class ProudSmile : BitmapData{ 
	public ProudSmile() {
		width = 20;
		height = 20;
		setPixels("a9a37862e45e704fa5b62dfa6cdc343c");
	}
}
public class PussySmile : BitmapData{ 
	public PussySmile() {
		width = 22;
		height = 20;
		setPixels("ae84baada685103372b46313ff56a5f6");
	}
}
public class QueerlySmile : BitmapData{ 
	public QueerlySmile() {
		width = 25;
		height = 25;
		setPixels("d4f0c4581887e4d907bc67fcdd009054");
	}
}
public class RastaSmile : BitmapData{ 
	public RastaSmile() {
		width = 24;
		height = 24;
		setPixels("6a91a0f93ab3675d1630f48786773db2");
	}
}
public class RoseSmile : BitmapData{ 
	public RoseSmile() {
		width = 28;
		height = 19;
		setPixels("6f4c8fa1e3d67e89912af57adab63f3e");
	}
}
public class SadSmile : BitmapData{ 
	public SadSmile() {
		width = 20;
		height = 19;
		setPixels("19d64eb436ba1296a511991146626209");
	}
}
public class ScreamingSmile : BitmapData{ 
	public ScreamingSmile() {
		width = 23;
		height = 21;
		setPixels("54c2d728fb5347551e0d7800576b1c4a");
	}
}
public class ScullSmile : BitmapData{ 
	public ScullSmile() {
		width = 20;
		height = 20;
		setPixels("31a7458697cb290653d752e00d061423");
	}
}
public class ShutUpSmile : BitmapData{ 
	public ShutUpSmile() {
		width = 20;
		height = 19;
		setPixels("5a6aca96c516a2c4a82efb33d4182fab");
	}
}
public class ShySmile : BitmapData{ 
	public ShySmile() {
		width = 20;
		height = 19;
		setPixels("2ec2a2eec1f2790561373a3d8d21ba70");
	}
}
public class SingerSmile : BitmapData{ 
	public SingerSmile() {
		width = 23;
		height = 24;
		setPixels("1db0ec09d726bb8d5005854d516528b4");
	}
}
public class SleepingSmile : BitmapData{ 
	public SleepingSmile() {
		width = 25;
		height = 23;
		setPixels("aa1d5490a9d89943dd6f61154779771f");
	}
}
public class SmartSmile : BitmapData{ 
	public SmartSmile() {
		width = 25;
		height = 19;
		setPixels("bfc43232dcc436908d3cceca60f5c0c6");
	}
}
public class Smile10Img : BitmapData{ 
	public Smile10Img() {
		width = 28;
		height = 22;
		setPixels("d631babe297b9fbb041d3b44d377479c");
	}
}
public class Smile1Img : BitmapData{ 
	public Smile1Img() {
		width = 28;
		height = 22;
		setPixels("8e8266b47f51425b93c421842700fbed");
	}
}
public class Smile2Img : BitmapData{ 
	public Smile2Img() {
		width = 28;
		height = 22;
		setPixels("9a679c2b28cf0401538a758b0dc5b108");
	}
}
public class Smile3Img : BitmapData{ 
	public Smile3Img() {
		width = 28;
		height = 22;
		setPixels("edf9acdabfaa84d9c2ed6bc8f466fb0b");
	}
}
public class Smile4Img : BitmapData{ 
	public Smile4Img() {
		width = 28;
		height = 22;
		setPixels("5a98cfb75e14b0db75f6730aff078810");
	}
}
public class Smile5Img : BitmapData{ 
	public Smile5Img() {
		width = 28;
		height = 22;
		setPixels("1078e1b4c2d3fd46d5cf88ddeb65aec0");
	}
}
public class Smile6Img : BitmapData{ 
	public Smile6Img() {
		width = 28;
		height = 22;
		setPixels("39a72abef59570d868a07c8249f79ca0");
	}
}
public class Smile7Img : BitmapData{ 
	public Smile7Img() {
		width = 28;
		height = 22;
		setPixels("f6000fae6af598034f54b167305c5998");
	}
}
public class Smile8Img : BitmapData{ 
	public Smile8Img() {
		width = 28;
		height = 22;
		setPixels("ae61237fe0a41efa9fecf79a6db23d81");
	}
}
public class Smile9Img : BitmapData{ 
	public Smile9Img() {
		width = 28;
		height = 22;
		setPixels("f66075ff3e88334cc223e91eece00540");
	}
}
public class SmileImage : BitmapData{ 
	public SmileImage() {
		width = 20;
		height = 19;
		setPixels("e4aa0287efd0464ab9880dd966c58ce1");
	}
}
public class StopSmile : BitmapData{ 
	public StopSmile() {
		width = 28;
		height = 23;
		setPixels("a6a1cc75a343ae6073011d25cee7f41b");
	}
}
public class StraightSmile : BitmapData{ 
	public StraightSmile() {
		width = 25;
		height = 19;
		setPixels("53494d5343ba6f04b7e9e784fc02e24b");
	}
}
public class StupidGirlSmile : BitmapData{ 
	public StupidGirlSmile() {
		width = 27;
		height = 22;
		setPixels("3e1b1ce21b99ce4fbeda1b83222cc2e3");
	}
}
public class SuicideSmile : BitmapData{ 
	public SuicideSmile() {
		width = 27;
		height = 19;
		setPixels("55d03cf362ebc011adfd32a077fe67e4");
	}
}
public class SunnySmile : BitmapData{ 
	public SunnySmile() {
		width = 24;
		height = 25;
		setPixels("be99fc3cb7563ea2f129ac1703e78fa0");
	}
}
public class SurprisedSmile : BitmapData{ 
	public SurprisedSmile() {
		width = 26;
		height = 23;
		setPixels("84c031d83b5719a657bf071e8269bf3f");
	}
}
public class TerribleSmile : BitmapData{ 
	public TerribleSmile() {
		width = 21;
		height = 23;
		setPixels("cc35b2285a67aa1aa365211fae806f05");
	}
}
public class ThumbsUpSmile : BitmapData{ 
	public ThumbsUpSmile() {
		width = 21;
		height = 22;
		setPixels("82b65b6ed46ec27f5f362d81c4c2bf4f");
	}
}
public class TongueOutSmile : BitmapData{ 
	public TongueOutSmile() {
		width = 20;
		height = 19;
		setPixels("9d704c39a78c69d6714c219bbdbc63d9");
	}
}
public class WallSmile : BitmapData{ 
	public WallSmile() {
		width = 27;
		height = 24;
		setPixels("1fe7d9c497c8697ba8b81fd75141000b");
	}
}
public class WarriorSmile : BitmapData{ 
	public WarriorSmile() {
		width = 25;
		height = 22;
		setPixels("26a5e94d3eb142a09781e4436e1a87ec");
	}
}
public class WinterSmile : BitmapData{ 
	public WinterSmile() {
		width = 19;
		height = 25;
		setPixels("76eae56279ad7d552aa7853fe0cb63f9");
	}
}
