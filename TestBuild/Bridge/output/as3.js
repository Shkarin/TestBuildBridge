Bridge.assembly("TestBuild", function ($asm, globals) {
    "use strict";

    Bridge.define("as3.Array", {
        statics: {
            DESCENDING: 2,
            UNIQUESORT: 4,
            RETURNINDEXEDARRAY: 8,
            NUMERIC: 16,
            makeArray: function (objects) {
                return null;
            },
            op_Implicit: function (objects) {
                return as3.Array.makeArray(objects);
            }
        },
        ctor: function () {
            this.$initialize();

        },
        $ctor1: function (length) {
            this.$initialize();

        },
        add: function (obj) {

        },
        push: function (obj) {
            if (obj === void 0) { obj = []; }
            return 0;
        },
        pop: function () {
            return null;
        },
        sort: function (type) {
            if (type === void 0) { type = 0; }

        },
        indexOf: function (item) {
            return 0;
        },
        unshift: function (obj) {
            if (obj === void 0) { obj = []; }
            return 0;
        },
        shift: function () {
            return 0;
        }
    });

    Bridge.define("as3.FrameInfo", {
        statics: {
            op_Addition: function (left, right) {
                left.add(right);
                return left;
            },
            op_Addition$1: function (left, right) {
                left.add$1(right);
                return left;
            }
        },
        id: 0,
        label: null,
        actions: null,
        config: {
            init: function () {
                this.actions = new (System.Collections.Generic.List$1(Function))();
            }
        },
        ctor: function (label) {
            if (label === void 0) { label = null; }

            this.$initialize();
            this.label = label;
        },
        add: function (action) {
            this.actions.add(action);
        },
        add$1: function (obj) {
        }
    });

    Bridge.define("as3.Frames", {
        frames: null,
        ctor: function (count) {
            if (count === void 0) { count = 0; }

            this.$initialize();
            this.frames = new (System.Collections.Generic.List$1(as3.FrameInfo))(count);
        },
        getcount: function () {
            return this.frames.getCount();
        },
        getItem: function (i) {
            return this.getItem$2(Bridge.cast(i, String));
        },
        getItem$1: function (i) {
            return this.frames.getItem(i);
        },
        getItem$2: function (name) {
            for (var i = 0; i < this.frames.getCount(); i = (i + 1) | 0) {
                var frameInfo = this.frames.getItem(i);
                if (Bridge.referenceEquals(frameInfo.label, name) && frameInfo.label != null) {
                    return frameInfo;
                }
            }
            return null;
        },
        add: function (label) {
            if (label === void 0) { label = null; }
            var frame = new as3.FrameInfo(label);
            frame.id = this.frames.getCount();
            this.frames.add(frame);
            return frame;
        }
    });
});
