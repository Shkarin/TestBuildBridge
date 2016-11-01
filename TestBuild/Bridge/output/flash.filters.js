Bridge.assembly("TestBuild", function ($asm, globals) {
    "use strict";

    Bridge.define("flash.filters.BlurFilter", {
        config: {
            properties: {
                blurX: 0,
                blurY: 0,
                quality: 0
            }
        },
        ctor: function (blurX, blurY, quality) {
            if (blurX === void 0) { blurX = 4.0; }
            if (blurY === void 0) { blurY = 4.0; }
            if (quality === void 0) { quality = 1; }

            this.$initialize();

        }
    });

    Bridge.define("flash.filters.ColorMatrixFilter", {
        _matrix: null,
        config: {
            init: function () {
                this._matrix = new as3.Array.ctor();
            }
        },
        ctor: function (matrix) {
            if (matrix === void 0) { matrix = null; }

            this.$initialize();

        },
        getmatrix: function () {
            return this._get_matrix();
        },
        setmatrix: function (value) {
            this._set_matrix(value);
        },
        _get_matrix: function () {
            return this._matrix;
        },
        _set_matrix: function (value) {
            this._matrix = this.getmatrix();
        }
    });

    Bridge.define("flash.filters.GlowFilter", {
        colorString: null,
        config: {
            properties: {
                color: 0,
                alpha: 0,
                blurX: 0,
                blurY: 0,
                inner: false,
                knockout: false,
                quality: 0,
                strength: 0
            }
        },
        ctor: function (color, alpha, blurX, blurY, strength, quality, inner, knockout) {
            if (color === void 0) { color = 16711680; }
            if (alpha === void 0) { alpha = 1.0; }
            if (blurX === void 0) { blurX = 6.0; }
            if (blurY === void 0) { blurY = 6.0; }
            if (strength === void 0) { strength = 2.0; }
            if (quality === void 0) { quality = 1; }
            if (inner === void 0) { inner = false; }
            if (knockout === void 0) { knockout = false; }

            this.$initialize();

        }
    });
});
