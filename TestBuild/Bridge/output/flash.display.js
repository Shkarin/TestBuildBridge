/**
 * @version 1.0.0.0
 * @copyright Copyright ©  2016
 * @compiler Bridge.NET 15.3.0
 */
Bridge.assembly("TestBuild", function ($asm, globals) {
    "use strict";

    Bridge.define("flash.display.Shape", {
        filters: null,
        x: 0,
        y: 0,
        scaleX: 0,
        scaleY: 0,
        alpha: 0,
        rotation: 0,
        mask: null,
        scale9Grid: null,
        visible: false,
        graphicsHash: null,
        ctor: function () {
            this.$initialize();
        },
        setGraphics: function (v1, v2, v3, v4, v5, v6, v7) {
        }
    });

    Bridge.define("flash.display.MovieClip", {
        frames: null,
        filters: null,
        x: 0,
        y: 0,
        scaleX: 0,
        scaleY: 0,
        alpha: 0,
        rotation: 0,
        mask: null,
        scale9Grid: null,
        visible: false,
        blendMode: null,
        _currentFrame: 0,
        _trackAsMenu: false,
        _enabled: false,
        _isPlaying: false,
        getcurrentFrame: function () {
            return this._get_currentFrame();
        },
        getframesLoaded: function () {
            return this._get_framesLoaded();
        },
        gettotalFrames: function () {
            return this._get_totalFrames();
        },
        gettrackAsMenu: function () {
            return this._get_trackAsMenu();
        },
        settrackAsMenu: function (value) {
            this._set_trackAsMenu(value);
        },
        getenabled: function () {
            return this._get_enabled();
        },
        setenabled: function (value) {
            this._set_enabled(value);
        },
        getisPlaying: function () {
            return this._get_isPlaying();
        },
        getdynamics: function () {
            return this;
        },
        setGraphics: function (v1, v2, v3, v4, v5, v6, v7) {
        },
        setFrames: function (frames) {
        },
        addChild: function (value) {
            return null;
        },
        _get_currentFrame: function () {
            return this._currentFrame;
        },
        _get_framesLoaded: function () {
            return this._get_totalFrames();
        },
        _get_totalFrames: function () {
            return this.frames == null ? 0 : 0;
        },
        _get_trackAsMenu: function () {
            return this._trackAsMenu;
        },
        _set_trackAsMenu: function (value) {
            this._trackAsMenu = value;
        },
        play: function () {
            if (this._isPlaying) {
                return;
            }
            this._isPlaying = true;
        },
        onEnterFrame: function () {
        },
        stop: function () {
            if (!this._isPlaying) {
                return;
            }
            this._isPlaying = false;
        },
        nextFrame: function () {
        },
        prevFrame: function () {
        },
        gotoAndPlay$1: function (frame, scene) {
            if (scene === void 0) { scene = null; }
        },
        gotoAndPlay: function (frame, scene) {
            if (scene === void 0) { scene = null; }
        },
        gotoAndPlay$2: function (frame, scene) {
            if (scene === void 0) { scene = null; }
        },
        gotoAndStop$1: function (frame, scene) {
            if (scene === void 0) { scene = null; }
        },
        gotoAndStop: function (frame, scene) {
            if (scene === void 0) { scene = null; }
        },
        gotoAndStop$2: function (frame, scene) {
            if (scene === void 0) { scene = null; }
        },
        addFrameScript: function (frameId, action) {
        },
        dispatchEvent: function (s) {
            return null;
        },
        _get_enabled: function () {
            return this._enabled;
        },
        _set_enabled: function (value) {
            this._enabled = value;
        },
        _get_isPlaying: function () {
            return this._isPlaying;
        }
    });

    Bridge.define("flash.display.BitmapData", {
        width: 0,
        height: 0,
        transparent: false,
        _url: null,
        config: {
            events: {
                Changed: null,
                CanDraw: null
            }
        },
        ctor: function (width, height, transparent, fillColor) {
            if (width === void 0) { width = 0; }
            if (height === void 0) { height = 0; }
            if (transparent === void 0) { transparent = true; }
            if (fillColor === void 0) { fillColor = 4294967295; }

            this.$initialize();
        },
        setPixels: function (value) {
        }
    });

    Bridge.define("flash.display.SimpleButton", {
        _currentState: null,
        _useHandCursor: false,
        _enabled: false,
        _trackAsMenu: false,
        _upState: null,
        _overState: null,
        _downState: null,
        _hitTestState: null,
        ctor: function (upState, overState, downState, hitTestState) {
            if (upState === void 0) { upState = null; }
            if (overState === void 0) { overState = null; }
            if (downState === void 0) { downState = null; }
            if (hitTestState === void 0) { hitTestState = null; }

            this.$initialize();
        },
        getuseHandCursor: function () {
            return this._get_useHandCursor();
        },
        setuseHandCursor: function (value) {
            this._set_useHandCursor(value);
        },
        getenabled: function () {
            return this._get_enabled();
        },
        setenabled: function (value) {
            this._set_enabled(value);
        },
        gettrackAsMenu: function () {
            return this._get_trackAsMenu();
        },
        settrackAsMenu: function (value) {
            this._set_trackAsMenu(value);
        },
        getupState: function () {
            return this._get_upState();
        },
        setupState: function (value) {
            this._set_upState(value);
        },
        getoverState: function () {
            return this._get_overState();
        },
        setoverState: function (value) {
            this._set_overState(value);
        },
        getdownState: function () {
            return this._get_downState();
        },
        setdownState: function (value) {
            this._set_downState(value);
        },
        gethitTestState: function () {
            return this._get_hitTestState();
        },
        sethitTestState: function (value) {
            this._set_hitTestState(value);
        },
        _get_useHandCursor: function () {
            return this._useHandCursor;
        },
        _set_useHandCursor: function (value) {
            this._useHandCursor = value;
        },
        _get_enabled: function () {
            return this._enabled;
        },
        _set_enabled: function (value) {
            this._enabled = value;
        },
        _get_trackAsMenu: function () {
            return this._trackAsMenu;
        },
        _set_trackAsMenu: function (value) {
            this._trackAsMenu = value;
        },
        _get_upState: function () {
            return this._upState;
        },
        _set_upState: function (value) {
            this._upState = value;
        },
        _get_overState: function () {
            return this._overState;
        },
        _set_overState: function (value) {
            this._overState = value;
        },
        _get_downState: function () {
            return this._downState;
        },
        _set_downState: function (value) {
            this._downState = value;
        },
        _get_hitTestState: function () {
            return this._hitTestState;
        },
        _set_hitTestState: function (value) {
            this._hitTestState = value;
        }
    });

    Bridge.define("flash.display.Sprite", {
        filters: null,
        x: 0,
        y: 0,
        scaleX: 0,
        scaleY: 0,
        alpha: 0,
        rotation: 0,
        mask: null,
        scale9Grid: null,
        visible: false,
        blendMode: null,
        _buttonMode: false,
        _hitArea: null,
        _useHanCursor: false,
        ctor: function () {
            this.$initialize();

        },
        getbuttonMode: function () {
            return this._get_buttonMode();
        },
        setbuttonMode: function (value) {
            this._set_buttonMode(value);
        },
        gethitArea: function () {
            return this._get_hitArea();
        },
        sethitArea: function (value) {
            this._set_hitArea(value);
        },
        addChild: function (value) {
            return value;
        },
        _get_buttonMode: function () {
            return this._buttonMode;
        },
        _set_buttonMode: function (value) {
            this._buttonMode = value;
        },
        startTouchDrag: function (touchPointID, lockCenter, bounds) {
            if (lockCenter === void 0) { lockCenter = false; }
            if (bounds === void 0) { bounds = null; }
            throw new System.NotImplementedException();
        },
        stopTouchDrag: function (touchPointID) {
            throw new System.NotImplementedException();
        },
        constructChildren: function () {

        },
        _get_hitArea: function () {
            return this._hitArea;
        },
        _set_hitArea: function (value) {
            this._hitArea = value;
        },
        _get_useHandCursor: function () {
            return this._useHanCursor;
        },
        setGraphics: function (imageGuid, x, y, width, height, bitmapWidth, bitmapHeight) {
        }
    });

    Bridge.define("flash.display.Bitmap", {
        _bitmapData: null,
        filters: null,
        x: 0,
        y: 0,
        scaleX: 0,
        scaleY: 0,
        alpha: 0,
        rotation: 0,
        mask: null,
        scale9Grid: null,
        visible: false,
        blendMode: null,
        config: {
            properties: {
                pixelSnapping: null,
                smoothing: false
            }
        },
        ctor: function (bitmapData, pixelSnapping, smoothing) {
            if (bitmapData === void 0) { bitmapData = null; }
            if (pixelSnapping === void 0) { pixelSnapping = "auto"; }
            if (smoothing === void 0) { smoothing = false; }

            this.$initialize();
            this.aS3_ctor(bitmapData, pixelSnapping, smoothing);
        },
        getbitmapData: function () {
            return this._bitmapData;
        },
        setbitmapData: function (value) {
        },
        aS3_ctor: function (bitmapData, pixelSnapping, smoothing) {
            if (bitmapData === void 0) { bitmapData = null; }
            if (pixelSnapping === void 0) { pixelSnapping = "auto"; }
            if (smoothing === void 0) { smoothing = false; }
            this.ctor$1(bitmapData, pixelSnapping, smoothing);
        },
        ctor$1: function (bitmapData, pixelSnapping, smoothing) {
            this.setbitmapData(bitmapData);
            this.setpixelSnapping(pixelSnapping);
            this.setsmoothing(smoothing);
        }
    });

    Bridge.define("flash.display.MorphShape", {
        inherits: [flash.display.Shape],
        setratio: function (value) {

        },
        setGraphicsStart: function (imageGuid, x, y, width, height, bitmapWidth, bitmapHeight) {

        },
        setGraphicsEnd: function (imageGuid, x, y, width, height, bitmapWidth, bitmapHeight) {

        },
        shiftColor: function (sColor, eColor, ratio) {
            var sRed = sColor >>> 16;
            var sGreen = (((sColor & 65280) >>> 0)) >>> 8;
            var sBlue = (((sColor & 255) >>> 0));

            var eRed = eColor >>> 16;
            var eGreen = (((eColor & 65280) >>> 0)) >>> 8;
            var eBlue = (((eColor & 255) >>> 0));

            sRed = (sRed + Bridge.Int.clipu32((((eRed - sRed) >>> 0)) * ratio)) >>> 0;
            sGreen = (sGreen + Bridge.Int.clipu32((((eGreen - sGreen) >>> 0)) * ratio)) >>> 0;
            sBlue = (sBlue + Bridge.Int.clipu32((((eBlue - sBlue) >>> 0)) * ratio)) >>> 0;

            return (((((((sRed << 16) >>> 0)) + (((sGreen << 8) >>> 0))) >>> 0) + sBlue) >>> 0);
        }
    });
});
