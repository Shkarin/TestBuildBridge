using System;
using flash.display;
using System.Collections.Generic;
using dialogs.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libdialogs : ResourcesExternalLib{
	public Libdialogs() {
	vectors = new string[] {
	"07df98088d58a521006655b5db245733",
	"d36d313459b99dabf0de4da938a1b974",
	"38130598ac831e721a67f121043ad1fc",
	"d5d2b14fcd90c516076cfb7806185adf",
	"d87dac96c2f261b833330be5d024e31a",
	"064d703136ea0bdc477ead42ec18bf98",
	"80b62bffda30eb56e0f87217bbc5e5aa",
	"9e03e247b1846a702b7df46286ea1221",
	"1808b3bb7c40ed17de58e32429ced9a9",
	"6bdcc7c919c70efe1e12fbbc84f5fc4f",
	"99686abedc14a10cc5256dc6510a7eda",
	"c8efb7ce037f2fd1d56b84677129bd33",
	"94e32216cf2228f92643790839ba23cf",
	"d9e1523a31c46dee4b75268c5123556d",
	"f932d7c9cd3819c1b7f19ecd2f98865d",
	"6b82b5e625a491338683f1e2ad1e1c56"
	};
	graphics = new string[] {
	"bb71591ef9f9c98202e4e054a849d4a5",
	"a64bb7e3ee68184a67701b4a5fa208c8",
	"75484eaa45bf9b23254f6e1f9842f23c",
	"f118934db6b09e7eb89468987529a12f",
	"93f60c655b90b17c7b7c94fd1ff268b4",
	"3f3b45ed7c489293de1660e37a783340",
	"2256517d4f930913c56d64b3898bbaf8",
	"12fc870223551c1957ecbb8043bbfa59",
	"717fd895d4c16d8bfce837abb3b6662e",
	"16c715d55c3dce58ce727c37d38e392b",
	"c2bab4660ff602b10ffbb178a9612484",
	"5f01c653b73e1776e87887044da8e378",
	"4be076b9bdeb8e752522c3928340bf22",
	"e614573f9afe095c5e487cd683ad11a6",
	"24aea8a678a66660ce02ce01b3ca0556",
	"926f56d10f762fe13a12b34004f035fc",
	"bb71591ef9f9c98202e4e054a849d4a5",
	"5a0025d10d09eebda87f6a736ff4d711",
	"00108681bbe1a2a19d8381e3e911007e",
	"0c8e79ba0ceff4afd2443cf1f6812ef9",
	"8dc9508ff530188dba18b9f1d11a2d85",
	"8df5889df1a125487f1346f77cafed78",
	"03ddc3a2f7445c9c31702b6b4bde7231",
	"ff9ec0d2800b378a5e2333a444364f4b",
	"7e6777820fa473733f0bb3850d11407c",
	"1709710247d4ebe24aafe70b5396ee05",
	"9754bc2267ac275a5aff375e2a8642db",
	"acdff4f4c31bc16aada1d1682a2e790c",
	"60e4a8a6a9c857544a3ae7f8943a004d",
	"a5a4623b18cfecdbdc8a9f9477345f60",
	"73348c8e5d8e691f2b0a33f29fd2d5ad",
	"77934b0a0cfe2a45af608ab2b0b0fa49",
	"260cddf70cfcb48b52a5b9934ff121bc",
	"68a67b48f66c4e98918778d4d372d681",
	"b0873a1eea02a18f230dea9b3ef26cca",
	"7d2b952eecc10ec8c8096712592129e7",
	"49641bb637990aa8fd23449fb3c940b2",
	"52834bf51caf05f01b341cb66df8e9f6",
	"11464373205c9a64b7008dd7d375dcfd",
	"41ce285429afa769668806ac885ba524",
	"b6b48b0d14d9543b328deb23da511719",
	"74fc1d2b460a64e6468e9fbaab172091",
	"eede00a81fc423a4af6f1faad3beae4f",
	"8a02cb5b396a8947da66f148c41979be",
	"7af5b8b9803a026a6f1cad603c24191d",
	"ed5c24a7e55e0e1d905beeea2ea78581",
	"ba45172ec5df46b15b1f1cacfb9f873f",
	"d260ff7b8c022a57c7d833705963cf69",
	"0863c5adf24371cd53dc314e49514f83",
	"011151d038c226185866da47d93709ee",
	"19d8a67a5dd29e057b9cd67d0a721d02",
	"eaabe044b76c1246fab54c1bbaf8ec24",
	"e8c252e84505ca6d425dc6f0311d1792",
	"5ebbad47c3d8047c63c8b7aaeac611d6",
	"b0397be40144ceb1a411c02f4ccd0b14",
	"77eed0741bafe8ca2b5277a056225ea3",
	"bc71c2febd7d26683da3614d787efa9e",
	"daaab2888b73c50ade99044627092fbb",
	"3d17bf1948fc08719a79dda4220f7414",
	"f6cf3dbcf44d1643a4e49a114e43b031",
	"0fba65f93670547cbc6bf3cef468fa10",
	"4f6775edac490a022aeb104e78de3b58",
	"e195b1a72f4a5acdaaff5ba072c99348",
	"492e67bcc45a53944cf06f968ef6b20c",
	"360737533503ce43b2b4ee8d98b5cde9",
	"14617866bcc70e557b25f5f81568a146",
	"92b3159c7e39c3589d521c6ac4e6f143",
	"55db5e5334b17892df06c86d138f83d5",
	"887dbc5be75b479efc84f996d1be46e9",
	"9e4073e71c5bc772abd55a0f6ec8ac0a",
	"d758d4e333fa06f25c864656713f15d4",
	"a15836fb133787e33f9b65c956ac3dd6",
	"f6add90aa665ab5f8ccb2b89d45c0dea",
	"81963da824697b66c553d53b04343f91",
	"8b1b9be19b1540455e47d746990aea95",
	"c4a575c61107f42d06a9fccd37e5dbc2",
	"a4034704789497aa5c6b6e847bbf615d",
	"b918d326dfc51fbbef4c07f606e24d5a",
	"41d8fdd90d91f30f5b6270a259e59238",
	"6a82051bed603bdde233ad8b9189a696",
	"b59cd6cb832ace70a7a0021717025aa6",
	"0043e25be3d55603dfa4bfa7eb00aac0",
	"d87d54f3f3f6053276347c1a421ec516",
	"9ef8c8a141f6af7d3429384af68c5d33",
	"283fe7fc5c6ecad8f96a99631c6f8806",
	"2f9a6d42c061d2e8cce27c8b1a03faa7",
	"2d14236a40163264e08b8eaf63007264",
	"b1a32075379e9d581cf18a6ff5e3d78a",
	"918ab392242c759623cf6af4aed7cd03",
	"9b644d0603f6d62e9be517d14dd6ffee",
	"dc7e7976b68aa59cfaa6ab9aa5017eb7",
	"513b86fad14b9d931bef45b5169b3263",
	"4bee1a85f22b294083c4bee1a62033e1",
	"476e57f24f511528b033e497435c4ee4",
	"ee669387ed4c5798c26e7ffe2a699f8b",
	"776f99b3c6d1cb8f173090f662e4b982",
	"23141169d46cd08b0a17a9644717ed03",
	"06ddbbe9f2265504b611b60c4c2a8908",
	"737b52548f12e8454c6924c79e9ff01d",
	"82f172bef7e1364549ecedc72c0498ea",
	"d61dd67acd3e45ed193ede5583c7ad99",
	"9fcce182c521ed5ef0dfcc861b080c0e",
	"a63511550dfd03fa209085700ede2b7e",
	"3b1d328f3e5529bdf7310b38dc2a29b8",
	"8c7d364c4b67c99a7951e5df7ce6b6ad",
	"1c879518a065cd841e2b3b1f55e94dbe",
	"655dfd2ac6d92320df42ac50195a8712",
	"d7792d73728ab43eb9f04f11a5bbe7cf",
	"e7dadefa4238a79cf6beff02742ebb55",
	"8843af1ec14397c0790ed938ecb6218a",
	"24b0a118d1528f2c1b87d0f2235e2f4a",
	"8dbd26055d38c39acbdceb620d1f8f61",
	"33182ef6bb080b652a52808e622b7890",
	"37ee17b8795c6db196592f39078885d5",
	"cb66ac4d1b78d95cac4065b2c5eaca3f",
	"843d7fe4dc391d9464c54aa9d1140a91",
	"69ab125e4b85c886041e929ae33d622a",
	"2fc16231661763b8b90f886c757369db",
	"a86922a53d675106ffa9fc8013b44afe",
	"ae8234f321ed73b57364eebf9b2020dd",
	"4fc456f714003aa510f2531116d6cae4",
	"3e4cc0293e2a09db76106ff8e338076b",
	"4864d7f09a240e7da0b14ebc8ce68329",
	"11ee93d34dc9883138b40278a4e26cf2",
	"bda1ca2e1040f4405a84d5c778c39c8d",
	"260c34c42611e6d89d8d890624e586f1",
	"05be9386ed825f699d05ea6b9f707833",
	"2fcdac312496c60ff09a685afb922e16",
	"18aeff3486f68353d722401682bf3155",
	"afc9f5f7d90ad7f0281cfe25c30b1814",
	"b8689c6015b2d8aceea484b55ede4ec2",
	"4d92a070a5170ecbbfe7d09d51e625fd",
	"a7cbeadf530b3d18799d2c992df0b43f",
	"c8e87cdbadbb0aa357ea4ed0519cbf2f",
	"ad38604527df7ff7c1dee49d87a7a2a0"
	};
	}
}
public class AttentionIcon : BitmapData{ 
	public AttentionIcon() {
		width = 65;
		height = 65;
		setPixels("c4a575c61107f42d06a9fccd37e5dbc2");
	}
}
public class AuraAmorLeftMenu : BitmapData{ 
	public AuraAmorLeftMenu() {
		width = 147;
		height = 133;
		setPixels("a5a4623b18cfecdbdc8a9f9477345f60");
	}
}
public class BackgroundBirthday : BitmapData{ 
	public BackgroundBirthday() {
		width = 468;
		height = 481;
		setPixels("9b644d0603f6d62e9be517d14dd6ffee");
	}
}
public class BankBottlesIcon : BitmapData{ 
	public BankBottlesIcon() {
		width = 18;
		height = 20;
		setPixels("e7dadefa4238a79cf6beff02742ebb55");
	}
}
public class BenefitArrowGreen : BitmapData{ 
	public BenefitArrowGreen() {
		width = 98;
		height = 46;
		setPixels("492e67bcc45a53944cf06f968ef6b20c");
	}
}
public class BenefitArrowYellow : BitmapData{ 
	public BenefitArrowYellow() {
		width = 137;
		height = 66;
		setPixels("2d14236a40163264e08b8eaf63007264");
	}
}
public class BenefitGreenBox : BitmapData{ 
	public BenefitGreenBox() {
		width = 64;
		height = 64;
		setPixels("f6add90aa665ab5f8ccb2b89d45c0dea");
	}
}
public class BenefitRedBox : BitmapData{ 
	public BenefitRedBox() {
		width = 65;
		height = 65;
		setPixels("2256517d4f930913c56d64b3898bbaf8");
	}
}
public class BgMafiaInfo : BitmapData{ 
	public BgMafiaInfo() {
		width = 530;
		height = 461;
		setPixels("7af5b8b9803a026a6f1cad603c24191d");
	}
}
public class BlotImage : BitmapData{ 
	public BlotImage() {
		width = 130;
		height = 124;
		setPixels("9e4073e71c5bc772abd55a0f6ec8ac0a");
	}
}
public class BombButton : SimpleButton{ 
	public BombButton() {
		downState = new symbol_0(){filters = new as3.Array(new object[]{})};
		overState = new symbol_0(){filters = new as3.Array(new object[]{})};
		upState = new symbol_0(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_1(){filters = new as3.Array(new object[]{})};
	}
}
public class Bonus1day : MovieClip{ 
	public Bonus1day() {
		var i31 = new symbol_2(){filters = new as3.Array(new object[]{})};
		addChild(i31);//0
	}
}
public class Bonus2day : MovieClip{ 
	public Bonus2day() {
		var i33 = new symbol_3(){filters = new as3.Array(new object[]{})};
		addChild(i33);//0
	}
}
public class Bonus3day : MovieClip{ 
	public Bonus3day() {
		var i35 = new symbol_4(){filters = new as3.Array(new object[]{})};
		addChild(i35);//0
	}
}
public class Bonus4day : MovieClip{ 
	public Bonus4day() {
		var i37 = new symbol_5(){filters = new as3.Array(new object[]{})};
		addChild(i37);//0
	}
}
public class Bonus5day : MovieClip{ 
	public Bonus5day() {
		var i39 = new symbol_6(){filters = new as3.Array(new object[]{})};
		addChild(i39);//0
	}
}
public class BonusSmall1 : BitmapData{ 
	public BonusSmall1() {
		width = 24;
		height = 26;
		setPixels("b918d326dfc51fbbef4c07f606e24d5a");
	}
}
public class BonusSmall2 : BitmapData{ 
	public BonusSmall2() {
		width = 24;
		height = 26;
		setPixels("1709710247d4ebe24aafe70b5396ee05");
	}
}
public class BonusSmall3 : BitmapData{ 
	public BonusSmall3() {
		width = 24;
		height = 26;
		setPixels("cb66ac4d1b78d95cac4065b2c5eaca3f");
	}
}
public class BonusSmall4 : BitmapData{ 
	public BonusSmall4() {
		width = 24;
		height = 26;
		setPixels("d61dd67acd3e45ed193ede5583c7ad99");
	}
}
public class BonusSmall5 : BitmapData{ 
	public BonusSmall5() {
		width = 24;
		height = 26;
		setPixels("49641bb637990aa8fd23449fb3c940b2");
	}
}
public class Bottles1 : BitmapData{ 
	public Bottles1() {
		width = 24;
		height = 53;
		setPixels("60e4a8a6a9c857544a3ae7f8943a004d");
	}
}
public class Bottles2 : BitmapData{ 
	public Bottles2() {
		width = 38;
		height = 57;
		setPixels("4bee1a85f22b294083c4bee1a62033e1");
	}
}
public class Bottles3 : BitmapData{ 
	public Bottles3() {
		width = 48;
		height = 58;
		setPixels("887dbc5be75b479efc84f996d1be46e9");
	}
}
public class Bottles4 : BitmapData{ 
	public Bottles4() {
		width = 58;
		height = 58;
		setPixels("8a02cb5b396a8947da66f148c41979be");
	}
}
public class Bottles5 : BitmapData{ 
	public Bottles5() {
		width = 64;
		height = 58;
		setPixels("b59cd6cb832ace70a7a0021717025aa6");
	}
}
public class BoxInfoIcon : BitmapData{ 
	public BoxInfoIcon() {
		width = 19;
		height = 11;
		setPixels("8843af1ec14397c0790ed938ecb6218a");
	}
}
public class BoxMutableBig : BitmapData{ 
	public BoxMutableBig() {
		width = 118;
		height = 143;
		setPixels("a4034704789497aa5c6b6e847bbf615d");
	}
}
public class BoxMutableBigDisabled : BitmapData{ 
	public BoxMutableBigDisabled() {
		width = 118;
		height = 143;
		setPixels("ee669387ed4c5798c26e7ffe2a699f8b");
	}
}
public class BoxMutableMedium : BitmapData{ 
	public BoxMutableMedium() {
		width = 94;
		height = 116;
		setPixels("4fc456f714003aa510f2531116d6cae4");
	}
}
public class BoxMutableMediumDisabled : BitmapData{ 
	public BoxMutableMediumDisabled() {
		width = 94;
		height = 116;
		setPixels("93f60c655b90b17c7b7c94fd1ff268b4");
	}
}
public class BoxMutableSmall : BitmapData{ 
	public BoxMutableSmall() {
		width = 73;
		height = 90;
		setPixels("1c879518a065cd841e2b3b1f55e94dbe");
	}
}
public class BoxMutableSmallDisabled : BitmapData{ 
	public BoxMutableSmallDisabled() {
		width = 73;
		height = 90;
		setPixels("11464373205c9a64b7008dd7d375dcfd");
	}
}
public class BoxWarningIcon : BitmapData{ 
	public BoxWarningIcon() {
		width = 33;
		height = 29;
		setPixels("9fcce182c521ed5ef0dfcc861b080c0e");
	}
}
public class ButtonPaymentGifts : SimpleButton{ 
	public ButtonPaymentGifts() {
		downState = new symbol_7(){filters = new as3.Array(new object[]{})};
		overState = new symbol_7(){filters = new as3.Array(new object[]{})};
		upState = new symbol_7(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_7(){filters = new as3.Array(new object[]{})};
	}
}
public class BuyShowsBankIcon : BitmapData{ 
	public BuyShowsBankIcon() {
		width = 34;
		height = 27;
		setPixels("8b1b9be19b1540455e47d746990aea95");
	}
}
public class BuyShowsBg1 : BitmapData{ 
	public BuyShowsBg1() {
		width = 74;
		height = 81;
		setPixels("d758d4e333fa06f25c864656713f15d4");
	}
}
public class BuyShowsBg2 : BitmapData{ 
	public BuyShowsBg2() {
		width = 84;
		height = 103;
		setPixels("b1a32075379e9d581cf18a6ff5e3d78a");
	}
}
public class BuyShowsBg3 : BitmapData{ 
	public BuyShowsBg3() {
		width = 102;
		height = 140;
		setPixels("d260ff7b8c022a57c7d833705963cf69");
	}
}
public class BuyShowsBg4 : BitmapData{ 
	public BuyShowsBg4() {
		width = 131;
		height = 140;
		setPixels("f6cf3dbcf44d1643a4e49a114e43b031");
	}
}
public class BuyShowsSmallBg : BitmapData{ 
	public BuyShowsSmallBg() {
		width = 54;
		height = 47;
		setPixels("8c7d364c4b67c99a7951e5df7ce6b6ad");
	}
}
public class CloseDialogBigImg : BitmapData{ 
	public CloseDialogBigImg() {
		width = 14;
		height = 15;
		setPixels("b0873a1eea02a18f230dea9b3ef26cca");
	}
}
public class DayBonusBg : MovieClip{ 
	public DayBonusBg() {
		var i46 = new symbol_8(){filters = new as3.Array(new object[]{})};
		addChild(i46);//0
	}
}
public class DayBonusBgFirst : MovieClip{ 
	public DayBonusBgFirst() {
		var i48 = new symbol_9(){filters = new as3.Array(new object[]{})};
		addChild(i48);//0
	}
}
public class DesignSelectedImg : BitmapData{ 
	public DesignSelectedImg() {
		width = 18;
		height = 18;
		setPixels("81963da824697b66c553d53b04343f91");
	}
}
public class DialogGreenTick : BitmapData{ 
	public DialogGreenTick() {
		width = 28;
		height = 24;
		setPixels("afc9f5f7d90ad7f0281cfe25c30b1814");
	}
}
public class DialogQuestAward : MovieClip{ 
	public DialogQuestAward() {
	}
}
public class EmptyFrameIcon : BitmapData{ 
	public EmptyFrameIcon() {
		width = 30;
		height = 30;
		setPixels("3e4cc0293e2a09db76106ff8e338076b");
	}
}
public class EverydayBonusTape : MovieClip{ 
	public EverydayBonusTape() {
		var i57 = new symbol_10(){filters = new as3.Array(new object[]{})};
		addChild(i57);//0
		var i58 = new symbol_11(){filters = new as3.Array(new object[]{})};
		addChild(i58);//1
		var i59 = new Bonus1day(){x = 76 , y = 57.5 , filters = new as3.Array(new object[]{})};
		addChild(i59);//2
		var i61 = new Bonus2day(){x = 212.6 , y = 57.5 , filters = new as3.Array(new object[]{})};
		addChild(i61);//3
		var i63 = new Bonus3day(){x = 360.6 , y = 61 , filters = new as3.Array(new object[]{})};
		addChild(i63);//4
		var i65 = new Bonus4day(){x = 510.1 , y = 60.5 , filters = new as3.Array(new object[]{})};
		addChild(i65);//5
		var i67 = new Bonus5day(){x = 647 , y = 60.5 , filters = new as3.Array(new object[]{})};
		addChild(i67);//6
		FrameInfo f;
		var l= new Frames(5);
		f = l.Add();
		f.Add(i57);
		f.Add(i58);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f += () => {
			i57.x = 0;
			i57.scaleX = 1;
			i57.y = 0;
			i57.scaleY = 1;
			i57.rotation = 0;
			i57.alpha = 1;
			i57.filters = new as3.Array(new object[]{});
			i57.scale9Grid = null;
			i57.visible = true;
			i58.x = 0;
			i58.scaleX = 1;
			i58.y = 0;
			i58.scaleY = 1;
			i58.rotation = 0;
			i58.alpha = 1;
			i58.filters = new as3.Array(new object[]{});
			i58.scale9Grid = null;
			i58.visible = true;
			i59.x = 76;
			i59.scaleX = 1;
			i59.y = 57.5;
			i59.scaleY = 1;
			i59.rotation = 0;
			i59.alpha = 1;
			i59.filters = new as3.Array(new object[]{});
			i59.scale9Grid = null;
			i59.visible = true;
			i61.x = 212.6;
			i61.scaleX = 1;
			i61.y = 57.5;
			i61.scaleY = 1;
			i61.rotation = 0;
			i61.alpha = 1;
			i61.filters = new as3.Array(new object[]{});
			i61.scale9Grid = null;
			i61.visible = true;
			i63.x = 360.6;
			i63.scaleX = 1;
			i63.y = 61;
			i63.scaleY = 1;
			i63.rotation = 0;
			i63.alpha = 1;
			i63.filters = new as3.Array(new object[]{});
			i63.scale9Grid = null;
			i63.visible = true;
			i65.x = 510.1;
			i65.scaleX = 1;
			i65.y = 60.5;
			i65.scaleY = 1;
			i65.rotation = 0;
			i65.alpha = 1;
			i65.filters = new as3.Array(new object[]{});
			i65.scale9Grid = null;
			i65.visible = true;
			i67.x = 647;
			i67.scaleX = 1;
			i67.y = 60.5;
			i67.scaleY = 1;
			i67.rotation = 0;
			i67.alpha = 1;
			i67.filters = new as3.Array(new object[]{});
			i67.scale9Grid = null;
			i67.visible = true;
		};
		f = l.Add();
		f.Add(i57);
		f.Add(i58);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f = l.Add();
		f.Add(i57);
		f.Add(i58);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f = l.Add();
		f.Add(i57);
		f.Add(i58);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		f = l.Add();
		f.Add(i57);
		f.Add(i58);
		f.Add(i59);
		f.Add(i61);
		f.Add(i63);
		f.Add(i65);
		f.Add(i67);
		setFrames(l);
	}
}
public class FacebookCardIcon : BitmapData{ 
	public FacebookCardIcon() {
		width = 140;
		height = 63;
		setPixels("74fc1d2b460a64e6468e9fbaab172091");
	}
}
public class FacebookCubeIcon : BitmapData{ 
	public FacebookCubeIcon() {
		width = 48;
		height = 55;
		setPixels("9ef8c8a141f6af7d3429384af68c5d33");
	}
}
public class FrameBirthday : BitmapData{ 
	public FrameBirthday() {
		width = 325;
		height = 303;
		setPixels("513b86fad14b9d931bef45b5169b3263");
	}
}
public class FreeBottlesIconEn : BitmapData{ 
	public FreeBottlesIconEn() {
		width = 66;
		height = 27;
		setPixels("03ddc3a2f7445c9c31702b6b4bde7231");
	}
}
public class FreeBottlesIconRu : BitmapData{ 
	public FreeBottlesIconRu() {
		width = 86;
		height = 27;
		setPixels("a86922a53d675106ffa9fc8013b44afe");
	}
}
public class GreenPlus : BitmapData{ 
	public GreenPlus() {
		width = 8;
		height = 9;
		setPixels("33182ef6bb080b652a52808e622b7890");
	}
}
public class GreenPopupImg : BitmapData{ 
	public GreenPopupImg() {
		width = 221;
		height = 55;
		setPixels("4be076b9bdeb8e752522c3928340bf22");
	}
}
public class HeartIcon : BitmapData{ 
	public HeartIcon() {
		width = 28;
		height = 25;
		setPixels("bda1ca2e1040f4405a84d5c778c39c8d");
	}
}
public class HeartsPiece : BitmapData{ 
	public HeartsPiece() {
		width = 402;
		height = 402;
		setPixels("a7cbeadf530b3d18799d2c992df0b43f");
	}
}
public class HeartsTextureImg : BitmapData{ 
	public HeartsTextureImg() {
		width = 283;
		height = 104;
		setPixels("d87d54f3f3f6053276347c1a421ec516");
	}
}
public class IconAdd : BitmapData{ 
	public IconAdd() {
		width = 25;
		height = 30;
		setPixels("24b0a118d1528f2c1b87d0f2235e2f4a");
	}
}
public class IconBarAmor : BitmapData{ 
	public IconBarAmor() {
		width = 32;
		height = 30;
		setPixels("5f01c653b73e1776e87887044da8e378");
	}
}
public class IconBarBackgound : BitmapData{ 
	public IconBarBackgound() {
		width = 44;
		height = 29;
		setPixels("eaabe044b76c1246fab54c1bbaf8ec24");
	}
}
public class IconBarCollection : BitmapData{ 
	public IconBarCollection() {
		width = 36;
		height = 35;
		setPixels("41d8fdd90d91f30f5b6270a259e59238");
	}
}
public class IconBarDecor : BitmapData{ 
	public IconBarDecor() {
		width = 30;
		height = 32;
		setPixels("92b3159c7e39c3589d521c6ac4e6f143");
	}
}
public class IconBarGift : BitmapData{ 
	public IconBarGift() {
		width = 9;
		height = 13;
		setPixels("37ee17b8795c6db196592f39078885d5");
	}
}
public class IconBarHat : BitmapData{ 
	public IconBarHat() {
		width = 15;
		height = 10;
		setPixels("4f6775edac490a022aeb104e78de3b58");
	}
}
public class IconBarHatMafia : BitmapData{ 
	public IconBarHatMafia() {
		width = 17;
		height = 11;
		setPixels("00108681bbe1a2a19d8381e3e911007e");
	}
}
public class IconBarHeart : BitmapData{ 
	public IconBarHeart() {
		width = 12;
		height = 10;
		setPixels("eede00a81fc423a4af6f1faad3beae4f");
	}
}
public class IconBarHeartMafia : BitmapData{ 
	public IconBarHeartMafia() {
		width = 14;
		height = 13;
		setPixels("77934b0a0cfe2a45af608ab2b0b0fa49");
	}
}
public class IconBarKiss : BitmapData{ 
	public IconBarKiss() {
		width = 17;
		height = 11;
		setPixels("e614573f9afe095c5e487cd683ad11a6");
	}
}
public class IconBarLeaders : BitmapData{ 
	public IconBarLeaders() {
		width = 48;
		height = 32;
		setPixels("ff9ec0d2800b378a5e2333a444364f4b");
	}
}
public class IconBarLeadersEng : BitmapData{ 
	public IconBarLeadersEng() {
		width = 37;
		height = 32;
		setPixels("77eed0741bafe8ca2b5277a056225ea3");
	}
}
public class IconBarMessage : BitmapData{ 
	public IconBarMessage() {
		width = 13;
		height = 13;
		setPixels("bb71591ef9f9c98202e4e054a849d4a5");
	}
}
public class IconBarMessagePersonal : BitmapData{ 
	public IconBarMessagePersonal() {
		width = 13;
		height = 12;
		setPixels("3d17bf1948fc08719a79dda4220f7414");
	}
}
public class IconBarPet : BitmapData{ 
	public IconBarPet() {
		width = 32;
		height = 34;
		setPixels("e8c252e84505ca6d425dc6f0311d1792");
	}
}
public class IconBarPicGrade : BitmapData{ 
	public IconBarPicGrade() {
		width = 14;
		height = 13;
		setPixels("daaab2888b73c50ade99044627092fbb");
	}
}
public class IconBarRoomItem : BitmapData{ 
	public IconBarRoomItem() {
		width = 28;
		height = 30;
		setPixels("a15836fb133787e33f9b65c956ac3dd6");
	}
}
public class IconBarRoomPack : BitmapData{ 
	public IconBarRoomPack() {
		width = 39;
		height = 31;
		setPixels("3f3b45ed7c489293de1660e37a783340");
	}
}
public class IconBarShows : BitmapData{ 
	public IconBarShows() {
		width = 34;
		height = 32;
		setPixels("9754bc2267ac275a5aff375e2a8642db");
	}
}
public class IconBarSticker : BitmapData{ 
	public IconBarSticker() {
		width = 32;
		height = 39;
		setPixels("06ddbbe9f2265504b611b60c4c2a8908");
	}
}
public class IconBarTime : BitmapData{ 
	public IconBarTime() {
		width = 12;
		height = 12;
		setPixels("a64bb7e3ee68184a67701b4a5fa208c8");
	}
}
public class IconBarTop : BitmapData{ 
	public IconBarTop() {
		width = 47;
		height = 29;
		setPixels("55db5e5334b17892df06c86d138f83d5");
	}
}
public class IconBarVipM : BitmapData{ 
	public IconBarVipM() {
		width = 43;
		height = 34;
		setPixels("73348c8e5d8e691f2b0a33f29fd2d5ad");
	}
}
public class IconBarVipW : BitmapData{ 
	public IconBarVipW() {
		width = 43;
		height = 32;
		setPixels("926f56d10f762fe13a12b34004f035fc");
	}
}
public class IconBarWinMafia : BitmapData{ 
	public IconBarWinMafia() {
		width = 13;
		height = 13;
		setPixels("737b52548f12e8454c6924c79e9ff01d");
	}
}
public class IconBow : BitmapData{ 
	public IconBow() {
		width = 56;
		height = 28;
		setPixels("dc7e7976b68aa59cfaa6ab9aa5017eb7");
	}
}
public class IconCheckBox : BitmapData{ 
	public IconCheckBox() {
		width = 20;
		height = 20;
		setPixels("82f172bef7e1364549ecedc72c0498ea");
	}
}
public class IconCollectionBox : BitmapData{ 
	public IconCollectionBox() {
		width = 29;
		height = 26;
		setPixels("14617866bcc70e557b25f5f81568a146");
	}
}
public class IconInfo : BitmapData{ 
	public IconInfo() {
		width = 20;
		height = 20;
		setPixels("ae8234f321ed73b57364eebf9b2020dd");
	}
}
public class IconInviteFriends : BitmapData{ 
	public IconInviteFriends() {
		width = 38;
		height = 35;
		setPixels("24aea8a678a66660ce02ce01b3ca0556");
	}
}
public class IconManBig : BitmapData{ 
	public IconManBig() {
		width = 80;
		height = 79;
		setPixels("05be9386ed825f699d05ea6b9f707833");
	}
}
public class IconMutableBoxBottle : BitmapData{ 
	public IconMutableBoxBottle() {
		width = 16;
		height = 20;
		setPixels("8dc9508ff530188dba18b9f1d11a2d85");
	}
}
public class IconMutableBoxPhoto : BitmapData{ 
	public IconMutableBoxPhoto() {
		width = 18;
		height = 21;
		setPixels("6a82051bed603bdde233ad8b9189a696");
	}
}
public class IconMutableCheck : BitmapData{ 
	public IconMutableCheck() {
		width = 19;
		height = 14;
		setPixels("260c34c42611e6d89d8d890624e586f1");
	}
}
public class IconMutableClock : BitmapData{ 
	public IconMutableClock() {
		width = 16;
		height = 19;
		setPixels("0043e25be3d55603dfa4bfa7eb00aac0");
	}
}
public class IconPartOk : BitmapData{ 
	public IconPartOk() {
		width = 14;
		height = 12;
		setPixels("19d8a67a5dd29e057b9cd67d0a721d02");
	}
}
public class IconPlusGray : BitmapData{ 
	public IconPlusGray() {
		width = 14;
		height = 13;
		setPixels("3b1d328f3e5529bdf7310b38dc2a29b8");
	}
}
public class IconPriceMutable : BitmapData{ 
	public IconPriceMutable() {
		width = 88;
		height = 100;
		setPixels("11ee93d34dc9883138b40278a4e26cf2");
	}
}
public class IconSelectedCheckBox : BitmapData{ 
	public IconSelectedCheckBox() {
		width = 8;
		height = 8;
		setPixels("16c715d55c3dce58ce727c37d38e392b");
	}
}
public class IconSub : BitmapData{ 
	public IconSub() {
		width = 25;
		height = 30;
		setPixels("41ce285429afa769668806ac885ba524");
	}
}
public class IconWomanBig : BitmapData{ 
	public IconWomanBig() {
		width = 52;
		height = 82;
		setPixels("0863c5adf24371cd53dc314e49514f83");
	}
}
public class ImageGetBonus : BitmapData{ 
	public ImageGetBonus() {
		width = 129;
		height = 54;
		setPixels("7d2b952eecc10ec8c8096712592129e7");
	}
}
public class ImageGetBonusEN : BitmapData{ 
	public ImageGetBonusEN() {
		width = 129;
		height = 54;
		setPixels("4d92a070a5170ecbbfe7d09d51e625fd");
	}
}
public class IndefiniteImg : BitmapData{ 
	public IndefiniteImg() {
		width = 22;
		height = 37;
		setPixels("ad38604527df7ff7c1dee49d87a7a2a0");
	}
}
public class InfoIconImg : BitmapData{ 
	public InfoIconImg() {
		width = 21;
		height = 20;
		setPixels("4864d7f09a240e7da0b14ebc8ce68329");
	}
}
public class InviteBackground : BitmapData{ 
	public InviteBackground() {
		width = 649;
		height = 483;
		setPixels("2fc16231661763b8b90f886c757369db");
	}
}
public class InviteBackgroundSmall : BitmapData{ 
	public InviteBackgroundSmall() {
		width = 649;
		height = 433;
		setPixels("c2bab4660ff602b10ffbb178a9612484");
	}
}
public class InviteCaptionEn : BitmapData{ 
	public InviteCaptionEn() {
		width = 538;
		height = 160;
		setPixels("a63511550dfd03fa209085700ede2b7e");
	}
}
public class InviteCaptionRu : BitmapData{ 
	public InviteCaptionRu() {
		width = 449;
		height = 160;
		setPixels("0fba65f93670547cbc6bf3cef468fa10");
	}
}
public class InviteImage : BitmapData{ 
	public InviteImage() {
		width = 361;
		height = 198;
		setPixels("75484eaa45bf9b23254f6e1f9842f23c");
	}
}
public class MafiaIntroBg : BitmapData{ 
	public MafiaIntroBg() {
		width = 450;
		height = 449;
		setPixels("476e57f24f511528b033e497435c4ee4");
	}
}
public class MoneyBoxImage : BitmapData{ 
	public MoneyBoxImage() {
		width = 85;
		height = 156;
		setPixels("68a67b48f66c4e98918778d4d372d681");
	}
}
public class MoneyBoxScaleFill : BitmapData{ 
	public MoneyBoxScaleFill() {
		width = 148;
		height = 15;
		setPixels("918ab392242c759623cf6af4aed7cd03");
	}
}
public class MoneyBoxScaleFull : BitmapData{ 
	public MoneyBoxScaleFull() {
		width = 226;
		height = 47;
		setPixels("f118934db6b09e7eb89468987529a12f");
	}
}
public class MoneyBoxTypes : BitmapData{ 
	public MoneyBoxTypes() {
		width = 281;
		height = 115;
		setPixels("23141169d46cd08b0a17a9644717ed03");
	}
}
public class MutableCaptionEn : BitmapData{ 
	public MutableCaptionEn() {
		width = 280;
		height = 61;
		setPixels("2f9a6d42c061d2e8cce27c8b1a03faa7");
	}
}
public class MutableCaptionRu : BitmapData{ 
	public MutableCaptionRu() {
		width = 356;
		height = 67;
		setPixels("843d7fe4dc391d9464c54aa9d1140a91");
	}
}
public class MutableHintBig : BitmapData{ 
	public MutableHintBig() {
		width = 122;
		height = 101;
		setPixels("011151d038c226185866da47d93709ee");
	}
}
public class MutableHintMedium : BitmapData{ 
	public MutableHintMedium() {
		width = 104;
		height = 80;
		setPixels("12fc870223551c1957ecbb8043bbfa59");
	}
}
public class MutableHintSmall : BitmapData{ 
	public MutableHintSmall() {
		width = 90;
		height = 71;
		setPixels("8df5889df1a125487f1346f77cafed78");
	}
}
public class MutableIconBottles : BitmapData{ 
	public MutableIconBottles() {
		width = 29;
		height = 40;
		setPixels("5ebbad47c3d8047c63c8b7aaeac611d6");
	}
}
public class MutableIconShows : BitmapData{ 
	public MutableIconShows() {
		width = 31;
		height = 40;
		setPixels("260cddf70cfcb48b52a5b9934ff121bc");
	}
}
public class MutableTimeIcon : BitmapData{ 
	public MutableTimeIcon() {
		width = 18;
		height = 19;
		setPixels("69ab125e4b85c886041e929ae33d622a");
	}
}
public class PhotoButtonPlus : SimpleButton{ 
	public PhotoButtonPlus() {
		downState = new symbol_17(){filters = new as3.Array(new object[]{})};
		overState = new symbol_17(){filters = new as3.Array(new object[]{})};
		upState = new symbol_17(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_17(){filters = new as3.Array(new object[]{})};
	}
}
public class PhotoLikesBankIcon : BitmapData{ 
	public PhotoLikesBankIcon() {
		width = 18;
		height = 16;
		setPixels("360737533503ce43b2b4ee8d98b5cde9");
	}
}
public class RedCaption : BitmapData{ 
	public RedCaption() {
		width = 672;
		height = 62;
		setPixels("b0397be40144ceb1a411c02f4ccd0b14");
	}
}
public class SlotClip : MovieClip{ 
	public SlotClip() {
		var i75 = new symbol_19(){x = 0.1 , scaleX = 1.01 , scaleY = 1.02 , filters = new as3.Array(new object[]{})};
		addChild(i75);//0
		FrameInfo f;
		var l= new Frames(8);
		f = l.Add();
		f.Add(i75);
		f += () => {
			i75.x = 0.1;
			i75.scaleX = 1.01;
			i75.y = 0;
			i75.scaleY = 1.02;
			i75.rotation = 0;
			i75.alpha = 1;
			i75.filters = new as3.Array(new object[]{});
			i75.scale9Grid = null;
			i75.visible = true;
		};
		f = l.Add();
		f.Add(i75);
		f += () => {
			i75.x = -0.1;
			i75.scaleX = 1.04;
			i75.y = 1.1;
			i75.scaleY = 0.99;
		};
		f = l.Add();
		f.Add(i75);
		f += () => {
			i75.x = -0.3;
			i75.scaleX = 1.08;
			i75.y = 2.1;
			i75.scaleY = 0.96;
		};
		f = l.Add();
		f.Add(i75);
		f += () => {
			i75.x = -0.5;
			i75.scaleX = 1.11;
			i75.y = 3.2;
			i75.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i75);
		f += () => {
			i75.x = -0.3;
			i75.scaleX = 1.07;
			i75.y = 1.8;
			i75.scaleY = 0.97;
		};
		f = l.Add();
		f.Add(i75);
		f += () => {
			i75.x = -0.1;
			i75.scaleX = 1.04;
			i75.y = 0.8;
			i75.scaleY = 1;
		};
		f = l.Add();
		f.Add(i75);
		f += () => {
			i75.x = 0;
			i75.scaleX = 1.02;
			i75.y = 0.2;
			i75.scaleY = 1.01;
		};
		f = l.Add();
		f.Add(i75);
		f += () => {
			i75.scaleX = 1.01;
			i75.y = 0;
			i75.scaleY = 1.02;
		};
		setFrames(l);
	}
}
public class SpinnerClip : MovieClip{ 
	public SpinnerClip() {
		var i78 = new symbol_20(){filters = new as3.Array(new object[]{})};
		addChild(i78);//0
		FrameInfo f;
		var l= new Frames(74);
		f = l.Add();
		f.Add(i78);
		f += () => {
			i78.x = 0;
			i78.scaleX = 1;
			i78.y = 0;
			i78.scaleY = 1;
			i78.rotation = 0;
			i78.alpha = 1;
			i78.filters = new as3.Array(new object[]{});
			i78.scale9Grid = null;
			i78.visible = true;
		};
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		f = l.Add();
		f.Add(i78);
		setFrames(l);
	}
}
public class StarsBg : BitmapData{ 
	public StarsBg() {
		width = 219;
		height = 30;
		setPixels("c8e87cdbadbb0aa357ea4ed0519cbf2f");
	}
}
public class StarsBgMini : BitmapData{ 
	public StarsBgMini() {
		width = 110;
		height = 34;
		setPixels("18aeff3486f68353d722401682bf3155");
	}
}
public class TimerIcon : BitmapData{ 
	public TimerIcon() {
		width = 16;
		height = 16;
		setPixels("7e6777820fa473733f0bb3850d11407c");
	}
}
public class WhiteTickInCircleR26 : BitmapData{ 
	public WhiteTickInCircleR26() {
		width = 26;
		height = 26;
		setPixels("655dfd2ac6d92320df42ac50195a8712");
	}
}
public class YouGiftTextImg : BitmapData{ 
	public YouGiftTextImg() {
		width = 306;
		height = 52;
		setPixels("776f99b3c6d1cb8f173090f662e4b982");
	}
}
public class YouGiftTextImgEn : BitmapData{ 
	public YouGiftTextImgEn() {
		width = 306;
		height = 60;
		setPixels("bc71c2febd7d26683da3614d787efa9e");
	}
}
namespace dialogs.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("80b62bffda30eb56e0f87217bbc5e5aa", -7, -3, 47, 47, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("6b82b5e625a491338683f1e2ad1e1c56", -0.2, -0.7, 34.75, 39.7, 1, 1);
		}
	}
	public class symbol_10 : Shape{ 
		public symbol_10() {
			setGraphics("9e03e247b1846a702b7df46286ea1221", 0, 0, 720.05, 100.1, 1, 1);
		}
	}
	public class symbol_11 : Shape{ 
		public symbol_11() {
			setGraphics("f932d7c9cd3819c1b7f19ecd2f98865d", 0, -0.1, 720, 100.1, 1, 1);
		}
	}
	public class symbol_12 : Shape{ 
		public symbol_12() {
			setGraphics("6bdcc7c919c70efe1e12fbbc84f5fc4f", -18, -28.5, 36, 57, 1, 1);
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("38130598ac831e721a67f121043ad1fc", -24.5, -28.5, 49, 57, 1, 1);
		}
	}
	public class symbol_14 : Shape{ 
		public symbol_14() {
			setGraphics("d5d2b14fcd90c516076cfb7806185adf", -29.5, -32, 59, 64, 1, 1);
		}
	}
	public class symbol_15 : Shape{ 
		public symbol_15() {
			setGraphics("99686abedc14a10cc5256dc6510a7eda", -35, -31.5, 70, 63, 1, 1);
		}
	}
	public class symbol_16 : Shape{ 
		public symbol_16() {
			setGraphics("1808b3bb7c40ed17de58e32429ced9a9", -38, -31.5, 76, 63, 1, 1);
		}
	}
	public class symbol_17 : Shape{ 
		public symbol_17() {
			setGraphics("d36d313459b99dabf0de4da938a1b974", 0, 0, 28, 28, 1, 1);
		}
	}
	public class symbol_18 : Shape{ 
		public symbol_18() {
			setGraphics("d9e1523a31c46dee4b75268c5123556d", -37, -52, 76, 91, 1, 1);
		}
	}
	public class symbol_19 : MovieClip{ 
		public symbol_19() {
			var i76 = new symbol_18(){filters = new as3.Array(new object[]{})};
			addChild(i76);//0
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("6bdcc7c919c70efe1e12fbbc84f5fc4f", -18, -28.5, 36, 57, 1, 1);
		}
	}
	public class symbol_20 : Shape{ 
		public symbol_20() {
			setGraphics("064d703136ea0bdc477ead42ec18bf98", 0, 0, 150, 14, 1, 1);
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("38130598ac831e721a67f121043ad1fc", -24.5, -28.5, 49, 57, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("d5d2b14fcd90c516076cfb7806185adf", -29.5, -32, 59, 64, 1, 1);
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("99686abedc14a10cc5256dc6510a7eda", -35, -31.5, 70, 63, 1, 1);
		}
	}
	public class symbol_6 : Shape{ 
		public symbol_6() {
			setGraphics("1808b3bb7c40ed17de58e32429ced9a9", -38, -31.5, 76, 63, 1, 1);
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("94e32216cf2228f92643790839ba23cf", 0, 0, 55, 48, 1, 1);
		}
	}
	public class symbol_8 : Shape{ 
		public symbol_8() {
			setGraphics("d87dac96c2f261b833330be5d024e31a", -10, 0, 114.95, 60, 1, 1);
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("c8efb7ce037f2fd1d56b84677129bd33", 0, 0, 104.65, 60, 1, 1);
		}
	}
}
