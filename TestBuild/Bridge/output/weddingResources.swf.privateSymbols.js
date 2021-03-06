﻿Bridge.assembly("TestBuild", function ($asm, globals) {
    "use strict";

    Bridge.define("weddingResources.swf.privateSymbols.symbol_0", {
        inherits: [flash.display.Shape],
        ctor: function () {
            this.$initialize();
            flash.display.Shape.ctor.call(this);
            this.setGraphics("8d8150777c2fa67dbc7fb10b180f8f7b", 0, 0, 416.3, 368.7, 1, 1);
        }
    });

    Bridge.define("weddingResources.swf.privateSymbols.symbol_1", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            var i11 = Bridge.merge(new weddingResources.swf.privateSymbols.symbol_0(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i11); //0
        }
    });

    Bridge.define("weddingResources.swf.privateSymbols.symbol_2", {
        inherits: [flash.display.Shape],
        ctor: function () {
            this.$initialize();
            flash.display.Shape.ctor.call(this);
            this.setGraphics("9685cbb3de3cb1ea9c9009c1dfbd4ee0", 0, 0, 63.05, 59.05, 1, 1);
        }
    });

    Bridge.define("weddingResources.swf.privateSymbols.symbol_3", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
            var i13 = Bridge.merge(new weddingResources.swf.privateSymbols.symbol_2(), {
                filters: new as3.Array.$ctor1([])
            } );
            this.addChild(i13); //0
        }
    });
});
