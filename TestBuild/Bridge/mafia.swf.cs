using System;
using flash.display;
using System.Collections.Generic;
using as3;
using mafia.swf.privateSymbols;

public class ComissarHintImg : MovieClip{ 
	public ComissarHintImg() {
		var i8 = new symbol_910d6bdd5350deceb0eb4816e954fc46();
		addChild(i8);//0
	}
}
public class MafiaCardBack : BitmapData{ 
	public MafiaCardBack() {
		width = 188;
		height = 269;
		setPixels("66f5b7d0d411be6047946654ea8a20cc");
	}
}
public class MafiaCardCommissar : BitmapData{ 
	public MafiaCardCommissar() {
		width = 188;
		height = 269;
		setPixels("fb620d910c3ca029a2f2968f4fc3e0a7");
	}
}
public class MafiaCardDoctor : BitmapData{ 
	public MafiaCardDoctor() {
		width = 188;
		height = 269;
		setPixels("efa22bebc798cd57a27e226342457a12");
	}
}
public class MafiaCardMafioso : BitmapData{ 
	public MafiaCardMafioso() {
		width = 188;
		height = 269;
		setPixels("8cde9625992d35599281bea7d577077b");
	}
}
public class MafiaCounterShot : BitmapData{ 
	public MafiaCounterShot() {
		width = 26;
		height = 22;
		setPixels("c7437902ed1461bf0a9b75e8a1e67716");
	}
}
public class MafiaCounterTrial : BitmapData{ 
	public MafiaCounterTrial() {
		width = 26;
		height = 22;
		setPixels("baba2e945435e64a9e19e63c99d5751b");
	}
}
public class MafiaCursorHealing : BitmapData{ 
	public MafiaCursorHealing() {
		width = 37;
		height = 32;
		setPixels("a7ada291a64b6db3109b37e454f3afbd");
	}
}
public class MafiaCursorShot : BitmapData{ 
	public MafiaCursorShot() {
		width = 37;
		height = 32;
		setPixels("2e94b9615220118e0b803346ad55b4e9");
	}
}
public class MafiaCursorTrial : BitmapData{ 
	public MafiaCursorTrial() {
		width = 37;
		height = 32;
		setPixels("a39312a9349b57c3957a4ed6166a7f07");
	}
}
public class MafiaDeadIcon : BitmapData{ 
	public MafiaDeadIcon() {
		width = 122;
		height = 80;
		setPixels("6238248d4a92a69ea821ddbb31e1b566");
	}
}
public class MafiaHealing : MovieClip{ 
	public MafiaHealing() {
		var i29 = new symbol_747b23780a4a7a85dde459441a095eec(){y = 74.1 , x = 43.75};
		addChild(i29);//0
		var i30 = new symbol_31e0fd89c44d035689c942ad04286c9b(){blendMode = "add"};
		addChild(i30);//1
		var i32 = new symbol_a10224c7131436b8bce9bfb8013622d3();
		addChild(i32);//2
		var i33 = new symbol_5d2e556a9dd559f5f83ae773e076c625(){y = 106.95 , x = 41.45};
		addChild(i33);//3
		var i35 = new symbol_747b23780a4a7a85dde459441a095eec(){y = 74.9 , x = 43.45};
		addChild(i35);//4
		var i55 = new mafia6_fla.animation_part_26(){y = 107.15 , x = 43.45};
		addChild(i55);//4
		var i39 = new symbol_50e6f0710a02130764ae9ec83c359f5b(){x = 11.8 , scaleY = 21.864059448242188 , y = 64.25 , scaleX = 0.5833282470703125 , alpha = 0};
		addChild(i39);//5
		var i36 = new symbol_26eec99206f141228e7a3cd96dad92b9(){x = 32.6 , scaleY = 0.712921142578125 , y = 52.55 , scaleX = 0.712921142578125 , alpha = 0};
		addChild(i36);//5
		var i51 = new symbol_c4c73c8a301dda6317c14b9a2fd41523(){x = 27.95 , scaleY = 21.864059448242188 , y = 57.2 , scaleX = 0.5833282470703125 , alpha = 0};
		addChild(i51);//6
		var i41 = new symbol_2cf7ddf432b32270b022bf251f1e12b0(){x = 72.95 , scaleY = 21.864059448242188 , y = 65.2 , scaleX = 0.5833282470703125 , alpha = 0};
		addChild(i41);//6
		var i43 = new symbol_342beba354ea99ae28704c12feb7e6a9(){x = 6 , scaleY = 0.665069580078125 , y = 95.55 , scaleX = 0.665069580078125 , alpha = 0};
		addChild(i43);//7
		var i45 = new symbol_3a63d1ec2c554e84437e964deb281c9a(){x = 48.95 , scaleY = 21.864059448242188 , y = 36.45 , scaleX = 0.5833282470703125 , alpha = 0};
		addChild(i45);//7
		var i49 = new symbol_7d330197d3cddb1915cd2ef12041bb48(){x = 53.1 , scaleY = 0.665069580078125 , y = 75.55 , scaleX = 0.665069580078125 , alpha = 0};
		addChild(i49);//8
		var i47 = new symbol_4e0aea374ac55cfa961e860a8766587f(){x = 78.4 , scaleY = 0.712921142578125 , y = 70.55 , scaleX = 0.712921142578125 , alpha = 0};
		addChild(i47);//10
		var i53 = new symbol_f8286a0b1c024efeec0c56c07435c11a(){x = 38.6 , scaleY = 0.712921142578125 , y = 98.05 , scaleX = 0.712921142578125 , alpha = 0};
		addChild(i53);//13
		FrameInfo f;
		var l= new Frames(160);
		f = l.Add()+i29;
		f = l.Add()+i29+i30+i32+i33+i35+i36;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i41;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i41+i43;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i41+i43+i45+i47;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i41+i43+i45+i47;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i41+i43+i45+i49+i47;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i41+i43+i45+i49+i47;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i51+i41+i43+i45+i49+i47;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i51+i41+i43+i45+i49+i47;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i39+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i39+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i39+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i39+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i41+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i43+i45+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i51+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i35+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i55+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		f = l.Add()+i29+i30+i32+i33+i36+i43+i49+i47+i53;
		setFrames(l);
	}
}
public class MafiaRoleCommissar : MovieClip{ 
	public MafiaRoleCommissar() {
		var i70 = new symbol_a10224c7131436b8bce9bfb8013622d3();
		addChild(i70);//0
		var i75 = new symbol_60a41b26ab32dc47bb19bedd65a55c56(){y = 75 , x = -40.5};
		addChild(i75);//0
		var i71 = new symbol_d13941406d124237bf733d4f2e32132d(){y = 75 , x = 31};
		addChild(i71);//1
		var i73 = new symbol_7864b7afdf4ab6be9286fac331fffcff(){x = -35 , y = 75 , scaleX = 0.07843017578125};
		addChild(i73);//1
		FrameInfo f;
		var l= new Frames(38);
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add()+i70+i71;
		f = l.Add()+i70+i71;
		f = l.Add()+i70+i71;
		f = l.Add()+i70+i71;
		f = l.Add()+i70+i71;
		f = l.Add()+i70+i71;
		f = l.Add()+i70+i71;
		f = l.Add()+i70+i71;
		f = l.Add()+i70+i73;
		f = l.Add()+i70+i73;
		f = l.Add()+i70+i73;
		f = l.Add()+i70+i73;
		f = l.Add()+i70+i73;
		f = l.Add()+i70+i73;
		f = l.Add()+i70+i73;
		f = l.Add()+i70+i73;
		f = l.Add()+i75;
		f = l.Add()+i75;
		f = l.Add()+i75;
		f = l.Add()+i75;
		f = l.Add()+i75;
		f = l.Add()+i75;
		f = l.Add()+i75;
		setFrames(l);
	}
}
public class MafiaRoleDoctor : MovieClip{ 
	public MafiaRoleDoctor() {
		var i83 = new symbol_2ccc2d7a7efe85a0b95a4d1b831dc431(){y = 75 , x = -40.5};
		addChild(i83);//0
		var i78 = new symbol_a10224c7131436b8bce9bfb8013622d3();
		addChild(i78);//0
		var i81 = new symbol_ee57bad9d8fcd4685f89332a862117cb(){x = -35 , y = 75 , scaleX = 0.07843017578125};
		addChild(i81);//1
		var i79 = new symbol_0098b6e6aaf2c122316158f0c9ed4132(){y = 75 , x = 31};
		addChild(i79);//1
		FrameInfo f;
		var l= new Frames(38);
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add()+i78+i79;
		f = l.Add()+i78+i79;
		f = l.Add()+i78+i79;
		f = l.Add()+i78+i79;
		f = l.Add()+i78+i79;
		f = l.Add()+i78+i79;
		f = l.Add()+i78+i79;
		f = l.Add()+i78+i79;
		f = l.Add()+i78+i81;
		f = l.Add()+i78+i81;
		f = l.Add()+i78+i81;
		f = l.Add()+i78+i81;
		f = l.Add()+i78+i81;
		f = l.Add()+i78+i81;
		f = l.Add()+i78+i81;
		f = l.Add()+i78+i81;
		f = l.Add()+i83;
		f = l.Add()+i83;
		f = l.Add()+i83;
		f = l.Add()+i83;
		f = l.Add()+i83;
		f = l.Add()+i83;
		f = l.Add()+i83;
		setFrames(l);
	}
}
public class MafiaRoleIsBusy : BitmapData{ 
	public MafiaRoleIsBusy() {
		width = 144;
		height = 81;
		setPixels("01a3785c369582ffe50d441a7efd54f2");
	}
}
public class MafiaRoleMafioso : MovieClip{ 
	public MafiaRoleMafioso() {
		var i91 = new symbol_38a0245e33fd9a152928c2ae0c7f8bdb(){y = 75 , x = -40.5};
		addChild(i91);//0
		var i86 = new symbol_a10224c7131436b8bce9bfb8013622d3();
		addChild(i86);//0
		var i87 = new symbol_a7b7d21583296fa01ec5f34ad25bb8cf(){y = 75 , x = 31};
		addChild(i87);//1
		var i89 = new symbol_54f00487e25703cb563415eee60a3897(){x = -35 , y = 75 , scaleX = 0.07843017578125};
		addChild(i89);//1
		FrameInfo f;
		var l= new Frames(38);
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add()+i86+i87;
		f = l.Add()+i86+i87;
		f = l.Add()+i86+i87;
		f = l.Add()+i86+i87;
		f = l.Add()+i86+i87;
		f = l.Add()+i86+i87;
		f = l.Add()+i86+i87;
		f = l.Add()+i86+i87;
		f = l.Add()+i86+i89;
		f = l.Add()+i86+i89;
		f = l.Add()+i86+i89;
		f = l.Add()+i86+i89;
		f = l.Add()+i86+i89;
		f = l.Add()+i86+i89;
		f = l.Add()+i86+i89;
		f = l.Add()+i86+i89;
		f = l.Add()+i91;
		f = l.Add()+i91;
		f = l.Add()+i91;
		f = l.Add()+i91;
		f = l.Add()+i91;
		f = l.Add()+i91;
		f = l.Add()+i91;
		setFrames(l);
	}
}
public class MafiaRoleSimple : MovieClip{ 
	public MafiaRoleSimple() {
		var i94 = new symbol_a10224c7131436b8bce9bfb8013622d3();
		addChild(i94);//0
		var i99 = new symbol_58d8b0e0814efc1296090c9ec1aab9a8(){y = 75 , x = -40.5};
		addChild(i99);//0
		var i95 = new symbol_bbe3ce8d39ca25dc34c4e770366f64d8(){y = 75 , x = 31};
		addChild(i95);//1
		var i97 = new symbol_d6c48713f99546d355f9c9f2d403eb97(){x = -35 , y = 75 , scaleX = 0.07843017578125};
		addChild(i97);//1
		FrameInfo f;
		var l= new Frames(38);
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add();
		f = l.Add()+i94+i95;
		f = l.Add()+i94+i95;
		f = l.Add()+i94+i95;
		f = l.Add()+i94+i95;
		f = l.Add()+i94+i95;
		f = l.Add()+i94+i95;
		f = l.Add()+i94+i95;
		f = l.Add()+i94+i95;
		f = l.Add()+i94+i97;
		f = l.Add()+i94+i97;
		f = l.Add()+i94+i97;
		f = l.Add()+i94+i97;
		f = l.Add()+i94+i97;
		f = l.Add()+i94+i97;
		f = l.Add()+i94+i97;
		f = l.Add()+i94+i97;
		f = l.Add()+i99;
		f = l.Add()+i99;
		f = l.Add()+i99;
		f = l.Add()+i99;
		f = l.Add()+i99;
		f = l.Add()+i99;
		f = l.Add()+i99;
		setFrames(l);
	}
}
public class MafiaShot : MovieClip{ 
	public MafiaShot() {
		var i102 = new mafia6_fla.shot_15();
		addChild(i102);//0
	}
}
public class MafiaShotDst : MovieClip{ 
	public MafiaShotDst() {
		var i108 = new symbol_0ccd87b15dacf3286925a67be5bb6f17(){y = 2.15 , x = -1.4};
		addChild(i108);//0
		FrameInfo f;
		var l= new Frames(30);
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add()+i108;
		f = l.Add();
		setFrames(l);
	}
}
public class MafiaShotSrc : MovieClip{ 
	public MafiaShotSrc() {
		var i118 = new symbol_b46e241c9eacf4121589ea2e5f844048(){x = 3.35 , y = 0.5 , rotation = 3.141592653589793};
		addChild(i118);//0
		FrameInfo f;
		var l= new Frames(31);
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add()+i118;
		f = l.Add();
		setFrames(l);
	}
}
public class MafiaStateCommisarShot : BitmapData{ 
	public MafiaStateCommisarShot() {
		width = 141;
		height = 146;
		setPixels("f8d90c1a963ca2d5202ca686442eb12b");
	}
}
public class MafiaStateHealing : BitmapData{ 
	public MafiaStateHealing() {
		width = 141;
		height = 146;
		setPixels("c8644b65f61d427b5c1b18b5f7baf883");
	}
}
public class MafiaStateMafiaShot : BitmapData{ 
	public MafiaStateMafiaShot() {
		width = 141;
		height = 146;
		setPixels("2bfee27ddc7fa5a6d81a8c3c430042be");
	}
}
public class MafiaStateMeeting : BitmapData{ 
	public MafiaStateMeeting() {
		width = 141;
		height = 146;
		setPixels("dea5b0ea83bab302bd7eb1c923b4a372");
	}
}
public class MafiaStateTrial : BitmapData{ 
	public MafiaStateTrial() {
		width = 141;
		height = 146;
		setPixels("6d3752d0fc9f8959e6ecc80c4ea1b00d");
	}
}
public class MafiaStateWaiting : BitmapData{ 
	public MafiaStateWaiting() {
		width = 141;
		height = 146;
		setPixels("acb5d7c97db6438d9607c58185639741");
	}
}
public class MafiaVoted : MovieClip{ 
	public MafiaVoted() {
		var i121 = new symbol_07c42aa4a2ecd1dbb807e7ed484f6713(){blendMode = "add"};
		addChild(i121);//0
		FrameInfo f;
		var l= new Frames(21);
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add()+i121;
		f = l.Add();
		setFrames(l);
	}
}
public class MafiosoHintImg : MovieClip{ 
	public MafiosoHintImg() {
		var i124 = new symbol_7cd2b608915c239f1dbcd532f4449fc2();
		addChild(i124);//0
	}
}
public class ResultAliveIcon : BitmapData{ 
	public ResultAliveIcon() {
		width = 18;
		height = 18;
		setPixels("1c1492481c8adfca6d049d7132546c75");
	}
}
public class ResultDeathIcon : BitmapData{ 
	public ResultDeathIcon() {
		width = 18;
		height = 18;
		setPixels("f7b8ab58c942801be61cf07fda924e17");
	}
}
public class SimpleHintImg : MovieClip{ 
	public SimpleHintImg() {
		var i126 = new symbol_ab6f34d395fa7f0cffaa2da80037e57c();
		addChild(i126);//0
	}
}
public class WinnersMafiaImage : BitmapData{ 
	public WinnersMafiaImage() {
		width = 141;
		height = 176;
		setPixels("5ac56377d52ce597e1b1211f08417ec3");
	}
}
public class WinnersSimpleImage : BitmapData{ 
	public WinnersSimpleImage() {
		width = 141;
		height = 176;
		setPixels("deea7378466041a823ee44a68ac159f2");
	}
}
namespace mafia6_fla
{	public class animation_part_26 : MovieClip{ 
		public animation_part_26() {
			var i10 = new symbol_747b23780a4a7a85dde459441a095eec();
			addChild(i10);//0
			var i11 = new symbol_0354a6117c3cb280454a56fc5771f019(){x = -35.75 , scaleY = 0.7311859130859375 , y = -2.5 , scaleX = 0.7311859130859375 , alpha = 0};
			addChild(i11);//1
			var i13 = new symbol_e5ddfcb377c88ca5a70d390b836752d8(){x = -0.95 , scaleY = 0.7311859130859375 , y = 3.05 , scaleX = 0.7311859130859375 , alpha = 0};
			addChild(i13);//2
			var i15 = new symbol_b61a1e211abe8a3b1fac35b24dc818d4(){x = -17.25 , scaleY = 0.7311859130859375 , y = -14.9 , scaleX = 0.7311859130859375 , alpha = 0};
			addChild(i15);//2
			var i17 = new symbol_0ef5c649952aea02fe7ce30d64bdc795(){x = 36.35 , scaleY = 0.7311859130859375 , y = -5.45 , scaleX = 0.7311859130859375 , alpha = 0};
			addChild(i17);//4
			var i21 = new symbol_a20c229130de82fcd485fda4f9166bed(){x = -10.8 , scaleY = 0.7311859130859375 , y = -2 , scaleX = 0.7311859130859375 , alpha = 0};
			addChild(i21);//4
			var i19 = new symbol_0794051886699c9b1bf044d00d20cf31(){x = 21.65 , scaleY = 0.7311859130859375 , y = -18.95 , scaleX = 0.7311859130859375 , alpha = 0};
			addChild(i19);//5
			FrameInfo f;
			var l= new Frames(85);
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11;
			f = l.Add()+i10+i11+i13;
			f = l.Add()+i10+i11+i13;
			f = l.Add()+i10+i11+i13;
			f = l.Add()+i10+i11+i13+i15;
			f = l.Add()+i10+i11+i13+i15;
			f = l.Add()+i10+i11+i13+i15+i17;
			f = l.Add()+i10+i11+i13+i15+i17;
			f = l.Add()+i10+i11+i13+i15+i17;
			f = l.Add()+i10+i11+i13+i15+i17;
			f = l.Add()+i10+i11+i13+i15+i17;
			f = l.Add()+i10+i11+i13+i15+i17+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i11+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i13+i15+i17+i21+i19;
			f = l.Add()+i10+i15+i17+i21+i19;
			f = l.Add()+i10+i15+i17+i21+i19;
			f = l.Add()+i10+i15+i17+i21+i19;
			f = l.Add()+i10+i15+i17+i21+i19;
			f = l.Add()+i10+i17+i21+i19;
			f = l.Add()+i10+i21+i19;
			f = l.Add()+i10+i21+i19;
			f = l.Add()+i10+i21+i19;
			f = l.Add()+i10+i21+i19;
			f = l.Add()+i10+i21;
			f = l.Add()+i10+i21;
			f = l.Add()+i10;
			setFrames(l);
		}
	}
	public class shot_15 : MovieClip{ 
		public shot_15() {
			var i26 = new symbol_89aa356c83adc7b913073f6eaefa74e7();
			addChild(i26);//0
			var i25 = new symbol_0d7c0f70570199026b04063049400b15();
			addChild(i25);//0
			var i27 = new symbol_5c381a61b78e3f9858a95db24f4a2ddb();
			addChild(i27);//0
			var i24 = new symbol_89aa356c83adc7b913073f6eaefa74e7();
			addChild(i24);//0
			FrameInfo f;
			var l= new Frames(70);
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i24;
			f = l.Add()+i25;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i26;
			f = l.Add()+i27;
			setFrames(l);
		}
	}
}
namespace mafia.swf.privateSymbols{
	public class symbol_0026aeb37c0e1220c73c4b6c5755a6eb : Shape{ 
		public symbol_0026aeb37c0e1220c73c4b6c5755a6eb() {
			setGraphics("2220801208436e93e4db624cde85eb17", -1.9, -1.9, 3.8499999999999996, 3.8, 3, 3);
		}
	}
	public class symbol_0077f68ecd507954153a659118287507 : Shape{ 
		public symbol_0077f68ecd507954153a659118287507() {
			setGraphics("3c807d1b58146b6e9cd3ce7733355976", 0, 0, 85, 110, 85, 110);
		}
	}
	public class symbol_0098b6e6aaf2c122316158f0c9ed4132 : MovieClip{ 
		public symbol_0098b6e6aaf2c122316158f0c9ed4132() {
			var i80 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i80);//0
		}
	}
	public class symbol_0354a6117c3cb280454a56fc5771f019 : MovieClip{ 
		public symbol_0354a6117c3cb280454a56fc5771f019() {
			var i12 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i12);//0
		}
	}
	public class symbol_03c941da09982661029ba2997b50d377 : Shape{ 
		public symbol_03c941da09982661029ba2997b50d377() {
			setGraphics("df094894547aa1c0bc0295b75fc924d5", -28.1, -1.8, 56.25, 3.6, 33, 79);
		}
	}
	public class symbol_0794051886699c9b1bf044d00d20cf31 : MovieClip{ 
		public symbol_0794051886699c9b1bf044d00d20cf31() {
			var i20 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i20);//0
		}
	}
	public class symbol_07c42aa4a2ecd1dbb807e7ed484f6713 : MovieClip{ 
		public symbol_07c42aa4a2ecd1dbb807e7ed484f6713() {
			var i122 = new symbol_bf40a594881c08e545ef72447bebfb4e();
			addChild(i122);//0
		}
	}
	public class symbol_0ccd87b15dacf3286925a67be5bb6f17 : MovieClip{ 
		public symbol_0ccd87b15dacf3286925a67be5bb6f17() {
			var i109 = new symbol_cc526685ddf6a4f09343c8f802947880();
			addChild(i109);//0
			var i111 = new symbol_6637501aff5a0529f23f63030a290870(){x = 3.35 , y = 0.5 , rotation = 3.141592653589793};
			addChild(i111);//1
			var i113 = new symbol_cb79d9d3ac8036f6c93a3f1febd2d934(){x = 0.45 , scaleY = 0.9999866531271137 , y = -2 , rotation = 1.8326053019739703 , scaleX = 0.9999866531271137};
			addChild(i113);//2
			var i115 = new symbol_71f286b53f93c5fc82c7970a1cbfb20c(){x = -1.05 , scaleY = 0.9999866531271137 , y = -3.5 , rotation = 1.3089873516158228 , scaleX = 0.9999866531271137};
			addChild(i115);//3
			FrameInfo f;
			var l= new Frames(30);
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i109+i111+i113+i115;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111+i113;
			f = l.Add()+i111;
			f = l.Add()+i111;
			f = l.Add()+i111;
			f = l.Add()+i111;
			setFrames(l);
		}
	}
	public class symbol_0d7c0f70570199026b04063049400b15 : Shape{ 
		public symbol_0d7c0f70570199026b04063049400b15() {
			setGraphics("bb3ceae93a660f3b7f39610c778f750a", 0, 1, 144, 1.4, 144, 2);
		}
	}
	public class symbol_0ef5c649952aea02fe7ce30d64bdc795 : MovieClip{ 
		public symbol_0ef5c649952aea02fe7ce30d64bdc795() {
			var i18 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i18);//0
		}
	}
	public class symbol_1bf97f9ea703e81b67b97b7aabbad3cf : Shape{ 
		public symbol_1bf97f9ea703e81b67b97b7aabbad3cf() {
			setGraphics("dd6c6bada59557398727bc51fbcd0e74", -4.75, -2.25, 9.55, 4.5, 10, 5);
		}
	}
	public class symbol_26eec99206f141228e7a3cd96dad92b9 : MovieClip{ 
		public symbol_26eec99206f141228e7a3cd96dad92b9() {
			var i37 = new symbol_46b891339bd4b6856cc16a4363965b66();
			addChild(i37);//0
		}
	}
	public class symbol_2ccc2d7a7efe85a0b95a4d1b831dc431 : MovieClip{ 
		public symbol_2ccc2d7a7efe85a0b95a4d1b831dc431() {
			var i84 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i84);//0
		}
	}
	public class symbol_2cf7ddf432b32270b022bf251f1e12b0 : MovieClip{ 
		public symbol_2cf7ddf432b32270b022bf251f1e12b0() {
			var i42 = new symbol_03c941da09982661029ba2997b50d377();
			addChild(i42);//0
		}
	}
	public class symbol_31e0fd89c44d035689c942ad04286c9b : MovieClip{ 
		public symbol_31e0fd89c44d035689c942ad04286c9b() {
			var i31 = new symbol_0077f68ecd507954153a659118287507();
			addChild(i31);//0
		}
	}
	public class symbol_342beba354ea99ae28704c12feb7e6a9 : MovieClip{ 
		public symbol_342beba354ea99ae28704c12feb7e6a9() {
			var i44 = new symbol_46b891339bd4b6856cc16a4363965b66();
			addChild(i44);//0
		}
	}
	public class symbol_3530b55b0611edaaa71184fc53a4be7c : MovieClip{ 
		public symbol_3530b55b0611edaaa71184fc53a4be7c() {
			var i60 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i60);//0
		}
	}
	public class symbol_38a0245e33fd9a152928c2ae0c7f8bdb : MovieClip{ 
		public symbol_38a0245e33fd9a152928c2ae0c7f8bdb() {
			var i92 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i92);//0
		}
	}
	public class symbol_3a63d1ec2c554e84437e964deb281c9a : MovieClip{ 
		public symbol_3a63d1ec2c554e84437e964deb281c9a() {
			var i46 = new symbol_03c941da09982661029ba2997b50d377();
			addChild(i46);//0
		}
	}
	public class symbol_46b891339bd4b6856cc16a4363965b66 : Shape{ 
		public symbol_46b891339bd4b6856cc16a4363965b66() {
			setGraphics("6fbaebc704af27f7b0338ab7a2875e8e", -10.65, -10.15, 20.9, 20.950000000000003, 15, 15);
		}
	}
	public class symbol_4e0aea374ac55cfa961e860a8766587f : MovieClip{ 
		public symbol_4e0aea374ac55cfa961e860a8766587f() {
			var i48 = new symbol_46b891339bd4b6856cc16a4363965b66();
			addChild(i48);//0
		}
	}
	public class symbol_506500a27ca9ffdac4dab6927feced22 : MovieClip{ 
		public symbol_506500a27ca9ffdac4dab6927feced22() {
			var i68 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i68);//0
		}
	}
	public class symbol_50e6f0710a02130764ae9ec83c359f5b : MovieClip{ 
		public symbol_50e6f0710a02130764ae9ec83c359f5b() {
			var i40 = new symbol_03c941da09982661029ba2997b50d377();
			addChild(i40);//0
		}
	}
	public class symbol_54f00487e25703cb563415eee60a3897 : MovieClip{ 
		public symbol_54f00487e25703cb563415eee60a3897() {
			var i90 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i90);//0
		}
	}
	public class symbol_58d8b0e0814efc1296090c9ec1aab9a8 : MovieClip{ 
		public symbol_58d8b0e0814efc1296090c9ec1aab9a8() {
			var i100 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i100);//0
		}
	}
	public class symbol_5c381a61b78e3f9858a95db24f4a2ddb : Shape{ 
		public symbol_5c381a61b78e3f9858a95db24f4a2ddb() {
			setGraphics("efd56130844f12aa9318ff591f49e15b", 0, 1, 144, 1.4, 144, 2);
		}
	}
	public class symbol_5d2e556a9dd559f5f83ae773e076c625 : MovieClip{ 
		public symbol_5d2e556a9dd559f5f83ae773e076c625() {
			var i34 = new symbol_89aa356c83adc7b913073f6eaefa74e7();
			addChild(i34);//0
			var i38 = new symbol_d4444fbcd958675536f35cf2a7417518();
			addChild(i38);//0
			FrameInfo f;
			var l= new Frames(40);
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i34;
			f = l.Add()+i38;
			setFrames(l);
		}
	}
	public class symbol_60a41b26ab32dc47bb19bedd65a55c56 : MovieClip{ 
		public symbol_60a41b26ab32dc47bb19bedd65a55c56() {
			var i76 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i76);//0
		}
	}
	public class symbol_6297954aec88b239bc6dcd668c781af7 : MovieClip{ 
		public symbol_6297954aec88b239bc6dcd668c781af7() {
			var i58 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i58);//0
		}
	}
	public class symbol_6637501aff5a0529f23f63030a290870 : MovieClip{ 
		public symbol_6637501aff5a0529f23f63030a290870() {
			var i112 = new symbol_dcad2376456c177c5afada55d6068e7e();
			addChild(i112);//0
		}
	}
	public class symbol_71f286b53f93c5fc82c7970a1cbfb20c : MovieClip{ 
		public symbol_71f286b53f93c5fc82c7970a1cbfb20c() {
			var i116 = new symbol_dcad2376456c177c5afada55d6068e7e();
			addChild(i116);//0
		}
	}
	public class symbol_747b23780a4a7a85dde459441a095eec : Shape{ 
		public symbol_747b23780a4a7a85dde459441a095eec() {
			setGraphics("2a894363aa0d65c959b126d43d2d6ef7", -43.75, -74.1, 85, 110, 85, 110);
		}
	}
	public class symbol_7864b7afdf4ab6be9286fac331fffcff : MovieClip{ 
		public symbol_7864b7afdf4ab6be9286fac331fffcff() {
			var i74 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i74);//0
		}
	}
	public class symbol_7cd2b608915c239f1dbcd532f4449fc2 : Shape{ 
		public symbol_7cd2b608915c239f1dbcd532f4449fc2() {
			setGraphics("ff2dfa64028eebc4db290f9370030b1b", -1, -232.65, 183, 233, 183, 233);
		}
	}
	public class symbol_7d330197d3cddb1915cd2ef12041bb48 : MovieClip{ 
		public symbol_7d330197d3cddb1915cd2ef12041bb48() {
			var i50 = new symbol_46b891339bd4b6856cc16a4363965b66();
			addChild(i50);//0
		}
	}
	public class symbol_89aa356c83adc7b913073f6eaefa74e7 : MorphShape{ 
		public symbol_89aa356c83adc7b913073f6eaefa74e7() {
		}
	}
	public class symbol_8d5774bc854be3bc5db388bafb4d6a8c : MovieClip{ 
		public symbol_8d5774bc854be3bc5db388bafb4d6a8c() {
			var i64 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i64);//0
		}
	}
	public class symbol_910d6bdd5350deceb0eb4816e954fc46 : Shape{ 
		public symbol_910d6bdd5350deceb0eb4816e954fc46() {
			setGraphics("a3a52289cce07ae30d2b7bb59d8c2967", -1.25, -246.65, 183, 247, 183, 247);
		}
	}
	public class symbol_9efbf786f7767670038a3a9c4fc2dbd5 : MovieClip{ 
		public symbol_9efbf786f7767670038a3a9c4fc2dbd5() {
			var i62 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i62);//0
		}
	}
	public class symbol_a10224c7131436b8bce9bfb8013622d3 : Shape{ 
		public symbol_a10224c7131436b8bce9bfb8013622d3() {
		}
	}
	public class symbol_a20c229130de82fcd485fda4f9166bed : MovieClip{ 
		public symbol_a20c229130de82fcd485fda4f9166bed() {
			var i22 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i22);//0
		}
	}
	public class symbol_a7b7d21583296fa01ec5f34ad25bb8cf : MovieClip{ 
		public symbol_a7b7d21583296fa01ec5f34ad25bb8cf() {
			var i88 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i88);//0
		}
	}
	public class symbol_ab6f34d395fa7f0cffaa2da80037e57c : Shape{ 
		public symbol_ab6f34d395fa7f0cffaa2da80037e57c() {
			setGraphics("e139768c46c6194803ee8bc4a14567f5", -1, -240.65, 183, 241, 183, 241);
		}
	}
	public class symbol_b46e241c9eacf4121589ea2e5f844048 : MovieClip{ 
		public symbol_b46e241c9eacf4121589ea2e5f844048() {
			var i119 = new symbol_1bf97f9ea703e81b67b97b7aabbad3cf();
			addChild(i119);//0
		}
	}
	public class symbol_b61a1e211abe8a3b1fac35b24dc818d4 : MovieClip{ 
		public symbol_b61a1e211abe8a3b1fac35b24dc818d4() {
			var i16 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i16);//0
		}
	}
	public class symbol_bbe3ce8d39ca25dc34c4e770366f64d8 : MovieClip{ 
		public symbol_bbe3ce8d39ca25dc34c4e770366f64d8() {
			var i96 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i96);//0
		}
	}
	public class symbol_bf40a594881c08e545ef72447bebfb4e : Shape{ 
		public symbol_bf40a594881c08e545ef72447bebfb4e() {
			setGraphics("5cc9949741406316dd4b74936b0e4a75", 0, 0, 85, 110, 85, 110);
		}
	}
	public class symbol_bf6825a3a6b59c64dd327479b55974bb : MovieClip{ 
		public symbol_bf6825a3a6b59c64dd327479b55974bb() {
			var i66 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i66);//0
		}
	}
	public class symbol_c4c73c8a301dda6317c14b9a2fd41523 : MovieClip{ 
		public symbol_c4c73c8a301dda6317c14b9a2fd41523() {
			var i52 = new symbol_03c941da09982661029ba2997b50d377();
			addChild(i52);//0
		}
	}
	public class symbol_cb79d9d3ac8036f6c93a3f1febd2d934 : MovieClip{ 
		public symbol_cb79d9d3ac8036f6c93a3f1febd2d934() {
			var i114 = new symbol_dcad2376456c177c5afada55d6068e7e();
			addChild(i114);//0
		}
	}
	public class symbol_cc526685ddf6a4f09343c8f802947880 : MovieClip{ 
		public symbol_cc526685ddf6a4f09343c8f802947880() {
			var i110 = new symbol_dcad2376456c177c5afada55d6068e7e();
			addChild(i110);//0
		}
	}
	public class symbol_d13941406d124237bf733d4f2e32132d : MovieClip{ 
		public symbol_d13941406d124237bf733d4f2e32132d() {
			var i72 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i72);//0
		}
	}
	public class symbol_d4444fbcd958675536f35cf2a7417518 : Shape{ 
		public symbol_d4444fbcd958675536f35cf2a7417518() {
			setGraphics("d034e624a3e7b8a9def592a9d3fe4f95", -52.8, -11.7, 105.6, 23.4, 106, 24);
		}
	}
	public class symbol_d6c48713f99546d355f9c9f2d403eb97 : MovieClip{ 
		public symbol_d6c48713f99546d355f9c9f2d403eb97() {
			var i98 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i98);//0
		}
	}
	public class symbol_db1cc8e01edbbd7db97bb3545a280754 : Shape{ 
		public symbol_db1cc8e01edbbd7db97bb3545a280754() {
			setGraphics("38f151e54e4f2ccab4d207810f09d497", -25, -33, 51, 67, 51, 67);
		}
	}
	public class symbol_dcad2376456c177c5afada55d6068e7e : Shape{ 
		public symbol_dcad2376456c177c5afada55d6068e7e() {
			setGraphics("191f1e4e35cb500e28b45eaae2fc0fac", -2.4, -1.4, 4.75, 2.75, 5, 3);
		}
	}
	public class symbol_e5ddfcb377c88ca5a70d390b836752d8 : MovieClip{ 
		public symbol_e5ddfcb377c88ca5a70d390b836752d8() {
			var i14 = new symbol_0026aeb37c0e1220c73c4b6c5755a6eb();
			addChild(i14);//0
		}
	}
	public class symbol_ee57bad9d8fcd4685f89332a862117cb : MovieClip{ 
		public symbol_ee57bad9d8fcd4685f89332a862117cb() {
			var i82 = new symbol_db1cc8e01edbbd7db97bb3545a280754();
			addChild(i82);//0
		}
	}
	public class symbol_f8286a0b1c024efeec0c56c07435c11a : MovieClip{ 
		public symbol_f8286a0b1c024efeec0c56c07435c11a() {
			var i54 = new symbol_46b891339bd4b6856cc16a4363965b66();
			addChild(i54);//0
		}
	}
}
