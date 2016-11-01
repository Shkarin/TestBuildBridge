using System;
using flash.text;
using flash.events;
using flash.display;
using System.Collections.Generic;
using screens.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libscreens : ResourcesExternalLib{
	public Libscreens() {
	vectors = new string[] {
	"15e3f9ffa80cbd0d19f74cc31156e692",
	"8737e82281f977cf2b9748eadc202359",
	"c4e286baf0c6c438338cabc12f2b246c",
	"a71aa60df7b2eae68aa6d4d44e22f580",
	"0ff09785ded94a65013f6d19005c8180",
	"949f12b95c950a98686571ea0179fb79",
	"3eb944bf81fab1b0831f9883bd9dd765",
	"c7041e5949250d23640a561fe37025cb",
	"3e03da9f6b209718a6717c412eaa6cff",
	"8e8fde2b6fb2dd56944cc95d624cae44",
	"208f2218ee2e4e5e11a5b887c5548b43",
	"9be09cbf6c292bece59392942ebefe6c",
	"169e4ac6df3b414086cbc6b15c6294e7",
	"54958f36662f991ddfffabec5c4f5b7d",
	"6e4997d7574b5d5cf5a2be4dd3e4b14a",
	"1afdc8eaf1e9972f8fec32a67415e19a",
	"a0fff9500423e8f8b8d031eba7ff7838",
	"658c7a671a7c665020080a0df97fca81",
	"978993bf49fc42465cd46b55ea0b988a",
	"71d92e9d66744442095b9819f37e3b69",
	"079b8b5c153bfce2ac1c31bc259cfab9",
	"8b232a7d68aea52d17d1061abf7b7f0b",
	"14d1ca6edc8eb613fec4a97af556f70d",
	"d71acff19b7e366c64a3b49d77b98725",
	"20f4569157017ee941b82a05343cbaad",
	"10ecf46f4a176caa5c7d95fd4c13cc31",
	"0d2ba93921dc261948a8ca0397d35792",
	"c9e93500a751220fb3b23934b41a2384",
	"2415786c8dcf42abf4c7ec02827e7759",
	"57fed21c68f241741bfcdb20b4165432",
	"5164e937373e8a657870dd81af01e845",
	"6b60a467fd24d4d6061e7e921ea8a83b",
	"e1566c00b1e5106ef9a4dc69c5b6af33",
	"500597087a0b04508a6a1927cd1fa098",
	"98e39af7fa34acb0ba5504cf45106e0e",
	"c8d83e06fd4b8180622b31255ff2f765",
	"f1c9c7f6231f59d8bd8a073d9bf98fc7",
	"66dc2dc894480a921250fdf2cf6ba5a0",
	"1867888913d97453ca6ba58b08e08540",
	"7f0dac78558967e054266d030b5a8a06"
	};
	graphics = new string[] {
	"e1d9777acdf8e5ed51aff24bd0ff12f6",
	"ea411018cc1d47f983b8907bc4d2a270",
	"c13dd74f5786aa9ebd96450b010d4a40",
	"daca5bf2845c0eea3feec8a037e2acd4",
	"4cc869813c5ebf207fd384543654a3f3",
	"1d6116e2f96f850b2a1abbcc1e62df52",
	"f393f33e10300e6ed57c10aa9713e96d",
	"357ec5601ad20bdafadc7526df8f4ae0",
	"6bae66408df6bfc45dac3574185e33ae",
	"5b6700ed2fa2cbd741577a4eaacdaa7b",
	"d64404fa29e49be8d66f2357daeee1b5",
	"b86bcfafff06372d5761eb51793f7cc6",
	"6a682165714c3ad191fd4ee032f1f654",
	"753b7d0debf6270bffacd57cc3c0dee0",
	"78cac915bc0872f1abb422c456444d4b",
	"cbb2ee001a9768c22b9b76d1eb0e4e2c",
	"2aef43c11b03fb74691dc437a479a9e6",
	"48ae59e33a92ca4d3c9c93699fd28435",
	"25c36ca634dfb4e130cfcf50f763a142",
	"de3536f24c81a28e63ec6b49d4d7001e",
	"d907f18e62aef6fbe46ac23c957b9574",
	"7eef4e8fcdb849b7c3cc3b2ab37e3def",
	"9b46af0df5a2f1b2d1571fc465db358a",
	"a3a97ef61ac0749158dd67f3eb5d30ec",
	"bf363901e4cedf376a53c9199b94ef9b",
	"a4e15a1c4bb25d285336dba7d0e278cc",
	"65a6357d45d57c81d05b6dc7ebb57d12",
	"19c07cbe233a1f7dbbd13967ab30ed8e",
	"d2130308fd661a355df6261d1f8c71bb",
	"05ea15ff1e2efa441b6d02ea6f13de83",
	"0da3fbf2ffb99990e60637cc5df18259",
	"7849d4c986f1a249d642f0e7308e843e",
	"5a503ffeebda0f3069ffc0c5594bcf3a",
	"3f8c705576ba880a7d77134bf480b8b2",
	"25e101c89a2deb095b5a3e287a14aa4b",
	"d418270ae2aac6fc65716cee7a902c93",
	"2f552c2af27c23dfa992b22cb57e5ff5",
	"d535fba5b378b1285358f965f54bda7a",
	"050fc49f7d9701b3810fa34a00af8f06",
	"ed3c44145d85cb645cf04a4e09095e7b",
	"56a609ed84c55f91881297a5ed4705c4",
	"c7e7f4e3b2a9f4d31e5c63abbc0a33c2",
	"0d8ac00811d945fc76fc7abc4505ba65",
	"35dfadb3596815c67b5a8c742c5468a7",
	"31e2f7b1d9fe17751f4f2826e38cc045",
	"0f1c57b29b801ddda2da8928109c2ca1",
	"ad2bcdbed6e676ae49381b78a9c976e4",
	"cf1c852cb8bb68b2c4b6506d0f47d30e",
	"5dbdfc6c59433cc0c38673b2eda68153",
	"78ff3cc60e32c4edcc9d63fd13874385",
	"09606850bbea405b03d89c26c49f29ad",
	"c57401415e081d4ac7562a06d37e8b74",
	"d19a0e75a20dc0a2b4a2f61c2b0ec032",
	"77cc4471e884bad59a8d491de2d046eb",
	"8f001db81ac0b6850c38d479a5314903",
	"b9439a5e676c3a040b7807ee5a4f0008",
	"3c497c180ef9c50e64844a625b0a68a0",
	"15bfce9b64c13b91e78a6be4b298a874",
	"8c86a78b713a13b96d33893936a26057",
	"db69ba03bfffc6387ceb8594ddfb0ca6",
	"8e606151ce36e86fe1e32f896ea9de20",
	"22802b26e4abee53d4e601828d0bf351",
	"7a28e8cd3d71c4fc4c4a3e39bdb57b5b",
	"bd7619942d53e75b94f14bf4ffd4cd9f",
	"6c8ab1e8ce46103bf6694a8169a3804c",
	"6fa1110af312dfb6719608bc93388c97",
	"0f75b11ecb46b2ef54d383b8144b93a4",
	"af534fcebd5613f68b6762df4f5682a8",
	"6fb7bf53658249b8b71a63759d6ceed0",
	"1e0954d1b1cdca6c5821bca2d3e11e06",
	"d3905b3f80c7c7a32c30e7810a621999",
	"21e0f81246e32c83ac29733ade7a0ed0",
	"c01380b5bd535d14e0a03808c5d35848",
	"92e48b9482218b2fd208d1bb901f6043",
	"57d9ebe944d9716d9b001edba4ed7882",
	"5424b134d6cf375a62a902b330b45da6",
	"79cc62985fd1372db9561fa7cb56055e",
	"16838a06de69cebb7cc4b139b6a899d4",
	"8b481d5d63ec21c744a9bf709732d20c",
	"7519921d276a41b5bf3ea9ae9625210a",
	"7715f7e6902e68235b3f5359f67a5d38",
	"b537c7abc41d7f5f8612195ae8d05dac",
	"83056e6f66784939a57e97b6afdf2dfb",
	"2ca5fa3215289170e53ee1cfe57e5606",
	"5a0df454e547dd7d7c4c6a84939b1e5e",
	"143a16d8964ee4fc3126b94779048cfc",
	"65e74cee631bf58b17b33a274c58de1e"
	};
	}
}
public class ArrowNoLeft : BitmapData{ 
	public ArrowNoLeft() {
		width = 153;
		height = 48;
		setPixels("de3536f24c81a28e63ec6b49d4d7001e");
	}
}
public class ArrowNoRight : BitmapData{ 
	public ArrowNoRight() {
		width = 153;
		height = 48;
		setPixels("15bfce9b64c13b91e78a6be4b298a874");
	}
}
public class ArrowYesLeft : BitmapData{ 
	public ArrowYesLeft() {
		width = 153;
		height = 48;
		setPixels("6fa1110af312dfb6719608bc93388c97");
	}
}
public class ArrowYesRight : BitmapData{ 
	public ArrowYesRight() {
		width = 153;
		height = 48;
		setPixels("5424b134d6cf375a62a902b330b45da6");
	}
}
public class ArrowsBottle : BitmapData{ 
	public ArrowsBottle() {
		width = 84;
		height = 95;
		setPixels("e1d9777acdf8e5ed51aff24bd0ff12f6");
	}
}
public class BackgroundBase : BitmapData{ 
	public BackgroundBase() {
		width = 900;
		height = 690;
		setPixels("57d9ebe944d9716d9b001edba4ed7882");
	}
}
public class BackgroundBaseRU : BitmapData{ 
	public BackgroundBaseRU() {
		width = 900;
		height = 690;
		setPixels("7849d4c986f1a249d642f0e7308e843e");
	}
}
public class BackgroundLeaderRates : BitmapData{ 
	public BackgroundLeaderRates() {
		width = 170;
		height = 231;
		setPixels("5dbdfc6c59433cc0c38673b2eda68153");
	}
}
public class BanImage : BitmapData{ 
	public BanImage() {
		width = 760;
		height = 522;
		setPixels("143a16d8964ee4fc3126b94779048cfc");
	}
}
public class BottleEaster : SimpleButton{ 
	public BottleEaster() {
		downState = new symbol_0();
		overState = new symbol_0();
		upState = new symbol_1();
		hitTestState = new symbol_2();
	}
}
public class BottleSimple : SimpleButton{ 
	public BottleSimple() {
		downState = new symbol_3();
		overState = new symbol_3();
		upState = new symbol_4();
		hitTestState = new symbol_5();
	}
}
public class ButtonChangeDesign : SimpleButton{ 
	public ButtonChangeDesign() {
		downState = new symbol_6();
		overState = new symbol_6();
		upState = new symbol_7();
		hitTestState = new symbol_8();
	}
}
public class ButtonChangeRoom : SimpleButton{ 
	public ButtonChangeRoom() {
		downState = new symbol_9();
		overState = new symbol_9();
		upState = new symbol_10();
		hitTestState = new symbol_8();
	}
}
public class ButtonExitRoom : SimpleButton{ 
	public ButtonExitRoom() {
		downState = new symbol_11();
		overState = new symbol_11();
		upState = new symbol_12();
		hitTestState = new symbol_8();
	}
}
public class ButtonHelpRoom : SimpleButton{ 
	public ButtonHelpRoom() {
		downState = new symbol_13();
		overState = new symbol_13();
		upState = new symbol_14();
		hitTestState = new symbol_8();
	}
}
public class ButtonInviteRoom : SimpleButton{ 
	public ButtonInviteRoom() {
		downState = new symbol_15();
		overState = new symbol_15();
		upState = new symbol_16();
		hitTestState = new symbol_8();
	}
}
public class ButtonPhotoNext : SimpleButton{ 
	public ButtonPhotoNext() {
		downState = new symbol_17();
		overState = new symbol_17();
		upState = new symbol_18();
		hitTestState = new symbol_19();
	}
}
public class ButtonPhotoPrevious : SimpleButton{ 
	public ButtonPhotoPrevious() {
		downState = new symbol_20();
		overState = new symbol_20();
		upState = new symbol_21();
		hitTestState = new symbol_19();
	}
}
public class ButtonPrivateRoom : SimpleButton{ 
	public ButtonPrivateRoom() {
		downState = new symbol_22();
		overState = new symbol_22();
		upState = new symbol_23();
		hitTestState = new symbol_8();
	}
}
public class ChatMenuIcon : BitmapData{ 
	public ChatMenuIcon() {
		width = 20;
		height = 25;
		setPixels("050fc49f7d9701b3810fa34a00af8f06");
	}
}
public class ClockIconKiss : BitmapData{ 
	public ClockIconKiss() {
		width = 18;
		height = 18;
		setPixels("25c36ca634dfb4e130cfcf50f763a142");
	}
}
public class DisconnectImage : BitmapData{ 
	public DisconnectImage() {
		width = 900;
		height = 374;
		setPixels("0da3fbf2ffb99990e60637cc5df18259");
	}
}
public class GiftProgressBar : MovieClip{ 
	public GiftProgressBar() {
		var i78 = new symbol_25();
		addChild(i78);//0
		FrameInfo f;
		var l= new Frames(60);
		f = l.Add();//0
		f.Add(i78);
		f += () => {
			i78.x = 0;
			i78.scaleX = 1;
			i78.y = 0;
			i78.scaleY = 1;
			i78.rotation = 0;
			i78.alpha = 1;
			i78.filters = null;
			i78.visible = true;
		};
		f = l.Add();//1
		f.Add(i78);
		f += () => {
			i78.rotation = 352;
		};
		f = l.Add();//2
		f.Add(i78);
		f += () => {
			i78.rotation = 347;
		};
		f = l.Add();//3
		f.Add(i78);
		f += () => {
			i78.rotation = 344;
		};
		f = l.Add();//4
		f.Add(i78);
		f += () => {
			i78.rotation = 343;
		};
		f = l.Add();//5
		f.Add(i78);
		f += () => {
			i78.rotation = 344;
		};
		f = l.Add();//6
		f.Add(i78);
		f += () => {
			i78.rotation = 346;
		};
		f = l.Add();//7
		f.Add(i78);
		f += () => {
			i78.rotation = 349;
		};
		f = l.Add();//8
		f.Add(i78);
		f += () => {
			i78.rotation = 354;
		};
		f = l.Add();//9
		f.Add(i78);
		f = l.Add();//10
		f.Add(i78);
		f += () => {
			i78.rotation = 6;
		};
		f = l.Add();//11
		f.Add(i78);
		f += () => {
			i78.rotation = 11;
		};
		f = l.Add();//12
		f.Add(i78);
		f += () => {
			i78.rotation = 14;
		};
		f = l.Add();//13
		f.Add(i78);
		f += () => {
			i78.rotation = 17;
		};
		f = l.Add();//14
		f.Add(i78);
		f = l.Add();//15
		f.Add(i78);
		f = l.Add();//16
		f.Add(i78);
		f += () => {
			i78.rotation = 14;
		};
		f = l.Add();//17
		f.Add(i78);
		f += () => {
			i78.rotation = 11;
		};
		f = l.Add();//18
		f.Add(i78);
		f += () => {
			i78.rotation = 6;
		};
		f = l.Add();//19
		f.Add(i78);
		f = l.Add();//20
		f.Add(i78);
		f += () => {
			i78.rotation = 354;
		};
		f = l.Add();//21
		f.Add(i78);
		f += () => {
			i78.rotation = 349;
		};
		f = l.Add();//22
		f.Add(i78);
		f += () => {
			i78.rotation = 346;
		};
		f = l.Add();//23
		f.Add(i78);
		f += () => {
			i78.rotation = 344;
		};
		f = l.Add();//24
		f.Add(i78);
		f += () => {
			i78.rotation = 343;
		};
		f = l.Add();//25
		f.Add(i78);
		f += () => {
			i78.rotation = 344;
		};
		f = l.Add();//26
		f.Add(i78);
		f += () => {
			i78.rotation = 346;
		};
		f = l.Add();//27
		f.Add(i78);
		f += () => {
			i78.rotation = 349;
		};
		f = l.Add();//28
		f.Add(i78);
		f += () => {
			i78.rotation = 354;
		};
		f = l.Add();//29
		f.Add(i78);
		f = l.Add();//30
		f.Add(i78);
		f += () => {
			i78.rotation = 6;
		};
		f = l.Add();//31
		f.Add(i78);
		f += () => {
			i78.rotation = 11;
		};
		f = l.Add();//32
		f.Add(i78);
		f += () => {
			i78.rotation = 14;
		};
		f = l.Add();//33
		f.Add(i78);
		f += () => {
			i78.rotation = 17;
		};
		f = l.Add();//34
		f.Add(i78);
		f = l.Add();//35
		f.Add(i78);
		f = l.Add();//36
		f.Add(i78);
		f += () => {
			i78.rotation = 14;
		};
		f = l.Add();//37
		f.Add(i78);
		f += () => {
			i78.rotation = 11;
		};
		f = l.Add();//38
		f.Add(i78);
		f += () => {
			i78.rotation = 6;
		};
		f = l.Add();//39
		f.Add(i78);
		f = l.Add();//40
		f.Add(i78);
		f = l.Add();//41
		f.Add(i78);
		f = l.Add();//42
		f.Add(i78);
		f = l.Add();//43
		f.Add(i78);
		f = l.Add();//44
		f.Add(i78);
		f = l.Add();//45
		f.Add(i78);
		f = l.Add();//46
		f.Add(i78);
		f = l.Add();//47
		f.Add(i78);
		f = l.Add();//48
		f.Add(i78);
		f = l.Add();//49
		f.Add(i78);
		f = l.Add();//50
		f.Add(i78);
		f = l.Add();//51
		f.Add(i78);
		f = l.Add();//52
		f.Add(i78);
		f = l.Add();//53
		f.Add(i78);
		f = l.Add();//54
		f.Add(i78);
		f = l.Add();//55
		f.Add(i78);
		f = l.Add();//56
		f.Add(i78);
		f = l.Add();//57
		f.Add(i78);
		f = l.Add();//58
		f.Add(i78);
		f = l.Add();//59
		f.Add(i78);
		setFrames(l);
	}
}
public class GiftProgressBarMafia : MovieClip{ 
	public GiftProgressBarMafia() {
		var i81 = new symbol_27();
		addChild(i81);//0
		FrameInfo f;
		var l= new Frames(60);
		f = l.Add();//0
		f.Add(i81);
		f += () => {
			i81.x = 0;
			i81.scaleX = 1;
			i81.y = 0;
			i81.scaleY = 1;
			i81.rotation = 0;
			i81.alpha = 1;
			i81.filters = null;
			i81.visible = true;
		};
		f = l.Add();//1
		f.Add(i81);
		f += () => {
			i81.rotation = 352;
		};
		f = l.Add();//2
		f.Add(i81);
		f += () => {
			i81.rotation = 347;
		};
		f = l.Add();//3
		f.Add(i81);
		f += () => {
			i81.rotation = 344;
		};
		f = l.Add();//4
		f.Add(i81);
		f += () => {
			i81.rotation = 343;
		};
		f = l.Add();//5
		f.Add(i81);
		f += () => {
			i81.rotation = 344;
		};
		f = l.Add();//6
		f.Add(i81);
		f += () => {
			i81.rotation = 346;
		};
		f = l.Add();//7
		f.Add(i81);
		f += () => {
			i81.rotation = 349;
		};
		f = l.Add();//8
		f.Add(i81);
		f += () => {
			i81.rotation = 354;
		};
		f = l.Add();//9
		f.Add(i81);
		f = l.Add();//10
		f.Add(i81);
		f += () => {
			i81.rotation = 6;
		};
		f = l.Add();//11
		f.Add(i81);
		f += () => {
			i81.rotation = 11;
		};
		f = l.Add();//12
		f.Add(i81);
		f += () => {
			i81.rotation = 14;
		};
		f = l.Add();//13
		f.Add(i81);
		f += () => {
			i81.rotation = 17;
		};
		f = l.Add();//14
		f.Add(i81);
		f = l.Add();//15
		f.Add(i81);
		f = l.Add();//16
		f.Add(i81);
		f += () => {
			i81.rotation = 14;
		};
		f = l.Add();//17
		f.Add(i81);
		f += () => {
			i81.rotation = 11;
		};
		f = l.Add();//18
		f.Add(i81);
		f += () => {
			i81.rotation = 6;
		};
		f = l.Add();//19
		f.Add(i81);
		f = l.Add();//20
		f.Add(i81);
		f += () => {
			i81.rotation = 354;
		};
		f = l.Add();//21
		f.Add(i81);
		f += () => {
			i81.rotation = 349;
		};
		f = l.Add();//22
		f.Add(i81);
		f += () => {
			i81.rotation = 346;
		};
		f = l.Add();//23
		f.Add(i81);
		f += () => {
			i81.rotation = 344;
		};
		f = l.Add();//24
		f.Add(i81);
		f += () => {
			i81.rotation = 343;
		};
		f = l.Add();//25
		f.Add(i81);
		f += () => {
			i81.rotation = 344;
		};
		f = l.Add();//26
		f.Add(i81);
		f += () => {
			i81.rotation = 346;
		};
		f = l.Add();//27
		f.Add(i81);
		f += () => {
			i81.rotation = 349;
		};
		f = l.Add();//28
		f.Add(i81);
		f += () => {
			i81.rotation = 354;
		};
		f = l.Add();//29
		f.Add(i81);
		f = l.Add();//30
		f.Add(i81);
		f += () => {
			i81.rotation = 6;
		};
		f = l.Add();//31
		f.Add(i81);
		f += () => {
			i81.rotation = 11;
		};
		f = l.Add();//32
		f.Add(i81);
		f += () => {
			i81.rotation = 14;
		};
		f = l.Add();//33
		f.Add(i81);
		f += () => {
			i81.rotation = 17;
		};
		f = l.Add();//34
		f.Add(i81);
		f = l.Add();//35
		f.Add(i81);
		f = l.Add();//36
		f.Add(i81);
		f += () => {
			i81.rotation = 14;
		};
		f = l.Add();//37
		f.Add(i81);
		f += () => {
			i81.rotation = 11;
		};
		f = l.Add();//38
		f.Add(i81);
		f += () => {
			i81.rotation = 6;
		};
		f = l.Add();//39
		f.Add(i81);
		f = l.Add();//40
		f.Add(i81);
		f = l.Add();//41
		f.Add(i81);
		f = l.Add();//42
		f.Add(i81);
		f = l.Add();//43
		f.Add(i81);
		f = l.Add();//44
		f.Add(i81);
		f = l.Add();//45
		f.Add(i81);
		f = l.Add();//46
		f.Add(i81);
		f = l.Add();//47
		f.Add(i81);
		f = l.Add();//48
		f.Add(i81);
		f = l.Add();//49
		f.Add(i81);
		f = l.Add();//50
		f.Add(i81);
		f = l.Add();//51
		f.Add(i81);
		f = l.Add();//52
		f.Add(i81);
		f = l.Add();//53
		f.Add(i81);
		f = l.Add();//54
		f.Add(i81);
		f = l.Add();//55
		f.Add(i81);
		f = l.Add();//56
		f.Add(i81);
		f = l.Add();//57
		f.Add(i81);
		f = l.Add();//58
		f.Add(i81);
		f = l.Add();//59
		f.Add(i81);
		setFrames(l);
	}
}
public class HeartMenuIcon : BitmapData{ 
	public HeartMenuIcon() {
		width = 21;
		height = 25;
		setPixels("ed3c44145d85cb645cf04a4e09095e7b");
	}
}
public class HelpPhotoRatesIcon : BitmapData{ 
	public HelpPhotoRatesIcon() {
		width = 30;
		height = 29;
		setPixels("357ec5601ad20bdafadc7526df8f4ae0");
	}
}
public class HintRollMovie : MovieClip{ 
	public HintRollMovie() {
		var i84 = new symbol_28();
		addChild(i84);//0
		FrameInfo f;
		var l= new Frames(12);
		f = l.Add();//0
		f.Add(i84);
		f += () => {
			i84.x = 0;
			i84.scaleX = 1;
			i84.y = 0;
			i84.scaleY = 1;
			i84.rotation = 0;
			i84.alpha = 1;
			i84.filters = null;
			i84.graphicsHash = "54958f36662f991ddfffabec5c4f5b7d";
			i84.visible = true;
		};
		f = l.Add();//1
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "8e8fde2b6fb2dd56944cc95d624cae44";
		};
		f = l.Add();//2
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "079b8b5c153bfce2ac1c31bc259cfab9";
		};
		f = l.Add();//3
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "98e39af7fa34acb0ba5504cf45106e0e";
		};
		f = l.Add();//4
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "6e4997d7574b5d5cf5a2be4dd3e4b14a";
		};
		f = l.Add();//5
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "169e4ac6df3b414086cbc6b15c6294e7";
		};
		f = l.Add();//6
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "9be09cbf6c292bece59392942ebefe6c";
		};
		f = l.Add();//7
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "2415786c8dcf42abf4c7ec02827e7759";
		};
		f = l.Add();//8
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "c7041e5949250d23640a561fe37025cb";
		};
		f = l.Add();//9
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "8737e82281f977cf2b9748eadc202359";
		};
		f = l.Add();//10
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "a0fff9500423e8f8b8d031eba7ff7838";
		};
		f = l.Add();//11
		f.Add(i84);
		f += () => {
			i84.graphicsHash = "8b232a7d68aea52d17d1061abf7b7f0b";
		};
		setFrames(l);
	}
}
public class IconAuraAmorUnactive : BitmapData{ 
	public IconAuraAmorUnactive() {
		width = 58;
		height = 56;
		setPixels("6bae66408df6bfc45dac3574185e33ae");
	}
}
public class IconBackgroundPopular : BitmapData{ 
	public IconBackgroundPopular() {
		width = 162;
		height = 159;
		setPixels("31e2f7b1d9fe17751f4f2826e38cc045");
	}
}
public class IconBecomePopular : BitmapData{ 
	public IconBecomePopular() {
		width = 14;
		height = 18;
		setPixels("2aef43c11b03fb74691dc437a479a9e6");
	}
}
public class IconLockedAchievement : BitmapData{ 
	public IconLockedAchievement() {
		width = 53;
		height = 53;
		setPixels("a3a97ef61ac0749158dd67f3eb5d30ec");
	}
}
public class IconRatesDown : BitmapData{ 
	public IconRatesDown() {
		width = 8;
		height = 7;
		setPixels("bd7619942d53e75b94f14bf4ffd4cd9f");
	}
}
public class IconRatesUp : BitmapData{ 
	public IconRatesUp() {
		width = 8;
		height = 7;
		setPixels("22802b26e4abee53d4e601828d0bf351");
	}
}
public class IconRulesBlocked : BitmapData{ 
	public IconRulesBlocked() {
		width = 30;
		height = 30;
		setPixels("c7e7f4e3b2a9f4d31e5c63abbc0a33c2");
	}
}
public class IconSendMessage : BitmapData{ 
	public IconSendMessage() {
		width = 14;
		height = 15;
		setPixels("daca5bf2845c0eea3feec8a037e2acd4");
	}
}
public class KickOutButtonImg : BitmapData{ 
	public KickOutButtonImg() {
		width = 16;
		height = 16;
		setPixels("cf1c852cb8bb68b2c4b6506d0f47d30e");
	}
}
public class KissGoNo : MovieClip{ 
	public screens_fla.GoNoMovie_27 KissMovieClip;
	public KissGoNo() {
		KissMovieClip = new screens_fla.GoNoMovie_27();
		addChild(KissMovieClip);//0
	}
}
public class KissNoShakeLeft : MovieClip{ 
	public screens_fla._Anim2_4 KissMovieClip;
	public KissNoShakeLeft() {
		KissMovieClip = new screens_fla._Anim2_4();
		addChild(KissMovieClip);//0
	}
}
public class KissTwoYes : MovieClip{ 
	public screens_fla.KissTwoYesMovie_10 KissMovieClip;
	public KissTwoYes() {
		KissMovieClip = new screens_fla.KissTwoYesMovie_10();
		addChild(KissMovieClip);//0
	}
}
public class KissYes : MovieClip{ 
	public KissYes() {
		var filter_0 = new GlowFilter(){strength = 0.55, blurX = 55.56, blurY = 55.56};
		var filter_1 = new GlowFilter(){strength = 1, color = 8355840, blurX = 75, blurY = 75};
		var filter_2 = new GlowFilter(){strength = 1, color = 65280, blurX = 50, blurY = 50};
		var filter_3 = new GlowFilter(){strength = 0.11, blurX = 11.11, blurY = 11.11};
		var filter_4 = new GlowFilter(){strength = 0, blurX = 0, blurY = 0};
		var filter_5 = new GlowFilter(){strength = 1, blurX = 100, blurY = 100};
		var filter_6 = new GlowFilter(){strength = 0.44, blurX = 44.44, blurY = 44.44};
		var filter_7 = new GlowFilter(){strength = 0.88, blurX = 88.89, blurY = 88.89};
		var filter_8 = new GlowFilter(){strength = 1, color = 12533760, blurX = 87.50, blurY = 87.50};
		var filter_9 = new GlowFilter(){strength = 1, color = 6266880, blurX = 68.75, blurY = 68.75};
		var filter_10 = new GlowFilter(){strength = 1, color = 14622720, blurX = 93.75, blurY = 93.75};
		var filter_11 = new GlowFilter(){strength = 0.22, blurX = 22.22, blurY = 22.22};
		var filter_12 = new GlowFilter(){strength = 1, color = 4177920, blurX = 62.50, blurY = 62.50};
		var filter_13 = new GlowFilter(){strength = 0.33, blurX = 33.33, blurY = 33.33};
		var filter_14 = new GlowFilter(){strength = 1, color = 2088960, blurX = 56.25, blurY = 56.25};
		var filter_15 = new GlowFilter(){strength = 1, color = 10444800, blurX = 81.25, blurY = 81.25};
		var filter_16 = new GlowFilter(){strength = 0.66, blurX = 66.67, blurY = 66.67};
		var filter_17 = new GlowFilter(){strength = 0.77, blurX = 77.78, blurY = 77.78};
		var i89 = new symbol_31(){alpha = 0 , scaleX = 1.27 , scaleY = 1.3};
		addChild(i89);//0
		var i91 = new symbol_33(){alpha = 0 , scaleX = 1 , scaleY = 1 , filters = new as3.Array(new object[]{filter_2}) , rotation = -14};
		addChild(i91);//1
		FrameInfo f;
		var l= new Frames(70);
		f = l.Add("ThisIsLabel");//0
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.x = 0;
			i89.scaleX = 1.27;
			i89.y = 0;
			i89.scaleY = 1.3;
			i89.rotation = 0;
			i89.alpha = 0;
			i89.filters = null;
			i89.visible = true;
			i91.x = 0;
			i91.scaleX = 1;
			i91.y = 0;
			i91.scaleY = 1;
			i91.rotation = 345;
			i91.alpha = 0;
			i91.filters = new as3.Array(new object[]{filter_2});
			i91.visible = true;
		};
		f = l.Add();//1
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.33;
			i89.scaleY = 1.35;
			i89.rotation = 5;
			i89.alpha = 0.1;
			i91.scaleX = 1.1;
			i91.scaleY = 1.1;
			i91.rotation = 347;
			i91.alpha = 0.1;
			i91.filters = new as3.Array(new object[]{filter_14});
		};
		f = l.Add();//2
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.39;
			i89.scaleY = 1.41;
			i89.rotation = 11;
			i89.alpha = 0.3;
			i91.scaleX = 1.19;
			i91.scaleY = 1.19;
			i91.rotation = 348;
			i91.alpha = 0.3;
			i91.filters = new as3.Array(new object[]{filter_12});
		};
		f = l.Add();//3
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.45;
			i89.scaleY = 1.47;
			i89.rotation = 16;
			i89.alpha = 0.4;
			i91.scaleX = 1.29;
			i91.scaleY = 1.29;
			i91.rotation = 350;
			i91.alpha = 0.4;
			i91.filters = new as3.Array(new object[]{filter_9});
		};
		f = l.Add();//4
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.51;
			i89.scaleY = 1.53;
			i89.rotation = 22;
			i89.alpha = 0.5;
			i91.scaleX = 1.39;
			i91.scaleY = 1.39;
			i91.rotation = 351;
			i91.alpha = 0.5;
			i91.filters = new as3.Array(new object[]{filter_1});
		};
		f = l.Add();//5
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.57;
			i89.scaleY = 1.58;
			i89.rotation = 28;
			i89.alpha = 0.6;
			i91.scaleX = 1.49;
			i91.scaleY = 1.49;
			i91.rotation = 353;
			i91.alpha = 0.6;
			i91.filters = new as3.Array(new object[]{filter_15});
		};
		f = l.Add();//6
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.63;
			i89.scaleY = 1.64;
			i89.rotation = 33;
			i89.alpha = 0.8;
			i91.scaleX = 1.59;
			i91.scaleY = 1.59;
			i91.rotation = 354;
			i91.alpha = 0.8;
			i91.filters = new as3.Array(new object[]{filter_8});
		};
		f = l.Add();//7
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.69;
			i89.scaleY = 1.7;
			i89.rotation = 39;
			i89.alpha = 0.9;
			i91.scaleX = 1.68;
			i91.scaleY = 1.68;
			i91.rotation = 356;
			i91.alpha = 0.9;
			i91.filters = new as3.Array(new object[]{filter_10});
		};
		f = l.Add();//8
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.76;
			i89.scaleY = 1.76;
			i89.rotation = 45;
			i89.alpha = 1;
			i91.scaleX = 1.78;
			i91.scaleY = 1.78;
			i91.rotation = 357;
			i91.alpha = 1;
			i91.filters = new as3.Array(new object[]{filter_5});
		};
		f = l.Add();//9
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.7;
			i89.scaleY = 1.7;
			i89.rotation = 50;
			i89.alpha = 0.9;
			i91.scaleX = 1.88;
			i91.scaleY = 1.88;
			i91.rotation = 359;
			i91.filters = new as3.Array(new object[]{filter_7});
		};
		f = l.Add();//10
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.64;
			i89.scaleY = 1.65;
			i89.rotation = 55;
			i89.alpha = 0.8;
			i91.scaleX = 1.98;
			i91.scaleY = 1.98;
			i91.rotation = 0;
			i91.filters = new as3.Array(new object[]{filter_17});
		};
		f = l.Add();//11
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.59;
			i89.scaleY = 1.6;
			i89.rotation = 59;
			i89.alpha = 0.7;
			i91.scaleX = 2.07;
			i91.scaleY = 2.07;
			i91.rotation = 2;
			i91.filters = new as3.Array(new object[]{filter_16});
		};
		f = l.Add();//12
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.54;
			i89.scaleY = 1.55;
			i89.rotation = 64;
			i89.alpha = 0.6;
			i91.scaleX = 2.17;
			i91.scaleY = 2.17;
			i91.rotation = 3;
			i91.filters = new as3.Array(new object[]{filter_0});
		};
		f = l.Add();//13
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.48;
			i89.scaleY = 1.5;
			i89.rotation = 70;
			i89.alpha = 0.4;
			i91.scaleX = 2.27;
			i91.scaleY = 2.27;
			i91.rotation = 4;
			i91.filters = new as3.Array(new object[]{filter_6});
		};
		f = l.Add();//14
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.43;
			i89.scaleY = 1.45;
			i89.rotation = 75;
			i89.alpha = 0.3;
			i91.scaleX = 2.37;
			i91.scaleY = 2.37;
			i91.rotation = 6;
			i91.filters = new as3.Array(new object[]{filter_13});
		};
		f = l.Add();//15
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.38;
			i89.scaleY = 1.4;
			i89.rotation = 79;
			i89.alpha = 0.2;
			i91.scaleX = 2.46;
			i91.scaleY = 2.46;
			i91.rotation = 7;
			i91.filters = new as3.Array(new object[]{filter_11});
		};
		f = l.Add();//16
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.32;
			i89.scaleY = 1.35;
			i89.rotation = 84;
			i89.alpha = 0.1;
			i91.scaleX = 2.56;
			i91.scaleY = 2.56;
			i91.rotation = 9;
			i91.filters = new as3.Array(new object[]{filter_3});
		};
		f = l.Add();//17
		f.Add(i89);
		f.Add(i91);
		f += () => {
			i89.scaleX = 1.27;
			i89.scaleY = 1.3;
			i89.rotation = 90;
			i89.alpha = 0;
			i91.scaleX = 2.66;
			i91.scaleY = 2.66;
			i91.rotation = 10;
			i91.filters = new as3.Array(new object[]{filter_4});
		};
		f = l.Add();//18
		f.Add(i91);
		f += () => {
			i91.scaleX = 2.76;
			i91.scaleY = 2.76;
			i91.rotation = 12;
			i91.alpha = 0.9;
		};
		f = l.Add();//19
		f.Add(i91);
		f += () => {
			i91.scaleX = 2.85;
			i91.scaleY = 2.85;
			i91.rotation = 13;
			i91.alpha = 0.7;
		};
		f = l.Add();//20
		f.Add(i91);
		f += () => {
			i91.scaleX = 2.95;
			i91.scaleY = 2.95;
			i91.rotation = 15;
			i91.alpha = 0.6;
		};
		f = l.Add();//21
		f.Add(i91);
		f += () => {
			i91.scaleX = 3.05;
			i91.scaleY = 3.05;
			i91.rotation = 16;
			i91.alpha = 0.4;
		};
		f = l.Add();//22
		f.Add(i91);
		f += () => {
			i91.scaleX = 3.15;
			i91.scaleY = 3.15;
			i91.rotation = 18;
			i91.alpha = 0.3;
		};
		f = l.Add();//23
		f.Add(i91);
		f += () => {
			i91.scaleX = 3.25;
			i91.scaleY = 3.25;
			i91.rotation = 19;
			i91.alpha = 0.1;
		};
		f = l.Add();//24
		f.Add(i91);
		f += () => {
			i91.scaleX = 3.35;
			i91.scaleY = 3.35;
			i91.rotation = 21;
			i91.alpha = 0;
		};
		f = l.Add();//25
		f = l.Add();//26
		f = l.Add();//27
		f = l.Add();//28
		f = l.Add();//29
		f = l.Add();//30
		f = l.Add();//31
		f = l.Add();//32
		f = l.Add();//33
		f = l.Add();//34
		f = l.Add();//35
		f = l.Add();//36
		f = l.Add();//37
		f = l.Add();//38
		f = l.Add();//39
		f = l.Add();//40
		f = l.Add();//41
		f = l.Add();//42
		f = l.Add();//43
		f = l.Add();//44
		f = l.Add();//45
		f = l.Add();//46
		f = l.Add();//47
		f = l.Add();//48
		f = l.Add();//49
		f = l.Add();//50
		f = l.Add();//51
		f = l.Add();//52
		f = l.Add();//53
		f = l.Add();//54
		f = l.Add();//55
		f = l.Add();//56
		f = l.Add();//57
		f = l.Add();//58
		f = l.Add();//59
		f = l.Add();//60
		f = l.Add();//61
		f = l.Add();//62
		f = l.Add();//63
		f = l.Add();//64
		f = l.Add();//65
		f = l.Add();//66
		f = l.Add();//67
		f = l.Add();//68
		f = l.Add();//69
		setFrames(l);
		addFrameScript(69, ()=>{stop();});
	}
}
public class LogoDisconectedRU : BitmapData{ 
	public LogoDisconectedRU() {
		width = 262;
		height = 58;
		setPixels("25e101c89a2deb095b5a3e287a14aa4b");
	}
}
public class LogoRU : BitmapData{ 
	public LogoRU() {
		width = 163;
		height = 38;
		setPixels("bf363901e4cedf376a53c9199b94ef9b");
	}
}
public class PhotoApprovedIcon : BitmapData{ 
	public PhotoApprovedIcon() {
		width = 28;
		height = 28;
		setPixels("0d8ac00811d945fc76fc7abc4505ba65");
	}
}
public class PhotoUnapprovedIcon : BitmapData{ 
	public PhotoUnapprovedIcon() {
		width = 28;
		height = 28;
		setPixels("4cc869813c5ebf207fd384543654a3f3");
	}
}
public class PhotosBuyShowsIcon : BitmapData{ 
	public PhotosBuyShowsIcon() {
		width = 16;
		height = 16;
		setPixels("b86bcfafff06372d5761eb51793f7cc6");
	}
}
public class PhotosLikeButtonIcon : BitmapData{ 
	public PhotosLikeButtonIcon() {
		width = 24;
		height = 22;
		setPixels("56a609ed84c55f91881297a5ed4705c4");
	}
}
public class PhotosNextButtonIcon : BitmapData{ 
	public PhotosNextButtonIcon() {
		width = 24;
		height = 24;
		setPixels("5a0df454e547dd7d7c4c6a84939b1e5e");
	}
}
public class PhotosSelfRatingIcon : BitmapData{ 
	public PhotosSelfRatingIcon() {
		width = 21;
		height = 21;
		setPixels("78cac915bc0872f1abb422c456444d4b");
	}
}
public class PhotosSelfShowsIcon : BitmapData{ 
	public PhotosSelfShowsIcon() {
		width = 20;
		height = 20;
		setPixels("92e48b9482218b2fd208d1bb901f6043");
	}
}
public class PhotosSelfViewsIcon : BitmapData{ 
	public PhotosSelfViewsIcon() {
		width = 20;
		height = 12;
		setPixels("0f75b11ecb46b2ef54d383b8144b93a4");
	}
}
public class PlayerKissesIcon : BitmapData{ 
	public PlayerKissesIcon() {
		width = 34;
		height = 25;
		setPixels("65a6357d45d57c81d05b6dc7ebb57d12");
	}
}
public class PresentMenuIcon : BitmapData{ 
	public PresentMenuIcon() {
		width = 20;
		height = 25;
		setPixels("c57401415e081d4ac7562a06d37e8b74");
	}
}
public class ProgressBarIconComplete : BitmapData{ 
	public ProgressBarIconComplete() {
		width = 10;
		height = 8;
		setPixels("09606850bbea405b03d89c26c49f29ad");
	}
}
public class ProgressBarIconGift : BitmapData{ 
	public ProgressBarIconGift() {
		width = 14;
		height = 21;
		setPixels("af534fcebd5613f68b6762df4f5682a8");
	}
}
public class ProgressBarIconHat : BitmapData{ 
	public ProgressBarIconHat() {
		width = 23;
		height = 15;
		setPixels("0f1c57b29b801ddda2da8928109c2ca1");
	}
}
public class ProgressBarIconHatMafia : BitmapData{ 
	public ProgressBarIconHatMafia() {
		width = 23;
		height = 15;
		setPixels("78ff3cc60e32c4edcc9d63fd13874385");
	}
}
public class ProgressBarIconHeart : BitmapData{ 
	public ProgressBarIconHeart() {
		width = 17;
		height = 16;
		setPixels("d907f18e62aef6fbe46ac23c957b9574");
	}
}
public class ProgressBarIconHeartMafia : BitmapData{ 
	public ProgressBarIconHeartMafia() {
		width = 19;
		height = 17;
		setPixels("c13dd74f5786aa9ebd96450b010d4a40");
	}
}
public class ProgressBarIconKiss : BitmapData{ 
	public ProgressBarIconKiss() {
		width = 25;
		height = 16;
		setPixels("8c86a78b713a13b96d33893936a26057");
	}
}
public class ProgressBarIconMessage : BitmapData{ 
	public ProgressBarIconMessage() {
		width = 20;
		height = 19;
		setPixels("ea411018cc1d47f983b8907bc4d2a270");
	}
}
public class ProgressBarIconMessagePersonal : BitmapData{ 
	public ProgressBarIconMessagePersonal() {
		width = 17;
		height = 16;
		setPixels("83056e6f66784939a57e97b6afdf2dfb");
	}
}
public class ProgressBarIconPhoto : BitmapData{ 
	public ProgressBarIconPhoto() {
		width = 18;
		height = 16;
		setPixels("753b7d0debf6270bffacd57cc3c0dee0");
	}
}
public class ProgressBarIconTime : BitmapData{ 
	public ProgressBarIconTime() {
		width = 19;
		height = 19;
		setPixels("b9439a5e676c3a040b7807ee5a4f0008");
	}
}
public class ProgressBarIconWinMafia : BitmapData{ 
	public ProgressBarIconWinMafia() {
		width = 18;
		height = 17;
		setPixels("3c497c180ef9c50e64844a625b0a68a0");
	}
}
public class ProgressBarImgBgMafia : BitmapData{ 
	public ProgressBarImgBgMafia() {
		width = 215;
		height = 44;
		setPixels("1e0954d1b1cdca6c5821bca2d3e11e06");
	}
}
public class RollShake : MovieClip{ 
	public MovieClip player;
	public RollShake() {
		player = new symbol_29(){y = 0.3 , x = 0};
		addChild(player);//0
		FrameInfo f;
		var l= new Frames(15);
		f = l.Add();//0
		f.Add(player);
		f += () => {
			player.x = 0;
			player.scaleX = 1;
			player.y = 0.3;
			player.scaleY = 1;
			player.rotation = 0;
			player.alpha = 1;
			player.filters = null;
			player.visible = true;
		};
		f = l.Add();//1
		f.Add(player);
		f += () => {
			player.rotation = 358;
		};
		f = l.Add();//2
		f.Add(player);
		f += () => {
			player.rotation = 356;
		};
		f = l.Add();//3
		f.Add(player);
		f += () => {
			player.rotation = 353;
		};
		f = l.Add();//4
		f.Add(player);
		f += () => {
			player.rotation = 349;
		};
		f = l.Add();//5
		f.Add(player);
		f += () => {
			player.rotation = 347;
		};
		f = l.Add();//6
		f.Add(player);
		f += () => {
			player.rotation = 345;
		};
		f = l.Add();//7
		f.Add(player);
		f += () => {
			player.rotation = 344;
		};
		f = l.Add();//8
		f.Add(player);
		f += () => {
			player.rotation = 345;
		};
		f = l.Add();//9
		f.Add(player);
		f += () => {
			player.rotation = 347;
		};
		f = l.Add();//10
		f.Add(player);
		f += () => {
			player.rotation = 351;
		};
		f = l.Add();//11
		f.Add(player);
		f += () => {
			player.rotation = 354;
		};
		f = l.Add();//12
		f.Add(player);
		f += () => {
			player.rotation = 357;
		};
		f = l.Add();//13
		f.Add(player);
		f += () => {
			player.rotation = 358;
		};
		f = l.Add();//14
		f.Add(player);
		setFrames(l);
		addFrameScript(14, ()=>{dispatchEvent(new Event("EventLeaderStopShaking"));stop();});
	}
}
public class RoomPhotoMask : MovieClip{ 
	public RoomPhotoMask() {
		this.scale9Grid = new flash.geom.Rectangle(12, 10, 81, 112);
		var i95 = new symbol_34();
		addChild(i95);//0
	}
}
public class ScalePhotoRate : BitmapData{ 
	public ScalePhotoRate() {
		width = 155;
		height = 26;
		setPixels("d418270ae2aac6fc65716cee7a902c93");
	}
}
public class TextBottle : BitmapData{ 
	public TextBottle() {
		width = 71;
		height = 31;
		setPixels("05ea15ff1e2efa441b6d02ea6f13de83");
	}
}
public class UnderlineLineImg : BitmapData{ 
	public UnderlineLineImg() {
		width = 3;
		height = 1;
		setPixels("7a28e8cd3d71c4fc4c4a3e39bdb57b5b");
	}
}
public class kiss : BitmapData{ 
	public kiss() {
		width = 380;
		height = 380;
		setPixels("2f552c2af27c23dfa992b22cb57e5ff5");
	}
}
namespace screens_fla
{	public class GoNoMovie_27 : MovieClip{ 
		public MovieClip player;
		public GoNoMovie_27() {
			player = new symbol_29();
			addChild(player);//0
			FrameInfo f;
			var l= new Frames(83);
			f = l.Add();//0
			f.Add(player);
			f += () => {
				player.x = 0;
				player.scaleX = 1;
				player.y = 0;
				player.scaleY = 1;
				player.rotation = 0;
				player.alpha = 1;
				player.filters = null;
				player.visible = true;
			};
			f = l.Add();//1
			f.Add(player);
			f += () => {
				player.x = 0.8;
			};
			f = l.Add();//2
			f.Add(player);
			f += () => {
				player.x = 3.5;
			};
			f = l.Add();//3
			f.Add(player);
			f += () => {
				player.x = 7.7;
			};
			f = l.Add();//4
			f.Add(player);
			f += () => {
				player.x = 13.8;
				player.rotation = 1;
			};
			f = l.Add();//5
			f.Add(player);
			f += () => {
				player.x = 21.4;
			};
			f = l.Add();//6
			f.Add(player);
			f += () => {
				player.x = 30.9;
				player.rotation = 2;
			};
			f = l.Add();//7
			f.Add(player);
			f += () => {
				player.x = 42;
				player.rotation = 3;
			};
			f = l.Add();//8
			f.Add(player);
			f += () => {
				player.x = 54.9;
				player.rotation = 4;
			};
			f = l.Add();//9
			f.Add(player);
			f += () => {
				player.x = 69.5;
				player.rotation = 6;
			};
			f = l.Add();//10
			f.Add(player);
			f += () => {
				player.x = 84.2;
				player.rotation = 7;
			};
			f = l.Add();//11
			f.Add(player);
			f += () => {
				player.x = 97.3;
				player.rotation = 8;
			};
			f = l.Add();//12
			f.Add(player);
			f += () => {
				player.x = 108.9;
				player.rotation = 9;
			};
			f = l.Add();//13
			f.Add(player);
			f += () => {
				player.x = 118.9;
				player.rotation = 10;
			};
			f = l.Add();//14
			f.Add(player);
			f += () => {
				player.x = 127.5;
				player.rotation = 11;
			};
			f = l.Add();//15
			f.Add(player);
			f += () => {
				player.x = 134.3;
				player.rotation = 12;
			};
			f = l.Add();//16
			f.Add(player);
			f += () => {
				player.x = 139.8;
			};
			f = l.Add();//17
			f.Add(player);
			f += () => {
				player.x = 143.6;
			};
			f = l.Add();//18
			f.Add(player);
			f += () => {
				player.x = 146;
				player.rotation = 13;
			};
			f = l.Add();//19
			f.Add(player);
			f += () => {
				player.x = 146.8;
			};
			f = l.Add();//20
			f.Add(player);
			f = l.Add();//21
			f.Add(player);
			f = l.Add();//22
			f.Add(player);
			f = l.Add();//23
			f.Add(player);
			f = l.Add();//24
			f.Add(player);
			f = l.Add();//25
			f.Add(player);
			f = l.Add();//26
			f.Add(player);
			f = l.Add();//27
			f.Add(player);
			f = l.Add();//28
			f.Add(player);
			f = l.Add();//29
			f.Add(player);
			f = l.Add();//30
			f.Add(player);
			f = l.Add();//31
			f.Add(player);
			f = l.Add();//32
			f.Add(player);
			f = l.Add();//33
			f.Add(player);
			f = l.Add();//34
			f.Add(player);
			f = l.Add();//35
			f.Add(player);
			f = l.Add();//36
			f.Add(player);
			f = l.Add();//37
			f.Add(player);
			f = l.Add();//38
			f.Add(player);
			f = l.Add();//39
			f.Add(player);
			f = l.Add();//40
			f.Add(player);
			f = l.Add();//41
			f.Add(player);
			f = l.Add();//42
			f.Add(player);
			f = l.Add();//43
			f.Add(player);
			f = l.Add();//44
			f.Add(player);
			f = l.Add();//45
			f.Add(player);
			f = l.Add();//46
			f.Add(player);
			f = l.Add();//47
			f.Add(player);
			f = l.Add();//48
			f.Add(player);
			f = l.Add();//49
			f.Add(player);
			f = l.Add();//50
			f.Add(player);
			f = l.Add();//51
			f.Add(player);
			f = l.Add();//52
			f.Add(player);
			f = l.Add();//53
			f.Add(player);
			f = l.Add();//54
			f.Add(player);
			f = l.Add();//55
			f.Add(player);
			f = l.Add();//56
			f.Add(player);
			f = l.Add();//57
			f.Add(player);
			f = l.Add();//58
			f.Add(player);
			f = l.Add();//59
			f.Add(player);
			f = l.Add();//60
			f.Add(player);
			f = l.Add();//61
			f.Add(player);
			f = l.Add();//62
			f.Add(player);
			f = l.Add();//63
			f.Add(player);
			f = l.Add();//64
			f.Add(player);
			f = l.Add();//65
			f.Add(player);
			f += () => {
				player.x = 145.8;
			};
			f = l.Add();//66
			f.Add(player);
			f += () => {
				player.x = 143.2;
				player.rotation = 12;
			};
			f = l.Add();//67
			f.Add(player);
			f += () => {
				player.x = 138.6;
			};
			f = l.Add();//68
			f.Add(player);
			f += () => {
				player.x = 132.2;
				player.rotation = 11;
			};
			f = l.Add();//69
			f.Add(player);
			f += () => {
				player.x = 124.1;
			};
			f = l.Add();//70
			f.Add(player);
			f += () => {
				player.x = 114.2;
				player.rotation = 10;
			};
			f = l.Add();//71
			f.Add(player);
			f += () => {
				player.x = 102.4;
				player.rotation = 9;
			};
			f = l.Add();//72
			f.Add(player);
			f += () => {
				player.x = 88.8;
				player.rotation = 7;
			};
			f = l.Add();//73
			f.Add(player);
			f += () => {
				player.x = 73.4;
				player.rotation = 6;
			};
			f = l.Add();//74
			f.Add(player);
			f += () => {
				player.x = 58;
				player.rotation = 5;
			};
			f = l.Add();//75
			f.Add(player);
			f += () => {
				player.x = 44.4;
				player.rotation = 3;
			};
			f = l.Add();//76
			f.Add(player);
			f += () => {
				player.x = 32.6;
				player.rotation = 2;
			};
			f = l.Add();//77
			f.Add(player);
			f += () => {
				player.x = 22.6;
			};
			f = l.Add();//78
			f.Add(player);
			f += () => {
				player.x = 14.4;
				player.rotation = 1;
			};
			f = l.Add();//79
			f.Add(player);
			f += () => {
				player.x = 8.1;
				player.rotation = 0;
			};
			f = l.Add();//80
			f.Add(player);
			f += () => {
				player.x = 3.6;
			};
			f = l.Add();//81
			f.Add(player);
			f += () => {
				player.x = 0.9;
			};
			f = l.Add();//82
			f.Add(player);
			f += () => {
				player.x = 0;
			};
			setFrames(l);
		}
	}
	public class KissTwoYesMovie_10 : MovieClip{ 
		public MovieClip player;
		public KissTwoYesMovie_10() {
			player = new symbol_29();
			addChild(player);//0
			FrameInfo f;
			var l= new Frames(55);
			f = l.Add();//0
			f.Add(player);
			f += () => {
				player.x = 0;
				player.scaleX = 1;
				player.y = 0;
				player.scaleY = 1;
				player.rotation = 0;
				player.alpha = 1;
				player.filters = null;
				player.visible = true;
			};
			f = l.Add();//1
			f.Add(player);
			f += () => {
				player.x = 1.1;
				player.y = -0.3;
			};
			f = l.Add();//2
			f.Add(player);
			f += () => {
				player.x = 4.5;
				player.y = -0.9;
			};
			f = l.Add();//3
			f.Add(player);
			f += () => {
				player.x = 10.2;
				player.y = -2.1;
			};
			f = l.Add();//4
			f.Add(player);
			f += () => {
				player.x = 18.1;
				player.y = -3.8;
				player.rotation = 1;
			};
			f = l.Add();//5
			f.Add(player);
			f += () => {
				player.x = 28.2;
				player.y = -6;
				player.rotation = 2;
			};
			f = l.Add();//6
			f.Add(player);
			f += () => {
				player.x = 40.6;
				player.y = -8.6;
				player.rotation = 3;
			};
			f = l.Add();//7
			f.Add(player);
			f += () => {
				player.x = 53.1;
				player.y = -11.2;
				player.rotation = 4;
			};
			f = l.Add();//8
			f.Add(player);
			f += () => {
				player.x = 63.8;
				player.y = -13.4;
			};
			f = l.Add();//9
			f.Add(player);
			f += () => {
				player.x = 72.5;
				player.y = -15.3;
				player.rotation = 5;
			};
			f = l.Add();//10
			f.Add(player);
			f += () => {
				player.x = 79.3;
				player.y = -16.7;
				player.rotation = 6;
			};
			f = l.Add();//11
			f.Add(player);
			f += () => {
				player.x = 84.1;
				player.y = -17.8;
			};
			f = l.Add();//12
			f.Add(player);
			f += () => {
				player.x = 87;
				player.y = -18.4;
			};
			f = l.Add();//13
			f.Add(player);
			f += () => {
				player.x = 88;
				player.y = -18.6;
			};
			f = l.Add();//14
			f.Add(player);
			f = l.Add();//15
			f.Add(player);
			f = l.Add();//16
			f.Add(player);
			f = l.Add();//17
			f.Add(player);
			f = l.Add();//18
			f.Add(player);
			f = l.Add();//19
			f.Add(player);
			f = l.Add();//20
			f.Add(player);
			f = l.Add();//21
			f.Add(player);
			f = l.Add();//22
			f.Add(player);
			f = l.Add();//23
			f.Add(player);
			f = l.Add();//24
			f.Add(player);
			f = l.Add();//25
			f.Add(player);
			f = l.Add();//26
			f.Add(player);
			f = l.Add();//27
			f.Add(player);
			f = l.Add();//28
			f.Add(player);
			f = l.Add();//29
			f.Add(player);
			f = l.Add();//30
			f.Add(player);
			f = l.Add();//31
			f.Add(player);
			f = l.Add();//32
			f.Add(player);
			f = l.Add();//33
			f.Add(player);
			f = l.Add();//34
			f.Add(player);
			f = l.Add();//35
			f.Add(player);
			f = l.Add();//36
			f.Add(player);
			f = l.Add();//37
			f.Add(player);
			f = l.Add();//38
			f.Add(player);
			f = l.Add();//39
			f.Add(player);
			f = l.Add();//40
			f.Add(player);
			f = l.Add();//41
			f.Add(player);
			f = l.Add();//42
			f.Add(player);
			f += () => {
				player.x = 87;
				player.y = -18.4;
			};
			f = l.Add();//43
			f.Add(player);
			f += () => {
				player.x = 84.1;
				player.y = -17.8;
			};
			f = l.Add();//44
			f.Add(player);
			f += () => {
				player.x = 79.3;
				player.y = -16.8;
			};
			f = l.Add();//45
			f.Add(player);
			f += () => {
				player.x = 72.5;
				player.y = -15.3;
				player.rotation = 5;
			};
			f = l.Add();//46
			f.Add(player);
			f += () => {
				player.x = 63.8;
				player.y = -13.4;
				player.rotation = 4;
			};
			f = l.Add();//47
			f.Add(player);
			f += () => {
				player.x = 53.2;
				player.y = -11.3;
			};
			f = l.Add();//48
			f.Add(player);
			f += () => {
				player.x = 40.6;
				player.y = -8.6;
				player.rotation = 3;
			};
			f = l.Add();//49
			f.Add(player);
			f += () => {
				player.x = 28.3;
				player.y = -6;
				player.rotation = 2;
			};
			f = l.Add();//50
			f.Add(player);
			f += () => {
				player.x = 18.1;
				player.y = -3.8;
				player.rotation = 1;
			};
			f = l.Add();//51
			f.Add(player);
			f += () => {
				player.x = 10.1;
				player.y = -2.2;
				player.rotation = 0;
			};
			f = l.Add();//52
			f.Add(player);
			f += () => {
				player.x = 4.5;
				player.y = -0.9;
			};
			f = l.Add();//53
			f.Add(player);
			f += () => {
				player.x = 1.1;
				player.y = -0.3;
			};
			f = l.Add();//54
			f.Add(player);
			f += () => {
				player.x = 0;
				player.y = 0;
			};
			setFrames(l);
		}
	}
	public class _Anim2_4 : MovieClip{ 
		public MovieClip player;
		public _Anim2_4() {
			player = new symbol_29();
			addChild(player);//0
			FrameInfo f;
			var l= new Frames(25);
			f = l.Add();//0
			f.Add(player);
			f += () => {
				player.x = 0;
				player.scaleX = 1;
				player.y = 0;
				player.scaleY = 1;
				player.rotation = 0;
				player.alpha = 1;
				player.filters = null;
				player.visible = true;
			};
			f = l.Add();//1
			f.Add(player);
			f += () => {
				player.rotation = 359;
			};
			f = l.Add();//2
			f.Add(player);
			f += () => {
				player.rotation = 358;
			};
			f = l.Add();//3
			f.Add(player);
			f += () => {
				player.rotation = 356;
			};
			f = l.Add();//4
			f.Add(player);
			f += () => {
				player.rotation = 353;
			};
			f = l.Add();//5
			f.Add(player);
			f += () => {
				player.rotation = 351;
			};
			f = l.Add();//6
			f.Add(player);
			f += () => {
				player.rotation = 349;
			};
			f = l.Add();//7
			f.Add(player);
			f += () => {
				player.rotation = 348;
			};
			f = l.Add();//8
			f.Add(player);
			f += () => {
				player.rotation = 347;
			};
			f = l.Add();//9
			f.Add(player);
			f += () => {
				player.rotation = 348;
			};
			f = l.Add();//10
			f.Add(player);
			f += () => {
				player.rotation = 349;
			};
			f = l.Add();//11
			f.Add(player);
			f += () => {
				player.rotation = 351;
			};
			f = l.Add();//12
			f.Add(player);
			f += () => {
				player.rotation = 353;
			};
			f = l.Add();//13
			f.Add(player);
			f += () => {
				player.rotation = 356;
			};
			f = l.Add();//14
			f.Add(player);
			f += () => {
				player.rotation = 358;
			};
			f = l.Add();//15
			f.Add(player);
			f += () => {
				player.rotation = 359;
			};
			f = l.Add();//16
			f.Add(player);
			f = l.Add();//17
			f.Add(player);
			f = l.Add();//18
			f.Add(player);
			f = l.Add();//19
			f.Add(player);
			f = l.Add();//20
			f.Add(player);
			f = l.Add();//21
			f.Add(player);
			f = l.Add();//22
			f.Add(player);
			f = l.Add();//23
			f.Add(player);
			f = l.Add();//24
			f.Add(player);
			setFrames(l);
		}
	}
}
namespace screens.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("10ecf46f4a176caa5c7d95fd4c13cc31", -22.5, -70, 45, 140, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("500597087a0b04508a6a1927cd1fa098", -22.5, -70, 45, 140, 1, 1);
		}
	}
	public class symbol_10 : Shape{ 
		public symbol_10() {
			setGraphics("1afdc8eaf1e9972f8fec32a67415e19a", -3.5, -5.5, 30, 30, 1, 1);
		}
	}
	public class symbol_11 : Shape{ 
		public symbol_11() {
			setGraphics("e1566c00b1e5106ef9a4dc69c5b6af33", -5, -6, 30, 30, 1, 1);
		}
	}
	public class symbol_12 : Shape{ 
		public symbol_12() {
			setGraphics("c8d83e06fd4b8180622b31255ff2f765", -5, -6, 30, 30, 1, 1);
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("7f0dac78558967e054266d030b5a8a06", -4.5, -5.75, 30, 30, 1, 1);
		}
	}
	public class symbol_14 : Shape{ 
		public symbol_14() {
			setGraphics("3eb944bf81fab1b0831f9883bd9dd765", -4.5, -5.75, 30, 30, 1, 1);
		}
	}
	public class symbol_15 : Shape{ 
		public symbol_15() {
			setGraphics("658c7a671a7c665020080a0df97fca81", -3.25, -5.25, 30, 30, 1, 1);
		}
	}
	public class symbol_16 : Shape{ 
		public symbol_16() {
			setGraphics("1867888913d97453ca6ba58b08e08540", -3.25, -5.25, 30, 30, 1, 1);
		}
	}
	public class symbol_17 : Shape{ 
		public symbol_17() {
			setGraphics("949f12b95c950a98686571ea0179fb79", 0, 0, 40, 40, 1, 1);
		}
	}
	public class symbol_18 : Shape{ 
		public symbol_18() {
			setGraphics("d71acff19b7e366c64a3b49d77b98725", 0, 0, 40, 40, 1, 1);
		}
	}
	public class symbol_19 : Shape{ 
		public symbol_19() {
			setGraphics("978993bf49fc42465cd46b55ea0b988a", 0, 0, 40, 40, 1, 1);
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("57fed21c68f241741bfcdb20b4165432", -15.65, -63.25, 30.4, 126.35, 1, 1);
		}
	}
	public class symbol_20 : Shape{ 
		public symbol_20() {
			setGraphics("3e03da9f6b209718a6717c412eaa6cff", 0, 0, 40, 40, 1, 1);
		}
	}
	public class symbol_21 : Shape{ 
		public symbol_21() {
			setGraphics("66dc2dc894480a921250fdf2cf6ba5a0", 0, 0, 40, 40, 1, 1);
		}
	}
	public class symbol_22 : Shape{ 
		public symbol_22() {
			setGraphics("15e3f9ffa80cbd0d19f74cc31156e692", -1.5, -3, 30, 30, 1, 1);
		}
	}
	public class symbol_23 : Shape{ 
		public symbol_23() {
			setGraphics("5164e937373e8a657870dd81af01e845", -1.5, -3, 30, 30, 1, 1);
		}
	}
	public class symbol_24 : Shape{ 
		public symbol_24() {
			setGraphics("0d2ba93921dc261948a8ca0397d35792", -18, -21.5, 37, 42, 1, 1);
		}
	}
	public class symbol_25 : MovieClip{ 
		public symbol_25() {
			var i79 = new symbol_24();
			addChild(i79);//0
		}
	}
	public class symbol_26 : Shape{ 
		public symbol_26() {
			setGraphics("a71aa60df7b2eae68aa6d4d44e22f580", -15, -17, 30, 34, 1, 1);
		}
	}
	public class symbol_27 : MovieClip{ 
		public symbol_27() {
			var i82 = new symbol_26();
			addChild(i82);//0
		}
	}
	public class symbol_28 : Shape{ 
		public symbol_28() {
			setGraphics("54958f36662f991ddfffabec5c4f5b7d", 0, 0, 89, 63, 1, 1);
		}
	}
	public class symbol_29 : MovieClip{ 
		public symbol_29() {
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("0ff09785ded94a65013f6d19005c8180", -25, -78, 50, 140, 1, 1);
		}
	}
	public class symbol_30 : Shape{ 
		public symbol_30() {
			setGraphics("14d1ca6edc8eb613fec4a97af556f70d", -45, -45, 90, 90, 1, 1);
		}
	}
	public class symbol_31 : MovieClip{ 
		public symbol_31() {
			var i90 = new symbol_30();
			addChild(i90);//0
		}
	}
	public class symbol_32 : Bitmap{ 
		public symbol_32() {
		}
	}
	public class symbol_33 : MovieClip{ 
		public symbol_33() {
			var i92 = new symbol_32(){y = -19 , x = -19};
			addChild(i92);//0
		}
	}
	public class symbol_34 : Shape{ 
		public symbol_34() {
			setGraphics("20f4569157017ee941b82a05343cbaad", 0, 0, 105, 135, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("f1c9c7f6231f59d8bd8a073d9bf98fc7", -24, -75.5, 48, 135, 1, 1);
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("208f2218ee2e4e5e11a5b887c5548b43", -16.65, -64.95, 33.4, 118.2, 1, 1);
		}
	}
	public class symbol_6 : Shape{ 
		public symbol_6() {
			setGraphics("c4e286baf0c6c438338cabc12f2b246c", -3.5, -4.5, 30, 30, 1, 1);
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("71d92e9d66744442095b9819f37e3b69", -3.5, -4.5, 30, 30, 1, 1);
		}
	}
	public class symbol_8 : Shape{ 
		public symbol_8() {
			setGraphics("c9e93500a751220fb3b23934b41a2384", 0, 0, 25, 23, 1, 1);
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("6b60a467fd24d4d6061e7e921ea8a83b", -3.5, -5.5, 30, 30, 1, 1);
		}
	}
}
