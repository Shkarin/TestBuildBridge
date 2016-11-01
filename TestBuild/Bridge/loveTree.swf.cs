using System;
using flash.display;
using System.Collections.Generic;
using loveTree.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class LibloveTree : ResourcesExternalLib{
	public LibloveTree() {
	vectors = new string[] {
	"e76c03748c9ce58d684da55974ada82e",
	"362c41981992240b1ac2fd66280b8f07",
	"c14fc32ec2f34798f2114244d5e86b5b",
	"cb7560d91f21c6f82438b8c8f580a289",
	"69ae261ee63ffdb6a6607e6da0b47479",
	"c4cc3473026062b088c8d2aeae0b05ec",
	"15380bfae905c287123a0a4fb15b91c1",
	"bb765bbf6b0054c0348989684c512809",
	"4992f5a0511a9f2435ddec0ae77d59b9",
	"7af4996d5a068a13cacdd4118d8f3dc6",
	"c5733850d24694eb5018129a3d9f779a",
	"fe9a5b784581cda81807ae16911b1e44",
	"76228eac0fc10ee2dcb374935a2126e9",
	"9c322d138ddf3121b8efde9e0b072f90",
	"f203455479802ba0fc39d4f5eed646a1",
	"15b7e623350c26539075eefc1331fa29",
	"936551ace588d8e9742d139bbf5c323a",
	"4677a5ace54ae7271f80b9b9559c1878",
	"45b80d9fc037c23d07a909da0065e9e9",
	"32d1215979a7aa7976dc3799d275c317",
	"197f0c08d228249008f5ace53f4af97b",
	"14ebe2e18717494163f67b34876e8379",
	"8378dc3e04721079b1e63452e00237f4",
	"2c3b902d413c1a6f766ac2d228643dfa",
	"0d3914cabbf43d5d2113843035bc2544",
	"bc784efe6ae91b70599c6b66e96724ae",
	"72ff2f0e6119452652bf6cf65cf89b5e",
	"db4a57fb75c83e033e3e35ef43649cc9",
	"8acede517da8a16f9cf09a736b289a08",
	"90b75091d4b5a052b3762e3f2539834f",
	"78cebcf43da993cf5e00d99b532602bc",
	"9e03bff8cd4c45f025a7c49bd0cf3385",
	"79d7afa363f09fdf376da60532e7ca0b",
	"5a747aa83c0f9e7cd81d66e0ae81a755",
	"4a6d5f1836d0bd3c443a6e2ed88cd849",
	"51314b55c92dd6e6322b9d7fdbac3b44",
	"9ca5a1a0e4120848a2eb211e3e454077",
	"900c6c05d1a3278b0da8c298424401de",
	"3221b854774604fb8b146e45dcac7b7c",
	"09b01d3d84cefc1e7af10ddab09fa2d4",
	"5bdeda31f0a34797197acbc5c26b6d5f",
	"916bb4d853e145cf361f88c86838850f",
	"05238f6f91ca1487d21d588e43b713af",
	"4842c890c58afc8561a10a6255cd4bd0",
	"718fc36546d7bd0315b3942f05325113",
	"cabdcff6ff798c3fec7e788f5a251291",
	"218181e8df25d6c64d91af14d55ca42e",
	"76c79ec6225c14ef66aea5852f769e19",
	"487272ee129221a3eeb75c0a17872fb3",
	"f197effb4f17e0671d613d912d7a1a41",
	"4670db8304e6e279d0a790223acdf32b",
	"da9c9f9519478b6a2f6306aca290aeee",
	"afa33cbf39af9881a6bdd7091f275838",
	"8efcabdf8b182d7049e40fc4cdad1ea7",
	"8234baf7c7522f9eaf95c0a9b13f3aec",
	"4364a6c46249a5dce758c3231f677e57",
	"2a9f76ec8865614d6a54671b1456a523",
	"25b4eb5a81be7cac4940c44ff5f36024",
	"61e87a4c5e4930bdd738741e4c61d481",
	"299ed65c73e58e7abdf818abe0abfb55",
	"d151224302294569515ee2f07a91f8fb",
	"b0e56836d72a13a9239575c4b4f8cb13",
	"69f65bc00551fa70cb5835d2438df79f",
	"33009e209686f923fb3f4d487a5072aa",
	"5408df054b66a2af81ab9663cd25e5dc",
	"10b5d9e6e9e85d99c248ffd6294733f1",
	"b5c45346d83d84376e1c81c3cfffd435",
	"cd8929b336f096b461ddb3fb4cc8a8e3",
	"08254b3eaed927920aa1a7ed66cf02bd",
	"5c2282542f86099881853afacd431545",
	"9f2f8e7934984503cf04c5038917695b",
	"fe32c2515491ef0c2be468db2268e7be",
	"416a92f79950b48d81c31cb14a1a4568",
	"b936151063d1e9f5257b2eea71662d5a",
	"8356fcf97c487e6437f20a1f5ac57503",
	"cb11bdd0703d95cae03d2dc9ca85015c",
	"28a8f92adc3c0e823dd46e14dc625291",
	"de529bdd9a8cc2e467be3a9896ad288b",
	"42d4aef996fa9fa2be932496303c168a",
	"bd1881fd85593ae4b1f99a550fc2418e",
	"ddc5bb4d09ae5f95bf253a10b5cbd98a",
	"07661f924e21258c36c23b1886006e02",
	"64a87cb0f89a81affb816fb01a411e4d",
	"69092c97663bfa779adb661908114e9c",
	"67dd14df1ac96dbcfc60ec5dbeffa17c",
	"05a5dfc9343b059c0f4a61ee033d8f57",
	"371cf9ed5016058b8ea8cd8f73c1f1b7",
	"58e7568781efc4eee744861510a75c7c",
	"1e081203ba3d7227d247f86b1e38dc2b",
	"27a5c4980b287c951ada360c0e536c05",
	"28a576bafd23358c861841fc4935819a",
	"a876623c271c8e4976b34b34e0e3a957",
	"3022472f7e25f898a0b55d4778346593",
	"b4d8cf296307f2ed5ecfdb0d48df34aa",
	"369890d5e8d8f66b39a52c6dff1018a7",
	"ba31f2a45025b237af1626928e54d386",
	"1ff712109d1d01ce20ed7711b353e0f6",
	"b5b93e028850acba7214f41bc9648a21",
	"d5796d5ca7b3f90349bedb54a9609162",
	"86546797e6f23a64410034e57a54da03",
	"a3899443d3f234b0f3a49ffb6a6735e6",
	"9d1150bbf4d90781e7f8f03b610b401b",
	"90b9b9ac41f604fbe69570bf1c6e13b6",
	"02fceebc0c345b1f44853793167c6b87",
	"42aa68298c317f09a85dffe75e0e00c3",
	"af05cc75f7be48b5a2703a39f23f7922",
	"a1e6790830bb200f29bb21428a57c592",
	"8524a09e1e336e6813d46df5d990cf74",
	"74292e544b093f572184be05c670bef5",
	"99df6b63ad8b7bea41efbac51c7150ac",
	"c48ec9de6632c79d0f63c8d6af4ad30b",
	"74c8aebf4b4cdf1d45ec6584db23ec45",
	"860a69cc9435adffbdcdd11bcf45d05e",
	"bf87fe6cdb7bc50f832a3d2164a8773d",
	"cd598a0f141466f129ba7cc3b0b9e14d"
	};
	graphics = new string[] {
	"e17e6f9c92d002446ce39505bbe8db08",
	"d12c4fa738440d2888d3f6cb4028c4d6",
	"0f5774d8bea1d66471a35880a22dda40",
	"6e3049dab6c401eca112e907445c95a3",
	"a3ee1f8f07a5865fdf82ee826bbff96f",
	"3fe6b635c67f090a982da03e469928b0",
	"506448bc0dfd8dd25a4001b7582c84fe",
	"5c10bfc11864be62ab4faa78f0ee74a5",
	"8701910a7ee14cf5ed1d0bab7612c1c2",
	"f9b500a7e23f2ec5c9c7158c0a97591e",
	"9ae631e939c14b6f3d17281783e073ec",
	"0e909f20c9a7e3a5adec7efc08c0dfd4",
	"dbec1144668fd5039dc5387b848d7dbc",
	"000d7886eb05b19ffd0c11e7f40b8f14",
	"bfc970edf692ba06dcd638364903f742",
	"1b64397e07763d1090db9ee2ea44aa7a",
	"7a3547230b99a063e51c37488f0a48be",
	"6238dbbc5dc2b8f2125009e05b3c8566",
	"65f7d24d00d1e2b873db1d6f94a31210",
	"baa9dcce708d284c0db8fe2715e182dd",
	"8f180b68c296063ec5e149e321dcedc5",
	"cd162a87762711b9933fbe9c6418452a",
	"00ab267f4aaeaff984c4a20ed04ce991",
	"2454c39b4399cd26ef22a57e2d1c2e20",
	"a20bc6e7afa8ea6581c2f3cee07fa0bf",
	"feeb6a77aca9771e68fa912100a13296",
	"bd53c175d81f9f5eb759fd449fecb894",
	"33836e8d88bcc627b2427c889326891f",
	"3295c9af462f2d02c04f47f16bcd1e74",
	"94dbc9eb13ab7ee2f270119c6644b8c8",
	"af03893c0edca0e84515c6c4893a4562",
	"eedd639ae7bb1b4de91a9e72bd5e70d8",
	"0d975fbbb095a7a95edc7b0564b4469a",
	"f90cbfdda1b2af9b4435a6e17bccf8ae",
	"50a8c554f8a5f4f7b10d8b9015198258",
	"084835b1b7f1a83d23b0edfff8a1f0ad",
	"4351c265ad73912aee65e3ff7eac6010",
	"e66d5a5b1659565d8cddb497155b4cb1",
	"9b5b9f459720381c915ee28fa48698dd",
	"8335cb29452612f8f0876ffe72ef58af",
	"5e70d81e2818625bd6652da9555554be",
	"0468a262050879024df4468c7fed9bb5",
	"d021bcec1eecf4b545c436ea5eef59a2",
	"fa0c6c26e71b80ebcdc4429779162ac7"
	};
	}
}
public class BackgoundDialogTreeGrows : BitmapData{ 
	public BackgoundDialogTreeGrows() {
		width = 275;
		height = 352;
		setPixels("bfc970edf692ba06dcd638364903f742");
	}
}
public class ButtonGrowth : SimpleButton{ 
	public ButtonGrowth() {
		downState = new symbol_0();
		overState = new symbol_0();
		upState = new symbol_0();
		hitTestState = new symbol_1(){y = 0 , x = 0};
	}
}
public class ButtonLoveTree : SimpleButton{ 
	public ButtonLoveTree() {
		downState = new symbol_2();
		overState = new symbol_2();
		upState = new symbol_2();
		hitTestState = new symbol_1(){y = 0 , x = 0};
	}
}
public class ButtonTreeDecor : SimpleButton{ 
	public ButtonTreeDecor() {
		downState = new symbol_3();
		overState = new symbol_3();
		upState = new symbol_4();
		hitTestState = new symbol_1();
	}
}
public class ButtonTreeMove : SimpleButton{ 
	public ButtonTreeMove() {
		downState = new symbol_5();
		overState = new symbol_5();
		upState = new symbol_6();
		hitTestState = new symbol_1();
	}
}
public class DashedCornerImg : BitmapData{ 
	public DashedCornerImg() {
		width = 16;
		height = 15;
		setPixels("6e3049dab6c401eca112e907445c95a3");
	}
}
public class DecorRibbon : BitmapData{ 
	public DecorRibbon() {
		width = 17;
		height = 51;
		setPixels("6238dbbc5dc2b8f2125009e05b3c8566");
	}
}
public class FertilizerBigImg : BitmapData{ 
	public FertilizerBigImg() {
		width = 66;
		height = 74;
		setPixels("000d7886eb05b19ffd0c11e7f40b8f14");
	}
}
public class FertilizerImg : BitmapData{ 
	public FertilizerImg() {
		width = 60;
		height = 68;
		setPixels("0e909f20c9a7e3a5adec7efc08c0dfd4");
	}
}
public class HitDecor : MovieClip{ 
	public HitDecor() {
		var i65 = new symbol_7();
		addChild(i65);//0
	}
}
public class IconUpTreeArrow : BitmapData{ 
	public IconUpTreeArrow() {
		width = 13;
		height = 18;
		setPixels("fa0c6c26e71b80ebcdc4429779162ac7");
	}
}
public class LightSprite : MovieClip{ 
	public LightSprite() {
		var i67 = new symbol_8();
		addChild(i67);//0
	}
}
public class MoveDecorIcon : BitmapData{ 
	public MoveDecorIcon() {
		width = 55;
		height = 55;
		setPixels("5e70d81e2818625bd6652da9555554be");
	}
}
public class RemoveDecorIcon : BitmapData{ 
	public RemoveDecorIcon() {
		width = 12;
		height = 12;
		setPixels("3295c9af462f2d02c04f47f16bcd1e74");
	}
}
public class TickGreenSize25 : BitmapData{ 
	public TickGreenSize25() {
		width = 25;
		height = 21;
		setPixels("1b64397e07763d1090db9ee2ea44aa7a");
	}
}
public class TickGreenSize9 : BitmapData{ 
	public TickGreenSize9() {
		width = 9;
		height = 8;
		setPixels("a3ee1f8f07a5865fdf82ee826bbff96f");
	}
}
public class TreeFurn : MovieClip{ 
	public MovieClip Link24;
	public MovieClip Link15;
	public MovieClip Link4;
	public MovieClip Link25;
	public MovieClip Link5;
	public MovieClip Link16;
	public MovieClip Link6;
	public MovieClip Link17;
	public MovieClip Link18;
	public MovieClip Link19;
	public MovieClip Link9;
	public MovieClip Link7;
	public MovieClip frontArea;
	public MovieClip Link11;
	public MovieClip Link10;
	public MovieClip Link20;
	public MovieClip Link12;
	public MovieClip Link1;
	public MovieClip Link8;
	public MovieClip Link22;
	public MovieClip Link21;
	public MovieClip Link13;
	public MovieClip Link2;
	public MovieClip Link23;
	public MovieClip Link14;
	public MovieClip Link3;
	public MovieClip stateSprite;
	public TreeFurn() {
		frontArea = new symbol_10(){scaleY = 0.96 , scaleX = 1.16};
		addChild(frontArea);//0
		stateSprite = new symbol_12(){scaleY = 1.02 , scaleX = 1.23};
		addChild(stateSprite);//1
		var i1209 = new symbol_635();
		addChild(i1209);//2
		var i199 = new symbol_97(){x = 243.6 , scaleX = 1.26 , y = -68.8 , scaleY = 2.08 , alpha = 0.3};
		addChild(i199);//2
		var i1325 = new symbol_696();
		addChild(i1325);//2
		var i71 = new symbol_14(){x = 245.6 , scaleX = 1.26 , y = -68.8 , scaleY = 2.08 , alpha = 0.3};
		addChild(i71);//2
		var i1327 = new symbol_698(){y = -104 , x = 240};
		addChild(i1327);//2
		var i1323 = new symbol_694();
		addChild(i1323);//2
		var i1100 = new symbol_580(){x = 243.6 , scaleX = 1.26 , y = -68.8 , scaleY = 2.08 , alpha = 0.3};
		addChild(i1100);//2
		var i1321 = new symbol_692();
		addChild(i1321);//2
		var i624 = new symbol_339(){x = 243.6 , scaleX = 1.26 , y = -68.8 , scaleY = 2.08 , alpha = 0.3};
		addChild(i624);//2
		var i163 = new symbol_76(){x = 240.3 , scaleX = 0.63 , y = -89 , scaleY = 0.63};
		addChild(i163);//3
		var i73 = new symbol_16(){x = 242.3 , scaleX = 0.63 , y = -89 , scaleY = 0.63};
		addChild(i73);//3
		var i201 = new symbol_99(){x = 240.3 , scaleX = 0.63 , y = -89 , scaleY = 0.63};
		addChild(i201);//3
		var i893 = new symbol_526(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i893);//4
		var i422 = new symbol_258(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i422);//4
		var i254 = new symbol_162(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i254);//4
		var i77 = new symbol_23(){x = 242.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i77);//4
		var i137 = new symbol_73(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i137);//4
		var i481 = new symbol_291(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i481);//4
		var i627 = new symbol_382(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i627);//4
		var i97 = new symbol_43(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i97);//4
		var i114 = new symbol_56(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i114);//4
		var i710 = new symbol_427(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i710);//4
		var i544 = new symbol_336(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i544);//4
		var i165 = new symbol_93(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i165);//4
		var i800 = new symbol_476(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i800);//4
		var i303 = new symbol_192(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i303);//4
		var i995 = new symbol_575(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i995);//4
		var i1102 = new symbol_633(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i1102);//4
		var i75 = new symbol_18(){x = 242.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i75);//4
		var i360 = new symbol_226(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i360);//4
		var i203 = new symbol_134(){x = 240.4 , scaleX = 0.63 , y = -103 , scaleY = 0.63};
		addChild(i203);//4
		var i84 = new symbol_32(){x = 242.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i84);//4
		Link1 = new symbol_34(){y = -127.8 , x = 271.6};
		addChild(Link1);//5
		var i83 = new symbol_24();
		addChild(i83);//5
		var i1210 = new symbol_690(){x = 240.7 , scaleX = 0.63 , y = -103.2 , scaleY = 0.63};
		addChild(i1210);//5
		var i1329 = new symbol_700();
		addChild(i1329);//6
		Link2 = new symbol_57(){y = -137.8 , x = 228.2};
		addChild(Link2);//6
		var i113 = new symbol_44();
		addChild(i113);//6
		Link3 = new symbol_94(){y = -156.3 , x = 315.6};
		addChild(Link3);//7
		var i1332 = new symbol_703();
		addChild(i1332);//7
		var i162 = new symbol_74();
		addChild(i162);//7
		Link4 = new symbol_135(){y = -133.8 , x = 190.1};
		addChild(Link4);//8
		Link5 = new symbol_163(){y = -160.8 , x = 148.7};
		addChild(Link5);//9
		var i198 = new symbol_95();
		addChild(i198);//9
		Link6 = new symbol_193(){y = -188.8 , x = 269.1};
		addChild(Link6);//10
		var i253 = new symbol_136();
		addChild(i253);//10
		var i302 = new symbol_164();
		addChild(i302);//11
		Link7 = new symbol_227(){y = -187.3 , x = 194.1};
		addChild(Link7);//11
		var i359 = new symbol_194();
		addChild(i359);//11
		Link8 = new symbol_259(){y = -147.2 , x = 356.9};
		addChild(Link8);//12
		var i421 = new symbol_228();
		addChild(i421);//12
		Link9 = new symbol_292(){y = -148.3 , x = 105.1};
		addChild(Link9);//13
		Link10 = new symbol_337(){y = -222.8 , x = 230.1};
		addChild(Link10);//14
		var i543 = new symbol_293();
		addChild(i543);//15
		var i626 = new symbol_340();
		addChild(i626);//15
		Link11 = new symbol_383(){y = -165.3 , x = 400.1};
		addChild(Link11);//15
		Link12 = new symbol_428(){y = -145.3 , x = 62.6};
		addChild(Link12);//16
		var i709 = new symbol_384();
		addChild(i709);//16
		var i797 = new symbol_429(){x = 322.4 , scaleX = 1.26 , y = -63.5 , scaleY = 2.08 , alpha = 0.3};
		addChild(i797);//17
		Link13 = new symbol_477(){y = -243.3 , x = 303.1};
		addChild(Link13);//17
		Link14 = new symbol_527(){y = -225.8 , x = 159.2};
		addChild(Link14);//18
		var i799 = new symbol_430();
		addChild(i799);//18
		Link15 = new symbol_576(){y = -278.3 , x = 373.1};
		addChild(Link15);//19
		Link16 = new symbol_634(){y = -293.3 , x = 140.6};
		addChild(Link16);//20
		Link17 = new symbol_691(){y = -278.8 , x = 331.1};
		addChild(Link17);//22
		var i1097 = new symbol_577(){x = 133.1 , scaleX = 1.26 , y = -63.5 , scaleY = 2.08 , alpha = 0.3};
		addChild(i1097);//22
		Link18 = new symbol_693(){y = -225.8 , x = 117.1};
		addChild(Link18);//23
		var i1099 = new symbol_578();
		addChild(i1099);//23
		Link19 = new symbol_695(){y = -132.8 , x = 430.1};
		addChild(Link19);//24
		Link20 = new symbol_697(){y = -190.3 , x = 335.6};
		addChild(Link20);//25
		Link21 = new symbol_699(){y = -197.3 , x = 371.1};
		addChild(Link21);//26
		Link22 = new symbol_701(){y = -274.3 , x = 179.6};
		addChild(Link22);//28
		Link23 = new symbol_702(){y = -271.4 , x = 245.1};
		addChild(Link23);//29
		Link24 = new symbol_704(){y = -320.8 , x = 221.6};
		addChild(Link24);//31
		Link25 = new symbol_705(){y = -306.3 , x = 270.6};
		addChild(Link25);//32
		FrameInfo f;
		var l= new Frames(50);
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i71);
		f.Add(i73);
		f.Add(i75);
		f += () => {
			frontArea.x = 0;
			frontArea.scaleX = 1.16;
			frontArea.y = 0;
			frontArea.scaleY = 0.96;
			frontArea.rotation = 0;
			frontArea.alpha = 1;
			frontArea.filters = null;
			frontArea.visible = true;
			stateSprite.x = 0;
			stateSprite.scaleX = 1.23;
			stateSprite.y = 0;
			stateSprite.scaleY = 1.02;
			stateSprite.rotation = 0;
			stateSprite.alpha = 1;
			stateSprite.filters = null;
			stateSprite.visible = true;
			i71.x = 245.6;
			i71.scaleX = 1.26;
			i71.y = -68.8;
			i71.scaleY = 2.08;
			i71.rotation = 0;
			i71.alpha = 0.3;
			i71.filters = null;
			i71.visible = true;
			i73.x = 242.3;
			i73.scaleX = 0.63;
			i73.y = -89;
			i73.scaleY = 0.63;
			i73.rotation = 0;
			i73.alpha = 1;
			i73.filters = null;
			i73.visible = true;
			i75.x = 242.7;
			i75.scaleX = 0.63;
			i75.y = -103.2;
			i75.scaleY = 0.63;
			i75.rotation = 0;
			i75.alpha = 1;
			i75.filters = null;
			i75.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i71);
		f.Add(i73);
		f.Add(i77);
		f.Add(i83);
		f += () => {
			i77.x = 242.7;
			i77.scaleX = 0.63;
			i77.y = -103.2;
			i77.scaleY = 0.63;
			i77.rotation = 0;
			i77.alpha = 1;
			i77.filters = null;
			i77.visible = true;
			i83.x = 0;
			i83.scaleX = 1;
			i83.y = 0;
			i83.scaleY = 1;
			i83.rotation = 0;
			i83.alpha = 1;
			i83.filters = null;
			i83.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i71);
		f.Add(i73);
		f.Add(i84);
		f.Add(Link1);
		f.Add(i83);
		f += () => {
			i84.x = 242.7;
			i84.scaleX = 0.63;
			i84.y = -103.2;
			i84.scaleY = 0.63;
			i84.rotation = 0;
			i84.alpha = 1;
			i84.filters = null;
			i84.visible = true;
			Link1.x = 271.6;
			Link1.scaleX = 1;
			Link1.y = -127.8;
			Link1.scaleY = 1;
			Link1.rotation = 0;
			Link1.alpha = 1;
			Link1.filters = null;
			Link1.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i71);
		f.Add(i73);
		f.Add(i97);
		f.Add(Link1);
		f.Add(i113);
		f += () => {
			i97.x = 240.7;
			i97.scaleX = 0.63;
			i97.y = -103.2;
			i97.scaleY = 0.63;
			i97.rotation = 0;
			i97.alpha = 1;
			i97.filters = null;
			i97.visible = true;
			Link1.x = 269.6;
			Link1.y = -129.8;
			i113.x = 0;
			i113.scaleX = 1;
			i113.y = 0;
			i113.scaleY = 1;
			i113.rotation = 0;
			i113.alpha = 1;
			i113.filters = null;
			i113.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i71);
		f.Add(i73);
		f.Add(i114);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(i113);
		f += () => {
			i114.x = 240.7;
			i114.scaleX = 0.63;
			i114.y = -103.2;
			i114.scaleY = 0.63;
			i114.rotation = 0;
			i114.alpha = 1;
			i114.filters = null;
			i114.visible = true;
			Link1.y = -126.8;
			Link2.x = 228.2;
			Link2.scaleX = 1;
			Link2.y = -137.8;
			Link2.scaleY = 1;
			Link2.rotation = 0;
			Link2.alpha = 1;
			Link2.filters = null;
			Link2.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i71);
		f.Add(i73);
		f.Add(i137);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(i162);
		f += () => {
			i137.x = 240.7;
			i137.scaleX = 0.63;
			i137.y = -103.2;
			i137.scaleY = 0.63;
			i137.rotation = 0;
			i137.alpha = 1;
			i137.filters = null;
			i137.visible = true;
			i162.x = 0;
			i162.scaleX = 1;
			i162.y = 0;
			i162.scaleY = 1;
			i162.rotation = 0;
			i162.alpha = 1;
			i162.filters = null;
			i162.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i71);
		f.Add(i163);
		f.Add(i165);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i162);
		f += () => {
			i163.x = 240.3;
			i163.scaleX = 0.63;
			i163.y = -89;
			i163.scaleY = 0.63;
			i163.rotation = 0;
			i163.alpha = 1;
			i163.filters = null;
			i163.visible = true;
			i165.x = 240.7;
			i165.scaleX = 0.63;
			i165.y = -103.2;
			i165.scaleY = 0.63;
			i165.rotation = 0;
			i165.alpha = 1;
			i165.filters = null;
			i165.visible = true;
			Link3.x = 315.6;
			Link3.scaleX = 1;
			Link3.y = -156.3;
			Link3.scaleY = 1;
			Link3.rotation = 0;
			Link3.alpha = 1;
			Link3.filters = null;
			Link3.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i71);
		f.Add(i163);
		f.Add(i165);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i162);
		f.Add(i198);
		f += () => {
			i198.x = 0;
			i198.scaleX = 1;
			i198.y = 0;
			i198.scaleY = 1;
			i198.rotation = 0;
			i198.alpha = 1;
			i198.filters = null;
			i198.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i203);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i162);
		f.Add(Link4);
		f.Add(i198);
		f += () => {
			i199.x = 243.6;
			i199.scaleX = 1.26;
			i199.y = -68.8;
			i199.scaleY = 2.08;
			i199.rotation = 0;
			i199.alpha = 0.3;
			i199.filters = null;
			i199.visible = true;
			i201.x = 240.3;
			i201.scaleX = 0.63;
			i201.y = -89;
			i201.scaleY = 0.63;
			i201.rotation = 0;
			i201.alpha = 1;
			i201.filters = null;
			i201.visible = true;
			i203.x = 240.4;
			i203.scaleX = 0.63;
			i203.y = -103;
			i203.scaleY = 0.63;
			i203.rotation = 0;
			i203.alpha = 1;
			i203.filters = null;
			i203.visible = true;
			Link1.y = -131.8;
			Link3.y = -160.3;
			Link4.x = 190.1;
			Link4.scaleX = 1;
			Link4.y = -133.8;
			Link4.scaleY = 1;
			Link4.rotation = 0;
			Link4.alpha = 1;
			Link4.filters = null;
			Link4.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i203);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i162);
		f.Add(Link4);
		f.Add(i253);
		f += () => {
			i253.x = 0;
			i253.scaleX = 1;
			i253.y = 0;
			i253.scaleY = 1;
			i253.rotation = 0;
			i253.alpha = 1;
			i253.filters = null;
			i253.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i254);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i162);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(i253);
		f += () => {
			i254.x = 240.7;
			i254.scaleX = 0.63;
			i254.y = -103.2;
			i254.scaleY = 0.63;
			i254.rotation = 0;
			i254.alpha = 1;
			i254.filters = null;
			i254.visible = true;
			Link1.y = -132.8;
			Link4.y = -134.8;
			Link5.x = 148.7;
			Link5.scaleX = 1;
			Link5.y = -160.8;
			Link5.scaleY = 1;
			Link5.rotation = 0;
			Link5.alpha = 1;
			Link5.filters = null;
			Link5.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i254);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i162);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(i302);
		f += () => {
			i302.x = 0;
			i302.scaleX = 1;
			i302.y = 0;
			i302.scaleY = 1;
			i302.rotation = 0;
			i302.alpha = 1;
			i302.filters = null;
			i302.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i303);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i162);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i302);
		f += () => {
			i303.x = 240.7;
			i303.scaleX = 0.63;
			i303.y = -103.2;
			i303.scaleY = 0.63;
			i303.rotation = 0;
			i303.alpha = 1;
			i303.filters = null;
			i303.visible = true;
			Link6.x = 269.1;
			Link6.scaleX = 1;
			Link6.y = -188.8;
			Link6.scaleY = 1;
			Link6.rotation = 0;
			Link6.alpha = 1;
			Link6.filters = null;
			Link6.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i303);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i302);
		f.Add(i359);
		f += () => {
			i359.x = 0;
			i359.scaleX = 1;
			i359.y = 0;
			i359.scaleY = 1;
			i359.rotation = 0;
			i359.alpha = 1;
			i359.filters = null;
			i359.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i360);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i302);
		f.Add(Link7);
		f.Add(i359);
		f += () => {
			i360.x = 240.7;
			i360.scaleX = 0.63;
			i360.y = -103.2;
			i360.scaleY = 0.63;
			i360.rotation = 0;
			i360.alpha = 1;
			i360.filters = null;
			i360.visible = true;
			Link6.y = -190.8;
			Link7.x = 194.1;
			Link7.scaleX = 1;
			Link7.y = -187.3;
			Link7.scaleY = 1;
			Link7.rotation = 0;
			Link7.alpha = 1;
			Link7.filters = null;
			Link7.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i360);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i302);
		f.Add(Link7);
		f.Add(i421);
		f += () => {
			i421.x = 0;
			i421.scaleX = 1;
			i421.y = 0;
			i421.scaleY = 1;
			i421.rotation = 0;
			i421.alpha = 1;
			i421.filters = null;
			i421.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i422);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i302);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(i421);
		f += () => {
			i422.x = 240.7;
			i422.scaleX = 0.63;
			i422.y = -103.2;
			i422.scaleY = 0.63;
			i422.rotation = 0;
			i422.alpha = 1;
			i422.filters = null;
			i422.visible = true;
			Link3.y = -162.3;
			Link8.x = 356.9;
			Link8.scaleX = 1;
			Link8.y = -147.2;
			Link8.scaleY = 1;
			Link8.rotation = 0;
			Link8.alpha = 1;
			Link8.filters = null;
			Link8.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i422);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i302);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(i421);
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i481);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i302);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(i421);
		f.Add(Link9);
		f += () => {
			i481.x = 240.7;
			i481.scaleX = 0.63;
			i481.y = -103.2;
			i481.scaleY = 0.63;
			i481.rotation = 0;
			i481.alpha = 1;
			i481.filters = null;
			i481.visible = true;
			Link9.x = 105.1;
			Link9.scaleX = 1;
			Link9.y = -148.3;
			Link9.scaleY = 1;
			Link9.rotation = 0;
			Link9.alpha = 1;
			Link9.filters = null;
			Link9.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i481);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(i421);
		f.Add(Link9);
		f.Add(i543);
		f += () => {
			i543.x = 0;
			i543.scaleX = 1;
			i543.y = 0;
			i543.scaleY = 1;
			i543.rotation = 0;
			i543.alpha = 1;
			i543.filters = null;
			i543.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i199);
		f.Add(i201);
		f.Add(i544);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(i421);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f += () => {
			i544.x = 240.7;
			i544.scaleX = 0.63;
			i544.y = -103.2;
			i544.scaleY = 0.63;
			i544.rotation = 0;
			i544.alpha = 1;
			i544.filters = null;
			i544.visible = true;
			Link3.y = -157.3;
			Link8.y = -143.2;
			Link10.x = 230.1;
			Link10.scaleX = 1;
			Link10.y = -222.8;
			Link10.scaleY = 1;
			Link10.rotation = 0;
			Link10.alpha = 1;
			Link10.filters = null;
			Link10.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i544);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(i626);
		f += () => {
			i624.x = 243.6;
			i624.scaleX = 1.26;
			i624.y = -68.8;
			i624.scaleY = 2.08;
			i624.rotation = 0;
			i624.alpha = 0.3;
			i624.filters = null;
			i624.visible = true;
			i626.x = 0;
			i626.scaleX = 1;
			i626.y = 0;
			i626.scaleY = 1;
			i626.rotation = 0;
			i626.alpha = 1;
			i626.filters = null;
			i626.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i627);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(i626);
		f.Add(Link11);
		f += () => {
			i627.x = 240.7;
			i627.scaleX = 0.63;
			i627.y = -103.2;
			i627.scaleY = 0.63;
			i627.rotation = 0;
			i627.alpha = 1;
			i627.filters = null;
			i627.visible = true;
			Link11.x = 400.1;
			Link11.scaleX = 1;
			Link11.y = -165.3;
			Link11.scaleY = 1;
			Link11.rotation = 0;
			Link11.alpha = 1;
			Link11.filters = null;
			Link11.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i627);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(Link11);
		f.Add(i709);
		f += () => {
			i709.x = 0;
			i709.scaleX = 1;
			i709.y = 0;
			i709.scaleY = 1;
			i709.rotation = 0;
			i709.alpha = 1;
			i709.filters = null;
			i709.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i710);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i709);
		f += () => {
			i710.x = 240.7;
			i710.scaleX = 0.63;
			i710.y = -103.2;
			i710.scaleY = 0.63;
			i710.rotation = 0;
			i710.alpha = 1;
			i710.filters = null;
			i710.visible = true;
			Link12.x = 62.6;
			Link12.scaleX = 1;
			Link12.y = -145.3;
			Link12.scaleY = 1;
			Link12.rotation = 0;
			Link12.alpha = 1;
			Link12.filters = null;
			Link12.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i710);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(i799);
		f += () => {
			i797.x = 322.4;
			i797.scaleX = 1.26;
			i797.y = -63.5;
			i797.scaleY = 2.08;
			i797.rotation = 0;
			i797.alpha = 0.3;
			i797.filters = null;
			i797.visible = true;
			i799.x = 0;
			i799.scaleX = 1;
			i799.y = 0;
			i799.scaleY = 1;
			i799.rotation = 0;
			i799.alpha = 1;
			i799.filters = null;
			i799.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i800);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(i799);
		f += () => {
			i800.x = 240.7;
			i800.scaleX = 0.63;
			i800.y = -103.2;
			i800.scaleY = 0.63;
			i800.rotation = 0;
			i800.alpha = 1;
			i800.filters = null;
			i800.visible = true;
			Link13.x = 303.1;
			Link13.scaleX = 1;
			Link13.y = -243.3;
			Link13.scaleY = 1;
			Link13.rotation = 0;
			Link13.alpha = 1;
			Link13.filters = null;
			Link13.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i800);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(i799);
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i893);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f += () => {
			i893.x = 240.7;
			i893.scaleX = 0.63;
			i893.y = -103.2;
			i893.scaleY = 0.63;
			i893.rotation = 0;
			i893.alpha = 1;
			i893.filters = null;
			i893.visible = true;
			Link14.x = 159.2;
			Link14.scaleX = 1;
			Link14.y = -225.8;
			Link14.scaleY = 1;
			Link14.rotation = 0;
			Link14.alpha = 1;
			Link14.filters = null;
			Link14.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i893);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i995);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i543);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f += () => {
			i995.x = 240.7;
			i995.scaleX = 0.63;
			i995.y = -103.2;
			i995.scaleY = 0.63;
			i995.rotation = 0;
			i995.alpha = 1;
			i995.filters = null;
			i995.visible = true;
			Link15.x = 373.1;
			Link15.scaleX = 1;
			Link15.y = -278.3;
			Link15.scaleY = 1;
			Link15.rotation = 0;
			Link15.alpha = 1;
			Link15.filters = null;
			Link15.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i624);
		f.Add(i201);
		f.Add(i995);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(i1097);
		f.Add(i1099);
		f += () => {
			i1097.x = 133.1;
			i1097.scaleX = 1.26;
			i1097.y = -63.5;
			i1097.scaleY = 2.08;
			i1097.rotation = 0;
			i1097.alpha = 0.3;
			i1097.filters = null;
			i1097.visible = true;
			i1099.x = 0;
			i1099.scaleX = 1;
			i1099.y = 0;
			i1099.scaleY = 1;
			i1099.rotation = 0;
			i1099.alpha = 1;
			i1099.filters = null;
			i1099.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1100);
		f.Add(i201);
		f.Add(i1102);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i1097);
		f.Add(i1099);
		f += () => {
			i1100.x = 243.6;
			i1100.scaleX = 1.26;
			i1100.y = -68.8;
			i1100.scaleY = 2.08;
			i1100.rotation = 0;
			i1100.alpha = 0.3;
			i1100.filters = null;
			i1100.visible = true;
			i1102.x = 240.7;
			i1102.scaleX = 0.63;
			i1102.y = -103.2;
			i1102.scaleY = 0.63;
			i1102.rotation = 0;
			i1102.alpha = 1;
			i1102.filters = null;
			i1102.visible = true;
			Link16.x = 140.6;
			Link16.scaleX = 1;
			Link16.y = -293.3;
			Link16.scaleY = 1;
			Link16.rotation = 0;
			Link16.alpha = 1;
			Link16.filters = null;
			Link16.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1209);
		f.Add(i1100);
		f.Add(i201);
		f.Add(i1102);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i1097);
		f.Add(i1099);
		f += () => {
			i1209.x = 0;
			i1209.scaleX = 1;
			i1209.y = 0;
			i1209.scaleY = 1;
			i1209.rotation = 0;
			i1209.alpha = 1;
			i1209.filters = null;
			i1209.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1209);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(i1099);
		f += () => {
			i1210.x = 240.7;
			i1210.scaleX = 0.63;
			i1210.y = -103.2;
			i1210.scaleY = 0.63;
			i1210.rotation = 0;
			i1210.alpha = 1;
			i1210.filters = null;
			i1210.visible = true;
			Link17.x = 331.1;
			Link17.scaleX = 1;
			Link17.y = -278.8;
			Link17.scaleY = 1;
			Link17.rotation = 0;
			Link17.alpha = 1;
			Link17.filters = null;
			Link17.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1100);
		f.Add(i1321);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(i1099);
		f += () => {
			i1321.x = 0;
			i1321.scaleX = 1;
			i1321.y = 0;
			i1321.scaleY = 1;
			i1321.rotation = 0;
			i1321.alpha = 1;
			i1321.filters = null;
			i1321.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1100);
		f.Add(i1321);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f += () => {
			Link18.x = 117.1;
			Link18.scaleX = 1;
			Link18.y = -225.8;
			Link18.scaleY = 1;
			Link18.rotation = 0;
			Link18.alpha = 1;
			Link18.filters = null;
			Link18.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1323);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f += () => {
			i1323.x = 0;
			i1323.scaleX = 1;
			i1323.y = 0;
			i1323.scaleY = 1;
			i1323.rotation = 0;
			i1323.alpha = 1;
			i1323.filters = null;
			i1323.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1323);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f += () => {
			Link19.x = 430.1;
			Link19.scaleX = 1;
			Link19.y = -132.8;
			Link19.scaleY = 1;
			Link19.rotation = 0;
			Link19.alpha = 1;
			Link19.filters = null;
			Link19.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1325);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f += () => {
			i1325.x = 0;
			i1325.scaleX = 1;
			i1325.y = 0;
			i1325.scaleY = 1;
			i1325.rotation = 0;
			i1325.alpha = 1;
			i1325.filters = null;
			i1325.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1325);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f += () => {
			Link20.x = 335.6;
			Link20.scaleX = 1;
			Link20.y = -190.3;
			Link20.scaleY = 1;
			Link20.rotation = 0;
			Link20.alpha = 1;
			Link20.filters = null;
			Link20.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f += () => {
			i1327.x = 240;
			i1327.scaleX = 1;
			i1327.y = -104;
			i1327.scaleY = 1;
			i1327.rotation = 0;
			i1327.alpha = 1;
			i1327.filters = null;
			i1327.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f += () => {
			Link21.x = 371.1;
			Link21.scaleX = 1;
			Link21.y = -197.3;
			Link21.scaleY = 1;
			Link21.rotation = 0;
			Link21.alpha = 1;
			Link21.filters = null;
			Link21.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(i1329);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f += () => {
			i1329.x = 0;
			i1329.scaleX = 1;
			i1329.y = 0;
			i1329.scaleY = 1;
			i1329.rotation = 0;
			i1329.alpha = 1;
			i1329.filters = null;
			i1329.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(i1329);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f += () => {
			Link22.x = 179.6;
			Link22.scaleX = 1;
			Link22.y = -274.3;
			Link22.scaleY = 1;
			Link22.rotation = 0;
			Link22.alpha = 1;
			Link22.filters = null;
			Link22.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(i1329);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(i1329);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f.Add(Link23);
		f += () => {
			Link23.x = 245.1;
			Link23.scaleX = 1;
			Link23.y = -271.4;
			Link23.scaleY = 1;
			Link23.rotation = 0;
			Link23.alpha = 1;
			Link23.filters = null;
			Link23.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(i1329);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1332);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f.Add(Link23);
		f += () => {
			i1332.x = 0;
			i1332.scaleX = 1;
			i1332.y = 0;
			i1332.scaleY = 1;
			i1332.rotation = 0;
			i1332.alpha = 1;
			i1332.filters = null;
			i1332.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(i1329);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1332);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f.Add(Link23);
		f.Add(Link24);
		f += () => {
			Link24.x = 221.6;
			Link24.scaleX = 1;
			Link24.y = -320.8;
			Link24.scaleY = 1;
			Link24.rotation = 0;
			Link24.alpha = 1;
			Link24.filters = null;
			Link24.visible = true;
		};
		f = l.Add();
		f.Add(frontArea);
		f.Add(stateSprite);
		f.Add(i1327);
		f.Add(i1100);
		f.Add(i201);
		f.Add(Link1);
		f.Add(i1210);
		f.Add(i1329);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1332);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(i797);
		f.Add(Link13);
		f.Add(Link14);
		f.Add(i799);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(Link17);
		f.Add(i1097);
		f.Add(Link18);
		f.Add(i1099);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f.Add(Link23);
		f.Add(Link24);
		f.Add(Link25);
		f += () => {
			Link25.x = 270.6;
			Link25.scaleX = 1;
			Link25.y = -306.3;
			Link25.scaleY = 1;
			Link25.rotation = 0;
			Link25.alpha = 1;
			Link25.filters = null;
			Link25.visible = true;
		};
		setFrames(l);
	}
}
public class TreeGrowthIconBottles : BitmapData{ 
	public TreeGrowthIconBottles() {
		width = 14;
		height = 22;
		setPixels("d12c4fa738440d2888d3f6cb4028c4d6");
	}
}
public class TreeGrowthIconGifts : BitmapData{ 
	public TreeGrowthIconGifts() {
		width = 14;
		height = 19;
		setPixels("f9b500a7e23f2ec5c9c7158c0a97591e");
	}
}
public class TreeGrowthIconHearts : BitmapData{ 
	public TreeGrowthIconHearts() {
		width = 21;
		height = 17;
		setPixels("d021bcec1eecf4b545c436ea5eef59a2");
	}
}
public class TreeGrowthIconKisses : BitmapData{ 
	public TreeGrowthIconKisses() {
		width = 24;
		height = 14;
		setPixels("2454c39b4399cd26ef22a57e2d1c2e20");
	}
}
public class TreeGrowthIconPayments : BitmapData{ 
	public TreeGrowthIconPayments() {
		width = 19;
		height = 21;
		setPixels("f90cbfdda1b2af9b4435a6e17bccf8ae");
	}
}
public class TreeGrowthIconPicGrade : BitmapData{ 
	public TreeGrowthIconPicGrade() {
		width = 21;
		height = 19;
		setPixels("a20bc6e7afa8ea6581c2f3cee07fa0bf");
	}
}
public class TreeGrowthIconPosting : BitmapData{ 
	public TreeGrowthIconPosting() {
		width = 16;
		height = 22;
		setPixels("e66d5a5b1659565d8cddb497155b4cb1");
	}
}
public class TreeGrowthIconVip : BitmapData{ 
	public TreeGrowthIconVip() {
		width = 24;
		height = 20;
		setPixels("feeb6a77aca9771e68fa912100a13296");
	}
}
public class TreeIconAdmire : BitmapData{ 
	public TreeIconAdmire() {
		width = 14;
		height = 9;
		setPixels("0d975fbbb095a7a95edc7b0564b4469a");
	}
}
public class TreeIconAdmireBig : BitmapData{ 
	public TreeIconAdmireBig() {
		width = 29;
		height = 20;
		setPixels("4351c265ad73912aee65e3ff7eac6010");
	}
}
public class TreeIconFriends : BitmapData{ 
	public TreeIconFriends() {
		width = 13;
		height = 11;
		setPixels("9b5b9f459720381c915ee28fa48698dd");
	}
}
public class TreeIconFriendsBig : BitmapData{ 
	public TreeIconFriendsBig() {
		width = 36;
		height = 28;
		setPixels("8701910a7ee14cf5ed1d0bab7612c1c2");
	}
}
public class TreeIconGifts : BitmapData{ 
	public TreeIconGifts() {
		width = 8;
		height = 11;
		setPixels("084835b1b7f1a83d23b0edfff8a1f0ad");
	}
}
public class TreeIconGiftsBig : BitmapData{ 
	public TreeIconGiftsBig() {
		width = 26;
		height = 31;
		setPixels("94dbc9eb13ab7ee2f270119c6644b8c8");
	}
}
public class TreeIconHearts : BitmapData{ 
	public TreeIconHearts() {
		width = 10;
		height = 9;
		setPixels("8f180b68c296063ec5e149e321dcedc5");
	}
}
public class TreeIconHeartsBig : BitmapData{ 
	public TreeIconHeartsBig() {
		width = 30;
		height = 27;
		setPixels("cd162a87762711b9933fbe9c6418452a");
	}
}
public class TreeIconHouse : BitmapData{ 
	public TreeIconHouse() {
		width = 10;
		height = 10;
		setPixels("8335cb29452612f8f0876ffe72ef58af");
	}
}
public class TreeIconHouseBig : BitmapData{ 
	public TreeIconHouseBig() {
		width = 29;
		height = 31;
		setPixels("e17e6f9c92d002446ce39505bbe8db08");
	}
}
public class TreeIconKisses : BitmapData{ 
	public TreeIconKisses() {
		width = 16;
		height = 10;
		setPixels("bd53c175d81f9f5eb759fd449fecb894");
	}
}
public class TreeIconKissesBig : BitmapData{ 
	public TreeIconKissesBig() {
		width = 35;
		height = 23;
		setPixels("33836e8d88bcc627b2427c889326891f");
	}
}
public class TreeIconPets : BitmapData{ 
	public TreeIconPets() {
		width = 15;
		height = 11;
		setPixels("0468a262050879024df4468c7fed9bb5");
	}
}
public class TreeIconPetsBig : BitmapData{ 
	public TreeIconPetsBig() {
		width = 31;
		height = 27;
		setPixels("50a8c554f8a5f4f7b10d8b9015198258");
	}
}
public class TreeIconPhotos : BitmapData{ 
	public TreeIconPhotos() {
		width = 13;
		height = 10;
		setPixels("cec9644790f7835e3cea6aca032a8034");
	}
}
public class TreeIconPhotosBig : BitmapData{ 
	public TreeIconPhotosBig() {
		width = 31;
		height = 31;
		setPixels("5c10bfc11864be62ab4faa78f0ee74a5");
	}
}
public class TreeIconVip : BitmapData{ 
	public TreeIconVip() {
		width = 15;
		height = 14;
		setPixels("506448bc0dfd8dd25a4001b7582c84fe");
	}
}
public class TreeIconVipBig : BitmapData{ 
	public TreeIconVipBig() {
		width = 33;
		height = 27;
		setPixels("eedd639ae7bb1b4de91a9e72bd5e70d8");
	}
}
public class TreePhotoSelectedImg : BitmapData{ 
	public TreePhotoSelectedImg() {
		width = 18;
		height = 18;
		setPixels("9ae631e939c14b6f3d17281783e073ec");
	}
}
public class TreeViewClip : MovieClip{ 
	public MovieClip Link24;
	public MovieClip Link15;
	public MovieClip Link4;
	public MovieClip Link5;
	public MovieClip Link25;
	public MovieClip Link16;
	public MovieClip Link6;
	public MovieClip Link17;
	public MovieClip Link9;
	public MovieClip Link7;
	public MovieClip Link19;
	public MovieClip Link10;
	public MovieClip Link11;
	public MovieClip Link20;
	public MovieClip Link12;
	public MovieClip Link1;
	public MovieClip Link21;
	public MovieClip Link8;
	public MovieClip Link18;
	public MovieClip Link22;
	public MovieClip Link2;
	public MovieClip Link23;
	public MovieClip Link14;
	public MovieClip Link3;
	public MovieClip Link13;
	public TreeViewClip() {
		var i2590 = new symbol_1315();
		addChild(i2590);//0
		var i1464 = new symbol_773(){x = 3.6 , scaleX = 1.26 , y = 35.2 , scaleY = 2.08 , alpha = 0.3};
		addChild(i1464);//0
		var i1889 = new symbol_980(){x = 3.6 , scaleX = 1.26 , y = 35.2 , scaleY = 2.08 , alpha = 0.3};
		addChild(i1889);//0
		var i2586 = new symbol_1311();
		addChild(i2586);//0
		var i2588 = new symbol_1313();
		addChild(i2588);//0
		var i2592 = new symbol_698();
		addChild(i2592);//0
		var i1336 = new symbol_706(){x = 5.6 , scaleX = 1.26 , y = 35.2 , scaleY = 2.08 , alpha = 0.3};
		addChild(i1336);//0
		var i2365 = new symbol_1207(){x = 3.6 , scaleX = 1.26 , y = 35.2 , scaleY = 2.08 , alpha = 0.3};
		addChild(i2365);//0
		var i2474 = new symbol_1258();
		addChild(i2474);//0
		var i1428 = new symbol_754(){x = 0.3 , scaleX = 0.63 , y = 15 , scaleY = 0.63};
		addChild(i1428);//1
		var i1338 = new symbol_707(){x = 2.4 , scaleX = 0.63 , y = 15 , scaleY = 0.63};
		addChild(i1338);//1
		var i1466 = new symbol_774(){x = 0.3 , scaleX = 0.63 , y = 15 , scaleY = 0.63};
		addChild(i1466);//1
		var i1362 = new symbol_727(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1362);//2
		var i1568 = new symbol_848(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1568);//2
		var i1349 = new symbol_718(){x = 2.6 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1349);//2
		var i2158 = new symbol_1155(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i2158);//2
		var i1519 = new symbol_820(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1519);//2
		var i1975 = new symbol_1061(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1975);//2
		var i1468 = new symbol_796(){x = 0.4 , scaleX = 0.63 , y = 1 , scaleY = 0.63};
		addChild(i1468);//2
		var i1746 = new symbol_939(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1746);//2
		var i2065 = new symbol_1107(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i2065);//2
		var i1430 = new symbol_770(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1430);//2
		var i1402 = new symbol_752(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1402);//2
		var i1625 = new symbol_878(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1625);//2
		var i2367 = new symbol_1256(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i2367);//2
		var i1687 = new symbol_908(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1687);//2
		var i1340 = new symbol_708(){x = 2.6 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1340);//2
		var i1809 = new symbol_978(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1809);//2
		var i1342 = new symbol_711(){x = 2.6 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1342);//2
		var i2260 = new symbol_1203(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i2260);//2
		var i1892 = new symbol_1019(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1892);//2
		var i1379 = new symbol_739(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i1379);//2
		var i1348 = new symbol_712();
		addChild(i1348);//3
		var i2475 = new symbol_1309(){x = 0.7 , scaleX = 0.63 , y = 0.8 , scaleY = 0.63};
		addChild(i2475);//3
		Link1 = new symbol_719(){y = -23.8 , x = 31.6};
		addChild(Link1);//3
		var i2594 = new symbol_1318();
		addChild(i2594);//4
		Link2 = new symbol_740(){y = -33.9 , x = -11.8};
		addChild(Link2);//4
		var i1378 = new symbol_728();
		addChild(i1378);//4
		var i2597 = new symbol_1321();
		addChild(i2597);//5
		Link3 = new symbol_771(){y = -52.3 , x = 75.7};
		addChild(Link3);//5
		var i1427 = new symbol_753();
		addChild(i1427);//5
		Link4 = new symbol_797(){y = -29.9 , x = -49.9};
		addChild(Link4);//6
		var i1463 = new symbol_772();
		addChild(i1463);//7
		Link5 = new symbol_821(){y = -56.8 , x = -91.3};
		addChild(Link5);//7
		var i1518 = new symbol_798();
		addChild(i1518);//8
		Link6 = new symbol_849(){y = -84.8 , x = 29.1};
		addChild(Link6);//8
		var i1567 = new symbol_822();
		addChild(i1567);//9
		var i1624 = new symbol_850();
		addChild(i1624);//9
		Link7 = new symbol_879(){y = -83.3 , x = -45.9};
		addChild(Link7);//9
		var i1686 = new symbol_880();
		addChild(i1686);//10
		Link8 = new symbol_909(){y = -43.2 , x = 117};
		addChild(Link8);//10
		Link9 = new symbol_940(){y = -44.3 , x = -134.9};
		addChild(Link9);//11
		Link10 = new symbol_979(){y = -118.8 , x = -9.9};
		addChild(Link10);//12
		var i1891 = new symbol_981();
		addChild(i1891);//13
		Link11 = new symbol_1020(){y = -61.3 , x = 160.2};
		addChild(Link11);//13
		var i1808 = new symbol_941();
		addChild(i1808);//13
		Link12 = new symbol_1062(){y = -41.3 , x = -177.4};
		addChild(Link12);//14
		var i1974 = new symbol_1021();
		addChild(i1974);//14
		Link13 = new symbol_1108(){y = -139.3 , x = 63.1};
		addChild(Link13);//15
		var i2062 = new symbol_1063(){x = 82.3 , scaleX = 1.26 , y = 40.5 , scaleY = 2.08 , alpha = 0.3};
		addChild(i2062);//15
		var i2064 = new symbol_1064();
		addChild(i2064);//16
		Link14 = new symbol_1156(){y = -121.8 , x = -80.8};
		addChild(Link14);//16
		Link15 = new symbol_1204(){y = -174.3 , x = 133.1};
		addChild(Link15);//17
		Link16 = new symbol_1257(){y = -189.3 , x = -99.4};
		addChild(Link16);//18
		var i2362 = new symbol_1205(){x = -106.9 , scaleX = 1.26 , y = 40.5 , scaleY = 2.08 , alpha = 0.3};
		addChild(i2362);//20
		Link17 = new symbol_1310(){y = -174.8 , x = 91.1};
		addChild(Link17);//20
		var i2364 = new symbol_1206();
		addChild(i2364);//21
		Link18 = new symbol_1312(){y = -121.8 , x = -122.9};
		addChild(Link18);//21
		Link19 = new symbol_1314(){y = -28.8 , x = 190.2};
		addChild(Link19);//22
		Link20 = new symbol_1316(){y = -86.3 , x = 95.6};
		addChild(Link20);//23
		Link21 = new symbol_1317(){y = -93.3 , x = 131.1};
		addChild(Link21);//24
		Link22 = new symbol_1319(){y = -170.3 , x = -60.4};
		addChild(Link22);//26
		Link23 = new symbol_1320(){y = -167.3 , x = 5.1};
		addChild(Link23);//27
		Link24 = new symbol_1322(){y = -216.8 , x = -18.4};
		addChild(Link24);//29
		Link25 = new symbol_1323(){y = -202.3 , x = 30.6};
		addChild(Link25);//30
		FrameInfo f;
		var l= new Frames(50);
		f = l.Add();
		f.Add(i1336);
		f.Add(i1338);
		f.Add(i1340);
		f += () => {
			i1336.x = 5.6;
			i1336.scaleX = 1.26;
			i1336.y = 35.2;
			i1336.scaleY = 2.08;
			i1336.rotation = 0;
			i1336.alpha = 0.3;
			i1336.filters = null;
			i1336.visible = true;
			i1338.x = 2.4;
			i1338.scaleX = 0.63;
			i1338.y = 15;
			i1338.scaleY = 0.63;
			i1338.rotation = 0;
			i1338.alpha = 1;
			i1338.filters = null;
			i1338.visible = true;
			i1340.x = 2.6;
			i1340.scaleX = 0.63;
			i1340.y = 0.8;
			i1340.scaleY = 0.63;
			i1340.rotation = 0;
			i1340.alpha = 1;
			i1340.filters = null;
			i1340.visible = true;
		};
		f = l.Add();
		f.Add(i1336);
		f.Add(i1338);
		f.Add(i1342);
		f.Add(i1348);
		f += () => {
			i1342.x = 2.6;
			i1342.scaleX = 0.63;
			i1342.y = 0.8;
			i1342.scaleY = 0.63;
			i1342.rotation = 0;
			i1342.alpha = 1;
			i1342.filters = null;
			i1342.visible = true;
			i1348.x = 0;
			i1348.scaleX = 1;
			i1348.y = 0;
			i1348.scaleY = 1;
			i1348.rotation = 0;
			i1348.alpha = 1;
			i1348.filters = null;
			i1348.visible = true;
		};
		f = l.Add();
		f.Add(i1336);
		f.Add(i1338);
		f.Add(i1349);
		f.Add(i1348);
		f.Add(Link1);
		f += () => {
			i1349.x = 2.6;
			i1349.scaleX = 0.63;
			i1349.y = 0.8;
			i1349.scaleY = 0.63;
			i1349.rotation = 0;
			i1349.alpha = 1;
			i1349.filters = null;
			i1349.visible = true;
			Link1.x = 31.6;
			Link1.scaleX = 1;
			Link1.y = -23.8;
			Link1.scaleY = 1;
			Link1.rotation = 0;
			Link1.alpha = 1;
			Link1.filters = null;
			Link1.visible = true;
		};
		f = l.Add();
		f.Add(i1336);
		f.Add(i1338);
		f.Add(i1362);
		f.Add(Link1);
		f.Add(i1378);
		f += () => {
			i1362.x = 0.7;
			i1362.scaleX = 0.63;
			i1362.y = 0.8;
			i1362.scaleY = 0.63;
			i1362.rotation = 0;
			i1362.alpha = 1;
			i1362.filters = null;
			i1362.visible = true;
			Link1.x = 29.6;
			Link1.y = -25.8;
			i1378.x = 0;
			i1378.scaleX = 1;
			i1378.y = 0;
			i1378.scaleY = 1;
			i1378.rotation = 0;
			i1378.alpha = 1;
			i1378.filters = null;
			i1378.visible = true;
		};
		f = l.Add();
		f.Add(i1336);
		f.Add(i1338);
		f.Add(i1379);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(i1378);
		f += () => {
			i1379.x = 0.7;
			i1379.scaleX = 0.63;
			i1379.y = 0.8;
			i1379.scaleY = 0.63;
			i1379.rotation = 0;
			i1379.alpha = 1;
			i1379.filters = null;
			i1379.visible = true;
			Link1.y = -22.8;
			Link2.x = -11.8;
			Link2.scaleX = 1;
			Link2.y = -33.9;
			Link2.scaleY = 1;
			Link2.rotation = 0;
			Link2.alpha = 1;
			Link2.filters = null;
			Link2.visible = true;
		};
		f = l.Add();
		f.Add(i1336);
		f.Add(i1338);
		f.Add(i1402);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(i1427);
		f += () => {
			i1402.x = 0.7;
			i1402.scaleX = 0.63;
			i1402.y = 0.8;
			i1402.scaleY = 0.63;
			i1402.rotation = 0;
			i1402.alpha = 1;
			i1402.filters = null;
			i1402.visible = true;
			i1427.x = 0;
			i1427.scaleX = 1;
			i1427.y = 0;
			i1427.scaleY = 1;
			i1427.rotation = 0;
			i1427.alpha = 1;
			i1427.filters = null;
			i1427.visible = true;
		};
		f = l.Add();
		f.Add(i1336);
		f.Add(i1428);
		f.Add(i1430);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1427);
		f += () => {
			i1428.x = 0.3;
			i1428.scaleX = 0.63;
			i1428.y = 15;
			i1428.scaleY = 0.63;
			i1428.rotation = 0;
			i1428.alpha = 1;
			i1428.filters = null;
			i1428.visible = true;
			i1430.x = 0.7;
			i1430.scaleX = 0.63;
			i1430.y = 0.8;
			i1430.scaleY = 0.63;
			i1430.rotation = 0;
			i1430.alpha = 1;
			i1430.filters = null;
			i1430.visible = true;
			Link3.x = 75.7;
			Link3.scaleX = 1;
			Link3.y = -52.3;
			Link3.scaleY = 1;
			Link3.rotation = 0;
			Link3.alpha = 1;
			Link3.filters = null;
			Link3.visible = true;
		};
		f = l.Add();
		f.Add(i1336);
		f.Add(i1428);
		f.Add(i1430);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1427);
		f.Add(i1463);
		f += () => {
			i1463.x = 0;
			i1463.scaleX = 1;
			i1463.y = 0;
			i1463.scaleY = 1;
			i1463.rotation = 0;
			i1463.alpha = 1;
			i1463.filters = null;
			i1463.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1468);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1427);
		f.Add(Link4);
		f.Add(i1463);
		f += () => {
			i1464.x = 3.6;
			i1464.scaleX = 1.26;
			i1464.y = 35.2;
			i1464.scaleY = 2.08;
			i1464.rotation = 0;
			i1464.alpha = 0.3;
			i1464.filters = null;
			i1464.visible = true;
			i1466.x = 0.3;
			i1466.scaleX = 0.63;
			i1466.y = 15;
			i1466.scaleY = 0.63;
			i1466.rotation = 0;
			i1466.alpha = 1;
			i1466.filters = null;
			i1466.visible = true;
			i1468.x = 0.4;
			i1468.scaleX = 0.63;
			i1468.y = 1;
			i1468.scaleY = 0.63;
			i1468.rotation = 0;
			i1468.alpha = 1;
			i1468.filters = null;
			i1468.visible = true;
			Link1.y = -27.8;
			Link3.y = -56.3;
			Link4.x = -49.9;
			Link4.scaleX = 1;
			Link4.y = -29.9;
			Link4.scaleY = 1;
			Link4.rotation = 0;
			Link4.alpha = 1;
			Link4.filters = null;
			Link4.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1468);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1427);
		f.Add(Link4);
		f.Add(i1518);
		f += () => {
			i1518.x = 0;
			i1518.scaleX = 1;
			i1518.y = 0;
			i1518.scaleY = 1;
			i1518.rotation = 0;
			i1518.alpha = 1;
			i1518.filters = null;
			i1518.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1519);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1427);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(i1518);
		f += () => {
			i1519.x = 0.7;
			i1519.scaleX = 0.63;
			i1519.y = 0.8;
			i1519.scaleY = 0.63;
			i1519.rotation = 0;
			i1519.alpha = 1;
			i1519.filters = null;
			i1519.visible = true;
			Link1.y = -28.8;
			Link4.y = -30.9;
			Link5.x = -91.3;
			Link5.scaleX = 1;
			Link5.y = -56.8;
			Link5.scaleY = 1;
			Link5.rotation = 0;
			Link5.alpha = 1;
			Link5.filters = null;
			Link5.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1519);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1427);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(i1567);
		f += () => {
			i1567.x = 0;
			i1567.scaleX = 1;
			i1567.y = 0;
			i1567.scaleY = 1;
			i1567.rotation = 0;
			i1567.alpha = 1;
			i1567.filters = null;
			i1567.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1568);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(i1427);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i1567);
		f += () => {
			i1568.x = 0.7;
			i1568.scaleX = 0.63;
			i1568.y = 0.8;
			i1568.scaleY = 0.63;
			i1568.rotation = 0;
			i1568.alpha = 1;
			i1568.filters = null;
			i1568.visible = true;
			Link6.x = 29.1;
			Link6.scaleX = 1;
			Link6.y = -84.8;
			Link6.scaleY = 1;
			Link6.rotation = 0;
			Link6.alpha = 1;
			Link6.filters = null;
			Link6.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1568);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i1567);
		f.Add(i1624);
		f += () => {
			i1624.x = 0;
			i1624.scaleX = 1;
			i1624.y = 0;
			i1624.scaleY = 1;
			i1624.rotation = 0;
			i1624.alpha = 1;
			i1624.filters = null;
			i1624.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1625);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i1567);
		f.Add(i1624);
		f.Add(Link7);
		f += () => {
			i1625.x = 0.7;
			i1625.scaleX = 0.63;
			i1625.y = 0.8;
			i1625.scaleY = 0.63;
			i1625.rotation = 0;
			i1625.alpha = 1;
			i1625.filters = null;
			i1625.visible = true;
			Link6.y = -86.8;
			Link7.x = -45.9;
			Link7.scaleX = 1;
			Link7.y = -83.3;
			Link7.scaleY = 1;
			Link7.rotation = 0;
			Link7.alpha = 1;
			Link7.filters = null;
			Link7.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1625);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i1567);
		f.Add(Link7);
		f.Add(i1686);
		f += () => {
			i1686.x = 0;
			i1686.scaleX = 1;
			i1686.y = 0;
			i1686.scaleY = 1;
			i1686.rotation = 0;
			i1686.alpha = 1;
			i1686.filters = null;
			i1686.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1687);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i1567);
		f.Add(Link7);
		f.Add(i1686);
		f.Add(Link8);
		f += () => {
			i1687.x = 0.7;
			i1687.scaleX = 0.63;
			i1687.y = 0.8;
			i1687.scaleY = 0.63;
			i1687.rotation = 0;
			i1687.alpha = 1;
			i1687.filters = null;
			i1687.visible = true;
			Link3.y = -58.3;
			Link8.x = 117;
			Link8.scaleX = 1;
			Link8.y = -43.2;
			Link8.scaleY = 1;
			Link8.rotation = 0;
			Link8.alpha = 1;
			Link8.filters = null;
			Link8.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1687);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i1567);
		f.Add(Link7);
		f.Add(i1686);
		f.Add(Link8);
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1746);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(i1567);
		f.Add(Link7);
		f.Add(i1686);
		f.Add(Link8);
		f.Add(Link9);
		f += () => {
			i1746.x = 0.7;
			i1746.scaleX = 0.63;
			i1746.y = 0.8;
			i1746.scaleY = 0.63;
			i1746.rotation = 0;
			i1746.alpha = 1;
			i1746.filters = null;
			i1746.visible = true;
			Link9.x = -134.9;
			Link9.scaleX = 1;
			Link9.y = -44.3;
			Link9.scaleY = 1;
			Link9.rotation = 0;
			Link9.alpha = 1;
			Link9.filters = null;
			Link9.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1746);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(i1686);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(i1808);
		f += () => {
			i1808.x = 0;
			i1808.scaleX = 1;
			i1808.y = 0;
			i1808.scaleY = 1;
			i1808.rotation = 0;
			i1808.alpha = 1;
			i1808.filters = null;
			i1808.visible = true;
		};
		f = l.Add();
		f.Add(i1464);
		f.Add(i1466);
		f.Add(i1809);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(i1686);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i1808);
		f += () => {
			i1809.x = 0.7;
			i1809.scaleX = 0.63;
			i1809.y = 0.8;
			i1809.scaleY = 0.63;
			i1809.rotation = 0;
			i1809.alpha = 1;
			i1809.filters = null;
			i1809.visible = true;
			Link3.y = -53.3;
			Link8.y = -39.2;
			Link10.x = -9.9;
			Link10.scaleX = 1;
			Link10.y = -118.8;
			Link10.scaleY = 1;
			Link10.rotation = 0;
			Link10.alpha = 1;
			Link10.filters = null;
			Link10.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i1809);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i1891);
		f.Add(i1808);
		f += () => {
			i1889.x = 3.6;
			i1889.scaleX = 1.26;
			i1889.y = 35.2;
			i1889.scaleY = 2.08;
			i1889.rotation = 0;
			i1889.alpha = 0.3;
			i1889.filters = null;
			i1889.visible = true;
			i1891.x = 0;
			i1891.scaleX = 1;
			i1891.y = 0;
			i1891.scaleY = 1;
			i1891.rotation = 0;
			i1891.alpha = 1;
			i1891.filters = null;
			i1891.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i1892);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(i1891);
		f.Add(Link11);
		f.Add(i1808);
		f += () => {
			i1892.x = 0.7;
			i1892.scaleX = 0.63;
			i1892.y = 0.8;
			i1892.scaleY = 0.63;
			i1892.rotation = 0;
			i1892.alpha = 1;
			i1892.filters = null;
			i1892.visible = true;
			Link11.x = 160.2;
			Link11.scaleX = 1;
			Link11.y = -61.3;
			Link11.scaleY = 1;
			Link11.rotation = 0;
			Link11.alpha = 1;
			Link11.filters = null;
			Link11.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i1892);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(i1808);
		f.Add(i1974);
		f += () => {
			i1974.x = 0;
			i1974.scaleX = 1;
			i1974.y = 0;
			i1974.scaleY = 1;
			i1974.rotation = 0;
			i1974.alpha = 1;
			i1974.filters = null;
			i1974.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i1975);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(i1808);
		f.Add(Link12);
		f.Add(i1974);
		f += () => {
			i1975.x = 0.7;
			i1975.scaleX = 0.63;
			i1975.y = 0.8;
			i1975.scaleY = 0.63;
			i1975.rotation = 0;
			i1975.alpha = 1;
			i1975.filters = null;
			i1975.visible = true;
			Link12.x = -177.4;
			Link12.scaleX = 1;
			Link12.y = -41.3;
			Link12.scaleY = 1;
			Link12.rotation = 0;
			Link12.alpha = 1;
			Link12.filters = null;
			Link12.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i1975);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(i1808);
		f.Add(Link12);
		f.Add(i2062);
		f.Add(i2064);
		f += () => {
			i2062.x = 82.3;
			i2062.scaleX = 1.26;
			i2062.y = 40.5;
			i2062.scaleY = 2.08;
			i2062.rotation = 0;
			i2062.alpha = 0.3;
			i2062.filters = null;
			i2062.visible = true;
			i2064.x = 0;
			i2064.scaleX = 1;
			i2064.y = 0;
			i2064.scaleY = 1;
			i2064.rotation = 0;
			i2064.alpha = 1;
			i2064.filters = null;
			i2064.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i2065);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(i1808);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f += () => {
			i2065.x = 0.7;
			i2065.scaleX = 0.63;
			i2065.y = 0.8;
			i2065.scaleY = 0.63;
			i2065.rotation = 0;
			i2065.alpha = 1;
			i2065.filters = null;
			i2065.visible = true;
			Link13.x = 63.1;
			Link13.scaleX = 1;
			Link13.y = -139.3;
			Link13.scaleY = 1;
			Link13.rotation = 0;
			Link13.alpha = 1;
			Link13.filters = null;
			Link13.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i2065);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(i1808);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i2158);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(i1808);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f += () => {
			i2158.x = 0.7;
			i2158.scaleX = 0.63;
			i2158.y = 0.8;
			i2158.scaleY = 0.63;
			i2158.rotation = 0;
			i2158.alpha = 1;
			i2158.filters = null;
			i2158.visible = true;
			Link14.x = -80.8;
			Link14.scaleX = 1;
			Link14.y = -121.8;
			Link14.scaleY = 1;
			Link14.rotation = 0;
			Link14.alpha = 1;
			Link14.filters = null;
			Link14.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i2158);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(i1808);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i2260);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(i1808);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f += () => {
			i2260.x = 0.7;
			i2260.scaleX = 0.63;
			i2260.y = 0.8;
			i2260.scaleY = 0.63;
			i2260.rotation = 0;
			i2260.alpha = 1;
			i2260.filters = null;
			i2260.visible = true;
			Link15.x = 133.1;
			Link15.scaleX = 1;
			Link15.y = -174.3;
			Link15.scaleY = 1;
			Link15.rotation = 0;
			Link15.alpha = 1;
			Link15.filters = null;
			Link15.visible = true;
		};
		f = l.Add();
		f.Add(i1889);
		f.Add(i1466);
		f.Add(i2260);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(i2362);
		f.Add(i2364);
		f += () => {
			i2362.x = -106.9;
			i2362.scaleX = 1.26;
			i2362.y = 40.5;
			i2362.scaleY = 2.08;
			i2362.rotation = 0;
			i2362.alpha = 0.3;
			i2362.filters = null;
			i2362.visible = true;
			i2364.x = 0;
			i2364.scaleX = 1;
			i2364.y = 0;
			i2364.scaleY = 1;
			i2364.rotation = 0;
			i2364.alpha = 1;
			i2364.filters = null;
			i2364.visible = true;
		};
		f = l.Add();
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2367);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(i2364);
		f += () => {
			i2365.x = 3.6;
			i2365.scaleX = 1.26;
			i2365.y = 35.2;
			i2365.scaleY = 2.08;
			i2365.rotation = 0;
			i2365.alpha = 0.3;
			i2365.filters = null;
			i2365.visible = true;
			i2367.x = 0.7;
			i2367.scaleX = 0.63;
			i2367.y = 0.8;
			i2367.scaleY = 0.63;
			i2367.rotation = 0;
			i2367.alpha = 1;
			i2367.filters = null;
			i2367.visible = true;
			Link16.x = -99.4;
			Link16.scaleX = 1;
			Link16.y = -189.3;
			Link16.scaleY = 1;
			Link16.rotation = 0;
			Link16.alpha = 1;
			Link16.filters = null;
			Link16.visible = true;
		};
		f = l.Add();
		f.Add(i2365);
		f.Add(i2474);
		f.Add(i1466);
		f.Add(i2367);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(i2364);
		f += () => {
			i2474.x = 0;
			i2474.scaleX = 1;
			i2474.y = 0;
			i2474.scaleY = 1;
			i2474.rotation = 0;
			i2474.alpha = 1;
			i2474.filters = null;
			i2474.visible = true;
		};
		f = l.Add();
		f.Add(i2365);
		f.Add(i2474);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f += () => {
			i2475.x = 0.7;
			i2475.scaleX = 0.63;
			i2475.y = 0.8;
			i2475.scaleY = 0.63;
			i2475.rotation = 0;
			i2475.alpha = 1;
			i2475.filters = null;
			i2475.visible = true;
			Link17.x = 91.1;
			Link17.scaleX = 1;
			Link17.y = -174.8;
			Link17.scaleY = 1;
			Link17.rotation = 0;
			Link17.alpha = 1;
			Link17.filters = null;
			Link17.visible = true;
		};
		f = l.Add();
		f.Add(i2586);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f += () => {
			i2586.x = 0;
			i2586.scaleX = 1;
			i2586.y = 0;
			i2586.scaleY = 1;
			i2586.rotation = 0;
			i2586.alpha = 1;
			i2586.filters = null;
			i2586.visible = true;
		};
		f = l.Add();
		f.Add(i2586);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f += () => {
			Link18.x = -122.9;
			Link18.scaleX = 1;
			Link18.y = -121.8;
			Link18.scaleY = 1;
			Link18.rotation = 0;
			Link18.alpha = 1;
			Link18.filters = null;
			Link18.visible = true;
		};
		f = l.Add();
		f.Add(i2588);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f += () => {
			i2588.x = 0;
			i2588.scaleX = 1;
			i2588.y = 0;
			i2588.scaleY = 1;
			i2588.rotation = 0;
			i2588.alpha = 1;
			i2588.filters = null;
			i2588.visible = true;
		};
		f = l.Add();
		f.Add(i2588);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f += () => {
			Link19.x = 190.2;
			Link19.scaleX = 1;
			Link19.y = -28.8;
			Link19.scaleY = 1;
			Link19.rotation = 0;
			Link19.alpha = 1;
			Link19.filters = null;
			Link19.visible = true;
		};
		f = l.Add();
		f.Add(i2590);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f += () => {
			i2590.x = 0;
			i2590.scaleX = 1;
			i2590.y = 0;
			i2590.scaleY = 1;
			i2590.rotation = 0;
			i2590.alpha = 1;
			i2590.filters = null;
			i2590.visible = true;
		};
		f = l.Add();
		f.Add(i2590);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f += () => {
			Link20.x = 95.6;
			Link20.scaleX = 1;
			Link20.y = -86.3;
			Link20.scaleY = 1;
			Link20.rotation = 0;
			Link20.alpha = 1;
			Link20.filters = null;
			Link20.visible = true;
		};
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f += () => {
			i2592.x = 0;
			i2592.scaleX = 1;
			i2592.y = 0;
			i2592.scaleY = 1;
			i2592.rotation = 0;
			i2592.alpha = 1;
			i2592.filters = null;
			i2592.visible = true;
		};
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f += () => {
			Link21.x = 131.1;
			Link21.scaleX = 1;
			Link21.y = -93.3;
			Link21.scaleY = 1;
			Link21.rotation = 0;
			Link21.alpha = 1;
			Link21.filters = null;
			Link21.visible = true;
		};
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(i2594);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f += () => {
			i2594.x = 0;
			i2594.scaleX = 1;
			i2594.y = 0;
			i2594.scaleY = 1;
			i2594.rotation = 0;
			i2594.alpha = 1;
			i2594.filters = null;
			i2594.visible = true;
		};
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(i2594);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f += () => {
			Link22.x = -60.4;
			Link22.scaleX = 1;
			Link22.y = -170.3;
			Link22.scaleY = 1;
			Link22.rotation = 0;
			Link22.alpha = 1;
			Link22.filters = null;
			Link22.visible = true;
		};
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(i2594);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(i2594);
		f.Add(Link2);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f.Add(Link23);
		f += () => {
			Link23.x = 5.1;
			Link23.scaleX = 1;
			Link23.y = -167.3;
			Link23.scaleY = 1;
			Link23.rotation = 0;
			Link23.alpha = 1;
			Link23.filters = null;
			Link23.visible = true;
		};
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(i2594);
		f.Add(Link2);
		f.Add(i2597);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f.Add(Link23);
		f += () => {
			i2597.x = 0;
			i2597.scaleX = 1;
			i2597.y = 0;
			i2597.scaleY = 1;
			i2597.rotation = 0;
			i2597.alpha = 1;
			i2597.filters = null;
			i2597.visible = true;
		};
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(i2594);
		f.Add(Link2);
		f.Add(i2597);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f.Add(Link23);
		f.Add(Link24);
		f += () => {
			Link24.x = -18.4;
			Link24.scaleX = 1;
			Link24.y = -216.8;
			Link24.scaleY = 1;
			Link24.rotation = 0;
			Link24.alpha = 1;
			Link24.filters = null;
			Link24.visible = true;
		};
		f = l.Add();
		f.Add(i2592);
		f.Add(i2365);
		f.Add(i1466);
		f.Add(i2475);
		f.Add(Link1);
		f.Add(i2594);
		f.Add(Link2);
		f.Add(i2597);
		f.Add(Link3);
		f.Add(Link4);
		f.Add(Link5);
		f.Add(Link6);
		f.Add(Link7);
		f.Add(Link8);
		f.Add(Link9);
		f.Add(Link10);
		f.Add(Link11);
		f.Add(Link12);
		f.Add(Link13);
		f.Add(i2062);
		f.Add(i2064);
		f.Add(Link14);
		f.Add(Link15);
		f.Add(Link16);
		f.Add(i2362);
		f.Add(Link17);
		f.Add(i2364);
		f.Add(Link18);
		f.Add(Link19);
		f.Add(Link20);
		f.Add(Link21);
		f.Add(Link22);
		f.Add(Link23);
		f.Add(Link24);
		f.Add(Link25);
		f += () => {
			Link25.x = 30.6;
			Link25.scaleX = 1;
			Link25.y = -202.3;
			Link25.scaleY = 1;
			Link25.rotation = 0;
			Link25.alpha = 1;
			Link25.filters = null;
			Link25.visible = true;
		};
		setFrames(l);
	}
}
public class WallPostBg : BitmapData{ 
	public WallPostBg() {
		width = 338;
		height = 238;
		setPixels("dbec1144668fd5039dc5387b848d7dbc");
	}
}
public class WateringCanImg : BitmapData{ 
	public WateringCanImg() {
		width = 63;
		height = 63;
		setPixels("3fe6b635c67f090a982da03e469928b0");
	}
}
namespace loveTree.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("da9c9f9519478b6a2f6306aca290aeee", -14.5, -18, 29, 36, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("8acede517da8a16f9cf09a736b289a08", -11.1, -11.1, 22.25, 22.25, 1, 1);
		}
	}
	public class symbol_10 : MovieClip{ 
		public symbol_10() {
			var i69 = new symbol_9();
			addChild(i69);//0
		}
	}
	public class symbol_100 : Shape{ 
		public symbol_100() {
			setGraphics("5c2282542f86099881853afacd431545", -10.35, -6.1, 20.75, 12.25, 1, 1);
		}
	}
	public class symbol_1000 : MovieClip{ 
		public symbol_1000() {
			var i1935 = new symbol_132();
			addChild(i1935);//0
		}
	}
	public class symbol_1001 : MovieClip{ 
		public symbol_1001() {
			var i1937 = new symbol_115();
			addChild(i1937);//0
		}
	}
	public class symbol_1002 : MovieClip{ 
		public symbol_1002() {
			var i1939 = new symbol_132();
			addChild(i1939);//0
		}
	}
	public class symbol_1003 : MovieClip{ 
		public symbol_1003() {
			var i1941 = new symbol_132();
			addChild(i1941);//0
		}
	}
	public class symbol_1004 : MovieClip{ 
		public symbol_1004() {
			var i1943 = new symbol_132();
			addChild(i1943);//0
		}
	}
	public class symbol_1005 : MovieClip{ 
		public symbol_1005() {
			var i1945 = new symbol_132();
			addChild(i1945);//0
		}
	}
	public class symbol_1006 : MovieClip{ 
		public symbol_1006() {
			var i1947 = new symbol_132();
			addChild(i1947);//0
		}
	}
	public class symbol_1007 : MovieClip{ 
		public symbol_1007() {
			var i1949 = new symbol_115();
			addChild(i1949);//0
		}
	}
	public class symbol_1008 : MovieClip{ 
		public symbol_1008() {
			var i1951 = new symbol_132();
			addChild(i1951);//0
		}
	}
	public class symbol_1009 : MovieClip{ 
		public symbol_1009() {
			var i1953 = new symbol_132();
			addChild(i1953);//0
		}
	}
	public class symbol_101 : MovieClip{ 
		public symbol_101() {
			var i205 = new symbol_100();
			addChild(i205);//0
		}
	}
	public class symbol_1010 : MovieClip{ 
		public symbol_1010() {
			var i1955 = new symbol_132();
			addChild(i1955);//0
		}
	}
	public class symbol_1011 : MovieClip{ 
		public symbol_1011() {
			var i1957 = new symbol_132();
			addChild(i1957);//0
		}
	}
	public class symbol_1012 : MovieClip{ 
		public symbol_1012() {
			var i1959 = new symbol_115();
			addChild(i1959);//0
		}
	}
	public class symbol_1013 : MovieClip{ 
		public symbol_1013() {
			var i1961 = new symbol_132();
			addChild(i1961);//0
		}
	}
	public class symbol_1014 : MovieClip{ 
		public symbol_1014() {
			var i1963 = new symbol_132();
			addChild(i1963);//0
		}
	}
	public class symbol_1015 : MovieClip{ 
		public symbol_1015() {
			var i1965 = new symbol_132();
			addChild(i1965);//0
		}
	}
	public class symbol_1016 : MovieClip{ 
		public symbol_1016() {
			var i1967 = new symbol_115();
			addChild(i1967);//0
		}
	}
	public class symbol_1017 : MovieClip{ 
		public symbol_1017() {
			var i1969 = new symbol_132();
			addChild(i1969);//0
		}
	}
	public class symbol_1018 : MovieClip{ 
		public symbol_1018() {
			var i1971 = new symbol_132();
			addChild(i1971);//0
		}
	}
	public class symbol_1019 : MovieClip{ 
		public symbol_1019() {
			var i1893 = new symbol_294();
			addChild(i1893);//0
			var i1894 = new symbol_982(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1894);//1
			var i1896 = new symbol_983(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1896);//2
			var i1898 = new symbol_984(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1898);//3
			var i1900 = new symbol_298();
			addChild(i1900);//4
			var i1901 = new symbol_985(){x = -145.1 , scaleX = 1 , y = -280.2 , scaleY = 1 , rotation = 4};
			addChild(i1901);//5
			var i1903 = new symbol_986(){x = -147.3 , scaleX = 0.84 , y = -268.1 , scaleY = 0.84 , rotation = -34};
			addChild(i1903);//6
			var i1905 = new symbol_346();
			addChild(i1905);//7
			var i1906 = new symbol_987(){x = 212.6 , scaleX = 1 , y = -189.7 , scaleY = 1 , rotation = 131};
			addChild(i1906);//8
			var i1908 = new symbol_348();
			addChild(i1908);//9
			var i1909 = new symbol_988(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i1909);//10
			var i1911 = new symbol_989(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i1911);//11
			var i1913 = new symbol_990(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i1913);//12
			var i1915 = new symbol_352();
			addChild(i1915);//13
			var i1916 = new symbol_991(){x = -92.6 , scaleX = 1 , y = -339.9 , scaleY = 1 , rotation = -160};
			addChild(i1916);//14
			var i1918 = new symbol_992(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i1918);//15
			var i1920 = new symbol_993(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i1920);//16
			var i1922 = new symbol_994(){x = 91.7 , scaleX = 0.79 , y = -420.6 , scaleY = 0.79 , rotation = 13};
			addChild(i1922);//17
			var i1924 = new symbol_995(){x = 102.2 , scaleX = 1 , y = -421.1 , scaleY = 1 , rotation = 53};
			addChild(i1924);//18
			var i1926 = new symbol_996(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i1926);//19
			var i1928 = new symbol_997(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i1928);//20
			var i1930 = new symbol_998(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i1930);//21
			var i1932 = new symbol_999(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i1932);//22
			var i1934 = new symbol_1000(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i1934);//23
			var i1936 = new symbol_1001(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1936);//24
			var i1938 = new symbol_1002(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1938);//25
			var i1940 = new symbol_1003(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i1940);//26
			var i1942 = new symbol_1004(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i1942);//27
			var i1944 = new symbol_1005(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i1944);//28
			var i1946 = new symbol_1006(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i1946);//29
			var i1948 = new symbol_1007(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i1948);//30
			var i1950 = new symbol_1008(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i1950);//31
			var i1952 = new symbol_1009(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i1952);//32
			var i1954 = new symbol_1010(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i1954);//33
			var i1956 = new symbol_1011(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i1956);//34
			var i1958 = new symbol_1012(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i1958);//35
			var i1960 = new symbol_1013(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i1960);//36
			var i1962 = new symbol_1014(){x = -85.7 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 16};
			addChild(i1962);//37
			var i1964 = new symbol_1015(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i1964);//38
			var i1966 = new symbol_1016(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i1966);//39
			var i1968 = new symbol_1017(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i1968);//40
			var i1970 = new symbol_1018(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i1970);//41
			var i1972 = new symbol_381();
			addChild(i1972);//42
		}
	}
	public class symbol_102 : Shape{ 
		public symbol_102() {
			setGraphics("487272ee129221a3eeb75c0a17872fb3", -60.6, -202.25, 62.95, 134.6, 1, 1);
		}
	}
	public class symbol_1020 : MovieClip{ 
		public symbol_1020() {
			var i1973 = new symbol_33();
			addChild(i1973);//0
		}
	}
	public class symbol_1021 : Shape{ 
		public symbol_1021() {
			setGraphics("8356fcf97c487e6437f20a1f5ac57503", 38.85, -34.45, 93.9, 83.9, 1, 1);
		}
	}
	public class symbol_1022 : MovieClip{ 
		public symbol_1022() {
			var i1978 = new symbol_115();
			addChild(i1978);//0
		}
	}
	public class symbol_1023 : MovieClip{ 
		public symbol_1023() {
			var i1980 = new symbol_115();
			addChild(i1980);//0
		}
	}
	public class symbol_1024 : MovieClip{ 
		public symbol_1024() {
			var i1982 = new symbol_115();
			addChild(i1982);//0
		}
	}
	public class symbol_1025 : MovieClip{ 
		public symbol_1025() {
			var i1985 = new symbol_132();
			addChild(i1985);//0
		}
	}
	public class symbol_1026 : MovieClip{ 
		public symbol_1026() {
			var i1987 = new symbol_132();
			addChild(i1987);//0
		}
	}
	public class symbol_1027 : MovieClip{ 
		public symbol_1027() {
			var i1990 = new symbol_115();
			addChild(i1990);//0
		}
	}
	public class symbol_1028 : MovieClip{ 
		public symbol_1028() {
			var i1993 = new symbol_132();
			addChild(i1993);//0
		}
	}
	public class symbol_1029 : MovieClip{ 
		public symbol_1029() {
			var i1996 = new symbol_115();
			addChild(i1996);//0
		}
	}
	public class symbol_103 : MovieClip{ 
		public symbol_103() {
			var i208 = new symbol_20();
			addChild(i208);//0
		}
	}
	public class symbol_1030 : MovieClip{ 
		public symbol_1030() {
			var i1998 = new symbol_115();
			addChild(i1998);//0
		}
	}
	public class symbol_1031 : MovieClip{ 
		public symbol_1031() {
			var i2000 = new symbol_115();
			addChild(i2000);//0
		}
	}
	public class symbol_1032 : MovieClip{ 
		public symbol_1032() {
			var i2003 = new symbol_115();
			addChild(i2003);//0
		}
	}
	public class symbol_1033 : MovieClip{ 
		public symbol_1033() {
			var i2005 = new symbol_132();
			addChild(i2005);//0
		}
	}
	public class symbol_1034 : MovieClip{ 
		public symbol_1034() {
			var i2007 = new symbol_132();
			addChild(i2007);//0
		}
	}
	public class symbol_1035 : MovieClip{ 
		public symbol_1035() {
			var i2009 = new symbol_132();
			addChild(i2009);//0
		}
	}
	public class symbol_1036 : MovieClip{ 
		public symbol_1036() {
			var i2011 = new symbol_132();
			addChild(i2011);//0
		}
	}
	public class symbol_1037 : MovieClip{ 
		public symbol_1037() {
			var i2013 = new symbol_115();
			addChild(i2013);//0
		}
	}
	public class symbol_1038 : MovieClip{ 
		public symbol_1038() {
			var i2015 = new symbol_115();
			addChild(i2015);//0
		}
	}
	public class symbol_1039 : MovieClip{ 
		public symbol_1039() {
			var i2017 = new symbol_132();
			addChild(i2017);//0
		}
	}
	public class symbol_104 : Shape{ 
		public symbol_104() {
			setGraphics("f203455479802ba0fc39d4f5eed646a1", -8.65, -10.25, 17.3, 20.5, 1, 1);
		}
	}
	public class symbol_1040 : MovieClip{ 
		public symbol_1040() {
			var i2019 = new symbol_132();
			addChild(i2019);//0
		}
	}
	public class symbol_1041 : MovieClip{ 
		public symbol_1041() {
			var i2021 = new symbol_132();
			addChild(i2021);//0
		}
	}
	public class symbol_1042 : MovieClip{ 
		public symbol_1042() {
			var i2023 = new symbol_115();
			addChild(i2023);//0
		}
	}
	public class symbol_1043 : MovieClip{ 
		public symbol_1043() {
			var i2025 = new symbol_132();
			addChild(i2025);//0
		}
	}
	public class symbol_1044 : MovieClip{ 
		public symbol_1044() {
			var i2027 = new symbol_132();
			addChild(i2027);//0
		}
	}
	public class symbol_1045 : MovieClip{ 
		public symbol_1045() {
			var i2029 = new symbol_132();
			addChild(i2029);//0
		}
	}
	public class symbol_1046 : MovieClip{ 
		public symbol_1046() {
			var i2031 = new symbol_132();
			addChild(i2031);//0
		}
	}
	public class symbol_1047 : MovieClip{ 
		public symbol_1047() {
			var i2033 = new symbol_132();
			addChild(i2033);//0
		}
	}
	public class symbol_1048 : MovieClip{ 
		public symbol_1048() {
			var i2035 = new symbol_115();
			addChild(i2035);//0
		}
	}
	public class symbol_1049 : MovieClip{ 
		public symbol_1049() {
			var i2037 = new symbol_132();
			addChild(i2037);//0
		}
	}
	public class symbol_105 : MovieClip{ 
		public symbol_105() {
			var i210 = new symbol_104();
			addChild(i210);//0
		}
	}
	public class symbol_1050 : MovieClip{ 
		public symbol_1050() {
			var i2039 = new symbol_132();
			addChild(i2039);//0
		}
	}
	public class symbol_1051 : MovieClip{ 
		public symbol_1051() {
			var i2041 = new symbol_132();
			addChild(i2041);//0
		}
	}
	public class symbol_1052 : MovieClip{ 
		public symbol_1052() {
			var i2043 = new symbol_132();
			addChild(i2043);//0
		}
	}
	public class symbol_1053 : MovieClip{ 
		public symbol_1053() {
			var i2045 = new symbol_115();
			addChild(i2045);//0
		}
	}
	public class symbol_1054 : MovieClip{ 
		public symbol_1054() {
			var i2047 = new symbol_132();
			addChild(i2047);//0
		}
	}
	public class symbol_1055 : MovieClip{ 
		public symbol_1055() {
			var i2049 = new symbol_132();
			addChild(i2049);//0
		}
	}
	public class symbol_1056 : MovieClip{ 
		public symbol_1056() {
			var i2051 = new symbol_132();
			addChild(i2051);//0
		}
	}
	public class symbol_1057 : MovieClip{ 
		public symbol_1057() {
			var i2053 = new symbol_115();
			addChild(i2053);//0
		}
	}
	public class symbol_1058 : MovieClip{ 
		public symbol_1058() {
			var i2055 = new symbol_132();
			addChild(i2055);//0
		}
	}
	public class symbol_1059 : MovieClip{ 
		public symbol_1059() {
			var i2057 = new symbol_132();
			addChild(i2057);//0
		}
	}
	public class symbol_106 : Shape{ 
		public symbol_106() {
			setGraphics("5c2282542f86099881853afacd431545", -10.35, -6.1, 20.75, 12.25, 1, 1);
		}
	}
	public class symbol_1060 : MovieClip{ 
		public symbol_1060() {
			var i2059 = new symbol_132();
			addChild(i2059);//0
		}
	}
	public class symbol_1061 : MovieClip{ 
		public symbol_1061() {
			var i1976 = new symbol_294();
			addChild(i1976);//0
			var i1977 = new symbol_1022(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1977);//1
			var i1979 = new symbol_1023(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1979);//2
			var i1981 = new symbol_1024(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1981);//3
			var i1983 = new symbol_298();
			addChild(i1983);//4
			var i1984 = new symbol_1025(){x = -145.1 , scaleX = 1 , y = -280.2 , scaleY = 1 , rotation = 4};
			addChild(i1984);//5
			var i1986 = new symbol_1026(){x = -147.3 , scaleX = 0.84 , y = -268.1 , scaleY = 0.84 , rotation = -34};
			addChild(i1986);//6
			var i1988 = new symbol_390();
			addChild(i1988);//7
			var i1989 = new symbol_1027(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i1989);//8
			var i1991 = new symbol_392();
			addChild(i1991);//9
			var i1992 = new symbol_1028(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i1992);//10
			var i1994 = new symbol_394();
			addChild(i1994);//11
			var i1995 = new symbol_1029(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i1995);//12
			var i1997 = new symbol_1030(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i1997);//13
			var i1999 = new symbol_1031(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i1999);//14
			var i2001 = new symbol_307();
			addChild(i2001);//15
			var i2002 = new symbol_1032(){x = -92.6 , scaleX = 1 , y = -339.9 , scaleY = 1 , rotation = -160};
			addChild(i2002);//16
			var i2004 = new symbol_1033(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i2004);//17
			var i2006 = new symbol_1034(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i2006);//18
			var i2008 = new symbol_1035(){x = 91.7 , scaleX = 0.79 , y = -420.6 , scaleY = 0.79 , rotation = 13};
			addChild(i2008);//19
			var i2010 = new symbol_1036(){x = 102.2 , scaleX = 1 , y = -421.1 , scaleY = 1 , rotation = 53};
			addChild(i2010);//20
			var i2012 = new symbol_1037(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i2012);//21
			var i2014 = new symbol_1038(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i2014);//22
			var i2016 = new symbol_1039(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i2016);//23
			var i2018 = new symbol_1040(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i2018);//24
			var i2020 = new symbol_1041(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i2020);//25
			var i2022 = new symbol_1042(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i2022);//26
			var i2024 = new symbol_1043(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i2024);//27
			var i2026 = new symbol_1044(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i2026);//28
			var i2028 = new symbol_1045(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i2028);//29
			var i2030 = new symbol_1046(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i2030);//30
			var i2032 = new symbol_1047(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i2032);//31
			var i2034 = new symbol_1048(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i2034);//32
			var i2036 = new symbol_1049(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i2036);//33
			var i2038 = new symbol_1050(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i2038);//34
			var i2040 = new symbol_1051(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i2040);//35
			var i2042 = new symbol_1052(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i2042);//36
			var i2044 = new symbol_1053(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i2044);//37
			var i2046 = new symbol_1054(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i2046);//38
			var i2048 = new symbol_1055(){x = -85.7 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 16};
			addChild(i2048);//39
			var i2050 = new symbol_1056(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i2050);//40
			var i2052 = new symbol_1057(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i2052);//41
			var i2054 = new symbol_1058(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i2054);//42
			var i2056 = new symbol_1059(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i2056);//43
			var i2058 = new symbol_1060(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i2058);//44
			var i2060 = new symbol_381();
			addChild(i2060);//45
		}
	}
	public class symbol_1062 : MovieClip{ 
		public symbol_1062() {
			var i2061 = new symbol_33();
			addChild(i2061);//0
		}
	}
	public class symbol_1063 : MovieClip{ 
		public symbol_1063() {
			var i2063 = new symbol_13();
			addChild(i2063);//0
		}
	}
	public class symbol_1064 : Shape{ 
		public symbol_1064() {
			setGraphics("9e03bff8cd4c45f025a7c49bd0cf3385", 52.6, -34.45, 58.35, 81.95, 1, 1);
		}
	}
	public class symbol_1065 : MovieClip{ 
		public symbol_1065() {
			var i2068 = new symbol_115();
			addChild(i2068);//0
		}
	}
	public class symbol_1066 : MovieClip{ 
		public symbol_1066() {
			var i2070 = new symbol_115();
			addChild(i2070);//0
		}
	}
	public class symbol_1067 : MovieClip{ 
		public symbol_1067() {
			var i2072 = new symbol_115();
			addChild(i2072);//0
		}
	}
	public class symbol_1068 : MovieClip{ 
		public symbol_1068() {
			var i2075 = new symbol_132();
			addChild(i2075);//0
		}
	}
	public class symbol_1069 : MovieClip{ 
		public symbol_1069() {
			var i2077 = new symbol_132();
			addChild(i2077);//0
		}
	}
	public class symbol_107 : MovieClip{ 
		public symbol_107() {
			var i212 = new symbol_106();
			addChild(i212);//0
		}
	}
	public class symbol_1070 : MovieClip{ 
		public symbol_1070() {
			var i2080 = new symbol_115();
			addChild(i2080);//0
		}
	}
	public class symbol_1071 : MovieClip{ 
		public symbol_1071() {
			var i2083 = new symbol_132();
			addChild(i2083);//0
		}
	}
	public class symbol_1072 : MovieClip{ 
		public symbol_1072() {
			var i2086 = new symbol_115();
			addChild(i2086);//0
		}
	}
	public class symbol_1073 : MovieClip{ 
		public symbol_1073() {
			var i2088 = new symbol_115();
			addChild(i2088);//0
		}
	}
	public class symbol_1074 : MovieClip{ 
		public symbol_1074() {
			var i2090 = new symbol_115();
			addChild(i2090);//0
		}
	}
	public class symbol_1075 : MovieClip{ 
		public symbol_1075() {
			var i2093 = new symbol_115();
			addChild(i2093);//0
		}
	}
	public class symbol_1076 : MovieClip{ 
		public symbol_1076() {
			var i2095 = new symbol_132();
			addChild(i2095);//0
		}
	}
	public class symbol_1077 : MovieClip{ 
		public symbol_1077() {
			var i2097 = new symbol_132();
			addChild(i2097);//0
		}
	}
	public class symbol_1078 : MovieClip{ 
		public symbol_1078() {
			var i2099 = new symbol_132();
			addChild(i2099);//0
		}
	}
	public class symbol_1079 : MovieClip{ 
		public symbol_1079() {
			var i2101 = new symbol_132();
			addChild(i2101);//0
		}
	}
	public class symbol_108 : Shape{ 
		public symbol_108() {
			setGraphics("c5733850d24694eb5018129a3d9f779a", -27.1, -280.55, 50.05, 281.2, 1, 1);
		}
	}
	public class symbol_1080 : MovieClip{ 
		public symbol_1080() {
			var i2103 = new symbol_115();
			addChild(i2103);//0
		}
	}
	public class symbol_1081 : MovieClip{ 
		public symbol_1081() {
			var i2105 = new symbol_115();
			addChild(i2105);//0
		}
	}
	public class symbol_1082 : MovieClip{ 
		public symbol_1082() {
			var i2107 = new symbol_132();
			addChild(i2107);//0
		}
	}
	public class symbol_1083 : MovieClip{ 
		public symbol_1083() {
			var i2109 = new symbol_132();
			addChild(i2109);//0
		}
	}
	public class symbol_1084 : MovieClip{ 
		public symbol_1084() {
			var i2111 = new symbol_132();
			addChild(i2111);//0
		}
	}
	public class symbol_1085 : MovieClip{ 
		public symbol_1085() {
			var i2113 = new symbol_115();
			addChild(i2113);//0
		}
	}
	public class symbol_1086 : MovieClip{ 
		public symbol_1086() {
			var i2115 = new symbol_132();
			addChild(i2115);//0
		}
	}
	public class symbol_1087 : MovieClip{ 
		public symbol_1087() {
			var i2117 = new symbol_132();
			addChild(i2117);//0
		}
	}
	public class symbol_1088 : MovieClip{ 
		public symbol_1088() {
			var i2119 = new symbol_132();
			addChild(i2119);//0
		}
	}
	public class symbol_1089 : MovieClip{ 
		public symbol_1089() {
			var i2121 = new symbol_132();
			addChild(i2121);//0
		}
	}
	public class symbol_109 : MovieClip{ 
		public symbol_109() {
			var i215 = new symbol_106();
			addChild(i215);//0
		}
	}
	public class symbol_1090 : MovieClip{ 
		public symbol_1090() {
			var i2123 = new symbol_132();
			addChild(i2123);//0
		}
	}
	public class symbol_1091 : MovieClip{ 
		public symbol_1091() {
			var i2125 = new symbol_115();
			addChild(i2125);//0
		}
	}
	public class symbol_1092 : MovieClip{ 
		public symbol_1092() {
			var i2127 = new symbol_132();
			addChild(i2127);//0
		}
	}
	public class symbol_1093 : MovieClip{ 
		public symbol_1093() {
			var i2129 = new symbol_132();
			addChild(i2129);//0
		}
	}
	public class symbol_1094 : MovieClip{ 
		public symbol_1094() {
			var i2131 = new symbol_132();
			addChild(i2131);//0
		}
	}
	public class symbol_1095 : MovieClip{ 
		public symbol_1095() {
			var i2133 = new symbol_132();
			addChild(i2133);//0
		}
	}
	public class symbol_1096 : MovieClip{ 
		public symbol_1096() {
			var i2135 = new symbol_115();
			addChild(i2135);//0
		}
	}
	public class symbol_1097 : MovieClip{ 
		public symbol_1097() {
			var i2137 = new symbol_132();
			addChild(i2137);//0
		}
	}
	public class symbol_1098 : MovieClip{ 
		public symbol_1098() {
			var i2139 = new symbol_132();
			addChild(i2139);//0
		}
	}
	public class symbol_1099 : MovieClip{ 
		public symbol_1099() {
			var i2141 = new symbol_132();
			addChild(i2141);//0
		}
	}
	public class symbol_11 : Shape{ 
		public symbol_11() {
			setGraphics("7af4996d5a068a13cacdd4118d8f3dc6", 0, -110.95, 412, 110.95, 1, 1);
		}
	}
	public class symbol_110 : MovieClip{ 
		public symbol_110() {
			var i217 = new symbol_106();
			addChild(i217);//0
		}
	}
	public class symbol_1100 : MovieClip{ 
		public symbol_1100() {
			var i2143 = new symbol_115();
			addChild(i2143);//0
		}
	}
	public class symbol_1101 : MovieClip{ 
		public symbol_1101() {
			var i2145 = new symbol_132();
			addChild(i2145);//0
		}
	}
	public class symbol_1102 : MovieClip{ 
		public symbol_1102() {
			var i2147 = new symbol_132();
			addChild(i2147);//0
		}
	}
	public class symbol_1103 : MovieClip{ 
		public symbol_1103() {
			var i2149 = new symbol_132();
			addChild(i2149);//0
		}
	}
	public class symbol_1104 : MovieClip{ 
		public symbol_1104() {
			var i2151 = new symbol_115();
			addChild(i2151);//0
		}
	}
	public class symbol_1105 : MovieClip{ 
		public symbol_1105() {
			var i2153 = new symbol_132();
			addChild(i2153);//0
		}
	}
	public class symbol_1106 : MovieClip{ 
		public symbol_1106() {
			var i2155 = new symbol_132();
			addChild(i2155);//0
		}
	}
	public class symbol_1107 : MovieClip{ 
		public symbol_1107() {
			var i2066 = new symbol_294();
			addChild(i2066);//0
			var i2067 = new symbol_1065(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i2067);//1
			var i2069 = new symbol_1066(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i2069);//2
			var i2071 = new symbol_1067(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i2071);//3
			var i2073 = new symbol_434();
			addChild(i2073);//4
			var i2074 = new symbol_1068(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i2074);//5
			var i2076 = new symbol_1069(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i2076);//6
			var i2078 = new symbol_437();
			addChild(i2078);//7
			var i2079 = new symbol_1070(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i2079);//8
			var i2081 = new symbol_392();
			addChild(i2081);//9
			var i2082 = new symbol_1071(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i2082);//10
			var i2084 = new symbol_440();
			addChild(i2084);//11
			var i2085 = new symbol_1072(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i2085);//12
			var i2087 = new symbol_1073(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i2087);//13
			var i2089 = new symbol_1074(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i2089);//14
			var i2091 = new symbol_352();
			addChild(i2091);//15
			var i2092 = new symbol_1075(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i2092);//16
			var i2094 = new symbol_1076(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i2094);//17
			var i2096 = new symbol_1077(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i2096);//18
			var i2098 = new symbol_1078(){x = 91.7 , scaleX = 0.79 , y = -420.6 , scaleY = 0.79 , rotation = 13};
			addChild(i2098);//19
			var i2100 = new symbol_1079(){x = 102.2 , scaleX = 1 , y = -421.1 , scaleY = 1 , rotation = 53};
			addChild(i2100);//20
			var i2102 = new symbol_1080(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i2102);//21
			var i2104 = new symbol_1081(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i2104);//22
			var i2106 = new symbol_1082(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i2106);//23
			var i2108 = new symbol_1083(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i2108);//24
			var i2110 = new symbol_1084(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i2110);//25
			var i2112 = new symbol_1085(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i2112);//26
			var i2114 = new symbol_1086(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i2114);//27
			var i2116 = new symbol_1087(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i2116);//28
			var i2118 = new symbol_1088(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i2118);//29
			var i2120 = new symbol_1089(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i2120);//30
			var i2122 = new symbol_1090(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i2122);//31
			var i2124 = new symbol_1091(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i2124);//32
			var i2126 = new symbol_1092(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i2126);//33
			var i2128 = new symbol_1093(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i2128);//34
			var i2130 = new symbol_1094(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i2130);//35
			var i2132 = new symbol_1095(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i2132);//36
			var i2134 = new symbol_1096(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i2134);//37
			var i2136 = new symbol_1097(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i2136);//38
			var i2138 = new symbol_1098(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i2138);//39
			var i2140 = new symbol_1099(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i2140);//40
			var i2142 = new symbol_1100(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i2142);//41
			var i2144 = new symbol_1101(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i2144);//42
			var i2146 = new symbol_1102(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i2146);//43
			var i2148 = new symbol_1103(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i2148);//44
			var i2150 = new symbol_1104(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i2150);//45
			var i2152 = new symbol_1105(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i2152);//46
			var i2154 = new symbol_1106(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i2154);//47
			var i2156 = new symbol_381();
			addChild(i2156);//48
		}
	}
	public class symbol_1108 : MovieClip{ 
		public symbol_1108() {
			var i2157 = new symbol_33();
			addChild(i2157);//0
		}
	}
	public class symbol_1109 : MovieClip{ 
		public symbol_1109() {
			var i2161 = new symbol_115();
			addChild(i2161);//0
		}
	}
	public class symbol_111 : Shape{ 
		public symbol_111() {
			setGraphics("8524a09e1e336e6813d46df5d990cf74", -161.1, -187.05, 169.4, 98.55000000000001, 1, 1);
		}
	}
	public class symbol_1110 : MovieClip{ 
		public symbol_1110() {
			var i2163 = new symbol_115();
			addChild(i2163);//0
		}
	}
	public class symbol_1111 : MovieClip{ 
		public symbol_1111() {
			var i2165 = new symbol_115();
			addChild(i2165);//0
		}
	}
	public class symbol_1112 : MovieClip{ 
		public symbol_1112() {
			var i2168 = new symbol_132();
			addChild(i2168);//0
		}
	}
	public class symbol_1113 : MovieClip{ 
		public symbol_1113() {
			var i2170 = new symbol_132();
			addChild(i2170);//0
		}
	}
	public class symbol_1114 : MovieClip{ 
		public symbol_1114() {
			var i2173 = new symbol_115();
			addChild(i2173);//0
		}
	}
	public class symbol_1115 : MovieClip{ 
		public symbol_1115() {
			var i2175 = new symbol_115();
			addChild(i2175);//0
		}
	}
	public class symbol_1116 : MovieClip{ 
		public symbol_1116() {
			var i2177 = new symbol_132();
			addChild(i2177);//0
		}
	}
	public class symbol_1117 : MovieClip{ 
		public symbol_1117() {
			var i2180 = new symbol_115();
			addChild(i2180);//0
		}
	}
	public class symbol_1118 : MovieClip{ 
		public symbol_1118() {
			var i2183 = new symbol_132();
			addChild(i2183);//0
		}
	}
	public class symbol_1119 : MovieClip{ 
		public symbol_1119() {
			var i2186 = new symbol_115();
			addChild(i2186);//0
		}
	}
	public class symbol_112 : Shape{ 
		public symbol_112() {
			setGraphics("5c2282542f86099881853afacd431545", -10.35, -6.1, 20.75, 12.25, 1, 1);
		}
	}
	public class symbol_1120 : MovieClip{ 
		public symbol_1120() {
			var i2188 = new symbol_115();
			addChild(i2188);//0
		}
	}
	public class symbol_1121 : MovieClip{ 
		public symbol_1121() {
			var i2190 = new symbol_115();
			addChild(i2190);//0
		}
	}
	public class symbol_1122 : MovieClip{ 
		public symbol_1122() {
			var i2193 = new symbol_115();
			addChild(i2193);//0
		}
	}
	public class symbol_1123 : MovieClip{ 
		public symbol_1123() {
			var i2195 = new symbol_132();
			addChild(i2195);//0
		}
	}
	public class symbol_1124 : MovieClip{ 
		public symbol_1124() {
			var i2197 = new symbol_132();
			addChild(i2197);//0
		}
	}
	public class symbol_1125 : MovieClip{ 
		public symbol_1125() {
			var i2199 = new symbol_132();
			addChild(i2199);//0
		}
	}
	public class symbol_1126 : MovieClip{ 
		public symbol_1126() {
			var i2201 = new symbol_132();
			addChild(i2201);//0
		}
	}
	public class symbol_1127 : MovieClip{ 
		public symbol_1127() {
			var i2203 = new symbol_115();
			addChild(i2203);//0
		}
	}
	public class symbol_1128 : MovieClip{ 
		public symbol_1128() {
			var i2205 = new symbol_115();
			addChild(i2205);//0
		}
	}
	public class symbol_1129 : MovieClip{ 
		public symbol_1129() {
			var i2207 = new symbol_132();
			addChild(i2207);//0
		}
	}
	public class symbol_113 : MovieClip{ 
		public symbol_113() {
			var i220 = new symbol_112();
			addChild(i220);//0
		}
	}
	public class symbol_1130 : MovieClip{ 
		public symbol_1130() {
			var i2209 = new symbol_132();
			addChild(i2209);//0
		}
	}
	public class symbol_1131 : MovieClip{ 
		public symbol_1131() {
			var i2211 = new symbol_132();
			addChild(i2211);//0
		}
	}
	public class symbol_1132 : MovieClip{ 
		public symbol_1132() {
			var i2213 = new symbol_115();
			addChild(i2213);//0
		}
	}
	public class symbol_1133 : MovieClip{ 
		public symbol_1133() {
			var i2215 = new symbol_132();
			addChild(i2215);//0
		}
	}
	public class symbol_1134 : MovieClip{ 
		public symbol_1134() {
			var i2217 = new symbol_132();
			addChild(i2217);//0
		}
	}
	public class symbol_1135 : MovieClip{ 
		public symbol_1135() {
			var i2219 = new symbol_132();
			addChild(i2219);//0
		}
	}
	public class symbol_1136 : MovieClip{ 
		public symbol_1136() {
			var i2221 = new symbol_132();
			addChild(i2221);//0
		}
	}
	public class symbol_1137 : MovieClip{ 
		public symbol_1137() {
			var i2223 = new symbol_132();
			addChild(i2223);//0
		}
	}
	public class symbol_1138 : MovieClip{ 
		public symbol_1138() {
			var i2225 = new symbol_115();
			addChild(i2225);//0
		}
	}
	public class symbol_1139 : MovieClip{ 
		public symbol_1139() {
			var i2227 = new symbol_132();
			addChild(i2227);//0
		}
	}
	public class symbol_114 : Shape{ 
		public symbol_114() {
			setGraphics("09b01d3d84cefc1e7af10ddab09fa2d4", 0.8, -218.25, 70.60000000000001, 59.75, 1, 1);
		}
	}
	public class symbol_1140 : MovieClip{ 
		public symbol_1140() {
			var i2229 = new symbol_132();
			addChild(i2229);//0
		}
	}
	public class symbol_1141 : MovieClip{ 
		public symbol_1141() {
			var i2231 = new symbol_132();
			addChild(i2231);//0
		}
	}
	public class symbol_1142 : MovieClip{ 
		public symbol_1142() {
			var i2233 = new symbol_132();
			addChild(i2233);//0
		}
	}
	public class symbol_1143 : MovieClip{ 
		public symbol_1143() {
			var i2235 = new symbol_115();
			addChild(i2235);//0
		}
	}
	public class symbol_1144 : MovieClip{ 
		public symbol_1144() {
			var i2237 = new symbol_132();
			addChild(i2237);//0
		}
	}
	public class symbol_1145 : MovieClip{ 
		public symbol_1145() {
			var i2239 = new symbol_132();
			addChild(i2239);//0
		}
	}
	public class symbol_1146 : MovieClip{ 
		public symbol_1146() {
			var i2241 = new symbol_132();
			addChild(i2241);//0
		}
	}
	public class symbol_1147 : MovieClip{ 
		public symbol_1147() {
			var i2243 = new symbol_115();
			addChild(i2243);//0
		}
	}
	public class symbol_1148 : MovieClip{ 
		public symbol_1148() {
			var i2245 = new symbol_132();
			addChild(i2245);//0
		}
	}
	public class symbol_1149 : MovieClip{ 
		public symbol_1149() {
			var i2247 = new symbol_132();
			addChild(i2247);//0
		}
	}
	public class symbol_115 : Shape{ 
		public symbol_115() {
			setGraphics("5c2282542f86099881853afacd431545", -10.35, -6.1, 20.75, 12.25, 1, 1);
		}
	}
	public class symbol_1150 : MovieClip{ 
		public symbol_1150() {
			var i2249 = new symbol_132();
			addChild(i2249);//0
		}
	}
	public class symbol_1151 : MovieClip{ 
		public symbol_1151() {
			var i2251 = new symbol_115();
			addChild(i2251);//0
		}
	}
	public class symbol_1152 : MovieClip{ 
		public symbol_1152() {
			var i2253 = new symbol_132();
			addChild(i2253);//0
		}
	}
	public class symbol_1153 : MovieClip{ 
		public symbol_1153() {
			var i2255 = new symbol_132();
			addChild(i2255);//0
		}
	}
	public class symbol_1154 : MovieClip{ 
		public symbol_1154() {
			var i2257 = new symbol_132();
			addChild(i2257);//0
		}
	}
	public class symbol_1155 : MovieClip{ 
		public symbol_1155() {
			var i2159 = new symbol_294();
			addChild(i2159);//0
			var i2160 = new symbol_1109(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i2160);//1
			var i2162 = new symbol_1110(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i2162);//2
			var i2164 = new symbol_1111(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i2164);//3
			var i2166 = new symbol_434();
			addChild(i2166);//4
			var i2167 = new symbol_1112(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i2167);//5
			var i2169 = new symbol_1113(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i2169);//6
			var i2171 = new symbol_483();
			addChild(i2171);//7
			var i2172 = new symbol_1114(){x = 135.9 , scaleX = 1 , y = -331.8 , scaleY = 1 , rotation = 48};
			addChild(i2172);//8
			var i2174 = new symbol_1115(){x = 207.3 , scaleX = 1 , y = -329.6 , scaleY = 1 , rotation = 18};
			addChild(i2174);//9
			var i2176 = new symbol_1116(){x = 220.8 , scaleX = 0.89 , y = -369.8 , scaleY = 0.77 , rotation = 68};
			addChild(i2176);//10
			var i2178 = new symbol_487();
			addChild(i2178);//11
			var i2179 = new symbol_1117(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i2179);//12
			var i2181 = new symbol_392();
			addChild(i2181);//13
			var i2182 = new symbol_1118(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i2182);//14
			var i2184 = new symbol_394();
			addChild(i2184);//15
			var i2185 = new symbol_1119(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i2185);//16
			var i2187 = new symbol_1120(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i2187);//17
			var i2189 = new symbol_1121(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i2189);//18
			var i2191 = new symbol_307();
			addChild(i2191);//19
			var i2192 = new symbol_1122(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i2192);//20
			var i2194 = new symbol_1123(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i2194);//21
			var i2196 = new symbol_1124(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i2196);//22
			var i2198 = new symbol_1125(){x = 91.7 , scaleX = 0.79 , y = -420.6 , scaleY = 0.79 , rotation = 13};
			addChild(i2198);//23
			var i2200 = new symbol_1126(){x = 102.2 , scaleX = 1 , y = -421.1 , scaleY = 1 , rotation = 53};
			addChild(i2200);//24
			var i2202 = new symbol_1127(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i2202);//25
			var i2204 = new symbol_1128(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i2204);//26
			var i2206 = new symbol_1129(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i2206);//27
			var i2208 = new symbol_1130(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i2208);//28
			var i2210 = new symbol_1131(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i2210);//29
			var i2212 = new symbol_1132(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i2212);//30
			var i2214 = new symbol_1133(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i2214);//31
			var i2216 = new symbol_1134(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i2216);//32
			var i2218 = new symbol_1135(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i2218);//33
			var i2220 = new symbol_1136(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i2220);//34
			var i2222 = new symbol_1137(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i2222);//35
			var i2224 = new symbol_1138(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i2224);//36
			var i2226 = new symbol_1139(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i2226);//37
			var i2228 = new symbol_1140(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i2228);//38
			var i2230 = new symbol_1141(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i2230);//39
			var i2232 = new symbol_1142(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i2232);//40
			var i2234 = new symbol_1143(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i2234);//41
			var i2236 = new symbol_1144(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i2236);//42
			var i2238 = new symbol_1145(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i2238);//43
			var i2240 = new symbol_1146(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i2240);//44
			var i2242 = new symbol_1147(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i2242);//45
			var i2244 = new symbol_1148(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i2244);//46
			var i2246 = new symbol_1149(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i2246);//47
			var i2248 = new symbol_1150(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i2248);//48
			var i2250 = new symbol_1151(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i2250);//49
			var i2252 = new symbol_1152(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i2252);//50
			var i2254 = new symbol_1153(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i2254);//51
			var i2256 = new symbol_1154(){x = 135.3 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 108};
			addChild(i2256);//52
			var i2258 = new symbol_381();
			addChild(i2258);//53
		}
	}
	public class symbol_1156 : MovieClip{ 
		public symbol_1156() {
			var i2259 = new symbol_33();
			addChild(i2259);//0
		}
	}
	public class symbol_1157 : MovieClip{ 
		public symbol_1157() {
			var i2263 = new symbol_115();
			addChild(i2263);//0
		}
	}
	public class symbol_1158 : MovieClip{ 
		public symbol_1158() {
			var i2265 = new symbol_115();
			addChild(i2265);//0
		}
	}
	public class symbol_1159 : MovieClip{ 
		public symbol_1159() {
			var i2267 = new symbol_115();
			addChild(i2267);//0
		}
	}
	public class symbol_116 : MovieClip{ 
		public symbol_116() {
			var i223 = new symbol_115();
			addChild(i223);//0
		}
	}
	public class symbol_1160 : MovieClip{ 
		public symbol_1160() {
			var i2270 = new symbol_132();
			addChild(i2270);//0
		}
	}
	public class symbol_1161 : MovieClip{ 
		public symbol_1161() {
			var i2272 = new symbol_132();
			addChild(i2272);//0
		}
	}
	public class symbol_1162 : MovieClip{ 
		public symbol_1162() {
			var i2275 = new symbol_115();
			addChild(i2275);//0
		}
	}
	public class symbol_1163 : MovieClip{ 
		public symbol_1163() {
			var i2277 = new symbol_115();
			addChild(i2277);//0
		}
	}
	public class symbol_1164 : MovieClip{ 
		public symbol_1164() {
			var i2279 = new symbol_132();
			addChild(i2279);//0
		}
	}
	public class symbol_1165 : MovieClip{ 
		public symbol_1165() {
			var i2282 = new symbol_115();
			addChild(i2282);//0
		}
	}
	public class symbol_1166 : MovieClip{ 
		public symbol_1166() {
			var i2285 = new symbol_132();
			addChild(i2285);//0
		}
	}
	public class symbol_1167 : MovieClip{ 
		public symbol_1167() {
			var i2288 = new symbol_115();
			addChild(i2288);//0
		}
	}
	public class symbol_1168 : MovieClip{ 
		public symbol_1168() {
			var i2290 = new symbol_115();
			addChild(i2290);//0
		}
	}
	public class symbol_1169 : MovieClip{ 
		public symbol_1169() {
			var i2292 = new symbol_115();
			addChild(i2292);//0
		}
	}
	public class symbol_117 : MovieClip{ 
		public symbol_117() {
			var i225 = new symbol_115();
			addChild(i225);//0
		}
	}
	public class symbol_1170 : MovieClip{ 
		public symbol_1170() {
			var i2295 = new symbol_115();
			addChild(i2295);//0
		}
	}
	public class symbol_1171 : MovieClip{ 
		public symbol_1171() {
			var i2297 = new symbol_132();
			addChild(i2297);//0
		}
	}
	public class symbol_1172 : MovieClip{ 
		public symbol_1172() {
			var i2299 = new symbol_132();
			addChild(i2299);//0
		}
	}
	public class symbol_1173 : MovieClip{ 
		public symbol_1173() {
			var i2301 = new symbol_132();
			addChild(i2301);//0
		}
	}
	public class symbol_1174 : MovieClip{ 
		public symbol_1174() {
			var i2303 = new symbol_132();
			addChild(i2303);//0
		}
	}
	public class symbol_1175 : MovieClip{ 
		public symbol_1175() {
			var i2305 = new symbol_115();
			addChild(i2305);//0
		}
	}
	public class symbol_1176 : MovieClip{ 
		public symbol_1176() {
			var i2307 = new symbol_115();
			addChild(i2307);//0
		}
	}
	public class symbol_1177 : MovieClip{ 
		public symbol_1177() {
			var i2309 = new symbol_132();
			addChild(i2309);//0
		}
	}
	public class symbol_1178 : MovieClip{ 
		public symbol_1178() {
			var i2311 = new symbol_132();
			addChild(i2311);//0
		}
	}
	public class symbol_1179 : MovieClip{ 
		public symbol_1179() {
			var i2313 = new symbol_132();
			addChild(i2313);//0
		}
	}
	public class symbol_118 : Shape{ 
		public symbol_118() {
			setGraphics("08254b3eaed927920aa1a7ed66cf02bd", 7.6, -168.65, 166.05, 99.2, 1, 1);
		}
	}
	public class symbol_1180 : MovieClip{ 
		public symbol_1180() {
			var i2315 = new symbol_115();
			addChild(i2315);//0
		}
	}
	public class symbol_1181 : MovieClip{ 
		public symbol_1181() {
			var i2317 = new symbol_132();
			addChild(i2317);//0
		}
	}
	public class symbol_1182 : MovieClip{ 
		public symbol_1182() {
			var i2319 = new symbol_132();
			addChild(i2319);//0
		}
	}
	public class symbol_1183 : MovieClip{ 
		public symbol_1183() {
			var i2321 = new symbol_132();
			addChild(i2321);//0
		}
	}
	public class symbol_1184 : MovieClip{ 
		public symbol_1184() {
			var i2323 = new symbol_132();
			addChild(i2323);//0
		}
	}
	public class symbol_1185 : MovieClip{ 
		public symbol_1185() {
			var i2325 = new symbol_132();
			addChild(i2325);//0
		}
	}
	public class symbol_1186 : MovieClip{ 
		public symbol_1186() {
			var i2327 = new symbol_115();
			addChild(i2327);//0
		}
	}
	public class symbol_1187 : MovieClip{ 
		public symbol_1187() {
			var i2329 = new symbol_132();
			addChild(i2329);//0
		}
	}
	public class symbol_1188 : MovieClip{ 
		public symbol_1188() {
			var i2331 = new symbol_132();
			addChild(i2331);//0
		}
	}
	public class symbol_1189 : MovieClip{ 
		public symbol_1189() {
			var i2333 = new symbol_132();
			addChild(i2333);//0
		}
	}
	public class symbol_119 : MovieClip{ 
		public symbol_119() {
			var i228 = new symbol_115();
			addChild(i228);//0
		}
	}
	public class symbol_1190 : MovieClip{ 
		public symbol_1190() {
			var i2335 = new symbol_132();
			addChild(i2335);//0
		}
	}
	public class symbol_1191 : MovieClip{ 
		public symbol_1191() {
			var i2337 = new symbol_115();
			addChild(i2337);//0
		}
	}
	public class symbol_1192 : MovieClip{ 
		public symbol_1192() {
			var i2339 = new symbol_132();
			addChild(i2339);//0
		}
	}
	public class symbol_1193 : MovieClip{ 
		public symbol_1193() {
			var i2341 = new symbol_132();
			addChild(i2341);//0
		}
	}
	public class symbol_1194 : MovieClip{ 
		public symbol_1194() {
			var i2343 = new symbol_132();
			addChild(i2343);//0
		}
	}
	public class symbol_1195 : MovieClip{ 
		public symbol_1195() {
			var i2345 = new symbol_115();
			addChild(i2345);//0
		}
	}
	public class symbol_1196 : MovieClip{ 
		public symbol_1196() {
			var i2347 = new symbol_132();
			addChild(i2347);//0
		}
	}
	public class symbol_1197 : MovieClip{ 
		public symbol_1197() {
			var i2349 = new symbol_132();
			addChild(i2349);//0
		}
	}
	public class symbol_1198 : MovieClip{ 
		public symbol_1198() {
			var i2351 = new symbol_132();
			addChild(i2351);//0
		}
	}
	public class symbol_1199 : MovieClip{ 
		public symbol_1199() {
			var i2353 = new symbol_115();
			addChild(i2353);//0
		}
	}
	public class symbol_12 : MovieClip{ 
		public symbol_12() {
			var i70 = new symbol_11();
			addChild(i70);//0
		}
	}
	public class symbol_120 : Shape{ 
		public symbol_120() {
			setGraphics("45b80d9fc037c23d07a909da0065e9e9", -92.8, -128.05, 162.7, 206.5, 1, 1);
		}
	}
	public class symbol_1200 : MovieClip{ 
		public symbol_1200() {
			var i2355 = new symbol_132();
			addChild(i2355);//0
		}
	}
	public class symbol_1201 : MovieClip{ 
		public symbol_1201() {
			var i2357 = new symbol_132();
			addChild(i2357);//0
		}
	}
	public class symbol_1202 : MovieClip{ 
		public symbol_1202() {
			var i2359 = new symbol_132();
			addChild(i2359);//0
		}
	}
	public class symbol_1203 : MovieClip{ 
		public symbol_1203() {
			var i2261 = new symbol_294();
			addChild(i2261);//0
			var i2262 = new symbol_1157(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i2262);//1
			var i2264 = new symbol_1158(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i2264);//2
			var i2266 = new symbol_1159(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i2266);//3
			var i2268 = new symbol_434();
			addChild(i2268);//4
			var i2269 = new symbol_1160(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i2269);//5
			var i2271 = new symbol_1161(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i2271);//6
			var i2273 = new symbol_483();
			addChild(i2273);//7
			var i2274 = new symbol_1162(){x = 135.9 , scaleX = 1 , y = -331.8 , scaleY = 1 , rotation = 48};
			addChild(i2274);//8
			var i2276 = new symbol_1163(){x = 207.3 , scaleX = 1 , y = -329.6 , scaleY = 1 , rotation = 18};
			addChild(i2276);//9
			var i2278 = new symbol_1164(){x = 220.8 , scaleX = 0.89 , y = -369.8 , scaleY = 0.77 , rotation = 68};
			addChild(i2278);//10
			var i2280 = new symbol_536();
			addChild(i2280);//11
			var i2281 = new symbol_1165(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i2281);//12
			var i2283 = new symbol_392();
			addChild(i2283);//13
			var i2284 = new symbol_1166(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i2284);//14
			var i2286 = new symbol_440();
			addChild(i2286);//15
			var i2287 = new symbol_1167(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i2287);//16
			var i2289 = new symbol_1168(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i2289);//17
			var i2291 = new symbol_1169(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i2291);//18
			var i2293 = new symbol_352();
			addChild(i2293);//19
			var i2294 = new symbol_1170(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i2294);//20
			var i2296 = new symbol_1171(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i2296);//21
			var i2298 = new symbol_1172(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i2298);//22
			var i2300 = new symbol_1173(){x = 90.7 , scaleX = 0.79 , y = -419.6 , scaleY = 0.79 , rotation = 13};
			addChild(i2300);//23
			var i2302 = new symbol_1174(){x = 101.2 , scaleX = 1 , y = -420.1 , scaleY = 1 , rotation = 53};
			addChild(i2302);//24
			var i2304 = new symbol_1175(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i2304);//25
			var i2306 = new symbol_1176(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i2306);//26
			var i2308 = new symbol_1177(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i2308);//27
			var i2310 = new symbol_1178(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i2310);//28
			var i2312 = new symbol_1179(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i2312);//29
			var i2314 = new symbol_1180(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i2314);//30
			var i2316 = new symbol_1181(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i2316);//31
			var i2318 = new symbol_1182(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i2318);//32
			var i2320 = new symbol_1183(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i2320);//33
			var i2322 = new symbol_1184(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i2322);//34
			var i2324 = new symbol_1185(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i2324);//35
			var i2326 = new symbol_1186(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i2326);//36
			var i2328 = new symbol_1187(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i2328);//37
			var i2330 = new symbol_1188(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i2330);//38
			var i2332 = new symbol_1189(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i2332);//39
			var i2334 = new symbol_1190(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i2334);//40
			var i2336 = new symbol_1191(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i2336);//41
			var i2338 = new symbol_1192(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i2338);//42
			var i2340 = new symbol_1193(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i2340);//43
			var i2342 = new symbol_1194(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i2342);//44
			var i2344 = new symbol_1195(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i2344);//45
			var i2346 = new symbol_1196(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i2346);//46
			var i2348 = new symbol_1197(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i2348);//47
			var i2350 = new symbol_1198(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i2350);//48
			var i2352 = new symbol_1199(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i2352);//49
			var i2354 = new symbol_1200(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i2354);//50
			var i2356 = new symbol_1201(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i2356);//51
			var i2358 = new symbol_1202(){x = 135.3 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 108};
			addChild(i2358);//52
			var i2360 = new symbol_381();
			addChild(i2360);//53
		}
	}
	public class symbol_1204 : MovieClip{ 
		public symbol_1204() {
			var i2361 = new symbol_33();
			addChild(i2361);//0
		}
	}
	public class symbol_1205 : MovieClip{ 
		public symbol_1205() {
			var i2363 = new symbol_13();
			addChild(i2363);//0
		}
	}
	public class symbol_1206 : Shape{ 
		public symbol_1206() {
			setGraphics("69092c97663bfa779adb661908114e9c", -137.25, -34.45, 58.349999999999994, 81.95, 1, 1);
		}
	}
	public class symbol_1207 : MovieClip{ 
		public symbol_1207() {
			var i2366 = new symbol_579();
			addChild(i2366);//0
		}
	}
	public class symbol_1208 : MovieClip{ 
		public symbol_1208() {
			var i2370 = new symbol_115();
			addChild(i2370);//0
		}
	}
	public class symbol_1209 : MovieClip{ 
		public symbol_1209() {
			var i2372 = new symbol_115();
			addChild(i2372);//0
		}
	}
	public class symbol_121 : MovieClip{ 
		public symbol_121() {
			var i231 = new symbol_104();
			addChild(i231);//0
		}
	}
	public class symbol_1210 : MovieClip{ 
		public symbol_1210() {
			var i2374 = new symbol_115();
			addChild(i2374);//0
		}
	}
	public class symbol_1211 : MovieClip{ 
		public symbol_1211() {
			var i2377 = new symbol_132();
			addChild(i2377);//0
		}
	}
	public class symbol_1212 : MovieClip{ 
		public symbol_1212() {
			var i2379 = new symbol_132();
			addChild(i2379);//0
		}
	}
	public class symbol_1213 : MovieClip{ 
		public symbol_1213() {
			var i2382 = new symbol_115();
			addChild(i2382);//0
		}
	}
	public class symbol_1214 : MovieClip{ 
		public symbol_1214() {
			var i2384 = new symbol_115();
			addChild(i2384);//0
		}
	}
	public class symbol_1215 : MovieClip{ 
		public symbol_1215() {
			var i2386 = new symbol_132();
			addChild(i2386);//0
		}
	}
	public class symbol_1216 : MovieClip{ 
		public symbol_1216() {
			var i2389 = new symbol_115();
			addChild(i2389);//0
		}
	}
	public class symbol_1217 : MovieClip{ 
		public symbol_1217() {
			var i2392 = new symbol_132();
			addChild(i2392);//0
		}
	}
	public class symbol_1218 : MovieClip{ 
		public symbol_1218() {
			var i2395 = new symbol_115();
			addChild(i2395);//0
		}
	}
	public class symbol_1219 : MovieClip{ 
		public symbol_1219() {
			var i2397 = new symbol_115();
			addChild(i2397);//0
		}
	}
	public class symbol_122 : MovieClip{ 
		public symbol_122() {
			var i233 = new symbol_104();
			addChild(i233);//0
		}
	}
	public class symbol_1220 : MovieClip{ 
		public symbol_1220() {
			var i2399 = new symbol_115();
			addChild(i2399);//0
		}
	}
	public class symbol_1221 : MovieClip{ 
		public symbol_1221() {
			var i2402 = new symbol_115();
			addChild(i2402);//0
		}
	}
	public class symbol_1222 : MovieClip{ 
		public symbol_1222() {
			var i2404 = new symbol_132();
			addChild(i2404);//0
		}
	}
	public class symbol_1223 : MovieClip{ 
		public symbol_1223() {
			var i2406 = new symbol_132();
			addChild(i2406);//0
		}
	}
	public class symbol_1224 : MovieClip{ 
		public symbol_1224() {
			var i2408 = new symbol_132();
			addChild(i2408);//0
		}
	}
	public class symbol_1225 : MovieClip{ 
		public symbol_1225() {
			var i2410 = new symbol_132();
			addChild(i2410);//0
		}
	}
	public class symbol_1226 : MovieClip{ 
		public symbol_1226() {
			var i2412 = new symbol_115();
			addChild(i2412);//0
		}
	}
	public class symbol_1227 : MovieClip{ 
		public symbol_1227() {
			var i2414 = new symbol_115();
			addChild(i2414);//0
		}
	}
	public class symbol_1228 : MovieClip{ 
		public symbol_1228() {
			var i2416 = new symbol_132();
			addChild(i2416);//0
		}
	}
	public class symbol_1229 : MovieClip{ 
		public symbol_1229() {
			var i2418 = new symbol_132();
			addChild(i2418);//0
		}
	}
	public class symbol_123 : MovieClip{ 
		public symbol_123() {
			var i235 = new symbol_104();
			addChild(i235);//0
		}
	}
	public class symbol_1230 : MovieClip{ 
		public symbol_1230() {
			var i2420 = new symbol_132();
			addChild(i2420);//0
		}
	}
	public class symbol_1231 : MovieClip{ 
		public symbol_1231() {
			var i2422 = new symbol_115();
			addChild(i2422);//0
		}
	}
	public class symbol_1232 : MovieClip{ 
		public symbol_1232() {
			var i2424 = new symbol_132();
			addChild(i2424);//0
		}
	}
	public class symbol_1233 : MovieClip{ 
		public symbol_1233() {
			var i2426 = new symbol_132();
			addChild(i2426);//0
		}
	}
	public class symbol_1234 : MovieClip{ 
		public symbol_1234() {
			var i2428 = new symbol_132();
			addChild(i2428);//0
		}
	}
	public class symbol_1235 : MovieClip{ 
		public symbol_1235() {
			var i2430 = new symbol_132();
			addChild(i2430);//0
		}
	}
	public class symbol_1236 : MovieClip{ 
		public symbol_1236() {
			var i2432 = new symbol_132();
			addChild(i2432);//0
		}
	}
	public class symbol_1237 : MovieClip{ 
		public symbol_1237() {
			var i2434 = new symbol_115();
			addChild(i2434);//0
		}
	}
	public class symbol_1238 : MovieClip{ 
		public symbol_1238() {
			var i2436 = new symbol_132();
			addChild(i2436);//0
		}
	}
	public class symbol_1239 : MovieClip{ 
		public symbol_1239() {
			var i2438 = new symbol_132();
			addChild(i2438);//0
		}
	}
	public class symbol_124 : MovieClip{ 
		public symbol_124() {
			var i237 = new symbol_104();
			addChild(i237);//0
		}
	}
	public class symbol_1240 : MovieClip{ 
		public symbol_1240() {
			var i2440 = new symbol_132();
			addChild(i2440);//0
		}
	}
	public class symbol_1241 : MovieClip{ 
		public symbol_1241() {
			var i2442 = new symbol_132();
			addChild(i2442);//0
		}
	}
	public class symbol_1242 : MovieClip{ 
		public symbol_1242() {
			var i2444 = new symbol_115();
			addChild(i2444);//0
		}
	}
	public class symbol_1243 : MovieClip{ 
		public symbol_1243() {
			var i2446 = new symbol_132();
			addChild(i2446);//0
		}
	}
	public class symbol_1244 : MovieClip{ 
		public symbol_1244() {
			var i2448 = new symbol_132();
			addChild(i2448);//0
		}
	}
	public class symbol_1245 : MovieClip{ 
		public symbol_1245() {
			var i2450 = new symbol_132();
			addChild(i2450);//0
		}
	}
	public class symbol_1246 : MovieClip{ 
		public symbol_1246() {
			var i2452 = new symbol_115();
			addChild(i2452);//0
		}
	}
	public class symbol_1247 : MovieClip{ 
		public symbol_1247() {
			var i2454 = new symbol_132();
			addChild(i2454);//0
		}
	}
	public class symbol_1248 : MovieClip{ 
		public symbol_1248() {
			var i2456 = new symbol_132();
			addChild(i2456);//0
		}
	}
	public class symbol_1249 : MovieClip{ 
		public symbol_1249() {
			var i2458 = new symbol_132();
			addChild(i2458);//0
		}
	}
	public class symbol_125 : MovieClip{ 
		public symbol_125() {
			var i239 = new symbol_104();
			addChild(i239);//0
		}
	}
	public class symbol_1250 : MovieClip{ 
		public symbol_1250() {
			var i2460 = new symbol_115();
			addChild(i2460);//0
		}
	}
	public class symbol_1251 : MovieClip{ 
		public symbol_1251() {
			var i2462 = new symbol_132();
			addChild(i2462);//0
		}
	}
	public class symbol_1252 : MovieClip{ 
		public symbol_1252() {
			var i2464 = new symbol_132();
			addChild(i2464);//0
		}
	}
	public class symbol_1253 : MovieClip{ 
		public symbol_1253() {
			var i2466 = new symbol_132();
			addChild(i2466);//0
		}
	}
	public class symbol_1254 : MovieClip{ 
		public symbol_1254() {
			var i2469 = new symbol_132();
			addChild(i2469);//0
		}
	}
	public class symbol_1255 : MovieClip{ 
		public symbol_1255() {
			var i2471 = new symbol_132();
			addChild(i2471);//0
		}
	}
	public class symbol_1256 : MovieClip{ 
		public symbol_1256() {
			var i2368 = new symbol_294();
			addChild(i2368);//0
			var i2369 = new symbol_1208(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i2369);//1
			var i2371 = new symbol_1209(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i2371);//2
			var i2373 = new symbol_1210(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i2373);//3
			var i2375 = new symbol_434();
			addChild(i2375);//4
			var i2376 = new symbol_1211(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i2376);//5
			var i2378 = new symbol_1212(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i2378);//6
			var i2380 = new symbol_483();
			addChild(i2380);//7
			var i2381 = new symbol_1213(){x = 135.9 , scaleX = 1 , y = -331.8 , scaleY = 1 , rotation = 48};
			addChild(i2381);//8
			var i2383 = new symbol_1214(){x = 207.3 , scaleX = 1 , y = -329.6 , scaleY = 1 , rotation = 18};
			addChild(i2383);//9
			var i2385 = new symbol_1215(){x = 220.8 , scaleX = 0.89 , y = -369.8 , scaleY = 0.77 , rotation = 68};
			addChild(i2385);//10
			var i2387 = new symbol_589();
			addChild(i2387);//11
			var i2388 = new symbol_1216(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i2388);//12
			var i2390 = new symbol_392();
			addChild(i2390);//13
			var i2391 = new symbol_1217(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i2391);//14
			var i2393 = new symbol_394();
			addChild(i2393);//15
			var i2394 = new symbol_1218(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i2394);//16
			var i2396 = new symbol_1219(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i2396);//17
			var i2398 = new symbol_1220(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i2398);//18
			var i2400 = new symbol_595();
			addChild(i2400);//19
			var i2401 = new symbol_1221(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i2401);//20
			var i2403 = new symbol_1222(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i2403);//21
			var i2405 = new symbol_1223(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i2405);//22
			var i2407 = new symbol_1224(){x = 90.7 , scaleX = 0.79 , y = -419.6 , scaleY = 0.79 , rotation = 13};
			addChild(i2407);//23
			var i2409 = new symbol_1225(){x = 101.2 , scaleX = 1 , y = -420.1 , scaleY = 1 , rotation = 53};
			addChild(i2409);//24
			var i2411 = new symbol_1226(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i2411);//25
			var i2413 = new symbol_1227(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i2413);//26
			var i2415 = new symbol_1228(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i2415);//27
			var i2417 = new symbol_1229(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i2417);//28
			var i2419 = new symbol_1230(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i2419);//29
			var i2421 = new symbol_1231(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i2421);//30
			var i2423 = new symbol_1232(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i2423);//31
			var i2425 = new symbol_1233(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i2425);//32
			var i2427 = new symbol_1234(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i2427);//33
			var i2429 = new symbol_1235(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i2429);//34
			var i2431 = new symbol_1236(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i2431);//35
			var i2433 = new symbol_1237(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i2433);//36
			var i2435 = new symbol_1238(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i2435);//37
			var i2437 = new symbol_1239(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i2437);//38
			var i2439 = new symbol_1240(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i2439);//39
			var i2441 = new symbol_1241(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i2441);//40
			var i2443 = new symbol_1242(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i2443);//41
			var i2445 = new symbol_1243(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i2445);//42
			var i2447 = new symbol_1244(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i2447);//43
			var i2449 = new symbol_1245(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i2449);//44
			var i2451 = new symbol_1246(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i2451);//45
			var i2453 = new symbol_1247(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i2453);//46
			var i2455 = new symbol_1248(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i2455);//47
			var i2457 = new symbol_1249(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i2457);//48
			var i2459 = new symbol_1250(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i2459);//49
			var i2461 = new symbol_1251(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i2461);//50
			var i2463 = new symbol_1252(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i2463);//51
			var i2465 = new symbol_1253(){x = 135.3 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 108};
			addChild(i2465);//52
			var i2467 = new symbol_629();
			addChild(i2467);//53
			var i2468 = new symbol_1254(){x = -57.7 , scaleX = 1 , y = -410.7 , scaleY = 1 , rotation = 19};
			addChild(i2468);//54
			var i2470 = new symbol_1255(){x = -48 , scaleX = 0.76 , y = -410.6 , scaleY = 0.76 , rotation = 55};
			addChild(i2470);//55
			var i2472 = new symbol_632();
			addChild(i2472);//56
		}
	}
	public class symbol_1257 : MovieClip{ 
		public symbol_1257() {
			var i2473 = new symbol_33();
			addChild(i2473);//0
		}
	}
	public class symbol_1258 : Shape{ 
		public symbol_1258() {
			setGraphics("27a5c4980b287c951ada360c0e536c05", -82, 50, 81.2, 41.400000000000006, 1, 1);
		}
	}
	public class symbol_1259 : MovieClip{ 
		public symbol_1259() {
			var i2478 = new symbol_115();
			addChild(i2478);//0
		}
	}
	public class symbol_126 : MovieClip{ 
		public symbol_126() {
			var i241 = new symbol_115();
			addChild(i241);//0
		}
	}
	public class symbol_1260 : MovieClip{ 
		public symbol_1260() {
			var i2480 = new symbol_115();
			addChild(i2480);//0
		}
	}
	public class symbol_1261 : MovieClip{ 
		public symbol_1261() {
			var i2482 = new symbol_115();
			addChild(i2482);//0
		}
	}
	public class symbol_1262 : MovieClip{ 
		public symbol_1262() {
			var i2485 = new symbol_132();
			addChild(i2485);//0
		}
	}
	public class symbol_1263 : MovieClip{ 
		public symbol_1263() {
			var i2487 = new symbol_132();
			addChild(i2487);//0
		}
	}
	public class symbol_1264 : MovieClip{ 
		public symbol_1264() {
			var i2490 = new symbol_115();
			addChild(i2490);//0
		}
	}
	public class symbol_1265 : MovieClip{ 
		public symbol_1265() {
			var i2492 = new symbol_115();
			addChild(i2492);//0
		}
	}
	public class symbol_1266 : MovieClip{ 
		public symbol_1266() {
			var i2494 = new symbol_132();
			addChild(i2494);//0
		}
	}
	public class symbol_1267 : MovieClip{ 
		public symbol_1267() {
			var i2496 = new symbol_115();
			addChild(i2496);//0
		}
	}
	public class symbol_1268 : MovieClip{ 
		public symbol_1268() {
			var i2499 = new symbol_115();
			addChild(i2499);//0
		}
	}
	public class symbol_1269 : MovieClip{ 
		public symbol_1269() {
			var i2502 = new symbol_132();
			addChild(i2502);//0
		}
	}
	public class symbol_127 : MovieClip{ 
		public symbol_127() {
			var i243 = new symbol_104();
			addChild(i243);//0
		}
	}
	public class symbol_1270 : MovieClip{ 
		public symbol_1270() {
			var i2505 = new symbol_115();
			addChild(i2505);//0
		}
	}
	public class symbol_1271 : MovieClip{ 
		public symbol_1271() {
			var i2507 = new symbol_115();
			addChild(i2507);//0
		}
	}
	public class symbol_1272 : MovieClip{ 
		public symbol_1272() {
			var i2509 = new symbol_115();
			addChild(i2509);//0
		}
	}
	public class symbol_1273 : MovieClip{ 
		public symbol_1273() {
			var i2512 = new symbol_115();
			addChild(i2512);//0
		}
	}
	public class symbol_1274 : MovieClip{ 
		public symbol_1274() {
			var i2514 = new symbol_132();
			addChild(i2514);//0
		}
	}
	public class symbol_1275 : MovieClip{ 
		public symbol_1275() {
			var i2516 = new symbol_132();
			addChild(i2516);//0
		}
	}
	public class symbol_1276 : MovieClip{ 
		public symbol_1276() {
			var i2518 = new symbol_132();
			addChild(i2518);//0
		}
	}
	public class symbol_1277 : MovieClip{ 
		public symbol_1277() {
			var i2520 = new symbol_132();
			addChild(i2520);//0
		}
	}
	public class symbol_1278 : MovieClip{ 
		public symbol_1278() {
			var i2522 = new symbol_115();
			addChild(i2522);//0
		}
	}
	public class symbol_1279 : MovieClip{ 
		public symbol_1279() {
			var i2524 = new symbol_115();
			addChild(i2524);//0
		}
	}
	public class symbol_128 : MovieClip{ 
		public symbol_128() {
			var i245 = new symbol_104();
			addChild(i245);//0
		}
	}
	public class symbol_1280 : MovieClip{ 
		public symbol_1280() {
			var i2526 = new symbol_132();
			addChild(i2526);//0
		}
	}
	public class symbol_1281 : MovieClip{ 
		public symbol_1281() {
			var i2528 = new symbol_132();
			addChild(i2528);//0
		}
	}
	public class symbol_1282 : MovieClip{ 
		public symbol_1282() {
			var i2530 = new symbol_132();
			addChild(i2530);//0
		}
	}
	public class symbol_1283 : MovieClip{ 
		public symbol_1283() {
			var i2532 = new symbol_115();
			addChild(i2532);//0
		}
	}
	public class symbol_1284 : MovieClip{ 
		public symbol_1284() {
			var i2534 = new symbol_132();
			addChild(i2534);//0
		}
	}
	public class symbol_1285 : MovieClip{ 
		public symbol_1285() {
			var i2536 = new symbol_132();
			addChild(i2536);//0
		}
	}
	public class symbol_1286 : MovieClip{ 
		public symbol_1286() {
			var i2538 = new symbol_132();
			addChild(i2538);//0
		}
	}
	public class symbol_1287 : MovieClip{ 
		public symbol_1287() {
			var i2540 = new symbol_132();
			addChild(i2540);//0
		}
	}
	public class symbol_1288 : MovieClip{ 
		public symbol_1288() {
			var i2542 = new symbol_132();
			addChild(i2542);//0
		}
	}
	public class symbol_1289 : MovieClip{ 
		public symbol_1289() {
			var i2544 = new symbol_115();
			addChild(i2544);//0
		}
	}
	public class symbol_129 : MovieClip{ 
		public symbol_129() {
			var i247 = new symbol_104();
			addChild(i247);//0
		}
	}
	public class symbol_1290 : MovieClip{ 
		public symbol_1290() {
			var i2546 = new symbol_132();
			addChild(i2546);//0
		}
	}
	public class symbol_1291 : MovieClip{ 
		public symbol_1291() {
			var i2548 = new symbol_132();
			addChild(i2548);//0
		}
	}
	public class symbol_1292 : MovieClip{ 
		public symbol_1292() {
			var i2550 = new symbol_132();
			addChild(i2550);//0
		}
	}
	public class symbol_1293 : MovieClip{ 
		public symbol_1293() {
			var i2552 = new symbol_132();
			addChild(i2552);//0
		}
	}
	public class symbol_1294 : MovieClip{ 
		public symbol_1294() {
			var i2554 = new symbol_115();
			addChild(i2554);//0
		}
	}
	public class symbol_1295 : MovieClip{ 
		public symbol_1295() {
			var i2556 = new symbol_132();
			addChild(i2556);//0
		}
	}
	public class symbol_1296 : MovieClip{ 
		public symbol_1296() {
			var i2558 = new symbol_132();
			addChild(i2558);//0
		}
	}
	public class symbol_1297 : MovieClip{ 
		public symbol_1297() {
			var i2560 = new symbol_132();
			addChild(i2560);//0
		}
	}
	public class symbol_1298 : MovieClip{ 
		public symbol_1298() {
			var i2562 = new symbol_115();
			addChild(i2562);//0
		}
	}
	public class symbol_1299 : MovieClip{ 
		public symbol_1299() {
			var i2564 = new symbol_132();
			addChild(i2564);//0
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("69ae261ee63ffdb6a6607e6da0b47479", -21, -6.4, 42, 12.8, 1, 1);
		}
	}
	public class symbol_130 : Shape{ 
		public symbol_130() {
			setGraphics("f203455479802ba0fc39d4f5eed646a1", -8.65, -10.25, 17.3, 20.5, 1, 1);
		}
	}
	public class symbol_1300 : MovieClip{ 
		public symbol_1300() {
			var i2566 = new symbol_132();
			addChild(i2566);//0
		}
	}
	public class symbol_1301 : MovieClip{ 
		public symbol_1301() {
			var i2568 = new symbol_132();
			addChild(i2568);//0
		}
	}
	public class symbol_1302 : MovieClip{ 
		public symbol_1302() {
			var i2570 = new symbol_115();
			addChild(i2570);//0
		}
	}
	public class symbol_1303 : MovieClip{ 
		public symbol_1303() {
			var i2572 = new symbol_132();
			addChild(i2572);//0
		}
	}
	public class symbol_1304 : MovieClip{ 
		public symbol_1304() {
			var i2574 = new symbol_132();
			addChild(i2574);//0
		}
	}
	public class symbol_1305 : MovieClip{ 
		public symbol_1305() {
			var i2576 = new symbol_132();
			addChild(i2576);//0
		}
	}
	public class symbol_1306 : MovieClip{ 
		public symbol_1306() {
			var i2578 = new symbol_132();
			addChild(i2578);//0
		}
	}
	public class symbol_1307 : MovieClip{ 
		public symbol_1307() {
			var i2580 = new symbol_132();
			addChild(i2580);//0
		}
	}
	public class symbol_1308 : MovieClip{ 
		public symbol_1308() {
			var i2583 = new symbol_132();
			addChild(i2583);//0
		}
	}
	public class symbol_1309 : MovieClip{ 
		public symbol_1309() {
			var i2476 = new symbol_294();
			addChild(i2476);//0
			var i2477 = new symbol_1259(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i2477);//1
			var i2479 = new symbol_1260(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i2479);//2
			var i2481 = new symbol_1261(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i2481);//3
			var i2483 = new symbol_434();
			addChild(i2483);//4
			var i2484 = new symbol_1262(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i2484);//5
			var i2486 = new symbol_1263(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i2486);//6
			var i2488 = new symbol_483();
			addChild(i2488);//7
			var i2489 = new symbol_1264(){x = 135.9 , scaleX = 1 , y = -331.8 , scaleY = 1 , rotation = 48};
			addChild(i2489);//8
			var i2491 = new symbol_1265(){x = 207.3 , scaleX = 1 , y = -329.6 , scaleY = 1 , rotation = 18};
			addChild(i2491);//9
			var i2493 = new symbol_1266(){x = 220.8 , scaleX = 0.89 , y = -369.8 , scaleY = 0.77 , rotation = 68};
			addChild(i2493);//10
			var i2495 = new symbol_1267(){x = 88.5 , scaleX = 1 , y = -402.1 , scaleY = 1 , rotation = -97};
			addChild(i2495);//11
			var i2497 = new symbol_645();
			addChild(i2497);//12
			var i2498 = new symbol_1268(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i2498);//13
			var i2500 = new symbol_392();
			addChild(i2500);//14
			var i2501 = new symbol_1269(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i2501);//15
			var i2503 = new symbol_440();
			addChild(i2503);//16
			var i2504 = new symbol_1270(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i2504);//17
			var i2506 = new symbol_1271(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i2506);//18
			var i2508 = new symbol_1272(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i2508);//19
			var i2510 = new symbol_651();
			addChild(i2510);//20
			var i2511 = new symbol_1273(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i2511);//21
			var i2513 = new symbol_1274(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i2513);//22
			var i2515 = new symbol_1275(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i2515);//23
			var i2517 = new symbol_1276(){x = 73.1 , scaleX = 0.79 , y = -454.3 , scaleY = 0.79 , rotation = -1};
			addChild(i2517);//24
			var i2519 = new symbol_1277(){x = 110.3 , scaleX = 1 , y = -378.8 , scaleY = 1 , rotation = 83};
			addChild(i2519);//25
			var i2521 = new symbol_1278(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i2521);//26
			var i2523 = new symbol_1279(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i2523);//27
			var i2525 = new symbol_1280(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i2525);//28
			var i2527 = new symbol_1281(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i2527);//29
			var i2529 = new symbol_1282(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i2529);//30
			var i2531 = new symbol_1283(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i2531);//31
			var i2533 = new symbol_1284(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i2533);//32
			var i2535 = new symbol_1285(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i2535);//33
			var i2537 = new symbol_1286(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i2537);//34
			var i2539 = new symbol_1287(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i2539);//35
			var i2541 = new symbol_1288(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i2541);//36
			var i2543 = new symbol_1289(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i2543);//37
			var i2545 = new symbol_1290(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i2545);//38
			var i2547 = new symbol_1291(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i2547);//39
			var i2549 = new symbol_1292(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i2549);//40
			var i2551 = new symbol_1293(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i2551);//41
			var i2553 = new symbol_1294(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i2553);//42
			var i2555 = new symbol_1295(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i2555);//43
			var i2557 = new symbol_1296(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i2557);//44
			var i2559 = new symbol_1297(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i2559);//45
			var i2561 = new symbol_1298(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i2561);//46
			var i2563 = new symbol_1299(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i2563);//47
			var i2565 = new symbol_1300(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i2565);//48
			var i2567 = new symbol_1301(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i2567);//49
			var i2569 = new symbol_1302(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i2569);//50
			var i2571 = new symbol_1303(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i2571);//51
			var i2573 = new symbol_1304(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i2573);//52
			var i2575 = new symbol_1305(){x = 135.3 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 108};
			addChild(i2575);//53
			var i2577 = new symbol_1306(){x = -71.2 , scaleX = 1 , y = -450.4 , scaleY = 1 , rotation = 19};
			addChild(i2577);//54
			var i2579 = new symbol_1307(){x = -61.5 , scaleX = 0.76 , y = -450.3 , scaleY = 0.76 , rotation = 55};
			addChild(i2579);//55
			var i2581 = new symbol_687();
			addChild(i2581);//56
			var i2582 = new symbol_1308(){x = -3.3 , scaleX = 0.76 , y = -468.3 , scaleY = 0.76 , rotation = 103};
			addChild(i2582);//57
			var i2584 = new symbol_689();
			addChild(i2584);//58
		}
	}
	public class symbol_131 : MovieClip{ 
		public symbol_131() {
			var i249 = new symbol_130();
			addChild(i249);//0
		}
	}
	public class symbol_1310 : MovieClip{ 
		public symbol_1310() {
			var i2585 = new symbol_33();
			addChild(i2585);//0
		}
	}
	public class symbol_1311 : Shape{ 
		public symbol_1311() {
			setGraphics("a1e6790830bb200f29bb21428a57c592", -180.9, 48.95, 270.7, 53.45, 1, 1);
		}
	}
	public class symbol_1312 : MovieClip{ 
		public symbol_1312() {
			var i2587 = new symbol_33();
			addChild(i2587);//0
		}
	}
	public class symbol_1313 : Shape{ 
		public symbol_1313() {
			setGraphics("197f0c08d228249008f5ace53f4af97b", -180.9, 8.1, 312.45000000000005, 96.30000000000001, 1, 1);
		}
	}
	public class symbol_1314 : MovieClip{ 
		public symbol_1314() {
			var i2589 = new symbol_33();
			addChild(i2589);//0
		}
	}
	public class symbol_1315 : Shape{ 
		public symbol_1315() {
			setGraphics("4992f5a0511a9f2435ddec0ae77d59b9", -180.9, 8.1, 312.45000000000005, 94.30000000000001, 1, 1);
		}
	}
	public class symbol_1316 : MovieClip{ 
		public symbol_1316() {
			var i2591 = new symbol_33();
			addChild(i2591);//0
		}
	}
	public class symbol_1317 : MovieClip{ 
		public symbol_1317() {
			var i2593 = new symbol_33();
			addChild(i2593);//0
		}
	}
	public class symbol_1318 : Shape{ 
		public symbol_1318() {
			setGraphics("299ed65c73e58e7abdf818abe0abfb55", -52.5, 51.55, 48.2, 30.650000000000006, 1, 1);
		}
	}
	public class symbol_1319 : MovieClip{ 
		public symbol_1319() {
			var i2595 = new symbol_33();
			addChild(i2595);//0
		}
	}
	public class symbol_132 : Shape{ 
		public symbol_132() {
			setGraphics("f203455479802ba0fc39d4f5eed646a1", -8.65, -10.25, 17.3, 20.5, 1, 1);
		}
	}
	public class symbol_1320 : MovieClip{ 
		public symbol_1320() {
			var i2596 = new symbol_33();
			addChild(i2596);//0
		}
	}
	public class symbol_1321 : Shape{ 
		public symbol_1321() {
			setGraphics("14ebe2e18717494163f67b34876e8379", -86.65, 53.55, 42.75000000000001, 30.549999999999997, 1, 1);
		}
	}
	public class symbol_1322 : MovieClip{ 
		public symbol_1322() {
			var i2598 = new symbol_33();
			addChild(i2598);//0
		}
	}
	public class symbol_1323 : MovieClip{ 
		public symbol_1323() {
			var i2599 = new symbol_33();
			addChild(i2599);//0
		}
	}
	public class symbol_133 : MovieClip{ 
		public symbol_133() {
			var i251 = new symbol_132();
			addChild(i251);//0
		}
	}
	public class symbol_134 : MovieClip{ 
		public symbol_134() {
			var i204 = new symbol_101(){x = -53.9 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i204);//0
			var i206 = new symbol_102();
			addChild(i206);//1
			var i207 = new symbol_103(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i207);//2
			var i209 = new symbol_105(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i209);//3
			var i211 = new symbol_107(){x = 18.8 , scaleX = 1 , y = -205.1 , scaleY = 1 , rotation = -26};
			addChild(i211);//4
			var i213 = new symbol_108();
			addChild(i213);//5
			var i214 = new symbol_109(){x = -105.6 , scaleX = 1 , y = -99.7 , scaleY = 1 , rotation = 140};
			addChild(i214);//6
			var i216 = new symbol_110(){x = -102.8 , scaleX = 1 , y = -137.5 , scaleY = 1 , rotation = 163};
			addChild(i216);//7
			var i218 = new symbol_111();
			addChild(i218);//8
			var i219 = new symbol_113(){x = -161.1 , scaleX = 1 , y = -170.6 , scaleY = 1 , rotation = -129};
			addChild(i219);//9
			var i221 = new symbol_114();
			addChild(i221);//10
			var i222 = new symbol_116(){x = 86.2 , scaleX = 1 , y = -118.3 , scaleY = 1 , rotation = 32};
			addChild(i222);//11
			var i224 = new symbol_117(){x = 147.4 , scaleX = 1 , y = -173.8 , scaleY = 1 , rotation = -41};
			addChild(i224);//12
			var i226 = new symbol_118();
			addChild(i226);//13
			var i227 = new symbol_119(){x = 172.2 , scaleX = 1 , y = -126.3 , scaleY = 1 , rotation = 25};
			addChild(i227);//14
			var i229 = new symbol_120();
			addChild(i229);//15
			var i230 = new symbol_121(){x = -61.3 , scaleX = 1 , y = -190.1 , scaleY = 1 , rotation = -61};
			addChild(i230);//16
			var i232 = new symbol_122(){x = 73.3 , scaleX = 1 , y = -207.3 , scaleY = 1 , rotation = 152};
			addChild(i232);//17
			var i234 = new symbol_123(){x = -141.8 , scaleX = 1 , y = -182 , scaleY = 1 , rotation = -40};
			addChild(i234);//18
			var i236 = new symbol_124(){x = -114 , scaleX = 1 , y = -174.4 , scaleY = 1 , rotation = 14};
			addChild(i236);//19
			var i238 = new symbol_125(){x = -160.3 , scaleX = 1 , y = -157.4 , scaleY = 1 , rotation = -65};
			addChild(i238);//20
			var i240 = new symbol_126(){x = -156.3 , scaleX = 1 , y = -96.2 , scaleY = 1 , rotation = 140};
			addChild(i240);//21
			var i242 = new symbol_127(){x = -163.1 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i242);//22
			var i244 = new symbol_128(){x = -62 , scaleX = 1 , y = -209.3 , scaleY = 1 , rotation = 10};
			addChild(i244);//23
			var i246 = new symbol_129(){x = 156.5 , scaleX = 1 , y = -169.8 , scaleY = 1 , rotation = 108};
			addChild(i246);//24
			var i248 = new symbol_131(){x = 147.8 , scaleX = 1 , y = -157.2 , scaleY = 1 , rotation = 143};
			addChild(i248);//25
			var i250 = new symbol_133(){x = 164.6 , scaleX = 1 , y = -135.7 , scaleY = 1 , rotation = 101};
			addChild(i250);//26
		}
	}
	public class symbol_135 : MovieClip{ 
		public symbol_135() {
			var i252 = new symbol_33();
			addChild(i252);//0
		}
	}
	public class symbol_136 : Shape{ 
		public symbol_136() {
			setGraphics("5a747aa83c0f9e7cd81d66e0ae81a755", 107.65, -100.75, 57.900000000000006, 43.9, 1, 1);
		}
	}
	public class symbol_137 : Shape{ 
		public symbol_137() {
			setGraphics("4364a6c46249a5dce758c3231f677e57", -60.6, -202.25, 62.95, 32.25, 1, 1);
		}
	}
	public class symbol_138 : MovieClip{ 
		public symbol_138() {
			var i257 = new symbol_115();
			addChild(i257);//0
		}
	}
	public class symbol_139 : Shape{ 
		public symbol_139() {
			setGraphics("900c6c05d1a3278b0da8c298424401de", -27.1, -280.55, 175.1, 281.2, 1, 1);
		}
	}
	public class symbol_14 : MovieClip{ 
		public symbol_14() {
			var i72 = new symbol_13();
			addChild(i72);//0
		}
	}
	public class symbol_140 : MovieClip{ 
		public symbol_140() {
			var i260 = new symbol_115();
			addChild(i260);//0
		}
	}
	public class symbol_141 : Shape{ 
		public symbol_141() {
			setGraphics("42aa68298c317f09a85dffe75e0e00c3", -96, -168.65, 269.65, 106.05000000000001, 1, 1);
		}
	}
	public class symbol_142 : MovieClip{ 
		public symbol_142() {
			var i263 = new symbol_115();
			addChild(i263);//0
		}
	}
	public class symbol_143 : MovieClip{ 
		public symbol_143() {
			var i265 = new symbol_115();
			addChild(i265);//0
		}
	}
	public class symbol_144 : Shape{ 
		public symbol_144() {
			setGraphics("51314b55c92dd6e6322b9d7fdbac3b44", -212.8, -210.9, 368, 289.35, 1, 1);
		}
	}
	public class symbol_145 : MovieClip{ 
		public symbol_145() {
			var i268 = new symbol_115();
			addChild(i268);//0
		}
	}
	public class symbol_146 : MovieClip{ 
		public symbol_146() {
			var i270 = new symbol_132();
			addChild(i270);//0
		}
	}
	public class symbol_147 : MovieClip{ 
		public symbol_147() {
			var i272 = new symbol_132();
			addChild(i272);//0
		}
	}
	public class symbol_148 : MovieClip{ 
		public symbol_148() {
			var i274 = new symbol_115();
			addChild(i274);//0
		}
	}
	public class symbol_149 : MovieClip{ 
		public symbol_149() {
			var i276 = new symbol_115();
			addChild(i276);//0
		}
	}
	public class symbol_15 : Shape{ 
		public symbol_15() {
			setGraphics("78cebcf43da993cf5e00d99b532602bc", -44.6, -40.5, 89.2, 81, 1, 1);
		}
	}
	public class symbol_150 : MovieClip{ 
		public symbol_150() {
			var i278 = new symbol_115();
			addChild(i278);//0
		}
	}
	public class symbol_151 : MovieClip{ 
		public symbol_151() {
			var i280 = new symbol_132();
			addChild(i280);//0
		}
	}
	public class symbol_152 : MovieClip{ 
		public symbol_152() {
			var i282 = new symbol_132();
			addChild(i282);//0
		}
	}
	public class symbol_153 : MovieClip{ 
		public symbol_153() {
			var i284 = new symbol_132();
			addChild(i284);//0
		}
	}
	public class symbol_154 : MovieClip{ 
		public symbol_154() {
			var i286 = new symbol_132();
			addChild(i286);//0
		}
	}
	public class symbol_155 : MovieClip{ 
		public symbol_155() {
			var i288 = new symbol_132();
			addChild(i288);//0
		}
	}
	public class symbol_156 : MovieClip{ 
		public symbol_156() {
			var i290 = new symbol_115();
			addChild(i290);//0
		}
	}
	public class symbol_157 : MovieClip{ 
		public symbol_157() {
			var i292 = new symbol_132();
			addChild(i292);//0
		}
	}
	public class symbol_158 : MovieClip{ 
		public symbol_158() {
			var i294 = new symbol_132();
			addChild(i294);//0
		}
	}
	public class symbol_159 : MovieClip{ 
		public symbol_159() {
			var i296 = new symbol_132();
			addChild(i296);//0
		}
	}
	public class symbol_16 : MovieClip{ 
		public symbol_16() {
			var i74 = new symbol_15();
			addChild(i74);//0
		}
	}
	public class symbol_160 : MovieClip{ 
		public symbol_160() {
			var i298 = new symbol_132();
			addChild(i298);//0
		}
	}
	public class symbol_161 : MovieClip{ 
		public symbol_161() {
			var i300 = new symbol_132();
			addChild(i300);//0
		}
	}
	public class symbol_162 : MovieClip{ 
		public symbol_162() {
			var i255 = new symbol_137();
			addChild(i255);//0
			var i256 = new symbol_138(){x = 18.8 , scaleX = 1 , y = -205.1 , scaleY = 1 , rotation = -26};
			addChild(i256);//1
			var i258 = new symbol_139();
			addChild(i258);//2
			var i259 = new symbol_140(){x = 86.2 , scaleX = 1 , y = -118.3 , scaleY = 1 , rotation = 32};
			addChild(i259);//3
			var i261 = new symbol_141();
			addChild(i261);//4
			var i262 = new symbol_142(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i262);//5
			var i264 = new symbol_143(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i264);//6
			var i266 = new symbol_144();
			addChild(i266);//7
			var i267 = new symbol_145(){x = -53.9 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i267);//8
			var i269 = new symbol_146(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i269);//9
			var i271 = new symbol_147(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i271);//10
			var i273 = new symbol_148(){x = -216.8 , scaleX = 1 , y = -149.6 , scaleY = 1 , rotation = -129};
			addChild(i273);//11
			var i275 = new symbol_149(){x = 147.4 , scaleX = 1 , y = -173.8 , scaleY = 1 , rotation = -41};
			addChild(i275);//12
			var i277 = new symbol_150(){x = 172.2 , scaleX = 1 , y = -126.3 , scaleY = 1 , rotation = 25};
			addChild(i277);//13
			var i279 = new symbol_151(){x = -61.3 , scaleX = 1 , y = -190.1 , scaleY = 1 , rotation = -61};
			addChild(i279);//14
			var i281 = new symbol_152(){x = 73.3 , scaleX = 1 , y = -207.3 , scaleY = 1 , rotation = 152};
			addChild(i281);//15
			var i283 = new symbol_153(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i283);//16
			var i285 = new symbol_154(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i285);//17
			var i287 = new symbol_155(){x = -218.3 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = -65};
			addChild(i287);//18
			var i289 = new symbol_156(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i289);//19
			var i291 = new symbol_157(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i291);//20
			var i293 = new symbol_158(){x = -62 , scaleX = 1 , y = -209.3 , scaleY = 1 , rotation = 10};
			addChild(i293);//21
			var i295 = new symbol_159(){x = 156.5 , scaleX = 1 , y = -169.8 , scaleY = 1 , rotation = 108};
			addChild(i295);//22
			var i297 = new symbol_160(){x = 147.8 , scaleX = 1 , y = -157.2 , scaleY = 1 , rotation = 143};
			addChild(i297);//23
			var i299 = new symbol_161(){x = 171.1 , scaleX = 1 , y = -136.4 , scaleY = 1 , rotation = 101};
			addChild(i299);//24
		}
	}
	public class symbol_163 : MovieClip{ 
		public symbol_163() {
			var i301 = new symbol_33();
			addChild(i301);//0
		}
	}
	public class symbol_164 : Shape{ 
		public symbol_164() {
			setGraphics("cb7560d91f21c6f82438b8c8f580a289", 99.6, -120.75, 74.65, 66.15, 1, 1);
		}
	}
	public class symbol_165 : MovieClip{ 
		public symbol_165() {
			var i306 = new symbol_115();
			addChild(i306);//0
		}
	}
	public class symbol_166 : Shape{ 
		public symbol_166() {
			setGraphics("3221b854774604fb8b146e45dcac7b7c", -27.1, -306.15, 175.1, 306.79999999999995, 1, 1);
		}
	}
	public class symbol_167 : MovieClip{ 
		public symbol_167() {
			var i309 = new symbol_115();
			addChild(i309);//0
		}
	}
	public class symbol_168 : Shape{ 
		public symbol_168() {
			setGraphics("218181e8df25d6c64d91af14d55ca42e", -96, -168.65, 269.65, 106.05000000000001, 1, 1);
		}
	}
	public class symbol_169 : MovieClip{ 
		public symbol_169() {
			var i312 = new symbol_115();
			addChild(i312);//0
		}
	}
	public class symbol_17 : Shape{ 
		public symbol_17() {
			setGraphics("8234baf7c7522f9eaf95c0a9b13f3aec", -27.05, -31.5, 48.55, 31.5, 1, 1);
		}
	}
	public class symbol_170 : MovieClip{ 
		public symbol_170() {
			var i314 = new symbol_115();
			addChild(i314);//0
		}
	}
	public class symbol_171 : MovieClip{ 
		public symbol_171() {
			var i317 = new symbol_115();
			addChild(i317);//0
		}
	}
	public class symbol_172 : MovieClip{ 
		public symbol_172() {
			var i319 = new symbol_132();
			addChild(i319);//0
		}
	}
	public class symbol_173 : MovieClip{ 
		public symbol_173() {
			var i321 = new symbol_132();
			addChild(i321);//0
		}
	}
	public class symbol_174 : MovieClip{ 
		public symbol_174() {
			var i323 = new symbol_115();
			addChild(i323);//0
		}
	}
	public class symbol_175 : MovieClip{ 
		public symbol_175() {
			var i325 = new symbol_115();
			addChild(i325);//0
		}
	}
	public class symbol_176 : MovieClip{ 
		public symbol_176() {
			var i327 = new symbol_115();
			addChild(i327);//0
		}
	}
	public class symbol_177 : MovieClip{ 
		public symbol_177() {
			var i329 = new symbol_132();
			addChild(i329);//0
		}
	}
	public class symbol_178 : MovieClip{ 
		public symbol_178() {
			var i331 = new symbol_132();
			addChild(i331);//0
		}
	}
	public class symbol_179 : MovieClip{ 
		public symbol_179() {
			var i333 = new symbol_132();
			addChild(i333);//0
		}
	}
	public class symbol_18 : MovieClip{ 
		public symbol_18() {
			var i76 = new symbol_17();
			addChild(i76);//0
		}
	}
	public class symbol_180 : MovieClip{ 
		public symbol_180() {
			var i335 = new symbol_132();
			addChild(i335);//0
		}
	}
	public class symbol_181 : MovieClip{ 
		public symbol_181() {
			var i337 = new symbol_132();
			addChild(i337);//0
		}
	}
	public class symbol_182 : MovieClip{ 
		public symbol_182() {
			var i339 = new symbol_115();
			addChild(i339);//0
		}
	}
	public class symbol_183 : MovieClip{ 
		public symbol_183() {
			var i341 = new symbol_132();
			addChild(i341);//0
		}
	}
	public class symbol_184 : MovieClip{ 
		public symbol_184() {
			var i343 = new symbol_132();
			addChild(i343);//0
		}
	}
	public class symbol_185 : MovieClip{ 
		public symbol_185() {
			var i345 = new symbol_132();
			addChild(i345);//0
		}
	}
	public class symbol_186 : MovieClip{ 
		public symbol_186() {
			var i347 = new symbol_132();
			addChild(i347);//0
		}
	}
	public class symbol_187 : MovieClip{ 
		public symbol_187() {
			var i349 = new symbol_132();
			addChild(i349);//0
		}
	}
	public class symbol_188 : MovieClip{ 
		public symbol_188() {
			var i351 = new symbol_132();
			addChild(i351);//0
		}
	}
	public class symbol_189 : MovieClip{ 
		public symbol_189() {
			var i353 = new symbol_115();
			addChild(i353);//0
		}
	}
	public class symbol_19 : Shape{ 
		public symbol_19() {
			setGraphics("79d7afa363f09fdf376da60532e7ca0b", -11.05, -96.65, 25.6, 97.25, 1, 1);
		}
	}
	public class symbol_190 : MovieClip{ 
		public symbol_190() {
			var i355 = new symbol_132();
			addChild(i355);//0
		}
	}
	public class symbol_191 : MovieClip{ 
		public symbol_191() {
			var i357 = new symbol_132();
			addChild(i357);//0
		}
	}
	public class symbol_192 : MovieClip{ 
		public symbol_192() {
			var i304 = new symbol_137();
			addChild(i304);//0
			var i305 = new symbol_165(){x = 18.8 , scaleX = 1 , y = -205.1 , scaleY = 1 , rotation = -26};
			addChild(i305);//1
			var i307 = new symbol_166();
			addChild(i307);//2
			var i308 = new symbol_167(){x = 86.2 , scaleX = 1 , y = -118.3 , scaleY = 1 , rotation = 32};
			addChild(i308);//3
			var i310 = new symbol_168();
			addChild(i310);//4
			var i311 = new symbol_169(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i311);//5
			var i313 = new symbol_170(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i313);//6
			var i315 = new symbol_144();
			addChild(i315);//7
			var i316 = new symbol_171(){x = -53.9 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i316);//8
			var i318 = new symbol_172(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i318);//9
			var i320 = new symbol_173(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i320);//10
			var i322 = new symbol_174(){x = -216.8 , scaleX = 1 , y = -149.6 , scaleY = 1 , rotation = -129};
			addChild(i322);//11
			var i324 = new symbol_175(){x = 147.4 , scaleX = 1 , y = -173.8 , scaleY = 1 , rotation = -41};
			addChild(i324);//12
			var i326 = new symbol_176(){x = 172.2 , scaleX = 1 , y = -126.3 , scaleY = 1 , rotation = 25};
			addChild(i326);//13
			var i328 = new symbol_177(){x = -61.3 , scaleX = 1 , y = -190.1 , scaleY = 1 , rotation = -61};
			addChild(i328);//14
			var i330 = new symbol_178(){x = 73.3 , scaleX = 1 , y = -207.3 , scaleY = 1 , rotation = 152};
			addChild(i330);//15
			var i332 = new symbol_179(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i332);//16
			var i334 = new symbol_180(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i334);//17
			var i336 = new symbol_181(){x = -218.3 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = -65};
			addChild(i336);//18
			var i338 = new symbol_182(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i338);//19
			var i340 = new symbol_183(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i340);//20
			var i342 = new symbol_184(){x = -62 , scaleX = 1 , y = -209.3 , scaleY = 1 , rotation = 10};
			addChild(i342);//21
			var i344 = new symbol_185(){x = 156.5 , scaleX = 1 , y = -169.8 , scaleY = 1 , rotation = 108};
			addChild(i344);//22
			var i346 = new symbol_186(){x = 147.8 , scaleX = 1 , y = -157.2 , scaleY = 1 , rotation = 143};
			addChild(i346);//23
			var i348 = new symbol_187(){x = 171.1 , scaleX = 1 , y = -136.4 , scaleY = 1 , rotation = 101};
			addChild(i348);//24
			var i350 = new symbol_188(){x = 117.3 , scaleX = 1 , y = -282.7 , scaleY = 1 , rotation = 151};
			addChild(i350);//25
			var i352 = new symbol_189(){x = 90.5 , scaleX = 1 , y = -312.6 , scaleY = 1 , rotation = -71};
			addChild(i352);//26
			var i354 = new symbol_190(){x = 101 , scaleX = 1 , y = -304.8 , scaleY = 1 , rotation = 108};
			addChild(i354);//27
			var i356 = new symbol_191(){x = 76.9 , scaleX = 1 , y = -296.9 , scaleY = 1 , rotation = 21};
			addChild(i356);//28
		}
	}
	public class symbol_193 : MovieClip{ 
		public symbol_193() {
			var i358 = new symbol_33();
			addChild(i358);//0
		}
	}
	public class symbol_194 : Shape{ 
		public symbol_194() {
			setGraphics("07661f924e21258c36c23b1886006e02", 278.85, -139.25, 93.89999999999998, 84.7, 1, 1);
		}
	}
	public class symbol_195 : Shape{ 
		public symbol_195() {
			setGraphics("ddc5bb4d09ae5f95bf253a10b5cbd98a", 65.5, -127.75, 82.5, 55.5, 1, 1);
		}
	}
	public class symbol_196 : MovieClip{ 
		public symbol_196() {
			var i363 = new symbol_115();
			addChild(i363);//0
		}
	}
	public class symbol_197 : Shape{ 
		public symbol_197() {
			setGraphics("371cf9ed5016058b8ea8cd8f73c1f1b7", -117.4, -231.1, 119.85000000000001, 64.85, 1, 1);
		}
	}
	public class symbol_198 : MovieClip{ 
		public symbol_198() {
			var i366 = new symbol_132();
			addChild(i366);//0
		}
	}
	public class symbol_199 : MovieClip{ 
		public symbol_199() {
			var i368 = new symbol_132();
			addChild(i368);//0
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("fe32c2515491ef0c2be468db2268e7be", -13, -16.5, 26, 33, 1, 1);
		}
	}
	public class symbol_20 : Shape{ 
		public symbol_20() {
			setGraphics("f203455479802ba0fc39d4f5eed646a1", -8.65, -10.25, 17.3, 20.5, 1, 1);
		}
	}
	public class symbol_200 : Shape{ 
		public symbol_200() {
			setGraphics("9c322d138ddf3121b8efde9e0b072f90", -27.1, -302.9, 211.29999999999998, 303.54999999999995, 1, 1);
		}
	}
	public class symbol_201 : MovieClip{ 
		public symbol_201() {
			var i371 = new symbol_115();
			addChild(i371);//0
		}
	}
	public class symbol_202 : Shape{ 
		public symbol_202() {
			setGraphics("f197effb4f17e0671d613d912d7a1a41", -96, -168.65, 269.65, 106.05000000000001, 1, 1);
		}
	}
	public class symbol_203 : MovieClip{ 
		public symbol_203() {
			var i374 = new symbol_115();
			addChild(i374);//0
		}
	}
	public class symbol_204 : MovieClip{ 
		public symbol_204() {
			var i376 = new symbol_115();
			addChild(i376);//0
		}
	}
	public class symbol_205 : MovieClip{ 
		public symbol_205() {
			var i379 = new symbol_132();
			addChild(i379);//0
		}
	}
	public class symbol_206 : MovieClip{ 
		public symbol_206() {
			var i381 = new symbol_132();
			addChild(i381);//0
		}
	}
	public class symbol_207 : MovieClip{ 
		public symbol_207() {
			var i383 = new symbol_115();
			addChild(i383);//0
		}
	}
	public class symbol_208 : MovieClip{ 
		public symbol_208() {
			var i385 = new symbol_115();
			addChild(i385);//0
		}
	}
	public class symbol_209 : MovieClip{ 
		public symbol_209() {
			var i387 = new symbol_115();
			addChild(i387);//0
		}
	}
	public class symbol_21 : MovieClip{ 
		public symbol_21() {
			var i80 = new symbol_20();
			addChild(i80);//0
		}
	}
	public class symbol_210 : MovieClip{ 
		public symbol_210() {
			var i389 = new symbol_132();
			addChild(i389);//0
		}
	}
	public class symbol_211 : MovieClip{ 
		public symbol_211() {
			var i391 = new symbol_132();
			addChild(i391);//0
		}
	}
	public class symbol_212 : MovieClip{ 
		public symbol_212() {
			var i393 = new symbol_132();
			addChild(i393);//0
		}
	}
	public class symbol_213 : MovieClip{ 
		public symbol_213() {
			var i395 = new symbol_132();
			addChild(i395);//0
		}
	}
	public class symbol_214 : MovieClip{ 
		public symbol_214() {
			var i397 = new symbol_115();
			addChild(i397);//0
		}
	}
	public class symbol_215 : MovieClip{ 
		public symbol_215() {
			var i399 = new symbol_132();
			addChild(i399);//0
		}
	}
	public class symbol_216 : MovieClip{ 
		public symbol_216() {
			var i401 = new symbol_132();
			addChild(i401);//0
		}
	}
	public class symbol_217 : MovieClip{ 
		public symbol_217() {
			var i403 = new symbol_132();
			addChild(i403);//0
		}
	}
	public class symbol_218 : MovieClip{ 
		public symbol_218() {
			var i405 = new symbol_132();
			addChild(i405);//0
		}
	}
	public class symbol_219 : MovieClip{ 
		public symbol_219() {
			var i407 = new symbol_132();
			addChild(i407);//0
		}
	}
	public class symbol_22 : MovieClip{ 
		public symbol_22() {
			var i82 = new symbol_20();
			addChild(i82);//0
		}
	}
	public class symbol_220 : MovieClip{ 
		public symbol_220() {
			var i409 = new symbol_115();
			addChild(i409);//0
		}
	}
	public class symbol_221 : MovieClip{ 
		public symbol_221() {
			var i411 = new symbol_132();
			addChild(i411);//0
		}
	}
	public class symbol_222 : MovieClip{ 
		public symbol_222() {
			var i413 = new symbol_132();
			addChild(i413);//0
		}
	}
	public class symbol_223 : MovieClip{ 
		public symbol_223() {
			var i415 = new symbol_132();
			addChild(i415);//0
		}
	}
	public class symbol_224 : MovieClip{ 
		public symbol_224() {
			var i417 = new symbol_132();
			addChild(i417);//0
		}
	}
	public class symbol_225 : MovieClip{ 
		public symbol_225() {
			var i419 = new symbol_132();
			addChild(i419);//0
		}
	}
	public class symbol_226 : MovieClip{ 
		public symbol_226() {
			var i361 = new symbol_195();
			addChild(i361);//0
			var i362 = new symbol_196(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i362);//1
			var i364 = new symbol_197();
			addChild(i364);//2
			var i365 = new symbol_198(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i365);//3
			var i367 = new symbol_199(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i367);//4
			var i369 = new symbol_200();
			addChild(i369);//5
			var i370 = new symbol_201(){x = 86.2 , scaleX = 1 , y = -118.3 , scaleY = 1 , rotation = 32};
			addChild(i370);//6
			var i372 = new symbol_202();
			addChild(i372);//7
			var i373 = new symbol_203(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i373);//8
			var i375 = new symbol_204(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i375);//9
			var i377 = new symbol_144();
			addChild(i377);//10
			var i378 = new symbol_205(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i378);//11
			var i380 = new symbol_206(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i380);//12
			var i382 = new symbol_207(){x = -216.8 , scaleX = 1 , y = -149.6 , scaleY = 1 , rotation = -129};
			addChild(i382);//13
			var i384 = new symbol_208(){x = 147.4 , scaleX = 1 , y = -173.8 , scaleY = 1 , rotation = -41};
			addChild(i384);//14
			var i386 = new symbol_209(){x = 172.2 , scaleX = 1 , y = -126.3 , scaleY = 1 , rotation = 25};
			addChild(i386);//15
			var i388 = new symbol_210(){x = 178.3 , scaleX = 1 , y = -195.3 , scaleY = 1 , rotation = 152};
			addChild(i388);//16
			var i390 = new symbol_211(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i390);//17
			var i392 = new symbol_212(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i392);//18
			var i394 = new symbol_213(){x = -218.3 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = -65};
			addChild(i394);//19
			var i396 = new symbol_214(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i396);//20
			var i398 = new symbol_215(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i398);//21
			var i400 = new symbol_216(){x = 156.5 , scaleX = 1 , y = -169.8 , scaleY = 1 , rotation = 108};
			addChild(i400);//22
			var i402 = new symbol_217(){x = 147.8 , scaleX = 1 , y = -157.2 , scaleY = 1 , rotation = 143};
			addChild(i402);//23
			var i404 = new symbol_218(){x = 171.1 , scaleX = 1 , y = -136.4 , scaleY = 1 , rotation = 101};
			addChild(i404);//24
			var i406 = new symbol_219(){x = 126.5 , scaleX = 1 , y = -280.7 , scaleY = 1 , rotation = 151};
			addChild(i406);//25
			var i408 = new symbol_220(){x = 96.5 , scaleX = 1 , y = -309.4 , scaleY = 1 , rotation = -71};
			addChild(i408);//26
			var i410 = new symbol_221(){x = 107.5 , scaleX = 1 , y = -302.8 , scaleY = 1 , rotation = 108};
			addChild(i410);//27
			var i412 = new symbol_222(){x = 79.9 , scaleX = 1 , y = -288.1 , scaleY = 1 , rotation = 21};
			addChild(i412);//28
			var i414 = new symbol_223(){x = 190.4 , scaleX = 1 , y = -218.9 , scaleY = 1 , rotation = 102};
			addChild(i414);//29
			var i416 = new symbol_224(){x = 153.7 , scaleX = 1 , y = -264.8 , scaleY = 1 , rotation = 150};
			addChild(i416);//30
			var i418 = new symbol_225(){x = 160.7 , scaleX = 1 , y = -281.9 , scaleY = 1 , rotation = 93};
			addChild(i418);//31
		}
	}
	public class symbol_227 : MovieClip{ 
		public symbol_227() {
			var i420 = new symbol_33();
			addChild(i420);//0
		}
	}
	public class symbol_228 : Shape{ 
		public symbol_228() {
			setGraphics("74292e544b093f572184be05c670bef5", 278.85, -138.45, 93.89999999999998, 83.89999999999999, 1, 1);
		}
	}
	public class symbol_229 : MovieClip{ 
		public symbol_229() {
			var i425 = new symbol_115();
			addChild(i425);//0
		}
	}
	public class symbol_23 : MovieClip{ 
		public symbol_23() {
			var i78 = new symbol_19();
			addChild(i78);//0
			var i79 = new symbol_21(){y = -83.4 , x = 1.6};
			addChild(i79);//1
			var i81 = new symbol_22(){x = 21.7 , scaleX = 1 , y = -98.8 , scaleY = 1 , rotation = 83};
			addChild(i81);//2
		}
	}
	public class symbol_230 : MovieClip{ 
		public symbol_230() {
			var i427 = new symbol_115();
			addChild(i427);//0
		}
	}
	public class symbol_231 : MovieClip{ 
		public symbol_231() {
			var i429 = new symbol_115();
			addChild(i429);//0
		}
	}
	public class symbol_232 : Shape{ 
		public symbol_232() {
			setGraphics("90b75091d4b5a052b3762e3f2539834f", -117.4, -280.55, 270.9, 281.2, 1, 1);
		}
	}
	public class symbol_233 : MovieClip{ 
		public symbol_233() {
			var i432 = new symbol_115();
			addChild(i432);//0
		}
	}
	public class symbol_234 : Shape{ 
		public symbol_234() {
			setGraphics("86546797e6f23a64410034e57a54da03", -267.25, -302.9, 515.1, 381.34999999999997, 1, 1);
		}
	}
	public class symbol_235 : MovieClip{ 
		public symbol_235() {
			var i435 = new symbol_132();
			addChild(i435);//0
		}
	}
	public class symbol_236 : MovieClip{ 
		public symbol_236() {
			var i437 = new symbol_132();
			addChild(i437);//0
		}
	}
	public class symbol_237 : MovieClip{ 
		public symbol_237() {
			var i439 = new symbol_132();
			addChild(i439);//0
		}
	}
	public class symbol_238 : MovieClip{ 
		public symbol_238() {
			var i441 = new symbol_132();
			addChild(i441);//0
		}
	}
	public class symbol_239 : MovieClip{ 
		public symbol_239() {
			var i443 = new symbol_115();
			addChild(i443);//0
		}
	}
	public class symbol_24 : Shape{ 
		public symbol_24() {
			setGraphics("10b5d9e6e9e85d99c248ffd6294733f1", 296.6, -89.25, 55.94999999999999, 32.4, 1, 1);
		}
	}
	public class symbol_240 : MovieClip{ 
		public symbol_240() {
			var i445 = new symbol_115();
			addChild(i445);//0
		}
	}
	public class symbol_241 : MovieClip{ 
		public symbol_241() {
			var i447 = new symbol_115();
			addChild(i447);//0
		}
	}
	public class symbol_242 : MovieClip{ 
		public symbol_242() {
			var i449 = new symbol_132();
			addChild(i449);//0
		}
	}
	public class symbol_243 : MovieClip{ 
		public symbol_243() {
			var i451 = new symbol_132();
			addChild(i451);//0
		}
	}
	public class symbol_244 : MovieClip{ 
		public symbol_244() {
			var i453 = new symbol_132();
			addChild(i453);//0
		}
	}
	public class symbol_245 : MovieClip{ 
		public symbol_245() {
			var i455 = new symbol_132();
			addChild(i455);//0
		}
	}
	public class symbol_246 : MovieClip{ 
		public symbol_246() {
			var i457 = new symbol_115();
			addChild(i457);//0
		}
	}
	public class symbol_247 : MovieClip{ 
		public symbol_247() {
			var i459 = new symbol_132();
			addChild(i459);//0
		}
	}
	public class symbol_248 : MovieClip{ 
		public symbol_248() {
			var i461 = new symbol_132();
			addChild(i461);//0
		}
	}
	public class symbol_249 : MovieClip{ 
		public symbol_249() {
			var i463 = new symbol_132();
			addChild(i463);//0
		}
	}
	public class symbol_25 : Shape{ 
		public symbol_25() {
			setGraphics("5c2282542f86099881853afacd431545", -10.35, -6.1, 20.75, 12.25, 1, 1);
		}
	}
	public class symbol_250 : MovieClip{ 
		public symbol_250() {
			var i465 = new symbol_132();
			addChild(i465);//0
		}
	}
	public class symbol_251 : MovieClip{ 
		public symbol_251() {
			var i467 = new symbol_132();
			addChild(i467);//0
		}
	}
	public class symbol_252 : MovieClip{ 
		public symbol_252() {
			var i469 = new symbol_115();
			addChild(i469);//0
		}
	}
	public class symbol_253 : MovieClip{ 
		public symbol_253() {
			var i471 = new symbol_132();
			addChild(i471);//0
		}
	}
	public class symbol_254 : MovieClip{ 
		public symbol_254() {
			var i473 = new symbol_132();
			addChild(i473);//0
		}
	}
	public class symbol_255 : MovieClip{ 
		public symbol_255() {
			var i475 = new symbol_132();
			addChild(i475);//0
		}
	}
	public class symbol_256 : MovieClip{ 
		public symbol_256() {
			var i477 = new symbol_132();
			addChild(i477);//0
		}
	}
	public class symbol_257 : MovieClip{ 
		public symbol_257() {
			var i479 = new symbol_132();
			addChild(i479);//0
		}
	}
	public class symbol_258 : MovieClip{ 
		public symbol_258() {
			var i423 = new symbol_58();
			addChild(i423);//0
			var i424 = new symbol_229(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i424);//1
			var i426 = new symbol_230(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i426);//2
			var i428 = new symbol_231(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i428);//3
			var i430 = new symbol_232();
			addChild(i430);//4
			var i431 = new symbol_233(){x = 92.2 , scaleX = 1 , y = -125.8 , scaleY = 1 , rotation = 32};
			addChild(i431);//5
			var i433 = new symbol_234();
			addChild(i433);//6
			var i434 = new symbol_235(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i434);//7
			var i436 = new symbol_236(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i436);//8
			var i438 = new symbol_237(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i438);//9
			var i440 = new symbol_238(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i440);//10
			var i442 = new symbol_239(){x = -271.3 , scaleX = 1 , y = -149.1 , scaleY = 1 , rotation = -129};
			addChild(i442);//11
			var i444 = new symbol_240(){x = 144.9 , scaleX = 1 , y = -178.3 , scaleY = 1 , rotation = -41};
			addChild(i444);//12
			var i446 = new symbol_241(){x = 249.7 , scaleX = 1 , y = -154.8 , scaleY = 1 , rotation = 25};
			addChild(i446);//13
			var i448 = new symbol_242(){x = 180.3 , scaleX = 1 , y = -196.3 , scaleY = 1 , rotation = 152};
			addChild(i448);//14
			var i450 = new symbol_243(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i450);//15
			var i452 = new symbol_244(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i452);//16
			var i454 = new symbol_245(){x = -274.9 , scaleX = 1 , y = -137.2 , scaleY = 1 , rotation = -65};
			addChild(i454);//17
			var i456 = new symbol_246(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i456);//18
			var i458 = new symbol_247(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i458);//19
			var i460 = new symbol_248(){x = 164 , scaleX = 1 , y = -175.3 , scaleY = 1 , rotation = 108};
			addChild(i460);//20
			var i462 = new symbol_249(){x = 159.8 , scaleX = 1 , y = -165.2 , scaleY = 1 , rotation = 143};
			addChild(i462);//21
			var i464 = new symbol_250(){x = 242.6 , scaleX = 1 , y = -165.4 , scaleY = 1 , rotation = 101};
			addChild(i464);//22
			var i466 = new symbol_251(){x = 126.5 , scaleX = 1 , y = -280.7 , scaleY = 1 , rotation = 151};
			addChild(i466);//23
			var i468 = new symbol_252(){x = 96.5 , scaleX = 1 , y = -309.4 , scaleY = 1 , rotation = -71};
			addChild(i468);//24
			var i470 = new symbol_253(){x = 107.5 , scaleX = 1 , y = -302.8 , scaleY = 1 , rotation = 108};
			addChild(i470);//25
			var i472 = new symbol_254(){x = 79.9 , scaleX = 1 , y = -288.1 , scaleY = 1 , rotation = 21};
			addChild(i472);//26
			var i474 = new symbol_255(){x = 191.4 , scaleX = 1 , y = -218.9 , scaleY = 1 , rotation = 102};
			addChild(i474);//27
			var i476 = new symbol_256(){x = 153.7 , scaleX = 1 , y = -264.8 , scaleY = 1 , rotation = 150};
			addChild(i476);//28
			var i478 = new symbol_257(){x = 160.7 , scaleX = 1 , y = -281.9 , scaleY = 1 , rotation = 93};
			addChild(i478);//29
		}
	}
	public class symbol_259 : MovieClip{ 
		public symbol_259() {
			var i480 = new symbol_33();
			addChild(i480);//0
		}
	}
	public class symbol_26 : MovieClip{ 
		public symbol_26() {
			var i86 = new symbol_25();
			addChild(i86);//0
		}
	}
	public class symbol_260 : MovieClip{ 
		public symbol_260() {
			var i483 = new symbol_115();
			addChild(i483);//0
		}
	}
	public class symbol_261 : MovieClip{ 
		public symbol_261() {
			var i485 = new symbol_115();
			addChild(i485);//0
		}
	}
	public class symbol_262 : MovieClip{ 
		public symbol_262() {
			var i487 = new symbol_115();
			addChild(i487);//0
		}
	}
	public class symbol_263 : MovieClip{ 
		public symbol_263() {
			var i489 = new symbol_115();
			addChild(i489);//0
		}
	}
	public class symbol_264 : Shape{ 
		public symbol_264() {
			setGraphics("3022472f7e25f898a0b55d4778346593", -117.4, -231.1, 270.9, 309.55, 1, 1);
		}
	}
	public class symbol_265 : MovieClip{ 
		public symbol_265() {
			var i492 = new symbol_115();
			addChild(i492);//0
		}
	}
	public class symbol_266 : Shape{ 
		public symbol_266() {
			setGraphics("05238f6f91ca1487d21d588e43b713af", -267.25, -356.25, 516.6, 356.3, 1, 1);
		}
	}
	public class symbol_267 : MovieClip{ 
		public symbol_267() {
			var i495 = new symbol_132();
			addChild(i495);//0
		}
	}
	public class symbol_268 : MovieClip{ 
		public symbol_268() {
			var i497 = new symbol_132();
			addChild(i497);//0
		}
	}
	public class symbol_269 : MovieClip{ 
		public symbol_269() {
			var i499 = new symbol_132();
			addChild(i499);//0
		}
	}
	public class symbol_27 : Shape{ 
		public symbol_27() {
			setGraphics("c14fc32ec2f34798f2114244d5e86b5b", -17.25, -149.75, 75.75, 150.25, 1, 1);
		}
	}
	public class symbol_270 : MovieClip{ 
		public symbol_270() {
			var i501 = new symbol_132();
			addChild(i501);//0
		}
	}
	public class symbol_271 : MovieClip{ 
		public symbol_271() {
			var i503 = new symbol_115();
			addChild(i503);//0
		}
	}
	public class symbol_272 : MovieClip{ 
		public symbol_272() {
			var i505 = new symbol_115();
			addChild(i505);//0
		}
	}
	public class symbol_273 : MovieClip{ 
		public symbol_273() {
			var i507 = new symbol_115();
			addChild(i507);//0
		}
	}
	public class symbol_274 : MovieClip{ 
		public symbol_274() {
			var i509 = new symbol_132();
			addChild(i509);//0
		}
	}
	public class symbol_275 : MovieClip{ 
		public symbol_275() {
			var i511 = new symbol_132();
			addChild(i511);//0
		}
	}
	public class symbol_276 : MovieClip{ 
		public symbol_276() {
			var i513 = new symbol_132();
			addChild(i513);//0
		}
	}
	public class symbol_277 : MovieClip{ 
		public symbol_277() {
			var i515 = new symbol_132();
			addChild(i515);//0
		}
	}
	public class symbol_278 : MovieClip{ 
		public symbol_278() {
			var i517 = new symbol_115();
			addChild(i517);//0
		}
	}
	public class symbol_279 : MovieClip{ 
		public symbol_279() {
			var i519 = new symbol_132();
			addChild(i519);//0
		}
	}
	public class symbol_28 : MovieClip{ 
		public symbol_28() {
			var i89 = new symbol_20();
			addChild(i89);//0
		}
	}
	public class symbol_280 : MovieClip{ 
		public symbol_280() {
			var i521 = new symbol_132();
			addChild(i521);//0
		}
	}
	public class symbol_281 : MovieClip{ 
		public symbol_281() {
			var i523 = new symbol_132();
			addChild(i523);//0
		}
	}
	public class symbol_282 : MovieClip{ 
		public symbol_282() {
			var i525 = new symbol_132();
			addChild(i525);//0
		}
	}
	public class symbol_283 : MovieClip{ 
		public symbol_283() {
			var i527 = new symbol_132();
			addChild(i527);//0
		}
	}
	public class symbol_284 : MovieClip{ 
		public symbol_284() {
			var i529 = new symbol_115();
			addChild(i529);//0
		}
	}
	public class symbol_285 : MovieClip{ 
		public symbol_285() {
			var i531 = new symbol_132();
			addChild(i531);//0
		}
	}
	public class symbol_286 : MovieClip{ 
		public symbol_286() {
			var i533 = new symbol_132();
			addChild(i533);//0
		}
	}
	public class symbol_287 : MovieClip{ 
		public symbol_287() {
			var i535 = new symbol_132();
			addChild(i535);//0
		}
	}
	public class symbol_288 : MovieClip{ 
		public symbol_288() {
			var i537 = new symbol_132();
			addChild(i537);//0
		}
	}
	public class symbol_289 : MovieClip{ 
		public symbol_289() {
			var i539 = new symbol_132();
			addChild(i539);//0
		}
	}
	public class symbol_29 : MovieClip{ 
		public symbol_29() {
			var i91 = new symbol_20();
			addChild(i91);//0
		}
	}
	public class symbol_290 : MovieClip{ 
		public symbol_290() {
			var i541 = new symbol_132();
			addChild(i541);//0
		}
	}
	public class symbol_291 : MovieClip{ 
		public symbol_291() {
			var i482 = new symbol_260(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i482);//0
			var i484 = new symbol_261(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i484);//1
			var i486 = new symbol_262(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i486);//2
			var i488 = new symbol_263(){x = 92.2 , scaleX = 1 , y = -125.8 , scaleY = 1 , rotation = 32};
			addChild(i488);//3
			var i490 = new symbol_264();
			addChild(i490);//4
			var i491 = new symbol_265(){x = -65.1 , scaleX = 1 , y = -299.1 , scaleY = 1 , rotation = -160};
			addChild(i491);//5
			var i493 = new symbol_266();
			addChild(i493);//6
			var i494 = new symbol_267(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i494);//7
			var i496 = new symbol_268(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i496);//8
			var i498 = new symbol_269(){x = 16.7 , scaleX = 0.79 , y = -361.9 , scaleY = 0.79 , rotation = 13};
			addChild(i498);//9
			var i500 = new symbol_270(){x = 27.9 , scaleX = 1 , y = -362.4 , scaleY = 1 , rotation = 53};
			addChild(i500);//10
			var i502 = new symbol_271(){x = -271.3 , scaleX = 1 , y = -149.1 , scaleY = 1 , rotation = -129};
			addChild(i502);//11
			var i504 = new symbol_272(){x = 144.9 , scaleX = 1 , y = -178.3 , scaleY = 1 , rotation = -41};
			addChild(i504);//12
			var i506 = new symbol_273(){x = 252.7 , scaleX = 1 , y = -154.8 , scaleY = 1 , rotation = 25};
			addChild(i506);//13
			var i508 = new symbol_274(){x = 180.3 , scaleX = 1 , y = -196.3 , scaleY = 1 , rotation = 152};
			addChild(i508);//14
			var i510 = new symbol_275(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i510);//15
			var i512 = new symbol_276(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i512);//16
			var i514 = new symbol_277(){x = -274.9 , scaleX = 1 , y = -137.2 , scaleY = 1 , rotation = -65};
			addChild(i514);//17
			var i516 = new symbol_278(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i516);//18
			var i518 = new symbol_279(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i518);//19
			var i520 = new symbol_280(){x = 164 , scaleX = 1 , y = -175.3 , scaleY = 1 , rotation = 108};
			addChild(i520);//20
			var i522 = new symbol_281(){x = 159.8 , scaleX = 1 , y = -165.2 , scaleY = 1 , rotation = 143};
			addChild(i522);//21
			var i524 = new symbol_282(){x = 245.6 , scaleX = 1 , y = -165.4 , scaleY = 1 , rotation = 101};
			addChild(i524);//22
			var i526 = new symbol_283(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i526);//23
			var i528 = new symbol_284(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i528);//24
			var i530 = new symbol_285(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i530);//25
			var i532 = new symbol_286(){x = 80.4 , scaleX = 1 , y = -292.1 , scaleY = 1 , rotation = 21};
			addChild(i532);//26
			var i534 = new symbol_287(){x = 191.4 , scaleX = 1 , y = -218.9 , scaleY = 1 , rotation = 102};
			addChild(i534);//27
			var i536 = new symbol_288(){x = 156.2 , scaleX = 1 , y = -263.8 , scaleY = 1 , rotation = 150};
			addChild(i536);//28
			var i538 = new symbol_289(){x = 163.2 , scaleX = 1 , y = -281.9 , scaleY = 1 , rotation = 93};
			addChild(i538);//29
			var i540 = new symbol_290(){x = -62.5 , scaleX = 1 , y = -310.6 , scaleY = 1 , rotation = 16};
			addChild(i540);//30
		}
	}
	public class symbol_292 : MovieClip{ 
		public symbol_292() {
			var i542 = new symbol_33();
			addChild(i542);//0
		}
	}
	public class symbol_293 : Shape{ 
		public symbol_293() {
			setGraphics("5408df054b66a2af81ab9663cd25e5dc", 88.85, -138.45, 93.9, 83.89999999999999, 1, 1);
		}
	}
	public class symbol_294 : Shape{ 
		public symbol_294() {
			setGraphics("916bb4d853e145cf361f88c86838850f", -19.65, -127.75, 167.65, 60.099999999999994, 1, 1);
		}
	}
	public class symbol_295 : MovieClip{ 
		public symbol_295() {
			var i547 = new symbol_115();
			addChild(i547);//0
		}
	}
	public class symbol_296 : MovieClip{ 
		public symbol_296() {
			var i549 = new symbol_115();
			addChild(i549);//0
		}
	}
	public class symbol_297 : MovieClip{ 
		public symbol_297() {
			var i551 = new symbol_115();
			addChild(i551);//0
		}
	}
	public class symbol_298 : Shape{ 
		public symbol_298() {
			setGraphics("5bdeda31f0a34797197acbc5c26b6d5f", -117.4, -231.1, 119.85000000000001, 113.8, 1, 1);
		}
	}
	public class symbol_299 : MovieClip{ 
		public symbol_299() {
			var i554 = new symbol_132();
			addChild(i554);//0
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("32d1215979a7aa7976dc3799d275c317", -14.95, -17.5, 30, 35, 1, 1);
		}
	}
	public class symbol_30 : MovieClip{ 
		public symbol_30() {
			var i93 = new symbol_20();
			addChild(i93);//0
		}
	}
	public class symbol_300 : MovieClip{ 
		public symbol_300() {
			var i556 = new symbol_132();
			addChild(i556);//0
		}
	}
	public class symbol_301 : Shape{ 
		public symbol_301() {
			setGraphics("416a92f79950b48d81c31cb14a1a4568", -138.7, -356.25, 277.45, 356.3, 1, 1);
		}
	}
	public class symbol_302 : MovieClip{ 
		public symbol_302() {
			var i559 = new symbol_132();
			addChild(i559);//0
		}
	}
	public class symbol_303 : Shape{ 
		public symbol_303() {
			setGraphics("2c3b902d413c1a6f766ac2d228643dfa", -303.45, -284, 540.8, 208.5, 1, 1);
		}
	}
	public class symbol_304 : MovieClip{ 
		public symbol_304() {
			var i562 = new symbol_115();
			addChild(i562);//0
		}
	}
	public class symbol_305 : MovieClip{ 
		public symbol_305() {
			var i564 = new symbol_115();
			addChild(i564);//0
		}
	}
	public class symbol_306 : MovieClip{ 
		public symbol_306() {
			var i566 = new symbol_115();
			addChild(i566);//0
		}
	}
	public class symbol_307 : Shape{ 
		public symbol_307() {
			setGraphics("90b9b9ac41f604fbe69570bf1c6e13b6", -129.75, -214.7, 449.45, 299.79999999999995, 1, 1);
		}
	}
	public class symbol_308 : MovieClip{ 
		public symbol_308() {
			var i569 = new symbol_115();
			addChild(i569);//0
		}
	}
	public class symbol_309 : MovieClip{ 
		public symbol_309() {
			var i571 = new symbol_132();
			addChild(i571);//0
		}
	}
	public class symbol_31 : MovieClip{ 
		public symbol_31() {
			var i95 = new symbol_20();
			addChild(i95);//0
		}
	}
	public class symbol_310 : MovieClip{ 
		public symbol_310() {
			var i573 = new symbol_132();
			addChild(i573);//0
		}
	}
	public class symbol_311 : MovieClip{ 
		public symbol_311() {
			var i575 = new symbol_132();
			addChild(i575);//0
		}
	}
	public class symbol_312 : MovieClip{ 
		public symbol_312() {
			var i577 = new symbol_132();
			addChild(i577);//0
		}
	}
	public class symbol_313 : MovieClip{ 
		public symbol_313() {
			var i579 = new symbol_115();
			addChild(i579);//0
		}
	}
	public class symbol_314 : MovieClip{ 
		public symbol_314() {
			var i581 = new symbol_115();
			addChild(i581);//0
		}
	}
	public class symbol_315 : MovieClip{ 
		public symbol_315() {
			var i583 = new symbol_132();
			addChild(i583);//0
		}
	}
	public class symbol_316 : MovieClip{ 
		public symbol_316() {
			var i585 = new symbol_132();
			addChild(i585);//0
		}
	}
	public class symbol_317 : MovieClip{ 
		public symbol_317() {
			var i587 = new symbol_132();
			addChild(i587);//0
		}
	}
	public class symbol_318 : MovieClip{ 
		public symbol_318() {
			var i589 = new symbol_115();
			addChild(i589);//0
		}
	}
	public class symbol_319 : MovieClip{ 
		public symbol_319() {
			var i591 = new symbol_132();
			addChild(i591);//0
		}
	}
	public class symbol_32 : MovieClip{ 
		public symbol_32() {
			var i85 = new symbol_26(){x = 36.1 , scaleX = 1 , y = -88.8 , scaleY = 1 , rotation = 14};
			addChild(i85);//0
			var i87 = new symbol_27();
			addChild(i87);//1
			var i88 = new symbol_28(){y = -141.4 , x = 0.3};
			addChild(i88);//2
			var i90 = new symbol_29(){x = 19.8 , scaleX = 1 , y = -150.9 , scaleY = 1 , rotation = 85};
			addChild(i90);//3
			var i92 = new symbol_30(){x = 31.8 , scaleX = 1 , y = -105 , scaleY = 1 , rotation = 57};
			addChild(i92);//4
			var i94 = new symbol_31(){x = 64 , scaleX = 1 , y = -109.5 , scaleY = 1 , rotation = 118};
			addChild(i94);//5
		}
	}
	public class symbol_320 : MovieClip{ 
		public symbol_320() {
			var i593 = new symbol_132();
			addChild(i593);//0
		}
	}
	public class symbol_321 : MovieClip{ 
		public symbol_321() {
			var i595 = new symbol_132();
			addChild(i595);//0
		}
	}
	public class symbol_322 : MovieClip{ 
		public symbol_322() {
			var i597 = new symbol_132();
			addChild(i597);//0
		}
	}
	public class symbol_323 : MovieClip{ 
		public symbol_323() {
			var i599 = new symbol_132();
			addChild(i599);//0
		}
	}
	public class symbol_324 : MovieClip{ 
		public symbol_324() {
			var i601 = new symbol_115();
			addChild(i601);//0
		}
	}
	public class symbol_325 : MovieClip{ 
		public symbol_325() {
			var i603 = new symbol_132();
			addChild(i603);//0
		}
	}
	public class symbol_326 : MovieClip{ 
		public symbol_326() {
			var i605 = new symbol_132();
			addChild(i605);//0
		}
	}
	public class symbol_327 : MovieClip{ 
		public symbol_327() {
			var i607 = new symbol_132();
			addChild(i607);//0
		}
	}
	public class symbol_328 : MovieClip{ 
		public symbol_328() {
			var i609 = new symbol_132();
			addChild(i609);//0
		}
	}
	public class symbol_329 : MovieClip{ 
		public symbol_329() {
			var i611 = new symbol_115();
			addChild(i611);//0
		}
	}
	public class symbol_33 : Shape{ 
		public symbol_33() {
			setGraphics("718fc36546d7bd0315b3942f05325113", -20, -50.55, 40, 70.55, 1, 1);
		}
	}
	public class symbol_330 : MovieClip{ 
		public symbol_330() {
			var i613 = new symbol_132();
			addChild(i613);//0
		}
	}
	public class symbol_331 : MovieClip{ 
		public symbol_331() {
			var i615 = new symbol_132();
			addChild(i615);//0
		}
	}
	public class symbol_332 : MovieClip{ 
		public symbol_332() {
			var i617 = new symbol_132();
			addChild(i617);//0
		}
	}
	public class symbol_333 : MovieClip{ 
		public symbol_333() {
			var i619 = new symbol_115();
			addChild(i619);//0
		}
	}
	public class symbol_334 : MovieClip{ 
		public symbol_334() {
			var i621 = new symbol_132();
			addChild(i621);//0
		}
	}
	public class symbol_335 : Shape{ 
		public symbol_335() {
			setGraphics("bc784efe6ae91b70599c6b66e96724ae", -15.5, -201.6, 42.3, 74.1, 1, 1);
		}
	}
	public class symbol_336 : MovieClip{ 
		public symbol_336() {
			var i545 = new symbol_294();
			addChild(i545);//0
			var i546 = new symbol_295(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i546);//1
			var i548 = new symbol_296(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i548);//2
			var i550 = new symbol_297(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i550);//3
			var i552 = new symbol_298();
			addChild(i552);//4
			var i553 = new symbol_299(){x = -145.1 , scaleX = 1 , y = -280.2 , scaleY = 1 , rotation = 4};
			addChild(i553);//5
			var i555 = new symbol_300(){x = -147.3 , scaleX = 0.84 , y = -268.1 , scaleY = 0.84 , rotation = -34};
			addChild(i555);//6
			var i557 = new symbol_301();
			addChild(i557);//7
			var i558 = new symbol_302(){x = 212.6 , scaleX = 1 , y = -189.7 , scaleY = 1 , rotation = 131};
			addChild(i558);//8
			var i560 = new symbol_303();
			addChild(i560);//9
			var i561 = new symbol_304(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i561);//10
			var i563 = new symbol_305(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i563);//11
			var i565 = new symbol_306(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i565);//12
			var i567 = new symbol_307();
			addChild(i567);//13
			var i568 = new symbol_308(){x = -92.6 , scaleX = 1 , y = -339.9 , scaleY = 1 , rotation = -160};
			addChild(i568);//14
			var i570 = new symbol_309(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i570);//15
			var i572 = new symbol_310(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i572);//16
			var i574 = new symbol_311(){x = 16.7 , scaleX = 0.79 , y = -361.9 , scaleY = 0.79 , rotation = 13};
			addChild(i574);//17
			var i576 = new symbol_312(){x = 27.9 , scaleX = 1 , y = -362.4 , scaleY = 1 , rotation = 53};
			addChild(i576);//18
			var i578 = new symbol_313(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i578);//19
			var i580 = new symbol_314(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i580);//20
			var i582 = new symbol_315(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i582);//21
			var i584 = new symbol_316(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i584);//22
			var i586 = new symbol_317(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i586);//23
			var i588 = new symbol_318(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i588);//24
			var i590 = new symbol_319(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i590);//25
			var i592 = new symbol_320(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i592);//26
			var i594 = new symbol_321(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i594);//27
			var i596 = new symbol_322(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i596);//28
			var i598 = new symbol_323(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i598);//29
			var i600 = new symbol_324(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i600);//30
			var i602 = new symbol_325(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i602);//31
			var i604 = new symbol_326(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i604);//32
			var i606 = new symbol_327(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i606);//33
			var i608 = new symbol_328(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i608);//34
			var i610 = new symbol_329(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i610);//35
			var i612 = new symbol_330(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i612);//36
			var i614 = new symbol_331(){x = -85.7 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 16};
			addChild(i614);//37
			var i616 = new symbol_332(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i616);//38
			var i618 = new symbol_333(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i618);//39
			var i620 = new symbol_334(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i620);//40
			var i622 = new symbol_335();
			addChild(i622);//41
		}
	}
	public class symbol_337 : MovieClip{ 
		public symbol_337() {
			var i623 = new symbol_33();
			addChild(i623);//0
		}
	}
	public class symbol_338 : Shape{ 
		public symbol_338() {
			setGraphics("936551ace588d8e9742d139bbf5c323a", -62.85, -6.4, 109.1, 21.8, 1, 1);
		}
	}
	public class symbol_339 : MovieClip{ 
		public symbol_339() {
			var i625 = new symbol_338();
			addChild(i625);//0
		}
	}
	public class symbol_34 : MovieClip{ 
		public symbol_34() {
			var i96 = new symbol_33();
			addChild(i96);//0
		}
	}
	public class symbol_340 : Shape{ 
		public symbol_340() {
			setGraphics("cabdcff6ff798c3fec7e788f5a251291", 278.85, -138.45, 93.89999999999998, 83.89999999999999, 1, 1);
		}
	}
	public class symbol_341 : MovieClip{ 
		public symbol_341() {
			var i630 = new symbol_115();
			addChild(i630);//0
		}
	}
	public class symbol_342 : MovieClip{ 
		public symbol_342() {
			var i632 = new symbol_115();
			addChild(i632);//0
		}
	}
	public class symbol_343 : MovieClip{ 
		public symbol_343() {
			var i634 = new symbol_115();
			addChild(i634);//0
		}
	}
	public class symbol_344 : MovieClip{ 
		public symbol_344() {
			var i637 = new symbol_132();
			addChild(i637);//0
		}
	}
	public class symbol_345 : MovieClip{ 
		public symbol_345() {
			var i639 = new symbol_132();
			addChild(i639);//0
		}
	}
	public class symbol_346 : Shape{ 
		public symbol_346() {
			setGraphics("05a5dfc9343b059c0f4a61ee033d8f57", -138.7, -420.7, 277.45, 420.75, 1, 1);
		}
	}
	public class symbol_347 : MovieClip{ 
		public symbol_347() {
			var i642 = new symbol_132();
			addChild(i642);//0
		}
	}
	public class symbol_348 : Shape{ 
		public symbol_348() {
			setGraphics("bd1881fd85593ae4b1f99a550fc2418e", -303.45, -284, 540.8, 208.5, 1, 1);
		}
	}
	public class symbol_349 : MovieClip{ 
		public symbol_349() {
			var i645 = new symbol_115();
			addChild(i645);//0
		}
	}
	public class symbol_35 : MovieClip{ 
		public symbol_35() {
			var i99 = new symbol_25();
			addChild(i99);//0
		}
	}
	public class symbol_350 : MovieClip{ 
		public symbol_350() {
			var i647 = new symbol_115();
			addChild(i647);//0
		}
	}
	public class symbol_351 : MovieClip{ 
		public symbol_351() {
			var i649 = new symbol_115();
			addChild(i649);//0
		}
	}
	public class symbol_352 : Shape{ 
		public symbol_352() {
			setGraphics("d5796d5ca7b3f90349bedb54a9609162", -129.75, -214.7, 449.45, 299.79999999999995, 1, 1);
		}
	}
	public class symbol_353 : MovieClip{ 
		public symbol_353() {
			var i652 = new symbol_115();
			addChild(i652);//0
		}
	}
	public class symbol_354 : MovieClip{ 
		public symbol_354() {
			var i654 = new symbol_132();
			addChild(i654);//0
		}
	}
	public class symbol_355 : MovieClip{ 
		public symbol_355() {
			var i656 = new symbol_132();
			addChild(i656);//0
		}
	}
	public class symbol_356 : MovieClip{ 
		public symbol_356() {
			var i658 = new symbol_132();
			addChild(i658);//0
		}
	}
	public class symbol_357 : MovieClip{ 
		public symbol_357() {
			var i660 = new symbol_132();
			addChild(i660);//0
		}
	}
	public class symbol_358 : MovieClip{ 
		public symbol_358() {
			var i662 = new symbol_115();
			addChild(i662);//0
		}
	}
	public class symbol_359 : MovieClip{ 
		public symbol_359() {
			var i664 = new symbol_115();
			addChild(i664);//0
		}
	}
	public class symbol_36 : Shape{ 
		public symbol_36() {
			setGraphics("1ff712109d1d01ce20ed7711b353e0f6", -48.55, -172.35, 152.5, 172.85, 1, 1);
		}
	}
	public class symbol_360 : MovieClip{ 
		public symbol_360() {
			var i666 = new symbol_132();
			addChild(i666);//0
		}
	}
	public class symbol_361 : MovieClip{ 
		public symbol_361() {
			var i668 = new symbol_132();
			addChild(i668);//0
		}
	}
	public class symbol_362 : MovieClip{ 
		public symbol_362() {
			var i670 = new symbol_132();
			addChild(i670);//0
		}
	}
	public class symbol_363 : MovieClip{ 
		public symbol_363() {
			var i672 = new symbol_115();
			addChild(i672);//0
		}
	}
	public class symbol_364 : MovieClip{ 
		public symbol_364() {
			var i674 = new symbol_132();
			addChild(i674);//0
		}
	}
	public class symbol_365 : MovieClip{ 
		public symbol_365() {
			var i676 = new symbol_132();
			addChild(i676);//0
		}
	}
	public class symbol_366 : MovieClip{ 
		public symbol_366() {
			var i678 = new symbol_132();
			addChild(i678);//0
		}
	}
	public class symbol_367 : MovieClip{ 
		public symbol_367() {
			var i680 = new symbol_132();
			addChild(i680);//0
		}
	}
	public class symbol_368 : MovieClip{ 
		public symbol_368() {
			var i682 = new symbol_132();
			addChild(i682);//0
		}
	}
	public class symbol_369 : MovieClip{ 
		public symbol_369() {
			var i684 = new symbol_115();
			addChild(i684);//0
		}
	}
	public class symbol_37 : MovieClip{ 
		public symbol_37() {
			var i102 = new symbol_20();
			addChild(i102);//0
		}
	}
	public class symbol_370 : MovieClip{ 
		public symbol_370() {
			var i686 = new symbol_132();
			addChild(i686);//0
		}
	}
	public class symbol_371 : MovieClip{ 
		public symbol_371() {
			var i688 = new symbol_132();
			addChild(i688);//0
		}
	}
	public class symbol_372 : MovieClip{ 
		public symbol_372() {
			var i690 = new symbol_132();
			addChild(i690);//0
		}
	}
	public class symbol_373 : MovieClip{ 
		public symbol_373() {
			var i692 = new symbol_132();
			addChild(i692);//0
		}
	}
	public class symbol_374 : MovieClip{ 
		public symbol_374() {
			var i694 = new symbol_115();
			addChild(i694);//0
		}
	}
	public class symbol_375 : MovieClip{ 
		public symbol_375() {
			var i696 = new symbol_132();
			addChild(i696);//0
		}
	}
	public class symbol_376 : MovieClip{ 
		public symbol_376() {
			var i698 = new symbol_132();
			addChild(i698);//0
		}
	}
	public class symbol_377 : MovieClip{ 
		public symbol_377() {
			var i700 = new symbol_132();
			addChild(i700);//0
		}
	}
	public class symbol_378 : MovieClip{ 
		public symbol_378() {
			var i702 = new symbol_115();
			addChild(i702);//0
		}
	}
	public class symbol_379 : MovieClip{ 
		public symbol_379() {
			var i704 = new symbol_132();
			addChild(i704);//0
		}
	}
	public class symbol_38 : MovieClip{ 
		public symbol_38() {
			var i104 = new symbol_20();
			addChild(i104);//0
		}
	}
	public class symbol_380 : MovieClip{ 
		public symbol_380() {
			var i706 = new symbol_132();
			addChild(i706);//0
		}
	}
	public class symbol_381 : Shape{ 
		public symbol_381() {
			setGraphics("1e081203ba3d7227d247f86b1e38dc2b", -15.5, -201.6, 42.3, 74.1, 1, 1);
		}
	}
	public class symbol_382 : MovieClip{ 
		public symbol_382() {
			var i628 = new symbol_294();
			addChild(i628);//0
			var i629 = new symbol_341(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i629);//1
			var i631 = new symbol_342(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i631);//2
			var i633 = new symbol_343(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i633);//3
			var i635 = new symbol_298();
			addChild(i635);//4
			var i636 = new symbol_344(){x = -145.1 , scaleX = 1 , y = -280.2 , scaleY = 1 , rotation = 4};
			addChild(i636);//5
			var i638 = new symbol_345(){x = -147.3 , scaleX = 0.84 , y = -268.1 , scaleY = 0.84 , rotation = -34};
			addChild(i638);//6
			var i640 = new symbol_346();
			addChild(i640);//7
			var i641 = new symbol_347(){x = 212.6 , scaleX = 1 , y = -189.7 , scaleY = 1 , rotation = 131};
			addChild(i641);//8
			var i643 = new symbol_348();
			addChild(i643);//9
			var i644 = new symbol_349(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i644);//10
			var i646 = new symbol_350(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i646);//11
			var i648 = new symbol_351(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i648);//12
			var i650 = new symbol_352();
			addChild(i650);//13
			var i651 = new symbol_353(){x = -92.6 , scaleX = 1 , y = -339.9 , scaleY = 1 , rotation = -160};
			addChild(i651);//14
			var i653 = new symbol_354(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i653);//15
			var i655 = new symbol_355(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i655);//16
			var i657 = new symbol_356(){x = 91.7 , scaleX = 0.79 , y = -420.6 , scaleY = 0.79 , rotation = 13};
			addChild(i657);//17
			var i659 = new symbol_357(){x = 102.2 , scaleX = 1 , y = -421.1 , scaleY = 1 , rotation = 53};
			addChild(i659);//18
			var i661 = new symbol_358(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i661);//19
			var i663 = new symbol_359(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i663);//20
			var i665 = new symbol_360(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i665);//21
			var i667 = new symbol_361(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i667);//22
			var i669 = new symbol_362(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i669);//23
			var i671 = new symbol_363(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i671);//24
			var i673 = new symbol_364(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i673);//25
			var i675 = new symbol_365(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i675);//26
			var i677 = new symbol_366(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i677);//27
			var i679 = new symbol_367(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i679);//28
			var i681 = new symbol_368(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i681);//29
			var i683 = new symbol_369(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i683);//30
			var i685 = new symbol_370(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i685);//31
			var i687 = new symbol_371(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i687);//32
			var i689 = new symbol_372(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i689);//33
			var i691 = new symbol_373(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i691);//34
			var i693 = new symbol_374(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i693);//35
			var i695 = new symbol_375(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i695);//36
			var i697 = new symbol_376(){x = -85.7 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 16};
			addChild(i697);//37
			var i699 = new symbol_377(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i699);//38
			var i701 = new symbol_378(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i701);//39
			var i703 = new symbol_379(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i703);//40
			var i705 = new symbol_380(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i705);//41
			var i707 = new symbol_381();
			addChild(i707);//42
		}
	}
	public class symbol_383 : MovieClip{ 
		public symbol_383() {
			var i708 = new symbol_33();
			addChild(i708);//0
		}
	}
	public class symbol_384 : Shape{ 
		public symbol_384() {
			setGraphics("2a9f76ec8865614d6a54671b1456a523", 278.85, -138.45, 93.89999999999998, 83.89999999999999, 1, 1);
		}
	}
	public class symbol_385 : MovieClip{ 
		public symbol_385() {
			var i713 = new symbol_115();
			addChild(i713);//0
		}
	}
	public class symbol_386 : MovieClip{ 
		public symbol_386() {
			var i715 = new symbol_115();
			addChild(i715);//0
		}
	}
	public class symbol_387 : MovieClip{ 
		public symbol_387() {
			var i717 = new symbol_115();
			addChild(i717);//0
		}
	}
	public class symbol_388 : MovieClip{ 
		public symbol_388() {
			var i720 = new symbol_132();
			addChild(i720);//0
		}
	}
	public class symbol_389 : MovieClip{ 
		public symbol_389() {
			var i722 = new symbol_132();
			addChild(i722);//0
		}
	}
	public class symbol_39 : MovieClip{ 
		public symbol_39() {
			var i106 = new symbol_20();
			addChild(i106);//0
		}
	}
	public class symbol_390 : Shape{ 
		public symbol_390() {
			setGraphics("9ca5a1a0e4120848a2eb211e3e454077", -138.7, -420.7, 277.45, 420.75, 1, 1);
		}
	}
	public class symbol_391 : MovieClip{ 
		public symbol_391() {
			var i725 = new symbol_115();
			addChild(i725);//0
		}
	}
	public class symbol_392 : Shape{ 
		public symbol_392() {
			setGraphics("4670db8304e6e279d0a790223acdf32b", 10.85, -284, 280.25, 120.94999999999999, 1, 1);
		}
	}
	public class symbol_393 : MovieClip{ 
		public symbol_393() {
			var i728 = new symbol_132();
			addChild(i728);//0
		}
	}
	public class symbol_394 : Shape{ 
		public symbol_394() {
			setGraphics("b5b93e028850acba7214f41bc9648a21", -303.45, -224.75, 309.7, 149.25, 1, 1);
		}
	}
	public class symbol_395 : MovieClip{ 
		public symbol_395() {
			var i731 = new symbol_115();
			addChild(i731);//0
		}
	}
	public class symbol_396 : MovieClip{ 
		public symbol_396() {
			var i733 = new symbol_115();
			addChild(i733);//0
		}
	}
	public class symbol_397 : MovieClip{ 
		public symbol_397() {
			var i735 = new symbol_115();
			addChild(i735);//0
		}
	}
	public class symbol_398 : MovieClip{ 
		public symbol_398() {
			var i738 = new symbol_115();
			addChild(i738);//0
		}
	}
	public class symbol_399 : MovieClip{ 
		public symbol_399() {
			var i740 = new symbol_132();
			addChild(i740);//0
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("4842c890c58afc8561a10a6255cd4bd0", -10, -12.5, 20, 25, 1, 1);
		}
	}
	public class symbol_40 : MovieClip{ 
		public symbol_40() {
			var i108 = new symbol_20();
			addChild(i108);//0
		}
	}
	public class symbol_400 : MovieClip{ 
		public symbol_400() {
			var i742 = new symbol_132();
			addChild(i742);//0
		}
	}
	public class symbol_401 : MovieClip{ 
		public symbol_401() {
			var i744 = new symbol_132();
			addChild(i744);//0
		}
	}
	public class symbol_402 : MovieClip{ 
		public symbol_402() {
			var i746 = new symbol_132();
			addChild(i746);//0
		}
	}
	public class symbol_403 : MovieClip{ 
		public symbol_403() {
			var i748 = new symbol_115();
			addChild(i748);//0
		}
	}
	public class symbol_404 : MovieClip{ 
		public symbol_404() {
			var i750 = new symbol_115();
			addChild(i750);//0
		}
	}
	public class symbol_405 : MovieClip{ 
		public symbol_405() {
			var i752 = new symbol_132();
			addChild(i752);//0
		}
	}
	public class symbol_406 : MovieClip{ 
		public symbol_406() {
			var i754 = new symbol_132();
			addChild(i754);//0
		}
	}
	public class symbol_407 : MovieClip{ 
		public symbol_407() {
			var i756 = new symbol_132();
			addChild(i756);//0
		}
	}
	public class symbol_408 : MovieClip{ 
		public symbol_408() {
			var i758 = new symbol_115();
			addChild(i758);//0
		}
	}
	public class symbol_409 : MovieClip{ 
		public symbol_409() {
			var i760 = new symbol_132();
			addChild(i760);//0
		}
	}
	public class symbol_41 : MovieClip{ 
		public symbol_41() {
			var i110 = new symbol_20();
			addChild(i110);//0
		}
	}
	public class symbol_410 : MovieClip{ 
		public symbol_410() {
			var i762 = new symbol_132();
			addChild(i762);//0
		}
	}
	public class symbol_411 : MovieClip{ 
		public symbol_411() {
			var i764 = new symbol_132();
			addChild(i764);//0
		}
	}
	public class symbol_412 : MovieClip{ 
		public symbol_412() {
			var i766 = new symbol_132();
			addChild(i766);//0
		}
	}
	public class symbol_413 : MovieClip{ 
		public symbol_413() {
			var i768 = new symbol_132();
			addChild(i768);//0
		}
	}
	public class symbol_414 : MovieClip{ 
		public symbol_414() {
			var i770 = new symbol_115();
			addChild(i770);//0
		}
	}
	public class symbol_415 : MovieClip{ 
		public symbol_415() {
			var i772 = new symbol_132();
			addChild(i772);//0
		}
	}
	public class symbol_416 : MovieClip{ 
		public symbol_416() {
			var i774 = new symbol_132();
			addChild(i774);//0
		}
	}
	public class symbol_417 : MovieClip{ 
		public symbol_417() {
			var i776 = new symbol_132();
			addChild(i776);//0
		}
	}
	public class symbol_418 : MovieClip{ 
		public symbol_418() {
			var i778 = new symbol_132();
			addChild(i778);//0
		}
	}
	public class symbol_419 : MovieClip{ 
		public symbol_419() {
			var i780 = new symbol_115();
			addChild(i780);//0
		}
	}
	public class symbol_42 : MovieClip{ 
		public symbol_42() {
			var i112 = new symbol_20();
			addChild(i112);//0
		}
	}
	public class symbol_420 : MovieClip{ 
		public symbol_420() {
			var i782 = new symbol_132();
			addChild(i782);//0
		}
	}
	public class symbol_421 : MovieClip{ 
		public symbol_421() {
			var i784 = new symbol_132();
			addChild(i784);//0
		}
	}
	public class symbol_422 : MovieClip{ 
		public symbol_422() {
			var i786 = new symbol_132();
			addChild(i786);//0
		}
	}
	public class symbol_423 : MovieClip{ 
		public symbol_423() {
			var i788 = new symbol_115();
			addChild(i788);//0
		}
	}
	public class symbol_424 : MovieClip{ 
		public symbol_424() {
			var i790 = new symbol_132();
			addChild(i790);//0
		}
	}
	public class symbol_425 : MovieClip{ 
		public symbol_425() {
			var i792 = new symbol_132();
			addChild(i792);//0
		}
	}
	public class symbol_426 : MovieClip{ 
		public symbol_426() {
			var i794 = new symbol_132();
			addChild(i794);//0
		}
	}
	public class symbol_427 : MovieClip{ 
		public symbol_427() {
			var i711 = new symbol_294();
			addChild(i711);//0
			var i712 = new symbol_385(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i712);//1
			var i714 = new symbol_386(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i714);//2
			var i716 = new symbol_387(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i716);//3
			var i718 = new symbol_298();
			addChild(i718);//4
			var i719 = new symbol_388(){x = -145.1 , scaleX = 1 , y = -280.2 , scaleY = 1 , rotation = 4};
			addChild(i719);//5
			var i721 = new symbol_389(){x = -147.3 , scaleX = 0.84 , y = -268.1 , scaleY = 0.84 , rotation = -34};
			addChild(i721);//6
			var i723 = new symbol_390();
			addChild(i723);//7
			var i724 = new symbol_391(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i724);//8
			var i726 = new symbol_392();
			addChild(i726);//9
			var i727 = new symbol_393(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i727);//10
			var i729 = new symbol_394();
			addChild(i729);//11
			var i730 = new symbol_395(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i730);//12
			var i732 = new symbol_396(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i732);//13
			var i734 = new symbol_397(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i734);//14
			var i736 = new symbol_307();
			addChild(i736);//15
			var i737 = new symbol_398(){x = -92.6 , scaleX = 1 , y = -339.9 , scaleY = 1 , rotation = -160};
			addChild(i737);//16
			var i739 = new symbol_399(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i739);//17
			var i741 = new symbol_400(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i741);//18
			var i743 = new symbol_401(){x = 91.7 , scaleX = 0.79 , y = -420.6 , scaleY = 0.79 , rotation = 13};
			addChild(i743);//19
			var i745 = new symbol_402(){x = 102.2 , scaleX = 1 , y = -421.1 , scaleY = 1 , rotation = 53};
			addChild(i745);//20
			var i747 = new symbol_403(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i747);//21
			var i749 = new symbol_404(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i749);//22
			var i751 = new symbol_405(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i751);//23
			var i753 = new symbol_406(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i753);//24
			var i755 = new symbol_407(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i755);//25
			var i757 = new symbol_408(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i757);//26
			var i759 = new symbol_409(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i759);//27
			var i761 = new symbol_410(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i761);//28
			var i763 = new symbol_411(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i763);//29
			var i765 = new symbol_412(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i765);//30
			var i767 = new symbol_413(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i767);//31
			var i769 = new symbol_414(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i769);//32
			var i771 = new symbol_415(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i771);//33
			var i773 = new symbol_416(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i773);//34
			var i775 = new symbol_417(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i775);//35
			var i777 = new symbol_418(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i777);//36
			var i779 = new symbol_419(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i779);//37
			var i781 = new symbol_420(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i781);//38
			var i783 = new symbol_421(){x = -85.7 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 16};
			addChild(i783);//39
			var i785 = new symbol_422(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i785);//40
			var i787 = new symbol_423(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i787);//41
			var i789 = new symbol_424(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i789);//42
			var i791 = new symbol_425(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i791);//43
			var i793 = new symbol_426(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i793);//44
			var i795 = new symbol_381();
			addChild(i795);//45
		}
	}
	public class symbol_428 : MovieClip{ 
		public symbol_428() {
			var i796 = new symbol_33();
			addChild(i796);//0
		}
	}
	public class symbol_429 : MovieClip{ 
		public symbol_429() {
			var i798 = new symbol_13();
			addChild(i798);//0
		}
	}
	public class symbol_43 : MovieClip{ 
		public symbol_43() {
			var i98 = new symbol_35(){x = 64.8 , scaleX = 1 , y = -110.5 , scaleY = 1 , rotation = 11};
			addChild(i98);//0
			var i100 = new symbol_36();
			addChild(i100);//1
			var i101 = new symbol_37(){x = -8.2 , scaleX = 1 , y = -161.3 , scaleY = 1 , rotation = 3};
			addChild(i101);//2
			var i103 = new symbol_38(){x = 15.1 , scaleX = 1 , y = -174.2 , scaleY = 1 , rotation = 87};
			addChild(i103);//3
			var i105 = new symbol_39(){x = -54.6 , scaleX = 1 , y = -127.3 , scaleY = 1 , rotation = -53};
			addChild(i105);//4
			var i107 = new symbol_40(){x = -31.7 , scaleX = 1 , y = -132.1 , scaleY = 1 , rotation = 10};
			addChild(i107);//5
			var i109 = new symbol_41(){x = 73.8 , scaleX = 1 , y = -137.8 , scaleY = 1 , rotation = 73};
			addChild(i109);//6
			var i111 = new symbol_42(){x = 111.3 , scaleX = 1 , y = -122.7 , scaleY = 1 , rotation = 130};
			addChild(i111);//7
		}
	}
	public class symbol_430 : Shape{ 
		public symbol_430() {
			setGraphics("69f65bc00551fa70cb5835d2438df79f", 292.6, -138.45, 58.349999999999966, 81.94999999999999, 1, 1);
		}
	}
	public class symbol_431 : MovieClip{ 
		public symbol_431() {
			var i803 = new symbol_115();
			addChild(i803);//0
		}
	}
	public class symbol_432 : MovieClip{ 
		public symbol_432() {
			var i805 = new symbol_115();
			addChild(i805);//0
		}
	}
	public class symbol_433 : MovieClip{ 
		public symbol_433() {
			var i807 = new symbol_115();
			addChild(i807);//0
		}
	}
	public class symbol_434 : Shape{ 
		public symbol_434() {
			setGraphics("99df6b63ad8b7bea41efbac51c7150ac", -210.95, -396, 222.95, 278.7, 1, 1);
		}
	}
	public class symbol_435 : MovieClip{ 
		public symbol_435() {
			var i810 = new symbol_132();
			addChild(i810);//0
		}
	}
	public class symbol_436 : MovieClip{ 
		public symbol_436() {
			var i812 = new symbol_132();
			addChild(i812);//0
		}
	}
	public class symbol_437 : Shape{ 
		public symbol_437() {
			setGraphics("58e7568781efc4eee744861510a75c7c", -26.5, -420.7, 165.25, 420.75, 1, 1);
		}
	}
	public class symbol_438 : MovieClip{ 
		public symbol_438() {
			var i815 = new symbol_115();
			addChild(i815);//0
		}
	}
	public class symbol_439 : MovieClip{ 
		public symbol_439() {
			var i818 = new symbol_132();
			addChild(i818);//0
		}
	}
	public class symbol_44 : Shape{ 
		public symbol_44() {
			setGraphics("e76c03748c9ce58d684da55974ada82e", 294.35, -100.75, 57.89999999999998, 43.9, 1, 1);
		}
	}
	public class symbol_440 : Shape{ 
		public symbol_440() {
			setGraphics("b4d8cf296307f2ed5ecfdb0d48df34aa", -303.45, -224.75, 309.7, 149.25, 1, 1);
		}
	}
	public class symbol_441 : MovieClip{ 
		public symbol_441() {
			var i821 = new symbol_115();
			addChild(i821);//0
		}
	}
	public class symbol_442 : MovieClip{ 
		public symbol_442() {
			var i823 = new symbol_115();
			addChild(i823);//0
		}
	}
	public class symbol_443 : MovieClip{ 
		public symbol_443() {
			var i825 = new symbol_115();
			addChild(i825);//0
		}
	}
	public class symbol_444 : MovieClip{ 
		public symbol_444() {
			var i828 = new symbol_115();
			addChild(i828);//0
		}
	}
	public class symbol_445 : MovieClip{ 
		public symbol_445() {
			var i830 = new symbol_132();
			addChild(i830);//0
		}
	}
	public class symbol_446 : MovieClip{ 
		public symbol_446() {
			var i832 = new symbol_132();
			addChild(i832);//0
		}
	}
	public class symbol_447 : MovieClip{ 
		public symbol_447() {
			var i834 = new symbol_132();
			addChild(i834);//0
		}
	}
	public class symbol_448 : MovieClip{ 
		public symbol_448() {
			var i836 = new symbol_132();
			addChild(i836);//0
		}
	}
	public class symbol_449 : MovieClip{ 
		public symbol_449() {
			var i838 = new symbol_115();
			addChild(i838);//0
		}
	}
	public class symbol_45 : MovieClip{ 
		public symbol_45() {
			var i116 = new symbol_25();
			addChild(i116);//0
		}
	}
	public class symbol_450 : MovieClip{ 
		public symbol_450() {
			var i840 = new symbol_115();
			addChild(i840);//0
		}
	}
	public class symbol_451 : MovieClip{ 
		public symbol_451() {
			var i842 = new symbol_132();
			addChild(i842);//0
		}
	}
	public class symbol_452 : MovieClip{ 
		public symbol_452() {
			var i844 = new symbol_132();
			addChild(i844);//0
		}
	}
	public class symbol_453 : MovieClip{ 
		public symbol_453() {
			var i846 = new symbol_132();
			addChild(i846);//0
		}
	}
	public class symbol_454 : MovieClip{ 
		public symbol_454() {
			var i848 = new symbol_115();
			addChild(i848);//0
		}
	}
	public class symbol_455 : MovieClip{ 
		public symbol_455() {
			var i850 = new symbol_132();
			addChild(i850);//0
		}
	}
	public class symbol_456 : MovieClip{ 
		public symbol_456() {
			var i852 = new symbol_132();
			addChild(i852);//0
		}
	}
	public class symbol_457 : MovieClip{ 
		public symbol_457() {
			var i854 = new symbol_132();
			addChild(i854);//0
		}
	}
	public class symbol_458 : MovieClip{ 
		public symbol_458() {
			var i856 = new symbol_132();
			addChild(i856);//0
		}
	}
	public class symbol_459 : MovieClip{ 
		public symbol_459() {
			var i858 = new symbol_132();
			addChild(i858);//0
		}
	}
	public class symbol_46 : MovieClip{ 
		public symbol_46() {
			var i118 = new symbol_25();
			addChild(i118);//0
		}
	}
	public class symbol_460 : MovieClip{ 
		public symbol_460() {
			var i860 = new symbol_115();
			addChild(i860);//0
		}
	}
	public class symbol_461 : MovieClip{ 
		public symbol_461() {
			var i862 = new symbol_132();
			addChild(i862);//0
		}
	}
	public class symbol_462 : MovieClip{ 
		public symbol_462() {
			var i864 = new symbol_132();
			addChild(i864);//0
		}
	}
	public class symbol_463 : MovieClip{ 
		public symbol_463() {
			var i866 = new symbol_132();
			addChild(i866);//0
		}
	}
	public class symbol_464 : MovieClip{ 
		public symbol_464() {
			var i868 = new symbol_132();
			addChild(i868);//0
		}
	}
	public class symbol_465 : MovieClip{ 
		public symbol_465() {
			var i870 = new symbol_115();
			addChild(i870);//0
		}
	}
	public class symbol_466 : MovieClip{ 
		public symbol_466() {
			var i872 = new symbol_132();
			addChild(i872);//0
		}
	}
	public class symbol_467 : MovieClip{ 
		public symbol_467() {
			var i874 = new symbol_132();
			addChild(i874);//0
		}
	}
	public class symbol_468 : MovieClip{ 
		public symbol_468() {
			var i876 = new symbol_132();
			addChild(i876);//0
		}
	}
	public class symbol_469 : MovieClip{ 
		public symbol_469() {
			var i878 = new symbol_115();
			addChild(i878);//0
		}
	}
	public class symbol_47 : Shape{ 
		public symbol_47() {
			setGraphics("61e87a4c5e4930bdd738741e4c61d481", -81.85, -182, 201.85, 182.5, 1, 1);
		}
	}
	public class symbol_470 : MovieClip{ 
		public symbol_470() {
			var i880 = new symbol_132();
			addChild(i880);//0
		}
	}
	public class symbol_471 : MovieClip{ 
		public symbol_471() {
			var i882 = new symbol_132();
			addChild(i882);//0
		}
	}
	public class symbol_472 : MovieClip{ 
		public symbol_472() {
			var i884 = new symbol_132();
			addChild(i884);//0
		}
	}
	public class symbol_473 : MovieClip{ 
		public symbol_473() {
			var i886 = new symbol_115();
			addChild(i886);//0
		}
	}
	public class symbol_474 : MovieClip{ 
		public symbol_474() {
			var i888 = new symbol_132();
			addChild(i888);//0
		}
	}
	public class symbol_475 : MovieClip{ 
		public symbol_475() {
			var i890 = new symbol_132();
			addChild(i890);//0
		}
	}
	public class symbol_476 : MovieClip{ 
		public symbol_476() {
			var i801 = new symbol_294();
			addChild(i801);//0
			var i802 = new symbol_431(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i802);//1
			var i804 = new symbol_432(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i804);//2
			var i806 = new symbol_433(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i806);//3
			var i808 = new symbol_434();
			addChild(i808);//4
			var i809 = new symbol_435(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i809);//5
			var i811 = new symbol_436(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i811);//6
			var i813 = new symbol_437();
			addChild(i813);//7
			var i814 = new symbol_438(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i814);//8
			var i816 = new symbol_392();
			addChild(i816);//9
			var i817 = new symbol_439(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i817);//10
			var i819 = new symbol_440();
			addChild(i819);//11
			var i820 = new symbol_441(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i820);//12
			var i822 = new symbol_442(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i822);//13
			var i824 = new symbol_443(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i824);//14
			var i826 = new symbol_352();
			addChild(i826);//15
			var i827 = new symbol_444(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i827);//16
			var i829 = new symbol_445(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i829);//17
			var i831 = new symbol_446(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i831);//18
			var i833 = new symbol_447(){x = 91.7 , scaleX = 0.79 , y = -420.6 , scaleY = 0.79 , rotation = 13};
			addChild(i833);//19
			var i835 = new symbol_448(){x = 102.2 , scaleX = 1 , y = -421.1 , scaleY = 1 , rotation = 53};
			addChild(i835);//20
			var i837 = new symbol_449(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i837);//21
			var i839 = new symbol_450(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i839);//22
			var i841 = new symbol_451(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i841);//23
			var i843 = new symbol_452(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i843);//24
			var i845 = new symbol_453(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i845);//25
			var i847 = new symbol_454(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i847);//26
			var i849 = new symbol_455(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i849);//27
			var i851 = new symbol_456(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i851);//28
			var i853 = new symbol_457(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i853);//29
			var i855 = new symbol_458(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i855);//30
			var i857 = new symbol_459(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i857);//31
			var i859 = new symbol_460(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i859);//32
			var i861 = new symbol_461(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i861);//33
			var i863 = new symbol_462(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i863);//34
			var i865 = new symbol_463(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i865);//35
			var i867 = new symbol_464(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i867);//36
			var i869 = new symbol_465(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i869);//37
			var i871 = new symbol_466(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i871);//38
			var i873 = new symbol_467(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i873);//39
			var i875 = new symbol_468(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i875);//40
			var i877 = new symbol_469(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i877);//41
			var i879 = new symbol_470(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i879);//42
			var i881 = new symbol_471(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i881);//43
			var i883 = new symbol_472(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i883);//44
			var i885 = new symbol_473(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i885);//45
			var i887 = new symbol_474(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i887);//46
			var i889 = new symbol_475(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i889);//47
			var i891 = new symbol_381();
			addChild(i891);//48
		}
	}
	public class symbol_477 : MovieClip{ 
		public symbol_477() {
			var i892 = new symbol_33();
			addChild(i892);//0
		}
	}
	public class symbol_478 : MovieClip{ 
		public symbol_478() {
			var i896 = new symbol_115();
			addChild(i896);//0
		}
	}
	public class symbol_479 : MovieClip{ 
		public symbol_479() {
			var i898 = new symbol_115();
			addChild(i898);//0
		}
	}
	public class symbol_48 : MovieClip{ 
		public symbol_48() {
			var i121 = new symbol_20();
			addChild(i121);//0
		}
	}
	public class symbol_480 : MovieClip{ 
		public symbol_480() {
			var i900 = new symbol_115();
			addChild(i900);//0
		}
	}
	public class symbol_481 : MovieClip{ 
		public symbol_481() {
			var i903 = new symbol_132();
			addChild(i903);//0
		}
	}
	public class symbol_482 : MovieClip{ 
		public symbol_482() {
			var i905 = new symbol_132();
			addChild(i905);//0
		}
	}
	public class symbol_483 : Shape{ 
		public symbol_483() {
			setGraphics("a3899443d3f234b0f3a49ffb6a6735e6", 32.1, -206.1, 106.65, 54.650000000000006, 1, 1);
		}
	}
	public class symbol_484 : MovieClip{ 
		public symbol_484() {
			var i908 = new symbol_115();
			addChild(i908);//0
		}
	}
	public class symbol_485 : MovieClip{ 
		public symbol_485() {
			var i910 = new symbol_115();
			addChild(i910);//0
		}
	}
	public class symbol_486 : MovieClip{ 
		public symbol_486() {
			var i912 = new symbol_132();
			addChild(i912);//0
		}
	}
	public class symbol_487 : Shape{ 
		public symbol_487() {
			setGraphics("362c41981992240b1ac2fd66280b8f07", -26.5, -420.7, 249, 420.75, 1, 1);
		}
	}
	public class symbol_488 : MovieClip{ 
		public symbol_488() {
			var i915 = new symbol_115();
			addChild(i915);//0
		}
	}
	public class symbol_489 : MovieClip{ 
		public symbol_489() {
			var i918 = new symbol_132();
			addChild(i918);//0
		}
	}
	public class symbol_49 : MovieClip{ 
		public symbol_49() {
			var i123 = new symbol_20();
			addChild(i123);//0
		}
	}
	public class symbol_490 : MovieClip{ 
		public symbol_490() {
			var i921 = new symbol_115();
			addChild(i921);//0
		}
	}
	public class symbol_491 : MovieClip{ 
		public symbol_491() {
			var i923 = new symbol_115();
			addChild(i923);//0
		}
	}
	public class symbol_492 : MovieClip{ 
		public symbol_492() {
			var i925 = new symbol_115();
			addChild(i925);//0
		}
	}
	public class symbol_493 : MovieClip{ 
		public symbol_493() {
			var i928 = new symbol_115();
			addChild(i928);//0
		}
	}
	public class symbol_494 : MovieClip{ 
		public symbol_494() {
			var i930 = new symbol_132();
			addChild(i930);//0
		}
	}
	public class symbol_495 : MovieClip{ 
		public symbol_495() {
			var i932 = new symbol_132();
			addChild(i932);//0
		}
	}
	public class symbol_496 : MovieClip{ 
		public symbol_496() {
			var i934 = new symbol_132();
			addChild(i934);//0
		}
	}
	public class symbol_497 : MovieClip{ 
		public symbol_497() {
			var i936 = new symbol_132();
			addChild(i936);//0
		}
	}
	public class symbol_498 : MovieClip{ 
		public symbol_498() {
			var i938 = new symbol_115();
			addChild(i938);//0
		}
	}
	public class symbol_499 : MovieClip{ 
		public symbol_499() {
			var i940 = new symbol_115();
			addChild(i940);//0
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("b936151063d1e9f5257b2eea71662d5a", -14.5, -14.5, 29, 29, 1, 1);
		}
	}
	public class symbol_50 : MovieClip{ 
		public symbol_50() {
			var i125 = new symbol_20();
			addChild(i125);//0
		}
	}
	public class symbol_500 : MovieClip{ 
		public symbol_500() {
			var i942 = new symbol_132();
			addChild(i942);//0
		}
	}
	public class symbol_501 : MovieClip{ 
		public symbol_501() {
			var i944 = new symbol_132();
			addChild(i944);//0
		}
	}
	public class symbol_502 : MovieClip{ 
		public symbol_502() {
			var i946 = new symbol_132();
			addChild(i946);//0
		}
	}
	public class symbol_503 : MovieClip{ 
		public symbol_503() {
			var i948 = new symbol_115();
			addChild(i948);//0
		}
	}
	public class symbol_504 : MovieClip{ 
		public symbol_504() {
			var i950 = new symbol_132();
			addChild(i950);//0
		}
	}
	public class symbol_505 : MovieClip{ 
		public symbol_505() {
			var i952 = new symbol_132();
			addChild(i952);//0
		}
	}
	public class symbol_506 : MovieClip{ 
		public symbol_506() {
			var i954 = new symbol_132();
			addChild(i954);//0
		}
	}
	public class symbol_507 : MovieClip{ 
		public symbol_507() {
			var i956 = new symbol_132();
			addChild(i956);//0
		}
	}
	public class symbol_508 : MovieClip{ 
		public symbol_508() {
			var i958 = new symbol_132();
			addChild(i958);//0
		}
	}
	public class symbol_509 : MovieClip{ 
		public symbol_509() {
			var i960 = new symbol_115();
			addChild(i960);//0
		}
	}
	public class symbol_51 : MovieClip{ 
		public symbol_51() {
			var i127 = new symbol_20();
			addChild(i127);//0
		}
	}
	public class symbol_510 : MovieClip{ 
		public symbol_510() {
			var i962 = new symbol_132();
			addChild(i962);//0
		}
	}
	public class symbol_511 : MovieClip{ 
		public symbol_511() {
			var i964 = new symbol_132();
			addChild(i964);//0
		}
	}
	public class symbol_512 : MovieClip{ 
		public symbol_512() {
			var i966 = new symbol_132();
			addChild(i966);//0
		}
	}
	public class symbol_513 : MovieClip{ 
		public symbol_513() {
			var i968 = new symbol_132();
			addChild(i968);//0
		}
	}
	public class symbol_514 : MovieClip{ 
		public symbol_514() {
			var i970 = new symbol_115();
			addChild(i970);//0
		}
	}
	public class symbol_515 : MovieClip{ 
		public symbol_515() {
			var i972 = new symbol_132();
			addChild(i972);//0
		}
	}
	public class symbol_516 : MovieClip{ 
		public symbol_516() {
			var i974 = new symbol_132();
			addChild(i974);//0
		}
	}
	public class symbol_517 : MovieClip{ 
		public symbol_517() {
			var i976 = new symbol_132();
			addChild(i976);//0
		}
	}
	public class symbol_518 : MovieClip{ 
		public symbol_518() {
			var i978 = new symbol_115();
			addChild(i978);//0
		}
	}
	public class symbol_519 : MovieClip{ 
		public symbol_519() {
			var i980 = new symbol_132();
			addChild(i980);//0
		}
	}
	public class symbol_52 : MovieClip{ 
		public symbol_52() {
			var i129 = new symbol_20();
			addChild(i129);//0
		}
	}
	public class symbol_520 : MovieClip{ 
		public symbol_520() {
			var i982 = new symbol_132();
			addChild(i982);//0
		}
	}
	public class symbol_521 : MovieClip{ 
		public symbol_521() {
			var i984 = new symbol_132();
			addChild(i984);//0
		}
	}
	public class symbol_522 : MovieClip{ 
		public symbol_522() {
			var i986 = new symbol_115();
			addChild(i986);//0
		}
	}
	public class symbol_523 : MovieClip{ 
		public symbol_523() {
			var i988 = new symbol_132();
			addChild(i988);//0
		}
	}
	public class symbol_524 : MovieClip{ 
		public symbol_524() {
			var i990 = new symbol_132();
			addChild(i990);//0
		}
	}
	public class symbol_525 : MovieClip{ 
		public symbol_525() {
			var i992 = new symbol_132();
			addChild(i992);//0
		}
	}
	public class symbol_526 : MovieClip{ 
		public symbol_526() {
			var i894 = new symbol_294();
			addChild(i894);//0
			var i895 = new symbol_478(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i895);//1
			var i897 = new symbol_479(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i897);//2
			var i899 = new symbol_480(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i899);//3
			var i901 = new symbol_434();
			addChild(i901);//4
			var i902 = new symbol_481(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i902);//5
			var i904 = new symbol_482(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i904);//6
			var i906 = new symbol_483();
			addChild(i906);//7
			var i907 = new symbol_484(){x = 135.9 , scaleX = 1 , y = -331.8 , scaleY = 1 , rotation = 48};
			addChild(i907);//8
			var i909 = new symbol_485(){x = 207.3 , scaleX = 1 , y = -329.6 , scaleY = 1 , rotation = 18};
			addChild(i909);//9
			var i911 = new symbol_486(){x = 220.8 , scaleX = 0.89 , y = -369.8 , scaleY = 0.77 , rotation = 68};
			addChild(i911);//10
			var i913 = new symbol_487();
			addChild(i913);//11
			var i914 = new symbol_488(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i914);//12
			var i916 = new symbol_392();
			addChild(i916);//13
			var i917 = new symbol_489(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i917);//14
			var i919 = new symbol_394();
			addChild(i919);//15
			var i920 = new symbol_490(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i920);//16
			var i922 = new symbol_491(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i922);//17
			var i924 = new symbol_492(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i924);//18
			var i926 = new symbol_307();
			addChild(i926);//19
			var i927 = new symbol_493(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i927);//20
			var i929 = new symbol_494(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i929);//21
			var i931 = new symbol_495(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i931);//22
			var i933 = new symbol_496(){x = 91.7 , scaleX = 0.79 , y = -420.6 , scaleY = 0.79 , rotation = 13};
			addChild(i933);//23
			var i935 = new symbol_497(){x = 102.2 , scaleX = 1 , y = -421.1 , scaleY = 1 , rotation = 53};
			addChild(i935);//24
			var i937 = new symbol_498(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i937);//25
			var i939 = new symbol_499(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i939);//26
			var i941 = new symbol_500(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i941);//27
			var i943 = new symbol_501(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i943);//28
			var i945 = new symbol_502(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i945);//29
			var i947 = new symbol_503(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i947);//30
			var i949 = new symbol_504(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i949);//31
			var i951 = new symbol_505(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i951);//32
			var i953 = new symbol_506(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i953);//33
			var i955 = new symbol_507(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i955);//34
			var i957 = new symbol_508(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i957);//35
			var i959 = new symbol_509(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i959);//36
			var i961 = new symbol_510(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i961);//37
			var i963 = new symbol_511(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i963);//38
			var i965 = new symbol_512(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i965);//39
			var i967 = new symbol_513(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i967);//40
			var i969 = new symbol_514(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i969);//41
			var i971 = new symbol_515(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i971);//42
			var i973 = new symbol_516(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i973);//43
			var i975 = new symbol_517(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i975);//44
			var i977 = new symbol_518(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i977);//45
			var i979 = new symbol_519(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i979);//46
			var i981 = new symbol_520(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i981);//47
			var i983 = new symbol_521(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i983);//48
			var i985 = new symbol_522(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i985);//49
			var i987 = new symbol_523(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i987);//50
			var i989 = new symbol_524(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i989);//51
			var i991 = new symbol_525(){x = 135.3 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 108};
			addChild(i991);//52
			var i993 = new symbol_381();
			addChild(i993);//53
		}
	}
	public class symbol_527 : MovieClip{ 
		public symbol_527() {
			var i994 = new symbol_33();
			addChild(i994);//0
		}
	}
	public class symbol_528 : MovieClip{ 
		public symbol_528() {
			var i998 = new symbol_115();
			addChild(i998);//0
		}
	}
	public class symbol_529 : MovieClip{ 
		public symbol_529() {
			var i1000 = new symbol_115();
			addChild(i1000);//0
		}
	}
	public class symbol_53 : MovieClip{ 
		public symbol_53() {
			var i131 = new symbol_20();
			addChild(i131);//0
		}
	}
	public class symbol_530 : MovieClip{ 
		public symbol_530() {
			var i1002 = new symbol_115();
			addChild(i1002);//0
		}
	}
	public class symbol_531 : MovieClip{ 
		public symbol_531() {
			var i1005 = new symbol_132();
			addChild(i1005);//0
		}
	}
	public class symbol_532 : MovieClip{ 
		public symbol_532() {
			var i1007 = new symbol_132();
			addChild(i1007);//0
		}
	}
	public class symbol_533 : MovieClip{ 
		public symbol_533() {
			var i1010 = new symbol_115();
			addChild(i1010);//0
		}
	}
	public class symbol_534 : MovieClip{ 
		public symbol_534() {
			var i1012 = new symbol_115();
			addChild(i1012);//0
		}
	}
	public class symbol_535 : MovieClip{ 
		public symbol_535() {
			var i1014 = new symbol_132();
			addChild(i1014);//0
		}
	}
	public class symbol_536 : Shape{ 
		public symbol_536() {
			setGraphics("28a8f92adc3c0e823dd46e14dc625291", -26.5, -431.35, 249, 431.40000000000003, 1, 1);
		}
	}
	public class symbol_537 : MovieClip{ 
		public symbol_537() {
			var i1017 = new symbol_115();
			addChild(i1017);//0
		}
	}
	public class symbol_538 : MovieClip{ 
		public symbol_538() {
			var i1020 = new symbol_132();
			addChild(i1020);//0
		}
	}
	public class symbol_539 : MovieClip{ 
		public symbol_539() {
			var i1023 = new symbol_115();
			addChild(i1023);//0
		}
	}
	public class symbol_54 : MovieClip{ 
		public symbol_54() {
			var i133 = new symbol_20();
			addChild(i133);//0
		}
	}
	public class symbol_540 : MovieClip{ 
		public symbol_540() {
			var i1025 = new symbol_115();
			addChild(i1025);//0
		}
	}
	public class symbol_541 : MovieClip{ 
		public symbol_541() {
			var i1027 = new symbol_115();
			addChild(i1027);//0
		}
	}
	public class symbol_542 : MovieClip{ 
		public symbol_542() {
			var i1030 = new symbol_115();
			addChild(i1030);//0
		}
	}
	public class symbol_543 : MovieClip{ 
		public symbol_543() {
			var i1032 = new symbol_132();
			addChild(i1032);//0
		}
	}
	public class symbol_544 : MovieClip{ 
		public symbol_544() {
			var i1034 = new symbol_132();
			addChild(i1034);//0
		}
	}
	public class symbol_545 : MovieClip{ 
		public symbol_545() {
			var i1036 = new symbol_132();
			addChild(i1036);//0
		}
	}
	public class symbol_546 : MovieClip{ 
		public symbol_546() {
			var i1038 = new symbol_132();
			addChild(i1038);//0
		}
	}
	public class symbol_547 : MovieClip{ 
		public symbol_547() {
			var i1040 = new symbol_115();
			addChild(i1040);//0
		}
	}
	public class symbol_548 : MovieClip{ 
		public symbol_548() {
			var i1042 = new symbol_115();
			addChild(i1042);//0
		}
	}
	public class symbol_549 : MovieClip{ 
		public symbol_549() {
			var i1044 = new symbol_132();
			addChild(i1044);//0
		}
	}
	public class symbol_55 : MovieClip{ 
		public symbol_55() {
			var i135 = new symbol_20();
			addChild(i135);//0
		}
	}
	public class symbol_550 : MovieClip{ 
		public symbol_550() {
			var i1046 = new symbol_132();
			addChild(i1046);//0
		}
	}
	public class symbol_551 : MovieClip{ 
		public symbol_551() {
			var i1048 = new symbol_132();
			addChild(i1048);//0
		}
	}
	public class symbol_552 : MovieClip{ 
		public symbol_552() {
			var i1050 = new symbol_115();
			addChild(i1050);//0
		}
	}
	public class symbol_553 : MovieClip{ 
		public symbol_553() {
			var i1052 = new symbol_132();
			addChild(i1052);//0
		}
	}
	public class symbol_554 : MovieClip{ 
		public symbol_554() {
			var i1054 = new symbol_132();
			addChild(i1054);//0
		}
	}
	public class symbol_555 : MovieClip{ 
		public symbol_555() {
			var i1056 = new symbol_132();
			addChild(i1056);//0
		}
	}
	public class symbol_556 : MovieClip{ 
		public symbol_556() {
			var i1058 = new symbol_132();
			addChild(i1058);//0
		}
	}
	public class symbol_557 : MovieClip{ 
		public symbol_557() {
			var i1060 = new symbol_132();
			addChild(i1060);//0
		}
	}
	public class symbol_558 : MovieClip{ 
		public symbol_558() {
			var i1062 = new symbol_115();
			addChild(i1062);//0
		}
	}
	public class symbol_559 : MovieClip{ 
		public symbol_559() {
			var i1064 = new symbol_132();
			addChild(i1064);//0
		}
	}
	public class symbol_56 : MovieClip{ 
		public symbol_56() {
			var i115 = new symbol_45(){x = -51.6 , scaleX = 1 , y = -108.8 , scaleY = 1 , rotation = 149};
			addChild(i115);//0
			var i117 = new symbol_46(){x = 69.3 , scaleX = 1 , y = -109.3 , scaleY = 1 , rotation = -14};
			addChild(i117);//1
			var i119 = new symbol_47();
			addChild(i119);//2
			var i120 = new symbol_48(){x = 123.5 , scaleX = 1 , y = -133.8 , scaleY = 1 , rotation = 91};
			addChild(i120);//3
			var i122 = new symbol_49(){x = 75 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = 72};
			addChild(i122);//4
			var i124 = new symbol_50(){x = 15.5 , scaleX = 1 , y = -183.8 , scaleY = 1 , rotation = 93};
			addChild(i124);//5
			var i126 = new symbol_51(){x = -12.3 , scaleX = 1 , y = -166.1 , scaleY = 1 , rotation = 1};
			addChild(i126);//6
			var i128 = new symbol_52(){x = -77.9 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = 31};
			addChild(i128);//7
			var i130 = new symbol_53(){x = -81.2 , scaleX = 1 , y = -138.2 , scaleY = 1 , rotation = -62};
			addChild(i130);//8
			var i132 = new symbol_54(){x = -80.5 , scaleX = 1 , y = -115.8 , scaleY = 1 , rotation = 54};
			addChild(i132);//9
			var i134 = new symbol_55(){x = 118.8 , scaleX = 1 , y = -118.2 , scaleY = 1 , rotation = 161};
			addChild(i134);//10
		}
	}
	public class symbol_560 : MovieClip{ 
		public symbol_560() {
			var i1066 = new symbol_132();
			addChild(i1066);//0
		}
	}
	public class symbol_561 : MovieClip{ 
		public symbol_561() {
			var i1068 = new symbol_132();
			addChild(i1068);//0
		}
	}
	public class symbol_562 : MovieClip{ 
		public symbol_562() {
			var i1070 = new symbol_132();
			addChild(i1070);//0
		}
	}
	public class symbol_563 : MovieClip{ 
		public symbol_563() {
			var i1072 = new symbol_115();
			addChild(i1072);//0
		}
	}
	public class symbol_564 : MovieClip{ 
		public symbol_564() {
			var i1074 = new symbol_132();
			addChild(i1074);//0
		}
	}
	public class symbol_565 : MovieClip{ 
		public symbol_565() {
			var i1076 = new symbol_132();
			addChild(i1076);//0
		}
	}
	public class symbol_566 : MovieClip{ 
		public symbol_566() {
			var i1078 = new symbol_132();
			addChild(i1078);//0
		}
	}
	public class symbol_567 : MovieClip{ 
		public symbol_567() {
			var i1080 = new symbol_115();
			addChild(i1080);//0
		}
	}
	public class symbol_568 : MovieClip{ 
		public symbol_568() {
			var i1082 = new symbol_132();
			addChild(i1082);//0
		}
	}
	public class symbol_569 : MovieClip{ 
		public symbol_569() {
			var i1084 = new symbol_132();
			addChild(i1084);//0
		}
	}
	public class symbol_57 : MovieClip{ 
		public symbol_57() {
			var i136 = new symbol_33();
			addChild(i136);//0
		}
	}
	public class symbol_570 : MovieClip{ 
		public symbol_570() {
			var i1086 = new symbol_132();
			addChild(i1086);//0
		}
	}
	public class symbol_571 : MovieClip{ 
		public symbol_571() {
			var i1088 = new symbol_115();
			addChild(i1088);//0
		}
	}
	public class symbol_572 : MovieClip{ 
		public symbol_572() {
			var i1090 = new symbol_132();
			addChild(i1090);//0
		}
	}
	public class symbol_573 : MovieClip{ 
		public symbol_573() {
			var i1092 = new symbol_132();
			addChild(i1092);//0
		}
	}
	public class symbol_574 : MovieClip{ 
		public symbol_574() {
			var i1094 = new symbol_132();
			addChild(i1094);//0
		}
	}
	public class symbol_575 : MovieClip{ 
		public symbol_575() {
			var i996 = new symbol_294();
			addChild(i996);//0
			var i997 = new symbol_528(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i997);//1
			var i999 = new symbol_529(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i999);//2
			var i1001 = new symbol_530(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1001);//3
			var i1003 = new symbol_434();
			addChild(i1003);//4
			var i1004 = new symbol_531(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i1004);//5
			var i1006 = new symbol_532(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i1006);//6
			var i1008 = new symbol_483();
			addChild(i1008);//7
			var i1009 = new symbol_533(){x = 135.9 , scaleX = 1 , y = -331.8 , scaleY = 1 , rotation = 48};
			addChild(i1009);//8
			var i1011 = new symbol_534(){x = 207.3 , scaleX = 1 , y = -329.6 , scaleY = 1 , rotation = 18};
			addChild(i1011);//9
			var i1013 = new symbol_535(){x = 220.8 , scaleX = 0.89 , y = -369.8 , scaleY = 0.77 , rotation = 68};
			addChild(i1013);//10
			var i1015 = new symbol_536();
			addChild(i1015);//11
			var i1016 = new symbol_537(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i1016);//12
			var i1018 = new symbol_392();
			addChild(i1018);//13
			var i1019 = new symbol_538(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i1019);//14
			var i1021 = new symbol_440();
			addChild(i1021);//15
			var i1022 = new symbol_539(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i1022);//16
			var i1024 = new symbol_540(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i1024);//17
			var i1026 = new symbol_541(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i1026);//18
			var i1028 = new symbol_352();
			addChild(i1028);//19
			var i1029 = new symbol_542(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i1029);//20
			var i1031 = new symbol_543(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i1031);//21
			var i1033 = new symbol_544(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i1033);//22
			var i1035 = new symbol_545(){x = 90.7 , scaleX = 0.79 , y = -419.6 , scaleY = 0.79 , rotation = 13};
			addChild(i1035);//23
			var i1037 = new symbol_546(){x = 101.2 , scaleX = 1 , y = -420.1 , scaleY = 1 , rotation = 53};
			addChild(i1037);//24
			var i1039 = new symbol_547(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i1039);//25
			var i1041 = new symbol_548(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i1041);//26
			var i1043 = new symbol_549(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i1043);//27
			var i1045 = new symbol_550(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i1045);//28
			var i1047 = new symbol_551(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i1047);//29
			var i1049 = new symbol_552(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1049);//30
			var i1051 = new symbol_553(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1051);//31
			var i1053 = new symbol_554(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i1053);//32
			var i1055 = new symbol_555(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i1055);//33
			var i1057 = new symbol_556(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i1057);//34
			var i1059 = new symbol_557(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i1059);//35
			var i1061 = new symbol_558(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i1061);//36
			var i1063 = new symbol_559(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i1063);//37
			var i1065 = new symbol_560(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i1065);//38
			var i1067 = new symbol_561(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i1067);//39
			var i1069 = new symbol_562(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i1069);//40
			var i1071 = new symbol_563(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i1071);//41
			var i1073 = new symbol_564(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i1073);//42
			var i1075 = new symbol_565(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i1075);//43
			var i1077 = new symbol_566(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i1077);//44
			var i1079 = new symbol_567(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i1079);//45
			var i1081 = new symbol_568(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i1081);//46
			var i1083 = new symbol_569(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i1083);//47
			var i1085 = new symbol_570(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i1085);//48
			var i1087 = new symbol_571(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i1087);//49
			var i1089 = new symbol_572(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i1089);//50
			var i1091 = new symbol_573(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i1091);//51
			var i1093 = new symbol_574(){x = 135.3 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 108};
			addChild(i1093);//52
			var i1095 = new symbol_381();
			addChild(i1095);//53
		}
	}
	public class symbol_576 : MovieClip{ 
		public symbol_576() {
			var i1096 = new symbol_33();
			addChild(i1096);//0
		}
	}
	public class symbol_577 : MovieClip{ 
		public symbol_577() {
			var i1098 = new symbol_13();
			addChild(i1098);//0
		}
	}
	public class symbol_578 : Shape{ 
		public symbol_578() {
			setGraphics("bb765bbf6b0054c0348989684c512809", 102.75, -138.45, 58.349999999999994, 81.94999999999999, 1, 1);
		}
	}
	public class symbol_579 : Shape{ 
		public symbol_579() {
			setGraphics("bf87fe6cdb7bc50f832a3d2164a8773d", -71.65, -6.4, 142.10000000000002, 22.05, 1, 1);
		}
	}
	public class symbol_58 : Shape{ 
		public symbol_58() {
			setGraphics("4a6d5f1836d0bd3c443a6e2ed88cd849", -19.15, -114.35, 20, 46.69999999999999, 1, 1);
		}
	}
	public class symbol_580 : MovieClip{ 
		public symbol_580() {
			var i1101 = new symbol_579();
			addChild(i1101);//0
		}
	}
	public class symbol_581 : MovieClip{ 
		public symbol_581() {
			var i1105 = new symbol_115();
			addChild(i1105);//0
		}
	}
	public class symbol_582 : MovieClip{ 
		public symbol_582() {
			var i1107 = new symbol_115();
			addChild(i1107);//0
		}
	}
	public class symbol_583 : MovieClip{ 
		public symbol_583() {
			var i1109 = new symbol_115();
			addChild(i1109);//0
		}
	}
	public class symbol_584 : MovieClip{ 
		public symbol_584() {
			var i1112 = new symbol_132();
			addChild(i1112);//0
		}
	}
	public class symbol_585 : MovieClip{ 
		public symbol_585() {
			var i1114 = new symbol_132();
			addChild(i1114);//0
		}
	}
	public class symbol_586 : MovieClip{ 
		public symbol_586() {
			var i1117 = new symbol_115();
			addChild(i1117);//0
		}
	}
	public class symbol_587 : MovieClip{ 
		public symbol_587() {
			var i1119 = new symbol_115();
			addChild(i1119);//0
		}
	}
	public class symbol_588 : MovieClip{ 
		public symbol_588() {
			var i1121 = new symbol_132();
			addChild(i1121);//0
		}
	}
	public class symbol_589 : Shape{ 
		public symbol_589() {
			setGraphics("c4cc3473026062b088c8d2aeae0b05ec", -26.5, -431.35, 249, 431.40000000000003, 1, 1);
		}
	}
	public class symbol_59 : Shape{ 
		public symbol_59() {
			setGraphics("5c2282542f86099881853afacd431545", -10.35, -6.1, 20.75, 12.25, 1, 1);
		}
	}
	public class symbol_590 : MovieClip{ 
		public symbol_590() {
			var i1124 = new symbol_115();
			addChild(i1124);//0
		}
	}
	public class symbol_591 : MovieClip{ 
		public symbol_591() {
			var i1127 = new symbol_132();
			addChild(i1127);//0
		}
	}
	public class symbol_592 : MovieClip{ 
		public symbol_592() {
			var i1130 = new symbol_115();
			addChild(i1130);//0
		}
	}
	public class symbol_593 : MovieClip{ 
		public symbol_593() {
			var i1132 = new symbol_115();
			addChild(i1132);//0
		}
	}
	public class symbol_594 : MovieClip{ 
		public symbol_594() {
			var i1134 = new symbol_115();
			addChild(i1134);//0
		}
	}
	public class symbol_595 : Shape{ 
		public symbol_595() {
			setGraphics("b0e56836d72a13a9239575c4b4f8cb13", -26, -214.7, 345.7, 188.6, 1, 1);
		}
	}
	public class symbol_596 : MovieClip{ 
		public symbol_596() {
			var i1137 = new symbol_115();
			addChild(i1137);//0
		}
	}
	public class symbol_597 : MovieClip{ 
		public symbol_597() {
			var i1139 = new symbol_132();
			addChild(i1139);//0
		}
	}
	public class symbol_598 : MovieClip{ 
		public symbol_598() {
			var i1141 = new symbol_132();
			addChild(i1141);//0
		}
	}
	public class symbol_599 : MovieClip{ 
		public symbol_599() {
			var i1143 = new symbol_132();
			addChild(i1143);//0
		}
	}
	public class symbol_6 : Shape{ 
		public symbol_6() {
			setGraphics("8378dc3e04721079b1e63452e00237f4", -11.5, -11.5, 23, 23, 1, 1);
		}
	}
	public class symbol_60 : MovieClip{ 
		public symbol_60() {
			var i140 = new symbol_59();
			addChild(i140);//0
		}
	}
	public class symbol_600 : MovieClip{ 
		public symbol_600() {
			var i1145 = new symbol_132();
			addChild(i1145);//0
		}
	}
	public class symbol_601 : MovieClip{ 
		public symbol_601() {
			var i1147 = new symbol_115();
			addChild(i1147);//0
		}
	}
	public class symbol_602 : MovieClip{ 
		public symbol_602() {
			var i1149 = new symbol_115();
			addChild(i1149);//0
		}
	}
	public class symbol_603 : MovieClip{ 
		public symbol_603() {
			var i1151 = new symbol_132();
			addChild(i1151);//0
		}
	}
	public class symbol_604 : MovieClip{ 
		public symbol_604() {
			var i1153 = new symbol_132();
			addChild(i1153);//0
		}
	}
	public class symbol_605 : MovieClip{ 
		public symbol_605() {
			var i1155 = new symbol_132();
			addChild(i1155);//0
		}
	}
	public class symbol_606 : MovieClip{ 
		public symbol_606() {
			var i1157 = new symbol_115();
			addChild(i1157);//0
		}
	}
	public class symbol_607 : MovieClip{ 
		public symbol_607() {
			var i1159 = new symbol_132();
			addChild(i1159);//0
		}
	}
	public class symbol_608 : MovieClip{ 
		public symbol_608() {
			var i1161 = new symbol_132();
			addChild(i1161);//0
		}
	}
	public class symbol_609 : MovieClip{ 
		public symbol_609() {
			var i1163 = new symbol_132();
			addChild(i1163);//0
		}
	}
	public class symbol_61 : Shape{ 
		public symbol_61() {
			setGraphics("5c2282542f86099881853afacd431545", -10.35, -6.1, 20.75, 12.25, 1, 1);
		}
	}
	public class symbol_610 : MovieClip{ 
		public symbol_610() {
			var i1165 = new symbol_132();
			addChild(i1165);//0
		}
	}
	public class symbol_611 : MovieClip{ 
		public symbol_611() {
			var i1167 = new symbol_132();
			addChild(i1167);//0
		}
	}
	public class symbol_612 : MovieClip{ 
		public symbol_612() {
			var i1169 = new symbol_115();
			addChild(i1169);//0
		}
	}
	public class symbol_613 : MovieClip{ 
		public symbol_613() {
			var i1171 = new symbol_132();
			addChild(i1171);//0
		}
	}
	public class symbol_614 : MovieClip{ 
		public symbol_614() {
			var i1173 = new symbol_132();
			addChild(i1173);//0
		}
	}
	public class symbol_615 : MovieClip{ 
		public symbol_615() {
			var i1175 = new symbol_132();
			addChild(i1175);//0
		}
	}
	public class symbol_616 : MovieClip{ 
		public symbol_616() {
			var i1177 = new symbol_132();
			addChild(i1177);//0
		}
	}
	public class symbol_617 : MovieClip{ 
		public symbol_617() {
			var i1179 = new symbol_115();
			addChild(i1179);//0
		}
	}
	public class symbol_618 : MovieClip{ 
		public symbol_618() {
			var i1181 = new symbol_132();
			addChild(i1181);//0
		}
	}
	public class symbol_619 : MovieClip{ 
		public symbol_619() {
			var i1183 = new symbol_132();
			addChild(i1183);//0
		}
	}
	public class symbol_62 : MovieClip{ 
		public symbol_62() {
			var i142 = new symbol_61();
			addChild(i142);//0
		}
	}
	public class symbol_620 : MovieClip{ 
		public symbol_620() {
			var i1185 = new symbol_132();
			addChild(i1185);//0
		}
	}
	public class symbol_621 : MovieClip{ 
		public symbol_621() {
			var i1187 = new symbol_115();
			addChild(i1187);//0
		}
	}
	public class symbol_622 : MovieClip{ 
		public symbol_622() {
			var i1189 = new symbol_132();
			addChild(i1189);//0
		}
	}
	public class symbol_623 : MovieClip{ 
		public symbol_623() {
			var i1191 = new symbol_132();
			addChild(i1191);//0
		}
	}
	public class symbol_624 : MovieClip{ 
		public symbol_624() {
			var i1193 = new symbol_132();
			addChild(i1193);//0
		}
	}
	public class symbol_625 : MovieClip{ 
		public symbol_625() {
			var i1195 = new symbol_115();
			addChild(i1195);//0
		}
	}
	public class symbol_626 : MovieClip{ 
		public symbol_626() {
			var i1197 = new symbol_132();
			addChild(i1197);//0
		}
	}
	public class symbol_627 : MovieClip{ 
		public symbol_627() {
			var i1199 = new symbol_132();
			addChild(i1199);//0
		}
	}
	public class symbol_628 : MovieClip{ 
		public symbol_628() {
			var i1201 = new symbol_132();
			addChild(i1201);//0
		}
	}
	public class symbol_629 : Shape{ 
		public symbol_629() {
			setGraphics("cd598a0f141466f129ba7cc3b0b9e14d", -56.6, -425.85, 76.75, 124.85000000000002, 1, 1);
		}
	}
	public class symbol_63 : Shape{ 
		public symbol_63() {
			setGraphics("cd8929b336f096b461ddb3fb4cc8a8e3", -81.85, -203.15, 201.85, 203.65, 1, 1);
		}
	}
	public class symbol_630 : MovieClip{ 
		public symbol_630() {
			var i1204 = new symbol_132();
			addChild(i1204);//0
		}
	}
	public class symbol_631 : MovieClip{ 
		public symbol_631() {
			var i1206 = new symbol_132();
			addChild(i1206);//0
		}
	}
	public class symbol_632 : Shape{ 
		public symbol_632() {
			setGraphics("a876623c271c8e4976b34b34e0e3a957", -135.8, -201.6, 252.20000000000002, 287.55, 1, 1);
		}
	}
	public class symbol_633 : MovieClip{ 
		public symbol_633() {
			var i1103 = new symbol_294();
			addChild(i1103);//0
			var i1104 = new symbol_581(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1104);//1
			var i1106 = new symbol_582(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1106);//2
			var i1108 = new symbol_583(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1108);//3
			var i1110 = new symbol_434();
			addChild(i1110);//4
			var i1111 = new symbol_584(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i1111);//5
			var i1113 = new symbol_585(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i1113);//6
			var i1115 = new symbol_483();
			addChild(i1115);//7
			var i1116 = new symbol_586(){x = 135.9 , scaleX = 1 , y = -331.8 , scaleY = 1 , rotation = 48};
			addChild(i1116);//8
			var i1118 = new symbol_587(){x = 207.3 , scaleX = 1 , y = -329.6 , scaleY = 1 , rotation = 18};
			addChild(i1118);//9
			var i1120 = new symbol_588(){x = 220.8 , scaleX = 0.89 , y = -369.8 , scaleY = 0.77 , rotation = 68};
			addChild(i1120);//10
			var i1122 = new symbol_589();
			addChild(i1122);//11
			var i1123 = new symbol_590(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i1123);//12
			var i1125 = new symbol_392();
			addChild(i1125);//13
			var i1126 = new symbol_591(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i1126);//14
			var i1128 = new symbol_394();
			addChild(i1128);//15
			var i1129 = new symbol_592(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i1129);//16
			var i1131 = new symbol_593(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i1131);//17
			var i1133 = new symbol_594(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i1133);//18
			var i1135 = new symbol_595();
			addChild(i1135);//19
			var i1136 = new symbol_596(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i1136);//20
			var i1138 = new symbol_597(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i1138);//21
			var i1140 = new symbol_598(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i1140);//22
			var i1142 = new symbol_599(){x = 90.7 , scaleX = 0.79 , y = -419.6 , scaleY = 0.79 , rotation = 13};
			addChild(i1142);//23
			var i1144 = new symbol_600(){x = 101.2 , scaleX = 1 , y = -420.1 , scaleY = 1 , rotation = 53};
			addChild(i1144);//24
			var i1146 = new symbol_601(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i1146);//25
			var i1148 = new symbol_602(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i1148);//26
			var i1150 = new symbol_603(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i1150);//27
			var i1152 = new symbol_604(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i1152);//28
			var i1154 = new symbol_605(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i1154);//29
			var i1156 = new symbol_606(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1156);//30
			var i1158 = new symbol_607(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1158);//31
			var i1160 = new symbol_608(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i1160);//32
			var i1162 = new symbol_609(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i1162);//33
			var i1164 = new symbol_610(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i1164);//34
			var i1166 = new symbol_611(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i1166);//35
			var i1168 = new symbol_612(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i1168);//36
			var i1170 = new symbol_613(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i1170);//37
			var i1172 = new symbol_614(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i1172);//38
			var i1174 = new symbol_615(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i1174);//39
			var i1176 = new symbol_616(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i1176);//40
			var i1178 = new symbol_617(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i1178);//41
			var i1180 = new symbol_618(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i1180);//42
			var i1182 = new symbol_619(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i1182);//43
			var i1184 = new symbol_620(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i1184);//44
			var i1186 = new symbol_621(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i1186);//45
			var i1188 = new symbol_622(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i1188);//46
			var i1190 = new symbol_623(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i1190);//47
			var i1192 = new symbol_624(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i1192);//48
			var i1194 = new symbol_625(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i1194);//49
			var i1196 = new symbol_626(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i1196);//50
			var i1198 = new symbol_627(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i1198);//51
			var i1200 = new symbol_628(){x = 135.3 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 108};
			addChild(i1200);//52
			var i1202 = new symbol_629();
			addChild(i1202);//53
			var i1203 = new symbol_630(){x = -57.7 , scaleX = 1 , y = -410.7 , scaleY = 1 , rotation = 19};
			addChild(i1203);//54
			var i1205 = new symbol_631(){x = -48 , scaleX = 0.76 , y = -410.6 , scaleY = 0.76 , rotation = 55};
			addChild(i1205);//55
			var i1207 = new symbol_632();
			addChild(i1207);//56
		}
	}
	public class symbol_634 : MovieClip{ 
		public symbol_634() {
			var i1208 = new symbol_33();
			addChild(i1208);//0
		}
	}
	public class symbol_635 : Shape{ 
		public symbol_635() {
			setGraphics("15b7e623350c26539075eefc1331fa29", 158, -54, 81.19999999999999, 41.4, 1, 1);
		}
	}
	public class symbol_636 : MovieClip{ 
		public symbol_636() {
			var i1213 = new symbol_115();
			addChild(i1213);//0
		}
	}
	public class symbol_637 : MovieClip{ 
		public symbol_637() {
			var i1215 = new symbol_115();
			addChild(i1215);//0
		}
	}
	public class symbol_638 : MovieClip{ 
		public symbol_638() {
			var i1217 = new symbol_115();
			addChild(i1217);//0
		}
	}
	public class symbol_639 : MovieClip{ 
		public symbol_639() {
			var i1220 = new symbol_132();
			addChild(i1220);//0
		}
	}
	public class symbol_64 : MovieClip{ 
		public symbol_64() {
			var i145 = new symbol_20();
			addChild(i145);//0
		}
	}
	public class symbol_640 : MovieClip{ 
		public symbol_640() {
			var i1222 = new symbol_132();
			addChild(i1222);//0
		}
	}
	public class symbol_641 : MovieClip{ 
		public symbol_641() {
			var i1225 = new symbol_115();
			addChild(i1225);//0
		}
	}
	public class symbol_642 : MovieClip{ 
		public symbol_642() {
			var i1227 = new symbol_115();
			addChild(i1227);//0
		}
	}
	public class symbol_643 : MovieClip{ 
		public symbol_643() {
			var i1229 = new symbol_132();
			addChild(i1229);//0
		}
	}
	public class symbol_644 : MovieClip{ 
		public symbol_644() {
			var i1231 = new symbol_115();
			addChild(i1231);//0
		}
	}
	public class symbol_645 : Shape{ 
		public symbol_645() {
			setGraphics("76228eac0fc10ee2dcb374935a2126e9", -26.5, -449.05, 249, 449.1, 1, 1);
		}
	}
	public class symbol_646 : MovieClip{ 
		public symbol_646() {
			var i1234 = new symbol_115();
			addChild(i1234);//0
		}
	}
	public class symbol_647 : MovieClip{ 
		public symbol_647() {
			var i1237 = new symbol_132();
			addChild(i1237);//0
		}
	}
	public class symbol_648 : MovieClip{ 
		public symbol_648() {
			var i1240 = new symbol_115();
			addChild(i1240);//0
		}
	}
	public class symbol_649 : MovieClip{ 
		public symbol_649() {
			var i1242 = new symbol_115();
			addChild(i1242);//0
		}
	}
	public class symbol_65 : MovieClip{ 
		public symbol_65() {
			var i147 = new symbol_20();
			addChild(i147);//0
		}
	}
	public class symbol_650 : MovieClip{ 
		public symbol_650() {
			var i1244 = new symbol_115();
			addChild(i1244);//0
		}
	}
	public class symbol_651 : Shape{ 
		public symbol_651() {
			setGraphics("369890d5e8d8f66b39a52c6dff1018a7", -135.8, -214.7, 455.5, 286.25, 1, 1);
		}
	}
	public class symbol_652 : MovieClip{ 
		public symbol_652() {
			var i1247 = new symbol_115();
			addChild(i1247);//0
		}
	}
	public class symbol_653 : MovieClip{ 
		public symbol_653() {
			var i1249 = new symbol_132();
			addChild(i1249);//0
		}
	}
	public class symbol_654 : MovieClip{ 
		public symbol_654() {
			var i1251 = new symbol_132();
			addChild(i1251);//0
		}
	}
	public class symbol_655 : MovieClip{ 
		public symbol_655() {
			var i1253 = new symbol_132();
			addChild(i1253);//0
		}
	}
	public class symbol_656 : MovieClip{ 
		public symbol_656() {
			var i1255 = new symbol_132();
			addChild(i1255);//0
		}
	}
	public class symbol_657 : MovieClip{ 
		public symbol_657() {
			var i1257 = new symbol_115();
			addChild(i1257);//0
		}
	}
	public class symbol_658 : MovieClip{ 
		public symbol_658() {
			var i1259 = new symbol_115();
			addChild(i1259);//0
		}
	}
	public class symbol_659 : MovieClip{ 
		public symbol_659() {
			var i1261 = new symbol_132();
			addChild(i1261);//0
		}
	}
	public class symbol_66 : MovieClip{ 
		public symbol_66() {
			var i149 = new symbol_20();
			addChild(i149);//0
		}
	}
	public class symbol_660 : MovieClip{ 
		public symbol_660() {
			var i1263 = new symbol_132();
			addChild(i1263);//0
		}
	}
	public class symbol_661 : MovieClip{ 
		public symbol_661() {
			var i1265 = new symbol_132();
			addChild(i1265);//0
		}
	}
	public class symbol_662 : MovieClip{ 
		public symbol_662() {
			var i1267 = new symbol_115();
			addChild(i1267);//0
		}
	}
	public class symbol_663 : MovieClip{ 
		public symbol_663() {
			var i1269 = new symbol_132();
			addChild(i1269);//0
		}
	}
	public class symbol_664 : MovieClip{ 
		public symbol_664() {
			var i1271 = new symbol_132();
			addChild(i1271);//0
		}
	}
	public class symbol_665 : MovieClip{ 
		public symbol_665() {
			var i1273 = new symbol_132();
			addChild(i1273);//0
		}
	}
	public class symbol_666 : MovieClip{ 
		public symbol_666() {
			var i1275 = new symbol_132();
			addChild(i1275);//0
		}
	}
	public class symbol_667 : MovieClip{ 
		public symbol_667() {
			var i1277 = new symbol_132();
			addChild(i1277);//0
		}
	}
	public class symbol_668 : MovieClip{ 
		public symbol_668() {
			var i1279 = new symbol_115();
			addChild(i1279);//0
		}
	}
	public class symbol_669 : MovieClip{ 
		public symbol_669() {
			var i1281 = new symbol_132();
			addChild(i1281);//0
		}
	}
	public class symbol_67 : MovieClip{ 
		public symbol_67() {
			var i151 = new symbol_20();
			addChild(i151);//0
		}
	}
	public class symbol_670 : MovieClip{ 
		public symbol_670() {
			var i1283 = new symbol_132();
			addChild(i1283);//0
		}
	}
	public class symbol_671 : MovieClip{ 
		public symbol_671() {
			var i1285 = new symbol_132();
			addChild(i1285);//0
		}
	}
	public class symbol_672 : MovieClip{ 
		public symbol_672() {
			var i1287 = new symbol_132();
			addChild(i1287);//0
		}
	}
	public class symbol_673 : MovieClip{ 
		public symbol_673() {
			var i1289 = new symbol_115();
			addChild(i1289);//0
		}
	}
	public class symbol_674 : MovieClip{ 
		public symbol_674() {
			var i1291 = new symbol_132();
			addChild(i1291);//0
		}
	}
	public class symbol_675 : MovieClip{ 
		public symbol_675() {
			var i1293 = new symbol_132();
			addChild(i1293);//0
		}
	}
	public class symbol_676 : MovieClip{ 
		public symbol_676() {
			var i1295 = new symbol_132();
			addChild(i1295);//0
		}
	}
	public class symbol_677 : MovieClip{ 
		public symbol_677() {
			var i1297 = new symbol_115();
			addChild(i1297);//0
		}
	}
	public class symbol_678 : MovieClip{ 
		public symbol_678() {
			var i1299 = new symbol_132();
			addChild(i1299);//0
		}
	}
	public class symbol_679 : MovieClip{ 
		public symbol_679() {
			var i1301 = new symbol_132();
			addChild(i1301);//0
		}
	}
	public class symbol_68 : MovieClip{ 
		public symbol_68() {
			var i153 = new symbol_20();
			addChild(i153);//0
		}
	}
	public class symbol_680 : MovieClip{ 
		public symbol_680() {
			var i1303 = new symbol_132();
			addChild(i1303);//0
		}
	}
	public class symbol_681 : MovieClip{ 
		public symbol_681() {
			var i1305 = new symbol_115();
			addChild(i1305);//0
		}
	}
	public class symbol_682 : MovieClip{ 
		public symbol_682() {
			var i1307 = new symbol_132();
			addChild(i1307);//0
		}
	}
	public class symbol_683 : MovieClip{ 
		public symbol_683() {
			var i1309 = new symbol_132();
			addChild(i1309);//0
		}
	}
	public class symbol_684 : MovieClip{ 
		public symbol_684() {
			var i1311 = new symbol_132();
			addChild(i1311);//0
		}
	}
	public class symbol_685 : MovieClip{ 
		public symbol_685() {
			var i1313 = new symbol_132();
			addChild(i1313);//0
		}
	}
	public class symbol_686 : MovieClip{ 
		public symbol_686() {
			var i1315 = new symbol_132();
			addChild(i1315);//0
		}
	}
	public class symbol_687 : Shape{ 
		public symbol_687() {
			setGraphics("c48ec9de6632c79d0f63c8d6af4ad30b", -70.15, -465.1, 96.05000000000001, 165.10000000000002, 1, 1);
		}
	}
	public class symbol_688 : MovieClip{ 
		public symbol_688() {
			var i1318 = new symbol_132();
			addChild(i1318);//0
		}
	}
	public class symbol_689 : Shape{ 
		public symbol_689() {
			setGraphics("76c79ec6225c14ef66aea5852f769e19", -15.5, -201.6, 131.9, 287.55, 1, 1);
		}
	}
	public class symbol_69 : MovieClip{ 
		public symbol_69() {
			var i155 = new symbol_20();
			addChild(i155);//0
		}
	}
	public class symbol_690 : MovieClip{ 
		public symbol_690() {
			var i1211 = new symbol_294();
			addChild(i1211);//0
			var i1212 = new symbol_636(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1212);//1
			var i1214 = new symbol_637(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1214);//2
			var i1216 = new symbol_638(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1216);//3
			var i1218 = new symbol_434();
			addChild(i1218);//4
			var i1219 = new symbol_639(){x = -216.3 , scaleX = 1 , y = -281.7 , scaleY = 1 , rotation = 4};
			addChild(i1219);//5
			var i1221 = new symbol_640(){x = -217.6 , scaleX = 0.84 , y = -269.6 , scaleY = 0.84 , rotation = -34};
			addChild(i1221);//6
			var i1223 = new symbol_483();
			addChild(i1223);//7
			var i1224 = new symbol_641(){x = 135.9 , scaleX = 1 , y = -331.8 , scaleY = 1 , rotation = 48};
			addChild(i1224);//8
			var i1226 = new symbol_642(){x = 207.3 , scaleX = 1 , y = -329.6 , scaleY = 1 , rotation = 18};
			addChild(i1226);//9
			var i1228 = new symbol_643(){x = 220.8 , scaleX = 0.89 , y = -369.8 , scaleY = 0.77 , rotation = 68};
			addChild(i1228);//10
			var i1230 = new symbol_644(){x = 88.5 , scaleX = 1 , y = -402.1 , scaleY = 1 , rotation = -97};
			addChild(i1230);//11
			var i1232 = new symbol_645();
			addChild(i1232);//12
			var i1233 = new symbol_646(){x = 288.1 , scaleX = 1 , y = -199.3 , scaleY = 1 , rotation = 13};
			addChild(i1233);//13
			var i1235 = new symbol_392();
			addChild(i1235);//14
			var i1236 = new symbol_647(){x = 295.4 , scaleX = 1 , y = -224.7 , scaleY = 1 , rotation = 88};
			addChild(i1236);//15
			var i1238 = new symbol_440();
			addChild(i1238);//16
			var i1239 = new symbol_648(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i1239);//17
			var i1241 = new symbol_649(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i1241);//18
			var i1243 = new symbol_650(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i1243);//19
			var i1245 = new symbol_651();
			addChild(i1245);//20
			var i1246 = new symbol_652(){x = -95.7 , scaleX = 1 , y = -366.4 , scaleY = 1 , rotation = -92};
			addChild(i1246);//21
			var i1248 = new symbol_653(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i1248);//22
			var i1250 = new symbol_654(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i1250);//23
			var i1252 = new symbol_655(){x = 73.1 , scaleX = 0.79 , y = -454.3 , scaleY = 0.79 , rotation = -1};
			addChild(i1252);//24
			var i1254 = new symbol_656(){x = 110.3 , scaleX = 1 , y = -378.8 , scaleY = 1 , rotation = 83};
			addChild(i1254);//25
			var i1256 = new symbol_657(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i1256);//26
			var i1258 = new symbol_658(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i1258);//27
			var i1260 = new symbol_659(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i1260);//28
			var i1262 = new symbol_660(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i1262);//29
			var i1264 = new symbol_661(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i1264);//30
			var i1266 = new symbol_662(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1266);//31
			var i1268 = new symbol_663(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1268);//32
			var i1270 = new symbol_664(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i1270);//33
			var i1272 = new symbol_665(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i1272);//34
			var i1274 = new symbol_666(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i1274);//35
			var i1276 = new symbol_667(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i1276);//36
			var i1278 = new symbol_668(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i1278);//37
			var i1280 = new symbol_669(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i1280);//38
			var i1282 = new symbol_670(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i1282);//39
			var i1284 = new symbol_671(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i1284);//40
			var i1286 = new symbol_672(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i1286);//41
			var i1288 = new symbol_673(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i1288);//42
			var i1290 = new symbol_674(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i1290);//43
			var i1292 = new symbol_675(){x = -85.7 , scaleX = 1 , y = -364.4 , scaleY = 1 , rotation = 54};
			addChild(i1292);//44
			var i1294 = new symbol_676(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i1294);//45
			var i1296 = new symbol_677(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i1296);//46
			var i1298 = new symbol_678(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i1298);//47
			var i1300 = new symbol_679(){x = 29.3 , scaleX = 1 , y = -341.9 , scaleY = 1 , rotation = 49};
			addChild(i1300);//48
			var i1302 = new symbol_680(){x = 280.1 , scaleX = 1 , y = -221 , scaleY = 1 , rotation = 31};
			addChild(i1302);//49
			var i1304 = new symbol_681(){x = -161.6 , scaleX = 1 , y = -399.8 , scaleY = 1 , rotation = -127};
			addChild(i1304);//50
			var i1306 = new symbol_682(){x = -169.3 , scaleX = 1 , y = -389.7 , scaleY = 1 , rotation = -60};
			addChild(i1306);//51
			var i1308 = new symbol_683(){x = -170.3 , scaleX = 1 , y = -347.5 , scaleY = 1 , rotation = -27};
			addChild(i1308);//52
			var i1310 = new symbol_684(){x = 135.3 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 108};
			addChild(i1310);//53
			var i1312 = new symbol_685(){x = -71.2 , scaleX = 1 , y = -450.4 , scaleY = 1 , rotation = 19};
			addChild(i1312);//54
			var i1314 = new symbol_686(){x = -61.5 , scaleX = 0.76 , y = -450.3 , scaleY = 0.76 , rotation = 55};
			addChild(i1314);//55
			var i1316 = new symbol_687();
			addChild(i1316);//56
			var i1317 = new symbol_688(){x = -3.3 , scaleX = 0.76 , y = -468.3 , scaleY = 0.76 , rotation = 103};
			addChild(i1317);//57
			var i1319 = new symbol_689();
			addChild(i1319);//58
		}
	}
	public class symbol_691 : MovieClip{ 
		public symbol_691() {
			var i1320 = new symbol_33();
			addChild(i1320);//0
		}
	}
	public class symbol_692 : Shape{ 
		public symbol_692() {
			setGraphics("db4a57fb75c83e033e3e35ef43649cc9", 59.1, -55.05, 270.7, 53.449999999999996, 1, 1);
		}
	}
	public class symbol_693 : MovieClip{ 
		public symbol_693() {
			var i1322 = new symbol_33();
			addChild(i1322);//0
		}
	}
	public class symbol_694 : Shape{ 
		public symbol_694() {
			setGraphics("9d1150bbf4d90781e7f8f03b610b401b", 59.1, -95.9, 312.45, 96.30000000000001, 1, 1);
		}
	}
	public class symbol_695 : MovieClip{ 
		public symbol_695() {
			var i1324 = new symbol_33();
			addChild(i1324);//0
		}
	}
	public class symbol_696 : Shape{ 
		public symbol_696() {
			setGraphics("afa33cbf39af9881a6bdd7091f275838", 59.1, -95.9, 312.45, 94.30000000000001, 1, 1);
		}
	}
	public class symbol_697 : MovieClip{ 
		public symbol_697() {
			var i1326 = new symbol_33();
			addChild(i1326);//0
		}
	}
	public class symbol_698 : Shape{ 
		public symbol_698() {
			setGraphics("af05cc75f7be48b5a2703a39f23f7922", -180.9, -8.4, 312.45000000000005, 111.30000000000001, 1, 1);
		}
	}
	public class symbol_699 : MovieClip{ 
		public symbol_699() {
			var i1328 = new symbol_33();
			addChild(i1328);//0
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("42d4aef996fa9fa2be932496303c168a", -20, -52.85, 40, 72.7, 1, 1);
		}
	}
	public class symbol_70 : MovieClip{ 
		public symbol_70() {
			var i157 = new symbol_20();
			addChild(i157);//0
		}
	}
	public class symbol_700 : Shape{ 
		public symbol_700() {
			setGraphics("15380bfae905c287123a0a4fb15b91c1", 187.5, -52.45, 48.19999999999999, 30.650000000000002, 1, 1);
		}
	}
	public class symbol_701 : MovieClip{ 
		public symbol_701() {
			var i1330 = new symbol_33();
			addChild(i1330);//0
		}
	}
	public class symbol_702 : MovieClip{ 
		public symbol_702() {
			var i1331 = new symbol_33();
			addChild(i1331);//0
		}
	}
	public class symbol_703 : Shape{ 
		public symbol_703() {
			setGraphics("25b4eb5a81be7cac4940c44ff5f36024", 153.35, -50.45, 42.75, 30.550000000000004, 1, 1);
		}
	}
	public class symbol_704 : MovieClip{ 
		public symbol_704() {
			var i1333 = new symbol_33();
			addChild(i1333);//0
		}
	}
	public class symbol_705 : MovieClip{ 
		public symbol_705() {
			var i1334 = new symbol_33();
			addChild(i1334);//0
		}
	}
	public class symbol_706 : MovieClip{ 
		public symbol_706() {
			var i1337 = new symbol_13();
			addChild(i1337);//0
		}
	}
	public class symbol_707 : MovieClip{ 
		public symbol_707() {
			var i1339 = new symbol_15();
			addChild(i1339);//0
		}
	}
	public class symbol_708 : MovieClip{ 
		public symbol_708() {
			var i1341 = new symbol_17();
			addChild(i1341);//0
		}
	}
	public class symbol_709 : MovieClip{ 
		public symbol_709() {
			var i1345 = new symbol_132();
			addChild(i1345);//0
		}
	}
	public class symbol_71 : MovieClip{ 
		public symbol_71() {
			var i159 = new symbol_20();
			addChild(i159);//0
		}
	}
	public class symbol_710 : MovieClip{ 
		public symbol_710() {
			var i1347 = new symbol_132();
			addChild(i1347);//0
		}
	}
	public class symbol_711 : MovieClip{ 
		public symbol_711() {
			var i1343 = new symbol_19();
			addChild(i1343);//0
			var i1344 = new symbol_709(){y = -83.4 , x = 1.6};
			addChild(i1344);//1
			var i1346 = new symbol_710(){x = 21.7 , scaleX = 1 , y = -98.8 , scaleY = 1 , rotation = 83};
			addChild(i1346);//2
		}
	}
	public class symbol_712 : Shape{ 
		public symbol_712() {
			setGraphics("cb11bdd0703d95cae03d2dc9ca85015c", 56.6, 14.75, 55.949999999999996, 32.4, 1, 1);
		}
	}
	public class symbol_713 : MovieClip{ 
		public symbol_713() {
			var i1351 = new symbol_115();
			addChild(i1351);//0
		}
	}
	public class symbol_714 : MovieClip{ 
		public symbol_714() {
			var i1354 = new symbol_132();
			addChild(i1354);//0
		}
	}
	public class symbol_715 : MovieClip{ 
		public symbol_715() {
			var i1356 = new symbol_132();
			addChild(i1356);//0
		}
	}
	public class symbol_716 : MovieClip{ 
		public symbol_716() {
			var i1358 = new symbol_132();
			addChild(i1358);//0
		}
	}
	public class symbol_717 : MovieClip{ 
		public symbol_717() {
			var i1360 = new symbol_132();
			addChild(i1360);//0
		}
	}
	public class symbol_718 : MovieClip{ 
		public symbol_718() {
			var i1350 = new symbol_713(){x = 36.1 , scaleX = 1 , y = -88.8 , scaleY = 1 , rotation = 14};
			addChild(i1350);//0
			var i1352 = new symbol_27();
			addChild(i1352);//1
			var i1353 = new symbol_714(){y = -141.4 , x = 0.3};
			addChild(i1353);//2
			var i1355 = new symbol_715(){x = 19.8 , scaleX = 1 , y = -150.9 , scaleY = 1 , rotation = 85};
			addChild(i1355);//3
			var i1357 = new symbol_716(){x = 31.8 , scaleX = 1 , y = -105 , scaleY = 1 , rotation = 57};
			addChild(i1357);//4
			var i1359 = new symbol_717(){x = 64 , scaleX = 1 , y = -109.5 , scaleY = 1 , rotation = 118};
			addChild(i1359);//5
		}
	}
	public class symbol_719 : MovieClip{ 
		public symbol_719() {
			var i1361 = new symbol_33();
			addChild(i1361);//0
		}
	}
	public class symbol_72 : MovieClip{ 
		public symbol_72() {
			var i161 = new symbol_20();
			addChild(i161);//0
		}
	}
	public class symbol_720 : MovieClip{ 
		public symbol_720() {
			var i1364 = new symbol_115();
			addChild(i1364);//0
		}
	}
	public class symbol_721 : MovieClip{ 
		public symbol_721() {
			var i1367 = new symbol_132();
			addChild(i1367);//0
		}
	}
	public class symbol_722 : MovieClip{ 
		public symbol_722() {
			var i1369 = new symbol_132();
			addChild(i1369);//0
		}
	}
	public class symbol_723 : MovieClip{ 
		public symbol_723() {
			var i1371 = new symbol_132();
			addChild(i1371);//0
		}
	}
	public class symbol_724 : MovieClip{ 
		public symbol_724() {
			var i1373 = new symbol_132();
			addChild(i1373);//0
		}
	}
	public class symbol_725 : MovieClip{ 
		public symbol_725() {
			var i1375 = new symbol_132();
			addChild(i1375);//0
		}
	}
	public class symbol_726 : MovieClip{ 
		public symbol_726() {
			var i1377 = new symbol_132();
			addChild(i1377);//0
		}
	}
	public class symbol_727 : MovieClip{ 
		public symbol_727() {
			var i1363 = new symbol_720(){x = 64.8 , scaleX = 1 , y = -110.5 , scaleY = 1 , rotation = 11};
			addChild(i1363);//0
			var i1365 = new symbol_36();
			addChild(i1365);//1
			var i1366 = new symbol_721(){x = -8.2 , scaleX = 1 , y = -161.3 , scaleY = 1 , rotation = 3};
			addChild(i1366);//2
			var i1368 = new symbol_722(){x = 15.1 , scaleX = 1 , y = -174.2 , scaleY = 1 , rotation = 87};
			addChild(i1368);//3
			var i1370 = new symbol_723(){x = -54.6 , scaleX = 1 , y = -127.3 , scaleY = 1 , rotation = -53};
			addChild(i1370);//4
			var i1372 = new symbol_724(){x = -31.7 , scaleX = 1 , y = -132.1 , scaleY = 1 , rotation = 10};
			addChild(i1372);//5
			var i1374 = new symbol_725(){x = 73.8 , scaleX = 1 , y = -137.8 , scaleY = 1 , rotation = 73};
			addChild(i1374);//6
			var i1376 = new symbol_726(){x = 111.3 , scaleX = 1 , y = -122.7 , scaleY = 1 , rotation = 130};
			addChild(i1376);//7
		}
	}
	public class symbol_728 : Shape{ 
		public symbol_728() {
			setGraphics("de529bdd9a8cc2e467be3a9896ad288b", 54.35, 3.25, 57.9, 43.9, 1, 1);
		}
	}
	public class symbol_729 : MovieClip{ 
		public symbol_729() {
			var i1381 = new symbol_115();
			addChild(i1381);//0
		}
	}
	public class symbol_73 : MovieClip{ 
		public symbol_73() {
			var i138 = new symbol_58(){y = -1.3 , x = 0.3};
			addChild(i138);//0
			var i139 = new symbol_60(){x = 69.8 , scaleX = 1 , y = -109.5 , scaleY = 1 , rotation = 17};
			addChild(i139);//1
			var i141 = new symbol_62(){x = -51 , scaleX = 1 , y = -108.1 , scaleY = 1 , rotation = 147};
			addChild(i141);//2
			var i143 = new symbol_63();
			addChild(i143);//3
			var i144 = new symbol_64(){x = 76.6 , scaleX = 1 , y = -138.3 , scaleY = 1 , rotation = 74};
			addChild(i144);//4
			var i146 = new symbol_65(){x = 124.1 , scaleX = 1 , y = -133 , scaleY = 1 , rotation = 97};
			addChild(i146);//5
			var i148 = new symbol_66(){x = 118.8 , scaleX = 1 , y = -118.1 , scaleY = 1 , rotation = 164};
			addChild(i148);//6
			var i150 = new symbol_67(){x = 17.4 , scaleX = 1 , y = -202.9 , scaleY = 1 , rotation = 84};
			addChild(i150);//7
			var i152 = new symbol_68(){x = -10 , scaleX = 1 , y = -169.5 , scaleY = 1 , rotation = 3};
			addChild(i152);//8
			var i154 = new symbol_69(){x = 2.3 , scaleX = 1 , y = -211.7 , scaleY = 1 , rotation = 12};
			addChild(i154);//9
			var i156 = new symbol_70(){x = -78 , scaleX = 1 , y = -158.9 , scaleY = 1 , rotation = 33};
			addChild(i156);//10
			var i158 = new symbol_71(){x = -82.8 , scaleX = 1 , y = -138.1 , scaleY = 1 , rotation = -62};
			addChild(i158);//11
			var i160 = new symbol_72(){x = -80.1 , scaleX = 1 , y = -116.4 , scaleY = 1 , rotation = 60};
			addChild(i160);//12
		}
	}
	public class symbol_730 : MovieClip{ 
		public symbol_730() {
			var i1383 = new symbol_115();
			addChild(i1383);//0
		}
	}
	public class symbol_731 : MovieClip{ 
		public symbol_731() {
			var i1386 = new symbol_132();
			addChild(i1386);//0
		}
	}
	public class symbol_732 : MovieClip{ 
		public symbol_732() {
			var i1388 = new symbol_132();
			addChild(i1388);//0
		}
	}
	public class symbol_733 : MovieClip{ 
		public symbol_733() {
			var i1390 = new symbol_132();
			addChild(i1390);//0
		}
	}
	public class symbol_734 : MovieClip{ 
		public symbol_734() {
			var i1392 = new symbol_132();
			addChild(i1392);//0
		}
	}
	public class symbol_735 : MovieClip{ 
		public symbol_735() {
			var i1394 = new symbol_132();
			addChild(i1394);//0
		}
	}
	public class symbol_736 : MovieClip{ 
		public symbol_736() {
			var i1396 = new symbol_132();
			addChild(i1396);//0
		}
	}
	public class symbol_737 : MovieClip{ 
		public symbol_737() {
			var i1398 = new symbol_132();
			addChild(i1398);//0
		}
	}
	public class symbol_738 : MovieClip{ 
		public symbol_738() {
			var i1400 = new symbol_132();
			addChild(i1400);//0
		}
	}
	public class symbol_739 : MovieClip{ 
		public symbol_739() {
			var i1380 = new symbol_729(){x = -51.6 , scaleX = 1 , y = -108.8 , scaleY = 1 , rotation = 149};
			addChild(i1380);//0
			var i1382 = new symbol_730(){x = 69.3 , scaleX = 1 , y = -109.3 , scaleY = 1 , rotation = -14};
			addChild(i1382);//1
			var i1384 = new symbol_47();
			addChild(i1384);//2
			var i1385 = new symbol_731(){x = 123.5 , scaleX = 1 , y = -133.8 , scaleY = 1 , rotation = 91};
			addChild(i1385);//3
			var i1387 = new symbol_732(){x = 75 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = 72};
			addChild(i1387);//4
			var i1389 = new symbol_733(){x = 15.5 , scaleX = 1 , y = -183.8 , scaleY = 1 , rotation = 93};
			addChild(i1389);//5
			var i1391 = new symbol_734(){x = -12.3 , scaleX = 1 , y = -166.1 , scaleY = 1 , rotation = 1};
			addChild(i1391);//6
			var i1393 = new symbol_735(){x = -77.9 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = 31};
			addChild(i1393);//7
			var i1395 = new symbol_736(){x = -81.2 , scaleX = 1 , y = -138.2 , scaleY = 1 , rotation = -62};
			addChild(i1395);//8
			var i1397 = new symbol_737(){x = -80.5 , scaleX = 1 , y = -115.8 , scaleY = 1 , rotation = 54};
			addChild(i1397);//9
			var i1399 = new symbol_738(){x = 118.8 , scaleX = 1 , y = -118.2 , scaleY = 1 , rotation = 161};
			addChild(i1399);//10
		}
	}
	public class symbol_74 : Shape{ 
		public symbol_74() {
			setGraphics("8efcabdf8b182d7049e40fc4cdad1ea7", 285.6, -120.75, 74.64999999999998, 66.15, 1, 1);
		}
	}
	public class symbol_740 : MovieClip{ 
		public symbol_740() {
			var i1401 = new symbol_33();
			addChild(i1401);//0
		}
	}
	public class symbol_741 : MovieClip{ 
		public symbol_741() {
			var i1405 = new symbol_115();
			addChild(i1405);//0
		}
	}
	public class symbol_742 : MovieClip{ 
		public symbol_742() {
			var i1407 = new symbol_115();
			addChild(i1407);//0
		}
	}
	public class symbol_743 : MovieClip{ 
		public symbol_743() {
			var i1410 = new symbol_132();
			addChild(i1410);//0
		}
	}
	public class symbol_744 : MovieClip{ 
		public symbol_744() {
			var i1412 = new symbol_132();
			addChild(i1412);//0
		}
	}
	public class symbol_745 : MovieClip{ 
		public symbol_745() {
			var i1414 = new symbol_132();
			addChild(i1414);//0
		}
	}
	public class symbol_746 : MovieClip{ 
		public symbol_746() {
			var i1416 = new symbol_132();
			addChild(i1416);//0
		}
	}
	public class symbol_747 : MovieClip{ 
		public symbol_747() {
			var i1418 = new symbol_132();
			addChild(i1418);//0
		}
	}
	public class symbol_748 : MovieClip{ 
		public symbol_748() {
			var i1420 = new symbol_132();
			addChild(i1420);//0
		}
	}
	public class symbol_749 : MovieClip{ 
		public symbol_749() {
			var i1422 = new symbol_132();
			addChild(i1422);//0
		}
	}
	public class symbol_75 : Shape{ 
		public symbol_75() {
			setGraphics("9f2f8e7934984503cf04c5038917695b", -44.6, -40.5, 89.2, 81, 1, 1);
		}
	}
	public class symbol_750 : MovieClip{ 
		public symbol_750() {
			var i1424 = new symbol_132();
			addChild(i1424);//0
		}
	}
	public class symbol_751 : MovieClip{ 
		public symbol_751() {
			var i1426 = new symbol_132();
			addChild(i1426);//0
		}
	}
	public class symbol_752 : MovieClip{ 
		public symbol_752() {
			var i1403 = new symbol_58(){y = -1.3 , x = 0.3};
			addChild(i1403);//0
			var i1404 = new symbol_741(){x = 69.8 , scaleX = 1 , y = -109.5 , scaleY = 1 , rotation = 17};
			addChild(i1404);//1
			var i1406 = new symbol_742(){x = -51 , scaleX = 1 , y = -108.1 , scaleY = 1 , rotation = 147};
			addChild(i1406);//2
			var i1408 = new symbol_63();
			addChild(i1408);//3
			var i1409 = new symbol_743(){x = 76.6 , scaleX = 1 , y = -138.3 , scaleY = 1 , rotation = 74};
			addChild(i1409);//4
			var i1411 = new symbol_744(){x = 124.1 , scaleX = 1 , y = -133 , scaleY = 1 , rotation = 97};
			addChild(i1411);//5
			var i1413 = new symbol_745(){x = 118.8 , scaleX = 1 , y = -118.1 , scaleY = 1 , rotation = 164};
			addChild(i1413);//6
			var i1415 = new symbol_746(){x = 17.4 , scaleX = 1 , y = -202.9 , scaleY = 1 , rotation = 84};
			addChild(i1415);//7
			var i1417 = new symbol_747(){x = -10 , scaleX = 1 , y = -169.5 , scaleY = 1 , rotation = 3};
			addChild(i1417);//8
			var i1419 = new symbol_748(){x = 2.3 , scaleX = 1 , y = -211.7 , scaleY = 1 , rotation = 12};
			addChild(i1419);//9
			var i1421 = new symbol_749(){x = -78 , scaleX = 1 , y = -158.9 , scaleY = 1 , rotation = 33};
			addChild(i1421);//10
			var i1423 = new symbol_750(){x = -82.8 , scaleX = 1 , y = -138.1 , scaleY = 1 , rotation = -62};
			addChild(i1423);//11
			var i1425 = new symbol_751(){x = -80.1 , scaleX = 1 , y = -116.4 , scaleY = 1 , rotation = 60};
			addChild(i1425);//12
		}
	}
	public class symbol_753 : Shape{ 
		public symbol_753() {
			setGraphics("4677a5ace54ae7271f80b9b9559c1878", 45.6, -16.75, 74.65, 66.15, 1, 1);
		}
	}
	public class symbol_754 : MovieClip{ 
		public symbol_754() {
			var i1429 = new symbol_75();
			addChild(i1429);//0
		}
	}
	public class symbol_755 : MovieClip{ 
		public symbol_755() {
			var i1432 = new symbol_115();
			addChild(i1432);//0
		}
	}
	public class symbol_756 : MovieClip{ 
		public symbol_756() {
			var i1434 = new symbol_132();
			addChild(i1434);//0
		}
	}
	public class symbol_757 : MovieClip{ 
		public symbol_757() {
			var i1436 = new symbol_115();
			addChild(i1436);//0
		}
	}
	public class symbol_758 : MovieClip{ 
		public symbol_758() {
			var i1439 = new symbol_132();
			addChild(i1439);//0
		}
	}
	public class symbol_759 : MovieClip{ 
		public symbol_759() {
			var i1441 = new symbol_132();
			addChild(i1441);//0
		}
	}
	public class symbol_76 : MovieClip{ 
		public symbol_76() {
			var i164 = new symbol_75();
			addChild(i164);//0
		}
	}
	public class symbol_760 : MovieClip{ 
		public symbol_760() {
			var i1443 = new symbol_132();
			addChild(i1443);//0
		}
	}
	public class symbol_761 : MovieClip{ 
		public symbol_761() {
			var i1445 = new symbol_132();
			addChild(i1445);//0
		}
	}
	public class symbol_762 : MovieClip{ 
		public symbol_762() {
			var i1447 = new symbol_132();
			addChild(i1447);//0
		}
	}
	public class symbol_763 : MovieClip{ 
		public symbol_763() {
			var i1449 = new symbol_132();
			addChild(i1449);//0
		}
	}
	public class symbol_764 : MovieClip{ 
		public symbol_764() {
			var i1451 = new symbol_132();
			addChild(i1451);//0
		}
	}
	public class symbol_765 : MovieClip{ 
		public symbol_765() {
			var i1453 = new symbol_132();
			addChild(i1453);//0
		}
	}
	public class symbol_766 : MovieClip{ 
		public symbol_766() {
			var i1455 = new symbol_132();
			addChild(i1455);//0
		}
	}
	public class symbol_767 : MovieClip{ 
		public symbol_767() {
			var i1457 = new symbol_132();
			addChild(i1457);//0
		}
	}
	public class symbol_768 : MovieClip{ 
		public symbol_768() {
			var i1459 = new symbol_132();
			addChild(i1459);//0
		}
	}
	public class symbol_769 : MovieClip{ 
		public symbol_769() {
			var i1461 = new symbol_132();
			addChild(i1461);//0
		}
	}
	public class symbol_77 : MovieClip{ 
		public symbol_77() {
			var i167 = new symbol_61();
			addChild(i167);//0
		}
	}
	public class symbol_770 : MovieClip{ 
		public symbol_770() {
			var i1431 = new symbol_755(){x = -51.6 , scaleX = 1 , y = -108.3 , scaleY = 1 , rotation = 109};
			addChild(i1431);//0
			var i1433 = new symbol_756(){x = 123.5 , scaleX = 1 , y = -114.7 , scaleY = 1 , rotation = 163};
			addChild(i1433);//1
			var i1435 = new symbol_757(){x = 74.2 , scaleX = 1 , y = -108.5 , scaleY = 1 , rotation = 18};
			addChild(i1435);//2
			var i1437 = new symbol_80();
			addChild(i1437);//3
			var i1438 = new symbol_758(){x = -103.5 , scaleX = 1 , y = -170.9 , scaleY = 1 , rotation = 22};
			addChild(i1438);//4
			var i1440 = new symbol_759(){x = -84 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = -72};
			addChild(i1440);//5
			var i1442 = new symbol_760(){x = -103.5 , scaleX = 1 , y = -114 , scaleY = 1 , rotation = 68};
			addChild(i1442);//6
			var i1444 = new symbol_761(){x = -96.5 , scaleX = 1 , y = -97.5 , scaleY = 1 , rotation = -2};
			addChild(i1444);//7
			var i1446 = new symbol_762(){x = 0 , scaleX = 1 , y = -216 , scaleY = 1 , rotation = 99};
			addChild(i1446);//8
			var i1448 = new symbol_763(){x = 20.1 , scaleX = 1 , y = -202.5 , scaleY = 1 , rotation = 84};
			addChild(i1448);//9
			var i1450 = new symbol_764(){x = -10 , scaleX = 1 , y = -170.2 , scaleY = 1 , rotation = 6};
			addChild(i1450);//10
			var i1452 = new symbol_765(){x = 78.2 , scaleX = 1 , y = -138.2 , scaleY = 1 , rotation = 76};
			addChild(i1452);//11
			var i1454 = new symbol_766(){x = 109.9 , scaleX = 1 , y = -153.4 , scaleY = 1 , rotation = 50};
			addChild(i1454);//12
			var i1456 = new symbol_767(){x = 131.1 , scaleX = 1 , y = -155.3 , scaleY = 1 , rotation = 109};
			addChild(i1456);//13
			var i1458 = new symbol_768(){x = 149.6 , scaleX = 1 , y = -123.6 , scaleY = 1 , rotation = 146};
			addChild(i1458);//14
			var i1460 = new symbol_769(){x = 123 , scaleX = 1 , y = -130.9 , scaleY = 1 , rotation = 103};
			addChild(i1460);//15
		}
	}
	public class symbol_771 : MovieClip{ 
		public symbol_771() {
			var i1462 = new symbol_33();
			addChild(i1462);//0
		}
	}
	public class symbol_772 : Shape{ 
		public symbol_772() {
			setGraphics("860a69cc9435adffbdcdd11bcf45d05e", -131.4, 14.75, 55.95, 32.4, 1, 1);
		}
	}
	public class symbol_773 : MovieClip{ 
		public symbol_773() {
			var i1465 = new symbol_96();
			addChild(i1465);//0
		}
	}
	public class symbol_774 : MovieClip{ 
		public symbol_774() {
			var i1467 = new symbol_98();
			addChild(i1467);//0
		}
	}
	public class symbol_775 : MovieClip{ 
		public symbol_775() {
			var i1470 = new symbol_115();
			addChild(i1470);//0
		}
	}
	public class symbol_776 : MovieClip{ 
		public symbol_776() {
			var i1473 = new symbol_132();
			addChild(i1473);//0
		}
	}
	public class symbol_777 : MovieClip{ 
		public symbol_777() {
			var i1475 = new symbol_132();
			addChild(i1475);//0
		}
	}
	public class symbol_778 : MovieClip{ 
		public symbol_778() {
			var i1477 = new symbol_115();
			addChild(i1477);//0
		}
	}
	public class symbol_779 : MovieClip{ 
		public symbol_779() {
			var i1480 = new symbol_115();
			addChild(i1480);//0
		}
	}
	public class symbol_78 : MovieClip{ 
		public symbol_78() {
			var i169 = new symbol_20();
			addChild(i169);//0
		}
	}
	public class symbol_780 : MovieClip{ 
		public symbol_780() {
			var i1482 = new symbol_115();
			addChild(i1482);//0
		}
	}
	public class symbol_781 : MovieClip{ 
		public symbol_781() {
			var i1485 = new symbol_115();
			addChild(i1485);//0
		}
	}
	public class symbol_782 : MovieClip{ 
		public symbol_782() {
			var i1488 = new symbol_115();
			addChild(i1488);//0
		}
	}
	public class symbol_783 : MovieClip{ 
		public symbol_783() {
			var i1490 = new symbol_115();
			addChild(i1490);//0
		}
	}
	public class symbol_784 : MovieClip{ 
		public symbol_784() {
			var i1493 = new symbol_115();
			addChild(i1493);//0
		}
	}
	public class symbol_785 : MovieClip{ 
		public symbol_785() {
			var i1496 = new symbol_132();
			addChild(i1496);//0
		}
	}
	public class symbol_786 : MovieClip{ 
		public symbol_786() {
			var i1498 = new symbol_132();
			addChild(i1498);//0
		}
	}
	public class symbol_787 : MovieClip{ 
		public symbol_787() {
			var i1500 = new symbol_132();
			addChild(i1500);//0
		}
	}
	public class symbol_788 : MovieClip{ 
		public symbol_788() {
			var i1502 = new symbol_132();
			addChild(i1502);//0
		}
	}
	public class symbol_789 : MovieClip{ 
		public symbol_789() {
			var i1504 = new symbol_132();
			addChild(i1504);//0
		}
	}
	public class symbol_79 : MovieClip{ 
		public symbol_79() {
			var i171 = new symbol_61();
			addChild(i171);//0
		}
	}
	public class symbol_790 : MovieClip{ 
		public symbol_790() {
			var i1506 = new symbol_115();
			addChild(i1506);//0
		}
	}
	public class symbol_791 : MovieClip{ 
		public symbol_791() {
			var i1508 = new symbol_132();
			addChild(i1508);//0
		}
	}
	public class symbol_792 : MovieClip{ 
		public symbol_792() {
			var i1510 = new symbol_132();
			addChild(i1510);//0
		}
	}
	public class symbol_793 : MovieClip{ 
		public symbol_793() {
			var i1512 = new symbol_132();
			addChild(i1512);//0
		}
	}
	public class symbol_794 : MovieClip{ 
		public symbol_794() {
			var i1514 = new symbol_132();
			addChild(i1514);//0
		}
	}
	public class symbol_795 : MovieClip{ 
		public symbol_795() {
			var i1516 = new symbol_132();
			addChild(i1516);//0
		}
	}
	public class symbol_796 : MovieClip{ 
		public symbol_796() {
			var i1469 = new symbol_775(){x = -53.9 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1469);//0
			var i1471 = new symbol_102();
			addChild(i1471);//1
			var i1472 = new symbol_776(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i1472);//2
			var i1474 = new symbol_777(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i1474);//3
			var i1476 = new symbol_778(){x = 18.8 , scaleX = 1 , y = -205.1 , scaleY = 1 , rotation = -26};
			addChild(i1476);//4
			var i1478 = new symbol_108();
			addChild(i1478);//5
			var i1479 = new symbol_779(){x = -105.6 , scaleX = 1 , y = -99.7 , scaleY = 1 , rotation = 140};
			addChild(i1479);//6
			var i1481 = new symbol_780(){x = -102.8 , scaleX = 1 , y = -137.5 , scaleY = 1 , rotation = 163};
			addChild(i1481);//7
			var i1483 = new symbol_111();
			addChild(i1483);//8
			var i1484 = new symbol_781(){x = -161.1 , scaleX = 1 , y = -170.6 , scaleY = 1 , rotation = -129};
			addChild(i1484);//9
			var i1486 = new symbol_114();
			addChild(i1486);//10
			var i1487 = new symbol_782(){x = 86.2 , scaleX = 1 , y = -118.3 , scaleY = 1 , rotation = 32};
			addChild(i1487);//11
			var i1489 = new symbol_783(){x = 147.4 , scaleX = 1 , y = -173.8 , scaleY = 1 , rotation = -41};
			addChild(i1489);//12
			var i1491 = new symbol_118();
			addChild(i1491);//13
			var i1492 = new symbol_784(){x = 172.2 , scaleX = 1 , y = -126.3 , scaleY = 1 , rotation = 25};
			addChild(i1492);//14
			var i1494 = new symbol_120();
			addChild(i1494);//15
			var i1495 = new symbol_785(){x = -61.3 , scaleX = 1 , y = -190.1 , scaleY = 1 , rotation = -61};
			addChild(i1495);//16
			var i1497 = new symbol_786(){x = 73.3 , scaleX = 1 , y = -207.3 , scaleY = 1 , rotation = 152};
			addChild(i1497);//17
			var i1499 = new symbol_787(){x = -141.8 , scaleX = 1 , y = -182 , scaleY = 1 , rotation = -40};
			addChild(i1499);//18
			var i1501 = new symbol_788(){x = -114 , scaleX = 1 , y = -174.4 , scaleY = 1 , rotation = 14};
			addChild(i1501);//19
			var i1503 = new symbol_789(){x = -160.3 , scaleX = 1 , y = -157.4 , scaleY = 1 , rotation = -65};
			addChild(i1503);//20
			var i1505 = new symbol_790(){x = -156.3 , scaleX = 1 , y = -96.2 , scaleY = 1 , rotation = 140};
			addChild(i1505);//21
			var i1507 = new symbol_791(){x = -163.1 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1507);//22
			var i1509 = new symbol_792(){x = -62 , scaleX = 1 , y = -209.3 , scaleY = 1 , rotation = 10};
			addChild(i1509);//23
			var i1511 = new symbol_793(){x = 156.5 , scaleX = 1 , y = -169.8 , scaleY = 1 , rotation = 108};
			addChild(i1511);//24
			var i1513 = new symbol_794(){x = 147.8 , scaleX = 1 , y = -157.2 , scaleY = 1 , rotation = 143};
			addChild(i1513);//25
			var i1515 = new symbol_795(){x = 164.6 , scaleX = 1 , y = -135.7 , scaleY = 1 , rotation = 101};
			addChild(i1515);//26
		}
	}
	public class symbol_797 : MovieClip{ 
		public symbol_797() {
			var i1517 = new symbol_33();
			addChild(i1517);//0
		}
	}
	public class symbol_798 : Shape{ 
		public symbol_798() {
			setGraphics("0d3914cabbf43d5d2113843035bc2544", -132.35, 3.25, 57.89999999999999, 43.9, 1, 1);
		}
	}
	public class symbol_799 : MovieClip{ 
		public symbol_799() {
			var i1522 = new symbol_115();
			addChild(i1522);//0
		}
	}
	public class symbol_8 : Shape{ 
		public symbol_8() {
			setGraphics("fe9a5b784581cda81807ae16911b1e44", 0, -110.95, 481.4, 110.95, 1, 1);
		}
	}
	public class symbol_80 : Shape{ 
		public symbol_80() {
			setGraphics("64a87cb0f89a81affb816fb01a411e4d", -105.1, -214.5, 247.5, 215.1, 1, 1);
		}
	}
	public class symbol_800 : MovieClip{ 
		public symbol_800() {
			var i1525 = new symbol_115();
			addChild(i1525);//0
		}
	}
	public class symbol_801 : MovieClip{ 
		public symbol_801() {
			var i1528 = new symbol_115();
			addChild(i1528);//0
		}
	}
	public class symbol_802 : MovieClip{ 
		public symbol_802() {
			var i1530 = new symbol_115();
			addChild(i1530);//0
		}
	}
	public class symbol_803 : MovieClip{ 
		public symbol_803() {
			var i1533 = new symbol_115();
			addChild(i1533);//0
		}
	}
	public class symbol_804 : MovieClip{ 
		public symbol_804() {
			var i1535 = new symbol_132();
			addChild(i1535);//0
		}
	}
	public class symbol_805 : MovieClip{ 
		public symbol_805() {
			var i1537 = new symbol_132();
			addChild(i1537);//0
		}
	}
	public class symbol_806 : MovieClip{ 
		public symbol_806() {
			var i1539 = new symbol_115();
			addChild(i1539);//0
		}
	}
	public class symbol_807 : MovieClip{ 
		public symbol_807() {
			var i1541 = new symbol_115();
			addChild(i1541);//0
		}
	}
	public class symbol_808 : MovieClip{ 
		public symbol_808() {
			var i1543 = new symbol_115();
			addChild(i1543);//0
		}
	}
	public class symbol_809 : MovieClip{ 
		public symbol_809() {
			var i1545 = new symbol_132();
			addChild(i1545);//0
		}
	}
	public class symbol_81 : MovieClip{ 
		public symbol_81() {
			var i174 = new symbol_20();
			addChild(i174);//0
		}
	}
	public class symbol_810 : MovieClip{ 
		public symbol_810() {
			var i1547 = new symbol_132();
			addChild(i1547);//0
		}
	}
	public class symbol_811 : MovieClip{ 
		public symbol_811() {
			var i1549 = new symbol_132();
			addChild(i1549);//0
		}
	}
	public class symbol_812 : MovieClip{ 
		public symbol_812() {
			var i1551 = new symbol_132();
			addChild(i1551);//0
		}
	}
	public class symbol_813 : MovieClip{ 
		public symbol_813() {
			var i1553 = new symbol_132();
			addChild(i1553);//0
		}
	}
	public class symbol_814 : MovieClip{ 
		public symbol_814() {
			var i1555 = new symbol_115();
			addChild(i1555);//0
		}
	}
	public class symbol_815 : MovieClip{ 
		public symbol_815() {
			var i1557 = new symbol_132();
			addChild(i1557);//0
		}
	}
	public class symbol_816 : MovieClip{ 
		public symbol_816() {
			var i1559 = new symbol_132();
			addChild(i1559);//0
		}
	}
	public class symbol_817 : MovieClip{ 
		public symbol_817() {
			var i1561 = new symbol_132();
			addChild(i1561);//0
		}
	}
	public class symbol_818 : MovieClip{ 
		public symbol_818() {
			var i1563 = new symbol_132();
			addChild(i1563);//0
		}
	}
	public class symbol_819 : MovieClip{ 
		public symbol_819() {
			var i1565 = new symbol_132();
			addChild(i1565);//0
		}
	}
	public class symbol_82 : MovieClip{ 
		public symbol_82() {
			var i176 = new symbol_20();
			addChild(i176);//0
		}
	}
	public class symbol_820 : MovieClip{ 
		public symbol_820() {
			var i1520 = new symbol_137();
			addChild(i1520);//0
			var i1521 = new symbol_799(){x = 18.8 , scaleX = 1 , y = -205.1 , scaleY = 1 , rotation = -26};
			addChild(i1521);//1
			var i1523 = new symbol_139();
			addChild(i1523);//2
			var i1524 = new symbol_800(){x = 86.2 , scaleX = 1 , y = -118.3 , scaleY = 1 , rotation = 32};
			addChild(i1524);//3
			var i1526 = new symbol_141();
			addChild(i1526);//4
			var i1527 = new symbol_801(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1527);//5
			var i1529 = new symbol_802(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1529);//6
			var i1531 = new symbol_144();
			addChild(i1531);//7
			var i1532 = new symbol_803(){x = -53.9 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1532);//8
			var i1534 = new symbol_804(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i1534);//9
			var i1536 = new symbol_805(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i1536);//10
			var i1538 = new symbol_806(){x = -216.8 , scaleX = 1 , y = -149.6 , scaleY = 1 , rotation = -129};
			addChild(i1538);//11
			var i1540 = new symbol_807(){x = 147.4 , scaleX = 1 , y = -173.8 , scaleY = 1 , rotation = -41};
			addChild(i1540);//12
			var i1542 = new symbol_808(){x = 172.2 , scaleX = 1 , y = -126.3 , scaleY = 1 , rotation = 25};
			addChild(i1542);//13
			var i1544 = new symbol_809(){x = -61.3 , scaleX = 1 , y = -190.1 , scaleY = 1 , rotation = -61};
			addChild(i1544);//14
			var i1546 = new symbol_810(){x = 73.3 , scaleX = 1 , y = -207.3 , scaleY = 1 , rotation = 152};
			addChild(i1546);//15
			var i1548 = new symbol_811(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i1548);//16
			var i1550 = new symbol_812(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i1550);//17
			var i1552 = new symbol_813(){x = -218.3 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = -65};
			addChild(i1552);//18
			var i1554 = new symbol_814(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1554);//19
			var i1556 = new symbol_815(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1556);//20
			var i1558 = new symbol_816(){x = -62 , scaleX = 1 , y = -209.3 , scaleY = 1 , rotation = 10};
			addChild(i1558);//21
			var i1560 = new symbol_817(){x = 156.5 , scaleX = 1 , y = -169.8 , scaleY = 1 , rotation = 108};
			addChild(i1560);//22
			var i1562 = new symbol_818(){x = 147.8 , scaleX = 1 , y = -157.2 , scaleY = 1 , rotation = 143};
			addChild(i1562);//23
			var i1564 = new symbol_819(){x = 171.1 , scaleX = 1 , y = -136.4 , scaleY = 1 , rotation = 101};
			addChild(i1564);//24
		}
	}
	public class symbol_821 : MovieClip{ 
		public symbol_821() {
			var i1566 = new symbol_33();
			addChild(i1566);//0
		}
	}
	public class symbol_822 : Shape{ 
		public symbol_822() {
			setGraphics("d151224302294569515ee2f07a91f8fb", -140.4, -16.75, 74.65, 66.15, 1, 1);
		}
	}
	public class symbol_823 : MovieClip{ 
		public symbol_823() {
			var i1571 = new symbol_115();
			addChild(i1571);//0
		}
	}
	public class symbol_824 : MovieClip{ 
		public symbol_824() {
			var i1574 = new symbol_115();
			addChild(i1574);//0
		}
	}
	public class symbol_825 : MovieClip{ 
		public symbol_825() {
			var i1577 = new symbol_115();
			addChild(i1577);//0
		}
	}
	public class symbol_826 : MovieClip{ 
		public symbol_826() {
			var i1579 = new symbol_115();
			addChild(i1579);//0
		}
	}
	public class symbol_827 : MovieClip{ 
		public symbol_827() {
			var i1582 = new symbol_115();
			addChild(i1582);//0
		}
	}
	public class symbol_828 : MovieClip{ 
		public symbol_828() {
			var i1584 = new symbol_132();
			addChild(i1584);//0
		}
	}
	public class symbol_829 : MovieClip{ 
		public symbol_829() {
			var i1586 = new symbol_132();
			addChild(i1586);//0
		}
	}
	public class symbol_83 : MovieClip{ 
		public symbol_83() {
			var i178 = new symbol_20();
			addChild(i178);//0
		}
	}
	public class symbol_830 : MovieClip{ 
		public symbol_830() {
			var i1588 = new symbol_115();
			addChild(i1588);//0
		}
	}
	public class symbol_831 : MovieClip{ 
		public symbol_831() {
			var i1590 = new symbol_115();
			addChild(i1590);//0
		}
	}
	public class symbol_832 : MovieClip{ 
		public symbol_832() {
			var i1592 = new symbol_115();
			addChild(i1592);//0
		}
	}
	public class symbol_833 : MovieClip{ 
		public symbol_833() {
			var i1594 = new symbol_132();
			addChild(i1594);//0
		}
	}
	public class symbol_834 : MovieClip{ 
		public symbol_834() {
			var i1596 = new symbol_132();
			addChild(i1596);//0
		}
	}
	public class symbol_835 : MovieClip{ 
		public symbol_835() {
			var i1598 = new symbol_132();
			addChild(i1598);//0
		}
	}
	public class symbol_836 : MovieClip{ 
		public symbol_836() {
			var i1600 = new symbol_132();
			addChild(i1600);//0
		}
	}
	public class symbol_837 : MovieClip{ 
		public symbol_837() {
			var i1602 = new symbol_132();
			addChild(i1602);//0
		}
	}
	public class symbol_838 : MovieClip{ 
		public symbol_838() {
			var i1604 = new symbol_115();
			addChild(i1604);//0
		}
	}
	public class symbol_839 : MovieClip{ 
		public symbol_839() {
			var i1606 = new symbol_132();
			addChild(i1606);//0
		}
	}
	public class symbol_84 : MovieClip{ 
		public symbol_84() {
			var i180 = new symbol_20();
			addChild(i180);//0
		}
	}
	public class symbol_840 : MovieClip{ 
		public symbol_840() {
			var i1608 = new symbol_132();
			addChild(i1608);//0
		}
	}
	public class symbol_841 : MovieClip{ 
		public symbol_841() {
			var i1610 = new symbol_132();
			addChild(i1610);//0
		}
	}
	public class symbol_842 : MovieClip{ 
		public symbol_842() {
			var i1612 = new symbol_132();
			addChild(i1612);//0
		}
	}
	public class symbol_843 : MovieClip{ 
		public symbol_843() {
			var i1614 = new symbol_132();
			addChild(i1614);//0
		}
	}
	public class symbol_844 : MovieClip{ 
		public symbol_844() {
			var i1616 = new symbol_132();
			addChild(i1616);//0
		}
	}
	public class symbol_845 : MovieClip{ 
		public symbol_845() {
			var i1618 = new symbol_115();
			addChild(i1618);//0
		}
	}
	public class symbol_846 : MovieClip{ 
		public symbol_846() {
			var i1620 = new symbol_132();
			addChild(i1620);//0
		}
	}
	public class symbol_847 : MovieClip{ 
		public symbol_847() {
			var i1622 = new symbol_132();
			addChild(i1622);//0
		}
	}
	public class symbol_848 : MovieClip{ 
		public symbol_848() {
			var i1569 = new symbol_137();
			addChild(i1569);//0
			var i1570 = new symbol_823(){x = 18.8 , scaleX = 1 , y = -205.1 , scaleY = 1 , rotation = -26};
			addChild(i1570);//1
			var i1572 = new symbol_166();
			addChild(i1572);//2
			var i1573 = new symbol_824(){x = 86.2 , scaleX = 1 , y = -118.3 , scaleY = 1 , rotation = 32};
			addChild(i1573);//3
			var i1575 = new symbol_168();
			addChild(i1575);//4
			var i1576 = new symbol_825(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1576);//5
			var i1578 = new symbol_826(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1578);//6
			var i1580 = new symbol_144();
			addChild(i1580);//7
			var i1581 = new symbol_827(){x = -53.9 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1581);//8
			var i1583 = new symbol_828(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i1583);//9
			var i1585 = new symbol_829(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i1585);//10
			var i1587 = new symbol_830(){x = -216.8 , scaleX = 1 , y = -149.6 , scaleY = 1 , rotation = -129};
			addChild(i1587);//11
			var i1589 = new symbol_831(){x = 147.4 , scaleX = 1 , y = -173.8 , scaleY = 1 , rotation = -41};
			addChild(i1589);//12
			var i1591 = new symbol_832(){x = 172.2 , scaleX = 1 , y = -126.3 , scaleY = 1 , rotation = 25};
			addChild(i1591);//13
			var i1593 = new symbol_833(){x = -61.3 , scaleX = 1 , y = -190.1 , scaleY = 1 , rotation = -61};
			addChild(i1593);//14
			var i1595 = new symbol_834(){x = 73.3 , scaleX = 1 , y = -207.3 , scaleY = 1 , rotation = 152};
			addChild(i1595);//15
			var i1597 = new symbol_835(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i1597);//16
			var i1599 = new symbol_836(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i1599);//17
			var i1601 = new symbol_837(){x = -218.3 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = -65};
			addChild(i1601);//18
			var i1603 = new symbol_838(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1603);//19
			var i1605 = new symbol_839(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1605);//20
			var i1607 = new symbol_840(){x = -62 , scaleX = 1 , y = -209.3 , scaleY = 1 , rotation = 10};
			addChild(i1607);//21
			var i1609 = new symbol_841(){x = 156.5 , scaleX = 1 , y = -169.8 , scaleY = 1 , rotation = 108};
			addChild(i1609);//22
			var i1611 = new symbol_842(){x = 147.8 , scaleX = 1 , y = -157.2 , scaleY = 1 , rotation = 143};
			addChild(i1611);//23
			var i1613 = new symbol_843(){x = 171.1 , scaleX = 1 , y = -136.4 , scaleY = 1 , rotation = 101};
			addChild(i1613);//24
			var i1615 = new symbol_844(){x = 117.3 , scaleX = 1 , y = -282.7 , scaleY = 1 , rotation = 151};
			addChild(i1615);//25
			var i1617 = new symbol_845(){x = 90.5 , scaleX = 1 , y = -312.6 , scaleY = 1 , rotation = -71};
			addChild(i1617);//26
			var i1619 = new symbol_846(){x = 101 , scaleX = 1 , y = -304.8 , scaleY = 1 , rotation = 108};
			addChild(i1619);//27
			var i1621 = new symbol_847(){x = 76.9 , scaleX = 1 , y = -296.9 , scaleY = 1 , rotation = 21};
			addChild(i1621);//28
		}
	}
	public class symbol_849 : MovieClip{ 
		public symbol_849() {
			var i1623 = new symbol_33();
			addChild(i1623);//0
		}
	}
	public class symbol_85 : MovieClip{ 
		public symbol_85() {
			var i182 = new symbol_20();
			addChild(i182);//0
		}
	}
	public class symbol_850 : Shape{ 
		public symbol_850() {
			setGraphics("02fceebc0c345b1f44853793167c6b87", 38.85, -35.25, 93.9, 84.7, 1, 1);
		}
	}
	public class symbol_851 : MovieClip{ 
		public symbol_851() {
			var i1628 = new symbol_115();
			addChild(i1628);//0
		}
	}
	public class symbol_852 : MovieClip{ 
		public symbol_852() {
			var i1631 = new symbol_132();
			addChild(i1631);//0
		}
	}
	public class symbol_853 : MovieClip{ 
		public symbol_853() {
			var i1633 = new symbol_132();
			addChild(i1633);//0
		}
	}
	public class symbol_854 : MovieClip{ 
		public symbol_854() {
			var i1636 = new symbol_115();
			addChild(i1636);//0
		}
	}
	public class symbol_855 : MovieClip{ 
		public symbol_855() {
			var i1639 = new symbol_115();
			addChild(i1639);//0
		}
	}
	public class symbol_856 : MovieClip{ 
		public symbol_856() {
			var i1641 = new symbol_115();
			addChild(i1641);//0
		}
	}
	public class symbol_857 : MovieClip{ 
		public symbol_857() {
			var i1644 = new symbol_132();
			addChild(i1644);//0
		}
	}
	public class symbol_858 : MovieClip{ 
		public symbol_858() {
			var i1646 = new symbol_132();
			addChild(i1646);//0
		}
	}
	public class symbol_859 : MovieClip{ 
		public symbol_859() {
			var i1648 = new symbol_115();
			addChild(i1648);//0
		}
	}
	public class symbol_86 : MovieClip{ 
		public symbol_86() {
			var i184 = new symbol_20();
			addChild(i184);//0
		}
	}
	public class symbol_860 : MovieClip{ 
		public symbol_860() {
			var i1650 = new symbol_115();
			addChild(i1650);//0
		}
	}
	public class symbol_861 : MovieClip{ 
		public symbol_861() {
			var i1652 = new symbol_115();
			addChild(i1652);//0
		}
	}
	public class symbol_862 : MovieClip{ 
		public symbol_862() {
			var i1654 = new symbol_132();
			addChild(i1654);//0
		}
	}
	public class symbol_863 : MovieClip{ 
		public symbol_863() {
			var i1656 = new symbol_132();
			addChild(i1656);//0
		}
	}
	public class symbol_864 : MovieClip{ 
		public symbol_864() {
			var i1658 = new symbol_132();
			addChild(i1658);//0
		}
	}
	public class symbol_865 : MovieClip{ 
		public symbol_865() {
			var i1660 = new symbol_132();
			addChild(i1660);//0
		}
	}
	public class symbol_866 : MovieClip{ 
		public symbol_866() {
			var i1662 = new symbol_115();
			addChild(i1662);//0
		}
	}
	public class symbol_867 : MovieClip{ 
		public symbol_867() {
			var i1664 = new symbol_132();
			addChild(i1664);//0
		}
	}
	public class symbol_868 : MovieClip{ 
		public symbol_868() {
			var i1666 = new symbol_132();
			addChild(i1666);//0
		}
	}
	public class symbol_869 : MovieClip{ 
		public symbol_869() {
			var i1668 = new symbol_132();
			addChild(i1668);//0
		}
	}
	public class symbol_87 : MovieClip{ 
		public symbol_87() {
			var i186 = new symbol_20();
			addChild(i186);//0
		}
	}
	public class symbol_870 : MovieClip{ 
		public symbol_870() {
			var i1670 = new symbol_132();
			addChild(i1670);//0
		}
	}
	public class symbol_871 : MovieClip{ 
		public symbol_871() {
			var i1672 = new symbol_132();
			addChild(i1672);//0
		}
	}
	public class symbol_872 : MovieClip{ 
		public symbol_872() {
			var i1674 = new symbol_115();
			addChild(i1674);//0
		}
	}
	public class symbol_873 : MovieClip{ 
		public symbol_873() {
			var i1676 = new symbol_132();
			addChild(i1676);//0
		}
	}
	public class symbol_874 : MovieClip{ 
		public symbol_874() {
			var i1678 = new symbol_132();
			addChild(i1678);//0
		}
	}
	public class symbol_875 : MovieClip{ 
		public symbol_875() {
			var i1680 = new symbol_132();
			addChild(i1680);//0
		}
	}
	public class symbol_876 : MovieClip{ 
		public symbol_876() {
			var i1682 = new symbol_132();
			addChild(i1682);//0
		}
	}
	public class symbol_877 : MovieClip{ 
		public symbol_877() {
			var i1684 = new symbol_132();
			addChild(i1684);//0
		}
	}
	public class symbol_878 : MovieClip{ 
		public symbol_878() {
			var i1626 = new symbol_195();
			addChild(i1626);//0
			var i1627 = new symbol_851(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1627);//1
			var i1629 = new symbol_197();
			addChild(i1629);//2
			var i1630 = new symbol_852(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i1630);//3
			var i1632 = new symbol_853(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i1632);//4
			var i1634 = new symbol_200();
			addChild(i1634);//5
			var i1635 = new symbol_854(){x = 86.2 , scaleX = 1 , y = -118.3 , scaleY = 1 , rotation = 32};
			addChild(i1635);//6
			var i1637 = new symbol_202();
			addChild(i1637);//7
			var i1638 = new symbol_855(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1638);//8
			var i1640 = new symbol_856(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1640);//9
			var i1642 = new symbol_144();
			addChild(i1642);//10
			var i1643 = new symbol_857(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i1643);//11
			var i1645 = new symbol_858(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i1645);//12
			var i1647 = new symbol_859(){x = -216.8 , scaleX = 1 , y = -149.6 , scaleY = 1 , rotation = -129};
			addChild(i1647);//13
			var i1649 = new symbol_860(){x = 147.4 , scaleX = 1 , y = -173.8 , scaleY = 1 , rotation = -41};
			addChild(i1649);//14
			var i1651 = new symbol_861(){x = 172.2 , scaleX = 1 , y = -126.3 , scaleY = 1 , rotation = 25};
			addChild(i1651);//15
			var i1653 = new symbol_862(){x = 178.3 , scaleX = 1 , y = -195.3 , scaleY = 1 , rotation = 152};
			addChild(i1653);//16
			var i1655 = new symbol_863(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i1655);//17
			var i1657 = new symbol_864(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i1657);//18
			var i1659 = new symbol_865(){x = -218.3 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = -65};
			addChild(i1659);//19
			var i1661 = new symbol_866(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1661);//20
			var i1663 = new symbol_867(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1663);//21
			var i1665 = new symbol_868(){x = 156.5 , scaleX = 1 , y = -169.8 , scaleY = 1 , rotation = 108};
			addChild(i1665);//22
			var i1667 = new symbol_869(){x = 147.8 , scaleX = 1 , y = -157.2 , scaleY = 1 , rotation = 143};
			addChild(i1667);//23
			var i1669 = new symbol_870(){x = 171.1 , scaleX = 1 , y = -136.4 , scaleY = 1 , rotation = 101};
			addChild(i1669);//24
			var i1671 = new symbol_871(){x = 126.5 , scaleX = 1 , y = -280.7 , scaleY = 1 , rotation = 151};
			addChild(i1671);//25
			var i1673 = new symbol_872(){x = 96.5 , scaleX = 1 , y = -309.4 , scaleY = 1 , rotation = -71};
			addChild(i1673);//26
			var i1675 = new symbol_873(){x = 107.5 , scaleX = 1 , y = -302.8 , scaleY = 1 , rotation = 108};
			addChild(i1675);//27
			var i1677 = new symbol_874(){x = 79.9 , scaleX = 1 , y = -288.1 , scaleY = 1 , rotation = 21};
			addChild(i1677);//28
			var i1679 = new symbol_875(){x = 190.4 , scaleX = 1 , y = -218.9 , scaleY = 1 , rotation = 102};
			addChild(i1679);//29
			var i1681 = new symbol_876(){x = 153.7 , scaleX = 1 , y = -264.8 , scaleY = 1 , rotation = 150};
			addChild(i1681);//30
			var i1683 = new symbol_877(){x = 160.7 , scaleX = 1 , y = -281.9 , scaleY = 1 , rotation = 93};
			addChild(i1683);//31
		}
	}
	public class symbol_879 : MovieClip{ 
		public symbol_879() {
			var i1685 = new symbol_33();
			addChild(i1685);//0
		}
	}
	public class symbol_88 : MovieClip{ 
		public symbol_88() {
			var i188 = new symbol_20();
			addChild(i188);//0
		}
	}
	public class symbol_880 : Shape{ 
		public symbol_880() {
			setGraphics("67dd14df1ac96dbcfc60ec5dbeffa17c", 38.85, -34.45, 93.9, 83.9, 1, 1);
		}
	}
	public class symbol_881 : MovieClip{ 
		public symbol_881() {
			var i1690 = new symbol_115();
			addChild(i1690);//0
		}
	}
	public class symbol_882 : MovieClip{ 
		public symbol_882() {
			var i1692 = new symbol_115();
			addChild(i1692);//0
		}
	}
	public class symbol_883 : MovieClip{ 
		public symbol_883() {
			var i1694 = new symbol_115();
			addChild(i1694);//0
		}
	}
	public class symbol_884 : MovieClip{ 
		public symbol_884() {
			var i1697 = new symbol_115();
			addChild(i1697);//0
		}
	}
	public class symbol_885 : MovieClip{ 
		public symbol_885() {
			var i1700 = new symbol_132();
			addChild(i1700);//0
		}
	}
	public class symbol_886 : MovieClip{ 
		public symbol_886() {
			var i1702 = new symbol_132();
			addChild(i1702);//0
		}
	}
	public class symbol_887 : MovieClip{ 
		public symbol_887() {
			var i1704 = new symbol_132();
			addChild(i1704);//0
		}
	}
	public class symbol_888 : MovieClip{ 
		public symbol_888() {
			var i1706 = new symbol_132();
			addChild(i1706);//0
		}
	}
	public class symbol_889 : MovieClip{ 
		public symbol_889() {
			var i1708 = new symbol_115();
			addChild(i1708);//0
		}
	}
	public class symbol_89 : MovieClip{ 
		public symbol_89() {
			var i190 = new symbol_20();
			addChild(i190);//0
		}
	}
	public class symbol_890 : MovieClip{ 
		public symbol_890() {
			var i1710 = new symbol_115();
			addChild(i1710);//0
		}
	}
	public class symbol_891 : MovieClip{ 
		public symbol_891() {
			var i1712 = new symbol_115();
			addChild(i1712);//0
		}
	}
	public class symbol_892 : MovieClip{ 
		public symbol_892() {
			var i1714 = new symbol_132();
			addChild(i1714);//0
		}
	}
	public class symbol_893 : MovieClip{ 
		public symbol_893() {
			var i1716 = new symbol_132();
			addChild(i1716);//0
		}
	}
	public class symbol_894 : MovieClip{ 
		public symbol_894() {
			var i1718 = new symbol_132();
			addChild(i1718);//0
		}
	}
	public class symbol_895 : MovieClip{ 
		public symbol_895() {
			var i1720 = new symbol_132();
			addChild(i1720);//0
		}
	}
	public class symbol_896 : MovieClip{ 
		public symbol_896() {
			var i1722 = new symbol_115();
			addChild(i1722);//0
		}
	}
	public class symbol_897 : MovieClip{ 
		public symbol_897() {
			var i1724 = new symbol_132();
			addChild(i1724);//0
		}
	}
	public class symbol_898 : MovieClip{ 
		public symbol_898() {
			var i1726 = new symbol_132();
			addChild(i1726);//0
		}
	}
	public class symbol_899 : MovieClip{ 
		public symbol_899() {
			var i1728 = new symbol_132();
			addChild(i1728);//0
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("ba31f2a45025b237af1626928e54d386", 0, -84.95, 418, 84.95, 1, 1);
		}
	}
	public class symbol_90 : MovieClip{ 
		public symbol_90() {
			var i192 = new symbol_20();
			addChild(i192);//0
		}
	}
	public class symbol_900 : MovieClip{ 
		public symbol_900() {
			var i1730 = new symbol_132();
			addChild(i1730);//0
		}
	}
	public class symbol_901 : MovieClip{ 
		public symbol_901() {
			var i1732 = new symbol_132();
			addChild(i1732);//0
		}
	}
	public class symbol_902 : MovieClip{ 
		public symbol_902() {
			var i1734 = new symbol_115();
			addChild(i1734);//0
		}
	}
	public class symbol_903 : MovieClip{ 
		public symbol_903() {
			var i1736 = new symbol_132();
			addChild(i1736);//0
		}
	}
	public class symbol_904 : MovieClip{ 
		public symbol_904() {
			var i1738 = new symbol_132();
			addChild(i1738);//0
		}
	}
	public class symbol_905 : MovieClip{ 
		public symbol_905() {
			var i1740 = new symbol_132();
			addChild(i1740);//0
		}
	}
	public class symbol_906 : MovieClip{ 
		public symbol_906() {
			var i1742 = new symbol_132();
			addChild(i1742);//0
		}
	}
	public class symbol_907 : MovieClip{ 
		public symbol_907() {
			var i1744 = new symbol_132();
			addChild(i1744);//0
		}
	}
	public class symbol_908 : MovieClip{ 
		public symbol_908() {
			var i1688 = new symbol_58();
			addChild(i1688);//0
			var i1689 = new symbol_881(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1689);//1
			var i1691 = new symbol_882(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1691);//2
			var i1693 = new symbol_883(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1693);//3
			var i1695 = new symbol_232();
			addChild(i1695);//4
			var i1696 = new symbol_884(){x = 92.2 , scaleX = 1 , y = -125.8 , scaleY = 1 , rotation = 32};
			addChild(i1696);//5
			var i1698 = new symbol_234();
			addChild(i1698);//6
			var i1699 = new symbol_885(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i1699);//7
			var i1701 = new symbol_886(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i1701);//8
			var i1703 = new symbol_887(){x = 4.2 , scaleX = 0.79 , y = -285.4 , scaleY = 0.79 , rotation = 13};
			addChild(i1703);//9
			var i1705 = new symbol_888(){x = 15.4 , scaleX = 1 , y = -285.9 , scaleY = 1 , rotation = 53};
			addChild(i1705);//10
			var i1707 = new symbol_889(){x = -271.3 , scaleX = 1 , y = -149.1 , scaleY = 1 , rotation = -129};
			addChild(i1707);//11
			var i1709 = new symbol_890(){x = 144.9 , scaleX = 1 , y = -178.3 , scaleY = 1 , rotation = -41};
			addChild(i1709);//12
			var i1711 = new symbol_891(){x = 249.7 , scaleX = 1 , y = -154.8 , scaleY = 1 , rotation = 25};
			addChild(i1711);//13
			var i1713 = new symbol_892(){x = 180.3 , scaleX = 1 , y = -196.3 , scaleY = 1 , rotation = 152};
			addChild(i1713);//14
			var i1715 = new symbol_893(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i1715);//15
			var i1717 = new symbol_894(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i1717);//16
			var i1719 = new symbol_895(){x = -274.9 , scaleX = 1 , y = -137.2 , scaleY = 1 , rotation = -65};
			addChild(i1719);//17
			var i1721 = new symbol_896(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1721);//18
			var i1723 = new symbol_897(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1723);//19
			var i1725 = new symbol_898(){x = 164 , scaleX = 1 , y = -175.3 , scaleY = 1 , rotation = 108};
			addChild(i1725);//20
			var i1727 = new symbol_899(){x = 159.8 , scaleX = 1 , y = -165.2 , scaleY = 1 , rotation = 143};
			addChild(i1727);//21
			var i1729 = new symbol_900(){x = 242.6 , scaleX = 1 , y = -165.4 , scaleY = 1 , rotation = 101};
			addChild(i1729);//22
			var i1731 = new symbol_901(){x = 126.5 , scaleX = 1 , y = -280.7 , scaleY = 1 , rotation = 151};
			addChild(i1731);//23
			var i1733 = new symbol_902(){x = 96.5 , scaleX = 1 , y = -309.4 , scaleY = 1 , rotation = -71};
			addChild(i1733);//24
			var i1735 = new symbol_903(){x = 107.5 , scaleX = 1 , y = -302.8 , scaleY = 1 , rotation = 108};
			addChild(i1735);//25
			var i1737 = new symbol_904(){x = 79.9 , scaleX = 1 , y = -288.1 , scaleY = 1 , rotation = 21};
			addChild(i1737);//26
			var i1739 = new symbol_905(){x = 191.4 , scaleX = 1 , y = -218.9 , scaleY = 1 , rotation = 102};
			addChild(i1739);//27
			var i1741 = new symbol_906(){x = 153.7 , scaleX = 1 , y = -264.8 , scaleY = 1 , rotation = 150};
			addChild(i1741);//28
			var i1743 = new symbol_907(){x = 160.7 , scaleX = 1 , y = -281.9 , scaleY = 1 , rotation = 93};
			addChild(i1743);//29
		}
	}
	public class symbol_909 : MovieClip{ 
		public symbol_909() {
			var i1745 = new symbol_33();
			addChild(i1745);//0
		}
	}
	public class symbol_91 : MovieClip{ 
		public symbol_91() {
			var i194 = new symbol_20();
			addChild(i194);//0
		}
	}
	public class symbol_910 : MovieClip{ 
		public symbol_910() {
			var i1748 = new symbol_115();
			addChild(i1748);//0
		}
	}
	public class symbol_911 : MovieClip{ 
		public symbol_911() {
			var i1750 = new symbol_115();
			addChild(i1750);//0
		}
	}
	public class symbol_912 : MovieClip{ 
		public symbol_912() {
			var i1752 = new symbol_115();
			addChild(i1752);//0
		}
	}
	public class symbol_913 : MovieClip{ 
		public symbol_913() {
			var i1754 = new symbol_115();
			addChild(i1754);//0
		}
	}
	public class symbol_914 : MovieClip{ 
		public symbol_914() {
			var i1757 = new symbol_115();
			addChild(i1757);//0
		}
	}
	public class symbol_915 : MovieClip{ 
		public symbol_915() {
			var i1760 = new symbol_132();
			addChild(i1760);//0
		}
	}
	public class symbol_916 : MovieClip{ 
		public symbol_916() {
			var i1762 = new symbol_132();
			addChild(i1762);//0
		}
	}
	public class symbol_917 : MovieClip{ 
		public symbol_917() {
			var i1764 = new symbol_132();
			addChild(i1764);//0
		}
	}
	public class symbol_918 : MovieClip{ 
		public symbol_918() {
			var i1766 = new symbol_132();
			addChild(i1766);//0
		}
	}
	public class symbol_919 : MovieClip{ 
		public symbol_919() {
			var i1768 = new symbol_115();
			addChild(i1768);//0
		}
	}
	public class symbol_92 : MovieClip{ 
		public symbol_92() {
			var i196 = new symbol_20();
			addChild(i196);//0
		}
	}
	public class symbol_920 : MovieClip{ 
		public symbol_920() {
			var i1770 = new symbol_115();
			addChild(i1770);//0
		}
	}
	public class symbol_921 : MovieClip{ 
		public symbol_921() {
			var i1772 = new symbol_115();
			addChild(i1772);//0
		}
	}
	public class symbol_922 : MovieClip{ 
		public symbol_922() {
			var i1774 = new symbol_132();
			addChild(i1774);//0
		}
	}
	public class symbol_923 : MovieClip{ 
		public symbol_923() {
			var i1776 = new symbol_132();
			addChild(i1776);//0
		}
	}
	public class symbol_924 : MovieClip{ 
		public symbol_924() {
			var i1778 = new symbol_132();
			addChild(i1778);//0
		}
	}
	public class symbol_925 : MovieClip{ 
		public symbol_925() {
			var i1780 = new symbol_132();
			addChild(i1780);//0
		}
	}
	public class symbol_926 : MovieClip{ 
		public symbol_926() {
			var i1782 = new symbol_115();
			addChild(i1782);//0
		}
	}
	public class symbol_927 : MovieClip{ 
		public symbol_927() {
			var i1784 = new symbol_132();
			addChild(i1784);//0
		}
	}
	public class symbol_928 : MovieClip{ 
		public symbol_928() {
			var i1786 = new symbol_132();
			addChild(i1786);//0
		}
	}
	public class symbol_929 : MovieClip{ 
		public symbol_929() {
			var i1788 = new symbol_132();
			addChild(i1788);//0
		}
	}
	public class symbol_93 : MovieClip{ 
		public symbol_93() {
			var i166 = new symbol_77(){x = -51.6 , scaleX = 1 , y = -108.3 , scaleY = 1 , rotation = 109};
			addChild(i166);//0
			var i168 = new symbol_78(){x = 123.5 , scaleX = 1 , y = -114.7 , scaleY = 1 , rotation = 163};
			addChild(i168);//1
			var i170 = new symbol_79(){x = 74.2 , scaleX = 1 , y = -108.5 , scaleY = 1 , rotation = 18};
			addChild(i170);//2
			var i172 = new symbol_80();
			addChild(i172);//3
			var i173 = new symbol_81(){x = -103.5 , scaleX = 1 , y = -170.9 , scaleY = 1 , rotation = 22};
			addChild(i173);//4
			var i175 = new symbol_82(){x = -84 , scaleX = 1 , y = -137.7 , scaleY = 1 , rotation = -72};
			addChild(i175);//5
			var i177 = new symbol_83(){x = -103.5 , scaleX = 1 , y = -114 , scaleY = 1 , rotation = 68};
			addChild(i177);//6
			var i179 = new symbol_84(){x = -96.5 , scaleX = 1 , y = -97.5 , scaleY = 1 , rotation = -2};
			addChild(i179);//7
			var i181 = new symbol_85(){x = 0 , scaleX = 1 , y = -216 , scaleY = 1 , rotation = 99};
			addChild(i181);//8
			var i183 = new symbol_86(){x = 20.1 , scaleX = 1 , y = -202.5 , scaleY = 1 , rotation = 84};
			addChild(i183);//9
			var i185 = new symbol_87(){x = -10 , scaleX = 1 , y = -170.2 , scaleY = 1 , rotation = 6};
			addChild(i185);//10
			var i187 = new symbol_88(){x = 78.2 , scaleX = 1 , y = -138.2 , scaleY = 1 , rotation = 76};
			addChild(i187);//11
			var i189 = new symbol_89(){x = 109.9 , scaleX = 1 , y = -153.4 , scaleY = 1 , rotation = 50};
			addChild(i189);//12
			var i191 = new symbol_90(){x = 131.1 , scaleX = 1 , y = -155.3 , scaleY = 1 , rotation = 109};
			addChild(i191);//13
			var i193 = new symbol_91(){x = 149.6 , scaleX = 1 , y = -123.6 , scaleY = 1 , rotation = 146};
			addChild(i193);//14
			var i195 = new symbol_92(){x = 123 , scaleX = 1 , y = -130.9 , scaleY = 1 , rotation = 103};
			addChild(i195);//15
		}
	}
	public class symbol_930 : MovieClip{ 
		public symbol_930() {
			var i1790 = new symbol_132();
			addChild(i1790);//0
		}
	}
	public class symbol_931 : MovieClip{ 
		public symbol_931() {
			var i1792 = new symbol_132();
			addChild(i1792);//0
		}
	}
	public class symbol_932 : MovieClip{ 
		public symbol_932() {
			var i1794 = new symbol_115();
			addChild(i1794);//0
		}
	}
	public class symbol_933 : MovieClip{ 
		public symbol_933() {
			var i1796 = new symbol_132();
			addChild(i1796);//0
		}
	}
	public class symbol_934 : MovieClip{ 
		public symbol_934() {
			var i1798 = new symbol_132();
			addChild(i1798);//0
		}
	}
	public class symbol_935 : MovieClip{ 
		public symbol_935() {
			var i1800 = new symbol_132();
			addChild(i1800);//0
		}
	}
	public class symbol_936 : MovieClip{ 
		public symbol_936() {
			var i1802 = new symbol_132();
			addChild(i1802);//0
		}
	}
	public class symbol_937 : MovieClip{ 
		public symbol_937() {
			var i1804 = new symbol_132();
			addChild(i1804);//0
		}
	}
	public class symbol_938 : MovieClip{ 
		public symbol_938() {
			var i1806 = new symbol_132();
			addChild(i1806);//0
		}
	}
	public class symbol_939 : MovieClip{ 
		public symbol_939() {
			var i1747 = new symbol_910(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1747);//0
			var i1749 = new symbol_911(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1749);//1
			var i1751 = new symbol_912(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1751);//2
			var i1753 = new symbol_913(){x = 92.2 , scaleX = 1 , y = -125.8 , scaleY = 1 , rotation = 32};
			addChild(i1753);//3
			var i1755 = new symbol_264();
			addChild(i1755);//4
			var i1756 = new symbol_914(){x = -65.1 , scaleX = 1 , y = -299.1 , scaleY = 1 , rotation = -160};
			addChild(i1756);//5
			var i1758 = new symbol_266();
			addChild(i1758);//6
			var i1759 = new symbol_915(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i1759);//7
			var i1761 = new symbol_916(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i1761);//8
			var i1763 = new symbol_917(){x = 16.7 , scaleX = 0.79 , y = -361.9 , scaleY = 0.79 , rotation = 13};
			addChild(i1763);//9
			var i1765 = new symbol_918(){x = 27.9 , scaleX = 1 , y = -362.4 , scaleY = 1 , rotation = 53};
			addChild(i1765);//10
			var i1767 = new symbol_919(){x = -271.3 , scaleX = 1 , y = -149.1 , scaleY = 1 , rotation = -129};
			addChild(i1767);//11
			var i1769 = new symbol_920(){x = 144.9 , scaleX = 1 , y = -178.3 , scaleY = 1 , rotation = -41};
			addChild(i1769);//12
			var i1771 = new symbol_921(){x = 252.7 , scaleX = 1 , y = -154.8 , scaleY = 1 , rotation = 25};
			addChild(i1771);//13
			var i1773 = new symbol_922(){x = 180.3 , scaleX = 1 , y = -196.3 , scaleY = 1 , rotation = 152};
			addChild(i1773);//14
			var i1775 = new symbol_923(){x = -171.5 , scaleX = 1 , y = -204.8 , scaleY = 1 , rotation = -40};
			addChild(i1775);//15
			var i1777 = new symbol_924(){x = -164.3 , scaleX = 1 , y = -216.4 , scaleY = 1 , rotation = 14};
			addChild(i1777);//16
			var i1779 = new symbol_925(){x = -274.9 , scaleX = 1 , y = -137.2 , scaleY = 1 , rotation = -65};
			addChild(i1779);//17
			var i1781 = new symbol_926(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1781);//18
			var i1783 = new symbol_927(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1783);//19
			var i1785 = new symbol_928(){x = 164 , scaleX = 1 , y = -175.3 , scaleY = 1 , rotation = 108};
			addChild(i1785);//20
			var i1787 = new symbol_929(){x = 159.8 , scaleX = 1 , y = -165.2 , scaleY = 1 , rotation = 143};
			addChild(i1787);//21
			var i1789 = new symbol_930(){x = 245.6 , scaleX = 1 , y = -165.4 , scaleY = 1 , rotation = 101};
			addChild(i1789);//22
			var i1791 = new symbol_931(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i1791);//23
			var i1793 = new symbol_932(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i1793);//24
			var i1795 = new symbol_933(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i1795);//25
			var i1797 = new symbol_934(){x = 80.4 , scaleX = 1 , y = -292.1 , scaleY = 1 , rotation = 21};
			addChild(i1797);//26
			var i1799 = new symbol_935(){x = 191.4 , scaleX = 1 , y = -218.9 , scaleY = 1 , rotation = 102};
			addChild(i1799);//27
			var i1801 = new symbol_936(){x = 156.2 , scaleX = 1 , y = -263.8 , scaleY = 1 , rotation = 150};
			addChild(i1801);//28
			var i1803 = new symbol_937(){x = 163.2 , scaleX = 1 , y = -281.9 , scaleY = 1 , rotation = 93};
			addChild(i1803);//29
			var i1805 = new symbol_938(){x = -62.5 , scaleX = 1 , y = -310.6 , scaleY = 1 , rotation = 16};
			addChild(i1805);//30
		}
	}
	public class symbol_94 : MovieClip{ 
		public symbol_94() {
			var i197 = new symbol_33();
			addChild(i197);//0
		}
	}
	public class symbol_940 : MovieClip{ 
		public symbol_940() {
			var i1807 = new symbol_33();
			addChild(i1807);//0
		}
	}
	public class symbol_941 : Shape{ 
		public symbol_941() {
			setGraphics("b5c45346d83d84376e1c81c3cfffd435", -151.15, -34.45, 93.9, 83.9, 1, 1);
		}
	}
	public class symbol_942 : MovieClip{ 
		public symbol_942() {
			var i1812 = new symbol_115();
			addChild(i1812);//0
		}
	}
	public class symbol_943 : MovieClip{ 
		public symbol_943() {
			var i1814 = new symbol_115();
			addChild(i1814);//0
		}
	}
	public class symbol_944 : MovieClip{ 
		public symbol_944() {
			var i1816 = new symbol_115();
			addChild(i1816);//0
		}
	}
	public class symbol_945 : MovieClip{ 
		public symbol_945() {
			var i1819 = new symbol_132();
			addChild(i1819);//0
		}
	}
	public class symbol_946 : MovieClip{ 
		public symbol_946() {
			var i1821 = new symbol_132();
			addChild(i1821);//0
		}
	}
	public class symbol_947 : MovieClip{ 
		public symbol_947() {
			var i1824 = new symbol_132();
			addChild(i1824);//0
		}
	}
	public class symbol_948 : MovieClip{ 
		public symbol_948() {
			var i1827 = new symbol_115();
			addChild(i1827);//0
		}
	}
	public class symbol_949 : MovieClip{ 
		public symbol_949() {
			var i1829 = new symbol_115();
			addChild(i1829);//0
		}
	}
	public class symbol_95 : Shape{ 
		public symbol_95() {
			setGraphics("33009e209686f923fb3f4d487a5072aa", 108.6, -89.25, 55.95000000000002, 32.4, 1, 1);
		}
	}
	public class symbol_950 : MovieClip{ 
		public symbol_950() {
			var i1831 = new symbol_115();
			addChild(i1831);//0
		}
	}
	public class symbol_951 : MovieClip{ 
		public symbol_951() {
			var i1834 = new symbol_115();
			addChild(i1834);//0
		}
	}
	public class symbol_952 : MovieClip{ 
		public symbol_952() {
			var i1836 = new symbol_132();
			addChild(i1836);//0
		}
	}
	public class symbol_953 : MovieClip{ 
		public symbol_953() {
			var i1838 = new symbol_132();
			addChild(i1838);//0
		}
	}
	public class symbol_954 : MovieClip{ 
		public symbol_954() {
			var i1840 = new symbol_132();
			addChild(i1840);//0
		}
	}
	public class symbol_955 : MovieClip{ 
		public symbol_955() {
			var i1842 = new symbol_132();
			addChild(i1842);//0
		}
	}
	public class symbol_956 : MovieClip{ 
		public symbol_956() {
			var i1844 = new symbol_115();
			addChild(i1844);//0
		}
	}
	public class symbol_957 : MovieClip{ 
		public symbol_957() {
			var i1846 = new symbol_115();
			addChild(i1846);//0
		}
	}
	public class symbol_958 : MovieClip{ 
		public symbol_958() {
			var i1848 = new symbol_132();
			addChild(i1848);//0
		}
	}
	public class symbol_959 : MovieClip{ 
		public symbol_959() {
			var i1850 = new symbol_132();
			addChild(i1850);//0
		}
	}
	public class symbol_96 : Shape{ 
		public symbol_96() {
			setGraphics("74c8aebf4b4cdf1d45ec6584db23ec45", -34.7, -6.4, 71.30000000000001, 17.75, 1, 1);
		}
	}
	public class symbol_960 : MovieClip{ 
		public symbol_960() {
			var i1852 = new symbol_132();
			addChild(i1852);//0
		}
	}
	public class symbol_961 : MovieClip{ 
		public symbol_961() {
			var i1854 = new symbol_115();
			addChild(i1854);//0
		}
	}
	public class symbol_962 : MovieClip{ 
		public symbol_962() {
			var i1856 = new symbol_132();
			addChild(i1856);//0
		}
	}
	public class symbol_963 : MovieClip{ 
		public symbol_963() {
			var i1858 = new symbol_132();
			addChild(i1858);//0
		}
	}
	public class symbol_964 : MovieClip{ 
		public symbol_964() {
			var i1860 = new symbol_132();
			addChild(i1860);//0
		}
	}
	public class symbol_965 : MovieClip{ 
		public symbol_965() {
			var i1862 = new symbol_132();
			addChild(i1862);//0
		}
	}
	public class symbol_966 : MovieClip{ 
		public symbol_966() {
			var i1864 = new symbol_132();
			addChild(i1864);//0
		}
	}
	public class symbol_967 : MovieClip{ 
		public symbol_967() {
			var i1866 = new symbol_115();
			addChild(i1866);//0
		}
	}
	public class symbol_968 : MovieClip{ 
		public symbol_968() {
			var i1868 = new symbol_132();
			addChild(i1868);//0
		}
	}
	public class symbol_969 : MovieClip{ 
		public symbol_969() {
			var i1870 = new symbol_132();
			addChild(i1870);//0
		}
	}
	public class symbol_97 : MovieClip{ 
		public symbol_97() {
			var i200 = new symbol_96();
			addChild(i200);//0
		}
	}
	public class symbol_970 : MovieClip{ 
		public symbol_970() {
			var i1872 = new symbol_132();
			addChild(i1872);//0
		}
	}
	public class symbol_971 : MovieClip{ 
		public symbol_971() {
			var i1874 = new symbol_132();
			addChild(i1874);//0
		}
	}
	public class symbol_972 : MovieClip{ 
		public symbol_972() {
			var i1876 = new symbol_115();
			addChild(i1876);//0
		}
	}
	public class symbol_973 : MovieClip{ 
		public symbol_973() {
			var i1878 = new symbol_132();
			addChild(i1878);//0
		}
	}
	public class symbol_974 : MovieClip{ 
		public symbol_974() {
			var i1880 = new symbol_132();
			addChild(i1880);//0
		}
	}
	public class symbol_975 : MovieClip{ 
		public symbol_975() {
			var i1882 = new symbol_132();
			addChild(i1882);//0
		}
	}
	public class symbol_976 : MovieClip{ 
		public symbol_976() {
			var i1884 = new symbol_115();
			addChild(i1884);//0
		}
	}
	public class symbol_977 : MovieClip{ 
		public symbol_977() {
			var i1886 = new symbol_132();
			addChild(i1886);//0
		}
	}
	public class symbol_978 : MovieClip{ 
		public symbol_978() {
			var i1810 = new symbol_294();
			addChild(i1810);//0
			var i1811 = new symbol_942(){x = -54.6 , scaleX = 1.01 , y = -184.4 , scaleY = 0.99 , rotation = 145};
			addChild(i1811);//1
			var i1813 = new symbol_943(){x = -132.8 , scaleX = 1 , y = -140.3 , scaleY = 1 , rotation = 163};
			addChild(i1813);//2
			var i1815 = new symbol_944(){x = -122.3 , scaleX = 1 , y = -104.2 , scaleY = 1 , rotation = 140};
			addChild(i1815);//3
			var i1817 = new symbol_298();
			addChild(i1817);//4
			var i1818 = new symbol_945(){x = -145.1 , scaleX = 1 , y = -280.2 , scaleY = 1 , rotation = 4};
			addChild(i1818);//5
			var i1820 = new symbol_946(){x = -147.3 , scaleX = 0.84 , y = -268.1 , scaleY = 0.84 , rotation = -34};
			addChild(i1820);//6
			var i1822 = new symbol_301();
			addChild(i1822);//7
			var i1823 = new symbol_947(){x = 212.6 , scaleX = 1 , y = -189.7 , scaleY = 1 , rotation = 131};
			addChild(i1823);//8
			var i1825 = new symbol_303();
			addChild(i1825);//9
			var i1826 = new symbol_948(){x = 144.8 , scaleX = 1 , y = -167.8 , scaleY = 1 , rotation = -31};
			addChild(i1826);//10
			var i1828 = new symbol_949(){x = 113.2 , scaleX = 1 , y = -111.7 , scaleY = 1 , rotation = 45};
			addChild(i1828);//11
			var i1830 = new symbol_950(){x = 233.9 , scaleX = 1 , y = -138.6 , scaleY = 1 , rotation = 25};
			addChild(i1830);//12
			var i1832 = new symbol_307();
			addChild(i1832);//13
			var i1833 = new symbol_951(){x = -92.6 , scaleX = 1 , y = -339.9 , scaleY = 1 , rotation = -160};
			addChild(i1833);//14
			var i1835 = new symbol_952(){x = -106.6 , scaleX = 1 , y = -232.6 , scaleY = 1 , rotation = 54};
			addChild(i1835);//15
			var i1837 = new symbol_953(){x = -117.3 , scaleX = 1 , y = -228.8 , scaleY = 1 , rotation = 10};
			addChild(i1837);//16
			var i1839 = new symbol_954(){x = 16.7 , scaleX = 0.79 , y = -361.9 , scaleY = 0.79 , rotation = 13};
			addChild(i1839);//17
			var i1841 = new symbol_955(){x = 27.9 , scaleX = 1 , y = -362.4 , scaleY = 1 , rotation = 53};
			addChild(i1841);//18
			var i1843 = new symbol_956(){x = -307.1 , scaleX = 1 , y = -168.6 , scaleY = 1 , rotation = -129};
			addChild(i1843);//19
			var i1845 = new symbol_957(){x = 317.9 , scaleX = 1 , y = -152.6 , scaleY = 1 , rotation = 25};
			addChild(i1845);//20
			var i1847 = new symbol_958(){x = -199.4 , scaleX = 0.78 , y = -223.7 , scaleY = 0.78 , rotation = -40};
			addChild(i1847);//21
			var i1849 = new symbol_959(){x = -193.7 , scaleX = 1 , y = -232.2 , scaleY = 1 , rotation = 1};
			addChild(i1849);//22
			var i1851 = new symbol_960(){x = -310.6 , scaleX = 1 , y = -157.9 , scaleY = 1 , rotation = -65};
			addChild(i1851);//23
			var i1853 = new symbol_961(){x = -186.8 , scaleX = 1 , y = -98.9 , scaleY = 1 , rotation = 140};
			addChild(i1853);//24
			var i1855 = new symbol_962(){x = -191.3 , scaleX = 1 , y = -109.1 , scaleY = 1 , rotation = -41};
			addChild(i1855);//25
			var i1857 = new symbol_963(){x = 167.5 , scaleX = 1 , y = -168.8 , scaleY = 1 , rotation = 108};
			addChild(i1857);//26
			var i1859 = new symbol_964(){x = 171.3 , scaleX = 1 , y = -157.7 , scaleY = 1 , rotation = 143};
			addChild(i1859);//27
			var i1861 = new symbol_965(){x = 317.3 , scaleX = 1 , y = -162.9 , scaleY = 1 , rotation = 97};
			addChild(i1861);//28
			var i1863 = new symbol_966(){x = 125 , scaleX = 1 , y = -285.7 , scaleY = 1 , rotation = 151};
			addChild(i1863);//29
			var i1865 = new symbol_967(){x = 96 , scaleX = 1 , y = -314.9 , scaleY = 1 , rotation = -71};
			addChild(i1865);//30
			var i1867 = new symbol_968(){x = 107 , scaleX = 1 , y = -308.3 , scaleY = 1 , rotation = 108};
			addChild(i1867);//31
			var i1869 = new symbol_969(){x = 80.9 , scaleX = 1 , y = -293.4 , scaleY = 1 , rotation = 21};
			addChild(i1869);//32
			var i1871 = new symbol_970(){x = 228.4 , scaleX = 1 , y = -243.9 , scaleY = 1 , rotation = 82};
			addChild(i1871);//33
			var i1873 = new symbol_971(){x = 159.2 , scaleX = 1 , y = -264.3 , scaleY = 1 , rotation = 150};
			addChild(i1873);//34
			var i1875 = new symbol_972(){x = 216.7 , scaleX = 1 , y = -277.9 , scaleY = 1 , rotation = 20};
			addChild(i1875);//35
			var i1877 = new symbol_973(){x = 213.9 , scaleX = 1 , y = -287.6 , scaleY = 1 , rotation = 93};
			addChild(i1877);//36
			var i1879 = new symbol_974(){x = -85.7 , scaleX = 1 , y = -350.8 , scaleY = 1 , rotation = 16};
			addChild(i1879);//37
			var i1881 = new symbol_975(){x = -144.3 , scaleX = 0.78 , y = -206.8 , scaleY = 0.78 , rotation = 24};
			addChild(i1881);//38
			var i1883 = new symbol_976(){x = -265.4 , scaleX = 0.8 , y = -192.4 , scaleY = 0.8 , rotation = -29};
			addChild(i1883);//39
			var i1885 = new symbol_977(){x = -255.8 , scaleX = 1 , y = -186 , scaleY = 1 , rotation = 125};
			addChild(i1885);//40
			var i1887 = new symbol_335();
			addChild(i1887);//41
		}
	}
	public class symbol_979 : MovieClip{ 
		public symbol_979() {
			var i1888 = new symbol_33();
			addChild(i1888);//0
		}
	}
	public class symbol_98 : Shape{ 
		public symbol_98() {
			setGraphics("72ff2f0e6119452652bf6cf65cf89b5e", -44.6, -40.5, 89.2, 81, 1, 1);
		}
	}
	public class symbol_980 : MovieClip{ 
		public symbol_980() {
			var i1890 = new symbol_338();
			addChild(i1890);//0
		}
	}
	public class symbol_981 : Shape{ 
		public symbol_981() {
			setGraphics("28a576bafd23358c861841fc4935819a", 38.85, -34.45, 93.9, 83.9, 1, 1);
		}
	}
	public class symbol_982 : MovieClip{ 
		public symbol_982() {
			var i1895 = new symbol_115();
			addChild(i1895);//0
		}
	}
	public class symbol_983 : MovieClip{ 
		public symbol_983() {
			var i1897 = new symbol_115();
			addChild(i1897);//0
		}
	}
	public class symbol_984 : MovieClip{ 
		public symbol_984() {
			var i1899 = new symbol_115();
			addChild(i1899);//0
		}
	}
	public class symbol_985 : MovieClip{ 
		public symbol_985() {
			var i1902 = new symbol_132();
			addChild(i1902);//0
		}
	}
	public class symbol_986 : MovieClip{ 
		public symbol_986() {
			var i1904 = new symbol_132();
			addChild(i1904);//0
		}
	}
	public class symbol_987 : MovieClip{ 
		public symbol_987() {
			var i1907 = new symbol_132();
			addChild(i1907);//0
		}
	}
	public class symbol_988 : MovieClip{ 
		public symbol_988() {
			var i1910 = new symbol_115();
			addChild(i1910);//0
		}
	}
	public class symbol_989 : MovieClip{ 
		public symbol_989() {
			var i1912 = new symbol_115();
			addChild(i1912);//0
		}
	}
	public class symbol_99 : MovieClip{ 
		public symbol_99() {
			var i202 = new symbol_98();
			addChild(i202);//0
		}
	}
	public class symbol_990 : MovieClip{ 
		public symbol_990() {
			var i1914 = new symbol_115();
			addChild(i1914);//0
		}
	}
	public class symbol_991 : MovieClip{ 
		public symbol_991() {
			var i1917 = new symbol_115();
			addChild(i1917);//0
		}
	}
	public class symbol_992 : MovieClip{ 
		public symbol_992() {
			var i1919 = new symbol_132();
			addChild(i1919);//0
		}
	}
	public class symbol_993 : MovieClip{ 
		public symbol_993() {
			var i1921 = new symbol_132();
			addChild(i1921);//0
		}
	}
	public class symbol_994 : MovieClip{ 
		public symbol_994() {
			var i1923 = new symbol_132();
			addChild(i1923);//0
		}
	}
	public class symbol_995 : MovieClip{ 
		public symbol_995() {
			var i1925 = new symbol_132();
			addChild(i1925);//0
		}
	}
	public class symbol_996 : MovieClip{ 
		public symbol_996() {
			var i1927 = new symbol_115();
			addChild(i1927);//0
		}
	}
	public class symbol_997 : MovieClip{ 
		public symbol_997() {
			var i1929 = new symbol_115();
			addChild(i1929);//0
		}
	}
	public class symbol_998 : MovieClip{ 
		public symbol_998() {
			var i1931 = new symbol_132();
			addChild(i1931);//0
		}
	}
	public class symbol_999 : MovieClip{ 
		public symbol_999() {
			var i1933 = new symbol_132();
			addChild(i1933);//0
		}
	}
}
