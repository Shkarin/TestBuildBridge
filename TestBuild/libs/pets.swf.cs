using System;
using flash.text;
using flash.display;
using System.Collections.Generic;
using as3;
using pets.swf.privateSymbols;

public class AwardsPetsExplosion : MovieClip{ 
	public AwardsPetsExplosion() {
		var i59 = new symbol_c9831045631a2ddd97f7b6289c92f405();
		addChild(i59);//0
		var i8 = new symbol_3010b382e11202594660e94b0a5dd3ac();
		addChild(i8);//0
		var i9 = new symbol_025bbd80edf7446fd8988e2b8ab50b96(){x = -4.25 , scaleY = 0.3536167329494905 , y = 5.3 , rotation = -0.4833347093934999 , scaleX = 0.3536167329494905};
		addChild(i9);//1
		var i13 = new symbol_7bff68541328f3bb08490d01cc73f9fa(){x = -4.45 , scaleY = 0.2836374114090187 , y = -4.4 , rotation = 0.6167303178666969 , scaleX = 0.2836374114090187};
		addChild(i13);//2
		var i17 = new symbol_aa04de6f9ddc7e21304ba3b55af82bde(){x = 5.05 , scaleY = 0.3483749131638278 , y = 4.95 , rotation = -2.460078279045829 , scaleX = 0.3483749131638278};
		addChild(i17);//3
		var i21 = new symbol_1c6dd01b2e2aa5e6b64048b096063bc0(){x = 6.9 , scaleY = 0.33445984788024236 , y = -0.95 , rotation = 2.9773001154139327 , scaleX = 0.33445984788024236};
		addChild(i21);//4
		var i25 = new symbol_de2a677f9a70564c62f637f6aa00e1cb(){x = 5.4 , scaleY = 0.1995946135213704 , y = -4.45 , rotation = 2.4234385087685184 , scaleX = 0.1995946135213704};
		addChild(i25);//5
		var i29 = new symbol_9ce54ccac8425ada50bb4688705f3315(){x = -1 , scaleY = 0.2673409953134303 , y = 6.65 , rotation = -1.354972686790439 , scaleX = 0.2673409953134303};
		addChild(i29);//6
		var i33 = new symbol_a61d55a8e810170dd3876d16e7ac9dd6(){x = 2.25 , scaleY = 0.20768572547619 , y = 6.45 , rotation = -1.8451051148663664 , scaleX = 0.20768572547619};
		addChild(i33);//7
		var i37 = new symbol_3d7d9742354409e4a1f246ba8270beaa(){x = 0.95 , scaleY = 0.42321757235988516 , y = -5.75 , rotation = 1.5962425646944947 , scaleX = 0.35262270777843713};
		addChild(i37);//8
		var i41 = new symbol_a1258c8a634edd335ebf7df743d01bb1(){x = -7.1 , scaleY = 0.2425876664697777 , y = 0.2 , rotation = -0.15484790368600326 , scaleX = 0.2425876664697777};
		addChild(i41);//9
		var i45 = new symbol_6dfbf0a0e219bb8b583ba0973f2bb662(){x = 7.4 , scaleY = 0.24260400520396863 , y = 1.8 , rotation = -2.8044095616587517 , scaleX = 0.24260400520396863};
		addChild(i45);//10
		FrameInfo f;
		var l= new Frames(16);
		f = l.Add()+i8+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i8+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i8+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i8+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i8+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i8+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i59+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add()+i9+i13+i17+i21+i25+i29+i33+i37+i41+i45;
		f = l.Add();
		setFrames(l);
	}
}
public class BoostersIconImg : BitmapData{ 
	public BoostersIconImg() {
		width = 31;
		height = 22;
		setPixels("ad29c6e2fef3ae18135bfe717c87772d");
	}
}
public class BoxPetImg : BitmapData{ 
	public BoxPetImg() {
		width = 29;
		height = 31;
		setPixels("9d6a0fd08e2f05d73c56ccd02d141236");
	}
}
public class BoxPetMovie : MovieClip{ 
	public BoxPetMovie() {
		var i61 = new symbol_320709e2b4dd4fa9f020219abc9e57f8(){x = -5.6 , y = 28.25 , alpha = 0.3984375};
		addChild(i61);//0
		var i63 = new symbol_fce27d71d54faba9e363342898c7e45e(){y = -8.75 , x = -5.6};
		addChild(i63);//1
		var i65 = new symbol_6ba1b7ff862fdf35f05e0a32bdea8a6d(){y = -22.85 , x = 4.35};
		addChild(i65);//2
		var i67 = new symbol_524712728ca4d1eaf5e3d5442ee12c20(){y = -22.2 , x = -15.1};
		addChild(i67);//3
		var i71 = new symbol_1f916b4e5864fcf661e129b4474b27ae(){y = -43.45 , x = 7};
		addChild(i71);//4
		var i69 = new symbol_ec0d794037de62c7996e800d81754754(){x = 3.5 , y = -28.35 , alpha = 0.3984375};
		addChild(i69);//4
		FrameInfo f;
		var l= new Frames(151);
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		f = l.Add()+i61+i63+i65+i67+i71+i69;
		setFrames(l);
	}
}
public class BrushPetImg : BitmapData{ 
	public BrushPetImg() {
		width = 28;
		height = 35;
		setPixels("092612243506d033dab5daa3bb646601");
	}
}
public class BrushPetSmallButton : SimpleButton{ 
	public BrushPetSmallButton() {
		downState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		overState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		upState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		hitTestState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
	}
}
public class Food1Award : MovieClip{ 
	public Food1Award() {
		var i79 = new symbol_322a132cb535a6d8885211a98be37688();
		addChild(i79);//0
	}
}
public class Food2Award : MovieClip{ 
	public Food2Award() {
		var i81 = new symbol_223be9807f9723d459d6793a2a2fb8aa();
		addChild(i81);//0
	}
}
public class Food3Award : MovieClip{ 
	public Food3Award() {
		var i83 = new symbol_2b93252eb4cbc3edc81236083e549f20();
		addChild(i83);//0
	}
}
public class FoodPetImg : BitmapData{ 
	public FoodPetImg() {
		width = 35;
		height = 23;
		setPixels("d3432a07bb8c7ba4646fb137cf8e03fd");
	}
}
public class FoodPetSmallButton : SimpleButton{ 
	public FoodPetSmallButton() {
		downState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		overState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		upState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		hitTestState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
	}
}
public class GlowAwardPet : MovieClip{ 
	public GlowAwardPet() {
		var i90 = new symbol_7b73ed52bcac7594ec1dde8ffcde5995();
		addChild(i90);//0
	}
}
public class InfoPetSmallButton : SimpleButton{ 
	public InfoPetSmallButton() {
		downState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		overState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		upState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		hitTestState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
	}
}
public class LotteryIconImg : BitmapData{ 
	public LotteryIconImg() {
		width = 38;
		height = 28;
		setPixels("829bc6d02a172c85bce9a86a96914982");
	}
}
public class NextBlueTapeButton : BitmapData{ 
	public NextBlueTapeButton() {
		width = 40;
		height = 40;
		setPixels("ee6b89cab2e18652526433e42687bad0");
	}
}
public class NotifyPets : MovieClip{ 
	public NotifyPets() {
		var i97 = new symbol_f0afc089392fbc92ccd67bad587a9191();
		addChild(i97);//0
		var i98 = new symbol_a010bd4b668b5f75e7bb6607a2ecfeba(){scaleY = 0.3721160888671875 , scaleX = 1.45684814453125};
		addChild(i98);//1
		FrameInfo f;
		var l= new Frames(70);
		f = l.Add()+i97;
		f = l.Add()+i97;
		f = l.Add()+i97;
		f = l.Add()+i97;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		f = l.Add()+i97+i98;
		setFrames(l);
	}
}
public class PetArrowCloudMovie : MovieClip{ 
	public PetArrowCloudMovie() {
		var i104 = new symbol_7b7537a63223765393d0d1ba56d96d65();
		addChild(i104);//0
	}
}
public class PetCloudMovie : MovieClip{ 
	public PetCloudMovie() {
		var i106 = new symbol_84ac50deb50d0411dd2ffc6eb3eb92fc();
		addChild(i106);//0
		FrameInfo f;
		var l= new Frames(12);
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add()+i106;
		f = l.Add();
		setFrames(l);
	}
}
public class PetExperienceImage : BitmapData{ 
	public PetExperienceImage() {
		width = 63;
		height = 339;
		setPixels("f4359e0c582a8daed86eeab36d78426f");
	}
}
public class PetsIconImg : BitmapData{ 
	public PetsIconImg() {
		width = 26;
		height = 22;
		setPixels("a44acc21a4513fdd0a75eb248e0cda01");
	}
}
public class PlaceActiveMenuPetsImg : BitmapData{ 
	public PlaceActiveMenuPetsImg() {
		width = 50;
		height = 50;
		setPixels("64f8dfc1601dc929c332dd72ef381349");
	}
}
public class PlaceMenuPetsImg : BitmapData{ 
	public PlaceMenuPetsImg() {
		width = 50;
		height = 50;
		setPixels("aca11c202031552231b5b8d9adc6eb70");
	}
}
public class Play1Award : MovieClip{ 
	public Play1Award() {
		var i108 = new symbol_3d445881313019345f733e2401917f41();
		addChild(i108);//0
	}
}
public class Play2Award : MovieClip{ 
	public Play2Award() {
		var i110 = new symbol_ded64b131d01a1f2490bb897323889df();
		addChild(i110);//0
	}
}
public class Play3Award : MovieClip{ 
	public Play3Award() {
		var i112 = new symbol_bf50449c2652ecd65a8fdbd607577abd(){x = 4.55 , scaleY = 0.4218597412109375 , y = -12.65 , scaleX = 0.4218597412109375};
		addChild(i112);//0
		var i117 = new symbol_553da9507817bf7e4d7660fbe65369c9();
		addChild(i117);//1
	}
}
public class PlayPetImg : BitmapData{ 
	public PlayPetImg() {
		width = 27;
		height = 27;
		setPixels("08c6861cafae7f3475907e422accff15");
	}
}
public class PlayPetSmallButton : SimpleButton{ 
	public PlayPetSmallButton() {
		downState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		overState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		upState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
		hitTestState = new symbol_f5f092b1ecaac81f8aefe6eb854afa47();
	}
}
public class ReDieImg : BitmapData{ 
	public ReDieImg() {
		width = 81;
		height = 107;
		setPixels("89e4b75ae4fb4cd41f571c8ee4a70494");
	}
}
public class RemovePetCross : BitmapData{ 
	public RemovePetCross() {
		width = 10;
		height = 10;
		setPixels("1b64b9fa09fe30e876868fa51002928a");
	}
}
public class ScaleAwardPet : MovieClip{ 
	public MovieClip place;
	public ScaleAwardPet() {
		place = new symbol_cd1f779bdf828942c0ba868688405913();
		addChild(place);//0
		FrameInfo f;
		var l= new Frames(13);
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		f = l.Add()+place;
		setFrames(l);
	}
}
public class StarPlayAwar : MovieClip{ 
	public StarPlayAwar() {
		var i134 = new symbol_6cd6378b3ff2477e4dc5ed28619d1790();
		addChild(i134);//0
		var i135 = new symbol_0abf4b232e3e0e19ec9619c5c7312606(){x = -5.1 , scaleY = 0.8148090423333832 , y = -3.35 , scaleX = 0.80859375};
		addChild(i135);//1
	}
}
public class SuperItemBgNormal : BitmapData{ 
	public SuperItemBgNormal() {
		width = 77;
		height = 77;
		setPixels("13c72512317c3200458c48826cbac43c");
	}
}
public class SuperItemBgOver : BitmapData{ 
	public SuperItemBgOver() {
		width = 77;
		height = 77;
		setPixels("13f63f140a433670869915c23c6d9fee");
	}
}
public class SuperPointsIcon : BitmapData{ 
	public SuperPointsIcon() {
		width = 36;
		height = 18;
		setPixels("0546658c75abc8988a0f5840b1ea9e62");
	}
}
public class ThinkingPetMovie : MovieClip{ 
	public ThinkingPetMovie() {
		var i140 = new symbol_754cb36e5a3ef5de97a4edf3d87a2120(){x = -28 , scaleY = 0.0902099609375 , y = 76.95 , scaleX = 0.11199951171875};
		addChild(i140);//0
		var i138 = new symbol_ef0604cd0a0b7c3c607f061d119811fc(){x = -30 , scaleY = 0.0631103515625 , y = 80 , scaleX = 0.0658111572265625};
		addChild(i138);//0
		var i142 = new symbol_b681fc0dee884e6dadad3b57ba63b21f(){x = -23 , scaleY = 0.1798553466796875 , y = 62 , scaleX = 0.212921142578125};
		addChild(i142);//1
		FrameInfo f;
		var l= new Frames(36);
		f = l.Add()+i138;
		f = l.Add()+i138;
		f = l.Add()+i138;
		f = l.Add()+i138;
		f = l.Add()+i140+i138;
		f = l.Add()+i140+i138;
		f = l.Add()+i140+i138;
		f = l.Add()+i140+i138;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		f = l.Add()+i140+i138+i142;
		setFrames(l);
	}
}
public class TickPetSelectedGreen : BitmapData{ 
	public TickPetSelectedGreen() {
		width = 27;
		height = 27;
		setPixels("945c670c1eeba1d2719bc03d463e00f0");
	}
}
public class WardrobePetImg : BitmapData{ 
	public WardrobePetImg() {
		width = 29;
		height = 22;
		setPixels("e09bef2efc991196cfc0338358c9bfeb");
	}
}
public class ZooIconImg : BitmapData{ 
	public ZooIconImg() {
		width = 22;
		height = 23;
		setPixels("4fa16b9c5a52dd509767959716a91573");
	}
}
namespace pets.swf.privateSymbols{
	public class symbol_025bbd80edf7446fd8988e2b8ab50b96 : MovieClip{ 
		public symbol_025bbd80edf7446fd8988e2b8ab50b96() {
			var i49 = new symbol_bf77c97143e4ff069291674085ea3d59();
			addChild(i49);//0
			var i10 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i10);//0
			var i11 = new symbol_b68ddb32cc932240f879023deab32d98(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i11);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i49+i11;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_0abf4b232e3e0e19ec9619c5c7312606 : MovieClip{ 
		public symbol_0abf4b232e3e0e19ec9619c5c7312606() {
			var i136 = new symbol_2b2b230f2a4349fcd8e00807a7f9a933();
			addChild(i136);//0
		}
	}
	public class symbol_0ad2513578a0433b70ad4770b6e26e41 : Shape{ 
		public symbol_0ad2513578a0433b70ad4770b6e26e41() {
			setGraphics("a61a89167344692cd10e07c032ab4565", -76, -55.5, 152, 111, 33, 20);
		}
	}
	public class symbol_18f3e6fbb5928217c32523a2c7b2cd8f : Shape{ 
		public symbol_18f3e6fbb5928217c32523a2c7b2cd8f() {
			setGraphics("1ef3fe24543b84c895e7ac3c79bddee0", -28.3, -27.6, 56.6, 55.2, 9, 11);
		}
	}
	public class symbol_1c6dd01b2e2aa5e6b64048b096063bc0 : MovieClip{ 
		public symbol_1c6dd01b2e2aa5e6b64048b096063bc0() {
			var i22 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i22);//0
			var i52 = new symbol_bf77c97143e4ff069291674085ea3d59();
			addChild(i52);//0
			var i23 = new symbol_d9576e1cbecc1c39a6079d05283f3734(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i23);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i22+i23;
			f = l.Add()+i52+i23;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_1f916b4e5864fcf661e129b4474b27ae : MovieClip{ 
		public symbol_1f916b4e5864fcf661e129b4474b27ae() {
			var i72 = new symbol_21be94e0302463a6a105cfa08f209aec();
			addChild(i72);//0
		}
	}
	public class symbol_21245a38defa9d4957ed9349d1dba561 : MovieClip{ 
		public symbol_21245a38defa9d4957ed9349d1dba561() {
			var i126 = new symbol_a1a4a2e580292dd61e76de66077c63b9();
			addChild(i126);//0
		}
	}
	public class symbol_21be94e0302463a6a105cfa08f209aec : Shape{ 
		public symbol_21be94e0302463a6a105cfa08f209aec() {
			setGraphics("e4549fef46f037af79083dc0ec3e047e", -11.45, -9, 22.95, 20.2, 23, 21);
		}
	}
	public class symbol_223be9807f9723d459d6793a2a2fb8aa : Shape{ 
		public symbol_223be9807f9723d459d6793a2a2fb8aa() {
			setGraphics("07b15d029e9994accddcdd22c2baab18", -23.85, -39.1, 46.75, 64.9, 47, 65);
		}
	}
	public class symbol_25d0a84e409aba928496ec90fcba6fc8 : MovieClip{ 
		public symbol_25d0a84e409aba928496ec90fcba6fc8() {
			var i44 = new symbol_18f3e6fbb5928217c32523a2c7b2cd8f();
			addChild(i44);//0
		}
	}
	public class symbol_294fd8d63220c6808c51f70cb99a3539 : MovieClip{ 
		public symbol_294fd8d63220c6808c51f70cb99a3539() {
			var i122 = new symbol_d7164344596104b7e5b5774a2ca57f3c();
			addChild(i122);//0
		}
	}
	public class symbol_2b2b230f2a4349fcd8e00807a7f9a933 : Shape{ 
		public symbol_2b2b230f2a4349fcd8e00807a7f9a933() {
			setGraphics("dd9f793b98bda0ee035920c38621e859", -7.25, -12.25, 14.55, 24.55, 12, 20);
		}
	}
	public class symbol_2b93252eb4cbc3edc81236083e549f20 : Shape{ 
		public symbol_2b93252eb4cbc3edc81236083e549f20() {
			setGraphics("34e858a2d8c1e304392a4317f62564da", -34.6, -12.35, 69, 24.9, 69, 25);
		}
	}
	public class symbol_3010b382e11202594660e94b0a5dd3ac : MorphShape{ 
		public symbol_3010b382e11202594660e94b0a5dd3ac() {
		}
	}
	public class symbol_320709e2b4dd4fa9f020219abc9e57f8 : MovieClip{ 
		public symbol_320709e2b4dd4fa9f020219abc9e57f8() {
			var i62 = new symbol_aa5c33726a46eaf48d2f9a2857a724f2();
			addChild(i62);//0
		}
	}
	public class symbol_322a132cb535a6d8885211a98be37688 : Shape{ 
		public symbol_322a132cb535a6d8885211a98be37688() {
			setGraphics("10fb087194c8bb250c2a9c1be3565430", -27, -23.65, 68.1, 49.2, 69, 50);
		}
	}
	public class symbol_3d445881313019345f733e2401917f41 : Shape{ 
		public symbol_3d445881313019345f733e2401917f41() {
			setGraphics("3c08c5ff26da5e79fafde461fd0aea7d", -22.5, -22.5, 45, 45, 45, 45);
		}
	}
	public class symbol_3d7d9742354409e4a1f246ba8270beaa : MovieClip{ 
		public symbol_3d7d9742354409e4a1f246ba8270beaa() {
			var i38 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i38);//0
			var i56 = new symbol_6f7f2fcbae61c864298d5b96a218bc08();
			addChild(i56);//0
			var i39 = new symbol_f0fedc37ffd0f9a8c3b746bd52f0a51c(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i39);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i38+i39;
			f = l.Add()+i56+i39;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_4f6300e5aee0a4749774ac2853dcfc4f : Shape{ 
		public symbol_4f6300e5aee0a4749774ac2853dcfc4f() {
			setGraphics("0db9ff65415da400a3fbf755d2557a7b", -4.1, -17.05, 8.149999999999999, 34, 4, 15);
		}
	}
	public class symbol_524712728ca4d1eaf5e3d5442ee12c20 : MovieClip{ 
		public symbol_524712728ca4d1eaf5e3d5442ee12c20() {
			var i68 = new symbol_e47b959eda0681cd05952711501463da();
			addChild(i68);//0
		}
	}
	public class symbol_553da9507817bf7e4d7660fbe65369c9 : Shape{ 
		public symbol_553da9507817bf7e4d7660fbe65369c9() {
			setGraphics("d2acca6035cbbf32b6805276a298ce09", -27.85, -11.55, 55.8, 21.200000000000003, 56, 22);
		}
	}
	public class symbol_58acb5390e3a3065a8c06a68f8bd3771 : MovieClip{ 
		public symbol_58acb5390e3a3065a8c06a68f8bd3771() {
			var i36 = new symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4();
			addChild(i36);//0
		}
	}
	public class symbol_69740eaddd794aee034eb0957fbc2d70 : MovieClip{ 
		public symbol_69740eaddd794aee034eb0957fbc2d70() {
			var i20 = new symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4();
			addChild(i20);//0
		}
	}
	public class symbol_6ba1b7ff862fdf35f05e0a32bdea8a6d : MovieClip{ 
		public symbol_6ba1b7ff862fdf35f05e0a32bdea8a6d() {
			var i66 = new symbol_c51360f3c6a60e0d5b1ae448dc54fa2a();
			addChild(i66);//0
		}
	}
	public class symbol_6cd6378b3ff2477e4dc5ed28619d1790 : Shape{ 
		public symbol_6cd6378b3ff2477e4dc5ed28619d1790() {
			setGraphics("f5ad8efaf5ae61c23c7dcf0833063dc1", -25.35, -24.25, 50.7, 48.55, 51, 49);
		}
	}
	public class symbol_6dfbf0a0e219bb8b583ba0973f2bb662 : MovieClip{ 
		public symbol_6dfbf0a0e219bb8b583ba0973f2bb662() {
			var i58 = new symbol_6f7f2fcbae61c864298d5b96a218bc08();
			addChild(i58);//0
			var i46 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i46);//0
			var i47 = new symbol_98448ec6de0ae15c2680a26bac38e345(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i47);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i46+i47;
			f = l.Add()+i58+i47;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_6f7f2fcbae61c864298d5b96a218bc08 : Shape{ 
		public symbol_6f7f2fcbae61c864298d5b96a218bc08() {
			setGraphics("7f2ec61cfabe48213f9d84960ce09428", -130.45, -5.5, 130.85, 13.9, 47, 6);
		}
	}
	public class symbol_754cb36e5a3ef5de97a4edf3d87a2120 : MovieClip{ 
		public symbol_754cb36e5a3ef5de97a4edf3d87a2120() {
			var i141 = new symbol_7f3c130d370c506225e16f8954bb3b97();
			addChild(i141);//0
		}
	}
	public class symbol_794c535ed6abd9c7cfc23a050d8a4cf5 : MovieClip{ 
		public symbol_794c535ed6abd9c7cfc23a050d8a4cf5() {
			var i119 = new symbol_d7164344596104b7e5b5774a2ca57f3c();
			addChild(i119);//0
		}
	}
	public class symbol_7b73ed52bcac7594ec1dde8ffcde5995 : Shape{ 
		public symbol_7b73ed52bcac7594ec1dde8ffcde5995() {
			setGraphics("83bd8288cabe5a15aeb90bb578c876d6", -6.75, -6.5, 13.5, 13, 14, 13);
		}
	}
	public class symbol_7b7537a63223765393d0d1ba56d96d65 : Shape{ 
		public symbol_7b7537a63223765393d0d1ba56d96d65() {
			setGraphics("ebe3c74d453dd80d26edc5f5b840489b", -17, -17.6, 34, 35.2, 34, 36);
		}
	}
	public class symbol_7bff68541328f3bb08490d01cc73f9fa : MovieClip{ 
		public symbol_7bff68541328f3bb08490d01cc73f9fa() {
			var i50 = new symbol_bf77c97143e4ff069291674085ea3d59();
			addChild(i50);//0
			var i14 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i14);//0
			var i15 = new symbol_e21cddc8f15439998906962e0ac0612d(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i15);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i14+i15;
			f = l.Add()+i50+i15;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_7f3c130d370c506225e16f8954bb3b97 : Shape{ 
		public symbol_7f3c130d370c506225e16f8954bb3b97() {
			setGraphics("a61a89167344692cd10e07c032ab4565", -76, -55.5, 152, 111, 33, 20);
		}
	}
	public class symbol_83b97ce0c4d947bac1711ae95ac611cd : MovieClip{ 
		public symbol_83b97ce0c4d947bac1711ae95ac611cd() {
			var i32 = new symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4();
			addChild(i32);//0
		}
	}
	public class symbol_84ac50deb50d0411dd2ffc6eb3eb92fc : Shape{ 
		public symbol_84ac50deb50d0411dd2ffc6eb3eb92fc() {
			setGraphics("fe00ef28f720af8c62cc165a8809d838", -37.6, -34.7, 70, 61.300000000000004, 70, 62);
		}
	}
	public class symbol_85d1a9a6b7bd5cfa978693bb9cc101b2 : Shape{ 
		public symbol_85d1a9a6b7bd5cfa978693bb9cc101b2() {
			setGraphics("cbe32a23f0bbc33fd4785276b5ad3829", -18.35, -18.4, 36.7, 36.8, 54, 14);
		}
	}
	public class symbol_98448ec6de0ae15c2680a26bac38e345 : MovieClip{ 
		public symbol_98448ec6de0ae15c2680a26bac38e345() {
			var i48 = new symbol_18f3e6fbb5928217c32523a2c7b2cd8f();
			addChild(i48);//0
		}
	}
	public class symbol_9ce54ccac8425ada50bb4688705f3315 : MovieClip{ 
		public symbol_9ce54ccac8425ada50bb4688705f3315() {
			var i54 = new symbol_bf77c97143e4ff069291674085ea3d59();
			addChild(i54);//0
			var i30 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i30);//0
			var i31 = new symbol_83b97ce0c4d947bac1711ae95ac611cd(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i31);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i30+i31;
			f = l.Add()+i54+i31;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_a010bd4b668b5f75e7bb6607a2ecfeba : MovieClip{ 
		public symbol_a010bd4b668b5f75e7bb6607a2ecfeba() {
			var i99 = new symbol_85d1a9a6b7bd5cfa978693bb9cc101b2();
			addChild(i99);//0
		}
	}
	public class symbol_a1258c8a634edd335ebf7df743d01bb1 : MovieClip{ 
		public symbol_a1258c8a634edd335ebf7df743d01bb1() {
			var i42 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i42);//0
			var i57 = new symbol_6f7f2fcbae61c864298d5b96a218bc08();
			addChild(i57);//0
			var i43 = new symbol_25d0a84e409aba928496ec90fcba6fc8(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i43);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i42+i43;
			f = l.Add()+i57+i43;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_a1a4a2e580292dd61e76de66077c63b9 : Shape{ 
		public symbol_a1a4a2e580292dd61e76de66077c63b9() {
			setGraphics("02ecca48fd2bf12a09a33870ecb26443", -15.9, -17.25, 31.8, 34.45, 14, 15);
		}
	}
	public class symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4 : Shape{ 
		public symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4() {
			setGraphics("1ef3fe24543b84c895e7ac3c79bddee0", -28.3, -27.6, 56.6, 55.2, 9, 11);
		}
	}
	public class symbol_a61d55a8e810170dd3876d16e7ac9dd6 : MovieClip{ 
		public symbol_a61d55a8e810170dd3876d16e7ac9dd6() {
			var i34 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i34);//0
			var i55 = new symbol_bf77c97143e4ff069291674085ea3d59();
			addChild(i55);//0
			var i35 = new symbol_58acb5390e3a3065a8c06a68f8bd3771(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i35);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i34+i35;
			f = l.Add()+i55+i35;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_aa04de6f9ddc7e21304ba3b55af82bde : MovieClip{ 
		public symbol_aa04de6f9ddc7e21304ba3b55af82bde() {
			var i18 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i18);//0
			var i51 = new symbol_bf77c97143e4ff069291674085ea3d59();
			addChild(i51);//0
			var i19 = new symbol_69740eaddd794aee034eb0957fbc2d70(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i19);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i18+i19;
			f = l.Add()+i51+i19;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_aa5c33726a46eaf48d2f9a2857a724f2 : Shape{ 
		public symbol_aa5c33726a46eaf48d2f9a2857a724f2() {
			setGraphics("44c25884e99aebcb3be7d37ed6f3aa8e", -53.15, -14.75, 121.94999999999999, 23.55, 122, 24);
		}
	}
	public class symbol_b1d57730fb5102689c8e9f93c013aa1b : Shape{ 
		public symbol_b1d57730fb5102689c8e9f93c013aa1b() {
			setGraphics("0a0c89b03aafefdbf80dfee0b7167774", -12, -7.4, 24, 14.75, 24, 15);
		}
	}
	public class symbol_b681fc0dee884e6dadad3b57ba63b21f : MovieClip{ 
		public symbol_b681fc0dee884e6dadad3b57ba63b21f() {
			var i143 = new symbol_0ad2513578a0433b70ad4770b6e26e41();
			addChild(i143);//0
		}
	}
	public class symbol_b68ddb32cc932240f879023deab32d98 : MovieClip{ 
		public symbol_b68ddb32cc932240f879023deab32d98() {
			var i12 = new symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4();
			addChild(i12);//0
		}
	}
	public class symbol_b9f34e5a244251a008b5391bf9a63963 : MovieClip{ 
		public symbol_b9f34e5a244251a008b5391bf9a63963() {
			var i28 = new symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4();
			addChild(i28);//0
		}
	}
	public class symbol_be2c707012ded825a6816ce57b6f216f : Shape{ 
		public symbol_be2c707012ded825a6816ce57b6f216f() {
			setGraphics("a61a89167344692cd10e07c032ab4565", -76, -55.5, 152, 111, 33, 20);
		}
	}
	public class symbol_bf50449c2652ecd65a8fdbd607577abd : MovieClip{ 
		public symbol_bf50449c2652ecd65a8fdbd607577abd() {
			var i121 = new symbol_294fd8d63220c6808c51f70cb99a3539(){x = 2.1 , scaleX = 0.4226531982421875};
			addChild(i121);//0
			var i113 = new symbol_cc1b70aac44299b94fe7b5774b6b66a2();
			addChild(i113);//0
			var i118 = new symbol_794c535ed6abd9c7cfc23a050d8a4cf5(){x = -2.3 , scaleX = 0.4226531982421875};
			addChild(i118);//0
			var i120 = new symbol_4f6300e5aee0a4749774ac2853dcfc4f();
			addChild(i120);//0
			var i125 = new symbol_21245a38defa9d4957ed9349d1dba561(){x = 1.6 , scaleX = 0.566986083984375};
			addChild(i125);//0
			var i123 = new symbol_daa592f3e762c190e09957915251d96d(){scaleX = 0.29254150390625};
			addChild(i123);//1
			var i115 = new symbol_f906ab364cddc373daa721033aff3b27();
			addChild(i115);//1
			FrameInfo f;
			var l= new Frames(12);
			f = l.Add()+i113+i115;
			f = l.Add()+i113+i115;
			f = l.Add()+i113+i115;
			f = l.Add()+i113+i115;
			f = l.Add()+i118+i115;
			f = l.Add()+i120;
			f = l.Add()+i120;
			f = l.Add()+i121+i123;
			f = l.Add()+i125+i123;
			f = l.Add()+i125+i123;
			f = l.Add()+i125+i123;
			f = l.Add()+i125+i123;
			setFrames(l);
		}
	}
	public class symbol_bf77c97143e4ff069291674085ea3d59 : Shape{ 
		public symbol_bf77c97143e4ff069291674085ea3d59() {
			setGraphics("7f2ec61cfabe48213f9d84960ce09428", -130.45, -5.5, 130.85, 13.9, 47, 6);
		}
	}
	public class symbol_c51360f3c6a60e0d5b1ae448dc54fa2a : Shape{ 
		public symbol_c51360f3c6a60e0d5b1ae448dc54fa2a() {
			setGraphics("ddbcf2ba4cc26f48002f5673f8ef2cf7", -6.8, -7.85, 13.6, 15.649999999999999, 14, 16);
		}
	}
	public class symbol_c9831045631a2ddd97f7b6289c92f405 : Shape{ 
		public symbol_c9831045631a2ddd97f7b6289c92f405() {
			setGraphics("476b9ea4b840850fb9a61ed2b4b96b29", -19, -18.8, 38, 38, 38, 38);
		}
	}
	public class symbol_cc1b70aac44299b94fe7b5774b6b66a2 : MovieClip{ 
		public symbol_cc1b70aac44299b94fe7b5774b6b66a2() {
			var i114 = new symbol_a1a4a2e580292dd61e76de66077c63b9();
			addChild(i114);//0
		}
	}
	public class symbol_cd1f779bdf828942c0ba868688405913 : MovieClip{ 
		public symbol_cd1f779bdf828942c0ba868688405913() {
		}
	}
	public class symbol_d040a13492cd4e451bf089dfbca5b8ab : Shape{ 
		public symbol_d040a13492cd4e451bf089dfbca5b8ab() {
			setGraphics("df7f9f256e21987aeb48d5cd25c5a467", -40.55, -42.4, 81.1, 84.8, 82, 85);
		}
	}
	public class symbol_d7164344596104b7e5b5774a2ca57f3c : Shape{ 
		public symbol_d7164344596104b7e5b5774a2ca57f3c() {
			setGraphics("28ba940c52061dc4e88de92bd99db708", -15.9, -17.25, 31.8, 34.45, 6, 15);
		}
	}
	public class symbol_d9576e1cbecc1c39a6079d05283f3734 : MovieClip{ 
		public symbol_d9576e1cbecc1c39a6079d05283f3734() {
			var i24 = new symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4();
			addChild(i24);//0
		}
	}
	public class symbol_daa592f3e762c190e09957915251d96d : MovieClip{ 
		public symbol_daa592f3e762c190e09957915251d96d() {
			var i124 = new symbol_a1a4a2e580292dd61e76de66077c63b9();
			addChild(i124);//0
		}
	}
	public class symbol_de2a677f9a70564c62f637f6aa00e1cb : MovieClip{ 
		public symbol_de2a677f9a70564c62f637f6aa00e1cb() {
			var i26 = new symbol_3010b382e11202594660e94b0a5dd3ac();
			addChild(i26);//0
			var i53 = new symbol_bf77c97143e4ff069291674085ea3d59();
			addChild(i53);//0
			var i27 = new symbol_b9f34e5a244251a008b5391bf9a63963(){x = -13 , scaleY = 0.43463134765625 , y = 1 , scaleX = 0.43463134765625};
			addChild(i27);//1
			FrameInfo f;
			var l= new Frames(16);
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i26+i27;
			f = l.Add()+i53+i27;
			f = l.Add();
			setFrames(l);
		}
	}
	public class symbol_ded64b131d01a1f2490bb897323889df : Shape{ 
		public symbol_ded64b131d01a1f2490bb897323889df() {
			setGraphics("beddc3b334c41d717eb1b5dc9929640c", -20.6, -18.3, 41.2, 36.55, 42, 37);
		}
	}
	public class symbol_e21cddc8f15439998906962e0ac0612d : MovieClip{ 
		public symbol_e21cddc8f15439998906962e0ac0612d() {
			var i16 = new symbol_a2145b4c2e17a6b7e1fd93a0bbdf10d4();
			addChild(i16);//0
		}
	}
	public class symbol_e47b959eda0681cd05952711501463da : Shape{ 
		public symbol_e47b959eda0681cd05952711501463da() {
			setGraphics("41c2229a5c1a5722050fa95b10f3f4ff", -8.4, -8.5, 16.8, 16.9, 17, 17);
		}
	}
	public class symbol_ec0d794037de62c7996e800d81754754 : MovieClip{ 
		public symbol_ec0d794037de62c7996e800d81754754() {
			var i70 = new symbol_b1d57730fb5102689c8e9f93c013aa1b();
			addChild(i70);//0
		}
	}
	public class symbol_ef0604cd0a0b7c3c607f061d119811fc : MovieClip{ 
		public symbol_ef0604cd0a0b7c3c607f061d119811fc() {
			var i139 = new symbol_be2c707012ded825a6816ce57b6f216f();
			addChild(i139);//0
		}
	}
	public class symbol_f0afc089392fbc92ccd67bad587a9191 : Shape{ 
		public symbol_f0afc089392fbc92ccd67bad587a9191() {
			setGraphics("4ee97726dc6574224dff99c45e79ceb5", -16.65, -16.6, 33.3, 33.3, 34, 34);
		}
	}
	public class symbol_f0fedc37ffd0f9a8c3b746bd52f0a51c : MovieClip{ 
		public symbol_f0fedc37ffd0f9a8c3b746bd52f0a51c() {
			var i40 = new symbol_18f3e6fbb5928217c32523a2c7b2cd8f();
			addChild(i40);//0
		}
	}
	public class symbol_f5f092b1ecaac81f8aefe6eb854afa47 : Shape{ 
		public symbol_f5f092b1ecaac81f8aefe6eb854afa47() {
			setGraphics("15af8f48cd86a990673a46009c0b24a7", 0, 0, 35, 36, 35, 36);
		}
	}
	public class symbol_f906ab364cddc373daa721033aff3b27 : MovieClip{ 
		public symbol_f906ab364cddc373daa721033aff3b27() {
			var i116 = new symbol_a1a4a2e580292dd61e76de66077c63b9();
			addChild(i116);//0
		}
	}
	public class symbol_fce27d71d54faba9e363342898c7e45e : MovieClip{ 
		public symbol_fce27d71d54faba9e363342898c7e45e() {
			var i64 = new symbol_d040a13492cd4e451bf089dfbca5b8ab();
			addChild(i64);//0
		}
	}
}
