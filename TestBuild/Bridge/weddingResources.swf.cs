using System;

using flash.display;
using System.Collections.Generic;
using weddingResources.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class LibweddingResources : ResourcesExternalLib{
	public LibweddingResources() {
	vectors = new string[] {
	"9685cbb3de3cb1ea9c9009c1dfbd4ee0",
	"8d8150777c2fa67dbc7fb10b180f8f7b"
	};
	graphics = new string[] {
	"c600817da1d692422d2c7d68f15f347a",
	"4b53b25db5633e8dfd9d8ebdd5a9c603",
	"c600817da1d692422d2c7d68f15f347a",
	"f0d38fe60ac2b233777265716c7034e2",
	"827c7cf74305524461825a1c28739112",
	"7288945b5ed827b8c6e22ba3faafcccc",
	"1f774a8924e7a9d1b61e4d15af9d6b3f",
	"908f740e6deb8304210c1cce528818c3"
	};
	}
}
public class AnswerYesShining : BitmapData{ 
	public AnswerYesShining() {
		width = 508;
		height = 119;
		setPixels("f0d38fe60ac2b233777265716c7034e2");
	}
}
public class ArrowBubbleAnswer : BitmapData{ 
	public ArrowBubbleAnswer() {
		width = 27;
		height = 34;
		setPixels("7288945b5ed827b8c6e22ba3faafcccc");
	}
}
public class BlueRingBox : BitmapData{ 
	public BlueRingBox() {
		width = 154;
		height = 170;
		setPixels("827c7cf74305524461825a1c28739112");
	}
}
public class CancelWeddingIcon : BitmapData{ 
	public CancelWeddingIcon() {
		width = 75;
		height = 75;
		setPixels("b100ffc1051acbc0b7f0b9352a98ccff");
	}
}
public class IconRingWedding : BitmapData{ 
	public IconRingWedding() {
		width = 41;
		height = 30;
		setPixels("4b53b25db5633e8dfd9d8ebdd5a9c603");
	}
}
public class LogoProposalAnswer : BitmapData{ 
	public LogoProposalAnswer() {
		width = 245;
		height = 84;
		setPixels("1f774a8924e7a9d1b61e4d15af9d6b3f");
	}
}
public class ProposalWhiteShining : BitmapData{ 
	public ProposalWhiteShining() {
		width = 628;
		height = 425;
		setPixels("908f740e6deb8304210c1cce528818c3");
	}
}
public class RingBoxBlue : BitmapData{ 
	public RingBoxBlue() {
		width = 40;
		height = 45;
		setPixels("c600817da1d692422d2c7d68f15f347a");
	}
}
public class RingBright : MovieClip{ 
	public MovieClip blinkLight;
	public RingBright() {
		blinkLight = new symbol_1(){x = -279 , filters = new as3.Array(new object[]{})};
		addChild(blinkLight);//0
		var i12 = new symbol_3(){x = 78.8 , scaleX = 0.3 , y = 22.6 , scaleY = 0.3 , rotation = 180 , alpha = 0 , filters = new as3.Array(new object[]{})};
		addChild(i12);//1
		FrameInfo f;
		var l= new Frames(125);
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -279;
			blinkLight.scaleX = 1;
			blinkLight.y = 0;
			blinkLight.scaleY = 1;
			blinkLight.rotation = 0;
			blinkLight.alpha = 1;
			blinkLight.filters = new as3.Array(new object[]{});
			blinkLight.scale9Grid = null;
			blinkLight.visible = true;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -269.6;
			blinkLight.y = -8.3;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -260.3;
			blinkLight.y = -16.6;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -250.9;
			blinkLight.y = -24.9;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -241.6;
			blinkLight.y = -33.3;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -232.2;
			blinkLight.y = -41.6;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -222.8;
			blinkLight.y = -49.9;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -213.5;
			blinkLight.y = -58.3;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -204.1;
			blinkLight.y = -66.5;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -194.8;
			blinkLight.y = -74.8;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -185.3;
			blinkLight.y = -83.2;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -176;
			blinkLight.y = -91.5;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -166.7;
			blinkLight.y = -99.8;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -157.3;
			blinkLight.y = -108.2;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -147.9;
			blinkLight.y = -116.5;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -138.6;
			blinkLight.y = -124.8;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -129.2;
			blinkLight.y = -133.2;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -119.8;
			blinkLight.y = -141.4;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -110.5;
			blinkLight.y = -149.8;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -101.1;
			blinkLight.y = -158.1;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -91.7;
			blinkLight.y = -166.4;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -82.3;
			blinkLight.y = -174.8;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -73;
			blinkLight.y = -183.1;
		};
		f = l.Add();
		f.Add(blinkLight);
		f += () => {
			blinkLight.x = -63.6;
			blinkLight.y = -191.4;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			blinkLight.x = -54.3;
			blinkLight.y = -199.8;
			i12.x = 78.8;
			i12.scaleX = 0.3;
			i12.y = 22.6;
			i12.scaleY = 0.3;
			i12.rotation = 180;
			i12.alpha = 0;
			i12.filters = new as3.Array(new object[]{});
			i12.scale9Grid = null;
			i12.visible = true;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			blinkLight.x = -44.9;
			blinkLight.y = -208.1;
			i12.x = 77;
			i12.scaleX = 0.38;
			i12.y = 28;
			i12.scaleY = 0.38;
			i12.rotation = -159;
			i12.alpha = 0.1;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			blinkLight.x = -35.5;
			blinkLight.y = -216.4;
			i12.x = 72.5;
			i12.scaleX = 0.46;
			i12.y = 32.7;
			i12.scaleY = 0.46;
			i12.rotation = -139;
			i12.alpha = 0.2;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 65.7;
			i12.scaleX = 0.53;
			i12.y = 35.6;
			i12.scaleY = 0.53;
			i12.rotation = -120;
			i12.alpha = 0.3;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 57.1;
			i12.scaleX = 0.61;
			i12.scaleY = 0.61;
			i12.rotation = -99;
			i12.alpha = 0.4;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 48.4;
			i12.scaleX = 0.69;
			i12.y = 32;
			i12.scaleY = 0.69;
			i12.rotation = -79;
			i12.alpha = 0.6;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 40.8;
			i12.scaleX = 0.77;
			i12.y = 24.6;
			i12.scaleY = 0.77;
			i12.rotation = -60;
			i12.alpha = 0.7;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 36.1;
			i12.scaleX = 0.84;
			i12.y = 14.1;
			i12.scaleY = 0.84;
			i12.rotation = -40;
			i12.alpha = 0.8;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 35.5;
			i12.scaleX = 0.92;
			i12.y = 1.4;
			i12.scaleY = 0.92;
			i12.rotation = -19;
			i12.alpha = 0.9;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 39.9;
			i12.scaleX = 1;
			i12.y = -11.5;
			i12.scaleY = 1;
			i12.rotation = 0;
			i12.alpha = 1;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 45.9;
			i12.scaleX = 0.99;
			i12.y = -16.4;
			i12.scaleY = 0.99;
			i12.rotation = 11;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 52.6;
			i12.scaleX = 0.97;
			i12.y = -19.9;
			i12.scaleY = 0.97;
			i12.rotation = 22;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 59.9;
			i12.scaleX = 0.96;
			i12.y = -22.2;
			i12.scaleY = 0.96;
			i12.rotation = 33;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 67.3;
			i12.scaleX = 0.95;
			i12.y = -22.9;
			i12.scaleY = 0.95;
			i12.rotation = 44;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 74.8;
			i12.scaleX = 0.94;
			i12.y = -22.3;
			i12.scaleY = 0.94;
			i12.rotation = 56;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 81.8;
			i12.scaleX = 0.92;
			i12.y = -20.1;
			i12.scaleY = 0.92;
			i12.rotation = 67;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 88.1;
			i12.scaleX = 0.91;
			i12.y = -16.7;
			i12.scaleY = 0.91;
			i12.rotation = 78;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 93.5;
			i12.scaleX = 0.9;
			i12.y = -12.1;
			i12.scaleY = 0.9;
			i12.rotation = 89;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 97.9;
			i12.scaleX = 0.89;
			i12.y = -6.8;
			i12.scaleY = 0.89;
			i12.rotation = 101;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 101.2;
			i12.scaleX = 0.87;
			i12.y = -0.6;
			i12.scaleY = 0.87;
			i12.rotation = 112;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 103;
			i12.scaleX = 0.86;
			i12.y = 5.9;
			i12.scaleY = 0.86;
			i12.rotation = 123;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 103.7;
			i12.scaleX = 0.85;
			i12.y = 12.6;
			i12.scaleY = 0.85;
			i12.rotation = 134;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 103;
			i12.scaleX = 0.84;
			i12.y = 19.2;
			i12.scaleY = 0.84;
			i12.rotation = 146;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 101;
			i12.scaleX = 0.82;
			i12.y = 25.5;
			i12.scaleY = 0.82;
			i12.rotation = 157;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 97.9;
			i12.scaleX = 0.81;
			i12.y = 31.1;
			i12.scaleY = 0.81;
			i12.rotation = 168;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 93.8;
			i12.scaleX = 0.8;
			i12.y = 36;
			i12.scaleY = 0.8;
			i12.rotation = 180;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 87.5;
			i12.scaleX = 0.76;
			i12.y = 39.4;
			i12.scaleY = 0.76;
			i12.rotation = -167;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 81;
			i12.scaleX = 0.71;
			i12.y = 41.1;
			i12.scaleY = 0.71;
			i12.rotation = -154;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 74.5;
			i12.scaleX = 0.67;
			i12.y = 41.2;
			i12.scaleY = 0.67;
			i12.rotation = -141;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 68.7;
			i12.scaleX = 0.63;
			i12.y = 39.9;
			i12.scaleY = 0.63;
			i12.rotation = -128;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 63.5;
			i12.scaleX = 0.58;
			i12.y = 37.4;
			i12.scaleY = 0.58;
			i12.rotation = -115;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 59.5;
			i12.scaleX = 0.54;
			i12.y = 33.9;
			i12.scaleY = 0.54;
			i12.rotation = -102;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 56.7;
			i12.scaleX = 0.5;
			i12.y = 29.9;
			i12.scaleY = 0.5;
			i12.rotation = -90;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 55.1;
			i12.scaleX = 0.46;
			i12.y = 25.4;
			i12.scaleY = 0.46;
			i12.rotation = -77;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 50.5;
			i12.scaleX = 0.53;
			i12.y = 23.1;
			i12.scaleY = 0.53;
			i12.rotation = -64;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 46.3;
			i12.scaleX = 0.6;
			i12.y = 19.1;
			i12.scaleY = 0.6;
			i12.rotation = -51;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 50;
			i12.scaleX = 0.5;
			i12.y = 13.9;
			i12.scaleY = 0.5;
			i12.rotation = -38;
			i12.alpha = 0.8;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 54.5;
			i12.scaleX = 0.4;
			i12.y = 10.5;
			i12.scaleY = 0.4;
			i12.rotation = -25;
			i12.alpha = 0.5;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 59.3;
			i12.scaleX = 0.3;
			i12.y = 9.2;
			i12.scaleY = 0.3;
			i12.rotation = -12;
			i12.alpha = 0.3;
		};
		f = l.Add();
		f.Add(blinkLight);
		f.Add(i12);
		f += () => {
			i12.x = 63.9;
			i12.scaleX = 0.2;
			i12.y = 9.6;
			i12.scaleY = 0.2;
			i12.rotation = 0;
			i12.alpha = 0;
		};
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		f = l.Add();
		f.Add(blinkLight);
		setFrames(l);
	}
}
namespace weddingResources.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("8d8150777c2fa67dbc7fb10b180f8f7b", 0, 0, 416.3, 368.7, 1, 1);
		}
	}
	public class symbol_1 : MovieClip{ 
		public symbol_1() {
			var i11 = new symbol_0(){filters = new as3.Array(new object[]{})};
			addChild(i11);//0
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("9685cbb3de3cb1ea9c9009c1dfbd4ee0", 0, 0, 63.05, 59.05, 1, 1);
		}
	}
	public class symbol_3 : MovieClip{ 
		public symbol_3() {
			var i13 = new symbol_2(){filters = new as3.Array(new object[]{})};
			addChild(i13);//0
		}
	}
}
