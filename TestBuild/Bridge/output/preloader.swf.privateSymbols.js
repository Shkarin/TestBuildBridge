Bridge.assembly("TestBuild", function ($asm, globals) {
    "use strict";

    Bridge.define("preloader.swf.privateSymbols.symbol_0", {
        inherits: [flash.display.Shape],
        ctor: function () {
            this.$initialize();
            flash.display.Shape.ctor.call(this);
            this.setGraphics("974867b49eeef16405ce0da4a096e544", -130, -11, 260, 22, 1, 1);
        }
    });

    Bridge.define("preloader.swf.privateSymbols.symbol_1", {
        inherits: [flash.display.Shape],
        ctor: function () {
            this.$initialize();
            flash.display.Shape.ctor.call(this);
            this.setGraphics("d807e3186471b77a4f8c3cd35310b8a9", 0, 0, 149, 7, 1, 1);
        }
    });

    Bridge.define("preloader.swf.privateSymbols.symbol_2", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            this.scale9Grid = new flash.geom.Rectangle(3, 2, 141, 1);
            var i11 = Bridge.merge(new preloader.swf.privateSymbols.symbol_1(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i11); //0
        }
    });
});
