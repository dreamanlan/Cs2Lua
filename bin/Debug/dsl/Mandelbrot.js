require("cs2dsl__utility.js");
require("cs2dsl__namespaces.js");
require("cs2dsl__externenums.js");

function Mandelbrot(){
	this.Exec = function(){
		var width;
		width = 50;
		var height;
		height = width;
		var maxiter;
		maxiter = 50;
		var limit;
		limit = 4.00;
		var y;
		y = 0;
		while(y < height){
			var Ci;
			Ci = 2.00 * y / height - 1.00;
			var x;
			x = 0;
			while(x < width){
				var Zr;
				Zr = 0.00;
				var Zi;
				Zi = 0.00;
				var Cr;
				Cr = 2.00 * x / width - 1.50;
				var i;
				i = maxiter;
				var isInside;
				isInside = true;
				do{
					var Tr;
					Tr = Zr * Zr - Zi * Zi + Cr;
					Zi = 2.00 * Zr * Zi + Ci;
					Zr = Tr;
					if(Zr * Zr + Zi * Zi > limit){
						isInside = false;
						break;
					};
				}while((function(){
					i = i - 1;
					return i;
				})() > 0) ;
				if(isInside){
					this.Output(x * 1.00 / width, y * 1.00 / height);
				};
				x = x + 1;
			};
			y = y + 1;
		};
	}
	this.Output = function(x, y){
		JsConsole.Print(x, y);
	}
	this.ctor = function(){
	}
	this.r = 10;
	this.scale = 3.00;
	this.datas = [1, 2, 3, 4, 5, 6];
	this.dicts = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "System.Collections.Generic.Dictionary_TKey_TValue", "ctor", {1 : 1, 2 : 2, 3 : 3, 4 : 4, 5 : 5});
	this.dicts2 = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "System.Collections.Generic.Dictionary_TKey_TValue", "ctor", {}, 128);
}

(function(){
	Mandelbrot.__new_object = function(){
		return newobject(Mandelbrot, null, null, getParams(0));
	}
	Mandelbrot.Test = function(){
		newobject(Mandelbrot, "ctor", null).Exec();
	}
	Mandelbrot.cctor = function(){
	}
})()
