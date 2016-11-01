using System;
using flash.display;
using System.Collections.Generic;

public class HeartFallSprite : BitmapData{ 
	public HeartFallSprite() {
		width = 512;
		height = 1024;
		setPixels("b93ac29bd85c8a7d1f165efae25b713b");
	}
}
public class HeartGlowSprite : BitmapData{ 
	public HeartGlowSprite() {
		width = 512;
		height = 512;
		setPixels("e7babe8f1d4be1f472b80860d10e3c3f");
	}
}
public class HeartSimpleSprite : BitmapData{ 
	public HeartSimpleSprite() {
		width = 256;
		height = 256;
		setPixels("78a76eaffb141551c69da808c627e11e");
	}
}
