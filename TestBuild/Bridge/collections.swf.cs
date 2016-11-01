using System;
using flash.display;
using System.Collections.Generic;
using collections.swf.privateSymbols; using as3;

public class BonusAnimation : MovieClip{ 
	public BonusAnimation() {
		var i7 = new collections1_fla.part_animation_2(){scaleX = 1.6265297349681336 , rotation = -0.20035466881273226 , x = 8.5 , scaleY = 1.6265297349681336 , y = -1.2};
		addChild(i7);//0
		var i10 = new collections1_fla.part_animation_2(){scaleX = 1.626544837335867 , rotation = -1.2497234952460716 , x = 3.7 , scaleY = 1.626544837335867 , y = -5.3};
		addChild(i10);//1
		var i13 = new collections1_fla.part_animation_2(){scaleX = 1.6265066288785868 , rotation = -2.2317004976627377 , x = -3.4 , scaleY = 1.6265066288785868 , y = -2.95};
		addChild(i13);//2
		var i16 = new collections1_fla.part_animation_2(){scaleX = 1.6264772217141263 , rotation = 2.3846431759048983 , x = -4.9 , scaleY = 1.6264772217141263 , y = 5.3};
		addChild(i16);//3
		var i19 = new collections1_fla.part_animation_2(){scaleX = 1.6264655309479266 , rotation = 3.044214967279373 , x = -7.1 , scaleY = 1.6264655309479266 , y = 0.5};
		addChild(i19);//4
		var i22 = new collections1_fla.part_animation_2(){scaleX = 1.6264610173813983 , rotation = 1.0794564214807274 , x = 4.05 , scaleY = 1.6264610173813983 , y = 4.4};
		addChild(i22);//5
		var i25 = new collections1_fla.part_animation_2(){scaleX = 1.1617763076051517 , rotation = -1.807514862396007 , x = -0.95 , scaleY = 1.1617763076051517 , y = -7.5};
		addChild(i25);//6
		var i28 = new collections1_fla.part_animation_2(){scaleX = 1.1617813513923816 , rotation = 1.6826174009612527 , x = -0.35 , scaleY = 1.1617813513923816 , y = 5.9};
		addChild(i28);//7
		var i31 = new collections1_fla.part_animation_2(){scaleX = 1.161781088055825 , rotation = 0.3222677919299436 , x = 9.3 , scaleY = 1.161781088055825 , y = 4.3};
		addChild(i31);//8
	}
}
public class GoldCollectionBackground : BitmapData{ 
	public GoldCollectionBackground() {
		width = 506;
		height = 80;
		setPixels("b2029cdd1f2508128433b527ef5a712b");
	}
}
public class SilverCollectionBackground : BitmapData{ 
	public SilverCollectionBackground() {
		width = 506;
		height = 80;
		setPixels("7393ade8e12da9439a576472fa213d5b");
	}
}
namespace collections1_fla
{	public class part_animation_2 : MovieClip{ 
		public part_animation_2() {
			var i8 = new symbol_b491279d8bd205059dd40ad2cc16b0d4(){scaleX = 1.8819427490234375 , x = 6.75 , scaleY = 0.59722900390625};
			addChild(i8);//0
			var i34 = new symbol_dd4f6c69761ddcd254eb8feae55ea68b(){scaleX = 0.59722900390625 , x = 10.55 , scaleY = 0.456207275390625};
			addChild(i34);//1
			var i36 = new symbol_fe6decf99e537b7a77911a4d13b166f4(){scaleX = 0.456207275390625 , x = 17.45 , scaleY = 0.3484954833984375};
			addChild(i36);//2
			var i38 = new symbol_2149a73ad57ea7487f1539ce3606556a(){scaleX = 0.59722900390625 , x = 29.45 , scaleY = 0.456207275390625};
			addChild(i38);//3
			FrameInfo f;
			var l= new Frames(20);
			f = l.Add()+i8;
			f = l.Add()+i8+i34;
			f = l.Add()+i8+i34+i36;
			f = l.Add()+i8+i34+i36;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i34+i36+i38;
			f = l.Add()+i8+i36+i38;
			f = l.Add()+i8+i38;
			f = l.Add()+i8;
			f = l.Add()+i8;
			f = l.Add()+i8;
			f = l.Add()+i8;
			setFrames(l);
		}
	}
}
namespace collections.swf.privateSymbols{
	public class symbol_0449000f0e4cd89c01585f909a6664fc : MovieClip{ 
		public symbol_0449000f0e4cd89c01585f909a6664fc() {
			var i41 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i41);//0
		}
	}
	public class symbol_0d5c0d3c6a83e297746f2fd13a1dadfd : MovieClip{ 
		public symbol_0d5c0d3c6a83e297746f2fd13a1dadfd() {
			var i15 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i15);//0
		}
	}
	public class symbol_0fb9cfc1e5a4737652ce0d50ec874676 : MovieClip{ 
		public symbol_0fb9cfc1e5a4737652ce0d50ec874676() {
			var i73 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i73);//0
		}
	}
	public class symbol_17593caee5977b5f018181c7731d6f23 : MovieClip{ 
		public symbol_17593caee5977b5f018181c7731d6f23() {
			var i30 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i30);//0
		}
	}
	public class symbol_18afff6ca48d828ffffbf56e3364d921 : MovieClip{ 
		public symbol_18afff6ca48d828ffffbf56e3364d921() {
			var i83 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i83);//0
		}
	}
	public class symbol_2149a73ad57ea7487f1539ce3606556a : MovieClip{ 
		public symbol_2149a73ad57ea7487f1539ce3606556a() {
			var i39 = new symbol_683a95e4b972b7312c462db10ae434a2();
			addChild(i39);//0
		}
	}
	public class symbol_2ff603605907e3cb7d5c938ce0a8bd49 : Shape{ 
		public symbol_2ff603605907e3cb7d5c938ce0a8bd49() {
			setGraphics("36192036d7e8e85147385bbe5b7e7e70", -4.9, -4.7, 9.850000000000001, 9.4, 31, 10);
		}
	}
	public class symbol_30db526c94fd3f4a32fcb0b9a290a2e3 : MovieClip{ 
		public symbol_30db526c94fd3f4a32fcb0b9a290a2e3() {
			var i67 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i67);//0
		}
	}
	public class symbol_3650cf2d61e638f9322d77c9e6a61a47 : MovieClip{ 
		public symbol_3650cf2d61e638f9322d77c9e6a61a47() {
			var i79 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i79);//0
		}
	}
	public class symbol_3be8829c863bd8b71a0d9b3f070b2446 : MovieClip{ 
		public symbol_3be8829c863bd8b71a0d9b3f070b2446() {
			var i27 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i27);//0
		}
	}
	public class symbol_3fd4107cd4e8efd98ccdee5500bc114f : MovieClip{ 
		public symbol_3fd4107cd4e8efd98ccdee5500bc114f() {
			var i57 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i57);//0
		}
	}
	public class symbol_4881b2436c79c08df7aa6ee7bfe22df1 : MovieClip{ 
		public symbol_4881b2436c79c08df7aa6ee7bfe22df1() {
			var i43 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i43);//0
		}
	}
	public class symbol_61f3e4e079812c42abe89bd703c9b716 : MovieClip{ 
		public symbol_61f3e4e079812c42abe89bd703c9b716() {
			var i47 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i47);//0
		}
	}
	public class symbol_683a95e4b972b7312c462db10ae434a2 : Shape{ 
		public symbol_683a95e4b972b7312c462db10ae434a2() {
			setGraphics("36192036d7e8e85147385bbe5b7e7e70", -4.9, -4.7, 9.850000000000001, 9.4, 31, 10);
		}
	}
	public class symbol_6a54d01ca75fcd3d622ed6b2fc83e1cd : MovieClip{ 
		public symbol_6a54d01ca75fcd3d622ed6b2fc83e1cd() {
			var i59 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i59);//0
		}
	}
	public class symbol_6ee241b64b0b2e92e9bafb0c5ce295c5 : MovieClip{ 
		public symbol_6ee241b64b0b2e92e9bafb0c5ce295c5() {
			var i69 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i69);//0
		}
	}
	public class symbol_71904e776f21e17e4e350db4db7d7e0b : MovieClip{ 
		public symbol_71904e776f21e17e4e350db4db7d7e0b() {
			var i71 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i71);//0
		}
	}
	public class symbol_71955363c7d81989629a2d76430a81bb : MovieClip{ 
		public symbol_71955363c7d81989629a2d76430a81bb() {
			var i18 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i18);//0
		}
	}
	public class symbol_7591d3c26987b8a9e1b8b4ef0ce6c6e3 : MovieClip{ 
		public symbol_7591d3c26987b8a9e1b8b4ef0ce6c6e3() {
			var i21 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i21);//0
		}
	}
	public class symbol_78c0c0a38b6219bf63e1d0218c913945 : MovieClip{ 
		public symbol_78c0c0a38b6219bf63e1d0218c913945() {
			var i45 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i45);//0
		}
	}
	public class symbol_78f1ba0ec547f0ec61cb7f918ac1d1d3 : MovieClip{ 
		public symbol_78f1ba0ec547f0ec61cb7f918ac1d1d3() {
			var i12 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i12);//0
		}
	}
	public class symbol_8196a162618ffa3a87744745a589cb36 : MovieClip{ 
		public symbol_8196a162618ffa3a87744745a589cb36() {
			var i24 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i24);//0
		}
	}
	public class symbol_8604da1fd271feb19852d6f5059535ae : MovieClip{ 
		public symbol_8604da1fd271feb19852d6f5059535ae() {
			var i61 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i61);//0
		}
	}
	public class symbol_8982f94847abdc8799bceeb891d22257 : MovieClip{ 
		public symbol_8982f94847abdc8799bceeb891d22257() {
			var i65 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i65);//0
		}
	}
	public class symbol_9091e4865054dcabae25642adcc51114 : MovieClip{ 
		public symbol_9091e4865054dcabae25642adcc51114() {
			var i81 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i81);//0
		}
	}
	public class symbol_9963031e6c7f583ccc8f58243d9a70be : MovieClip{ 
		public symbol_9963031e6c7f583ccc8f58243d9a70be() {
			var i75 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i75);//0
		}
	}
	public class symbol_9d531d870f032cbca8403769234a8a80 : MovieClip{ 
		public symbol_9d531d870f032cbca8403769234a8a80() {
			var i53 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i53);//0
		}
	}
	public class symbol_aa652fa2922ab9137dc4950e6a2ff7bd : MovieClip{ 
		public symbol_aa652fa2922ab9137dc4950e6a2ff7bd() {
			var i51 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i51);//0
		}
	}
	public class symbol_ac7de2da6b5258c0bffab7e20905bb0f : MovieClip{ 
		public symbol_ac7de2da6b5258c0bffab7e20905bb0f() {
			var i77 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i77);//0
		}
	}
	public class symbol_b491279d8bd205059dd40ad2cc16b0d4 : MovieClip{ 
		public symbol_b491279d8bd205059dd40ad2cc16b0d4() {
			var i9 = new symbol_683a95e4b972b7312c462db10ae434a2();
			addChild(i9);//0
		}
	}
	public class symbol_c2fcc1c43e26c61aa836f01a88ec600e : MovieClip{ 
		public symbol_c2fcc1c43e26c61aa836f01a88ec600e() {
			var i85 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i85);//0
		}
	}
	public class symbol_d0666fd4e1890a05c282172af891a10e : MovieClip{ 
		public symbol_d0666fd4e1890a05c282172af891a10e() {
			var i63 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i63);//0
		}
	}
	public class symbol_d3b8fe036f88fb43daa69200df19c078 : MovieClip{ 
		public symbol_d3b8fe036f88fb43daa69200df19c078() {
			var i33 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i33);//0
		}
	}
	public class symbol_d9a4aa976fd25abcb48956c736a6ee30 : MovieClip{ 
		public symbol_d9a4aa976fd25abcb48956c736a6ee30() {
			var i49 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i49);//0
		}
	}
	public class symbol_dd4f6c69761ddcd254eb8feae55ea68b : MovieClip{ 
		public symbol_dd4f6c69761ddcd254eb8feae55ea68b() {
			var i35 = new symbol_683a95e4b972b7312c462db10ae434a2();
			addChild(i35);//0
		}
	}
	public class symbol_f1227c026375976987e2d44f06e68697 : MovieClip{ 
		public symbol_f1227c026375976987e2d44f06e68697() {
			var i87 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i87);//0
		}
	}
	public class symbol_faf88dfd9a989fe87b6014d4a940ec8e : MovieClip{ 
		public symbol_faf88dfd9a989fe87b6014d4a940ec8e() {
			var i55 = new symbol_2ff603605907e3cb7d5c938ce0a8bd49();
			addChild(i55);//0
		}
	}
	public class symbol_fe6decf99e537b7a77911a4d13b166f4 : MovieClip{ 
		public symbol_fe6decf99e537b7a77911a4d13b166f4() {
			var i37 = new symbol_683a95e4b972b7312c462db10ae434a2();
			addChild(i37);//0
		}
	}
}
