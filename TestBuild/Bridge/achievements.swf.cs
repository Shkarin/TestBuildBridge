using System;

using flash.display;
using System.Collections.Generic;
using achievements.swf.privateSymbols;
using as3;
using RockiePlayer;
using flash.filters;

public class Libachievements : ResourcesExternalLib{
	public Libachievements() {
	vectors = new string[] {
	"f1f5ff2775ab70f558b48610ea0cdc97",
	"7a6091d4955eb7c86e8753095624b296",
	"b3ac91063dbe512ebfa62d49b2ed56fb",
	"ef42bdfacdb5a7f176dffeb6c8ac673e",
	"c8614091893bf7e924ad1d96b958b5bc"
	};
	graphics = new string[] {
	"00a2e394e1f540f6e6d61cf1ba3aa887",
	"700cf01fed19f4524fa7325f1f1aa30b",
	"9d70e6ef85712629eef8b00fed6b3c14",
	"25615f8af601460f624218fda63e88f3",
	"02849beacadb65ba42c9505bd00d3276",
	"00a2e394e1f540f6e6d61cf1ba3aa887",
	"44c368d6df1f172ceb0a531a5d6ba48d"
	};
	}
}
public class AchievementShadow : BitmapData{ 
	public AchievementShadow() {
		width = 78;
		height = 16;
		setPixels("cde4efa66005b712664252ce07ba8c1b");
	}
}
public class BackgroundAchievements : BitmapData{ 
	public BackgroundAchievements() {
		width = 760;
		height = 1380;
		setPixels("00a2e394e1f540f6e6d61cf1ba3aa887");
	}
}
public class BackgroundCaption : MovieClip{ 
	public BackgroundCaption() {
		this.scale9Grid = new flash.geom.Rectangle(54, 9, 112, 22);
		var i9 = new symbol_0();
		addChild(i9);//0
	}
}
public class LightOnCaption : BitmapData{ 
	public LightOnCaption() {
		width = 193;
		height = 41;
		setPixels("25615f8af601460f624218fda63e88f3");
	}
}
public class LockedAchievement : BitmapData{ 
	public LockedAchievement() {
		width = 78;
		height = 78;
		setPixels("9d70e6ef85712629eef8b00fed6b3c14");
	}
}
public class NextAchievementLevelButton : SimpleButton{ 
	public NextAchievementLevelButton() {
		downState = new symbol_1();
		overState = new symbol_2();
		upState = new symbol_1();
		hitTestState = new symbol_1();
	}
}
public class PrevAchievementLevelButton : SimpleButton{ 
	public PrevAchievementLevelButton() {
		downState = new symbol_3();
		overState = new symbol_4();
		upState = new symbol_3();
		hitTestState = new symbol_3();
	}
}
public class ShelfAchievements : BitmapData{ 
	public ShelfAchievements() {
		width = 760;
		height = 43;
		setPixels("44c368d6df1f172ceb0a531a5d6ba48d");
	}
}
namespace achievements.swf.privateSymbols{
	public class symbol_0 : Shape{ 
		public symbol_0() {
			setGraphics("ef42bdfacdb5a7f176dffeb6c8ac673e", -2, -2, 226.35, 46.5, 1, 1);
		}
	}
	public class symbol_1 : Shape{ 
		public symbol_1() {
			setGraphics("c8614091893bf7e924ad1d96b958b5bc", 0, 0, 23, 41, 1, 1);
		}
	}
	public class symbol_2 : Shape{ 
		public symbol_2() {
			setGraphics("f1f5ff2775ab70f558b48610ea0cdc97", -2, -1, 27, 44, 1, 1);
		}
	}
	public class symbol_3 : Shape{ 
		public symbol_3() {
			setGraphics("b3ac91063dbe512ebfa62d49b2ed56fb", 0, 0, 23, 41, 1, 1);
		}
	}
	public class symbol_4 : Shape{ 
		public symbol_4() {
			setGraphics("7a6091d4955eb7c86e8753095624b296", -2, -1, 27, 44, 1, 1);
		}
	}
}
