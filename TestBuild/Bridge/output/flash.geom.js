Bridge.assembly("TestBuild", function ($asm, globals) {
    "use strict";

    Bridge.define("flash.geom.Rectangle", {
        x: 0,
        y: 0,
        width: 0,
        height: 0,
        ctor: function (x, y, width, height) {
            if (x === void 0) { x = 0.0; }
            if (y === void 0) { y = 0.0; }
            if (width === void 0) { width = 0.0; }
            if (height === void 0) { height = 0.0; }

            this.$initialize();
            this.aS3_ctor(x, y, width, height);
        },
        getleft: function () {
            return this._get_left();
        },
        setleft: function (value) {
            this._set_left(value);
        },
        getright: function () {
            return this._get_right();
        },
        setright: function (value) {
            this._set_right(value);
        },
        gettop: function () {
            return this._get_top();
        },
        settop: function (value) {
            this._set_top(value);
        },
        getbottom: function () {
            return this._get_bottom();
        },
        setbottom: function (value) {
            this._set_bottom(value);
        },
        aS3_ctor: function (x, y, width, height) {
            if (x === void 0) { x = 0.0; }
            if (y === void 0) { y = 0.0; }
            if (width === void 0) { width = 0.0; }
            if (height === void 0) { height = 0.0; }
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        },
        _get_left: function () {
            return this.x;
        },
        _set_left: function (value) {
            this.width = this.width + (this.x - value);
            this.x = value;
        },
        _get_right: function () {
            return this.x + this.width;
        },
        _set_right: function (value) {
            this.width = value - this.x;
        },
        _get_top: function () {
            return this.y;
        },
        _set_top: function (value) {
            this.height = this.height + (this.y - value);
            this.y = value;
        },
        _get_bottom: function () {
            return this.y + this.height;
        },
        _set_bottom: function (value) {
            this.height = value - this.y;
        },
        clone: function () {
            return new flash.geom.Rectangle(this.x, this.y, this.width, this.height);
        },
        isEmpty: function () {
            return this.width <= 0 || this.height <= 0;
        },
        setEmpty: function () {
            this.x = 0;
            this.y = 0;
            this.width = 0;
            this.height = 0;
        },
        inflate: function (dx, dy) {
            this.x = this.x - dx;
            this.width = this.width + 2 * dx;
            this.y = this.y - dy;
            this.height = this.height + 2 * dy;
        },
        offset: function (dx, dy) {
            this.x = this.x + dx;
            this.y = this.y + dy;
        },
        contains: function (x, y) {
            return x >= this.x && x < this.x + this.width && y >= this.y && y < this.y + this.height;
        },
        containsRect: function (rect) {
            var r1 = rect.x + rect.width;
            var b1 = rect.y + rect.height;
            var r2 = this.x + this.width;
            var b2 = this.y + this.height;
            return rect.x >= this.x && rect.x < r2 && rect.y >= this.y && rect.y < b2 && r1 > this.x && r1 <= r2 && b1 > this.y && b1 <= b2;
        },
        intersection: function (toIntersect) {

            return null;
        },
        intersects: function (toIntersect) {

            return true;
        },
        union: function (toUnion, result) {
            if (result === void 0) { result = null; }

            return null;
        },
        equals: function (toCompare) {
            return toCompare.x === this.x && toCompare.y === this.y && toCompare.width === this.width && toCompare.height === this.height;
        },
        toString$1: function () {
            return "(x=" + System.Double.format(this.x, 'G') + ", y=" + System.Double.format(this.y, 'G') + ", w=" + System.Double.format(this.width, 'G') + ", h=" + System.Double.format(this.height, 'G') + ")";
        },
        copyFrom: function (sourceRect) {
            this.x = sourceRect.x;
            this.y = sourceRect.y;
            this.width = sourceRect.width;
            this.height = sourceRect.height;
        },
        setTo: function (xa, ya, widtha, heighta) {
            this.x = xa;
            this.y = ya;
            this.width = widtha;
            this.height = heighta;
        },
        encapsulate: function (x, y) {
            if (x < this.getleft()) {
                this.setleft(x);
            }
            if (y < this.gettop()) {
                this.settop(y);
            }
            if (x > this.getright()) {
                this.setright(x);
            }
            if (y > this.getbottom()) {
                this.setbottom(y);
            }
        }
    });
});
