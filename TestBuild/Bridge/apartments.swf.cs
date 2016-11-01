using System;
using flash.display;
using apartments.swf.privateSymbols;
using RockiePlayer;
using as3;
using flash.filters;

public class Libapartments : ResourcesExternalLib{
	public Libapartments() {
	vectors = new string[] {
	"f4b48fa2a2ab5825a8bc47a002ed8ca2",
	"6e800b2e516ca989a6a1ba76c771f243",
	"64280531ef7be4177e6d593922525e05",
	"6ba690121378ce97359f0359d0518209",
	"1f582392bb7df7d0603cffb2ebe2093b",
	"e285c6116da9255aea31706fa53add7e",
	"e3ed11c091275757d01081836293fbaa",
	"50e543013d4e3276c09322dbbf1220d4",
	"d38118094c9fd17b91492b77434b53ba",
	"ea17057b9068750c3bb366e097976088",
	"c618a62900f30d89e25c90eb72c3c3af",
	"debf0ab35b9bad0188214d6e4b5d7215",
	"af4761442da5bca2a0207ae05f371e61",
	"2198748673b5c5b4ae98cc96bc39026a",
	"31548d66f82ff788317b6dd109563ce4",
	"151b04cd31fb0efdc5b4fc6bdc3ad254",
	"00689f6f758c8b7c2dbfdf1535c36fe8",
	"8fdc6dcea79f043cdea0dd6c964b0254",
	"0a25a7360321c5d4b9b29d998ab28e5d",
	"57e51541bc6e0ba8c43c67ac9cd5eb4b",
	"44b8d1f571f2e6df894e5aaceef12b8c",
	"6929e302349afe70cac2451e65744c4f",
	"8a61e6ff31d58e46257b871953fd3732",
	"f7602b5fea95a083f431dbb9d70d50ce",
	"628b2c8d0fac02a80ae7f816985ddeb3",
	"ab9ac661f900a9327a9cecc1a5ce1439",
	"5946c5846832535ec3e964660d751ad1",
	"19f522a4be23119d1aa2de1acfcf8017",
	"eb070a324ab016fdccde8c0faa165201",
	"d525ed62d1773a0313ecee6bf764bd7f",
	"74e08245199deeb1861110b822f35305",
	"dc7a6ddccf2160e6d0c130641c095714",
	"64a20c7d775713aed7423bc07cfceca9",
	"c211cdb2b5099939e882eb5a1fcbdd92",
	"5a26e2b8a41e4fe4bbf4151f731f0df6",
	"fd3dad08f703bab2a566057d712cfc88",
	"830668633713170e05009cbb3cb4c0ad",
	"ea77703b220de1ebfcb19a136055eea5",
	"909854f53dd8ec122a6d78f407f9dc9c",
	"6a2044032be0ad9274a0623f594c006e",
	"629afa1be7a1ab4692a981479bc97f0c",
	"2266a3064508c34da7439bd9e4c37609",
	"82a6de580cbc21cb624304076797b205",
	"ac435da99791341375b9b150c473e2f5",
	"71c767165fcd172fd1a93c80db8a2131",
	"9a478cc8e74a234eab39e08d6022f4a9",
	"3a38ebc54936e513ed45792e6c2186ee",
	"0f912d19ab7db633d6586ea11b4c1d6f",
	"9bd3110ab665ce7ca210abd0644b0c6b",
	"9e3281c620218beb5c2bc2cfbaef3d8d",
	"a0eee9a4b03890824bce8eb997fe8da0",
	"2551f7be311f582b80b1e779c2e8467b",
	"335591bc3fbc2fed909665430af6e723",
	"d6491a2bdc33d728537acaae265c00b7",
	"a3865a841cd721caec02fc047258299f",
	"cf96f2f72e16654de1bf3b5c1414474b",
	"4a8e2f2de5939eb9c3f0c1d993f9f112",
	"194dea5e2e366ffa72889aeb8fd40737",
	"7ca2e38bec24029bb05594e256a06c92",
	"e51e0d834d2c69f71c92915165945dba"
	};
	graphics = new string[] {
	"79bf4ce5c9becd3c872ec92dc7adc385",
	"c5dcae2aa7fa5a1278f33fce0d8feee6",
	"30be8cddd53bbf6ddb158863ac20f196",
	"a554718ae03bceacb4a172d86a94a030",
	"27b60defeff1f4934060f0009ade4fc8",
	"5bd9410d4b2991d7fd28c2b04fffc334",
	"6df9d92ba9d00eb5b071fdfe76814e64",
	"56700766d6e277df22f4c68901c572fc",
	"1984fcb02d703252c81b9d5aebe03387",
	"ffbfbce97388540f4ac9a64f1717506b",
	"98cbdb816246dd9818b10c3216efb5ac",
	"870ee3d5d3882941f7a6acd9883d4ba8",
	"c5ae397b838fe8800c8733acf8adabd4",
	"65bb978fa39ca3a8f997723e2c5b8d3c",
	"24098c84dc310b153d1d9a85f63cf5ce",
	"02efe0e1612447cd5b9f497223012568",
	"c5b5f8ca9ef350e41ccf79a84f05286d",
	"c2671b24af62d7d0f2902700076f5971",
	"38b187385f48bb01865959b4b2f082f1",
	"0d093b0254dd0e7dcd3f52f3976aae41",
	"57417b189d126777c93401d3639e72ba",
	"49c47c245fe129e258d005991aba53ff",
	"a049acac72652514f735334d28c88ac6",
	"b4f1acbe2d062a31e7a1fd55c1065b73",
	"114c79019b159b876e94c8495c1aa8f2",
	"771231d72f5339894dfa1cd8091342be",
	"3f2441dd8fa654b953f37fe56cbd98e2",
	"5dd61d7a9aa778f037a290884f70d5b0",
	"139e0178653a71ca300191fdfeb70421",
	"f4cef59208094134061174424a470158",
	"d373318adc625eeebc1c357922d31514",
	"32c0c76fb4c89b7c330f0098fecfec6d",
	"35a6ce7b608d1dcbe460c78c64115a2b",
	"1629c72003a14a1cc548e6308741ef96",
	"1a14082e32227b0b1ac7dc590739a8be",
	"cfde93cf7642f57682796fe89e3dc757",
	"a1a75fd2853b7028b8eb00170e5b7056",
	"5dbfda06a5ccece06b6759e120837e06",
	"2ca5fa3215289170e53ee1cfe57e5606"
	};
	}
}
public class ActiveRadioImg : BitmapData{ 
	public ActiveRadioImg() {
		width = 18;
		height = 18;
		setPixels("a049acac72652514f735334d28c88ac6");
	}

	private void setPixels(string v)
	{
		throw new NotImplementedException();
	}
}
public class ArrowsInCircle : BitmapData{ 
	public ArrowsInCircle() {
		width = 20;
		height = 20;
		setPixels("d373318adc625eeebc1c357922d31514");
	}
}
public class AtticButtonBg : BitmapData{ 
	public AtticButtonBg() {
		width = 81;
		height = 30;
		setPixels("5dbfda06a5ccece06b6759e120837e06");
	}
}
public class BlinkMovie : MovieClip{ 
	public BlinkMovie() {
		var i206 = new symbol_6();
		addChild(i206);//0
		var i205 = new symbol_6();
		addChild(i205);//0
		var i202 = new symbol_6();
		addChild(i202);//0
		var i204 = new symbol_6();
		addChild(i204);//0
		var i208 = new symbol_6();
		addChild(i208);//0
		var i207 = new symbol_6();
		addChild(i207);//0
		var i203 = new symbol_6();
		addChild(i203);//0
		FrameInfo f;
		var l= new Frames(28);
		f = l.Add();//0
		f = l.Add();//1
		f.Add(i202);
		f += () => {
			i202.x = 0;
			i202.scaleX = 1;
			i202.y = 0;
			i202.scaleY = 1;
			i202.rotation = 0;
			i202.alpha = 1;
			i202.filters = null;
			i202.graphicsHash = "64280531ef7be4177e6d593922525e05";
			i202.visible = true;
		};
		f = l.Add();//2
		f.Add(i202);
		f += () => {
			i202.graphicsHash = "64280531ef7be4177e6d593922525e05";
		};
		f = l.Add();//3
		f = l.Add();//4
		f = l.Add();//5
		f.Add(i203);
		f += () => {
			i203.x = 0;
			i203.scaleX = 1;
			i203.y = 0;
			i203.scaleY = 1;
			i203.rotation = 0;
			i203.alpha = 1;
			i203.filters = null;
			i203.graphicsHash = "64280531ef7be4177e6d593922525e05";
			i203.visible = true;
		};
		f = l.Add();//6
		f.Add(i203);
		f += () => {
			i203.graphicsHash = "64280531ef7be4177e6d593922525e05";
		};
		f = l.Add();//7
		f = l.Add();//8
		f = l.Add();//9
		f.Add(i204);
		f += () => {
			i204.x = 0;
			i204.scaleX = 1;
			i204.y = 0;
			i204.scaleY = 1;
			i204.rotation = 0;
			i204.alpha = 1;
			i204.filters = null;
			i204.graphicsHash = "64280531ef7be4177e6d593922525e05";
			i204.visible = true;
		};
		f = l.Add();//10
		f.Add(i204);
		f += () => {
			i204.graphicsHash = "64280531ef7be4177e6d593922525e05";
		};
		f = l.Add();//11
		f = l.Add();//12
		f = l.Add();//13
		f.Add(i205);
		f += () => {
			i205.x = 0;
			i205.scaleX = 1;
			i205.y = 0;
			i205.scaleY = 1;
			i205.rotation = 0;
			i205.alpha = 1;
			i205.filters = null;
			i205.graphicsHash = "64280531ef7be4177e6d593922525e05";
			i205.visible = true;
		};
		f = l.Add();//14
		f.Add(i205);
		f += () => {
			i205.graphicsHash = "64280531ef7be4177e6d593922525e05";
		};
		f = l.Add();//15
		f = l.Add();//16
		f = l.Add();//17
		f.Add(i206);
		f += () => {
			i206.x = 0;
			i206.scaleX = 1;
			i206.y = 0;
			i206.scaleY = 1;
			i206.rotation = 0;
			i206.alpha = 1;
			i206.filters = null;
			i206.graphicsHash = "64280531ef7be4177e6d593922525e05";
			i206.visible = true;
		};
		f = l.Add();//18
		f.Add(i206);
		f += () => {
			i206.graphicsHash = "64280531ef7be4177e6d593922525e05";
		};
		f = l.Add();//19
		f = l.Add();//20
		f = l.Add();//21
		f.Add(i207);
		f += () => {
			i207.x = 0;
			i207.scaleX = 1;
			i207.y = 0;
			i207.scaleY = 1;
			i207.rotation = 0;
			i207.alpha = 1;
			i207.filters = null;
			i207.graphicsHash = "64280531ef7be4177e6d593922525e05";
			i207.visible = true;
		};
		f = l.Add();//22
		f.Add(i207);
		f += () => {
			i207.graphicsHash = "64280531ef7be4177e6d593922525e05";
		};
		f = l.Add();//23
		f = l.Add();//24
		f = l.Add();//25
		f.Add(i208);
		f += () => {
			i208.x = 0;
			i208.scaleX = 1;
			i208.y = 0;
			i208.scaleY = 1;
			i208.rotation = 0;
			i208.alpha = 1;
			i208.filters = null;
			i208.graphicsHash = "64280531ef7be4177e6d593922525e05";
			i208.visible = true;
		};
		f = l.Add();//26
		f.Add(i208);
		f += () => {
			i208.graphicsHash = "64280531ef7be4177e6d593922525e05";
		};
		f = l.Add();//27
		setFrames(l);
		addFrameScript(27, ()=>{stop();});
	}
}
public class BlueArrow : BitmapData{ 
	public BlueArrow() {
		width = 14;
		height = 9;
		setPixels("6df9d92ba9d00eb5b071fdfe76814e64");
	}
}
public class BoxOpenPetMovie2 : MovieClip{ 
	public BoxOpenPetMovie2() {
		var filter_0 = new GlowFilter(){strength = 1, color = 16777134, blurX = 5, blurY = 5};
		var i210 = new symbol_8(){x = -5.6 , alpha = 0.4 , y = 28.3};
		addChild(i210);//0
		var i212 = new symbol_10(){y = -8.8 , x = -5.6};
		addChild(i212);//1
		var i222 = new symbol_18(){x = 22.3 , scaleX = 0.87 , y = -16 , scaleY = 1.18};
		addChild(i222);//1
		var i224 = new symbol_20(){x = -11.8 , scaleX = 0.87 , y = -10.6 , scaleY = 1.18};
		addChild(i224);//2
		var i214 = new symbol_12(){y = -3.6 , x = -48.1};
		addChild(i214);//2
		var i216 = new symbol_14(){y = -8 , x = 29.2};
		addChild(i216);//3
		var i226 = new symbol_22(){x = -14.4 , scaleX = 0.87 , y = -10.6 , scaleY = 1.18};
		addChild(i226);//3
		var i228 = new symbol_24(){x = -11.4 , scaleX = 0.87 , y = 1.1 , scaleY = 1.18};
		addChild(i228);//4
		var i218 = new symbol_16(){y = -3.6 , x = 19.8};
		addChild(i218);//4
		var i230 = new symbol_26(){x = -4.7 , scaleX = 0.87 , y = -60.3 , scaleY = 1.18};
		addChild(i230);//5
		var i220 = new apartments_fla.open_24(){x = -3.8 , y = -3.8 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i220);//5
		var i232 = new symbol_28(){x = -7.5 , scaleX = 0.87 , y = -60.3 , scaleY = 1.18};
		addChild(i232);//6
		FrameInfo f;
		var l= new Frames(21);
		f = l.Add();//0
		f.Add(i210);
		f.Add(i212);
		f.Add(i214);
		f.Add(i216);
		f.Add(i218);
		f += () => {
			i210.x = -5.6;
			i210.scaleX = 1;
			i210.y = 28.3;
			i210.scaleY = 1;
			i210.rotation = 0;
			i210.alpha = 0.4;
			i210.filters = null;
			i210.visible = true;
			i212.x = -5.6;
			i212.scaleX = 1;
			i212.y = -8.8;
			i212.scaleY = 1;
			i212.rotation = 0;
			i212.alpha = 1;
			i212.filters = null;
			i212.visible = true;
			i214.x = -48.1;
			i214.scaleX = 1;
			i214.y = -3.6;
			i214.scaleY = 1;
			i214.rotation = 0;
			i214.alpha = 1;
			i214.filters = null;
			i214.visible = true;
			i216.x = 29.2;
			i216.scaleX = 1;
			i216.y = -8;
			i216.scaleY = 1;
			i216.rotation = 0;
			i216.alpha = 1;
			i216.filters = null;
			i216.visible = true;
			i218.x = 19.8;
			i218.scaleX = 1;
			i218.y = -3.6;
			i218.scaleY = 1;
			i218.rotation = 0;
			i218.alpha = 1;
			i218.filters = null;
			i218.visible = true;
		};
		f = l.Add();//1
		f.Add(i210);
		f.Add(i212);
		f.Add(i214);
		f.Add(i216);
		f.Add(i218);
		f += () => {
			i210.x = -6.3;
			i210.scaleX = 1.09;
			i210.y = 28.7;
			i210.scaleY = 0.95;
			i212.x = -6.3;
			i212.scaleX = 1.09;
			i212.y = -6.5;
			i212.scaleY = 0.95;
			i214.x = -52.5;
			i214.scaleX = 1.09;
			i214.y = -1.6;
			i214.scaleY = 0.95;
			i216.x = 31.6;
			i216.scaleX = 1.09;
			i216.y = -5.8;
			i216.scaleY = 0.95;
			i218.x = 21.3;
			i218.scaleX = 1.09;
			i218.y = -1.6;
			i218.scaleY = 0.95;
		};
		f = l.Add();//2
		f.Add(i210);
		f.Add(i212);
		f.Add(i214);
		f.Add(i216);
		f.Add(i218);
		f += () => {
			i210.x = -7;
			i210.scaleX = 1.17;
			i210.y = 29.1;
			i210.scaleY = 0.9;
			i212.x = -7;
			i212.scaleX = 1.17;
			i212.y = -4.3;
			i212.scaleY = 0.9;
			i214.x = -56.9;
			i214.scaleX = 1.17;
			i214.y = 0.4;
			i214.scaleY = 0.9;
			i216.x = 33.9;
			i216.scaleX = 1.17;
			i216.y = -3.5;
			i216.scaleY = 0.9;
			i218.x = 22.8;
			i218.scaleX = 1.17;
			i218.y = 0.4;
			i218.scaleY = 0.9;
		};
		f = l.Add();//3
		f.Add(i210);
		f.Add(i212);
		f.Add(i214);
		f.Add(i216);
		f.Add(i218);
		f.Add(i220);
		f += () => {
			i210.x = -7.7;
			i210.scaleX = 1.26;
			i210.y = 29.6;
			i210.scaleY = 0.85;
			i212.x = -7.7;
			i212.scaleX = 1.26;
			i212.y = -2;
			i212.scaleY = 0.85;
			i214.x = -61.3;
			i214.scaleX = 1.26;
			i214.y = 2.4;
			i214.scaleY = 0.85;
			i216.x = 36.3;
			i216.scaleX = 1.26;
			i216.y = -1.4;
			i216.scaleY = 0.85;
			i218.x = 24.4;
			i218.scaleX = 1.26;
			i218.y = 2.4;
			i218.scaleY = 0.85;
			i220.x = -3.8;
			i220.scaleX = 1;
			i220.y = -3.8;
			i220.scaleY = 1;
			i220.rotation = 0;
			i220.alpha = 1;
			i220.filters = new as3.Array(new object[]{filter_0});
			i220.visible = true;
		};
		f = l.Add();//4
		f.Add(i210);
		f.Add(i212);
		f.Add(i214);
		f.Add(i216);
		f.Add(i218);
		f.Add(i220);
		f += () => {
			i210.x = -6.8;
			i210.scaleX = 1.16;
			i210.y = 28.9;
			i210.scaleY = 0.93;
			i212.x = -6.8;
			i212.scaleX = 1.16;
			i212.y = -5.7;
			i212.scaleY = 0.93;
			i214.x = -55.1;
			i214.scaleX = 1.07;
			i214.y = -0.8;
			i214.scaleY = 0.91;
			i216.x = 33;
			i216.scaleX = 1.07;
			i216.y = -4.5;
			i216.scaleY = 0.89;
			i218.x = 21.7;
			i218.scaleX = 1.03;
			i218.y = -0.8;
			i218.scaleY = 0.91;
		};
		f = l.Add();//5
		f.Add(i210);
		f.Add(i212);
		f.Add(i214);
		f.Add(i216);
		f.Add(i218);
		f.Add(i220);
		f += () => {
			i210.x = -6.1;
			i210.scaleX = 1.07;
			i210.y = 28.1;
			i210.scaleY = 1.01;
			i212.x = -6.1;
			i212.scaleX = 1.07;
			i212.y = -9.2;
			i212.scaleY = 1.01;
			i214.x = -48.8;
			i214.scaleX = 0.88;
			i214.y = -3.9;
			i214.scaleY = 0.97;
			i216.x = 29.7;
			i216.scaleX = 0.87;
			i216.y = -7.6;
			i216.scaleY = 0.93;
			i218.x = 19.1;
			i218.scaleX = 0.8;
			i218.y = -4;
			i218.scaleY = 0.97;
		};
		f = l.Add();//6
		f.Add(i210);
		f.Add(i212);
		f.Add(i214);
		f.Add(i216);
		f.Add(i218);
		f.Add(i220);
		f += () => {
			i210.x = -5.3;
			i210.scaleX = 0.97;
			i210.y = 27.4;
			i210.scaleY = 1.09;
			i212.x = -5.3;
			i212.scaleX = 0.97;
			i212.y = -12.9;
			i212.scaleY = 1.09;
			i214.x = -42.6;
			i214.scaleX = 0.7;
			i214.y = -7;
			i214.scaleY = 1.02;
			i216.x = 26.4;
			i216.scaleX = 0.67;
			i216.y = -10.8;
			i216.scaleY = 0.96;
			i218.x = 16.4;
			i218.scaleX = 0.56;
			i218.y = -7.3;
			i218.scaleY = 1.03;
		};
		f = l.Add();//7
		f.Add(i210);
		f.Add(i212);
		f.Add(i222);
		f.Add(i224);
		f.Add(i214);
		f.Add(i216);
		f.Add(i226);
		f.Add(i228);
		f.Add(i218);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i210.x = -4.5;
			i210.scaleX = 0.87;
			i210.y = 26.8;
			i210.scaleY = 1.17;
			i212.x = -4.5;
			i212.scaleX = 0.87;
			i212.y = -16.6;
			i212.scaleY = 1.17;
			i222.x = 22.3;
			i222.scaleX = 0.87;
			i222.y = -16;
			i222.scaleY = 1.18;
			i222.rotation = 0;
			i222.alpha = 1;
			i222.filters = null;
			i222.visible = true;
			i224.x = -11.8;
			i224.scaleX = 0.87;
			i224.y = -10.6;
			i224.scaleY = 1.18;
			i224.rotation = 0;
			i224.alpha = 1;
			i224.filters = null;
			i224.visible = true;
			i214.x = -36.4;
			i214.scaleX = 0.51;
			i214.y = -10.2;
			i214.scaleY = 1.08;
			i216.x = 23.1;
			i216.scaleX = 0.47;
			i216.y = -13.9;
			i216.scaleY = 1;
			i226.x = -14.4;
			i226.scaleX = 0.87;
			i226.y = -10.6;
			i226.scaleY = 1.18;
			i226.rotation = 0;
			i226.alpha = 1;
			i226.filters = null;
			i226.visible = true;
			i228.x = -11.4;
			i228.scaleX = 0.87;
			i228.y = 1.1;
			i228.scaleY = 1.18;
			i228.rotation = 0;
			i228.alpha = 1;
			i228.filters = null;
			i228.visible = true;
			i218.x = 13.8;
			i218.scaleX = 0.33;
			i218.y = -10.5;
			i218.scaleY = 1.08;
			i230.x = -4.7;
			i230.scaleX = 0.87;
			i230.y = -60.3;
			i230.scaleY = 1.18;
			i230.rotation = 0;
			i230.alpha = 1;
			i230.filters = null;
			i230.visible = true;
			i232.x = -7.5;
			i232.scaleX = 0.87;
			i232.y = -60.3;
			i232.scaleY = 1.18;
			i232.rotation = 0;
			i232.alpha = 1;
			i232.filters = null;
			i232.visible = true;
		};
		f = l.Add();//8
		f.Add(i210);
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i210.x = -4.9;
			i210.scaleX = 0.91;
			i210.y = 27.3;
			i210.scaleY = 1.11;
			i210.alpha = 0.3;
			i222.x = 26.1;
			i222.y = -18.9;
			i222.rotation = 3;
			i224.x = -22.7;
			i224.scaleX = 0.83;
			i224.y = -12.6;
			i224.scaleY = 1.24;
			i224.rotation = 345;
			i226.x = -24.7;
			i226.scaleX = 0.83;
			i226.y = -12.6;
			i226.scaleY = 1.24;
			i226.rotation = 345;
			i228.x = -21.4;
			i228.scaleX = 0.85;
			i228.y = -0.9;
			i228.scaleY = 1.2;
			i228.rotation = 339;
			i230.x = -4.3;
			i230.y = -67.8;
			i230.rotation = 6;
			i232.x = -7;
			i232.y = -68.1;
			i232.rotation = 6;
		};
		f = l.Add();//9
		f.Add(i210);
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i210.x = -5.3;
			i210.scaleX = 0.96;
			i210.y = 27.8;
			i210.scaleY = 1.06;
			i210.alpha = 0.1;
			i222.x = 30;
			i222.y = -21.9;
			i222.rotation = 7;
			i224.x = -33.6;
			i224.scaleX = 0.8;
			i224.y = -14.7;
			i224.scaleY = 1.29;
			i224.rotation = 330;
			i226.x = -35;
			i226.scaleX = 0.79;
			i226.y = -14.4;
			i226.scaleY = 1.3;
			i226.rotation = 330;
			i228.x = -31.4;
			i228.scaleX = 0.83;
			i228.y = -3.1;
			i228.scaleY = 1.23;
			i228.rotation = 318;
			i230.x = -3.9;
			i230.y = -75.3;
			i230.rotation = 12;
			i232.x = -6.6;
			i232.y = -75.9;
			i232.rotation = 12;
		};
		f = l.Add();//10
		f.Add(i210);
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i210.x = -5.6;
			i210.scaleX = 1;
			i210.y = 28.3;
			i210.scaleY = 1;
			i210.alpha = 0;
			i222.x = 33.9;
			i222.y = -24.8;
			i222.rotation = 11;
			i224.x = -44.5;
			i224.scaleX = 0.76;
			i224.y = -16.8;
			i224.scaleY = 1.35;
			i224.rotation = 316;
			i226.x = -45.3;
			i226.scaleX = 0.76;
			i226.y = -16.4;
			i226.scaleY = 1.36;
			i226.rotation = 315;
			i228.x = -41.4;
			i228.scaleX = 0.82;
			i228.y = -5.4;
			i228.scaleY = 1.25;
			i228.rotation = 297;
			i230.x = -3.5;
			i230.y = -82.7;
			i230.rotation = 18;
			i232.x = -6.2;
			i232.y = -83.6;
			i232.rotation = 18;
		};
		f = l.Add();//11
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 35.5;
			i222.rotation = 13;
			i222.alpha = 0.8;
			i224.x = -45.9;
			i224.y = -17.9;
			i224.rotation = 314;
			i224.alpha = 0.8;
			i226.x = -46.5;
			i226.y = -17.6;
			i226.scaleY = 1.35;
			i226.rotation = 314;
			i226.alpha = 0.8;
			i228.x = -42.5;
			i228.y = -6.7;
			i228.rotation = 296;
			i228.alpha = 0.8;
			i230.x = -1.9;
			i230.y = -86.5;
			i230.rotation = 20;
			i230.alpha = 0.8;
			i232.x = -4.5;
			i232.y = -87.5;
			i232.rotation = 20;
			i232.alpha = 0.8;
		};
		f = l.Add();//12
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 37.1;
			i222.y = -24.7;
			i222.rotation = 15;
			i222.alpha = 0.7;
			i224.x = -47.1;
			i224.y = -19.1;
			i224.rotation = 313;
			i224.alpha = 0.7;
			i226.x = -47.8;
			i226.y = -18.6;
			i226.rotation = 313;
			i226.alpha = 0.7;
			i228.x = -43.6;
			i228.y = -7.8;
			i228.rotation = 295;
			i228.alpha = 0.7;
			i230.x = -0.6;
			i230.y = -89.8;
			i230.rotation = 22;
			i230.alpha = 0.7;
			i232.x = -3.2;
			i232.y = -91;
			i232.rotation = 22;
			i232.alpha = 0.7;
		};
		f = l.Add();//13
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 38.5;
			i222.y = -24.8;
			i222.rotation = 17;
			i222.alpha = 0.5;
			i224.x = -48.2;
			i224.y = -19.9;
			i224.rotation = 312;
			i224.alpha = 0.5;
			i226.x = -49;
			i226.y = -19.6;
			i226.rotation = 312;
			i226.alpha = 0.5;
			i228.x = -44.6;
			i228.y = -8.8;
			i228.rotation = 294;
			i228.alpha = 0.5;
			i230.x = 0.7;
			i230.y = -92.9;
			i230.rotation = 24;
			i230.alpha = 0.5;
			i232.x = -1.9;
			i232.y = -94.2;
			i232.rotation = 24;
			i232.alpha = 0.5;
		};
		f = l.Add();//14
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 39.8;
			i222.y = -24.9;
			i222.rotation = 18;
			i222.alpha = 0.4;
			i224.x = -49.3;
			i224.y = -20.9;
			i224.alpha = 0.4;
			i226.x = -50;
			i226.y = -20.4;
			i226.rotation = 311;
			i226.alpha = 0.4;
			i228.x = -45.4;
			i228.y = -9.8;
			i228.rotation = 293;
			i228.alpha = 0.4;
			i230.x = 1.9;
			i230.y = -95.7;
			i230.rotation = 26;
			i230.alpha = 0.4;
			i232.x = -0.7;
			i232.y = -97;
			i232.rotation = 26;
			i232.alpha = 0.4;
		};
		f = l.Add();//15
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 40.9;
			i222.y = -24.8;
			i222.rotation = 20;
			i222.alpha = 0.3;
			i224.x = -50.1;
			i224.y = -21.6;
			i224.rotation = 311;
			i224.alpha = 0.3;
			i226.x = -50.9;
			i226.y = -21.3;
			i226.rotation = 310;
			i226.alpha = 0.3;
			i228.x = -46.1;
			i228.y = -10.6;
			i228.rotation = 292;
			i228.alpha = 0.3;
			i230.x = 2.8;
			i230.y = -98.2;
			i230.rotation = 27;
			i230.alpha = 0.3;
			i232.x = 0.3;
			i232.y = -99.5;
			i232.rotation = 27;
			i232.alpha = 0.3;
		};
		f = l.Add();//16
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 41.9;
			i222.rotation = 21;
			i222.alpha = 0.2;
			i224.x = -50.9;
			i224.y = -22.3;
			i224.rotation = 310;
			i224.alpha = 0.2;
			i226.x = -51.7;
			i226.y = -21.9;
			i226.alpha = 0.2;
			i228.x = -46.8;
			i228.y = -11.3;
			i228.alpha = 0.2;
			i230.x = 3.7;
			i230.y = -100.3;
			i230.rotation = 29;
			i230.alpha = 0.2;
			i232.x = 1.2;
			i232.y = -101.7;
			i232.rotation = 29;
			i232.alpha = 0.2;
		};
		f = l.Add();//17
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 42.6;
			i222.y = -24.9;
			i222.rotation = 22;
			i222.alpha = 0.1;
			i224.x = -51.5;
			i224.y = -22.9;
			i224.alpha = 0.1;
			i226.x = -52.4;
			i226.y = -22.4;
			i226.rotation = 309;
			i226.alpha = 0.1;
			i228.x = -47.3;
			i228.y = -11.9;
			i228.rotation = 291;
			i228.alpha = 0.1;
			i230.x = 4.5;
			i230.y = -102.1;
			i230.rotation = 30;
			i230.alpha = 0.1;
			i232.x = 1.9;
			i232.y = -103.5;
			i232.rotation = 30;
			i232.alpha = 0.1;
		};
		f = l.Add();//18
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 43.3;
			i222.y = -24.8;
			i222.rotation = 23;
			i222.alpha = 0;
			i224.x = -52.1;
			i224.y = -23.3;
			i224.rotation = 309;
			i224.alpha = 0;
			i226.x = -52.9;
			i226.y = -22.9;
			i226.alpha = 0;
			i228.x = -47.9;
			i228.y = -12.3;
			i228.alpha = 0;
			i230.x = 5;
			i230.y = -103.5;
			i230.rotation = 31;
			i230.alpha = 0;
			i232.x = 2.5;
			i232.y = -105;
			i232.rotation = 31;
			i232.alpha = 0;
		};
		f = l.Add();//19
		f.Add(i222);
		f.Add(i224);
		f.Add(i226);
		f.Add(i228);
		f.Add(i230);
		f.Add(i220);
		f.Add(i232);
		f += () => {
			i222.x = 43.9;
			i224.x = -52.5;
			i224.y = -23.7;
			i226.x = -53.3;
			i226.y = -23.3;
			i226.scaleY = 1.36;
			i226.rotation = 308;
			i228.x = -48.1;
			i228.y = -12.8;
			i228.rotation = 290;
			i230.x = 5.5;
			i230.y = -104.7;
			i232.x = 3.1;
			i232.y = -106.2;
		};
		f = l.Add();//20
		f.Add(i220);
		setFrames(l);
		addFrameScript(8, ()=>{dispatchEvent(new Event("EventBoxOpenAppear"));});
		addFrameScript(20, ()=>{dispatchEvent(new Event("EventOpenBoxPet"));stop();});
	}
}

internal class Event
{
	private string v;

	public Event(string v)
	{
		this.v = v;
	}
}

public class ButtonGuestsRoom : SimpleButton{ 
	public ButtonGuestsRoom() {
		downState = new symbol_29();
		overState = new symbol_29();
		upState = new symbol_29();
		hitTestState = new symbol_30();
	}
}
public class ButtonInviteHouse : SimpleButton{ 
	public ButtonInviteHouse() {
		downState = new symbol_31();
		overState = new symbol_31();
		upState = new symbol_31();
		hitTestState = new symbol_30(){y = 0};
	}
}
public class ButtonMapHouse : SimpleButton{ 
	public ButtonMapHouse() {
		downState = new symbol_29();
		overState = new symbol_29();
		upState = new symbol_29();
		hitTestState = new symbol_30(){x = 0};
	}
}
public class ButtonPetsRoom : SimpleButton{ 
	public ButtonPetsRoom() {
		downState = new symbol_29();
		overState = new symbol_29();
		upState = new symbol_29();
		hitTestState = new symbol_30();
	}
}
public class ButtonSnapshot : SimpleButton{ 
	public ButtonSnapshot() {
		downState = new symbol_32();
		overState = new symbol_32();
		upState = new symbol_33();
		hitTestState = new symbol_30();
	}
}
public class CickPlayerImg : BitmapData{ 
	public CickPlayerImg() {
		width = 12;
		height = 12;
		setPixels("56700766d6e277df22f4c68901c572fc");
	}
}
public class CloseGuests : SimpleButton{ 
	public CloseGuests() {
		downState = new symbol_34();
		overState = new symbol_34();
		upState = new symbol_34();
		hitTestState = new symbol_34();
	}
}
public class CursorDragItem : MovieClip{ 
	public CursorDragItem() {
		var i265 = new symbol_35();
		addChild(i265);//0
		FrameInfo f;
		var l= new Frames(26);
		f = l.Add();//0
		f.Add(i265);
		f += () => {
			i265.x = 0;
			i265.scaleX = 1;
			i265.y = 0;
			i265.scaleY = 1;
			i265.rotation = 0;
			i265.alpha = 1;
			i265.filters = null;
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
			i265.visible = true;
		};
		f = l.Add();//1
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//2
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//3
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//4
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//5
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//6
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//7
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//8
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//9
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//10
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//11
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//12
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//13
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//14
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//15
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//16
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add("finalAnimation");//17
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//18
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//19
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//20
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//21
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//22
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//23
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//24
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		f = l.Add();//25
		f.Add(i265);
		f += () => {
			i265.graphicsHash = "64a20c7d775713aed7423bc07cfceca9";
		};
		setFrames(l);
		addFrameScript(16, ()=>{stop();dispatchEvent(new Event("EventItemHold"));});
		addFrameScript(25, ()=>{dispatchEvent(new Event("EventDragFinish"));stop();});
	}
}
public class DeleteObjectBtn : SimpleButton{ 
	public DeleteObjectBtn() {
		downState = new symbol_36();
		overState = new symbol_36();
		upState = new symbol_36();
		hitTestState = new symbol_37();
	}
}
public class DoorHitClip : MovieClip{ 
	public DoorHitClip() {
		var i272 = new symbol_38();
		addChild(i272);//0
	}
}
public class GreenTickImg : BitmapData{ 
	public GreenTickImg() {
		width = 16;
		height = 14;
		setPixels("57417b189d126777c93401d3639e72ba");
	}
}
public class GuestsBg : BitmapData{ 
	public GuestsBg() {
		width = 143;
		height = 94;
		setPixels("ffbfbce97388540f4ac9a64f1717506b");
	}
}
public class GuestsBgHit : MovieClip{ 
	public GuestsBgHit() {
		var i275 = new symbol_39();
		addChild(i275);//0
	}
}
public class HouseMapBgImg : BitmapData{ 
	public HouseMapBgImg() {
		width = 200;
		height = 198;
		setPixels("b4f1acbe2d062a31e7a1fd55c1065b73");
	}
}
public class HouseRoofBg : BitmapData{ 
	public HouseRoofBg() {
		width = 200;
		height = 77;
		setPixels("5dd61d7a9aa778f037a290884f70d5b0");
	}
}
public class IconChatHelp : BitmapData{ 
	public IconChatHelp() {
		width = 15;
		height = 15;
		setPixels("27b60defeff1f4934060f0009ade4fc8");
	}
}
public class IconChatHelpActive : BitmapData{ 
	public IconChatHelpActive() {
		width = 15;
		height = 15;
		setPixels("5bd9410d4b2991d7fd28c2b04fffc334");
	}
}
public class IconShop : BitmapData{ 
	public IconShop() {
		width = 17;
		height = 11;
		setPixels("49c47c245fe129e258d005991aba53ff");
	}
}
public class IconShopActive : BitmapData{ 
	public IconShopActive() {
		width = 17;
		height = 11;
		setPixels("1629c72003a14a1cc548e6308741ef96");
	}
}
public class IntercomClip : MovieClip{ 
	public IntercomClip() {
		var i279 = new symbol_40();
		addChild(i279);//0
	}
}
public class InviteTicks : BitmapData{ 
	public InviteTicks() {
		width = 18;
		height = 12;
		setPixels("98cbdb816246dd9818b10c3216efb5ac");
	}
}
public class LeftArrowButton : SimpleButton{ 
	public LeftArrowButton() {
		downState = new symbol_41();
		overState = new symbol_41();
		upState = new symbol_41();
		hitTestState = new symbol_41();
	}
}
public class MenuButtonLeft : SimpleButton{ 
	public MenuButtonLeft() {
		downState = new symbol_42();
		overState = new symbol_43();
		upState = new symbol_44();
		hitTestState = new symbol_45();
	}
}
public class MenuButtonRight : SimpleButton{ 
	public MenuButtonRight() {
		downState = new symbol_46();
		overState = new symbol_47();
		upState = new symbol_48();
		hitTestState = new symbol_49();
	}
}
public class MenuHintImg : BitmapData{ 
	public MenuHintImg() {
		width = 118;
		height = 112;
		setPixels("65bb978fa39ca3a8f997723e2c5b8d3c");
	}
}
public class NotInvitedImg : BitmapData{ 
	public NotInvitedImg() {
		width = 36;
		height = 36;
		setPixels("3f2441dd8fa654b953f37fe56cbd98e2");
	}
}
public class NotificationPet : MovieClip{ 
	public NotificationPet() {
		var i296 = new symbol_50();
		addChild(i296);//0
		var i297 = new symbol_52(){scaleY = 0.37 , scaleX = 1.46};
		addChild(i297);//0
		FrameInfo f;
		var l= new Frames(25);
		f = l.Add();//0
		f.Add(i296);
		f += () => {
			i296.x = 0;
			i296.scaleX = 1;
			i296.y = 0;
			i296.scaleY = 1;
			i296.rotation = 0;
			i296.alpha = 1;
			i296.filters = null;
			i296.graphicsHash = "e51e0d834d2c69f71c92915165945dba";
			i296.visible = true;
		};
		f = l.Add();//1
		f.Add(i296);
		f += () => {
			i296.graphicsHash = "e51e0d834d2c69f71c92915165945dba";
		};
		f = l.Add();//2
		f.Add(i296);
		f += () => {
			i296.graphicsHash = "e51e0d834d2c69f71c92915165945dba";
		};
		f = l.Add();//3
		f.Add(i296);
		f += () => {
			i296.graphicsHash = "e51e0d834d2c69f71c92915165945dba";
		};
		f = l.Add();//4
		f.Add(i297);
		f += () => {
			i297.x = 0;
			i297.scaleX = 1.46;
			i297.y = 0;
			i297.scaleY = 0.37;
			i297.rotation = 0;
			i297.alpha = 1;
			i297.filters = null;
			i297.visible = true;
		};
		f = l.Add();//5
		f.Add(i297);
		f += () => {
			i297.scaleX = 1.17;
			i297.scaleY = 0.72;
		};
		f = l.Add();//6
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.88;
			i297.scaleY = 1.07;
		};
		f = l.Add();//7
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.59;
			i297.scaleY = 1.42;
		};
		f = l.Add();//8
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.76;
			i297.scaleY = 1.24;
		};
		f = l.Add();//9
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.92;
			i297.scaleY = 1.07;
		};
		f = l.Add();//10
		f.Add(i297);
		f += () => {
			i297.scaleX = 1.08;
			i297.scaleY = 0.89;
		};
		f = l.Add();//11
		f.Add(i297);
		f += () => {
			i297.scaleX = 1.24;
			i297.scaleY = 0.71;
		};
		f = l.Add();//12
		f.Add(i297);
		f += () => {
			i297.scaleX = 1.16;
			i297.scaleY = 0.8;
		};
		f = l.Add();//13
		f.Add(i297);
		f += () => {
			i297.scaleX = 1.07;
			i297.scaleY = 0.88;
		};
		f = l.Add();//14
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.99;
			i297.scaleY = 0.96;
		};
		f = l.Add();//15
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.91;
			i297.scaleY = 1.05;
		};
		f = l.Add();//16
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.82;
			i297.scaleY = 1.13;
		};
		f = l.Add();//17
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.86;
			i297.scaleY = 1.11;
		};
		f = l.Add();//18
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.89;
			i297.scaleY = 1.08;
		};
		f = l.Add();//19
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.91;
			i297.scaleY = 1.06;
		};
		f = l.Add();//20
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.94;
			i297.scaleY = 1.05;
		};
		f = l.Add();//21
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.96;
			i297.scaleY = 1.03;
		};
		f = l.Add();//22
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.98;
			i297.scaleY = 1.02;
		};
		f = l.Add();//23
		f.Add(i297);
		f += () => {
			i297.scaleX = 0.99;
			i297.scaleY = 1.01;
		};
		f = l.Add();//24
		f.Add(i297);
		f += () => {
			i297.scaleX = 1;
			i297.scaleY = 1;
		};
		setFrames(l);
		addFrameScript(24, ()=>{stop();});
	}
}
public class OtherPlayersIcon : BitmapData{ 
	public OtherPlayersIcon() {
		width = 50;
		height = 50;
		setPixels("24098c84dc310b153d1d9a85f63cf5ce");
	}
}
public class OverSelectedImg : BitmapData{ 
	public OverSelectedImg() {
		width = 18;
		height = 18;
		setPixels("a1a75fd2853b7028b8eb00170e5b7056");
	}
}
public class OverUnactiveImg : BitmapData{ 
	public OverUnactiveImg() {
		width = 18;
		height = 18;
		setPixels("cfde93cf7642f57682796fe89e3dc757");
	}
}
public class RightArrowButton : SimpleButton{ 
	public RightArrowButton() {
		downState = new symbol_41();
		overState = new symbol_41();
		upState = new symbol_41();
		hitTestState = new symbol_41();
	}
}
public class RoomDoorClip : MovieClip{ 
	public RoomDoorClip() {
		var i306 = new symbol_53();
		addChild(i306);//0
		FrameInfo f;
		var l= new Frames(12);
		f = l.Add();//0
		f.Add(i306);
		f += () => {
			i306.x = 0;
			i306.scaleX = 1;
			i306.y = 0;
			i306.scaleY = 1;
			i306.rotation = 0;
			i306.alpha = 1;
			i306.filters = null;
			i306.graphicsHash = "cf96f2f72e16654de1bf3b5c1414474b";
			i306.visible = true;
		};
		f = l.Add();//1
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "cf96f2f72e16654de1bf3b5c1414474b";
		};
		f = l.Add();//2
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "cf96f2f72e16654de1bf3b5c1414474b";
		};
		f = l.Add();//3
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "cf96f2f72e16654de1bf3b5c1414474b";
		};
		f = l.Add();//4
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "a3865a841cd721caec02fc047258299f";
		};
		f = l.Add();//5
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "ea17057b9068750c3bb366e097976088";
		};
		f = l.Add();//6
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "ea17057b9068750c3bb366e097976088";
		};
		f = l.Add();//7
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "a3865a841cd721caec02fc047258299f";
		};
		f = l.Add();//8
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "cf96f2f72e16654de1bf3b5c1414474b";
		};
		f = l.Add();//9
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "cf96f2f72e16654de1bf3b5c1414474b";
		};
		f = l.Add();//10
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "cf96f2f72e16654de1bf3b5c1414474b";
		};
		f = l.Add();//11
		f.Add(i306);
		f += () => {
			i306.graphicsHash = "cf96f2f72e16654de1bf3b5c1414474b";
		};
		setFrames(l);
		addFrameScript(7, ()=>{stop();});
		addFrameScript(11, ()=>{stop();});
	}
}
public class RotateObjectBtn : SimpleButton{ 
	public RotateObjectBtn() {
		downState = new symbol_54();
		overState = new symbol_54();
		upState = new symbol_54();
		hitTestState = new symbol_37();
	}
}
public class SaleRedRound : BitmapData{ 
	public SaleRedRound() {
		width = 143;
		height = 143;
		setPixels("02efe0e1612447cd5b9f497223012568");
	}
}
public class ScrollLeftBtn : SimpleButton{ 
	public ScrollLeftBtn() {
		downState = new symbol_42();
		overState = new symbol_43();
		upState = new symbol_55();
		hitTestState = new symbol_45();
	}
}
public class ScrollRightBtn : SimpleButton{ 
	public ScrollRightBtn() {
		downState = new symbol_46();
		overState = new symbol_47();
		upState = new symbol_56();
		hitTestState = new symbol_49();
	}
}
public class SettingsWhiteImg : BitmapData{ 
	public SettingsWhiteImg() {
		width = 16;
		height = 16;
		setPixels("f4cef59208094134061174424a470158");
	}
}
public class ShadowsImg : BitmapData{ 
	public ShadowsImg() {
		width = 761;
		height = 438;
		setPixels("139e0178653a71ca300191fdfeb70421");
	}
}
public class ShopBg : BitmapData{ 
	public ShopBg() {
		width = 4;
		height = 253;
		setPixels("c2671b24af62d7d0f2902700076f5971");
	}
}
public class ToPlayerImg : BitmapData{ 
	public ToPlayerImg() {
		width = 12;
		height = 17;
		setPixels("38b187385f48bb01865959b4b2f082f1");
	}
}
public class UnactiveRadioImg : BitmapData{ 
	public UnactiveRadioImg() {
		width = 18;
		height = 18;
		setPixels("c5b5f8ca9ef350e41ccf79a84f05286d");
	}
}
public class WhiteTickTapeImg : BitmapData{ 
	public WhiteTickTapeImg() {
		width = 10;
		height = 9;
		setPixels("771231d72f5339894dfa1cd8091342be");
	}
}
namespace apartments_fla
{	public class open_24 : MovieClip{ 
		public open_24() {
			var i176 = new symbol_3(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i176);//0
			var i43 = new symbol_0(){y = -39.6 , x = -3};
			addChild(i43);//0
			var i181 = new symbol_0(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i181);//0
			var i132 = new symbol_3(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i132);//0
			var i84 = new symbol_3(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i84);//0
			var i153 = new symbol_1(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i153);//0
			var i42 = new symbol_1(){x = -31.1 , alpha = 0.6 , y = -6.8};
			addChild(i42);//0
			var i52 = new symbol_1(){x = -3 , alpha = 0.6 , y = -39.6};
			addChild(i52);//0
			var i53 = new symbol_0(){y = 17.3 , x = 9.4};
			addChild(i53);//0
			var i67 = new symbol_2(){x = 9.4 , alpha = 0.5 , y = 17.3};
			addChild(i67);//0
			var i138 = new symbol_0(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i138);//0
			var i86 = new symbol_0(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i86);//0
			var i35 = new symbol_1(){x = 0.3 , alpha = 0.6 , y = -6.8};
			addChild(i35);//0
			var i195 = new symbol_1(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i195);//0
			var i36 = new symbol_0(){y = -6.8 , x = -31.1};
			addChild(i36);//0
			var i196 = new symbol_2(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i196);//0
			var i32 = new symbol_0(){y = -6.8 , x = 0.3};
			addChild(i32);//0
			var i110 = new symbol_2(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i110);//0
			var i105 = new symbol_1(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i105);//0
			var i157 = new symbol_2(){x = 9.4 , alpha = 0 , y = 17.3};
			addChild(i157);//0
			var i66 = new symbol_1(){x = 9.4 , alpha = 0.6 , y = 17.3};
			addChild(i66);//0
			var i118 = new symbol_0(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i118);//1
			var i165 = new symbol_0(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i165);//1
			var i139 = new symbol_2(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i139);//1
			var i68 = new symbol_3(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i68);//1
			var i197 = new symbol_3(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i197);//1
			var i72 = new symbol_0(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i72);//1
			var i87 = new symbol_2(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i87);//1
			var i85 = new symbol_1(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i85);//1
			var i111 = new symbol_3(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i111);//1
			var i37 = new symbol_2(){x = 0.3 , alpha = 0.5 , y = -6.8};
			addChild(i37);//1
			var i158 = new symbol_3(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i158);//1
			var i133 = new symbol_1(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i133);//1
			var i182 = new symbol_2(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i182);//1
			var i177 = new symbol_1(){x = -3 , alpha = 0 , y = -39.6};
			addChild(i177);//1
			var i119 = new symbol_2(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i119);//2
			var i183 = new symbol_3(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i183);//2
			var i44 = new symbol_3(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i44);//2
			var i112 = new symbol_1(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i112);//2
			var i54 = new symbol_3(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i54);//2
			var i146 = new symbol_0(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i146);//2
			var i73 = new symbol_2(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i73);//2
			var i69 = new symbol_1(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i69);//2
			var i166 = new symbol_2(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i166);//2
			var i189 = new symbol_0(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i189);//2
			var i140 = new symbol_3(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i140);//2
			var i47 = new symbol_0(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i47);//2
			var i88 = new symbol_3(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i88);//2
			var i159 = new symbol_1(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i159);//2
			var i198 = new symbol_1(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i198);//2
			var i97 = new symbol_0(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i97);//2
			var i60 = new symbol_0(){x = -31.1 , alpha = 0 , y = -6.8};
			addChild(i60);//2
			var i74 = new symbol_3(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i74);//3
			var i98 = new symbol_2(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i98);//3
			var i147 = new symbol_2(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i147);//3
			var i81 = new symbol_0(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i81);//3
			var i55 = new symbol_1(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i55);//3
			var i141 = new symbol_1(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i141);//3
			var i61 = new symbol_2(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i61);//3
			var i89 = new symbol_1(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i89);//3
			var i172 = new symbol_0(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i172);//3
			var i184 = new symbol_1(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i184);//3
			var i167 = new symbol_3(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i167);//3
			var i120 = new symbol_3(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i120);//3
			var i125 = new symbol_0(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i125);//3
			var i48 = new symbol_4(){y = -0.2};
			addChild(i48);//3
			var i190 = new symbol_2(){x = 0.3 , alpha = 0 , y = -6.8};
			addChild(i190);//3
			var i49 = new symbol_5(){y = -0.2};
			addChild(i49);//4
			var i56 = new symbol_4(){y = -22.8 , x = -1.1};
			addChild(i56);//4
			var i99 = new symbol_4(){y = 0.1 , x = 3.4};
			addChild(i99);//4
			var i75 = new symbol_4(){y = -14.4 , x = -3};
			addChild(i75);//4
			var i76 = new symbol_5(){y = -14.4 , x = -3};
			addChild(i76);//5
			var i57 = new symbol_5(){y = -22.8 , x = -1.1};
			addChild(i57);//5
			var i100 = new symbol_5(){y = 0.1 , x = 3.4};
			addChild(i100);//5
			var i160 = new symbol_0(){y = 21.2 , x = -25.4};
			addChild(i160);//5
			var i175 = new symbol_1(){x = -25.4 , alpha = 0.6 , y = 21.2};
			addChild(i175);//5
			var i178 = new symbol_2(){x = -25.4 , alpha = 0.5 , y = 21.2};
			addChild(i178);//5
			var i134 = new symbol_0(){y = -1.6 , x = 30.2};
			addChild(i134);//7
			var i152 = new symbol_1(){x = 30.2 , alpha = 0.6 , y = -1.6};
			addChild(i152);//7
			var i154 = new symbol_2(){x = 30.2 , alpha = 0.5 , y = -1.6};
			addChild(i154);//7
			var i126 = new symbol_1(){x = 27.9 , alpha = 0.6 , y = -43.5};
			addChild(i126);//9
			var i90 = new symbol_0(){y = -36.6 , x = -26.4};
			addChild(i90);//9
			var i106 = new symbol_0(){y = -43.5 , x = 27.9};
			addChild(i106);//9
			var i129 = new symbol_2(){x = 27.9 , alpha = 0.5 , y = -43.5};
			addChild(i129);//9
			var i135 = new symbol_3(){x = -26.4 , alpha = 0 , y = -36.6};
			addChild(i135);//11
			var i113 = new symbol_2(){x = -26.4 , alpha = 0.5 , y = -36.6};
			addChild(i113);//11
			var i107 = new symbol_1(){x = -26.4 , alpha = 0.6 , y = -36.6};
			addChild(i107);//11
			FrameInfo f;
			var l= new Frames(44);
			f = l.Add();//0
			f.Add(i32);
			f += () => {
				i32.x = 0.3;
				i32.ratio = 0;
				i32.y = -6.8;
				i32.scaleY = 1;
				i32.rotation = 0;
				i32.alpha = 1;
				i32.scaleX = 1;
				i32.filters = null;
				i32.visible = true;
			};
			f = l.Add();//1
			f.Add(i32);
			f += () => {
				i32.ratio = 21845;
				i32.alpha = 0.9;
			};
			f = l.Add();//2
			f.Add(i32);
			f += () => {
				i32.ratio = 43691;
				i32.alpha = 0.8;
			};
			f = l.Add();//3
			f.Add(i35);
			f += () => {
				i35.x = 0.3;
				i35.scaleX = 1;
				i35.y = -6.8;
				i35.scaleY = 1;
				i35.rotation = 0;
				i35.alpha = 0.6;
				i35.filters = null;
				i35.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i35.visible = true;
			};
			f = l.Add();//4
			f.Add(i36);
			f.Add(i37);
			f += () => {
				i36.x = -31.1;
				i36.ratio = 0;
				i36.y = -6.8;
				i36.scaleY = 1;
				i36.rotation = 0;
				i36.alpha = 1;
				i36.scaleX = 1;
				i36.filters = null;
				i36.visible = true;
				i37.x = 0.3;
				i37.ratio = 0;
				i37.y = -6.8;
				i37.scaleY = 1;
				i37.rotation = 0;
				i37.alpha = 0.5;
				i37.scaleX = 1;
				i37.filters = null;
				i37.visible = true;
			};
			f = l.Add();//5
			f.Add(i36);
			f.Add(i37);
			f += () => {
				i36.ratio = 21845;
				i36.alpha = 0.9;
				i37.ratio = 16384;
				i37.alpha = 0.4;
			};
			f = l.Add();//6
			f.Add(i36);
			f.Add(i37);
			f += () => {
				i36.ratio = 43691;
				i36.alpha = 0.8;
				i37.ratio = 32768;
				i37.alpha = 0.3;
			};
			f = l.Add();//7
			f.Add(i42);
			f.Add(i37);
			f += () => {
				i42.x = -31.1;
				i42.scaleX = 1;
				i42.y = -6.8;
				i42.scaleY = 1;
				i42.rotation = 0;
				i42.alpha = 0.6;
				i42.filters = null;
				i42.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i42.visible = true;
				i37.ratio = 49152;
				i37.alpha = 0.1;
			};
			f = l.Add();//8
			f.Add(i43);
			f.Add(i37);
			f.Add(i44);
			f += () => {
				i43.x = -3;
				i43.ratio = 0;
				i43.y = -39.6;
				i43.scaleY = 1;
				i43.rotation = 0;
				i43.alpha = 1;
				i43.scaleX = 1;
				i43.filters = null;
				i43.visible = true;
				i37.x = -31.1;
				i37.ratio = 0;
				i37.alpha = 0.5;
				i44.x = 0.3;
				i44.scaleX = 1;
				i44.y = -6.8;
				i44.scaleY = 1;
				i44.rotation = 0;
				i44.alpha = 0;
				i44.filters = null;
				i44.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i44.visible = true;
			};
			f = l.Add();//9
			f.Add(i43);
			f.Add(i37);
			f.Add(i47);
			f.Add(i48);
			f.Add(i49);
			f += () => {
				i43.ratio = 21845;
				i43.alpha = 0.9;
				i37.ratio = 16384;
				i37.alpha = 0.4;
				i47.x = 0.3;
				i47.ratio = 0;
				i47.y = -6.8;
				i47.scaleY = 1;
				i47.rotation = 0;
				i47.alpha = 0;
				i47.scaleX = 1;
				i47.filters = null;
				i47.visible = true;
				i48.x = 0;
				i48.scaleX = 1;
				i48.y = -0.2;
				i48.scaleY = 1;
				i48.rotation = 0;
				i48.alpha = 1;
				i48.filters = null;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i48.visible = true;
				i49.x = 0;
				i49.scaleX = 1;
				i49.y = -0.2;
				i49.scaleY = 1;
				i49.rotation = 0;
				i49.alpha = 1;
				i49.filters = null;
				i49.graphicsHash = "194dea5e2e366ffa72889aeb8fd40737";
				i49.visible = true;
			};
			f = l.Add();//10
			f.Add(i43);
			f.Add(i37);
			f.Add(i47);
			f.Add(i48);
			f.Add(i49);
			f += () => {
				i43.ratio = 43691;
				i43.alpha = 0.8;
				i37.ratio = 32768;
				i37.alpha = 0.3;
				i47.ratio = 21845;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "31548d66f82ff788317b6dd109563ce4";
			};
			f = l.Add();//11
			f.Add(i52);
			f.Add(i37);
			f.Add(i47);
			f.Add(i48);
			f.Add(i49);
			f += () => {
				i52.x = -3;
				i52.scaleX = 1;
				i52.y = -39.6;
				i52.scaleY = 1;
				i52.rotation = 0;
				i52.alpha = 0.6;
				i52.filters = null;
				i52.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i52.visible = true;
				i37.ratio = 49152;
				i37.alpha = 0.1;
				i47.ratio = 43691;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "5a26e2b8a41e4fe4bbf4151f731f0df6";
			};
			f = l.Add();//12
			f.Add(i53);
			f.Add(i37);
			f.Add(i54);
			f.Add(i55);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i57);
			f += () => {
				i53.x = 9.4;
				i53.ratio = 0;
				i53.y = 17.3;
				i53.scaleY = 1;
				i53.rotation = 0;
				i53.alpha = 1;
				i53.scaleX = 1;
				i53.filters = null;
				i53.visible = true;
				i37.x = -3;
				i37.ratio = 0;
				i37.y = -39.6;
				i37.scaleY = 0.71;
				i37.alpha = 0.5;
				i37.scaleX = 0.71;
				i54.x = -31.1;
				i54.scaleX = 1;
				i54.y = -6.8;
				i54.scaleY = 1;
				i54.rotation = 0;
				i54.alpha = 0;
				i54.filters = null;
				i54.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i54.visible = true;
				i55.x = 0.3;
				i55.scaleX = 1;
				i55.y = -6.8;
				i55.scaleY = 1;
				i55.rotation = 0;
				i55.alpha = 0;
				i55.filters = null;
				i55.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i55.visible = true;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "6929e302349afe70cac2451e65744c4f";
				i56.x = -1.1;
				i56.scaleX = 1;
				i56.y = -22.8;
				i56.scaleY = 1;
				i56.rotation = 90;
				i56.alpha = 1;
				i56.filters = null;
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.visible = true;
				i57.x = -1.1;
				i57.scaleX = 1;
				i57.y = -22.8;
				i57.scaleY = 1;
				i57.rotation = 90;
				i57.alpha = 1;
				i57.filters = null;
				i57.graphicsHash = "194dea5e2e366ffa72889aeb8fd40737";
				i57.visible = true;
			};
			f = l.Add();//13
			f.Add(i53);
			f.Add(i37);
			f.Add(i60);
			f.Add(i61);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i57);
			f += () => {
				i53.ratio = 21845;
				i53.alpha = 0.9;
				i37.ratio = 16384;
				i37.alpha = 0.4;
				i60.x = -31.1;
				i60.ratio = 0;
				i60.y = -6.8;
				i60.scaleY = 1;
				i60.rotation = 0;
				i60.alpha = 0;
				i60.scaleX = 1;
				i60.filters = null;
				i60.visible = true;
				i61.x = 0.3;
				i61.ratio = 0;
				i61.y = -6.8;
				i61.scaleY = 1;
				i61.rotation = 0;
				i61.alpha = 0;
				i61.scaleX = 1;
				i61.filters = null;
				i61.visible = true;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "74e08245199deeb1861110b822f35305";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i57.graphicsHash = "31548d66f82ff788317b6dd109563ce4";
			};
			f = l.Add();//14
			f.Add(i53);
			f.Add(i37);
			f.Add(i60);
			f.Add(i61);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i57);
			f += () => {
				i53.ratio = 43691;
				i53.alpha = 0.8;
				i37.ratio = 32768;
				i37.alpha = 0.3;
				i60.ratio = 21845;
				i61.ratio = 16384;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "2198748673b5c5b4ae98cc96bc39026a";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i57.graphicsHash = "5a26e2b8a41e4fe4bbf4151f731f0df6";
			};
			f = l.Add();//15
			f.Add(i66);
			f.Add(i37);
			f.Add(i60);
			f.Add(i61);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i57);
			f += () => {
				i66.x = 9.4;
				i66.scaleX = 1;
				i66.y = 17.3;
				i66.scaleY = 1;
				i66.rotation = 0;
				i66.alpha = 0.6;
				i66.filters = null;
				i66.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i66.visible = true;
				i37.ratio = 49152;
				i37.alpha = 0.1;
				i60.ratio = 43691;
				i61.ratio = 32768;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "d6491a2bdc33d728537acaae265c00b7";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i57.graphicsHash = "6929e302349afe70cac2451e65744c4f";
			};
			f = l.Add();//16
			f.Add(i67);
			f.Add(i68);
			f.Add(i69);
			f.Add(i61);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i57);
			f += () => {
				i67.x = 9.4;
				i67.ratio = 0;
				i67.y = 17.3;
				i67.scaleY = 1;
				i67.rotation = 0;
				i67.alpha = 0.5;
				i67.scaleX = 1;
				i67.filters = null;
				i67.visible = true;
				i68.x = -3;
				i68.scaleX = 1;
				i68.y = -39.6;
				i68.scaleY = 1;
				i68.rotation = 0;
				i68.alpha = 0;
				i68.filters = null;
				i68.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i68.visible = true;
				i69.x = -31.1;
				i69.scaleX = 1;
				i69.y = -6.8;
				i69.scaleY = 1;
				i69.rotation = 0;
				i69.alpha = 0;
				i69.filters = null;
				i69.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i69.visible = true;
				i61.ratio = 49152;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "4a8e2f2de5939eb9c3f0c1d993f9f112";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i57.graphicsHash = "74e08245199deeb1861110b822f35305";
			};
			f = l.Add();//17
			f.Add(i67);
			f.Add(i72);
			f.Add(i73);
			f.Add(i74);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i75);
			f.Add(i76);
			f.Add(i57);
			f += () => {
				i67.ratio = 16384;
				i67.alpha = 0.4;
				i72.x = -3;
				i72.ratio = 0;
				i72.y = -39.6;
				i72.scaleY = 1;
				i72.rotation = 0;
				i72.alpha = 0;
				i72.scaleX = 1;
				i72.filters = null;
				i72.visible = true;
				i73.x = -31.1;
				i73.ratio = 0;
				i73.y = -6.8;
				i73.scaleY = 1;
				i73.rotation = 0;
				i73.alpha = 0;
				i73.scaleX = 1;
				i73.filters = null;
				i73.visible = true;
				i74.x = 0.3;
				i74.scaleX = 1;
				i74.y = -6.8;
				i74.scaleY = 1;
				i74.rotation = 0;
				i74.alpha = 0;
				i74.filters = null;
				i74.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i74.visible = true;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "debf0ab35b9bad0188214d6e4b5d7215";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.x = -3;
				i75.scaleX = 1;
				i75.y = -14.4;
				i75.scaleY = 1;
				i75.rotation = 147;
				i75.alpha = 1;
				i75.filters = null;
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.visible = true;
				i76.x = -3;
				i76.scaleX = 1;
				i76.y = -14.4;
				i76.scaleY = 1;
				i76.rotation = 147;
				i76.alpha = 1;
				i76.filters = null;
				i76.graphicsHash = "194dea5e2e366ffa72889aeb8fd40737";
				i76.visible = true;
				i57.graphicsHash = "2198748673b5c5b4ae98cc96bc39026a";
			};
			f = l.Add();//18
			f.Add(i67);
			f.Add(i72);
			f.Add(i73);
			f.Add(i81);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i75);
			f.Add(i76);
			f.Add(i57);
			f += () => {
				i67.ratio = 32768;
				i67.alpha = 0.3;
				i72.ratio = 21845;
				i73.ratio = 16384;
				i81.x = 0.3;
				i81.ratio = 0;
				i81.y = -6.8;
				i81.scaleY = 1;
				i81.rotation = 0;
				i81.alpha = 0;
				i81.scaleX = 1;
				i81.filters = null;
				i81.visible = true;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "335591bc3fbc2fed909665430af6e723";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "31548d66f82ff788317b6dd109563ce4";
				i57.graphicsHash = "d6491a2bdc33d728537acaae265c00b7";
			};
			f = l.Add();//19
			f.Add(i67);
			f.Add(i72);
			f.Add(i73);
			f.Add(i81);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i75);
			f.Add(i76);
			f.Add(i57);
			f += () => {
				i67.ratio = 49152;
				i67.alpha = 0.1;
				i72.ratio = 43691;
				i73.ratio = 32768;
				i81.ratio = 21845;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "eb070a324ab016fdccde8c0faa165201";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "5a26e2b8a41e4fe4bbf4151f731f0df6";
				i57.graphicsHash = "4a8e2f2de5939eb9c3f0c1d993f9f112";
			};
			f = l.Add();//20
			f.Add(i84);
			f.Add(i85);
			f.Add(i73);
			f.Add(i81);
			f.Add(i48);
			f.Add(i49);
			f.Add(i56);
			f.Add(i75);
			f.Add(i76);
			f.Add(i57);
			f += () => {
				i84.x = 9.4;
				i84.scaleX = 1;
				i84.y = 17.3;
				i84.scaleY = 1;
				i84.rotation = 0;
				i84.alpha = 0;
				i84.filters = null;
				i84.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i84.visible = true;
				i85.x = -3;
				i85.scaleX = 1;
				i85.y = -39.6;
				i85.scaleY = 1;
				i85.rotation = 0;
				i85.alpha = 0;
				i85.filters = null;
				i85.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i85.visible = true;
				i73.ratio = 49152;
				i81.ratio = 43691;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i49.graphicsHash = "c618a62900f30d89e25c90eb72c3c3af";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "6929e302349afe70cac2451e65744c4f";
				i57.graphicsHash = "debf0ab35b9bad0188214d6e4b5d7215";
			};
			f = l.Add();//21
			f.Add(i86);
			f.Add(i87);
			f.Add(i88);
			f.Add(i89);
			f.Add(i48);
			f.Add(i56);
			f.Add(i75);
			f.Add(i76);
			f.Add(i57);
			f.Add(i90);
			f += () => {
				i86.x = 9.4;
				i86.ratio = 0;
				i86.y = 17.3;
				i86.scaleY = 1;
				i86.rotation = 0;
				i86.alpha = 0;
				i86.scaleX = 1;
				i86.filters = null;
				i86.visible = true;
				i87.x = -3;
				i87.ratio = 0;
				i87.y = -39.6;
				i87.scaleY = 1;
				i87.rotation = 0;
				i87.alpha = 0;
				i87.scaleX = 1;
				i87.filters = null;
				i87.visible = true;
				i88.x = -31.1;
				i88.scaleX = 1;
				i88.y = -6.8;
				i88.scaleY = 1;
				i88.rotation = 0;
				i88.alpha = 0;
				i88.filters = null;
				i88.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i88.visible = true;
				i89.x = 0.3;
				i89.scaleX = 1;
				i89.y = -6.8;
				i89.scaleY = 1;
				i89.rotation = 0;
				i89.alpha = 0;
				i89.filters = null;
				i89.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i89.visible = true;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "74e08245199deeb1861110b822f35305";
				i57.graphicsHash = "335591bc3fbc2fed909665430af6e723";
				i90.x = -26.4;
				i90.ratio = 0;
				i90.y = -36.6;
				i90.scaleY = 1;
				i90.rotation = 0;
				i90.alpha = 1;
				i90.scaleX = 1;
				i90.filters = null;
				i90.visible = true;
			};
			f = l.Add();//22
			f.Add(i86);
			f.Add(i87);
			f.Add(i97);
			f.Add(i98);
			f.Add(i48);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i76);
			f.Add(i57);
			f.Add(i100);
			f.Add(i90);
			f += () => {
				i86.ratio = 21845;
				i87.ratio = 16384;
				i97.x = -31.1;
				i97.ratio = 0;
				i97.y = -6.8;
				i97.scaleY = 1;
				i97.rotation = 0;
				i97.alpha = 0;
				i97.scaleX = 1;
				i97.filters = null;
				i97.visible = true;
				i98.x = 0.3;
				i98.ratio = 0;
				i98.y = -6.8;
				i98.scaleY = 1;
				i98.rotation = 0;
				i98.alpha = 0;
				i98.scaleX = 1;
				i98.filters = null;
				i98.visible = true;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.x = 3.4;
				i99.scaleX = 1;
				i99.y = 0.1;
				i99.scaleY = 1;
				i99.rotation = 269;
				i99.alpha = 1;
				i99.filters = null;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.visible = true;
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "2198748673b5c5b4ae98cc96bc39026a";
				i57.graphicsHash = "eb070a324ab016fdccde8c0faa165201";
				i100.x = 3.4;
				i100.scaleX = 1;
				i100.y = 0.1;
				i100.scaleY = 1;
				i100.rotation = 269;
				i100.alpha = 1;
				i100.filters = null;
				i100.graphicsHash = "194dea5e2e366ffa72889aeb8fd40737";
				i100.visible = true;
				i90.ratio = 21845;
				i90.alpha = 0.9;
			};
			f = l.Add();//23
			f.Add(i86);
			f.Add(i87);
			f.Add(i97);
			f.Add(i98);
			f.Add(i48);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i76);
			f.Add(i57);
			f.Add(i100);
			f.Add(i90);
			f += () => {
				i86.ratio = 43691;
				i87.ratio = 32768;
				i97.ratio = 21845;
				i98.ratio = 16384;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "d6491a2bdc33d728537acaae265c00b7";
				i57.graphicsHash = "c618a62900f30d89e25c90eb72c3c3af";
				i100.graphicsHash = "31548d66f82ff788317b6dd109563ce4";
				i90.ratio = 43691;
				i90.alpha = 0.8;
			};
			f = l.Add();//24
			f.Add(i105);
			f.Add(i87);
			f.Add(i97);
			f.Add(i98);
			f.Add(i48);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i76);
			f.Add(i100);
			f.Add(i106);
			f.Add(i107);
			f += () => {
				i105.x = 9.4;
				i105.scaleX = 1;
				i105.y = 17.3;
				i105.scaleY = 1;
				i105.rotation = 0;
				i105.alpha = 0;
				i105.filters = null;
				i105.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i105.visible = true;
				i87.ratio = 49152;
				i97.ratio = 43691;
				i98.ratio = 32768;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "4a8e2f2de5939eb9c3f0c1d993f9f112";
				i100.graphicsHash = "5a26e2b8a41e4fe4bbf4151f731f0df6";
				i106.x = 27.9;
				i106.ratio = 0;
				i106.y = -43.5;
				i106.scaleY = 1;
				i106.rotation = 90;
				i106.alpha = 1;
				i106.scaleX = 1;
				i106.filters = null;
				i106.visible = true;
				i107.x = -26.4;
				i107.scaleX = 1;
				i107.y = -36.6;
				i107.scaleY = 1;
				i107.rotation = 0;
				i107.alpha = 0.6;
				i107.filters = null;
				i107.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i107.visible = true;
			};
			f = l.Add();//25
			f.Add(i110);
			f.Add(i111);
			f.Add(i112);
			f.Add(i98);
			f.Add(i48);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i76);
			f.Add(i100);
			f.Add(i106);
			f.Add(i113);
			f += () => {
				i110.x = 9.4;
				i110.ratio = 0;
				i110.y = 17.3;
				i110.scaleY = 1;
				i110.rotation = 0;
				i110.alpha = 0;
				i110.scaleX = 1;
				i110.filters = null;
				i110.visible = true;
				i111.x = -3;
				i111.scaleX = 1;
				i111.y = -39.6;
				i111.scaleY = 1;
				i111.rotation = 0;
				i111.alpha = 0;
				i111.filters = null;
				i111.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i111.visible = true;
				i112.x = -31.1;
				i112.scaleX = 1;
				i112.y = -6.8;
				i112.scaleY = 1;
				i112.rotation = 0;
				i112.alpha = 0;
				i112.filters = null;
				i112.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i112.visible = true;
				i98.ratio = 49152;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "debf0ab35b9bad0188214d6e4b5d7215";
				i100.graphicsHash = "6929e302349afe70cac2451e65744c4f";
				i106.ratio = 21845;
				i106.alpha = 0.9;
				i113.x = -26.4;
				i113.ratio = 0;
				i113.y = -36.6;
				i113.scaleY = 1;
				i113.rotation = 0;
				i113.alpha = 0.5;
				i113.scaleX = 1;
				i113.filters = null;
				i113.visible = true;
			};
			f = l.Add();//26
			f.Add(i110);
			f.Add(i118);
			f.Add(i119);
			f.Add(i120);
			f.Add(i48);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i76);
			f.Add(i100);
			f.Add(i106);
			f.Add(i113);
			f += () => {
				i110.ratio = 16384;
				i118.x = -3;
				i118.ratio = 0;
				i118.y = -39.6;
				i118.scaleY = 1;
				i118.rotation = 0;
				i118.alpha = 0;
				i118.scaleX = 1;
				i118.filters = null;
				i118.visible = true;
				i119.x = -31.1;
				i119.ratio = 0;
				i119.y = -6.8;
				i119.scaleY = 1;
				i119.rotation = 0;
				i119.alpha = 0;
				i119.scaleX = 1;
				i119.filters = null;
				i119.visible = true;
				i120.x = 0.3;
				i120.scaleX = 1;
				i120.y = -6.8;
				i120.scaleY = 1;
				i120.rotation = 0;
				i120.alpha = 0;
				i120.filters = null;
				i120.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i120.visible = true;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "335591bc3fbc2fed909665430af6e723";
				i100.graphicsHash = "74e08245199deeb1861110b822f35305";
				i106.ratio = 43691;
				i106.alpha = 0.8;
				i113.ratio = 16384;
				i113.alpha = 0.4;
			};
			f = l.Add();//27
			f.Add(i110);
			f.Add(i118);
			f.Add(i119);
			f.Add(i125);
			f.Add(i48);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i76);
			f.Add(i100);
			f.Add(i126);
			f.Add(i113);
			f += () => {
				i110.ratio = 32768;
				i118.ratio = 21845;
				i119.ratio = 16384;
				i125.x = 0.3;
				i125.ratio = 0;
				i125.y = -6.8;
				i125.scaleY = 1;
				i125.rotation = 0;
				i125.alpha = 0;
				i125.scaleX = 1;
				i125.filters = null;
				i125.visible = true;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "eb070a324ab016fdccde8c0faa165201";
				i100.graphicsHash = "2198748673b5c5b4ae98cc96bc39026a";
				i126.x = 27.9;
				i126.scaleX = 1;
				i126.y = -43.5;
				i126.scaleY = 1;
				i126.rotation = 90;
				i126.alpha = 0.6;
				i126.filters = null;
				i126.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i126.visible = true;
				i113.ratio = 32768;
				i113.alpha = 0.3;
			};
			f = l.Add();//28
			f.Add(i110);
			f.Add(i118);
			f.Add(i119);
			f.Add(i125);
			f.Add(i48);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i76);
			f.Add(i100);
			f.Add(i129);
			f.Add(i113);
			f += () => {
				i110.ratio = 49152;
				i118.ratio = 43691;
				i119.ratio = 32768;
				i125.ratio = 21845;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i76.graphicsHash = "c618a62900f30d89e25c90eb72c3c3af";
				i100.graphicsHash = "d6491a2bdc33d728537acaae265c00b7";
				i129.x = 27.9;
				i129.ratio = 0;
				i129.y = -43.5;
				i129.scaleY = 1;
				i129.rotation = 90;
				i129.alpha = 0.5;
				i129.scaleX = 1;
				i129.filters = null;
				i129.visible = true;
				i113.ratio = 49152;
				i113.alpha = 0.1;
			};
			f = l.Add();//29
			f.Add(i132);
			f.Add(i133);
			f.Add(i119);
			f.Add(i125);
			f.Add(i48);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i100);
			f.Add(i134);
			f.Add(i129);
			f.Add(i135);
			f += () => {
				i132.x = 9.4;
				i132.scaleX = 1;
				i132.y = 17.3;
				i132.scaleY = 1;
				i132.rotation = 0;
				i132.alpha = 0;
				i132.filters = null;
				i132.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i132.visible = true;
				i133.x = -3;
				i133.scaleX = 1;
				i133.y = -39.6;
				i133.scaleY = 1;
				i133.rotation = 0;
				i133.alpha = 0;
				i133.filters = null;
				i133.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i133.visible = true;
				i119.ratio = 49152;
				i125.ratio = 43691;
				i48.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i100.graphicsHash = "4a8e2f2de5939eb9c3f0c1d993f9f112";
				i134.x = 30.2;
				i134.ratio = 0;
				i134.y = -1.6;
				i134.scaleY = 1;
				i134.rotation = 147;
				i134.alpha = 1;
				i134.scaleX = 1;
				i134.filters = null;
				i134.visible = true;
				i129.ratio = 16384;
				i129.alpha = 0.4;
				i135.x = -26.4;
				i135.scaleX = 1;
				i135.y = -36.6;
				i135.scaleY = 1;
				i135.rotation = 0;
				i135.alpha = 0;
				i135.filters = null;
				i135.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i135.visible = true;
			};
			f = l.Add();//30
			f.Add(i138);
			f.Add(i139);
			f.Add(i140);
			f.Add(i141);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i100);
			f.Add(i134);
			f.Add(i129);
			f += () => {
				i138.x = 9.4;
				i138.ratio = 0;
				i138.y = 17.3;
				i138.scaleY = 1;
				i138.rotation = 0;
				i138.alpha = 0;
				i138.scaleX = 1;
				i138.filters = null;
				i138.visible = true;
				i139.x = -3;
				i139.ratio = 0;
				i139.y = -39.6;
				i139.scaleY = 1;
				i139.rotation = 0;
				i139.alpha = 0;
				i139.scaleX = 1;
				i139.filters = null;
				i139.visible = true;
				i140.x = -31.1;
				i140.scaleX = 1;
				i140.y = -6.8;
				i140.scaleY = 1;
				i140.rotation = 0;
				i140.alpha = 0;
				i140.filters = null;
				i140.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i140.visible = true;
				i141.x = 0.3;
				i141.scaleX = 1;
				i141.y = -6.8;
				i141.scaleY = 1;
				i141.rotation = 0;
				i141.alpha = 0;
				i141.filters = null;
				i141.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i141.visible = true;
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i100.graphicsHash = "debf0ab35b9bad0188214d6e4b5d7215";
				i134.ratio = 21845;
				i134.alpha = 0.9;
				i129.ratio = 32768;
				i129.alpha = 0.3;
			};
			f = l.Add();//31
			f.Add(i138);
			f.Add(i139);
			f.Add(i146);
			f.Add(i147);
			f.Add(i56);
			f.Add(i99);
			f.Add(i75);
			f.Add(i100);
			f.Add(i134);
			f.Add(i129);
			f += () => {
				i138.ratio = 21845;
				i139.ratio = 16384;
				i146.x = -31.1;
				i146.ratio = 0;
				i146.y = -6.8;
				i146.scaleY = 1;
				i146.rotation = 0;
				i146.alpha = 0;
				i146.scaleX = 1;
				i146.filters = null;
				i146.visible = true;
				i147.x = 0.3;
				i147.ratio = 0;
				i147.y = -6.8;
				i147.scaleY = 1;
				i147.rotation = 0;
				i147.alpha = 0;
				i147.scaleX = 1;
				i147.filters = null;
				i147.visible = true;
				i56.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i100.graphicsHash = "335591bc3fbc2fed909665430af6e723";
				i134.ratio = 43691;
				i134.alpha = 0.8;
				i129.ratio = 49152;
				i129.alpha = 0.1;
			};
			f = l.Add();//32
			f.Add(i138);
			f.Add(i139);
			f.Add(i146);
			f.Add(i147);
			f.Add(i99);
			f.Add(i75);
			f.Add(i100);
			f.Add(i152);
			f += () => {
				i138.ratio = 43691;
				i139.ratio = 32768;
				i146.ratio = 21845;
				i147.ratio = 16384;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i100.graphicsHash = "eb070a324ab016fdccde8c0faa165201";
				i152.x = 30.2;
				i152.scaleX = 1;
				i152.y = -1.6;
				i152.scaleY = 1;
				i152.rotation = 147;
				i152.alpha = 0.6;
				i152.filters = null;
				i152.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i152.visible = true;
			};
			f = l.Add();//33
			f.Add(i153);
			f.Add(i139);
			f.Add(i146);
			f.Add(i147);
			f.Add(i99);
			f.Add(i75);
			f.Add(i100);
			f.Add(i154);
			f += () => {
				i153.x = 9.4;
				i153.scaleX = 1;
				i153.y = 17.3;
				i153.scaleY = 1;
				i153.rotation = 0;
				i153.alpha = 0;
				i153.filters = null;
				i153.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i153.visible = true;
				i139.ratio = 49152;
				i146.ratio = 43691;
				i147.ratio = 32768;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i100.graphicsHash = "c618a62900f30d89e25c90eb72c3c3af";
				i154.x = 30.2;
				i154.ratio = 0;
				i154.y = -1.6;
				i154.scaleY = 1;
				i154.rotation = 147;
				i154.alpha = 0.5;
				i154.scaleX = 1;
				i154.filters = null;
				i154.visible = true;
			};
			f = l.Add();//34
			f.Add(i157);
			f.Add(i158);
			f.Add(i159);
			f.Add(i147);
			f.Add(i99);
			f.Add(i75);
			f.Add(i160);
			f.Add(i154);
			f += () => {
				i157.x = 9.4;
				i157.ratio = 0;
				i157.y = 17.3;
				i157.scaleY = 1;
				i157.rotation = 0;
				i157.alpha = 0;
				i157.scaleX = 1;
				i157.filters = null;
				i157.visible = true;
				i158.x = -3;
				i158.scaleX = 1;
				i158.y = -39.6;
				i158.scaleY = 1;
				i158.rotation = 0;
				i158.alpha = 0;
				i158.filters = null;
				i158.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i158.visible = true;
				i159.x = -31.1;
				i159.scaleX = 1;
				i159.y = -6.8;
				i159.scaleY = 1;
				i159.rotation = 0;
				i159.alpha = 0;
				i159.filters = null;
				i159.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i159.visible = true;
				i147.ratio = 49152;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i160.x = -25.4;
				i160.ratio = 0;
				i160.y = 21.2;
				i160.scaleY = 1;
				i160.rotation = 269;
				i160.alpha = 1;
				i160.scaleX = 1;
				i160.filters = null;
				i160.visible = true;
				i154.ratio = 16384;
				i154.alpha = 0.4;
			};
			f = l.Add();//35
			f.Add(i157);
			f.Add(i165);
			f.Add(i166);
			f.Add(i167);
			f.Add(i99);
			f.Add(i75);
			f.Add(i160);
			f.Add(i154);
			f += () => {
				i157.ratio = 16384;
				i165.x = -3;
				i165.ratio = 0;
				i165.y = -39.6;
				i165.scaleY = 1;
				i165.rotation = 0;
				i165.alpha = 0;
				i165.scaleX = 1;
				i165.filters = null;
				i165.visible = true;
				i166.x = -31.1;
				i166.ratio = 0;
				i166.y = -6.8;
				i166.scaleY = 1;
				i166.rotation = 0;
				i166.alpha = 0;
				i166.scaleX = 1;
				i166.filters = null;
				i166.visible = true;
				i167.x = 0.3;
				i167.scaleX = 1;
				i167.y = -6.8;
				i167.scaleY = 1;
				i167.rotation = 0;
				i167.alpha = 0;
				i167.filters = null;
				i167.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i167.visible = true;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i160.ratio = 21845;
				i160.alpha = 0.9;
				i154.ratio = 32768;
				i154.alpha = 0.3;
			};
			f = l.Add();//36
			f.Add(i157);
			f.Add(i165);
			f.Add(i166);
			f.Add(i172);
			f.Add(i99);
			f.Add(i75);
			f.Add(i160);
			f.Add(i154);
			f += () => {
				i157.ratio = 32768;
				i165.ratio = 21845;
				i166.ratio = 16384;
				i172.x = 0.3;
				i172.ratio = 0;
				i172.y = -6.8;
				i172.scaleY = 1;
				i172.rotation = 0;
				i172.alpha = 0;
				i172.scaleX = 1;
				i172.filters = null;
				i172.visible = true;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i75.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i160.ratio = 43691;
				i160.alpha = 0.8;
				i154.ratio = 49152;
				i154.alpha = 0.1;
			};
			f = l.Add();//37
			f.Add(i157);
			f.Add(i165);
			f.Add(i166);
			f.Add(i172);
			f.Add(i99);
			f.Add(i175);
			f += () => {
				i157.ratio = 49152;
				i165.ratio = 43691;
				i166.ratio = 32768;
				i172.ratio = 21845;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i175.x = -25.4;
				i175.scaleX = 1;
				i175.y = 21.2;
				i175.scaleY = 1;
				i175.rotation = 269;
				i175.alpha = 0.6;
				i175.filters = null;
				i175.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i175.visible = true;
			};
			f = l.Add();//38
			f.Add(i176);
			f.Add(i177);
			f.Add(i166);
			f.Add(i172);
			f.Add(i99);
			f.Add(i178);
			f += () => {
				i176.x = 9.4;
				i176.scaleX = 1;
				i176.y = 17.3;
				i176.scaleY = 1;
				i176.rotation = 0;
				i176.alpha = 0;
				i176.filters = null;
				i176.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i176.visible = true;
				i177.x = -3;
				i177.scaleX = 1;
				i177.y = -39.6;
				i177.scaleY = 1;
				i177.rotation = 0;
				i177.alpha = 0;
				i177.filters = null;
				i177.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i177.visible = true;
				i166.ratio = 49152;
				i172.ratio = 43691;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i178.x = -25.4;
				i178.ratio = 0;
				i178.y = 21.2;
				i178.scaleY = 1;
				i178.rotation = 269;
				i178.alpha = 0.5;
				i178.scaleX = 1;
				i178.filters = null;
				i178.visible = true;
			};
			f = l.Add();//39
			f.Add(i181);
			f.Add(i182);
			f.Add(i183);
			f.Add(i184);
			f.Add(i99);
			f.Add(i178);
			f += () => {
				i181.x = 9.4;
				i181.ratio = 0;
				i181.y = 17.3;
				i181.scaleY = 1;
				i181.rotation = 0;
				i181.alpha = 0;
				i181.scaleX = 1;
				i181.filters = null;
				i181.visible = true;
				i182.x = -3;
				i182.ratio = 0;
				i182.y = -39.6;
				i182.scaleY = 1;
				i182.rotation = 0;
				i182.alpha = 0;
				i182.scaleX = 1;
				i182.filters = null;
				i182.visible = true;
				i183.x = -31.1;
				i183.scaleX = 1;
				i183.y = -6.8;
				i183.scaleY = 1;
				i183.rotation = 0;
				i183.alpha = 0;
				i183.filters = null;
				i183.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i183.visible = true;
				i184.x = 0.3;
				i184.scaleX = 1;
				i184.y = -6.8;
				i184.scaleY = 1;
				i184.rotation = 0;
				i184.alpha = 0;
				i184.filters = null;
				i184.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i184.visible = true;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i178.ratio = 16384;
				i178.alpha = 0.4;
			};
			f = l.Add();//40
			f.Add(i181);
			f.Add(i182);
			f.Add(i189);
			f.Add(i190);
			f.Add(i99);
			f.Add(i178);
			f += () => {
				i181.ratio = 21845;
				i182.ratio = 16384;
				i189.x = -31.1;
				i189.ratio = 0;
				i189.y = -6.8;
				i189.scaleY = 1;
				i189.rotation = 0;
				i189.alpha = 0;
				i189.scaleX = 1;
				i189.filters = null;
				i189.visible = true;
				i190.x = 0.3;
				i190.ratio = 0;
				i190.y = -6.8;
				i190.scaleY = 1;
				i190.rotation = 0;
				i190.alpha = 0;
				i190.scaleX = 1;
				i190.filters = null;
				i190.visible = true;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i178.ratio = 32768;
				i178.alpha = 0.3;
			};
			f = l.Add();//41
			f.Add(i181);
			f.Add(i182);
			f.Add(i189);
			f.Add(i190);
			f.Add(i99);
			f.Add(i178);
			f += () => {
				i181.ratio = 43691;
				i182.ratio = 32768;
				i189.ratio = 21845;
				i190.ratio = 16384;
				i99.graphicsHash = "ab9ac661f900a9327a9cecc1a5ce1439";
				i178.ratio = 49152;
				i178.alpha = 0.1;
			};
			f = l.Add();//42
			f.Add(i195);
			f.Add(i182);
			f.Add(i189);
			f.Add(i190);
			f += () => {
				i195.x = 9.4;
				i195.scaleX = 1;
				i195.y = 17.3;
				i195.scaleY = 1;
				i195.rotation = 0;
				i195.alpha = 0;
				i195.filters = null;
				i195.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i195.visible = true;
				i182.ratio = 49152;
				i189.ratio = 43691;
				i190.ratio = 32768;
			};
			f = l.Add();//43
			f.Add(i196);
			f.Add(i197);
			f.Add(i198);
			f.Add(i190);
			f += () => {
				i196.x = 9.4;
				i196.ratio = 0;
				i196.y = 17.3;
				i196.scaleY = 1;
				i196.rotation = 0;
				i196.alpha = 0;
				i196.scaleX = 1;
				i196.filters = null;
				i196.visible = true;
				i197.x = -3;
				i197.scaleX = 1;
				i197.y = -39.6;
				i197.scaleY = 1;
				i197.rotation = 0;
				i197.alpha = 0;
				i197.filters = null;
				i197.graphicsHash = "9a478cc8e74a234eab39e08d6022f4a9";
				i197.visible = true;
				i198.x = -31.1;
				i198.scaleX = 1;
				i198.y = -6.8;
				i198.scaleY = 1;
				i198.rotation = 0;
				i198.alpha = 0;
				i198.filters = null;
				i198.graphicsHash = "71c767165fcd172fd1a93c80db8a2131";
				i198.visible = true;
				i190.ratio = 49152;
			};
			setFrames(l);
		}
	}
}
namespace apartments.swf.privateSymbols{
	public class symbol_0 : MorphShape{ 
		public symbol_0() {
			setGraphicsStart("f7602b5fea95a083f431dbb9d70d50ce", 0, 0, 0, 0, 1, 1);
			setGraphicsEnd("e3ed11c091275757d01081836293fbaa", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("71c767165fcd172fd1a93c80db8a2131", -9.65, -9.65, 19.3, 19.3, 1, 1);
		}
	}
	public class symbol_10 : MovieClip{ 
		public symbol_10() {
			var i213 = new symbol_9();
			addChild(i213);//0
		}
	}
	public class symbol_11 : Shape{ 
		public symbol_11() {
			setGraphics("2266a3064508c34da7439bd9e4c37609", -5.6, -37.3, 11.2, 74.55, 1, 1);
		}
	}
	public class symbol_12 : MovieClip{ 
		public symbol_12() {
			var i215 = new symbol_11();
			addChild(i215);//0
		}
	}
	public class symbol_13 : Shape{ 
		public symbol_13() {
			setGraphics("c211cdb2b5099939e882eb5a1fcbdd92", -12.95, -41.9, 25.9, 83.75, 1, 1);
		}
	}
	public class symbol_14 : MovieClip{ 
		public symbol_14() {
			var i217 = new symbol_13();
			addChild(i217);//0
		}
	}
	public class symbol_15 : Shape{ 
		public symbol_15() {
			setGraphics("3a38ebc54936e513ed45792e6c2186ee", -4.5, -37.05, 9, 74.05, 1, 1);
		}
	}
	public class symbol_16 : MovieClip{ 
		public symbol_16() {
			var i219 = new symbol_15();
			addChild(i219);//0
		}
	}
	public class symbol_17 : Shape{ 
		public symbol_17() {
			setGraphics("830668633713170e05009cbb3cb4c0ad", -9.35, -42.15, 18.7, 84.25, 1, 1);
		}
	}
	public class symbol_18 : MovieClip{ 
		public symbol_18() {
			var i223 = new symbol_17();
			addChild(i223);//0
		}
	}
	public class symbol_19 : Shape{ 
		public symbol_19() {
			setGraphics("ea77703b220de1ebfcb19a136055eea5", -32.4, -37.05, 64.75, 74.55, 1, 1);
		}
	}
	public class symbol_2 : MorphShape{ 
		public symbol_2() {
			setGraphicsStart("6a2044032be0ad9274a0623f594c006e", 0, 0, 0, 0, 1, 1);
			setGraphicsEnd("44b8d1f571f2e6df894e5aaceef12b8c", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_20 : MovieClip{ 
		public symbol_20() {
			var i225 = new symbol_19();
			addChild(i225);//0
		}
	}
	public class symbol_21 : Shape{ 
		public symbol_21() {
			setGraphics("151b04cd31fb0efdc5b4fc6bdc3ad254", -5.45, -37.55, 10.9, 75.05, 1, 1);
		}
	}
	public class symbol_22 : MovieClip{ 
		public symbol_22() {
			var i227 = new symbol_21();
			addChild(i227);//0
		}
	}
	public class symbol_23 : Shape{ 
		public symbol_23() {
			setGraphics("8fdc6dcea79f043cdea0dd6c964b0254", -28.45, -12.9, 56.849999999999994, 25.8, 1, 1);
		}
	}
	public class symbol_24 : MovieClip{ 
		public symbol_24() {
			var i229 = new symbol_23();
			addChild(i229);//0
		}
	}
	public class symbol_25 : Shape{ 
		public symbol_25() {
			setGraphics("629afa1be7a1ab4692a981479bc97f0c", -40.55, -5.15, 81.1, 10.25, 1, 1);
		}
	}
	public class symbol_26 : MovieClip{ 
		public symbol_26() {
			var i231 = new symbol_25();
			addChild(i231);//0
		}
	}
	public class symbol_27 : Shape{ 
		public symbol_27() {
			setGraphics("0f912d19ab7db633d6586ea11b4c1d6f", -13.45, -5.15, 26.85, 10.25, 1, 1);
		}
	}
	public class symbol_28 : MovieClip{ 
		public symbol_28() {
			var i233 = new symbol_27();
			addChild(i233);//0
		}
	}
	public class symbol_29 : Shape{ 
		public symbol_29() {
			setGraphics("9e3281c620218beb5c2bc2cfbaef3d8d", -14, -15, 30, 30, 1, 1);
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("9a478cc8e74a234eab39e08d6022f4a9", -20.25, -20.25, 40.5, 40.5, 1, 1);
		}
	}
	public class symbol_30 : Shape{ 
		public symbol_30() {
			setGraphics("2551f7be311f582b80b1e779c2e8467b", -13.25, -10.35, 26.5, 20.75, 1, 1);
		}
	}
	public class symbol_31 : Shape{ 
		public symbol_31() {
			setGraphics("7ca2e38bec24029bb05594e256a06c92", -14.3, -15, 30, 30, 1, 1);
		}
	}
	public class symbol_32 : Shape{ 
		public symbol_32() {
			setGraphics("d525ed62d1773a0313ecee6bf764bd7f", -16, -13, 32, 26, 1, 1);
		}
	}
	public class symbol_33 : Shape{ 
		public symbol_33() {
			setGraphics("af4761442da5bca2a0207ae05f371e61", -12, -9, 24, 18, 1, 1);
		}
	}
	public class symbol_34 : Shape{ 
		public symbol_34() {
			setGraphics("00689f6f758c8b7c2dbfdf1535c36fe8", -3.5, -4, 7, 8, 1, 1);
		}
	}
	public class symbol_35 : Shape{ 
		public symbol_35() {
			setGraphics("64a20c7d775713aed7423bc07cfceca9", -15.5, -17, 31, 34, 1, 1);
		}
	}
	public class symbol_36 : Shape{ 
		public symbol_36() {
			setGraphics("0a25a7360321c5d4b9b29d998ab28e5d", -17.5, -18.5, 35, 37, 1, 1);
		}
	}
	public class symbol_37 : Shape{ 
		public symbol_37() {
			setGraphics("57e51541bc6e0ba8c43c67ac9cd5eb4b", -14.5, -15, 30, 30, 1, 1);
		}
	}
	public class symbol_38 : Shape{ 
		public symbol_38() {
			setGraphics("5946c5846832535ec3e964660d751ad1", 0, -232.05, 58, 232.05, 1, 1);
		}
	}
	public class symbol_39 : Shape{ 
		public symbol_39() {
			setGraphics("fd3dad08f703bab2a566057d712cfc88", 0, 0, 141.9, 92.35, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("ab9ac661f900a9327a9cecc1a5ce1439", -49.4, -50.8, 49.5, 51, 1, 1);
		}
	}
	public class symbol_40 : Shape{ 
		public symbol_40() {
			setGraphics("9bd3110ab665ce7ca210abd0644b0c6b", 0, -53, 25, 53, 1, 1);
		}
	}
	public class symbol_41 : Shape{ 
		public symbol_41() {
			setGraphics("f4b48fa2a2ab5825a8bc47a002ed8ca2", 0, 0, 29, 30, 1, 1);
		}
	}
	public class symbol_42 : Shape{ 
		public symbol_42() {
			setGraphics("ac435da99791341375b9b150c473e2f5", -0.8, -79.5, 15.450000000000001, 79, 1, 1);
		}
	}
	public class symbol_43 : Shape{ 
		public symbol_43() {
			setGraphics("dc7a6ddccf2160e6d0c130641c095714", -1, -81, 16, 82, 1, 1);
		}
	}
	public class symbol_44 : Shape{ 
		public symbol_44() {
			setGraphics("e285c6116da9255aea31706fa53add7e", -1, -81, 16, 82, 1, 1);
		}
	}
	public class symbol_45 : Shape{ 
		public symbol_45() {
			setGraphics("8a61e6ff31d58e46257b871953fd3732", -1, -81, 16, 82, 1, 1);
		}
	}
	public class symbol_46 : Shape{ 
		public symbol_46() {
			setGraphics("82a6de580cbc21cb624304076797b205", -0.75, -79.5, 15.45, 79, 1, 1);
		}
	}
	public class symbol_47 : Shape{ 
		public symbol_47() {
			setGraphics("628b2c8d0fac02a80ae7f816985ddeb3", -1, -81, 16, 82, 1, 1);
		}
	}
	public class symbol_48 : Shape{ 
		public symbol_48() {
			setGraphics("19f522a4be23119d1aa2de1acfcf8017", -1, -81, 16, 82, 1, 1);
		}
	}
	public class symbol_49 : Shape{ 
		public symbol_49() {
			setGraphics("909854f53dd8ec122a6d78f407f9dc9c", -1, -81, 16, 82, 1, 1);
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("194dea5e2e366ffa72889aeb8fd40737", -17.75, -8.25, 18.15, 7.25, 1, 1);
		}
	}
	public class symbol_50 : Shape{ 
		public symbol_50() {
			setGraphics("e51e0d834d2c69f71c92915165945dba", -12.25, -12.25, 24.5, 24.5, 1, 1);
		}
	}
	public class symbol_51 : Shape{ 
		public symbol_51() {
			setGraphics("6e800b2e516ca989a6a1ba76c771f243", -18.35, -18.4, 36.7, 36.8, 1, 1);
		}
	}
	public class symbol_52 : MovieClip{ 
		public symbol_52() {
			var i298 = new symbol_51();
			addChild(i298);//0
		}
	}
	public class symbol_53 : Shape{ 
		public symbol_53() {
			setGraphics("cf96f2f72e16654de1bf3b5c1414474b", 0, -233, 58, 233, 1, 1);
		}
	}
	public class symbol_54 : Shape{ 
		public symbol_54() {
			setGraphics("d38118094c9fd17b91492b77434b53ba", -16.5, -17.5, 33, 35, 1, 1);
		}
	}
	public class symbol_55 : Shape{ 
		public symbol_55() {
			setGraphics("a0eee9a4b03890824bce8eb997fe8da0", -1, -81, 16, 82, 1, 1);
		}
	}
	public class symbol_56 : Shape{ 
		public symbol_56() {
			setGraphics("1f582392bb7df7d0603cffb2ebe2093b", -1, -81, 16, 82, 1, 1);
		}
	}
	public class symbol_6 : Shape{ 
		public symbol_6() {
			setGraphics("64280531ef7be4177e6d593922525e05", -6.35, -6.35, 12.7, 12.7, 1, 1);
		}
	}
	public class symbol_7 : Shape{ 
		public symbol_7() {
			setGraphics("6ba690121378ce97359f0359d0518209", -53.15, -14.75, 121.94999999999999, 23.55, 1, 1);
		}
	}
	public class symbol_8 : MovieClip{ 
		public symbol_8() {
			var i211 = new symbol_7();
			addChild(i211);//0
		}
	}
	public class symbol_9 : Shape{ 
		public symbol_9() {
			setGraphics("50e543013d4e3276c09322dbbf1220d4", -40.55, -42.4, 81.1, 84.8, 1, 1);
		}
	}
}
