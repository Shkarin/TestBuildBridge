Bridge.assembly("TestBuild", function ($asm, globals) {
    "use strict";

    Bridge.define("resources_fla.animation_42", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            var i425 = Bridge.merge(new resources.swf.privateSymbols.symbol_120(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i425); //0
            var i426 = Bridge.merge(new resources.swf.privateSymbols.symbol_4(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i426); //1
            var i427 = Bridge.merge(new resources.swf.privateSymbols.symbol_122(), {
                x: -65,
                scaleX: 1,
                y: 2.2,
                scaleY: 1,
                rotation: -25,
                blendMode: "overlay",
                alpha: 0.5,
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i427); //2
            var i429 = Bridge.merge(new resources.swf.privateSymbols.symbol_124(), {
                x: -1.6,
                alpha: 0,
                y: -13.9,
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i429); //3
            var f;
            var l = new as3.Frames(25);
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i425.x = 0;
                i425.scaleX = 1;
                i425.y = 0;
                i425.scaleY = 1;
                i425.rotation = 0;
                i425.alpha = 1;
                i425.filters = new as3.Array.$ctor1([]);
                i425.scale9Grid = null;
                i425.visible = true;
                i426.x = 0;
                i426.scaleX = 1;
                i426.y = 0;
                i426.scaleY = 1;
                i426.rotation = 0;
                i426.alpha = 1;
                i426.filters = new as3.Array.$ctor1([]);
                i426.scale9Grid = null;
                i426.visible = true;
                i427.x = -65;
                i427.scaleX = 1;
                i427.y = 2.2;
                i427.scaleY = 1;
                i427.rotation = -25;
                i427.blendMode = "overlay";
                i427.alpha = 0.5;
                i427.filters = new as3.Array.$ctor1([]);
                i427.scale9Grid = null;
                i427.visible = true;
                i429.x = -1.6;
                i429.scaleX = 1;
                i429.y = -13.9;
                i429.scaleY = 1;
                i429.rotation = 0;
                i429.alpha = 0;
                i429.filters = new as3.Array.$ctor1([]);
                i429.scale9Grid = null;
                i429.visible = true;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -59.6;
                i429.rotation = 4;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -54.4;
                i429.rotation = 8;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -49;
                i429.rotation = 12;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -43.8;
                i429.rotation = 16;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -38.5;
                i427.alpha = 0.6;
                i429.y = -14;
                i429.rotation = 20;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -33.2;
                i429.y = -13.9;
                i429.rotation = 24;
                i429.alpha = 0.2;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -27.9;
                i429.rotation = 29;
                i429.alpha = 0.4;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -22.6;
                i429.rotation = 33;
                i429.alpha = 0.6;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -17.3;
                i429.rotation = 37;
                i429.alpha = 0.8;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -12;
                i429.rotation = 41;
                i429.alpha = 1;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -6.7;
                i429.rotation = 45;
                i429.alpha = 0.9;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = -1.4;
                i429.rotation = 49;
                i429.alpha = 0.8;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 3.9;
                i429.rotation = 54;
                i429.alpha = 0.6;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 9.2;
                i429.y = -14;
                i429.rotation = 58;
                i429.alpha = 0.5;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 14.8;
                i429.rotation = 62;
                i429.alpha = 0.4;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 20.4;
                i427.alpha = 0.7;
                i429.y = -13.9;
                i429.rotation = 66;
                i429.alpha = 0.3;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 25.9;
                i429.y = -14;
                i429.rotation = 70;
                i429.alpha = 0.1;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 31.5;
                i429.y = -13.9;
                i429.rotation = 74;
                i429.alpha = 0;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 37.1;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 42.7;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 48.3;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 53.9;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 59.5;
            });
            f = l.add();
            f.add$1(i425);
            f.add$1(i426);
            f.add$1(i427);
            f.add$1(i429);
            f = as3.FrameInfo.op_Addition(f, function () {
                i427.x = 65;
            });
            this.setFrames(l);
        }
    });

    Bridge.define("resources_fla.salute_67", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            var i304 = Bridge.merge(new resources.swf.privateSymbols.symbol_29(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i304); //0
            var i305 = Bridge.merge(new resources.swf.privateSymbols.symbol_4(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i305); //0
            var i118 = Bridge.merge(new resources.swf.privateSymbols.symbol_0(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i118); //0
            var i119 = Bridge.merge(new resources.swf.privateSymbols.symbol_28(), {
                x: 0.5,
                y: -1.1,
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i119); //1
            var i307 = Bridge.merge(new resources.swf.privateSymbols.symbol_30(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i307); //1
            var i306 = Bridge.merge(new resources.swf.privateSymbols.symbol_0(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i306); //1
            var f;
            var l = new as3.Frames(40);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = as3.FrameInfo.op_Addition(f, function () {
                i118.x = 0;
                i118.scaleX = 1;
                i118.y = 0;
                i118.scaleY = 1;
                i118.rotation = 0;
                i118.alpha = 1;
                i118.filters = new as3.Array.$ctor1([]);
                i118.scale9Grid = null;
                i118.visible = true;
                i119.x = 0.5;
                i119.scaleX = 1;
                i119.y = -1.1;
                i119.scaleY = 1;
                i119.rotation = 0;
                i119.alpha = 1;
                i119.filters = new as3.Array.$ctor1([]);
                i119.scale9Grid = null;
                i119.visible = true;
            });
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i118);
            f.add$1(i119);
            f = l.add();
            f.add$1(i304);
            f.add$1(i119);
            f = as3.FrameInfo.op_Addition(f, function () {
                i304.x = 0;
                i304.scaleX = 1;
                i304.y = 0;
                i304.scaleY = 1;
                i304.rotation = 0;
                i304.alpha = 1;
                i304.filters = new as3.Array.$ctor1([]);
                i304.scale9Grid = null;
                i304.visible = true;
            });
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i119);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = as3.FrameInfo.op_Addition(f, function () {
                i305.x = 0;
                i305.scaleX = 1;
                i305.y = 0;
                i305.scaleY = 1;
                i305.rotation = 0;
                i305.alpha = 1;
                i305.filters = new as3.Array.$ctor1([]);
                i305.scale9Grid = null;
                i305.visible = true;
                i306.x = 0;
                i306.scaleX = 1;
                i306.y = 0;
                i306.scaleY = 1;
                i306.rotation = 0;
                i306.alpha = 1;
                i306.filters = new as3.Array.$ctor1([]);
                i306.scale9Grid = null;
                i306.visible = true;
            });
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i306);
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            f.add$1(i307);
            f = as3.FrameInfo.op_Addition(f, function () {
                i307.x = 0;
                i307.scaleX = 1;
                i307.y = 0;
                i307.scaleY = 1;
                i307.rotation = 0;
                i307.alpha = 1;
                i307.filters = new as3.Array.$ctor1([]);
                i307.scale9Grid = null;
                i307.visible = true;
            });
            f = l.add();
            f.add$1(i305);
            f.add$1(i119);
            this.setFrames(l);
        }
    });

    Bridge.define("resources_fla.staranim3_69", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            var i121 = Bridge.merge(new resources.swf.privateSymbols.symbol_0(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i121); //0
            var i236 = Bridge.merge(new resources.swf.privateSymbols.symbol_4(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i236); //0
            var i237 = Bridge.merge(new resources.swf.privateSymbols.symbol_5(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i237); //1
            var i122 = Bridge.merge(new resources.swf.privateSymbols.symbol_1(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i122); //1
            var i235 = Bridge.merge(new resources.swf.privateSymbols.symbol_0(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i235); //1
            var i123 = Bridge.merge(new resources.swf.privateSymbols.symbol_3(), {
                x: 16.5,
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i123); //2
            var f;
            var l = new as3.Frames(26);
            f = l.add();
            f.add$1(i121);
            f.add$1(i122);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i121.x = 0;
                i121.scaleX = 1;
                i121.y = 0;
                i121.scaleY = 1;
                i121.rotation = 0;
                i121.alpha = 1;
                i121.filters = new as3.Array.$ctor1([]);
                i121.scale9Grid = null;
                i121.visible = true;
                i122.x = 0;
                i122.scaleX = 1;
                i122.y = 0;
                i122.scaleY = 1;
                i122.rotation = 0;
                i122.alpha = 1;
                i122.filters = new as3.Array.$ctor1([]);
                i122.scale9Grid = null;
                i122.visible = true;
                i123.x = 16.5;
                i123.scaleX = 1;
                i123.y = 0;
                i123.scaleY = 1;
                i123.rotation = 0;
                i123.alpha = 1;
                i123.filters = new as3.Array.$ctor1([]);
                i123.scale9Grid = null;
                i123.visible = true;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i122);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 30.7;
                i123.scaleX = 0.95;
                i123.scaleY = 0.95;
                i123.rotation = 40;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i122);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 44.1;
                i123.scaleX = 0.9;
                i123.scaleY = 0.9;
                i123.rotation = 77;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i122);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 56.8;
                i123.scaleX = 0.85;
                i123.scaleY = 0.85;
                i123.rotation = 113;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i122);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 68.7;
                i123.scaleX = 0.81;
                i123.y = -0.1;
                i123.scaleY = 0.81;
                i123.rotation = 146;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i122);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 79.8;
                i123.scaleX = 0.77;
                i123.scaleY = 0.77;
                i123.rotation = 178;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i122);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 90.2;
                i123.scaleX = 0.74;
                i123.scaleY = 0.74;
                i123.rotation = -152;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i235);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i235.x = 0;
                i235.scaleX = 1;
                i235.y = 0;
                i235.scaleY = 1;
                i235.rotation = 0;
                i235.alpha = 1;
                i235.filters = new as3.Array.$ctor1([]);
                i235.scale9Grid = null;
                i235.visible = true;
                i123.x = 99.8;
                i123.scaleX = 0.7;
                i123.scaleY = 0.7;
                i123.rotation = -125;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i235);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 108.5;
                i123.scaleX = 0.67;
                i123.y = 0;
                i123.scaleY = 0.67;
                i123.rotation = -101;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i235);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 116.5;
                i123.scaleX = 0.64;
                i123.scaleY = 0.64;
                i123.rotation = -78;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i235);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 123.7;
                i123.scaleX = 0.62;
                i123.scaleY = 0.62;
                i123.rotation = -58;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i235);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 130.1;
                i123.scaleX = 0.59;
                i123.scaleY = 0.59;
                i123.rotation = -40;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i235);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 135.6;
                i123.scaleX = 0.57;
                i123.scaleY = 0.57;
                i123.rotation = -24;
            });
            f = l.add();
            f.add$1(i121);
            f.add$1(i235);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 140.4;
                i123.scaleX = 0.56;
                i123.scaleY = 0.56;
                i123.rotation = -11;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i236.x = 0;
                i236.scaleX = 1;
                i236.y = 0;
                i236.scaleY = 1;
                i236.rotation = 0;
                i236.alpha = 1;
                i236.filters = new as3.Array.$ctor1([]);
                i236.scale9Grid = null;
                i236.visible = true;
                i237.x = 0;
                i237.scaleX = 1;
                i237.y = 0;
                i237.scaleY = 1;
                i237.rotation = 0;
                i237.alpha = 1;
                i237.filters = new as3.Array.$ctor1([]);
                i237.scale9Grid = null;
                i237.visible = true;
                i123.x = 144.5;
                i123.scaleX = 0.54;
                i123.scaleY = 0.54;
                i123.rotation = 0;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 147.8;
                i123.alpha = 0.9;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 151.1;
                i123.alpha = 0.8;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 154.3;
                i123.alpha = 0.7;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 157.6;
                i123.alpha = 0.6;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 160.8;
                i123.alpha = 0.5;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 164.2;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 167.4;
                i123.alpha = 0.4;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 170.7;
                i123.alpha = 0.3;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 173.9;
                i123.alpha = 0.2;
            });
            f = l.add();
            f.add$1(i236);
            f.add$1(i237);
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 177.3;
                i123.alpha = 0;
            });
            f = l.add();
            f.add$1(i123);
            f = as3.FrameInfo.op_Addition(f, function () {
                i123.x = 180.5;
            });
            this.setFrames(l);
        }
    });

    Bridge.define("resources_fla.tie_104", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            var i701 = Bridge.merge(new resources.swf.privateSymbols.symbol_193(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i701); //0
            var i702 = Bridge.merge(new resources.swf.privateSymbols.symbol_195(), {
                x: 1.1,
                y: 10.3,
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i702); //1
            var f;
            var l = new as3.Frames(164);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i701.x = 0;
                i701.scaleX = 1;
                i701.y = 0;
                i701.scaleY = 1;
                i701.rotation = 0;
                i701.alpha = 1;
                i701.filters = new as3.Array.$ctor1([]);
                i701.scale9Grid = null;
                i701.visible = true;
                i702.x = 1.1;
                i702.scaleX = 1;
                i702.y = 10.3;
                i702.scaleY = 1;
                i702.rotation = 0;
                i702.alpha = 1;
                i702.filters = new as3.Array.$ctor1([]);
                i702.scale9Grid = null;
                i702.visible = true;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.2;
                i702.rotation = 1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = 2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.2;
                i702.y = 10.1;
                i702.rotation = 3;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.3;
                i702.y = 10;
                i702.rotation = 4;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 9.9;
                i702.rotation = 5;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.4;
                i702.rotation = 6;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 9.8;
                i702.rotation = 7;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.5;
                i702.rotation = 8;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.6;
                i702.y = 9.7;
                i702.rotation = 9;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 9.8;
                i702.rotation = 8;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.5;
                i702.rotation = 7;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = 6;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.4;
                i702.rotation = 5;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 9.9;
                i702.rotation = 4;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.3;
                i702.y = 10;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = 3;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.1;
                i702.rotation = 2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.2;
                i702.rotation = 1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.3;
                i702.rotation = 0;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 0.9;
                i702.y = 10.4;
                i702.rotation = -1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = -2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 0.8;
                i702.y = 10.5;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = -3;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.6;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.7;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 0.7;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 0.8;
                i702.y = 10.6;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.5;
                i702.rotation = -2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.6;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 0.9;
                i702.y = 10.5;
                i702.rotation = -1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.4;
                i702.rotation = 0;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.1;
                i702.y = 10.3;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.2;
                i702.rotation = 1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = 2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.1;
                i702.rotation = 3;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.4;
                i702.y = 9.9;
                i702.rotation = 4;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.3;
                i702.y = 10.1;
                i702.rotation = 3;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = 2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.1;
                i702.y = 10.2;
                i702.rotation = 1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = 0;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.3;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.3;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1;
                i702.y = 10.2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 0.9;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.rotation = -1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 0.8;
                i702.rotation = -2;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.5;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.6;
                i702.rotation = -1;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 0.9;
                i702.y = 10.7;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.y = 10.6;
                i702.rotation = 0;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1;
                i702.y = 10.7;
            });
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = l.add();
            f.add$1(i701);
            f.add$1(i702);
            f = as3.FrameInfo.op_Addition(f, function () {
                i702.x = 1.1;
                i702.y = 10.3;
            });
            this.setFrames(l);
        }
    });

    Bridge.define("resources_fla.Timeline_80", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            var i520 = Bridge.merge(new resources.swf.privateSymbols.symbol_166(), {
                x: 0.3,
                y: 7.6,
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i520); //0
            var i522 = Bridge.merge(new resources.swf.privateSymbols.symbol_168(), {
                x: 0.1,
                y: -3.9,
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i522); //1
            var f;
            var l = new as3.Frames(75);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.3;
                i520.scaleX = 1;
                i520.y = 7.6;
                i520.scaleY = 1;
                i520.rotation = 0;
                i520.alpha = 1;
                i520.filters = new as3.Array.$ctor1([]);
                i520.scale9Grid = null;
                i520.visible = true;
                i522.x = 0.1;
                i522.scaleX = 1;
                i522.y = -3.9;
                i522.scaleY = 1;
                i522.rotation = 0;
                i522.alpha = 1;
                i522.filters = new as3.Array.$ctor1([]);
                i522.scale9Grid = null;
                i522.visible = true;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.05;
                i520.y = 8.3;
                i520.scaleY = 0.96;
                i522.scaleX = 1.05;
                i522.y = -2.8;
                i522.scaleY = 0.96;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.09;
                i520.y = 8.7;
                i520.scaleY = 0.93;
                i522.scaleX = 1.09;
                i522.y = -1.9;
                i522.scaleY = 0.93;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.11;
                i520.y = 8.9;
                i520.scaleY = 0.91;
                i522.scaleX = 1.11;
                i522.y = -1.4;
                i522.scaleY = 0.91;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.12;
                i520.y = 9.1;
                i520.scaleY = 0.9;
                i522.scaleX = 1.12;
                i522.y = -1.3;
                i522.scaleY = 0.9;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.5;
                i520.scaleX = 1.06;
                i520.y = 8.2;
                i520.scaleY = 0.96;
                i522.x = 0.3;
                i522.scaleX = 1.06;
                i522.y = -4.2;
                i522.scaleY = 0.93;
                i522.rotation = -2;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.3;
                i520.scaleX = 1.01;
                i520.y = 7.5;
                i520.scaleY = 1.01;
                i522.scaleX = 1.01;
                i522.y = -6.3;
                i522.scaleY = 0.95;
                i522.rotation = -5;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.97;
                i520.y = 7;
                i520.scaleY = 1.04;
                i522.x = 0.4;
                i522.scaleX = 0.98;
                i522.y = -7.9;
                i522.scaleY = 0.97;
                i522.rotation = -6;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.95;
                i520.y = 6.7;
                i520.scaleY = 1.06;
                i522.x = 0.5;
                i522.scaleX = 0.96;
                i522.y = -8.8;
                i522.scaleY = 0.98;
                i522.rotation = -7;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.94;
                i520.y = 6.5;
                i520.scaleY = 1.07;
                i522.y = -9.2;
                i522.rotation = -8;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.98;
                i520.y = 7.1;
                i520.scaleY = 1.04;
                i522.x = 0.3;
                i522.scaleX = 0.99;
                i522.y = -7.6;
                i522.scaleY = 0.97;
                i522.rotation = -6;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.01;
                i520.y = 7.6;
                i520.scaleY = 1;
                i522.scaleX = 1.02;
                i522.y = -6;
                i522.scaleY = 0.95;
                i522.rotation = -4;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.5;
                i520.scaleX = 1.05;
                i520.y = 8.1;
                i520.scaleY = 0.97;
                i522.scaleX = 1.05;
                i522.y = -4.4;
                i522.scaleY = 0.93;
                i522.rotation = -3;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.08;
                i520.y = 8.6;
                i520.scaleY = 0.93;
                i522.x = 0.1;
                i522.scaleX = 1.09;
                i522.y = -2.8;
                i522.scaleY = 0.92;
                i522.rotation = -1;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.12;
                i520.y = 9.1;
                i520.scaleY = 0.9;
                i522.scaleX = 1.12;
                i522.y = -1.3;
                i522.scaleY = 0.9;
                i522.rotation = 0;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.08;
                i520.y = 8.6;
                i520.scaleY = 0.94;
                i522.scaleX = 1.08;
                i522.y = -2.3;
                i522.scaleY = 0.94;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.3;
                i520.scaleX = 1.04;
                i520.y = 8.1;
                i520.scaleY = 0.96;
                i522.scaleX = 1.04;
                i522.y = -3;
                i522.scaleY = 0.96;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.02;
                i520.y = 7.8;
                i520.scaleY = 0.98;
                i522.scaleX = 1.02;
                i522.y = -3.5;
                i522.scaleY = 0.98;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1;
                i520.y = 7.7;
                i520.scaleY = 1;
                i522.scaleX = 1;
                i522.y = -3.8;
                i522.scaleY = 1;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.y = 7.6;
                i522.y = -3.9;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.04;
                i520.y = 8.1;
                i520.scaleY = 0.97;
                i522.scaleX = 1.04;
                i522.y = -3;
                i522.scaleY = 0.97;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.06;
                i520.y = 8.4;
                i520.scaleY = 0.94;
                i522.scaleX = 1.06;
                i522.y = -2.5;
                i522.scaleY = 0.94;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.08;
                i520.y = 8.7;
                i520.scaleY = 0.93;
                i522.scaleX = 1.08;
                i522.y = -2;
                i522.scaleY = 0.93;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleY = 0.92;
                i522.y = -1.9;
                i522.scaleY = 0.92;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.5;
                i520.scaleX = 1.05;
                i520.y = 3.5;
                i520.scaleY = 0.96;
                i522.scaleX = 1.05;
                i522.y = -7.5;
                i522.scaleY = 0.96;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.02;
                i520.y = -0.1;
                i520.scaleY = 0.98;
                i522.scaleX = 1.02;
                i522.y = -11.4;
                i522.scaleY = 0.98;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.3;
                i520.scaleX = 1.01;
                i520.y = -2.4;
                i520.scaleY = 1;
                i522.scaleX = 1.01;
                i522.y = -13.8;
                i522.scaleY = 1;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1;
                i520.y = -3.1;
                i522.scaleX = 1;
                i522.y = -14.6;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.y = -2.5;
                i522.y = -14.3;
                i522.rotation = -1;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.98;
                i520.y = -0.6;
                i520.scaleY = 1.01;
                i522.x = 0.3;
                i522.scaleX = 0.99;
                i522.y = -13.6;
                i522.scaleY = 0.99;
                i522.rotation = -4;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 0.96;
                i520.y = 2.6;
                i520.scaleY = 1.02;
                i522.x = 0.5;
                i522.scaleX = 0.98;
                i522.y = -12.3;
                i522.scaleY = 0.97;
                i522.rotation = -10;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.92;
                i520.y = 7.1;
                i520.scaleY = 1.03;
                i522.x = 0.7;
                i522.scaleX = 0.97;
                i522.y = -10.5;
                i522.scaleY = 0.94;
                i522.rotation = -17;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.99;
                i520.y = 7.8;
                i520.scaleY = 0.99;
                i522.x = 0.5;
                i522.scaleX = 1.02;
                i522.y = -6.8;
                i522.scaleY = 0.93;
                i522.rotation = -10;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.04;
                i520.y = 8.3;
                i520.scaleY = 0.95;
                i522.x = 0.3;
                i522.scaleX = 1.06;
                i522.y = -4.1;
                i522.rotation = -4;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.3;
                i520.scaleX = 1.07;
                i520.y = 8.6;
                i520.scaleY = 0.93;
                i522.x = 0.1;
                i522.scaleX = 1.08;
                i522.y = -2.5;
                i522.rotation = -1;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.08;
                i520.y = 8.7;
                i520.scaleY = 0.92;
                i522.y = -1.9;
                i522.scaleY = 0.92;
                i522.rotation = 0;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleY = 0.93;
                i522.y = -2;
                i522.scaleY = 0.93;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.5;
                i520.scaleX = 1.06;
                i520.y = 8.5;
                i520.scaleY = 0.94;
                i522.scaleX = 1.06;
                i522.y = -2.5;
                i522.scaleY = 0.94;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.04;
                i520.y = 8.1;
                i520.scaleY = 0.97;
                i522.scaleX = 1.04;
                i522.y = -3;
                i522.scaleY = 0.97;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.3;
                i520.scaleX = 1;
                i520.y = 7.6;
                i520.scaleY = 1;
                i522.scaleX = 1;
                i522.y = -3.9;
                i522.scaleY = 1;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.y = 2.9;
                i522.y = -8.6;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.y = -0.4;
                i522.y = -11.9;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.y = -2.5;
                i522.y = -13.9;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.y = -3.1;
                i522.y = -14.6;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.y = -2.5;
                i522.y = -14.3;
                i522.rotation = -1;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.98;
                i520.y = -0.6;
                i520.scaleY = 1.01;
                i522.x = 0.3;
                i522.scaleX = 0.99;
                i522.y = -13.6;
                i522.scaleY = 0.99;
                i522.rotation = -4;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 0.96;
                i520.y = 2.6;
                i520.scaleY = 1.02;
                i522.x = 0.5;
                i522.scaleX = 0.98;
                i522.y = -12.3;
                i522.scaleY = 0.97;
                i522.rotation = -10;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.92;
                i520.y = 7.1;
                i520.scaleY = 1.03;
                i522.x = 0.7;
                i522.scaleX = 0.97;
                i522.y = -10.5;
                i522.scaleY = 0.94;
                i522.rotation = -17;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 0.99;
                i520.y = 7.8;
                i520.scaleY = 0.99;
                i522.x = 0.5;
                i522.scaleX = 1.02;
                i522.y = -6.8;
                i522.scaleY = 0.93;
                i522.rotation = -10;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleX = 1.04;
                i520.y = 8.3;
                i520.scaleY = 0.95;
                i522.x = 0.3;
                i522.scaleX = 1.06;
                i522.y = -4.1;
                i522.rotation = -4;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.3;
                i520.scaleX = 1.07;
                i520.y = 8.6;
                i520.scaleY = 0.93;
                i522.x = 0.1;
                i522.scaleX = 1.08;
                i522.y = -2.5;
                i522.rotation = -1;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.08;
                i520.y = 8.7;
                i520.scaleY = 0.92;
                i522.y = -1.9;
                i522.scaleY = 0.92;
                i522.rotation = 0;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.scaleY = 0.93;
                i522.y = -2;
                i522.scaleY = 0.93;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.5;
                i520.scaleX = 1.06;
                i520.y = 8.5;
                i520.scaleY = 0.94;
                i522.scaleX = 1.06;
                i522.y = -2.5;
                i522.scaleY = 0.94;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.4;
                i520.scaleX = 1.04;
                i520.y = 8.1;
                i520.scaleY = 0.97;
                i522.scaleX = 1.04;
                i522.y = -3;
                i522.scaleY = 0.97;
            });
            f = l.add();
            f.add$1(i520);
            f.add$1(i522);
            f = as3.FrameInfo.op_Addition(f, function () {
                i520.x = 0.3;
                i520.scaleX = 1;
                i520.y = 7.6;
                i520.scaleY = 1;
                i522.scaleX = 1;
                i522.y = -3.9;
                i522.scaleY = 1;
            });
            this.setFrames(l);
        }
    });

    Bridge.define("resources_fla.vip_97", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            var i710 = Bridge.merge(new resources.swf.privateSymbols.symbol_196(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i710); //0
            var i711 = Bridge.merge(new resources.swf.privateSymbols.symbol_4(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i711); //1
            var i712 = Bridge.merge(new resources.swf.privateSymbols.symbol_197(), {
                x: -1.4,
                y: -6.6,
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i712); //2
            var f;
            var l = new as3.Frames(38);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i710.x = 0;
                i710.scaleX = 1;
                i710.y = 0;
                i710.scaleY = 1;
                i710.rotation = 0;
                i710.alpha = 1;
                i710.filters = new as3.Array.$ctor1([]);
                i710.scale9Grid = null;
                i710.visible = true;
                i711.x = 0;
                i711.scaleX = 1;
                i711.y = 0;
                i711.scaleY = 1;
                i711.rotation = 0;
                i711.alpha = 1;
                i711.filters = new as3.Array.$ctor1([]);
                i711.scale9Grid = null;
                i711.visible = true;
                i712.x = -1.4;
                i712.scaleX = 1;
                i712.y = -6.6;
                i712.scaleY = 1;
                i712.rotation = 0;
                i712.alpha = 1;
                i712.filters = new as3.Array.$ctor1([]);
                i712.scale9Grid = null;
                i712.visible = true;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 2.3;
                i712.y = -3.7;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 5.8;
                i712.y = -0.8;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 9.5;
                i712.y = 2.1;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 13.1;
                i712.y = 5.1;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 16.7;
                i712.y = 8;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 20.3;
                i712.y = 10.9;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 23.9;
                i712.y = 13.8;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 27.6;
                i712.y = 16.8;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 31.1;
                i712.y = 19.7;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 34.8;
                i712.y = 22.6;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 38.4;
                i712.y = 25.6;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 42;
                i712.y = 28.4;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 45.6;
                i712.y = 31.4;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = as3.FrameInfo.op_Addition(f, function () {
                i712.x = 49.2;
                i712.y = 34.3;
            });
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            f = l.add();
            f.add$1(i710);
            f.add$1(i711);
            f.add$1(i712);
            this.setFrames(l);
        }
    });
});
