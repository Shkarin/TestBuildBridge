using System;

using flash.display;
using System.Collections.Generic;
using resources.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libresources : ResourcesExternalLib{
	public Libresources() {
	vectors = new string[] {
	"9ef4f75fd9375beb30e2d7f519c14ade",
	"fe344f72a25fddb4d3d1f433fae21ab3",
	"3aad0454c82dfa7d9899f93d657cd91a",
	"ea009f038860c48f3ea438420cd54122",
	"ef1b84bd0c879b1b107fab3dd6fe6e05",
	"bdc375517715d2e0f7d5747d17a39ccd",
	"d8a4ba116ce5ffb650290061b9be7890",
	"fe082cd5429070cd84be792d35631af3",
	"7344c6a714ab1cba0fbd408299aed580",
	"5b53f607be50658f032b811567adc49c",
	"dd52a7f11796631ac8b28e41d0c0c976",
	"ae19f947e1b5eb7e96e0152cd82486c2",
	"71aa2fe8ff4e35e66b5aa8e09875cc61",
	"164a3ea095e4ba2ea8120fb28982e87a",
	"5120b1c6fc453e4ea596e7622316b24f",
	"f27b3c08b4b29060ba021e63f772addc",
	"3aba6701792a8a6a78c62ed642ff2353",
	"d403e25f3e1fbe49c24c70f4c7026c1e",
	"77dbfb6bedff87982c46bc4a3ef23f5a",
	"b0432f1e5be40771c28455c8610b7e21",
	"872cad7ebd179977860111c494b59609",
	"afa6e5e421160ccdb794f2d2c9c8130b",
	"92eb0ec1c9fa1b7682b944b3772ce503",
	"b1231245a3295abccf4c14f6c9e0e4a4",
	"03d240bcd7a42a859d3881e1b92c4caf",
	"437b94b92b4ebe367ce6135cc3635efd",
	"1df68fc73eb56553baf5d0e59c727f69",
	"47a5514118504a552e35f0409408588b",
	"5cc649e5fcb173b4bde1ac46a47e4c2b",
	"6b1ec13d238baf902fe5b7144c90903a",
	"a1bb89bb3978aa7bc551e34b0f2eedd6",
	"11db35def2fc280d6f7c07a75b57c53f",
	"c328c656a9b5504cb3ae246115f2f72f",
	"f6a2be8e4019c2be5db7f7d1893fada0",
	"c0ba48f71314e6772e0761c3d166ea7a",
	"a7db65e384683dad66c0a83a7e14fa1c",
	"8de6b92a0b510f3a7ef9f2365448825e",
	"4f44772646f70f437816def67e40fcda",
	"e52245f95a3867349e10e99ef45cc7e8",
	"28213568e6a7616270abe1a3060730e1",
	"07724813a9bf12a9e1aa37ae05a53fd1",
	"059aa45cb8de205ced5ef89d30e688d2",
	"ad3785a109fa32aa0af95d7124c0a5d1",
	"adca0a79f28ba6756c48c377597b153e",
	"041b87bbe09d78583826bfd726be6c65",
	"67cd4db60b688f860f4a124e34378d6e",
	"c398d75a732683b7262d3c87048894b0",
	"5de2f086285061d1dc3e932cfba6ce36",
	"166d7553e6f02b47cf4d1a693936881c",
	"37bc7a3abf91b7ffc065a091cf5db051",
	"60cf3de8180aafd983d5998cc8eda2bf",
	"70dd25c5a1843e4dfc6cac21128ddc1d",
	"0a5b075f9f4315d6cdedde26495af679",
	"eb3ee9aa05df10ae2eb0853491a4672c",
	"f9fd089aa0194152505d93d65d7c6e48",
	"eb6a0030c4bc5d6f055d6de4db2cb1f7",
	"29d1505ffd213107e448c68d3c1f9eaa",
	"26e85619f48a17e21f23f2ed845d5bbe",
	"8a19db0713450e5bc35a9c47719673e0",
	"e0a462712cd691f5bcfc0f25a789ee84",
	"43a755f315626c25bbd36f2a170827b5",
	"679cc7a2fcb7eaa09c276e045f488d85",
	"b09c78830a20f6279a909c7379242182",
	"95a8717af71668eb25ff4d97fe4e743a",
	"c6a79f4366557f38549d7e1d107c2ef9",
	"1ef3fe24543b84c895e7ac3c79bddee0",
	"4b62196a2776643559437c077747d800",
	"0b729fa175f83b333b8120c17ee4eebb",
	"a29ea19732831850f66b45d247881f74",
	"84c698fd8b05fab0a799d0e2824499d1",
	"e98bd26d81b50c8e5d14a2e8edac2b87",
	"a3651de718f9d81fb26d33d2f9ca23d4",
	"30e5331c98e719e56ec1f9b5f436f78a",
	"787fccca333df486bc950b2e38d8432a",
	"a3e3945c1df05c8a50bdb2149c2bcc88",
	"57852d1ad2066e005def644646d8dfcf",
	"35a87a1d61110a1e702570e2a7e67a7c",
	"1ff3fc2961a834bd531c773349e83535",
	"f77be51acec4338af49967fd50e9db01",
	"9d07b7dd01e09f364cb2a94e47a5eae0",
	"1d9b2d161fac751d5eb9124d49f0e947",
	"f820ce9dfee8677bf4a0918ceded5f8b",
	"aac130de963e807f7a7a287c188521de",
	"9f6304a25067d4738103b15018131dac",
	"077345c18849f37452b1247d1659b5e2",
	"bdae3c6d4abbc057b8c5d91c7f0549ac",
	"8d4d7ed61a008cc12eb30530117f7924",
	"ddbe38000f4036061f89202adbdf001d",
	"cc1de5eb68cb9b89cbf062b477fab352",
	"3ec4433213d04eb443245c60a9760258",
	"36d72d27d5fae71b2e986658741c5068",
	"7f2ec61cfabe48213f9d84960ce09428",
	"46cb57cb10c2f48dc7053a5091b93a01",
	"af888039a5ec52c4e1bbb28a07405c0d",
	"6eec51f060c488d6f19a48fd5664fc72",
	"ff992b91d35ca27dab5d476366a83449",
	"ec55e9027c5d989b8fb9b42c38d72909",
	"8711cfb1cced39739118560f51ec9249",
	"b56e780cc9287dc953e95e2feb7ce705",
	"8b8fe16d040f04ec6c2f187b874052c4",
	"e8cfc323cea3fcfb67d022c785db3f9a",
	"cb31929c423c906f51fc19a556abaacf",
	"0bb35424218414cbea721a6e39c612b0",
	"50065b964fb1957691f26d7660fb01be",
	"4c52d132d37d0a89d178fa2bedbd1a61",
	"5e8ac034d9b591fb35445ef3b3b848a7",
	"7037abdb33df1a427b7b9ec6fb0c5b14",
	"a99bb901d81dddc730928fa3cfe794e9",
	"2c1a068a5fdc533806c682bbc9a219ab",
	"e7c0d661858318ac023f0871fcb948b2",
	"d43e9fca83e874336f84aae5566d4533"
	};
	graphics = new string[] {
	"8ba47ab7890e038ef65d665fee811acb",
	"b7d8e3bde5d518af712cf98aa8a57a1d",
	"43d3e629f7ba7376ca5f71c5ce65843a",
	"7d87ce6dea097020fde64737db61beae",
	"c8702baf696191bdf703b13b72cbe4e4",
	"5c8869f17a5acc8869198d20c5d72d8c",
	"28e9fc1cde3d621e5bfa4c47c40e81b8",
	"a038c1f7439c97242a812c4e0f745af2",
	"d575716ad1f9333e4d3c6400d8585de9",
	"f1c160d590b5aa859e1acd9eb8832011",
	"223fd4e456d7bfdc5b624f9b0d165f46",
	"ce0f9d5b9733e126c1007bf7c5b7ae36",
	"c330399345d4984bb008a556f5648507",
	"ab69573c01b837a2145a4ba7358b6abf",
	"d15907090a73f4eb72c0a8051a9c1efe",
	"bff65a2b6bf5e3119e47a135f38ea608",
	"4a61d8c633717c142b83aa82d4c19b0b",
	"0a823704a1708a81d8736ca59b3e53e1",
	"ba504848b699d907aa0fbc96b322685c",
	"918f02bc0ba6581f345eb96142742560",
	"37eb22d4b3f98ef16657d8c2383debe6",
	"159aa7a425787855f3527fc7526fafc3",
	"b6e465032f1536a124e8cd73296bb738",
	"3f2d4ce01f5de3fc051ae746667e2640",
	"ec875b99708c418dc51c509fa1aa32e8",
	"7aea4ee05f2ed0659ea2808a82411762",
	"ed159e34780737c9f6588dbb2e2b65ce",
	"8e1d9699ab747610e87a255aed0111b1",
	"93de8f612d0d38cd580f839bccd14058",
	"c4768f49f53318afb5ca7d2dbe808f56",
	"1bca6c88bf2262a12f7766f61bad0048",
	"58c307a797ffeecf13be878d406d6cd3",
	"3084a1bbf71a0b762c271843287f4c25",
	"4b4001ecb3f00b8f8a6a81922f0fa61d",
	"32e6d718531e94fb000c034519fc9a8e",
	"934eebae1d103899901bb032479e8b73",
	"0f1f8ec80d0c2cec10b6964fcb890638",
	"537d6c95d1031481815a82738b93182f",
	"9027188a4a62c3891d340d65ea2628a6",
	"e471e241e1f7b2777a1e44a8e7865882",
	"4add0f081b223ae2fe4f095d4af1afac",
	"99a507869d83fced0d1514d34e2a0a5d",
	"3fe27b247e5d201aba15616bb489f3bf",
	"825e14714fd57d2138a1bb2d7cf0dfbd",
	"91a67264be7ca527571e8bd9c5c46349",
	"8dbb9c9436b9092979d9ff5f95b72b2e",
	"d97d8c1062663bc9c72e76324749d639",
	"7fc215e748f426e4c3b6a007c8a48fb0",
	"62c4e3a6c2a0dc79c7747ff594f491c5",
	"dd55ee245028608108ba1a7be782f001",
	"f2e9d344246ba20f351c14ffbdca3949",
	"35f167cfa4f706df6f4a5926aab5b944",
	"85b5c8adb98ac8a9b0ea5e8acfa93c95",
	"93c14d7157caea7018f7d376307ff4bf",
	"165f66d1f4e0b69e155fb2081461bf82",
	"41a94eeb75c78657b41eb0ad382aa484",
	"538e4d09fff897919d4c73a0c04e307b",
	"8002919debbedcf40f083c62e0d56751",
	"6addd04caf57252d8b1899ae1e772f4d",
	"3f3b628789f259b28bb3daf19bbbd2f3",
	"8f639ca5ebeedf2e009d4076e8749ba3",
	"3af4035af0a4cd5014812225bd95e1e4",
	"704673029f921aec76c9cb715728c070",
	"0877972e79eb52d18e5a1e29a1ff78f1",
	"62c461cdc9ad242247c638c8e9fe564a",
	"09ae53f7e02a07ea01d3b2362f183128",
	"2d68187ada9f62dd460cf43b0bd78d11",
	"54b324695fbaaab748e86ec07335d738",
	"b6d195c187a4f7d4072d0351945b107f",
	"d6c07dd439e211ccfedb4268abbe3157",
	"df817c9009899cc4e2aad35f46f4e77b",
	"42a3b1930d8b8d0933de5aa8811c11b7",
	"19a5159b39f164d1ac10a12dab566579",
	"b593d565bb90bfec6c33052010c515ad",
	"544b5855e93aa48444ce4bb370c3631e",
	"73ef40d2758ae8094f39970e2813a7ca",
	"378ce0739e7452d6cb4edb541521a523",
	"2751fbd7a334f0fa36e34908372444f1",
	"719d323f40ccc69b33d64869175a012b",
	"f51435690cb51e35d4f517676c413988",
	"f99c27624af034bdb9be5fd79db28533",
	"f2187e01c3de4454d0102fce29763658",
	"a0e1bc7a3ee9afad55536e093724f580",
	"2773e09911382c7aaf3f4aa4a38a32e5",
	"550b3b3b3a197d706410725ee4283af7",
	"57591cf4c594fa267d4ba7ea06c8469e",
	"23df08b8d7b89d282e7f95c9c9c8574d",
	"67550128b2e776c72c336efe223b5153",
	"9646ae27cd4d1601bcbf5cebc45186e0",
	"4ed0e7c2b4e8766792ca931a6bc3c97e",
	"3f11ef5e146f55d364f3baac28aba288",
	"2953f70457b552d620d332cee0b4358f",
	"2e7b26147eb0b8ad25870b7ac3f07dde",
	"772a395c1680807145dba40e6d7b7523",
	"d6615d0adb123747da7cc5a5f4651fd7",
	"197f6de41be7115b2afe3f8b42cade48",
	"3bdd37c1aeded2ba3f741c3e12596bf5",
	"8fb569ac8199afc8cf24877f3ed540f8",
	"c681630b1f8ec865141c6512a623659d",
	"dd5c687a9ee9c3c2200171a58905d89c",
	"38ab210634a2fe79e8f68f3c47d414f7",
	"62d9f7e543c583a8fd37050aa239b24d",
	"a3cb47d04865f202c500c1e016f16dd5",
	"fb18543cf0bdc50bb7fbebab00f7adaa",
	"1126f6a5309455ca9b442c24efcf4154",
	"19838100e6cd4247463160f115d460ae",
	"fc4ccd359586e30a542699dff81ad733",
	"28cdf2d795e2076a5c13c6a8eee53e52",
	"879b0ef71f0ac060aa3ddf66375e7b65",
	"a258c62c35aa1211d807b370982f49b1",
	"353161b2148bd938af2bf661de6c309b",
	"8ba47ab7890e038ef65d665fee811acb",
	"b7ba0957ab814ee661c0cdf3b809117c",
	"f37e257b36b10aeacc173146e72d40ea",
	"6c4d822edbe27e036575602415b3d75f",
	"9ae631e939c14b6f3d17281783e073ec",
	"b2ba483872ce802bdc03878f5cffeda4",
	"eba2629e5af6cb25f4239df12fe1b396",
	"f350dc0ea6677541eae7d663bda3ffeb",
	"3f928304e7d49e1fe5a7cef383919861",
	"24c76ec4aebab397aafdeaaa37e0233f",
	"05395f0b010d637f4e9eb22881d37ac1",
	"476b79d338b5de9d7584a13e69b89335",
	"9f3d05d58dac059e260bf3a54a28c977",
	"1e53554e87a613ba4e5a3431e1fd89d5",
	"a3759a50b2272ac863b4f05b69dc33a3",
	"238049b18fd32424eff6f0437c6db6d7",
	"189f999492b67e876ae14ad7d3320ded",
	"bde604994e05a22c1c8bd7ae67f4ea01",
	"5bc9c2914f29b92c8f807debdb0f9d4f",
	"4f50ea3ed9f9ffe6fe75542089dce779",
	"87b9094fde141cd14b11ce87924e4329",
	"9977d0c3a841c39665d51989baa70521",
	"b6bd6631def41b751557a75b5baff80e",
	"f633394e549fc8ddaaba505c5f1e803f",
	"9cbc9dd99363bdf29507ee75d58bdac6",
	"fa71fc70fe0239bede1bcc3d8e5445ee",
	"1c76918713ca577ba1cf02e0923bd85a",
	"b4295634a92e7697d860a9daa5544757",
	"e3423a97f0564a764832e89bfe7cad87",
	"cea0feae1af83f59c9a248253092b7bf",
	"733a2b0df581e4a5103a6e3af482ec6d",
	"7f4b76a3e22f2fb849883f4a4752ab35",
	"aaf601e03df43359aab84b96d630b421",
	"0d02f7536c2e021edce156b2e6d23606",
	"3b2a0473a0bfb20dacc21a1412db4f95",
	"14a80aede3bc0a72bee0b056361fedd6",
	"7ab0f979f02d9127f01c688624e0b262",
	"6cf587c89da52f3788c9edfbfac70500",
	"3d1eccca2c13cc79718345659a810b27",
	"cb5a27fb64fbd60cbf0a1160cc60b525",
	"5705818a3443e168405e14f1bbe28e09",
	"86be0b9bbdf556bac67bc3ec37b2be2d",
	"c8c862c7ee9f2a5e781677022cae7f53",
	"305389b3f70c02ea6091bb42e862050e",
	"12635fb71177511003cb07613f4f4e6f",
	"0852625260a2ffed95186e1d5c46a9d1",
	"3ae4eef3f6f9fb157fa2bf4a4c780b0a",
	"9518ebb8c4b9a43300531b2e30204993",
	"10d1f1632e4e7d43a5e167859c66e3de",
	"1036c6891f75fbc984f7d66ba563a70f",
	"c83aa87e660d17fd913e8650f6d27b49",
	"023ddd6ccb959b9443803ec0ce89b4b7",
	"02212169f2886387dcc4e325acaa5550",
	"cb281cd869b545ba3d8d5b860ae3f545",
	"a4b9cd8335bbf20eded3fde0178f13bd",
	"9aeaf4031c977009a135e22e77fc2333",
	"2432b43ff420c065e13be2f322e48a49",
	"ce60511a26079c3b0172e8814833857f",
	"e3db4d6eed66a8dc556cccd9866cd06b",
	"c8e5efb714c78492e4ca0c7d43cbb152",
	"7477f8e334cfa730ae0130fc8219e11b"
	};
	}
}
public class AchievementsEffect : MovieClip{ 
	public AchievementsEffect() {
		var i117 = new resources_fla.salute_67(){scaleX = 0.68 , filters = new as3.Array(new object[]{}) , scaleY = 0.68};
		addChild(i117);//0
		FrameInfo f;
		var l= new Frames(40);
		f = l.Add();
		f.Add(i117);
		f += () => {
			i117.x = 0;
			i117.scaleX = 0.68;
			i117.y = 0;
			i117.scaleY = 0.68;
			i117.rotation = 0;
			i117.alpha = 1;
			i117.filters = new as3.Array(new object[]{});
			i117.scale9Grid = null;
			i117.visible = true;
		};
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		f = l.Add();
		f.Add(i117);
		setFrames(l);
	}
}
public class ActionBuyRates : BitmapData{ 
	public ActionBuyRates() {
		width = 34;
		height = 34;
		setPixels("f350dc0ea6677541eae7d663bda3ffeb");
	}
}
public class AnimationGacha : MovieClip{ 
	public MovieClip place;
	public AnimationGacha() {
		var filter_0 = new BlurFilter(){blurX = 6, quality = 2, blurY = 6};
		var i309 = new symbol_31(){filters = new as3.Array(new object[]{})};
		addChild(i309);//0
		var i310 = new symbol_33(){x = 69.2 , scaleX = 0.98 , y = 108.1 , scaleY = 0.98 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i310);//1
		place = new symbol_36(){x = 129.1 , y = 155.1 , filters = new as3.Array(new object[]{})};
		addChild(place);//2
		var i314 = new symbol_39(){x = 185.3 , scaleX = 0.64 , y = 194.1 , scaleY = 0.64 , rotation = -21 , filters = new as3.Array(new object[]{})};
		addChild(i314);//3
		var i318 = new symbol_42(){x = 174.3 , y = 195.8 , filters = new as3.Array(new object[]{})};
		addChild(i318);//3
		var i322 = new symbol_44(){x = 164.1 , scaleX = 0.63 , y = 214.3 , scaleY = 0.63 , rotation = -147 , filters = new as3.Array(new object[]{})};
		addChild(i322);//4
		var i326 = new symbol_46(){x = 181.5 , scaleX = 0.64 , y = 229.3 , scaleY = 0.64 , rotation = 141 , filters = new as3.Array(new object[]{})};
		addChild(i326);//5
		var i330 = new symbol_48(){x = 170.8 , scaleX = 0.83 , y = 226.9 , scaleY = 0.83 , rotation = 179 , filters = new as3.Array(new object[]{})};
		addChild(i330);//6
		var i334 = new symbol_50(){x = 166.4 , scaleX = 0.83 , y = 211.7 , scaleY = 0.83 , rotation = -79 , filters = new as3.Array(new object[]{})};
		addChild(i334);//7
		var i338 = new symbol_52(){x = 188 , scaleX = 0.64 , y = 207.2 , scaleY = 0.64 , rotation = 101 , filters = new as3.Array(new object[]{})};
		addChild(i338);//7
		FrameInfo f;
		var l= new Frames(200);
		f = l.Add();
		f.Add(i309);
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i309.x = 0;
			i309.scaleX = 1;
			i309.y = 0;
			i309.scaleY = 1;
			i309.rotation = 0;
			i309.alpha = 1;
			i309.filters = new as3.Array(new object[]{});
			i309.scale9Grid = null;
			i309.visible = true;
			i310.x = 69.2;
			i310.scaleX = 0.98;
			i310.y = 108.1;
			i310.scaleY = 0.98;
			i310.rotation = 0;
			i310.alpha = 1;
			i310.filters = new as3.Array(new object[]{filter_0});
			i310.scale9Grid = null;
			i310.visible = true;
			place.x = 129.1;
			place.scaleX = 1;
			place.y = 155.1;
			place.scaleY = 1;
			place.rotation = 0;
			place.alpha = 1;
			place.filters = new as3.Array(new object[]{});
			place.scale9Grid = null;
			place.visible = true;
			i314.x = 185.3;
			i314.scaleX = 0.64;
			i314.y = 194.1;
			i314.scaleY = 0.64;
			i314.rotation = -21;
			i314.alpha = 1;
			i314.filters = new as3.Array(new object[]{});
			i314.scale9Grid = null;
			i314.visible = true;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 73.9;
			i310.scaleX = 0.97;
			i310.y = 103.8;
			i310.scaleY = 0.97;
			i310.rotation = 2;
			place.y = 154.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 78.8;
			i310.y = 99.7;
			i310.rotation = 5;
			place.y = 154.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 83.8;
			i310.y = 95.8;
			i310.rotation = 7;
			place.y = 154.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 88.7;
			i310.scaleX = 0.96;
			i310.y = 92.5;
			i310.scaleY = 0.96;
			i310.rotation = 9;
			place.y = 154.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 94;
			i310.y = 89;
			i310.rotation = 12;
			place.y = 154.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 99.3;
			i310.y = 86;
			i310.rotation = 14;
			place.y = 153.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 104.5;
			i310.scaleX = 0.95;
			i310.y = 83.3;
			i310.scaleY = 0.95;
			i310.rotation = 17;
			i310.alpha = 0.9;
			place.y = 153.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 110;
			i310.y = 80.6;
			i310.rotation = 19;
			place.y = 153.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 115.3;
			i310.y = 78.4;
			i310.rotation = 21;
			place.y = 153.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 120.5;
			i310.scaleX = 0.94;
			i310.y = 76.5;
			i310.scaleY = 0.94;
			i310.rotation = 24;
			place.y = 153.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 126.3;
			i310.y = 74.5;
			i310.rotation = 26;
			place.y = 152.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 131.7;
			i310.scaleX = 0.93;
			i310.y = 73;
			i310.scaleY = 0.93;
			i310.rotation = 28;
			place.y = 152.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 137.1;
			i310.y = 71.7;
			i310.rotation = 31;
			place.y = 152.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 142.4;
			i310.y = 70.5;
			i310.rotation = 33;
			place.y = 152.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 147.4;
			i310.y = 69.8;
			i310.rotation = 35;
			place.y = 151.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 152.8;
			i310.scaleX = 0.92;
			i310.y = 69.1;
			i310.scaleY = 0.92;
			i310.rotation = 37;
			place.y = 151.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 158.2;
			i310.y = 68.7;
			i310.rotation = 39;
			place.y = 151.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f += () => {
			i310.x = 163.1;
			i310.y = 68.4;
			i310.rotation = 41;
			place.y = 150.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 168.4;
			i310.scaleX = 0.91;
			i310.y = 68.3;
			i310.scaleY = 0.91;
			i310.rotation = 44;
			place.y = 150.7;
			i318.x = 174.3;
			i318.scaleX = 1;
			i318.y = 195.8;
			i318.scaleY = 1;
			i318.rotation = 0;
			i318.alpha = 1;
			i318.filters = new as3.Array(new object[]{});
			i318.scale9Grid = null;
			i318.visible = true;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 173.3;
			i310.y = 68.5;
			i310.rotation = 46;
			place.y = 150.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 178.1;
			i310.y = 68.8;
			i310.rotation = 48;
			place.y = 150.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 183.4;
			i310.scaleX = 0.9;
			i310.y = 69.3;
			i310.scaleY = 0.9;
			i310.rotation = 50;
			i310.alpha = 0.8;
			place.y = 149.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 188.1;
			i310.y = 70;
			i310.rotation = 52;
			place.y = 149.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 192.8;
			i310.y = 70.8;
			i310.rotation = 54;
			place.y = 149.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 197;
			i310.y = 71.7;
			i310.rotation = 56;
			place.y = 148.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 201.6;
			i310.scaleX = 0.89;
			i310.y = 72.8;
			i310.scaleY = 0.89;
			i310.rotation = 58;
			place.y = 148.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 205.9;
			i310.y = 74;
			i310.rotation = 60;
			place.y = 148.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 210;
			i310.y = 75.2;
			i310.rotation = 61;
			place.y = 149.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f += () => {
			i310.x = 214.3;
			i310.scaleX = 0.88;
			i310.y = 76.8;
			i310.scaleY = 0.88;
			i310.rotation = 63;
			place.y = 149.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 218.2;
			i310.y = 78.3;
			i310.rotation = 65;
			place.y = 149.9;
			i322.x = 164.1;
			i322.scaleX = 0.63;
			i322.y = 214.3;
			i322.scaleY = 0.63;
			i322.rotation = -147;
			i322.alpha = 1;
			i322.filters = new as3.Array(new object[]{});
			i322.scale9Grid = null;
			i322.visible = true;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 222.4;
			i310.y = 80.1;
			i310.rotation = 67;
			place.y = 150.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 226.1;
			i310.y = 81.8;
			i310.rotation = 69;
			place.y = 150.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 229.7;
			i310.scaleX = 0.87;
			i310.y = 83.7;
			i310.scaleY = 0.87;
			i310.rotation = 71;
			place.y = 150.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 233.3;
			i310.y = 85.6;
			i310.rotation = 72;
			place.y = 151.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 236.7;
			i310.y = 87.5;
			i310.rotation = 74;
			place.y = 151.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 240.1;
			i310.y = 89.7;
			i310.rotation = 76;
			place.y = 151.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 242.9;
			i310.scaleX = 0.86;
			i310.y = 91.7;
			i310.scaleY = 0.86;
			i310.rotation = 77;
			place.y = 152;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 246.3;
			i310.y = 94;
			i310.rotation = 79;
			place.y = 152.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 249.3;
			i310.y = 96.3;
			i310.rotation = 81;
			place.y = 152.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 252.1;
			i310.y = 98.5;
			i310.rotation = 82;
			i310.alpha = 0.7;
			place.y = 152.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 254.9;
			i310.y = 101;
			i310.rotation = 84;
			place.y = 153.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 257.5;
			i310.scaleX = 0.85;
			i310.y = 103.3;
			i310.scaleY = 0.85;
			i310.rotation = 86;
			place.y = 153.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f += () => {
			i310.x = 260;
			i310.y = 105.6;
			i310.rotation = 87;
			place.y = 153.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 262.4;
			i310.y = 108;
			i310.rotation = 89;
			place.y = 153.8;
			i326.x = 181.5;
			i326.scaleX = 0.64;
			i326.y = 229.3;
			i326.scaleY = 0.64;
			i326.rotation = 141;
			i326.alpha = 1;
			i326.filters = new as3.Array(new object[]{});
			i326.scale9Grid = null;
			i326.visible = true;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 264.3;
			i310.y = 110.2;
			i310.rotation = 90;
			place.y = 154.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 266.5;
			i310.scaleX = 0.84;
			i310.y = 112.6;
			i310.scaleY = 0.84;
			i310.rotation = 92;
			place.y = 154.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 268.8;
			i310.y = 115.2;
			i310.rotation = 93;
			place.y = 154.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 270.4;
			i310.y = 117.5;
			i310.rotation = 94;
			place.y = 154.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 272.5;
			i310.y = 120;
			i310.rotation = 96;
			place.y = 154.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 274.5;
			i310.y = 122.7;
			i310.rotation = 97;
			place.y = 155.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 277.4;
			i310.y = 125.3;
			i310.rotation = 99;
			place.y = 154.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 280.2;
			i310.y = 128;
			i310.rotation = 101;
			place.y = 154.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 282.9;
			i310.scaleX = 0.85;
			i310.y = 130.9;
			i310.scaleY = 0.85;
			i310.rotation = 103;
			place.y = 154.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 285.8;
			i310.y = 133.7;
			i310.rotation = 104;
			place.y = 154.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 288.5;
			i310.scaleX = 0.86;
			i310.y = 137.1;
			i310.scaleY = 0.86;
			i310.rotation = 106;
			place.y = 154.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 291.1;
			i310.y = 140.2;
			i310.rotation = 108;
			place.y = 154;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 293.5;
			i310.y = 143.4;
			i310.rotation = 110;
			place.y = 153.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 295.9;
			i310.scaleX = 0.87;
			i310.y = 146.8;
			i310.scaleY = 0.87;
			i310.rotation = 112;
			place.y = 153.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 298.1;
			i310.y = 150.1;
			i310.rotation = 113;
			i310.alpha = 0.8;
			place.y = 153.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 300.4;
			i310.y = 153.9;
			i310.rotation = 115;
			place.y = 153.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 302.5;
			i310.scaleX = 0.88;
			i310.y = 157.5;
			i310.scaleY = 0.88;
			i310.rotation = 117;
			place.y = 152.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 304.4;
			i310.y = 161.1;
			i310.rotation = 119;
			place.y = 152.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 306.3;
			i310.scaleX = 0.89;
			i310.y = 164.8;
			i310.scaleY = 0.89;
			i310.rotation = 121;
			place.y = 152.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f += () => {
			i310.x = 308;
			i310.y = 168.6;
			i310.rotation = 122;
			place.y = 152.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 309.7;
			i310.y = 172.8;
			i310.rotation = 124;
			place.y = 151.9;
			i330.x = 170.8;
			i330.scaleX = 0.83;
			i330.y = 226.9;
			i330.scaleY = 0.83;
			i330.rotation = 179;
			i330.alpha = 1;
			i330.filters = new as3.Array(new object[]{});
			i330.scale9Grid = null;
			i330.visible = true;
			i334.x = 166.4;
			i334.scaleX = 0.83;
			i334.y = 211.7;
			i334.scaleY = 0.83;
			i334.rotation = -79;
			i334.alpha = 1;
			i334.filters = new as3.Array(new object[]{});
			i334.scale9Grid = null;
			i334.visible = true;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 311.2;
			i310.scaleX = 0.9;
			i310.y = 176.8;
			i310.scaleY = 0.9;
			i310.rotation = 126;
			place.y = 151.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 312.6;
			i310.y = 180.7;
			i310.rotation = 128;
			place.y = 151.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 313.8;
			i310.y = 184.8;
			i310.rotation = 130;
			place.y = 151.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 315;
			i310.scaleX = 0.91;
			i310.y = 188.8;
			i310.scaleY = 0.91;
			i310.rotation = 131;
			place.y = 150.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 316;
			i310.y = 193.4;
			i310.rotation = 133;
			place.y = 150.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 316.9;
			i310.scaleX = 0.92;
			i310.y = 197.7;
			i310.scaleY = 0.92;
			i310.rotation = 135;
			place.y = 150.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 317.6;
			i310.y = 201.8;
			i310.rotation = 137;
			place.y = 150;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 318.2;
			i310.y = 206.2;
			i310.rotation = 139;
			place.y = 149.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 318.7;
			i310.scaleX = 0.93;
			i310.y = 210.4;
			i310.scaleY = 0.93;
			i310.rotation = 140;
			place.y = 149.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 319;
			i310.y = 215.2;
			i310.rotation = 142;
			i310.alpha = 0.9;
			place.y = 149.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 319.3;
			i310.scaleX = 0.94;
			i310.y = 219.6;
			i310.scaleY = 0.94;
			i310.rotation = 144;
			place.y = 148.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.y = 223.9;
			i310.rotation = 146;
			place.y = 148.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 319.2;
			i310.y = 228.3;
			i310.rotation = 148;
			place.y = 148.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 318.9;
			i310.scaleX = 0.95;
			i310.y = 232.7;
			i310.scaleY = 0.95;
			i310.rotation = 149;
			place.y = 149.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 318.6;
			i310.y = 237.6;
			i310.rotation = 151;
			place.y = 149.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 318.1;
			i310.y = 242;
			i310.rotation = 153;
			place.y = 149.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 317.4;
			i310.scaleX = 0.96;
			i310.y = 246.4;
			i310.scaleY = 0.96;
			i310.rotation = 155;
			place.y = 150.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 316.6;
			i310.y = 250.8;
			i310.rotation = 157;
			place.y = 150.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 315.4;
			i310.scaleX = 0.97;
			i310.y = 255.7;
			i310.scaleY = 0.97;
			i310.rotation = 159;
			place.y = 150.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 314.4;
			i310.y = 260.1;
			i310.rotation = 160;
			place.y = 151.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f += () => {
			i310.x = 313.1;
			i310.y = 264.5;
			i310.rotation = 162;
			place.y = 151.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 311.9;
			i310.scaleX = 0.98;
			i310.y = 268.9;
			i310.scaleY = 0.98;
			i310.rotation = 164;
			place.y = 151.8;
			i338.x = 188;
			i338.scaleX = 0.64;
			i338.y = 207.2;
			i338.scaleY = 0.64;
			i338.rotation = 101;
			i338.alpha = 1;
			i338.filters = new as3.Array(new object[]{});
			i338.scale9Grid = null;
			i338.visible = true;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 310.3;
			i310.y = 273.1;
			i310.rotation = 166;
			place.y = 152.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i314);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 308.4;
			i310.scaleX = 0.99;
			i310.y = 277.9;
			i310.scaleY = 0.99;
			i310.rotation = 168;
			place.y = 152.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 306.6;
			i310.y = 282.1;
			i310.rotation = 169;
			place.y = 152.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 304.6;
			i310.y = 286.3;
			i310.rotation = 171;
			place.y = 153;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 302.6;
			i310.scaleX = 1;
			i310.y = 290.4;
			i310.scaleY = 1;
			i310.rotation = 173;
			i310.alpha = 1;
			place.y = 153.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 300.4;
			i310.y = 294.5;
			i310.rotation = 175;
			place.y = 153.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 297.8;
			i310.scaleX = 1.01;
			i310.y = 298.9;
			i310.scaleY = 1.01;
			i310.rotation = 177;
			place.y = 153.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 295.3;
			i310.y = 302.9;
			i310.rotation = 178;
			place.y = 154;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 292.9;
			i310.y = 306.4;
			i310.rotation = -179;
			place.y = 154.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 290.1;
			i310.scaleX = 1.02;
			i310.y = 310.3;
			i310.scaleY = 1.02;
			i310.rotation = -177;
			place.y = 154.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 287.3;
			i310.y = 314.1;
			i310.rotation = -175;
			place.y = 154.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i318);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 283.8;
			i310.y = 318;
			i310.rotation = -173;
			place.y = 154.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 280.7;
			i310.scaleX = 1.03;
			i310.y = 321.8;
			i310.scaleY = 1.03;
			i310.rotation = -172;
			place.y = 155.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 276.2;
			i310.y = 324.6;
			i310.rotation = -170;
			place.y = 154.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 271.1;
			i310.scaleX = 1.02;
			i310.y = 327.9;
			i310.scaleY = 1.02;
			i310.rotation = -167;
			place.y = 154.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 266.4;
			i310.y = 330.6;
			i310.rotation = -165;
			place.y = 154.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 261.6;
			i310.scaleX = 1.01;
			i310.y = 333.1;
			i310.scaleY = 1.01;
			i310.rotation = -163;
			place.y = 154.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 256.4;
			i310.y = 335.7;
			i310.rotation = -161;
			place.y = 154.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 251.5;
			i310.y = 337.9;
			i310.rotation = -159;
			place.y = 153.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 246.6;
			i310.scaleX = 1;
			i310.y = 339.8;
			i310.scaleY = 1;
			i310.rotation = -157;
			i310.alpha = 0.9;
			place.y = 153.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 241.5;
			i310.y = 341.6;
			i310.rotation = -155;
			place.y = 153.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 236.6;
			i310.y = 343.3;
			i310.rotation = -153;
			place.y = 153.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 231.6;
			i310.scaleX = 0.99;
			i310.y = 344.7;
			i310.scaleY = 0.99;
			i310.rotation = -151;
			place.y = 153.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 226.9;
			i310.y = 345.7;
			i310.rotation = -149;
			place.y = 152.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 221.9;
			i310.y = 346.9;
			i310.rotation = -147;
			place.y = 152.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 216.9;
			i310.scaleX = 0.98;
			i310.y = 347.8;
			i310.scaleY = 0.98;
			i310.rotation = -145;
			place.y = 152.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 212.3;
			i310.y = 348.4;
			i310.rotation = -144;
			place.y = 152.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 207.2;
			i310.y = 348.9;
			i310.rotation = -142;
			place.y = 151.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 202.7;
			i310.scaleX = 0.97;
			i310.y = 349.3;
			i310.scaleY = 0.97;
			i310.rotation = -140;
			place.y = 151.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 198.2;
			i310.y = 349.4;
			i310.rotation = -138;
			place.y = 151.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 193.6;
			i310.y = 349.5;
			i310.rotation = -136;
			place.y = 150.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 189.2;
			i310.scaleX = 0.96;
			i310.y = 349.4;
			i310.scaleY = 0.96;
			i310.rotation = -135;
			place.y = 150.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 184.7;
			i310.y = 349.2;
			i310.rotation = -133;
			place.y = 150.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 180.3;
			i310.y = 348.8;
			i310.rotation = -131;
			place.y = 150.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 175.8;
			i310.y = 348.4;
			i310.rotation = -129;
			i310.alpha = 0.8;
			place.y = 149.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 171.5;
			i310.scaleX = 0.95;
			i310.y = 347.8;
			i310.scaleY = 0.95;
			i310.rotation = -128;
			place.y = 149.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 167.2;
			i310.y = 347.1;
			i310.rotation = -126;
			place.y = 149.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 163.4;
			i310.y = 346.3;
			i310.rotation = -124;
			place.y = 148.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 159.3;
			i310.scaleX = 0.94;
			i310.y = 345.3;
			i310.scaleY = 0.94;
			i310.rotation = -123;
			place.y = 148.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 155.6;
			i310.y = 344.3;
			i310.rotation = -121;
			place.y = 148.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 151.4;
			i310.y = 343.1;
			i310.rotation = -119;
			place.y = 149.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 147.9;
			i310.y = 341.9;
			i310.rotation = -118;
			place.y = 149.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 144.3;
			i310.scaleX = 0.93;
			i310.y = 340.7;
			i310.scaleY = 0.93;
			i310.rotation = -116;
			place.y = 149.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 140.5;
			i310.y = 339.2;
			i310.rotation = -115;
			place.y = 150.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 137.1;
			i310.y = 337.8;
			i310.rotation = -113;
			place.y = 150.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 133.7;
			i310.y = 336.4;
			i310.rotation = -112;
			place.y = 150.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 130.5;
			i310.scaleX = 0.92;
			i310.y = 334.8;
			i310.scaleY = 0.92;
			i310.rotation = -110;
			place.y = 151.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 127.6;
			i310.y = 333.2;
			i310.rotation = -109;
			place.y = 151.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 124.5;
			i310.y = 331.6;
			i310.rotation = -107;
			place.y = 151.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 121.3;
			i310.y = 329.8;
			i310.rotation = -106;
			place.y = 152;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 118.3;
			i310.scaleX = 0.91;
			i310.y = 327.9;
			i310.scaleY = 0.91;
			i310.rotation = -104;
			place.y = 152.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 115.8;
			i310.y = 326.1;
			i310.rotation = -103;
			place.y = 152.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 112.8;
			i310.y = 324.1;
			i310.rotation = -102;
			i310.alpha = 0.7;
			place.y = 152.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 110.3;
			i310.y = 322.4;
			i310.rotation = -100;
			place.y = 153.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 107.9;
			i310.y = 320.6;
			i310.rotation = -99;
			place.y = 153.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i330);
		f.Add(i334);
		f.Add(i338);
		f += () => {
			i310.x = 105.5;
			i310.scaleX = 0.9;
			i310.y = 318.6;
			i310.scaleY = 0.9;
			i310.rotation = -98;
			place.y = 153.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 103;
			i310.y = 316.5;
			i310.rotation = -96;
			place.y = 153.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 100.7;
			i310.y = 314.6;
			i310.rotation = -95;
			place.y = 154.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 98.4;
			i310.y = 312.6;
			i310.rotation = -94;
			place.y = 154.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 96.7;
			i310.y = 310.8;
			i310.rotation = -93;
			place.y = 154.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 94.6;
			i310.scaleX = 0.89;
			i310.y = 308.8;
			i310.scaleY = 0.89;
			i310.rotation = -92;
			place.y = 154.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 92.6;
			i310.y = 306.7;
			i310.rotation = -90;
			place.y = 154.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 90.8;
			i310.y = 304.8;
			i310.rotation = -89;
			place.y = 155.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 87.7;
			i310.y = 302.2;
			i310.rotation = -87;
			place.y = 154.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 84.1;
			i310.y = 299.1;
			i310.rotation = -85;
			place.y = 154.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 81;
			i310.y = 296.4;
			i310.rotation = -84;
			place.y = 154.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 77.8;
			i310.scaleX = 0.9;
			i310.y = 293.1;
			i310.scaleY = 0.9;
			i310.rotation = -82;
			place.y = 154.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 74.9;
			i310.y = 290.1;
			i310.rotation = -80;
			place.y = 154.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 71.8;
			i310.y = 286.5;
			i310.rotation = -78;
			place.y = 154;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 69.2;
			i310.y = 283.4;
			i310.rotation = -76;
			place.y = 153.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 66.5;
			i310.y = 279.9;
			i310.rotation = -74;
			i310.alpha = 0.8;
			place.y = 153.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 63.8;
			i310.y = 276.1;
			i310.rotation = -72;
			place.y = 153.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 61.4;
			i310.scaleX = 0.91;
			i310.y = 272.6;
			i310.scaleY = 0.91;
			i310.rotation = -71;
			place.y = 153.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 58.9;
			i310.y = 268.8;
			i310.rotation = -69;
			place.y = 152.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 56.8;
			i310.y = 265;
			i310.rotation = -67;
			place.y = 152.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 54.5;
			i310.y = 260.9;
			i310.rotation = -65;
			place.y = 152.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 52.6;
			i310.y = 257;
			i310.rotation = -63;
			place.y = 152.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 50.7;
			i310.scaleX = 0.92;
			i310.y = 252.8;
			i310.scaleY = 0.92;
			i310.rotation = -61;
			place.y = 151.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 49;
			i310.y = 248.8;
			i310.rotation = -59;
			place.y = 151.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 47.4;
			i310.y = 244.3;
			i310.rotation = -57;
			place.y = 151.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 45.9;
			i310.y = 240.3;
			i310.rotation = -56;
			place.y = 151.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 44.4;
			i310.y = 235.7;
			i310.rotation = -54;
			place.y = 150.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 43.3;
			i310.y = 231.6;
			i310.rotation = -52;
			place.y = 150.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 42.2;
			i310.scaleX = 0.93;
			i310.y = 226.9;
			i310.scaleY = 0.93;
			i310.rotation = -50;
			place.y = 150.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 41.3;
			i310.y = 222.7;
			i310.rotation = -48;
			place.y = 150;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 40.6;
			i310.y = 217.8;
			i310.rotation = -46;
			place.y = 149.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 39.9;
			i310.y = 213.6;
			i310.rotation = -44;
			place.y = 149.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 39.4;
			i310.y = 209.2;
			i310.rotation = -43;
			i310.alpha = 0.9;
			place.y = 149.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 39;
			i310.y = 204.4;
			i310.rotation = -41;
			place.y = 148.8;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.scaleX = 0.94;
			i310.y = 200;
			i310.scaleY = 0.94;
			i310.rotation = -39;
			place.y = 148.5;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 38.9;
			i310.y = 195.2;
			i310.rotation = -37;
			place.y = 148.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 39;
			i310.y = 190.8;
			i310.rotation = -35;
			place.y = 149.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 39.3;
			i310.y = 185.9;
			i310.rotation = -33;
			place.y = 149.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 39.6;
			i310.y = 181.5;
			i310.rotation = -31;
			place.y = 150;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 40.3;
			i310.scaleX = 0.95;
			i310.y = 176.7;
			i310.scaleY = 0.95;
			i310.rotation = -29;
			place.y = 150.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 41;
			i310.y = 172.3;
			i310.rotation = -28;
			place.y = 150.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 42;
			i310.y = 167.4;
			i310.rotation = -26;
			place.y = 151.1;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 42.9;
			i310.y = 163.1;
			i310.rotation = -24;
			place.y = 151.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 44.1;
			i310.y = 158.4;
			i310.rotation = -22;
			place.y = 151.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 45.4;
			i310.scaleX = 0.96;
			i310.y = 154;
			i310.scaleY = 0.96;
			i310.rotation = -20;
			place.y = 152;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 47;
			i310.y = 149.3;
			i310.rotation = -18;
			place.y = 152.3;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 48.5;
			i310.y = 145.1;
			i310.rotation = -16;
			place.y = 152.6;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 50.4;
			i310.y = 140.6;
			i310.rotation = -14;
			place.y = 152.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 52.2;
			i310.y = 136.4;
			i310.rotation = -13;
			place.y = 153.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 54.4;
			i310.y = 131.9;
			i310.rotation = -11;
			i310.alpha = 1;
			place.y = 153.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 56.5;
			i310.scaleX = 0.97;
			i310.y = 128;
			i310.scaleY = 0.97;
			i310.rotation = -9;
			place.y = 153.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 58.6;
			i310.y = 124;
			i310.rotation = -7;
			place.y = 153.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 61.3;
			i310.y = 119.8;
			i310.rotation = -5;
			place.y = 154.2;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 63.8;
			i310.y = 115.9;
			i310.rotation = -3;
			place.y = 154.4;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 66.6;
			i310.y = 111.8;
			i310.rotation = -1;
			place.y = 154.7;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 69.3;
			i310.scaleX = 0.98;
			i310.y = 108.2;
			i310.scaleY = 0.98;
			i310.rotation = 0;
			place.y = 154.9;
		};
		f = l.Add();
		f.Add(i310);
		f.Add(place);
		f.Add(i322);
		f.Add(i326);
		f.Add(i338);
		f += () => {
			i310.x = 72.3;
			i310.y = 104.5;
			i310.rotation = 1;
			place.y = 155.1;
		};
		setFrames(l);
	}
}
public class AnnounceCollectionBananiIcon : BitmapData{ 
	public AnnounceCollectionBananiIcon() {
		width = 52;
		height = 52;
		setPixels("2751fbd7a334f0fa36e34908372444f1");
	}
}
public class AnnounceGiftsIcon : BitmapData{ 
	public AnnounceGiftsIcon() {
		width = 96;
		height = 65;
		setPixels("0d02f7536c2e021edce156b2e6d23606");
	}
}
public class AnnounceGiftsIcon2 : BitmapData{ 
	public AnnounceGiftsIcon2() {
		width = 96;
		height = 58;
		setPixels("f51435690cb51e35d4f517676c413988");
	}
}
public class AnnounceStickersIcon : BitmapData{ 
	public AnnounceStickersIcon() {
		width = 103;
		height = 64;
		setPixels("05395f0b010d637f4e9eb22881d37ac1");
	}
}
public class AnnounceStickersIcon2 : BitmapData{ 
	public AnnounceStickersIcon2() {
		width = 96;
		height = 53;
		setPixels("58c307a797ffeecf13be878d406d6cd3");
	}
}
public class ApproxIcon : BitmapData{ 
	public ApproxIcon() {
		width = 8;
		height = 6;
		setPixels("f1c160d590b5aa859e1acd9eb8832011");
	}
}
public class ArrowAnimation : MovieClip{ 
	public ArrowAnimation() {
		var i343 = new symbol_54(){filters = new as3.Array(new object[]{})};
		addChild(i343);//0
		FrameInfo f;
		var l= new Frames(22);
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.x = 0;
			i343.scaleX = 1;
			i343.y = 0;
			i343.scaleY = 1;
			i343.rotation = 0;
			i343.alpha = 1;
			i343.filters = new as3.Array(new object[]{});
			i343.scale9Grid = null;
			i343.visible = true;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 0.5;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 1.7;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 3.9;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 6.9;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 10.8;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.05;
			i343.y = 12;
			i343.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.09;
			i343.y = 13;
			i343.scaleY = 0.91;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.12;
			i343.y = 13.7;
			i343.scaleY = 0.88;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.13;
			i343.y = 14.1;
			i343.scaleY = 0.86;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.14;
			i343.y = 14.3;
			i343.scaleY = 0.85;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.13;
			i343.y = 14.1;
			i343.scaleY = 0.86;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.12;
			i343.y = 13.7;
			i343.scaleY = 0.88;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.09;
			i343.y = 13.1;
			i343.scaleY = 0.91;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1.05;
			i343.y = 12.1;
			i343.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.scaleX = 1;
			i343.y = 10.8;
			i343.scaleY = 1;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 7.5;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 4.8;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 2.7;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 1.2;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 0.3;
		};
		f = l.Add();
		f.Add(i343);
		f += () => {
			i343.y = 0;
		};
		setFrames(l);
	}
}
public class ArrowNextDisableIcon : BitmapData{ 
	public ArrowNextDisableIcon() {
		width = 20;
		height = 20;
		setPixels("3f3b628789f259b28bb3daf19bbbd2f3");
	}
}
public class ArrowNextIcon : BitmapData{ 
	public ArrowNextIcon() {
		width = 20;
		height = 20;
		setPixels("4a61d8c633717c142b83aa82d4c19b0b");
	}
}
public class ArrowPreviousDisableIcon : BitmapData{ 
	public ArrowPreviousDisableIcon() {
		width = 20;
		height = 20;
		setPixels("5705818a3443e168405e14f1bbe28e09");
	}
}
public class ArrowPreviousIcon : BitmapData{ 
	public ArrowPreviousIcon() {
		width = 20;
		height = 20;
		setPixels("62c4e3a6c2a0dc79c7747ff594f491c5");
	}
}
public class AuraAmurBig : BitmapData{ 
	public AuraAmurBig() {
		width = 69;
		height = 63;
		setPixels("879b0ef71f0ac060aa3ddf66375e7b65");
	}
}
public class BanRed : BitmapData{ 
	public BanRed() {
		width = 20;
		height = 20;
		setPixels("9cbc9dd99363bdf29507ee75d58bdac6");
	}
}
public class BanWhite : BitmapData{ 
	public BanWhite() {
		width = 16;
		height = 16;
		setPixels("3ae4eef3f6f9fb157fa2bf4a4c780b0a");
	}
}
public class BananiBottlesHintImage : BitmapData{ 
	public BananiBottlesHintImage() {
		width = 72;
		height = 72;
		setPixels("37eb22d4b3f98ef16657d8c2383debe6");
	}
}
public class BananiGiftTape : BitmapData{ 
	public BananiGiftTape() {
		width = 194;
		height = 48;
		setPixels("197f6de41be7115b2afe3f8b42cade48");
	}
}
public class BananiGlowImage : BitmapData{ 
	public BananiGlowImage() {
		width = 239;
		height = 222;
		setPixels("73ef40d2758ae8094f39970e2813a7ca");
	}
}
public class BananiPrizeOverBg : BitmapData{ 
	public BananiPrizeOverBg() {
		width = 154;
		height = 149;
		setPixels("ec875b99708c418dc51c509fa1aa32e8");
	}
}
public class BananiRatingIcon : BitmapData{ 
	public BananiRatingIcon() {
		width = 24;
		height = 25;
		setPixels("3b2a0473a0bfb20dacc21a1412db4f95");
	}
}
public class BananiStickersLock : BitmapData{ 
	public BananiStickersLock() {
		width = 15;
		height = 22;
		setPixels("a3cb47d04865f202c500c1e016f16dd5");
	}
}
public class BananiStickersTapeBig : BitmapData{ 
	public BananiStickersTapeBig() {
		width = 728;
		height = 165;
		setPixels("9027188a4a62c3891d340d65ea2628a6");
	}
}
public class BananiStickersTapeSmall : BitmapData{ 
	public BananiStickersTapeSmall() {
		width = 544;
		height = 125;
		setPixels("10d1f1632e4e7d43a5e167859c66e3de");
	}
}
public class BgLoadPhoto : BitmapData{ 
	public BgLoadPhoto() {
		width = 400;
		height = 400;
		setPixels("b7ba0957ab814ee661c0cdf3b809117c");
	}
}
public class BlockedPhotoMan : BitmapData{ 
	public BlockedPhotoMan() {
		width = 400;
		height = 400;
		setPixels("f2187e01c3de4454d0102fce29763658");
	}
}
public class BlockedPhotoManEn : BitmapData{ 
	public BlockedPhotoManEn() {
		width = 400;
		height = 400;
		setPixels("772a395c1680807145dba40e6d7b7523");
	}
}
public class BlockedPhotoWoman : BitmapData{ 
	public BlockedPhotoWoman() {
		width = 400;
		height = 400;
		setPixels("7f4b76a3e22f2fb849883f4a4752ab35");
	}
}
public class BlockedPhotoWomanEn : BitmapData{ 
	public BlockedPhotoWomanEn() {
		width = 400;
		height = 400;
		setPixels("d97d8c1062663bc9c72e76324749d639");
	}
}
public class BonusAuraImage : MovieClip{ 
	public MovieClip hit;
	public BonusAuraImage() {
		var i346 = new symbol_55(){filters = new as3.Array(new object[]{})};
		addChild(i346);//0
		hit = new symbol_57(){x = -22 , y = -43.3 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusBottlesPandora : MovieClip{ 
	public BonusBottlesPandora() {
		var i349 = new symbol_58(){filters = new as3.Array(new object[]{})};
		addChild(i349);//0
	}
}
public class BonusBoxBottles : MovieClip{ 
	public MovieClip hit;
	public BonusBoxBottles() {
		var i351 = new symbol_59(){filters = new as3.Array(new object[]{})};
		addChild(i351);//0
		hit = new symbol_61(){x = -20.8 , y = -37.5 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusChatEngImage : MovieClip{ 
	public MovieClip hit;
	public BonusChatEngImage() {
		hit = new symbol_63(){x = -27.9 , y = -33.8 , filters = new as3.Array(new object[]{})};
		addChild(hit);//0
		var i355 = new symbol_64(){filters = new as3.Array(new object[]{})};
		addChild(i355);//1
	}
}
public class BonusChatImage : MovieClip{ 
	public MovieClip hit;
	public BonusChatImage() {
		hit = new symbol_65(){x = -27.9 , y = -33.8 , filters = new as3.Array(new object[]{})};
		addChild(hit);//0
		var i358 = new symbol_66(){filters = new as3.Array(new object[]{})};
		addChild(i358);//1
	}
}
public class BonusCollectionImageEN : MovieClip{ 
	public MovieClip hit;
	public BonusCollectionImageEN() {
		var i360 = new symbol_67(){filters = new as3.Array(new object[]{})};
		addChild(i360);//0
		hit = new symbol_69(){x = -19 , y = -39 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusCollectionImageRU : MovieClip{ 
	public MovieClip hit;
	public BonusCollectionImageRU() {
		var i363 = new symbol_70(){filters = new as3.Array(new object[]{})};
		addChild(i363);//0
		hit = new symbol_71(){x = -19 , y = -39 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusDesignImage : MovieClip{ 
	public MovieClip hit;
	public BonusDesignImage() {
		hit = new symbol_73(){x = -29.1 , y = -34.9 , filters = new as3.Array(new object[]{})};
		addChild(hit);//0
		var i367 = new symbol_74(){filters = new as3.Array(new object[]{})};
		addChild(i367);//1
	}
}
public class BonusDisplaysImage : MovieClip{ 
	public MovieClip hit;
	public BonusDisplaysImage() {
		var i369 = new symbol_75(){filters = new as3.Array(new object[]{})};
		addChild(i369);//0
		hit = new symbol_77(){x = -26 , y = -33.5 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusFurnitureImage : MovieClip{ 
	public MovieClip hit;
	public BonusFurnitureImage() {
		var i372 = new symbol_78(){filters = new as3.Array(new object[]{})};
		addChild(i372);//0
		hit = new symbol_80(){x = -22.4 , y = -33 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusHouseImage : MovieClip{ 
	public MovieClip hit;
	public BonusHouseImage() {
		var i375 = new symbol_81(){filters = new as3.Array(new object[]{})};
		addChild(i375);//0
		hit = new symbol_83(){x = -22.9 , y = -44.4 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusMoneyBoxGold : MovieClip{ 
	public MovieClip hit;
	public BonusMoneyBoxGold() {
		hit = new symbol_85(){x = -27.1 , y = -33.8 , filters = new as3.Array(new object[]{})};
		addChild(hit);//0
		var i379 = new symbol_86(){filters = new as3.Array(new object[]{})};
		addChild(i379);//1
	}
}
public class BonusMoneyBoxSilver : MovieClip{ 
	public MovieClip hit;
	public BonusMoneyBoxSilver() {
		hit = new symbol_87(){x = -27.1 , y = -33.8 , filters = new as3.Array(new object[]{})};
		addChild(hit);//0
		var i382 = new symbol_86(){filters = new as3.Array(new object[]{})};
		addChild(i382);//1
	}
}
public class BonusPetImage : MovieClip{ 
	public MovieClip hit;
	public BonusPetImage() {
		var i384 = new symbol_88(){filters = new as3.Array(new object[]{})};
		addChild(i384);//0
		hit = new symbol_90(){x = -19.5 , y = -41 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusPuzzleImage : MovieClip{ 
	public MovieClip hit;
	public BonusPuzzleImage() {
		var i387 = new symbol_91(){filters = new as3.Array(new object[]{})};
		addChild(i387);//0
		hit = new symbol_93(){x = -22.4 , y = -39.8 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusStickerImage : MovieClip{ 
	public MovieClip hit;
	public BonusStickerImage() {
		var i390 = new symbol_94(){filters = new as3.Array(new object[]{})};
		addChild(i390);//0
		hit = new symbol_96(){x = -23 , y = -41.8 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusTopImage : MovieClip{ 
	public MovieClip hit;
	public BonusTopImage() {
		hit = new symbol_98(){x = -29.1 , y = -37.5 , filters = new as3.Array(new object[]{})};
		addChild(hit);//0
		var i394 = new symbol_99(){filters = new as3.Array(new object[]{})};
		addChild(i394);//1
	}
}
public class BonusVipManImage : MovieClip{ 
	public MovieClip hit;
	public BonusVipManImage() {
		var i396 = new symbol_100(){filters = new as3.Array(new object[]{})};
		addChild(i396);//0
		hit = new symbol_102(){x = -24.2 , y = -42.2 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BonusVipWomanImage : MovieClip{ 
	public MovieClip hit;
	public BonusVipWomanImage() {
		var i399 = new symbol_100(){filters = new as3.Array(new object[]{})};
		addChild(i399);//0
		hit = new symbol_103(){x = -24 , y = -43 , filters = new as3.Array(new object[]{})};
		addChild(hit);//1
	}
}
public class BottleBonusImage : BitmapData{ 
	public BottleBonusImage() {
		width = 17;
		height = 53;
		setPixels("223fd4e456d7bfdc5b624f9b0d165f46");
	}
}
public class BottlePaymentNormal : MovieClip{ 
	public BottlePaymentNormal() {
		var i402 = new symbol_104(){filters = new as3.Array(new object[]{})};
		addChild(i402);//0
	}
}
public class BottlePaymentShadow : MovieClip{ 
	public BottlePaymentShadow() {
		var filter_0 = new DropShadowFilter(){strength = 0.20, angle = 45.00, blurX = 10, hideObject = true, blurY = 10};
		var i404 = new symbol_106(){filters = new as3.Array(new object[]{filter_0})};
		addChild(i404);//0
	}

	private class DropShadowFilter
	{
		public DropShadowFilter()
		{
		}

		public double angle { get; set; }
		public int blurX { get; set; }
		public int blurY { get; set; }
		public bool hideObject { get; set; }
		public double strength { get; set; }
	}
}
public class BottlesBananiPrize : BitmapData{ 
	public BottlesBananiPrize() {
		width = 52;
		height = 56;
		setPixels("238049b18fd32424eff6f0437c6db6d7");
	}
}
public class BoxNewsIcon : BitmapData{ 
	public BoxNewsIcon() {
		width = 37;
		height = 37;
		setPixels("c8702baf696191bdf703b13b72cbe4e4");
	}
}
public class BubblesMovie : MovieClip{ 
	public BubblesMovie() {
		var i407 = new symbol_40(){x = -28.5 , y = 35.1 , filters = new as3.Array(new object[]{})};
		addChild(i407);//0
		var i408 = new symbol_40(){x = -20.2 , y = 30.1 , filters = new as3.Array(new object[]{})};
		addChild(i408);//1
		var i409 = new symbol_40(){x = -13.8 , y = 22.1 , filters = new as3.Array(new object[]{})};
		addChild(i409);//2
		FrameInfo f;
		var l= new Frames(10);
		f = l.Add();
		f.Add(i407);
		f += () => {
			i407.x = -28.5;
			i407.scaleX = 1;
			i407.y = 35.1;
			i407.scaleY = 1;
			i407.rotation = 0;
			i407.alpha = 1;
			i407.filters = new as3.Array(new object[]{});
			i407.scale9Grid = null;
			i407.visible = true;
		};
		f = l.Add();
		f.Add(i407);
		f += () => {
			i407.x = -25.8;
			i407.scaleX = 0.29;
			i407.y = 33.5;
			i407.scaleY = 0.29;
		};
		f = l.Add();
		f.Add(i407);
		f.Add(i408);
		f += () => {
			i407.x = -23;
			i407.scaleX = 0.34;
			i407.y = 31.8;
			i407.scaleY = 0.34;
			i408.x = -20.2;
			i408.scaleX = 1;
			i408.y = 30.1;
			i408.scaleY = 1;
			i408.rotation = 0;
			i408.alpha = 1;
			i408.filters = new as3.Array(new object[]{});
			i408.scale9Grid = null;
			i408.visible = true;
		};
		f = l.Add();
		f.Add(i407);
		f.Add(i408);
		f += () => {
			i407.x = -20.3;
			i407.scaleX = 0.39;
			i407.y = 30.1;
			i407.scaleY = 0.39;
			i408.x = -17.9;
			i408.scaleX = 0.45;
			i408.y = 27.1;
			i408.scaleY = 0.45;
		};
		f = l.Add();
		f.Add(i407);
		f.Add(i408);
		f.Add(i409);
		f += () => {
			i408.x = -15.7;
			i408.scaleX = 0.5;
			i408.y = 24.2;
			i408.scaleY = 0.5;
			i409.x = -13.8;
			i409.scaleX = 1;
			i409.y = 22.1;
			i409.scaleY = 1;
			i409.rotation = 0;
			i409.alpha = 1;
			i409.filters = new as3.Array(new object[]{});
			i409.scale9Grid = null;
			i409.visible = true;
		};
		f = l.Add();
		f.Add(i407);
		f.Add(i408);
		f.Add(i409);
		f += () => {
			i408.x = -13.3;
			i408.scaleX = 0.55;
			i408.y = 21.1;
			i408.scaleY = 0.55;
			i409.x = -11.1;
			i409.scaleX = 0.63;
			i409.y = 17.6;
			i409.scaleY = 0.63;
		};
		f = l.Add();
		f.Add(i407);
		f.Add(i408);
		f.Add(i409);
		f += () => {
			i408.x = -11.1;
			i408.scaleX = 0.61;
			i408.y = 18.1;
			i408.scaleY = 0.61;
			i409.x = -8.2;
			i409.scaleX = 0.72;
			i409.y = 13.3;
			i409.scaleY = 0.72;
		};
		f = l.Add();
		f.Add(i407);
		f.Add(i408);
		f.Add(i409);
		f += () => {
			i409.x = -5.5;
			i409.scaleX = 0.81;
			i409.y = 8.8;
			i409.scaleY = 0.81;
		};
		f = l.Add();
		f.Add(i407);
		f.Add(i408);
		f.Add(i409);
		f += () => {
			i409.x = -2.7;
			i409.scaleX = 0.91;
			i409.y = 4.4;
			i409.scaleY = 0.91;
		};
		f = l.Add();
		f.Add(i407);
		f.Add(i408);
		f.Add(i409);
		f += () => {
			i409.x = 0;
			i409.scaleX = 1;
			i409.y = 0;
			i409.scaleY = 1;
		};
		setFrames(l);
	}
}
public class ButtonBanani : MovieClip{ 
	public ButtonBanani() {
		var filter_0 = new GlowFilter(){strength = 0.50, blurX = 10, quality = 3, blurY = 10};
		var filter_1 = new GlowFilter(){strength = 0.87, blurX = 10, quality = 3, blurY = 10};
		var filter_2 = new GlowFilter(){strength = 1.06, blurX = 10, quality = 3, blurY = 10};
		var filter_3 = new GlowFilter(){strength = 1.40, blurX = 10, quality = 3, blurY = 10};
		var filter_4 = new GlowFilter(){strength = 0.11, blurX = 10, quality = 3, blurY = 10};
		var filter_5 = new GlowFilter(){strength = 0.35, blurX = 10, quality = 3, blurY = 10};
		var filter_6 = new GlowFilter(){strength = 0.70, blurX = 10, quality = 3, blurY = 10};
		var filter_7 = new GlowFilter(){strength = 0.39, blurX = 10, quality = 3, blurY = 10};
		var filter_8 = new GlowFilter(){strength = 0.76, blurX = 10, quality = 3, blurY = 10};
		var filter_9 = new GlowFilter(){strength = 1.10, blurX = 10, quality = 3, blurY = 10};
		var filter_10 = new GlowFilter(){strength = 0.12, blurX = 10, quality = 3, blurY = 10};
		var filter_11 = new GlowFilter(){strength = 0.82, blurX = 10, quality = 3, blurY = 10};
		var filter_12 = new GlowFilter(){strength = 0.62, blurX = 10, quality = 3, blurY = 10};
		var filter_13 = new GlowFilter(){strength = 0.56, blurX = 10, quality = 3, blurY = 10};
		var filter_14 = new GlowFilter(){strength = 1, blurX = 10, quality = 3, blurY = 10};
		var filter_15 = new GlowFilter(){strength = 1.50, blurX = 10, quality = 3, blurY = 10};
		var filter_16 = new GlowFilter(){strength = 1.43, blurX = 10, quality = 3, blurY = 10};
		var filter_17 = new GlowFilter(){strength = 1.31, blurX = 10, quality = 3, blurY = 10};
		var filter_18 = new GlowFilter(){strength = 1.20, blurX = 10, quality = 3, blurY = 10};
		var filter_19 = new GlowFilter(){strength = 1.12, blurX = 10, quality = 3, blurY = 10};
		var filter_20 = new GlowFilter(){strength = 0.25, blurX = 10, quality = 3, blurY = 10};
		var filter_21 = new GlowFilter(){strength = 0.05, blurX = 10, quality = 3, blurY = 10};
		var filter_22 = new GlowFilter(){strength = 0.93, blurX = 10, quality = 3, blurY = 10};
		var filter_23 = new GlowFilter(){strength = 0.19, blurX = 10, quality = 3, blurY = 10};
		var filter_24 = new GlowFilter(){strength = 1.37, blurX = 10, quality = 3, blurY = 10};
		var filter_25 = new GlowFilter(){strength = 0.68, blurX = 10, quality = 3, blurY = 10};
		var filter_26 = new GlowFilter(){strength = 0.09, blurX = 10, quality = 3, blurY = 10};
		var filter_27 = new GlowFilter(){strength = 0.80, blurX = 10, quality = 3, blurY = 10};
		var filter_28 = new GlowFilter(){strength = 0.88, blurX = 10, quality = 3, blurY = 10};
		var filter_29 = new GlowFilter(){strength = 0.94, blurX = 10, quality = 3, blurY = 10};
		var filter_30 = new GlowFilter(){strength = 0.41, blurX = 10, quality = 3, blurY = 10};
		var filter_31 = new GlowFilter(){strength = 0.49, blurX = 10, quality = 3, blurY = 10};
		var filter_32 = new GlowFilter(){strength = 0.52, blurX = 10, quality = 3, blurY = 10};
		var filter_33 = new GlowFilter(){strength = 0.43, blurX = 10, quality = 3, blurY = 10};
		var filter_34 = new GlowFilter(){strength = 1.18, blurX = 10, quality = 3, blurY = 10};
		var filter_35 = new GlowFilter(){strength = 0.37, blurX = 10, quality = 3, blurY = 10};
		var filter_36 = new GlowFilter(){strength = 0.31, blurX = 10, quality = 3, blurY = 10};
		var filter_37 = new GlowFilter(){strength = 0.58, blurX = 10, quality = 3, blurY = 10};
		var filter_38 = new GlowFilter(){strength = 0.75, blurX = 10, quality = 3, blurY = 10};
		var filter_39 = new GlowFilter(){strength = 0.06, blurX = 10, quality = 3, blurY = 10};
		var filter_40 = new GlowFilter(){strength = 0, blurX = 10, quality = 3, blurY = 10};
		var filter_41 = new GlowFilter(){strength = 1.30, blurX = 10, quality = 3, blurY = 10};
		var filter_42 = new GlowFilter(){strength = 0.64, blurX = 10, quality = 3, blurY = 10};
		var filter_43 = new GlowFilter(){strength = 0.90, blurX = 10, quality = 3, blurY = 10};
		var filter_44 = new GlowFilter(){strength = 0, blurX = 0, quality = 3, blurY = 0};
		var filter_45 = new GlowFilter(){strength = 1.24, blurX = 10, quality = 3, blurY = 10};
		var filter_46 = new GlowFilter(){strength = 0.47, blurX = 10, quality = 3, blurY = 10};
		var filter_47 = new GlowFilter(){strength = 0.23, blurX = 10, quality = 3, blurY = 10};
		var filter_48 = new GlowFilter(){strength = 0.17, blurX = 10, quality = 3, blurY = 10};
		var filter_49 = new GlowFilter(){strength = 0.59, blurX = 10, quality = 3, blurY = 10};
		var filter_50 = new GlowFilter(){strength = 0.69, blurX = 10, quality = 3, blurY = 10};
		var filter_51 = new GlowFilter(){strength = 0.18, blurX = 10, quality = 3, blurY = 10};
		var filter_52 = new GlowFilter(){strength = 0.81, blurX = 10, quality = 3, blurY = 10};
		var filter_53 = new GlowFilter(){strength = 0.29, blurX = 10, quality = 3, blurY = 10};
		var i411 = new symbol_107(){filters = new as3.Array(new object[]{})};
		addChild(i411);//0
		var i412 = new symbol_108(){filters = new as3.Array(new object[]{})};
		addChild(i412);//1
		var i413 = new symbol_109(){mask = i412 , filters = new as3.Array(new object[]{})};
		addChild(i413);//2
		var i414 = new symbol_110(){x = 198.7 , y = 27.4 , mask = i412 , filters = new as3.Array(new object[]{})};
		addChild(i414);//3
		var i415 = new symbol_111(){x = 154.3 , y = 27.6 , mask = i412 , filters = new as3.Array(new object[]{})};
		addChild(i415);//4
		var i416 = new symbol_113(){x = 60.5 , scaleX = 0.15 , y = 10.4 , scaleY = 0.15 , alpha = 0 , mask = i412 , filters = new as3.Array(new object[]{})};
		addChild(i416);//5
		var i418 = new symbol_115(){x = 59.7 , scaleX = 0.18 , y = 23.9 , scaleY = 0.18 , alpha = 0 , mask = i412 , filters = new as3.Array(new object[]{})};
		addChild(i418);//6
		var i422 = new symbol_119(){x = 60.5 , scaleX = 4.2 , y = 23.6 , scaleY = 4.19 , mask = i412 , filters = new as3.Array(new object[]{filter_44})};
		addChild(i422);//6
		var i420 = new symbol_117(){x = 60.8 , scaleX = 0.11 , y = 39.6 , scaleY = 0.11 , alpha = 0 , mask = i412 , filters = new as3.Array(new object[]{})};
		addChild(i420);//7
		FrameInfo f;
		var l= new Frames(195);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i411.x = 0;
			i411.scaleX = 1;
			i411.y = 0;
			i411.scaleY = 1;
			i411.rotation = 0;
			i411.alpha = 1;
			i411.filters = new as3.Array(new object[]{});
			i411.scale9Grid = null;
			i411.visible = true;
			i412.x = 0;
			i412.scaleX = 1;
			i412.y = 0;
			i412.scaleY = 1;
			i412.rotation = 0;
			i412.alpha = 1;
			i412.filters = new as3.Array(new object[]{});
			i412.scale9Grid = null;
			i412.visible = true;
			i413.x = 0;
			i413.scaleX = 1;
			i413.y = 0;
			i413.scaleY = 1;
			i413.rotation = 0;
			i413.alpha = 1;
			i413.filters = new as3.Array(new object[]{});
			i413.scale9Grid = null;
			i413.visible = true;
			i414.x = 198.7;
			i414.scaleX = 1;
			i414.y = 27.4;
			i414.scaleY = 1;
			i414.rotation = 0;
			i414.alpha = 1;
			i414.filters = new as3.Array(new object[]{});
			i414.scale9Grid = null;
			i414.visible = true;
			i415.x = 154.3;
			i415.scaleX = 1;
			i415.y = 27.6;
			i415.scaleY = 1;
			i415.rotation = 0;
			i415.alpha = 1;
			i415.filters = new as3.Array(new object[]{});
			i415.scale9Grid = null;
			i415.visible = true;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i415.x = 129.9;
			i415.y = 27.4;
			i415.scaleY = 0.81;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i415.x = 105.5;
			i415.scaleY = 0.86;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i415.x = 81.2;
			i415.scaleY = 0.9;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i415.x = 56.8;
			i415.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i414.y = 27.6;
			i414.scaleY = 0.67;
			i415.x = 32.5;
			i415.scaleY = 1;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i414.x = 172.4;
			i414.scaleY = 0.73;
			i415.x = 26.7;
			i415.scaleX = 0.82;
			i415.y = 27.3;
			i415.scaleY = 1.08;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i414.x = 146.3;
			i414.scaleY = 0.8;
			i415.x = 20.9;
			i415.scaleX = 0.64;
			i415.y = 27.2;
			i415.scaleY = 1.17;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i414.x = 120;
			i414.y = 27.5;
			i414.scaleY = 0.87;
			i415.x = 15.2;
			i415.scaleX = 0.46;
			i415.y = 27.1;
			i415.scaleY = 1.25;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i414.x = 93.8;
			i414.y = 27.4;
			i414.scaleY = 0.93;
			i415.x = 18.1;
			i415.scaleX = 0.52;
			i415.y = 27.2;
			i415.scaleY = 1.11;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 220.2;
			i413.scaleX = 0.88;
			i413.y = 27.4;
			i413.scaleY = 0.98;
			i414.x = 66.5;
			i414.scaleY = 1;
			i415.x = 20.9;
			i415.scaleX = 0.58;
			i415.y = 27.4;
			i415.scaleY = 0.96;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 196.9;
			i414.x = 64.5;
			i414.scaleX = 0.9;
			i414.y = 26.9;
			i414.scaleY = 1.08;
			i415.x = 23.8;
			i415.scaleX = 0.63;
			i415.y = 27.5;
			i415.scaleY = 0.81;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 173.7;
			i414.x = 62.5;
			i414.scaleX = 0.8;
			i414.y = 26.6;
			i414.scaleY = 1.16;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 150.4;
			i414.x = 60.6;
			i414.scaleX = 0.7;
			i414.y = 27.4;
			i414.scaleY = 1.24;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 127.2;
			i414.x = 61.7;
			i414.scaleX = 0.76;
			i414.scaleY = 1.1;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 103.9;
			i414.x = 62.8;
			i414.scaleX = 0.81;
			i414.scaleY = 0.96;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 100.8;
			i413.scaleX = 0.76;
			i413.y = 27.3;
			i413.scaleY = 1.06;
			i414.x = 63.8;
			i414.scaleX = 0.86;
			i414.scaleY = 0.82;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 97.7;
			i413.scaleX = 0.64;
			i413.scaleY = 1.13;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 94.5;
			i413.scaleX = 0.51;
			i413.y = 27.4;
			i413.scaleY = 1.2;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 96.4;
			i413.scaleX = 0.59;
			i413.scaleY = 1.21;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 98.3;
			i413.scaleX = 0.67;
			i413.y = 27.5;
			i413.scaleY = 1.22;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 100.2;
			i413.scaleX = 0.75;
			i413.y = 27.4;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 110.6;
			i413.scaleX = 0.78;
			i413.scaleY = 1.13;
			i414.x = 72.7;
			i414.scaleX = 0.9;
			i414.scaleY = 0.75;
			i415.x = 30.9;
			i415.scaleX = 0.66;
			i415.y = 27.6;
			i415.scaleY = 0.75;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 119.8;
			i413.scaleX = 0.81;
			i413.scaleY = 1.05;
			i414.x = 80.4;
			i414.scaleX = 0.93;
			i414.scaleY = 0.7;
			i415.x = 37.1;
			i415.scaleX = 0.69;
			i415.y = 27.5;
			i415.scaleY = 0.69;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 127.8;
			i413.scaleX = 0.83;
			i413.scaleY = 0.98;
			i414.x = 87.2;
			i414.scaleX = 0.96;
			i414.y = 27.3;
			i414.scaleY = 0.65;
			i415.x = 42.5;
			i415.scaleX = 0.71;
			i415.scaleY = 0.65;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 134.5;
			i413.scaleX = 0.86;
			i413.scaleY = 0.92;
			i414.x = 92.9;
			i414.scaleX = 0.99;
			i414.y = 27.4;
			i414.scaleY = 0.61;
			i415.x = 47.1;
			i415.scaleX = 0.73;
			i415.scaleY = 0.61;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 140;
			i413.scaleX = 0.87;
			i413.scaleY = 0.87;
			i414.x = 97.5;
			i414.scaleX = 1.01;
			i414.scaleY = 0.58;
			i415.x = 50.9;
			i415.scaleX = 0.74;
			i415.y = 27.4;
			i415.scaleY = 0.58;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 144.3;
			i413.scaleX = 0.89;
			i413.scaleY = 0.83;
			i414.x = 101.2;
			i414.scaleX = 1.02;
			i414.scaleY = 0.56;
			i415.x = 53.8;
			i415.scaleX = 0.75;
			i415.scaleY = 0.55;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 127.5;
			i414.x = 84.1;
			i414.scaleX = 1.03;
			i415.x = 36.3;
			i415.scaleX = 0.76;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 105.8;
			i413.scaleX = 0.9;
			i414.x = 62;
			i414.scaleX = 1.04;
			i415.x = 13.8;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 79.4;
			i413.scaleX = 0.91;
			i414.x = 35.1;
			i414.scaleX = 1.05;
			i415.x = -13.6;
			i415.scaleX = 0.77;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 48.1;
			i413.scaleX = 0.92;
			i414.x = 3.4;
			i414.scaleX = 1.06;
			i415.x = -46;
			i415.scaleX = 0.78;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = 12.1;
			i413.scaleX = 0.93;
			i414.x = -33.4;
			i414.scaleX = 1.08;
			i415.x = -83.3;
			i415.scaleX = 0.79;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f += () => {
			i413.x = -28.8;
			i413.scaleX = 0.95;
			i414.x = -75;
			i414.scaleX = 1.1;
			i415.x = -125.8;
			i415.scaleX = 0.81;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f += () => {
			i416.x = 60.5;
			i416.scaleX = 0.15;
			i416.y = 10.4;
			i416.scaleY = 0.15;
			i416.rotation = 0;
			i416.alpha = 0;
			i416.filters = new as3.Array(new object[]{});
			i416.scale9Grid = null;
			i416.visible = true;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f += () => {
			i416.x = 60.4;
			i416.scaleX = 0.31;
			i416.scaleY = 0.31;
			i416.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f += () => {
			i416.scaleX = 0.45;
			i416.scaleY = 0.45;
			i416.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f += () => {
			i416.x = 60.3;
			i416.scaleX = 0.56;
			i416.scaleY = 0.56;
			i416.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f += () => {
			i416.scaleX = 0.66;
			i416.scaleY = 0.66;
			i416.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f += () => {
			i416.scaleX = 0.73;
			i416.scaleY = 0.73;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f += () => {
			i416.x = 60.2;
			i416.scaleX = 0.78;
			i416.scaleY = 0.78;
			i416.alpha = 0.6;
			i418.x = 59.7;
			i418.scaleX = 0.18;
			i418.y = 23.9;
			i418.scaleY = 0.18;
			i418.rotation = 0;
			i418.alpha = 0;
			i418.filters = new as3.Array(new object[]{});
			i418.scale9Grid = null;
			i418.visible = true;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f += () => {
			i416.scaleX = 0.81;
			i416.scaleY = 0.81;
			i418.scaleX = 0.28;
			i418.scaleY = 0.28;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f += () => {
			i416.scaleX = 0.82;
			i416.scaleY = 0.82;
			i418.scaleX = 0.39;
			i418.scaleY = 0.39;
			i418.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f += () => {
			i416.x = 60.3;
			i416.alpha = 0.7;
			i418.scaleX = 0.49;
			i418.scaleY = 0.49;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f += () => {
			i416.x = 60.4;
			i416.alpha = 0.8;
			i418.x = 59.6;
			i418.scaleX = 0.59;
			i418.scaleY = 0.59;
			i418.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f += () => {
			i416.alpha = 0.9;
			i418.x = 59.7;
			i418.scaleX = 0.69;
			i418.scaleY = 0.69;
			i418.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.x = 60.5;
			i416.alpha = 1;
			i418.scaleX = 0.8;
			i418.scaleY = 0.8;
			i418.alpha = 0.5;
			i420.x = 60.8;
			i420.scaleX = 0.11;
			i420.y = 39.6;
			i420.scaleY = 0.11;
			i420.rotation = 0;
			i420.alpha = 0;
			i420.filters = new as3.Array(new object[]{});
			i420.scale9Grid = null;
			i420.visible = true;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.scaleX = 0.9;
			i418.scaleY = 0.9;
			i420.x = 60.6;
			i420.scaleX = 0.36;
			i420.y = 41;
			i420.scaleY = 0.36;
			i420.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.scaleX = 1;
			i418.scaleY = 1;
			i418.alpha = 0.6;
			i420.x = 60.5;
			i420.scaleX = 0.58;
			i420.y = 42.1;
			i420.scaleY = 0.58;
			i420.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.x = 59.8;
			i418.alpha = 0.7;
			i420.scaleX = 0.77;
			i420.y = 43.1;
			i420.scaleY = 0.77;
			i420.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.x = 59.9;
			i418.alpha = 0.8;
			i420.scaleX = 0.92;
			i420.y = 43.9;
			i420.scaleY = 0.92;
			i420.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.alpha = 0.9;
			i420.x = 60.4;
			i420.scaleX = 1.04;
			i420.y = 44.5;
			i420.scaleY = 1.04;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.x = 60;
			i418.alpha = 1;
			i420.scaleX = 1.12;
			i420.y = 44.9;
			i420.scaleY = 1.12;
			i420.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.x = 60.3;
			i420.scaleX = 1.17;
			i420.y = 45.1;
			i420.scaleY = 1.17;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.x = 60.2;
			i420.scaleX = 1.19;
			i420.scaleY = 1.19;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.scaleX = 1.16;
			i420.y = 45;
			i420.scaleY = 1.16;
			i420.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.scaleX = 1.13;
			i420.y = 44.9;
			i420.scaleY = 1.13;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.scaleX = 1.1;
			i420.y = 44.8;
			i420.scaleY = 1.1;
			i420.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.x = 60.3;
			i420.scaleX = 1.08;
			i420.y = 44.5;
			i420.scaleY = 1.08;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.scaleX = 1.05;
			i420.y = 44.4;
			i420.scaleY = 1.05;
			i420.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.scaleX = 1.02;
			i420.y = 44.3;
			i420.scaleY = 1.02;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.x = 60.4;
			i420.scaleX = 0.99;
			i420.y = 44.1;
			i420.scaleY = 0.99;
			i420.alpha = 1;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.x = 60.2;
			i416.filters = new as3.Array(new object[]{filter_40});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_39});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_10});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_51});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_20});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_36});
			i418.x = 59.7;
			i418.filters = new as3.Array(new object[]{filter_40});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_35});
			i418.filters = new as3.Array(new object[]{filter_39});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_33});
			i418.filters = new as3.Array(new object[]{filter_10});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_0});
			i418.filters = new as3.Array(new object[]{filter_51});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_13});
			i418.filters = new as3.Array(new object[]{filter_20});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_12});
			i418.filters = new as3.Array(new object[]{filter_36});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_25});
			i418.filters = new as3.Array(new object[]{filter_35});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_38});
			i418.filters = new as3.Array(new object[]{filter_33});
			i420.filters = new as3.Array(new object[]{filter_40});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_52});
			i418.filters = new as3.Array(new object[]{filter_0});
			i420.filters = new as3.Array(new object[]{filter_26});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_1});
			i418.filters = new as3.Array(new object[]{filter_13});
			i420.filters = new as3.Array(new object[]{filter_23});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_22});
			i418.filters = new as3.Array(new object[]{filter_12});
			i420.filters = new as3.Array(new object[]{filter_53});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_14});
			i418.filters = new as3.Array(new object[]{filter_25});
			i420.filters = new as3.Array(new object[]{filter_7});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_29});
			i418.filters = new as3.Array(new object[]{filter_38});
			i420.filters = new as3.Array(new object[]{filter_31});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_28});
			i418.filters = new as3.Array(new object[]{filter_52});
			i420.filters = new as3.Array(new object[]{filter_49});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_11});
			i418.filters = new as3.Array(new object[]{filter_1});
			i420.filters = new as3.Array(new object[]{filter_50});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_8});
			i418.filters = new as3.Array(new object[]{filter_22});
			i420.filters = new as3.Array(new object[]{filter_27});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_6});
			i418.filters = new as3.Array(new object[]{filter_14});
			i420.filters = new as3.Array(new object[]{filter_43});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_42});
			i418.filters = new as3.Array(new object[]{filter_22});
			i420.filters = new as3.Array(new object[]{filter_14});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_37});
			i418.filters = new as3.Array(new object[]{filter_1});
			i420.filters = new as3.Array(new object[]{filter_9});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_32});
			i418.filters = new as3.Array(new object[]{filter_52});
			i420.filters = new as3.Array(new object[]{filter_18});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_46});
			i418.filters = new as3.Array(new object[]{filter_38});
			i420.filters = new as3.Array(new object[]{filter_41});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_30});
			i418.filters = new as3.Array(new object[]{filter_25});
			i420.filters = new as3.Array(new object[]{filter_3});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_5});
			i418.filters = new as3.Array(new object[]{filter_12});
			i420.filters = new as3.Array(new object[]{filter_15});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_53});
			i418.filters = new as3.Array(new object[]{filter_13});
			i420.filters = new as3.Array(new object[]{filter_16});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_47});
			i418.filters = new as3.Array(new object[]{filter_0});
			i420.filters = new as3.Array(new object[]{filter_24});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_48});
			i418.filters = new as3.Array(new object[]{filter_33});
			i420.filters = new as3.Array(new object[]{filter_17});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_4});
			i418.filters = new as3.Array(new object[]{filter_35});
			i420.filters = new as3.Array(new object[]{filter_45});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_21});
			i418.filters = new as3.Array(new object[]{filter_36});
			i420.filters = new as3.Array(new object[]{filter_34});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_40});
			i418.filters = new as3.Array(new object[]{filter_20});
			i420.filters = new as3.Array(new object[]{filter_19});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.filters = new as3.Array(new object[]{filter_51});
			i420.filters = new as3.Array(new object[]{filter_2});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.filters = new as3.Array(new object[]{filter_10});
			i420.filters = new as3.Array(new object[]{filter_14});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.filters = new as3.Array(new object[]{filter_39});
			i420.filters = new as3.Array(new object[]{filter_22});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i418.filters = new as3.Array(new object[]{filter_40});
			i420.filters = new as3.Array(new object[]{filter_1});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_52});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_38});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_25});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_12});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_13});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_31});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_33});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_35});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_36});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_20});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_51});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_10});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_39});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f += () => {
			i420.filters = new as3.Array(new object[]{filter_40});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i418);
		f.Add(i420);
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.filters = new as3.Array(new object[]{filter_44});
			i422.x = 60.5;
			i422.scaleX = 4.2;
			i422.y = 23.6;
			i422.scaleY = 4.19;
			i422.rotation = 0;
			i422.alpha = 1;
			i422.filters = new as3.Array(new object[]{filter_44});
			i422.scale9Grid = null;
			i422.visible = true;
			i420.x = 60.5;
			i420.scaleX = 1;
			i420.y = 44.5;
			i420.scaleY = 1;
			i420.filters = new as3.Array(new object[]{filter_44});
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 67.9;
			i416.scaleX = 0.86;
			i416.y = 11.7;
			i416.scaleY = 0.76;
			i416.alpha = 0.9;
			i422.x = 68.2;
			i422.scaleX = 4.45;
			i422.y = 23.7;
			i422.scaleY = 3.86;
			i422.alpha = 0.9;
			i420.x = 68.3;
			i420.scaleX = 1.04;
			i420.y = 43.2;
			i420.scaleY = 0.92;
			i420.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 74.4;
			i416.scaleX = 0.89;
			i416.y = 12.8;
			i416.scaleY = 0.7;
			i416.alpha = 0.8;
			i422.x = 74.8;
			i422.scaleX = 4.67;
			i422.y = 23.8;
			i422.scaleY = 3.58;
			i422.alpha = 0.8;
			i420.x = 75;
			i420.scaleX = 1.08;
			i420.y = 42.1;
			i420.scaleY = 0.85;
			i420.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 79.7;
			i416.scaleX = 0.91;
			i416.y = 13.6;
			i416.scaleY = 0.66;
			i416.alpha = 0.7;
			i422.x = 80;
			i422.scaleX = 4.84;
			i422.y = 23.9;
			i422.scaleY = 3.34;
			i422.alpha = 0.7;
			i420.x = 80.3;
			i420.scaleX = 1.11;
			i420.y = 41.3;
			i420.scaleY = 0.8;
			i420.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 83.8;
			i416.scaleX = 0.93;
			i416.y = 14.3;
			i416.scaleY = 0.62;
			i422.x = 84.2;
			i422.scaleX = 4.98;
			i422.scaleY = 3.17;
			i420.x = 84.6;
			i420.scaleX = 1.13;
			i420.y = 40.6;
			i420.scaleY = 0.76;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 86.8;
			i416.scaleX = 0.94;
			i416.y = 14.7;
			i416.scaleY = 0.6;
			i416.alpha = 0.6;
			i422.x = 87.2;
			i422.scaleX = 5.08;
			i422.scaleY = 3.04;
			i422.alpha = 0.6;
			i420.x = 87.6;
			i420.scaleX = 1.15;
			i420.y = 40.1;
			i420.scaleY = 0.72;
			i420.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i411);
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 88.5;
			i416.scaleX = 0.95;
			i416.y = 15.1;
			i416.scaleY = 0.58;
			i422.x = 88.9;
			i422.scaleX = 5.14;
			i422.y = 24;
			i422.scaleY = 2.96;
			i420.x = 89.4;
			i420.scaleX = 1.16;
			i420.y = 39.9;
			i420.scaleY = 0.71;
		};
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 89.2;
			i416.y = 15.2;
			i422.x = 89.5;
			i422.scaleX = 5.16;
			i422.scaleY = 2.93;
			i420.x = 90;
			i420.y = 39.8;
			i420.scaleY = 0.7;
		};
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 84.9;
			i422.x = 85.3;
			i422.y = 23.9;
			i420.x = 85.8;
		};
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 72.2;
			i416.alpha = 0.5;
			i422.x = 72.5;
			i422.alpha = 0.5;
			i420.x = 73;
			i420.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 50.9;
			i422.x = 51.3;
			i420.x = 51.8;
		};
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = 21.1;
			i416.alpha = 0.3;
			i422.x = 21.6;
			i422.alpha = 0.3;
			i420.x = 22;
			i420.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = -17.1;
			i416.alpha = 0.2;
			i422.x = -16.7;
			i422.alpha = 0.2;
			i420.x = -16.3;
			i420.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.x = -63.9;
			i416.alpha = 0;
			i422.x = -63.5;
			i422.y = 24;
			i422.alpha = 0;
			i420.x = -63;
			i420.alpha = 0;
		};
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f = l.Add();
		f.Add(i412);
		f.Add(i413);
		f.Add(i414);
		f.Add(i415);
		f.Add(i416);
		f.Add(i422);
		f.Add(i420);
		f += () => {
			i416.y = 17.1;
			i416.alpha = 0.6;
			i416.filters = new as3.Array(new object[]{});
			i420.y = 41.1;
			i420.alpha = 0.6;
			i420.filters = new as3.Array(new object[]{});
		};
		setFrames(l);
	}
}
public class ButtonFreeBottles : MovieClip{ 
	public resources_fla.animation_42 animation;
	public ButtonFreeBottles() {
		var i432 = new symbol_126(){filters = new as3.Array(new object[]{})};
		addChild(i432);//0
		animation = new resources_fla.animation_42(){x = 23.5 , y = 25 , filters = new as3.Array(new object[]{})};
		addChild(animation);//0
		var i431 = new symbol_125(){filters = new as3.Array(new object[]{})};
		addChild(i431);//1
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(animation);
		f.Add(i431);
		f += () => {
			animation.x = 23.5;
			animation.scaleX = 1;
			animation.y = 25;
			animation.scaleY = 1;
			animation.rotation = 0;
			animation.alpha = 1;
			animation.filters = new as3.Array(new object[]{});
			animation.scale9Grid = null;
			animation.visible = true;
			i431.x = 0;
			i431.scaleX = 1;
			i431.y = 0;
			i431.scaleY = 1;
			i431.rotation = 0;
			i431.alpha = 1;
			i431.filters = new as3.Array(new object[]{});
			i431.scale9Grid = null;
			i431.visible = true;
		};
		f = l.Add();
		f.Add(i432);
		f.Add(i431);
		f += () => {
			i432.x = 0;
			i432.scaleX = 1;
			i432.y = 0;
			i432.scaleY = 1;
			i432.rotation = 0;
			i432.alpha = 1;
			i432.filters = new as3.Array(new object[]{});
			i432.scale9Grid = null;
			i432.visible = true;
		};
		setFrames(l);
	}
}
public class ButtonFreeBottlesEng : MovieClip{ 
	public resources_fla.animation_42 animation;
	public ButtonFreeBottlesEng() {
		animation = new resources_fla.animation_42(){x = 23.5 , y = 25 , filters = new as3.Array(new object[]{})};
		addChild(animation);//0
		var i441 = new symbol_126(){filters = new as3.Array(new object[]{})};
		addChild(i441);//0
		var i440 = new symbol_129(){filters = new as3.Array(new object[]{})};
		addChild(i440);//1
		FrameInfo f;
		var l= new Frames(2);
		f = l.Add();
		f.Add(animation);
		f.Add(i440);
		f += () => {
			animation.x = 23.5;
			animation.scaleX = 1;
			animation.y = 25;
			animation.scaleY = 1;
			animation.rotation = 0;
			animation.alpha = 1;
			animation.filters = new as3.Array(new object[]{});
			animation.scale9Grid = null;
			animation.visible = true;
			i440.x = 0;
			i440.scaleX = 1;
			i440.y = 0;
			i440.scaleY = 1;
			i440.rotation = 0;
			i440.alpha = 1;
			i440.filters = new as3.Array(new object[]{});
			i440.scale9Grid = null;
			i440.visible = true;
		};
		f = l.Add();
		f.Add(i441);
		f.Add(i440);
		f += () => {
			i441.x = 0;
			i441.scaleX = 1;
			i441.y = 0;
			i441.scaleY = 1;
			i441.rotation = 0;
			i441.alpha = 1;
			i441.filters = new as3.Array(new object[]{});
			i441.scale9Grid = null;
			i441.visible = true;
		};
		setFrames(l);
	}
}
public class ButtonFreeBottlesHit : MovieClip{ 
	public ButtonFreeBottlesHit() {
		var i443 = new symbol_130(){filters = new as3.Array(new object[]{})};
		addChild(i443);//0
	}
}
public class ButtonUploadPhoto : SimpleButton{ 
	public ButtonUploadPhoto() {
		downState = new symbol_131(){filters = new as3.Array(new object[]{})};
		overState = new symbol_131(){filters = new as3.Array(new object[]{})};
		upState = new symbol_131(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_131(){filters = new as3.Array(new object[]{})};
	}
}
public class ButtonUploadPhotoEN : SimpleButton{ 
	public ButtonUploadPhotoEN() {
		downState = new symbol_131(){filters = new as3.Array(new object[]{})};
		overState = new symbol_131(){filters = new as3.Array(new object[]{})};
		upState = new symbol_131(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_131(){filters = new as3.Array(new object[]{})};
	}
}
public class CertificateIcon : BitmapData{ 
	public CertificateIcon() {
		width = 55;
		height = 56;
		setPixels("42a3b1930d8b8d0933de5aa8811c11b7");
	}
}
public class ClipLoading : MovieClip{ 
	public ClipLoading() {
		var i455 = new symbol_132(){x = 88.5 , y = 77.5 , filters = new as3.Array(new object[]{})};
		addChild(i455);//0
		var i456 = new symbol_133(){filters = new as3.Array(new object[]{})};
		addChild(i456);//1
		FrameInfo f;
		var l= new Frames(39);
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.x = 88.5;
			i455.scaleX = 1;
			i455.y = 77.5;
			i455.scaleY = 1;
			i455.rotation = 0;
			i455.alpha = 1;
			i455.filters = new as3.Array(new object[]{});
			i455.scale9Grid = null;
			i455.visible = true;
			i456.x = 0;
			i456.scaleX = 1;
			i456.y = 0;
			i456.scaleY = 1;
			i456.rotation = 0;
			i456.alpha = 1;
			i456.filters = new as3.Array(new object[]{});
			i456.scale9Grid = null;
			i456.visible = true;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.8;
			i455.scaleY = 0.8;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.81;
			i455.scaleY = 0.81;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.82;
			i455.scaleY = 0.82;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.83;
			i455.scaleY = 0.83;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.84;
			i455.scaleY = 0.84;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.85;
			i455.scaleY = 0.85;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.86;
			i455.scaleY = 0.86;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.87;
			i455.scaleY = 0.87;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.88;
			i455.scaleY = 0.88;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.89;
			i455.scaleY = 0.89;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.91;
			i455.scaleY = 0.91;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.92;
			i455.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.x = 88.4;
			i455.scaleX = 0.93;
			i455.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.x = 88.5;
			i455.scaleX = 0.94;
			i455.scaleY = 0.94;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.x = 88.4;
			i455.scaleX = 0.95;
			i455.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.x = 88.5;
			i455.scaleX = 0.97;
			i455.scaleY = 0.97;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.98;
			i455.scaleY = 0.98;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 1;
			i455.scaleY = 1;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.99;
			i455.scaleY = 0.99;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.97;
			i455.scaleY = 0.97;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.96;
			i455.scaleY = 0.96;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.95;
			i455.scaleY = 0.95;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.94;
			i455.scaleY = 0.94;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.93;
			i455.scaleY = 0.93;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.92;
			i455.scaleY = 0.92;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.91;
			i455.scaleY = 0.91;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.9;
			i455.scaleY = 0.9;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.89;
			i455.scaleY = 0.89;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.88;
			i455.scaleY = 0.88;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.87;
			i455.scaleY = 0.87;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.86;
			i455.scaleY = 0.86;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.85;
			i455.scaleY = 0.85;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.84;
			i455.scaleY = 0.84;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.83;
			i455.scaleY = 0.83;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.82;
			i455.scaleY = 0.82;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.81;
			i455.scaleY = 0.81;
		};
		f = l.Add();
		f.Add(i455);
		f.Add(i456);
		f += () => {
			i455.scaleX = 0.8;
			i455.scaleY = 0.8;
		};
		setFrames(l);
	}
}
public class CollectionBonus : BitmapData{ 
	public CollectionBonus() {
		width = 35;
		height = 35;
		setPixels("825e14714fd57d2138a1bb2d7cf0dfbd");
	}
}
public class CollectionButtonClip : MovieClip{ 
	public CollectionButtonClip() {
		var i458 = new symbol_135(){x = 108.9 , scaleX = 0.9 , y = 82.8 , scaleY = 0.9 , rotation = -11 , filters = new as3.Array(new object[]{})};
		addChild(i458);//0
		var i460 = new symbol_137(){x = 71.3 , scaleX = 0.9 , y = 75.4 , scaleY = 0.9 , rotation = -56 , blendMode = "add" , alpha = 0 , filters = new as3.Array(new object[]{})};
		addChild(i460);//1
		var i462 = new symbol_138(){x = 124.5 , scaleX = 0.9 , y = 87.7 , scaleY = 0.9 , rotation = -56 , blendMode = "add" , alpha = 0 , filters = new as3.Array(new object[]{})};
		addChild(i462);//2
		FrameInfo f;
		var l= new Frames(41);
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i458.x = 108.9;
			i458.scaleX = 0.9;
			i458.y = 82.8;
			i458.scaleY = 0.9;
			i458.rotation = -11;
			i458.alpha = 1;
			i458.filters = new as3.Array(new object[]{});
			i458.scale9Grid = null;
			i458.visible = true;
			i460.x = 71.3;
			i460.scaleX = 0.9;
			i460.y = 75.4;
			i460.scaleY = 0.9;
			i460.rotation = -56;
			i460.blendMode = "add";
			i460.alpha = 0;
			i460.filters = new as3.Array(new object[]{});
			i460.scale9Grid = null;
			i460.visible = true;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 71.6;
			i460.scaleX = 0.89;
			i460.y = 75.1;
			i460.scaleY = 0.89;
			i460.rotation = -49;
			i460.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 71.8;
			i460.y = 74.8;
			i460.rotation = -42;
			i460.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 72;
			i460.y = 74.5;
			i460.rotation = -35;
			i460.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 72.3;
			i460.y = 74.3;
			i460.rotation = -29;
			i460.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 72.5;
			i460.scaleX = 0.9;
			i460.y = 74;
			i460.scaleY = 0.9;
			i460.rotation = -22;
			i460.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 72.8;
			i460.y = 73.8;
			i460.rotation = -15;
			i460.alpha = 1;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 73;
			i460.y = 73.5;
			i460.rotation = -8;
			i460.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 73.3;
			i460.y = 73.3;
			i460.rotation = -2;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 73.5;
			i460.y = 73;
			i460.rotation = 4;
			i460.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 73.8;
			i460.y = 72.8;
			i460.rotation = 11;
			i460.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 74;
			i460.y = 72.5;
			i460.rotation = 18;
			i460.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 74.3;
			i460.y = 72.3;
			i460.rotation = 24;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 74.5;
			i460.scaleX = 0.89;
			i460.y = 72;
			i460.scaleY = 0.89;
			i460.rotation = 31;
			i460.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 74.7;
			i460.y = 71.8;
			i460.rotation = 38;
			i460.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 75;
			i460.y = 71.5;
			i460.rotation = 45;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 75.3;
			i460.y = 71.2;
			i460.rotation = 51;
			i460.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 75.5;
			i460.scaleX = 0.9;
			i460.y = 71;
			i460.scaleY = 0.9;
			i460.rotation = 58;
			i460.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 75.8;
			i460.y = 70.8;
			i460.rotation = 65;
			i460.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f += () => {
			i460.x = 76;
			i460.y = 70.5;
			i460.rotation = 72;
			i460.alpha = 0;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i460.x = 76.3;
			i460.y = 70.3;
			i460.rotation = 78;
			i462.x = 124.5;
			i462.scaleX = 0.9;
			i462.y = 87.7;
			i462.scaleY = 0.9;
			i462.rotation = -56;
			i462.blendMode = "add";
			i462.alpha = 0;
			i462.filters = new as3.Array(new object[]{});
			i462.scale9Grid = null;
			i462.visible = true;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 124.7;
			i462.scaleX = 0.89;
			i462.y = 87.4;
			i462.scaleY = 0.89;
			i462.rotation = -49;
			i462.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 125;
			i462.y = 87.1;
			i462.rotation = -42;
			i462.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 125.2;
			i462.y = 86.9;
			i462.rotation = -35;
			i462.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 125.5;
			i462.y = 86.7;
			i462.rotation = -29;
			i462.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 125.7;
			i462.scaleX = 0.9;
			i462.y = 86.5;
			i462.scaleY = 0.9;
			i462.rotation = -22;
			i462.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 125.9;
			i462.y = 86.2;
			i462.rotation = -15;
			i462.alpha = 1;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 126.2;
			i462.y = 85.8;
			i462.rotation = -8;
			i462.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 126.3;
			i462.y = 85.7;
			i462.rotation = -2;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 126.7;
			i462.y = 85.3;
			i462.rotation = 4;
			i462.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 126.8;
			i462.y = 85.2;
			i462.rotation = 11;
			i462.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 127.2;
			i462.y = 84.8;
			i462.rotation = 18;
			i462.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 127.4;
			i462.y = 84.7;
			i462.rotation = 24;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 127.8;
			i462.scaleX = 0.89;
			i462.y = 84.4;
			i462.scaleY = 0.89;
			i462.rotation = 31;
			i462.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 128;
			i462.y = 84.2;
			i462.rotation = 38;
			i462.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 128.2;
			i462.y = 83.8;
			i462.rotation = 45;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 128.4;
			i462.y = 83.6;
			i462.rotation = 51;
			i462.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 128.7;
			i462.scaleX = 0.9;
			i462.y = 83.3;
			i462.scaleY = 0.9;
			i462.rotation = 58;
			i462.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 128.9;
			i462.y = 83;
			i462.rotation = 65;
			i462.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 129.2;
			i462.y = 82.8;
			i462.rotation = 72;
			i462.alpha = 0;
		};
		f = l.Add();
		f.Add(i458);
		f.Add(i460);
		f.Add(i462);
		f += () => {
			i462.x = 129.4;
			i462.y = 82.6;
			i462.rotation = 78;
		};
		setFrames(l);
	}
}
public class Corner : MovieClip{ 
	public Corner() {
		var i465 = new symbol_139(){filters = new as3.Array(new object[]{})};
		addChild(i465);//0
	}
}
public class CountAddIcon : BitmapData{ 
	public CountAddIcon() {
		width = 20;
		height = 20;
		setPixels("d15907090a73f4eb72c0a8051a9c1efe");
	}
}
public class CountSubtractIcon : BitmapData{ 
	public CountSubtractIcon() {
		width = 20;
		height = 20;
		setPixels("fc4ccd359586e30a542699dff81ad733");
	}
}
public class CursorMove : BitmapData{ 
	public CursorMove() {
		width = 20;
		height = 20;
		setPixels("f37e257b36b10aeacc173146e72d40ea");
	}
}
public class CursorNESW : BitmapData{ 
	public CursorNESW() {
		width = 20;
		height = 20;
		setPixels("1bca6c88bf2262a12f7766f61bad0048");
	}
}
public class CursorNWSE : BitmapData{ 
	public CursorNWSE() {
		width = 20;
		height = 20;
		setPixels("719d323f40ccc69b33d64869175a012b");
	}
}
public class ElementExplosion : MovieClip{ 
	public ElementExplosion() {
		var i467 = new symbol_0(){filters = new as3.Array(new object[]{})};
		addChild(i467);//0
		var i518 = new symbol_164(){filters = new as3.Array(new object[]{})};
		addChild(i518);//0
		var i468 = new symbol_143(){x = -4.3 , scaleX = 0.35 , y = 5.3 , scaleY = 0.35 , rotation = -27 , filters = new as3.Array(new object[]{})};
		addChild(i468);//1
		var i472 = new symbol_145(){x = -4.5 , scaleX = 0.28 , y = -4.4 , scaleY = 0.28 , rotation = 35 , filters = new as3.Array(new object[]{})};
		addChild(i472);//2
		var i476 = new symbol_147(){x = 5 , scaleX = 0.35 , y = 5 , scaleY = 0.35 , rotation = -140 , filters = new as3.Array(new object[]{})};
		addChild(i476);//3
		var i480 = new symbol_149(){x = 6.9 , scaleX = 0.33 , y = -0.9 , scaleY = 0.33 , rotation = 170 , filters = new as3.Array(new object[]{})};
		addChild(i480);//4
		var i484 = new symbol_151(){x = 5.4 , scaleX = 0.2 , y = -4.5 , scaleY = 0.2 , rotation = 138 , filters = new as3.Array(new object[]{})};
		addChild(i484);//5
		var i488 = new symbol_153(){x = -1 , scaleX = 0.27 , y = 6.7 , scaleY = 0.27 , rotation = -77 , filters = new as3.Array(new object[]{})};
		addChild(i488);//6
		var i492 = new symbol_155(){x = 2.3 , scaleX = 0.21 , y = 6.5 , scaleY = 0.21 , rotation = -105 , filters = new as3.Array(new object[]{})};
		addChild(i492);//7
		var i496 = new symbol_159(){x = 0.9 , scaleX = 0.35 , y = -5.8 , scaleY = 0.42 , rotation = 91 , filters = new as3.Array(new object[]{})};
		addChild(i496);//8
		var i500 = new symbol_161(){x = -7.1 , scaleX = 0.24 , y = 0.2 , scaleY = 0.24 , rotation = -8 , filters = new as3.Array(new object[]{})};
		addChild(i500);//9
		var i504 = new symbol_163(){x = 7.4 , scaleX = 0.24 , y = 1.8 , scaleY = 0.24 , rotation = -160 , filters = new as3.Array(new object[]{})};
		addChild(i504);//10
		FrameInfo f;
		var l= new Frames(16);
		f = l.Add();
		f.Add(i467);
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f += () => {
			i467.x = 0;
			i467.scaleX = 1;
			i467.y = 0;
			i467.scaleY = 1;
			i467.rotation = 0;
			i467.alpha = 1;
			i467.filters = new as3.Array(new object[]{});
			i467.scale9Grid = null;
			i467.visible = true;
			i468.x = -4.3;
			i468.scaleX = 0.35;
			i468.y = 5.3;
			i468.scaleY = 0.35;
			i468.rotation = -27;
			i468.alpha = 1;
			i468.filters = new as3.Array(new object[]{});
			i468.scale9Grid = null;
			i468.visible = true;
			i472.x = -4.5;
			i472.scaleX = 0.28;
			i472.y = -4.4;
			i472.scaleY = 0.28;
			i472.rotation = 35;
			i472.alpha = 1;
			i472.filters = new as3.Array(new object[]{});
			i472.scale9Grid = null;
			i472.visible = true;
			i476.x = 5;
			i476.scaleX = 0.35;
			i476.y = 5;
			i476.scaleY = 0.35;
			i476.rotation = -140;
			i476.alpha = 1;
			i476.filters = new as3.Array(new object[]{});
			i476.scale9Grid = null;
			i476.visible = true;
			i480.x = 6.9;
			i480.scaleX = 0.33;
			i480.y = -0.9;
			i480.scaleY = 0.33;
			i480.rotation = 170;
			i480.alpha = 1;
			i480.filters = new as3.Array(new object[]{});
			i480.scale9Grid = null;
			i480.visible = true;
			i484.x = 5.4;
			i484.scaleX = 0.2;
			i484.y = -4.5;
			i484.scaleY = 0.2;
			i484.rotation = 138;
			i484.alpha = 1;
			i484.filters = new as3.Array(new object[]{});
			i484.scale9Grid = null;
			i484.visible = true;
			i488.x = -1;
			i488.scaleX = 0.27;
			i488.y = 6.7;
			i488.scaleY = 0.27;
			i488.rotation = -77;
			i488.alpha = 1;
			i488.filters = new as3.Array(new object[]{});
			i488.scale9Grid = null;
			i488.visible = true;
			i492.x = 2.3;
			i492.scaleX = 0.21;
			i492.y = 6.5;
			i492.scaleY = 0.21;
			i492.rotation = -105;
			i492.alpha = 1;
			i492.filters = new as3.Array(new object[]{});
			i492.scale9Grid = null;
			i492.visible = true;
			i496.x = 0.9;
			i496.scaleX = 0.35;
			i496.y = -5.8;
			i496.scaleY = 0.42;
			i496.rotation = 91;
			i496.alpha = 1;
			i496.filters = new as3.Array(new object[]{});
			i496.scale9Grid = null;
			i496.visible = true;
			i500.x = -7.1;
			i500.scaleX = 0.24;
			i500.y = 0.2;
			i500.scaleY = 0.24;
			i500.rotation = -8;
			i500.alpha = 1;
			i500.filters = new as3.Array(new object[]{});
			i500.scale9Grid = null;
			i500.visible = true;
			i504.x = 7.4;
			i504.scaleX = 0.24;
			i504.y = 1.8;
			i504.scaleY = 0.24;
			i504.rotation = -160;
			i504.alpha = 1;
			i504.filters = new as3.Array(new object[]{});
			i504.scale9Grid = null;
			i504.visible = true;
		};
		f = l.Add();
		f.Add(i467);
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i467);
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i467);
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i467);
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i467);
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i518);
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f += () => {
			i518.x = 0;
			i518.scaleX = 1;
			i518.y = 0;
			i518.scaleY = 1;
			i518.rotation = 0;
			i518.alpha = 1;
			i518.filters = new as3.Array(new object[]{});
			i518.scale9Grid = null;
			i518.visible = true;
		};
		f = l.Add();
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		f.Add(i468);
		f.Add(i472);
		f.Add(i476);
		f.Add(i480);
		f.Add(i484);
		f.Add(i488);
		f.Add(i492);
		f.Add(i496);
		f.Add(i500);
		f.Add(i504);
		f = l.Add();
		setFrames(l);
	}
}
public class GachaChest : MovieClip{ 
	public resources_fla.Timeline_80 clip;
	public GachaChest() {
		var filter_0 = new GlowFilter(){strength = 3, color = 2297345, blurX = 2, blurY = 2};
		clip = new resources_fla.Timeline_80(){x = -0.1 , y = -0.6 , filters = new as3.Array(new object[]{filter_0})};
		addChild(clip);//0
	}
}
public class HandCatch : BitmapData{ 
	public HandCatch() {
		width = 20;
		height = 20;
		setPixels("dd5c687a9ee9c3c2200171a58905d89c");
	}
}
public class HelpIcon : BitmapData{ 
	public HelpIcon() {
		width = 30;
		height = 29;
		setPixels("54b324695fbaaab748e86ec07335d738");
	}
}
public class HintKeyButton : SimpleButton{ 
	public HintKeyButton() {
		downState = new symbol_169(){filters = new as3.Array(new object[]{})};
		overState = new symbol_169(){filters = new as3.Array(new object[]{})};
		upState = new symbol_169(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_170(){filters = new as3.Array(new object[]{})};
	}
}
public class HintKissClock : BitmapData{ 
	public HintKissClock() {
		width = 13;
		height = 13;
		setPixels("62d9f7e543c583a8fd37050aa239b24d");
	}
}
public class HouseNewsHintImg : BitmapData{ 
	public HouseNewsHintImg() {
		width = 34;
		height = 34;
		setPixels("0852625260a2ffed95186e1d5c46a9d1");
	}
}
public class IconBananiActive : BitmapData{ 
	public IconBananiActive() {
		width = 127;
		height = 57;
		setPixels("dd55ee245028608108ba1a7be782f001");
	}
}
public class IconBananiBank : BitmapData{ 
	public IconBananiBank() {
		width = 150;
		height = 140;
		setPixels("b7d8e3bde5d518af712cf98aa8a57a1d");
	}
}
public class IconBananiOver : BitmapData{ 
	public IconBananiOver() {
		width = 127;
		height = 57;
		setPixels("1036c6891f75fbc984f7d66ba563a70f");
	}
}
public class IconBottleBalance : BitmapData{ 
	public IconBottleBalance() {
		width = 9;
		height = 19;
		setPixels("14a80aede3bc0a72bee0b056361fedd6");
	}
}
public class IconBottleH11 : BitmapData{ 
	public IconBottleH11() {
		width = 5;
		height = 11;
		setPixels("28e9fc1cde3d621e5bfa4c47c40e81b8");
	}
}
public class IconBottleH12 : BitmapData{ 
	public IconBottleH12() {
		width = 5;
		height = 14;
		setPixels("2e7b26147eb0b8ad25870b7ac3f07dde");
	}
}
public class IconBottleH16 : BitmapData{ 
	public IconBottleH16() {
		width = 7;
		height = 17;
		setPixels("159aa7a425787855f3527fc7526fafc3");
	}
}
public class IconBottleH20 : BitmapData{ 
	public IconBottleH20() {
		width = 8;
		height = 20;
		setPixels("7d87ce6dea097020fde64737db61beae");
	}
}
public class IconBottleH30 : BitmapData{ 
	public IconBottleH30() {
		width = 8;
		height = 24;
		setPixels("19a5159b39f164d1ac10a12dab566579");
	}
}
public class IconCaptionCollectionEN : BitmapData{ 
	public IconCaptionCollectionEN() {
		width = 146;
		height = 85;
		setPixels("b2ba483872ce802bdc03878f5cffeda4");
	}
}
public class IconCaptionCollectionRU : BitmapData{ 
	public IconCaptionCollectionRU() {
		width = 139;
		height = 87;
		setPixels("87b9094fde141cd14b11ce87924e4329");
	}
}
public class IconChest : BitmapData{ 
	public IconChest() {
		width = 24;
		height = 24;
		setPixels("538e4d09fff897919d4c73a0c04e307b");
	}
}
public class IconCollectionArrow : BitmapData{ 
	public IconCollectionArrow() {
		width = 13;
		height = 21;
		setPixels("9977d0c3a841c39665d51989baa70521");
	}
}
public class IconCollectionSet1 : BitmapData{ 
	public IconCollectionSet1() {
		width = 23;
		height = 25;
		setPixels("eba2629e5af6cb25f4239df12fe1b396");
	}
}
public class IconCollectionSet2 : BitmapData{ 
	public IconCollectionSet2() {
		width = 23;
		height = 25;
		setPixels("8f639ca5ebeedf2e009d4076e8749ba3");
	}
}
public class IconCollectionSet3 : BitmapData{ 
	public IconCollectionSet3() {
		width = 23;
		height = 25;
		setPixels("99a507869d83fced0d1514d34e2a0a5d");
	}
}
public class IconCollectionSet4 : BitmapData{ 
	public IconCollectionSet4() {
		width = 23;
		height = 25;
		setPixels("12635fb71177511003cb07613f4f4e6f");
	}
}
public class IconCollectionSet5 : BitmapData{ 
	public IconCollectionSet5() {
		width = 23;
		height = 25;
		setPixels("2d68187ada9f62dd460cf43b0bd78d11");
	}
}
public class IconDiscount : BitmapData{ 
	public IconDiscount() {
		width = 49;
		height = 29;
		setPixels("1e53554e87a613ba4e5a3431e1fd89d5");
	}
}
public class IconDisplayCollection : BitmapData{ 
	public IconDisplayCollection() {
		width = 22;
		height = 22;
		setPixels("537d6c95d1031481815a82738b93182f");
	}
}
public class IconFB : BitmapData{ 
	public IconFB() {
		width = 20;
		height = 20;
		setPixels("6c4d822edbe27e036575602415b3d75f");
	}
}
public class IconFS : BitmapData{ 
	public IconFS() {
		width = 20;
		height = 20;
		setPixels("28cdf2d795e2076a5c13c6a8eee53e52");
	}
}
public class IconGachaDecoration : BitmapData{ 
	public IconGachaDecoration() {
		width = 15;
		height = 19;
		setPixels("3f928304e7d49e1fe5a7cef383919861");
	}
}
public class IconGachaFurniture : BitmapData{ 
	public IconGachaFurniture() {
		width = 21;
		height = 19;
		setPixels("8e1d9699ab747610e87a255aed0111b1");
	}
}
public class IconGachaPet : BitmapData{ 
	public IconGachaPet() {
		width = 24;
		height = 18;
		setPixels("c4768f49f53318afb5ca7d2dbe808f56");
	}
}
public class IconGachaRoom : BitmapData{ 
	public IconGachaRoom() {
		width = 20;
		height = 19;
		setPixels("df817c9009899cc4e2aad35f46f4e77b");
	}
}
public class IconGiftProfile : BitmapData{ 
	public IconGiftProfile() {
		width = 13;
		height = 16;
		setPixels("3bdd37c1aeded2ba3f741c3e12596bf5");
	}
}
public class IconHeart : BitmapData{ 
	public IconHeart() {
		width = 17;
		height = 15;
		setPixels("189f999492b67e876ae14ad7d3320ded");
	}
}
public class IconHelpCollection : BitmapData{ 
	public IconHelpCollection() {
		width = 20;
		height = 20;
		setPixels("ce0f9d5b9733e126c1007bf7c5b7ae36");
	}
}
public class IconMB : BitmapData{ 
	public IconMB() {
		width = 20;
		height = 20;
		setPixels("0f1f8ec80d0c2cec10b6964fcb890638");
	}
}
public class IconMM : BitmapData{ 
	public IconMM() {
		width = 20;
		height = 20;
		setPixels("0a823704a1708a81d8736ca59b3e53e1");
	}
}
public class IconMainRatingCollection : BitmapData{ 
	public IconMainRatingCollection() {
		width = 16;
		height = 17;
		setPixels("fb18543cf0bdc50bb7fbebab00f7adaa");
	}
}
public class IconMenuFB : BitmapData{ 
	public IconMenuFB() {
		width = 20;
		height = 20;
		setPixels("19838100e6cd4247463160f115d460ae");
	}
}
public class IconMenuFS : BitmapData{ 
	public IconMenuFS() {
		width = 20;
		height = 20;
		setPixels("7fc215e748f426e4c3b6a007c8a48fb0");
	}
}
public class IconMenuMB : BitmapData{ 
	public IconMenuMB() {
		width = 20;
		height = 20;
		setPixels("e471e241e1f7b2777a1e44a8e7865882");
	}
}
public class IconMenuMM : BitmapData{ 
	public IconMenuMM() {
		width = 20;
		height = 20;
		setPixels("62c461cdc9ad242247c638c8e9fe564a");
	}
}
public class IconMenuOK : BitmapData{ 
	public IconMenuOK() {
		width = 20;
		height = 20;
		setPixels("2953f70457b552d620d332cee0b4358f");
	}
}
public class IconMenuVK : BitmapData{ 
	public IconMenuVK() {
		width = 20;
		height = 20;
		setPixels("d6c07dd439e211ccfedb4268abbe3157");
	}
}
public class IconMobileOk : BitmapData{ 
	public IconMobileOk() {
		width = 59;
		height = 54;
		setPixels("9646ae27cd4d1601bcbf5cebc45186e0");
	}
}
public class IconOK : BitmapData{ 
	public IconOK() {
		width = 20;
		height = 20;
		setPixels("8fb569ac8199afc8cf24877f3ed540f8");
	}
}
public class IconPhone : BitmapData{ 
	public IconPhone() {
		width = 20;
		height = 20;
		setPixels("b6bd6631def41b751557a75b5baff80e");
	}
}
public class IconPrizeDecoration : BitmapData{ 
	public IconPrizeDecoration() {
		width = 75;
		height = 100;
		setPixels("57591cf4c594fa267d4ba7ea06c8469e");
	}
}
public class IconPrizeFurniture : BitmapData{ 
	public IconPrizeFurniture() {
		width = 73;
		height = 100;
		setPixels("d575716ad1f9333e4d3c6400d8585de9");
	}
}
public class IconPrizeHome : BitmapData{ 
	public IconPrizeHome() {
		width = 100;
		height = 81;
		setPixels("7477f8e334cfa730ae0130fc8219e11b");
	}
}
public class IconPrizePet : BitmapData{ 
	public IconPrizePet() {
		width = 71;
		height = 100;
		setPixels("3af4035af0a4cd5014812225bd95e1e4");
	}
}
public class IconPuzzleImage : BitmapData{ 
	public IconPuzzleImage() {
		width = 63;
		height = 45;
		setPixels("86be0b9bbdf556bac67bc3ec37b2be2d");
	}
}
public class IconRG : BitmapData{ 
	public IconRG() {
		width = 20;
		height = 20;
		setPixels("ab69573c01b837a2145a4ba7358b6abf");
	}
}
public class IconSelectItem : BitmapData{ 
	public IconSelectItem() {
		width = 38;
		height = 38;
		setPixels("a3759a50b2272ac863b4f05b69dc33a3");
	}
}
public class IconSmallFB : BitmapData{ 
	public IconSmallFB() {
		width = 16;
		height = 16;
		setPixels("b4295634a92e7697d860a9daa5544757");
	}
}
public class IconSmallFS : BitmapData{ 
	public IconSmallFS() {
		width = 16;
		height = 16;
		setPixels("bff65a2b6bf5e3119e47a135f38ea608");
	}
}
public class IconSmallMB : BitmapData{ 
	public IconSmallMB() {
		width = 16;
		height = 16;
		setPixels("3fe27b247e5d201aba15616bb489f3bf");
	}
}
public class IconSmallMM : BitmapData{ 
	public IconSmallMM() {
		width = 16;
		height = 16;
		setPixels("9518ebb8c4b9a43300531b2e30204993");
	}
}
public class IconSmallOK : BitmapData{ 
	public IconSmallOK() {
		width = 16;
		height = 16;
		setPixels("a0e1bc7a3ee9afad55536e093724f580");
	}
}
public class IconSmallPhone : BitmapData{ 
	public IconSmallPhone() {
		width = 16;
		height = 16;
		setPixels("f633394e549fc8ddaaba505c5f1e803f");
	}
}
public class IconSmallRG : BitmapData{ 
	public IconSmallRG() {
		width = 16;
		height = 16;
		setPixels("9f3d05d58dac059e260bf3a54a28c977");
	}
}
public class IconSmallVK : BitmapData{ 
	public IconSmallVK() {
		width = 16;
		height = 16;
		setPixels("d6615d0adb123747da7cc5a5f4651fd7");
	}
}
public class IconVK : BitmapData{ 
	public IconVK() {
		width = 20;
		height = 20;
		setPixels("91a67264be7ca527571e8bd9c5c46349");
	}
}
public class IconWarning : BitmapData{ 
	public IconWarning() {
		width = 34;
		height = 34;
		setPixels("476b79d338b5de9d7584a13e69b89335");
	}
}
public class ImageHeaderDiscount : BitmapData{ 
	public ImageHeaderDiscount() {
		width = 193;
		height = 42;
		setPixels("3f2d4ce01f5de3fc051ae746667e2640");
	}
}
public class ImageProfileDiscount : BitmapData{ 
	public ImageProfileDiscount() {
		width = 170;
		height = 50;
		setPixels("8ba47ab7890e038ef65d665fee811acb");
	}
}
public class InviteFriendsImage : BitmapData{ 
	public InviteFriendsImage() {
		width = 50;
		height = 50;
		setPixels("a4b9cd8335bbf20eded3fde0178f13bd");
	}
}
public class InviteFriendsSmallImage : BitmapData{ 
	public InviteFriendsSmallImage() {
		width = 40;
		height = 40;
		setPixels("934eebae1d103899901bb032479e8b73");
	}
}
public class KeyProgressBg : BitmapData{ 
	public KeyProgressBg() {
		width = 100;
		height = 102;
		setPixels("41a94eeb75c78657b41eb0ad382aa484");
	}
}
public class LightBall : MovieClip{ 
	public LightBall() {
		var i530 = new symbol_171(){filters = new as3.Array(new object[]{})};
		addChild(i530);//0
	}
}
public class LineLoading : MovieClip{ 
	public LineLoading() {
		var i537 = new symbol_172(){x = 4.8 , y = -2.6 , filters = new as3.Array(new object[]{})};
		addChild(i537);//0
		var i536 = new symbol_172(){x = -2.6 , y = -2.6 , filters = new as3.Array(new object[]{})};
		addChild(i536);//0
		var i539 = new symbol_172(){x = 19.4 , y = -2.6 , filters = new as3.Array(new object[]{})};
		addChild(i539);//0
		var i538 = new symbol_172(){x = 12.2 , y = -2.6 , filters = new as3.Array(new object[]{})};
		addChild(i538);//0
		var i532 = new symbol_0(){x = -2.6 , y = -2.6 , filters = new as3.Array(new object[]{})};
		addChild(i532);//0
		var i533 = new symbol_0(){x = 4.8 , y = -2.6 , filters = new as3.Array(new object[]{})};
		addChild(i533);//1
		var i534 = new symbol_0(){x = 12.2 , y = -2.6 , filters = new as3.Array(new object[]{})};
		addChild(i534);//2
		var i535 = new symbol_0(){x = 19.4 , y = -2.6 , filters = new as3.Array(new object[]{})};
		addChild(i535);//3
		FrameInfo f;
		var l= new Frames(19);
		f = l.Add();
		f.Add(i532);
		f += () => {
			i532.x = -2.6;
			i532.scaleX = 1;
			i532.y = -2.6;
			i532.scaleY = 1;
			i532.rotation = 0;
			i532.alpha = 1;
			i532.filters = new as3.Array(new object[]{});
			i532.scale9Grid = null;
			i532.visible = true;
		};
		f = l.Add();
		f.Add(i532);
		f = l.Add();
		f.Add(i532);
		f = l.Add();
		f.Add(i532);
		f.Add(i533);
		f += () => {
			i533.x = 4.8;
			i533.scaleX = 1;
			i533.y = -2.6;
			i533.scaleY = 1;
			i533.rotation = 0;
			i533.alpha = 1;
			i533.filters = new as3.Array(new object[]{});
			i533.scale9Grid = null;
			i533.visible = true;
		};
		f = l.Add();
		f.Add(i532);
		f.Add(i533);
		f = l.Add();
		f.Add(i532);
		f.Add(i533);
		f = l.Add();
		f.Add(i532);
		f.Add(i533);
		f.Add(i534);
		f += () => {
			i534.x = 12.2;
			i534.scaleX = 1;
			i534.y = -2.6;
			i534.scaleY = 1;
			i534.rotation = 0;
			i534.alpha = 1;
			i534.filters = new as3.Array(new object[]{});
			i534.scale9Grid = null;
			i534.visible = true;
		};
		f = l.Add();
		f.Add(i532);
		f.Add(i533);
		f.Add(i534);
		f = l.Add();
		f.Add(i532);
		f.Add(i533);
		f.Add(i534);
		f.Add(i535);
		f += () => {
			i535.x = 19.4;
			i535.scaleX = 1;
			i535.y = -2.6;
			i535.scaleY = 1;
			i535.rotation = 0;
			i535.alpha = 1;
			i535.filters = new as3.Array(new object[]{});
			i535.scale9Grid = null;
			i535.visible = true;
		};
		f = l.Add();
		f.Add(i536);
		f.Add(i533);
		f.Add(i534);
		f.Add(i535);
		f += () => {
			i536.x = -2.6;
			i536.scaleX = 1;
			i536.y = -2.6;
			i536.scaleY = 1;
			i536.rotation = 0;
			i536.alpha = 1;
			i536.filters = new as3.Array(new object[]{});
			i536.scale9Grid = null;
			i536.visible = true;
		};
		f = l.Add();
		f.Add(i533);
		f.Add(i534);
		f.Add(i535);
		f = l.Add();
		f.Add(i533);
		f.Add(i534);
		f.Add(i535);
		f = l.Add();
		f.Add(i537);
		f.Add(i534);
		f.Add(i535);
		f += () => {
			i537.x = 4.8;
			i537.scaleX = 1;
			i537.y = -2.6;
			i537.scaleY = 1;
			i537.rotation = 0;
			i537.alpha = 1;
			i537.filters = new as3.Array(new object[]{});
			i537.scale9Grid = null;
			i537.visible = true;
		};
		f = l.Add();
		f.Add(i534);
		f.Add(i535);
		f = l.Add();
		f.Add(i534);
		f.Add(i535);
		f = l.Add();
		f.Add(i538);
		f.Add(i535);
		f += () => {
			i538.x = 12.2;
			i538.scaleX = 1;
			i538.y = -2.6;
			i538.scaleY = 1;
			i538.rotation = 0;
			i538.alpha = 1;
			i538.filters = new as3.Array(new object[]{});
			i538.scale9Grid = null;
			i538.visible = true;
		};
		f = l.Add();
		f.Add(i535);
		f = l.Add();
		f.Add(i539);
		f += () => {
			i539.x = 19.4;
			i539.scaleX = 1;
			i539.y = -2.6;
			i539.scaleY = 1;
			i539.rotation = 0;
			i539.alpha = 1;
			i539.filters = new as3.Array(new object[]{});
			i539.scale9Grid = null;
			i539.visible = true;
		};
		f = l.Add();
		setFrames(l);
	}
}
public class LoveTreeHintIcon : BitmapData{ 
	public LoveTreeHintIcon() {
		width = 50;
		height = 50;
		setPixels("23df08b8d7b89d282e7f95c9c9c8574d");
	}
}
public class MinusWhiteImage : BitmapData{ 
	public MinusWhiteImage() {
		width = 11;
		height = 3;
		setPixels("93de8f612d0d38cd580f839bccd14058");
	}
}
public class MovieLoading : MovieClip{ 
	public MovieLoading() {
		var i541 = new symbol_173(){filters = new as3.Array(new object[]{})};
		addChild(i541);//0
		FrameInfo f;
		var l= new Frames(20);
		f = l.Add();
		f.Add(i541);
		f += () => {
			i541.x = 0;
			i541.scaleX = 1;
			i541.y = 0;
			i541.scaleY = 1;
			i541.rotation = 0;
			i541.alpha = 1;
			i541.filters = new as3.Array(new object[]{});
			i541.scale9Grid = null;
			i541.visible = true;
		};
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		f = l.Add();
		f.Add(i541);
		setFrames(l);
	}
}
public class NewRussia : MovieClip{ 
	public NewRussia() {
		var i543 = new symbol_175(){x = -16 , y = -0.5 , filters = new as3.Array(new object[]{})};
		addChild(i543);//0
		var i558 = new CollectionButtonClip(){x = -376.7 , y = -108.1 , filters = new as3.Array(new object[]{})};
		addChild(i558);//0
		var i556 = new symbol_186(){x = -92.3 , scaleX = 0.88 , y = 58.3 , scaleY = 0.88 , rotation = -139 , filters = new as3.Array(new object[]{})};
		addChild(i556);//0
		var i545 = new symbol_177(){x = 24.1 , y = 52.1 , filters = new as3.Array(new object[]{})};
		addChild(i545);//1
		var i547 = new symbol_179(){x = 4.7 , scaleX = 0.57 , y = 112 , scaleY = 0.57 , rotation = 21 , filters = new as3.Array(new object[]{})};
		addChild(i547);//2
		var i549 = new symbol_181(){x = -44.3 , y = -26.8 , filters = new as3.Array(new object[]{})};
		addChild(i549);//3
		var i551 = new symbol_183(){x = 4.6 , y = -20.2 , filters = new as3.Array(new object[]{})};
		addChild(i551);//4
		var i555 = new symbol_184(){x = -115.3 , y = -113.5 , filters = new as3.Array(new object[]{})};
		addChild(i555);//5
		var i553 = new symbol_184(){x = -16.6 , y = -115.8 , filters = new as3.Array(new object[]{})};
		addChild(i553);//5
		var i554 = new symbol_185(){x = -115.3 , y = -113.5 , filters = new as3.Array(new object[]{})};
		addChild(i554);//5
		FrameInfo f;
		var l= new Frames(100);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -16;
			i543.scaleX = 1;
			i543.y = -0.5;
			i543.scaleY = 1;
			i543.rotation = 0;
			i543.alpha = 1;
			i543.filters = new as3.Array(new object[]{});
			i543.scale9Grid = null;
			i543.visible = true;
			i545.x = 24.1;
			i545.scaleX = 1;
			i545.y = 52.1;
			i545.scaleY = 1;
			i545.rotation = 0;
			i545.alpha = 1;
			i545.filters = new as3.Array(new object[]{});
			i545.scale9Grid = null;
			i545.visible = true;
			i547.x = 4.7;
			i547.scaleX = 0.57;
			i547.y = 112;
			i547.scaleY = 0.57;
			i547.rotation = 21;
			i547.alpha = 1;
			i547.filters = new as3.Array(new object[]{});
			i547.scale9Grid = null;
			i547.visible = true;
			i549.x = -44.3;
			i549.scaleX = 1;
			i549.y = -26.8;
			i549.scaleY = 1;
			i549.rotation = 0;
			i549.alpha = 1;
			i549.filters = new as3.Array(new object[]{});
			i549.scale9Grid = null;
			i549.visible = true;
			i551.x = 4.6;
			i551.scaleX = 1;
			i551.y = -20.2;
			i551.scaleY = 1;
			i551.rotation = 0;
			i551.alpha = 1;
			i551.filters = new as3.Array(new object[]{});
			i551.scale9Grid = null;
			i551.visible = true;
			i553.x = -16.6;
			i553.scaleX = 1;
			i553.y = -115.8;
			i553.scaleY = 1;
			i553.rotation = 0;
			i553.alpha = 1;
			i553.filters = new as3.Array(new object[]{});
			i553.scale9Grid = null;
			i553.visible = true;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -26.8;
			i543.y = 5.3;
			i543.rotation = 9;
			i545.x = 14.3;
			i545.y = 52.3;
			i547.x = -0.6;
			i547.y = 113;
			i547.rotation = 16;
			i549.x = -54.5;
			i549.y = -27.4;
			i551.x = -5.2;
			i551.y = -20.1;
			i553.x = -26.6;
			i553.scaleX = 0.57;
			i553.y = -115.6;
			i553.scaleY = 0.57;
			i553.rotation = -9;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -37.9;
			i543.y = 10.6;
			i543.rotation = 17;
			i545.x = 5;
			i545.y = 52.4;
			i547.x = -5.5;
			i547.y = 113.8;
			i547.rotation = 12;
			i549.x = -64.2;
			i549.y = -28;
			i551.x = -14.4;
			i551.y = -19.9;
			i553.x = -36.3;
			i553.y = -115.3;
			i553.rotation = -10;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -49.2;
			i543.y = 15.1;
			i543.rotation = 25;
			i545.x = -3.8;
			i545.y = 52.5;
			i547.x = -10.1;
			i547.y = 114.1;
			i547.rotation = 7;
			i549.x = -73.3;
			i549.y = -28.6;
			i551.x = -23.2;
			i551.y = -19.8;
			i553.x = -45.4;
			i553.y = -115.2;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -60.6;
			i543.y = 19;
			i543.rotation = 33;
			i545.x = -11.9;
			i545.y = 52.6;
			i547.x = -14.1;
			i547.y = 114.2;
			i547.rotation = 3;
			i549.x = -81.8;
			i549.y = -29.1;
			i549.rotation = 1;
			i551.x = -31.4;
			i551.y = -19.6;
			i553.x = -53.7;
			i553.y = -115;
			i553.rotation = -11;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -71.8;
			i543.y = 22.2;
			i543.rotation = 40;
			i545.x = -19.6;
			i545.y = 52.8;
			i547.x = -18.3;
			i547.y = 114;
			i547.rotation = 0;
			i549.x = -90;
			i549.y = -29.6;
			i551.x = -39;
			i551.y = -19.5;
			i553.x = -61.6;
			i553.y = -114.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -82.7;
			i543.y = 24.8;
			i543.rotation = 47;
			i545.x = -26.8;
			i545.y = 52.9;
			i547.x = -22.3;
			i547.y = 113.6;
			i547.rotation = -3;
			i549.x = -97.5;
			i549.y = -30.1;
			i551.x = -46.2;
			i551.y = -19.4;
			i553.x = -69;
			i553.y = -114.7;
			i553.rotation = -12;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -93.2;
			i543.y = 26.6;
			i543.rotation = 53;
			i545.x = -33.4;
			i545.y = 53;
			i547.x = -25.9;
			i547.y = 113.1;
			i547.rotation = -6;
			i549.x = -104.3;
			i549.y = -30.6;
			i551.x = -52.8;
			i551.y = -19.3;
			i553.x = -75.8;
			i553.y = -114.4;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -103;
			i543.y = 27.9;
			i543.rotation = 58;
			i545.x = -39.5;
			i545.y = 53.1;
			i547.x = -29.1;
			i547.y = 112.5;
			i547.rotation = -9;
			i549.x = -110.8;
			i549.y = -31;
			i549.rotation = 2;
			i551.x = -58.9;
			i551.y = -19.2;
			i553.x = -82.2;
			i553.y = -114.3;
			i553.rotation = -13;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -112;
			i543.y = 28.8;
			i543.rotation = 63;
			i545.x = -45;
			i545.y = 53.2;
			i547.x = -32.1;
			i547.y = 111.8;
			i547.rotation = -12;
			i549.x = -116.6;
			i549.y = -31.3;
			i551.x = -64.5;
			i551.y = -19.1;
			i553.x = -87.9;
			i553.y = -114.2;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -120.3;
			i543.y = 29.3;
			i543.rotation = 68;
			i545.x = -50;
			i545.y = 53.3;
			i547.x = -34.9;
			i547.y = 110.9;
			i547.rotation = -14;
			i549.x = -121.9;
			i549.y = -31.6;
			i551.x = -69.5;
			i553.x = -93;
			i553.y = -114;
			i553.rotation = -14;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -127.9;
			i543.y = 29.4;
			i543.rotation = 72;
			i545.x = -54.5;
			i545.y = 53.4;
			i547.x = -37.3;
			i547.y = 110.2;
			i547.rotation = -17;
			i549.x = -126.5;
			i549.y = -31.9;
			i551.x = -74;
			i551.y = -18.9;
			i553.x = -97.7;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -134.5;
			i543.rotation = 76;
			i545.x = -58.5;
			i547.x = -39.5;
			i547.y = 109.3;
			i547.rotation = -19;
			i549.x = -130.8;
			i549.y = -32.2;
			i551.x = -78;
			i553.x = -101.9;
			i553.y = -113.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -140.3;
			i543.y = 29.3;
			i543.rotation = 79;
			i545.x = -62;
			i545.y = 53.5;
			i547.x = -41.6;
			i547.y = 108.8;
			i547.rotation = -20;
			i549.x = -134.3;
			i549.y = -32.4;
			i551.x = -81.4;
			i553.x = -105.5;
			i553.rotation = -15;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -145.3;
			i543.y = 29.1;
			i543.rotation = 82;
			i545.x = -64.8;
			i547.x = -43.3;
			i547.y = 108.1;
			i547.rotation = -22;
			i549.x = -137.4;
			i549.y = -32.6;
			i549.rotation = 3;
			i551.x = -84.3;
			i551.y = -18.8;
			i553.x = -108.3;
			i553.y = -113.7;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -149.3;
			i543.y = 28.7;
			i543.rotation = 84;
			i545.x = -67.2;
			i547.x = -44.6;
			i547.y = 107.6;
			i547.rotation = -23;
			i549.x = -139.9;
			i549.y = -32.8;
			i551.x = -86.7;
			i553.x = -110.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -152.4;
			i543.y = 28.5;
			i543.rotation = 86;
			i545.x = -69;
			i547.x = -45.8;
			i547.y = 107.2;
			i547.rotation = -24;
			i549.x = -141.8;
			i549.y = -32.9;
			i551.x = -88.5;
			i553.x = -112.7;
			i553.y = -113.6;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -154.6;
			i543.y = 28.4;
			i543.rotation = 87;
			i545.x = -70.4;
			i545.y = 53.6;
			i547.x = -46.5;
			i547.y = 106.8;
			i549.x = -143.3;
			i549.y = -33;
			i551.x = -89.8;
			i551.y = -18.7;
			i553.x = -114.1;
			i553.y = -113.5;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -155.9;
			i543.y = 28.1;
			i543.rotation = 88;
			i545.x = -71.2;
			i547.x = -47.1;
			i547.rotation = -25;
			i549.x = -144.1;
			i551.x = -90.7;
			i553.x = -114.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f += () => {
			i543.x = -156.3;
			i545.x = -71.5;
			i547.x = -47;
			i547.y = 106.7;
			i549.x = -144.4;
			i551.x = -90.9;
			i553.x = -115.3;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i553);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i554);
		f += () => {
			i554.x = -115.3;
			i554.scaleX = 1;
			i554.y = -113.5;
			i554.scaleY = 1;
			i554.rotation = 0;
			i554.alpha = 1;
			i554.filters = new as3.Array(new object[]{});
			i554.scale9Grid = null;
			i554.visible = true;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i554);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i554);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i554);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i555.x = -115.3;
			i555.scaleX = 1;
			i555.y = -113.5;
			i555.scaleY = 1;
			i555.rotation = 0;
			i555.alpha = 1;
			i555.filters = new as3.Array(new object[]{});
			i555.scale9Grid = null;
			i555.visible = true;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -165.5;
			i543.y = 25.9;
			i543.rotation = 101;
			i549.x = -145.9;
			i549.y = -33.4;
			i549.rotation = 5;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -171.8;
			i543.y = 23.1;
			i543.rotation = 110;
			i549.x = -147.2;
			i549.y = -33.7;
			i549.rotation = 7;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -175.3;
			i543.y = 20.9;
			i543.rotation = 115;
			i549.x = -147.8;
			i549.y = -33.9;
			i549.rotation = 8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -176.6;
			i543.y = 20.1;
			i543.rotation = 117;
			i549.x = -148.1;
			i549.rotation = 9;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -157.7;
			i543.y = 27.9;
			i543.rotation = 93;
			i549.x = -144.1;
			i549.y = -33;
			i549.rotation = 2;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -141.3;
			i543.y = 28.5;
			i543.rotation = 73;
			i549.x = -140.8;
			i549.y = -32.5;
			i549.rotation = -2;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -129;
			i543.y = 25.3;
			i543.rotation = 58;
			i549.x = -138.3;
			i549.rotation = -6;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -121;
			i543.y = 21.1;
			i543.rotation = 47;
			i549.x = -136.3;
			i549.rotation = -9;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -116.7;
			i543.y = 18.1;
			i543.rotation = 40;
			i549.x = -135.2;
			i549.rotation = -11;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -115.4;
			i543.y = 16.9;
			i543.rotation = 38;
			i549.x = -134.8;
			i549.y = -32.6;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -130.8;
			i543.y = 23.6;
			i543.rotation = 57;
			i556.x = -92.3;
			i556.scaleX = 0.88;
			i556.y = 58.3;
			i556.scaleY = 0.88;
			i556.rotation = -139;
			i556.alpha = 1;
			i556.filters = new as3.Array(new object[]{});
			i556.scale9Grid = null;
			i556.visible = true;
			i549.x = -139.6;
			i549.y = -31.1;
			i549.rotation = -2;
			i551.x = -90.8;
			i551.y = -19;
			i555.x = -114.7;
			i555.scaleX = 0.57;
			i555.y = -113.8;
			i555.scaleY = 0.57;
			i555.rotation = -15;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -147.3;
			i543.y = 25.9;
			i543.rotation = 74;
			i556.x = -121.6;
			i556.y = 67;
			i556.rotation = -120;
			i549.x = -143.8;
			i549.y = -30.4;
			i549.rotation = 6;
			i551.y = -19.3;
			i555.x = -114.2;
			i555.y = -114.1;
			i555.rotation = -14;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -162.9;
			i543.y = 24.6;
			i543.rotation = 90;
			i556.x = -150.4;
			i556.y = 69.5;
			i556.rotation = -103;
			i549.x = -147.8;
			i549.y = -30.5;
			i549.rotation = 14;
			i551.y = -19.4;
			i555.x = -113.7;
			i555.y = -114.3;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -177;
			i543.y = 20;
			i543.rotation = 105;
			i556.x = -177.2;
			i556.y = 65.7;
			i556.rotation = -87;
			i549.x = -151.2;
			i549.y = -31.2;
			i549.rotation = 21;
			i551.x = -90.7;
			i551.y = -19.7;
			i555.x = -113.3;
			i555.y = -114.5;
			i555.rotation = -13;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -189;
			i543.y = 13.4;
			i543.rotation = 119;
			i556.x = -200.2;
			i556.y = 56.9;
			i556.rotation = -72;
			i549.x = -154;
			i549.y = -32.4;
			i549.rotation = 28;
			i551.x = -90.5;
			i551.y = -19.9;
			i551.rotation = 1;
			i555.x = -112.9;
			i555.y = -114.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -198.6;
			i543.y = 5.7;
			i543.rotation = 131;
			i556.x = -219;
			i556.y = 44.6;
			i556.rotation = -59;
			i549.x = -156.3;
			i549.y = -33.7;
			i549.rotation = 34;
			i551.y = -20.1;
			i555.x = -112.5;
			i555.y = -115.1;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -205.8;
			i543.y = -2.4;
			i543.rotation = 142;
			i556.x = -233.8;
			i556.y = 31.3;
			i556.rotation = -48;
			i549.x = -158.1;
			i549.y = -35.2;
			i549.rotation = 39;
			i551.y = -20.3;
			i555.x = -112.2;
			i555.y = -115.2;
			i555.rotation = -12;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -210.9;
			i543.y = -10.1;
			i543.rotation = 152;
			i556.x = -245.1;
			i556.y = 17.9;
			i556.rotation = -38;
			i549.x = -159.6;
			i549.y = -36.6;
			i549.rotation = 44;
			i551.x = -90.3;
			i551.y = -20.4;
			i555.x = -111.8;
			i555.y = -115.5;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -214.6;
			i543.y = -17.4;
			i543.rotation = 160;
			i556.x = -253.3;
			i556.y = 5.5;
			i556.rotation = -29;
			i549.x = -160.7;
			i549.y = -38.1;
			i549.rotation = 48;
			i551.y = -20.5;
			i555.x = -111.6;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -216.8;
			i543.y = -23.7;
			i543.rotation = 167;
			i556.x = -259.4;
			i556.y = -5.3;
			i556.rotation = -23;
			i549.x = -161.4;
			i549.y = -39.5;
			i549.rotation = 52;
			i551.y = -20.6;
			i555.x = -111.4;
			i555.y = -115.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -218.2;
			i543.y = -28.9;
			i543.rotation = 173;
			i556.x = -263.5;
			i556.y = -13.9;
			i556.rotation = -17;
			i549.x = -161.9;
			i549.y = -40.5;
			i549.rotation = 55;
			i551.y = -20.7;
			i555.x = -111.3;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -218.9;
			i543.y = -32.9;
			i543.rotation = 178;
			i556.x = -266.1;
			i556.y = -20.3;
			i556.rotation = -13;
			i549.x = -162.3;
			i549.y = -41.4;
			i549.rotation = 57;
			i551.x = -90.2;
			i551.y = -20.8;
			i555.x = -111;
			i555.rotation = -11;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -219.3;
			i543.y = -35.6;
			i543.rotation = -178;
			i556.x = -267.5;
			i556.y = -24.1;
			i556.rotation = -11;
			i549.x = -162.5;
			i549.y = -42;
			i549.rotation = 58;
			i551.y = -20.9;
			i551.rotation = 2;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i556);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -219.4;
			i543.y = -37.4;
			i543.rotation = -176;
			i556.x = -268.3;
			i556.y = -25.3;
			i556.rotation = -10;
			i549.x = -162.7;
			i549.y = -42.4;
			i549.rotation = 59;
			i555.y = -116;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.y = -38;
			i558.x = -376.7;
			i558.scaleX = 1;
			i558.y = -108.1;
			i558.scaleY = 1;
			i558.rotation = 0;
			i558.alpha = 1;
			i558.filters = new as3.Array(new object[]{});
			i558.scale9Grid = null;
			i558.visible = true;
			i549.x = -162.8;
			i549.y = -42.5;
			i549.rotation = 60;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -214.5;
			i543.y = -22.3;
			i543.rotation = 167;
			i549.x = -161.2;
			i549.y = -38.1;
			i549.rotation = 48;
			i551.x = -90.4;
			i551.y = -20.4;
			i551.rotation = 1;
			i555.x = -111.8;
			i555.y = -115.6;
			i555.rotation = -12;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -206.8;
			i543.y = -8.5;
			i543.rotation = 152;
			i549.x = -158.9;
			i549.y = -34.9;
			i549.rotation = 38;
			i551.x = -90.5;
			i551.y = -20.1;
			i555.x = -112.5;
			i555.y = -115.2;
			i555.rotation = -13;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -197.7;
			i543.y = 2.9;
			i543.rotation = 138;
			i549.x = -156.1;
			i549.y = -32.8;
			i549.rotation = 29;
			i551.y = -19.8;
			i555.x = -113.2;
			i555.y = -114.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -188.4;
			i543.y = 11.4;
			i543.rotation = 127;
			i549.x = -153.2;
			i549.y = -31.4;
			i549.rotation = 21;
			i551.x = -90.8;
			i551.y = -19.4;
			i551.rotation = 0;
			i555.x = -113.7;
			i555.y = -114.4;
			i555.rotation = -14;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -179.3;
			i543.y = 17.9;
			i543.rotation = 117;
			i549.x = -150.5;
			i549.y = -30.9;
			i549.rotation = 14;
			i551.y = -19.3;
			i555.x = -114;
			i555.y = -114.2;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -171.4;
			i543.y = 22.3;
			i543.rotation = 109;
			i549.x = -148.2;
			i549.y = -30.7;
			i549.rotation = 9;
			i551.x = -90.9;
			i551.y = -19.1;
			i555.x = -114.5;
			i555.y = -114;
			i555.rotation = -15;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -165;
			i543.y = 25.1;
			i543.rotation = 103;
			i549.x = -146.3;
			i549.y = -30.8;
			i549.rotation = 4;
			i551.x = -90.8;
			i551.y = -18.9;
			i555.x = -114.8;
			i555.y = -113.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -160.3;
			i543.y = 26.9;
			i543.rotation = 99;
			i549.x = -144.9;
			i549.y = -31;
			i549.rotation = 1;
			i551.x = -90.9;
			i551.y = -18.8;
			i555.x = -115;
			i555.y = -113.7;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -157.3;
			i543.y = 27.9;
			i543.rotation = 96;
			i549.x = -144.2;
			i549.y = -31.1;
			i549.rotation = 0;
			i551.y = -18.7;
			i555.x = -115.1;
			i555.y = -113.5;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -156.6;
			i543.y = 28.1;
			i543.rotation = 95;
			i549.x = -144;
			i549.y = -31.2;
			i555.x = -115.3;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -156;
			i543.y = 29;
			i543.rotation = 94;
			i545.x = -71.8;
			i545.y = 53.7;
			i547.x = -47.2;
			i549.x = -144.8;
			i549.y = -30.6;
			i549.rotation = -1;
			i551.x = -91.8;
			i551.y = -18.5;
			i555.x = -116.7;
			i555.y = -113;
			i555.rotation = -16;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -155.5;
			i543.y = 29.7;
			i543.rotation = 92;
			i545.x = -72.2;
			i545.y = 53.8;
			i547.x = -47.1;
			i547.y = 106.5;
			i547.rotation = -26;
			i549.x = -145.3;
			i549.y = -30.1;
			i551.x = -92.4;
			i551.y = -18.3;
			i555.x = -117.9;
			i555.y = -112.8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -155.1;
			i543.y = 30.1;
			i543.rotation = 91;
			i545.x = -72.4;
			i545.y = 53.9;
			i549.x = -145.7;
			i549.y = -29.7;
			i549.rotation = -2;
			i551.x = -92.9;
			i551.y = -18.1;
			i555.x = -118.8;
			i555.y = -112.5;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -154.8;
			i543.y = 30.6;
			i543.rotation = 90;
			i545.x = -72.5;
			i545.rotation = -1;
			i547.x = -47.3;
			i549.x = -146.1;
			i549.y = -29.5;
			i551.x = -93.3;
			i551.rotation = -1;
			i555.x = -119.5;
			i555.y = -112.3;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -154.7;
			i543.y = 30.8;
			i545.x = -72.7;
			i545.y = 54;
			i547.x = -47.2;
			i549.x = -146.3;
			i549.y = -29.3;
			i551.x = -93.5;
			i551.y = -18;
			i555.x = -119.9;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.y = 30.9;
			i543.rotation = 89;
			i547.x = -47.1;
			i549.y = -29.2;
			i551.x = -93.7;
			i551.y = -17.9;
			i555.x = -120;
			i555.y = -112.2;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -130.3;
			i543.y = 28.3;
			i543.rotation = 92;
			i545.x = -48.6;
			i545.rotation = 0;
			i547.x = -24.9;
			i547.y = 107.5;
			i547.rotation = -24;
			i549.x = -119.4;
			i549.y = -31.3;
			i549.rotation = 0;
			i551.x = -67.1;
			i551.y = -18.4;
			i551.rotation = 0;
			i555.x = -90;
			i555.y = -113.3;
			i555.rotation = -14;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -108.8;
			i543.y = 25.9;
			i543.rotation = 95;
			i545.x = -27.4;
			i545.y = 54.2;
			i545.rotation = 2;
			i547.x = -5.3;
			i547.y = 108.2;
			i547.rotation = -22;
			i549.x = -95.5;
			i549.y = -33.2;
			i549.rotation = 1;
			i551.x = -43.7;
			i551.y = -18.8;
			i551.rotation = 2;
			i555.x = -63.7;
			i555.y = -114.2;
			i555.rotation = -13;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -90.2;
			i543.y = 23.6;
			i543.rotation = 97;
			i545.x = -9;
			i545.y = 54.3;
			i545.rotation = 4;
			i547.x = 11.6;
			i547.y = 108.9;
			i547.rotation = -21;
			i549.x = -74.9;
			i549.y = -34.9;
			i549.rotation = 2;
			i551.x = -23.3;
			i551.y = -19.1;
			i551.rotation = 4;
			i555.x = -40.8;
			i555.y = -115;
			i555.rotation = -11;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -74.5;
			i543.y = 21.7;
			i543.rotation = 99;
			i545.x = 6.5;
			i545.y = 54.4;
			i545.rotation = 5;
			i547.x = 26;
			i547.y = 109.5;
			i547.rotation = -20;
			i549.x = -57.5;
			i549.y = -36.3;
			i549.rotation = 4;
			i551.x = -6.1;
			i551.y = -19.4;
			i551.rotation = 5;
			i555.x = -21.5;
			i555.y = -115.6;
			i555.rotation = -10;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -61.5;
			i543.y = 20.2;
			i543.rotation = 101;
			i545.x = 19.4;
			i545.rotation = 6;
			i547.x = 37.8;
			i547.y = 109.8;
			i547.rotation = -19;
			i549.x = -43.1;
			i549.y = -37.5;
			i549.rotation = 5;
			i551.x = 8;
			i551.y = -19.5;
			i551.rotation = 6;
			i555.x = -5.5;
			i555.y = -116.2;
			i555.rotation = -9;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -51.6;
			i543.y = 18.9;
			i543.rotation = 102;
			i545.x = 29.2;
			i545.y = 54.5;
			i545.rotation = 7;
			i547.x = 46.8;
			i547.y = 110.3;
			i547.rotation = -18;
			i549.x = -32;
			i549.y = -38.5;
			i549.rotation = 6;
			i551.x = 18.8;
			i551.y = -19.6;
			i551.rotation = 7;
			i555.x = 6.7;
			i555.y = -116.5;
			i555.rotation = -8;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -44.5;
			i543.y = 17.9;
			i543.rotation = 103;
			i545.x = 36.4;
			i547.x = 53.4;
			i547.rotation = -17;
			i549.x = -24.1;
			i549.y = -39.1;
			i549.rotation = 7;
			i551.x = 26.6;
			i555.x = 15.5;
			i555.y = -116.8;
			i555.rotation = -7;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -40;
			i543.y = 17.4;
			i545.x = 40.6;
			i545.rotation = 8;
			i547.x = 57.3;
			i547.y = 110.5;
			i549.x = -19.4;
			i549.y = -39.6;
			i551.x = 31.4;
			i551.y = -19.7;
			i551.rotation = 8;
			i555.x = 20.8;
			i555.y = -117;
		};
		f = l.Add();
		f.Add(i543);
		f.Add(i558);
		f.Add(i545);
		f.Add(i547);
		f.Add(i549);
		f.Add(i551);
		f.Add(i555);
		f += () => {
			i543.x = -38.8;
			i543.y = 17.3;
			i543.rotation = 104;
			i545.x = 42;
			i547.x = 58.5;
			i547.y = 110.7;
			i549.x = -17.8;
			i549.y = -39.7;
			i551.x = 33;
			i551.y = -19.8;
			i555.x = 22.4;
		};
		setFrames(l);
	}
}
public class NextPageIcon : BitmapData{ 
	public NextPageIcon() {
		width = 28;
		height = 28;
		setPixels("1126f6a5309455ca9b442c24efcf4154");
	}
}
public class NextPageIcon2 : BitmapData{ 
	public NextPageIcon2() {
		width = 14;
		height = 14;
		setPixels("8dbb9c9436b9092979d9ff5f95b72b2e");
	}
}
public class NotifyRedIcon : BitmapData{ 
	public NotifyRedIcon() {
		width = 21;
		height = 21;
		setPixels("6cf587c89da52f3788c9edfbfac70500");
	}
}
public class OneStarClip : MovieClip{ 
	public OneStarClip() {
		var i566 = new symbol_191(){alpha = 0 , filters = new as3.Array(new object[]{})};
		addChild(i566);//0
		FrameInfo f;
		var l= new Frames(30);
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.x = 0;
			i566.scaleX = 1;
			i566.y = 0;
			i566.scaleY = 1;
			i566.rotation = 0;
			i566.alpha = 0;
			i566.filters = new as3.Array(new object[]{});
			i566.scale9Grid = null;
			i566.visible = true;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 3;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 6;
			i566.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 9;
			i566.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 12;
			i566.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 16;
			i566.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 19;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 22;
			i566.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 25;
			i566.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 28;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 32;
			i566.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 35;
			i566.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 38;
			i566.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 41;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 44;
			i566.alpha = 1;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 47;
			i566.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 50;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 53;
			i566.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 56;
			i566.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 59;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 62;
			i566.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 65;
			i566.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 68;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 71;
			i566.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 74;
			i566.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 77;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 80;
			i566.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 83;
			i566.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 87;
			i566.alpha = 0;
		};
		f = l.Add();
		f.Add(i566);
		f += () => {
			i566.rotation = 90;
		};
		setFrames(l);
	}
}
public class PaginationShape : MovieClip{ 
	public PaginationShape() {
		this.scale9Grid = new flash.geom.Rectangle(13,  7,  1,  14);
		var i569 = new symbol_192(){filters = new as3.Array(new object[]{})};
		addChild(i569);//0
	}
}
public class PencilEditImg : BitmapData{ 
	public PencilEditImg() {
		width = 15;
		height = 15;
		setPixels("3f11ef5e146f55d364f3baac28aba288");
	}
}
public class PendantHintArrow : BitmapData{ 
	public PendantHintArrow() {
		width = 94;
		height = 32;
		setPixels("544b5855e93aa48444ce4bb370c3631e");
	}
}
public class PhotoSelectedImg : BitmapData{ 
	public PhotoSelectedImg() {
		width = 18;
		height = 18;
		setPixels("9ae631e939c14b6f3d17281783e073ec");
	}
}
public class PlusWhiteImage : BitmapData{ 
	public PlusWhiteImage() {
		width = 11;
		height = 11;
		setPixels("85b5c8adb98ac8a9b0ea5e8acfa93c95");
	}
}
public class PresentsSelectedIcon : BitmapData{ 
	public PresentsSelectedIcon() {
		width = 12;
		height = 10;
		setPixels("35f167cfa4f706df6f4a5926aab5b944");
	}
}
public class PresentsUnselectedIcon : BitmapData{ 
	public PresentsUnselectedIcon() {
		width = 10;
		height = 10;
		setPixels("38ab210634a2fe79e8f68f3c47d414f7");
	}
}
public class PreviousPageIcon : BitmapData{ 
	public PreviousPageIcon() {
		width = 28;
		height = 28;
		setPixels("704673029f921aec76c9cb715728c070");
	}
}
public class PreviousPageIcon2 : BitmapData{ 
	public PreviousPageIcon2() {
		width = 14;
		height = 14;
		setPixels("733a2b0df581e4a5103a6e3af482ec6d");
	}
}
public class ReWindLeftButton : SimpleButton{ 
	public ReWindLeftButton() {
		downState = new symbol_198(){filters = new as3.Array(new object[]{})};
		overState = new symbol_198(){filters = new as3.Array(new object[]{})};
		upState = new symbol_198(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_198(){filters = new as3.Array(new object[]{})};
	}
}
public class ReWindRightButton : SimpleButton{ 
	public ReWindRightButton() {
		downState = new symbol_198(){filters = new as3.Array(new object[]{})};
		overState = new symbol_198(){filters = new as3.Array(new object[]{})};
		upState = new symbol_198(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_198(){filters = new as3.Array(new object[]{})};
	}
}
public class ScaleCleanIcon : BitmapData{ 
	public ScaleCleanIcon() {
		width = 25;
		height = 24;
		setPixels("f2e9d344246ba20f351c14ffbdca3949");
	}
}
public class ScaleFoodIcon : BitmapData{ 
	public ScaleFoodIcon() {
		width = 21;
		height = 24;
		setPixels("023ddd6ccb959b9443803ec0ce89b4b7");
	}
}
public class ScaleHappyIcon : BitmapData{ 
	public ScaleHappyIcon() {
		width = 21;
		height = 24;
		setPixels("f99c27624af034bdb9be5fd79db28533");
	}
}
public class SmallLoader : MovieClip{ 
	public SmallLoader() {
		var i724 = new symbol_199(){filters = new as3.Array(new object[]{})};
		addChild(i724);//0
		var i725 = new symbol_200(){x = 9.2 , y = 9.2 , filters = new as3.Array(new object[]{})};
		addChild(i725);//1
		FrameInfo f;
		var l= new Frames(40);
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i724.x = 0;
			i724.scaleX = 1;
			i724.y = 0;
			i724.scaleY = 1;
			i724.rotation = 0;
			i724.alpha = 1;
			i724.filters = new as3.Array(new object[]{});
			i724.scale9Grid = null;
			i724.visible = true;
			i725.x = 9.2;
			i725.scaleX = 1;
			i725.y = 9.2;
			i725.scaleY = 1;
			i725.rotation = 0;
			i725.alpha = 1;
			i725.filters = new as3.Array(new object[]{});
			i725.scale9Grid = null;
			i725.visible = true;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 9;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 18;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 28;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 37;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 47;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 56;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 66;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 75;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 85;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 94;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 104;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 113;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 123;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 132;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 142;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 151;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 161;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 170;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 180;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -170;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -162;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -152;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -144;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -135;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -125;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -117;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -107;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -99;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -90;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -80;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -72;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -62;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -54;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -45;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -35;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -27;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -17;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = -9;
		};
		f = l.Add();
		f.Add(i724);
		f.Add(i725);
		f += () => {
			i725.rotation = 0;
		};
		setFrames(l);
	}
}
public class StarMovie : MovieClip{ 
	public StarMovie() {
		var i727 = new symbol_171(){filters = new as3.Array(new object[]{})};
		addChild(i727);//0
	}
}
public class StarsMovie : MovieClip{ 
	public StarsMovie() {
		var i729 = new symbol_201(){filters = new as3.Array(new object[]{})};
		addChild(i729);//0
		var i738 = new symbol_210(){x = 56.8 , alpha = 0 , y = 51.6 , filters = new as3.Array(new object[]{})};
		addChild(i738);//1
		var i730 = new symbol_203(){x = 56.8 , y = 51.6 , filters = new as3.Array(new object[]{})};
		addChild(i730);//1
		var i732 = new symbol_205(){x = 54.4 , alpha = 0 , y = 55.2 , filters = new as3.Array(new object[]{})};
		addChild(i732);//2
		var i736 = new symbol_209(){x = 52.5 , alpha = 0 , y = 54.3 , filters = new as3.Array(new object[]{})};
		addChild(i736);//3
		var i734 = new symbol_207(){x = 54.6 , alpha = 0 , y = 50.5 , filters = new as3.Array(new object[]{})};
		addChild(i734);//3
		FrameInfo f;
		var l= new Frames(41);
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i729.x = 0;
			i729.scaleX = 1;
			i729.y = 0;
			i729.scaleY = 1;
			i729.rotation = 0;
			i729.alpha = 1;
			i729.filters = new as3.Array(new object[]{});
			i729.scale9Grid = null;
			i729.visible = true;
			i730.x = 56.8;
			i730.scaleX = 1;
			i730.y = 51.6;
			i730.scaleY = 1;
			i730.rotation = 0;
			i730.alpha = 1;
			i730.filters = new as3.Array(new object[]{});
			i730.scale9Grid = null;
			i730.visible = true;
			i732.x = 54.4;
			i732.scaleX = 1;
			i732.y = 55.2;
			i732.scaleY = 1;
			i732.rotation = 0;
			i732.alpha = 0;
			i732.filters = new as3.Array(new object[]{});
			i732.scale9Grid = null;
			i732.visible = true;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.9;
			i732.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.8;
			i732.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.7;
			i732.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.6;
			i732.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.5;
			i732.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.4;
			i732.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.3;
			i732.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.2;
			i732.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f += () => {
			i730.alpha = 0.1;
			i732.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i730);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i730.alpha = 0;
			i732.alpha = 1;
			i734.x = 54.6;
			i734.scaleX = 1;
			i734.y = 50.5;
			i734.scaleY = 1;
			i734.rotation = 0;
			i734.alpha = 0;
			i734.filters = new as3.Array(new object[]{});
			i734.scale9Grid = null;
			i734.visible = true;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.9;
			i734.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.8;
			i734.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.7;
			i734.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.6;
			i734.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.5;
			i734.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.4;
			i734.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.3;
			i734.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.2;
			i734.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i734);
		f += () => {
			i732.alpha = 0.1;
			i734.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i732);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i732.alpha = 0;
			i736.x = 52.5;
			i736.scaleX = 1;
			i736.y = 54.3;
			i736.scaleY = 1;
			i736.rotation = 0;
			i736.alpha = 0;
			i736.filters = new as3.Array(new object[]{});
			i736.scale9Grid = null;
			i736.visible = true;
			i734.alpha = 1;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.1;
			i734.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.2;
			i734.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.3;
			i734.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.4;
			i734.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.5;
			i734.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.6;
			i734.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.7;
			i734.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.8;
			i734.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i736.alpha = 0.9;
			i734.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f.Add(i734);
		f += () => {
			i738.x = 56.8;
			i738.scaleX = 1;
			i738.y = 51.6;
			i738.scaleY = 1;
			i738.rotation = 0;
			i738.alpha = 0;
			i738.filters = new as3.Array(new object[]{});
			i738.scale9Grid = null;
			i738.visible = true;
			i736.alpha = 1;
			i734.alpha = 0;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.1;
			i736.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.2;
			i736.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.3;
			i736.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.4;
			i736.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.5;
			i736.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.6;
			i736.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.7;
			i736.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.8;
			i736.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 0.9;
			i736.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i729);
		f.Add(i738);
		f.Add(i736);
		f += () => {
			i738.alpha = 1;
			i736.alpha = 0;
		};
		setFrames(l);
	}
}
public class StatGiftIcon : BitmapData{ 
	public StatGiftIcon() {
		width = 14;
		height = 16;
		setPixels("c681630b1f8ec865141c6512a623659d");
	}
}
public class StatKissIcon : BitmapData{ 
	public StatKissIcon() {
		width = 20;
		height = 12;
		setPixels("bde604994e05a22c1c8bd7ae67f4ea01");
	}
}
public class StatusArrowView : MovieClip{ 
	public StatusArrowView() {
		var i741 = new symbol_211(){filters = new as3.Array(new object[]{})};
		addChild(i741);//0
	}
}
public class SubscriptionAnnounceClip : MovieClip{ 
	public SubscriptionAnnounceClip() {
		var filter_0 = new BlurFilter(){blurX = 2, blurY = 2};
		var i743 = new symbol_212(){filters = new as3.Array(new object[]{})};
		addChild(i743);//0
		var i744 = new symbol_215(){x = 163 , scaleX = 1 , y = 218.3 , scaleY = 1 , rotation = -150 , filters = new as3.Array(new object[]{})};
		addChild(i744);//1
		var i751 = new symbol_217(){x = 120.4 , scaleX = 1 , y = 105.3 , scaleY = 1 , rotation = -51 , filters = new as3.Array(new object[]{})};
		addChild(i751);//2
		var i753 = new symbol_219(){x = 154.8 , scaleX = 1 , y = 47.5 , scaleY = 1 , rotation = -7 , filters = new as3.Array(new object[]{})};
		addChild(i753);//3
		var i771 = new symbol_231(){x = 6.3 , y = 52.1 , filters = new as3.Array(new object[]{})};
		addChild(i771);//4
		var i782 = new symbol_231(){x = 6.3 , y = 52.1 , filters = new as3.Array(new object[]{})};
		addChild(i782);//4
		var i755 = new symbol_221(){x = 168.3 , scaleX = 1 , y = 242 , scaleY = 1 , rotation = -138 , filters = new as3.Array(new object[]{})};
		addChild(i755);//4
		var i783 = new symbol_239(){x = 5.1 , scaleX = 1 , y = 53.4 , scaleY = 1 , rotation = -2 , filters = new as3.Array(new object[]{})};
		addChild(i783);//4
		var i778 = new symbol_236(){x = 5.1 , scaleX = 1 , y = 53.4 , scaleY = 1 , rotation = -2 , filters = new as3.Array(new object[]{})};
		addChild(i778);//4
		var i780 = new symbol_238(){x = 9.2 , scaleX = 0.36 , y = 63.5 , scaleY = 0.36 , rotation = -28 , alpha = 0 , filters = new as3.Array(new object[]{filter_0})};
		addChild(i780);//5
		var i757 = new symbol_229(){x = 141.1 , scaleX = 1 , y = -6.8 , scaleY = 1 , rotation = 14 , filters = new as3.Array(new object[]{})};
		addChild(i757);//5
		var i765 = new resources_fla.tie_104(){x = 162.9 , scaleX = 1 , y = 72.5 , scaleY = 1 , rotation = -2 , filters = new as3.Array(new object[]{})};
		addChild(i765);//6
		var i772 = new symbol_232(){x = 49.6 , scaleX = 0.75 , y = 113.5 , scaleY = 0.75 , alpha = 0 , filters = new as3.Array(new object[]{})};
		addChild(i772);//7
		var i774 = new symbol_233(){x = 24.6 , scaleX = 0.75 , y = 116.8 , scaleY = 0.75 , alpha = 0 , filters = new as3.Array(new object[]{})};
		addChild(i774);//8
		var i785 = new symbol_240(){x = 37.6 , scaleX = 0.68 , y = 116 , scaleY = 0.68 , filters = new as3.Array(new object[]{})};
		addChild(i785);//8
		var i776 = new symbol_235(){x = -68 , scaleX = 0.9 , y = 89 , scaleY = 0.9 , alpha = 0 , filters = new as3.Array(new object[]{})};
		addChild(i776);//9
		var i787 = new symbol_242(){x = 15.7 , scaleX = 1.26 , y = 119 , scaleY = 1.26 , filters = new as3.Array(new object[]{})};
		addChild(i787);//9
		var i789 = new symbol_244(){x = -75.8 , y = 83.8 , filters = new as3.Array(new object[]{})};
		addChild(i789);//10
		FrameInfo f;
		var l= new Frames(196);
		f = l.Add();
		f.Add(i743);
		f += () => {
			i743.x = 0;
			i743.scaleX = 1;
			i743.y = 0;
			i743.scaleY = 1;
			i743.rotation = 0;
			i743.alpha = 1;
			i743.filters = new as3.Array(new object[]{});
			i743.scale9Grid = null;
			i743.visible = true;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 163;
			i744.scaleX = 1;
			i744.y = 218.3;
			i744.scaleY = 1;
			i744.rotation = -150;
			i744.alpha = 1;
			i744.filters = new as3.Array(new object[]{});
			i744.scale9Grid = null;
			i744.visible = true;
			i751.x = 120.4;
			i751.scaleX = 1;
			i751.y = 105.3;
			i751.scaleY = 1;
			i751.rotation = -51;
			i751.alpha = 1;
			i751.filters = new as3.Array(new object[]{});
			i751.scale9Grid = null;
			i751.visible = true;
			i753.x = 154.8;
			i753.scaleX = 1;
			i753.y = 47.5;
			i753.scaleY = 1;
			i753.rotation = -7;
			i753.alpha = 1;
			i753.filters = new as3.Array(new object[]{});
			i753.scale9Grid = null;
			i753.visible = true;
			i755.x = 168.3;
			i755.scaleX = 1;
			i755.y = 242;
			i755.scaleY = 1;
			i755.rotation = -138;
			i755.alpha = 1;
			i755.filters = new as3.Array(new object[]{});
			i755.scale9Grid = null;
			i755.visible = true;
			i757.x = 141.1;
			i757.scaleX = 1;
			i757.y = -6.8;
			i757.scaleY = 1;
			i757.rotation = 14;
			i757.alpha = 1;
			i757.filters = new as3.Array(new object[]{});
			i757.scale9Grid = null;
			i757.visible = true;
			i765.x = 162.9;
			i765.scaleX = 1;
			i765.y = 72.5;
			i765.scaleY = 1;
			i765.rotation = -2;
			i765.alpha = 1;
			i765.filters = new as3.Array(new object[]{});
			i765.scale9Grid = null;
			i765.visible = true;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 156.9;
			i744.y = 217.8;
			i744.rotation = -146;
			i751.x = 118.5;
			i751.y = 105;
			i753.x = 153.3;
			i753.y = 47.9;
			i753.rotation = -8;
			i755.x = 161.4;
			i755.y = 242.1;
			i755.rotation = -136;
			i757.x = 138.9;
			i757.y = -6.2;
			i757.rotation = 13;
			i765.x = 161.5;
			i765.y = 72.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 151.1;
			i744.y = 217.1;
			i744.rotation = -143;
			i751.x = 116.7;
			i751.y = 104.7;
			i751.rotation = -50;
			i753.x = 151.7;
			i753.y = 48.3;
			i755.x = 154.6;
			i755.rotation = -133;
			i757.x = 136.8;
			i757.y = -5.7;
			i765.x = 160.2;
			i765.y = 73.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 144.9;
			i744.y = 216.3;
			i744.rotation = -139;
			i751.x = 114.8;
			i751.y = 104.5;
			i751.rotation = -49;
			i753.x = 150.2;
			i753.y = 48.5;
			i755.x = 147.5;
			i755.y = 241.7;
			i755.rotation = -130;
			i757.x = 134.7;
			i757.y = -5;
			i757.rotation = 12;
			i765.x = 158.8;
			i765.y = 73.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 138.8;
			i744.y = 215.3;
			i744.rotation = -136;
			i751.x = 113;
			i751.y = 104.2;
			i751.rotation = -48;
			i753.x = 148.6;
			i753.y = 48.9;
			i753.rotation = -9;
			i755.x = 140.6;
			i755.y = 241.1;
			i755.rotation = -128;
			i757.x = 132.6;
			i757.y = -4.5;
			i765.x = 157.5;
			i765.y = 73.7;
			i765.rotation = -1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 132.8;
			i744.y = 214.3;
			i744.rotation = -133;
			i751.x = 111.3;
			i751.y = 103.9;
			i751.rotation = -47;
			i753.x = 146.9;
			i753.y = 49.4;
			i755.x = 134;
			i755.y = 240.4;
			i755.rotation = -125;
			i757.x = 130.8;
			i757.y = -4;
			i757.rotation = 11;
			i765.x = 156.2;
			i765.y = 74;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 126.7;
			i744.y = 213.1;
			i744.rotation = -129;
			i751.x = 109.5;
			i751.y = 103.7;
			i751.rotation = -46;
			i753.x = 145.4;
			i753.y = 49.6;
			i753.rotation = -10;
			i755.x = 127.1;
			i755.y = 239.3;
			i755.rotation = -122;
			i757.x = 128.6;
			i757.y = -3.5;
			i765.x = 154.8;
			i765.y = 74.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 120.7;
			i744.y = 211.8;
			i744.rotation = -126;
			i751.x = 107.7;
			i751.y = 103.3;
			i751.rotation = -45;
			i753.x = 143.8;
			i753.y = 50;
			i755.x = 120.3;
			i755.y = 238;
			i755.rotation = -120;
			i757.x = 126.6;
			i757.y = -2.9;
			i757.rotation = 10;
			i765.x = 153.5;
			i765.y = 74.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 114.6;
			i744.y = 210.4;
			i744.rotation = -122;
			i751.x = 106.1;
			i751.y = 103.1;
			i753.x = 142.3;
			i753.y = 50.5;
			i753.rotation = -11;
			i755.x = 113.5;
			i755.y = 236.4;
			i755.rotation = -117;
			i757.x = 124.6;
			i757.y = -2.4;
			i765.x = 152.2;
			i765.y = 74.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 108.7;
			i744.y = 208.8;
			i744.rotation = -119;
			i751.x = 104.5;
			i751.y = 102.8;
			i751.rotation = -44;
			i753.x = 140.9;
			i753.y = 50.8;
			i755.x = 107.2;
			i755.y = 234.8;
			i755.rotation = -114;
			i757.x = 122.8;
			i757.y = -1.9;
			i765.x = 150.8;
			i765.y = 75;
			i765.rotation = 0;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 102.7;
			i744.y = 207.2;
			i744.rotation = -116;
			i751.x = 102.9;
			i751.y = 102.5;
			i751.rotation = -43;
			i753.x = 139.4;
			i753.y = 51.2;
			i755.x = 100.7;
			i755.y = 232.8;
			i755.rotation = -112;
			i757.x = 120.8;
			i757.y = -1.4;
			i757.rotation = 9;
			i765.x = 149.6;
			i765.y = 75.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 97;
			i744.y = 205.3;
			i744.rotation = -112;
			i751.x = 101.3;
			i751.y = 102.3;
			i751.rotation = -42;
			i753.x = 137.9;
			i753.y = 51.4;
			i753.rotation = -12;
			i755.x = 94.3;
			i755.y = 230.4;
			i755.rotation = -109;
			i757.x = 118.9;
			i757.y = -0.8;
			i765.x = 148.3;
			i765.y = 75.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 93.6;
			i744.y = 203.2;
			i751.x = 99.7;
			i751.y = 101.8;
			i751.rotation = -41;
			i753.x = 136.5;
			i753.y = 51.9;
			i755.x = 88.2;
			i755.y = 228.1;
			i755.rotation = -106;
			i757.x = 117.2;
			i757.y = -0.4;
			i757.rotation = 8;
			i765.x = 147.2;
			i765.y = 75.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 90.3;
			i744.y = 201.1;
			i751.x = 98.2;
			i751.y = 101.6;
			i753.x = 135.2;
			i753.y = 52.1;
			i755.x = 82.1;
			i755.y = 225.3;
			i755.rotation = -104;
			i757.x = 115.2;
			i757.y = 0.1;
			i765.x = 145.9;
			i765.y = 76;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 86.8;
			i744.y = 199;
			i751.x = 96.7;
			i751.y = 101.3;
			i751.rotation = -40;
			i753.x = 133.7;
			i753.y = 52.5;
			i753.rotation = -13;
			i755.x = 76;
			i755.y = 222.4;
			i755.rotation = -101;
			i757.x = 113.5;
			i757.y = 0.6;
			i765.x = 144.7;
			i765.y = 76.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 83.5;
			i744.y = 196.9;
			i751.x = 95.3;
			i751.y = 101.2;
			i751.rotation = -39;
			i753.x = 132.3;
			i753.y = 52.8;
			i755.x = 70;
			i755.y = 219.3;
			i755.rotation = -98;
			i757.x = 111.7;
			i757.y = 1.1;
			i757.rotation = 7;
			i765.x = 143.4;
			i765.y = 76.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 80.1;
			i744.y = 194.8;
			i751.x = 93.8;
			i751.y = 100.8;
			i753.x = 130.9;
			i753.y = 53.2;
			i753.rotation = -14;
			i755.x = 64.6;
			i755.y = 216.1;
			i755.rotation = -96;
			i757.x = 110.1;
			i757.y = 1.6;
			i765.x = 142.3;
			i765.y = 76.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 76.8;
			i744.y = 192.8;
			i751.x = 92.3;
			i751.y = 100.5;
			i751.rotation = -38;
			i753.x = 129.7;
			i753.y = 53.5;
			i755.x = 59;
			i755.y = 212.6;
			i755.rotation = -93;
			i757.x = 108.3;
			i757.y = 2;
			i757.rotation = 6;
			i765.x = 141.1;
			i765.y = 77;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 73.3;
			i744.y = 190.7;
			i751.x = 91;
			i751.y = 100.3;
			i751.rotation = -37;
			i753.x = 128.2;
			i753.y = 54;
			i755.x = 53.6;
			i755.y = 208.8;
			i755.rotation = -90;
			i757.x = 106.7;
			i757.y = 2.5;
			i765.x = 139.9;
			i765.y = 77.2;
			i765.rotation = 1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 68.3;
			i744.y = 187.2;
			i744.rotation = -107;
			i751.x = 89.8;
			i751.y = 100;
			i751.rotation = -36;
			i753.x = 127;
			i753.y = 54.2;
			i753.rotation = -15;
			i755.x = 48.7;
			i755.y = 205.1;
			i755.rotation = -87;
			i757.x = 104.9;
			i757.y = 3;
			i765.x = 138.8;
			i765.y = 77.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 63.5;
			i744.y = 183.6;
			i744.rotation = -103;
			i751.x = 88.3;
			i751.y = 99.6;
			i753.x = 125.6;
			i753.y = 54.6;
			i755.x = 43.9;
			i755.y = 201.3;
			i755.rotation = -85;
			i757.x = 103.4;
			i757.y = 3.5;
			i757.rotation = 5;
			i765.x = 137.6;
			i765.y = 77.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 58.8;
			i744.y = 179.7;
			i744.rotation = -98;
			i751.x = 87;
			i751.y = 99.4;
			i751.rotation = -35;
			i753.x = 124.3;
			i753.y = 54.9;
			i755.x = 39.1;
			i755.y = 197.1;
			i755.rotation = -82;
			i757.x = 101.7;
			i757.y = 4;
			i765.x = 136.4;
			i765.y = 77.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 54.3;
			i744.y = 175.7;
			i744.rotation = -93;
			i751.x = 85.8;
			i751.y = 99;
			i751.rotation = -34;
			i753.x = 123.1;
			i753.y = 55;
			i753.rotation = -16;
			i755.x = 34.5;
			i755.y = 192.7;
			i755.rotation = -79;
			i757.x = 100.3;
			i757.y = 4.4;
			i765.x = 135.4;
			i765.y = 78.1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 50;
			i744.y = 171.5;
			i744.rotation = -88;
			i751.x = 84.6;
			i753.x = 121.8;
			i753.y = 55.5;
			i755.x = 30.1;
			i755.y = 188.1;
			i755.rotation = -77;
			i757.x = 98.6;
			i757.y = 5;
			i757.rotation = 4;
			i765.x = 134.3;
			i765.y = 78.3;
			i765.rotation = 2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 45.8;
			i744.y = 167;
			i744.rotation = -83;
			i751.x = 83.3;
			i751.y = 98.6;
			i751.rotation = -33;
			i753.x = 120.5;
			i753.y = 55.8;
			i755.x = 26.1;
			i755.y = 183.8;
			i755.rotation = -74;
			i757.x = 97;
			i757.y = 5.3;
			i765.x = 133.1;
			i765.y = 78.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 41.8;
			i744.y = 162.4;
			i744.rotation = -79;
			i751.x = 82.2;
			i751.y = 98.3;
			i751.rotation = -32;
			i753.x = 119.3;
			i753.y = 56.2;
			i753.rotation = -17;
			i755.x = 22.2;
			i755.y = 178.9;
			i755.rotation = -71;
			i757.x = 95.6;
			i757.y = 5.7;
			i765.x = 132.1;
			i765.y = 78.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 37.9;
			i744.y = 157.8;
			i744.rotation = -74;
			i751.x = 81;
			i751.y = 98.1;
			i753.x = 118.1;
			i753.y = 56.5;
			i755.x = 18.6;
			i755.y = 174;
			i755.rotation = -69;
			i757.x = 94.3;
			i757.y = 6.1;
			i757.rotation = 3;
			i765.x = 131.1;
			i765.y = 79;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 35.7;
			i744.y = 153.3;
			i744.rotation = -70;
			i751.x = 80;
			i751.y = 97.9;
			i751.rotation = -31;
			i753.x = 116.9;
			i753.y = 56.7;
			i755.x = 15.2;
			i755.y = 168.9;
			i755.rotation = -66;
			i757.x = 92.7;
			i757.y = 6.5;
			i765.x = 129.9;
			i765.y = 79.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 33.6;
			i744.y = 148.8;
			i744.rotation = -67;
			i751.x = 78.8;
			i751.y = 97.6;
			i753.x = 115.7;
			i753.y = 57.2;
			i753.rotation = -18;
			i755.x = 12.1;
			i755.y = 164.2;
			i755.rotation = -63;
			i757.x = 91.3;
			i757.y = 7;
			i765.x = 128.8;
			i765.y = 79.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 31.7;
			i744.y = 144.2;
			i744.rotation = -64;
			i751.x = 77.8;
			i751.y = 97.5;
			i751.rotation = -30;
			i753.x = 114.6;
			i753.y = 57.4;
			i755.x = 9.1;
			i755.y = 159;
			i755.rotation = -61;
			i757.x = 90;
			i757.y = 7.4;
			i757.rotation = 2;
			i765.x = 127.8;
			i765.y = 79.7;
			i765.rotation = 3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 29.8;
			i744.y = 139.6;
			i744.rotation = -60;
			i751.x = 76.8;
			i751.y = 97.2;
			i753.x = 113.5;
			i753.y = 57.6;
			i755.x = 6.3;
			i755.y = 153.8;
			i755.rotation = -58;
			i757.x = 88.6;
			i757.y = 7.8;
			i765.x = 126.8;
			i765.y = 79.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 28.1;
			i744.y = 135;
			i744.rotation = -57;
			i751.x = 75.7;
			i751.y = 96.8;
			i751.rotation = -29;
			i753.x = 112.3;
			i753.y = 57.9;
			i753.rotation = -19;
			i755.x = 3.9;
			i755.y = 148.5;
			i755.rotation = -55;
			i757.x = 87.2;
			i757.y = 8.2;
			i765.x = 125.8;
			i765.y = 80;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 26.6;
			i744.y = 130.3;
			i744.rotation = -53;
			i751.x = 74.7;
			i751.y = 96.5;
			i751.rotation = -28;
			i753.x = 111.2;
			i753.y = 58.4;
			i755.x = 1.8;
			i755.y = 143.6;
			i755.rotation = -53;
			i757.x = 85.9;
			i757.y = 8.6;
			i757.rotation = 1;
			i765.x = 124.8;
			i765.y = 80.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 25.1;
			i744.y = 125.5;
			i744.rotation = -50;
			i751.x = 73.7;
			i751.y = 96.3;
			i753.x = 110;
			i753.y = 58.6;
			i755.x = -0.2;
			i755.y = 138.1;
			i755.rotation = -50;
			i757.x = 84.7;
			i757.y = 8.9;
			i765.x = 123.8;
			i765.y = 80.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 23.8;
			i744.y = 121;
			i744.rotation = -47;
			i751.x = 72.7;
			i751.y = 96.1;
			i751.rotation = -27;
			i753.x = 109;
			i753.y = 58.9;
			i753.rotation = -20;
			i755.x = -1.9;
			i755.y = 132.7;
			i755.rotation = -47;
			i757.x = 83.5;
			i757.y = 9.3;
			i765.x = 123;
			i765.y = 80.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 22.6;
			i744.y = 116.2;
			i744.rotation = -43;
			i751.x = 71.8;
			i751.y = 96;
			i753.x = 108;
			i753.y = 59;
			i755.x = -3.3;
			i755.y = 127.8;
			i755.rotation = -45;
			i757.x = 82.3;
			i757.y = 9.7;
			i765.x = 122;
			i765.y = 80.8;
			i765.rotation = 4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 21.5;
			i744.y = 111.5;
			i744.rotation = -40;
			i751.x = 70.9;
			i751.y = 95.8;
			i751.rotation = -26;
			i753.x = 106.9;
			i753.y = 59.4;
			i755.x = -4.5;
			i755.y = 122.4;
			i755.rotation = -42;
			i757.x = 81;
			i757.y = 10.1;
			i757.rotation = 0;
			i765.x = 121;
			i765.y = 81;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 20.6;
			i744.y = 106.8;
			i744.rotation = -36;
			i751.x = 70;
			i751.y = 95.5;
			i753.x = 105.8;
			i753.y = 59.8;
			i753.rotation = -21;
			i755.x = -5.4;
			i755.y = 117;
			i755.rotation = -39;
			i757.x = 79.8;
			i757.y = 10.4;
			i765.x = 120;
			i765.y = 81.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 19.6;
			i744.y = 102.2;
			i744.rotation = -33;
			i751.x = 69.2;
			i751.y = 95.3;
			i751.rotation = -25;
			i753.x = 104.8;
			i753.y = 60;
			i755.x = -6.1;
			i755.y = 111.8;
			i755.rotation = -36;
			i757.x = 78.8;
			i757.y = 10.8;
			i765.x = 119.2;
			i765.y = 81.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 20.1;
			i744.y = 99;
			i744.rotation = -31;
			i751.x = 68.4;
			i751.y = 95;
			i753.x = 103.8;
			i753.y = 60.3;
			i755.x = -6.6;
			i755.y = 106.8;
			i755.rotation = -34;
			i757.x = 77.5;
			i757.y = 11.1;
			i765.x = 118.3;
			i765.y = 81.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 20.7;
			i744.y = 95.9;
			i744.rotation = -29;
			i751.x = 67.5;
			i751.y = 94.9;
			i751.rotation = -24;
			i753.x = 102.8;
			i753.y = 60.6;
			i755.x = -6.7;
			i755.y = 101.6;
			i755.rotation = -31;
			i757.x = 76.5;
			i757.y = 11.3;
			i765.x = 117.3;
			i765.y = 81.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 21.3;
			i744.y = 92.8;
			i744.rotation = -27;
			i751.x = 66.7;
			i751.y = 94.7;
			i753.x = 101.9;
			i753.y = 60.8;
			i753.rotation = -22;
			i755.x = -6.6;
			i755.y = 96.4;
			i755.rotation = -28;
			i757.x = 75.4;
			i757.y = 11.7;
			i765.x = 116.5;
			i765.y = 81.9;
			i765.rotation = 5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 21.9;
			i744.y = 89.6;
			i744.rotation = -25;
			i751.x = 65.7;
			i751.y = 94.4;
			i751.rotation = -23;
			i753.x = 101;
			i753.y = 61;
			i755.x = -6.3;
			i755.y = 91.3;
			i755.rotation = -26;
			i757.x = 74.2;
			i757.y = 12.1;
			i765.x = 115.6;
			i765.y = 82.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 22.5;
			i744.y = 86.7;
			i744.rotation = -23;
			i751.x = 64.9;
			i751.y = 94.2;
			i753.x = 100;
			i753.y = 61.3;
			i755.x = -5.8;
			i755.y = 86.7;
			i755.rotation = -23;
			i757.x = 73;
			i757.y = 12.4;
			i765.x = 114.8;
			i765.y = 82.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 23.1;
			i744.y = 83.6;
			i744.rotation = -21;
			i751.x = 64;
			i751.y = 94;
			i751.rotation = -22;
			i753.x = 99;
			i753.y = 61.5;
			i755.x = -5;
			i755.y = 81.8;
			i755.rotation = -20;
			i757.x = 72;
			i757.y = 12.7;
			i757.rotation = -1;
			i765.x = 113.9;
			i765.y = 82.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 23.9;
			i744.y = 80.5;
			i744.rotation = -19;
			i751.x = 63.1;
			i751.y = 93.8;
			i753.x = 98.1;
			i753.y = 61.8;
			i753.rotation = -23;
			i755.x = -4;
			i755.y = 77;
			i755.rotation = -18;
			i757.x = 70.8;
			i757.y = 13.1;
			i765.x = 113;
			i765.y = 82.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 24.6;
			i744.y = 77.4;
			i744.rotation = -17;
			i751.x = 62.4;
			i751.y = 93.5;
			i751.rotation = -21;
			i753.x = 97.3;
			i753.y = 62.1;
			i755.x = -2.6;
			i755.y = 72.4;
			i755.rotation = -15;
			i757.x = 69.7;
			i757.y = 13.4;
			i765.x = 112.2;
			i765.y = 82.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 25.5;
			i744.y = 74.5;
			i744.rotation = -15;
			i751.x = 61.5;
			i751.y = 93.3;
			i753.x = 96.3;
			i753.y = 62.4;
			i755.x = -1.4;
			i755.y = 68.2;
			i755.rotation = -12;
			i757.x = 68.5;
			i757.y = 13.8;
			i765.x = 111.5;
			i765.y = 83;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 26.3;
			i744.y = 71.5;
			i744.rotation = -13;
			i751.x = 60.7;
			i751.y = 93.2;
			i751.rotation = -20;
			i753.x = 95.5;
			i753.y = 62.5;
			i755.x = 0.4;
			i755.y = 63.8;
			i755.rotation = -10;
			i757.x = 67.3;
			i757.y = 14.2;
			i757.rotation = -2;
			i765.x = 110.7;
			i765.y = 83.1;
			i765.rotation = 6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 27.2;
			i744.y = 68.5;
			i744.rotation = -11;
			i751.x = 59.8;
			i751.y = 92.8;
			i753.x = 94.7;
			i753.y = 62.8;
			i753.rotation = -24;
			i755.x = 2.3;
			i755.y = 59.6;
			i755.rotation = -7;
			i757.x = 66.2;
			i757.y = 14.6;
			i765.x = 109.8;
			i765.y = 83.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i755);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 28.1;
			i744.y = 65.5;
			i744.rotation = -9;
			i751.x = 59;
			i751.y = 92.7;
			i751.rotation = -19;
			i753.x = 93.8;
			i753.y = 63;
			i755.x = 4.4;
			i755.y = 55.6;
			i755.rotation = -4;
			i757.x = 65;
			i757.y = 14.9;
			i765.x = 109.2;
			i765.y = 83.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f += () => {
			i744.x = 29;
			i744.y = 62.7;
			i744.rotation = -7;
			i751.x = 58;
			i751.y = 92.5;
			i753.x = 92.8;
			i753.y = 63.3;
			i771.x = 6.3;
			i771.scaleX = 1;
			i771.y = 52.1;
			i771.scaleY = 1;
			i771.rotation = 0;
			i771.alpha = 1;
			i771.filters = new as3.Array(new object[]{});
			i771.scale9Grid = null;
			i771.visible = true;
			i757.x = 63.9;
			i757.y = 15.3;
			i765.x = 108.4;
			i772.x = 49.6;
			i772.scaleX = 0.75;
			i772.y = 113.5;
			i772.scaleY = 0.75;
			i772.rotation = 0;
			i772.alpha = 0;
			i772.filters = new as3.Array(new object[]{});
			i772.scale9Grid = null;
			i772.visible = true;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f += () => {
			i744.x = 28.7;
			i744.y = 62.6;
			i744.rotation = -6;
			i771.x = 6.7;
			i771.y = 51.8;
			i771.rotation = -1;
			i772.x = 47.7;
			i772.scaleX = 0.74;
			i772.y = 113.9;
			i772.scaleY = 0.74;
			i772.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f += () => {
			i744.x = 29.4;
			i744.y = 62.2;
			i744.rotation = -5;
			i771.x = 7;
			i771.y = 51.4;
			i757.x = 63.8;
			i757.y = 15.5;
			i757.rotation = -3;
			i772.x = 46;
			i772.scaleX = 0.73;
			i772.y = 114.3;
			i772.scaleY = 0.73;
			i772.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f += () => {
			i744.x = 30.1;
			i744.y = 61.8;
			i771.x = 7.4;
			i771.y = 51;
			i757.x = 63.5;
			i757.y = 15.9;
			i772.x = 44.4;
			i772.scaleX = 0.72;
			i772.y = 114.6;
			i772.scaleY = 0.72;
			i772.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f += () => {
			i744.x = 30.7;
			i744.y = 61.3;
			i744.rotation = -4;
			i771.x = 7.7;
			i771.y = 50.7;
			i757.x = 63.3;
			i757.y = 16.1;
			i772.x = 43;
			i772.scaleX = 0.71;
			i772.y = 114.9;
			i772.scaleY = 0.71;
			i772.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f += () => {
			i744.x = 31.4;
			i744.y = 61;
			i771.x = 8.1;
			i771.y = 50.4;
			i771.rotation = 0;
			i757.x = 63.1;
			i757.y = 16.4;
			i772.x = 41.7;
			i772.scaleX = 0.7;
			i772.y = 115.2;
			i772.scaleY = 0.7;
			i772.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f += () => {
			i744.x = 32;
			i744.y = 60.4;
			i744.rotation = -3;
			i771.x = 8.5;
			i771.y = 50;
			i757.x = 62.9;
			i757.y = 16.8;
			i757.rotation = -4;
			i772.x = 40.6;
			i772.y = 115.4;
			i772.alpha = 0.8;
			i774.x = 24.6;
			i774.scaleX = 0.75;
			i774.y = 116.8;
			i774.scaleY = 0.75;
			i774.rotation = 0;
			i774.alpha = 0;
			i774.filters = new as3.Array(new object[]{});
			i774.scale9Grid = null;
			i774.visible = true;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f += () => {
			i744.x = 32.7;
			i744.y = 60;
			i744.rotation = -2;
			i771.x = 8.9;
			i771.y = 49.7;
			i757.x = 62.6;
			i757.y = 17;
			i772.x = 39.8;
			i772.scaleX = 0.69;
			i772.y = 115.5;
			i772.scaleY = 0.69;
			i774.x = 23.2;
			i774.scaleX = 0.83;
			i774.y = 117.1;
			i774.scaleY = 0.83;
			i774.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f += () => {
			i744.x = 33.4;
			i744.y = 59.6;
			i771.x = 9.2;
			i771.y = 49.3;
			i757.x = 62.5;
			i757.y = 17.4;
			i772.x = 39;
			i772.y = 115.7;
			i772.alpha = 0.9;
			i774.x = 21.9;
			i774.scaleX = 0.91;
			i774.y = 117.5;
			i774.scaleY = 0.91;
			i774.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f += () => {
			i744.x = 34;
			i744.y = 59.3;
			i744.rotation = -1;
			i771.x = 9.3;
			i757.x = 62.3;
			i757.y = 17.6;
			i772.x = 38.4;
			i772.scaleX = 0.68;
			i772.y = 115.8;
			i772.scaleY = 0.68;
			i774.x = 20.7;
			i774.scaleX = 0.97;
			i774.y = 117.8;
			i774.scaleY = 0.97;
			i774.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f += () => {
			i744.x = 34.1;
			i744.y = 59.1;
			i771.x = 9.7;
			i771.y = 48.9;
			i757.x = 62;
			i757.y = 18;
			i757.rotation = -5;
			i772.x = 38;
			i772.y = 116;
			i772.alpha = 1;
			i774.x = 19.6;
			i774.scaleX = 1.03;
			i774.y = 118;
			i774.scaleY = 1.03;
			i774.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f += () => {
			i744.x = 34.4;
			i744.y = 58.9;
			i744.rotation = 0;
			i771.x = 10.2;
			i771.y = 48.5;
			i757.x = 61.9;
			i757.y = 18.3;
			i772.x = 37.8;
			i774.x = 18.7;
			i774.scaleX = 1.08;
			i774.y = 118.3;
			i774.scaleY = 1.08;
			i774.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i771.x = 9.4;
			i771.y = 49.2;
			i757.x = 61.6;
			i757.y = 18.6;
			i772.x = 37.6;
			i774.x = 17.9;
			i774.scaleX = 1.13;
			i774.y = 118.5;
			i774.scaleY = 1.13;
			i774.alpha = 0.8;
			i776.x = -68;
			i776.scaleX = 0.9;
			i776.y = 89;
			i776.scaleY = 0.9;
			i776.rotation = 0;
			i776.alpha = 0;
			i776.filters = new as3.Array(new object[]{});
			i776.scale9Grid = null;
			i776.visible = true;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 34.5;
			i744.rotation = 1;
			i771.x = 8.9;
			i771.y = 49.6;
			i757.x = 61.9;
			i757.y = 18.3;
			i774.x = 17.2;
			i774.scaleX = 1.17;
			i774.y = 118.7;
			i774.scaleY = 1.17;
			i776.x = -68.9;
			i776.scaleX = 0.91;
			i776.y = 88.3;
			i776.scaleY = 0.91;
			i776.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 34.9;
			i744.y = 58.7;
			i744.rotation = 2;
			i771.x = 8.5;
			i771.y = 50;
			i757.x = 62.1;
			i757.y = 17.9;
			i774.x = 16.6;
			i774.scaleX = 1.2;
			i774.y = 118.8;
			i774.scaleY = 1.2;
			i774.alpha = 0.9;
			i776.x = -69.7;
			i776.scaleX = 0.92;
			i776.y = 87.8;
			i776.scaleY = 0.92;
			i776.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 35;
			i744.y = 58.5;
			i744.rotation = 3;
			i771.x = 7.8;
			i771.y = 50.8;
			i771.rotation = -1;
			i774.x = 16.2;
			i774.scaleX = 1.23;
			i774.y = 118.9;
			i774.scaleY = 1.23;
			i776.x = -70.5;
			i776.scaleX = 0.93;
			i776.y = 87.3;
			i776.scaleY = 0.93;
			i776.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 35.3;
			i744.y = 58.4;
			i744.rotation = 4;
			i771.x = 7.2;
			i771.y = 51.4;
			i757.x = 62.4;
			i757.y = 17.6;
			i757.rotation = -4;
			i774.x = 15.9;
			i774.scaleX = 1.24;
			i774.y = 119;
			i774.scaleY = 1.24;
			i774.alpha = 1;
			i776.x = -71.2;
			i776.scaleX = 0.94;
			i776.y = 86.8;
			i776.scaleY = 0.94;
			i776.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 35.5;
			i744.y = 58.3;
			i744.rotation = 5;
			i771.x = 6.5;
			i771.y = 52.1;
			i771.rotation = -2;
			i757.x = 62.5;
			i757.y = 17.3;
			i774.x = 15.7;
			i774.scaleX = 1.25;
			i774.scaleY = 1.25;
			i776.x = -72;
			i776.scaleX = 0.95;
			i776.y = 86.3;
			i776.scaleY = 0.95;
			i776.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i771);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 35.9;
			i744.y = 58.2;
			i744.rotation = 6;
			i771.x = 6;
			i771.y = 52.5;
			i757.x = 62.8;
			i757.y = 17.1;
			i774.scaleX = 1.26;
			i774.scaleY = 1.26;
			i776.x = -72.5;
			i776.scaleX = 0.96;
			i776.y = 86;
			i776.scaleY = 0.96;
			i776.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 36.1;
			i744.y = 58;
			i744.rotation = 7;
			i778.x = 5.1;
			i778.scaleX = 1;
			i778.y = 53.4;
			i778.scaleY = 1;
			i778.rotation = -2;
			i778.alpha = 1;
			i778.filters = new as3.Array(new object[]{});
			i778.scale9Grid = null;
			i778.visible = true;
			i757.x = 63;
			i757.y = 16.7;
			i776.x = -73;
			i776.scaleX = 0.97;
			i776.y = 85.5;
			i776.scaleY = 0.97;
			i776.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 36.4;
			i744.y = 57.9;
			i744.rotation = 8;
			i757.x = 63.1;
			i757.y = 16.4;
			i757.rotation = -3;
			i776.x = -73.6;
			i776.y = 85.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 36.8;
			i744.y = 58;
			i744.rotation = 10;
			i757.x = 63.4;
			i757.y = 16.1;
			i776.x = -74;
			i776.scaleX = 0.98;
			i776.y = 84.9;
			i776.scaleY = 0.98;
			i776.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 37.3;
			i744.y = 57.6;
			i744.rotation = 11;
			i776.x = -74.5;
			i776.y = 84.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 35;
			i744.y = 58.9;
			i744.rotation = 7;
			i757.x = 63.6;
			i757.y = 15.8;
			i776.x = -74.8;
			i776.scaleX = 0.99;
			i776.y = 84.4;
			i776.scaleY = 0.99;
			i776.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 32.8;
			i744.y = 60.3;
			i744.rotation = 2;
			i757.x = 63.9;
			i757.y = 15.5;
			i776.x = -75.1;
			i776.y = 84.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 30.9;
			i744.y = 61.8;
			i744.rotation = -2;
			i757.y = 15.3;
			i757.rotation = -2;
			i776.x = -75.3;
			i776.y = 84;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 29.1;
			i744.y = 63.5;
			i744.rotation = -6;
			i776.x = -75.5;
			i776.scaleX = 1;
			i776.y = 83.9;
			i776.scaleY = 1;
			i776.alpha = 1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 27.4;
			i744.y = 65.3;
			i744.rotation = -11;
			i776.x = -75.7;
			i776.y = 83.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 25.9;
			i744.y = 67.5;
			i744.rotation = -15;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i776.x = -75.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 9.2;
			i780.scaleX = 0.36;
			i780.y = 63.5;
			i780.scaleY = 0.36;
			i780.rotation = -28;
			i780.alpha = 0;
			i780.filters = new as3.Array(new object[]{filter_0});
			i780.scale9Grid = null;
			i780.visible = true;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 10.6;
			i780.scaleX = 0.39;
			i780.scaleY = 0.39;
			i780.rotation = -31;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 11.9;
			i780.scaleX = 0.42;
			i780.y = 63.4;
			i780.scaleY = 0.42;
			i780.rotation = -34;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 13.4;
			i780.scaleX = 0.45;
			i780.y = 63.2;
			i780.scaleY = 0.45;
			i780.rotation = -38;
			i780.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 14.8;
			i780.scaleX = 0.48;
			i780.scaleY = 0.48;
			i780.rotation = -41;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 16.5;
			i780.scaleX = 0.52;
			i780.y = 63;
			i780.scaleY = 0.52;
			i780.rotation = -44;
			i780.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 18.1;
			i780.scaleX = 0.56;
			i780.scaleY = 0.56;
			i780.rotation = -48;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 20;
			i780.scaleX = 0.6;
			i780.y = 62.9;
			i780.scaleY = 0.6;
			i780.rotation = -52;
			i780.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 21.7;
			i780.scaleX = 0.64;
			i780.y = 62.7;
			i780.scaleY = 0.64;
			i780.rotation = -56;
			i780.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 23.6;
			i780.scaleX = 0.68;
			i780.y = 62.6;
			i780.scaleY = 0.68;
			i780.rotation = -60;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 25.6;
			i780.scaleX = 0.72;
			i780.y = 62.4;
			i780.scaleY = 0.72;
			i780.rotation = -64;
			i780.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 27.8;
			i780.scaleX = 0.77;
			i780.y = 62.3;
			i780.scaleY = 0.77;
			i780.rotation = -69;
			i780.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 29.8;
			i780.scaleX = 0.81;
			i780.y = 62.1;
			i780.scaleY = 0.81;
			i780.rotation = -74;
			i780.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 32;
			i780.scaleX = 0.86;
			i780.y = 62;
			i780.scaleY = 0.86;
			i780.rotation = -78;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 34.3;
			i780.scaleX = 0.91;
			i780.y = 61.8;
			i780.scaleY = 0.91;
			i780.rotation = -83;
			i780.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 36.6;
			i780.scaleX = 0.96;
			i780.y = 61.6;
			i780.scaleY = 0.96;
			i780.rotation = -88;
			i780.alpha = 1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 36.7;
			i780.scaleX = 0.9;
			i780.y = 62;
			i780.scaleY = 0.9;
			i780.rotation = -99;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 36.8;
			i780.scaleX = 0.87;
			i780.y = 62.2;
			i780.scaleY = 0.87;
			i780.rotation = -104;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.scaleX = 0.84;
			i780.y = 62.4;
			i780.scaleY = 0.84;
			i780.rotation = -109;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.scaleX = 0.81;
			i780.y = 62.6;
			i780.scaleY = 0.81;
			i780.rotation = -114;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 36.9;
			i780.scaleX = 0.79;
			i780.y = 62.8;
			i780.scaleY = 0.79;
			i780.rotation = -119;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.scaleX = 0.76;
			i780.y = 62.9;
			i780.scaleY = 0.76;
			i780.rotation = -124;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 37;
			i780.scaleX = 0.73;
			i780.y = 63.1;
			i780.scaleY = 0.73;
			i780.rotation = -129;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.scaleX = 0.7;
			i780.y = 63.3;
			i780.scaleY = 0.7;
			i780.rotation = -134;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.scaleX = 0.67;
			i780.y = 63.5;
			i780.scaleY = 0.67;
			i780.rotation = -139;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.scaleX = 0.64;
			i780.y = 63.6;
			i780.scaleY = 0.64;
			i780.rotation = -144;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 37.1;
			i780.scaleX = 0.62;
			i780.y = 63.8;
			i780.scaleY = 0.62;
			i780.rotation = -148;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 37.3;
			i780.scaleX = 0.59;
			i780.y = 63.9;
			i780.scaleY = 0.59;
			i780.rotation = -156;
			i780.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 37.4;
			i780.scaleX = 0.57;
			i780.y = 63.8;
			i780.scaleY = 0.57;
			i780.rotation = -164;
			i780.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 37.6;
			i780.scaleX = 0.55;
			i780.y = 64;
			i780.scaleY = 0.55;
			i780.rotation = -171;
			i780.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 37.7;
			i780.scaleX = 0.53;
			i780.scaleY = 0.53;
			i780.rotation = -179;
			i780.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i778);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i780.x = 37.9;
			i780.scaleX = 0.51;
			i780.y = 64.1;
			i780.scaleY = 0.51;
			i780.rotation = 172;
			i780.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 26.6;
			i744.y = 66.5;
			i744.rotation = -13;
			i782.x = 6.3;
			i782.scaleX = 1;
			i782.y = 52.1;
			i782.scaleY = 1;
			i782.rotation = 0;
			i782.alpha = 1;
			i782.filters = new as3.Array(new object[]{});
			i782.scale9Grid = null;
			i782.visible = true;
			i780.x = 38.1;
			i780.scaleX = 0.49;
			i780.scaleY = 0.49;
			i780.rotation = 165;
			i780.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 27.4;
			i744.y = 65.5;
			i744.rotation = -12;
			i782.x = 6.7;
			i782.y = 51.8;
			i782.rotation = -1;
			i780.x = 38.3;
			i780.scaleX = 0.46;
			i780.y = 64.2;
			i780.scaleY = 0.46;
			i780.rotation = 157;
			i780.alpha = 0.2;
			i757.x = 63.8;
			i757.y = 15.5;
			i757.rotation = -3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 28.1;
			i744.y = 64.5;
			i744.rotation = -10;
			i782.x = 7;
			i782.y = 51.4;
			i780.x = 38.4;
			i780.scaleX = 0.44;
			i780.scaleY = 0.44;
			i780.rotation = 149;
			i780.alpha = 0.1;
			i757.x = 63.5;
			i757.y = 15.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 29;
			i744.y = 63.5;
			i744.rotation = -8;
			i782.x = 7.5;
			i782.y = 51;
			i780.x = 38.6;
			i780.scaleX = 0.42;
			i780.y = 64.3;
			i780.scaleY = 0.42;
			i780.rotation = 142;
			i780.alpha = 0;
			i757.x = 63.3;
			i757.y = 16.1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 29.9;
			i744.y = 62.5;
			i744.rotation = -6;
			i782.x = 7.8;
			i782.y = 50.6;
			i757.x = 63.1;
			i757.y = 16.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 30.7;
			i744.y = 61.6;
			i744.rotation = -5;
			i782.x = 8.1;
			i782.y = 50.4;
			i782.rotation = 0;
			i757.x = 62.9;
			i757.y = 16.8;
			i757.rotation = -4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 31.6;
			i744.y = 60.7;
			i744.rotation = -3;
			i782.x = 8.4;
			i782.y = 50;
			i757.x = 62.6;
			i757.y = 17;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 32.5;
			i744.y = 59.9;
			i744.rotation = -1;
			i782.x = 8.8;
			i782.y = 49.6;
			i757.x = 62.5;
			i757.y = 17.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 33.1;
			i744.y = 59.5;
			i744.rotation = 0;
			i782.x = 9.3;
			i782.y = 49.4;
			i757.x = 62.3;
			i757.y = 17.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 33.8;
			i744.y = 59;
			i782.y = 49.3;
			i757.x = 62;
			i757.y = 18;
			i757.rotation = -5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 34.5;
			i744.y = 58.6;
			i744.rotation = 2;
			i782.x = 9.7;
			i782.y = 49;
			i757.x = 61.9;
			i757.y = 18.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 35.5;
			i744.y = 58.1;
			i744.rotation = 3;
			i782.x = 10.2;
			i782.y = 48.5;
			i757.x = 61.6;
			i757.y = 18.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 36.5;
			i744.y = 57.7;
			i744.rotation = 5;
			i782.x = 9.4;
			i782.y = 49.2;
			i757.x = 61.9;
			i757.y = 18.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 37.5;
			i744.y = 57.3;
			i744.rotation = 7;
			i782.x = 8.9;
			i782.y = 49.6;
			i757.x = 62.1;
			i757.y = 17.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 38.6;
			i744.y = 56.8;
			i744.rotation = 9;
			i782.x = 8.5;
			i782.y = 50;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 40;
			i744.y = 56.1;
			i744.rotation = 11;
			i782.x = 7.8;
			i782.y = 50.8;
			i782.rotation = -1;
			i757.x = 62.4;
			i757.y = 17.6;
			i757.rotation = -4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 37.9;
			i744.y = 57.3;
			i744.rotation = 8;
			i782.x = 7.2;
			i782.y = 51.4;
			i757.x = 62.5;
			i757.y = 17.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 35.8;
			i744.y = 58.5;
			i744.rotation = 4;
			i782.x = 6.5;
			i782.y = 52.1;
			i782.rotation = -2;
			i757.x = 62.8;
			i757.y = 17.1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i782);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 34;
			i744.y = 59.6;
			i744.rotation = 1;
			i782.x = 6;
			i782.y = 52.5;
			i757.x = 63;
			i757.y = 16.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 32.3;
			i744.y = 61;
			i744.rotation = -2;
			i783.x = 5.1;
			i783.scaleX = 1;
			i783.y = 53.4;
			i783.scaleY = 1;
			i783.rotation = -2;
			i783.alpha = 1;
			i783.filters = new as3.Array(new object[]{});
			i783.scale9Grid = null;
			i783.visible = true;
			i757.x = 63.1;
			i757.y = 16.4;
			i757.rotation = -3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 30.6;
			i744.y = 62.5;
			i744.rotation = -5;
			i757.x = 63.4;
			i757.y = 16.1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 28.9;
			i744.y = 64;
			i744.rotation = -8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 27.4;
			i744.y = 65.7;
			i744.rotation = -12;
			i757.x = 63.6;
			i757.y = 15.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i772);
		f.Add(i774);
		f.Add(i776);
		f += () => {
			i744.x = 25.9;
			i744.y = 67.5;
			i744.rotation = -15;
			i757.x = 63.9;
			i757.y = 15.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i757.y = 15.3;
			i757.rotation = -2;
			i785.x = 37.6;
			i785.scaleX = 0.68;
			i785.y = 116;
			i785.scaleY = 0.68;
			i785.rotation = 0;
			i785.alpha = 1;
			i785.filters = new as3.Array(new object[]{});
			i785.scale9Grid = null;
			i785.visible = true;
			i787.x = 15.7;
			i787.scaleX = 1.26;
			i787.y = 119;
			i787.scaleY = 1.26;
			i787.rotation = 0;
			i787.alpha = 1;
			i787.filters = new as3.Array(new object[]{});
			i787.scale9Grid = null;
			i787.visible = true;
			i789.x = -75.8;
			i789.scaleX = 1;
			i789.y = 83.8;
			i789.scaleY = 1;
			i789.rotation = 0;
			i789.alpha = 1;
			i789.filters = new as3.Array(new object[]{});
			i789.scale9Grid = null;
			i789.visible = true;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 37.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 38;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 38.4;
			i785.y = 115.8;
			i785.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 39;
			i785.scaleX = 0.69;
			i785.scaleY = 0.69;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 39.7;
			i785.y = 115.5;
			i785.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 40.6;
			i785.scaleX = 0.7;
			i785.y = 115.4;
			i785.scaleY = 0.7;
			i787.scaleX = 1.25;
			i787.scaleY = 1.25;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 41.8;
			i785.y = 115.2;
			i785.alpha = 0.7;
			i787.x = 15.9;
			i787.scaleX = 1.24;
			i787.scaleY = 1.24;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 43;
			i785.scaleX = 0.71;
			i785.y = 114.9;
			i785.scaleY = 0.71;
			i785.alpha = 0.6;
			i787.x = 16.2;
			i787.scaleX = 1.23;
			i787.y = 118.8;
			i787.scaleY = 1.23;
			i787.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 44.4;
			i785.scaleX = 0.72;
			i785.y = 114.6;
			i785.scaleY = 0.72;
			i785.alpha = 0.4;
			i787.x = 16.6;
			i787.scaleX = 1.2;
			i787.scaleY = 1.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 46;
			i785.scaleX = 0.73;
			i785.y = 114.3;
			i785.scaleY = 0.73;
			i785.alpha = 0.3;
			i787.x = 17.2;
			i787.scaleX = 1.17;
			i787.y = 118.5;
			i787.scaleY = 1.17;
			i787.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 47.7;
			i785.scaleX = 0.74;
			i785.y = 113.9;
			i785.scaleY = 0.74;
			i785.alpha = 0.2;
			i787.x = 17.9;
			i787.scaleX = 1.13;
			i787.scaleY = 1.13;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i785.x = 49.6;
			i785.scaleX = 0.75;
			i785.y = 113.5;
			i785.scaleY = 0.75;
			i785.alpha = 0;
			i787.x = 18.8;
			i787.scaleX = 1.08;
			i787.y = 118.3;
			i787.scaleY = 1.08;
			i787.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i787.x = 19.6;
			i787.scaleX = 1.03;
			i787.y = 118;
			i787.scaleY = 1.03;
			i787.alpha = 0.6;
			i789.x = -75.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i787.x = 20.7;
			i787.scaleX = 0.97;
			i787.y = 117.7;
			i787.scaleY = 0.97;
			i787.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i787.x = 21.9;
			i787.scaleX = 0.91;
			i787.y = 117.4;
			i787.scaleY = 0.91;
			i787.alpha = 0.3;
			i789.x = -75.5;
			i789.y = 83.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i787.x = 23.2;
			i787.scaleX = 0.83;
			i787.y = 117.1;
			i787.scaleY = 0.83;
			i787.alpha = 0.2;
			i789.x = -75.3;
			i789.scaleX = 0.99;
			i789.y = 84;
			i789.scaleY = 0.99;
			i789.alpha = 0.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i787.x = 24.6;
			i787.scaleX = 0.75;
			i787.y = 116.8;
			i787.scaleY = 0.75;
			i787.alpha = 0;
			i789.x = -75.1;
			i789.y = 84.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i789.x = -74.8;
			i789.y = 84.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i789.x = -74.5;
			i789.scaleX = 0.98;
			i789.y = 84.7;
			i789.scaleY = 0.98;
			i789.alpha = 0.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i789.x = -74;
			i789.y = 84.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i789.x = -73.6;
			i789.scaleX = 0.97;
			i789.y = 85.2;
			i789.scaleY = 0.97;
			i789.alpha = 0.7;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i789.x = -73;
			i789.y = 85.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i789.x = -72.5;
			i789.scaleX = 0.96;
			i789.y = 86;
			i789.scaleY = 0.96;
			i789.alpha = 0.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i744.x = 26.3;
			i744.y = 71.3;
			i744.rotation = -14;
			i751.x = 59.9;
			i751.y = 93;
			i751.rotation = -20;
			i753.x = 95;
			i753.y = 62.6;
			i783.x = 1.8;
			i783.y = 59.6;
			i783.rotation = -7;
			i757.x = 66.3;
			i757.y = 14.4;
			i765.x = 110.2;
			i765.y = 83.1;
			i789.x = -71.9;
			i789.scaleX = 0.95;
			i789.y = 86.3;
			i789.scaleY = 0.95;
			i789.alpha = 0.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i744.x = 26.8;
			i744.y = 75;
			i744.rotation = -13;
			i751.x = 61.7;
			i751.y = 93.5;
			i751.rotation = -21;
			i753.x = 96.8;
			i753.y = 62.2;
			i753.rotation = -23;
			i783.x = -1.1;
			i783.y = 66.5;
			i783.rotation = -11;
			i757.x = 68.9;
			i757.y = 13.3;
			i757.rotation = -1;
			i765.x = 111.9;
			i765.y = 82.7;
			i765.rotation = 5;
			i789.x = -71.2;
			i789.scaleX = 0.94;
			i789.y = 86.8;
			i789.scaleY = 0.94;
			i789.alpha = 0.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i744.x = 27.3;
			i744.y = 78.7;
			i744.rotation = -12;
			i751.x = 63.4;
			i751.y = 93.9;
			i751.rotation = -22;
			i753.x = 98.7;
			i753.y = 61.6;
			i783.x = -3.6;
			i783.y = 73.8;
			i783.rotation = -16;
			i757.x = 71.3;
			i757.y = 12.5;
			i765.x = 113.7;
			i765.y = 82.3;
			i789.x = -70.5;
			i789.scaleX = 0.93;
			i789.y = 87.3;
			i789.scaleY = 0.93;
			i789.alpha = 0.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i744.x = 27.7;
			i744.y = 82.5;
			i744.rotation = -11;
			i751.x = 65.2;
			i751.y = 94.3;
			i751.rotation = -23;
			i753.x = 100.7;
			i753.y = 61;
			i753.rotation = -22;
			i783.x = -5.3;
			i783.y = 81.1;
			i783.rotation = -20;
			i757.x = 73.6;
			i757.y = 11.7;
			i757.rotation = 0;
			i765.x = 115.5;
			i765.y = 82;
			i789.x = -69.7;
			i789.scaleX = 0.92;
			i789.y = 87.8;
			i789.scaleY = 0.92;
			i789.alpha = 0.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i744.x = 28.1;
			i744.y = 86.3;
			i744.rotation = -10;
			i751.x = 67;
			i751.y = 94.8;
			i751.rotation = -24;
			i753.x = 102.7;
			i753.y = 60.5;
			i753.rotation = -21;
			i783.x = -6.5;
			i783.y = 89.2;
			i783.rotation = -24;
			i757.x = 76;
			i757.y = 10.8;
			i765.x = 117.2;
			i765.y = 81.7;
			i765.rotation = 4;
			i789.x = -68.9;
			i789.scaleX = 0.91;
			i789.y = 88.3;
			i789.scaleY = 0.91;
			i789.alpha = 0.1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f.Add(i785);
		f.Add(i787);
		f.Add(i789);
		f += () => {
			i744.x = 28.6;
			i744.y = 90;
			i744.rotation = -9;
			i751.x = 68.8;
			i751.y = 95.3;
			i751.rotation = -25;
			i753.x = 104.6;
			i753.y = 60;
			i783.x = -7;
			i783.y = 97.1;
			i783.rotation = -29;
			i757.x = 78.5;
			i757.y = 10.1;
			i765.x = 118.9;
			i765.y = 81.3;
			i789.x = -68;
			i789.scaleX = 0.9;
			i789.y = 89;
			i789.scaleY = 0.9;
			i789.alpha = 0;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 29.2;
			i744.y = 93.8;
			i744.rotation = -8;
			i751.x = 70.8;
			i751.y = 95.8;
			i751.rotation = -26;
			i753.x = 106.5;
			i753.y = 59.5;
			i753.rotation = -20;
			i783.y = 105.6;
			i783.rotation = -33;
			i757.x = 81;
			i757.y = 9;
			i757.rotation = 1;
			i765.x = 120.7;
			i765.y = 81;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 29.6;
			i744.y = 97.5;
			i744.rotation = -7;
			i751.x = 72.6;
			i751.y = 96.2;
			i751.rotation = -27;
			i753.x = 108.5;
			i753.y = 59;
			i783.x = -6.3;
			i783.y = 114.2;
			i783.rotation = -38;
			i757.x = 83.5;
			i757.y = 8.2;
			i765.x = 122.5;
			i765.y = 80.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 30.8;
			i744.y = 101.2;
			i744.rotation = -9;
			i751.x = 74.5;
			i751.y = 96.7;
			i751.rotation = -28;
			i753.x = 110.5;
			i753.y = 58.4;
			i753.rotation = -19;
			i783.x = -4.8;
			i783.y = 122.5;
			i783.rotation = -42;
			i757.x = 85.9;
			i757.y = 7.5;
			i757.rotation = 2;
			i765.x = 124.3;
			i765.y = 80.3;
			i765.rotation = 3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 31.9;
			i744.y = 104.8;
			i744.rotation = -10;
			i751.x = 76.4;
			i751.y = 97;
			i751.rotation = -29;
			i753.x = 112.5;
			i753.y = 57.8;
			i783.x = -2.8;
			i783.y = 131.4;
			i783.rotation = -46;
			i757.x = 88.5;
			i757.y = 6.4;
			i757.rotation = 3;
			i765.x = 125.9;
			i765.y = 79.9;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 33.2;
			i744.y = 108.6;
			i744.rotation = -12;
			i751.x = 78.3;
			i751.y = 97.5;
			i751.rotation = -30;
			i753.x = 114.5;
			i753.y = 57.4;
			i753.rotation = -18;
			i783.x = 0;
			i783.y = 139.8;
			i783.rotation = -51;
			i757.x = 91;
			i757.y = 5.6;
			i765.x = 127.8;
			i765.y = 79.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 34.3;
			i744.y = 112.5;
			i744.rotation = -14;
			i751.x = 80.3;
			i751.y = 98;
			i751.rotation = -32;
			i753.x = 116.4;
			i753.y = 56.9;
			i783.x = 3.5;
			i783.y = 148.6;
			i783.rotation = -55;
			i757.x = 93.4;
			i757.y = 4.8;
			i757.rotation = 4;
			i765.x = 129.6;
			i765.y = 79.2;
			i765.rotation = 2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 35.5;
			i744.y = 116.3;
			i744.rotation = -15;
			i751.x = 82.3;
			i751.y = 98.4;
			i751.rotation = -33;
			i753.x = 118.3;
			i753.y = 56.4;
			i753.rotation = -17;
			i783.x = 7.6;
			i783.y = 156.8;
			i783.rotation = -59;
			i757.x = 96.1;
			i757.y = 3.9;
			i765.x = 131.3;
			i765.y = 78.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 36.8;
			i744.y = 120.2;
			i744.rotation = -17;
			i751.x = 84.3;
			i751.y = 98.9;
			i751.rotation = -34;
			i753.x = 120.4;
			i753.y = 55.6;
			i753.rotation = -16;
			i783.x = 12.4;
			i783.y = 165.3;
			i783.rotation = -64;
			i757.x = 98.5;
			i757.y = 3.1;
			i757.rotation = 5;
			i765.x = 133;
			i765.y = 78.5;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 38;
			i744.y = 124;
			i744.rotation = -18;
			i751.x = 86.2;
			i751.y = 99.3;
			i751.rotation = -35;
			i753.x = 122.4;
			i753.y = 55.3;
			i783.x = 17.7;
			i783.y = 173.3;
			i783.rotation = -68;
			i757.x = 101.1;
			i757.y = 2.1;
			i757.rotation = 6;
			i765.x = 134.7;
			i765.y = 78.1;
			i765.rotation = 1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 39.3;
			i744.y = 127.8;
			i744.rotation = -20;
			i751.x = 88.3;
			i751.y = 99.7;
			i751.rotation = -36;
			i753.x = 124.4;
			i753.y = 54.7;
			i753.rotation = -15;
			i783.x = 23.9;
			i783.y = 181.3;
			i783.rotation = -73;
			i757.x = 103.7;
			i757.y = 1.4;
			i765.x = 136.6;
			i765.y = 77.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 40.5;
			i744.y = 131.8;
			i744.rotation = -21;
			i751.x = 90.3;
			i751.y = 100.2;
			i751.rotation = -37;
			i753.x = 126.4;
			i753.y = 54.3;
			i783.x = 30.6;
			i783.y = 189;
			i783.rotation = -77;
			i757.x = 106.2;
			i757.y = 0.6;
			i757.rotation = 7;
			i765.x = 138.3;
			i765.y = 77.4;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 43.6;
			i744.y = 138.1;
			i744.rotation = -27;
			i751.x = 92.3;
			i751.y = 100.5;
			i751.rotation = -38;
			i753.x = 128.3;
			i753.y = 53.8;
			i753.rotation = -14;
			i783.x = 37.6;
			i783.y = 196.1;
			i783.rotation = -81;
			i757.x = 108.8;
			i757.y = -0.3;
			i765.x = 140.1;
			i765.y = 77;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 47;
			i744.y = 144.2;
			i744.rotation = -32;
			i751.x = 94.3;
			i751.y = 101;
			i751.rotation = -39;
			i753.x = 130.4;
			i753.y = 53.4;
			i783.x = 45.6;
			i783.y = 203.1;
			i783.rotation = -86;
			i757.x = 111.3;
			i757.y = -1.1;
			i757.rotation = 8;
			i765.x = 141.8;
			i765.y = 76.7;
			i765.rotation = 0;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 50.8;
			i744.y = 150.6;
			i744.rotation = -38;
			i751.x = 96.5;
			i751.y = 101.4;
			i751.rotation = -40;
			i753.x = 132.4;
			i753.y = 52.6;
			i753.rotation = -13;
			i783.x = 53.5;
			i783.y = 208.9;
			i783.rotation = -90;
			i757.x = 113.8;
			i757.y = -1.9;
			i765.x = 143.6;
			i765.y = 76.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 54.9;
			i744.y = 156.9;
			i744.rotation = -44;
			i751.x = 98.5;
			i751.y = 101.7;
			i751.rotation = -41;
			i753.x = 134.5;
			i753.y = 52.2;
			i783.x = 62.5;
			i783.y = 215;
			i783.rotation = -95;
			i757.x = 116.5;
			i757.y = -2.7;
			i757.rotation = 9;
			i765.x = 145.3;
			i765.y = 76;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 59.3;
			i744.y = 163.4;
			i744.rotation = -49;
			i751.x = 100.7;
			i751.y = 102.3;
			i751.rotation = -42;
			i753.x = 136.5;
			i753.y = 51.8;
			i753.rotation = -12;
			i783.x = 71.7;
			i783.y = 220.3;
			i783.rotation = -99;
			i757.x = 119;
			i757.y = -3.5;
			i757.rotation = 10;
			i765.x = 147.2;
			i765.y = 75.6;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 64.1;
			i744.y = 169.8;
			i744.rotation = -55;
			i751.x = 102.8;
			i751.y = 102.5;
			i751.rotation = -43;
			i753.x = 138.5;
			i753.y = 51.4;
			i783.x = 81.5;
			i783.y = 225.3;
			i783.rotation = -103;
			i757.x = 121.7;
			i757.y = -4.3;
			i765.x = 148.9;
			i765.y = 75.3;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 69.2;
			i744.y = 176.2;
			i744.rotation = -61;
			i751.x = 105;
			i751.y = 102.9;
			i751.rotation = -44;
			i753.x = 140.5;
			i753.y = 50.9;
			i753.rotation = -11;
			i783.x = 91.3;
			i783.y = 229.4;
			i783.rotation = -108;
			i757.x = 124.2;
			i757.y = -5;
			i757.rotation = 11;
			i765.x = 150.6;
			i765.y = 74.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 79.2;
			i744.y = 186;
			i744.rotation = -73;
			i751.x = 107.2;
			i751.y = 103.2;
			i751.rotation = -45;
			i753.x = 142.7;
			i753.y = 50.3;
			i753.rotation = -10;
			i783.x = 101.9;
			i783.y = 233.2;
			i783.rotation = -112;
			i757.x = 126.7;
			i757.y = -5.8;
			i765.x = 152.4;
			i765.y = 74.5;
			i765.rotation = -1;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 90.9;
			i744.y = 195.1;
			i744.rotation = -86;
			i751.x = 109.3;
			i751.y = 103.5;
			i751.rotation = -46;
			i753.x = 144.8;
			i753.y = 49.8;
			i783.x = 112.7;
			i783.y = 236.4;
			i783.rotation = -117;
			i757.x = 129.4;
			i757.y = -6.7;
			i757.rotation = 12;
			i765.x = 154.2;
			i765.y = 74.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 103.8;
			i744.y = 202.8;
			i744.rotation = -99;
			i751.x = 111.5;
			i751.y = 103.9;
			i751.rotation = -47;
			i753.x = 146.8;
			i753.y = 49.3;
			i753.rotation = -9;
			i783.x = 123.5;
			i783.y = 238.7;
			i783.rotation = -121;
			i757.x = 132;
			i757.y = -7.3;
			i757.rotation = 13;
			i765.x = 155.9;
			i765.y = 73.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 117.8;
			i744.y = 209.2;
			i744.rotation = -111;
			i751.x = 113.8;
			i751.y = 104.3;
			i751.rotation = -48;
			i753.x = 148.8;
			i753.y = 48.9;
			i783.x = 134.7;
			i783.y = 240.6;
			i783.rotation = -125;
			i757.x = 134.6;
			i757.y = -8.1;
			i765.x = 157.7;
			i765.y = 73.5;
			i765.rotation = -2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 132.7;
			i744.y = 214;
			i744.rotation = -124;
			i751.x = 116;
			i751.y = 104.6;
			i751.rotation = -49;
			i753.x = 150.8;
			i753.y = 48.4;
			i753.rotation = -8;
			i783.x = 145.7;
			i783.y = 241.7;
			i783.rotation = -130;
			i757.x = 137.3;
			i757.y = -8.9;
			i757.rotation = 14;
			i765.x = 159.4;
			i765.y = 73.2;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 147.9;
			i744.y = 216.9;
			i744.rotation = -137;
			i751.x = 118.3;
			i751.y = 105;
			i751.rotation = -50;
			i753.x = 152.9;
			i753.y = 47.9;
			i783.x = 157.1;
			i783.y = 242.2;
			i783.rotation = -134;
			i757.x = 139.8;
			i757.y = -9.6;
			i765.x = 161.2;
			i765.y = 72.8;
		};
		f = l.Add();
		f.Add(i743);
		f.Add(i744);
		f.Add(i751);
		f.Add(i753);
		f.Add(i783);
		f.Add(i780);
		f.Add(i757);
		f.Add(i765);
		f += () => {
			i744.x = 163;
			i744.y = 218.3;
			i744.rotation = -150;
			i751.x = 120.4;
			i751.y = 105.3;
			i751.rotation = -51;
			i753.x = 154.8;
			i753.y = 47.5;
			i753.rotation = -7;
			i783.x = 168.3;
			i783.y = 242;
			i783.rotation = -138;
			i757.x = 142.7;
			i757.y = -10.4;
			i757.rotation = 15;
			i765.x = 162.9;
			i765.y = 72.5;
		};
		f = l.Add();
		f.Add(i743);
		setFrames(l);
	}
}
public class TickGreenSubmit : BitmapData{ 
	public TickGreenSubmit() {
		width = 14;
		height = 12;
		setPixels("4f50ea3ed9f9ffe6fe75542089dce779");
	}
}
public class VerifyingPhotoMan : BitmapData{ 
	public VerifyingPhotoMan() {
		width = 400;
		height = 400;
		setPixels("e3db4d6eed66a8dc556cccd9866cd06b");
	}
}
public class VerifyingPhotoManEn : BitmapData{ 
	public VerifyingPhotoManEn() {
		width = 400;
		height = 400;
		setPixels("4b4001ecb3f00b8f8a6a81922f0fa61d");
	}
}
public class VerifyingPhotoWoman : BitmapData{ 
	public VerifyingPhotoWoman() {
		width = 400;
		height = 400;
		setPixels("c330399345d4984bb008a556f5648507");
	}
}
public class VerifyingPhotoWomanEn : BitmapData{ 
	public VerifyingPhotoWomanEn() {
		width = 400;
		height = 400;
		setPixels("93c14d7157caea7018f7d376307ff4bf");
	}
}
public class VipHintImage : BitmapData{ 
	public VipHintImage() {
		width = 52;
		height = 54;
		setPixels("cea0feae1af83f59c9a248253092b7bf");
	}
}
public class WhiteTickGreenInCircle : BitmapData{ 
	public WhiteTickGreenInCircle() {
		width = 20;
		height = 20;
		setPixels("353161b2148bd938af2bf661de6c309b");
	}
}
public class WindLeftButton : SimpleButton{ 
	public WindLeftButton() {
		downState = new symbol_245(){filters = new as3.Array(new object[]{})};
		overState = new symbol_245(){filters = new as3.Array(new object[]{})};
		upState = new symbol_245(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_245(){filters = new as3.Array(new object[]{})};
	}
}
public class WindRightButton : SimpleButton{ 
	public WindRightButton() {
		downState = new symbol_245(){filters = new as3.Array(new object[]{})};
		overState = new symbol_245(){filters = new as3.Array(new object[]{})};
		upState = new symbol_245(){filters = new as3.Array(new object[]{})};
		hitTestState = new symbol_245(){filters = new as3.Array(new object[]{})};
	}
}
namespace resources_fla
{	public class Timeline_80 : MovieClip{ 
		public Timeline_80() {
			var i520 = new symbol_166(){x = 0.3 , y = 7.6 , filters = new as3.Array(new object[]{})};
			addChild(i520);//0
			var i522 = new symbol_168(){x = 0.1 , y = -3.9 , filters = new as3.Array(new object[]{})};
			addChild(i522);//1
			FrameInfo f;
			var l= new Frames(75);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.3;
				i520.scaleX = 1;
				i520.y = 7.6;
				i520.scaleY = 1;
				i520.rotation = 0;
				i520.alpha = 1;
				i520.filters = new as3.Array(new object[]{});
				i520.scale9Grid = null;
				i520.visible = true;
				i522.x = 0.1;
				i522.scaleX = 1;
				i522.y = -3.9;
				i522.scaleY = 1;
				i522.rotation = 0;
				i522.alpha = 1;
				i522.filters = new as3.Array(new object[]{});
				i522.scale9Grid = null;
				i522.visible = true;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.05;
				i520.y = 8.3;
				i520.scaleY = 0.96;
				i522.scaleX = 1.05;
				i522.y = -2.8;
				i522.scaleY = 0.96;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.09;
				i520.y = 8.7;
				i520.scaleY = 0.93;
				i522.scaleX = 1.09;
				i522.y = -1.9;
				i522.scaleY = 0.93;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.11;
				i520.y = 8.9;
				i520.scaleY = 0.91;
				i522.scaleX = 1.11;
				i522.y = -1.4;
				i522.scaleY = 0.91;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.12;
				i520.y = 9.1;
				i520.scaleY = 0.9;
				i522.scaleX = 1.12;
				i522.y = -1.3;
				i522.scaleY = 0.9;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.5;
				i520.scaleX = 1.06;
				i520.y = 8.2;
				i520.scaleY = 0.96;
				i522.x = 0.3;
				i522.scaleX = 1.06;
				i522.y = -4.2;
				i522.scaleY = 0.93;
				i522.rotation = -2;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.3;
				i520.scaleX = 1.01;
				i520.y = 7.5;
				i520.scaleY = 1.01;
				i522.scaleX = 1.01;
				i522.y = -6.3;
				i522.scaleY = 0.95;
				i522.rotation = -5;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.97;
				i520.y = 7;
				i520.scaleY = 1.04;
				i522.x = 0.4;
				i522.scaleX = 0.98;
				i522.y = -7.9;
				i522.scaleY = 0.97;
				i522.rotation = -6;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.95;
				i520.y = 6.7;
				i520.scaleY = 1.06;
				i522.x = 0.5;
				i522.scaleX = 0.96;
				i522.y = -8.8;
				i522.scaleY = 0.98;
				i522.rotation = -7;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.94;
				i520.y = 6.5;
				i520.scaleY = 1.07;
				i522.y = -9.2;
				i522.rotation = -8;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.98;
				i520.y = 7.1;
				i520.scaleY = 1.04;
				i522.x = 0.3;
				i522.scaleX = 0.99;
				i522.y = -7.6;
				i522.scaleY = 0.97;
				i522.rotation = -6;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.01;
				i520.y = 7.6;
				i520.scaleY = 1;
				i522.scaleX = 1.02;
				i522.y = -6;
				i522.scaleY = 0.95;
				i522.rotation = -4;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.5;
				i520.scaleX = 1.05;
				i520.y = 8.1;
				i520.scaleY = 0.97;
				i522.scaleX = 1.05;
				i522.y = -4.4;
				i522.scaleY = 0.93;
				i522.rotation = -3;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.08;
				i520.y = 8.6;
				i520.scaleY = 0.93;
				i522.x = 0.1;
				i522.scaleX = 1.09;
				i522.y = -2.8;
				i522.scaleY = 0.92;
				i522.rotation = -1;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.12;
				i520.y = 9.1;
				i520.scaleY = 0.9;
				i522.scaleX = 1.12;
				i522.y = -1.3;
				i522.scaleY = 0.9;
				i522.rotation = 0;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.08;
				i520.y = 8.6;
				i520.scaleY = 0.94;
				i522.scaleX = 1.08;
				i522.y = -2.3;
				i522.scaleY = 0.94;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.3;
				i520.scaleX = 1.04;
				i520.y = 8.1;
				i520.scaleY = 0.96;
				i522.scaleX = 1.04;
				i522.y = -3;
				i522.scaleY = 0.96;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.02;
				i520.y = 7.8;
				i520.scaleY = 0.98;
				i522.scaleX = 1.02;
				i522.y = -3.5;
				i522.scaleY = 0.98;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1;
				i520.y = 7.7;
				i520.scaleY = 1;
				i522.scaleX = 1;
				i522.y = -3.8;
				i522.scaleY = 1;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.y = 7.6;
				i522.y = -3.9;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.04;
				i520.y = 8.1;
				i520.scaleY = 0.97;
				i522.scaleX = 1.04;
				i522.y = -3;
				i522.scaleY = 0.97;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.06;
				i520.y = 8.4;
				i520.scaleY = 0.94;
				i522.scaleX = 1.06;
				i522.y = -2.5;
				i522.scaleY = 0.94;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.08;
				i520.y = 8.7;
				i520.scaleY = 0.93;
				i522.scaleX = 1.08;
				i522.y = -2;
				i522.scaleY = 0.93;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleY = 0.92;
				i522.y = -1.9;
				i522.scaleY = 0.92;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.5;
				i520.scaleX = 1.05;
				i520.y = 3.5;
				i520.scaleY = 0.96;
				i522.scaleX = 1.05;
				i522.y = -7.5;
				i522.scaleY = 0.96;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.02;
				i520.y = -0.1;
				i520.scaleY = 0.98;
				i522.scaleX = 1.02;
				i522.y = -11.4;
				i522.scaleY = 0.98;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.3;
				i520.scaleX = 1.01;
				i520.y = -2.4;
				i520.scaleY = 1;
				i522.scaleX = 1.01;
				i522.y = -13.8;
				i522.scaleY = 1;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1;
				i520.y = -3.1;
				i522.scaleX = 1;
				i522.y = -14.6;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.y = -2.5;
				i522.y = -14.3;
				i522.rotation = -1;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.98;
				i520.y = -0.6;
				i520.scaleY = 1.01;
				i522.x = 0.3;
				i522.scaleX = 0.99;
				i522.y = -13.6;
				i522.scaleY = 0.99;
				i522.rotation = -4;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 0.96;
				i520.y = 2.6;
				i520.scaleY = 1.02;
				i522.x = 0.5;
				i522.scaleX = 0.98;
				i522.y = -12.3;
				i522.scaleY = 0.97;
				i522.rotation = -10;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.92;
				i520.y = 7.1;
				i520.scaleY = 1.03;
				i522.x = 0.7;
				i522.scaleX = 0.97;
				i522.y = -10.5;
				i522.scaleY = 0.94;
				i522.rotation = -17;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.99;
				i520.y = 7.8;
				i520.scaleY = 0.99;
				i522.x = 0.5;
				i522.scaleX = 1.02;
				i522.y = -6.8;
				i522.scaleY = 0.93;
				i522.rotation = -10;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.04;
				i520.y = 8.3;
				i520.scaleY = 0.95;
				i522.x = 0.3;
				i522.scaleX = 1.06;
				i522.y = -4.1;
				i522.rotation = -4;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.3;
				i520.scaleX = 1.07;
				i520.y = 8.6;
				i520.scaleY = 0.93;
				i522.x = 0.1;
				i522.scaleX = 1.08;
				i522.y = -2.5;
				i522.rotation = -1;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.08;
				i520.y = 8.7;
				i520.scaleY = 0.92;
				i522.y = -1.9;
				i522.scaleY = 0.92;
				i522.rotation = 0;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleY = 0.93;
				i522.y = -2;
				i522.scaleY = 0.93;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.5;
				i520.scaleX = 1.06;
				i520.y = 8.5;
				i520.scaleY = 0.94;
				i522.scaleX = 1.06;
				i522.y = -2.5;
				i522.scaleY = 0.94;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.04;
				i520.y = 8.1;
				i520.scaleY = 0.97;
				i522.scaleX = 1.04;
				i522.y = -3;
				i522.scaleY = 0.97;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.3;
				i520.scaleX = 1;
				i520.y = 7.6;
				i520.scaleY = 1;
				i522.scaleX = 1;
				i522.y = -3.9;
				i522.scaleY = 1;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.y = 2.9;
				i522.y = -8.6;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.y = -0.4;
				i522.y = -11.9;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.y = -2.5;
				i522.y = -13.9;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.y = -3.1;
				i522.y = -14.6;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.y = -2.5;
				i522.y = -14.3;
				i522.rotation = -1;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.98;
				i520.y = -0.6;
				i520.scaleY = 1.01;
				i522.x = 0.3;
				i522.scaleX = 0.99;
				i522.y = -13.6;
				i522.scaleY = 0.99;
				i522.rotation = -4;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 0.96;
				i520.y = 2.6;
				i520.scaleY = 1.02;
				i522.x = 0.5;
				i522.scaleX = 0.98;
				i522.y = -12.3;
				i522.scaleY = 0.97;
				i522.rotation = -10;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.92;
				i520.y = 7.1;
				i520.scaleY = 1.03;
				i522.x = 0.7;
				i522.scaleX = 0.97;
				i522.y = -10.5;
				i522.scaleY = 0.94;
				i522.rotation = -17;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 0.99;
				i520.y = 7.8;
				i520.scaleY = 0.99;
				i522.x = 0.5;
				i522.scaleX = 1.02;
				i522.y = -6.8;
				i522.scaleY = 0.93;
				i522.rotation = -10;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleX = 1.04;
				i520.y = 8.3;
				i520.scaleY = 0.95;
				i522.x = 0.3;
				i522.scaleX = 1.06;
				i522.y = -4.1;
				i522.rotation = -4;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.3;
				i520.scaleX = 1.07;
				i520.y = 8.6;
				i520.scaleY = 0.93;
				i522.x = 0.1;
				i522.scaleX = 1.08;
				i522.y = -2.5;
				i522.rotation = -1;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.08;
				i520.y = 8.7;
				i520.scaleY = 0.92;
				i522.y = -1.9;
				i522.scaleY = 0.92;
				i522.rotation = 0;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.scaleY = 0.93;
				i522.y = -2;
				i522.scaleY = 0.93;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.5;
				i520.scaleX = 1.06;
				i520.y = 8.5;
				i520.scaleY = 0.94;
				i522.scaleX = 1.06;
				i522.y = -2.5;
				i522.scaleY = 0.94;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.4;
				i520.scaleX = 1.04;
				i520.y = 8.1;
				i520.scaleY = 0.97;
				i522.scaleX = 1.04;
				i522.y = -3;
				i522.scaleY = 0.97;
			};
			f = l.Add();
			f.Add(i520);
			f.Add(i522);
			f += () => {
				i520.x = 0.3;
				i520.scaleX = 1;
				i520.y = 7.6;
				i520.scaleY = 1;
				i522.scaleX = 1;
				i522.y = -3.9;
				i522.scaleY = 1;
			};
			setFrames(l);
		}
	}
	public class animation_42 : MovieClip{ 
		public animation_42() {
			var i425 = new symbol_120(){filters = new as3.Array(new object[]{})};
			addChild(i425);//0
			var i426 = new symbol_4(){filters = new as3.Array(new object[]{})};
			addChild(i426);//1
			var i427 = new symbol_122(){x = -65 , scaleX = 1 , y = 2.2 , scaleY = 1 , rotation = -25 , blendMode = "overlay" , alpha = 0.5 , filters = new as3.Array(new object[]{})};
			addChild(i427);//2
			var i429 = new symbol_124(){x = -1.6 , alpha = 0 , y = -13.9 , filters = new as3.Array(new object[]{})};
			addChild(i429);//3
			FrameInfo f;
			var l= new Frames(25);
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i425.x = 0;
				i425.scaleX = 1;
				i425.y = 0;
				i425.scaleY = 1;
				i425.rotation = 0;
				i425.alpha = 1;
				i425.filters = new as3.Array(new object[]{});
				i425.scale9Grid = null;
				i425.visible = true;
				i426.x = 0;
				i426.scaleX = 1;
				i426.y = 0;
				i426.scaleY = 1;
				i426.rotation = 0;
				i426.alpha = 1;
				i426.filters = new as3.Array(new object[]{});
				i426.scale9Grid = null;
				i426.visible = true;
				i427.x = -65;
				i427.scaleX = 1;
				i427.y = 2.2;
				i427.scaleY = 1;
				i427.rotation = -25;
				i427.blendMode = "overlay";
				i427.alpha = 0.5;
				i427.filters = new as3.Array(new object[]{});
				i427.scale9Grid = null;
				i427.visible = true;
				i429.x = -1.6;
				i429.scaleX = 1;
				i429.y = -13.9;
				i429.scaleY = 1;
				i429.rotation = 0;
				i429.alpha = 0;
				i429.filters = new as3.Array(new object[]{});
				i429.scale9Grid = null;
				i429.visible = true;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -59.6;
				i429.rotation = 4;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -54.4;
				i429.rotation = 8;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -49;
				i429.rotation = 12;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -43.8;
				i429.rotation = 16;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -38.5;
				i427.alpha = 0.6;
				i429.y = -14;
				i429.rotation = 20;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -33.2;
				i429.y = -13.9;
				i429.rotation = 24;
				i429.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -27.9;
				i429.rotation = 29;
				i429.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -22.6;
				i429.rotation = 33;
				i429.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -17.3;
				i429.rotation = 37;
				i429.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -12;
				i429.rotation = 41;
				i429.alpha = 1;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -6.7;
				i429.rotation = 45;
				i429.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = -1.4;
				i429.rotation = 49;
				i429.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 3.9;
				i429.rotation = 54;
				i429.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 9.2;
				i429.y = -14;
				i429.rotation = 58;
				i429.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 14.8;
				i429.rotation = 62;
				i429.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 20.4;
				i427.alpha = 0.7;
				i429.y = -13.9;
				i429.rotation = 66;
				i429.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 25.9;
				i429.y = -14;
				i429.rotation = 70;
				i429.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 31.5;
				i429.y = -13.9;
				i429.rotation = 74;
				i429.alpha = 0;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 37.1;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 42.7;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 48.3;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 53.9;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 59.5;
			};
			f = l.Add();
			f.Add(i425);
			f.Add(i426);
			f.Add(i427);
			f.Add(i429);
			f += () => {
				i427.x = 65;
			};
			setFrames(l);
		}
	}
	public class salute_67 : MovieClip{ 
		public salute_67() {
			var i304 = new symbol_29(){filters = new as3.Array(new object[]{})};
			addChild(i304);//0
			var i305 = new symbol_4(){filters = new as3.Array(new object[]{})};
			addChild(i305);//0
			var i118 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i118);//0
			var i119 = new symbol_28(){x = 0.5 , y = -1.1 , filters = new as3.Array(new object[]{})};
			addChild(i119);//1
			var i307 = new symbol_30(){filters = new as3.Array(new object[]{})};
			addChild(i307);//1
			var i306 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i306);//1
			FrameInfo f;
			var l= new Frames(40);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f += () => {
				i118.x = 0;
				i118.scaleX = 1;
				i118.y = 0;
				i118.scaleY = 1;
				i118.rotation = 0;
				i118.alpha = 1;
				i118.filters = new as3.Array(new object[]{});
				i118.scale9Grid = null;
				i118.visible = true;
				i119.x = 0.5;
				i119.scaleX = 1;
				i119.y = -1.1;
				i119.scaleY = 1;
				i119.rotation = 0;
				i119.alpha = 1;
				i119.filters = new as3.Array(new object[]{});
				i119.scale9Grid = null;
				i119.visible = true;
			};
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i118);
			f.Add(i119);
			f = l.Add();
			f.Add(i304);
			f.Add(i119);
			f += () => {
				i304.x = 0;
				i304.scaleX = 1;
				i304.y = 0;
				i304.scaleY = 1;
				i304.rotation = 0;
				i304.alpha = 1;
				i304.filters = new as3.Array(new object[]{});
				i304.scale9Grid = null;
				i304.visible = true;
			};
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i119);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f += () => {
				i305.x = 0;
				i305.scaleX = 1;
				i305.y = 0;
				i305.scaleY = 1;
				i305.rotation = 0;
				i305.alpha = 1;
				i305.filters = new as3.Array(new object[]{});
				i305.scale9Grid = null;
				i305.visible = true;
				i306.x = 0;
				i306.scaleX = 1;
				i306.y = 0;
				i306.scaleY = 1;
				i306.rotation = 0;
				i306.alpha = 1;
				i306.filters = new as3.Array(new object[]{});
				i306.scale9Grid = null;
				i306.visible = true;
			};
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i306);
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			f.Add(i307);
			f += () => {
				i307.x = 0;
				i307.scaleX = 1;
				i307.y = 0;
				i307.scaleY = 1;
				i307.rotation = 0;
				i307.alpha = 1;
				i307.filters = new as3.Array(new object[]{});
				i307.scale9Grid = null;
				i307.visible = true;
			};
			f = l.Add();
			f.Add(i305);
			f.Add(i119);
			setFrames(l);
		}
	}
	public class staranim3_69 : MovieClip{ 
		public staranim3_69() {
			var i121 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i121);//0
			var i236 = new symbol_4(){filters = new as3.Array(new object[]{})};
			addChild(i236);//0
			var i237 = new symbol_5(){filters = new as3.Array(new object[]{})};
			addChild(i237);//1
			var i122 = new symbol_1(){filters = new as3.Array(new object[]{})};
			addChild(i122);//1
			var i235 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i235);//1
			var i123 = new symbol_3(){x = 16.5 , filters = new as3.Array(new object[]{})};
			addChild(i123);//2
			FrameInfo f;
			var l= new Frames(26);
			f = l.Add();
			f.Add(i121);
			f.Add(i122);
			f.Add(i123);
			f += () => {
				i121.x = 0;
				i121.scaleX = 1;
				i121.y = 0;
				i121.scaleY = 1;
				i121.rotation = 0;
				i121.alpha = 1;
				i121.filters = new as3.Array(new object[]{});
				i121.scale9Grid = null;
				i121.visible = true;
				i122.x = 0;
				i122.scaleX = 1;
				i122.y = 0;
				i122.scaleY = 1;
				i122.rotation = 0;
				i122.alpha = 1;
				i122.filters = new as3.Array(new object[]{});
				i122.scale9Grid = null;
				i122.visible = true;
				i123.x = 16.5;
				i123.scaleX = 1;
				i123.y = 0;
				i123.scaleY = 1;
				i123.rotation = 0;
				i123.alpha = 1;
				i123.filters = new as3.Array(new object[]{});
				i123.scale9Grid = null;
				i123.visible = true;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i122);
			f.Add(i123);
			f += () => {
				i123.x = 30.7;
				i123.scaleX = 0.95;
				i123.scaleY = 0.95;
				i123.rotation = 40;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i122);
			f.Add(i123);
			f += () => {
				i123.x = 44.1;
				i123.scaleX = 0.9;
				i123.scaleY = 0.9;
				i123.rotation = 77;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i122);
			f.Add(i123);
			f += () => {
				i123.x = 56.8;
				i123.scaleX = 0.85;
				i123.scaleY = 0.85;
				i123.rotation = 113;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i122);
			f.Add(i123);
			f += () => {
				i123.x = 68.7;
				i123.scaleX = 0.81;
				i123.y = -0.1;
				i123.scaleY = 0.81;
				i123.rotation = 146;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i122);
			f.Add(i123);
			f += () => {
				i123.x = 79.8;
				i123.scaleX = 0.77;
				i123.scaleY = 0.77;
				i123.rotation = 178;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i122);
			f.Add(i123);
			f += () => {
				i123.x = 90.2;
				i123.scaleX = 0.74;
				i123.scaleY = 0.74;
				i123.rotation = -152;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i235);
			f.Add(i123);
			f += () => {
				i235.x = 0;
				i235.scaleX = 1;
				i235.y = 0;
				i235.scaleY = 1;
				i235.rotation = 0;
				i235.alpha = 1;
				i235.filters = new as3.Array(new object[]{});
				i235.scale9Grid = null;
				i235.visible = true;
				i123.x = 99.8;
				i123.scaleX = 0.7;
				i123.scaleY = 0.7;
				i123.rotation = -125;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i235);
			f.Add(i123);
			f += () => {
				i123.x = 108.5;
				i123.scaleX = 0.67;
				i123.y = 0;
				i123.scaleY = 0.67;
				i123.rotation = -101;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i235);
			f.Add(i123);
			f += () => {
				i123.x = 116.5;
				i123.scaleX = 0.64;
				i123.scaleY = 0.64;
				i123.rotation = -78;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i235);
			f.Add(i123);
			f += () => {
				i123.x = 123.7;
				i123.scaleX = 0.62;
				i123.scaleY = 0.62;
				i123.rotation = -58;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i235);
			f.Add(i123);
			f += () => {
				i123.x = 130.1;
				i123.scaleX = 0.59;
				i123.scaleY = 0.59;
				i123.rotation = -40;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i235);
			f.Add(i123);
			f += () => {
				i123.x = 135.6;
				i123.scaleX = 0.57;
				i123.scaleY = 0.57;
				i123.rotation = -24;
			};
			f = l.Add();
			f.Add(i121);
			f.Add(i235);
			f.Add(i123);
			f += () => {
				i123.x = 140.4;
				i123.scaleX = 0.56;
				i123.scaleY = 0.56;
				i123.rotation = -11;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i236.x = 0;
				i236.scaleX = 1;
				i236.y = 0;
				i236.scaleY = 1;
				i236.rotation = 0;
				i236.alpha = 1;
				i236.filters = new as3.Array(new object[]{});
				i236.scale9Grid = null;
				i236.visible = true;
				i237.x = 0;
				i237.scaleX = 1;
				i237.y = 0;
				i237.scaleY = 1;
				i237.rotation = 0;
				i237.alpha = 1;
				i237.filters = new as3.Array(new object[]{});
				i237.scale9Grid = null;
				i237.visible = true;
				i123.x = 144.5;
				i123.scaleX = 0.54;
				i123.scaleY = 0.54;
				i123.rotation = 0;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 147.8;
				i123.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 151.1;
				i123.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 154.3;
				i123.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 157.6;
				i123.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 160.8;
				i123.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 164.2;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 167.4;
				i123.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 170.7;
				i123.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 173.9;
				i123.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i236);
			f.Add(i237);
			f.Add(i123);
			f += () => {
				i123.x = 177.3;
				i123.alpha = 0;
			};
			f = l.Add();
			f.Add(i123);
			f += () => {
				i123.x = 180.5;
			};
			setFrames(l);
		}
	}
	public class tie_104 : MovieClip{ 
		public tie_104() {
			var i701 = new symbol_193(){filters = new as3.Array(new object[]{})};
			addChild(i701);//0
			var i702 = new symbol_195(){x = 1.1 , y = 10.3 , filters = new as3.Array(new object[]{})};
			addChild(i702);//1
			FrameInfo f;
			var l= new Frames(164);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i701.x = 0;
				i701.scaleX = 1;
				i701.y = 0;
				i701.scaleY = 1;
				i701.rotation = 0;
				i701.alpha = 1;
				i701.filters = new as3.Array(new object[]{});
				i701.scale9Grid = null;
				i701.visible = true;
				i702.x = 1.1;
				i702.scaleX = 1;
				i702.y = 10.3;
				i702.scaleY = 1;
				i702.rotation = 0;
				i702.alpha = 1;
				i702.filters = new as3.Array(new object[]{});
				i702.scale9Grid = null;
				i702.visible = true;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.2;
				i702.rotation = 1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = 2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.2;
				i702.y = 10.1;
				i702.rotation = 3;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.3;
				i702.y = 10;
				i702.rotation = 4;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 9.9;
				i702.rotation = 5;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.4;
				i702.rotation = 6;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 9.8;
				i702.rotation = 7;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.5;
				i702.rotation = 8;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.6;
				i702.y = 9.7;
				i702.rotation = 9;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 9.8;
				i702.rotation = 8;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.5;
				i702.rotation = 7;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = 6;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.4;
				i702.rotation = 5;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 9.9;
				i702.rotation = 4;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.3;
				i702.y = 10;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = 3;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.1;
				i702.rotation = 2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.2;
				i702.rotation = 1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.3;
				i702.rotation = 0;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 0.9;
				i702.y = 10.4;
				i702.rotation = -1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = -2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 0.8;
				i702.y = 10.5;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = -3;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.6;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.7;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 0.7;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 0.8;
				i702.y = 10.6;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.5;
				i702.rotation = -2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.6;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 0.9;
				i702.y = 10.5;
				i702.rotation = -1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.4;
				i702.rotation = 0;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.1;
				i702.y = 10.3;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.2;
				i702.rotation = 1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = 2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.1;
				i702.rotation = 3;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.4;
				i702.y = 9.9;
				i702.rotation = 4;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.3;
				i702.y = 10.1;
				i702.rotation = 3;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = 2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.1;
				i702.y = 10.2;
				i702.rotation = 1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = 0;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.3;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.3;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1;
				i702.y = 10.2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 0.9;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.rotation = -1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 0.8;
				i702.rotation = -2;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.5;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.6;
				i702.rotation = -1;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 0.9;
				i702.y = 10.7;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.y = 10.6;
				i702.rotation = 0;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1;
				i702.y = 10.7;
			};
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f = l.Add();
			f.Add(i701);
			f.Add(i702);
			f += () => {
				i702.x = 1.1;
				i702.y = 10.3;
			};
			setFrames(l);
		}
	}
	public class vip_97 : MovieClip{ 
		public vip_97() {
			var i710 = new symbol_196(){filters = new as3.Array(new object[]{})};
			addChild(i710);//0
			var i711 = new symbol_4(){filters = new as3.Array(new object[]{})};
			addChild(i711);//1
			var i712 = new symbol_197(){x = -1.4 , y = -6.6 , filters = new as3.Array(new object[]{})};
			addChild(i712);//2
			FrameInfo f;
			var l= new Frames(38);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i710.x = 0;
				i710.scaleX = 1;
				i710.y = 0;
				i710.scaleY = 1;
				i710.rotation = 0;
				i710.alpha = 1;
				i710.filters = new as3.Array(new object[]{});
				i710.scale9Grid = null;
				i710.visible = true;
				i711.x = 0;
				i711.scaleX = 1;
				i711.y = 0;
				i711.scaleY = 1;
				i711.rotation = 0;
				i711.alpha = 1;
				i711.filters = new as3.Array(new object[]{});
				i711.scale9Grid = null;
				i711.visible = true;
				i712.x = -1.4;
				i712.scaleX = 1;
				i712.y = -6.6;
				i712.scaleY = 1;
				i712.rotation = 0;
				i712.alpha = 1;
				i712.filters = new as3.Array(new object[]{});
				i712.scale9Grid = null;
				i712.visible = true;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 2.3;
				i712.y = -3.7;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 5.8;
				i712.y = -0.8;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 9.5;
				i712.y = 2.1;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 13.1;
				i712.y = 5.1;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 16.7;
				i712.y = 8;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 20.3;
				i712.y = 10.9;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 23.9;
				i712.y = 13.8;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 27.6;
				i712.y = 16.8;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 31.1;
				i712.y = 19.7;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 34.8;
				i712.y = 22.6;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 38.4;
				i712.y = 25.6;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 42;
				i712.y = 28.4;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 45.6;
				i712.y = 31.4;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f += () => {
				i712.x = 49.2;
				i712.y = 34.3;
			};
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			f = l.Add();
			f.Add(i710);
			f.Add(i711);
			f.Add(i712);
			setFrames(l);
		}
	}
}
namespace resources.swf.privateSymbols{
	public class symbol_0 : MorphShape{ 
		public symbol_0() {
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("d403e25f3e1fbe49c24c70f4c7026c1e", 5.6, -2.5, 124.15, 9.75, 1, 1);
		}
	}
	public class symbol_10 : MovieClip{ 
		public symbol_10() {
			var i149 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i149);//0
		}
	}
	public class symbol_100 : Shape{ 
		public symbol_100() {
			setGraphics("70dd25c5a1843e4dfc6cac21128ddc1d", -30, -46, 76, 48, 1, 1);
		}
	}
	public class symbol_101 : Shape{ 
		public symbol_101() {
			setGraphics("eb6a0030c4bc5d6f055d6de4db2cb1f7", -6, -2.95, 60.05, 45.7, 1, 1);
		}
	}
	public class symbol_102 : MovieClip{ 
		public symbol_102() {
			var i397 = new symbol_101(){filters = new as3.Array(new object[]{})};
			addChild(i397);//0
		}
	}
	public class symbol_103 : MovieClip{ 
		public symbol_103() {
			var i400 = new symbol_101(){filters = new as3.Array(new object[]{})};
			addChild(i400);//0
		}
	}
	public class symbol_104 : Shape{ 
		public symbol_104() {
			setGraphics("a99bb901d81dddc730928fa3cfe794e9", -7.75, -25.2, 15.5, 50.4, 1, 1);
		}
	}
	public class symbol_105 : Shape{ 
		public symbol_105() {
			setGraphics("1ff3fc2961a834bd531c773349e83535", -14, -45.5, 28, 91, 1, 1);
		}
	}
	public class symbol_106 : MovieClip{ 
		public symbol_106() {
			var i405 = new symbol_105(){filters = new as3.Array(new object[]{})};
			addChild(i405);//0
		}
	}
	public class symbol_107 : Shape{ 
		public symbol_107() {
			setGraphics("eb3ee9aa05df10ae2eb0853491a4672c", 0, 0, 125.75, 53.65, 1, 1);
		}
	}
	public class symbol_108 : Shape{ 
		public symbol_108() {
			setGraphics("fe082cd5429070cd84be792d35631af3", 0, 0, 0, 0, 1, 1);
		}
	}
	public class symbol_109 : Shape{ 
		public symbol_109() {
			setGraphics("77dbfb6bedff87982c46bc4a3ef23f5a", 224.25, 7.35, 40, 40, 1, 1);
		}
	}
	public class symbol_11 : MovieClip{ 
		public symbol_11() {
			var i154 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i154);//0
		}
	}
	public class symbol_110 : Shape{ 
		public symbol_110() {
			setGraphics("437b94b92b4ebe367ce6135cc3635efd", -20, -20, 40, 40, 1, 1);
		}
	}
	public class symbol_111 : Shape{ 
		public symbol_111() {
			setGraphics("9ef4f75fd9375beb30e2d7f519c14ade", -25, -20, 50, 40, 1, 1);
		}
	}
	public class symbol_112 : Shape{ 
		public symbol_112() {
			setGraphics("872cad7ebd179977860111c494b59609", -48.3, -2.4, 88.9, 9.5, 1, 1);
		}
	}
	public class symbol_113 : MovieClip{ 
		public symbol_113() {
			var i417 = new symbol_112(){filters = new as3.Array(new object[]{})};
			addChild(i417);//0
		}
	}
	public class symbol_114 : Shape{ 
		public symbol_114() {
			setGraphics("0b729fa175f83b333b8120c17ee4eebb", -42.5, -5.5, 85, 11, 1, 1);
		}
	}
	public class symbol_115 : MovieClip{ 
		public symbol_115() {
			var i419 = new symbol_114(){filters = new as3.Array(new object[]{})};
			addChild(i419);//0
		}
	}
	public class symbol_116 : Shape{ 
		public symbol_116() {
			setGraphics("3aad0454c82dfa7d9899f93d657cd91a", -40.45, -9.45, 78, 9.6, 1, 1);
		}
	}
	public class symbol_117 : MovieClip{ 
		public symbol_117() {
			var i421 = new symbol_116(){filters = new as3.Array(new object[]{})};
			addChild(i421);//0
		}
	}
	public class symbol_118 : Shape{ 
		public symbol_118() {
			setGraphics("ddbe38000f4036061f89202adbdf001d", -10.25, -1.45, 20.15, 2.8, 1, 1);
		}
	}
	public class symbol_119 : MovieClip{ 
		public symbol_119() {
			var i423 = new symbol_118(){filters = new as3.Array(new object[]{})};
			addChild(i423);//0
		}
	}
	public class symbol_12 : MovieClip{ 
		public symbol_12() {
			var i159 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i159);//0
		}
	}
	public class symbol_120 : Shape{ 
		public symbol_120() {
			setGraphics("5e8ac034d9b591fb35445ef3b3b848a7", -23.5, -25, 43, 47, 1, 1);
		}
	}
	public class symbol_121 : Shape{ 
		public symbol_121() {
			setGraphics("cc1de5eb68cb9b89cbf062b477fab352", -54, -52.85, 107.95, 105.65, 1, 1);
		}
	}
	public class symbol_122 : MovieClip{ 
		public symbol_122() {
			var i428 = new symbol_121(){filters = new as3.Array(new object[]{})};
			addChild(i428);//0
		}
	}
	public class symbol_123 : Shape{ 
		public symbol_123() {
			setGraphics("4c52d132d37d0a89d178fa2bedbd1a61", -38.55, -38.05, 65.1, 64.05, 1, 1);
		}
	}
	public class symbol_124 : MovieClip{ 
		public symbol_124() {
			var i430 = new symbol_123(){filters = new as3.Array(new object[]{})};
			addChild(i430);//0
		}
	}
	public class symbol_125 : Shape{ 
		public symbol_125() {
			setGraphics("0bb35424218414cbea721a6e39c612b0", -14.55, 18.2, 73, 19.000000000000004, 1, 1);
		}
	}
	public class symbol_126 : Shape{ 
		public symbol_126() {
			setGraphics("e0a462712cd691f5bcfc0f25a789ee84", 0, 0, 43, 47, 1, 1);
		}
	}
	public class symbol_127 : MovieClip{ 
		public symbol_127() {
			var i437 = new symbol_121(){filters = new as3.Array(new object[]{})};
			addChild(i437);//0
		}
	}
	public class symbol_128 : MovieClip{ 
		public symbol_128() {
			var i439 = new symbol_123(){filters = new as3.Array(new object[]{})};
			addChild(i439);//0
		}
	}
	public class symbol_129 : Shape{ 
		public symbol_129() {
			setGraphics("7344c6a714ab1cba0fbd408299aed580", -14.65, 18.45, 73, 19.000000000000004, 1, 1);
		}
	}
	public class symbol_13 : MovieClip{ 
		public symbol_13() {
			var i164 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i164);//0
		}
	}
	public class symbol_130 : Shape{ 
		public symbol_130() {
			setGraphics("36d72d27d5fae71b2e986658741c5068", -19.55, -2.15, 78.15, 48.55, 1, 1);
		}
	}
	public class symbol_131 : Shape{ 
		public symbol_131() {
			setGraphics("35a87a1d61110a1e702570e2a7e67a7c", 2, 0, 84, 101, 1, 1);
		}
	}
	public class symbol_132 : Shape{ 
		public symbol_132() {
			setGraphics("b56e780cc9287dc953e95e2feb7ce705", -88.5, -77.5, 177, 155, 1, 1);
		}
	}
	public class symbol_133 : Shape{ 
		public symbol_133() {
			setGraphics("f820ce9dfee8677bf4a0918ceded5f8b", 60.4, 46.5, 33.1, 23.450000000000003, 1, 1);
		}
	}
	public class symbol_134 : Shape{ 
		public symbol_134() {
			setGraphics("c6a79f4366557f38549d7e1d107c2ef9", -50.5, -38, 101, 76, 1, 1);
		}
	}
	public class symbol_135 : MovieClip{ 
		public symbol_135() {
			var i459 = new symbol_134(){filters = new as3.Array(new object[]{})};
			addChild(i459);//0
		}
	}
	public class symbol_136 : Shape{ 
		public symbol_136() {
			setGraphics("11db35def2fc280d6f7c07a75b57c53f", -49, -49, 98, 98, 1, 1);
		}
	}
	public class symbol_137 : MovieClip{ 
		public symbol_137() {
			var i461 = new symbol_136(){filters = new as3.Array(new object[]{})};
			addChild(i461);//0
		}
	}
	public class symbol_138 : MovieClip{ 
		public symbol_138() {
			var i463 = new symbol_136(){filters = new as3.Array(new object[]{})};
			addChild(i463);//0
		}
	}
	public class symbol_139 : Shape{ 
		public symbol_139() {
			setGraphics("f9fd089aa0194152505d93d65d7c6e48", -8, -8, 8, 8, 1, 1);
		}
	}
	public class symbol_14 : MovieClip{ 
		public symbol_14() {
			var i169 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i169);//0
		}
	}
	public class symbol_140 : Shape{ 
		public symbol_140() {
			setGraphics("1ef3fe24543b84c895e7ac3c79bddee0", -28.3, -27.6, 56.6, 55.2, 1, 1);
		}
	}
	public class symbol_141 : MovieClip{ 
		public symbol_141() {
			var i471 = new symbol_140(){filters = new as3.Array(new object[]{})};
			addChild(i471);//0
		}
	}
	public class symbol_142 : Shape{ 
		public symbol_142() {
			setGraphics("7f2ec61cfabe48213f9d84960ce09428", -130.45, -5.5, 130.85, 13.9, 1, 1);
		}
	}
	public class symbol_143 : MovieClip{ 
		public symbol_143() {
			var i508 = new symbol_142(){filters = new as3.Array(new object[]{})};
			addChild(i508);//0
			var i469 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i469);//0
			var i470 = new symbol_141(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i470);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i469.x = 0;
				i469.scaleX = 1;
				i469.y = 0;
				i469.scaleY = 1;
				i469.rotation = 0;
				i469.alpha = 1;
				i469.filters = new as3.Array(new object[]{});
				i469.scale9Grid = null;
				i469.visible = true;
				i470.x = -13;
				i470.scaleX = 0.43;
				i470.y = 1;
				i470.scaleY = 0.43;
				i470.rotation = 0;
				i470.alpha = 1;
				i470.filters = new as3.Array(new object[]{});
				i470.scale9Grid = null;
				i470.visible = true;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -36.7;
				i470.scaleX = 0.62;
				i470.y = 1.1;
				i470.scaleY = 0.62;
				i470.rotation = 11;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -56.8;
				i470.scaleX = 0.77;
				i470.y = 1;
				i470.scaleY = 0.77;
				i470.rotation = 21;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -73.2;
				i470.scaleX = 0.9;
				i470.scaleY = 0.9;
				i470.rotation = 29;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -86;
				i470.scaleX = 1;
				i470.scaleY = 1;
				i470.rotation = 35;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -91.5;
				i470.y = 1.1;
				i470.rotation = 42;
				i470.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -96.5;
				i470.y = 0.9;
				i470.rotation = 48;
				i470.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -101.3;
				i470.y = 1;
				i470.rotation = 54;
				i470.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -105.8;
				i470.rotation = 59;
				i470.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -110;
				i470.rotation = 64;
				i470.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -113.8;
				i470.y = 1.1;
				i470.rotation = 69;
				i470.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -117.3;
				i470.y = 1;
				i470.rotation = 73;
				i470.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -120.5;
				i470.y = 1.1;
				i470.rotation = 77;
				i470.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i469);
			f.Add(i470);
			f += () => {
				i470.x = -123.5;
				i470.y = 1;
				i470.rotation = 81;
				i470.alpha = 0;
			};
			f = l.Add();
			f.Add(i508);
			f.Add(i470);
			f += () => {
				i508.x = 0;
				i508.scaleX = 1;
				i508.y = 0;
				i508.scaleY = 1;
				i508.rotation = 0;
				i508.alpha = 1;
				i508.filters = new as3.Array(new object[]{});
				i508.scale9Grid = null;
				i508.visible = true;
				i470.x = -126;
				i470.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_144 : MovieClip{ 
		public symbol_144() {
			var i475 = new symbol_140(){filters = new as3.Array(new object[]{})};
			addChild(i475);//0
		}
	}
	public class symbol_145 : MovieClip{ 
		public symbol_145() {
			var i509 = new symbol_142(){filters = new as3.Array(new object[]{})};
			addChild(i509);//0
			var i473 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i473);//0
			var i474 = new symbol_144(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i474);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i473.x = 0;
				i473.scaleX = 1;
				i473.y = 0;
				i473.scaleY = 1;
				i473.rotation = 0;
				i473.alpha = 1;
				i473.filters = new as3.Array(new object[]{});
				i473.scale9Grid = null;
				i473.visible = true;
				i474.x = -13;
				i474.scaleX = 0.43;
				i474.y = 1;
				i474.scaleY = 0.43;
				i474.rotation = 0;
				i474.alpha = 1;
				i474.filters = new as3.Array(new object[]{});
				i474.scale9Grid = null;
				i474.visible = true;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -36.7;
				i474.scaleX = 0.62;
				i474.y = 1.1;
				i474.scaleY = 0.62;
				i474.rotation = 11;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -56.8;
				i474.scaleX = 0.77;
				i474.y = 1;
				i474.scaleY = 0.77;
				i474.rotation = 21;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -73.2;
				i474.scaleX = 0.9;
				i474.scaleY = 0.9;
				i474.rotation = 29;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -86;
				i474.scaleX = 1;
				i474.scaleY = 1;
				i474.rotation = 35;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -91.5;
				i474.y = 1.1;
				i474.rotation = 42;
				i474.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -96.5;
				i474.y = 0.9;
				i474.rotation = 48;
				i474.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -101.3;
				i474.y = 1;
				i474.rotation = 54;
				i474.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -105.8;
				i474.rotation = 59;
				i474.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -110;
				i474.rotation = 64;
				i474.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -113.8;
				i474.y = 1.1;
				i474.rotation = 69;
				i474.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -117.3;
				i474.y = 1;
				i474.rotation = 73;
				i474.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -120.5;
				i474.y = 1.1;
				i474.rotation = 77;
				i474.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i473);
			f.Add(i474);
			f += () => {
				i474.x = -123.5;
				i474.y = 1;
				i474.rotation = 81;
				i474.alpha = 0;
			};
			f = l.Add();
			f.Add(i509);
			f.Add(i474);
			f += () => {
				i509.x = 0;
				i509.scaleX = 1;
				i509.y = 0;
				i509.scaleY = 1;
				i509.rotation = 0;
				i509.alpha = 1;
				i509.filters = new as3.Array(new object[]{});
				i509.scale9Grid = null;
				i509.visible = true;
				i474.x = -126;
				i474.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_146 : MovieClip{ 
		public symbol_146() {
			var i479 = new symbol_140(){filters = new as3.Array(new object[]{})};
			addChild(i479);//0
		}
	}
	public class symbol_147 : MovieClip{ 
		public symbol_147() {
			var i477 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i477);//0
			var i510 = new symbol_142(){filters = new as3.Array(new object[]{})};
			addChild(i510);//0
			var i478 = new symbol_146(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i478);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i477.x = 0;
				i477.scaleX = 1;
				i477.y = 0;
				i477.scaleY = 1;
				i477.rotation = 0;
				i477.alpha = 1;
				i477.filters = new as3.Array(new object[]{});
				i477.scale9Grid = null;
				i477.visible = true;
				i478.x = -13;
				i478.scaleX = 0.43;
				i478.y = 1;
				i478.scaleY = 0.43;
				i478.rotation = 0;
				i478.alpha = 1;
				i478.filters = new as3.Array(new object[]{});
				i478.scale9Grid = null;
				i478.visible = true;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -36.7;
				i478.scaleX = 0.62;
				i478.y = 1.1;
				i478.scaleY = 0.62;
				i478.rotation = 11;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -56.8;
				i478.scaleX = 0.77;
				i478.y = 1;
				i478.scaleY = 0.77;
				i478.rotation = 21;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -73.2;
				i478.scaleX = 0.9;
				i478.scaleY = 0.9;
				i478.rotation = 29;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -86;
				i478.scaleX = 1;
				i478.scaleY = 1;
				i478.rotation = 35;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -91.5;
				i478.y = 1.1;
				i478.rotation = 42;
				i478.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -96.5;
				i478.y = 0.9;
				i478.rotation = 48;
				i478.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -101.3;
				i478.y = 1;
				i478.rotation = 54;
				i478.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -105.8;
				i478.rotation = 59;
				i478.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -110;
				i478.rotation = 64;
				i478.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -113.8;
				i478.y = 1.1;
				i478.rotation = 69;
				i478.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -117.3;
				i478.y = 1;
				i478.rotation = 73;
				i478.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -120.5;
				i478.y = 1.1;
				i478.rotation = 77;
				i478.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i477);
			f.Add(i478);
			f += () => {
				i478.x = -123.5;
				i478.y = 1;
				i478.rotation = 81;
				i478.alpha = 0;
			};
			f = l.Add();
			f.Add(i510);
			f.Add(i478);
			f += () => {
				i510.x = 0;
				i510.scaleX = 1;
				i510.y = 0;
				i510.scaleY = 1;
				i510.rotation = 0;
				i510.alpha = 1;
				i510.filters = new as3.Array(new object[]{});
				i510.scale9Grid = null;
				i510.visible = true;
				i478.x = -126;
				i478.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_148 : MovieClip{ 
		public symbol_148() {
			var i483 = new symbol_140(){filters = new as3.Array(new object[]{})};
			addChild(i483);//0
		}
	}
	public class symbol_149 : MovieClip{ 
		public symbol_149() {
			var i481 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i481);//0
			var i511 = new symbol_142(){filters = new as3.Array(new object[]{})};
			addChild(i511);//0
			var i482 = new symbol_148(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i482);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i481.x = 0;
				i481.scaleX = 1;
				i481.y = 0;
				i481.scaleY = 1;
				i481.rotation = 0;
				i481.alpha = 1;
				i481.filters = new as3.Array(new object[]{});
				i481.scale9Grid = null;
				i481.visible = true;
				i482.x = -13;
				i482.scaleX = 0.43;
				i482.y = 1;
				i482.scaleY = 0.43;
				i482.rotation = 0;
				i482.alpha = 1;
				i482.filters = new as3.Array(new object[]{});
				i482.scale9Grid = null;
				i482.visible = true;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -36.7;
				i482.scaleX = 0.62;
				i482.y = 1.1;
				i482.scaleY = 0.62;
				i482.rotation = 11;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -56.8;
				i482.scaleX = 0.77;
				i482.y = 1;
				i482.scaleY = 0.77;
				i482.rotation = 21;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -73.2;
				i482.scaleX = 0.9;
				i482.scaleY = 0.9;
				i482.rotation = 29;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -86;
				i482.scaleX = 1;
				i482.scaleY = 1;
				i482.rotation = 35;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -91.5;
				i482.y = 1.1;
				i482.rotation = 42;
				i482.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -96.5;
				i482.y = 0.9;
				i482.rotation = 48;
				i482.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -101.3;
				i482.y = 1;
				i482.rotation = 54;
				i482.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -105.8;
				i482.rotation = 59;
				i482.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -110;
				i482.rotation = 64;
				i482.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -113.8;
				i482.y = 1.1;
				i482.rotation = 69;
				i482.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -117.3;
				i482.y = 1;
				i482.rotation = 73;
				i482.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -120.5;
				i482.y = 1.1;
				i482.rotation = 77;
				i482.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i481);
			f.Add(i482);
			f += () => {
				i482.x = -123.5;
				i482.y = 1;
				i482.rotation = 81;
				i482.alpha = 0;
			};
			f = l.Add();
			f.Add(i511);
			f.Add(i482);
			f += () => {
				i511.x = 0;
				i511.scaleX = 1;
				i511.y = 0;
				i511.scaleY = 1;
				i511.rotation = 0;
				i511.alpha = 1;
				i511.filters = new as3.Array(new object[]{});
				i511.scale9Grid = null;
				i511.visible = true;
				i482.x = -126;
				i482.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_15 : MovieClip{ 
		public symbol_15() {
			var i174 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i174);//0
		}
	}
	public class symbol_150 : MovieClip{ 
		public symbol_150() {
			var i487 = new symbol_140(){filters = new as3.Array(new object[]{})};
			addChild(i487);//0
		}
	}
	public class symbol_151 : MovieClip{ 
		public symbol_151() {
			var i485 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i485);//0
			var i512 = new symbol_142(){filters = new as3.Array(new object[]{})};
			addChild(i512);//0
			var i486 = new symbol_150(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i486);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i485.x = 0;
				i485.scaleX = 1;
				i485.y = 0;
				i485.scaleY = 1;
				i485.rotation = 0;
				i485.alpha = 1;
				i485.filters = new as3.Array(new object[]{});
				i485.scale9Grid = null;
				i485.visible = true;
				i486.x = -13;
				i486.scaleX = 0.43;
				i486.y = 1;
				i486.scaleY = 0.43;
				i486.rotation = 0;
				i486.alpha = 1;
				i486.filters = new as3.Array(new object[]{});
				i486.scale9Grid = null;
				i486.visible = true;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -36.7;
				i486.scaleX = 0.62;
				i486.y = 1.1;
				i486.scaleY = 0.62;
				i486.rotation = 11;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -56.8;
				i486.scaleX = 0.77;
				i486.y = 1;
				i486.scaleY = 0.77;
				i486.rotation = 21;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -73.2;
				i486.scaleX = 0.9;
				i486.scaleY = 0.9;
				i486.rotation = 29;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -86;
				i486.scaleX = 1;
				i486.scaleY = 1;
				i486.rotation = 35;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -91.5;
				i486.y = 1.1;
				i486.rotation = 42;
				i486.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -96.5;
				i486.y = 0.9;
				i486.rotation = 48;
				i486.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -101.3;
				i486.y = 1;
				i486.rotation = 54;
				i486.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -105.8;
				i486.rotation = 59;
				i486.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -110;
				i486.rotation = 64;
				i486.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -113.8;
				i486.y = 1.1;
				i486.rotation = 69;
				i486.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -117.3;
				i486.y = 1;
				i486.rotation = 73;
				i486.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -120.5;
				i486.y = 1.1;
				i486.rotation = 77;
				i486.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i485);
			f.Add(i486);
			f += () => {
				i486.x = -123.5;
				i486.y = 1;
				i486.rotation = 81;
				i486.alpha = 0;
			};
			f = l.Add();
			f.Add(i512);
			f.Add(i486);
			f += () => {
				i512.x = 0;
				i512.scaleX = 1;
				i512.y = 0;
				i512.scaleY = 1;
				i512.rotation = 0;
				i512.alpha = 1;
				i512.filters = new as3.Array(new object[]{});
				i512.scale9Grid = null;
				i512.visible = true;
				i486.x = -126;
				i486.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_152 : MovieClip{ 
		public symbol_152() {
			var i491 = new symbol_140(){filters = new as3.Array(new object[]{})};
			addChild(i491);//0
		}
	}
	public class symbol_153 : MovieClip{ 
		public symbol_153() {
			var i489 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i489);//0
			var i513 = new symbol_142(){filters = new as3.Array(new object[]{})};
			addChild(i513);//0
			var i490 = new symbol_152(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i490);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i489.x = 0;
				i489.scaleX = 1;
				i489.y = 0;
				i489.scaleY = 1;
				i489.rotation = 0;
				i489.alpha = 1;
				i489.filters = new as3.Array(new object[]{});
				i489.scale9Grid = null;
				i489.visible = true;
				i490.x = -13;
				i490.scaleX = 0.43;
				i490.y = 1;
				i490.scaleY = 0.43;
				i490.rotation = 0;
				i490.alpha = 1;
				i490.filters = new as3.Array(new object[]{});
				i490.scale9Grid = null;
				i490.visible = true;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -36.7;
				i490.scaleX = 0.62;
				i490.y = 1.1;
				i490.scaleY = 0.62;
				i490.rotation = 11;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -56.8;
				i490.scaleX = 0.77;
				i490.y = 1;
				i490.scaleY = 0.77;
				i490.rotation = 21;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -73.2;
				i490.scaleX = 0.9;
				i490.scaleY = 0.9;
				i490.rotation = 29;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -86;
				i490.scaleX = 1;
				i490.scaleY = 1;
				i490.rotation = 35;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -91.5;
				i490.y = 1.1;
				i490.rotation = 42;
				i490.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -96.5;
				i490.y = 0.9;
				i490.rotation = 48;
				i490.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -101.3;
				i490.y = 1;
				i490.rotation = 54;
				i490.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -105.8;
				i490.rotation = 59;
				i490.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -110;
				i490.rotation = 64;
				i490.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -113.8;
				i490.y = 1.1;
				i490.rotation = 69;
				i490.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -117.3;
				i490.y = 1;
				i490.rotation = 73;
				i490.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -120.5;
				i490.y = 1.1;
				i490.rotation = 77;
				i490.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i489);
			f.Add(i490);
			f += () => {
				i490.x = -123.5;
				i490.y = 1;
				i490.rotation = 81;
				i490.alpha = 0;
			};
			f = l.Add();
			f.Add(i513);
			f.Add(i490);
			f += () => {
				i513.x = 0;
				i513.scaleX = 1;
				i513.y = 0;
				i513.scaleY = 1;
				i513.rotation = 0;
				i513.alpha = 1;
				i513.filters = new as3.Array(new object[]{});
				i513.scale9Grid = null;
				i513.visible = true;
				i490.x = -126;
				i490.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_154 : MovieClip{ 
		public symbol_154() {
			var i495 = new symbol_140(){filters = new as3.Array(new object[]{})};
			addChild(i495);//0
		}
	}
	public class symbol_155 : MovieClip{ 
		public symbol_155() {
			var i514 = new symbol_142(){filters = new as3.Array(new object[]{})};
			addChild(i514);//0
			var i493 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i493);//0
			var i494 = new symbol_154(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i494);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i493.x = 0;
				i493.scaleX = 1;
				i493.y = 0;
				i493.scaleY = 1;
				i493.rotation = 0;
				i493.alpha = 1;
				i493.filters = new as3.Array(new object[]{});
				i493.scale9Grid = null;
				i493.visible = true;
				i494.x = -13;
				i494.scaleX = 0.43;
				i494.y = 1;
				i494.scaleY = 0.43;
				i494.rotation = 0;
				i494.alpha = 1;
				i494.filters = new as3.Array(new object[]{});
				i494.scale9Grid = null;
				i494.visible = true;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -36.7;
				i494.scaleX = 0.62;
				i494.y = 1.1;
				i494.scaleY = 0.62;
				i494.rotation = 11;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -56.8;
				i494.scaleX = 0.77;
				i494.y = 1;
				i494.scaleY = 0.77;
				i494.rotation = 21;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -73.2;
				i494.scaleX = 0.9;
				i494.scaleY = 0.9;
				i494.rotation = 29;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -86;
				i494.scaleX = 1;
				i494.scaleY = 1;
				i494.rotation = 35;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -91.5;
				i494.y = 1.1;
				i494.rotation = 42;
				i494.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -96.5;
				i494.y = 0.9;
				i494.rotation = 48;
				i494.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -101.3;
				i494.y = 1;
				i494.rotation = 54;
				i494.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -105.8;
				i494.rotation = 59;
				i494.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -110;
				i494.rotation = 64;
				i494.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -113.8;
				i494.y = 1.1;
				i494.rotation = 69;
				i494.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -117.3;
				i494.y = 1;
				i494.rotation = 73;
				i494.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -120.5;
				i494.y = 1.1;
				i494.rotation = 77;
				i494.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i493);
			f.Add(i494);
			f += () => {
				i494.x = -123.5;
				i494.y = 1;
				i494.rotation = 81;
				i494.alpha = 0;
			};
			f = l.Add();
			f.Add(i514);
			f.Add(i494);
			f += () => {
				i514.x = 0;
				i514.scaleX = 1;
				i514.y = 0;
				i514.scaleY = 1;
				i514.rotation = 0;
				i514.alpha = 1;
				i514.filters = new as3.Array(new object[]{});
				i514.scale9Grid = null;
				i514.visible = true;
				i494.x = -126;
				i494.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_156 : Shape{ 
		public symbol_156() {
			setGraphics("1ef3fe24543b84c895e7ac3c79bddee0", -28.3, -27.6, 56.6, 55.2, 1, 1);
		}
	}
	public class symbol_157 : MovieClip{ 
		public symbol_157() {
			var i499 = new symbol_156(){filters = new as3.Array(new object[]{})};
			addChild(i499);//0
		}
	}
	public class symbol_158 : Shape{ 
		public symbol_158() {
			setGraphics("7f2ec61cfabe48213f9d84960ce09428", -130.45, -5.5, 130.85, 13.9, 1, 1);
		}
	}
	public class symbol_159 : MovieClip{ 
		public symbol_159() {
			var i515 = new symbol_158(){filters = new as3.Array(new object[]{})};
			addChild(i515);//0
			var i497 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i497);//0
			var i498 = new symbol_157(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i498);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i497.x = 0;
				i497.scaleX = 1;
				i497.y = 0;
				i497.scaleY = 1;
				i497.rotation = 0;
				i497.alpha = 1;
				i497.filters = new as3.Array(new object[]{});
				i497.scale9Grid = null;
				i497.visible = true;
				i498.x = -13;
				i498.scaleX = 0.43;
				i498.y = 1;
				i498.scaleY = 0.43;
				i498.rotation = 0;
				i498.alpha = 1;
				i498.filters = new as3.Array(new object[]{});
				i498.scale9Grid = null;
				i498.visible = true;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -36.7;
				i498.scaleX = 0.62;
				i498.y = 1.1;
				i498.scaleY = 0.62;
				i498.rotation = 11;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -56.8;
				i498.scaleX = 0.77;
				i498.y = 1;
				i498.scaleY = 0.77;
				i498.rotation = 21;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -73.2;
				i498.scaleX = 0.9;
				i498.scaleY = 0.9;
				i498.rotation = 29;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -86;
				i498.scaleX = 1;
				i498.scaleY = 1;
				i498.rotation = 35;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -91.5;
				i498.y = 1.1;
				i498.rotation = 42;
				i498.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -96.5;
				i498.y = 0.9;
				i498.rotation = 48;
				i498.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -101.3;
				i498.y = 1;
				i498.rotation = 54;
				i498.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -105.8;
				i498.rotation = 59;
				i498.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -110;
				i498.rotation = 64;
				i498.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -113.8;
				i498.y = 1.1;
				i498.rotation = 69;
				i498.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -117.3;
				i498.y = 1;
				i498.rotation = 73;
				i498.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -120.5;
				i498.y = 1.1;
				i498.rotation = 77;
				i498.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i497);
			f.Add(i498);
			f += () => {
				i498.x = -123.5;
				i498.y = 1;
				i498.rotation = 81;
				i498.alpha = 0;
			};
			f = l.Add();
			f.Add(i515);
			f.Add(i498);
			f += () => {
				i515.x = 0;
				i515.scaleX = 1;
				i515.y = 0;
				i515.scaleY = 1;
				i515.rotation = 0;
				i515.alpha = 1;
				i515.filters = new as3.Array(new object[]{});
				i515.scale9Grid = null;
				i515.visible = true;
				i498.x = -126;
				i498.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_16 : MovieClip{ 
		public symbol_16() {
			var i179 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i179);//0
		}
	}
	public class symbol_160 : MovieClip{ 
		public symbol_160() {
			var i503 = new symbol_156(){filters = new as3.Array(new object[]{})};
			addChild(i503);//0
		}
	}
	public class symbol_161 : MovieClip{ 
		public symbol_161() {
			var i516 = new symbol_158(){filters = new as3.Array(new object[]{})};
			addChild(i516);//0
			var i501 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i501);//0
			var i502 = new symbol_160(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i502);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i501.x = 0;
				i501.scaleX = 1;
				i501.y = 0;
				i501.scaleY = 1;
				i501.rotation = 0;
				i501.alpha = 1;
				i501.filters = new as3.Array(new object[]{});
				i501.scale9Grid = null;
				i501.visible = true;
				i502.x = -13;
				i502.scaleX = 0.43;
				i502.y = 1;
				i502.scaleY = 0.43;
				i502.rotation = 0;
				i502.alpha = 1;
				i502.filters = new as3.Array(new object[]{});
				i502.scale9Grid = null;
				i502.visible = true;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -36.7;
				i502.scaleX = 0.62;
				i502.y = 1.1;
				i502.scaleY = 0.62;
				i502.rotation = 11;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -56.8;
				i502.scaleX = 0.77;
				i502.y = 1;
				i502.scaleY = 0.77;
				i502.rotation = 21;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -73.2;
				i502.scaleX = 0.9;
				i502.scaleY = 0.9;
				i502.rotation = 29;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -86;
				i502.scaleX = 1;
				i502.scaleY = 1;
				i502.rotation = 35;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -91.5;
				i502.y = 1.1;
				i502.rotation = 42;
				i502.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -96.5;
				i502.y = 0.9;
				i502.rotation = 48;
				i502.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -101.3;
				i502.y = 1;
				i502.rotation = 54;
				i502.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -105.8;
				i502.rotation = 59;
				i502.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -110;
				i502.rotation = 64;
				i502.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -113.8;
				i502.y = 1.1;
				i502.rotation = 69;
				i502.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -117.3;
				i502.y = 1;
				i502.rotation = 73;
				i502.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -120.5;
				i502.y = 1.1;
				i502.rotation = 77;
				i502.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i501);
			f.Add(i502);
			f += () => {
				i502.x = -123.5;
				i502.y = 1;
				i502.rotation = 81;
				i502.alpha = 0;
			};
			f = l.Add();
			f.Add(i516);
			f.Add(i502);
			f += () => {
				i516.x = 0;
				i516.scaleX = 1;
				i516.y = 0;
				i516.scaleY = 1;
				i516.rotation = 0;
				i516.alpha = 1;
				i516.filters = new as3.Array(new object[]{});
				i516.scale9Grid = null;
				i516.visible = true;
				i502.x = -126;
				i502.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_162 : MovieClip{ 
		public symbol_162() {
			var i507 = new symbol_156(){filters = new as3.Array(new object[]{})};
			addChild(i507);//0
		}
	}
	public class symbol_163 : MovieClip{ 
		public symbol_163() {
			var i505 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i505);//0
			var i517 = new symbol_158(){filters = new as3.Array(new object[]{})};
			addChild(i517);//0
			var i506 = new symbol_162(){x = -13 , scaleX = 0.43 , y = 1 , scaleY = 0.43 , filters = new as3.Array(new object[]{})};
			addChild(i506);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i505.x = 0;
				i505.scaleX = 1;
				i505.y = 0;
				i505.scaleY = 1;
				i505.rotation = 0;
				i505.alpha = 1;
				i505.filters = new as3.Array(new object[]{});
				i505.scale9Grid = null;
				i505.visible = true;
				i506.x = -13;
				i506.scaleX = 0.43;
				i506.y = 1;
				i506.scaleY = 0.43;
				i506.rotation = 0;
				i506.alpha = 1;
				i506.filters = new as3.Array(new object[]{});
				i506.scale9Grid = null;
				i506.visible = true;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -36.7;
				i506.scaleX = 0.62;
				i506.y = 1.1;
				i506.scaleY = 0.62;
				i506.rotation = 11;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -56.8;
				i506.scaleX = 0.77;
				i506.y = 1;
				i506.scaleY = 0.77;
				i506.rotation = 21;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -73.2;
				i506.scaleX = 0.9;
				i506.scaleY = 0.9;
				i506.rotation = 29;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -86;
				i506.scaleX = 1;
				i506.scaleY = 1;
				i506.rotation = 35;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -91.5;
				i506.y = 1.1;
				i506.rotation = 42;
				i506.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -96.5;
				i506.y = 0.9;
				i506.rotation = 48;
				i506.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -101.3;
				i506.y = 1;
				i506.rotation = 54;
				i506.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -105.8;
				i506.rotation = 59;
				i506.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -110;
				i506.rotation = 64;
				i506.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -113.8;
				i506.y = 1.1;
				i506.rotation = 69;
				i506.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -117.3;
				i506.y = 1;
				i506.rotation = 73;
				i506.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -120.5;
				i506.y = 1.1;
				i506.rotation = 77;
				i506.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i505);
			f.Add(i506);
			f += () => {
				i506.x = -123.5;
				i506.y = 1;
				i506.rotation = 81;
				i506.alpha = 0;
			};
			f = l.Add();
			f.Add(i517);
			f.Add(i506);
			f += () => {
				i517.x = 0;
				i517.scaleX = 1;
				i517.y = 0;
				i517.scaleY = 1;
				i517.rotation = 0;
				i517.alpha = 1;
				i517.filters = new as3.Array(new object[]{});
				i517.scale9Grid = null;
				i517.visible = true;
				i506.x = -126;
				i506.rotation = 84;
			};
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_164 : Shape{ 
		public symbol_164() {
			setGraphics("92eb0ec1c9fa1b7682b944b3772ce503", -19, -18.8, 38, 38, 1, 1);
		}
	}
	public class symbol_165 : Shape{ 
		public symbol_165() {
			setGraphics("ec55e9027c5d989b8fb9b42c38d72909", -21.5, -14.5, 43, 29, 1, 1);
		}
	}
	public class symbol_166 : MovieClip{ 
		public symbol_166() {
			var i521 = new symbol_165(){filters = new as3.Array(new object[]{})};
			addChild(i521);//0
		}
	}
	public class symbol_167 : Shape{ 
		public symbol_167() {
			setGraphics("059aa45cb8de205ced5ef89d30e688d2", -22.5, -17, 45, 34, 1, 1);
		}
	}
	public class symbol_168 : MovieClip{ 
		public symbol_168() {
			var i523 = new symbol_167(){filters = new as3.Array(new object[]{})};
			addChild(i523);//0
		}
	}
	public class symbol_169 : Shape{ 
		public symbol_169() {
			setGraphics("f27b3c08b4b29060ba021e63f772addc", 32, 28, 42, 46, 1, 1);
		}
	}
	public class symbol_17 : MovieClip{ 
		public symbol_17() {
			var i184 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i184);//0
		}
	}
	public class symbol_170 : Shape{ 
		public symbol_170() {
			setGraphics("8de6b92a0b510f3a7ef9f2365448825e", 6.25, 3.35, 86.5, 89.15, 1, 1);
		}
	}
	public class symbol_171 : Shape{ 
		public symbol_171() {
			setGraphics("ef1b84bd0c879b1b107fab3dd6fe6e05", -11.8, -11.7, 23.65, 23.45, 1, 1);
		}
	}
	public class symbol_172 : Shape{ 
		public symbol_172() {
			setGraphics("d8a4ba116ce5ffb650290061b9be7890", 0, 0, 20.3, 20.3, 1, 1);
		}
	}
	public class symbol_173 : Shape{ 
		public symbol_173() {
			setGraphics("8d4d7ed61a008cc12eb30530117f7924", 0, 0, 40, 43, 1, 1);
		}
	}
	public class symbol_174 : Shape{ 
		public symbol_174() {
			setGraphics("af888039a5ec52c4e1bbb28a07405c0d", -47.95, -40.75, 95.9, 81.45, 1, 1);
		}
	}
	public class symbol_175 : MovieClip{ 
		public symbol_175() {
			var i544 = new symbol_174(){filters = new as3.Array(new object[]{})};
			addChild(i544);//0
		}
	}
	public class symbol_176 : Shape{ 
		public symbol_176() {
			setGraphics("50065b964fb1957691f26d7660fb01be", -42.8, -14.4, 85.65, 28.8, 1, 1);
		}
	}
	public class symbol_177 : MovieClip{ 
		public symbol_177() {
			var i546 = new symbol_176(){filters = new as3.Array(new object[]{})};
			addChild(i546);//0
		}
	}
	public class symbol_178 : Shape{ 
		public symbol_178() {
			setGraphics("c328c656a9b5504cb3ae246115f2f72f", -91.8, -128.6, 183.6, 257.2, 1, 1);
		}
	}
	public class symbol_179 : MovieClip{ 
		public symbol_179() {
			var i548 = new symbol_178(){filters = new as3.Array(new object[]{})};
			addChild(i548);//0
		}
	}
	public class symbol_18 : MovieClip{ 
		public symbol_18() {
			var i189 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i189);//0
		}
	}
	public class symbol_180 : Shape{ 
		public symbol_180() {
			setGraphics("f6a2be8e4019c2be5db7f7d1893fada0", -36.1, -42.75, 72.2, 85.5, 1, 1);
		}
	}
	public class symbol_181 : MovieClip{ 
		public symbol_181() {
			var i550 = new symbol_180(){filters = new as3.Array(new object[]{})};
			addChild(i550);//0
		}
	}
	public class symbol_182 : Shape{ 
		public symbol_182() {
			setGraphics("9f6304a25067d4738103b15018131dac", -62.55, -82.5, 125.15, 165, 1, 1);
		}
	}
	public class symbol_183 : MovieClip{ 
		public symbol_183() {
			var i552 = new symbol_182(){filters = new as3.Array(new object[]{})};
			addChild(i552);//0
		}
	}
	public class symbol_184 : Shape{ 
		public symbol_184() {
			setGraphics("b0432f1e5be40771c28455c8610b7e21", -53.15, -69.25, 106.3, 138.45, 1, 1);
		}
	}
	public class symbol_185 : Shape{ 
		public symbol_185() {
			setGraphics("47a5514118504a552e35f0409408588b", -53.15, -69.25, 106.3, 138.45, 1, 1);
		}
	}
	public class symbol_186 : MovieClip{ 
		public symbol_186() {
			var i557 = new symbol_134(){filters = new as3.Array(new object[]{})};
			addChild(i557);//0
		}
	}
	public class symbol_187 : MovieClip{ 
		public symbol_187() {
			var i560 = new symbol_134(){filters = new as3.Array(new object[]{})};
			addChild(i560);//0
		}
	}
	public class symbol_188 : MovieClip{ 
		public symbol_188() {
			var i562 = new symbol_136(){filters = new as3.Array(new object[]{})};
			addChild(i562);//0
		}
	}
	public class symbol_189 : MovieClip{ 
		public symbol_189() {
			var i564 = new symbol_136(){filters = new as3.Array(new object[]{})};
			addChild(i564);//0
		}
	}
	public class symbol_19 : MovieClip{ 
		public symbol_19() {
			var i194 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i194);//0
		}
	}
	public class symbol_190 : Shape{ 
		public symbol_190() {
			setGraphics("07724813a9bf12a9e1aa37ae05a53fd1", -11.6, -11.6, 23.25, 23.25, 1, 1);
		}
	}
	public class symbol_191 : MovieClip{ 
		public symbol_191() {
			var i567 = new symbol_190(){filters = new as3.Array(new object[]{})};
			addChild(i567);//0
		}
	}
	public class symbol_192 : Shape{ 
		public symbol_192() {
			setGraphics("166d7553e6f02b47cf4d1a693936881c", 0, 0, 28, 28, 1, 1);
		}
	}
	public class symbol_193 : Shape{ 
		public symbol_193() {
			setGraphics("60cf3de8180aafd983d5998cc8eda2bf", 0, 0, 6.95, 12.25, 1, 1);
		}
	}
	public class symbol_194 : Shape{ 
		public symbol_194() {
			setGraphics("03d240bcd7a42a859d3881e1b92c4caf", 0, 0, 18.25, 62.2, 1, 1);
		}
	}
	public class symbol_195 : MovieClip{ 
		public symbol_195() {
			var i703 = new symbol_194(){filters = new as3.Array(new object[]{})};
			addChild(i703);//0
		}
	}
	public class symbol_196 : Shape{ 
		public symbol_196() {
			setGraphics("a3651de718f9d81fb26d33d2f9ca23d4", 0, 0, 45.5, 35, 1, 1);
		}
	}
	public class symbol_197 : Shape{ 
		public symbol_197() {
			setGraphics("4f44772646f70f437816def67e40fcda", -26.1, -26.5, 52.150000000000006, 53, 1, 1);
		}
	}
	public class symbol_198 : Shape{ 
		public symbol_198() {
			setGraphics("71aa2fe8ff4e35e66b5aa8e09875cc61", 0, 0, 11, 13, 1, 1);
		}
	}
	public class symbol_199 : Shape{ 
		public symbol_199() {
			setGraphics("bdae3c6d4abbc057b8c5d91c7f0549ac", 0, 0, 18.3, 18.3, 1, 1);
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("84c698fd8b05fab0a799d0e2824499d1", -16.4, -15.65, 32.849999999999994, 31.25, 1, 1);
		}
	}
	public class symbol_20 : MovieClip{ 
		public symbol_20() {
			var i199 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i199);//0
		}
	}
	public class symbol_200 : Shape{ 
		public symbol_200() {
			setGraphics("0a5b075f9f4315d6cdedde26495af679", -6.15, -6.15, 12.3, 12.3, 1, 1);
		}
	}
	public class symbol_201 : Shape{ 
		public symbol_201() {
			setGraphics("c398d75a732683b7262d3c87048894b0", 0, 0, 106, 106, 1, 1);
		}
	}
	public class symbol_202 : Shape{ 
		public symbol_202() {
			setGraphics("ea009f038860c48f3ea438420cd54122", -46.25, -45.55, 92.55, 91.1, 1, 1);
		}
	}
	public class symbol_203 : MovieClip{ 
		public symbol_203() {
			var i731 = new symbol_202(){filters = new as3.Array(new object[]{})};
			addChild(i731);//0
		}
	}
	public class symbol_204 : Shape{ 
		public symbol_204() {
			setGraphics("26e85619f48a17e21f23f2ed845d5bbe", -43.85, -49.1, 87.7, 98.2, 1, 1);
		}
	}
	public class symbol_205 : MovieClip{ 
		public symbol_205() {
			var i733 = new symbol_204(){filters = new as3.Array(new object[]{})};
			addChild(i733);//0
		}
	}
	public class symbol_206 : Shape{ 
		public symbol_206() {
			setGraphics("8b8fe16d040f04ec6c2f187b874052c4", -45.15, -47.8, 90.35, 95.65, 1, 1);
		}
	}
	public class symbol_207 : MovieClip{ 
		public symbol_207() {
			var i735 = new symbol_206(){filters = new as3.Array(new object[]{})};
			addChild(i735);//0
		}
	}
	public class symbol_208 : Shape{ 
		public symbol_208() {
			setGraphics("5b53f607be50658f032b811567adc49c", -45.8, -44.8, 91.6, 89.65, 1, 1);
		}
	}
	public class symbol_209 : MovieClip{ 
		public symbol_209() {
			var i737 = new symbol_208(){filters = new as3.Array(new object[]{})};
			addChild(i737);//0
		}
	}
	public class symbol_21 : MovieClip{ 
		public symbol_21() {
			var i204 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i204);//0
		}
	}
	public class symbol_210 : MovieClip{ 
		public symbol_210() {
			var i739 = new symbol_202(){filters = new as3.Array(new object[]{})};
			addChild(i739);//0
		}
	}
	public class symbol_211 : Shape{ 
		public symbol_211() {
			setGraphics("67cd4db60b688f860f4a124e34378d6e", -7.8, -4.95, 11, 11, 1, 1);
		}
	}
	public class symbol_212 : Shape{ 
		public symbol_212() {
			setGraphics("077345c18849f37452b1247d1659b5e2", 0, 0, 194.8, 151.3, 1, 1);
		}
	}
	public class symbol_213 : Shape{ 
		public symbol_213() {
			setGraphics("afa6e5e421160ccdb794f2d2c9c8130b", -0.5, -0.5, 34.45, 33.1, 1, 1);
		}
	}
	public class symbol_214 : Shape{ 
		public symbol_214() {
			setGraphics("8a19db0713450e5bc35a9c47719673e0", 3.75, 5.6, 17.1, 9, 1, 1);
		}
	}
	public class symbol_215 : MovieClip{ 
		public symbol_215() {
			var filter_0 = new GlowFilter(){strength = 9.23, color = 10780723, blurX = 3, blurY = 3};
			var i745 = new symbol_213(){filters = new as3.Array(new object[]{})};
			addChild(i745);//0
			var i746 = new resources_fla.vip_97(){x = -25.8 , y = -11.8 , filters = new as3.Array(new object[]{filter_0})};
			addChild(i746);//1
			var i750 = new symbol_214(){filters = new as3.Array(new object[]{})};
			addChild(i750);//2
		}
	}
	public class symbol_216 : Shape{ 
		public symbol_216() {
			setGraphics("1d9b2d161fac751d5eb9124d49f0e947", -0.5, 3.85, 64.9, 57.199999999999996, 1, 1);
		}
	}
	public class symbol_217 : MovieClip{ 
		public symbol_217() {
			var i752 = new symbol_216(){filters = new as3.Array(new object[]{})};
			addChild(i752);//0
		}
	}
	public class symbol_218 : Shape{ 
		public symbol_218() {
			setGraphics("e52245f95a3867349e10e99ef45cc7e8", -0.5, -0.5, 92.45, 81.35, 1, 1);
		}
	}
	public class symbol_219 : MovieClip{ 
		public symbol_219() {
			var i754 = new symbol_218(){filters = new as3.Array(new object[]{})};
			addChild(i754);//0
		}
	}
	public class symbol_22 : MovieClip{ 
		public symbol_22() {
			var i209 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i209);//0
		}
	}
	public class symbol_220 : Shape{ 
		public symbol_220() {
			setGraphics("5cc649e5fcb173b4bde1ac46a47e4c2b", 34.95, 28.85, 52.64999999999999, 71.75, 1, 1);
		}
	}
	public class symbol_221 : MovieClip{ 
		public symbol_221() {
			var i756 = new symbol_220(){filters = new as3.Array(new object[]{})};
			addChild(i756);//0
			FrameInfo f;
			var l= new Frames(24);
			f = l.Add();
			f.Add(i756);
			f += () => {
				i756.x = 0;
				i756.scaleX = 1;
				i756.y = 0;
				i756.scaleY = 1;
				i756.rotation = 0;
				i756.alpha = 1;
				i756.filters = new as3.Array(new object[]{});
				i756.scale9Grid = null;
				i756.visible = true;
			};
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			f = l.Add();
			f.Add(i756);
			setFrames(l);
		}
	}
	public class symbol_222 : Shape{ 
		public symbol_222() {
			setGraphics("fe344f72a25fddb4d3d1f433fae21ab3", -0.5, -0.5, 81.75, 85.8, 1, 1);
		}
	}
	public class symbol_223 : Shape{ 
		public symbol_223() {
			setGraphics("f77be51acec4338af49967fd50e9db01", -0.1, 0.05, 32.85, 44.300000000000004, 1, 1);
		}
	}
	public class symbol_224 : MovieClip{ 
		public symbol_224() {
			var i761 = new symbol_223(){filters = new as3.Array(new object[]{})};
			addChild(i761);//0
		}
	}
	public class symbol_225 : Shape{ 
		public symbol_225() {
			setGraphics("1df68fc73eb56553baf5d0e59c727f69", 29.05, 42.6, 10.2, 7.949999999999996, 1, 1);
		}
	}
	public class symbol_226 : Shape{ 
		public symbol_226() {
			setGraphics("b1231245a3295abccf4c14f6c9e0e4a4", 0, 0, 55.45, 35.15, 1, 1);
		}
	}
	public class symbol_227 : MovieClip{ 
		public symbol_227() {
			var i764 = new symbol_226(){filters = new as3.Array(new object[]{})};
			addChild(i764);//0
		}
	}
	public class symbol_228 : Shape{ 
		public symbol_228() {
			setGraphics("4b62196a2776643559437c077747d800", -11.35, 1, 65.55, 37.05, 1, 1);
		}
	}
	public class symbol_229 : MovieClip{ 
		public symbol_229() {
			var i758 = new symbol_222(){filters = new as3.Array(new object[]{})};
			addChild(i758);//0
			var i759 = new symbol_4(){filters = new as3.Array(new object[]{})};
			addChild(i759);//1
			var i769 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i769);//2
			var i760 = new symbol_224(){x = 25.9 , scaleX = 0.6 , y = 39.8 , scaleY = 0.41 , rotation = -7 , filters = new as3.Array(new object[]{})};
			addChild(i760);//2
			var i770 = new symbol_228(){filters = new as3.Array(new object[]{})};
			addChild(i770);//2
			var i762 = new symbol_225(){filters = new as3.Array(new object[]{})};
			addChild(i762);//3
			var i763 = new symbol_227(){x = 0.1 , scaleX = 0.7 , y = 12.3 , scaleY = 0.6 , rotation = -4 , filters = new as3.Array(new object[]{})};
			addChild(i763);//4
			FrameInfo f;
			var l= new Frames(175);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i758.x = 0;
				i758.scaleX = 1;
				i758.y = 0;
				i758.scaleY = 1;
				i758.rotation = 0;
				i758.alpha = 1;
				i758.filters = new as3.Array(new object[]{});
				i758.scale9Grid = null;
				i758.visible = true;
				i759.x = 0;
				i759.scaleX = 1;
				i759.y = 0;
				i759.scaleY = 1;
				i759.rotation = 0;
				i759.alpha = 1;
				i759.filters = new as3.Array(new object[]{});
				i759.scale9Grid = null;
				i759.visible = true;
				i760.x = 25.9;
				i760.scaleX = 0.6;
				i760.y = 39.8;
				i760.scaleY = 0.41;
				i760.rotation = -7;
				i760.alpha = 1;
				i760.filters = new as3.Array(new object[]{});
				i760.scale9Grid = null;
				i760.visible = true;
				i762.x = 0;
				i762.scaleX = 1;
				i762.y = 0;
				i762.scaleY = 1;
				i762.rotation = 0;
				i762.alpha = 1;
				i762.filters = new as3.Array(new object[]{});
				i762.scale9Grid = null;
				i762.visible = true;
				i763.x = 0.1;
				i763.scaleX = 0.7;
				i763.y = 12.3;
				i763.scaleY = 0.6;
				i763.rotation = -4;
				i763.alpha = 1;
				i763.filters = new as3.Array(new object[]{});
				i763.scale9Grid = null;
				i763.visible = true;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.1;
				i760.y = 39.5;
				i760.scaleY = 0.42;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26;
				i760.rotation = -6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.1;
				i760.y = 39.3;
				i760.scaleY = 0.43;
				i763.y = 12.1;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 39;
				i760.scaleY = 0.44;
				i763.y = 11.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.2;
				i763.x = 0;
				i763.y = 11.7;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 38.8;
				i760.scaleY = 0.45;
				i760.rotation = -5;
				i763.y = 11.6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.3;
				i760.y = 38.6;
				i760.scaleY = 0.46;
				i763.y = 11.4;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.4;
				i760.y = 38.4;
				i763.y = 11.2;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 38.2;
				i760.scaleY = 0.47;
				i763.y = 11.1;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 38;
				i760.scaleY = 0.48;
				i763.x = -0.1;
				i763.y = 10.9;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.rotation = -4;
				i763.y = 10.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.6;
				i760.y = 37.8;
				i760.scaleY = 0.49;
				i763.y = 10.6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 37.5;
				i760.scaleY = 0.5;
				i763.x = -0.2;
				i763.y = 10.4;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.7;
				i760.y = 37.4;
				i763.x = -0.3;
				i763.y = 10.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 37.2;
				i760.scaleY = 0.51;
				i760.rotation = -3;
				i763.y = 10.1;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.8;
				i760.y = 37;
				i760.scaleY = 0.52;
				i763.y = 9.9;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.9;
				i760.y = 36.9;
				i763.y = 9.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 36.6;
				i760.scaleY = 0.53;
				i763.y = 9.6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27;
				i760.y = 36.5;
				i760.scaleY = 0.54;
				i760.rotation = -2;
				i763.x = -0.4;
				i763.y = 9.4;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.1;
				i760.y = 36.4;
				i763.y = 9.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.2;
				i760.y = 36.2;
				i760.scaleY = 0.55;
				i763.x = -0.5;
				i763.y = 9.2;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.3;
				i760.y = 36;
				i760.scaleY = 0.56;
				i763.y = 9.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 35.9;
				i760.rotation = -1;
				i763.x = -0.4;
				i763.y = 9.6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.4;
				i760.y = 35.6;
				i760.scaleY = 0.57;
				i763.y = 9.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 35.5;
				i760.scaleY = 0.58;
				i763.x = -0.3;
				i763.y = 9.9;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.5;
				i760.y = 35.3;
				i763.y = 10.1;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.6;
				i760.y = 35.1;
				i760.scaleY = 0.59;
				i760.rotation = 0;
				i763.y = 10.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 35;
				i760.scaleY = 0.6;
				i763.y = 10.5;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i769.x = 0;
				i769.scaleX = 1;
				i769.y = 0;
				i769.scaleY = 1;
				i769.rotation = 0;
				i769.alpha = 1;
				i769.filters = new as3.Array(new object[]{});
				i769.scale9Grid = null;
				i769.visible = true;
				i763.x = -0.2;
				i763.y = 10.7;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.1;
				i763.y = 10.9;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 11.1;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 11.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = 0;
				i763.y = 11.5;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 11.7;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 11.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 12.1;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = 0.1;
				i763.y = 12.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 12;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = 0;
				i763.y = 11.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 11.6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 11.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 11.2;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.1;
				i763.y = 10.9;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 10.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 10.6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.2;
				i763.y = 10.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.3;
				i763.y = 10.2;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 9.9;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 9.7;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 9.5;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.4;
				i763.y = 9.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.5;
				i763.y = 9.2;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 9.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.4;
				i763.y = 9.6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 9.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.3;
				i763.y = 10;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 10.2;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 10.4;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.2;
				i763.y = 10.6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 10.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.x = -0.1;
				i763.y = 11;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i763.y = 11.2;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.5;
				i760.y = 35.3;
				i760.scaleY = 0.59;
				i760.rotation = -1;
				i763.x = 0;
				i763.y = 11.4;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.4;
				i760.y = 35.4;
				i760.scaleY = 0.58;
				i763.y = 11.7;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 35.7;
				i760.scaleY = 0.57;
				i763.y = 11.8;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.3;
				i760.y = 35.9;
				i760.scaleY = 0.56;
				i763.y = 12.1;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.2;
				i760.y = 36.1;
				i760.scaleY = 0.55;
				i760.rotation = -2;
				i763.x = 0.1;
				i763.y = 12.3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 27.1;
				i760.y = 36.4;
				i760.scaleY = 0.54;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 36.6;
				i760.scaleY = 0.53;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.9;
				i760.y = 36.9;
				i760.rotation = -3;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.8;
				i760.y = 37.1;
				i760.scaleY = 0.52;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.7;
				i760.y = 37.3;
				i760.scaleY = 0.51;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 37.5;
				i760.scaleY = 0.5;
				i760.rotation = -4;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.6;
				i760.y = 37.8;
				i760.scaleY = 0.49;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.4;
				i760.y = 37.9;
				i760.scaleY = 0.48;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 38.2;
				i760.scaleY = 0.47;
				i760.rotation = -5;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 38.4;
				i760.scaleY = 0.46;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.3;
				i760.y = 38.6;
				i760.scaleY = 0.45;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.1;
				i760.y = 38.9;
				i760.rotation = -6;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.y = 39;
				i760.scaleY = 0.44;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26;
				i760.y = 39.4;
				i760.scaleY = 0.43;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 26.1;
				i760.y = 39.5;
				i760.scaleY = 0.42;
				i760.rotation = -7;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i760.x = 25.9;
				i760.y = 39.8;
				i760.scaleY = 0.41;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i769);
			f.Add(i760);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f += () => {
				i770.x = 0;
				i770.scaleX = 1;
				i770.y = 0;
				i770.scaleY = 1;
				i770.rotation = 0;
				i770.alpha = 1;
				i770.filters = new as3.Array(new object[]{});
				i770.scale9Grid = null;
				i770.visible = true;
			};
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			f = l.Add();
			f.Add(i758);
			f.Add(i759);
			f.Add(i760);
			f.Add(i770);
			f.Add(i762);
			f.Add(i763);
			setFrames(l);
		}
	}
	public class symbol_23 : MovieClip{ 
		public symbol_23() {
			var i214 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i214);//0
		}
	}
	public class symbol_230 : MovieClip{ 
		public symbol_230() {
			var i768 = new symbol_194(){filters = new as3.Array(new object[]{})};
			addChild(i768);//0
		}
	}
	public class symbol_231 : Shape{ 
		public symbol_231() {
			setGraphics("5cc649e5fcb173b4bde1ac46a47e4c2b", 34.95, 28.85, 52.64999999999999, 71.75, 1, 1);
		}
	}
	public class symbol_232 : MovieClip{ 
		public symbol_232() {
			var i773 = new symbol_40(){y = 0 , filters = new as3.Array(new object[]{})};
			addChild(i773);//0
		}
	}
	public class symbol_233 : MovieClip{ 
		public symbol_233() {
			var i775 = new symbol_40(){y = 0 , filters = new as3.Array(new object[]{})};
			addChild(i775);//0
		}
	}
	public class symbol_234 : Shape{ 
		public symbol_234() {
			setGraphics("95a8717af71668eb25ff4d97fe4e743a", -78.8, -52.95, 157.6, 105.95, 1, 1);
		}
	}
	public class symbol_235 : MovieClip{ 
		public symbol_235() {
			var i777 = new symbol_234(){filters = new as3.Array(new object[]{})};
			addChild(i777);//0
		}
	}
	public class symbol_236 : MovieClip{ 
		public symbol_236() {
			var i779 = new symbol_231(){filters = new as3.Array(new object[]{})};
			addChild(i779);//0
			FrameInfo f;
			var l= new Frames(24);
			f = l.Add();
			f.Add(i779);
			f += () => {
				i779.x = 0;
				i779.scaleX = 1;
				i779.y = 0;
				i779.scaleY = 1;
				i779.rotation = 0;
				i779.alpha = 1;
				i779.filters = new as3.Array(new object[]{});
				i779.scale9Grid = null;
				i779.visible = true;
			};
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			f = l.Add();
			f.Add(i779);
			setFrames(l);
		}
	}
	public class symbol_237 : Shape{ 
		public symbol_237() {
			setGraphics("ad3785a109fa32aa0af95d7124c0a5d1", -25.5, -18.5, 48.1, 41.1, 1, 1);
		}
	}
	public class symbol_238 : MovieClip{ 
		public symbol_238() {
			var i781 = new symbol_237(){filters = new as3.Array(new object[]{})};
			addChild(i781);//0
		}
	}
	public class symbol_239 : MovieClip{ 
		public symbol_239() {
			var i784 = new symbol_231(){filters = new as3.Array(new object[]{})};
			addChild(i784);//0
			FrameInfo f;
			var l= new Frames(24);
			f = l.Add();
			f.Add(i784);
			f += () => {
				i784.x = 0;
				i784.scaleX = 1;
				i784.y = 0;
				i784.scaleY = 1;
				i784.rotation = 0;
				i784.alpha = 1;
				i784.filters = new as3.Array(new object[]{});
				i784.scale9Grid = null;
				i784.visible = true;
			};
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			f = l.Add();
			f.Add(i784);
			setFrames(l);
		}
	}
	public class symbol_24 : MovieClip{ 
		public symbol_24() {
			var i219 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i219);//0
		}
	}
	public class symbol_240 : MovieClip{ 
		public symbol_240() {
			var i786 = new symbol_40(){y = 0 , filters = new as3.Array(new object[]{})};
			addChild(i786);//0
		}
	}
	public class symbol_241 : Shape{ 
		public symbol_241() {
			setGraphics("b09c78830a20f6279a909c7379242182", -14.55, -9.5, 29.15, 19, 1, 1);
		}
	}
	public class symbol_242 : MovieClip{ 
		public symbol_242() {
			var i788 = new symbol_241(){y = 0 , filters = new as3.Array(new object[]{})};
			addChild(i788);//0
		}
	}
	public class symbol_243 : Shape{ 
		public symbol_243() {
			setGraphics("95a8717af71668eb25ff4d97fe4e743a", -78.8, -52.95, 157.6, 105.95, 1, 1);
		}
	}
	public class symbol_244 : MovieClip{ 
		public symbol_244() {
			var i790 = new symbol_243(){filters = new as3.Array(new object[]{})};
			addChild(i790);//0
		}
	}
	public class symbol_245 : Shape{ 
		public symbol_245() {
			setGraphics("e98bd26d81b50c8e5d14a2e8edac2b87", 0, 0, 7, 13, 1, 1);
		}
	}
	public class symbol_25 : MovieClip{ 
		public symbol_25() {
			var i224 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i224);//0
		}
	}
	public class symbol_26 : MovieClip{ 
		public symbol_26() {
			var i229 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i229);//0
		}
	}
	public class symbol_27 : MovieClip{ 
		public symbol_27() {
			var i234 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i234);//0
		}
	}
	public class symbol_28 : MovieClip{ 
		public symbol_28() {
			var i120 = new resources_fla.staranim3_69(){scaleX = 0.74 , filters = new as3.Array(new object[]{}) , scaleY = 0.74};
			addChild(i120);//0
			var i125 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.52 , scaleY = 0.52 , filters = new as3.Array(new object[]{}) , rotation = -29};
			addChild(i125);//1
			var i130 = new resources_fla.staranim3_69(){x = 0.1 , scaleX = 0.67 , y = 0 , scaleY = 0.67 , rotation = -89 , filters = new as3.Array(new object[]{})};
			addChild(i130);//2
			var i135 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.73 , y = 0 , scaleY = 0.73 , rotation = -134 , filters = new as3.Array(new object[]{})};
			addChild(i135);//3
			var i140 = new resources_fla.staranim3_69(){x = 0.1 , scaleX = 0.66 , y = 0.1 , scaleY = 0.66 , rotation = 165 , filters = new as3.Array(new object[]{})};
			addChild(i140);//4
			var i145 = new resources_fla.staranim3_69(){x = 0.1 , scaleX = 0.51 , y = 0.1 , scaleY = 0.51 , rotation = 120 , filters = new as3.Array(new object[]{})};
			addChild(i145);//5
			var i150 = new resources_fla.staranim3_69(){x = 0.1 , scaleX = 0.51 , y = 0.1 , scaleY = 0.51 , rotation = 75 , filters = new as3.Array(new object[]{})};
			addChild(i150);//6
			var i155 = new resources_fla.staranim3_69(){scaleX = 0.65 , scaleY = 0.65 , filters = new as3.Array(new object[]{}) , rotation = -14};
			addChild(i155);//7
			var i160 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.62 , y = 0 , scaleY = 0.62 , rotation = 45 , filters = new as3.Array(new object[]{})};
			addChild(i160);//8
			var i165 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.36 , y = 0 , scaleY = 0.36 , rotation = -59 , filters = new as3.Array(new object[]{})};
			addChild(i165);//9
			var i170 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.36 , y = 0.1 , scaleY = 0.36 , rotation = 0 , filters = new as3.Array(new object[]{})};
			addChild(i170);//10
			var i175 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.36 , y = 0.1 , scaleY = 0.36 , rotation = 105 , filters = new as3.Array(new object[]{})};
			addChild(i175);//11
			var i180 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.36 , y = 0.1 , scaleY = 0.36 , rotation = 165 , filters = new as3.Array(new object[]{})};
			addChild(i180);//12
			var i185 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.36 , y = 0.1 , scaleY = 0.36 , rotation = 180 , filters = new as3.Array(new object[]{})};
			addChild(i185);//13
			var i190 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.36 , y = 0 , scaleY = 0.36 , rotation = -135 , filters = new as3.Array(new object[]{})};
			addChild(i190);//14
			var i195 = new resources_fla.staranim3_69(){scaleX = 0.36 , y = 0 , scaleY = 0.36 , filters = new as3.Array(new object[]{}) , rotation = -119};
			addChild(i195);//15
			var i200 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.36 , y = 0.1 , scaleY = 0.36 , rotation = 44 , filters = new as3.Array(new object[]{})};
			addChild(i200);//16
			var i205 = new resources_fla.staranim3_69(){scaleX = 0.36 , y = 0.2 , scaleY = 0.36 , filters = new as3.Array(new object[]{}) , rotation = 89};
			addChild(i205);//17
			var i210 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.36 , y = 0 , scaleY = 0.36 , rotation = -45 , filters = new as3.Array(new object[]{})};
			addChild(i210);//18
			var i215 = new resources_fla.staranim3_69(){x = 0 , scaleX = 0.55 , scaleY = 0.55 , filters = new as3.Array(new object[]{}) , rotation = 29};
			addChild(i215);//19
			var i220 = new resources_fla.staranim3_69(){x = -0.1 , scaleX = 0.55 , y = -0.1 , scaleY = 0.55 , rotation = 89 , filters = new as3.Array(new object[]{})};
			addChild(i220);//20
			var i225 = new resources_fla.staranim3_69(){x = -0.1 , scaleX = 0.55 , y = -0.1 , scaleY = 0.55 , rotation = 104 , filters = new as3.Array(new object[]{})};
			addChild(i225);//21
			var i230 = new resources_fla.staranim3_69(){x = 0.2 , scaleX = 0.55 , y = -0.1 , scaleY = 0.55 , rotation = -150 , filters = new as3.Array(new object[]{})};
			addChild(i230);//22
		}
	}
	public class symbol_29 : Shape{ 
		public symbol_29() {
			setGraphics("9d07b7dd01e09f364cb2a94e47a5eae0", -63, -63, 126, 126, 1, 1);
		}
	}
	public class symbol_3 : MovieClip{ 
		public symbol_3() {
			var i124 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i124);//0
		}
	}
	public class symbol_30 : Shape{ 
		public symbol_30() {
			setGraphics("6b1ec13d238baf902fe5b7144c90903a", 2.4, -23.2, 122.25, 143.54999999999998, 1, 1);
		}
	}
	public class symbol_31 : Shape{ 
		public symbol_31() {
			setGraphics("ff992b91d35ca27dab5d476366a83449", 0, 0, 372.1, 365.45, 1, 1);
		}
	}
	public class symbol_32 : Shape{ 
		public symbol_32() {
			setGraphics("8711cfb1cced39739118560f51ec9249", 6.55, 0, 212.5, 198.1, 1, 1);
		}
	}
	public class symbol_33 : MovieClip{ 
		public symbol_33() {
			var i311 = new symbol_32(){filters = new as3.Array(new object[]{})};
			addChild(i311);//0
		}
	}
	public class symbol_34 : Shape{ 
		public symbol_34() {
			setGraphics("c0ba48f71314e6772e0761c3d166ea7a", 0, 0, 189.55, 40.15, 1, 1);
		}
	}
	public class symbol_35 : MovieClip{ 
		public symbol_35() {
		}
	}
	public class symbol_36 : MovieClip{ 
		public symbol_36() {
			var filter_0 = new GlowFilter(){color = 16777215, blurX = 39.88, blurY = 39.88};
			var filter_1 = new GlowFilter(){color = 16777215, blurX = 41.88, blurY = 41.88};
			var filter_2 = new GlowFilter(){color = 16777215, blurX = 48.21, blurY = 48.21};
			var filter_3 = new GlowFilter(){color = 16777215, blurX = 41.40, blurY = 41.40};
			var filter_4 = new GlowFilter(){color = 16777215, blurX = 42.67, blurY = 42.67};
			var filter_5 = new GlowFilter(){color = 16777215, blurX = 37.60, blurY = 37.60};
			var filter_6 = new GlowFilter(){color = 16777215, blurX = 34.75, blurY = 34.75};
			var filter_7 = new GlowFilter(){color = 16777215, blurX = 31.58, blurY = 31.58};
			var filter_8 = new GlowFilter(){color = 16777215, blurX = 38.71, blurY = 38.71};
			var filter_9 = new GlowFilter(){color = 16777215, blurX = 45.83, blurY = 45.83};
			var filter_10 = new GlowFilter(){color = 16777215, blurX = 31.52, blurY = 31.52};
			var filter_11 = new GlowFilter(){color = 16777215, blurX = 40.64, blurY = 40.64};
			var filter_12 = new GlowFilter(){color = 16777215, blurX = 45.96, blurY = 45.96};
			var filter_13 = new GlowFilter(){color = 16777215, blurX = 30.79, blurY = 30.79};
			var filter_14 = new GlowFilter(){color = 16777215, blurX = 45.20, blurY = 45.20};
			var filter_15 = new GlowFilter(){color = 16777215, blurX = 40.29, blurY = 40.29};
			var filter_16 = new GlowFilter(){color = 16777215, blurX = 32.28, blurY = 32.28};
			var filter_17 = new GlowFilter(){color = 16777215, blurX = 42.16, blurY = 42.16};
			var filter_18 = new GlowFilter(){color = 16777215, blurX = 35.54, blurY = 35.54};
			var filter_19 = new GlowFilter(){color = 16777215, blurX = 46.63, blurY = 46.63};
			var filter_20 = new GlowFilter(){color = 16777215, blurX = 36.08, blurY = 36.08};
			var filter_21 = new GlowFilter(){color = 16777215, blurX = 43.46, blurY = 43.46};
			var filter_22 = new GlowFilter(){color = 16777215, blurX = 33.80, blurY = 33.80};
			var filter_23 = new GlowFilter(){color = 16777215, blurX = 41.08, blurY = 41.08};
			var filter_24 = new GlowFilter(){color = 16777215, blurX = 33.96, blurY = 33.96};
			var filter_25 = new GlowFilter(){color = 16777215, blurX = 47.42, blurY = 47.42};
			var filter_26 = new GlowFilter(){color = 16777215, blurX = 44.25, blurY = 44.25};
			var filter_27 = new GlowFilter(){color = 16777215, blurX = 45.04, blurY = 45.04};
			var filter_28 = new GlowFilter(){color = 16777215, blurX = 49, blurY = 49};
			var filter_29 = new GlowFilter(){color = 16777215, blurX = 35.32, blurY = 35.32};
			var filter_30 = new GlowFilter(){color = 16777215, blurX = 37.92, blurY = 37.92};
			var filter_31 = new GlowFilter(){color = 16777215, blurX = 43.68, blurY = 43.68};
			var filter_32 = new GlowFilter(){color = 16777215, blurX = 30, blurY = 30};
			var filter_33 = new GlowFilter(){color = 16777215, blurX = 42.92, blurY = 42.92};
			var filter_34 = new GlowFilter(){color = 16777215, blurX = 33.04, blurY = 33.04};
			var filter_35 = new GlowFilter(){color = 16777215, blurX = 30.76, blurY = 30.76};
			var filter_36 = new GlowFilter(){color = 16777215, blurX = 39.12, blurY = 39.12};
			var filter_37 = new GlowFilter(){color = 16777215, blurX = 47.48, blurY = 47.48};
			var filter_38 = new GlowFilter(){color = 16777215, blurX = 39.50, blurY = 39.50};
			var filter_39 = new GlowFilter(){color = 16777215, blurX = 38.36, blurY = 38.36};
			var filter_40 = new GlowFilter(){color = 16777215, blurX = 34.56, blurY = 34.56};
			var filter_41 = new GlowFilter(){color = 16777215, blurX = 44.44, blurY = 44.44};
			var filter_42 = new GlowFilter(){color = 16777215, blurX = 48.24, blurY = 48.24};
			var filter_43 = new GlowFilter(){color = 16777215, blurX = 37.13, blurY = 37.13};
			var filter_44 = new GlowFilter(){color = 16777215, blurX = 46.72, blurY = 46.72};
			var filter_45 = new GlowFilter(){color = 16777215, blurX = 36.33, blurY = 36.33};
			var filter_46 = new GlowFilter(){color = 16777215, blurX = 36.84, blurY = 36.84};
			var filter_47 = new GlowFilter(){color = 16777215, blurX = 32.38, blurY = 32.38};
			var filter_48 = new GlowFilter(){color = 16777215, blurX = 33.17, blurY = 33.17};
			var i312 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i312);//0
			var i313 = new symbol_35(){x = 13.7 , scaleX = 1.03 , y = 3 , scaleY = 0.97 , filters = new as3.Array(new object[]{filter_28})};
			addChild(i313);//1
			FrameInfo f;
			var l= new Frames(50);
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i312.x = 0;
				i312.scaleX = 1;
				i312.y = 0;
				i312.scaleY = 1;
				i312.rotation = 0;
				i312.alpha = 1;
				i312.filters = new as3.Array(new object[]{});
				i312.scale9Grid = null;
				i312.visible = true;
				i313.x = 13.7;
				i313.scaleX = 1.03;
				i313.y = 3;
				i313.scaleY = 0.97;
				i313.rotation = 0;
				i313.alpha = 1;
				i313.filters = new as3.Array(new object[]{filter_28});
				i313.scale9Grid = null;
				i313.visible = true;
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 13.8;
				i313.filters = new as3.Array(new object[]{filter_2});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 13.9;
				i313.scaleX = 1.02;
				i313.y = 2.9;
				i313.filters = new as3.Array(new object[]{filter_25});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.1;
				i313.y = 2.8;
				i313.scaleY = 0.98;
				i313.filters = new as3.Array(new object[]{filter_19});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.2;
				i313.y = 2.6;
				i313.filters = new as3.Array(new object[]{filter_9});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.3;
				i313.scaleX = 1.01;
				i313.y = 2.5;
				i313.filters = new as3.Array(new object[]{filter_27});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.4;
				i313.y = 2.4;
				i313.filters = new as3.Array(new object[]{filter_26});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.6;
				i313.y = 2.3;
				i313.filters = new as3.Array(new object[]{filter_21});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.7;
				i313.scaleX = 1;
				i313.y = 2.1;
				i313.filters = new as3.Array(new object[]{filter_4});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.8;
				i313.y = 2;
				i313.filters = new as3.Array(new object[]{filter_1});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.9;
				i313.y = 1.9;
				i313.filters = new as3.Array(new object[]{filter_23});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.1;
				i313.scaleX = 0.99;
				i313.filters = new as3.Array(new object[]{filter_15});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.2;
				i313.y = 1.8;
				i313.scaleY = 0.99;
				i313.filters = new as3.Array(new object[]{filter_38});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.3;
				i313.y = 1.6;
				i313.filters = new as3.Array(new object[]{filter_8});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.4;
				i313.scaleX = 0.98;
				i313.y = 1.4;
				i313.filters = new as3.Array(new object[]{filter_30});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.5;
				i313.filters = new as3.Array(new object[]{filter_43});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.6;
				i313.scaleX = 0.97;
				i313.y = 1.3;
				i313.filters = new as3.Array(new object[]{filter_45});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.8;
				i313.y = 1.1;
				i313.filters = new as3.Array(new object[]{filter_18});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.9;
				i313.y = 1;
				i313.filters = new as3.Array(new object[]{filter_6});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16;
				i313.scaleX = 0.96;
				i313.y = 0.9;
				i313.filters = new as3.Array(new object[]{filter_24});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.1;
				i313.y = 0.8;
				i313.scaleY = 1;
				i313.filters = new as3.Array(new object[]{filter_48});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.3;
				i313.y = 0.7;
				i313.filters = new as3.Array(new object[]{filter_47});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.4;
				i313.scaleX = 0.95;
				i313.y = 0.6;
				i313.filters = new as3.Array(new object[]{filter_7});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.5;
				i313.y = 0.5;
				i313.filters = new as3.Array(new object[]{filter_13});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.6;
				i313.y = 0.3;
				i313.filters = new as3.Array(new object[]{filter_32});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.5;
				i313.y = 0.4;
				i313.filters = new as3.Array(new object[]{filter_35});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.4;
				i313.y = 0.5;
				i313.filters = new as3.Array(new object[]{filter_10});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.3;
				i313.scaleX = 0.96;
				i313.y = 0.6;
				i313.filters = new as3.Array(new object[]{filter_16});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.2;
				i313.y = 0.7;
				i313.filters = new as3.Array(new object[]{filter_34});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 16.1;
				i313.y = 0.8;
				i313.scaleY = 0.99;
				i313.filters = new as3.Array(new object[]{filter_22});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.9;
				i313.scaleX = 0.97;
				i313.y = 0.9;
				i313.filters = new as3.Array(new object[]{filter_40});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.8;
				i313.y = 1.1;
				i313.filters = new as3.Array(new object[]{filter_29});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.7;
				i313.y = 1.2;
				i313.filters = new as3.Array(new object[]{filter_20});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.6;
				i313.scaleX = 0.98;
				i313.y = 1.3;
				i313.filters = new as3.Array(new object[]{filter_46});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.5;
				i313.y = 1.4;
				i313.filters = new as3.Array(new object[]{filter_5});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.3;
				i313.y = 1.5;
				i313.filters = new as3.Array(new object[]{filter_39});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.scaleX = 0.99;
				i313.y = 1.6;
				i313.filters = new as3.Array(new object[]{filter_36});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15.1;
				i313.y = 1.7;
				i313.filters = new as3.Array(new object[]{filter_0});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 15;
				i313.y = 1.8;
				i313.scaleY = 0.98;
				i313.filters = new as3.Array(new object[]{filter_11});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.8;
				i313.scaleX = 1;
				i313.y = 1.9;
				i313.filters = new as3.Array(new object[]{filter_3});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.y = 2;
				i313.filters = new as3.Array(new object[]{filter_17});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.7;
				i313.y = 2.1;
				i313.filters = new as3.Array(new object[]{filter_33});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.6;
				i313.scaleX = 1.01;
				i313.y = 2.3;
				i313.filters = new as3.Array(new object[]{filter_31});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.4;
				i313.y = 2.4;
				i313.filters = new as3.Array(new object[]{filter_41});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.3;
				i313.y = 2.5;
				i313.filters = new as3.Array(new object[]{filter_14});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.2;
				i313.scaleX = 1.02;
				i313.y = 2.6;
				i313.filters = new as3.Array(new object[]{filter_12});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 14.1;
				i313.y = 2.7;
				i313.filters = new as3.Array(new object[]{filter_44});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 13.9;
				i313.y = 2.8;
				i313.scaleY = 0.97;
				i313.filters = new as3.Array(new object[]{filter_37});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 13.8;
				i313.scaleX = 1.03;
				i313.y = 3;
				i313.filters = new as3.Array(new object[]{filter_42});
			};
			f = l.Add();
			f.Add(i312);
			f.Add(i313);
			f += () => {
				i313.x = 13.7;
				i313.filters = new as3.Array(new object[]{filter_28});
			};
			setFrames(l);
		}
	}
	public class symbol_37 : Shape{ 
		public symbol_37() {
			setGraphics("b09c78830a20f6279a909c7379242182", -14.55, -9.5, 29.15, 19, 1, 1);
		}
	}
	public class symbol_38 : MovieClip{ 
		public symbol_38() {
			var i317 = new symbol_37(){x = 2.3 , y = 2.3 , filters = new as3.Array(new object[]{})};
			addChild(i317);//0
		}
	}
	public class symbol_39 : MovieClip{ 
		public symbol_39() {
			var filter_0 = new BlurFilter(){blurX = 6, blurY = 6};
			var i315 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i315);//0
			var i316 = new symbol_38(){x = 5.9 , alpha = 0.5 , y = 18.6 , filters = new as3.Array(new object[]{filter_0})};
			addChild(i316);//1
			FrameInfo f;
			var l= new Frames(90);
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i315.x = 0;
				i315.scaleX = 1;
				i315.y = 0;
				i315.scaleY = 1;
				i315.rotation = 0;
				i315.alpha = 1;
				i315.filters = new as3.Array(new object[]{});
				i315.scale9Grid = null;
				i315.visible = true;
				i316.x = 5.9;
				i316.scaleX = 1;
				i316.y = 18.6;
				i316.scaleY = 1;
				i316.rotation = 0;
				i316.alpha = 0.5;
				i316.filters = new as3.Array(new object[]{filter_0});
				i316.scale9Grid = null;
				i316.visible = true;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 7;
				i316.scaleX = 1.02;
				i316.scaleY = 1.02;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 8.2;
				i316.scaleX = 1.04;
				i316.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 9.4;
				i316.scaleX = 1.06;
				i316.y = 18.4;
				i316.scaleY = 1.05;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 10.6;
				i316.scaleX = 1.08;
				i316.scaleY = 1.07;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 11.8;
				i316.scaleX = 1.11;
				i316.scaleY = 1.09;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 13.1;
				i316.scaleX = 1.13;
				i316.scaleY = 1.11;
				i316.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 14.4;
				i316.scaleX = 1.15;
				i316.y = 18.3;
				i316.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 15.7;
				i316.scaleX = 1.17;
				i316.scaleY = 1.14;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 17;
				i316.scaleX = 1.2;
				i316.scaleY = 1.16;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 18.4;
				i316.scaleX = 1.22;
				i316.y = 18.2;
				i316.scaleY = 1.18;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 19.7;
				i316.scaleX = 1.24;
				i316.y = 18.1;
				i316.scaleY = 1.2;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 21.1;
				i316.scaleX = 1.27;
				i316.scaleY = 1.22;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 22.4;
				i316.scaleX = 1.29;
				i316.scaleY = 1.24;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 23.9;
				i316.scaleX = 1.32;
				i316.y = 18;
				i316.scaleY = 1.26;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 25.3;
				i316.scaleX = 1.34;
				i316.y = 17.9;
				i316.scaleY = 1.28;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 26.8;
				i316.scaleX = 1.37;
				i316.scaleY = 1.31;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 28.2;
				i316.scaleX = 1.39;
				i316.scaleY = 1.33;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 29.7;
				i316.scaleX = 1.42;
				i316.y = 17.8;
				i316.scaleY = 1.35;
				i316.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 31.3;
				i316.scaleX = 1.45;
				i316.scaleY = 1.37;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 32.8;
				i316.scaleX = 1.47;
				i316.y = 17.7;
				i316.scaleY = 1.39;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 34.3;
				i316.scaleX = 1.5;
				i316.y = 17.6;
				i316.scaleY = 1.42;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 35.9;
				i316.scaleX = 1.53;
				i316.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 37.5;
				i316.scaleX = 1.56;
				i316.y = 17.5;
				i316.scaleY = 1.46;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 39;
				i316.scaleX = 1.59;
				i316.y = 17.4;
				i316.scaleY = 1.49;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 40.7;
				i316.scaleX = 1.62;
				i316.scaleY = 1.51;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 42.4;
				i316.scaleX = 1.64;
				i316.scaleY = 1.54;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 44;
				i316.scaleX = 1.67;
				i316.y = 17.3;
				i316.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 45.8;
				i316.scaleX = 1.7;
				i316.scaleY = 1.58;
				i316.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 47.5;
				i316.scaleX = 1.73;
				i316.y = 17.2;
				i316.scaleY = 1.61;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 49.1;
				i316.scaleX = 1.76;
				i316.y = 17.1;
				i316.scaleY = 1.64;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 51;
				i316.scaleX = 1.8;
				i316.scaleY = 1.66;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 52.7;
				i316.scaleX = 1.83;
				i316.scaleY = 1.69;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 54.5;
				i316.scaleX = 1.86;
				i316.y = 16.9;
				i316.scaleY = 1.71;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 56.3;
				i316.scaleX = 1.89;
				i316.scaleY = 1.74;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 58.1;
				i316.scaleX = 1.92;
				i316.scaleY = 1.77;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 60;
				i316.scaleX = 1.96;
				i316.y = 16.8;
				i316.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 61.9;
				i316.scaleX = 1.99;
				i316.scaleY = 1.82;
				i316.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 63.8;
				i316.scaleX = 2.02;
				i316.y = 16.6;
				i316.scaleY = 1.85;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 65.7;
				i316.scaleX = 2.06;
				i316.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 67.6;
				i316.scaleX = 2.09;
				i316.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 69.5;
				i316.scaleX = 2.12;
				i316.y = 16.5;
				i316.scaleY = 1.93;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 71.5;
				i316.scaleX = 2.16;
				i316.y = 16.4;
				i316.scaleY = 1.96;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 73.5;
				i316.scaleX = 2.19;
				i316.y = 16.3;
				i316.scaleY = 1.99;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 75.5;
				i316.scaleX = 2.23;
				i316.scaleY = 2.02;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 77.5;
				i316.scaleX = 2.27;
				i316.y = 16.1;
				i316.scaleY = 2.05;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 79.5;
				i316.scaleX = 2.3;
				i316.scaleY = 2.08;
				i316.alpha = 1;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 81.7;
				i316.scaleX = 2.34;
				i316.scaleY = 2.11;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 83.7;
				i316.scaleX = 2.38;
				i316.y = 15.9;
				i316.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 85.8;
				i316.scaleX = 2.41;
				i316.scaleY = 2.17;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 88.2;
				i316.scaleX = 2.38;
				i316.y = 16;
				i316.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 90.5;
				i316.scaleX = 2.34;
				i316.y = 16.1;
				i316.scaleY = 2.12;
				i316.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 92.8;
				i316.scaleX = 2.31;
				i316.scaleY = 2.09;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 95.2;
				i316.scaleX = 2.27;
				i316.y = 16.2;
				i316.scaleY = 2.06;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 97.5;
				i316.scaleX = 2.24;
				i316.y = 16.3;
				i316.scaleY = 2.03;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 99.8;
				i316.scaleX = 2.2;
				i316.scaleY = 2;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 102.2;
				i316.scaleX = 2.17;
				i316.y = 16.4;
				i316.scaleY = 1.97;
				i316.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 104.5;
				i316.scaleX = 2.13;
				i316.y = 16.5;
				i316.scaleY = 1.94;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 106.9;
				i316.scaleX = 2.1;
				i316.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 109.3;
				i316.scaleX = 2.06;
				i316.y = 16.6;
				i316.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 111.5;
				i316.scaleX = 2.02;
				i316.y = 16.7;
				i316.scaleY = 1.85;
				i316.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 113.8;
				i316.scaleX = 1.99;
				i316.scaleY = 1.82;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 116.2;
				i316.scaleX = 1.95;
				i316.y = 16.8;
				i316.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 118.5;
				i316.scaleX = 1.92;
				i316.y = 16.9;
				i316.scaleY = 1.76;
				i316.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 121;
				i316.scaleX = 1.88;
				i316.scaleY = 1.73;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 123.3;
				i316.scaleX = 1.85;
				i316.y = 17;
				i316.scaleY = 1.7;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 125.6;
				i316.scaleX = 1.81;
				i316.y = 17.1;
				i316.scaleY = 1.67;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 128;
				i316.scaleX = 1.78;
				i316.scaleY = 1.65;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 130.3;
				i316.scaleX = 1.74;
				i316.y = 17.2;
				i316.scaleY = 1.62;
				i316.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 132.6;
				i316.scaleX = 1.71;
				i316.y = 17.3;
				i316.scaleY = 1.59;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 134.9;
				i316.scaleX = 1.67;
				i316.y = 17.4;
				i316.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 137.3;
				i316.scaleX = 1.64;
				i316.scaleY = 1.53;
				i316.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 139.7;
				i316.scaleX = 1.6;
				i316.scaleY = 1.5;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 142;
				i316.scaleX = 1.57;
				i316.y = 17.6;
				i316.scaleY = 1.47;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 144.3;
				i316.scaleX = 1.53;
				i316.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 146.7;
				i316.scaleX = 1.49;
				i316.scaleY = 1.41;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 149;
				i316.scaleX = 1.46;
				i316.y = 17.8;
				i316.scaleY = 1.38;
				i316.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 151.3;
				i316.scaleX = 1.42;
				i316.scaleY = 1.35;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 153.7;
				i316.scaleX = 1.39;
				i316.y = 17.9;
				i316.scaleY = 1.32;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 156;
				i316.scaleX = 1.35;
				i316.scaleY = 1.29;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 158.3;
				i316.scaleX = 1.32;
				i316.y = 18;
				i316.scaleY = 1.26;
				i316.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 160.8;
				i316.scaleX = 1.28;
				i316.y = 18.1;
				i316.scaleY = 1.23;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 163.1;
				i316.scaleX = 1.25;
				i316.scaleY = 1.21;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 165.3;
				i316.scaleX = 1.21;
				i316.y = 18.2;
				i316.scaleY = 1.18;
				i316.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 167.7;
				i316.scaleX = 1.18;
				i316.y = 18.3;
				i316.scaleY = 1.15;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 170.1;
				i316.scaleX = 1.14;
				i316.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 172.4;
				i316.scaleX = 1.11;
				i316.y = 18.4;
				i316.scaleY = 1.09;
				i316.alpha = 0;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 174.8;
				i316.scaleX = 1.07;
				i316.y = 18.5;
				i316.scaleY = 1.06;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 177.1;
				i316.scaleX = 1.04;
				i316.y = 18.6;
				i316.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i315);
			f.Add(i316);
			f += () => {
				i316.x = 179.4;
				i316.scaleX = 1;
				i316.scaleY = 1;
			};
			setFrames(l);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
		}
	}
	public class symbol_40 : Shape{ 
		public symbol_40() {
			setGraphics("b09c78830a20f6279a909c7379242182", -14.55, -9.5, 29.15, 19, 1, 1);
		}
	}
	public class symbol_41 : MovieClip{ 
		public symbol_41() {
			var i321 = new symbol_40(){x = 2.3 , y = 2.3 , filters = new as3.Array(new object[]{})};
			addChild(i321);//0
		}
	}
	public class symbol_42 : MovieClip{ 
		public symbol_42() {
			var filter_0 = new BlurFilter(){blurX = 6, blurY = 6};
			var i319 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i319);//0
			var i320 = new symbol_41(){x = 5.9 , alpha = 0.5 , y = 18.6 , filters = new as3.Array(new object[]{filter_0})};
			addChild(i320);//1
			FrameInfo f;
			var l= new Frames(90);
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i319.x = 0;
				i319.scaleX = 1;
				i319.y = 0;
				i319.scaleY = 1;
				i319.rotation = 0;
				i319.alpha = 1;
				i319.filters = new as3.Array(new object[]{});
				i319.scale9Grid = null;
				i319.visible = true;
				i320.x = 5.9;
				i320.scaleX = 1;
				i320.y = 18.6;
				i320.scaleY = 1;
				i320.rotation = 0;
				i320.alpha = 0.5;
				i320.filters = new as3.Array(new object[]{filter_0});
				i320.scale9Grid = null;
				i320.visible = true;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 7;
				i320.scaleX = 1.02;
				i320.scaleY = 1.02;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 8.2;
				i320.scaleX = 1.04;
				i320.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 9.4;
				i320.scaleX = 1.06;
				i320.y = 18.4;
				i320.scaleY = 1.05;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 10.6;
				i320.scaleX = 1.08;
				i320.scaleY = 1.07;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 11.8;
				i320.scaleX = 1.11;
				i320.scaleY = 1.09;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 13.1;
				i320.scaleX = 1.13;
				i320.scaleY = 1.11;
				i320.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 14.4;
				i320.scaleX = 1.15;
				i320.y = 18.3;
				i320.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 15.7;
				i320.scaleX = 1.17;
				i320.scaleY = 1.14;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 17;
				i320.scaleX = 1.2;
				i320.scaleY = 1.16;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 18.4;
				i320.scaleX = 1.22;
				i320.y = 18.2;
				i320.scaleY = 1.18;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 19.7;
				i320.scaleX = 1.24;
				i320.y = 18.1;
				i320.scaleY = 1.2;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 21.1;
				i320.scaleX = 1.27;
				i320.scaleY = 1.22;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 22.4;
				i320.scaleX = 1.29;
				i320.scaleY = 1.24;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 23.9;
				i320.scaleX = 1.32;
				i320.y = 18;
				i320.scaleY = 1.26;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 25.3;
				i320.scaleX = 1.34;
				i320.y = 17.9;
				i320.scaleY = 1.28;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 26.8;
				i320.scaleX = 1.37;
				i320.scaleY = 1.31;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 28.2;
				i320.scaleX = 1.39;
				i320.scaleY = 1.33;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 29.7;
				i320.scaleX = 1.42;
				i320.y = 17.8;
				i320.scaleY = 1.35;
				i320.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 31.3;
				i320.scaleX = 1.45;
				i320.scaleY = 1.37;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 32.8;
				i320.scaleX = 1.47;
				i320.y = 17.7;
				i320.scaleY = 1.39;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 34.3;
				i320.scaleX = 1.5;
				i320.y = 17.6;
				i320.scaleY = 1.42;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 35.9;
				i320.scaleX = 1.53;
				i320.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 37.5;
				i320.scaleX = 1.56;
				i320.y = 17.5;
				i320.scaleY = 1.46;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 39;
				i320.scaleX = 1.59;
				i320.y = 17.4;
				i320.scaleY = 1.49;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 40.7;
				i320.scaleX = 1.62;
				i320.scaleY = 1.51;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 42.4;
				i320.scaleX = 1.64;
				i320.scaleY = 1.54;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 44;
				i320.scaleX = 1.67;
				i320.y = 17.3;
				i320.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 45.8;
				i320.scaleX = 1.7;
				i320.scaleY = 1.58;
				i320.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 47.5;
				i320.scaleX = 1.73;
				i320.y = 17.2;
				i320.scaleY = 1.61;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 49.1;
				i320.scaleX = 1.76;
				i320.y = 17.1;
				i320.scaleY = 1.64;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 51;
				i320.scaleX = 1.8;
				i320.scaleY = 1.66;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 52.7;
				i320.scaleX = 1.83;
				i320.scaleY = 1.69;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 54.5;
				i320.scaleX = 1.86;
				i320.y = 16.9;
				i320.scaleY = 1.71;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 56.3;
				i320.scaleX = 1.89;
				i320.scaleY = 1.74;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 58.1;
				i320.scaleX = 1.92;
				i320.scaleY = 1.77;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 60;
				i320.scaleX = 1.96;
				i320.y = 16.8;
				i320.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 61.9;
				i320.scaleX = 1.99;
				i320.scaleY = 1.82;
				i320.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 63.8;
				i320.scaleX = 2.02;
				i320.y = 16.6;
				i320.scaleY = 1.85;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 65.7;
				i320.scaleX = 2.06;
				i320.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 67.6;
				i320.scaleX = 2.09;
				i320.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 69.5;
				i320.scaleX = 2.12;
				i320.y = 16.5;
				i320.scaleY = 1.93;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 71.5;
				i320.scaleX = 2.16;
				i320.y = 16.4;
				i320.scaleY = 1.96;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 73.5;
				i320.scaleX = 2.19;
				i320.y = 16.3;
				i320.scaleY = 1.99;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 75.5;
				i320.scaleX = 2.23;
				i320.scaleY = 2.02;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 77.5;
				i320.scaleX = 2.27;
				i320.y = 16.1;
				i320.scaleY = 2.05;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 79.5;
				i320.scaleX = 2.3;
				i320.scaleY = 2.08;
				i320.alpha = 1;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 81.7;
				i320.scaleX = 2.34;
				i320.scaleY = 2.11;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 83.7;
				i320.scaleX = 2.38;
				i320.y = 15.9;
				i320.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 85.8;
				i320.scaleX = 2.41;
				i320.scaleY = 2.17;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 88.2;
				i320.scaleX = 2.38;
				i320.y = 16;
				i320.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 90.5;
				i320.scaleX = 2.34;
				i320.y = 16.1;
				i320.scaleY = 2.12;
				i320.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 92.8;
				i320.scaleX = 2.31;
				i320.scaleY = 2.09;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 95.2;
				i320.scaleX = 2.27;
				i320.y = 16.2;
				i320.scaleY = 2.06;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 97.5;
				i320.scaleX = 2.24;
				i320.y = 16.3;
				i320.scaleY = 2.03;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 99.8;
				i320.scaleX = 2.2;
				i320.scaleY = 2;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 102.2;
				i320.scaleX = 2.17;
				i320.y = 16.4;
				i320.scaleY = 1.97;
				i320.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 104.5;
				i320.scaleX = 2.13;
				i320.y = 16.5;
				i320.scaleY = 1.94;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 106.9;
				i320.scaleX = 2.1;
				i320.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 109.3;
				i320.scaleX = 2.06;
				i320.y = 16.6;
				i320.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 111.5;
				i320.scaleX = 2.02;
				i320.y = 16.7;
				i320.scaleY = 1.85;
				i320.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 113.8;
				i320.scaleX = 1.99;
				i320.scaleY = 1.82;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 116.2;
				i320.scaleX = 1.95;
				i320.y = 16.8;
				i320.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 118.5;
				i320.scaleX = 1.92;
				i320.y = 16.9;
				i320.scaleY = 1.76;
				i320.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 121;
				i320.scaleX = 1.88;
				i320.scaleY = 1.73;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 123.3;
				i320.scaleX = 1.85;
				i320.y = 17;
				i320.scaleY = 1.7;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 125.6;
				i320.scaleX = 1.81;
				i320.y = 17.1;
				i320.scaleY = 1.67;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 128;
				i320.scaleX = 1.78;
				i320.scaleY = 1.65;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 130.3;
				i320.scaleX = 1.74;
				i320.y = 17.2;
				i320.scaleY = 1.62;
				i320.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 132.6;
				i320.scaleX = 1.71;
				i320.y = 17.3;
				i320.scaleY = 1.59;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 134.9;
				i320.scaleX = 1.67;
				i320.y = 17.4;
				i320.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 137.3;
				i320.scaleX = 1.64;
				i320.scaleY = 1.53;
				i320.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 139.7;
				i320.scaleX = 1.6;
				i320.scaleY = 1.5;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 142;
				i320.scaleX = 1.57;
				i320.y = 17.6;
				i320.scaleY = 1.47;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 144.3;
				i320.scaleX = 1.53;
				i320.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 146.7;
				i320.scaleX = 1.49;
				i320.scaleY = 1.41;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 149;
				i320.scaleX = 1.46;
				i320.y = 17.8;
				i320.scaleY = 1.38;
				i320.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 151.3;
				i320.scaleX = 1.42;
				i320.scaleY = 1.35;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 153.7;
				i320.scaleX = 1.39;
				i320.y = 17.9;
				i320.scaleY = 1.32;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 156;
				i320.scaleX = 1.35;
				i320.scaleY = 1.29;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 158.3;
				i320.scaleX = 1.32;
				i320.y = 18;
				i320.scaleY = 1.26;
				i320.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 160.8;
				i320.scaleX = 1.28;
				i320.y = 18.1;
				i320.scaleY = 1.23;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 163.1;
				i320.scaleX = 1.25;
				i320.scaleY = 1.21;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 165.3;
				i320.scaleX = 1.21;
				i320.y = 18.2;
				i320.scaleY = 1.18;
				i320.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 167.7;
				i320.scaleX = 1.18;
				i320.y = 18.3;
				i320.scaleY = 1.15;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 170.1;
				i320.scaleX = 1.14;
				i320.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 172.4;
				i320.scaleX = 1.11;
				i320.y = 18.4;
				i320.scaleY = 1.09;
				i320.alpha = 0;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 174.8;
				i320.scaleX = 1.07;
				i320.y = 18.5;
				i320.scaleY = 1.06;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 177.1;
				i320.scaleX = 1.04;
				i320.y = 18.6;
				i320.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i319);
			f.Add(i320);
			f += () => {
				i320.x = 179.4;
				i320.scaleX = 1;
				i320.scaleY = 1;
			};
			setFrames(l);
		}
	}
	public class symbol_43 : MovieClip{ 
		public symbol_43() {
			var i325 = new symbol_40(){x = 2.3 , y = 2.3 , filters = new as3.Array(new object[]{})};
			addChild(i325);//0
		}
	}
	public class symbol_44 : MovieClip{ 
		public symbol_44() {
			var filter_0 = new BlurFilter(){blurX = 6, blurY = 6};
			var i323 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i323);//0
			var i324 = new symbol_43(){x = 5.9 , alpha = 0.5 , y = 18.6 , filters = new as3.Array(new object[]{filter_0})};
			addChild(i324);//1
			FrameInfo f;
			var l= new Frames(90);
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i323.x = 0;
				i323.scaleX = 1;
				i323.y = 0;
				i323.scaleY = 1;
				i323.rotation = 0;
				i323.alpha = 1;
				i323.filters = new as3.Array(new object[]{});
				i323.scale9Grid = null;
				i323.visible = true;
				i324.x = 5.9;
				i324.scaleX = 1;
				i324.y = 18.6;
				i324.scaleY = 1;
				i324.rotation = 0;
				i324.alpha = 0.5;
				i324.filters = new as3.Array(new object[]{filter_0});
				i324.scale9Grid = null;
				i324.visible = true;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 7;
				i324.scaleX = 1.02;
				i324.scaleY = 1.02;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 8.2;
				i324.scaleX = 1.04;
				i324.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 9.4;
				i324.scaleX = 1.06;
				i324.y = 18.4;
				i324.scaleY = 1.05;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 10.6;
				i324.scaleX = 1.08;
				i324.scaleY = 1.07;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 11.8;
				i324.scaleX = 1.11;
				i324.scaleY = 1.09;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 13.1;
				i324.scaleX = 1.13;
				i324.scaleY = 1.11;
				i324.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 14.4;
				i324.scaleX = 1.15;
				i324.y = 18.3;
				i324.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 15.7;
				i324.scaleX = 1.17;
				i324.scaleY = 1.14;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 17;
				i324.scaleX = 1.2;
				i324.scaleY = 1.16;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 18.4;
				i324.scaleX = 1.22;
				i324.y = 18.2;
				i324.scaleY = 1.18;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 19.7;
				i324.scaleX = 1.24;
				i324.y = 18.1;
				i324.scaleY = 1.2;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 21.1;
				i324.scaleX = 1.27;
				i324.scaleY = 1.22;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 22.4;
				i324.scaleX = 1.29;
				i324.scaleY = 1.24;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 23.9;
				i324.scaleX = 1.32;
				i324.y = 18;
				i324.scaleY = 1.26;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 25.3;
				i324.scaleX = 1.34;
				i324.y = 17.9;
				i324.scaleY = 1.28;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 26.8;
				i324.scaleX = 1.37;
				i324.scaleY = 1.31;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 28.2;
				i324.scaleX = 1.39;
				i324.scaleY = 1.33;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 29.7;
				i324.scaleX = 1.42;
				i324.y = 17.8;
				i324.scaleY = 1.35;
				i324.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 31.3;
				i324.scaleX = 1.45;
				i324.scaleY = 1.37;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 32.8;
				i324.scaleX = 1.47;
				i324.y = 17.7;
				i324.scaleY = 1.39;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 34.3;
				i324.scaleX = 1.5;
				i324.y = 17.6;
				i324.scaleY = 1.42;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 35.9;
				i324.scaleX = 1.53;
				i324.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 37.5;
				i324.scaleX = 1.56;
				i324.y = 17.5;
				i324.scaleY = 1.46;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 39;
				i324.scaleX = 1.59;
				i324.y = 17.4;
				i324.scaleY = 1.49;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 40.7;
				i324.scaleX = 1.62;
				i324.scaleY = 1.51;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 42.4;
				i324.scaleX = 1.64;
				i324.scaleY = 1.54;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 44;
				i324.scaleX = 1.67;
				i324.y = 17.3;
				i324.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 45.8;
				i324.scaleX = 1.7;
				i324.scaleY = 1.58;
				i324.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 47.5;
				i324.scaleX = 1.73;
				i324.y = 17.2;
				i324.scaleY = 1.61;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 49.1;
				i324.scaleX = 1.76;
				i324.y = 17.1;
				i324.scaleY = 1.64;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 51;
				i324.scaleX = 1.8;
				i324.scaleY = 1.66;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 52.7;
				i324.scaleX = 1.83;
				i324.scaleY = 1.69;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 54.5;
				i324.scaleX = 1.86;
				i324.y = 16.9;
				i324.scaleY = 1.71;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 56.3;
				i324.scaleX = 1.89;
				i324.scaleY = 1.74;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 58.1;
				i324.scaleX = 1.92;
				i324.scaleY = 1.77;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 60;
				i324.scaleX = 1.96;
				i324.y = 16.8;
				i324.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 61.9;
				i324.scaleX = 1.99;
				i324.scaleY = 1.82;
				i324.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 63.8;
				i324.scaleX = 2.02;
				i324.y = 16.6;
				i324.scaleY = 1.85;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 65.7;
				i324.scaleX = 2.06;
				i324.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 67.6;
				i324.scaleX = 2.09;
				i324.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 69.5;
				i324.scaleX = 2.12;
				i324.y = 16.5;
				i324.scaleY = 1.93;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 71.5;
				i324.scaleX = 2.16;
				i324.y = 16.4;
				i324.scaleY = 1.96;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 73.5;
				i324.scaleX = 2.19;
				i324.y = 16.3;
				i324.scaleY = 1.99;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 75.5;
				i324.scaleX = 2.23;
				i324.scaleY = 2.02;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 77.5;
				i324.scaleX = 2.27;
				i324.y = 16.1;
				i324.scaleY = 2.05;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 79.5;
				i324.scaleX = 2.3;
				i324.scaleY = 2.08;
				i324.alpha = 1;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 81.7;
				i324.scaleX = 2.34;
				i324.scaleY = 2.11;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 83.7;
				i324.scaleX = 2.38;
				i324.y = 15.9;
				i324.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 85.8;
				i324.scaleX = 2.41;
				i324.scaleY = 2.17;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 88.2;
				i324.scaleX = 2.38;
				i324.y = 16;
				i324.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 90.5;
				i324.scaleX = 2.34;
				i324.y = 16.1;
				i324.scaleY = 2.12;
				i324.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 92.8;
				i324.scaleX = 2.31;
				i324.scaleY = 2.09;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 95.2;
				i324.scaleX = 2.27;
				i324.y = 16.2;
				i324.scaleY = 2.06;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 97.5;
				i324.scaleX = 2.24;
				i324.y = 16.3;
				i324.scaleY = 2.03;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 99.8;
				i324.scaleX = 2.2;
				i324.scaleY = 2;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 102.2;
				i324.scaleX = 2.17;
				i324.y = 16.4;
				i324.scaleY = 1.97;
				i324.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 104.5;
				i324.scaleX = 2.13;
				i324.y = 16.5;
				i324.scaleY = 1.94;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 106.9;
				i324.scaleX = 2.1;
				i324.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 109.3;
				i324.scaleX = 2.06;
				i324.y = 16.6;
				i324.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 111.5;
				i324.scaleX = 2.02;
				i324.y = 16.7;
				i324.scaleY = 1.85;
				i324.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 113.8;
				i324.scaleX = 1.99;
				i324.scaleY = 1.82;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 116.2;
				i324.scaleX = 1.95;
				i324.y = 16.8;
				i324.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 118.5;
				i324.scaleX = 1.92;
				i324.y = 16.9;
				i324.scaleY = 1.76;
				i324.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 121;
				i324.scaleX = 1.88;
				i324.scaleY = 1.73;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 123.3;
				i324.scaleX = 1.85;
				i324.y = 17;
				i324.scaleY = 1.7;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 125.6;
				i324.scaleX = 1.81;
				i324.y = 17.1;
				i324.scaleY = 1.67;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 128;
				i324.scaleX = 1.78;
				i324.scaleY = 1.65;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 130.3;
				i324.scaleX = 1.74;
				i324.y = 17.2;
				i324.scaleY = 1.62;
				i324.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 132.6;
				i324.scaleX = 1.71;
				i324.y = 17.3;
				i324.scaleY = 1.59;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 134.9;
				i324.scaleX = 1.67;
				i324.y = 17.4;
				i324.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 137.3;
				i324.scaleX = 1.64;
				i324.scaleY = 1.53;
				i324.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 139.7;
				i324.scaleX = 1.6;
				i324.scaleY = 1.5;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 142;
				i324.scaleX = 1.57;
				i324.y = 17.6;
				i324.scaleY = 1.47;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 144.3;
				i324.scaleX = 1.53;
				i324.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 146.7;
				i324.scaleX = 1.49;
				i324.scaleY = 1.41;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 149;
				i324.scaleX = 1.46;
				i324.y = 17.8;
				i324.scaleY = 1.38;
				i324.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 151.3;
				i324.scaleX = 1.42;
				i324.scaleY = 1.35;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 153.7;
				i324.scaleX = 1.39;
				i324.y = 17.9;
				i324.scaleY = 1.32;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 156;
				i324.scaleX = 1.35;
				i324.scaleY = 1.29;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 158.3;
				i324.scaleX = 1.32;
				i324.y = 18;
				i324.scaleY = 1.26;
				i324.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 160.8;
				i324.scaleX = 1.28;
				i324.y = 18.1;
				i324.scaleY = 1.23;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 163.1;
				i324.scaleX = 1.25;
				i324.scaleY = 1.21;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 165.3;
				i324.scaleX = 1.21;
				i324.y = 18.2;
				i324.scaleY = 1.18;
				i324.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 167.7;
				i324.scaleX = 1.18;
				i324.y = 18.3;
				i324.scaleY = 1.15;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 170.1;
				i324.scaleX = 1.14;
				i324.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 172.4;
				i324.scaleX = 1.11;
				i324.y = 18.4;
				i324.scaleY = 1.09;
				i324.alpha = 0;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 174.8;
				i324.scaleX = 1.07;
				i324.y = 18.5;
				i324.scaleY = 1.06;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 177.1;
				i324.scaleX = 1.04;
				i324.y = 18.6;
				i324.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i323);
			f.Add(i324);
			f += () => {
				i324.x = 179.4;
				i324.scaleX = 1;
				i324.scaleY = 1;
			};
			setFrames(l);
		}
	}
	public class symbol_45 : MovieClip{ 
		public symbol_45() {
			var i329 = new symbol_40(){x = 2.3 , y = 2.3 , filters = new as3.Array(new object[]{})};
			addChild(i329);//0
		}
	}
	public class symbol_46 : MovieClip{ 
		public symbol_46() {
			var filter_0 = new BlurFilter(){blurX = 6, blurY = 6};
			var i327 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i327);//0
			var i328 = new symbol_45(){x = 5.9 , alpha = 0.5 , y = 18.6 , filters = new as3.Array(new object[]{filter_0})};
			addChild(i328);//1
			FrameInfo f;
			var l= new Frames(90);
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i327.x = 0;
				i327.scaleX = 1;
				i327.y = 0;
				i327.scaleY = 1;
				i327.rotation = 0;
				i327.alpha = 1;
				i327.filters = new as3.Array(new object[]{});
				i327.scale9Grid = null;
				i327.visible = true;
				i328.x = 5.9;
				i328.scaleX = 1;
				i328.y = 18.6;
				i328.scaleY = 1;
				i328.rotation = 0;
				i328.alpha = 0.5;
				i328.filters = new as3.Array(new object[]{filter_0});
				i328.scale9Grid = null;
				i328.visible = true;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 7;
				i328.scaleX = 1.02;
				i328.scaleY = 1.02;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 8.2;
				i328.scaleX = 1.04;
				i328.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 9.4;
				i328.scaleX = 1.06;
				i328.y = 18.4;
				i328.scaleY = 1.05;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 10.6;
				i328.scaleX = 1.08;
				i328.scaleY = 1.07;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 11.8;
				i328.scaleX = 1.11;
				i328.scaleY = 1.09;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 13.1;
				i328.scaleX = 1.13;
				i328.scaleY = 1.11;
				i328.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 14.4;
				i328.scaleX = 1.15;
				i328.y = 18.3;
				i328.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 15.7;
				i328.scaleX = 1.17;
				i328.scaleY = 1.14;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 17;
				i328.scaleX = 1.2;
				i328.scaleY = 1.16;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 18.4;
				i328.scaleX = 1.22;
				i328.y = 18.2;
				i328.scaleY = 1.18;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 19.7;
				i328.scaleX = 1.24;
				i328.y = 18.1;
				i328.scaleY = 1.2;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 21.1;
				i328.scaleX = 1.27;
				i328.scaleY = 1.22;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 22.4;
				i328.scaleX = 1.29;
				i328.scaleY = 1.24;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 23.9;
				i328.scaleX = 1.32;
				i328.y = 18;
				i328.scaleY = 1.26;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 25.3;
				i328.scaleX = 1.34;
				i328.y = 17.9;
				i328.scaleY = 1.28;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 26.8;
				i328.scaleX = 1.37;
				i328.scaleY = 1.31;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 28.2;
				i328.scaleX = 1.39;
				i328.scaleY = 1.33;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 29.7;
				i328.scaleX = 1.42;
				i328.y = 17.8;
				i328.scaleY = 1.35;
				i328.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 31.3;
				i328.scaleX = 1.45;
				i328.scaleY = 1.37;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 32.8;
				i328.scaleX = 1.47;
				i328.y = 17.7;
				i328.scaleY = 1.39;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 34.3;
				i328.scaleX = 1.5;
				i328.y = 17.6;
				i328.scaleY = 1.42;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 35.9;
				i328.scaleX = 1.53;
				i328.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 37.5;
				i328.scaleX = 1.56;
				i328.y = 17.5;
				i328.scaleY = 1.46;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 39;
				i328.scaleX = 1.59;
				i328.y = 17.4;
				i328.scaleY = 1.49;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 40.7;
				i328.scaleX = 1.62;
				i328.scaleY = 1.51;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 42.4;
				i328.scaleX = 1.64;
				i328.scaleY = 1.54;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 44;
				i328.scaleX = 1.67;
				i328.y = 17.3;
				i328.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 45.8;
				i328.scaleX = 1.7;
				i328.scaleY = 1.58;
				i328.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 47.5;
				i328.scaleX = 1.73;
				i328.y = 17.2;
				i328.scaleY = 1.61;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 49.1;
				i328.scaleX = 1.76;
				i328.y = 17.1;
				i328.scaleY = 1.64;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 51;
				i328.scaleX = 1.8;
				i328.scaleY = 1.66;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 52.7;
				i328.scaleX = 1.83;
				i328.scaleY = 1.69;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 54.5;
				i328.scaleX = 1.86;
				i328.y = 16.9;
				i328.scaleY = 1.71;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 56.3;
				i328.scaleX = 1.89;
				i328.scaleY = 1.74;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 58.1;
				i328.scaleX = 1.92;
				i328.scaleY = 1.77;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 60;
				i328.scaleX = 1.96;
				i328.y = 16.8;
				i328.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 61.9;
				i328.scaleX = 1.99;
				i328.scaleY = 1.82;
				i328.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 63.8;
				i328.scaleX = 2.02;
				i328.y = 16.6;
				i328.scaleY = 1.85;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 65.7;
				i328.scaleX = 2.06;
				i328.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 67.6;
				i328.scaleX = 2.09;
				i328.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 69.5;
				i328.scaleX = 2.12;
				i328.y = 16.5;
				i328.scaleY = 1.93;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 71.5;
				i328.scaleX = 2.16;
				i328.y = 16.4;
				i328.scaleY = 1.96;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 73.5;
				i328.scaleX = 2.19;
				i328.y = 16.3;
				i328.scaleY = 1.99;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 75.5;
				i328.scaleX = 2.23;
				i328.scaleY = 2.02;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 77.5;
				i328.scaleX = 2.27;
				i328.y = 16.1;
				i328.scaleY = 2.05;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 79.5;
				i328.scaleX = 2.3;
				i328.scaleY = 2.08;
				i328.alpha = 1;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 81.7;
				i328.scaleX = 2.34;
				i328.scaleY = 2.11;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 83.7;
				i328.scaleX = 2.38;
				i328.y = 15.9;
				i328.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 85.8;
				i328.scaleX = 2.41;
				i328.scaleY = 2.17;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 88.2;
				i328.scaleX = 2.38;
				i328.y = 16;
				i328.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 90.5;
				i328.scaleX = 2.34;
				i328.y = 16.1;
				i328.scaleY = 2.12;
				i328.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 92.8;
				i328.scaleX = 2.31;
				i328.scaleY = 2.09;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 95.2;
				i328.scaleX = 2.27;
				i328.y = 16.2;
				i328.scaleY = 2.06;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 97.5;
				i328.scaleX = 2.24;
				i328.y = 16.3;
				i328.scaleY = 2.03;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 99.8;
				i328.scaleX = 2.2;
				i328.scaleY = 2;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 102.2;
				i328.scaleX = 2.17;
				i328.y = 16.4;
				i328.scaleY = 1.97;
				i328.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 104.5;
				i328.scaleX = 2.13;
				i328.y = 16.5;
				i328.scaleY = 1.94;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 106.9;
				i328.scaleX = 2.1;
				i328.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 109.3;
				i328.scaleX = 2.06;
				i328.y = 16.6;
				i328.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 111.5;
				i328.scaleX = 2.02;
				i328.y = 16.7;
				i328.scaleY = 1.85;
				i328.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 113.8;
				i328.scaleX = 1.99;
				i328.scaleY = 1.82;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 116.2;
				i328.scaleX = 1.95;
				i328.y = 16.8;
				i328.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 118.5;
				i328.scaleX = 1.92;
				i328.y = 16.9;
				i328.scaleY = 1.76;
				i328.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 121;
				i328.scaleX = 1.88;
				i328.scaleY = 1.73;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 123.3;
				i328.scaleX = 1.85;
				i328.y = 17;
				i328.scaleY = 1.7;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 125.6;
				i328.scaleX = 1.81;
				i328.y = 17.1;
				i328.scaleY = 1.67;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 128;
				i328.scaleX = 1.78;
				i328.scaleY = 1.65;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 130.3;
				i328.scaleX = 1.74;
				i328.y = 17.2;
				i328.scaleY = 1.62;
				i328.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 132.6;
				i328.scaleX = 1.71;
				i328.y = 17.3;
				i328.scaleY = 1.59;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 134.9;
				i328.scaleX = 1.67;
				i328.y = 17.4;
				i328.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 137.3;
				i328.scaleX = 1.64;
				i328.scaleY = 1.53;
				i328.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 139.7;
				i328.scaleX = 1.6;
				i328.scaleY = 1.5;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 142;
				i328.scaleX = 1.57;
				i328.y = 17.6;
				i328.scaleY = 1.47;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 144.3;
				i328.scaleX = 1.53;
				i328.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 146.7;
				i328.scaleX = 1.49;
				i328.scaleY = 1.41;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 149;
				i328.scaleX = 1.46;
				i328.y = 17.8;
				i328.scaleY = 1.38;
				i328.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 151.3;
				i328.scaleX = 1.42;
				i328.scaleY = 1.35;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 153.7;
				i328.scaleX = 1.39;
				i328.y = 17.9;
				i328.scaleY = 1.32;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 156;
				i328.scaleX = 1.35;
				i328.scaleY = 1.29;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 158.3;
				i328.scaleX = 1.32;
				i328.y = 18;
				i328.scaleY = 1.26;
				i328.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 160.8;
				i328.scaleX = 1.28;
				i328.y = 18.1;
				i328.scaleY = 1.23;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 163.1;
				i328.scaleX = 1.25;
				i328.scaleY = 1.21;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 165.3;
				i328.scaleX = 1.21;
				i328.y = 18.2;
				i328.scaleY = 1.18;
				i328.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 167.7;
				i328.scaleX = 1.18;
				i328.y = 18.3;
				i328.scaleY = 1.15;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 170.1;
				i328.scaleX = 1.14;
				i328.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 172.4;
				i328.scaleX = 1.11;
				i328.y = 18.4;
				i328.scaleY = 1.09;
				i328.alpha = 0;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 174.8;
				i328.scaleX = 1.07;
				i328.y = 18.5;
				i328.scaleY = 1.06;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 177.1;
				i328.scaleX = 1.04;
				i328.y = 18.6;
				i328.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i327);
			f.Add(i328);
			f += () => {
				i328.x = 179.4;
				i328.scaleX = 1;
				i328.scaleY = 1;
			};
			setFrames(l);
		}
	}
	public class symbol_47 : MovieClip{ 
		public symbol_47() {
			var i333 = new symbol_40(){x = 2.3 , y = 2.3 , filters = new as3.Array(new object[]{})};
			addChild(i333);//0
		}
	}
	public class symbol_48 : MovieClip{ 
		public symbol_48() {
			var filter_0 = new BlurFilter(){blurX = 6, blurY = 6};
			var i331 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i331);//0
			var i332 = new symbol_47(){x = 5.9 , alpha = 0.5 , y = 18.6 , filters = new as3.Array(new object[]{filter_0})};
			addChild(i332);//1
			FrameInfo f;
			var l= new Frames(90);
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i331.x = 0;
				i331.scaleX = 1;
				i331.y = 0;
				i331.scaleY = 1;
				i331.rotation = 0;
				i331.alpha = 1;
				i331.filters = new as3.Array(new object[]{});
				i331.scale9Grid = null;
				i331.visible = true;
				i332.x = 5.9;
				i332.scaleX = 1;
				i332.y = 18.6;
				i332.scaleY = 1;
				i332.rotation = 0;
				i332.alpha = 0.5;
				i332.filters = new as3.Array(new object[]{filter_0});
				i332.scale9Grid = null;
				i332.visible = true;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 7;
				i332.scaleX = 1.02;
				i332.scaleY = 1.02;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 8.2;
				i332.scaleX = 1.04;
				i332.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 9.4;
				i332.scaleX = 1.06;
				i332.y = 18.4;
				i332.scaleY = 1.05;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 10.6;
				i332.scaleX = 1.08;
				i332.scaleY = 1.07;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 11.8;
				i332.scaleX = 1.11;
				i332.scaleY = 1.09;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 13.1;
				i332.scaleX = 1.13;
				i332.scaleY = 1.11;
				i332.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 14.4;
				i332.scaleX = 1.15;
				i332.y = 18.3;
				i332.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 15.7;
				i332.scaleX = 1.17;
				i332.scaleY = 1.14;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 17;
				i332.scaleX = 1.2;
				i332.scaleY = 1.16;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 18.4;
				i332.scaleX = 1.22;
				i332.y = 18.2;
				i332.scaleY = 1.18;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 19.7;
				i332.scaleX = 1.24;
				i332.y = 18.1;
				i332.scaleY = 1.2;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 21.1;
				i332.scaleX = 1.27;
				i332.scaleY = 1.22;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 22.4;
				i332.scaleX = 1.29;
				i332.scaleY = 1.24;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 23.9;
				i332.scaleX = 1.32;
				i332.y = 18;
				i332.scaleY = 1.26;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 25.3;
				i332.scaleX = 1.34;
				i332.y = 17.9;
				i332.scaleY = 1.28;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 26.8;
				i332.scaleX = 1.37;
				i332.scaleY = 1.31;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 28.2;
				i332.scaleX = 1.39;
				i332.scaleY = 1.33;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 29.7;
				i332.scaleX = 1.42;
				i332.y = 17.8;
				i332.scaleY = 1.35;
				i332.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 31.3;
				i332.scaleX = 1.45;
				i332.scaleY = 1.37;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 32.8;
				i332.scaleX = 1.47;
				i332.y = 17.7;
				i332.scaleY = 1.39;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 34.3;
				i332.scaleX = 1.5;
				i332.y = 17.6;
				i332.scaleY = 1.42;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 35.9;
				i332.scaleX = 1.53;
				i332.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 37.5;
				i332.scaleX = 1.56;
				i332.y = 17.5;
				i332.scaleY = 1.46;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 39;
				i332.scaleX = 1.59;
				i332.y = 17.4;
				i332.scaleY = 1.49;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 40.7;
				i332.scaleX = 1.62;
				i332.scaleY = 1.51;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 42.4;
				i332.scaleX = 1.64;
				i332.scaleY = 1.54;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 44;
				i332.scaleX = 1.67;
				i332.y = 17.3;
				i332.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 45.8;
				i332.scaleX = 1.7;
				i332.scaleY = 1.58;
				i332.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 47.5;
				i332.scaleX = 1.73;
				i332.y = 17.2;
				i332.scaleY = 1.61;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 49.1;
				i332.scaleX = 1.76;
				i332.y = 17.1;
				i332.scaleY = 1.64;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 51;
				i332.scaleX = 1.8;
				i332.scaleY = 1.66;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 52.7;
				i332.scaleX = 1.83;
				i332.scaleY = 1.69;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 54.5;
				i332.scaleX = 1.86;
				i332.y = 16.9;
				i332.scaleY = 1.71;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 56.3;
				i332.scaleX = 1.89;
				i332.scaleY = 1.74;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 58.1;
				i332.scaleX = 1.92;
				i332.scaleY = 1.77;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 60;
				i332.scaleX = 1.96;
				i332.y = 16.8;
				i332.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 61.9;
				i332.scaleX = 1.99;
				i332.scaleY = 1.82;
				i332.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 63.8;
				i332.scaleX = 2.02;
				i332.y = 16.6;
				i332.scaleY = 1.85;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 65.7;
				i332.scaleX = 2.06;
				i332.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 67.6;
				i332.scaleX = 2.09;
				i332.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 69.5;
				i332.scaleX = 2.12;
				i332.y = 16.5;
				i332.scaleY = 1.93;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 71.5;
				i332.scaleX = 2.16;
				i332.y = 16.4;
				i332.scaleY = 1.96;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 73.5;
				i332.scaleX = 2.19;
				i332.y = 16.3;
				i332.scaleY = 1.99;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 75.5;
				i332.scaleX = 2.23;
				i332.scaleY = 2.02;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 77.5;
				i332.scaleX = 2.27;
				i332.y = 16.1;
				i332.scaleY = 2.05;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 79.5;
				i332.scaleX = 2.3;
				i332.scaleY = 2.08;
				i332.alpha = 1;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 81.7;
				i332.scaleX = 2.34;
				i332.scaleY = 2.11;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 83.7;
				i332.scaleX = 2.38;
				i332.y = 15.9;
				i332.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 85.8;
				i332.scaleX = 2.41;
				i332.scaleY = 2.17;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 88.2;
				i332.scaleX = 2.38;
				i332.y = 16;
				i332.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 90.5;
				i332.scaleX = 2.34;
				i332.y = 16.1;
				i332.scaleY = 2.12;
				i332.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 92.8;
				i332.scaleX = 2.31;
				i332.scaleY = 2.09;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 95.2;
				i332.scaleX = 2.27;
				i332.y = 16.2;
				i332.scaleY = 2.06;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 97.5;
				i332.scaleX = 2.24;
				i332.y = 16.3;
				i332.scaleY = 2.03;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 99.8;
				i332.scaleX = 2.2;
				i332.scaleY = 2;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 102.2;
				i332.scaleX = 2.17;
				i332.y = 16.4;
				i332.scaleY = 1.97;
				i332.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 104.5;
				i332.scaleX = 2.13;
				i332.y = 16.5;
				i332.scaleY = 1.94;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 106.9;
				i332.scaleX = 2.1;
				i332.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 109.3;
				i332.scaleX = 2.06;
				i332.y = 16.6;
				i332.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 111.5;
				i332.scaleX = 2.02;
				i332.y = 16.7;
				i332.scaleY = 1.85;
				i332.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 113.8;
				i332.scaleX = 1.99;
				i332.scaleY = 1.82;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 116.2;
				i332.scaleX = 1.95;
				i332.y = 16.8;
				i332.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 118.5;
				i332.scaleX = 1.92;
				i332.y = 16.9;
				i332.scaleY = 1.76;
				i332.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 121;
				i332.scaleX = 1.88;
				i332.scaleY = 1.73;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 123.3;
				i332.scaleX = 1.85;
				i332.y = 17;
				i332.scaleY = 1.7;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 125.6;
				i332.scaleX = 1.81;
				i332.y = 17.1;
				i332.scaleY = 1.67;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 128;
				i332.scaleX = 1.78;
				i332.scaleY = 1.65;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 130.3;
				i332.scaleX = 1.74;
				i332.y = 17.2;
				i332.scaleY = 1.62;
				i332.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 132.6;
				i332.scaleX = 1.71;
				i332.y = 17.3;
				i332.scaleY = 1.59;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 134.9;
				i332.scaleX = 1.67;
				i332.y = 17.4;
				i332.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 137.3;
				i332.scaleX = 1.64;
				i332.scaleY = 1.53;
				i332.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 139.7;
				i332.scaleX = 1.6;
				i332.scaleY = 1.5;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 142;
				i332.scaleX = 1.57;
				i332.y = 17.6;
				i332.scaleY = 1.47;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 144.3;
				i332.scaleX = 1.53;
				i332.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 146.7;
				i332.scaleX = 1.49;
				i332.scaleY = 1.41;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 149;
				i332.scaleX = 1.46;
				i332.y = 17.8;
				i332.scaleY = 1.38;
				i332.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 151.3;
				i332.scaleX = 1.42;
				i332.scaleY = 1.35;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 153.7;
				i332.scaleX = 1.39;
				i332.y = 17.9;
				i332.scaleY = 1.32;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 156;
				i332.scaleX = 1.35;
				i332.scaleY = 1.29;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 158.3;
				i332.scaleX = 1.32;
				i332.y = 18;
				i332.scaleY = 1.26;
				i332.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 160.8;
				i332.scaleX = 1.28;
				i332.y = 18.1;
				i332.scaleY = 1.23;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 163.1;
				i332.scaleX = 1.25;
				i332.scaleY = 1.21;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 165.3;
				i332.scaleX = 1.21;
				i332.y = 18.2;
				i332.scaleY = 1.18;
				i332.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 167.7;
				i332.scaleX = 1.18;
				i332.y = 18.3;
				i332.scaleY = 1.15;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 170.1;
				i332.scaleX = 1.14;
				i332.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 172.4;
				i332.scaleX = 1.11;
				i332.y = 18.4;
				i332.scaleY = 1.09;
				i332.alpha = 0;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 174.8;
				i332.scaleX = 1.07;
				i332.y = 18.5;
				i332.scaleY = 1.06;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 177.1;
				i332.scaleX = 1.04;
				i332.y = 18.6;
				i332.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i331);
			f.Add(i332);
			f += () => {
				i332.x = 179.4;
				i332.scaleX = 1;
				i332.scaleY = 1;
			};
			setFrames(l);
		}
	}
	public class symbol_49 : MovieClip{ 
		public symbol_49() {
			var i337 = new symbol_40(){x = 2.3 , y = 2.3 , filters = new as3.Array(new object[]{})};
			addChild(i337);//0
		}
	}
	public class symbol_5 : Shape{ 
		public symbol_5() {
			setGraphics("e7c0d661858318ac023f0871fcb948b2", 5.6, -2.5, 124.15, 9.75, 1, 1);
		}
	}
	public class symbol_50 : MovieClip{ 
		public symbol_50() {
			var filter_0 = new BlurFilter(){blurX = 6, blurY = 6};
			var i335 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i335);//0
			var i336 = new symbol_49(){x = 5.9 , alpha = 0.5 , y = 18.6 , filters = new as3.Array(new object[]{filter_0})};
			addChild(i336);//1
			FrameInfo f;
			var l= new Frames(90);
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i335.x = 0;
				i335.scaleX = 1;
				i335.y = 0;
				i335.scaleY = 1;
				i335.rotation = 0;
				i335.alpha = 1;
				i335.filters = new as3.Array(new object[]{});
				i335.scale9Grid = null;
				i335.visible = true;
				i336.x = 5.9;
				i336.scaleX = 1;
				i336.y = 18.6;
				i336.scaleY = 1;
				i336.rotation = 0;
				i336.alpha = 0.5;
				i336.filters = new as3.Array(new object[]{filter_0});
				i336.scale9Grid = null;
				i336.visible = true;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 7;
				i336.scaleX = 1.02;
				i336.scaleY = 1.02;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 8.2;
				i336.scaleX = 1.04;
				i336.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 9.4;
				i336.scaleX = 1.06;
				i336.y = 18.4;
				i336.scaleY = 1.05;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 10.6;
				i336.scaleX = 1.08;
				i336.scaleY = 1.07;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 11.8;
				i336.scaleX = 1.11;
				i336.scaleY = 1.09;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 13.1;
				i336.scaleX = 1.13;
				i336.scaleY = 1.11;
				i336.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 14.4;
				i336.scaleX = 1.15;
				i336.y = 18.3;
				i336.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 15.7;
				i336.scaleX = 1.17;
				i336.scaleY = 1.14;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 17;
				i336.scaleX = 1.2;
				i336.scaleY = 1.16;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 18.4;
				i336.scaleX = 1.22;
				i336.y = 18.2;
				i336.scaleY = 1.18;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 19.7;
				i336.scaleX = 1.24;
				i336.y = 18.1;
				i336.scaleY = 1.2;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 21.1;
				i336.scaleX = 1.27;
				i336.scaleY = 1.22;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 22.4;
				i336.scaleX = 1.29;
				i336.scaleY = 1.24;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 23.9;
				i336.scaleX = 1.32;
				i336.y = 18;
				i336.scaleY = 1.26;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 25.3;
				i336.scaleX = 1.34;
				i336.y = 17.9;
				i336.scaleY = 1.28;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 26.8;
				i336.scaleX = 1.37;
				i336.scaleY = 1.31;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 28.2;
				i336.scaleX = 1.39;
				i336.scaleY = 1.33;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 29.7;
				i336.scaleX = 1.42;
				i336.y = 17.8;
				i336.scaleY = 1.35;
				i336.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 31.3;
				i336.scaleX = 1.45;
				i336.scaleY = 1.37;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 32.8;
				i336.scaleX = 1.47;
				i336.y = 17.7;
				i336.scaleY = 1.39;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 34.3;
				i336.scaleX = 1.5;
				i336.y = 17.6;
				i336.scaleY = 1.42;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 35.9;
				i336.scaleX = 1.53;
				i336.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 37.5;
				i336.scaleX = 1.56;
				i336.y = 17.5;
				i336.scaleY = 1.46;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 39;
				i336.scaleX = 1.59;
				i336.y = 17.4;
				i336.scaleY = 1.49;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 40.7;
				i336.scaleX = 1.62;
				i336.scaleY = 1.51;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 42.4;
				i336.scaleX = 1.64;
				i336.scaleY = 1.54;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 44;
				i336.scaleX = 1.67;
				i336.y = 17.3;
				i336.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 45.8;
				i336.scaleX = 1.7;
				i336.scaleY = 1.58;
				i336.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 47.5;
				i336.scaleX = 1.73;
				i336.y = 17.2;
				i336.scaleY = 1.61;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 49.1;
				i336.scaleX = 1.76;
				i336.y = 17.1;
				i336.scaleY = 1.64;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 51;
				i336.scaleX = 1.8;
				i336.scaleY = 1.66;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 52.7;
				i336.scaleX = 1.83;
				i336.scaleY = 1.69;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 54.5;
				i336.scaleX = 1.86;
				i336.y = 16.9;
				i336.scaleY = 1.71;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 56.3;
				i336.scaleX = 1.89;
				i336.scaleY = 1.74;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 58.1;
				i336.scaleX = 1.92;
				i336.scaleY = 1.77;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 60;
				i336.scaleX = 1.96;
				i336.y = 16.8;
				i336.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 61.9;
				i336.scaleX = 1.99;
				i336.scaleY = 1.82;
				i336.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 63.8;
				i336.scaleX = 2.02;
				i336.y = 16.6;
				i336.scaleY = 1.85;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 65.7;
				i336.scaleX = 2.06;
				i336.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 67.6;
				i336.scaleX = 2.09;
				i336.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 69.5;
				i336.scaleX = 2.12;
				i336.y = 16.5;
				i336.scaleY = 1.93;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 71.5;
				i336.scaleX = 2.16;
				i336.y = 16.4;
				i336.scaleY = 1.96;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 73.5;
				i336.scaleX = 2.19;
				i336.y = 16.3;
				i336.scaleY = 1.99;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 75.5;
				i336.scaleX = 2.23;
				i336.scaleY = 2.02;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 77.5;
				i336.scaleX = 2.27;
				i336.y = 16.1;
				i336.scaleY = 2.05;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 79.5;
				i336.scaleX = 2.3;
				i336.scaleY = 2.08;
				i336.alpha = 1;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 81.7;
				i336.scaleX = 2.34;
				i336.scaleY = 2.11;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 83.7;
				i336.scaleX = 2.38;
				i336.y = 15.9;
				i336.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 85.8;
				i336.scaleX = 2.41;
				i336.scaleY = 2.17;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 88.2;
				i336.scaleX = 2.38;
				i336.y = 16;
				i336.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 90.5;
				i336.scaleX = 2.34;
				i336.y = 16.1;
				i336.scaleY = 2.12;
				i336.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 92.8;
				i336.scaleX = 2.31;
				i336.scaleY = 2.09;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 95.2;
				i336.scaleX = 2.27;
				i336.y = 16.2;
				i336.scaleY = 2.06;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 97.5;
				i336.scaleX = 2.24;
				i336.y = 16.3;
				i336.scaleY = 2.03;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 99.8;
				i336.scaleX = 2.2;
				i336.scaleY = 2;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 102.2;
				i336.scaleX = 2.17;
				i336.y = 16.4;
				i336.scaleY = 1.97;
				i336.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 104.5;
				i336.scaleX = 2.13;
				i336.y = 16.5;
				i336.scaleY = 1.94;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 106.9;
				i336.scaleX = 2.1;
				i336.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 109.3;
				i336.scaleX = 2.06;
				i336.y = 16.6;
				i336.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 111.5;
				i336.scaleX = 2.02;
				i336.y = 16.7;
				i336.scaleY = 1.85;
				i336.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 113.8;
				i336.scaleX = 1.99;
				i336.scaleY = 1.82;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 116.2;
				i336.scaleX = 1.95;
				i336.y = 16.8;
				i336.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 118.5;
				i336.scaleX = 1.92;
				i336.y = 16.9;
				i336.scaleY = 1.76;
				i336.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 121;
				i336.scaleX = 1.88;
				i336.scaleY = 1.73;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 123.3;
				i336.scaleX = 1.85;
				i336.y = 17;
				i336.scaleY = 1.7;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 125.6;
				i336.scaleX = 1.81;
				i336.y = 17.1;
				i336.scaleY = 1.67;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 128;
				i336.scaleX = 1.78;
				i336.scaleY = 1.65;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 130.3;
				i336.scaleX = 1.74;
				i336.y = 17.2;
				i336.scaleY = 1.62;
				i336.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 132.6;
				i336.scaleX = 1.71;
				i336.y = 17.3;
				i336.scaleY = 1.59;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 134.9;
				i336.scaleX = 1.67;
				i336.y = 17.4;
				i336.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 137.3;
				i336.scaleX = 1.64;
				i336.scaleY = 1.53;
				i336.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 139.7;
				i336.scaleX = 1.6;
				i336.scaleY = 1.5;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 142;
				i336.scaleX = 1.57;
				i336.y = 17.6;
				i336.scaleY = 1.47;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 144.3;
				i336.scaleX = 1.53;
				i336.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 146.7;
				i336.scaleX = 1.49;
				i336.scaleY = 1.41;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 149;
				i336.scaleX = 1.46;
				i336.y = 17.8;
				i336.scaleY = 1.38;
				i336.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 151.3;
				i336.scaleX = 1.42;
				i336.scaleY = 1.35;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 153.7;
				i336.scaleX = 1.39;
				i336.y = 17.9;
				i336.scaleY = 1.32;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 156;
				i336.scaleX = 1.35;
				i336.scaleY = 1.29;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 158.3;
				i336.scaleX = 1.32;
				i336.y = 18;
				i336.scaleY = 1.26;
				i336.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 160.8;
				i336.scaleX = 1.28;
				i336.y = 18.1;
				i336.scaleY = 1.23;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 163.1;
				i336.scaleX = 1.25;
				i336.scaleY = 1.21;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 165.3;
				i336.scaleX = 1.21;
				i336.y = 18.2;
				i336.scaleY = 1.18;
				i336.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 167.7;
				i336.scaleX = 1.18;
				i336.y = 18.3;
				i336.scaleY = 1.15;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 170.1;
				i336.scaleX = 1.14;
				i336.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 172.4;
				i336.scaleX = 1.11;
				i336.y = 18.4;
				i336.scaleY = 1.09;
				i336.alpha = 0;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 174.8;
				i336.scaleX = 1.07;
				i336.y = 18.5;
				i336.scaleY = 1.06;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 177.1;
				i336.scaleX = 1.04;
				i336.y = 18.6;
				i336.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i335);
			f.Add(i336);
			f += () => {
				i336.x = 179.4;
				i336.scaleX = 1;
				i336.scaleY = 1;
			};
			setFrames(l);
		}
	}
	public class symbol_51 : MovieClip{ 
		public symbol_51() {
			var i341 = new symbol_40(){x = 2.3 , y = 2.3 , filters = new as3.Array(new object[]{})};
			addChild(i341);//0
		}
	}
	public class symbol_52 : MovieClip{ 
		public symbol_52() {
			var filter_0 = new BlurFilter(){blurX = 6, blurY = 6};
			var i339 = new symbol_34(){filters = new as3.Array(new object[]{})};
			addChild(i339);//0
			var i340 = new symbol_51(){x = 5.9 , alpha = 0.5 , y = 18.6 , filters = new as3.Array(new object[]{filter_0})};
			addChild(i340);//1
			FrameInfo f;
			var l= new Frames(90);
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i339.x = 0;
				i339.scaleX = 1;
				i339.y = 0;
				i339.scaleY = 1;
				i339.rotation = 0;
				i339.alpha = 1;
				i339.filters = new as3.Array(new object[]{});
				i339.scale9Grid = null;
				i339.visible = true;
				i340.x = 5.9;
				i340.scaleX = 1;
				i340.y = 18.6;
				i340.scaleY = 1;
				i340.rotation = 0;
				i340.alpha = 0.5;
				i340.filters = new as3.Array(new object[]{filter_0});
				i340.scale9Grid = null;
				i340.visible = true;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 7;
				i340.scaleX = 1.02;
				i340.scaleY = 1.02;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 8.2;
				i340.scaleX = 1.04;
				i340.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 9.4;
				i340.scaleX = 1.06;
				i340.y = 18.4;
				i340.scaleY = 1.05;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 10.6;
				i340.scaleX = 1.08;
				i340.scaleY = 1.07;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 11.8;
				i340.scaleX = 1.11;
				i340.scaleY = 1.09;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 13.1;
				i340.scaleX = 1.13;
				i340.scaleY = 1.11;
				i340.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 14.4;
				i340.scaleX = 1.15;
				i340.y = 18.3;
				i340.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 15.7;
				i340.scaleX = 1.17;
				i340.scaleY = 1.14;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 17;
				i340.scaleX = 1.2;
				i340.scaleY = 1.16;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 18.4;
				i340.scaleX = 1.22;
				i340.y = 18.2;
				i340.scaleY = 1.18;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 19.7;
				i340.scaleX = 1.24;
				i340.y = 18.1;
				i340.scaleY = 1.2;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 21.1;
				i340.scaleX = 1.27;
				i340.scaleY = 1.22;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 22.4;
				i340.scaleX = 1.29;
				i340.scaleY = 1.24;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 23.9;
				i340.scaleX = 1.32;
				i340.y = 18;
				i340.scaleY = 1.26;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 25.3;
				i340.scaleX = 1.34;
				i340.y = 17.9;
				i340.scaleY = 1.28;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 26.8;
				i340.scaleX = 1.37;
				i340.scaleY = 1.31;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 28.2;
				i340.scaleX = 1.39;
				i340.scaleY = 1.33;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 29.7;
				i340.scaleX = 1.42;
				i340.y = 17.8;
				i340.scaleY = 1.35;
				i340.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 31.3;
				i340.scaleX = 1.45;
				i340.scaleY = 1.37;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 32.8;
				i340.scaleX = 1.47;
				i340.y = 17.7;
				i340.scaleY = 1.39;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 34.3;
				i340.scaleX = 1.5;
				i340.y = 17.6;
				i340.scaleY = 1.42;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 35.9;
				i340.scaleX = 1.53;
				i340.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 37.5;
				i340.scaleX = 1.56;
				i340.y = 17.5;
				i340.scaleY = 1.46;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 39;
				i340.scaleX = 1.59;
				i340.y = 17.4;
				i340.scaleY = 1.49;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 40.7;
				i340.scaleX = 1.62;
				i340.scaleY = 1.51;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 42.4;
				i340.scaleX = 1.64;
				i340.scaleY = 1.54;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 44;
				i340.scaleX = 1.67;
				i340.y = 17.3;
				i340.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 45.8;
				i340.scaleX = 1.7;
				i340.scaleY = 1.58;
				i340.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 47.5;
				i340.scaleX = 1.73;
				i340.y = 17.2;
				i340.scaleY = 1.61;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 49.1;
				i340.scaleX = 1.76;
				i340.y = 17.1;
				i340.scaleY = 1.64;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 51;
				i340.scaleX = 1.8;
				i340.scaleY = 1.66;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 52.7;
				i340.scaleX = 1.83;
				i340.scaleY = 1.69;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 54.5;
				i340.scaleX = 1.86;
				i340.y = 16.9;
				i340.scaleY = 1.71;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 56.3;
				i340.scaleX = 1.89;
				i340.scaleY = 1.74;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 58.1;
				i340.scaleX = 1.92;
				i340.scaleY = 1.77;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 60;
				i340.scaleX = 1.96;
				i340.y = 16.8;
				i340.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 61.9;
				i340.scaleX = 1.99;
				i340.scaleY = 1.82;
				i340.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 63.8;
				i340.scaleX = 2.02;
				i340.y = 16.6;
				i340.scaleY = 1.85;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 65.7;
				i340.scaleX = 2.06;
				i340.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 67.6;
				i340.scaleX = 2.09;
				i340.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 69.5;
				i340.scaleX = 2.12;
				i340.y = 16.5;
				i340.scaleY = 1.93;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 71.5;
				i340.scaleX = 2.16;
				i340.y = 16.4;
				i340.scaleY = 1.96;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 73.5;
				i340.scaleX = 2.19;
				i340.y = 16.3;
				i340.scaleY = 1.99;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 75.5;
				i340.scaleX = 2.23;
				i340.scaleY = 2.02;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 77.5;
				i340.scaleX = 2.27;
				i340.y = 16.1;
				i340.scaleY = 2.05;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 79.5;
				i340.scaleX = 2.3;
				i340.scaleY = 2.08;
				i340.alpha = 1;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 81.7;
				i340.scaleX = 2.34;
				i340.scaleY = 2.11;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 83.7;
				i340.scaleX = 2.38;
				i340.y = 15.9;
				i340.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 85.8;
				i340.scaleX = 2.41;
				i340.scaleY = 2.17;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 88.2;
				i340.scaleX = 2.38;
				i340.y = 16;
				i340.scaleY = 2.14;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 90.5;
				i340.scaleX = 2.34;
				i340.y = 16.1;
				i340.scaleY = 2.12;
				i340.alpha = 0.9;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 92.8;
				i340.scaleX = 2.31;
				i340.scaleY = 2.09;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 95.2;
				i340.scaleX = 2.27;
				i340.y = 16.2;
				i340.scaleY = 2.06;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 97.5;
				i340.scaleX = 2.24;
				i340.y = 16.3;
				i340.scaleY = 2.03;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 99.8;
				i340.scaleX = 2.2;
				i340.scaleY = 2;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 102.2;
				i340.scaleX = 2.17;
				i340.y = 16.4;
				i340.scaleY = 1.97;
				i340.alpha = 0.8;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 104.5;
				i340.scaleX = 2.13;
				i340.y = 16.5;
				i340.scaleY = 1.94;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 106.9;
				i340.scaleX = 2.1;
				i340.scaleY = 1.91;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 109.3;
				i340.scaleX = 2.06;
				i340.y = 16.6;
				i340.scaleY = 1.88;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 111.5;
				i340.scaleX = 2.02;
				i340.y = 16.7;
				i340.scaleY = 1.85;
				i340.alpha = 0.7;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 113.8;
				i340.scaleX = 1.99;
				i340.scaleY = 1.82;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 116.2;
				i340.scaleX = 1.95;
				i340.y = 16.8;
				i340.scaleY = 1.79;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 118.5;
				i340.scaleX = 1.92;
				i340.y = 16.9;
				i340.scaleY = 1.76;
				i340.alpha = 0.6;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 121;
				i340.scaleX = 1.88;
				i340.scaleY = 1.73;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 123.3;
				i340.scaleX = 1.85;
				i340.y = 17;
				i340.scaleY = 1.7;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 125.6;
				i340.scaleX = 1.81;
				i340.y = 17.1;
				i340.scaleY = 1.67;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 128;
				i340.scaleX = 1.78;
				i340.scaleY = 1.65;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 130.3;
				i340.scaleX = 1.74;
				i340.y = 17.2;
				i340.scaleY = 1.62;
				i340.alpha = 0.5;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 132.6;
				i340.scaleX = 1.71;
				i340.y = 17.3;
				i340.scaleY = 1.59;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 134.9;
				i340.scaleX = 1.67;
				i340.y = 17.4;
				i340.scaleY = 1.56;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 137.3;
				i340.scaleX = 1.64;
				i340.scaleY = 1.53;
				i340.alpha = 0.4;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 139.7;
				i340.scaleX = 1.6;
				i340.scaleY = 1.5;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 142;
				i340.scaleX = 1.57;
				i340.y = 17.6;
				i340.scaleY = 1.47;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 144.3;
				i340.scaleX = 1.53;
				i340.scaleY = 1.44;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 146.7;
				i340.scaleX = 1.49;
				i340.scaleY = 1.41;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 149;
				i340.scaleX = 1.46;
				i340.y = 17.8;
				i340.scaleY = 1.38;
				i340.alpha = 0.3;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 151.3;
				i340.scaleX = 1.42;
				i340.scaleY = 1.35;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 153.7;
				i340.scaleX = 1.39;
				i340.y = 17.9;
				i340.scaleY = 1.32;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 156;
				i340.scaleX = 1.35;
				i340.scaleY = 1.29;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 158.3;
				i340.scaleX = 1.32;
				i340.y = 18;
				i340.scaleY = 1.26;
				i340.alpha = 0.2;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 160.8;
				i340.scaleX = 1.28;
				i340.y = 18.1;
				i340.scaleY = 1.23;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 163.1;
				i340.scaleX = 1.25;
				i340.scaleY = 1.21;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 165.3;
				i340.scaleX = 1.21;
				i340.y = 18.2;
				i340.scaleY = 1.18;
				i340.alpha = 0.1;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 167.7;
				i340.scaleX = 1.18;
				i340.y = 18.3;
				i340.scaleY = 1.15;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 170.1;
				i340.scaleX = 1.14;
				i340.scaleY = 1.12;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 172.4;
				i340.scaleX = 1.11;
				i340.y = 18.4;
				i340.scaleY = 1.09;
				i340.alpha = 0;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 174.8;
				i340.scaleX = 1.07;
				i340.y = 18.5;
				i340.scaleY = 1.06;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 177.1;
				i340.scaleX = 1.04;
				i340.y = 18.6;
				i340.scaleY = 1.03;
			};
			f = l.Add();
			f.Add(i339);
			f.Add(i340);
			f += () => {
				i340.x = 179.4;
				i340.scaleX = 1;
				i340.scaleY = 1;
			};
			setFrames(l);
		}
	}
	public class symbol_53 : Shape{ 
		public symbol_53() {
			setGraphics("adca0a79f28ba6756c48c377597b153e", -8.5, -11.35, 17, 22.7, 1, 1);
		}
	}
	public class symbol_54 : MovieClip{ 
		public symbol_54() {
			var i344 = new symbol_53(){filters = new as3.Array(new object[]{})};
			addChild(i344);//0
		}
	}
	public class symbol_55 : Shape{ 
		public symbol_55() {
			setGraphics("5120b1c6fc453e4ea596e7622316b24f", -23.75, -43, 54, 46, 1, 1);
		}
	}
	public class symbol_56 : Shape{ 
		public symbol_56() {
			setGraphics("46cb57cb10c2f48dc7053a5091b93a01", 0, 0, 45.35, 44.35, 1, 1);
		}
	}
	public class symbol_57 : MovieClip{ 
		public symbol_57() {
			var i347 = new symbol_56(){filters = new as3.Array(new object[]{})};
			addChild(i347);//0
		}
	}
	public class symbol_58 : Shape{ 
		public symbol_58() {
			setGraphics("3ec4433213d04eb443245c60a9760258", -30.5, -63, 61, 67, 1, 1);
		}
	}
	public class symbol_59 : Shape{ 
		public symbol_59() {
			setGraphics("a7db65e384683dad66c0a83a7e14fa1c", -23.75, -42, 44, 46, 1, 1);
		}
	}
	public class symbol_6 : MovieClip{ 
		public symbol_6() {
			var i129 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i129);//0
		}
	}
	public class symbol_60 : Shape{ 
		public symbol_60() {
			setGraphics("041b87bbe09d78583826bfd726be6c65", 4.55, -2.85, 32.6, 45.300000000000004, 1, 1);
		}
	}
	public class symbol_61 : MovieClip{ 
		public symbol_61() {
			var i352 = new symbol_60(){filters = new as3.Array(new object[]{})};
			addChild(i352);//0
		}
	}
	public class symbol_62 : Shape{ 
		public symbol_62() {
			setGraphics("bdc375517715d2e0f7d5747d17a39ccd", 6.45, -0.65, 45.5, 37.6, 1, 1);
		}
	}
	public class symbol_63 : MovieClip{ 
		public symbol_63() {
			var i354 = new symbol_62(){filters = new as3.Array(new object[]{})};
			addChild(i354);//0
		}
	}
	public class symbol_64 : Shape{ 
		public symbol_64() {
			setGraphics("28213568e6a7616270abe1a3060730e1", -30.1, -33.55, 62, 38, 1, 1);
		}
	}
	public class symbol_65 : MovieClip{ 
		public symbol_65() {
			var i357 = new symbol_62(){filters = new as3.Array(new object[]{})};
			addChild(i357);//0
		}
	}
	public class symbol_66 : Shape{ 
		public symbol_66() {
			setGraphics("164a3ea095e4ba2ea8120fb28982e87a", -28.1, -33.55, 60, 37, 1, 1);
		}
	}
	public class symbol_67 : Shape{ 
		public symbol_67() {
			setGraphics("e8cfc323cea3fcfb67d022c785db3f9a", -26.5, -41.25, 57.95, 44.15, 1, 1);
		}
	}
	public class symbol_68 : Shape{ 
		public symbol_68() {
			setGraphics("a1bb89bb3978aa7bc551e34b0f2eedd6", 0, 0, 39, 39, 1, 1);
		}
	}
	public class symbol_69 : MovieClip{ 
		public symbol_69() {
			var i361 = new symbol_68(){filters = new as3.Array(new object[]{})};
			addChild(i361);//0
		}
	}
	public class symbol_7 : MovieClip{ 
		public symbol_7() {
			var i134 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i134);//0
		}
	}
	public class symbol_70 : Shape{ 
		public symbol_70() {
			setGraphics("2c1a068a5fdc533806c682bbc9a219ab", -24.5, -41.25, 57.95, 44.15, 1, 1);
		}
	}
	public class symbol_71 : MovieClip{ 
		public symbol_71() {
			var i364 = new symbol_68(){filters = new as3.Array(new object[]{})};
			addChild(i364);//0
		}
	}
	public class symbol_72 : Shape{ 
		public symbol_72() {
			setGraphics("6eec51f060c488d6f19a48fd5664fc72", 1.4, 0.5, 55.35, 37.05, 1, 1);
		}
	}
	public class symbol_73 : MovieClip{ 
		public symbol_73() {
			var i366 = new symbol_72(){filters = new as3.Array(new object[]{})};
			addChild(i366);//0
		}
	}
	public class symbol_74 : Shape{ 
		public symbol_74() {
			setGraphics("679cc7a2fcb7eaa09c276e045f488d85", -28.3, -34.6, 58, 39, 1, 1);
		}
	}
	public class symbol_75 : Shape{ 
		public symbol_75() {
			setGraphics("3aba6701792a8a6a78c62ed642ff2353", -26, -34, 68, 37, 1, 1);
		}
	}
	public class symbol_76 : Shape{ 
		public symbol_76() {
			setGraphics("ae19f947e1b5eb7e96e0152cd82486c2", 0, 0, 43.25, 34.5, 1, 1);
		}
	}
	public class symbol_77 : MovieClip{ 
		public symbol_77() {
			var i370 = new symbol_76(){filters = new as3.Array(new object[]{})};
			addChild(i370);//0
		}
	}
	public class symbol_78 : Shape{ 
		public symbol_78() {
			setGraphics("37bc7a3abf91b7ffc065a091cf5db051", -25, -32.35, 74, 38, 1, 1);
		}
	}
	public class symbol_79 : Shape{ 
		public symbol_79() {
			setGraphics("a3e3945c1df05c8a50bdb2149c2bcc88", 0, 0, 46.2, 35.65, 1, 1);
		}
	}
	public class symbol_8 : MovieClip{ 
		public symbol_8() {
			var i139 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i139);//0
		}
	}
	public class symbol_80 : MovieClip{ 
		public symbol_80() {
			var i373 = new symbol_79(){filters = new as3.Array(new object[]{})};
			addChild(i373);//0
		}
	}
	public class symbol_81 : Shape{ 
		public symbol_81() {
			setGraphics("29d1505ffd213107e448c68d3c1f9eaa", -35, -45, 70, 52, 1, 1);
		}
	}
	public class symbol_82 : Shape{ 
		public symbol_82() {
			setGraphics("787fccca333df486bc950b2e38d8432a", 0, 0, 45.2, 44.85, 1, 1);
		}
	}
	public class symbol_83 : MovieClip{ 
		public symbol_83() {
			var i376 = new symbol_82(){filters = new as3.Array(new object[]{})};
			addChild(i376);//0
		}
	}
	public class symbol_84 : Shape{ 
		public symbol_84() {
			setGraphics("43a755f315626c25bbd36f2a170827b5", 0, 0, 56.1, 39, 1, 1);
		}
	}
	public class symbol_85 : MovieClip{ 
		public symbol_85() {
			var i378 = new symbol_84(){filters = new as3.Array(new object[]{})};
			addChild(i378);//0
		}
	}
	public class symbol_86 : Shape{ 
		public symbol_86() {
			setGraphics("5de2f086285061d1dc3e932cfba6ce36", -20.4, -38.9, 44, 40, 1, 1);
		}
	}
	public class symbol_87 : MovieClip{ 
		public symbol_87() {
			var i381 = new symbol_84(){filters = new as3.Array(new object[]{})};
			addChild(i381);//0
		}
	}
	public class symbol_88 : Shape{ 
		public symbol_88() {
			setGraphics("a29ea19732831850f66b45d247881f74", -25, -42, 51, 48, 1, 1);
		}
	}
	public class symbol_89 : Shape{ 
		public symbol_89() {
			setGraphics("30e5331c98e719e56ec1f9b5f436f78a", 0, 0, 42.55, 42.25, 1, 1);
		}
	}
	public class symbol_9 : MovieClip{ 
		public symbol_9() {
			var i144 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i144);//0
		}
	}
	public class symbol_90 : MovieClip{ 
		public symbol_90() {
			var i385 = new symbol_89(){filters = new as3.Array(new object[]{})};
			addChild(i385);//0
		}
	}
	public class symbol_91 : Shape{ 
		public symbol_91() {
			setGraphics("d43e9fca83e874336f84aae5566d4533", -28, -40, 63, 45, 1, 1);
		}
	}
	public class symbol_92 : Shape{ 
		public symbol_92() {
			setGraphics("dd52a7f11796631ac8b28e41d0c0c976", 0, 0, 40.7, 41.65, 1, 1);
		}
	}
	public class symbol_93 : MovieClip{ 
		public symbol_93() {
			var i388 = new symbol_92(){filters = new as3.Array(new object[]{})};
			addChild(i388);//0
		}
	}
	public class symbol_94 : Shape{ 
		public symbol_94() {
			setGraphics("57852d1ad2066e005def644646d8dfcf", -20.5, -43.5, 51, 49, 1, 1);
		}
	}
	public class symbol_95 : Shape{ 
		public symbol_95() {
			setGraphics("aac130de963e807f7a7a287c188521de", 3, -0.75, 41, 43, 1, 1);
		}
	}
	public class symbol_96 : MovieClip{ 
		public symbol_96() {
			var i391 = new symbol_95(){filters = new as3.Array(new object[]{})};
			addChild(i391);//0
		}
	}
	public class symbol_97 : Shape{ 
		public symbol_97() {
			setGraphics("cb31929c423c906f51fc19a556abaacf", 6.6, 2.25, 49.5, 36.25, 1, 1);
		}
	}
	public class symbol_98 : MovieClip{ 
		public symbol_98() {
			var i393 = new symbol_97(){filters = new as3.Array(new object[]{})};
			addChild(i393);//0
		}
	}
	public class symbol_99 : Shape{ 
		public symbol_99() {
			setGraphics("7037abdb33df1a427b7b9ec6fb0c5b14", -27.15, -35.15, 59, 37, 1, 1);
		}
	}
}
