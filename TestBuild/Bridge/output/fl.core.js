Bridge.assembly("TestBuild", function ($asm, globals) {
    "use strict";

    Bridge.define("fl.core.ComponentShim", {
        inherits: [flash.display.MovieClip],
        ctor: function () {
            this.$initialize();
            flash.display.MovieClip.ctor.call(this);
        }
    });
});
